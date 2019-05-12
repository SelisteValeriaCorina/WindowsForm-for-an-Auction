using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace project
{
    public partial class Form1 : Form
    {
        List<Bidder> bidder;
        private object listViewItem;
        public Form1()
        {
            InitializeComponent();
            bidder = new List<Bidder>();//punem () deoarece se implementeaza constructorul implicit pt obiectul bidders;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            string lastname = tbName.Text.Trim();
            if (lastname.Length < 2)
            {
                e.Cancel = true;
                erpLastName.SetError(tbName, ">=2 letters");
            }
        }

        private void tbName_Validated(object sender, EventArgs e)
        {
            erpLastName.Clear();
        }

        private void tbPrename_Validating(object sender, CancelEventArgs e)
        {
            string prename = tbPrename.Text.Trim();
            if (prename.Length <= 2)
            {
                e.Cancel = true;
                erpFirstName.SetError(tbPrename, "=> letters");
            }
        }

        private void tbPrename_Validated(object sender, EventArgs e)
        {
            erpFirstName.Clear();
        }

        private void tbAmount_Validating(object sender, CancelEventArgs e)
        {
            var amount = tbAmount.Text;
            //Parsing to float
            float amountFloat = float.Parse(amount);

            //Comparison
            if (amountFloat < 50.0f)
            {
                e.Cancel = true;
                erpAmount.SetError(tbAmount, "The amount must always be over 50!");
            }

        }
        private void tbAmount_Validated(object sender, EventArgs e)
        {
            erpAmount.Clear();
        }

        void Displaybidders()
        {
            lvBidders.Items.Clear();
            foreach (var bidder in bidder)
            {
                var listViewItem = new ListViewItem(bidder.LastName);

                //listViewItem.SubItems.Add(bidder.LastName);
                listViewItem.SubItems.Add(bidder.FirstName);
                listViewItem.SubItems.Add(bidder.Amount.ToString());

                listViewItem.Tag = bidder;

                lvBidders.Items.Add(listViewItem);

            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            var lastname = tbName.Text.Trim();
            var firstname = tbPrename.Text.Trim();
            var value = tbAmount.Text.Trim();
            float valueFloat = float.Parse(value);

            bool valid = true;
            if (lastname.Length < 2)
            {
                valid = false;
                erpLastName.SetError(tbName, ">=2 letters");
            }
            if (firstname.Length < 2)
            {
                valid = false;
                erpFirstName.SetError(tbPrename, ">=2 letters");
            }
            if (valueFloat <= 50.0f)
            {
                valid = false;
                erpAmount.SetError(tbAmount, ">50  lei");
            }

            if (!valid)
            {
                MessageBox.Show("The form contains errors!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Bidder bidder;
                try
                {
                    bidder = new Bidder(lastname, firstname, valueFloat);
                    this.bidder.Add(bidder);
                    Displaybidders();
                    tbName.Text = tbPrename.Text = tbAmount.Text = string.Empty;

                }
                catch (ArgumentException ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }
        }

        private void btnAbandon_Click(object sender, EventArgs e)
        {
            if (lvBidders.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose an offer!");

            }
            else
            {
                if (MessageBox.Show("Are you sure?", "Abandon the offer?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var listViewitem = lvBidders.SelectedItems[0];
                    Bidder bidder = (Bidder)listViewitem.Tag;

                    this.bidder.Remove(bidder);
                    Displaybidders();
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (lvBidders.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose a participant");
            }
            else
            {
                var listViewItem = lvBidders.SelectedItems[0];
                Bidder bidder = (Bidder)listViewItem.Tag;

                EditForm editForm = new EditForm(bidder);
                if (editForm.ShowDialog() == DialogResult.OK)
                    Displaybidders();
            }

        }

        private void btnserializationbinary_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.Create("serialize.bin"))
            {
                formatter.Serialize(stream, bidder);
            }
        }

        private void deserializationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream=File.OpenRead("serialize.bin"))
            {
                bidder = (List<Bidder>)formatter.Deserialize(stream);
                Displaybidders();
            }
        }

        private void serializationXml_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Bidder>));
            using (FileStream stream=File.Create("serializer.xml"))
            {
                serializer.Serialize(stream, bidder);
            }
        }

        private void deserializationXml_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Bidder>));
            using (FileStream stream = File.OpenRead("serializer.xml"))
            {
                bidder = (List<Bidder>)serializer.Deserialize(stream);
                Displaybidders();
            }
        }

        private void exportText_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export CSV";
            saveFileDialog.Filter = "csv|*.csv";

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine("Lastname,Firstname,Value");
                    foreach(var bidd in bidder)
                    {
                        sw.WriteLine("{0},{1},{2}",
                        bidd.LastName,
                        bidd.FirstName,
                        bidd.Amount.ToString());
                    }
                }
            }
        }
    }
}

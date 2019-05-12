using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class EditForm : Form
    {
        Bidder bidder;

        public EditForm(Bidder bidder)
        {
            this.bidder = bidder;
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            tbLastName.Text = bidder.LastName;
            tbFirstName.Text = bidder.FirstName;
            tbAmount.Text = bidder.Amount.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bidder.LastName = tbLastName.Text;
            bidder.FirstName = tbFirstName.Text;
            bidder.Amount = float.Parse(tbAmount.Text);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}

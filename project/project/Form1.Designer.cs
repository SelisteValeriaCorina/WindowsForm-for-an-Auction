﻿namespace project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPrename = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lvBidders = new System.Windows.Forms.ListView();
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPrename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnAbandon = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.erpLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpAmount = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.binarymenustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnserializationbinary = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializationXml = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializationXml = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportText = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.erpLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpAmount)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbName.Location = new System.Drawing.Point(106, 60);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 22);
            this.tbName.TabIndex = 3;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            this.tbName.Validated += new System.EventHandler(this.tbName_Validated);
            // 
            // tbPrename
            // 
            this.tbPrename.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbPrename.Location = new System.Drawing.Point(106, 108);
            this.tbPrename.Name = "tbPrename";
            this.tbPrename.Size = new System.Drawing.Size(100, 22);
            this.tbPrename.TabIndex = 4;
            this.tbPrename.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrename_Validating);
            this.tbPrename.Validated += new System.EventHandler(this.tbPrename_Validated);
            // 
            // tbAmount
            // 
            this.tbAmount.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbAmount.Location = new System.Drawing.Point(106, 160);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(100, 22);
            this.tbAmount.TabIndex = 5;
            this.tbAmount.Validating += new System.ComponentModel.CancelEventHandler(this.tbAmount_Validating);
            this.tbAmount.Validated += new System.EventHandler(this.tbAmount_Validated);
            // 
            // lvBidders
            // 
            this.lvBidders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clName,
            this.clPrename,
            this.clAmount});
            this.lvBidders.Location = new System.Drawing.Point(90, 216);
            this.lvBidders.MultiSelect = false;
            this.lvBidders.Name = "lvBidders";
            this.lvBidders.Size = new System.Drawing.Size(432, 222);
            this.lvBidders.TabIndex = 6;
            this.lvBidders.UseCompatibleStateImageBehavior = false;
            this.lvBidders.View = System.Windows.Forms.View.Details;
            // 
            // clName
            // 
            this.clName.Text = "Last Name";
            this.clName.Width = 117;
            // 
            // clPrename
            // 
            this.clPrename.Text = "First Name";
            this.clPrename.Width = 125;
            // 
            // clAmount
            // 
            this.clAmount.Text = "Amount";
            this.clAmount.Width = 142;
            // 
            // btnJoin
            // 
            this.btnJoin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnJoin.Location = new System.Drawing.Point(298, 148);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(97, 46);
            this.btnJoin.TabIndex = 7;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = false;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnAbandon
            // 
            this.btnAbandon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAbandon.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnAbandon.Location = new System.Drawing.Point(433, 149);
            this.btnAbandon.Name = "btnAbandon";
            this.btnAbandon.Size = new System.Drawing.Size(116, 45);
            this.btnAbandon.TabIndex = 8;
            this.btnAbandon.Text = "Abandon the Offer";
            this.btnAbandon.UseVisualStyleBackColor = false;
            this.btnAbandon.Click += new System.EventHandler(this.btnAbandon_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnChange.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnChange.Location = new System.Drawing.Point(590, 148);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(91, 45);
            this.btnChange.TabIndex = 9;
            this.btnChange.Text = "Change ";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // erpLastName
            // 
            this.erpLastName.ContainerControl = this;
            // 
            // erpFirstName
            // 
            this.erpFirstName.ContainerControl = this;
            // 
            // erpAmount
            // 
            this.erpAmount.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binarymenustrip,
            this.xMLToolStripMenuItem,
            this.textToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // binarymenustrip
            // 
            this.binarymenustrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnserializationbinary,
            this.deserializationToolStripMenuItem});
            this.binarymenustrip.Name = "binarymenustrip";
            this.binarymenustrip.Size = new System.Drawing.Size(62, 24);
            this.binarymenustrip.Text = "Binary";
            // 
            // btnserializationbinary
            // 
            this.btnserializationbinary.Name = "btnserializationbinary";
            this.btnserializationbinary.Size = new System.Drawing.Size(183, 26);
            this.btnserializationbinary.Text = "Serialization";
            this.btnserializationbinary.Click += new System.EventHandler(this.btnserializationbinary_Click);
            // 
            // deserializationToolStripMenuItem
            // 
            this.deserializationToolStripMenuItem.Name = "deserializationToolStripMenuItem";
            this.deserializationToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.deserializationToolStripMenuItem.Text = "Deserialization";
            this.deserializationToolStripMenuItem.Click += new System.EventHandler(this.deserializationToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializationXml,
            this.deserializationXml});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // serializationXml
            // 
            this.serializationXml.Name = "serializationXml";
            this.serializationXml.Size = new System.Drawing.Size(183, 26);
            this.serializationXml.Text = "Serialization";
            this.serializationXml.Click += new System.EventHandler(this.serializationXml_Click);
            // 
            // deserializationXml
            // 
            this.deserializationXml.Name = "deserializationXml";
            this.deserializationXml.Size = new System.Drawing.Size(183, 26);
            this.deserializationXml.Text = "Deserialization";
            this.deserializationXml.Click += new System.EventHandler(this.deserializationXml_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportText});
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.textToolStripMenuItem.Text = "Text";
            // 
            // exportText
            // 
            this.exportText.Name = "exportText";
            this.exportText.Size = new System.Drawing.Size(216, 26);
            this.exportText.Text = "Export";
            this.exportText.Click += new System.EventHandler(this.exportText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAbandon);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.lvBidders);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.tbPrename);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.erpLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpAmount)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPrename;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.ListView lvBidders;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader clPrename;
        private System.Windows.Forms.ColumnHeader clAmount;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnAbandon;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ErrorProvider erpLastName;
        private System.Windows.Forms.ErrorProvider erpFirstName;
        private System.Windows.Forms.ErrorProvider erpAmount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem binarymenustrip;
        private System.Windows.Forms.ToolStripMenuItem btnserializationbinary;
        private System.Windows.Forms.ToolStripMenuItem deserializationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializationXml;
        private System.Windows.Forms.ToolStripMenuItem deserializationXml;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportText;
    }
}


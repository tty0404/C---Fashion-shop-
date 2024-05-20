using ICT711_Day5_classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ICT711_Day9_Forms
{
    public partial class AssociateForms : Form
    {
        public AssociateForms()
        {
            InitializeComponent();
        }

        private void Associate_Load(object sender, EventArgs e)
        {
            Associate associate = (Associate)Tag;
            associateBindingSource1.DataSource = associate;
            //fnameTextBox.Text = associate.FName;
            //lnameTextBox.Text = associate.LName;
            //associateIdTextBox.Text = associate.AssociateId.ToString();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            // Setting a value for DialogResult will automatically close the form
            this.DialogResult = DialogResult.OK;
            this.Tag = "Associate form was closed";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // Cancel is the default value
            this.DialogResult = DialogResult.Cancel;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Save")
                MessageBox.Show("Save");
            if (e.ClickedItem.Text == "Edit")
                MessageBox.Show("Edit");
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Clicked");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                tabInfoLbl.Text = "Edit associate personal information";
            else
                tabInfoLbl.Text = "Edit associate job information";
        }

    }
}

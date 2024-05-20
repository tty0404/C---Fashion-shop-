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
    public partial class myNewForm : Form
    {
        private Associate _associate;
        public Associate MyAssociate { get { return _associate; } 
            set {
                _associate = value;
                associateFNameTxt.Text = _associate.FName;
                associateIdLbl.Text = _associate.AssociateId.ToString();
            } 
        }
        public myNewForm()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            MyAssociate.FName= associateFNameTxt.Text;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void myNewForm_Load(object sender, EventArgs e)
        {
            // Convert the Tag to Associate type
            //Associate associate = ((Associate)this.Tag);
            //associateFNmaeLbl.Text = associate.FName;
            //associateIdLbl.Text = associate.AssociateId.ToString();
        }

        private void myNewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var r  =MessageBox.Show("Are you sure", "Confirm", MessageBoxButtons.YesNo);
            if(r== DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}

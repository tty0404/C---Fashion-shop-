using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ICT711_Day9_Forms
{
    public partial class inventoryCreateForm : Form
    {
        public inventoryCreateForm()
        {
            InitializeComponent();
        }

        private void helloBtn_Click(object sender, EventArgs e)
        {
            helloMsgLbl.Text = "Hello " + helloMsgTxt.Text;
        }
    }
}

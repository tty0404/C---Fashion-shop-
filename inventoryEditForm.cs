using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ICT711_Day9_Forms
{
    public partial class inventoryEditForm : Form
    {
        public inventoryEditForm()
        {
            InitializeComponent();
        }

        private void helloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helloLbl.Text = "Hello there!";
        }
    }
}

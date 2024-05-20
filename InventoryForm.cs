using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ICT711_Day9_Forms
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Debug.WriteLine(e.ClickedItem.Text);
            switch (e.ClickedItem.Text)
            {
                case "Create":
                    inventoryCreateForm cf = new inventoryCreateForm();
                    cf.MdiParent = this;
                    cf.Show();
                    break;
                case "Edit":
                    inventoryEditForm ef = new inventoryEditForm();
                    ef.MdiParent = this;
                    ef.Show();
                    break;
                case "Cascade":
                    this.LayoutMdi(MdiLayout.Cascade);
                    break;
                case "Horizontal":
                    this.LayoutMdi(MdiLayout.TileHorizontal);
                    break;
                case "Vertical":
                    this.LayoutMdi(MdiLayout.TileVertical);
                    break;
            }
        }

        private void CascadetoolStripMenu_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void VerticaltoolStripMenu_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void HorizontaltoolStripMenu_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}

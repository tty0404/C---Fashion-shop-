
namespace ICT711_Day9_Forms
{
    partial class inventoryEditForm
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            helloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helloLbl = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { helloToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(342, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // helloToolStripMenuItem
            // 
            helloToolStripMenuItem.Name = "helloToolStripMenuItem";
            helloToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            helloToolStripMenuItem.Text = "Hello";
            helloToolStripMenuItem.Click += helloToolStripMenuItem_Click;
            // 
            // helloLbl
            // 
            helloLbl.AutoSize = true;
            helloLbl.Location = new System.Drawing.Point(51, 75);
            helloLbl.Name = "helloLbl";
            helloLbl.Size = new System.Drawing.Size(10, 15);
            helloLbl.TabIndex = 1;
            helloLbl.Text = ".";
            // 
            // inventoryEditForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(342, 237);
            Controls.Add(helloLbl);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "inventoryEditForm";
            Text = "Inventory Edit";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helloToolStripMenuItem;
        private System.Windows.Forms.Label helloLbl;
    }
}
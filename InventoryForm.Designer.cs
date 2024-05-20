
namespace ICT711_Day9_Forms
{
    partial class InventoryForm
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
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            CascadetoolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            VerticaltoolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            HorizontaltoolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            toolStripMenuItem1.Text = "Create";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(39, 20);
            toolStripMenuItem2.Text = "Edit";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { CascadetoolStripMenu, VerticaltoolStripMenu, HorizontaltoolStripMenu });
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new System.Drawing.Size(44, 20);
            toolStripMenuItem3.Text = "View";
            // 
            // CascadetoolStripMenu
            // 
            CascadetoolStripMenu.Name = "CascadetoolStripMenu";
            CascadetoolStripMenu.Size = new System.Drawing.Size(180, 22);
            CascadetoolStripMenu.Text = "Cascade";
            CascadetoolStripMenu.Click += CascadetoolStripMenu_Click;
            // 
            // VerticaltoolStripMenu
            // 
            VerticaltoolStripMenu.Name = "VerticaltoolStripMenu";
            VerticaltoolStripMenu.Size = new System.Drawing.Size(180, 22);
            VerticaltoolStripMenu.Text = "Vertical";
            VerticaltoolStripMenu.Click += VerticaltoolStripMenu_Click;
            // 
            // HorizontaltoolStripMenu
            // 
            HorizontaltoolStripMenu.Name = "HorizontaltoolStripMenu";
            HorizontaltoolStripMenu.Size = new System.Drawing.Size(180, 22);
            HorizontaltoolStripMenu.Text = "Horizontal";
            HorizontaltoolStripMenu.Click += HorizontaltoolStripMenu_Click;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "InventoryForm";
            Opacity = 0.95D;
            Text = "Inventory Form";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem CascadetoolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem VerticaltoolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem HorizontaltoolStripMenu;
    }
}
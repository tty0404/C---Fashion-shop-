
namespace ICT711_Day9_Forms
{
    partial class AssociateForms
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
            components = new System.ComponentModel.Container();
            label1 = new System.Windows.Forms.Label();
            fnameLbl = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            associateIdTextBox = new System.Windows.Forms.TextBox();
            associateBindingSource1 = new System.Windows.Forms.BindingSource(components);
            fnameTextBox = new System.Windows.Forms.TextBox();
            lnameTextBox = new System.Windows.Forms.TextBox();
            okBtn = new System.Windows.Forms.Button();
            cancelBtn = new System.Windows.Forms.Button();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage2 = new System.Windows.Forms.TabPage();
            EmailTxt = new System.Windows.Forms.TextBox();
            departmentTxt = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            jobTxt = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            tabInfoLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)associateBindingSource1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 51);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(70, 15);
            label1.TabIndex = 2;
            label1.Text = "Associate Id";
            // 
            // fnameLbl
            // 
            fnameLbl.AutoSize = true;
            fnameLbl.Location = new System.Drawing.Point(9, 42);
            fnameLbl.Name = "fnameLbl";
            fnameLbl.Size = new System.Drawing.Size(64, 15);
            fnameLbl.TabIndex = 1;
            fnameLbl.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(10, 100);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // associateIdTextBox
            // 
            associateIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", associateBindingSource1, "AssociateId", true));
            associateIdTextBox.Location = new System.Drawing.Point(96, 49);
            associateIdTextBox.Name = "associateIdTextBox";
            associateIdTextBox.ReadOnly = true;
            associateIdTextBox.Size = new System.Drawing.Size(100, 23);
            associateIdTextBox.TabIndex = 0;
            // 
            // associateBindingSource1
            // 
            associateBindingSource1.DataSource = typeof(ICT711_Day5_classes.Associate);
            // 
            // fnameTextBox
            // 
            fnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", associateBindingSource1, "FName", true));
            fnameTextBox.Location = new System.Drawing.Point(119, 34);
            fnameTextBox.Name = "fnameTextBox";
            fnameTextBox.Size = new System.Drawing.Size(195, 23);
            fnameTextBox.TabIndex = 0;
            // 
            // lnameTextBox
            // 
            lnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", associateBindingSource1, "LName", true));
            lnameTextBox.Location = new System.Drawing.Point(119, 92);
            lnameTextBox.Name = "lnameTextBox";
            lnameTextBox.Size = new System.Drawing.Size(195, 23);
            lnameTextBox.TabIndex = 3;
            // 
            // okBtn
            // 
            okBtn.Location = new System.Drawing.Point(291, 49);
            okBtn.Name = "okBtn";
            okBtn.Size = new System.Drawing.Size(75, 23);
            okBtn.TabIndex = 2;
            okBtn.Text = "Ok";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new System.Drawing.Point(210, 48);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new System.Drawing.Size(75, 23);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            tabControl1.Location = new System.Drawing.Point(0, 126);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(619, 230);
            tabControl1.TabIndex = 1;
            tabControl1.TabStop = false;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(fnameTextBox);
            tabPage1.Controls.Add(fnameLbl);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(lnameTextBox);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(611, 202);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Personal";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(EmailTxt);
            tabPage2.Controls.Add(departmentTxt);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(jobTxt);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(611, 202);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Job";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // EmailTxt
            // 
            EmailTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", associateBindingSource1, "Email", true));
            EmailTxt.Location = new System.Drawing.Point(108, 169);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new System.Drawing.Size(232, 23);
            EmailTxt.TabIndex = 3;
            // 
            // departmentTxt
            // 
            departmentTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", associateBindingSource1, "Department", true));
            departmentTxt.Location = new System.Drawing.Point(108, 122);
            departmentTxt.Name = "departmentTxt";
            departmentTxt.Size = new System.Drawing.Size(232, 23);
            departmentTxt.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(23, 172);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(36, 15);
            label5.TabIndex = 2;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(23, 124);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(70, 15);
            label4.TabIndex = 2;
            label4.Text = "Department";
            // 
            // jobTxt
            // 
            jobTxt.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            jobTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", associateBindingSource1, "JobDescription", true));
            jobTxt.Location = new System.Drawing.Point(108, 34);
            jobTxt.Multiline = true;
            jobTxt.Name = "jobTxt";
            jobTxt.PlaceholderText = "Sales";
            jobTxt.Size = new System.Drawing.Size(473, 50);
            jobTxt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(23, 34);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 15);
            label2.TabIndex = 0;
            label2.Text = "Job title";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { openMenuItem, toolStripMenuItem2, toolStripMenuItem3 });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(619, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "fileMenu";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked_1;
            // 
            // openMenuItem
            // 
            openMenuItem.Name = "openMenuItem";
            openMenuItem.ShortcutKeyDisplayString = "Alt+O";
            openMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            openMenuItem.Size = new System.Drawing.Size(48, 20);
            openMenuItem.Text = "&Open";
            openMenuItem.Click += openMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E;
            toolStripMenuItem2.Size = new System.Drawing.Size(39, 20);
            toolStripMenuItem2.Text = "Edit";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new System.Drawing.Size(43, 20);
            toolStripMenuItem3.Text = "Save";
            // 
            // tabInfoLbl
            // 
            tabInfoLbl.AutoSize = true;
            tabInfoLbl.Location = new System.Drawing.Point(13, 87);
            tabInfoLbl.Name = "tabInfoLbl";
            tabInfoLbl.Size = new System.Drawing.Size(192, 15);
            tabInfoLbl.TabIndex = 5;
            tabInfoLbl.Text = "Edit associate personal information";
            // 
            // AssociateForms
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(619, 356);
            Controls.Add(tabInfoLbl);
            Controls.Add(tabControl1);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(associateIdTextBox);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "AssociateForms";
            Text = "Associate info";
            Load += Associate_Load;
            ((System.ComponentModel.ISupportInitialize)associateBindingSource1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fnameLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox associateIdTextBox;
        private System.Windows.Forms.TextBox fnameTextBox;
        private System.Windows.Forms.TextBox lnameTextBox;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox jobTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Label tabInfoLbl;
        private System.Windows.Forms.BindingSource associateBindingSource1;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.TextBox departmentTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
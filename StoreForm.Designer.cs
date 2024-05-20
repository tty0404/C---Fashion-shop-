namespace ICT711_Day9_Forms
{
    partial class StoreForm
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
            customersBtn = new System.Windows.Forms.Button();
            storeNameTxt = new System.Windows.Forms.TextBox();
            storeBindingSource = new System.Windows.Forms.BindingSource(components);
            storeAddressTxt = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            saveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)storeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // customersBtn
            // 
            customersBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            customersBtn.BackColor = System.Drawing.Color.SandyBrown;
            customersBtn.Location = new System.Drawing.Point(77, 205);
            customersBtn.Name = "customersBtn";
            customersBtn.Size = new System.Drawing.Size(197, 44);
            customersBtn.TabIndex = 3;
            customersBtn.Text = "&Customers Info.";
            customersBtn.UseVisualStyleBackColor = false;
            customersBtn.Click += customersBtn_Click;
            // 
            // storeNameTxt
            // 
            storeNameTxt.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            storeNameTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", storeBindingSource, "StoreName", true));
            storeNameTxt.Location = new System.Drawing.Point(188, 28);
            storeNameTxt.Name = "storeNameTxt";
            storeNameTxt.Size = new System.Drawing.Size(358, 23);
            storeNameTxt.TabIndex = 0;
            // 
            // storeBindingSource
            // 
            storeBindingSource.DataSource = typeof(ICT711_Day5_classes.Store);
            // 
            // storeAddressTxt
            // 
            storeAddressTxt.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            storeAddressTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", storeBindingSource, "Address", true));
            storeAddressTxt.Location = new System.Drawing.Point(188, 77);
            storeAddressTxt.Name = "storeAddressTxt";
            storeAddressTxt.Size = new System.Drawing.Size(358, 23);
            storeAddressTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(48, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 15);
            label1.TabIndex = 3;
            label1.Text = "Store Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(48, 80);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Address";
            // 
            // saveBtn
            // 
            saveBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            saveBtn.BackColor = System.Drawing.Color.SandyBrown;
            saveBtn.Location = new System.Drawing.Point(334, 205);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new System.Drawing.Size(197, 44);
            saveBtn.TabIndex = 2;
            saveBtn.Text = "&Save Data";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // StoreForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.PeachPuff;
            ClientSize = new System.Drawing.Size(584, 261);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(storeAddressTxt);
            Controls.Add(storeNameTxt);
            Controls.Add(saveBtn);
            Controls.Add(customersBtn);
            MinimumSize = new System.Drawing.Size(500, 200);
            Name = "StoreForm";
            Text = "Store Form";
            FormClosing += StoreForm_FormClosing;
            Load += StoreForm_Load;
            ((System.ComponentModel.ISupportInitialize)storeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button customersBtn;
        private System.Windows.Forms.TextBox storeNameTxt;
        private System.Windows.Forms.BindingSource storeBindingSource;
        private System.Windows.Forms.TextBox storeAddressTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveBtn;
    }
}
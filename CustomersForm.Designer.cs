namespace ICT711_Day9_Forms
{
    partial class CustomersForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new System.Windows.Forms.DataGridView();
            CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            RegisteredOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            detailsBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            inventoryBtn = new System.Windows.Forms.Button();
            testBtn = new System.Windows.Forms.Button();
            associateNameLbl = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { CustomerId, FName, LName, Tel, Email, RegisteredOn });
            dataGridView1.Location = new System.Drawing.Point(12, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new System.Drawing.Size(776, 255);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // CustomerId
            // 
            CustomerId.DataPropertyName = "CustomerId";
            CustomerId.HeaderText = "ID";
            CustomerId.Name = "CustomerId";
            // 
            // FName
            // 
            FName.DataPropertyName = "Fname";
            FName.HeaderText = "First Name";
            FName.Name = "FName";
            // 
            // LName
            // 
            LName.DataPropertyName = "LName";
            LName.HeaderText = "Last Name";
            LName.Name = "LName";
            // 
            // Tel
            // 
            Tel.DataPropertyName = "Tel";
            Tel.HeaderText = "Tel";
            Tel.Name = "Tel";
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // RegisteredOn
            // 
            RegisteredOn.DataPropertyName = "RegisteredOn";
            RegisteredOn.HeaderText = "Registered On";
            RegisteredOn.Name = "RegisteredOn";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 423);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 20);
            label1.TabIndex = 3;
            label1.Text = "Associate";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { detailsBtn });
            dataGridView2.ImeMode = System.Windows.Forms.ImeMode.Off;
            dataGridView2.Location = new System.Drawing.Point(168, 303);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 27;
            dataGridView2.Size = new System.Drawing.Size(407, 109);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // detailsBtn
            // 
            detailsBtn.HeaderText = "";
            detailsBtn.Name = "detailsBtn";
            detailsBtn.ReadOnly = true;
            detailsBtn.Text = "Details";
            detailsBtn.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(12, 11);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(84, 20);
            label2.TabIndex = 7;
            label2.Text = "Customers";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(12, 299);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 20);
            label3.TabIndex = 7;
            label3.Text = "Purchases";
            // 
            // inventoryBtn
            // 
            inventoryBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            inventoryBtn.Location = new System.Drawing.Point(594, 420);
            inventoryBtn.Name = "inventoryBtn";
            inventoryBtn.Size = new System.Drawing.Size(75, 23);
            inventoryBtn.TabIndex = 4;
            inventoryBtn.Text = "Inventory";
            inventoryBtn.UseVisualStyleBackColor = true;
            inventoryBtn.Click += inventoryBtn_Click;
            // 
            // testBtn
            // 
            testBtn.Location = new System.Drawing.Point(662, 334);
            testBtn.Name = "testBtn";
            testBtn.Size = new System.Drawing.Size(75, 20);
            testBtn.TabIndex = 6;
            testBtn.Text = "Test";
            testBtn.UseVisualStyleBackColor = true;
            testBtn.Click += testBtn_Click;
            // 
            // associateNameLbl
            // 
            associateNameLbl.AutoSize = true;
            associateNameLbl.Location = new System.Drawing.Point(115, 424);
            associateNameLbl.Name = "associateNameLbl";
            associateNameLbl.Size = new System.Drawing.Size(16, 15);
            associateNameLbl.TabIndex = 2;
            associateNameLbl.TabStop = true;
            associateNameLbl.Text = "...";
            associateNameLbl.LinkClicked += associateNameLbl_LinkClicked;
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 451);
            Controls.Add(associateNameLbl);
            Controls.Add(testBtn);
            Controls.Add(inventoryBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "CustomersForm";
            Text = "eStore";
            Load += eStore_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisteredOn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewButtonColumn detailsBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button inventoryBtn;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.LinkLabel associateNameLbl;
    }
}


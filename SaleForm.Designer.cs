
namespace ICT711_Day9_Forms
{
    partial class SaleForm
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            idLbl = new System.Windows.Forms.Label();
            AssociateLbl = new System.Windows.Forms.Label();
            customerLbl = new System.Windows.Forms.Label();
            dateLbl = new System.Windows.Forms.Label();
            statusLbl = new System.Windows.Forms.Label();
            totalLbl = new System.Windows.Forms.Label();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            associateCombobox = new System.Windows.Forms.ComboBox();
            comboBox2 = new System.Windows.Forms.ComboBox();
            comboBox3 = new System.Windows.Forms.ComboBox();
            saveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(12, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new System.Drawing.Size(776, 229);
            dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(23, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Associate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(23, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(17, 15);
            label2.TabIndex = 2;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(23, 73);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 15);
            label3.TabIndex = 3;
            label3.Text = "Customer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(23, 105);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(438, 9);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(63, 15);
            label5.TabIndex = 3;
            label5.Text = "Sale Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(438, 40);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(32, 15);
            label6.TabIndex = 3;
            label6.Text = "Total";
            // 
            // idLbl
            // 
            idLbl.AutoSize = true;
            idLbl.Location = new System.Drawing.Point(127, 9);
            idLbl.Name = "idLbl";
            idLbl.Size = new System.Drawing.Size(16, 15);
            idLbl.TabIndex = 2;
            idLbl.Text = "...";
            // 
            // AssociateLbl
            // 
            AssociateLbl.AutoSize = true;
            AssociateLbl.Location = new System.Drawing.Point(127, 40);
            AssociateLbl.Name = "AssociateLbl";
            AssociateLbl.Size = new System.Drawing.Size(16, 15);
            AssociateLbl.TabIndex = 2;
            AssociateLbl.Text = "...";
            // 
            // customerLbl
            // 
            customerLbl.AutoSize = true;
            customerLbl.Location = new System.Drawing.Point(127, 73);
            customerLbl.Name = "customerLbl";
            customerLbl.Size = new System.Drawing.Size(16, 15);
            customerLbl.TabIndex = 2;
            customerLbl.Text = "...";
            // 
            // dateLbl
            // 
            dateLbl.AutoSize = true;
            dateLbl.Location = new System.Drawing.Point(127, 105);
            dateLbl.Name = "dateLbl";
            dateLbl.Size = new System.Drawing.Size(16, 15);
            dateLbl.TabIndex = 2;
            dateLbl.Text = "...";
            // 
            // statusLbl
            // 
            statusLbl.AutoSize = true;
            statusLbl.Location = new System.Drawing.Point(550, 9);
            statusLbl.Name = "statusLbl";
            statusLbl.Size = new System.Drawing.Size(16, 15);
            statusLbl.TabIndex = 2;
            statusLbl.Text = "...";
            // 
            // totalLbl
            // 
            totalLbl.AutoSize = true;
            totalLbl.Location = new System.Drawing.Point(550, 40);
            totalLbl.Name = "totalLbl";
            totalLbl.Size = new System.Drawing.Size(16, 15);
            totalLbl.TabIndex = 2;
            totalLbl.Text = "...";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(252, 105);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // associateCombobox
            // 
            associateCombobox.FormattingEnabled = true;
            associateCombobox.Location = new System.Drawing.Point(252, 33);
            associateCombobox.Name = "associateCombobox";
            associateCombobox.Size = new System.Drawing.Size(121, 23);
            associateCombobox.TabIndex = 0;
            associateCombobox.SelectedIndexChanged += associateCombobox_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(252, 66);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(121, 23);
            comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new System.Drawing.Point(624, 6);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new System.Drawing.Size(121, 23);
            comboBox3.TabIndex = 3;
            // 
            // saveBtn
            // 
            saveBtn.Location = new System.Drawing.Point(658, 107);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new System.Drawing.Size(75, 23);
            saveBtn.TabIndex = 4;
            saveBtn.Text = "&Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Highlight;
            ClientSize = new System.Drawing.Size(800, 397);
            Controls.Add(saveBtn);
            Controls.Add(comboBox2);
            Controls.Add(comboBox3);
            Controls.Add(associateCombobox);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(totalLbl);
            Controls.Add(statusLbl);
            Controls.Add(dateLbl);
            Controls.Add(customerLbl);
            Controls.Add(AssociateLbl);
            Controls.Add(idLbl);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "SaleForm";
            Text = "Sale";
            Load += Sale_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label AssociateLbl;
        private System.Windows.Forms.Label customerLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox associateCombobox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button saveBtn;
    }
}
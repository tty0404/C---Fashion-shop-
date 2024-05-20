
namespace ICT711_Day9_Forms
{
    partial class inventoryCreateForm
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
            this.helloBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.helloMsgTxt = new System.Windows.Forms.TextBox();
            this.helloMsgLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // helloBtn
            // 
            this.helloBtn.Location = new System.Drawing.Point(206, 91);
            this.helloBtn.Name = "helloBtn";
            this.helloBtn.Size = new System.Drawing.Size(75, 33);
            this.helloBtn.TabIndex = 0;
            this.helloBtn.Text = "&Hello";
            this.helloBtn.UseVisualStyleBackColor = true;
            this.helloBtn.Click += new System.EventHandler(this.helloBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your name";
            // 
            // helloMsgTxt
            // 
            this.helloMsgTxt.Location = new System.Drawing.Point(87, 27);
            this.helloMsgTxt.Name = "helloMsgTxt";
            this.helloMsgTxt.PlaceholderText = "Jim";
            this.helloMsgTxt.Size = new System.Drawing.Size(194, 25);
            this.helloMsgTxt.TabIndex = 2;
            // 
            // helloMsgLbl
            // 
            this.helloMsgLbl.AutoSize = true;
            this.helloMsgLbl.Location = new System.Drawing.Point(12, 91);
            this.helloMsgLbl.Name = "helloMsgLbl";
            this.helloMsgLbl.Size = new System.Drawing.Size(11, 17);
            this.helloMsgLbl.TabIndex = 3;
            this.helloMsgLbl.Text = ".";
            // 
            // inventoryCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 136);
            this.Controls.Add(this.helloMsgLbl);
            this.Controls.Add(this.helloMsgTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.helloBtn);
            this.Name = "inventoryCreateForm";
            this.Text = "Inventory Create";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button helloBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox helloMsgTxt;
        private System.Windows.Forms.Label helloMsgLbl;
    }
}
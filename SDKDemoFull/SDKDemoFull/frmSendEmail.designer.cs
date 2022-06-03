namespace SDKDemo
{
    partial class frmSendEmail
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtTransactionID = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtReceiverName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtReceiverEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã tra cứu";
            // 
            // txtTransactionID
            // 
            this.txtTransactionID.Location = new System.Drawing.Point(106, 12);
            this.txtTransactionID.Name = "txtTransactionID";
            this.txtTransactionID.Size = new System.Drawing.Size(238, 20);
            this.txtTransactionID.TabIndex = 5;
            this.txtTransactionID.Text = "_ESKURJ919";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(269, 101);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtReceiverName
            // 
            this.txtReceiverName.Location = new System.Drawing.Point(106, 38);
            this.txtReceiverName.Name = "txtReceiverName";
            this.txtReceiverName.Size = new System.Drawing.Size(238, 20);
            this.txtReceiverName.TabIndex = 24;
            this.txtReceiverName.Text = "sealovesandy";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Tên người nhận";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Email người nhận";
            // 
            // txtReceiverEmail
            // 
            this.txtReceiverEmail.Location = new System.Drawing.Point(106, 64);
            this.txtReceiverEmail.Name = "txtReceiverEmail";
            this.txtReceiverEmail.Size = new System.Drawing.Size(238, 20);
            this.txtReceiverEmail.TabIndex = 21;
            this.txtReceiverEmail.Text = "meinvoiceemail@gmail.com";
            // 
            // frmSendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 135);
            this.Controls.Add(this.txtReceiverName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtReceiverEmail);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTransactionID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSendEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSendEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTransactionID;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtReceiverName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtReceiverEmail;
    }
}
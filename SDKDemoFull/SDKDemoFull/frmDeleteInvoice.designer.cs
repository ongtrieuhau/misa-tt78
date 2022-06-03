namespace SDKDemo
{
    partial class frmDeleteInvoice
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
            this.txtTransactionID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDeleteReason = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dteRefDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtTransactionID
            // 
            this.txtTransactionID.Location = new System.Drawing.Point(90, 26);
            this.txtTransactionID.Name = "txtTransactionID";
            this.txtTransactionID.Size = new System.Drawing.Size(114, 20);
            this.txtTransactionID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã tra cứu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lý do xóa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày xóa";
            // 
            // txtDeleteReason
            // 
            this.txtDeleteReason.Location = new System.Drawing.Point(90, 84);
            this.txtDeleteReason.Name = "txtDeleteReason";
            this.txtDeleteReason.Size = new System.Drawing.Size(114, 20);
            this.txtDeleteReason.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dteRefDate
            // 
            this.dteRefDate.CustomFormat = "dd/MM/yyyy";
            this.dteRefDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dteRefDate.Location = new System.Drawing.Point(90, 53);
            this.dteRefDate.Name = "dteRefDate";
            this.dteRefDate.Size = new System.Drawing.Size(114, 20);
            this.dteRefDate.TabIndex = 10;
            // 
            // frmDeleteInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 150);
            this.Controls.Add(this.dteRefDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDeleteReason);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTransactionID);
            this.Name = "frmDeleteInvoice";
            this.Text = "Xóa hóa đơn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTransactionID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDeleteReason;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dteRefDate;
    }
}
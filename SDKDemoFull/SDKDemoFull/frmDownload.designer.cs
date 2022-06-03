namespace SDKDemo
{
    partial class frmDownload
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
            this.downloadButton = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtTransactionID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.optXml = new System.Windows.Forms.RadioButton();
            this.optPdf = new System.Windows.Forms.RadioButton();
            this.optZip = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(336, 104);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(75, 23);
            this.downloadButton.TabIndex = 6;
            this.downloadButton.Text = "Tải";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(424, 104);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtTransactionID
            // 
            this.txtTransactionID.Location = new System.Drawing.Point(176, 30);
            this.txtTransactionID.Name = "txtTransactionID";
            this.txtTransactionID.Size = new System.Drawing.Size(320, 20);
            this.txtTransactionID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã tra cứu hóa đơn";
            // 
            // optXml
            // 
            this.optXml.AutoSize = true;
            this.optXml.Checked = true;
            this.optXml.Location = new System.Drawing.Point(176, 62);
            this.optXml.Name = "optXml";
            this.optXml.Size = new System.Drawing.Size(42, 17);
            this.optXml.TabIndex = 3;
            this.optXml.TabStop = true;
            this.optXml.Text = "Xml";
            this.optXml.UseVisualStyleBackColor = true;
            // 
            // optPdf
            // 
            this.optPdf.AutoSize = true;
            this.optPdf.Location = new System.Drawing.Point(232, 62);
            this.optPdf.Name = "optPdf";
            this.optPdf.Size = new System.Drawing.Size(41, 17);
            this.optPdf.TabIndex = 4;
            this.optPdf.Text = "Pdf";
            this.optPdf.UseVisualStyleBackColor = true;
            // 
            // optZip
            // 
            this.optZip.AutoSize = true;
            this.optZip.Location = new System.Drawing.Point(288, 62);
            this.optZip.Name = "optZip";
            this.optZip.Size = new System.Drawing.Size(94, 17);
            this.optZip.TabIndex = 5;
            this.optZip.Text = "Zip (Xml && Pdf)";
            this.optZip.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại dữ liệu sẽ tải về";
            // 
            // frmDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 143);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.optZip);
            this.Controls.Add(this.optPdf);
            this.Controls.Add(this.optXml);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTransactionID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.downloadButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDownload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tải hóa đơn điện tử";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtTransactionID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton optXml;
        private System.Windows.Forms.RadioButton optPdf;
        private System.Windows.Forms.RadioButton optZip;
        private System.Windows.Forms.Label label2;
    }
}
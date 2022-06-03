namespace SDKDemo
{
    partial class frmConvert
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
            this.label1 = new System.Windows.Forms.Label();
            this.transactionText = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.converterText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã tra cứu hóa đơn";
            // 
            // transactionText
            // 
            this.transactionText.Location = new System.Drawing.Point(176, 24);
            this.transactionText.Name = "transactionText";
            this.transactionText.Size = new System.Drawing.Size(320, 20);
            this.transactionText.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(424, 96);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Hủy bỏ";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(336, 96);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Chuyển đổi";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên người thực hiện chuyển đổi";
            // 
            // converterText
            // 
            this.converterText.Location = new System.Drawing.Point(176, 54);
            this.converterText.Name = "converterText";
            this.converterText.Size = new System.Drawing.Size(320, 20);
            this.converterText.TabIndex = 3;
            // 
            // frmConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 144);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.converterText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transactionText);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.convertButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConvert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConvert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox transactionText;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox converterText;
    }
}
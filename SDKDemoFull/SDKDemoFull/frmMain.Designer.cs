
namespace SDKDemo
{
    partial class frmMain
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
            this.btnSend = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.publishButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.btnViewInvoicePublish = new System.Windows.Forms.Button();
            this.btnGetTaxSTT = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(124, 367);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(352, 40);
            this.btnSend.TabIndex = 19;
            this.btnSend.Text = "Gửi hóa đơn";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(124, 526);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(352, 40);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Xóa hóa đơn";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadButton.Location = new System.Drawing.Point(124, 256);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(352, 40);
            this.downloadButton.TabIndex = 17;
            this.downloadButton.Text = "Tải hóa đơn điện tử";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(124, 310);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(352, 40);
            this.btnConvert.TabIndex = 16;
            this.btnConvert.Text = "Chuyển thành chứng từ giấy";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Bước 2: Thực hiện các thao tác";
            // 
            // publishButton
            // 
            this.publishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishButton.Location = new System.Drawing.Point(124, 202);
            this.publishButton.Name = "publishButton";
            this.publishButton.Size = new System.Drawing.Size(352, 40);
            this.publishButton.TabIndex = 15;
            this.publishButton.Text = "Phát hành hóa đơn điện tử";
            this.publishButton.UseVisualStyleBackColor = true;
            this.publishButton.Click += new System.EventHandler(this.publishButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bước 1:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 48);
            this.label1.TabIndex = 11;
            this.label1.Text = "Các bước thực hiện";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(124, 112);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(352, 40);
            this.loginButton.TabIndex = 13;
            this.loginButton.Text = "Kết nối meInvoice.vn";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // btnViewInvoicePublish
            // 
            this.btnViewInvoicePublish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInvoicePublish.Location = new System.Drawing.Point(124, 422);
            this.btnViewInvoicePublish.Name = "btnViewInvoicePublish";
            this.btnViewInvoicePublish.Size = new System.Drawing.Size(352, 40);
            this.btnViewInvoicePublish.TabIndex = 19;
            this.btnViewInvoicePublish.Text = "Xem hóa đơn đã phát hành";
            this.btnViewInvoicePublish.UseVisualStyleBackColor = true;
            this.btnViewInvoicePublish.Click += new System.EventHandler(this.btnViewInvoicePublish_Click);
            // 
            // btnGetTaxSTT
            // 
            this.btnGetTaxSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetTaxSTT.Location = new System.Drawing.Point(124, 475);
            this.btnGetTaxSTT.Name = "btnGetTaxSTT";
            this.btnGetTaxSTT.Size = new System.Drawing.Size(352, 40);
            this.btnGetTaxSTT.TabIndex = 19;
            this.btnGetTaxSTT.Text = "Lấy trạng thái từ cơ quan thuế trả về";
            this.btnGetTaxSTT.UseVisualStyleBackColor = true;
            this.btnGetTaxSTT.Click += new System.EventHandler(this.btnGetTaxSTT_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(326, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(120, 28);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.Text = "DN có mã";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(124, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(155, 28);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "DN không mã";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 621);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnGetTaxSTT);
            this.Controls.Add(this.btnViewInvoicePublish);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.publishButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginButton);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo chức năng HĐĐT TT78/ND123";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button publishButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button btnViewInvoicePublish;
        private System.Windows.Forms.Button btnGetTaxSTT;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}


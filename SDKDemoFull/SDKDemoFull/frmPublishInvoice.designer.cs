namespace SDKDemo
{
    partial class frmPublishInvoice
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
            this.components = new System.ComponentModel.Container();
            this.btnPublish = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.gvDetail = new System.Windows.Forms.DataGridView();
            this.lineNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDetail = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSellerAddress = new System.Windows.Forms.TextBox();
            this.txtSellerName = new System.Windows.Forms.TextBox();
            this.txtSellerTaxCode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkSendEmail = new System.Windows.Forms.CheckBox();
            this.txtReceiverName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtReceiverEmail = new System.Windows.Forms.TextBox();
            this.txtBuyerAddress = new System.Windows.Forms.TextBox();
            this.txtBuyerName = new System.Windows.Forms.TextBox();
            this.txtBuyerTaxCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboKyHieu = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pnlSignFile = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtPINFile = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlSignServer = new System.Windows.Forms.Panel();
            this.lblSign_Name = new System.Windows.Forms.Label();
            this.txtSign_Name = new System.Windows.Forms.TextBox();
            this.txtSign_Pin = new System.Windows.Forms.TextBox();
            this.lblSign_Pin = new System.Windows.Forms.Label();
            this.rbSignFile = new System.Windows.Forms.RadioButton();
            this.rbSignHSM = new System.Windows.Forms.RadioButton();
            this.rbSignServer = new System.Windows.Forms.RadioButton();
            this.rbSignDirect = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dteOrgDate = new System.Windows.Forms.DateTimePicker();
            this.lblOrgDate = new System.Windows.Forms.Label();
            this.lblNumberOrg = new System.Windows.Forms.Label();
            this.txtNumberOrg = new System.Windows.Forms.TextBox();
            this.rbAdjust = new System.Windows.Forms.RadioButton();
            this.rbReplace = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.pnlSignFile.SuspendLayout();
            this.pnlSignServer.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPublish
            // 
            this.btnPublish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPublish.Location = new System.Drawing.Point(609, 571);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(123, 23);
            this.btnPublish.TabIndex = 5;
            this.btnPublish.Text = "Phát hành HĐĐT";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(737, 571);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnView.Location = new System.Drawing.Point(16, 571);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(87, 23);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "Xem trước";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // gvDetail
            // 
            this.gvDetail.AutoGenerateColumns = false;
            this.gvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lineNumberDataGridViewTextBoxColumn,
            this.itemCodeDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.unitNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn});
            this.gvDetail.DataSource = this.bsDetail;
            this.gvDetail.Location = new System.Drawing.Point(16, 317);
            this.gvDetail.Name = "gvDetail";
            this.gvDetail.Size = new System.Drawing.Size(796, 248);
            this.gvDetail.TabIndex = 4;
            // 
            // lineNumberDataGridViewTextBoxColumn
            // 
            this.lineNumberDataGridViewTextBoxColumn.DataPropertyName = "LineNumber";
            this.lineNumberDataGridViewTextBoxColumn.HeaderText = "LineNumber";
            this.lineNumberDataGridViewTextBoxColumn.Name = "lineNumberDataGridViewTextBoxColumn";
            // 
            // itemCodeDataGridViewTextBoxColumn
            // 
            this.itemCodeDataGridViewTextBoxColumn.DataPropertyName = "ItemCode";
            this.itemCodeDataGridViewTextBoxColumn.HeaderText = "ItemCode";
            this.itemCodeDataGridViewTextBoxColumn.Name = "itemCodeDataGridViewTextBoxColumn";
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // unitNameDataGridViewTextBoxColumn
            // 
            this.unitNameDataGridViewTextBoxColumn.DataPropertyName = "UnitName";
            this.unitNameDataGridViewTextBoxColumn.HeaderText = "UnitName";
            this.unitNameDataGridViewTextBoxColumn.Name = "unitNameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // bsDetail
            // 
            this.bsDetail.DataSource = typeof(API3.SDK.Model.Parameter.OriginalInvoiceDetail);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ký hiệu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã số thuế";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tên người bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Địa chỉ người bán";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSellerAddress);
            this.groupBox1.Controls.Add(this.txtSellerName);
            this.groupBox1.Controls.Add(this.txtSellerTaxCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(16, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin người bán";
            // 
            // txtSellerAddress
            // 
            this.txtSellerAddress.Location = new System.Drawing.Point(112, 68);
            this.txtSellerAddress.Name = "txtSellerAddress";
            this.txtSellerAddress.Size = new System.Drawing.Size(405, 20);
            this.txtSellerAddress.TabIndex = 12;
            this.txtSellerAddress.Text = "Tầng X, Tòa nhà Y, Số zzz Cầu Giấy - Hà Nội";
            // 
            // txtSellerName
            // 
            this.txtSellerName.Location = new System.Drawing.Point(112, 44);
            this.txtSellerName.Name = "txtSellerName";
            this.txtSellerName.Size = new System.Drawing.Size(405, 20);
            this.txtSellerName.TabIndex = 11;
            this.txtSellerName.Text = "Công ty cổ phần MISA (Test - 103)";
            // 
            // txtSellerTaxCode
            // 
            this.txtSellerTaxCode.Location = new System.Drawing.Point(112, 20);
            this.txtSellerTaxCode.Name = "txtSellerTaxCode";
            this.txtSellerTaxCode.Size = new System.Drawing.Size(160, 20);
            this.txtSellerTaxCode.TabIndex = 10;
            this.txtSellerTaxCode.Text = "0101243150-999";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkSendEmail);
            this.groupBox2.Controls.Add(this.txtReceiverName);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtReceiverEmail);
            this.groupBox2.Controls.Add(this.txtBuyerAddress);
            this.groupBox2.Controls.Add(this.txtBuyerName);
            this.groupBox2.Controls.Add(this.txtBuyerTaxCode);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(16, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 175);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin người mua";
            // 
            // chkSendEmail
            // 
            this.chkSendEmail.AutoSize = true;
            this.chkSendEmail.Checked = true;
            this.chkSendEmail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSendEmail.Location = new System.Drawing.Point(114, 99);
            this.chkSendEmail.Name = "chkSendEmail";
            this.chkSendEmail.Size = new System.Drawing.Size(115, 17);
            this.chkSendEmail.TabIndex = 21;
            this.chkSendEmail.Text = "Phát hành kèm gửi";
            this.chkSendEmail.UseVisualStyleBackColor = true;
            // 
            // txtReceiverName
            // 
            this.txtReceiverName.Location = new System.Drawing.Point(112, 122);
            this.txtReceiverName.Name = "txtReceiverName";
            this.txtReceiverName.Size = new System.Drawing.Size(405, 20);
            this.txtReceiverName.TabIndex = 20;
            this.txtReceiverName.Text = "MeInvoice Nhận hóa đơn";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Tên người nhận";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Email người nhận";
            // 
            // txtReceiverEmail
            // 
            this.txtReceiverEmail.Location = new System.Drawing.Point(112, 147);
            this.txtReceiverEmail.Name = "txtReceiverEmail";
            this.txtReceiverEmail.Size = new System.Drawing.Size(405, 20);
            this.txtReceiverEmail.TabIndex = 16;
            this.txtReceiverEmail.Text = "meinvoiceemail@gmail.com";
            // 
            // txtBuyerAddress
            // 
            this.txtBuyerAddress.Location = new System.Drawing.Point(112, 72);
            this.txtBuyerAddress.Name = "txtBuyerAddress";
            this.txtBuyerAddress.Size = new System.Drawing.Size(405, 20);
            this.txtBuyerAddress.TabIndex = 15;
            this.txtBuyerAddress.Text = "Hà Nội";
            // 
            // txtBuyerName
            // 
            this.txtBuyerName.Location = new System.Drawing.Point(112, 48);
            this.txtBuyerName.Name = "txtBuyerName";
            this.txtBuyerName.Size = new System.Drawing.Size(405, 20);
            this.txtBuyerName.TabIndex = 14;
            this.txtBuyerName.Text = "Công ty cổ phần MISA (Test - 666)";
            // 
            // txtBuyerTaxCode
            // 
            this.txtBuyerTaxCode.Location = new System.Drawing.Point(112, 24);
            this.txtBuyerTaxCode.Name = "txtBuyerTaxCode";
            this.txtBuyerTaxCode.Size = new System.Drawing.Size(160, 20);
            this.txtBuyerTaxCode.TabIndex = 13;
            this.txtBuyerTaxCode.Text = "0101243150-666";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mã số thuế";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Địa chỉ người mua";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tên người mua";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboKyHieu);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(556, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 54);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hóa đơn";
            // 
            // cboKyHieu
            // 
            this.cboKyHieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboKyHieu.FormattingEnabled = true;
            this.cboKyHieu.Location = new System.Drawing.Point(56, 19);
            this.cboKyHieu.Name = "cboKyHieu";
            this.cboKyHieu.Size = new System.Drawing.Size(181, 21);
            this.cboKyHieu.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pnlSignFile);
            this.groupBox4.Controls.Add(this.pnlSignServer);
            this.groupBox4.Controls.Add(this.rbSignFile);
            this.groupBox4.Controls.Add(this.rbSignHSM);
            this.groupBox4.Controls.Add(this.rbSignServer);
            this.groupBox4.Controls.Add(this.rbSignDirect);
            this.groupBox4.Location = new System.Drawing.Point(556, 85);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 124);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thiết lập ký số";
            // 
            // pnlSignFile
            // 
            this.pnlSignFile.Controls.Add(this.label11);
            this.pnlSignFile.Controls.Add(this.txtFilePath);
            this.pnlSignFile.Controls.Add(this.txtPINFile);
            this.pnlSignFile.Controls.Add(this.label12);
            this.pnlSignFile.Location = new System.Drawing.Point(12, 122);
            this.pnlSignFile.Name = "pnlSignFile";
            this.pnlSignFile.Size = new System.Drawing.Size(265, 59);
            this.pnlSignFile.TabIndex = 15;
            this.pnlSignFile.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "FilePath";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(70, 6);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(143, 20);
            this.txtFilePath.TabIndex = 2;
            this.txtFilePath.Text = "C:\\Shared\\ddkhanh1\\CKS\\Cong_ty_co_phan_MISA_SDC_Test_(0101243150-613).p12";
            // 
            // txtPINFile
            // 
            this.txtPINFile.Location = new System.Drawing.Point(70, 31);
            this.txtPINFile.Name = "txtPINFile";
            this.txtPINFile.Size = new System.Drawing.Size(143, 20);
            this.txtPINFile.TabIndex = 4;
            this.txtPINFile.Text = "12345678";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "PIN Code";
            // 
            // pnlSignServer
            // 
            this.pnlSignServer.Controls.Add(this.lblSign_Name);
            this.pnlSignServer.Controls.Add(this.txtSign_Name);
            this.pnlSignServer.Controls.Add(this.txtSign_Pin);
            this.pnlSignServer.Controls.Add(this.lblSign_Pin);
            this.pnlSignServer.Location = new System.Drawing.Point(9, 83);
            this.pnlSignServer.Name = "pnlSignServer";
            this.pnlSignServer.Size = new System.Drawing.Size(265, 59);
            this.pnlSignServer.TabIndex = 7;
            this.pnlSignServer.Visible = false;
            // 
            // lblSign_Name
            // 
            this.lblSign_Name.AutoSize = true;
            this.lblSign_Name.Location = new System.Drawing.Point(10, 10);
            this.lblSign_Name.Name = "lblSign_Name";
            this.lblSign_Name.Size = new System.Drawing.Size(51, 13);
            this.lblSign_Name.TabIndex = 6;
            this.lblSign_Name.Text = "IP Server";
            // 
            // txtSign_Name
            // 
            this.txtSign_Name.Location = new System.Drawing.Point(70, 6);
            this.txtSign_Name.Name = "txtSign_Name";
            this.txtSign_Name.Size = new System.Drawing.Size(143, 20);
            this.txtSign_Name.TabIndex = 2;
            this.txtSign_Name.Text = "192.168.100.93";
            // 
            // txtSign_Pin
            // 
            this.txtSign_Pin.Location = new System.Drawing.Point(70, 31);
            this.txtSign_Pin.Name = "txtSign_Pin";
            this.txtSign_Pin.Size = new System.Drawing.Size(143, 20);
            this.txtSign_Pin.TabIndex = 4;
            this.txtSign_Pin.Text = "12345678";
            // 
            // lblSign_Pin
            // 
            this.lblSign_Pin.AutoSize = true;
            this.lblSign_Pin.Location = new System.Drawing.Point(10, 35);
            this.lblSign_Pin.Name = "lblSign_Pin";
            this.lblSign_Pin.Size = new System.Drawing.Size(53, 13);
            this.lblSign_Pin.TabIndex = 3;
            this.lblSign_Pin.Text = "PIN Code";
            // 
            // rbSignFile
            // 
            this.rbSignFile.AutoSize = true;
            this.rbSignFile.Location = new System.Drawing.Point(90, 20);
            this.rbSignFile.Name = "rbSignFile";
            this.rbSignFile.Size = new System.Drawing.Size(74, 17);
            this.rbSignFile.TabIndex = 8;
            this.rbSignFile.Text = "Ký qua file";
            this.rbSignFile.UseVisualStyleBackColor = true;
            this.rbSignFile.CheckedChanged += new System.EventHandler(this.rbSignFile_CheckedChanged);
            // 
            // rbSignHSM
            // 
            this.rbSignHSM.AutoSize = true;
            this.rbSignHSM.Location = new System.Drawing.Point(170, 20);
            this.rbSignHSM.Name = "rbSignHSM";
            this.rbSignHSM.Size = new System.Drawing.Size(49, 17);
            this.rbSignHSM.TabIndex = 5;
            this.rbSignHSM.Text = "HSM";
            this.rbSignHSM.UseVisualStyleBackColor = true;
            this.rbSignHSM.CheckedChanged += new System.EventHandler(this.rbHSM_CheckedChanged);
            // 
            // rbSignServer
            // 
            this.rbSignServer.AutoSize = true;
            this.rbSignServer.Location = new System.Drawing.Point(11, 41);
            this.rbSignServer.Name = "rbSignServer";
            this.rbSignServer.Size = new System.Drawing.Size(80, 17);
            this.rbSignServer.TabIndex = 1;
            this.rbSignServer.Text = "Ký máy chủ";
            this.rbSignServer.UseVisualStyleBackColor = true;
            this.rbSignServer.CheckedChanged += new System.EventHandler(this.rbSignServer_CheckedChanged);
            // 
            // rbSignDirect
            // 
            this.rbSignDirect.AutoSize = true;
            this.rbSignDirect.Checked = true;
            this.rbSignDirect.Location = new System.Drawing.Point(11, 20);
            this.rbSignDirect.Name = "rbSignDirect";
            this.rbSignDirect.Size = new System.Drawing.Size(78, 17);
            this.rbSignDirect.TabIndex = 0;
            this.rbSignDirect.TabStop = true;
            this.rbSignDirect.Text = "Ký trực tiếp";
            this.rbSignDirect.UseVisualStyleBackColor = true;
            this.rbSignDirect.CheckedChanged += new System.EventHandler(this.rbSignDirect_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dteOrgDate);
            this.groupBox5.Controls.Add(this.lblOrgDate);
            this.groupBox5.Controls.Add(this.lblNumberOrg);
            this.groupBox5.Controls.Add(this.txtNumberOrg);
            this.groupBox5.Controls.Add(this.rbAdjust);
            this.groupBox5.Controls.Add(this.rbReplace);
            this.groupBox5.Controls.Add(this.rbNormal);
            this.groupBox5.Location = new System.Drawing.Point(556, 215);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(256, 96);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Loại hóa đơn";
            // 
            // dteOrgDate
            // 
            this.dteOrgDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dteOrgDate.CustomFormat = "dd/MM/yyyy";
            this.dteOrgDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dteOrgDate.Location = new System.Drawing.Point(89, 68);
            this.dteOrgDate.Name = "dteOrgDate";
            this.dteOrgDate.Size = new System.Drawing.Size(152, 20);
            this.dteOrgDate.TabIndex = 9;
            this.dteOrgDate.Visible = false;
            // 
            // lblOrgDate
            // 
            this.lblOrgDate.AutoSize = true;
            this.lblOrgDate.Location = new System.Drawing.Point(11, 73);
            this.lblOrgDate.Name = "lblOrgDate";
            this.lblOrgDate.Size = new System.Drawing.Size(72, 13);
            this.lblOrgDate.TabIndex = 8;
            this.lblOrgDate.Text = "Ngày HĐ gốc";
            this.lblOrgDate.Visible = false;
            // 
            // lblNumberOrg
            // 
            this.lblNumberOrg.AutoSize = true;
            this.lblNumberOrg.Location = new System.Drawing.Point(11, 50);
            this.lblNumberOrg.Name = "lblNumberOrg";
            this.lblNumberOrg.Size = new System.Drawing.Size(60, 13);
            this.lblNumberOrg.TabIndex = 7;
            this.lblNumberOrg.Text = "Số HĐ gốc";
            this.lblNumberOrg.Visible = false;
            // 
            // txtNumberOrg
            // 
            this.txtNumberOrg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumberOrg.Location = new System.Drawing.Point(89, 46);
            this.txtNumberOrg.MaxLength = 7;
            this.txtNumberOrg.Name = "txtNumberOrg";
            this.txtNumberOrg.Size = new System.Drawing.Size(152, 20);
            this.txtNumberOrg.TabIndex = 3;
            this.txtNumberOrg.Text = "0000001";
            this.txtNumberOrg.Visible = false;
            // 
            // rbAdjust
            // 
            this.rbAdjust.AutoSize = true;
            this.rbAdjust.Location = new System.Drawing.Point(133, 20);
            this.rbAdjust.Name = "rbAdjust";
            this.rbAdjust.Size = new System.Drawing.Size(76, 17);
            this.rbAdjust.TabIndex = 2;
            this.rbAdjust.Text = "Điều chỉnh";
            this.rbAdjust.UseVisualStyleBackColor = true;
            this.rbAdjust.CheckedChanged += new System.EventHandler(this.rbAdjust_CheckedChanged);
            // 
            // rbReplace
            // 
            this.rbReplace.AutoSize = true;
            this.rbReplace.Location = new System.Drawing.Point(61, 20);
            this.rbReplace.Name = "rbReplace";
            this.rbReplace.Size = new System.Drawing.Size(67, 17);
            this.rbReplace.TabIndex = 1;
            this.rbReplace.Text = "Thay thế";
            this.rbReplace.UseVisualStyleBackColor = true;
            this.rbReplace.CheckedChanged += new System.EventHandler(this.rbReplace_CheckedChanged);
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.Location = new System.Drawing.Point(11, 20);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(45, 17);
            this.rbNormal.TabIndex = 0;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Gốc";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.rbNormal_CheckedChanged);
            // 
            // frmPublishInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 603);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gvDetail);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPublish);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPublishInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phát hành hóa đơn điện tử";
            this.Shown += new System.EventHandler(this.frmPublishInvoice_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.pnlSignFile.ResumeLayout(false);
            this.pnlSignFile.PerformLayout();
            this.pnlSignServer.ResumeLayout(false);
            this.pnlSignServer.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView gvDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vatPercentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vatAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn promotionDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource bsDetail;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSellerTaxCode;
        private System.Windows.Forms.TextBox txtSellerAddress;
        private System.Windows.Forms.TextBox txtSellerName;
        private System.Windows.Forms.TextBox txtBuyerAddress;
        private System.Windows.Forms.TextBox txtBuyerName;
        private System.Windows.Forms.TextBox txtBuyerTaxCode;
        private System.Windows.Forms.ComboBox cboKyHieu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtSign_Name;
        private System.Windows.Forms.RadioButton rbSignServer;
        private System.Windows.Forms.RadioButton rbSignDirect;
        private System.Windows.Forms.TextBox txtSign_Pin;
        private System.Windows.Forms.Label lblSign_Pin;
        private System.Windows.Forms.RadioButton rbSignHSM;
        private System.Windows.Forms.Label lblSign_Name;
        private System.Windows.Forms.Panel pnlSignServer;
        private System.Windows.Forms.RadioButton rbSignFile;
        private System.Windows.Forms.Panel pnlSignFile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtPINFile;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkSendEmail;
        private System.Windows.Forms.TextBox txtReceiverName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtReceiverEmail;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbAdjust;
        private System.Windows.Forms.RadioButton rbReplace;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.Label lblNumberOrg;
        private System.Windows.Forms.TextBox txtNumberOrg;
        private System.Windows.Forms.DateTimePicker dteOrgDate;
        private System.Windows.Forms.Label lblOrgDate;
    }
}
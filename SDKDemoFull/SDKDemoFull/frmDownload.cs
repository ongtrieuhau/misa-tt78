using API3.SDK;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace SDKDemo
{
    public partial class frmDownload : Form
    {
        public frmDownload()
        {
            InitializeComponent();
        }


        private void downloadButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                string downloadDataType ="xml";

                if (optZip.Checked)
                {
                    downloadDataType = "all";
                }
                else if (optPdf.Checked)
                {
                    downloadDataType = "pdf";
                }
           
                //Khai báo và gán list mã tra cứu cần tải
                List<string> transactionIDList = new List<string>();
               
                transactionIDList.Add(txtTransactionID.Text);
                //Khai báo đối tượng xử lý hóa đơn đã phát hành
                var invoiceObject = MeInvoiceFactory.CreateInvoicePublishedClass( Session.TaxCode,Session.Token);
                // tải hóa đơn theo list mã tra cứu
                var oResult = invoiceObject.DownloadInvoiceData(downloadDataType, transactionIDList, Session.IsInvoiceCode);
               //kiểm tra kết quả trả về và lưu file theo type tương ứng
                if (oResult.Success)
                {
                    var result = oResult.DownloadInvoices;

                    byte[] fileContent = null;
                    if (result.Count > 0)
                    {
                        if (string.IsNullOrEmpty(result[0].ErrorCode))
                        {
                            if(downloadDataType !="xml")
                              fileContent = Convert.FromBase64String(result[0].Data.ToString());
                            else
                                fileContent = Encoding.UTF8.GetBytes(result[0].Data.ToString());
                        }
                        else
                        {
                            Common.ShowMessage("Error: " + result[0].ErrorCode);
                        }

                    }

                    if (fileContent != null)
                    {
                        string filter = "";
                        string defaultExt = "";
                        switch (downloadDataType)
                        {
                            case "xml":
                                filter = "Xml (*.xml)|All (*.*)";
                                defaultExt = ".xml";
                                break;
                            case "pdf":
                                filter = "Pdf (*.pdf)|All (*.*)";
                                defaultExt = ".pdf";
                                break;
                            case "all":
                                filter = "Zip (*.zip)|All (*.*)";
                                defaultExt = ".zip";
                                break;
                        }

                        using (SaveFileDialog frm = new SaveFileDialog())
                        {
                            frm.Filter = filter;
                            frm.DefaultExt = defaultExt;
                            frm.FileName = string.Format("{0}{1}", txtTransactionID.Text, defaultExt);
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                System.IO.File.WriteAllBytes(frm.FileName, fileContent);
                                Common.ShowMessage("Successed.");
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            { Common.ShowException(ex); }
            finally { this.Cursor = Cursors.Default; }

        }
    }
}

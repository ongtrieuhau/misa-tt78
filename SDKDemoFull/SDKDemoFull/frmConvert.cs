using System;
using System.Collections.Generic;
using System.Windows.Forms;
using API3.SDK;
using API3.SDK.Interface;

namespace SDKDemo
{
    public partial class frmConvert : Form
    {

        IInvoicePublishing IInvoicePublishingObject ;
        public frmConvert()
        {
            InitializeComponent();

            IInvoicePublishingObject = MeInvoiceFactory.CreateInvoicePublishingClass(Session.TaxCode,Session.Token);
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.Cursor = Cursors.WaitCursor;

            //    List<string> transactionIDList = new List<string>();
            //    transactionIDList.Add(transactionText.Text);

            //    ConvertInvoiceToPaperOperationResult oResult = invoiceObject.ConvertInvoiceToPaper(converterText.Text, transactionIDList);
            //    if (oResult.Success)
            //    {
            //        List<ConvertToPaperResult> result = oResult.ConvertToPaperResultList;

            //        byte[] fileContent = null;
            //        if (result.Count > 0)
            //        {
            //            if (string.IsNullOrEmpty(result[0].ErrorCode))
            //            {
            //                //Dữ liệu trả về ở dạng base64 nên sẽ phải convert lại thành byte[]
            //                fileContent = Convert.FromBase64String(result[0].Data.ToString());
            //            }
            //            else
            //            {
            //                Common.ShowMessage("Error: " + result[0].ErrorCode);
            //            }
            //        }

            //        if (fileContent != null)
            //        {
            //            using (SaveFileDialog frm = new SaveFileDialog())
            //            {
            //                frm.Filter = "Pdf (*.pdf)|All (*.*)";
            //                frm.DefaultExt = ".pdf";
            //                frm.FileName = string.Format("{0}{1}", transactionText.Text, ".pdf");
            //                if (frm.ShowDialog() == DialogResult.OK)
            //                {
            //                    System.IO.File.WriteAllBytes(frm.FileName, fileContent);
            //                    Common.ShowMessage("Successed.");
            //                }
            //            }
            //        }
            //    }
                
            //}
            //catch (Exception ex)
            //{
            //    Common.ShowException(ex);
            //}
            //finally
            //{ this.Cursor = Cursors.Default; }
            
        }
    }
}

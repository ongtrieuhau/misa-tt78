using API3.SDK;
using API3.SDK.Model.Parameter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SDKDemo
{
    public partial class frmSendEmail : Form
    {
        public frmSendEmail()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, System.EventArgs e)
        {
            try
            {
                //khai báo đối tượng xử lý email
                var invoiceObject = MeInvoiceFactory.CreateEmailClass(Session.TaxCode, Session.Token);
                // khai báo đối tượng email gửi đi
                SendEmailParameter Emailparam = new SendEmailParameter();
                // khai báo list đối tượng email gửi đi
                List<SendEmailData> lstEmaildata = new List<SendEmailData>();
                // khai báo đối tượng dữ liệu email
                SendEmailData EmailData = new SendEmailData();
                // gán giá trị cho đối tượng dữ liệu email
                EmailData.TransactionID = txtTransactionID.Text;
                EmailData.ReceiverEmail = txtReceiverEmail.Text;
                EmailData.ReceiverName = txtReceiverName.Text;
                // thêm đối tượng dữ liệu email vào list
                lstEmaildata.Add(EmailData);
                // gán list đối tượng dữ liệu email vào đối tượng gửi email
                Emailparam.SendEmailDatas = lstEmaildata;
                //thực hiện gửi mail
                var result = invoiceObject.SendEmail(Emailparam);
                //kiểm tra gửi mail thành công hay không
                if (result != null && result.Success)
                {
                    Common.ShowMessage("Gửi thành công");
                }
                else
                {
                    Common.ShowMessage("Gửi thất bại: " + result.ErrorCode);
                }
            }
            catch (Exception ex)
            {
                Common.ShowException(ex);
            }
        }
    }
}

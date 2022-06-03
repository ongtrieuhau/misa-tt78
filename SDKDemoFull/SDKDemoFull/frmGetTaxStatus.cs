using API3.SDK;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDKDemo
{
    public partial class frmGetTaxStatus : Form
    {
        public frmGetTaxStatus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                //Khai báo đối tượng xử lý hóa đơn đã phát hành
                var invoiceObject = MeInvoiceFactory.CreateInvoicePublishedClass(Session.TaxCode, Session.Token);
                List<string> lstTransID = new List<string>();
                lstTransID.Add(txtTransactionID.Text);
                var Result = invoiceObject.GetListInvoiceStatus(lstTransID, Session.IsInvoiceCode);

                if (Result.Success)
                {
                   string Message = "";
                   if(Session.IsInvoiceCode)
                    {
                        Message += "trạng thái gửi cơ qua quan thuế: " + JsonConvert.SerializeObject(Result) + "(0: chờ cấp mã; 1: gửi lỗi; 2: đã cấp mã; 3: từ chối cấp mã; 4: gửi lỗi)";
                    }
                    else
                    {
                        Message += "trạng thái gửi cơ qua quan thuế: " + JsonConvert.SerializeObject(Result) + "(0: chưa gửi CQT; 1: Đã gửi CQT; 2: CQT tiếp nhận; 3: CQT không tiếp nhận; 4: gửi lỗi)";
                    }
                    Common.ShowMessage(Message);

                }
                else
                {
                    Common.ShowMessage("Không thể lấy trạng thái, mã lỗi: "+ Result.ErrorCode);
                }    
            }
            catch (Exception ex)
            {
                Common.ShowException(ex);
            }
            finally
            { this.Cursor = Cursors.Default; }
           
        }
    }
}

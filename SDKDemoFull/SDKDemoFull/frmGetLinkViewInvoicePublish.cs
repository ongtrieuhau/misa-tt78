using API3.SDK;
using API3.SDK.Interface;
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
    public partial class frmGetLinkViewInvoicePublish : Form
    {
        public frmGetLinkViewInvoicePublish()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                //khai báo đối tượng xử lý hóa đơn đã phát hành
                var IInvoicePublishedObject = MeInvoiceFactory.CreateInvoicePublishedClass( Session.TaxCode, Session.Token);
                // lấy link view từ mã tra cứu truyền vào
                string linkview = IInvoicePublishedObject.GetLinkViewInvoice(transactionText.Text);
                //kiểm tra có link không
                if (!string.IsNullOrWhiteSpace(linkview))
                {
                    //show link bằng trình duyệt
                    System.Diagnostics.Process.Start(linkview);
                }
                else
                {
                    Common.ShowMessage("Không thể lấy link xem hóa đơn");
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

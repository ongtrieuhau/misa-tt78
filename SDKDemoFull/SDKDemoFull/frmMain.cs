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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                Session.IsInvoiceCode = false;
            else
                Session.IsInvoiceCode = true;
            using (frmLogin frm = new frmLogin())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Common.ShowMessage("Kết nối thành công.");
                }
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var invObject = MeInvoiceFactory.CreatMISALicenseClass(Session.TaxCode,Session.Token );
            //    var result = invObject.GetLicenseseInfo();

            //    string resultJson = DataContract.SerializeUtil.SerializeObject(result);

            //    Common.ShowMessage("Success:" + Environment.NewLine + resultJson);
            //}
            //catch (Exception ex)
            //{
            //    Common.ShowException(ex);
            //}
        }

        private void publishButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session.Token))
            {
                Common.ShowMessage("chưa có thông tin token");
                return;
            }
            frmPublishInvoice frm = new frmPublishInvoice();
            frm.Show();
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session.Token))
            {
                Common.ShowMessage("chưa có thông tin token");
                return;
            }
            using (frmDownload frm = new frmDownload())
            {
                frm.ShowDialog();
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(Session.Token))
            //{
            //    Common.ShowMessage("chưa có thông tin token");
            //    return;
            //}
            //using (frmConvert frm = new frmConvert())
            //{
            //    frm.ShowDialog();
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session.Token))
            {
                Common.ShowMessage("chưa có thông tin token");
                return;
            }
            using (frmDeleteInvoice frm = new frmDeleteInvoice())
            {
                frm.ShowDialog();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session.Token))
            {
                Common.ShowMessage("chưa có thông tin token");
                return;
            }
            using (frmSendEmail frm = new frmSendEmail())
            {
                frm.ShowDialog();
            }
        }

        private void btnPublishMulti_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(Session.Token))
            //{
            //    Common.ShowMessage("chưa có thông tin token");
            //    return;
            //}
            //using (frmPublishMulti frm = new frmPublishMulti())
            //{
            //    frm.ShowDialog();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (frmConvertBase64 frm = new frmConvertBase64())
            //{
            //    frm.ShowDialog();
            //}
        }

        private void btnViewInvoicePublish_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session.Token))
            {
                Common.ShowMessage("chưa có thông tin token");
                return;
            }
            frmGetLinkViewInvoicePublish frm = new frmGetLinkViewInvoicePublish();
            frm.Show();
        }

        private void btnGetTaxSTT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session.Token))
            {
                Common.ShowMessage("chưa có thông tin token");
                return;
            }
            frmGetTaxStatus frm = new frmGetTaxStatus();
            frm.Show();
        }
    }
}

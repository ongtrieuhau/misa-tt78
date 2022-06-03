
using API3.SDK;
using API3.SDK.Interface;
using API3.SDK.Model.SDKResult;
using SDKDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SDKDemo
{
    public partial class frmDeleteInvoice : Form
    {
        public frmDeleteInvoice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                IInvoicePublished InvoicePublished = MeInvoiceFactory.CreateInvoicePublishedClass(Session.TaxCode, Session.Token);

                OperationResult oResult= InvoicePublished.CancelInvoice(txtTransactionID.Text, dteRefDate.Value,txtDeleteReason.Text, Session.IsInvoiceCode);
                
                if (oResult.Success && string.IsNullOrWhiteSpace(oResult.ErrorCode)) 
                {
                    Common.ShowMessage("Xóa thành công");
                }
                else
                {
                    Common.ShowMessage("Xóa thất bại");
                }
            }
            catch (Exception ex)
            {
                Common.ShowException(ex);
            }
        }
    }
}

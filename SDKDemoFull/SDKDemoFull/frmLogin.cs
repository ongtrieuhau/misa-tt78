using System;
using System.Windows.Forms;
using System.Net;
using API3.SDK.Model.SDKResult;
using API3.SDK;

namespace SDKDemo
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
               //Khai báo đối tượng Authen.
                var authen = MeInvoiceFactory.CreateAuthenClass();               
              // Lấy token từ : appid(misa cung cấp), mã số thuế, tài khoản đăng nhập hệ thống HĐĐT, Mật khẩu.
                GetTokenOperationResult oResult = authen.GetToken(Session.AppID, txtTaxCode.Text, txtUserName.Text, txtPassword.Text);

                if (oResult.Success && !string.IsNullOrEmpty(oResult.Token))
                {
                    //Gán token vào biến dùng chung từ kết quả oResult lấy token trả về.
                    Session.Token = oResult.Token;
                    //Gán mã số thuế vào biến dùng chung.
                    Session.TaxCode = txtTaxCode.Text;

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    //thông báo kết nối thất bại và show mã lỗi được trả về.
                    Common.ShowMessage("Kết nối thất bại, mã lỗi: "+ oResult.ErrorCode);
                   
                    txtTaxCode.Focus();
                }
            }
            catch (Exception ex)
            {
                Common.ShowException(ex);
            }
        }
    }
}

using API3.SDK.Interface;
using API3.SDK.Model;
using API3.SDK.Model.Parameter;
using API3.SDK.Model.SDKResult;
using System.Collections.Generic;

namespace API3.SDK.Class
{
    internal class Email : IEmail
    {
        #region Declaration

        /// <summary>
        /// Mã số thuế
        /// </summary>
        private string _taxCode = "";

        /// <summary>
        /// Token
        /// </summary>
        private string _token = "";

        #endregion Declaration

        #region Constructor

        /// <summary>
        /// Phương thức khởi tạo đối tượng <see cref="Email"/>
        /// </summary>
        /// <param name="token">Chuỗi Token của người dùng. Chuỗi Token này được trả về khi gọi phương thức <seealso cref="UserManagement.GetToken(string, string, string, string)"/></param>
        /// <param name="taxCode">Mã số thuế công ty </param>
        internal Email(string taxCode, string token)
        {
            _taxCode = taxCode;
            _token = token;
        }

        #endregion Constructor

        #region Function

        public SendInvoiceEmailResult SendEmail(SendEmailParameter sendData)
        {
            SendInvoiceEmailResult oResult = new SendInvoiceEmailResult { Success = false, ErrorCode = string.Empty };

            ServiceResult result = CommonFunction.ExecuteApiFunction(HttpMethod.POST, "itg/emails", "", _token, sendData, _taxCode);

            if (result.Success && !string.IsNullOrEmpty(result.Data.ToString()))
            {
                oResult.Success = result.Success;
                oResult.ErrorCode = result.ErrorCode;
                if (!string.IsNullOrEmpty(result.Data.ToString()))
                {
                    oResult.SendInvoiceEmail = (SerializeUtil.DeserializeObject<List<SendInvoiceEmail>>(result.Data.ToString()))[0];
                }
            }
            else
            {
                oResult.ErrorCode = result.ErrorCode;
            }
            return oResult;
        }

        #endregion Function
    }
}
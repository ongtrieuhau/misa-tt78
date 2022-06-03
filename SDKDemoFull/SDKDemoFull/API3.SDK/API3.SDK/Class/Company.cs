using API3.SDK.Interface;
using API3.SDK.Model;
using API3.SDK.Model.SDKResult;

namespace API3.SDK.Class
{
    class Company : ICompany
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
        internal Company(string taxCode, string token)
        {
            _taxCode = taxCode;
            _token = token;
        }

        #endregion Constructor

        #region Function

        /// <summary>
        /// Lấy thông tin công ty
        /// </summary>
        /// <returns>Thông tin công ty <see cref="Model.SDKResult.CompanyInfoResult.CompanyInfo"/></returns>
        public CompanyInfoResult GetCompanyInfo()
        {
            CompanyInfoResult oResult = new CompanyInfoResult { Success = false, ErrorCode = string.Empty };
            ServiceResult result = CommonFunction.ExecuteApiFunction(HttpMethod.GET, "company", "", _token, "", _taxCode);
            if (result.Success && !string.IsNullOrEmpty(result.Data.ToString()))
            {
                oResult.Success = true;
                oResult.CompanyInfo = SerializeUtil.DeserializeObject<API3.SDK.Model.SDKResult.Company>(result.Data.ToString());
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

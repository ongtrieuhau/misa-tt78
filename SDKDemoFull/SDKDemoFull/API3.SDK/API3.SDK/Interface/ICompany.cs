namespace API3.SDK.Interface
{
    /// <summary>
    /// Đối tượng liên quan thông tin công ty
    /// </summary>
    public interface ICompany
    {
        /// <summary>
        /// Lấy thông tin công ty
        /// </summary>
        /// <returns>Thông tin công ty <see cref="Model.SDKResult.CompanyInfoResult.CompanyInfo"/></returns>
        Model.SDKResult.CompanyInfoResult GetCompanyInfo();
    }
}

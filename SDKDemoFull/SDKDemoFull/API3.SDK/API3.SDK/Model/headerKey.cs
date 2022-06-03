namespace API3.SDK.Model
{
    /// <summary>
    /// Lớp chứa các key của header trong request gọi lên meInvoice Cloud
    /// </summary>
    public class HeaderKey
    {
        /// <summary>
        /// Key header chứa chuỗi Token bảo mật
        /// </summary>
        public const string Authorization = "Authorization";

        /// <summary>
        /// Key header chứa taxcode
        /// </summary>
        public const string CompanyTaxCode = "CompanyTaxCode";
    }

    /// <summary>
    /// Lớp chứa các key định nghĩa phương thức gọi request lên meInvoice Cloud
    /// </summary>
    public class HttpMethod
    {
        /// <summary>
        /// Phương thức GET
        /// </summary>
        public const string GET = "GET";

        /// <summary>
        /// Phương thức POST
        /// </summary>
        public const string POST = "POST";

        /// <summary>
        /// Phương thức PUT
        /// </summary>
        public const string PUT = "PUT";

        /// <summary>
        /// Phương thức Xóa
        /// </summary>
        public const string DELETE = "DELETE";
    }
}
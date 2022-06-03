namespace API3.SDK
{
    public class MeInvoiceFactory
    {
        /// <summary>
        /// Đường dẫn API thông thường
        /// </summary>
        public static string MEAPIV3URL { get; set; } = "https://api.meinvoice.vn/api/v3";

        /// <summary>
        /// Đường dẫn API hóa đơn có mã
        /// </summary>
        public static string MECODEAPIV3URL { get; set; } = "https://api.meinvoice.vn/api/v3/code";

        /// <summary>
        /// Đường dẫn Download hóa đơn
        /// </summary>
        public static string MEDownloadURL { get; set; } = "https://download.meinvoice.vn";

        /// <summary>
        /// Đường dẫn Download hóa đơn
        /// </summary>
        public static string MESearchURL { get; set; } = "https://meinvoice.vn/tra-cuu";

        /// <summary>
        /// Phương thức khởi tạo Đối tượng liên quan Authen
        /// <para>Đăng nhập lấy Token</para>
        /// </summary>
        /// <returns>Đối tượng liên quan Authen</returns>
        public static Interface.IAuthen CreateAuthenClass()
        {
            return new Class.Authen();
        }

        /// <summary>
        /// Phương thức khởi tạo Đối tượng phát hành hóa đơn không mã
        /// </summary>
        /// <param name="taxCode">Mã số thuế</param>
        /// <param name="token">Token của người dùng khi đăng nhập</param>
        /// <returns>Đối tượng phát hành hóa đơn không mã</returns>
        public static Interface.IInvoicePublishing CreateInvoicePublishingClass(string taxCode, string token)
        {
            return new Class.InvoicePublishing(taxCode, token);
        }

        /// <summary>
        /// Phương thức khởi tạo Đối tượng thao tác với hóa đơn đã phát hành
        /// </summary>
        /// <param name="taxCode">Mã số thuế</param>
        /// <param name="token">Token của người dùng khi đăng nhập</param>
        /// <returns>Đối tượng thao tác với hóa đơn đã phát hành</returns>
        public static Interface.IInvoicePublished CreateInvoicePublishedClass(string taxCode, string token)
        {
            return new Class.InvoicePublished(taxCode, token);
        }

        /// <summary>
        /// Phương thức khởi tạo Đối tượng xử lý gửi email
        /// </summary>
        /// <param name="taxCode">Mã số thuế</param>
        /// <param name="token">Token của người dùng khi đăng nhập</param>
        /// <returns>Đối tượng xử lý gửi email</returns>
        public static Interface.IEmail CreateEmailClass(string taxCode, string token)
        {
            return new Class.Email(taxCode, token);
        }
    }
}
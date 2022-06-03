namespace API3.SDK.Model.SDKResult
{
    /// <summary>
    /// Kết quả trả về: Danh sách kết quả gửi email
    /// </summary>
    public class SendInvoiceEmailResult : OperationResult
    {
        /// <summary>
        /// Danh sách kết quả gửi email
        /// </summary>
        public SendInvoiceEmail SendInvoiceEmail { get; set; }
    }

    /// <summary>
    /// Thông tin kết quả gửi email
    /// </summary>
    public class SendInvoiceEmail
    {
        /// <summary>
        /// Mã tra cứu hóa đơn
        /// </summary>
        public string TransactionID { get; set; }

        /// <summary>
        /// Trạng thái gửi email
        /// </summary>
        public Enum.SendInvoiceStatus SendEmailStatus { get; set; }

        /// <summary>
        /// Mã lỗi
        /// </summary>
        public string ErrorCode { get; set; }
    }
}
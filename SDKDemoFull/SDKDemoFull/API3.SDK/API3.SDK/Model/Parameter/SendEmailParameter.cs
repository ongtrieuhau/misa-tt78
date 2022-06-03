namespace API3.SDK.Model.Parameter
{
    /// <summary>
    /// Tham số gửi Email
    /// </summary>
    public class SendEmailParameter
    {
        /// <summary>
        /// Danh sách thông tin gửi email
        /// </summary>
        public System.Collections.Generic.List<SendEmailData> SendEmailDatas { get; set; }

        /// <summary>
        /// Hóa đơn có mã hay không
        /// </summary>
        public bool IsInvoiceCode { get; set; }
    }

    /// <summary>
    /// Tham số gửi Email
    /// </summary>
    public class SendEmailData
    {
        /// <summary>
        /// Mã tra cứu
        /// </summary>
        public string TransactionID { get; set; }

        /// <summary>
        /// Tên người nhận
        /// </summary>
        public string ReceiverName { get; set; }

        /// <summary>
        /// List Email
        /// </summary>
        public string ReceiverEmail { get; set; }

        /// <summary>
        /// Email cc
        /// </summary>
        public string CCEmail { get; set; }

        /// <summary>
        /// Email bcc
        /// </summary>
        public string BCCEmail { get; set; }

        /// <summary>
        /// Link callback
        /// </summary>
        public string CallbackUrl { get; set; }

        /// <summary>
        /// địa chỉ email khi reply
        /// </summary>
        public string ReplyEmail { get; set; }
    }
}
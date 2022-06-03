namespace API3.SDK.Model.SDKResult
{
    /// <summary>
    /// Đối tượng trả về kết quả khi ký điện tử
    /// </summary>
    public class SignXMLResult
    {
        /// <summary>
        /// Nội dung file xml đã ký
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// Mã lỗi
        /// </summary>
        public string Error { get; set; }
    }

    /// <summary>
    /// Đối tượng trả về kết quả khi gọi Windows service
    /// </summary>
    public class SignServiceResult
    {
        /// <summary>
        /// Trạng thái
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Payload
        /// </summary>
        public string Payload { get; set; }
    }
}
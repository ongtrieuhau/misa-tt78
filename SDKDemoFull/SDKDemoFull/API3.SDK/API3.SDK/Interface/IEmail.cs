namespace API3.SDK.Interface
{
    /// <summary>
    /// Đối tượng xử lý gửi email
    /// </summary>
    public interface IEmail
    {
        /// <summary>
        /// Gửi Email theo nhiều loại
        /// </summary>
        /// <param name="sendData">Dữ liệu gửi Email</param>
        /// <returns>Kết quả gửi email - <see cref="Model.SDKResult.SendInvoiceEmailResult.SendInvoiceEmail"/></returns>
        Model.SDKResult.SendInvoiceEmailResult SendEmail(Model.Parameter.SendEmailParameter sendData);
    }
}
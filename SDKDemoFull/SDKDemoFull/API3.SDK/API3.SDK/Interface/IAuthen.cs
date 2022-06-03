namespace API3.SDK.Interface
{
    /// <summary>
    /// Đối tượng liên quan Authen
    /// </summary>
    public interface IAuthen
    {
        /// <summary>
        /// Hàm thực hiện lấy về Token dùng để Authentication khi truy cập vào các tài nguyên của MISA meInvoice
        /// - Nếu đăng nhập thành công thì trả về Token có giá trị
        /// - Nếu đăng nhập thất bại thì trả về:
        ///     + <see cref="Model.SDKResult.OperationResult.ErrorCode"/> = "TwoFactorAuthen" thì xác thực 2 lớp với hàm <see cref=TwoFactorAuthorize"/>
        ///     + <see cref="Model.SDKResult.OperationResult.ErrorCode"/> = "UnAuthorize" thì kiểm tra mã lỗi trong <see cref="Model.SDKResult.OperationResult.ErrorCodes"/> để cảnh báo
        /// - Danh sách mã lỗi trong trong <see cref="Model.SDKResult.OperationResult.ErrorCodes"/>:
        ///     + InvalidAppID: AppID không hợp lệ
        ///     + TaxCodeNotExist: Mã số thuế chưa đăng ký MISA meInvoice
        ///     + InactiveTaxCode: Mã số thuế đã ngưng hoạt động
        ///     + UserNotExist: Tài khoản không tồn tại
        ///     + WrongPassWord: Mật khẩu không chính xác
        ///     + InactiveUser: Tài khoản đã ngưng hoạt động
        ///     + MisaIdError: Kết nối MISA ID lỗi
        /// </summary>
        /// <param name="appID">ID của ứng dụng. ID này do MISA cung cấp cho đối tác tích hợp MISA meInvoice</param>
        /// <param name="taxCode">Mã số thuế doanh nghiệp sử dụng MISÂ meInvoice</param>
        /// <param name="userName">Email hoặc số điện thoại của người dùng MISA meInvoice</param>
        /// <param name="password">Mật khẩu của người dùng MISA meInvoice</param>
        /// <returns>Kết quả chứa chuỗi Token nếu các thông tin gửi lên là hợp lệ - <see cref="Model.SDKResult.GetTokenOperationResult.Token"/></returns>
        Model.SDKResult.GetTokenOperationResult GetToken(string appID, string taxCode, string userName, string password);

        /// <summary>
        /// Hàm để xác thực MISAID nếu tài khoản bật bảo mật 2 lớp
        /// </summary>
        /// <param name="code">Mã xác thực 2 lớp</param>
        /// <param name="taxCode">Mã số thuế</param>
        /// <param name="userName">Tài khoản đăng nhập</param>
        /// <param name="userId">ID Tài khoản đăng nhập</param>
        /// <param name="deviceId">ID thiết bị</param>
        /// <param name="hasAuthenticator">Có phải Mã xác thực từ Ứng dụng Goole Authenticator không</param>
        /// <param name="remember">Có ghi nhớ thiết bị không</param>
        /// <param name="appID">ID của ứng dụng. ID này do MISA cung cấp cho đối tác tích hợp MISA meInvoice</param>
        /// <returns>Kết quả chứa chuỗi Token nếu các thông tin gửi lên là hợp lệ - <see cref="Model.SDKResult.GetTokenOperationResult.Token"/></returns>
        Model.SDKResult.GetTokenOperationResult TwoFactorAuthorize(string code, string taxCode, string userName, string userId, string deviceId, bool hasAuthenticator, bool remember, string appID);

        /// <summary>
        /// Token hết hạn thì gọi lên meinvoice lấy token mới
        /// <para>Nếu Token cũ chưa hết hạn thì sẽ trả về mã lỗi UnAuthorize và dùng tiếp Token cũ</para>
        /// </summary>
        /// <param name="token">Token cũ đã hết hạn</param>
        /// <returns>Kết quả chứa chuỗi Token mới - <see cref="Model.SDKResult.GetTokenOperationResult.Token"/></returns>
        Model.SDKResult.GetTokenOperationResult RefreshToken(string token);
    }
}
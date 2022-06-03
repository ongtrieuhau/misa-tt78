namespace API3.SDK.Model.SDKResult
{
    /// <summary>
    /// Kết quả lấy Token để Authentication khi kết nối với MISA meInvoice
    /// - Nếu đăng nhập thành công thì trả về Token có giá trị
    /// - Nếu đăng nhập thất bại thì trả về:
    ///     + <see cref="MISA.MeInvoice.Model.SDKResult.OperationResult.ErrorCode"/> = "TwoFactorAuthen" thì xác thực 2 lớp
    ///     + <see cref="MISA.MeInvoice.Model.SDKResult.OperationResult.ErrorCode"/> = "UnAuthorize" thì kiểm tra mã lỗi trong <see cref="MISA.MeInvoice.Model.SDKResult.OperationResult.ErrorCodes"/> để cảnh báo
    /// - Danh sách mã lỗi trong trong <see cref="MISA.MeInvoice.Model.SDKResult.OperationResult.ErrorCodes"/>:
    ///     + InvalidAppID: AppID không hợp lệ
    ///     + TaxCodeNotExist: Mã số thuế chưa đăng ký MISA meInvoice
    ///     + InactiveTaxCode: Mã số thuế đã ngưng hoạt động
    ///     + UserNotExist: Tài khoản không tồn tại
    ///     + WrongPassWord: Mật khẩu không chính xác
    ///     + InactiveUser: Tài khoản đã ngưng hoạt động
    ///     + MisaIdError: Kết nối MISA ID lỗi
    /// </summary>
    public class GetTokenOperationResult : OperationResult
    {
        /// <summary>
        /// Token kết nối với MISA meInvoice
        /// </summary>
        public string Token { get; set; }
    }
}
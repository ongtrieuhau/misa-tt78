namespace API3.SDK.Model.Parameter
{
    /// <summary>
    /// Tham số để lấy token
    /// </summary>
    public class GetTokenParameter
    {
        /// <summary>
        /// ID của ứnng dụng tích hợp
        /// </summary>
        public string AppID { get; set; }

        /// <summary>
        /// Mã số thuế
        /// </summary>
        public string TaxCode { get; set; }

        /// <summary>
        /// Tên đăng nhập
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Mật khẩu
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// ID thiết bị xác thực 2 lớp MISAID
        /// </summary>
        public string DeviceID { get; set; }
    }

    /// <summary>
    /// Tham số cho hàm gọi TwoFactorAuthorize của misaid
    /// </summary>
    public class MisaIDRegisterParameter
    {
        public string AppID { get; set; }

        /// <summary>
        /// Tên tài khoản
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Mã xác thực 2 lớp
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// ID Thiết bị
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// Có phải Mã từ Ứng dụng Google Authen không
        /// </summary>
        public bool HasAuthenticator { get; set; } = false;

        /// <summary>
        /// Nhớ thiết bị không hỏi xác thực ở lần sau
        /// </summary>
        public bool Remember { get; set; } = false;

        /// <summary>
        /// Mã số thuế
        /// </summary>
        public string TaxCode { get; set; }

        /// <summary>
        /// id của user
        /// </summary>
        public string UserId { get; set; }
    }
}
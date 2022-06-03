using System;

namespace API3.SDK.Model.SDKResult
{
    /// <summary>
    /// Kết quả trả về: Thông tin công ty
    /// </summary>
    public class CompanyInfoResult : OperationResult
    {
        /// <summary>
        /// Thông tin công ty
        /// </summary>
        public Company CompanyInfo { get; set; }
    }

    /// <summary>
    /// Thông tin công ty
    /// </summary>
    public class Company
    {
        /// <summary>
        /// ID công ty
        /// </summary>
        public int CompanyID { get; set; }

        /// <summary>
        /// Mã công ty
        /// </summary>
        public string CompanyCode { get; set; }

        /// <summary>
        /// Tên công ty
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Mã bảo mật
        /// </summary>
        public string SecureToken { get; set; }

        /// <summary>
        /// Mã số thuế công ty
        /// </summary>
        public string CompanyTaxCode { get; set; }

        /// <summary>
        /// Ngưng hoạt dộng
        /// </summary>
        public bool Inactive { get; set; }

        /// <summary>
        /// Địa chỉ công ty
        /// </summary>
        public string CompanyAddress { get; set; }

        /// <summary>
        /// Tỉnh/ Thành phố
        /// </summary>
        public string CompanyCity { get; set; }

        /// <summary>
        /// Mã nhân viên MISA
        /// </summary>
        public string MISAEmployeeCode { get; set; }

        /// <summary>
        /// Đơn vị tích hợp
        /// </summary>
        public int SourceType { get; set; }

        /// <summary>
        /// Ngày tạo
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Ngày tích hợp
        /// </summary>
        public DateTime? IntegratedDate { get; set; }

        /// <summary>
        /// Mã số thuế không dấu
        /// </summary>
        public string CompanyTaxCodeWithoutSign { get; set; }

        /// <summary>
        /// Thông tin người đại diện pháp luật
        /// </summary>
        public string CompanyAgentFollowLaw { get; set; }

        /// <summary>
        /// ĐT cty
        /// </summary>
        public string CompanyTel { get; set; }

        /// <summary>
        /// Email cty
        /// </summary>
        public string CompanyEmail { get; set; }

        /// <summary>
        /// Website
        /// </summary>
        public string CompanyWebsite { get; set; }

        /// <summary>
        /// Lĩnh vực hoạt động
        /// </summary>
        public string BusinessType { get; set; }

        /// <summary>
        /// TK Ngân Hàng
        /// </summary>
        public string BankAccount { get; set; }

        /// <summary>
        /// Ngân hàng
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// Chi nhánh NH
        /// </summary>
        public string BankBranchName { get; set; }

        /// <summary>
        /// Cơ quan thuế cấp cục
        /// </summary>
        public string TaxationBureau { get; set; }

        /// <summary>
        /// CQ thuế quản lý
        /// </summary>
        public string TaxOrganManagement { get; set; }

        /// <summary>
        /// Mã CQ thuế quản lý
        /// </summary>
        public string TaxOrganManagementCode { get; set; }

        /// <summary>
        /// Người đại diện pháp luật
        /// </summary>
        public string Director { get; set; }

        /// <summary>
        /// Fax công ty
        /// </summary>
        public string CompanyFax { get; set; }

        /// <summary>
        /// nghệ nghiệp lĩnh vực hoạt động của công ty
        /// </summary>
        public string Career { get; set; }

        /// <summary>
        /// email người đại diện pháp luật
        /// </summary>
        public string LegalepresentationEmail { get; set; }

        /// <summary>
        /// SĐT người đại diện pháp luật
        /// </summary>
        public string LegalepresentationPhone { get; set; }

        /// <summary>
        /// Thông tư áp dụng
        /// </summary>
        public string CircularFollow { get; set; }

        /// <summary>
        /// True: sử dụng HĐ có mã
        /// </summary>
        public bool IsInvoiceWithCode { get; set; }

        /// <summary>
        /// Sử dụng vé
        /// </summary>
        public bool IsUsingTicket { get; set; }

        /// <summary>
        /// Người liên hệ
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// Địa chỉ liên hệ
        /// </summary>
        public string ContactAddress { get; set; }

        /// <summary>
        /// Email liên hệ
        /// </summary>
        public string ContactEmail { get; set; }

        /// <summary>
        /// Điện thoại liên hệ
        /// </summary>
        public string ContactMobile { get; set; }

        /// <summary>
        /// Có tờ khai được chấp nhận hay chưa
        /// </summary>
        public bool HasAccepted123 { get; set; }
    }
}

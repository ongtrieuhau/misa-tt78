namespace API3.SDK.Model.SDKResult
{
    /// <summary>
    /// Kết quả trả về: Danh sách mẫu hóa đơn
    /// </summary>
    public class ListInvoiceTemplateResult : OperationResult
    {
        /// <summary>
        /// Danh sách mẫu hóa đơn
        /// </summary>
        public System.Collections.Generic.List<TemplateData> TemplateDatas { get; set; }
    }

    /// <summary>
    /// Mẫu hóa đơn
    /// </summary>
    public class TemplateData
    {
        /// <summary>
        /// ID mẫu
        /// </summary>
        public System.Guid IPTemplateID { get; set; }

        /// <summary>
        /// ID công ty
        /// </summary>
        public int CompanyID { get; set; }

        /// <summary>
        /// Tên mẫu
        /// </summary>
        public string TemplateName { get; set; }

        /// <summary>
        /// Mẫu số
        /// </summary>
        public string InvTemplateNo { get; set; }

        /// <summary>
        /// Ký hiệu
        /// </summary>
        public string InvSeries { get; set; }

        /// <summary>
        /// Ký hiệu
        /// </summary>
        public string OrgInvSeries { get; set; }

        /// <summary>
        /// Loại mẫu (stimul, xslt,...)
        /// </summary>
        public int TemplateType { get; set; }

        /// <summary>
        /// Loại hóa đơn (GTGT, bán hàng, xuất kho,...)
        /// </summary>
        public int InvoiceType { get; set; }

        /// <summary>
        /// Nghiệp vụ
        /// </summary>
        public int BusinessAreas { get; set; }

        /// <summary>
        /// Thứ tự
        /// </summary>
        public int SortOrder { get; set; }

        /// <summary>
        /// Ngày ký
        /// </summary>
        public System.DateTime? SignedDate { get; set; }

        /// <summary>
        /// Ngày tạo
        /// </summary>
        public System.DateTime CreatedDate { get; set; }

        /// <summary>
        /// Người tạo
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Ngày sửa
        /// </summary>
        public System.DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Người sửa
        /// </summary>
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Ngừng hoạt động
        /// </summary>
        /// <returns></returns>
        public bool Inactive { get; set; }

        /// <summary>
        /// Nội dung file mẫu
        /// </summary>
        public byte[] TemplateContent { get; set; }

        /// <summary>
        /// ID mẫu mặc định
        /// </summary>
        public System.Guid DefaultTemplateID { get; set; }

        /// <summary>
        /// Có phải mẫu custom không
        /// </summary>
        public bool IsCustomTemplate { get; set; }

        /// <summary>
        /// kế thừa từ mẫu cũ hay không
        /// </summary>
        public bool IsInheritFromOldTemplate { get; set; }

        /// <summary>
        /// Phiên bản mẫu xslt
        /// </summary>
        public int? XsltVersion { get; set; }

        /// <summary>
        /// Đã phát hành hđ hay chưa
        /// </summary>
        public bool IsPublished { get; set; }
    }
}
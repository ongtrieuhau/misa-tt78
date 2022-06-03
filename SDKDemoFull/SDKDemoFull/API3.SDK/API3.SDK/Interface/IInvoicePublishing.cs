namespace API3.SDK.Interface
{
    /// <summary>
    /// Đối tượng phát hành hóa đơn
    /// </summary>
    public interface IInvoicePublishing
    {
        /// <summary>
        /// Lấy danh sách các mẫu hóa đơn đã đăng ký sử dụng với Cơ quan thuế để phát hành
        /// </summary>
        /// <param name="invYear">Năm sử dụng để phát hành hóa đơn điện tử</param>
        /// <param name="IsInvoiceCode">Là hóa đơn có mã không?</param>
        /// <returns>Danh sách mẫu đã đăng ký sử dụng - <see cref="Model.SDKResult.ListInvoiceTemplateResult.TemplateDatas"/></returns>
        Model.SDKResult.ListInvoiceTemplateResult GetInvoiceTemplateForPublish(int invYear, bool IsInvoiceCode = false);

        /// <summary>
        /// Lấy link xem hóa đơn chưa phát hành
        /// </summary>
        /// <param name="originalInvoiceData">Thông tin hóa đơn cần xem trước</param>
        /// <param name="IsInvoiceCode">Là hóa đơn có mã không?</param>
        /// <returns>Link xem hóa đơn - <see cref="Model.SDKResult.LinkViewInvoiceResult.LinkViewInvoice"/></returns>
        Model.SDKResult.LinkViewInvoiceResult GetLinkViewInvoiceUnPublish(Model.Parameter.OriginalInvoiceData originalInvoiceData, bool IsInvoiceCode = false);

        /// <summary>
        /// Tạo dữ liệu hóa đơn
        /// <para>Tạo XML</para>
        /// </summary>
        /// <param name="originalInvoiceDatas">Danh sách thông tin hóa đơn dạng thô</param>
        /// <param name="IsInvoiceCode">Là hóa đơn có mã không?</param>
        /// <returns>Danh sách hóa đơn đã khởi tạo XML - List <see cref="Model.SDKResult.ListCreateInvoiceDataResult.CreateInvoiceDatas"/></returns>
        Model.SDKResult.ListCreateInvoiceDataResult CreateInvoiceData(System.Collections.Generic.List<Model.Parameter.OriginalInvoiceData> originalInvoiceDatas, bool IsInvoiceCode = false);

        /// <summary>
        /// Phát hành hóa đơn
        /// <para>Phát hành các hóa đơn đã ký</para>
        /// </summary>
        /// <param name="publishInvoiceDatas">Danh sách hóa đơn đã ký</param>
        /// <param name="IsInvoiceCode">Là hóa đơn có mã không?</param>
        /// <returns>Danh sách kết quả phát hành hóa đơn - List <see cref="Model.SDKResult.ListPublishInvoiceResult.PublishInvoices"/></returns>
        Model.SDKResult.ListPublishInvoiceResult PublishInvoice(System.Collections.Generic.List<Model.Parameter.PublishInvoiceData> publishInvoiceDatas, bool IsInvoiceCode = false);
    }
}
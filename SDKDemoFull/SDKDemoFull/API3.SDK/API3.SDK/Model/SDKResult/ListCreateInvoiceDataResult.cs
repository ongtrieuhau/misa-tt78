namespace API3.SDK.Model.SDKResult
{
    /// <summary>
    /// Kết quả trả về: Danh sách hóa đơn đã khởi tạo XML
    /// </summary>
    public class ListCreateInvoiceDataResult : OperationResult
    {
        /// <summary>
        /// Danh sách hóa đơn đã khởi tạo XML
        /// </summary>
        public System.Collections.Generic.List<CreateInvoiceData> CreateInvoiceDatas { get; set; }
    }

    /// <summary>
    /// Kết quả hàm tạo hóa đơn - tạo XML
    /// </summary>
    public class CreateInvoiceData
    {
        /// <summary>
        /// ID của hóa đơn gốc
        /// </summary>
        public string RefID { get; set; }

        /// <summary>
        /// Mã tra cứu hóa đơn
        /// </summary>
        public string TransactionID { get; set; }

        /// <summary>
        /// Số hóa đơn
        /// </summary>
        public string InvNo { get; set; }

        /// <summary>
        /// Ngày hóa đơn
        /// </summary>
        public System.DateTime InvDate { get; set; }

        /// <summary>
        /// Thông tin hóa đơn dạng XML
        /// </summary>
        public string InvoiceData { get; set; }

        /// <summary>
        /// Mã lỗi
        /// </summary>
        public string ErrorCode { get; set; }
    }
}
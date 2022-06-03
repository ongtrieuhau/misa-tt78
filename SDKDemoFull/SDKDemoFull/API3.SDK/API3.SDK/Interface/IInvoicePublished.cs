using System;
using API3.SDK.Interface;
using API3.SDK.Model;
using API3.SDK.Model.Parameter;
using API3.SDK.Model.SDKResult;
using System.Collections.Generic;

namespace API3.SDK.Interface
{
    /// <summary>
    /// Đối tượng thao tác với hóa đơn đã phát hành
    /// </summary>
    public interface IInvoicePublished
    {
        /// <summary>
        /// Lấy trạng thái hóa đơn đã phát hành theo Mã tra cứu
        /// </summary>
        /// <param name="transactionID">Mã tra cứu</param>
        /// <param name="IsInvoiceCode">Là hóa đơn có mã không?</param>
        /// <returns>Thông tin trạng thái hóa đơn đã phát hành - <see cref="Model.SDKResult.InvoiceStatusResult.InvoiceStatus"/></returns>
        Model.SDKResult.InvoiceStatusResult GetInvoiceStatus(string transactionID, bool IsInvoiceCode = false);
        /// <summary>
        /// Lấy trạng thái hóa đơn đã phát hành theo Mã tra cứu
        /// </summary>
        /// <param name="transactionID">Mã tra cứu</param>
        Model.SDKResult.ListInvoiceStatusResult GetListInvoiceStatus(List<string> lsttransactionID, bool IsInvoiceCode = false);
        /// <summary>
        /// Lấy link tra cứu để xem hóa đơn
        /// </summary>
        /// <param name="TransactionID">Mã tra cứu </param>
        /// <returns>Link xem hóa đơn</returns>
        string GetLinkViewInvoice(string TransactionID);

        /// <summary>
        /// Tải hóa đơn không mã
        /// <para>Nếu tải cả xml và pdf thì: downloadDataType="all"</para>
        /// </summary>
        /// <param name="downloadDataType">Loại dữ liệu cần tải: xml - pdf - all (<see cref="Model.Enum.DownloadType"/>)</param>
        /// <param name="TransactionIDs">List mã tra cứu</param>
        /// <param name="IsInvoiceCode">Là hóa đơn có mã không?</param>
        /// <returns>Thông tin tải hóa đơn - <see cref="Model.SDKResult.DownloadInvoiceResult.DownloadInvoices"/></returns>
        Model.SDKResult.DownloadInvoiceResult DownloadInvoiceData(string downloadDataType, System.Collections.Generic.List<string> TransactionIDs, bool IsInvoiceCode = false);

        /// <summary>
        /// Hủy hóa đơn
        /// </summary>
        /// <param name="transId">Mã tra cứu hóa đơn cần hủy</param>
        /// <param name="cancelDate">Ngày hủy hóa đơn</param>
        /// <param name="cancelReason">Lý do hủy</param>
        /// <param name="IsInvoiceCode">Là hóa đơn có mã không?</param>
        /// <returns>Kết quả hủy: <see cref="Model.SDKResult.OperationResult.Success"/>=true && <see cref="Model.SDKResult.OperationResult.ErrorCode"/>==string.empty => thành công </returns>
        Model.SDKResult.OperationResult CancelInvoice(string transId, System.DateTime cancelDate, string cancelReason, bool IsInvoiceCode = false);
    }
}
using API3.SDK.Interface;
using API3.SDK.Model;
using API3.SDK.Model.SDKResult;
using System.Collections.Generic;

namespace API3.SDK.Class
{
    internal class InvoicePublished : IInvoicePublished
    {
        #region Declare

        /// <summary>
        /// Mã số thuế
        /// </summary>
        private string _taxCode = "";

        /// <summary>
        /// Token
        /// </summary>
        private string _token = "";

        #endregion Declare

        #region Constructor

        /// <summary>
        /// Phương thức khởi tạo đối tượng <see cref="InvoicePublished"/>
        /// </summary>
        /// <param name="taxCode">Mã số thuế</param>
        /// <param name="token">Token của người dùng khi đăng nhập <seealso cref="IAuthen.GetToken(string, string, string, string)"/></param>
        internal InvoicePublished(string taxCode, string token)
        {
            _taxCode = taxCode;
            _token = token;
        }

        #endregion Constructor

        public DownloadInvoiceResult DownloadInvoiceData(string downloadDataType, List<string> TransactionIDs, bool IsInvoiceCode = false)
        {
            DownloadInvoiceResult oResult = new DownloadInvoiceResult { Success = false, ErrorCode = string.Empty };
            ServiceResult result = CommonFunction.ExecuteApiFunction(HttpMethod.POST, "itg/invoicepublished", string.Format("downloadinvoice?downloadDataType={0}", downloadDataType), _token, TransactionIDs, _taxCode, IsInvoiceCode);
            if (result.Success && !string.IsNullOrEmpty(result.Data.ToString()))
            {
                oResult.Success = true;
                oResult.DownloadInvoices = SerializeUtil.DeserializeObject<List<DownloadInvoice>>(result.Data.ToString());
            }
            else
            {
                oResult.ErrorCode = result.ErrorCode;
            }
            return oResult;
        }

        public InvoiceStatusResult GetInvoiceStatus(string transactionID, bool IsInvoiceCode = false)
        {
            InvoiceStatusResult oResult = new InvoiceStatusResult { Success = false, ErrorCode = string.Empty };
            ServiceResult result = CommonFunction.ExecuteApiFunction(HttpMethod.GET, "itg/invoicepublished", string.Format("invoicestatus?transactionID={0}", transactionID), _token, "", _taxCode, IsInvoiceCode);
            if (result.Success && !string.IsNullOrEmpty(result.Data.ToString()))
            {
                oResult.Success = true;
                oResult.InvoiceStatus = SerializeUtil.DeserializeObject<InvoiceStatus>(result.Data.ToString());
            }
            else
            {
                oResult.ErrorCode = result.ErrorCode;
            }
            return oResult;
        }

        public ListInvoiceStatusResult GetListInvoiceStatus(List<string> lsttransactionID, bool IsInvoiceCode = false)
        {
            ListInvoiceStatusResult oResult = new ListInvoiceStatusResult { Success = false, ErrorCode = string.Empty };

            ServiceResult result = CommonFunction.ExecuteApiFunction(HttpMethod.POST, "invoicepublished", "invoicestatus", _token, lsttransactionID, _taxCode, IsInvoiceCode);

            if (result.Success && !string.IsNullOrEmpty(result.Data.ToString()))
            {
                oResult.Success = true;
                oResult.lstInvoiceStatus = SerializeUtil.DeserializeObject<List<InvoiceStatus>>(result.Data.ToString());
            }
            else
            {
                oResult.ErrorCode = result.ErrorCode;
            }
            return oResult;
        }

        public string GetLinkViewInvoice(string TransactionID)
        {
            ServiceResult resultTimeEncode = CommonFunction.ExecuteApiFunction(HttpMethod.GET, string.Format("{0}/GetRequestTimeEnCode", MeInvoiceFactory.MESearchURL));
            if (resultTimeEncode.Success && !string.IsNullOrEmpty(resultTimeEncode.Data.ToString()))
                return string.Format("{0}/DownloadHandler.ashx?Type=pdf&Viewer=1&ext={1}&Code={2}", MeInvoiceFactory.MEDownloadURL, resultTimeEncode.Data.ToString().Trim(), TransactionID);
            return null;
        }

        /// <summary>
        /// Hủy hóa đơn
        /// </summary>
        /// <param name="transId">Mã tra cứu hóa đơn cần hủy</param>
        /// <param name="cancelDate">Ngày hủy hóa đơn</param>
        /// <param name="cancelReason">Lý do hủy</param>
        /// <returns>Kết quả hủy: <see cref="Model.SDKResult.OperationResult.Success"/>=true && <see cref="Model.SDKResult.OperationResult.ErrorCode"/>==string.empty => thành công </returns>
        public Model.SDKResult.OperationResult CancelInvoice(string transId, System.DateTime cancelDate, string cancelReason, bool IsInvoiceCode = false)
        {
            OperationResult oResult = new InvoiceStatusResult { Success = false, ErrorCode = string.Empty };
            Model.Parameter.CancelInvoiceParamter paramter = new Model.Parameter.CancelInvoiceParamter() { TransactionID = transId, RefDate = cancelDate, CancelReason = cancelReason };
            ServiceResult result = CommonFunction.ExecuteApiFunction(HttpMethod.POST, "itg/invoicepublished", "cancel", _token, paramter, _taxCode, IsInvoiceCode);
            if (result.Success && string.IsNullOrEmpty(result.ErrorCode))
            {
                oResult.Success = true;
            }
            else
            {
                oResult.ErrorCode = result.ErrorCode;
            }
            return oResult;
        }

    }
}
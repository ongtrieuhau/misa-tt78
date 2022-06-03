using API3.SDK.Interface;
using API3.SDK.Model;
using API3.SDK.Model.Parameter;
using API3.SDK.Model.SDKResult;
using System.Collections.Generic;

namespace API3.SDK.Class
{
    internal class InvoicePublishing : IInvoicePublishing
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
        /// Phương thức khởi tạo đối tượng <see cref="InvoicePublishing"/>
        /// </summary>
        /// <param name="taxCode">Mã số thuế</param>
        /// <param name="token">Token của người dùng khi đăng nhập <seealso cref="IAuthen.GetToken(string, string, string, string)"/></param>
        internal InvoicePublishing(string taxCode, string token)
        {
            _taxCode = taxCode;
            _token = token;
        }

        #endregion Constructor

        #region Function

        public ListCreateInvoiceDataResult CreateInvoiceData(List<OriginalInvoiceData> originalInvoiceDatas, bool IsInvoiceCode = false)
        {
            ListCreateInvoiceDataResult oResult = new ListCreateInvoiceDataResult { Success = false, ErrorCode = string.Empty };
            ServiceResult result = CommonFunction.ExecuteApiFunction(HttpMethod.POST, "itg/invoicepublishing", "createinvoice", _token, originalInvoiceDatas, _taxCode, IsInvoiceCode);
            if (result.Success && !string.IsNullOrEmpty(result.Data.ToString()))
            {
                oResult.Success = true;
                oResult.CreateInvoiceDatas = SerializeUtil.DeserializeObject<List<CreateInvoiceData>>(result.Data.ToString());
            }
            else
            {
                oResult.ErrorCode = result.ErrorCode;
            }
            return oResult;
        }

        public ListInvoiceTemplateResult GetInvoiceTemplateForPublish(int invYear, bool IsInvoiceCode = false)
        {
            ListInvoiceTemplateResult oResult = new ListInvoiceTemplateResult { Success = false, ErrorCode = string.Empty };
            ServiceResult result = CommonFunction.ExecuteApiFunction(HttpMethod.GET, "itg/invoicepublishing", string.Format("templates?invYear={0}", invYear), _token, "", _taxCode, IsInvoiceCode);
            if (result.Success && !string.IsNullOrEmpty(result.Data.ToString()))
            {
                oResult.Success = true;
                oResult.TemplateDatas = SerializeUtil.DeserializeObject<List<TemplateData>>(result.Data.ToString());
            }
            else
            {
                oResult.ErrorCode = result.ErrorCode;
            }
            return oResult;
        }

        public LinkViewInvoiceResult GetLinkViewInvoiceUnPublish(OriginalInvoiceData originalInvoiceData, bool IsInvoiceCode = false)
        {
            LinkViewInvoiceResult oResult = new LinkViewInvoiceResult { Success = false, ErrorCode = string.Empty };
            ServiceResult result = CommonFunction.ExecuteApiFunction(HttpMethod.POST, "itg/invoicepublishing", "invoicelinkview?type=1", _token, originalInvoiceData, _taxCode, IsInvoiceCode);

            if (result.Success && !string.IsNullOrEmpty(result.Data.ToString()))
            {
                oResult.Success = true;
                oResult.LinkViewInvoice = result.Data.ToString();
            }
            else
            {
                oResult.ErrorCode = result.ErrorCode;
            }
            return oResult;
        }

        public ListPublishInvoiceResult PublishInvoice(List<PublishInvoiceData> publishInvoiceDatas, bool IsInvoiceCode = false)
        {
            ListPublishInvoiceResult oResult = new ListPublishInvoiceResult { Success = false, ErrorCode = string.Empty };

            ServiceResult result = CommonFunction.ExecuteApiFunction(HttpMethod.POST, "itg/invoicepublishing", "", _token, publishInvoiceDatas, _taxCode, IsInvoiceCode);

            if (result.Success && !string.IsNullOrEmpty(result.Data.ToString()))
            {
                oResult.Success = true;
                oResult.PublishInvoices = SerializeUtil.DeserializeObject<List<PublishInvoice>>(result.Data.ToString());
            }
            else
            {
                oResult.ErrorCode = result.ErrorCode;
            }
            return oResult;
        }

        #endregion Function
    }
}
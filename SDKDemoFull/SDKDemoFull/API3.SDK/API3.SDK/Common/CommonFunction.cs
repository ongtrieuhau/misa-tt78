using API3.SDK.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace API3.SDK
{
    /// <summary>
    /// Các hàm dùng chung
    /// </summary>
    internal class CommonFunction
    {
        /// <summary>
        /// Thực hiện gọi 1 hàm trên API Meinvoice
        /// </summary>
        /// <returns></returns>
        internal static ServiceResult ExecuteApiFunction(string method, string serviceName, string functionName, string token, object parameter, string taxcode, bool IsInvoiceCode = false)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                string strApiURL = String.Empty;
                if (IsInvoiceCode)
                {
                    strApiURL = MeInvoiceFactory.MECODEAPIV3URL;
                }
                else
                {
                    strApiURL = MeInvoiceFactory.MEAPIV3URL;
                }
                if (string.IsNullOrEmpty(functionName))
                {
                    strApiURL = string.Format("{0}/{1}", strApiURL, serviceName);
                }
                else
                {
                    strApiURL = string.Format("{0}/{1}/{2}", strApiURL, serviceName, functionName);
                }
                Dictionary<string, string> headers = new Dictionary<string, string>();
                if (!string.IsNullOrWhiteSpace(token))
                {
                    headers.Add(HeaderKey.Authorization, "Bearer " + token);
                }
                if (!string.IsNullOrEmpty(taxcode))
                {
                    headers.Add(HeaderKey.CompanyTaxCode, taxcode);
                }

                result = CallWebRequest<ServiceResult>(method, strApiURL, headers, parameter);
            }
            catch (Exception ex)
            {
                //throw ex;
                result.Success = false;
                result.ErrorCode = ex.Message;
                result.Errors.Add(ex.Message);
            }
            return result;
        }

        /// <summary>
        /// Thực hiện gọi 1 hàm trên API Meinvoice
        /// </summary>
        /// <returns></returns>
        internal static ServiceResult ExecuteApiFunction(string method, string apiURL, Dictionary<string, string> headers = null, object parameter = null)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result = CallWebRequest<ServiceResult>(method, apiURL, headers, parameter);
            }
            catch (Exception ex)
            {
                //throw ex;
                result.Success = false;
                result.ErrorCode = ex.Message;
                result.Errors.Add(ex.Message);
            }
            return result;
        }

        /// <summary>
        /// Gọi API
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="method"></param>
        /// <param name="api"></param>
        /// <param name="headers"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        internal static T CallWebRequest<T>(string method, string api, Dictionary<string, string> headers, object parameter)
        {
            T result = default(T);
            System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)(System.Net.WebRequest.Create(api));
            request.Method = method;
            request.KeepAlive = true;
            request.Timeout = 30000;
            request.ContentType = "application/json; charset=utf-8";
            if (headers != null)
            {
                foreach (var item in headers)
                {
                    request.Headers.Add(item.Key, item.Value);
                }
            }
            if (method.ToLower() != System.Net.WebRequestMethods.Http.Get.ToLower() && parameter != null)
            {
                string strParam = SerializeUtil.SerializeObject(parameter);
                byte[] byteArray = (new System.Text.UTF8Encoding()).GetBytes(strParam);
                request.ContentLength = byteArray.Length;
                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }
            }

            using (System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)(request.GetResponse()))
            {
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                    {
                        string resultstring = sr.ReadToEnd();
                        if (!(string.IsNullOrWhiteSpace(resultstring)))
                        {
                            result = SerializeUtil.DeserializeObject<T>(resultstring);
                        }
                    }
                }
            }
            return result;
        }
    }
}
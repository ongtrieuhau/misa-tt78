using API3.SDK.Interface;
using API3.SDK.Model;
using API3.SDK.Model.Parameter;
using API3.SDK.Model.SDKResult;

namespace API3.SDK.Class
{
    internal class Authen : IAuthen
    {
        public GetTokenOperationResult GetToken(string appID, string taxCode, string userName, string password)
        {
            GetTokenOperationResult oResult = new GetTokenOperationResult { Success = false, Token = string.Empty, ErrorCode = string.Empty };
            GetTokenParameter oParam = new GetTokenParameter { AppID = appID, TaxCode = taxCode, UserName = userName, Password = password };
            ServiceResult result = CommonFunction.ExecuteApiFunction(HttpMethod.POST, "auth", "token", "", oParam, taxCode);
            if (result.Success && !string.IsNullOrEmpty(result.Data.ToString()))
            {
                oResult.Success = true;
                oResult.Token = result.Data.ToString();
            }
            else
            {
                oResult.Data = result.Data.ToString();
                oResult.ErrorCode = result.ErrorCode;
                oResult.Errors = result.Errors;
                oResult.CustomData = result.CustomData;
            }
            return oResult;
        }

        public GetTokenOperationResult RefreshToken(string token)
        {
            GetTokenOperationResult oResult = new GetTokenOperationResult { Success = false, Token = string.Empty, ErrorCode = string.Empty };
            ServiceResult result = CommonFunction.ExecuteApiFunction(HttpMethod.POST, "auth", "refreshtoken", "", token, "");
            if (result.Success && !string.IsNullOrEmpty(result.Data.ToString()))
            {
                oResult.Success = true;
                oResult.Token = result.Data.ToString();
            }
            else
            {
                oResult.ErrorCode = result.ErrorCode;
                oResult.Errors = result.Errors;
            }
            return oResult;
        }

        public GetTokenOperationResult TwoFactorAuthorize(string code, string taxCode, string userName, string userId, string deviceId, bool hasAuthenticator, bool remember, string appID)
        {
            GetTokenOperationResult oResult = new GetTokenOperationResult { Success = false, Token = string.Empty, ErrorCode = string.Empty };
            MisaIDRegisterParameter oParam = new MisaIDRegisterParameter
            {
                TaxCode = taxCode,
                Username = userName,
                UserId = userId,
                AppID = appID,
                Code = code,
                DeviceId = deviceId,
                HasAuthenticator = hasAuthenticator,
                Remember = remember
            };
            ServiceResult result = CommonFunction.ExecuteApiFunction(HttpMethod.POST, "auth", "twofactorauth", "", oParam, "");
            if (result != null)
            {
                if (result.Success)
                {
                    oResult.Success = true;
                    oResult.Token = result.Data.ToString();
                }
                else
                {
                    oResult.ErrorCode = result.ErrorCode;
                    oResult.Errors = result.Errors;
                }
            }
            return oResult;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API3.SDK.Model.SDKResult
{
    public class OperationResult
    {
        /// <summary>
        /// Dữ liệu trả về
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        /// Trạng thái (thành công = true)
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Mã lỗi
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Thông báo: thường là thông báo lỗi
        /// </summary>
        public System.Collections.Generic.List<string> Errors { get; set; }

        /// <summary>
        /// Dữ liệu cấu hình riêng nếu có
        /// </summary>
        public string CustomData { get; set; }
    }
}

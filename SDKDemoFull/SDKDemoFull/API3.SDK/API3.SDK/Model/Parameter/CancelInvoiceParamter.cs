using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API3.SDK.Model.Parameter
{
    /// <summary>
    /// Đối tượng hủy hóa đơn
    /// </summary>
    public class CancelInvoiceParamter
    {
        /// <summary>
        /// TransactionID
        /// </summary>
        public string TransactionID { get; set; }

        /// <summary>
        /// Ngày hủy hóa đơn
        /// </summary>
        public DateTime RefDate { get; set; }

        /// <summary>
        /// Lý do hủy
        /// </summary>
        public string CancelReason { get; set; }
    }
}

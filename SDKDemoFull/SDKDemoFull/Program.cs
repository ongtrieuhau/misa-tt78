using API3.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDKDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //gán link môi trường cho SDK call APi (mặc định: môi trường thật).
            //Link api hóa đơn không mã cơ quan thuế.
            MeInvoiceFactory.MEAPIV3URL = "https://testapi.meinvoice.vn/api/v3";
            //Link API hóa đơn có mã cơ quan thuế.
            MeInvoiceFactory.MECODEAPIV3URL = "https://testapi.meinvoice.vn/api/v3/code";
            //Link dowload hóa đơn
            MeInvoiceFactory.MEDownloadURL = "https://testdownload.meinvoice.vn";
            //Link tra cứu và get link tra cứu hóa đơn.
            MeInvoiceFactory.MESearchURL = "https://test.meinvoice.vn/tra-cuu";

            ////gán link môi trường cho SDK call APi (mặc định: môi trường thật).
            ////Link api hóa đơn không mã cơ quan thuế.
            //MeInvoiceFactory.MEAPIV3URL = "https://api.meinvoice.vn/api/v3";
            ////Link API hóa đơn có mã cơ quan thuế.
            //MeInvoiceFactory.MECODEAPIV3URL = "https://api.meinvoice.vn/api/v3/code";
            ////Link dowload hóa đơn
            //MeInvoiceFactory.MEDownloadURL = "https://download.meinvoice.vn";
            ////Link tra cứu và get link tra cứu hóa đơn.
            //MeInvoiceFactory.MESearchURL = "https://meinvoice.vn/tra-cuu";

            AppContext.SetSwitch("Switch.System.Security.Cryptography.Xml.UseInsecureHashAlgorithms", true);
            AppContext.SetSwitch("Switch.System.Security.Cryptography.Pkcs.UseInsecureHashAlgorithms", true);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());

           

        }
    }
}

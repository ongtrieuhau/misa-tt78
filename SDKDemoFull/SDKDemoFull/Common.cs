using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKDemo
{
    public class Common
    {
        const string MesageBoxCaption = "MISA meInvocie Demo";

        internal static void ShowMessage(string message)
        {
            System.Windows.Forms.MessageBox.Show(message, MesageBoxCaption);
        }
        internal static void ShowException(Exception ex)
        {
            System.Windows.Forms.MessageBox.Show(ex.ToString(), MesageBoxCaption);
        }
    }
}

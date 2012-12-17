using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace YongShuiGuanLiV2
{
    public class JavaScriptHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        static public string GetAlertScript(string p)
        {
            string s = "<script type=\"text/javascript\"> alert('{0}'); </script>";
            s = string.Format (s, p);

            return s;
        }
    }
}

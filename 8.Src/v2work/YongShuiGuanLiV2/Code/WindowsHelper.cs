using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace YongShuiGuanLiV2
{
    /// <summary>
    /// 
    /// </summary>
    public class WindowsHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        static public void OpenInNewWindows(HttpResponse response, string url)
        {
            string s = string.Format(
                "<script type='text/javascript' language='javascript'>window.open('{0}')</script>", 
                url);
            response.Write(s);
        }
    }
}

using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace YongShuiGuanLiV2.map_query
{
    public class basepage : System.Web.UI.Page
    {
        private static String pageSecureUrlBase;
        private static String pageUrlBase;
        private static String urlSuffix;
        public basepage()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
            try
            {
                //				ApplicationConfig.OnApplicationStart(Context.Server.MapPath( Context.Request.ApplicationPath ));
                urlSuffix = Context.Request.Url.Host + Context.Request.ApplicationPath;
                pageUrlBase = @"http://" + urlSuffix;
            }
            catch
            {

            }
        }
        public static String SecureUrlBase
        {
            get
            {
                pageSecureUrlBase = @"http://" + urlSuffix;

                //				if (pageSecureUrlBase == null )
                //				{
                //					pageSecureUrlBase = (CurrentConfig.EnableSsl ? @"https://": @"http://") + urlSuffix;
                //				}
                return pageSecureUrlBase;
            }
        }
    }
}

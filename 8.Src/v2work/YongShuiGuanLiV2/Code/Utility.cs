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
    public class Utility
    {
        /// <summary>
        /// 
        /// </summary>
        static public bool CheckLogin()
        {
            if (SessionManager.LoginSession.WaterUser == null)
            {
                System.Web.Security.FormsAuthentication.SignOut();
                System.Web.Security.FormsAuthentication.RedirectToLoginPage();
                return false;
            }
            return true;
        }
    }
}

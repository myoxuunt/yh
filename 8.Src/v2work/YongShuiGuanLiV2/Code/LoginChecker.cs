using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace YongShuiGuanLiV2.Code
{
    /// <summary>
    /// 
    /// </summary>
    public class LoginChecker
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public bool Check()
        {
            if (SessionManager.LoginSession.WaterUser == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        static public void CheckAndRedirect()
        {
            if (!Check())
            {
                FormsAuthentication.SignOut();
                FormsAuthentication.RedirectToLoginPage();
            }
        }
    }
}

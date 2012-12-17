using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using YongShuiGuanLiDBI;

namespace YongShuiGuanLiV2Manage
{
    public partial class login : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Login1_LoggingIn(object sender, LoginCancelEventArgs e)
        {
            Trace.Warn("logging in");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string userName = this.Login1.UserName;
            string pwd = this.Login1.Password;

            // admin login
            // 
            if (userName == "admin")
            {
                if (pwd == "admin")
                {
                    //WaterUserLevel level = WaterUserLevelFactory.CreateWaterLevel(WaterUserLevelEnum.Ju);
                    ////SessionManager.WaterUserSession.WaterUser = WaterUserFactory.CreateWaterUser(level);
                    //SessionManager.LoginSession.WaterUser = WaterUserFactory.CreateWaterUser(level);
                    e.Authenticated = true;
                }
                return;
            }

            //int userID, waterUserID;
            //bool b = UserDBI.CanLogin(userName, pwd, out userID, out waterUserID);

            ////if (b)
            ////{
            ////    LoginSession ls = SessionManager.LoginSession;
            ////    ls.LoginUserName = userName;
            ////    ls.LoginUserID = userID;
            ////    ls.WaterUser = WaterUserFactory.CreateWaterUserByID(waterUserID);
            ////}

            //e.Authenticated = b;
            //Trace.Warn("authenticate : " + b.ToString());
        }
    }
}

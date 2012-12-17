using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace YongShuiGuanLiV2
{

    /// <summary>
    /// 
    /// </summary>
    public class Global : System.Web.HttpApplication
    {

        /// <summary>
        /// 
        /// </summary>
        static private NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();

        protected void Application_Start(object sender, EventArgs e)
        {
            //log.Debug("start");
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            //log.FatalException("Application_Error", ex.ToString ());
            log.Fatal(ex);
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}
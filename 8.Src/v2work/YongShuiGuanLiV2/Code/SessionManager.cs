using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Xdgk.Common;
using YongShuiGuanLiDBI;

namespace YongShuiGuanLiV2
{
    /// <summary>
    /// 
    /// </summary>
    public class SessionManager
    {

        const string CHANNELSESSION = "ChannelSession";
        /// <summary>
        /// 
        /// </summary>
        static public ChannelSession ChannelSession
        {
            get
            {
                object obj = HttpContext.Current.Session[CHANNELSESSION];
                if (obj == null)
                {
                    HttpContext.Current.Session[CHANNELSESSION] = new ChannelSession();
                    return SessionManager.ChannelSession;
                }
                else
                {
                    return obj as ChannelSession;
                }
            }
        }

        //const string WATERUSERSESSION = "WaterUserSession";
        ///// <summary>
        ///// for add or edit water, in diff page
        ///// </summary>
        //static public WaterUserSession WaterUserSession
        //{
        //    get
        //    {
        //        object obj = HttpContext .Current .Session [WATERUSERSESSION];
        //        if (obj == null)
        //        {
        //            HttpContext.Current.Session[WATERUSERSESSION] = new WaterUserSession();
        //            return SessionManager.WaterUserSession;
        //        }
        //        else
        //        {
        //            return obj as WaterUserSession;
        //        }
        //    }
        //}


        const string LOGINSESSION = "LoginSession";
        /// <summary>
        /// 
        /// </summary>
        static public LoginSession LoginSession
        {
            get 
            {
                object obj = HttpContext.Current.Session[LOGINSESSION];
                if (obj == null)
                {
                    HttpContext.Current.Session[LOGINSESSION] = new LoginSession();
                    return SessionManager.LoginSession;
                }
                else
                {
                    return obj as LoginSession;
                }
            }
        }




        /// <summary>
        /// 
        /// </summary>
        const string CHARTSESSION = "ChartSession";
        /// <summary>
        /// 
        /// </summary>
        static public ChartSession ChartSession
        {
            get
            {
                object obj = HttpContext.Current.Session[CHARTSESSION];
                if (obj == null)
                {
                    HttpContext.Current.Session[CHARTSESSION] = new ChartSession();
                    return SessionManager.ChartSession;
                }
                else
                {
                    return obj as ChartSession;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        const string CHARTSESSIONMANAGER = "ChartSessionManager";
        /// <summary>
        /// 
        /// </summary>
        static public ChartSessionManager ChartSessionManager
        {
            get
            {
                object obj = HttpContext.Current.Session[CHARTSESSIONMANAGER];
                if (obj == null)
                {
                    HttpContext.Current.Session[CHARTSESSIONMANAGER] = new ChartSessionManager();
                    return SessionManager.ChartSessionManager;
                }
                else
                {
                    return obj as ChartSessionManager;
                }
            }
        }
    }
}

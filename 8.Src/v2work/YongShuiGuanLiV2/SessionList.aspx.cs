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

namespace YongShuiGuanLiV2
{
    public partial class SessionList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (string key in this.Session.Keys)
            {
                string s = string.Format("'{0}' -> '{1}'",key, Session[key]);
                Response.Write(s);
                Response.Write("<br/>");

            }

            foreach (string key in this.Request.Cookies.Keys)
            {
                string s = string.Format("'{0}' -> '{1}'",key, Request.Cookies[key]);
                Response.Write(s);
                Response.Write("<br/>");
            }
        }
    }
}

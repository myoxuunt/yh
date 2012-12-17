using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace YongShuiGuanLiV2
{
    public partial class pGis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string t = "地理信息系统";
            MasterPageHelper.SetTitle(this, t);
        }
    }
}

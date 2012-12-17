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
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MasterPageHelper.SetTitle(this, "About");
            this.lblAbout.Text = "YongShuiGuanLiV2 V1.5.0.0";
        }
    }
}

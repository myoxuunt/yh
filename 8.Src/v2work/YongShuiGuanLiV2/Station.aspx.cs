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
    public partial class Station : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //this.form1.Visible = false;
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            object obj = this.ViewState["v"];
            if (obj == null)
            {
                this.ViewState["v"] = true;
            }
            bool b = (bool)this.ViewState["v"];
            this.Panel1.Visible = !b;
            this.ViewState["v"] = !b;
        }
    }
}

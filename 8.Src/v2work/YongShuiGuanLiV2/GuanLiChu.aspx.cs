﻿using System;
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
    public partial class GuanLiChu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.HyperLink1.NavigateUrl = "http://www.baidu.com";
        }
    }
}

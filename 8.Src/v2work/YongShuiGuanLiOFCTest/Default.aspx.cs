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

namespace YongShuiGuanLiOFCTest
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //this.OpenFlashChartControl1.DataFile = "ChartData/RealData.aspx";
            this.OpenFlashChartControl1.ExternalSWFfile = "open-flash-chart-SimplifiedChinese.swf";
            //this.OpenFlashChartControl1.ExternalSWFObjectFile = ""
            this.OpenFlashChartControl1.DataFile = "ChartData/RealDataUseWebChartDLL.aspx";
        }
    }
}
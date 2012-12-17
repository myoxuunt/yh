using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace YongShuiGuanLiV2
{
    /// <summary>
    /// 
    /// </summary>
    public class PageNames
    {
        public const string 
            ChannelSelect = "ChannelSelect.aspx",
            WaterUser = "WaterUser.aspx",
            ChartCommData = "ChartData/ChartCommonData.aspx";
    }

    /// <summary>
    /// 
    /// </summary>
    public class SessionChartName
    {
        public const string
            P2Hour = "p2hour",
            PDuringWL = "pDuringWL",
            PDuringFlux = "pDuringFlux",
            PDuringAmount = "pDuringAmount",

            PReal = "pReal"
            ;
    }
}

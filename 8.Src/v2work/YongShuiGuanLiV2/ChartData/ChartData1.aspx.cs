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
using WebChart;

namespace YongShuiGuanLiV2.ChartData
{
    public partial class ChartData1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i = 1 - 1;
            ChartSession cs = SessionManager.ChartSessionManager.GetChartSession(i);
            LineChartConfig cfg = cs.ChartConfig as LineChartConfig;

            ChartFactory f = new ChartFactory();
            OpenFlashChart.OpenFlashChart chart = f.Create(cs.DataSource as DataTable, cfg);
            Response.Write(chart.ToString());
        }
    }
}

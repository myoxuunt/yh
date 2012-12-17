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
using YongShuiGuanLiDBI;

namespace YongShuiGuanLiOFCTest.ChartData
{
    public partial class RealDataUseWebChartDLL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable tbl = DitchDataReal.GetDitchDataRealDataTable();
            f2(tbl);
        }


        /// <summary>
        /// 
        /// </summary>
        private void f2(DataTable tbl)
        {
            LineChartConfig cfg = new LineChartConfig(
            "use line chart config",
             "x title(X轴承)",
             "Y title(Y轴承)",
            "DT");
            //cfg.XSegmentCount 

            LineDataConfig ldc = new LineDataConfig("line1", "wl1","#00ff00");

            LineDataConfig ldc2 = new LineDataConfig("line2", "wl2", "#0000ff");
            //ldc2.Name = "line2";
            //ldc2.DataFieldName = "wl2";

            cfg.LineDataConfigCollection.Add(ldc);
            cfg.LineDataConfigCollection.Add(ldc2);


            OpenFlashChart.OpenFlashChart chart = new ChartFactory().Create(tbl, cfg);
            Response.Write(chart.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        private void f1(DataTable tbl)
        {
            WebChartConfig wcConfig = new WebChartConfig();

            //DataTable tbl = DitchDataReal.GetDitchDataRealDataTable();

            ChartDataConfig item = CreateChartDataConfig(tbl, "wl1");
            ChartDataConfig item1 = CreateChartDataConfig(tbl,"wl2");

            wcConfig.Title = "webchartdll";
            wcConfig.TipFormat = "";
            wcConfig.ChartDataConfigCollection.Add(item);
            wcConfig.ChartDataConfigCollection.Add(item1);
            //OpenFlashChart.OpenFlashChart chart = new OpenFlashChart.OpenFlashChart();

            Response.Write(wcConfig.Create());

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tbl"></param>
        /// <returns></returns>
        private static ChartDataConfig CreateChartDataConfig(DataTable tbl, string name)
        {
            ChartDataConfig item = new ChartDataConfig();
            item.DataSource = tbl;
            item.DataFieldName = name;
            return item;
        }
    }
}

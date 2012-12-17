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
    public partial class ChartCommonData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ChartSession cs = SessionManager.ChartSession;
            if (!cs.IsEmpty())
            {
                LineChartConfig cfg = cs.ChartConfig as LineChartConfig;
                if (cs.Name == SessionChartName.P2Hour ||
                    cs.Name == SessionChartName.PDuringWL ||
                    cs.Name == SessionChartName.PDuringFlux ||
                    cs.Name == SessionChartName.PDuringAmount)
                {
                    CreateLineConfig(cfg, cs.DataSource);
                    //LineChartConfig cfg = Create(cs.DataSource);
                }

                //if (cs.Name == SessionChartName.PDuringWL)
                //{
                //    LineChartConfig cfg = cs.ChartConfig as LineChartConfig;
                //    CreateLineConfig(cfg, cs.DataSource);
                //}
                //if (cs.Name == "...")
                //{
                
                //}

                ChartFactory f = new ChartFactory();
                OpenFlashChart.OpenFlashChart chart = f.Create(cs.DataSource as DataTable, cfg);
                Response.Write(chart.ToString());
            }
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="cfg"></param>
        ///// <param name="p"></param>
        //private void CreateLineConfigPDuring(LineChartConfig cfg, object dataSource)
        //{
        //    DataTable tbl = dataSource as DataTable;
        //    ColorProvider cp = new ColorProvider();
        //    for( int i=1;
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private void CreateLineConfig(LineChartConfig cfg, object datasource)
        {

            //  tbl 表格样式
            // ----------------------------------------------------------
            //  DT                  | st1   | st2   | st3   | st4   | ...
            // ----------------------------------------------------------
            // 2011-1-1 12:00:00    | 12    | 23    | 17    | 5     | ...
            // 2011-1-1 12:00:00    | 12    | 23    | 17    | 5     | ...
            // 2011-1-1 12:00:00    | 12    | 23    | 17    | 5     | ...
            // ...
            // 
            // st   - 站名称
            //
            DataTable tbl = datasource as DataTable;
            ColorProvider cp = new ColorProvider();

            // create line data configs
            // 生成除第一列(时间列)意外的所有列的曲线配置
            // 
            for( int i=1; i<tbl.Columns.Count ;i++)
            {
                DataColumn col = tbl.Columns[i];
                string name = col.ColumnName;
                LineDataConfig ldcfg = new LineDataConfig(name, name, cp.GetNextColorString());
                cfg.LineDataConfigCollection.Add (ldcfg);
            }
        }
    }
}

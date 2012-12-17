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

namespace YongShuiGuanLiV2.UC
{
    public partial class UCCharList : System.Web.UI.UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                UCChart uc = this.GetUCChartByNO(i);
                uc.Hide();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public void Bind()
        {
            ChartSession cs = SessionManager.ChartSession;
            DataTable[] tbls = cs.DataSource as DataTable[];

            
            int no = 0;
            foreach (DataTable tbl in tbls)
            {
                LineChartConfig cfg = new LineChartConfig(
                    tbl.TableName,
                    "时间",
                    "水位....",
                    "DT");

                LineDataConfig item = new LineDataConfig(
                    tbl.TableName, "wl1", new ColorProvider().GetNextColorString());
                cfg.LineDataConfigCollection.Add(item);

                ChartSessionManager manager = SessionManager.ChartSessionManager;
                ChartSession itemcs = manager.GetChartSession(no);
                itemcs.ChartConfig = cfg;
                itemcs.DataSource = tbl;

                UCChart uc = GetUCChartByNO(no);
                uc.Bind(GetChartDataPageName(no));
                uc.Show();
                //this.Controls.Add(uc);
                no++;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        public UCChart GetUCChartByNO(int no)
        {
            UCChart[] chartList = new UC.UCChart[] 
            {
                this.UCChart1,
                this.UCChart2
            };
            return chartList[no];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        private string GetChartDataPageName(int no)
        {
            return "ChartData/ChartData" + (no + 1) + ".aspx";
        }
    }
}
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
using YongShuiGuanLiDBI;

namespace YongShuiGuanLiV2
{
    public partial class pCompareAmountWithWaterUser : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UCCompareWithWaterUser1.QueryEvent += new EventHandler(UCCompareWithWaterUser1_QueryEvent);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCCompareWithWaterUser1_QueryEvent(object sender, EventArgs e)
        {
            Query();
        }

        /// <summary>
        /// 
        /// </summary>
        private void Query()
        {
            WaterUserCollection wus = this.UCCompareWithWaterUser1.SelectedWaterUserCollection;
            DateTime begin = this.UCCompareWithWaterUser1.Begin ;
            DateTime end = this.UCCompareWithWaterUser1 .End ;
            DataTable tbl = wus.CalcUsedWaterAmount(begin, end);


            string title = GetTitle(begin, end);
            this.UCAMChart1.SetColumnChartInfo(tbl, "WaterUserName", 
                "UsedAmount", "Begin", "", title , "");

            this.GridView1.DataSource = tbl;
            this.GridView1.DataBind();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string GetTitle(DateTime begin, DateTime end)
        {
            string s = string.Format("{0} ~ {1} 用水量对比",
                begin, end);
            return s;
        }
    }
}

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
    public partial class pDuringAmount : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UCConditionDTTwo1.QueryEvent += new EventHandler(UCConditionDTTwo1_QueryEvent);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCConditionDTTwo1_QueryEvent(object sender, EventArgs e)
        {
            if (IsValid)
            {
                DateTime begin = this.UCConditionDTTwo1.Begin;
                DateTime end = this.UCConditionDTTwo1.End;

                StationCollection stations = this.UCConditionDTTwo1.Stations;
                DataTable tbl = DitchDataDayDBI.GetDayDataTable(begin, end, stations.GetStationNames(), DataEnum.Amount);
                this.GridView1.DataSource = tbl;
                this.GridView1.DataBind();
            }
        }
    }
}

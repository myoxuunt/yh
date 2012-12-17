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
    /// <summary>
    /// 单个测点年用水量汇总表
    /// </summary>
    public partial class pYearAmount : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
                MasterPageHelper.SetTitle(this, Titles.YearAmount);
            this.UCConditionYear1.QueryEvent += new EventHandler(UCConditionYear1_QueryEvent);
            if (!IsPostBack)
            {
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCConditionYear1_QueryEvent(object sender, EventArgs e)
        {
            if (IsValid)
            {
                int year = this.UCConditionYear1.Year ;
                // TODO:
                //
                DeviceClass device = this.UCConditionYear1.Station.DeviceCollection[0];
                DataTable tbl = DitchDataYearDBI.ExecuteYearDataTable(year, device, DataEnum.Amount);
                this.GridView1.DataSource = tbl;
                this.GridView1.DataBind();
            }
        }
    }
}

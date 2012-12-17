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
using Xdgk.UI;

namespace YongShuiGuanLiV2
{
    public partial class pYear : System.Web.UI.Page
    {
        #region H
        /// <summary>
        ///
        /// 
        /// </summary>
        private Xdgk.UI.GridViewHelper H
        {
            get
            {
                if (_h == null)
                {
                    _h = new Xdgk.UI.GridViewHelper(this.GridView1);
                    if (!_h.IsSetGridViewConfig())
                    {
                        _h.GridViewConfig = GetGridViewConfig();
                    }
                }
                return _h;
            }
        } Xdgk.UI.GridViewHelper _h;
        #endregion //H

        #region GetGridViewConfig
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private GridViewConfig GetGridViewConfig()
        {
            GridViewConfig c = new GridViewConfig();
            //c.GridViewColumnConfigCollection.AddBoundField("", "");
            c.AutoGenerateColumns = false;
            c.GridViewColumnConfigCollection.AddBoundField("日期", "Day");
            for (int i = 1; i <= 12; i++)
            {
                string f = string.Format("m{0}", i);
                string h = string.Format("{0}月", i);

                c.GridViewColumnConfigCollection.AddBoundField(h, f); 
            }

            return c;
        }
        #endregion //GetGridViewConfig

        #region DataEnum
        /// <summary>
        /// 
        /// </summary>
        public DataEnum DataEnum
        {
            get
            {
                return DataEnumClass.GetDataEnumFromQueryString(this.Request.QueryString,
                    QueryStringNames.DataEnum);
            }
        }
        #endregion //DataEnum


        #region Page_Load
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {string t = null;
                if (this.DataEnum == DataEnum.WL)
                {
                    t = Titles.YearWL;
                }
                else if (this.DataEnum == DataEnum.Amount)
                {
                    t = Titles.YearAmount ;
                }
                else if (this.DataEnum == DataEnum.Flux)
                {
                    t = Titles.YearFlux;
                }
                MasterPageHelper.SetTitle(this, t);
            this.UCConditionYear1.QueryEvent += new EventHandler(UCConditionYear1_QueryEvent);

            //this.Title = DataEnumClass.GetDataEnumString(this.DataEnum);
            if (!IsPostBack)
            {
                
            }
        }
        #endregion //Page_Load


        #region UCConditionYear1_QueryEvent
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCConditionYear1_QueryEvent(object sender, EventArgs e)
        {
            if (IsValid)
            {
                int year = this.UCConditionYear1.Year;
                StationClass station = this.UCConditionYear1.Station;
                if (station.DeviceCollection.Count > 0)
                {
                    DeviceClass device = station.DeviceCollection[0];

                    DataTable tbl = DitchDataYearDBI.ExecuteYearDataTable(year, device, this.DataEnum);

                    H.DataSource = tbl;
                    H.Bind();
                    //this.GridView1.DataSource = tbl;
                    //this.GridView1.DataBind();
                }
            }
        }
        #endregion //UCConditionYear1_QueryEvent
    }
}

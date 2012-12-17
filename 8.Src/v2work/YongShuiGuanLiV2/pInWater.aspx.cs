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
using Xdgk.UI;
using YongShuiGuanLiDBI;
using Xdgk.UI.Z;

namespace YongShuiGuanLiV2
{
    public partial class pInWater : System.Web.UI.Page
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
            c.GridViewColumnConfigCollection.AddBoundField(strings.StationName, YongShuiGuanLiDBI.DBNames.vDitchDataDay.StationName);
            c.GridViewColumnConfigCollection.AddBoundField(strings.DT, YongShuiGuanLiDBI.DBNames.vDitchDataDay.DT);
            c.GridViewColumnConfigCollection.AddBoundField(strings.Amount, YongShuiGuanLiDBI.DBNames.vDitchDataDay.DayAmount);
            return c;
        }
        #endregion //GetGridViewConfig

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            MasterPageHelper.SetTitle(this, Titles.InWater);
            this.UCDTTwoOnly1.QueryEvent += new EventHandler(UCDTTwoOnly1_QueryEvent);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCDTTwoOnly1_QueryEvent(object sender, EventArgs e)
        {
            DateTime b = UCDTTwoOnly1.Begin;
            DateTime end = UCDTTwoOnly1.End;

            WaterUserClass wu = SessionManager.LoginSession.WaterUser;
            if (wu != null)
            {
                if (wu.InDeviceCollection.Count > 0)
                {
                    DataTable tbl = wu.InDeviceCollection[0].GetDayDitchData(b, end);
                    this.H.DataSource = tbl;
                    this.H.Bind();

                    this.UCZedChart1.GraphPaneConfig = GetGraphPaneConfig();
                    this.UCZedChart1.DataSource = tbl;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Xdgk.UI.Z.GraphPaneConfig GetGraphPaneConfig()
        {
            GraphPaneConfig cfg = new GraphPaneConfig();
            cfg.Title = "来水量曲线";
            cfg.XTitle = strings.DT;
            cfg.YTitle = strings.AmountWithUnit;

            MultiCurveConfig item = new MultiCurveConfig();
            item.NameField = YongShuiGuanLiDBI.DBNames.vDitchDataDay.StationName;
            item.XDataField = YongShuiGuanLiDBI.DBNames.vDitchDataDay.DT;
            item.YDataField = YongShuiGuanLiDBI.DBNames.vDitchDataDay.DayAmount;

            cfg.CurveConfigBaseCollection.Add(item);
            return cfg;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using YongShuiGuanLiDBI;
using WebChart;
using Xdgk.UI.Z;
using Xdgk.UI;

namespace YongShuiGuanLiV2
{
    /// <summary>
    /// 
    /// </summary>
    public partial class pReal : System.Web.UI.Page
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
                    _h = new Xdgk.UI.GridViewHelper(this.gvLast);
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
            Xdgk.UI.GridViewConfig cfg = new Xdgk.UI.GridViewConfig();
            cfg.AutoGenerateColumns = false;
            cfg.AllowSorting = true;
            cfg.Caption = "LastDataCaption";
            cfg.GridViewColumnConfigCollection.AddHyperLinkField(
                "",
                strings.Detail,
                new string[] { YongShuiGuanLiDBI.DBNames.vDitchDataLast.StationID },
                "~/pDataHistory.aspx?StationID={0}"
                );

            cfg.GridViewColumnConfigCollection.AddBoundField(strings.StationName,
                YongShuiGuanLiDBI.DBNames.vDitchData.StationName);

            cfg.GridViewColumnConfigCollection.AddBoundField(strings.DT, YongShuiGuanLiDBI.DBNames.vDitchData.DT);
            cfg.GridViewColumnConfigCollection.AddBoundField(strings.WL1, YongShuiGuanLiDBI.DBNames.vDitchData.WL1);
            cfg.GridViewColumnConfigCollection.AddBoundField(strings.InstantFlux, YongShuiGuanLiDBI.DBNames.vDitchData.InstantFlux);
            return cfg;
            
        }
        #endregion //GetGridViewConfig


        #region Page_Load
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            MasterPageHelper.SetTitle(this, Titles.RealData);

            WaterUserClass wu = SessionManager.LoginSession.WaterUser;
            if (wu != null)
            {
                this.UCZedChart1.GraphPaneConfig = GetZedGraphConfig();
                this.UCZedChart1.DataSource = wu.GetDitchDataRealDataTable();

                H.DataSourceDelegate = GetLastDataTable;
                if (!IsPostBack)
                {
                    Query();
                }
            }
        }
        #endregion //Page_Load


        #region GetLastDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private DataTable GetLastDataTable()
        {
            WaterUserClass wu = SessionManager.LoginSession.WaterUser ;
            if( wu != null )
            {
                DataTable tbl = wu.GetDitchDataLastDataTable();
                return tbl;
            }
            return null;
        }
        #endregion //GetLastDataTable


        #region btnRefresh_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            Query();
        }
        #endregion //btnRefresh_Click


        #region Query
        /// <summary>
        /// 
        /// </summary>
        private void Query()
        {
            H.Bind();

            //this.gvLast.DataSource = DitchDataLastDBI.GetDataTable();
            //this.gvLast.DataBind();

            //this.UCZedChart1.SetTable(tbl);
            //this.UCZedChart1.Setconfig(GetConfig());
            //this.UCZedChart1.DataSource = tbl;

            DataTable tbl = SessionManager.LoginSession.WaterUser.GetDitchDataRealDataTable();
            //UCAMChart1.SetLineChartInfo(tbl, "StationName", "DT", "WL1");
        }
        #endregion //Query


        #region GetZedGraphConfig
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Xdgk.UI.Z.GraphPaneConfig GetZedGraphConfig()
        {
            MultiCurveConfig curveCfg = new MultiCurveConfig();
            curveCfg.NameField = YongShuiGuanLiDBI.DBNames.vDitchData.StationName;
            curveCfg.XDataField = YongShuiGuanLiDBI.DBNames.vDitchData.DT;
            curveCfg.YDataField = YongShuiGuanLiDBI.DBNames.vDitchData.WL1;

            GraphPaneConfig c = new GraphPaneConfig();
            c.Title = "实时水位曲线";
            c.XTitle = "时间";
            c.YTitle = "水位(cm)";
            c.XAxisType = ZedGraph.AxisType.Date;
            c.CurveConfigBaseCollection.Add(curveCfg);

            return c;
        }
        #endregion //GetZedGraphConfig
    }
}

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
//using WebChart;
using Xdgk.UI;

using Xdgk.UI.Z;

namespace YongShuiGuanLiV2
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 阶段水位 流量 用水量, 
    /// 行 - 日期 
    /// 列 - 站点
    /// </remarks>
    public partial class pDuring : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        static NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();


        //#region H
        ///// <summary>
        /////
        ///// 
        ///// </summary>
        //private Xdgk.UI.GridViewHelper H
        //{
        //    get
        //    {
        //        if (_h == null)
        //        {
        //            _h = new Xdgk.UI.GridViewHelper(this.GridView1);
        //            if (!_h.IsSetGridViewConfig())
        //            {
        //                _h.GridViewConfig = GetGridViewConfig();
        //            }
        //        }
        //        return _h;
        //    }
        //} Xdgk.UI.GridViewHelper _h;
        //#endregion //H

        //#region GetGridViewConfig
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //private GridViewConfig GetGridViewConfig()
        //{
        //    GridViewConfig c = new GridViewConfig();

        //    return c;
        //}
        //#endregion //GetGridViewConfig

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tbl"></param>
        /// <returns></returns>
        private GridViewConfig GetGridViewConfig(DataTable tbl)
        {
            GridViewConfig cfg = new GridViewConfig();
            GridViewColumnConfig colCfg = cfg.GridViewColumnConfigCollection.AddBoundField(strings.DT, "DT");
            colCfg.DataFormatString = "{0:yyyy-MM-dd}";

            for (int i = 1; i < tbl.Columns.Count; i++)
            {
                DataColumn col = tbl.Columns[i];
                cfg.GridViewColumnConfigCollection.AddBoundField(col.ColumnName, col.ColumnName);
            }

            return cfg;
        }

        #region Page_Load
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = null;
            if (this.DataEnum == DataEnum.WL)
            {
                s = Titles.DuringWL;
            }
            else if (this.DataEnum == DataEnum.Amount)
            {
                s = Titles.DuringAmount;
            }
            MasterPageHelper.SetTitle(this, s);
            //this.UCZedChart1.GraphPaneConfig = GetGraphPaneConfig();

            this.UCConditionDTTwo1.QueryEvent += new EventHandler(UCConditionDTTwo1_QueryEvent);
            // TODO: 2011-05-03 set title or title like lable
            //
            this.Page.Title = this.DataEnum.ToString() + "查询";

            if (!IsPostBack)
            {
                //this.UCChart1.Hide();

            }
        }
        #endregion //Page_Load

        #region UCConditionDTTwo1_QueryEvent
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCConditionDTTwo1_QueryEvent(object sender, EventArgs e)
        {
            this.Query();
        }
        #endregion //UCConditionDTTwo1_QueryEvent

        #region Query
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Query()
        {
            if (IsValid)
            {
                DateTime begin = UCConditionDTTwo1.Begin;
                DateTime end = UCConditionDTTwo1.End;

                //int  UCConditionDTTwo1.GetQueryDeviceIDs();
                StationCollection sc = this.UCConditionDTTwo1.Stations;
                string[] stationNames = sc.GetStationNames();

                DataTable tbl = DitchDataDayDBI.GetDayDataTable(begin, end, stationNames, this.DataEnum);
                //this.GridView1.DataSource = tbl;
                //this.DataBind();
                this.GridView1.Columns.Clear();
                Xdgk.UI.GridViewHelper H = new Xdgk.UI.GridViewHelper(this.GridView1);
                H.GridViewConfig = GetGridViewConfig(tbl);
                H.DataSource = tbl;
                H.Bind();


                this.UCZedChart1.DataSource = tbl;
                this.UCZedChart1.GraphPaneConfig = GetGraphPaneConfig(tbl);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private GraphPaneConfig GetGraphPaneConfig(DataTable tbl)
        {
            ColorProvider cp = new ColorProvider();
            GraphPaneConfig cfg = new GraphPaneConfig();
            cfg.Title = DataEnumClass.GetDataEnumString(this.DataEnum) + "曲线";

            if (this.DataEnum == DataEnum.WL)
            {
                cfg.YTitle = strings.WLWithUnit;
            }
            if (this.DataEnum == DataEnum.Amount)
            {
                cfg.YTitle = strings.AmountWithUnit;
            }
            cfg.XTitle = "时间";

            cfg.CurItemType = CurveItemType.Line;
            cfg.XAxisType = ZedGraph.AxisType.Date;

            for (int i = 1; i < tbl.Columns.Count; i++)
            {
                DataColumn col = tbl.Columns[i];
                SingleCurveConfig item = new SingleCurveConfig();
                item.Color = cp.GetNextColor();
                item.Name = col.ColumnName;
                item.XDataField = "DT";
                item.YDataField = col.ColumnName;

                cfg.CurveConfigBaseCollection.Add(item);
            }

            return cfg;
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //private object CreateChartConfig()
        //{
        //    string title = GetTitle();
        //    string xtitle = GetXTitle();
        //    string ytitle = GetYTitle();
        //    LineChartConfig cfg = new LineChartConfig(title, xtitle, ytitle, "DT");
        //    return cfg;
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //private string GetTitle()
        //{
        //    return string.Format("{0} ~ {1} {2} {3}曲线",
        //        this.UCConditionDTTwo1.Begin.ToShortDateString(),
        //        this.UCConditionDTTwo1.End.ToShortDateString(),
        //        this.UCConditionDTTwo1.WaterUser.Name,
        //        DataEnumClass.GetDataEnumString(this.DataEnum));
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //private string GetXTitle()
        //{
        //    return "时间";
        //}


        #region DataEnum
        /// <summary>
        /// 
        /// </summary>
        public DataEnum DataEnum
        {
            get
            {
                return DataEnumClass.GetDataEnumFromQueryString(this.Request.QueryString, QueryStringNames.DataEnum);
            }
        }
        #endregion //DataEnum

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //private string GetYTitle()
        //{
        //    return string.Format("{0}({1})",
        //        DataEnumClass.GetDataEnumString(this.DataEnum),
        //        DataEnumClass.GetDataEnumUnit(this.DataEnum));
        //}

        #endregion //Query

    }
}

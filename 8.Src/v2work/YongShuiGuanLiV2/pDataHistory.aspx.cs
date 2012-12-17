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
using YongShuiGuanLiDBI;
using WebChart;
using Xdgk.UI.Z;
namespace YongShuiGuanLiV2
{

    /// <summary>
    /// 原始历史数据查询, 仅包括水位和流量, 不包括用水量
    /// </summary>
    public partial class pDataHistory : System.Web.UI.Page
    {

        Xdgk.UI.GridViewHelper _h = null;

        #region Page_Load
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            _h = new Xdgk.UI.GridViewHelper(this.GridView1);
            _h.DataSourceDelegate = this.GetDataTable;


            //this.UCZedChart1.GraphPaneConfig = GetGraphPaneConfig();
            //this.UCZedChart1.DataSource = this.GetDataTable();

            //this.GridView1.AutoGenerateColumns = false; 
            // TODO: 2011-05-16 ddlStation not add all
            //
            this.UCConditionDTTwo1.IsAddAll = false;
            //
            this.UCConditionDTTwo1.QueryEvent += new EventHandler(UCConditionDTTwo1_QueryEvent);

            if (!IsPostBack)
            {
                _h.GridViewConfig = GetGridViewConfig();
                //this.UCChart1.Hide();

                //this.UCConditionDTTwo1.Begin = 
                if (DistributeQueryStringParam())
                {
                    // todo: query
                    //
                }
                if (DistributeQueryStringParam_Real())
                {
                    // query
                    //
                }

                string t = null;
                if (this.DataEnum == DataEnum.WL)
                {
                    t = Titles.DataHistoryWL;
                }
                else if (this.DataEnum == DataEnum.Flux)
                {
                    t = Titles.DataHistoryFlux;
                }
                else if (this.DataEnum == DataEnum.Amount)
                {
                    t = Titles.DataHistoryAmount;
                }

                MasterPageHelper.SetTitle(this, t);
            }
        }
        #endregion //Page_Load


        #region GetGraphPaneConfig
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Xdgk.UI.Z.GraphPaneConfig GetGraphPaneConfig()
        {
            GraphPaneConfig c = new GraphPaneConfig();
            c.Title = DataEnumClass.GetDataEnumString(this.DataEnum) + "历史曲线";
            c.YTitle = this.GetYTitle();
            c.XTitle = strings.DT;
            if (this.UCConditionDTTwo1.Stations.Count > 0)
            {
                SingleCurveConfig sc = new SingleCurveConfig();
                sc.Name = this.UCConditionDTTwo1.Stations[0].StationName;
                sc.XDataField = "DT";
                sc.YDataField = "WL1";
                sc.Color = new ColorProvider().GetNextColor();
                c.CurveConfigBaseCollection.Add(sc);
            }
            return c;
        }
        #endregion //GetGraphPaneConfig

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string GetYTitle()
        {
            string s = null;
            if (this.DataEnum == DataEnum.WL)
            {
                s = strings.WLWithUnit;
            }
            else if (this.DataEnum == DataEnum.Flux)
            {
                s = strings.InstanFluxWithUnit;
            }
            return s;
        }

        #region GetGridViewConfig
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Xdgk.UI.GridViewConfig GetGridViewConfig()
        {
            Xdgk.UI.GridViewConfig cfg = new Xdgk.UI.GridViewConfig();
            cfg.Caption = "DataHistoryCaption";
            cfg.GridViewColumnConfigCollection.AddBoundField(strings.StationName , YongShuiGuanLiDBI.DBNames.vDitchData.StationName );
            cfg.GridViewColumnConfigCollection.AddBoundField(strings.DT, YongShuiGuanLiDBI.DBNames.vDitchData.DT);
            cfg.GridViewColumnConfigCollection.AddBoundField(strings.WL, YongShuiGuanLiDBI.DBNames.vDitchData.WL1);
            cfg.GridViewColumnConfigCollection.AddBoundField(strings.InstantFlux, YongShuiGuanLiDBI.DBNames.vDitchData.InstantFlux);
            return cfg;
        }
        #endregion //GetGridViewConfig

        #region DistributeQueryStringParam_Real
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool DistributeQueryStringParam_Real()
        {
            string[] paramNames = new string[] { QueryStringNames.StationID};
            Type[] paramTypes = new Type[]{typeof(int)};

            object []result ;
            bool b = QueryStringParamPicker.Pick(this.Request.QueryString, paramNames, paramTypes,
                out result);

            if (b)
            {
                int stationid = (int)result[0];
                this.UCConditionDTTwo1.WaterUser = SessionManager.LoginSession.WaterUser;

                StationClass sc = StationFactory.CreateStationByStationID(stationid);
                StationCollection stations = new StationCollection();
                stations.Add (sc);
                this.UCConditionDTTwo1.Stations = stations;
                this.UCConditionDTTwo1.Begin = DateTime.Now.Date;
                this.UCConditionDTTwo1.End = DateTime.Now.Date + TimeSpan.FromDays(1d);
                return true;
            }
            return false;
        }

        #endregion

        #region DistributeQueryStringParam
        /// <summary>
        ///
        /// </summary>
        private bool DistributeQueryStringParam()
        {
            string[] paramNames = new string[] { QueryStringNames.WaterUserID ,
                QueryStringNames.Begin,
                QueryStringNames.End };

            Type[] paramTypes = new Type[] { typeof(int), typeof(DateTime), typeof(DateTime) };

            object[] result;
            bool b = QueryStringParamPicker.Pick(this.Request.QueryString, paramNames, paramTypes,
               out result);

            if (!b)
            {
                return false;
            }

            int waterUserID = (int)result[0];
            DateTime begin = (DateTime)result[1];
            DateTime end = (DateTime)result[2];

            WaterUserClass wu = WaterUserFactory.CreateWaterUserByID(waterUserID);

            this.UCConditionDTTwo1.Begin = begin;
            this.UCConditionDTTwo1.End = end;

            this.UCConditionDTTwo1.WaterUser = wu;

            return true;
            //this.Query();

        }
        #endregion //

        //#region GetQueryParams
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="begin"></param>
        ///// <param name="end"></param>
        ///// <param name="waterUserID"></param>
        //private bool GetQueryParams(out DateTime begin, out DateTime end, out int waterUserID)
        //{
        //    begin = DateTime.MinValue;
        //    end = DateTime.MinValue;
        //    waterUserID = 0;

        //    object obj = null;
        //    obj = this.Request.QueryString[QueryStringNames.WaterUserID];
        //    if (obj != null)
        //    {
        //        waterUserID = Convert.ToInt32(obj);
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //    obj = this.Request.QueryString[QueryStringNames.Begin];
        //    begin = Convert.ToDateTime(obj);

        //    obj = this.Request.QueryString[QueryStringNames.End];
        //    end = Convert.ToDateTime(obj);

        //    return true;
        //}
        //#endregion //GetQueryParams

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
        #endregion

        #region Query
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Query()
        {
            // TODO: 2011-05-27 page_load 之前不能调用 IsValid
            //
            //if (IsValid)
            DateTime begin = UCConditionDTTwo1.Begin;
            DateTime end = UCConditionDTTwo1.End;

            //int[] deviceIDs = UCConditionDTTwo1.GetQueryDeviceIDs();
            DeviceCollection dc = UCConditionDTTwo1.Stations.GetDeviceCollection();
            int[] deviceIDs = dc.GetDeviceIDs();
            if (deviceIDs.Length == 0)
            {
                // TODO: 2011-05-16 not select station msg
                //
                return;
            }

            DataTable tbl = DitchDataDBI.GetData(begin, end, deviceIDs);
            _h.Bind();
            //DataTable tbl = GetDataTable(begin, end, deviceIDs[0]);
            //ColumnNameTextCollection nts = GetColumnNameTextCollection();
            //GridViewHelper.SetGridViewColumn(this.GridView1, nts);
            //this.GridView1.DataSource = tbl;
            //this.DataBind();


            this.UCZedChart1.GraphPaneConfig = this.GetGraphPaneConfig();
            this.UCZedChart1.DataSource = tbl;
        }
        #endregion //Query

        #region GetDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private DataTable GetDataTable()
        {
            DateTime begin = UCConditionDTTwo1.Begin;
            DateTime end = UCConditionDTTwo1.End;

            //int[] deviceIDs = UCConditionDTTwo1.GetQueryDeviceIDs();
            DeviceCollection dc = UCConditionDTTwo1.Stations.GetDeviceCollection();
            int[] deviceIDs = dc.GetDeviceIDs();
            if (deviceIDs.Length == 0)
            {
                // TODO: 2011-05-16 not select station msg
                //
                return null;
            }

            //DataTable tbl = DitchDataDBI.GetData(begin, end, deviceIDs);
            DataTable tbl = DitchDataDBI.GetData(begin, end, deviceIDs[0]);
            return tbl;
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="begin"></param>
        ///// <param name="end"></param>
        ///// <param name="deviceid"></param>
        ///// <returns></returns>
        //private DataTable GetDataTable(DateTime begin, DateTime end, int deviceid)
        //{
        //    switch  (this.DataEnum )
        //    {
        //        case DataEnum.WL:
        //            return DitchDataDBI.GetWLTable(begin, end, deviceid);
        //        case DataEnum.Flux:
        //            return DitchDataDBI.GetFluxDataTable(begin, end, deviceid);
        //        default:
        //            throw new InvalidOperationException("cannot get datatable by dataEnum '" + this.DataEnum + "'");
        //    }
        //}
        #endregion


        #region GetColumnNameTextCollection
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private ColumnNameTextCollection GetColumnNameTextCollection()
        {
            switch (this.DataEnum)
            {
                case DataEnum.WL :
                    return ColumnNameTextManager.WLHistoryColumnNames;
                case DataEnum.Flux :
                    return ColumnNameTextManager.FluxHistoryColumnNames;
                default :
                    throw new InvalidOperationException("cannot get columnNameTextCollection by '" + this.DataEnum + "'");
            }
        }
        #endregion //GetColumnNameTextCollection

        #region GetSelectedStationName
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string GetSelectedStationName()
        {
            StationCollection stations = this.UCConditionDTTwo1.Stations;
            if (stations.Count > 0)
            {
                return stations[0].StationName;
            }
            else
            {
                return string.Empty;
            }
        }
        #endregion //GetSelectedStationName

        #region DataEnum
        /// <summary>
        /// 
        /// </summary>
        public DataEnum DataEnum
        {
            get
            {
                return DataEnumClass.GetDataEnumFromQueryString(
                    this.Request.QueryString,
                    QueryStringNames.DataEnum);
            }
        }
        #endregion //DataEnum


        //#region GetDataColumnName
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //private string GetDataColumnName()
        //{
        //    switch (this.DataEnum)
        //    {
        //        case DataEnum.WL :
        //            return "wl1";
        //        case DataEnum.Flux :
        //            return "Instantflux";
        //        default :
        //            throw new ArgumentException("cannot get data column name by '" + this.DataEnum + "'");
        //    }
        //}
        //#endregion //GetDataColumnName


        //#region CreateChartConfig
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //private object CreateChartConfig()
        //{
        //    LineChartConfig cfg = new LineChartConfig(
        //        GetTitle(), GetXTitle(), GetYTitle(), "DT");
        //    string lineName = GetSelectedStationName();
        //    LineDataConfig item = new LineDataConfig(
        //        lineName ,
        //        GetDataColumnName(),
        //        new ColorProvider().GetNextColorString()
        //        );
        //    cfg.LineDataConfigCollection.Add(item);
        //    return cfg;
        //}
        //#endregion //CreateChartConfig


        //#region GetYTitle
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
        //#endregion //GetYTitle


        //#region GetXTitle
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //private string GetXTitle()
        //{
        //    return "时间";
        //}
        //#endregion //GetXTitle


        //#region GetTitle
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //private string GetTitle()
        //{
        //    return string.Format("{0} ~ {1} {2} {3}曲线",
        //        this.UCConditionDTTwo1.Begin.ToShortDateString(),
        //        this.UCConditionDTTwo1.End.ToShortDateString(),
        //        this.GetSelectedStationName(),
        //        DataEnumClass.GetDataEnumString(this.DataEnum));
        //}
        //#endregion //GetTitle

    }
}

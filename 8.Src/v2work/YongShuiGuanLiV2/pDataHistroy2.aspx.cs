using System;
using Xdgk.UI.AMCharts;
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
    /// <summary>
    /// 
    /// </summary>
    public partial class pDataHistroy2 : System.Web.UI.Page
    {

        #region Page_Load
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            MasterPageHelper.SetTitle(this, DataEnumClass.GetDataEnumTitle(this.DataEnum));

            // register events
            //
            //this.UCChannelStationDT1.QueryEvent += new EventHandler(UCChannelStationDT1_QueryEvent);
            this.UCCompareAmount1.QueryEvent += new EventHandler(UCChannelStationDT1_QueryEvent);
            this.UCNavigation1.ForwardEvent += new EventHandler(UCNavigation1_ForwardEvent);
            this.UCNavigation1.BackwardEvent += new EventHandler(UCNavigation1_BackwardEvent);
            this.UCNavigation1.IncreaseEvent += new EventHandler(UCNavigation1_IncreaseEvent);
            this.UCNavigation1.DecreaseEvent += new EventHandler(UCNavigation1_DecreaseEvent);
            
            // init 
            // 
            Xdgk.UI.GridViewHelper h = this.GetGridViewHelper();
            h.SortingDelegate = Query;

            if (!IsPostBack)
            {
                PanelHelper.InitPanelForGridView(this.Panel1);

                this.HideControls();
                ChannelStationDTCondition c;
                bool hasIDParam = GetChannelStationDTCondition(out c);
                if (hasIDParam)
                {
                    MasterPageHelper.SetTitle(this, DataEnumClass.GetDataEnumTitle(c.DataEnum));
                    Query();
                }
                else
                {
                    MasterPageHelper.SetTitle(this, DataEnumClass.GetDataEnumTitle(this.DataEnum));
                }
            }
            else
            {
            }
        }
        #endregion //Page_Load

        #region HideControls
        private void HideControls()
        {
            SetControlsVisible(false);
        }
        #endregion //HideControls

        #region ShowControls
        private void ShowControls()
        {
            SetControlsVisible(true);
        }
        #endregion //ShowControls

        #region SetControlsVisible
        private void SetControlsVisible(bool b)
        {
            this.UCAMChart1.Visible = b;
            this.UCNavigation1.Visible = false;
            this.GridView1.Visible = b;

            this.lbAmount.Visible = false;
            this.lbWL.Visible = false;
            this.lbFlux.Visible = false;
            this.Panel1.Visible = b;
            this.btnExportToExcel.Visible = b;
        }
        #endregion //SetControlsVisible

        #region UCNavigation1_DecreaseEvent
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCNavigation1_DecreaseEvent(object sender, EventArgs e)
        {
            DoIncreaseOrDecrease(false);
        }
        #endregion //UCNavigation1_DecreaseEvent

        #region UCNavigation1_IncreaseEvent
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCNavigation1_IncreaseEvent(object sender, EventArgs e)
        {
            DoIncreaseOrDecrease(true);
        }
        #endregion //UCNavigation1_IncreaseEvent

        #region DoIncreaseOrDecrease
        /// <summary>
        /// 
        /// </summary>
        /// <param name="increase"></param>
        private void DoIncreaseOrDecrease(bool increase)
        {
            StepUnit su = this.UCNavigation1.IncreaseDecreaseStepUnit;
            int step = this.UCNavigation1.IncreaseDecreaseStep;

            TimeSpan ts = GetTimeSpan(su, step);
            DateTime newbegin = this.UCCompareAmount1 .Begin;
            DateTime newend = this.UCCompareAmount1 .End;
            if (increase)
            {
                newbegin -= ts;
                newend += ts;
            }
            else
            {
                newbegin += ts;
                newend -= ts;
            }
            Query();
        }
        #endregion //DoIncreaseOrDecrease

        #region DoForWardOrBackward
        /// <summary>
        /// 
        /// </summary>
        /// <param name="forward"></param>
        private void DoForWardOrBackward(bool forward)
        {
            StepUnit su = this.UCNavigation1.StepUnit;
            int step = this.UCNavigation1.Step;
            TimeSpan ts = GetTimeSpan(su, step);
            DateTime newbegin = this.UCCompareAmount1 .Begin;
            DateTime newend = this.UCCompareAmount1.End;

            if (forward)
            {
                newbegin += ts;
                newend += ts;
            }
            else
            {
                newbegin -= ts;
                newend -= ts;
            }

            Query();
        }
        #endregion //DoForWardOrBackward

        #region UCNavigation1_BackwardEvent
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCNavigation1_BackwardEvent(object sender, EventArgs e)
        {
            DoForWardOrBackward(false);
        }
        #endregion //UCNavigation1_BackwardEvent

        #region GetTimeSpan
        #region UCNavigation1_ForwardEvent
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCNavigation1_ForwardEvent(object sender, EventArgs e)
        {
            DoForWardOrBackward(true);
        }
        #endregion //UCNavigation1_ForwardEvent
        /// <summary>
        /// 
        /// </summary>
        /// <param name="su"></param>
        /// <returns></returns>
        private TimeSpan GetTimeSpan(StepUnit su, int step)
        {
            TimeSpan ts = TimeSpan.Zero;
            switch (su)
            {
                case StepUnit.Day :
                    ts = TimeSpan.FromDays(1d * step);
                    break;

                case StepUnit.Week:
                    ts = TimeSpan.FromDays(7d * step);
                    break;

                case StepUnit. Month:
                    ts = TimeSpan.FromDays(30d * step);
                    break;

                default:
                    break;
            }
            return ts;
        }
        #endregion //GetTimeSpan

        #region GetChannelStationDTCondition
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool GetChannelStationDTCondition(out ChannelStationDTCondition c)
        {
            c = null;

            string[] names = new string[] { "id" };
            Type[] types = new Type[] { typeof(string) };
            object[] result = new object[1];

            bool b = QueryStringParamPicker.Pick(this.Request.QueryString, names, types, out result);
            if (b)
            {
                string id = result[0] as string;
                c = Session[id] as ChannelStationDTCondition;
                if (c == null)
                {
                    b = false;
                }
            }
            return b;
        }
        #endregion //GetChannelStationDTCondition


        #region GetGridViewConfig
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private GridViewConfig GetGridViewConfig(DataEnum de, DataTable dataSourceDataTable)
        {
            if( dataSourceDataTable == null )
            {
                throw new ArgumentNullException ("dataSourceDataTable");
            }

            GridViewConfig c = new GridViewConfig();
            c.GridViewColumnConfigCollection.AddBoundField(strings.ChannelName, "ChannelName");
            c.GridViewColumnConfigCollection.AddBoundField(strings.StationName, "StationName");
            c.GridViewColumnConfigCollection.AddBoundField(strings.DT , "DT");
            string t = string.Empty;
            switch (de)
            {
                case DataEnum.WL:
                    t = DataTableHelper.GetExistColumnName(dataSourceDataTable, "WL1", "AVGWL");
                    c.GridViewColumnConfigCollection.AddBoundField(strings.WLWithUnit , t);
                    break;

                case DataEnum.Flux:
                    t =  DataTableHelper.GetExistColumnName(dataSourceDataTable, "InstantFlux", "avgflux");
                    //c.GridViewColumnConfigCollection.AddBoundField(strings.InstantFlux , "InstantFlux");
                    GridViewColumnConfig columnConfig = c.GridViewColumnConfigCollection.AddBoundField(
                        strings.InstantFluxWithUnit, t, FormatStringManager.FloatValueFormatString); 
                    break;

                case DataEnum.Amount:
                    t = DataTableHelper.GetExistColumnName(dataSourceDataTable, "DayAmount");
                    c.GridViewColumnConfigCollection.AddBoundField(strings.AmountWithUnit, t, 
                        FormatStringManager.FloatValueFormatString);
                    break;
            }
            // 
            //
            c.AllowSorting = true;
            return c;
        }
        #endregion //GetGridViewConfig

        #region UCChannelStationDT1_QueryEvent
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCChannelStationDT1_QueryEvent(object sender, EventArgs e)
        {
            Query();
        }
        #endregion //UCChannelStationDT1_QueryEvent

        #region ReBindGridViewDataSource
        /// <summary>
        /// 
        /// </summary>
        /// <param name="gv"></param>
        /// <param name="dataSource"></param>
        /// <param name="cfg"></param>
        private void ReBindGridViewDataSource(GridView gv, object dataSource, GridViewConfig cfg)
        {
            gv.Columns.Clear();
            Xdgk.UI.GridViewHelper h = new Xdgk.UI.GridViewHelper(gv);
            h.GridViewConfig = cfg;
            h.DataSource = dataSource;
            h.Bind();
        }
        #endregion //ReBindGridViewDataSource

        #region GetSelectedChannelName
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string GetSelectedChannelName()
        {
            string channelNames = string.Empty;
            foreach( ChannelClass c in this.UCCompareAmount1.SelectedChannelCollection)
            {
                channelNames += c.ChannelName + " ";
            }
            return channelNames;
        }
        #endregion //GetSelectedChannelName

        #region GetDataTableDTColumnValue
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tbl"></param>
        /// <returns></returns>
        private string GetDataTableDTColumnValue(DataTable tbl)
        {
            if (tbl.Rows.Count > 0)
            {
                DateTime dt = Convert.ToDateTime (tbl.Rows[0]["DT"]);
                return dt.ToString("yyyy-MM-dd");
            }
            return string.Empty;
        }
        #endregion //GetDataTableDTColumnValue

        #region Query
        /// <summary>
        /// 
        /// </summary>
        private void Query()
        {
            string title = string.Empty;
            string ytitle = string.Empty;

            StationCollection selected = this.UCCompareAmount1.SelectedStationCollection;
            DateTime begin = this.UCCompareAmount1.Begin;
            DateTime end = this.UCCompareAmount1.End;

            this.UCAMChart1.StationOrderList = GetStationOrderList(selected);
            this.UCAMChart1.StationColorList = GetStationColorList(selected);
            switch (this.DataEnum)
            {
                case DataEnum.WL:
                    QueryWL(selected, begin, end);
                    break;

                case DataEnum.Flux:
                    QueryFlux(selected, begin, end);
                    break;

                case DataEnum.Amount:
                    QueryAmount(selected, begin, end);
                    break;
            }
            this.ShowControls();
        }
        #endregion //Query

        #region GetStationColorList
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selected"></param>
        /// <returns></returns>
        private System.Collections.Generic.List<Xdgk.UI.AMCharts.StationColor> GetStationColorList(StationCollection selected)
        {
            System.Collections.Generic.List<Xdgk.UI.AMCharts.StationColor> list = new System.Collections.Generic.List<Xdgk.UI.AMCharts.StationColor>();
            foreach (StationClass item in selected)
            {
                StationColor stationClr = new StationColor(item.StationName, item.Color);
                list.Add(stationClr);
            }
            return list;
        }
        #endregion //GetStationColorList

        #region GetStationOrderList
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selected"></param>
        /// <returns></returns>
        private System.Collections.Generic.List<string> GetStationOrderList(StationCollection selected)
        {
            System.Collections.Generic.List<string> result = new System.Collections.Generic.List<string>();
            foreach (StationClass st in selected)
            {
                result.Add(st.StationName);
            }
            return result;
        }
        #endregion //GetStationOrderList

        #region QueryAmount
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selected"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        private void QueryAmount(StationCollection selected, DateTime begin, DateTime end)
        {
            string title = string.Format("{0} ~ {1} {2}水量曲线", begin, end, this.GetSelectedChannelName());
            string yTitle = "水量(m3)";

            DataTable tbl = selected.GetAmountDataTable(begin, end);
            this.UCAMChart1.SetLineChartInfo(tbl,
                YongShuiGuanLiDBI.DBNames.vDitchDataDay.StationName,
                YongShuiGuanLiDBI.DBNames.vDitchDataDay.DT,
                YongShuiGuanLiDBI.DBNames.vDitchDataDay.DayAmount,
                title,
                yTitle);


            this.GridView1.Columns.Clear();
            Xdgk.UI.GridViewHelper h = new Xdgk.UI.GridViewHelper(this.GridView1);
            h.GridViewConfig = GetGridViewConfig(DataEnum.Amount,tbl);
            h.DataSource = tbl;
            h.Bind();
        }
        #endregion //QueryAmount

        #region QueryFlux
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selected"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        private void QueryFlux(StationCollection selected, DateTime begin, DateTime end)
        {
            string title = string.Format("{0} ~ {1} {2}流量曲线", begin, end, this.GetSelectedChannelName());
            string yTitle = "流量(m3/s)";
            DataTable tbl = selected.GetFluxDataTable(begin, end);
            this.UCAMChart1.SetLineChartInfo(tbl,
                YongShuiGuanLiDBI.DBNames.vDitchData.StationName,
                YongShuiGuanLiDBI.DBNames.vDitchData.DT,
                DataTableHelper.GetExistColumnName (tbl, "InstantFlux","avgflux"),
                title, 
                yTitle);

            this.GridView1.Columns.Clear();
            Xdgk.UI.GridViewHelper h = new Xdgk.UI.GridViewHelper(this.GridView1);
            h.GridViewConfig = GetGridViewConfig(DataEnum.Flux, tbl);
            h.DataSource = tbl;
            h.Bind();

        }
        #endregion //QueryFlux

        #region QueryWL
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selected"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        private void QueryWL(StationCollection selected, DateTime begin, DateTime end)
        {
            string title = string.Format("{0} ~ {1} {2}水位曲线", begin, end, this.GetSelectedChannelName());
            string ytitle = "水位(cm)";
            DataTable tbl = selected.GetWL1DataTable(begin, end);

            this.UCAMChart1.SetLineChartInfo(tbl,
                YongShuiGuanLiDBI.DBNames.vDitchData.StationName,
                YongShuiGuanLiDBI.DBNames.vDitchData.DT,
                DataTableHelper.GetExistColumnName ( tbl, "wl1", "avgwl" ),
                title,
                ytitle);

            this.GridView1.Columns.Clear();

            Xdgk.UI.GridViewHelper h = GetGridViewHelper();
            h.GridViewConfig = GetGridViewConfig(DataEnum.WL, tbl);
            h.DataSource = tbl;
            h.Bind();
        }
        #endregion //QueryWL

        #region GetGridViewHelper
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Xdgk.UI.GridViewHelper GetGridViewHelper()
        {
            if (_h == null)
            {
                _h = new Xdgk.UI.GridViewHelper(this.GridView1);
            }
            return _h;
        } private Xdgk.UI.GridViewHelper _h;
        #endregion //GetGridViewHelper

        #region DataEnum
        /// <summary>
        /// 
        /// </summary>
        private DataEnum DataEnum
        {
            get 
            {
                ChannelStationDTCondition c;
                bool b = GetChannelStationDTCondition(out c);
                if (b)
                {
                    return c.DataEnum;
                }
                else
                {
                    return DataEnumClass.GetDataEnumFromQueryString(
                        this.Request.QueryString, QueryStringNames.DataEnum);
                }
            }
        }
        #endregion //DataEnum
        
        #region ToSamePage
        /// <summary>
        /// 
        /// </summary>
        /// <param name="de"></param>
        private void ToSamePage(DataEnum de)
        {
            ChannelStationDTCondition c = new ChannelStationDTCondition();
            c.ChannelCollection = this.UCCompareAmount1.SelectedChannelCollection;
            c.StationCollection  = this.UCCompareAmount1.SelectedStationCollection;
            c.Begin = this.UCCompareAmount1.Begin;
            c.End = this.UCCompareAmount1.End;
            c.DataEnum = de;

            Guid guid = Guid.NewGuid();
            string guidstring = guid.ToString();
            Session[guidstring] = c;

            string url = string.Format("pDataHistroy2.aspx?id={0}", guidstring);
            WindowsHelper.OpenInNewWindows(this.Response, url);

            this.Query();
        }
        #endregion //ToSamePage

        #region lbWL_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbWL_Click(object sender, EventArgs e)
        {
            ToSamePage(DataEnum.WL);
        }
        #endregion //lbWL_Click

        #region lbFlux_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbFlux_Click(object sender, EventArgs e)
        {
            ToSamePage(DataEnum.Flux);
        }
        #endregion //lbFlux_Click

        #region lbAmount_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbAmount_Click(object sender, EventArgs e)
        {
            ToSamePage(DataEnum.Amount);
        }
        #endregion //lbAmount_Click

        #region Button1_Click
        protected void Button1_Click(object sender, EventArgs e)
        {
            ToSamePage(DataEnum.Amount);
        }
        #endregion //Button1_Click

        #region DeviceTypeFilter
        /// <summary>
        /// 
        /// </summary>
        public string[] DeviceTypeFilter
        {
            get
            {
                return ConfigDBI.GetWaterLevelDeviceType();
            }
        }
        #endregion //DeviceTypeFilter

        #region VerifyRenderingInServerForm
        /// <summary>
        /// 
        /// </summary>
        /// <param name="control"></param>
        public override void VerifyRenderingInServerForm(Control control)
        {
        }
        #endregion //VerifyRenderingInServerForm

        #region btnExportToExcel_Click
        protected void btnExportToExcel_Click(object sender, EventArgs e)
        {
            ExcelExporter.ExportToExcel(this.GridView1);
        }
        #endregion //btnExportToExcel_Click
    }

   
}

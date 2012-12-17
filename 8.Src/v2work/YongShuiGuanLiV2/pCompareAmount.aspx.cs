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
    public partial class pCompareAmount : System.Web.UI.Page
    {

        #region Page_Load
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UCCompareAmount1.QueryEvent += new EventHandler(UCCompareAmount1_QueryEvent);
            MasterPageHelper.SetTitle(this, "水量对比");

            this.H.SortingDelegate = this.Query;

            if (!IsPostBack)
            {
                HideControls();
            }
        }
        #endregion //Page_Load

        /// <summary>
        /// 
        /// </summary>
        private void HideControls()
        {
            HideOrShow(false);
        }
        private void ShowControls()
        {
            HideOrShow(true);
        }

        private void HideOrShow(bool show)
        {
            this.GridView1.Visible = show;
            this.UCAMChart1.Visible = show;
            this.btnExportToExcel.Visible = show;
        }

        #region UCCompareAmount1_QueryEvent
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCCompareAmount1_QueryEvent(object sender, EventArgs e)
        {
            Query();
        }
        #endregion //UCCompareAmount1_QueryEvent

        #region SelectedStationCollection
        /// <summary>
        /// 
        /// </summary>
        private StationCollection SelectedStationCollection
        {
            get
            {
                return this.UCCompareAmount1.SelectedStationCollection;
            }
        }
        #endregion //SelectedStationCollection

        #region Query
        /// <summary>
        /// 
        /// </summary>
        private void Query()
        {
            StationCollection stations = this.UCCompareAmount1.SelectedStationCollection;
            RangeType rt = this.UCCompareAmount1.RangeType;
            switch  (rt)
            {
                case RangeType.Year:
                    QueryYear();
                    break;

                case RangeType.During:
                    QueryDuring();
                    break;

                case RangeType.Range:
                    QueryRange();
                    break;

                case RangeType.Day :
                    QueryDay();
                    break;

                default:
                    throw new NotSupportedException("cannot query with RangeType: " + rt);
            }
            ShowControls();
        }
        #endregion //Query

        #region QueryDay
        /// <summary>
        /// 
        /// </summary>
        private void QueryDay()
        {
            DateTime begin = this.UCCompareAmount1.Day;
            DateTime end = begin + TimeSpan.FromDays(1d);
            this.Query(begin, end);
        }
        #endregion //QueryDay

        #region QueryRange
        /// <summary>
        /// 
        /// </summary>
        private void QueryRange()
        {
            DateTime begin = this.UCCompareAmount1.DuringBegin ;
            DateTime end = this.UCCompareAmount1.DuringEnd;
            this.Query(begin, end);
        }
        #endregion //QueryRange

        #region QueryDuring
        /// <summary>
        /// 
        /// </summary>
        private void QueryDuring()
        {
            int year = this.UCCompareAmount1.Year;
            DuringWaterClass dw = this.UCCompareAmount1.DuringWater;
            DateTime begin = dw.GetBeginDTWithYear(year);
            DateTime end = dw.GetEndDTWithYear(year);

            this.Query(begin, end);
        }
        #endregion //QueryDuring

        #region QueryYear
        /// <summary>
        /// 
        /// </summary>
        private void QueryYear()
        {
            int year = this.UCCompareAmount1.Year;
            DateTime begin = new DateTime(year, 1, 1);
            DateTime end = new DateTime(year + 1, 1, 1);

            this.Query(begin, end);
        }
        #endregion //QueryYear

        #region Query
        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        private void Query( DateTime begin, DateTime end )
        {
            // create year result data table
            //
            DataTable resultTable = CreateResultDataTable();

            //this.SelectedStationCollection.GetWL1DataTable(

            foreach (StationClass st in this.SelectedStationCollection)
            {
                DeviceClass d = st.DeviceCollection[0];
                double usedAmount = d.CalcUsedAmount(begin, end);
                // insert result row to year table
                //
                CreateAndAddRow(resultTable, st.StationName, begin, end, (int)usedAmount);
            }


            // bind result result data table to chart
            //
            BindDataToChart(resultTable);
            BindDataToGridView(resultTable);
        }
        #endregion //Query

        #region QueryWL
        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        private void QueryWL(DateTime begin, DateTime end)
        {
            DataTable tbl = this.SelectedStationCollection.GetWL1DataTable(begin, end);
            BindDataToChartWL(tbl);
            BindDataToGridViewWL(tbl);
        }
        #endregion //QueryWL

        #region BindDataToChartWL
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tbl"></param>
        private void BindDataToChartWL(DataTable tbl)
        {
            this.UCAMChart1.SetLineChartInfo(tbl, "StationName", "DT", "WL1",
                "title", "yTitle");
        }
        #endregion //BindDataToChartWL

        #region BindDataToGridViewWL
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tbl"></param>
        private void BindDataToGridViewWL(DataTable tbl)
        {
        }
        #endregion //BindDataToGridViewWL

        #region BindDataToGridView
        /// <summary>
        /// 
        /// </summary>
        /// <param name="yeartable"></param>
        private void BindDataToGridView(DataTable yeartable)
        {
            H.DataSource = yeartable;
            H.Bind();
        }
        #endregion //BindDataToGridView

        #region BindDataToChart
        /// <summary>
        /// 
        /// </summary>
        /// <param name="yeartable"></param>
        private void BindDataToChart(DataTable resultTable)
        {
            this.UCAMChart1.SetColumnChartInfo(resultTable, "StationName", "UsedAmount",
                "BeginDT", "line-name", GetColumnChartTitle(), "");
        }
        #endregion //BindDataToChart

        #region GetColumnChartTitle
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string GetColumnChartTitle()
        {
            string s = string.Format(
                "{0} {1} 水量对比",
                GetDateTimePartOfTitle(),
                this.UCCompareAmount1.SelectedChannelName);
            return s;
                
        }
        #endregion //GetColumnChartTitle

        #region GetDateTimePartOfTitle
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string GetDateTimePartOfTitle()
        {
            string r = string.Empty;
            RangeType rt = this.UCCompareAmount1.RangeType;
            switch  (rt)
            {
                case RangeType.Year:
                    r = this.UCCompareAmount1.Year.ToString ();
                    break;

                case RangeType.During:
                    r = string.Format("{0}年{1}",
                        this.UCCompareAmount1.Year,
                        this.UCCompareAmount1.DuringWater.Name);
                    break;

                case RangeType.Range:
                    r = string.Format("{0} ~ {1}",
                        this.UCCompareAmount1.DuringBegin,
                        this.UCCompareAmount1.DuringEnd);
                    break;

                case RangeType.Day :
                    r = this.UCCompareAmount1.Day.ToShortDateString();
                    break;

                default:
                    throw new NotSupportedException("cannot query with RangeType: " + rt);
            }

            return r;
        }
        #endregion //GetDateTimePartOfTitle

        #region CreateResultDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private DataTable CreateResultDataTable()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("StationName", typeof(string));
            tbl.Columns.Add("BeginDT", typeof(DateTime));
            tbl.Columns.Add("EndDT", typeof(DateTime));
            tbl.Columns.Add("UsedAmount", typeof(int));

            return tbl;
        }
        #endregion //CreateResultDataTable

        #region CreateAndAddRow
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="stationName"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="usedAmount"></param>
        /// <returns></returns>
        private void CreateAndAddRow(DataTable source, string stationName, DateTime begin,
            DateTime end, int usedAmount)
        {
            DataRow row =  source.NewRow();
            row["StationName"] = stationName;
            row["BeginDT"] = begin;
            row["EndDT"] = end ;
            row["UsedAmount"]=usedAmount;
            
            source.Rows.Add(row);
        }
        #endregion //CreateAndAddRow

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
                    //_h = new Xdgk.UI.GridViewHelper(this.GridView1);
                    //if (!_h.IsSetGridViewConfig())
                    //{
                    //    _h.GridViewConfig = GetGridViewConfig();
                    //}
                    _h = new Xdgk.UI.GridViewHelper(this.GridView1);
                    this.GridView1.Columns.Clear();
                    _h.GridViewConfig = GetGridViewConfig();
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
            c.AllowSorting = true;
            c.GridViewColumnConfigCollection.AddBoundField(strings.StationName, "StationName");
            c.GridViewColumnConfigCollection.AddBoundField("开始时间", "BeginDT");
            c.GridViewColumnConfigCollection.AddBoundField("结束时间", "EndDT");
            c.GridViewColumnConfigCollection.AddBoundField(strings.AmountWithUnit, "UsedAmount");
            return c;
        }
        #endregion //GetGridViewConfig

        /// <summary>
        /// 
        /// </summary>
        public string[] DeviceTypeFilter
        {
            get
            {
                return YongShuiGuanLiDBI.ConfigDBI.GetWaterLevelDeviceType();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="control"></param>
        public override void VerifyRenderingInServerForm(Control control)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnExportToExcel_Click(object sender, EventArgs e)
        {
            ExcelExporter.ExportToExcel(this.GridView1);
        }
    }
}

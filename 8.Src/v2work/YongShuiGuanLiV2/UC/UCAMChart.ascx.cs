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
using am.Charts;
using Xdgk.UI.AMCharts ;
using Xdgk.Common;
using YongShuiGuanLiDBI;

namespace YongShuiGuanLiV2.UC
{
    /// <summary>
    /// 
    /// </summary>
    public partial class UCAMChart : System.Web.UI.UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            //this.LineChart1.GraphSettingsInData = false;
        }

        ///// <summary>
        ///// 
        ///// </summary>
        //public void ClearAMChart()
        //{
        //    this.LineChart1.Graphs.Clear();
        //}

        /// <summary>
        /// 
        /// </summary>
        public void SetColumnChartInfo(object dataSource, string nameColumn, string valueColumn, string dateTimeColumn,
            string lineName,
            string title, string yTitle)
        {
            SetColumnChartInfo(dataSource, nameColumn, valueColumn, dateTimeColumn, lineName, title, yTitle, string.Empty);
        }

        public void SetColumnChartInfo(object dataSource, string nameColumn, string valueColumn, string dateTimeColumn,
            string lineName,
            string title, string yTitle, string valueFormatString)
        {
            this.ColumnChart1.Series.Clear();
            this.ColumnChart1.Graphs.Clear();
            this.ColumnChart1.Labels.Clear();

            this.ColumnChart1.LegendEnabled = false;

            ChartLabel titleLabel = new ChartLabel(title, 60, 20,false, 600, LabelAlignments.Center , 
                System.Drawing.Color.Black , 18);
            this.ColumnChart1.Labels.Add(titleLabel);

            ChartLabel yLabel = new ChartLabel(yTitle, 5, 150, true, 20, LabelAlignments.Center,
                System.Drawing.Color.Black, 12);
            this.ColumnChart1.Labels.Add(yLabel);

            DataTable tbl = dataSource as DataTable ;
            ColumnChartGraph ccg = new ColumnChartGraph();
            ccg.EnableViewState = false;
            ccg.GraphType = ColumnChartGraphTypes.Column;
            ccg.Title = lineName;

            foreach (DataRow row in tbl.Rows)
            {
                string id = row[nameColumn].ToString();

                string value = string.IsNullOrEmpty(valueFormatString) ? row[valueColumn].ToString() :
                    string.Format("{0:" + valueFormatString + "}", row[valueColumn]);

                    //row[valueColumn].ToString(valueFormatString);
                ColumnChartValuesDataItem item = new ColumnChartValuesDataItem(id, value);
                ccg.Items.Add(item);
            }

            this.ColumnChart1.ValuesMin = 0;
            this.ColumnChart1.Graphs.Add(ccg);
            this.ColumnChart1.DataSource = dataSource;
            this.ColumnChart1.DataSeriesIDField = nameColumn;
            this.ColumnChart1.DataBind();

            // set column label
            //
            this.ColumnChart1.ColumnDataLabelFormatString = "{value}";

            this.ColumnChart1.Visible = true;
            this.LineChart1.Visible = false;
        }

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataSource"></param>
        /// <param name="lcCfg"></param>
        public void SetLineChartInfo(object dataSource, string filterColumn, string dateTimeColumn, string dataColumn,
            string title, string yTitle)
        {
            //string chartTitle = "2001-1-1 12:00:00 ~ 2001-1-1 12:00:00 一干渠 水位曲线";
            //this.LineChart1.Series.Clear();
            ////this.LineChart1.Graphs.Clear();
            //if (LineChart1.Graphs.Count > 0)
            //{
            //    this.LineChart1.Graphs[0].Items.Clear();
            //}

            this.LineChart1.Labels.Clear();
            //this.LineChart1 = new LineChart();
            //this.LineChart1 = new LineChart();
            ChartLabel titleLabel = new ChartLabel(title, 60, 20,false, 600, LabelAlignments.Center , 
                System.Drawing.Color.Black , 18);
            this.LineChart1.Labels.Add(titleLabel);

            ChartLabel yLabel = new ChartLabel(yTitle, 5, 150, true, 20, LabelAlignments.Center,
                System.Drawing.Color.Black, 12);

            this.LineChart1.Labels.Add(yLabel);

            DataTable source = dataSource as DataTable;
            DataTable convertedTable = DataTableConverter.ConvertRowToColumn(source, filterColumn,
                dataColumn, dateTimeColumn);

            LineChartConfig lccfg = new LineChartConfig();
            lccfg.DataSeriesIDField = dateTimeColumn;
            lccfg.YLeftValueMin = 0;

            foreach (DataColumn col in convertedTable.Columns)
            {
                if (!StringHelper.Equal(col.ColumnName, dateTimeColumn))
                {
                    LineGraphItemConfig item = new LineGraphItemConfig();
                    item.DataValueField = col.ColumnName;
                    item.Title = col.ColumnName;
                    item.Color = GetLineColor(col.ColumnName);
                    lccfg.LineGraphItemConfigCollection.Add(item);
                }
            }
            //Sort(lccfg.LineGraphItemConfigCollection);

            lccfg.LineGraphItemConfigCollection.Sort(this.StationOrderList);

            convertedTable.DefaultView.Sort = dateTimeColumn;
            LineGraphSetter.Set(this.LineChart1, lccfg, convertedTable.DefaultView,
                FormatStringManager.FloatValueFormatString);

            this.ColumnChart1.Visible = false;

            this.LineChart1.Visible = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private System.Drawing.Color GetLineColor(string name)
        {
            foreach (StationColor item in StationColorList)
            {
                if (StringHelper.Equal(item.StatinName, name))
                {
                    return item.Color;
                }
            }

            return System.Drawing.Color.White;
        }

        /// <summary>
        /// 
        /// </summary>
        public List<StationColor> StationColorList
        {
            get 
            {
                if (_stationColorList == null)
                {
                    _stationColorList = new List<StationColor>();
                }
                return _stationColorList;
            }

            set 
            {
                _stationColorList = value;
            }
        } private List<StationColor> _stationColorList;

        /// <summary>
        /// 获取或设置排序的站点列表
        /// </summary>
        public List<string> StationOrderList
        {
            get
            {
                if (_stationOrderList == null)
                {
                    _stationOrderList = new List<string>();
                }
                return _stationOrderList;
            }
            set { _stationOrderList = value; }
        } private List<string> _stationOrderList;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataSource"></param>
        /// <param name="lcCfg"></param>
        public void SetDayLineChartInfo(object dataSource, string filterColumn, string dateTimeColumn, string dataColumn,
            string title, string yTitle)
        {
            this.LineChart1.Labels.Clear();

            ChartLabel titleLabel = new ChartLabel(title, 60, 20, false, 600, LabelAlignments.Center,
                System.Drawing.Color.Black, 18);

            this.LineChart1.Labels.Add(titleLabel);

            ChartLabel yLabel = new ChartLabel(yTitle, 5, 150, true, 20, LabelAlignments.Center,
                System.Drawing.Color.Black, 12);

            this.LineChart1.Labels.Add(yLabel);

            DataTable source = dataSource as DataTable;
            DataTable convertedTable = DataTableConverter.ConvertRowToColumn(source, filterColumn,
                dataColumn, dateTimeColumn);

            LineChartConfig lccfg = new LineChartConfig();
            lccfg.DataSeriesIDField = dateTimeColumn;
            lccfg.YLeftValueMin = 0;

            foreach (DataColumn col in convertedTable.Columns)
            {
                if (!StringHelper.Equal(col.ColumnName, dateTimeColumn))
                {
                    LineGraphItemConfig item = new LineGraphItemConfig();
                    item.DataValueField = col.ColumnName;
                    item.Title = col.ColumnName;
                    item.Color = GetLineColor(col.ColumnName);
                    lccfg.LineGraphItemConfigCollection.Add(item);
                }
            }

            convertedTable.DefaultView.Sort = dateTimeColumn;
            //LineGraphSetter.Set(this.LineChart1, lccfg, convertedTable.DefaultView);

            DataTable xAxisDataSource = GetDayXAxisDataSource ( convertedTable, dateTimeColumn );
            xAxisDataSource.DefaultView.Sort = dateTimeColumn;

            LineGraphSetter.Set(this.LineChart1, lccfg, convertedTable.DefaultView, 
                xAxisDataSource.DefaultView, FormatStringManager.FloatValueFormatString);

            this.ColumnChart1.Visible = false;

            this.LineChart1.Visible = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tbl"></param>
        /// <returns></returns>
        private DataTable GetDayXAxisDataSource(DataTable tbl, string dateTimeColumn)
        {
            DataTable t = tbl.DefaultView.ToTable(true, dateTimeColumn);
            DateTime dt = Convert.ToDateTime(t.Rows[0][0]);
            dt = dt.Date;

            for (int i = 0; i < 48; i++)
            {
                DateTime rowdt = dt + TimeSpan.FromMinutes(i * 30);
                t.Rows.Add(rowdt);
            }

            t.DefaultView.Sort = dateTimeColumn;
            DataTable t2 = t.DefaultView.ToTable(true, dateTimeColumn);
            return t2;
        }
    }
}
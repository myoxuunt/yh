using System;
using System.Drawing;
using System.Data;
using System.Collections.Generic;
using System.Text;
using am.Charts;

namespace Xdgk.UI.AMCharts
{
    /// <summary>
    /// 
    /// </summary>
    public class LineGraphSetter
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lc"></param>
        /// <param name="lccfg"></param>
        /// <param name="lineDataSource"></param>
        /// <param name="xAxisDataSource"></param>
        static public void Set(LineChart lc, LineChartConfig lccfg, object lineDataSource, object xAxisDataSource, string valueFormatString)
        {
            if (lc == null)
                throw new ArgumentNullException("lc");

            if (lccfg == null)
                throw new ArgumentNullException("lccfg");

            if (lineDataSource == null)
                throw new ArgumentNullException("dataSource");

            lc.Series.Clear();
            lc.Graphs.Clear();


            foreach ( LineGraphItemConfig itemConfig in lccfg.LineGraphItemConfigCollection )
            {
                am.Charts.LineChartGraph lcg = new LineChartGraph();
                lcg.EnableViewState = false;
                lcg.Title = itemConfig.Title;
                lcg.Bullet = LineChartBulletTypes.Round;
                DataView dsTable = lineDataSource as DataView;
                foreach (DataRowView rowView in dsTable)
                {
                    string seriesItemID = rowView.Row[lccfg.DataSeriesIDField].ToString();
                    object value = rowView.Row[itemConfig.DataValueField];
                    if (value == null || value == DBNull.Value)
                        continue;

                    value = Convert.ToDouble(value);
                    string strValue = string.Format(valueFormatString, value);
                    LineChartValuesDataItem item = new LineChartValuesDataItem(seriesItemID, strValue);
                    lcg.Items.Add(item);
                }
                lc.Graphs.Add(lcg);
            }

            lc.YLeftValuesMin = lccfg.YLeftValueMin;
            lc.Connect = true;
            lc.DataSeriesIDField = lccfg.DataSeriesIDField;

            DataView view = xAxisDataSource as DataView;
            DataTable tbl =  view.ToTable(true, lccfg.DataSeriesIDField);
            lc.DataSource = tbl;
            lc.DataBind();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lc"></param>
        /// <param name="lccfg"></param>
        static public void Set(LineChart lc, LineChartConfig lccfg, object dataSource, string valueFormatString)
        {
            if (lc == null)
                throw new ArgumentNullException("lc");

            if (lccfg == null)
                throw new ArgumentNullException("lccfg");

            if (dataSource == null)
                throw new ArgumentNullException("dataSource");

            lc.Series.Clear();
            lc.Graphs.Clear();

            foreach ( LineGraphItemConfig itemConfig in lccfg.LineGraphItemConfigCollection )
            {
                am.Charts.LineChartGraph lcg = new LineChartGraph();
                lcg.EnableViewState = false;

                if (itemConfig.Color != Color.White)
                {
                    // title color
                    //
                    lcg.BalloonColor = itemConfig.Color;
                    // data point color
                    //
                    lcg.BulletColor = itemConfig.Color;
                    // line color
                    //
                    lcg.ForeColor = itemConfig.Color;
                }

                lcg.Title = itemConfig.Title;
                lcg.Bullet = LineChartBulletTypes.Round;
                DataView dsTable = dataSource as DataView;
                foreach (DataRowView rowView in dsTable)
                {
                    string seriesItemID = rowView.Row[lccfg.DataSeriesIDField].ToString();
                    object value = rowView.Row[itemConfig.DataValueField];
                    if (value == null || value == DBNull.Value)
                        continue;

                    value = Convert.ToDouble(value);
                    string strValue = string.Format(valueFormatString, value);
                    LineChartValuesDataItem item = new LineChartValuesDataItem(seriesItemID,
                        strValue);
                    lcg.Items.Add(item);
                }
                lc.Graphs.Add(lcg);
            }

            lc.YLeftValuesMin = lccfg.YLeftValueMin;
            lc.Connect = true;
            lc.DataSeriesIDField = lccfg.DataSeriesIDField;

            DataView view = dataSource as DataView;
            DataTable tbl =  view.ToTable(true, lccfg.DataSeriesIDField);
            lc.DataSource = tbl;
            lc.DataBind();
        }
    }
}

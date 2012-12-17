using System;
using System.Collections.Generic;
using System.Text;
using OpenFlashChart;
namespace WebChart
{


    /// <summary>
    /// 
    /// </summary>
    public class WebChartConfig
    {
        #region ChartDataConfigCollection
        /// <summary>
        /// 
        /// </summary>
        public ChartDataConfigCollection  ChartDataConfigCollection
        {
            get
            {
                if (_chartDataConfigCollection == null)
                {
                    _chartDataConfigCollection = new ChartDataConfigCollection();
                }
                return _chartDataConfigCollection;
            }
            set
            {
                _chartDataConfigCollection = value;
            }
        } private ChartDataConfigCollection  _chartDataConfigCollection;
        #endregion //ChartDataConfigCollection

        #region Title
        /// <summary>
        /// 
        /// </summary>
        public string Title
        {
            get
            {
                if (_title == null)
                {
                    _title = string.Empty;
                }
                return _title;
            }
            set
            {
                _title = value;
            }
        } private string _title;
        #endregion //Title

        #region TipFormat
        /// <summary>
        /// 
        /// </summary>
        public string TipFormat
        {
            get
            {
                if (_tipFormat == null)
                {
                    _tipFormat = string.Empty;
                }
                return _tipFormat;
            }
            set
            {
                _tipFormat = value;
            }
        } private string _tipFormat;
        #endregion //TipFormat

        #region XAxisConfig
        /// <summary>
        /// 
        /// </summary>
        public AxisConfig XAxisConfig
        {
            get
            {
                if (_xAxisConfig == null)
                {
                    _xAxisConfig = new AxisConfig();
                    _xAxisConfig.Title = "X轴";
                    _xAxisConfig.Min = 0;
                    _xAxisConfig.Max = 30;
                    _xAxisConfig.Step = 3;
                }
                return _xAxisConfig;
            }
            set
            {
                _xAxisConfig = value;
            }
        } private AxisConfig _xAxisConfig;
        #endregion //XAxisConfig

        #region YAxisConfig
        /// <summary>
        /// 
        /// </summary>
        public AxisConfig YAxisConfig
        {
            get
            {
                if (_yAxisConfig == null)
                {
                    _yAxisConfig = new AxisConfig();
                    _yAxisConfig.Title = "Y轴(cm)";
                    _yAxisConfig.Min = 0;
                    _yAxisConfig.Max = 30;
                    _yAxisConfig.Step = 3;
                }
                return _yAxisConfig;
            }
            set
            {
                _yAxisConfig = value;
            }
        } private AxisConfig _yAxisConfig;
        #endregion //YAxisConfig

        #region Create

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Create()
        {
            OpenFlashChart.OpenFlashChart chart = new OpenFlashChart.OpenFlashChart();

            // set title
            //
            chart.Title.Text = this.Title;

            //double min=0;

            // add element
            //
            foreach( ChartDataConfig item in this.ChartDataConfigCollection )
            {
                chart.AddElement(item.CreateElement());
                chart.X_Axis.SetLabels(item.XAxisLabels);
                XAxisConfig.Max = item.XAxisLabels.Count;
            }

            // x axis
            //
            chart.X_Legend = new Legend(XAxisConfig.Title);
            XAxisConfig.Min = 0;
            SetAxis(chart.X_Axis, XAxisConfig);

            // y axis
            chart.Y_Legend = new Legend(YAxisConfig.Title);
            AxisCalculator calculator = new AxisCalculator();
            calculator.Calc(this.ChartDataConfigCollection.GetMin(), this.ChartDataConfigCollection.GetMax());

            YAxisConfig.Min = calculator.Min;
            YAxisConfig.Max = calculator.Max;
            YAxisConfig.Step = calculator.Step;

            SetAxis(chart.Y_Axis, YAxisConfig);

            // set x axis label
            //
            //IList<string> lbls = new List<string>();
            //for (int i = 0; i < 30; i++)
            //{
            //    if (i % 10 == 0)
            //    {
            //        lbls.Add(DateTime.Now.ToString());
            //    }
            //    else
            //    {
            //        lbls.Add("");
            //    }
            //}
            //chart.X_Axis.Labels.SetLabels(item);
            return chart.ToString ();
        }
        #endregion //Create

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xAxis"></param>
        /// <param name="XAxisConfig"></param>
        private void SetAxis(Axis axis, AxisConfig axisConfig)
        {
            axis.Offset = true;
            axis.Min = axisConfig.Min;
            axis.Max = axisConfig.Max;
            axis.Steps = (int)axisConfig.Step;
        }
    }
}

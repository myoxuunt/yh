using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using OpenFlashChart;

namespace WebChart
{

    /// <summary>
    /// 
    /// </summary>
    public class LineDataConfig
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dataFieldName"></param>
        /// <param name="color"></param>
        public LineDataConfig(string name, string dataFieldName, string color)
        {
            this.DataFieldName = dataFieldName;
            this.Name = name;
            this.Color = color;
        }

        #region FontSize
        /// <summary>
        /// 
        /// </summary>
        public double FontSize
        {
            get
            {
                return _fontSize;
            }
            set
            {
                _fontSize = value;
            }
        } private double _fontSize = 18D;
        #endregion //FontSize

        #region DataFieldName
        /// <summary>
        /// 
        /// </summary>
        public string DataFieldName
        {
            get
            {
                if (_dataFieldName == null)
                {
                    _dataFieldName = string.Empty;
                }
                return _dataFieldName;
            }
            set
            {
                _dataFieldName = value;
            }
        } private string _dataFieldName;
        #endregion //DataFieldName

        #region Name
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get
            {
                if (_name == null)
                {
                    _name = string.Empty;
                }
                return _name;
            }
            set
            {
                _name = value;
            }
        } private string _name;
        #endregion //Name

        #region Color
        /// <summary>
        /// 
        /// </summary>
        public string Color
        {
            get
            {
                if (_color == null)
                {
                    _color = string.Empty;
                }
                return _color;
            }
            set
            {
                _color = value;
            }
        } private string _color;
        #endregion //Color
    }

    /// <summary>
    /// 
    /// </summary>
    public class LineDataConfigCollection : Xdgk.Common.Collection<LineDataConfig>
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public class LineChartConfig
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="xtitle"></param>
        /// <param name="ytitle"></param>
        /// <param name="xAxisFieldName"></param>
        public LineChartConfig(string title, string xtitle, string ytitle, string xAxisFieldName)
        {
            this.Title = title;
            this.XTitle = xtitle;
            this.YTitle = ytitle;
            this.XAxisFieldName = xAxisFieldName;
        }

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

        #region XTitle
        /// <summary>
        /// 
        /// </summary>
        public string XTitle
        {
            get
            {
                if (_xTitle == null)
                {
                    _xTitle = string.Empty;
                }
                return _xTitle;
            }
            set
            {
                _xTitle = value;
            }
        } private string _xTitle;
        #endregion //XTitle

        #region YTitle
        /// <summary>
        /// 
        /// </summary>
        public string YTitle
        {
            get
            {
                if (_yTitle == null)
                {
                    _yTitle = string.Empty;
                }
                return _yTitle;
            }
            set
            {
                _yTitle = value;
            }
        } private string _yTitle;
        #endregion //YTitle

        #region XSegmentCount
        /// <summary>
        /// 
        /// </summary>
        public int XSegmentCount
        {
            get
            {
                return _xSegmentCount;
            }
            set
            {
                _xSegmentCount = value;
            }
        } private int _xSegmentCount;
        #endregion //XSegmentCount

        #region YSegmentCount
        /// <summary>
        /// 
        /// </summary>
        public int YSegmentCount
        {
            get
            {
                return _ySegmentCount;
            }
            set
            {
                _ySegmentCount = value;
            }
        } private int _ySegmentCount;
        #endregion //YSegmentCount
        #region XAxisFieldName
        /// <summary>
        /// 
        /// </summary>
        public string XAxisFieldName
        {
            get
            {
                if (_xAxisFieldName == null)
                {
                    _xAxisFieldName = string.Empty;
                }
                return _xAxisFieldName;
            }
            set
            {
                _xAxisFieldName = value;
            }
        } private string _xAxisFieldName;
        #endregion //XAxisFieldName

        /// <summary>
        /// 
        /// </summary>
        public LineDataConfigCollection LineDataConfigCollection
        {
            get
            {
                if (_lineDataConfigCollection == null)
                {
                    _lineDataConfigCollection = new LineDataConfigCollection();
                }
                return _lineDataConfigCollection;
            }
        } private LineDataConfigCollection _lineDataConfigCollection;

    }


    /// <summary>
    /// 
    /// </summary>
    public class MinMaxFinder
    {
        /// <summary>
        /// 
        /// </summary>
        public double Min
        {
            get { return _min; }
        } private double _min;

        /// <summary>
        /// 
        /// </summary>
        public double Max
        {
            get { return _max; }
        }private double _max;

        /// <summary>
        /// 
        /// </summary>
        bool _hasMin;

        /// <summary>
        /// 
        /// </summary>
        bool _hasMax;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        public void Find(IList list)
        {
            foreach (object obj in list)
            {
                LineDotValue ldv = obj as LineDotValue;
                double value = (double)ldv.Value;

                // min
                //
                if (_hasMin)
                {
                    if (value < _min)
                    {
                        _min = value;
                    }
                }
                else
                {
                    _min = value;
                    _hasMin = true;
                }

                // 
                //
                if (_hasMax)
                {
                    if (value > _max)
                    {
                        _max = value;
                    }
                }
                else
                {
                    _max = value;
                    _hasMax = true;
                }
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ChartFactory
    {
        #region IgnoreAllZeroLine

        /// <summary>
        /// 
        /// </summary>
        public bool IgnoreAllZeroLine
        {
            get { return _ignoreAllZeroLine; }
            set { _ignoreAllZeroLine = value; }
        } private bool _ignoreAllZeroLine = true;
        #endregion //

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tbl"></param>
        /// <param name="cfg"></param>
        /// <returns></returns>
        public OpenFlashChart.OpenFlashChart Create(DataTable tbl, LineChartConfig cfg)
        {
            if (tbl == null || tbl.Rows.Count <= 0)
            {
                throw new ArgumentException("tbl is null or tbl.rows == 0");
            }

            if (cfg == null)
            {
                throw new ArgumentNullException("cfg");
            }

            OpenFlashChart.OpenFlashChart chart = new OpenFlashChart.OpenFlashChart();
            chart.Title = new Title(cfg.Title);

            foreach (LineDataConfig ldcfg in cfg.LineDataConfigCollection)
            {
                LineBase linebase = new LineFactory().CreateLine(tbl, ldcfg, cfg.XAxisFieldName);
                bool isAdd = false;

                if (IgnoreAllZeroLine)
                {
                    if (IsAllZeroLine(linebase))
                    {
                        isAdd = false;
                    }
                    else
                    {
                        isAdd = true;
                    }
                }
                else
                {
                    isAdd = true;
                }
                
                if (isAdd)
                {
                    chart.Elements.Add(linebase);
                }
            }

            // set yaxis
            //
            SetYAxis(chart, cfg.YTitle);

            // set xaxis
            //
            SetXAxis(chart, cfg.XTitle, tbl, cfg.XAxisFieldName);

            return chart;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsAllZeroLine(LineBase line)
        {
            foreach (object obj in line.Values)
            {
                LineDotValue ldv = obj as LineDotValue;
                if (ldv.Value != 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chart"></param>
        /// <param name="title"></param>
        /// <param name="tbl"></param>
        /// <param name="cfg"></param>
        private void SetXAxis(OpenFlashChart.OpenFlashChart chart, string title, DataTable tbl, string xAxisFieldName)
        {
            chart.X_Legend = new Legend(title);

            object objBegin = tbl.Rows[0][xAxisFieldName];
            object objEnd = tbl.Rows[tbl.Rows.Count - 1][xAxisFieldName];

            DateTime begin = Convert.ToDateTime(objBegin);
            DateTime end = Convert.ToDateTime(objEnd);

            AxisCalculator calc = new AxisCalculator();
            calc.Calc(0, tbl.Rows.Count);
            chart.X_Axis.Max = calc.Max;
            chart.X_Axis.Min = calc.Min;
            chart.X_Axis.Steps = (int)calc.Step;

            List<string> lables = CreateXAXisLabels(tbl, xAxisFieldName, (int)calc.Step);
            chart.X_Axis.SetLabels(lables);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tbl"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        private List<string> CreateXAXisLabels(DataTable tbl, string xAxisFieldName, int step)
        {
            if (step <= 0)
            {
                throw new ArgumentOutOfRangeException("step must >= 0");
            }

            List<string> list = new List<string>();
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                DateTime dt = Convert.ToDateTime(tbl.Rows[i][xAxisFieldName]);
                if (i % step == 0)
                {
                    string s = dt.ToString("yyyy-MM-dd" + "\n" + "HH:mm:ss");
                    list.Add(s);
                }
                else
                {
                    list.Add(string.Empty);
                }
            }
            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        private void SetYAxis(OpenFlashChart.OpenFlashChart chart, string title)
        {
            chart.Y_Legend = new Legend(title);

            MinMaxFinder finder = new MinMaxFinder();

            foreach (ChartBase cb in chart.Elements)
            {
                if (cb is LineBase)
                {
                    finder.Find(cb.Values);
                }
            }

            // TODO: finder has value
            //
            double min, max;
            int step;

            CalcYAXisInfo(finder.Min, finder.Max, out min, out max, out step);

            YAxis y = chart.Y_Axis;
            y.Min = min;
            y.Max = max;
            y.Steps = step;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chart"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="step"></param>
        private void CalcYAXisInfo(double minSrc, double maxSrc, out double min, out double max, out int step)
        {
            AxisCalculator c = new AxisCalculator();
            //double minTemp = 0, maxTemp = 0;
            c.Calc(minSrc, maxSrc);
            min = c.Min;
            max = c.Max;
            step = (int)c.Step;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class LineFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private LineBase CreateLine()
        {
            return new LineDot();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tbl"></param>
        /// <param name="cfg"></param>
        /// <returns></returns>
        public LineBase CreateLine(DataTable tbl, LineDataConfig cfg, string xAxisFieldName)
        {
            LineBase line1 = CreateLine();
            line1.Colour = cfg.Color;

            // line name and font size
            //
            line1.Set_Key(cfg.Name, cfg.FontSize);

            //line1.Tooltip = "my tip #val#";
            //line1.Tooltip = "x_label #value#";
            foreach (DataRow row in tbl.Rows)
            {
                double value =0;
                object valueObject = row[cfg.DataFieldName];
                if (valueObject != DBNull.Value)
                {
                    value = Convert.ToDouble(valueObject);
                }

                DateTime dt = Convert.ToDateTime(row[xAxisFieldName]);

                string tip = string.Format("{0}\n{1}\n{2}\n", cfg.Name, dt, value);
                LineDotValue ldValue = new LineDotValue(value, tip, cfg.Color);
                line1.Add(ldValue);
            }
            return line1;
        }


    }
}

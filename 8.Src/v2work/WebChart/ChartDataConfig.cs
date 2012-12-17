using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Data;
using OpenFlashChart;

namespace WebChart
{

    /// <summary>
    /// 
    /// </summary>
    public class ChartDataConfig
    {
        #region ChartDataColor
        /// <summary>
        /// 
        /// </summary>
        public Color ChartDataColor
        {
            get
            {
                return _chartDataColor;
            }
            set
            {
                _chartDataColor = value;
            }
        } private Color _chartDataColor;
        #endregion //ChartDataColor

        #region Key
        /// <summary>
        /// 
        /// </summary>
        public string Key
        {
            get
            {
                if (_chartDataName == null)
                {
                    _chartDataName = "string.Empty";
                }
                return _chartDataName;
            }
            set
            {
                _chartDataName = value;
            }
        } private string _chartDataName;
        #endregion //Key

        #region KeyFontSize
        /// <summary>
        /// 
        /// </summary>
        public double KeyFontSize
        {
            get
            {
                return _keyFontSize;
            }
            set
            {
                _keyFontSize = value;
            }
        } private double _keyFontSize = 14D;
        #endregion //KeyFontSize



        #region DataSource
        /// <summary>
        /// 
        /// </summary>
        public object DataSource
        {
            get
            {
                return _dataSource;
            }
            set
            {
                _dataSource = value;
            }
        } private object _dataSource;
        #endregion //DataSource

        #region DataFieldName
        /// <summary>
        /// 
        /// </summary>
        public string DataFieldName
        {
            get
            {
                if (_dataSourceName == null)
                {
                    _dataSourceName = string.Empty;
                }
                return _dataSourceName;
            }
            set
            {
                _dataSourceName = value;
            }
        } private string _dataSourceName;
        #endregion //DataFieldName

        #region DTFieldName
        /// <summary>
        /// 
        /// </summary>
        public string DTFieldName
        {
            get
            {
                if (_dTFieldName == null)
                {
                    _dTFieldName = string.Empty;
                }
                return _dTFieldName;
            }
            set
            {
                _dTFieldName = value;
            }
        } private string _dTFieldName = "DT";
        #endregion //DTFieldName


        #region TipFormat
        /// <summary>
        /// 
        /// </summary>
        public string TipFormat
        {
            get { return _tipFormat; }
            set { _tipFormat = value; }
        } private string _tipFormat;
        #endregion //TipFormat

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal OpenFlashChart.ChartBase CreateElement()
        {
            LineBase line1 = CreateLine();
            _linebase = line1;
            // color
            //

            // line name and font size
            //
            line1.Set_Key(this.Key, this.KeyFontSize);

            //line1.Tooltip = "my tip #val#";
            //line1.Tooltip = "x_label #value#";
            DataTable tbl = this.DataSource as DataTable;
            foreach (DataRow row in tbl.Rows)
            {
                double value = Convert.ToDouble(row[this.DataFieldName]);
                DateTime dt = Convert.ToDateTime(row[this.DTFieldName]);
                string tip = string.Format("{0}\n{1}", value, dt);
                LineDotValue ldValue = new LineDotValue( value, tip, "#0000ff");
                line1.Add(ldValue);
            }
            return line1;
        }

        /// <summary>
        /// 
        /// </summary>
        public IList<string> XAxisLabels
        {
            get 
            {
                List<string> list = new List<string>();
                DataTable tbl = this.DataSource as DataTable;
                foreach (DataRow row in tbl.Rows)
                {
                    DateTime dt = Convert.ToDateTime(row[this.DTFieldName]);
                    list.Add ( dt.ToString ("yyyy-MM-dd"));
                }
                return list;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public LineBase LineBase
        {
            get { return _linebase; }
        } private LineBase _linebase;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private LineBase CreateLine()
        {
            return new LineDot();
        }

        #region MinValue
        /// <summary>
        /// 
        /// </summary>
        public double MinValue
        {
            get
            {
                LineDotValue min = null;
                foreach (LineDotValue v in this.LineBase.Values)
                {
                    if (min == null)
                    {
                        min = v;
                    }
                    else
                    {
                        if (v.Value < min.Value)
                        {
                            min = v;
                        }
                    }
                }
                return (double)min.Value;
            }
        }
        #endregion //MinValue

        #region MaxValue
        /// <summary>
        /// 
        /// </summary>
        public double MaxValue
        {
            get
            {
                LineDotValue max = null;
                foreach (LineDotValue v in this.LineBase.Values)
                {
                    if (max == null)
                    {
                        max = v;
                    }
                    else
                    {
                        if (v.Value > max.Value)
                        {
                            max = v;
                        }
                    }
                }
                return (double)max.Value;
            }
        }
        #endregion //MaxValue
    }

    #region ChartDataConfigCollection
    /// <summary>
    /// 
    /// </summary>
    public class ChartDataConfigCollection : Xdgk.Common.Collection<ChartDataConfig>
    {
        /// <summary>
        /// 
        /// </summary>
        public double GetMin()
        {
            object obj = null;
            foreach (ChartDataConfig c in this)
            {
                if (obj == null)
                {
                    obj = c.MinValue;
                }
                else
                {
                    double min = (double)obj;
                    double temp = c.MinValue;
                    if (temp< min)
                    {
                        obj = temp;
                    }
                }
            }

            return (double)obj;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double GetMax()
        {
            object obj = null;
            foreach( ChartDataConfig c in this )
            {
                if (obj == null)
                {
                    obj = c.MaxValue;
                }
                else
                {
                    double max = (double)obj;
                    double temp = c.MaxValue;
                    if (max < temp )
                    {
                        obj = temp;
                    }
                }
            }
            return (double)obj;
        }
    }
    #endregion //ChartDataConfigCollection

}

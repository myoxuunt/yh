using System;
using System.Collections.Generic;
using System.Text;
using am.Charts;
using Xdgk.Common;

namespace Xdgk.UI.AMCharts
{


    /// <summary>
    /// 
    /// </summary>
    public class LineChartConfig
    {
        #region YLeftValueMin
        /// <summary>
        /// 
        /// </summary>
        public decimal YLeftValueMin
        {
            get
            {
                return _yLeftValueMin;
            }
            set
            {
                _yLeftValueMin = value;
            }
        } private decimal _yLeftValueMin;
        #endregion //YLeftValueMin

        #region Connect
        /// <summary>
        /// 
        /// </summary>
        public bool Connect
        {
            get
            {
                return _connect;
            }
            set
            {
                _connect = value;
            }
        } private bool _connect;
        #endregion //Connect

        #region DataSeriesIDField
        /// <summary>
        /// 
        /// </summary>
        public string DataSeriesIDField
        {
            get
            {
                if (_dataSeriesIDField == null)
                {
                    _dataSeriesIDField = string.Empty;
                }
                return _dataSeriesIDField;
            }
            set
            {
                _dataSeriesIDField = value;
            }
        } private string _dataSeriesIDField;
        #endregion //DataSeriesIDField

        #region LineGraphItemConfigCollection
        /// <summary>
        /// 
        /// </summary>
        public LineGraphItemConfigCollection LineGraphItemConfigCollection
        {
            get
            {
                if (_lineGraphItemConfigCollection == null)
                {
                    _lineGraphItemConfigCollection = new LineGraphItemConfigCollection();
                }
                return _lineGraphItemConfigCollection;
            }

            set
            {
                _lineGraphItemConfigCollection = value;
            }
        } private LineGraphItemConfigCollection _lineGraphItemConfigCollection;
        #endregion //

    }
}

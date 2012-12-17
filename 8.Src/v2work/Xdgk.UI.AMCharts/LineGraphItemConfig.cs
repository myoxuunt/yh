using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using am.Charts;
using Xdgk.Common;

namespace Xdgk.UI.AMCharts
{
    /// <summary>
    /// 
    /// </summary>
    public class LineGraphItemConfig
    {
        #region DataSeriesItemIDField
        /// <summary>
        /// 
        /// </summary>
        public string DataSeriesItemIDField
        {
            get
            {
                if (_dataSeriesItemIDField == null)
                {
                    _dataSeriesItemIDField = string.Empty;
                }
                return _dataSeriesItemIDField;
            }
            set
            {
                _dataSeriesItemIDField = value;
            }
        } private string _dataSeriesItemIDField;
        #endregion //DataSeriesItemIDField

        #region DataValueField
        /// <summary>
        /// 
        /// </summary>
        public string DataValueField
        {
            get
            {
                if (_dataValueField == null)
                {
                    _dataValueField = string.Empty;
                }
                return _dataValueField;
            }
            set
            {
                _dataValueField = value;
            }
        } private string _dataValueField;
        #endregion //DataValueField

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

        #region Color
        /// <summary>
        /// 
        /// </summary>
        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        } private Color _color;
        #endregion //Color

    }
}

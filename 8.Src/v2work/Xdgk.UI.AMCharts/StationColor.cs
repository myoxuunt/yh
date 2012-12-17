using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.UI.AMCharts
{
    /// <summary>
    /// 
    /// </summary>
    public class StationColor
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stationName"></param>
        /// <param name="color"></param>
        public StationColor(string stationName, Color color)
        {
            if (string.IsNullOrEmpty(stationName))
            {
                throw new ArgumentException("stationName null or empty");
            }

            this.StatinName = stationName;
            this.Color = color;
        }

        #region StatinName
        /// <summary>
        /// 
        /// </summary>
        public string StatinName
        {
            get
            {
                if (_statinName == null)
                {
                    _statinName = string.Empty;
                }
                return _statinName;
            }
            set
            {
                _statinName = value;
            }
        } private string _statinName;
        #endregion //StatinName

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

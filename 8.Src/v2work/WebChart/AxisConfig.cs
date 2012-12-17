using System;
using System.Collections.Generic;
using System.Text;

namespace WebChart
{
    /// <summary>
    /// 
    /// </summary>
    public class AxisConfig
    {

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

        #region Min
        /// <summary>
        /// 
        /// </summary>
        public double Min
        {
            get
            {
                return _min;
            }
            set
            {
                _min = value;
            }
        } private double _min;
        #endregion //Min

        #region Max
        /// <summary>
        /// 
        /// </summary>
        public double Max
        {
            get
            {
                return _max;
            }
            set
            {
                _max = value;
            }
        } private double _max;
        #endregion //Max

        #region Step
        /// <summary>
        /// 
        /// </summary>
        public double Step
        {
            get
            {
                return _step;
            }
            set
            {
                _step = value;
            }
        } private double _step;
        #endregion //Step

    }
}

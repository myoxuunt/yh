using System;
using System.Collections.Generic;
using System.Text;

namespace WebChart
{
    /// <summary>
    /// 
    /// </summary>
    public class AxisCalculator
    {

        /// <summary>
        /// 
        /// </summary>
        public int SegmentNumber
        {
            get { return _segmentNumber; }
            set { _segmentNumber = value; }
        } private int _segmentNumber = 10;

        /// <summary>
        /// 
        /// </summary>
        public void Calc(double min, double max)
        {
            if (min > 0)
            {
                min = 0;
            }

            double distance = max - min;
            double step = distance / (SegmentNumber - 1);

            step = Convert.ToInt32(step);

            this.Min = min;
            this.Max = step + max;
            this.Step = step;
        }


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

        #region Step
        /// <summary>
        /// 
        /// </summary>
        public double Step
        {
            get
            {
                if (_step <= 0)
                {
                    _step = 1;
                }
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

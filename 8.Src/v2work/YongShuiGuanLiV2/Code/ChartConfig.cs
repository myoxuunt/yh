using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace YongShuiGuanLiV2
{
    /// <summary>
    /// 
    /// </summary>
    public class ChartConfig
    {
        /// <summary>
        /// 
        /// </summary>
        static public ChartConfig Default
        {
            get
            {
                return _default;
            }
        } static private ChartConfig _default = new ChartConfig();

        #region Width
        /// <summary>
        /// 
        /// </summary>
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        } private int _width = 800;
        #endregion //Width

        #region Height
        /// <summary>
        /// 
        /// </summary>
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        } private int _height = 600;
        #endregion //Height

        #region Text
        /// <summary>
        /// 
        /// </summary>
        public string Text
        {
            get
            {
                if (_text == null)
                {
                    _text = string.Empty;
                }
                return _text;
            }
            set
            {
                _text = value;
            }
        } private string _text;
        #endregion //Text
    }


    /// <summary>
    /// 
    /// </summary>
    public class XAxisConfgi
    {
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

        #region Text
        /// <summary>
        /// 
        /// </summary>
        public string Text
        {
            get
            {
                if (_text == null)
                {
                    _text = string.Empty;
                }
                return _text;
            }
            set
            {
                _text = value;
            }
        } private string _text;
        #endregion //Text
    }

    /// <summary>
    /// 
    /// </summary>
    public class YAxisConfgi
    {
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

    }

}

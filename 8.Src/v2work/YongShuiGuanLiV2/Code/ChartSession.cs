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
    public class ChartSession
    {

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return this.Name == null || this.Name.Length == 0;
        }


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

        #region Tag
        /// <summary>
        /// 
        /// </summary>
        public object Tag
        {
            get
            {
                return _tag;
            }
            set
            {
                _tag = value;
            }
        } private object _tag;
        #endregion //Tag

        #region ChartConfig
        /// <summary>
        /// 
        /// </summary>
        public object ChartConfig
        {
            get
            {
                return _chartConfig;
            }
            set
            {
                _chartConfig = value;
            }
        } private object _chartConfig;
        #endregion //ChartConfig
    }

    /// <summary>
    /// 
    /// </summary>
    public class ChartSessionManager
    {
        private ChartSession[] _css = new ChartSession[10];

        /// <summary>
        /// 
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        public ChartSession GetChartSession(int no)
        {
            ChartSession obj = _css[no];
            if (obj == null)
            {
                _css[no] = new ChartSession();
                return _css[no];
            }
            else
            {
                return obj;
            }

        }
    }
}

using System;
using System.Configuration;
using System.Collections.Generic;
using System.Text;

namespace RWTrans
{
    public class Config
    {
        /// <summary>
        /// 
        /// </summary>
        public Config()
        {
            FromConnectionString = ConfigurationSettings.AppSettings["FromConnectionString"];
            ToConnectionString = ConfigurationSettings.AppSettings["ToConnectionString"];
            ExecuteTimeSpan = TimeSpan.Parse(ConfigurationSettings.AppSettings["ExecuteTimeSpan"]);
        }

        #region FromConnectionString
        /// <summary>
        /// 
        /// </summary>
        public string FromConnectionString
        {
            get
            {
                if (_fromConnectionString == null)
                {
                    _fromConnectionString = string.Empty;
                }
                return _fromConnectionString;
            }
            set
            {
                _fromConnectionString = value;
            }
        } private string _fromConnectionString;
        #endregion //FromConnectionString

        #region ToConnectionString
        /// <summary>
        /// 
        /// </summary>
        public string ToConnectionString
        {
            get
            {
                if (_toConnectionString == null)
                {
                    _toConnectionString = string.Empty;
                }
                return _toConnectionString;
            }
            set
            {
                _toConnectionString = value;
            }
        } private string _toConnectionString;
        #endregion //ToConnectionString

        #region ExecuteTimeSpan
        /// <summary>
        /// 
        /// </summary>
        public TimeSpan ExecuteTimeSpan
        {
            get
            {
                TimeSpan min = TimeSpan.FromSeconds(5);
                TimeSpan max = TimeSpan.FromDays(1);
                if (_executeTimeSpan < min)
                {
                    _executeTimeSpan = min;
                }
                if (_executeTimeSpan > max)
                {
                    _executeTimeSpan = max;
                }
                return _executeTimeSpan;
            }
            set
            {
                _executeTimeSpan = value;
            }
        } private TimeSpan _executeTimeSpan;
        #endregion //ExecuteTimeSpan

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Communi
{
    public interface IReplaceOption
    {
        /// <summary>
        /// 有效数据时间范围
        /// </summary>
        TimeSpan ValidTimeSpan
        {
            get;
            set;
        }


        /// <summary>
        /// 
        /// </summary>
        object ReplaceNames
        {
            get;
            set;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public interface IAlarmData
    {
        /// <summary>
        /// 
        /// </summary>
        DateTime DT
        {
            get;
            set;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public interface IData
    {
        /// <summary>
        /// 
        /// </summary>
        DateTime DT
        {
            get;
            set;
        }
    }
}

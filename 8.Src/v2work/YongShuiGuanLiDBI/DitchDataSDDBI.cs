using System;
using System.Data ;
using System.Collections.Generic;
using System.Text;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// from vDitchDataSD view
    /// </remarks>
    public class DitchDataSDDBI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceID"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        static public DataTable GetDitchData(int deviceID, DateTime begin, DateTime end)
        {
            string s = string.Format(
                "select * from vDitchData where deviceid={0} and dt >= '{1}' and dt < '{2}' order by DT",
                deviceID , begin ,end);

            return DBI.GetDBI().ExecuteDataTable(s);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// from vDitchDataDaySD
    /// </remarks>
    public class DitchDataDaySDDBI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        static public DataTable GetDayDitchData(int deviceID, DateTime  begin, DateTime end)
        {
            string s = string.Format(
                "select * from vDitchDataDaySD where deviceid={0} and dt >= '{1}' and dt < '{2}' order by DT",
                deviceID, begin, end);
            return DBI.GetDBI().ExecuteDataTable(s);
        }
    }
}

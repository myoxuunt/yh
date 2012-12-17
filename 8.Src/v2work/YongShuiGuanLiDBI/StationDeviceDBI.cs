using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Xdgk.Common;
using System.Data.SqlClient;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class StationDeviceDBI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserID"></param>
        /// <returns></returns>
        static public DataTable GetStationDeviceDataTable()
        {
            string s = "select * from vStationDevice";
            return DBI.GetDBI().ExecuteDataTable(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserID"></param>
        /// <returns></returns>
        static public DataTable GetStationDeviceDataTable(int waterUserID)
        {
            string s = string.Format(
                "select * from vWaterUserChannelStationDevice where waterUserID = {0}",
                waterUserID);

            return DBI.GetDBI().ExecuteDataTable(s);
        }
    }
}

using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace YongShuiGuanLiDBI
{
    public class RainDBI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="deviceIDs"></param>
        /// <returns></returns>
        static public DataTable GetData( DateTime begin, DateTime end, int[] deviceIDs)
        {
            string deviceIDsString = SqlHelper.MakeInQueryCondition(deviceIDs);
            string s = string.Format(
                "select * from vRainFillData where (deviceid in ({0}))  and ( dt >= '{1}' and dt < '{2}') order by DT",
                deviceIDsString, begin, end);
            return DBI.GetDBI().ExecuteDataTable(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="deviceIDs"></param>
        /// <returns></returns>
        public static DataTable GetDayData(DateTime begin, DateTime end, int[] deviceIDs)
        {

            string sql =
"select stationid, deviceid, name, convert(varchar(10), dt,120)  as dt, sum(rainfill) as RainFill from vrainfilldata " +
"where (deviceid in ({0}))  and ( dt >= '{1}' and dt < '{2}') " +
"group by stationid,deviceid, name, convert(varchar(10), dt,120) " +
"order by DT ";

            string deviceIDsString = SqlHelper.MakeInQueryCondition(deviceIDs);
            sql = string.Format(sql, deviceIDsString, begin, end);

            return DBI.GetDBI().ExecuteDataTable(sql);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceIDs"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static DataTable GetSumData(int[] deviceIDs, DateTime begin, DateTime end)
        {
            string sql =
            "select stationid, deviceid, name, sum(rainfill) as RainFill from vrainfilldata " +
            "where (deviceid in ({0}))  and ( dt >= '{1}' and dt < '{2}') " +
            "group by stationid,deviceid, name";
            string deviceIDsString = SqlHelper.MakeInQueryCondition(deviceIDs);
            sql = string.Format(sql, deviceIDsString, begin, end);

            return DBI.GetDBI().ExecuteDataTable(sql);

        }
    }
}

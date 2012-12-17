using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class SluiceDataDBI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="stationIDs"></param>
        /// <returns></returns>
        static public DataTable GetDataByStationIDs(DateTime begin, DateTime end, int[] stationIDs)
        {
            string dataTableName = GetDataTableName(begin, end);
            string stationIDsString = SqlHelper.MakeInQueryCondition(stationIDs );
            string s = string.Format(
                "select * from {3} where (stationid in ({0}))  and ( dt >= '{1}' and dt < '{2}') order by DT",
                stationIDsString, begin, end, dataTableName);
            return DBI.GetDBI().ExecuteDataTable(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private static string GetDataTableName(DateTime begin, DateTime end)
        {
            return "vMeasureSluiceData";
        }

    }
}

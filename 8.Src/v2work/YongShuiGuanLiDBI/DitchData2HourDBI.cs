using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class DitchData2HourDBI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="sc"></param>
        /// <returns></returns>
        static public DataTable Execute2HourDataTable(DateTime begin, DateTime end, string[] stationNames)
        {
            string columns = SqlRowColumnConverter.MakeColumnsSql(stationNames, "StationName", "AVGWL");
            string where = string.Format("StationName in ({0})", SqlHelper.MakeInQueryCondition(stationNames));
            
            string s = string.Format(
                "select dt, {0} from vDitchData2Hour where (dt >= '{1}' and dt < '{2}') " + 
                " and {3} group by dt order by dt",
                 columns, begin, end, where );

            return DBI.GetDBI().ExecuteDataTable(s);

        }
    }
}

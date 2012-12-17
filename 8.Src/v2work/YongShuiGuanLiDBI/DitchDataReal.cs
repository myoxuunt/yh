using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class DitchDataRealDBI
    {
        // TODO: 2011-05-18 water user 's station real data
        //

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public DataTable GetDitchDataRealDataTable()
        {
            string s = "select * from vDitchDataReal order by DT";
            return DBI.GetDBI().ExecuteDataTable(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stationIDs"></param>
        /// <returns></returns>
        static public DataTable GetDitchDataRealDataTable(int[] stationIDs)
        {
            string inString = SqlHelper.MakeInQueryCondition(stationIDs);
            string f = "select * from vDitchDataReal where stationID in ({0}) order by DT";
            string s = string.Format(f, inString);
            return DBI.GetDBI().ExecuteDataTable(s);
        }
    }
}

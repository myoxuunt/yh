using System;
using System.Collections.Generic;
using System.Text;
using System.Data ;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class DitchDataLastDBI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public DataTable GetDataTable()
        {
            string s = "select * from vDitchDataLast";
            return DBI.GetDBI().ExecuteDataTable(s);
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="waterUserID"></param>
        ///// <returns></returns>
        //static public DataTable GetDitchDataLastDataTable(int waterUserID)
        //{
        //    // TODO: 2011-06-17
        //    //
        //    return null;
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stationIDs"></param>
        internal static DataTable GetDitchDataLastDataTable(int[] stationIDs)
        {

            string inString = SqlHelper.MakeInQueryCondition(stationIDs);
            string s = "select * from vDitchDataLast where StationID in ({0})";
            s = string.Format(s, inString);
            return DBI.GetDBI().ExecuteDataTable(s);
        }
    }
}

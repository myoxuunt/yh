using System;
using System.Collections.Generic;
using System.Text;
using System.Data ;
using System.Collections;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class DitchDataDayDBI
    {


        #region MakeColumnSql
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        static private string MakeColumnSql(string name, DataEnum de)
        {
            string dataColumnName = DataEnumClass.GetDataColumnNameByDataEnum(de);
            string s = string.Format(
                "Max( Case when StationName = '{0}' then {1} end ) as '{0}'",
                name, dataColumnName);
            return s;
        }
        #endregion //MakeColumnSql


        #region MakeColumns
        /// <summary>
        /// 
        /// </summary>
        /// <param name="names"></param>
        /// <returns></returns>
        static private string MakeColumns(string[] names, DataEnum de)
        {
            if (names == null || names.Length == 0)
                throw new ArgumentException("names null or length == 0");

            string s = string.Empty ;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < names.Length - 1; i++)
            {
                s = MakeColumnSql(names[i], de);
                sb.Append(s + ",");
            }

            s = MakeColumnSql(names[names.Length - 1], de);
            sb.Append(s);

            return sb.ToString();
        }
        #endregion //MakeColumns


        #region MakeWheres
        /// <summary>
        /// 
        /// </summary>
        /// <param name="names"></param>
        /// <returns></returns>
        static private string MakeWheres(string[] names)
        {
            string s = string.Format("stationName in ({0})",
                SqlHelper.MakeInQueryCondition(names));
            return s;
        }
        #endregion //MakeWheres


        #region MakeSql
        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="stationNames"></param>
        /// <returns></returns>
        static private string MakeSql(DateTime begin, DateTime end, string[] stationNames, DataEnum de)
        {
            // 0
            string columns = MakeColumns(stationNames, de);
            string nameWhere = MakeWheres(stationNames);

            string s = 
                "select DT, {0} from vDitchDataDay where (dt >= '{1}' and dt < '{2}') " +
                " and {3} group by DT order by DT";
            s = string.Format(s, columns, begin, end, nameWhere);
            return s;
        }
        #endregion //MakeSql


        #region GetDayDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <param name="day"></param>
        /// <param name="channelID"></param>
        /// <returns></returns>
        static public DataTable GetDayDataTable( DateTime begin, DateTime end, string[] stationNames, DataEnum de)
        {
            string s = MakeSql(begin, end, stationNames,de);

            DataTable tbl = DBI.GetDBI().ExecuteDataTable(s);
            return tbl;
        }
        #endregion //GetDayDataTable

        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="stationIDs"></param>
        /// <returns></returns>
        static public DataTable GetDayDataTableWithRow(DateTime begin, DateTime end, int[] stationIDs)
        {
            string stationIDsString = SqlHelper.MakeInQueryCondition(stationIDs);

            string s =
            "select  channelName, stationid, stationname, deviceid, convert(nvarchar(10),dt, 120) as dt, " +
              "avg(wl1) as wl1, avg(instantflux)  as instantflux, avg(instantflux) * 24 * 60 * 60 as dayAmount " +
            "from vditchdata " +
            "where stationid in ({0}) and dt >='{1}' and dt < '{2}' " +
            "group by channelName, stationid, stationname, deviceid, convert(nvarchar(10),dt, 120) " +
            "order by dt";

            s = string.Format(s, stationIDsString, begin, end);

            return DBI.GetDBI().ExecuteDataTable(s);
        }


        //static public DataTable GetDayDataTable(DateTime begin, DateTime end, int[] deviceids, DataEnum de)
        //{

        //}
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data ;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class WaterUserLevelDBI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public DataTable GetWaterUserLevelDataTable(int id)
        {
            string s = string.Format(
                "select * from tblWaterUserLevel where deleted=0 and waterUserLevelID = {0}",
                id);

            return DBI.GetDBI().ExecuteDataTable(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public DataTable GetWaterUserLevelDataTable()
        {
            string s = string.Format("select * from tblWaterUserLevel where deleted=0");
            return DBI.GetDBI().ExecuteDataTable(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        internal static DataTable GetWaterUserLevelDataTableByOrdinal(int ordinal)
        {
            string s = string.Format("select * from tblWaterUserLevel where ordinal = {0}",
                ordinal);
            return DBI.GetDBI().ExecuteDataTable(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="le"></param>
        /// <returns></returns>
        static public int GetWaterUserLevelID(WaterUserLevelEnum le)
        {
            DataTable tbl = GetWaterUserLevelDataTableByOrdinal((int)le);
            if (tbl.Rows.Count > 0)
            {
                return Convert.ToInt32(tbl.Rows[0][DBNames.tblWaterUserLevel.WaterUserLevelID]);
            }
            else
            {
                return 0;
            }
        }
    }
}

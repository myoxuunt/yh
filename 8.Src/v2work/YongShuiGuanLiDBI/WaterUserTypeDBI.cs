using System;
using System.Collections.Generic;
using System.Text;
using System.Data ;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class WaterUserTypeDBI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public DataTable GetWaterUserTypeDataTable()
        {
            //string s = "select * from tblWaterUserType where isManager = 0";
            string s = "select * from tblWaterUserType";
            return DBI.GetDBI().ExecuteDataTable(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public DataTable GetWaterUserTypeDataTable(int waterUserTypeID)
        {
            string s = string.Format(
                //"select * from tblWaterUserType where waterUserTypeID = {0} and isManager = 0",
                "select * from tblWaterUserType where waterUserTypeID = {0}",
                waterUserTypeID);

            return DBI.GetDBI().ExecuteDataTable(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal static DataTable GetManagerWaterUserDataTable()
        {
            // TODO: 2011-05-19
            // 
            //string s = string.Format("select * from tblWaterUserType where isManager = 1");
            string s = string.Format("select * from tblWaterUserType");

            return DBI.GetDBI().ExecuteDataTable(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public DataTable GetDefaultWaterUserTypeDataTable()
        {
            // TODO: 2011-05-19
            // remove isManager
            //
            //string s = string.Format("select top 1 * from tblWaterUserType where isManager = 0 order by waterUserTypeID");
            string s = string.Format("select top 1 * from tblWaterUserType order by waterUserTypeID");
            return DBI.GetDBI().ExecuteDataTable(s);
        }
    }
}

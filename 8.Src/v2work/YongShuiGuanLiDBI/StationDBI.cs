using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Drawing;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class StationDBI
    {


        #region GetStationDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public DataTable GetStationDataTable()
        {
            string s = "select * from tblStation";
            //string s = "select * from vStationDevice";
            return DBI.GetDBI().ExecuteDataTable(s);
        }
        #endregion //GetStationDataTable

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public DataTable GetRainStationDataTable()
        {
            string RAIN_TYPE = "CQRain";
            string s = "select * from vstationdevice where deviceType = '{0}'";
            s = string.Format(s, RAIN_TYPE);

            return DBI.GetDBI().ExecuteDataTable(s);
        }


        #region GetNotAssociateStationDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public DataTable GetNotAssociateStationDataTable()
        {
            string s = @"select * from tblstation where deleted = 0 and 
                    	stationid not in (select stationid from tblchannelstationmap)";
            return DBI.GetDBI().ExecuteDataTable(s);
        }
        #endregion //GetNotAssociateStationDataTable



        #region GetStationDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stationID"></param>
        /// <returns></returns>
        public static DataTable GetStationDataTable(int stationID)
        {
            string s = string.Format("select * from tblstation where stationid = {0} and deleted = 0",
                stationID);
            return DBI.GetDBI().ExecuteDataTable(s);
        }
        #endregion //GetStationDataTable


        #region GetStationDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stationIDs"></param>
        /// <returns></returns>
        public static DataTable GetStationDataTable(int[] stationIDs)
        {
            string inCondition = SqlHelper.MakeInQueryCondition(stationIDs);
            string s = string.Format("select * from tblStation where deleted = 0 and StationID in ({0})",
               inCondition);

            return DBI.GetDBI().ExecuteDataTable(s);
        }
        #endregion //GetStationDataTable

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceTypes"></param>
        /// <returns></returns>
        public static DataTable GetStationDataTable(string[] deviceTypes)
        {
            string inCondition = SqlHelper.MakeInQueryCondition(deviceTypes);
            string s = string.Format(
                "select * from vStationDevice where deviceType in ({0}) order by DeviceType, StationName",
                inCondition);

            return DBI.GetDBI().ExecuteDataTable(s);
        }




        #region GetStationDataTableByDeviceID
        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceID"></param>
        /// <returns></returns>
        internal static DataTable GetStationDataTableByDeviceID(int deviceID)
        {
            string s = string.Format(
                @"select * from tblStation where deleted = 0 and stationID in 
                    (select stationID from tblDevice where deviceid = {0})",
                deviceID
                );
            return DBI.GetDBI().ExecuteDataTable(s);
        }
        #endregion //GetStationDataTableByDeviceID



        public static void UpdateStationName(int id, string newName)
        {
            string s = string.Format("Update tblStation set name = '{0}' where stationid = {1}", newName, id);
            DBI.GetDBI().ExecuteScalar(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="color"></param>
        public static void UpdateColor(int id, Color color)
        {
            string s = string.Format(
                "update tblStation set Color = '{1}' where stationid = {0}",
                id, color.ToArgb().ToString());
            DBI.GetDBI().ExecuteScalar(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newname"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool Exist(string newname, int exclude)
        {
            string s = string.Format(
                "select count(*) from tblStation where Name = '{0}' and stationID <> {1} and deleted = 0",
                newname, exclude);
            object obj = DBI.GetDBI().ExecuteScalar(s);

            int n = Convert.ToInt32(obj);
            return n > 0;
        }
    }
}

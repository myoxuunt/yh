using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Diagnostics;
using Xdgk.Common;

namespace XDYHZKWeb
{
    /// <summary>
    /// 
    /// </summary>
    public class XDYHZKWebDBI : DBIBase 
    {


        #region XDYHZKWebDBI
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connString"></param>
        public XDYHZKWebDBI(string connString)
            : base(connString)
        #endregion //XDYHZKWebDBI
        {

        }


        #region XDYHZKWebDBI
        /// <summary>
        /// 
        /// </summary>
        static public XDYHZKWebDBI Default
        {
            get
            {
                if (s_default == null)
                {
                    string connString = ConfigurationSettings.AppSettings["ConnectionString"];
                    s_default = new XDYHZKWebDBI(connString);
                    //s_default.Open();
                }
                return s_default;
            }
        } static private XDYHZKWebDBI s_default;
        #endregion //XDYHZKWebDBI

        // 
        /// 
        //


        #region GetLastDataTime
        /// <summary>
        /// get a datatable last datetime 
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public DateTime GetLastDataTime(string tableName)
        {
            string sql = string.Format("select top 1 DT from {0} order by DT desc", tableName);
            object obj = this.ExecuteScalar(sql);
            if (obj != null)
            {
                return Convert.ToDateTime(obj);
            }
            return DateTime.Parse("1900-1-1");
        }
        #endregion //GetLastDataTime


        // insert new datas to a datatable
        //


        //#region InsertDatas
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="tableName"></param>
        ///// <param name="tbl"></param>
        //public void InsertDatas(string tableName, DataTable dataTable)
        //{
        //    if (StringHelper.Equal("tblWaterLevelData", tableName))
        //    {
        //        InsertWaterLevelDatas(dataTable);
        //    }
        //    else if (StringHelper.Equal("tblSluiceData", tableName))
        //    {
        //        InsertSluiceDatas(dataTable);
        //    }
        //    else
        //    {
        //        // TODO:
        //        //
        //    }
        //}
        //#endregion //InsertDatas


        #region InsertSluiceDatas
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// get deviceid by stationName and devcietype
        /// insert deviceid, DT, height, beforeWL, behindWL
        /// </remarks>
        public void InsertSluiceDatas(DataTable dataTable)
        {
            foreach (DataRow dr in dataTable.Rows)
            {
                string stationName = dr["StationName"].ToString();
                string deviceType = dr["DeviceType"].ToString();

                DateTime dt = Convert.ToDateTime(dr["DT"]);
                int height = Convert.ToInt32(dr["Height"]);
                int beforeWL = Convert.ToInt32(dr["BeforeWL"]);
                int behindWL = Convert.ToInt32(dr["BehindWL"]);

                int deviceid = GetDeviceID(stationName, deviceType);
                Debug.Assert(deviceid > 0, "deviceid must > 0, current value: " + deviceid );
                string sql = "insert into tblSluiceData(deviceid, dt, height, beforeWL, behindWL) values( {0}, '{1}', {2}, {3}, {4})";
                sql = string.Format(sql, deviceid, dt, height, beforeWL, behindWL);
                ExecuteScalar(sql);
            }
        }
        #endregion //InsertSluiceDatas


        #region InsertWaterLevelDatas
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataTable"></param>
        public void InsertWaterLevelDatas(DataTable dataTable)
        {
            foreach (DataRow dr in dataTable.Rows)
            {
                string stationName = dr["StationName"].ToString();
                DateTime dt = Convert.ToDateTime(dr["DT"]);
                int beforeWL = Convert.ToInt32(dr["BeforeWL"]);
                int behindWL = Convert.ToInt32(dr["BehindWL"]);
                string deviceType = dr["deviceType"].ToString();

                int deviceid = GetDeviceID(stationName, deviceType);

                string sql = string.Format(
                    "insert into tblWaterLevelData(DeviceID, DT, BeforeWL, BehindWL) values( {0}, '{1}', {2}, {3} )", 
                    deviceid, dt, beforeWL, behindWL
                    );
                this.ExecuteScalar(sql);
            }
        }
        #endregion //InsertWaterLevelDatas



        #region GetDeviceID
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stationName"></param>
        /// <param name="deviceType"></param>
        /// <returns></returns>
        private int GetDeviceID(string stationName, string deviceType)
        {
            int stationID = GetStationID(stationName);
            return GetDeviceID(deviceType, stationID);
        }
        #endregion //GetDeviceID


        #region GetDeviceID
        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceType"></param>
        /// <param name="stationID"></param>
        /// <returns></returns>
        private int GetDeviceID(string deviceType, int stationID)
        {
            string sql = "select deviceID from tblDevice where stationID = {0}";
            sql = string.Format(sql, stationID);
            object obj = ExecuteScalar(sql);
            if (obj == null)
            {
                return CreateDevcie(deviceType, stationID);
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        #endregion //GetDeviceID


        #region CreateDevcie
        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceType"></param>
        /// <param name="stationID"></param>
        /// <returns></returns>
        private int CreateDevcie(string deviceType, int stationID)
        {
            string sql = "insert into tblDevice(stationID, deviceType) values({0}, '{1}')";
            sql = string.Format(sql, stationID, deviceType);
            object obj = ExecuteScalar(sql);
            //return Convert.ToInt32(obj);
            return this.GetIdentity();
        }
        #endregion //CreateDevcie


        #region GetStationID
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stationName"></param>
        /// <returns></returns>
        private int GetStationID(string stationName)
        {
            string sql = "select stationID from tblStation where name = '{0}'";
            sql = string.Format(sql, stationName);

            object obj = this.ExecuteScalar(sql);
            if (obj == null)
            {
                return CreateStation(stationName);
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        #endregion //GetStationID


        #region CreateStation
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stationName"></param>
        /// <returns></returns>
        private int CreateStation(string stationName)
        {
            string sql = "Insert into tblStation(name) values ('{0}')";
            sql = string.Format(sql, stationName);
            this.ExecuteScalar(sql);
            return this.GetIdentity();
        }
        #endregion //CreateStation

        //#region
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //public DataTable GetTestDataTable()
        //{
        //    string sql = "select * from tblDevice";
        //    return this.ExecuteDataTable(sql);
        //}
        //#endregion //

    }
}

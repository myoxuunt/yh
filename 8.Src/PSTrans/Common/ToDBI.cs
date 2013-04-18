using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using Xdgk.Common;

namespace Common 
{
    public class ToDBI : DBIBase 
    {
        #region ToDBI
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString"></param>
        public ToDBI(string connectionString) :
            base(connectionString)
        {
        }
        #endregion //ToDBI

        #region GetToInfo
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fromName"></param>
        /// <param name="toName"></param>
        /// <param name="toStationID"></param>
        /// <param name="toDeviceID"></param>
        public void GetToInfo(string fromName, string type, 
            out string toName, out int toStationID, out int toDeviceID)
        {
            // init out values 
            //
            toName = string.Empty ;
            toStationID = 0;
            toDeviceID = 0;

            int stationID = GetStationID(fromName);
            int deviceID = GetDeviceID(stationID, type);

            toName = fromName;
            toStationID = stationID;
            toDeviceID = deviceID;
        }
        #endregion //GetToInfo

        #region GetStationID
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fromName"></param>
        /// <returns></returns>
        private int GetStationID(string fromName)
        {
            string sql = string.Format(
                "select stationid from tblStation where name = '{0}'",
                fromName
                );
            object obj = ExecuteScalar(sql);
            if (obj != null && obj != DBNull.Value)
            {
                return (int)obj;
            }
            else
            {
                CreateStation(fromName);
                return GetStationID(fromName);
            }

        }
        #endregion //GetStationID

        #region CreateStation
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fromName"></param>
        /// <returns></returns>
        private void CreateStation(string fromName)
        {
            string sql = string.Format(
            "insert into tblStation( Name ) values( '{0}' )",
            fromName);

            ExecuteScalar(sql);
        }
        #endregion //CreateStation

        #region GetDeviceID
        private int GetDeviceID(int stationID, string type)
        {
            string sql = string.Format(
                "select deviceid from tblDevice where stationID = {0} and DeviceType = '{1}'",
                stationID, 
                type
                );

            object obj = ExecuteScalar(sql);
            if (obj != null && obj != DBNull.Value)
            {
                return (int)obj;
            }
            else
            {
                CreateDevice(stationID, type);
                return GetDeviceID(stationID, type);
            }
        }
        #endregion //GetDeviceID

        #region CreateDevice
        private void CreateDevice(int stationID, string type)
        {
            string sql = string.Format(
                "insert into tblDevice (stationID, DeviceType, address) values ({0}, '{1}', 0)",
                stationID,
                type
                );

            ExecuteScalar(sql);
        }
        #endregion //CreateDevice

        #region GetLastDateTime
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public DateTime GetLastDateTime(int deviceID ,DataType dataType)
        {
            string tableName = GetTableName(dataType);
            string sql = string.Format(
                "select max(DT) from {1} where deviceid = {0}",
                deviceID,
                tableName
                );
            object obj = ExecuteScalar(sql);
            if (obj != null && obj != DBNull.Value)
            {
                return (DateTime)obj;
            }
            else
            {
                return DateTime.Parse("1900-1-1");
            }
        }
        #endregion //GetLastDateTime

        #region GetTableName
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataType"></param>
        /// <returns></returns>
        private string GetTableName(DataType dataType)
        {
            switch (dataType)
            {
                case DataType.Water :
                    return "tblDitchData";
                case DataType.Rain :
                    return "tblRainFillData";
                default :
                    throw new ArgumentException(dataType.ToString());
            }
        }
        #endregion //GetTableName

        #region InsertRain
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ToDeviceID"></param>
        /// <param name="dt"></param>
        /// <param name="rain"></param>
        public void InsertRain(int ToDeviceID, DateTime dt, float rain)
        {
            string sql = string.Format(
                "insert into tblRainFillData(deviceid, dt, rainfill) values ( {0}, '{1}', {2} )",
                ToDeviceID,
                dt,
                rain);

            ExecuteScalar(sql);

        }
        #endregion //InsertRain

        #region InsertWater
        public void InsertWater(int ToDeviceID, DateTime dt, float wl, float instantFlux)
        {
            float MIN = 0, MAX = 32760;
            if (wl > MAX)
            {
                wl = MAX;
            }

            if (wl < MIN)
            {
                wl = MIN;
            }

            string sql = string.Format(
                "insert into tblDitchData(deviceid, dt, wl1, InstantFlux) values ( {0}, '{1}', {2}, {3} )",
                ToDeviceID,
                dt,
                wl,
                instantFlux);
            ExecuteScalar(sql);
        }
        #endregion //InsertWater

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceid"></param>
        /// <returns></returns>
       public DataTable GetFormulaDataTable(int deviceid)
        {
            string s = string.Format(
                "select * from tblFormula where deviceID = {0}",
                deviceid);
            return this.ExecuteDataTable(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceid"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="express"></param>
        public int InsertFormula(int deviceid, DateTime begin, DateTime end, string express)
        {
            string s = string.Format(
                "insert into tblFormula(deviceid, dtbegin, dtend, formula) values ({0}, '{1}', '{2}' , '{3}' );" +
                "select @@identity",
                deviceid, begin, end, express 
                );

            object obj = this.ExecuteScalar(s);
            if (obj != null && obj != DBNull.Value)
            {
                return Convert.ToInt32(obj);
            }
            throw new Exception("Insert formula fail.");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="express"></param>
        public void UpdateFormula(int id, DateTime begin, DateTime end, string express)
        {
            string s = string.Format(
                "update tblFormula set dtbegin = '{1}', dtend = '{2}', formula = '{3}' where formulaid = {0}",
                id, begin, end, express );
            this.ExecuteScalar(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void DeleteFormula(int id)
        {
            string s = string.Format(
                "delete from tblformula where formulaid = {0}", 
                id);
            this.ExecuteScalar(s);
        }
    }
}

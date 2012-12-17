using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class DeviceAlarmManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceID"></param>
        /// <param name="wl"></param>
        /// <returns></returns>
        public bool IsBeyondScopeOfAlarm(int deviceID, int wl)
        {
            return  this.DeviceAlarmCollection.IsBeyongScopeOfAlarm(deviceID, wl); 
        }

        /// <summary>
        /// 
        /// </summary>
        public DeviceAlarmCollection DeviceAlarmCollection
        {
            get
            {
                if (_deviceAlarmCollection == null)
                {
                    _deviceAlarmCollection = new DeviceAlarmCollection();
                }
                return _deviceAlarmCollection;
            }
        } private DeviceAlarmCollection _deviceAlarmCollection;
    }

    /// <summary>
    /// 
    /// </summary>
    public class DeviceAlarmCollection : Xdgk.Common.Collection<DeviceAlarm>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceID"></param>
        /// <param name="wl"></param>
        /// <returns></returns>
        public bool IsBeyongScopeOfAlarm(int deviceID, int wl)
        {
            DeviceAlarm a = Find(deviceID);
            return a.IsBeyongScopeOfAlarm(wl);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceID"></param>
        /// <returns></returns>
        private DeviceAlarm Find( int deviceID )
        {
            foreach (DeviceAlarm item in this)
            {
                if (item.DeviceID == deviceID)
                {
                    //return item.IsBeyongScopeOfAlarm(wl);
                    return item;
                }
            }

            DeviceAlarm newAlarm = BuildDeviceAlarm(deviceID);
            this.Add(newAlarm);
            return newAlarm;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceID"></param>
        /// <returns></returns>
        private DeviceAlarm BuildDeviceAlarm(int deviceID)
        {
            DeviceAlarm a = DeviceAlarmFactory.Create(deviceID);
            return a;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class DeviceAlarm
    {
        #region DeviceAlarmID
        /// <summary>
        /// 
        /// </summary>
        public int DeviceAlarmID
        {
            get
            {
                return _deviceAlarmID;
            }
            set
            {
                _deviceAlarmID = value;
            }
        } private int _deviceAlarmID;
        #endregion

        #region DeviceID
        /// <summary>
        /// 
        /// </summary>
        public int DeviceID
        {
            get
            {
                return _deviceID;
            }
            set
            {
                _deviceID = value;
            }
        } private int _deviceID;
        #endregion //DeviceID

        #region LowLimit
        /// <summary>
        /// 
        /// </summary>
        public int LowLimit
        {
            get
            {
                return _lowLimit;
            }
            set
            {
                _lowLimit = value;
            }
        } private int _lowLimit;
        #endregion //LowLimit

        #region HighLimit
        /// <summary>
        /// 
        /// </summary>
        public int HighLimit
        {
            get
            {
                return _highLimit;
            }
            set
            {
                _highLimit = value;
            }
        } private int _highLimit;
        #endregion //HighLimit

        #region HasHighLimit
        /// <summary>
        /// 
        /// </summary>
        public bool HasHighLimit
        {
            get
            {
                return _hasHighLimit;
            }
            set
            {
                _hasHighLimit = value;
            }
        } private bool _hasHighLimit;
        #endregion //HasHighLimit

        #region HasLowLimit
        /// <summary>
        /// 
        /// </summary>
        public bool HasLowLimit
        {
            get
            {
                return _hasLowLimit;
            }
            set
            {
                _hasLowLimit = value;
            }
        } private bool _hasLowLimit;
        #endregion //HasLowLimit

        /// <summary>
        /// 
        /// </summary>
        /// <param name="wl"></param>
        /// <returns></returns>
        public bool IsBeyongScopeOfAlarm(int wl)
        {
            if (
                (HasHighLimit && (wl >= HighLimit)) ||
                (HasLowLimit && (wl <= LowLimit))
                )
            {
                return true;
            }

            return false;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class DeviceAlarmFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceid"></param>
        /// <returns></returns>
        static public DeviceAlarm Create(int deviceid)
        {
            DeviceAlarm a = null;
            DataTable tbl = DeviceAlarmDBI.GetDataTable(deviceid);
            if (tbl.Rows.Count > 0)
            {
                DataRow row = tbl.Rows[0];
                a = Create(row);
            }
            else
            {
                a = new DeviceAlarm();
                a.DeviceID = deviceid;
                a.HasLowLimit = false;
                a.HasHighLimit = false;
            }

            return a;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private static DeviceAlarm Create(DataRow row)
        {
            DeviceAlarm a = new DeviceAlarm();
            a.DeviceID = Convert.ToInt32(row["DeviceID"]);
            object highObject = row["HighLimit"];
            if (highObject == DBNull.Value)
            {
                a.HasHighLimit = false;
            }
            else
            {
                a.HasHighLimit = true;
                a.HighLimit = Convert.ToInt32(highObject);
            }

            object lowObject = row["LowLimit"];
            if (lowObject == DBNull.Value)
            {
                a.HasLowLimit = false;
            }
            else
            {
                a.HasLowLimit = true;
                a.LowLimit = Convert.ToInt32(lowObject);
            }
            return a;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class DeviceAlarmDBI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceid"></param>
        /// <returns></returns>
        internal static DataTable GetDataTable(int deviceid)
        {
            string s = string.Format(
                "select * from tblAlarm where deviceid = {0}", 
                deviceid
                );

            return DBI.GetDBI().ExecuteDataTable(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="highLimit"></param>
        public static void Insert(int deviceID, int highLimit)
        {
            string s = string.Format(
                "INSERT INTO tblAlarm( DeviceID, HighLimit) " +
                "VALUES('{0}', '{1}')",
                deviceID, highLimit);

            DBI.GetDBI().ExecuteScalar(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="alarmID"></param>
        /// <param name="highLimit"></param>
        public static void Update(int alarmID, int highLimit)
        {
            string s = string.Format(
                "UPDATE tblAlarm SET HighLimit='{1}'  " +
                "WHERE AlarmID = '{0}'",
                alarmID, highLimit);
            DBI.GetDBI().ExecuteScalar(s);
        }

        public static void Delete(int deviceID)
        {
            string s = string.Format("delete from tblAlarm where DeviceID = {0}",
                deviceID);
            DBI.GetDBI().ExecuteScalar(s);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="highLimit"></param>
        public static void Save(int deviceID, int highLimit)
        {
            Delete(deviceID);
            Insert(deviceID, highLimit);
        }
    }

}

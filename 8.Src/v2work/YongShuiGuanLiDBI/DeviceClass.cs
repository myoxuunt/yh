using System;
using System.Data ;
using System.Collections.Generic;
using System.Text;
using Xdgk.Common;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class DeviceClass
    {
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

        #region DeviceKind
        /// <summary>
        /// 
        /// </summary>
        public string DeviceKind
        {
            get
            {
                if (_deviceKind == null)
                {
                    _deviceKind = string.Empty;
                }
                return _deviceKind;
            }
            set
            {
                _deviceKind = value;
            }
        } private string _deviceKind;
        #endregion //DeviceKind

        #region DeviceType
        /// <summary>
        /// 
        /// </summary>
        public string DeviceType
        {
            get
            {
                if (_deviceType == null)
                {
                    _deviceType = string.Empty;
                }
                return _deviceType;
            }
            set
            {
                _deviceType = value;
            }
        } private string _deviceType;
        #endregion //DeviceType

        #region DeviceRemark
        /// <summary>
        /// 
        /// </summary>
        public string DeviceRemark
        {
            get
            {
                if (_deviceRemark == null)
                {
                    _deviceRemark = string.Empty;
                }
                return _deviceRemark;
            }
            set
            {
                _deviceRemark = value;
            }
        } private string _deviceRemark;
        #endregion //DeviceRemark

        #region StationName
        /// <summary>
        /// 
        /// </summary>
        public string StationName
        {
            get 
            {
                return this.StationClass.StationName;
            }
        }
        #endregion //StationName

        #region StationClass
        /// <summary>
        /// 
        /// </summary>
        public StationClass StationClass 
        {
            get 
            {
                if (_stationClass == null)
                {
                    // TODO: device.station
                    //
                    //_stationClass  = 
                    _stationClass = StationFactory.CreateStation(this.DeviceID);
                }
                return _stationClass;
            }
        } private StationClass _stationClass;
        #endregion //StationClass


        #region CalcUsedAmount
        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public double CalcUsedAmount(DateTime begin, DateTime end)
        {
            return DeviceDBI.CalcUsedAmount(this.DeviceID, begin, end);
        }
        #endregion //CalcUsedAmount


        #region GetDitchData
        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public DataTable GetDitchData(DateTime begin, DateTime end)
        {
            return DitchDataSDDBI.GetDitchData(this.DeviceID, begin, end);
        }
        #endregion //GetDitchData


        #region GetDayDitchData
        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public DataTable GetDayDitchData(DateTime begin, DateTime end)
        {
            return DitchDataDaySDDBI.GetDayDitchData(this.DeviceID, begin, end);
        }
        #endregion //GetDayDitchData


        #region GetLastDateTimeForm10MinuteDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DateTime GetLastDateTimeForm10MinuteDataTable()
        {
            DateTime dt = DitchData10MinuteDBI.GetLastDateTime(this.DeviceID);
            if (dt.Year == 1900)
            {
                return DitchDataDBI.GetFirstDateTime(this.DeviceID);
            }
            else
            {
                return dt;
            }
        }
        #endregion //GetLastDateTimeForm10MinuteDataTable


        #region Write10MinuteDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tbl"></param>
        public void Write10MinuteDataTable(DataTable tbl)
        {
            foreach ( DataRow row in tbl.Rows )
            {
                DitchData10MinuteDBI.Write(this.DeviceID, row);
            }
        }
        #endregion //Write10MinuteDataTable

        #region FormulaCollection
        /// <summary>
        /// 
        /// </summary>
        public FormulaCollection FormulaCollection
        {
            get
            {
                if (_formulaCollection == null)
                {
                    //_formulaCollection = FormulaFactory.Create(this.DeviceID);
                    _formulaCollection = FormulaFactory.Create(this);
                }
                return _formulaCollection;
            }
            set
            {
                _formulaCollection = value;
            }
        } private FormulaCollection _formulaCollection;
        #endregion //FormulaCollection

        #region DeviceAlarm
        /// <summary>
        /// 
        /// </summary>
        public DeviceAlarm DeviceAlarm
        {
            get
            {
                if (_deviceAlarm == null)
                {
                    _deviceAlarm = DeviceAlarmFactory.Create(this.DeviceID);
                }
                return _deviceAlarm;
            }
            set
            {
                _deviceAlarm = value;
            }
        } private DeviceAlarm _deviceAlarm;
        #endregion //DeviceAlarm

    }
}

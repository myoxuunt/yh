using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Common;

namespace RWTrans
{
    /// <summary>
    /// 
    /// </summary>
    abstract public class Item
    {
        static protected FromDBI GetFromDBI()
        {
            return App.Default.FromDBI;
        }

        static protected ToDBI GetToDBI()
        {
            return App.Default.ToDBI;
        }
        #region FromName
        /// <summary>
        /// 
        /// </summary>
        public string FromName
        {
            get
            {
                if (_fromName == null)
                {
                    _fromName = string.Empty;
                }
                return _fromName;
            }
            set
            {
                _fromName = value;
            }
        } private string _fromName;
        #endregion //FromName

        #region FromID
        /// <summary>
        /// 
        /// </summary>
        public string FromID
        {
            get
            {
                if (_fromID == null)
                {
                    _fromID = string.Empty;
                }
                return _fromID;
            }
            set
            {
                _fromID = value;
            }
        } private string _fromID;
        #endregion //FromID

        #region ToName
        /// <summary>
        /// 
        /// </summary>
        public string ToName
        {
            get
            {
                if (_toName == null)
                {
                    _toName = string.Empty;
                }
                return _toName;
            }
            set
            {
                _toName = value;
            }
        } private string _toName;
        #endregion //ToName

        #region ToStationID
        /// <summary>
        /// 
        /// </summary>
        public int ToStationID
        {
            get
            {
                return _toStationID;
            }
            set
            {
                _toStationID = value;
            }
        } private int _toStationID;
        #endregion //ToStationID

        #region ToDeviceID
        /// <summary>
        /// 
        /// </summary>
        public int ToDeviceID
        {
            get
            {
                return _toDeviceID;
            }
            set
            {
                _toDeviceID = value;
            }
        } private int _toDeviceID;
        #endregion //ToDeviceID


        /// <summary>
        /// 
        /// </summary>
        public int Transmit()
        {
            DateTime toLastDateTime = GetToLastDateTime();
            DataTable tbl = GetTransmitDataTable(toLastDateTime);
            WriteTo(tbl);
            return tbl.Rows.Count;
        }

        abstract public void WriteTo(DataTable tbl);
        abstract public DataTable GetTransmitDataTable(DateTime toLastDateTime);
        abstract public DateTime GetToLastDateTime();
    }
}

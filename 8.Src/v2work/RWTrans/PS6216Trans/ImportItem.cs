using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data ;
using System.Data.SqlClient;

namespace PS6216DataImporter
{
    public class TransItem
    {
        public TransItem()
        {
        } 
        
        #region FromDevice
        /// <summary>
        /// 
        /// </summary>
        public FromDevice FromDevice
        {
            get
            {
                if (_fromDevice == null)
                {
                    _fromDevice = new FromDevice();
                }
                return _fromDevice;
            }
            set
            {
                _fromDevice = value;
            }
        } private FromDevice _fromDevice;
        #endregion //FromDevice

        #region ToDevice
        /// <summary>
        /// 
        /// </summary>
        public ToDevice ToDevice
        {
            get
            {
                if (_toDevice == null)
                {
                    _toDevice = new ToDevice();
                }
                return _toDevice;
            }
            set
            {
                _toDevice = value;
            }
        } private ToDevice _toDevice;
        #endregion //ToDevice

    }


    public class DeviceBase
    {
        #region Name
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get
            {
                if (_name == null)
                {
                    _name = string.Empty;
                }
                return _name;
            }
            set
            {
                _name = value;
            }
        } private string _name;
        #endregion //Name

        #region ID
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            get
            {
                return _iD;
            }
            set
            {
                _iD = value;
            }
        } private int _iD;
        #endregion //ID

        #region DBI
        /// <summary>
        /// 
        /// </summary>
        public object DBI
        {
            get
            {
                return _dBI;
            }
            set
            {
                _dBI = value;
            }
        } private object _dBI;
        #endregion //DBI


        #region Elvation
        /// <summary>
        /// 基本高程, 单位M
        /// </summary>
        public float Elvation
        {
            get
            {
                return _elvation;
            }
            set
            {
                _elvation = value;
            }
        } private float _elvation;
        #endregion //Elvation

    }


    public class FromDevice : DeviceBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param deviceType="formDateTime"></param>
        /// <returns></returns>
        public DataTable ReadDataTable(DateTime fromDateTime)
        {
            return ((FromDBI)DBI).ReadNewDataTable(fromDateTime);
        }

        new private string Name
        {
            get { return base.Name; }
            set { base.Name = value; }
        }

        new private int ID
        {
            get { return base.ID; }
            set { base.ID = value; }
        }
    }

    ///// <summary>
    ///// 
    ///// </summary>
    ///// <param deviceType="hs">deviceType - value map</param>
    //public delegate void WriteDelegate( Hashtable hs );

    public enum DataEnum
    {
        DeviceID,
        DT,
        BeforeDepth,
        Discharge,
        TotalWaterVolum,
        Elvation,
    }

    /// <summary>
    /// 
    /// </summary>
    public class ToDevice : DeviceBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param deviceType="writeDelegate"></param>
        public ToDevice()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param deviceType="tbl"></param>
        public void WriteDataTable(DataTable tbl)
        {
            foreach (DataRow row in tbl.Rows)
            {
                WriteDataRow(row);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param deviceType="value"></param>
        /// <returns></returns>
        static private float MMToCM(float value)
        {
            return value / 10f;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param deviceType="value"></param>
        /// <returns></returns>
        static private float MToCM(float value)
        {
             return value * 100f;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param deviceType="obj"></param>
        /// <returns></returns>
        private object SafeFloat(object obj)
        {
            if (obj == null || obj == DBNull.Value)
            {
                return 0;
            }
            else
            {
                return obj;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param deviceType="row"></param>
        private void WriteDataRow(DataRow row)
        {
            DateTime dt = Convert.ToDateTime(row["记录时间"]);
            int wl = Convert.ToInt32(row["水位"]);
            float instantFlux = 123f;// Convert.ToSingle(row[""]);
            ((ToDBI)DBI).InsertDitchData(this.ID, dt, wl, instantFlux);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DateTime ReadLastDataDateTime()
        {
            ToDBI dbi = this.DBI as ToDBI;
            DateTime dt = dbi.ReadLastDitchDataDateTime(this.Name);
            return dt;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PS6216DataImporter
{
    public class ToDBI : Xdgk.Common.DBIBase
    {
        public ToDBI(string connstring)
            : base(connstring)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param deviceType="deviceType"></param>
        /// <returns></returns>
        internal int ReadToDeviceID(string name)
        {
            int deviceID = ReadDeviceID(ReadStationID(name));
            // TODO: assert
            //
            return deviceID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param deviceType="deviceType"></param>
        /// <returns></returns>
        private int ReadDeviceID(int stationID)
        {
            // TODO: check devicetype
            //
            string sql = string.Format(
                "select DeviceID from tblDevice where deleted <> 1 and StationID = '{0}'",
                stationID);
            object obj = ExecuteScalar(sql);

            if (obj == null)
            {
                throw new InvalidOperationException(string.Format("cannot find device by stationID '{0}'", stationID));
            }
            return Convert.ToInt32(obj);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param deviceType="deviceType"></param>
        /// <returns></returns>
        internal int ReadStationID(string name)
        {
            string sql = string.Format(
                "select StationID from tblStation where deleted <> 1 and Name = '{0}'",
                name);
            object obj = ExecuteScalar(sql);
            if (obj == null)
            {
                throw new InvalidOperationException(
                    string.Format("cannot find device by name '{0}'", 
                    name));
            }

            return Convert.ToInt32(obj);
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param deviceType="deviceType"></param>
        //private void CreateToDevice(string name)
        //{
        //    InsertAddress(name);
        //    int addressID = GetAddressID(name);
        //    InsertGate(addressID);
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param deviceType="gateID"></param>
        /// <returns></returns>
        public DateTime ReadLastDitchDataDateTime(string name)
        {
            int stationID = ReadStationID(name);
            int deviceID = ReadDeviceID(stationID);
            string s = string.Format("select Max(DT) from tblDitchData where DeviceID = '{0}'", deviceID);
            object obj = ExecuteScalar(s);
            if (obj != null)
            {
                return Convert.ToDateTime(obj);
            }
            else
            {
                return DateTime.Parse("2000-1-1");
            }
        }

        public void InsertDitchData(int deviceID, DateTime dt, int wl, float instantFlux)
        {
            string sql = string.Format(
                @"insert into tblDitchData (deviceID, dt,    wl1,   wl2, instantFlux, usedAmount, voltage) 
                                    values ({0},      '{1}', {2},   0,   {3},         0,          0)",
                deviceID,
                dt,
                wl,
                instantFlux);

            ExecuteScalar(sql);
        }
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param deviceType="p"></param>
        ///// <returns></returns>
        //internal int ReadToDeviceComAdr(int deviceID)
        //{
        //    string s = string.Format(
        //        "select comAdr from tb_gateInf where id = '{0}'",
        //        deviceID);

        //    object obj = ExecuteScalar(s);
        //    if (obj != null || obj != DBNull.Value)
        //    {
        //        return Convert.ToInt32(obj);
        //    }

        //    throw new InvalidOperationException(
        //        string.Format("catnot find gate comadr by id '{0}'",
        //        deviceID)
        //        );
        //}
    }
}

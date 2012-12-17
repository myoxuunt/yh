using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace YeHeCommuniServer.DB
{
    /// <summary>
    /// 
    /// </summary>
    public class DitchDataDBI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="device"></param>
        /// <param name="instantFlux"></param>
        /// <param name="wl1"></param>
        /// <param name="wl2"></param>
        static public object Insert(DitchDevice device, DateTime dt, float instantFlux, int wl1, int wl2,
            uint usedAmount, int voltage)
        {
            string s = "insert into tblDitchData(DeviceID, DT, WL1, WL2, InstantFlux, UsedAmount, voltage) " +
                "values ({0}, '{1}', {2}, {3}, {4}, {5}, {6})";

            //s = string.Format(s, device.ID, DateTime.Now, wl1, wl2, instantFlux, usedAmount, voltage);
            s = string.Format(s, device.ID, dt, wl1, wl2, instantFlux, usedAmount, voltage);
            return CSDBI.Instance.ExecuteScalar(s);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="cache"></param>
        /// <returns></returns>
        static public object Insert(DitchDevice device, DitchDataCache cache)
        {
            return Insert(device, cache.WLDT, cache.InstantFlux, cache.WL1, cache.WL2, 
                cache.UsedAmount, cache.Voltage );
        }
    }
}

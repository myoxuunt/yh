using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class DeviceDBI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public DataTable GetDeviceDataView()
        {
            string s = @"select * from tbldevice tbld inner join tblstation tbls
    on tbld.stationid = tbls.stationid
    where tbld.deleted=0 and tbls.deleted = 0";
            // string s = string.Format("select * from tblDevice where deleted = 0");
            return DBI.GetDBI().ExecuteDataTable(s);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceID"></param>
        /// <returns></returns>
        static public DataTable GetDeviceDataTable(int deviceID)
        {
            string s = string.Format("select * from tblDevice where deleted = 0  and deviceid = {0}",
                deviceID);
            return DBI.GetDBI().ExecuteDataTable(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stationID"></param>
        /// <returns></returns>
        static public DataTable GetDeviceDataTableByStationID(int stationID)
        {
            string s = string.Format(
                "select * from tblDevice where deleted = 0 and stationID = {0}",
                stationID);
            return DBI.GetDBI().ExecuteDataTable(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stationID"></param>
        /// <returns></returns>
        static public int[] GetDeviceIDsByStationID(int stationID)
        {
            ArrayList list = new ArrayList();
            DataTable tbl = GetDeviceDataTableByStationID(stationID);
            foreach (DataRow row in tbl.Rows)
            {
                int id = Convert.ToInt32(row["deviceID"]);
                list.Add(id);
            }
            return (int[])list.ToArray(typeof(int));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceID"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns>unit m3</returns>
        internal static double CalcUsedAmount(int deviceID, DateTime begin, DateTime end)
        {
            string sql =
                "select  deviceid, convert(varchar(10), dt, 120) as dt, avg(wl1) as wl1, avg(wl2) as wl2, " +

                // 2012-07-05 
                //
                // 
                //"avg(convert(bigint, instantflux)) as instantFlux " +
                "avg(convert(real, instantflux)) as instantFlux " +

                "from tblDitchData " +
                "where DeviceID = {0} and DT > '{1}' and dt < '{2}' " +
                "group by deviceid, convert(varchar(10), dt, 120) ";

            sql = string.Format(sql, deviceID, begin, end);

            DataTable tbl = DBI.GetDBI().ExecuteDataTable(sql);

            // instant flux unit m3/s
            //
            object totalInstantFluxObj = tbl.Compute("sum(instantflux)", true.ToString());
            if (totalInstantFluxObj != DBNull.Value)
            {
                double totalInstantFlux = Convert.ToDouble(totalInstantFluxObj);
                double amount = totalInstantFlux * 24 * 60 * 60;
                return amount;
            }
            else
            {
                return 0d;
            }
        }
    }
}

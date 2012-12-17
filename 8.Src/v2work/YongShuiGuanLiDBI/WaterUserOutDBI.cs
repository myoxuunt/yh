using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class WaterUserOutDBI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserID"></param>
        /// <returns></returns>
        static public DataTable GetOutDataTable(int waterUserID)
        {
            string s = string.Format("select * from tblOut where waterUserID = {0}",
                waterUserID );
            return DBI.GetDBI().ExecuteDataTable(s);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserID"></param>
        /// <returns></returns>
        static public int[] GetOutDeviceIds(int waterUserID)
        {
            ArrayList list = new ArrayList();
            DataTable tbl = GetOutDataTable(waterUserID);
            foreach (DataRow row in tbl.Rows)
            {
                int deviceID = Convert.ToInt32(row["DeviceID"]);
                list.Add(deviceID);
            }
            return (int[])list.ToArray(typeof(int));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserID"></param>
        /// <param name="outDeviceIDs"></param>
        static public void AssociateWaterUserOutDevice(int waterUserID, int[] outDeviceIDs)
        {
            DeleteByWaterUserID(waterUserID);
            foreach (int id in outDeviceIDs)
            {
                Insert(waterUserID, id);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserID"></param>
        /// <param name="id"></param>
        private static void Insert(int waterUserID, int id)
        {
            string s = string.Format("insert into tblOut (waterUserID, deviceID) values ({0}, {1})",
                waterUserID , id);
            DBI.GetDBI().ExecuteScalar(s);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserID"></param>
        static public void DeleteByWaterUserID(int waterUserID)
        {
            string s = string.Format("delete from tblOut where waterUserID = {0}",
                waterUserID);

            DBI.GetDBI().ExecuteScalar(s);
        }

    }
}

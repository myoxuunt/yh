using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class WaterUserInDBI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserID"></param>
        /// <returns></returns>
        static public DataTable GetInDataTable(int waterUserID)
        {
            string s = string.Format("select * from tblIn where waterUserID = {0}",
                waterUserID );
            return DBI.GetDBI().ExecuteDataTable(s);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserID"></param>
        /// <returns></returns>
        static public int[] GetInDeviceIds(int waterUserID)
        {
            ArrayList list = new ArrayList();
            DataTable tbl = GetInDataTable(waterUserID);
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
        /// <param name="inDeviceIDs"></param>
        static public void AssociateWaterUserInDevice(int waterUserID, int[] inDeviceIDs)
        {
            DeleteByWaterUserID(waterUserID);
            foreach (int id in inDeviceIDs)
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
            string s = string.Format("insert into tblIn (waterUserID, deviceID) values ({0}, {1})",
                waterUserID , id);
            DBI.GetDBI().ExecuteScalar(s);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserID"></param>
        static public void DeleteByWaterUserID(int waterUserID)
        {
            string s = string.Format("delete from tblIn where waterUserID = {0}",
                waterUserID);

            DBI.GetDBI().ExecuteScalar(s);
        }

    }
}

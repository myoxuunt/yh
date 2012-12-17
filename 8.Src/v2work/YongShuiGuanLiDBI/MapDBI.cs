using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class MapDBI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserID"></param>
        /// <returns></returns>
        static public int[] GetDeviceIDsByWaterUserID(int waterUserID)
        {
            string s = string.Format(
                "select deviceID from vWaterUserChannelstationdevice where waterUserID = {0}",
                waterUserID);

            ArrayList list = new ArrayList();
            DataTable tbl = DBI.GetDBI().ExecuteDataTable(s);
            foreach (DataRow row in tbl.Rows)
            {
                int id = Convert.ToInt32(row["DeviceID"]);
                list.Add(id);
            }

            return (int[])list.ToArray(typeof(int));
        }
    }
}

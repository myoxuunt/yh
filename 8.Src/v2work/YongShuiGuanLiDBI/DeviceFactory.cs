using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class DeviceFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stationID"></param>
        /// <returns></returns>
        static public DeviceCollection CreateDeviceCollectionByStationID(int stationID)
        {
            DeviceCollection dc = new DeviceCollection();
            //int[] devicdIDs = DeviceDBI.GetDeviceIDsByStationID(stationID);
            //string s = SqlHelper.MakeInQueryCondition(devicdIDs);
            DataTable tbl = DeviceDBI.GetDeviceDataTableByStationID(stationID);
            foreach (DataRow row in tbl.Rows)
            {
                DeviceClass d = CreateDevice(row);
                dc.Add(d);
            }
            return dc;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public DeviceCollection CreateDeviceCollection()
        {
            DeviceCollection dc = new DeviceCollection();
            DataTable tbl = DeviceDBI.GetDeviceDataView();
            foreach (DataRow row in tbl.Rows)
            {
                DeviceClass c = CreateDevice(row);
                dc.Add(c);
            }
            return dc;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceid"></param>
        /// <returns></returns>
        static public DeviceClass CreateDevice( int deviceid )
        {
            DeviceClass c = null;
            DataTable tbl = DeviceDBI.GetDeviceDataTable(deviceid);
            if (tbl.Rows.Count > 0)
            {
                c = CreateDevice(tbl.Rows[0]);
            }
            return c;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataRow"></param>
        /// <returns></returns>
        private static DeviceClass CreateDevice(DataRow dataRow)
        {
            DeviceClass c = new DeviceClass();

            int deviceID = Convert.ToInt32 (dataRow["DeviceID"]);
            string deviceKind = dataRow["DeviceKind"].ToString();
            string deviceType = dataRow["deviceType"].ToString();
            string remark = dataRow["Remark"].ToString();


            c.DeviceID = deviceID;
            c.DeviceKind = deviceKind;
            c.DeviceType = deviceType;
            c.DeviceRemark = remark;

            return c;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserId"></param>
        /// <returns></returns>
        static public  DeviceCollection CreateInDeviceCollection(int waterUserId)
        {
            return CreateDeviceCollection("tblIN", waterUserId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserID"></param>
        /// <returns></returns>
        static public DeviceCollection CreateOutDeviceCollection(int waterUserId)
        {
            return CreateDeviceCollection("tblOut", waterUserId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inOrOutTableName"></param>
        /// <param name="waterUserId"></param>
        /// <returns></returns>
        private static DeviceCollection CreateDeviceCollection(string inOrOutTableName, int waterUserId)
        {
            DeviceCollection ds = new DeviceCollection();
            string s = string.Format(
                @"select * from tblDevice 
                    where deleted = 0 and 
                        deviceid in (select deviceid from {0} where waterUserID = {1})",
                inOrOutTableName, waterUserId);

            DataTable tbl = DBI.GetDBI().ExecuteDataTable(s);

            foreach (DataRow row in tbl.Rows)
            {
                DeviceClass d = CreateDevice(row);
                ds.Add(d);
            }
            return ds;
        }


    }
}

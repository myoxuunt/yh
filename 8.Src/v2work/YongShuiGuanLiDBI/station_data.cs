using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace YongShuiGuanLiDBI
{
    public class station_data
    {
        public DataTable devicetype(string stationid)
        {

            string sql = string.Format("SELECT dbo.tblDevice.DeviceType, dbo.tblStation.Name AS station_name," 
                                +" dbo.tblDevice.DeviceID, dbo.tblStation.StationID"
                                +" FROM dbo.tblStation INNER JOIN"
                                + " dbo.tblDevice ON dbo.tblStation.StationID = dbo.tblDevice.StationID where tblStation.stationid='{0}'", stationid);
            DataTable dt = DBI.GetDBI().ExecuteDataTable(sql);
            return dt;
        }
        public int type(string devicetype)
        {
            int _type = 0;
            switch (devicetype)
            {
                case "xd200":
                    _type = 1;
                    break;
                case "xd200i":
                    _type = 1;
                    break;
                case "xd2300":
                    _type = 2;
                    break;
                case "xd221":
                    _type = 2;
                    break;
                case "xd221modbus":
                    _type = 2;
                    break;
                case "xd202":
                    _type = 4;
                    break;
                case "RF":
                    _type = 3;
                    break;
            }
            return _type;
        }
        /// <summary>
        /// 根据站点返回闸控最后一条数据
        /// </summary>
        /// <param name="station_name"></param>
        /// <returns></returns>
        public DataTable sluice_station_query(string station)
        {
            string sql = string.Format("select top 1 sluicedataid,dt,height,beforewl,behindwl,stationname from vSluiceData where stationid='{0}' order by sluicedataid desc", station);
            DataTable dt = DBI.GetDBI().ExecuteDataTable(sql);
            return dt;
        }
        /// 按站点名称取最后一条数据
        /// </summary>
        /// <param name="deviceid"></param>
        /// <returns></returns>
        public DataTable ditch_station_query(string station)
        {
            string sql = string.Format("select top 1 ditchdataid,dt,wl1,wl2,instantflux,usedamount,stationname from vDitchData where stationid='{0}' order by ditchdataid desc", station);
            DataTable dt = DBI.GetDBI().ExecuteDataTable(sql);
            return dt;
        }
        /// <summary>
        /// 降雨量
        /// </summary>
        /// <param name="station"></param>
        /// <returns></returns>
        public DataTable ditch_stationrain_query(string station)
        {
            string sql = string.Format("select top 1 RainFillDataID,name,DT,Remark,RainFill from Vrainfilldata where stationid='{0}' order by RainFillDataID desc", station);
            DataTable dt = DBI.GetDBI().ExecuteDataTable(sql);
            return dt;
        }
    }
}

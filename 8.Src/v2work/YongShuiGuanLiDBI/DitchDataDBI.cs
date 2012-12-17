using System;
using System.Collections.Generic;
using System.Text;
using System.Data ;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class DitchDataDBI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="deviceID"></param>
        /// <returns></returns>
        static public DataTable GetData(DateTime begin, DateTime end, int deviceID)
        {
            string s = string.Format(
                "select * from vDitchData where (deviceid = {0}) and (dt >= '{1}' and dt < '{2}') order by DT",
                deviceID, begin, end);
            return DBI.GetDBI().ExecuteDataTable(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="deviceIDs"></param>
        /// <returns></returns>
        static public DataTable GetData(DateTime begin, DateTime end, int[] deviceIDs)
        {
            string deviceIDsString = SqlHelper.MakeInQueryCondition(deviceIDs);
            string s = string.Format(
                "select * from vDitchData where (deviceid in ({0}))  and ( dt >= '{1}' and dt < '{2}') order by DT",
                deviceIDsString, begin, end);
            return DBI.GetDBI().ExecuteDataTable(s);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="deviceIDs"></param>
        /// <returns></returns>
        static public DataTable GetDataByStationIDs(DateTime begin, DateTime end, int[] stationIDs)
        {
            string stationIDsString = SqlHelper.MakeInQueryCondition(stationIDs );

            string sqlFormat = GetSqlFormat(begin, end);

            string s = string.Format(
                //"select * from {3} where (stationid in ({0}))  and ( dt >= '{1}' and dt < '{2}') order by DT desc",
                sqlFormat,
                stationIDsString, begin, end);
            return DBI.GetDBI().ExecuteDataTable(s);
        }

        /// <summary>
        /// 根据不同的时间段, 返回不同的数据表
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private static string GetSqlFormat(DateTime begin, DateTime end)
        {
            
            TimeSpan ts = end - begin;
            if (ts.Days >= 30)
            {
                string s =
                    @"SELECT [ChannelID], [StationID], [DeviceID], [ChannelName], [StationName], [StationOrdinal], 
                        convert(varchar(10),dt,120) as DT, 
                        avg([WL1]) as wl1, 
                        avg([InstantFlux]) as instantflux 
                        FROM [yehesldbv2-3].[dbo].[vDitchData]
                        where stationid in ({0}) and dt >= '{1}' and dt < '{2}' 
                        group by channelid, stationid, deviceid, channelname, stationname, stationOrdinal, 
                        convert(varchar(10),dt,120)
                        order by DT desc";
                return s;
            }
            else if (ts.Days > 1)
            {
                string s =
                    @"SELECT [ChannelID], [StationID], [DeviceID], [ChannelName], [StationName], [StationOrdinal], 
                        convert(varchar(13),dt,120) + ':00:00' as DT, 
                        avg([WL1]) as wl1, 
                        avg([InstantFlux]) as instantflux 
                        FROM [yehesldbv2-3].[dbo].[vDitchData]
                        where stationid in ({0}) and dt >= '{1}' and dt < '{2}' 
                        group by channelid, stationid, deviceid, channelname, stationname, stationOrdinal, 
                        convert(varchar(13),dt,120) + ':00:00'
                        order by DT desc";
                return s;
            }
            else
            {
                string s = @"select * from vDitchData 
                        where (stationid in ({0}))  and ( dt >= '{1}' and dt < '{2}') 
                        order by DT desc";
                return s;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="deviceID"></param>
        /// <returns></returns>
        static public DataTable GetWLTable(DateTime begin, DateTime end, int deviceID)
        {
            string s = string.Format (
               "select stationName, dt, wl1 from vDitchData where deviceid = {0} and dt >= '{1}' and dt < '{2}' order by dt",
                deviceID, begin, end);

            return DBI.GetDBI ().ExecuteDataTable (s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="deviceID"></param>
        /// <returns></returns>
        static public DataTable GetWLFluxTable(DateTime begin, DateTime end, int deviceID)
        {
            string s = string.Format (
               "select ditchDataID, stationName, dt, wl1, InstantFlux from vDitchData where deviceid = {0} and dt >= '{1}' and dt < '{2}' order by dt",
                deviceID, begin, end);

            return DBI.GetDBI ().ExecuteDataTable (s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="deviceid"></param>
        /// <returns></returns>
        static public DataTable GetFluxDataTable(DateTime begin, DateTime end, int deviceID)
        {
            string s = string.Format (
               "select stationName, dt, instantFlux from vDitchData where deviceid = {0} and dt >= '{1}' and dt < '{2}' order by dt",
                deviceID, begin, end);

            return DBI.GetDBI ().ExecuteDataTable (s);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="tbl"></param>
        static public void FormatDitchDataDateTime(DataTable tbl)
        {

        }

        internal static DateTime GetFirstDateTime(int deviceid)
        {
            string s = string.Format("select Min(DT) from tblDitchData where deviceid = {0}",
                                deviceid);
            object obj = DBI.GetDBI().ExecuteScalar(s);
            if (obj == null || obj == DBNull.Value)
            {
                //return DateTime.Parse("1900-1-1");
                return DateTime.Now;
            }
            else
            {
                return Convert.ToDateTime(obj);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceID"></param>
        /// <param name="wl1"></param>
        /// <param name="wl2"></param>
        /// <param name="instantFlux"></param>
        public static void Insert(int deviceID, DateTime dt , int wl1, int wl2, float instantFlux)
        {
            string s = string.Format(
                "insert into tblDitchData (DeviceID, DT, wl1, wl2, instantflux) values({0}, '{1}', {2}, {3}, {4})",
                deviceID, dt, wl1, wl2, instantFlux);

            DBI.GetDBI().ExecuteScalar(s);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataID"></param>
        /// <param name="wl1"></param>
        /// <param name="p"></param>
        /// <param name="instantFlux"></param>
        public static void Update(int dataID, int wl1, int wl2, float instantFlux)
        {
            string s = string.Format(
                "update tblDitchData set wl1 = {1}, wl2 = {2}, instantFlux = {3} where ditchdataid = {0}",
                dataID, wl1, wl2, instantFlux);

            DBI.GetDBI().ExecuteScalar(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataID"></param>
        public static void Delete(int dataID)
        {
            string s = string.Format(
                "delete from tblDitchData where DitchDataID = {0}",
                dataID);

            DBI.GetDBI().ExecuteScalar(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceID"></param>
        /// <param name="dt"></param>
        public static void DeleteDay(int deviceID, DateTime day)
        {
            DateTime b = day.Date ;
            DateTime e = b  + TimeSpan.FromDays (1d);
            string s = string.Format(
                "delete from tblDitchData where deviceid = {0} and dt >= '{1}' and dt < '{2}'",
                deviceID, b, e);

            DBI.GetDBI().ExecuteScalar(s);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class DitchData10MinuteDBI
    {

        //static public DataTable 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        static public void Write(int deviceid, DataRow row)
        {
            object  amountObj = row["usedAmount"];
            int amount = 0;
            if (amountObj != DBNull.Value)
            {
                amount = Convert.ToInt32(amountObj);
            }

            string s = string.Format(
                "insert into tblDitchData10Minute(deviceid, dt, wl1, instantflux, usedamount) values({0}, '{1}', {2}, {3}, {4})",
                deviceid, row["DT"], row["wl1"], row["instantflux"], amount);

            DBI.GetDBI().ExecuteScalar(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceid"></param>
        /// <returns></returns>
        static public DateTime GetLastDateTime(int deviceid)
        {
            string s = string.Format("select Max(DT) from tblDitchData10Minute where deviceid = {0}",
                                deviceid);
            object obj = DBI.GetDBI().ExecuteScalar(s);
            if (obj == null || obj == DBNull.Value)
            {
                return DateTime.Parse("1900-1-1");
            }
            else
            {
                return Convert.ToDateTime(obj);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataid"></param>
        /// <param name="r"></param>
        public static void UpdateWL1(int dataid, int wl1)
        {
            string s = string.Format(
                "update tblDitchData10Minute set wl1 = {1} where DitchData10MinuteID = {0}",
                dataid, wl1);
            DBI.GetDBI().ExecuteScalar(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ditchData10MinuteID"></param>
        /// <returns></returns>
        internal static int GetWLByID(int ditchData10MinuteID)
        {
            string s = string.Format("select wl1 from tblDitchData10Minute where ditchdata10MinuteID = {0}",
                    ditchData10MinuteID);
            object obj = DBI.GetDBI().ExecuteScalar(s);
            if (obj != null && obj != DBNull.Value)
            {
                return Convert.ToInt32(obj);
            }
            else
            {
                return 0;
            }

        }
    }
}

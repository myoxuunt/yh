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
    public class ChannelStationMapDBI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="channelID"></param>
        /// <returns></returns>
        static public DataTable GetChannelStationMapDataTable(int channelID)
        {
            string s = string.Format(
                "select * from tblChannelStationMap where channelID = {0} order by stationOrdinal",
                channelID);
            
            DataTable tbl = DBI.GetDBI().ExecuteDataTable(s);
            return tbl;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="channelID"></param>
        /// <returns></returns>
        static public int[] GetStationIDs(int channelID)
        {
            ArrayList list = new ArrayList();
            string s = string.Format(
                "select * from tblChannelStationMap where channelID = {0} order by stationOrdinal",
                channelID);
            
            DataTable tbl = DBI.GetDBI().ExecuteDataTable(s);
            foreach (DataRow row in tbl.Rows)
            {
                int stationid = Convert.ToInt32(row["StationID"]);
                list.Add(stationid);
            }

            return (int[])list.ToArray(typeof(int));
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="stationID"></param>
        /// <returns></returns>
        static public int GetChannelID(int stationID)
        {
            int channelID = 0;

            ArrayList list = new ArrayList();
            string s = string.Format("select * from tblChannelStationMap where stationID = {0}",
                channelID);

            DataTable tbl = DBI.GetDBI().ExecuteDataTable(s);
            if (tbl.Rows.Count > 0)
            {
                channelID = Convert.ToInt32(tbl.Rows[0]["channelID"]);
            }
            return channelID;
        }

    }
}

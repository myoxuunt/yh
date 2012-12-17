using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Xdgk.Common;
using System.Diagnostics;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class ChannelDBI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public DataTable GetChannelDataTable()
        {
            string s = "select * from tblChannel";
            return DBI.GetDBI().ExecuteDataTable(s);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="channelName"></param>
        /// <returns></returns>
        static public bool ExistChannelName(string channelName)
        {
            return ExistChannelName(channelName, -1);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="channelName"></param>
        /// <param name="ignoreID"></param>
        /// <returns></returns>
        static public bool ExistChannelName(string channelName, int ignoreID)
        {
            string s = "select count(*) from tblChannel " + 
                "where ChannelName = @channelName and channelID <> @ignoreID and deleted = 0";

            SqlCommand cmd = new SqlCommand(s);
            DBIBase.AddSqlParameter(cmd, "channelName", channelName);
            DBIBase.AddSqlParameter(cmd, "ignoreID", ignoreID );

            object obj = DBI.GetDBI().ExecuteScalar(cmd);
            int count = Convert.ToInt32(obj);
            return count > 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="channelID"></param>
        /// <returns></returns>
        static public DataTable GetChannelDataTable(int channelID)
        {
            string s = string.Format("select * from tblChannel where deleted = 0 and channelID = {0}",
                channelID );
            DataTable tbl = DBI.GetDBI().ExecuteDataTable(s);
            return tbl;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="channelIDs"></param>
        /// <returns></returns>
        static public DataTable GetChannelDataTable(int[] channelIDs)
        {
            string idsString = MakeInQueryCondition(channelIDs);

            string s = string.Format("select * from tblChannel where deleted = 0 and channelID in ({0})",
                idsString);

            return DBI.GetDBI().ExecuteDataTable(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ids"></param>
        static private string MakeInQueryCondition( int[] ids )
        {
            return SqlHelper.MakeInQueryCondition(ids);
            //Debug.Assert(ids != null);
            //Debug.Assert(ids.Length > 0);

            //string s = string.Empty;
            //for (int i = 0; i < ids.Length; i++)
            //{
            //    s += ids[i] + ",";
            //}

            //s += ids[ids.Length - 1];
            //return s;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="channelName"></param>
        /// <param name="remark"></param>
        /// <param name="stationIDs"></param>
        static public void AddChannel(string channelName, string remark, int[] stationIDs)
        {
            string s = "insert into tblChannel(ChannelName, Remark) values(@channelName, @remark)";
            SqlCommand cmd = new SqlCommand(s);
            DBIBase.AddSqlParameter(cmd, "channelName", channelName);
            DBIBase.AddSqlParameter(cmd, "remark", remark);

            DBI.GetDBI().ExecuteScalar(cmd);
            //int newID = DBI.GetDBI().GetIdentity();
            int newID = GetChannelID(channelName);

            if (newID != 0)
            {
                //AddChannelStationMap(newID, stationIDs);
                AssociateChannalStation(newID, stationIDs);
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="channelname"></param>
        /// <returns></returns>
        static public int GetChannelID( string channelname )
        {
            string s = "select channelid from tblChannel where channelname = @n";
            SqlCommand cmd = new SqlCommand(s);
            DBIBase.AddSqlParameter(cmd, "n", channelname);
            object obj = DBI.GetDBI().ExecuteScalar(cmd);
            if (obj != null && obj != DBNull.Value)
            {
                return Convert.ToInt32(obj);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="channelID"></param>
        /// <param name="channelName"></param>
        /// <param name="remark"></param>
        /// <param name="stationIDs"></param>
        static public void EditChannel(int channelID, string channelName, string remark, int[] stationIDs)
        {
            string s = "update tblChannel set channelName=@channelName, Remark=@remark where channelID=@id";
            SqlCommand cmd = new SqlCommand(s);
            DBIBase.AddSqlParameter(cmd, "channelName", channelName);
            DBIBase.AddSqlParameter(cmd, "remark", remark);
            DBIBase.AddSqlParameter(cmd, "id", channelID);

            DBI.GetDBI().ExecuteScalar(cmd);
            //AddChannelStationMap(channelID, stationIDs);
            AssociateChannalStation(channelID, stationIDs);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="channelID"></param>
        /// <param name="stationIDs"></param>
        static public void AssociateChannalStation(int channelID, int[] stationIDs)
        {
            DeleteChannalStationMap(channelID);
            AddChannelStationMap(channelID, stationIDs);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="channelID"></param>
        /// <param name="stationIDs"></param>
        static public void AddChannelStationMap(int channelID, int[] stationIDs)
        {
            if (stationIDs != null)
            {
                int ordinal = 1;
                foreach (int stationID in stationIDs)
                {
                    AddChannelStationMap(channelID, stationID, ordinal++);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="channelID"></param>
        /// <param name="stationID"></param>
        /// <param name="stationOrdinal">站点在渠道中的顺序</param>
        static public void AddChannelStationMap(int channelID, int stationID, int stationOrdinal)
        {
            string s = string.Format(
                "insert into tblChannelStationMap(ChannelID, stationID, stationOrdinal) values({0}, {1}, {2})", 
                channelID, stationID, stationOrdinal);

            DBI.GetDBI().ExecuteScalar(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="channelID"></param>
        static public void DeleteChannalStationMap(int channelID)
        {
            string s = string.Format("Delete from tblChannelStationMap where channelID = {0}", 
                channelID );
            DBI.GetDBI().ExecuteScalar(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="channelID"></param>
        /// <returns></returns>
        static public DataTable GetStationDataTable(int channelID)
        {
            string s = string.Format(
                "select * from tblStation where deleted = 0 and stationid in (select stationid from tblChannelStationMap where channelID = {0})",
                channelID );
            return DBI.GetDBI().ExecuteDataTable(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="channelID"></param>
        /// <param name="exStationIDs"></param>
        /// <returns></returns>
        //static public DataTable GetStationDataTable(int channelID, int[] exStationIDs)
        //{
            
        //    string s = string.Format ("select * from tblChannelStationMap where channelID = {0}", 
        //        channelID);
        //    DataTable tbl = DBI.GetDBI().ExecuteDataTable(s);

        //    // use tbl.Merge ?
        //    //

        //    string ids = string.Empty;
        //    foreach (DataRow row in tbl.Rows)
        //    {
        //        string id = row["stationID"].ToString();
        //        ids += id + ",";
        //    }


        //    if (exStationIDs != null && exStationIDs.Length > 0)
        //    {
        //        for (int i = 0; i < exStationIDs.Length; i++)
        //        {
        //            ids += exStationIDs[i] + ",";
        //        }
        //    }

        //    if (ids.Length > 0)
        //    {
        //        ids = ids.Substring(0, ids.Length - 1);
        //    }

        //    if (ids.Length == 0)
        //    {
        //        ids = "-1";
        //    }
        //    string sql = string.Empty;
        //    //if (ids.Length > 0)
        //    //{
        //        sql = string.Format(
        //            "select * from tblStation where deleted = 0 and stationid in ({0})",
        //            ids);
        //    //}
        //    //else
        //    //{
        //    //    sql = "select * from tblStation where deleted = 0";
        //    //}
        //    return DBI.GetDBI().ExecuteDataTable(sql);
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteChannel(int id)
        {
            string s = string.Format("delete from tblChannel where channelID = {0}",
                id);

            DBI.GetDBI().ExecuteScalar(s);
        }

        //wangp
        public static DataTable GetChannelTableForLevel(int levelID) // 5\4\3
        {
            string s = string.Format("select * from tblChannel where deleted = 0 and ChannelLevelID = {0}",
                levelID);
            DataTable tbl = DBI.GetDBI().ExecuteDataTable(s);
            return tbl;
        }
        public static DataTable GetLowLevelChannelDataTable(int ParentID)
        {
            string s = string.Format("select * from tblChannel where deleted = 0 and ParentChannelID = {0}",
                ParentID);
            DataTable tbl = DBI.GetDBI().ExecuteDataTable(s);
            return tbl;
        }
        public static int GetInDeviceIds(int ChannelID)
        {
            string s = string.Format("select top 1 * from vWChannal where ChannelID={0} order by StationOrdinal asc",
                ChannelID);
            DataTable tbl = DBI.GetDBI().ExecuteDataTable(s);
            return int.Parse(tbl.Rows[0]["DeviceID"].ToString());
        }
        public static int GetOutDeviceIds(int ChannelID)
        {
            string s = string.Format("select top 1 * from vWChannal where ChannelID={0} order by StationOrdinal desc",
                ChannelID);
            DataTable tbl = DBI.GetDBI().ExecuteDataTable(s);
            return int.Parse(tbl.Rows[0]["DeviceID"].ToString());
        }

    }
}

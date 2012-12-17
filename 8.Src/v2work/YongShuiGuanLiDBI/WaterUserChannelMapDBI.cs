using System;
using System.Collections.Generic;
using System.Text;
using System.Data ;
using System.Collections;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class WaterUserChannelMapDBI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserID"></param>
        /// <returns></returns>
        static public int[] GetChannelIDs(int waterUserID)
        {
            ArrayList list = new ArrayList();
            DataTable tbl = GetWaterUserChannelMapDataTable(waterUserID);
            foreach (DataRow r in tbl.Rows)
            {
                int id = Convert.ToInt32(r["ChannelID"]);
                list.Add(id);
            }
            return (int[])list.ToArray(typeof(int));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserID"></param>
        /// <returns></returns>
        static public DataTable GetWaterUserChannelMapDataTable(int waterUserID)
        {
            string s = string.Format("select * from tblWaterUserChannelMap where waterUserID = {0}", 
                waterUserID );
            return DBI.GetDBI().ExecuteDataTable(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserID"></param>
        /// <param name="channelIDs"></param>
        static public void Associate(int waterUserID, int[] channelIDs)
        {
            DeleteByWaterUserID(waterUserID);
            foreach (int id in channelIDs)
            {
                Insert(waterUserID, id);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserID"></param>
        static public void DeleteByWaterUserID(int waterUserID)
        {
            string s = string.Format("delete from tblWaterUserChannelMap where waterUserID = {0}", 
                waterUserID );
            DBI.GetDBI().ExecuteScalar(s);
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="waterUserID"></param>
        ///// <param name="channelID"></param>
        //static public void Associate(int waterUserID, int channelID)
        //{
        //    // TODO:
        //    //
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserID"></param>
        /// <param name="channelID"></param>
        static public void Insert(int waterUserID, int channelID)
        {
            string s = string.Format("insert into tblWaterUserChannelMap(waterUserID, channelID) values({0}, {1})",
                waterUserID , channelID );

            DBI.GetDBI().ExecuteScalar(s);
        }
    }
}

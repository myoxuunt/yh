using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class ChannelFactory
    {
        /// <summary>
        /// 
        /// </summary>
        NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public ChannelClass CreateChannel(int id)
        {
            ChannelClass cc = null;
            DataTable tbl = ChannelDBI.GetChannelDataTable(id);
            if (tbl.Rows.Count > 0)
            {
                DataRow row = tbl.Rows[0];
                cc = CreateChannel(row);
            }
            return cc;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        private static ChannelClass CreateChannel(DataRow row)
        {
            int id = Convert.ToInt32(row["ChannelID"]);
            string n = row["ChannelName"].ToString();
            string r = row["remark"].ToString();

            ChannelClass  cc = new ChannelClass();
            cc.ChannelID = id;
            cc.ChannelName = n;
            cc.ChannelRemark = r;
            return cc;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserDI"></param>
        /// <returns></returns>
        static public ChannelCollection CreateChannelCollection(int waterUserID)
        {
            // waterUserID -> channelID[] -> channelCollection
            //
            ChannelCollection ccs = new ChannelCollection();

            int[] channelIDs = WaterUserChannelMapDBI.GetChannelIDs(waterUserID);
            if (channelIDs.Length > 0)
            {
                DataTable tbl = ChannelDBI.GetChannelDataTable(channelIDs);
                foreach (DataRow row in tbl.Rows)
                {
                    ChannelClass cc = CreateChannel(row);
                    ccs.Add(cc);
                }
            }
            return ccs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public ChannelCollection CreateChannelCollection()
        {
            ChannelCollection cc = new ChannelCollection();
            DataTable tbl = ChannelDBI.GetChannelDataTable();
            foreach (DataRow row in tbl.Rows)
            {
                ChannelClass c = CreateChannel(row);
                cc.Add(c);
            }
            return cc;
        }
    }
}

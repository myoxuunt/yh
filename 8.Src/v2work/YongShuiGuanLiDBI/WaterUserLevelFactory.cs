using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class WaterUserLevelFactory
    {
        static NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="wulEnum"></param>
        /// <returns></returns>
        static public WaterUserLevel CreateWaterLevel(WaterUserLevelEnum wulEnum)
        {
            DataTable tbl = WaterUserLevelDBI.GetWaterUserLevelDataTableByOrdinal((int)wulEnum);
            if (tbl.Rows.Count > 0)
            {
                int wulID = Convert.ToInt32(tbl.Rows[0]["WaterUserlevelID"]);
                WaterUserLevel l = WaterUserLevelFactory.CreateWaterUserLevelByID(wulID);
                return l;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserLevelID"></param>
        /// <returns></returns>
        static public WaterUserLevel CreateWaterUserLevelByID(int waterUserLevelID)
        {
            WaterUserLevel l = null; 
            DataTable tbl = WaterUserLevelDBI.GetWaterUserLevelDataTable(waterUserLevelID);
            if (tbl.Rows.Count > 0)
            {
                DataRow r = tbl.Rows[0];
                l = CreateWaterUserLevel(r);
            }
            else
            {
                string err = string.Format("not find waterUserLevel by id '{0}'", waterUserLevelID);
                log.Error(err);
            }
            return l;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserLevelID"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        private static WaterUserLevel CreateWaterUserLevel(DataRow r)
        {
            int id = Convert.ToInt32(r["WaterUserLevelID"]);
            string n = r["WaterUserLevelName"].ToString();
            int ordinal = Convert.ToInt32(r["Ordinal"]);
            string remark = r["Remark"].ToString();

            WaterUserLevel wul = new WaterUserLevel(id, n, remark, ordinal);
            //wul.WaterUserLevelID = id;
            return wul;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal static WaterUserLevelCollection CreateWaterUserLevelCollection()
        {
            WaterUserLevelCollection wulc = new WaterUserLevelCollection();
            DataTable tbl = WaterUserLevelDBI.GetWaterUserLevelDataTable();
            foreach (DataRow row in tbl.Rows)
            {
                WaterUserLevel wul = CreateWaterUserLevel(row);
                wulc.Add(wul);
            }
            return wulc;
        }
    }
}

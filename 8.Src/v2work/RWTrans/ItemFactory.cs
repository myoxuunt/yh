using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace RWTrans
{
    /// <summary>
    /// 
    /// </summary>
    public class ItemFactory
    {
        private const string 
            CQWater = "CQWater",
            CQRain = "CQRain";

        private ToDBI _todbi;
        public ItemFactory(ToDBI toDBI)
        {
            _todbi = toDBI;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <param name="dataType"></param>
        /// <returns></returns>
        public Item Create(DataRow row, DataType dataType)
        {
            switch (dataType)
            {
                case DataType.Rain :
                    return CreateRainItem(row);
                case DataType.Water :
                    return CreateWaterItem(row);

                default :
                    throw new ArgumentException("unknow data type: " + dataType);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Item CreateWaterItem(DataRow row)
        {
            Item item = new WaterItem ();
            string fromName = row["站点名称"].ToString();
            string fromID = row["站点编号"].ToString();
            string toName;
            int toStationID;
            int toDeviceID;

            _todbi.GetToInfo(fromName, CQWater, out toName, out toStationID, out toDeviceID);

            item.FromName = fromName;
            item.FromID = fromID;
            item.ToName = toName;
            item.ToStationID = toStationID;
            item.ToDeviceID = toDeviceID;

            return item;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Item CreateRainItem(DataRow row)
        {
            Item item = new RainItem ();
            string fromName = row["站点名称"].ToString();
            string fromID = row["站点编号"].ToString();
            string toName;
            int toStationID;
            int toDeviceID;

            _todbi.GetToInfo(fromName, CQRain, out toName, out toStationID, out toDeviceID);

            item.FromName = fromName;
            item.FromID = fromID;
            item.ToName = toName;
            item.ToStationID = toStationID;
            item.ToDeviceID = toDeviceID;

            return item;
        }
    }
}

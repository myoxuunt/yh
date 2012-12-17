using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class StationFactory
    {

        /// <summary>
        /// 
        /// </summary>
        static NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public StationClass CreateStation()
        {
            // TODO:
            //
            return null;
        }

        static public StationClass CreateStationByStationID(int stationID)
        {
            DataTable tbl = StationDBI.GetStationDataTable(stationID);
            if (tbl.Rows.Count > 0)
            {
                return CreateStation(tbl.Rows[0]);
            }
            return null;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        internal static StationClass CreateStation(int deviceID)
        {
            DataTable tbl = StationDBI.GetStationDataTableByDeviceID(deviceID);
            if (tbl.Rows.Count > 0)
            {
                DataRow row = tbl.Rows[0];
                return CreateStation(row);
            }
            else
            {
                string err = string.Format("not find station by device id '{0}'", deviceID);
                log.Error(err);
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private static string GetStationName(DataRow row)
        {
            string[] columnNames = new string[] { "StationName", "Name"};
            foreach (string columnName in columnNames)
            {
                int idx = row.Table.Columns.IndexOf(columnName);
                if (idx >=0)
                {
                    return row[columnName].ToString();
                }
            }

            throw new InvalidOperationException("Cannot get column.");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private static StationClass CreateStation(DataRow row)
        {
            StationClass s = new StationClass();
            s.StationID = Convert.ToInt32 (row["StationID"]);
            //s.StationName = row["Name"].ToString();
            s.StationName = GetStationName(row);

            object colorObject = row["Color"];
            if (colorObject != null && colorObject != DBNull.Value)
            {
                string colorString = colorObject.ToString();
                int argb = 0;
                bool r = int.TryParse(colorString, out argb);
                if (r)
                {
                    System.Drawing.Color color = System.Drawing.Color.FromArgb(argb);
                    s.Color = color;
                }
            }
            return s;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public StationCollection CreateStationCollection(int channelID)
        {
            StationCollection stations = new StationCollection();
            DataTable channelStationMapTbl = ChannelStationMapDBI.GetChannelStationMapDataTable(channelID);

            //int[] stationIDs = ChannelStationMapDBI.GetStationIDs(channelID);
            int[] stationIDs = DataTableHelper.GetIDs(channelStationMapTbl, "stationid");

            DataTable tbl =  StationDBI.GetStationDataTable(stationIDs);
            foreach (DataRow row in tbl.Rows)
            {
                StationClass c = CreateStation(row);
                c.StationOrdinal = GetStationOrdinal(channelStationMapTbl, c.StationID);
                stations.Add(c);
            }

            stations.SortByStationOrdinal();
            return stations;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="channelStationMapTbl"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        private static int GetStationOrdinal(DataTable channelStationMapTbl, int stationID)
        {
            foreach (DataRow row in channelStationMapTbl.Rows)
            {
                int rowStationID = Convert.ToInt32(row["StationID"]);
                int rowStationOrdinal = Convert.ToInt32(row["StationOrdinal"]);
                if (rowStationID == stationID)
                {
                    return rowStationOrdinal;
                }
            }
            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        static public StationCollection CreateRainStationCollection()
        {
            StationCollection rainStations = new StationCollection();
            DataTable rainStationTable = StationDBI.GetRainStationDataTable();

            return CreateStationCollection(rainStationTable);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tbl"></param>
        /// <returns></returns>
        static private StationCollection CreateStationCollection(DataTable tbl)
        {
            StationCollection stations = new StationCollection();
            foreach (DataRow row in tbl.Rows)
            {
                StationClass s = CreateStation(row);
                stations.Add(s);
            }
            return stations;
        }
    }
}

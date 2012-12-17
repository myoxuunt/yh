using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Xdgk.Common;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class StationCollection : Collection<StationClass>
    {

        #region stationCollection
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stationCollection"></param>
        public void Add(StationCollection stationCollection)
        {
            foreach (StationClass s in stationCollection)
            {
                this.Add(s);
            }
        }
        #endregion //stationCollection

        #region Remove
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stationCollection"></param>
        public void Remove(StationCollection stationCollection)
        {
            foreach (StationClass s in stationCollection)
            {
                this.RemoveStation(s);
            }
        }
        #endregion //Remove

        #region RemoveStation
        /// <summary>
        /// 
        /// </summary>
        /// <param name="station"></param>
        public void RemoveStation(StationClass station)
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                StationClass item = this[i];
                if (item.StationID == station.StationID)
                {
                    this.RemoveAt(i);
                }
            }
        }
        #endregion //RemoveStation

        #region AddByStationID
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stationID"></param>
        public void AddByStationID(int stationID)
        {
            DataTable tbl  = StationDBI.GetStationDataTable(stationID);

            StationCollection stations = new StationCollection();
            foreach (DataRow r in tbl.Rows)
            {
                string n = r["Name"].ToString ();
                int id = Convert.ToInt32(r["StationID"]);
                StationClass newStation = new StationClass();
                newStation.StationName = n;
                newStation.StationID = id;
                stations.Add(newStation);
            }

            this.Add(stations);
        }
        #endregion //AddByStationID

        #region GetStationNames
        /// <summary>
        /// 
        /// </summary>
        /// <param name="channelID"></param>
        /// <returns></returns>
        public string[] GetStationNames()
        {
            ArrayList list = new ArrayList();
            foreach (StationClass station in this )
            {
                string name = station.StationName;
                list.Add(name);
            }
            return (string[])list.ToArray(typeof(string));
        }
        #endregion //GetStationNames

        #region GetStationIDs
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int[] GetStationIDs()
        {
            ArrayList list = new ArrayList();
            foreach (StationClass s in this)
            {
                int id = s.StationID;
                list.Add(id);
            }
            return (int[])list.ToArray(typeof(int));
        }
        #endregion //GetStationIDs

        #region GetDeviceCollection
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DeviceCollection GetDeviceCollection()
        {
            DeviceCollection list = new DeviceCollection();
            foreach (StationClass sc in this)
            {
                foreach (DeviceClass d in sc.DeviceCollection)
                {
                    list.Add(d);
                }
            }
            return list;
        }
        #endregion //GetDeviceCollection

        #region GetDitchDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public DataTable GetDitchDataTable(DateTime begin, DateTime end)
        {
            return DitchDataDBI.GetDataByStationIDs(begin, end, this.GetStationIDs());
        }
        #endregion //GetDitchDataTable

        #region GetWL1DataTable
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable GetWL1DataTable(DateTime begin, DateTime end)
        {
            return  DitchDataDBI.GetDataByStationIDs(begin, end, 
             this.GetStationIDs());
        }
        #endregion //GetWL1DataTable

        #region GetAmountDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public DataTable GetAmountDataTable(DateTime begin, DateTime end)
        {
            return DitchDataDayDBI.GetDayDataTableWithRow(begin, end, GetStationIDs());
        }
        #endregion //

        #region GetFluxDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public DataTable GetFluxDataTable(DateTime begin, DateTime end)
        {
            return DitchDataDBI.GetDataByStationIDs(begin, end,
                this.GetStationIDs());
        }
        #endregion //GetFluxDataTable

        #region GetDitchDataSection
        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <returns></returns>
        public DataTable GetDitchDataSection(DateTime end)
        {
            DateTime begin = end.Date;
            return GetDitchDataSection(begin, end);
        }
        #endregion //GetDitchDataSection

        #region GetDitchDataSection
        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public DataTable GetDitchDataSection(DateTime begin, DateTime end)
        {
            DataTable tbl = DitchDataDBI.GetDataByStationIDs(begin, end, this.GetStationIDs());
            tbl.DefaultView.Sort = "DT desc";
            DataTable result = tbl.Clone();

            foreach (DataRowView rowView in tbl.DefaultView)
            {
                string stationName = rowView.Row[YongShuiGuanLiDBI.DBNames.vDitchData.StationName].ToString ();
                string filter = string.Format("{0} = '{1}'",
                    YongShuiGuanLiDBI.DBNames.vDitchData.StationName,
                    stationName);
                DataRow[] rows = result.Select(filter);

                if (rows.Length == 0)
                {
                    result.Rows.Add(rowView.Row.ItemArray);
                }
            }

            return result;
        }
        #endregion //GetDitchDataSection

        #region GetDitchDataSectionAmount
        /// <summary>
        /// 获取水量最后数据
        /// </summary>
        /// <param name="end"></param>
        /// <returns></returns>
        public DataTable GetDitchDataSectionAmount(DateTime end)
        {
            DateTime begin = end.Date;
            end = begin + TimeSpan.FromDays(1d);
            return GetDitchDataSectionAmount(begin, end);
        }
        #endregion //GetDitchDataSectionAmount

        #region GetDitchDataSectionAmount
        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public DataTable GetDitchDataSectionAmount(DateTime begin, DateTime end)
        {
            //DataTable tbl = DitchDataDBI.GetDataByStationIDs(begin, end, this.GetStationIDs());
            DataTable tbl = DitchDataDayDBI.GetDayDataTableWithRow(begin, end, this.GetStationIDs());
            tbl.DefaultView.Sort = "DT desc";
            DataTable result = tbl.Clone();

            foreach (DataRowView rowView in tbl.DefaultView)
            {
                string stationName = rowView.Row[YongShuiGuanLiDBI.DBNames.vDitchDataDay.StationName].ToString ();
                string filter = string.Format("{0} = '{1}'",
                    YongShuiGuanLiDBI.DBNames.vDitchData.StationName,
                    stationName);
                DataRow[] rows = result.Select(filter);

                if (rows.Length == 0)
                {
                    result.Rows.Add(rowView.Row.ItemArray);
                }
            }

            return result;
        }
        #endregion //GetDitchDataSectionAmount

        #region GetStationCollection
        /// <summary>
        /// 获取某些类型的设备的站点的集合
        /// </summary>
        /// <param name="deviceTypes"></param>
        /// <returns></returns>
        public StationCollection GetStationCollection(params string[] deviceTypes)
        {
            StationCollection t = new StationCollection();
            foreach (StationClass s in this)
            {
                if (s.DeviceCollection.Include(deviceTypes))
                {
                    t.Add(s);
                }
            }
            return t;
        }
        #endregion //GetStationCollection

        #region GetSluiceDataTable 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public DataTable GetSluiceDataTable(DateTime begin, DateTime end)
        {
            return SluiceDataDBI.GetDataByStationIDs(begin, end, this.GetStationIDs());
        }
        #endregion //GetSluiceDataTable


        /// <summary>
        /// 根据站点序号排列
        /// </summary>
        public void SortByStationOrdinal()
        {
            IList<StationClass> aaa = this.Items;
            StationClass[] ttt = new StationClass[this.Count];

            this.CopyTo(ttt, 0);
            Array.Sort(ttt, new ComparerWithStationOrdinal());
            this.Clear();

            foreach (StationClass s in ttt)
            {
                this.Add(s);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private class ComparerWithStationOrdinal : IComparer 
        {
            public int Compare(object x, object y)
            {
                StationClass s1 = x as StationClass;
                StationClass s2 = y as StationClass;

                if (s1 == null || s2 == null)
                {
                    return 0;
                }

                return s1.StationOrdinal - s2.StationOrdinal;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        public void Up(int index)
        {
            StationClass s = this[index];
            this.RemoveAt(index);
            int newindex = index - 1;
            if (newindex < 0)
                newindex = 0;
            this.Insert(newindex, s);
        }

        public void Down(int index)
        {
            StationClass s = this[index];
            this.RemoveAt(index);
            int newindex = index + 1;
            if (newindex > this.Count)
            {
                newindex = this.Count;
            }
            this.Insert(newindex, s);
        }
    }
}

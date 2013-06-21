using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Xdgk.Common;
using YongShuiGuanLiDBI;

namespace YongShuiGuanLiV2
{
    /// <summary>
    /// 
    /// </summary>
    public class ChannelSession
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="?"></param>
        public void SetChannalInfo( int channelID )
        {
            this.ChannelID = channelID;
            DataTable tbl = ChannelDBI.GetChannelDataTable(channelID);
            if (tbl.Rows.Count > 0)
            {
                DataRow r = tbl.Rows[0];
                this.ChannelName = r["ChannelName"].ToString();
                this.ChannelRemark = r["Remark"].ToString();
                //this.StationCollection = 

                this.StationCollection.Clear();
                StationCollection stationsOfChannel = GetStationList(channelID);
                //this.StationCollection.Add(stationsOfChannel 
                this.StationCollection = stationsOfChannel;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Clear()
        {
            this.ADEState = ADEStatus.Add;
            this.ChannelRemark = string.Empty;
            this.ChannelName = string.Empty;
            this.ChannelID = 0;
            this.StationCollection.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="channelID"></param>
        private StationCollection GetStationList(int channelID)
        {
            StationCollection list = new StationCollection();
            DataTable stationTbl = ChannelDBI.GetStationDataTable(channelID);
            foreach (DataRow row in stationTbl.Rows)
            {
                StationClass sc = new StationClass();
                sc.StationID = Convert.ToInt32(row["StationID"]);
                sc.StationName = row["Name"].ToString();
                //this.StationCollection.Add(sc);
                list.Add(sc);
            }
            return list;
        }

        

        #region ADEState
        /// <summary>
        /// 
        /// </summary>
        public ADEStatus ADEState
        {
            get { return _aDEState; }
            set { _aDEState = value; }
        } private ADEStatus _aDEState;
        #endregion //ADEState

        #region ChannelID
        /// <summary>
        /// 
        /// </summary>
        public int ChannelID
        {
            get { return _channelID; }
            set { _channelID = value; }
        } private int _channelID;
        #endregion //ChannelID

        #region NewChannelName
        /// <summary>
        /// 
        /// </summary>
        public string ChannelName
        {
            get
            {
                if (_channelName == null)
                {
                    _channelName = string.Empty;
                }
                return _channelName;
            }
            set { _channelName = value; }
        } private string _channelName;
        #endregion //NewChannelName

        #region NewChannelRemark
        /// <summary>
        /// 
        /// </summary>
        public string ChannelRemark
        {
            get
            {
                if (_channelRemark == null)
                {
                    _channelRemark = string.Empty;
                }
                return _channelRemark;
            }
            set { _channelRemark = value; }
        } private string _channelRemark;
        #endregion //NewChannelRemark



        //#region SelectedStationIDs
        ///// <summary>
        ///// 
        ///// </summary>
        //public int[] SelectedStationIDs
        //{
        //    get
        //    {
        //        if (_selectedStationIDs == null)
        //        {
        //            _selectedStationIDs = new int[] { };
        //        }
        //        return _selectedStationIDs;
        //    }
        //    set { _selectedStationIDs = value; }
        //} private int[] _selectedStationIDs;
        //#endregion //SelectedStationIDs

        /// <summary>
        /// 
        /// </summary>
        public StationCollection StationCollection
        {
            get
            {
                if (_stationCollection == null)
                {
                    _stationCollection = new StationCollection();
                }
                return _stationCollection;
            }
            set { _stationCollection = value; }
        } private StationCollection _stationCollection;


        /// <summary>
        /// 
        /// </summary>
        public StationCollection GetDeletedStationCollection()
        {
            StationCollection stations = this.GetStationList(this.ChannelID);
            stations.Remove(this.StationCollection);
            return stations;
        }

        /// <summary>
        /// 获取候选站点列表
        /// </summary>
        /// <returns></returns>
        public StationCollection GetCandidateStationList()
        {
            StationCollection list = new StationCollection();
            DataTable tbl =  StationDBI.GetNotAssociateStationDataTable();
            foreach (DataRow row in tbl.Rows)
            {
                int stationID = Convert.ToInt32(row["StationID"]);
                string name = row["Name"].ToString();
                StationClass n = new StationClass();
                n.StationID = stationID;
                n.StationName = name;
                list.Add(n);
            }
            list.Remove(this.StationCollection);
            list.Add(GetDeletedStationCollection());
            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private int[] GetStationIDs()
        {
            int[] list = new int[this.StationCollection.Count];
            //foreach (StationClass s in this.StationCollection)
            for(int i=0;i<this.StationCollection.Count ; i++)
            {
                StationClass item = this.StationCollection[i];
                list[i] = item.StationID;
            }
            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsAdd()
        {
            return this.ADEState == ADEStatus.Add;
        }

        /// <summary>
        /// insert or update channel
        /// </summary>
        public void Save()
        {
            string n = this.ChannelName;
            string r = this.ChannelRemark;

            if (IsAdd())
            {
                ChannelDBI.AddChannel(n, r, GetStationIDs());
            }
            else
            {
                // edit
                //
                ChannelDBI.EditChannel(this.ChannelID, n, r, GetStationIDs());

            }
        }
    }

}

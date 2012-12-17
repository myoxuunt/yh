using System;
using System.Collections.Generic;
using System.Text;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class ChannelClass
    {
        #region ChannelID
        /// <summary>
        /// 
        /// </summary>
        public int ChannelID
        {
            get
            {
                return _channelID;
            }
            set
            {
                _channelID = value;
            }
        } private int _channelID;
        #endregion //ChannelID

        #region ChannelName
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
            set
            {
                _channelName = value;
            }
        } private string _channelName;
        #endregion //ChannelName

        #region ChannelRemark
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
            set
            {
                _channelRemark = value;
            }
        } private string _channelRemark;
        #endregion //ChannelRemark


        #region StationCollection
        /// <summary>
        /// 
        /// </summary>
        public StationCollection StationCollection
        {
            get 
            {
                if (_stationCollection == null)
                {
                    _stationCollection = StationFactory.CreateStationCollection(this.ChannelID);
                }
                return _stationCollection;
            }
            set 
            {
                _stationCollection = value;
            }
        } private StationCollection _stationCollection;
        #endregion //StationCollection

        #region LowLevelCollection
        /// <summary>
        /// 
        /// </summary>
        public ChannelCollection LowLevelCollection
        {
            get
            {
                if (_lowLevelCollection == null)
                {
                    // 
                    //
                    return new ChannelCollection();
                }
                return _lowLevelCollection;
            }
            set
            {
                _lowLevelCollection = value;
            }
        } private ChannelCollection _lowLevelCollection;
        #endregion //LowLevelCollection

    }
}

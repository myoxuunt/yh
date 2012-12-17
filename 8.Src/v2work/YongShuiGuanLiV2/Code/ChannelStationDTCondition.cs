using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using YongShuiGuanLiDBI;

namespace YongShuiGuanLiV2
{
    /// <summary>
    /// 
    /// </summary>
    public class ChannelStationDTCondition
    {
        #region StationCollection
        /// <summary>
        /// 
        /// </summary>
        public StationCollection StationCollection
        {
            get
            {
                return _stationCollection;
            }
            set
            {
                _stationCollection = value;
            }
        } private StationCollection _stationCollection;
        #endregion //StationCollection

        #region ChannelCollection
        /// <summary>
        /// 
        /// </summary>
        public ChannelCollection ChannelCollection
        {
            get
            {
                return _channelCollection;
            }
            set
            {
                _channelCollection = value;
            }
        } private ChannelCollection _channelCollection;
        #endregion //ChannelCollection

        #region Begin
        /// <summary>
        /// 
        /// </summary>
        public DateTime Begin
        {
            get
            {
                return _begin;
            }
            set
            {
                _begin = value;
            }
        } private DateTime _begin;
        #endregion //Begin

        #region End
        /// <summary>
        /// 
        /// </summary>
        public DateTime End
        {
            get
            {
                return _end;
            }
            set
            {
                _end = value;
            }
        } private DateTime _end;
        #endregion //End

        #region DataEnum
        /// <summary>
        /// 
        /// </summary>
        public DataEnum DataEnum
        {
            get
            {
                return _dataEnum;
            }
            set
            {
                _dataEnum = value;
            }
        } private DataEnum _dataEnum;
        #endregion //DataEnum

    }
}

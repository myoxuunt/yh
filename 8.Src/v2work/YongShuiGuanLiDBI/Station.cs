using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using Xdgk.Common;
using System.Data;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class StationClass
    {
        #region StationID
        /// <summary>
        /// 
        /// </summary>
        public int StationID
        {
            get { return _stationID; }
            set { _stationID = value; }
        } private int _stationID;
        #endregion //StationID

        #region StationName
        /// <summary>
        /// 
        /// </summary>
        public string StationName
        {
            get { return _stationName; }
            set { _stationName = value; }
        } private string _stationName;
        #endregion //StationName

        #region DeviceCollection
        /// <summary>
        /// 
        /// </summary>
        public DeviceCollection DeviceCollection
        {
            get 
            {
                if (_deviceCollection == null)
                {
                    //_deviceCollection = new DeviceCollection();
                    _deviceCollection = DeviceFactory.CreateDeviceCollectionByStationID(this.StationID);
                }
                return _deviceCollection; 
            }
        } private DeviceCollection _deviceCollection;
        #endregion //DeviceCollection

        #region StationOrdinal
        /// <summary>
        /// 站点在所属渠道中的顺序号
        /// </summary>
        public int StationOrdinal
        {
            get
            {
                return _stationOrdinal;
            }
            set
            {
                _stationOrdinal = value;
            }
        } private int _stationOrdinal;
        #endregion //StationOrdinal


        #region Color
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// default color is white, white == invalid color
        /// </remarks>
        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        } private Color _color = Color.White;
        #endregion //Color

        public string ColorString
        {
            get
            {
                return string.Format("#{0:x2}{1:x2}{2:x2}", Color.R, Color.G, Color.B);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ChannelClass Channel
        {
            get
            {
                if (_channel == null)
                {
                    int channelID = ChannelStationMapDBI .GetChannelID (this.StationID );
                    _channel = ChannelFactory.CreateChannel(channelID);
                }
                return _channel;
            }
        } private ChannelClass _channel;
    }

}

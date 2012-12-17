using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using Xdgk.Common;
using System.Collections.Specialized;
using System.Collections;
using System.Threading ;

namespace Xdgk.Communi
{

    /// <summary>
    /// 站点
    /// </summary>
    public class Station : ObjectBase
    {

        #region Events
        /// <summary>
        /// 当CommuniPort属性改变时候触发此事件
        /// </summary>
        public event EventHandler CommuniPortChanged;
        #endregion //Events

        #region Members

        private DeviceCollection m_DeviceCollection;
        private CommuniType m_CommuniType;
        //private CommuniTypeOption m_CommuniTypeOption = CommuniTypeOption.GprsCommuni;
        private string _name = null;
        private string m_Description = null;

        #endregion

        #region Constructors


        #region Station
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stationName"></param>
        /// <param name="description"></param>
        public Station(string stationName, CommuniType communiType )
        {
            _name = stationName;
            //m_Description = description;

            if (communiType == null)
                throw new ArgumentNullException("communiType");
            this.m_CommuniType = communiType;
        }
        #endregion //Station


        #region Station
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stationName"></param>
        /// <param name="description"></param>
        public Station(string stationName, string description, DeviceCollection deviceCollection, CommuniType communiType)
            : this(stationName, communiType)
        {
            if (deviceCollection == null)
                throw new ArgumentNullException("deviceCollection");
            m_DeviceCollection = deviceCollection;
            m_DeviceCollection.Station = this;

            m_CommuniType = communiType;
        }
        #endregion //Station

        #endregion

        #region Properties


        #region Devices
        /// <summary>
        /// 获取或设置设备集合
        /// </summary>
        public DeviceCollection Devices
        {
            get
            {
                if (m_DeviceCollection == null)
                    m_DeviceCollection = new DeviceCollection(this);
                return m_DeviceCollection;
            }
            set
            {
                if (m_DeviceCollection != value)
                {
                    if (m_DeviceCollection != null)
                        m_DeviceCollection.Station = null;

                    m_DeviceCollection = value;
                    if (m_DeviceCollection != null)
                        m_DeviceCollection.Station = this;
                }
            }
        }
        #endregion //Devices

        #region CommuniType
        /// <summary>
        /// 获取或设置通讯方式集合
        /// </summary>
        public CommuniType CommuniType
        {
            get
            {
                return this.m_CommuniType;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("CommuniType");
                m_CommuniType = value;
            }
        }
        #endregion //CommuniType


        #region Name
        /// <summary>
        /// 获取或设置站点名称集合
        /// 站点名称不能为空，首尾不含空格不区分大小写
        /// 同一集合名称不能相同
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                //SetStationName(value);
                if (value == null || value.Trim().Length == 0)
                {
                    throw new System.ArgumentException("Station Name Exception!");
                }

                this._name = value.Trim();
            }
        }
        #endregion //Name

        #region Description
        /// <summary>
        /// 获取或设置站点备注集合
        /// 站点备注可以为空
        /// </summary>
        public string Description
        {
            get
            {
                if (m_Description == null)
                    m_Description = string.Empty;
                return m_Description;
            }
            set { m_Description = value; }
        }
        #endregion //Description


        #region DictionaryTag
        /// <summary>
        /// 
        /// </summary>
        public HybridDictionary DictionaryTag
        {
            get
            {
                if (_hybridDictionaryTag == null)
                    _hybridDictionaryTag = new HybridDictionary(true);
                return _hybridDictionaryTag;
            }
        } private HybridDictionary _hybridDictionaryTag;
        #endregion //DictionaryTag

        #region CommuniPort
        /// <summary>
        /// 获取或设置该Station相关的CommuniPort
        /// </summary>
        public CommuniPort CommuniPort
        {
            get { return _communiPort; }
            set
            {
                if (_communiPort != value)
                {
                    _communiPort = value;
                    //OnCommuniPortChanged();
                    if (CommuniSoft.IsUseUISynchronizationContext)
                    {
                        CommuniSoft.UISynchronizationContext.Post(
                            this.CommuniPortChangedCallback, null);
                    }
                    else
                    {
                        this.OnCommuniPortChanged();
                    }
                }
            }
        }private CommuniPort _communiPort;
        #endregion //CommuniPort



        #region CommuniPortChangedCallback
        /// <summary>
        /// 
        /// </summary>
        private SendOrPostCallback CommuniPortChangedCallback
        {
            get
            {
                return new SendOrPostCallback(CommuniPortChangedCallbackTarget);
            }
        }
        #endregion //CommuniPortChangedCallback


        #region CommuniPortChangedCallbackTarget
        /// <summary>
        /// 
        /// </summary>
        /// <param name="state"></param>
        private void CommuniPortChangedCallbackTarget( object state )
        {
            OnCommuniPortChanged();
        }
        #endregion //CommuniPortChangedCallbackTarget


        #region OnCommuniPortChanged
        /// <summary>
        /// 
        /// </summary>
        private void OnCommuniPortChanged()
        {
            if (this.CommuniPortChanged != null)
            {
                EventHandler temp = this.CommuniPortChanged;
                temp(this, EventArgs.Empty);
            }
        } 
        #endregion //OnCommuniPortChanged
        
        #endregion


        #region ID
        /// <summary>
        /// 获取或设置创建该对象的数据行的ID
        /// </summary>
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        } private int _id;
        #endregion //ID


        #region StationCollection
        /// <summary>
        /// 获取或设置于该站点相关的站点集合
        /// </summary>
        public StationCollection StationCollection
        {
            get { return _stationCollection; }
            set { _stationCollection = value; }
        } private StationCollection _stationCollection;
        #endregion //StationCollection
    }
}

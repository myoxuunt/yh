using System;
using System.Runtime.Serialization;
using System.Diagnostics;
using System.Collections;
using System.Threading;
using Xdgk.Common;

namespace Xdgk.Communi
{
    #region Device
    /// <summary>
    /// 设备基类
    /// </summary>
    public class Device : Xdgk.Common.ObjectBase
    {
        // TODO:  update datasource 2009-12-26
        //        datasource is db record or xml file ...
        //
        // TODO: add dbdevice?
        // a device create from dbdevice(datasoure)
        //
        #region Members
        #endregion //Members

        #region Device
        /// <summary>
        /// 
        /// </summary>
        public Device(DeviceDefine deviceDefine, string name, int address)
        {
            this._deviceDefine = deviceDefine;
            this._name = name;
            this.m_address = address;
        }
        #endregion //Device

        //#region Device
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="deviceType"></param>
        ///// <param name="address"></param>
        //public Device(string deviceType, int address)
        //    : this("", deviceType, address, "")
        //{
        //}
        //#endregion //Device

        //#region Device
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="name"></param>、
        ///// <param name="deviceType"></param>
        ///// <param name="address"></param>
        ///// <param name="remark"></param>
        ////public Device(int address,string deviceType)
        //public Device( string name, string deviceType, int address, string remark)
        //{
        //    if (address < 0 || address > 255)
        //        throw new ArgumentOutOfRangeException("Address Out!");
        //    m_address = address;

        //    this.DeviceType = deviceType;
        //    this.Name = name;
        //    this.Remark = remark;
        //}
        //#endregion //Device

        #region Properties


        #region Address
        /// <summary>
        /// 获取或设置设备地址
        /// </summary>
        public int Address
        {
            get { return m_address; }
            set
            {
                if (value < 0 || value > 255)
                    throw new ArgumentOutOfRangeException("Address out range!");
                m_address = value;
            }
        } private int m_address = 0;
        #endregion //Address


        #region DeviceType
        /// <summary>
        /// 获取或设置设备类型
        /// </summary>
        public string DeviceType
        {
            //    get
            //    {
            //        return _deviceType;
            //    }
            //    set
            //    {
            //        if (value == null || value.Trim().Length == 0)
            //            throw new ArgumentNullException("DeviceType");
            //        _deviceType = value;
            //    }
            //} private string _deviceType;
            get { return DeviceDefine.DeviceType; }
        }
        #endregion //DeviceType


        #region Name
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get
            {
                if (_name == null)
                    _name = string.Empty;
                return _name; 
            }
            set { _name = value; }
        } private string _name;
        #endregion //Name

        #region Text
        // TODO: Device text
        //
        /// <summary>
        /// 
        /// </summary>
        public string Text
        {
            //get 
            //{
            //    if (_text == null || _text.Trim().Length == 0)
            //    {
            //        return _deviceType;
            //    }
            //    else
            //    {
            //        return _text;
            //    }
            //}
            //set { _text = value.Trim(); }
            //} private string _text;
            get
            {
                return this.DeviceDefine.Text;
            }
        }
        #endregion //Text

        #region Devices
        /// <summary>
        /// 
        /// </summary>
        public DeviceCollection Devices
        {
            get { return _deviceCollection; }
            set { _deviceCollection = value; }
        } private DeviceCollection _deviceCollection;
        #endregion //Devices

        #region Standard
        /// <summary>
        /// 
        /// </summary>
        public bool IsStandard
        {
            get { return _isStandard; }
            set { _isStandard = value; }
        } private bool _isStandard;
        #endregion //Standard

        #endregion //Properties

        #region ReplaceOption
        /// <summary>
        /// 
        /// </summary>
        public IReplaceOption ReplaceOption
        {
            get { return _replaceOption; }
            set { _replaceOption = value; }
        } private IReplaceOption _replaceOption;
        #endregion //

        #region Station
        /// <summary>
        /// 获取关联站，如不存在返回null
        /// </summary>
        public Station Station
        {
            get
            {
                if (this.Devices != null)
                    return this.Devices.Station;
                return null;
            }
        }
        #endregion //Station

        #region CommuniDetailQueue
        /// <summary>
        /// 
        /// </summary>
        public CommuniDetailQueue CommuniDetailQueue
        {
            get
            {
                if (_communiDetailQueue == null)
                {
                    _communiDetailQueue = new CommuniDetailQueue();
                }
                return _communiDetailQueue;
            }
        } private CommuniDetailQueue _communiDetailQueue;
        #endregion //CommuniDetailQueue


        #region CommuniFailDetails
        /// <summary>
        /// 
        /// </summary>
        public CommuniFailDetailCollection CommuniFailDetails
        {
            get
            {
                if (_communiFailDetails == null)
                    _communiFailDetails = new CommuniFailDetailCollection();
                return _communiFailDetails;
            }
        } private CommuniFailDetailCollection _communiFailDetails;
        #endregion //CommuniFailDetails

        #region Remark
        /// <summary>
        /// 
        /// </summary>
        public string Remark
        {
            get { return _remark; }
            set { _remark = value; }
        } private string _remark;
        #endregion //Remark

        #region GetAssociateStandardDevice
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Device GetAssociateStandardDevice()
        {
            if (this.Station != null)
            {
                foreach (Device device in this.Station.Devices)
                {
                    if (device.IsStandard &&
                        (device != this) &&
                        (device.GetType() == this.GetType()))
                    {
                        return device;
                    }
                }
            }
            return null;
        }
        #endregion //GetAssociateStandardDevice

        #region Delete
        /// <summary>
        /// 
        /// </summary>
        virtual public void Delete()
        {
            if (this._deviceCollection != null)
            {
                this._deviceCollection.Remove(this);
            }
        }
        #endregion //Delete

        #region State
        /// <summary>
        /// 
        /// </summary>
        public DeviceState State
        {
            get
            {
                if (_state == null)
                    _state = DeviceState.None;
                return _state;
            }
            set
            {
                if (_state != value)
                {
                    _state = value;
                    if (StateChanged != null)
                    {
                        if (CommuniSoft.IsUseUISynchronizationContext)
                        {
                            CommuniSoft.UISynchronizationContext.Post(
                                this.StateChangedCallback, null);
                        }
                        else
                        {
                            OnStateChanged();
                        }
                    }
                }
            }
        } private DeviceState _state;
        #endregion //State



        #region StateChangedCallback
        /// <summary>
        /// 
        /// </summary>
        private SendOrPostCallback StateChangedCallback
        {
            get
            {
                return new SendOrPostCallback(StateChangedCallbackTarget);
            }
        }
        #endregion //StateChangedCallback


        #region StateChangedCallbackTarget
        /// <summary>
        /// 
        /// </summary>
        /// <param name="state"></param>
        private void StateChangedCallbackTarget(object state)
        {
            OnStateChanged();
        }
        #endregion //StateChangedCallbackTarget


        #region OnStateChanged
        /// <summary>
        /// 
        /// </summary>
        private void OnStateChanged()
        {
            StateChanged(this, EventArgs.Empty);
        }
        #endregion //OnStateChanged


        #region Data
        /// <summary>
        /// 数据
        /// </summary>
        public IData Data
        {
            get { return _data; }
            set 
            {
                if (_data != value)
                {
                    _data = value;
                    if (this.DataChanged != null)
                    {
                        if (CommuniSoft.IsUseUISynchronizationContext)
                        {
                            CommuniSoft.UISynchronizationContext.Post(
                                this.DataChangedCallback, null);
                        }
                        else
                        {
                            OnDataChanged();
                        }
                    }
                }
            }
        } private IData _data;

        /// <summary>
        /// 
        /// </summary>
        private void OnDataChanged()
        {
            DataChanged(this, EventArgs.Empty);
        }

        /// <summary>
        /// 
        /// </summary>
        private SendOrPostCallback DataChangedCallback
        {
            get
            {
                return new SendOrPostCallback(DataChangedCallbackTarget);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="state"></param>
        private void DataChangedCallbackTarget(object state)
        {
            OnDataChanged();
        }

        #endregion //Data

        #region DataCollection
        /// <summary>
        /// 
        /// </summary>
        public IDataCollection DataCollection
        {
            get
            {
                if (_dataCollection == null)
                {
                    _dataCollection = new IDataCollection();
                }
                return _dataCollection;
            }
        } private IDataCollection _dataCollection;
        #endregion //DataCollection

        #region AlarmData
        /// <summary>
        /// 报警数据
        /// </summary>
        public IAlarmData AlarmData
        {
            get { return _alarmData; }
            set 
            {
                if (_alarmData != value)
                {
                    _alarmData = value;
                    if (this.AlarmDataChanged != null)
                    {
                        if (CommuniSoft.IsUseUISynchronizationContext)
                        {
                            CommuniSoft.UISynchronizationContext.Post(
                                AlarmDataChangedCallback, null);
                        }
                        else
                        {
                            OnAlarmDataChanged();
                        }
                    }
                }
            }
        } private IAlarmData _alarmData;
        #endregion //AlarmData


        #region AlarmDataChangedCallback
        /// <summary>
        /// 
        /// </summary>
        private SendOrPostCallback AlarmDataChangedCallback
        {
            get
            {
                return new SendOrPostCallback(AlarmDataChangedCallbackTarget);
            }
        }
        #endregion //AlarmDataChangedCallback


        #region AlarmDataChangedCallbackTarget
        /// <summary>
        /// 
        /// </summary>
        /// <param name="state"></param>
        private void AlarmDataChangedCallbackTarget(object state)
        {
            OnAlarmDataChanged();
        }
        #endregion //AlarmDataChangedCallbackTarget


        #region OnAlarmDataChanged
        /// <summary>
        /// 
        /// </summary>
        private void OnAlarmDataChanged()
        {
            AlarmDataChanged(this, EventArgs.Empty);
        }
        #endregion //OnAlarmDataChanged

        #region StateChanged
        /// <summary>
        /// 
        /// </summary>
        public event EventHandler StateChanged;
        #endregion //StateChanged

        #region LastDataChanged
        /// <summary>
        /// 
        /// </summary>
        public event EventHandler DataChanged;

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler AlarmDataChanged;
        #endregion //LastDataChanged

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

        #region DeviceDefine
        /// <summary>
        /// 
        /// </summary>
        public DeviceDefine DeviceDefine
        {
            get { return _deviceDefine; }
        } private DeviceDefine _deviceDefine;
        #endregion //DeviceDefine


        #region ParameterCollection
        /// <summary>
        /// 
        /// </summary>
        public ParameterCollection ParameterCollection
        {
            get
            {
                if (_parameterCollection == null)
                {
                    _parameterCollection = new ParameterCollection();
                }
                return _parameterCollection;
            }
            set { _parameterCollection = value; }
        } private ParameterCollection _parameterCollection;
        #endregion //ParameterCollection


        #region ShowCommuniDetailsDialog
        /// <summary>
        /// 
        /// </summary>
        public void ShowCommuniDetailsDialog()
        {
            frmCommuniDetails f = new frmCommuniDetails(this, this.CommuniDetailQueue);
            f.ShowDialog();
        }
        #endregion //ShowCommuniDetailsDialog

    }
    #endregion//end Device
}

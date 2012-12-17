using System;
using System.Threading;
using System.Windows.Forms;
using System.Collections;
using Xdgk.Communi.Builder;
using Xdgk.Communi.Factory;
using Xdgk.Common;

namespace Xdgk.Communi
{

    // TODO: get device types, names
    //

    
    using Timer = System.Windows.Forms.Timer;

    /// <summary>
    /// 采集软件
    /// </summary>
    public class CommuniSoft
    {
        /// <summary>
        /// 默认计时器触发间隔
        /// </summary>
        private const int DefaultTimerInterval = 1000;

        #region Settings
        /// <summary>
        /// 
        /// </summary>
        public Hashtable Settings
        {
            get { return _settings; }
        } private Hashtable _settings;
        #endregion //Settings

        #region CommuniSoft
        /// <summary>
        /// 
        /// </summary>
        public CommuniSoft(Hashtable settings)
        {
            //this.SocketListenerManager.NewConnectEvent += new NewConnectEventHandler(SocketListenerManager_NewConnectEvent);
            this._settings = settings;
        }
        #endregion //CommuniSoft

        #region Default
        /// <summary>
        /// 
        /// </summary>
        static public CommuniSoft Default
        {
            get
            {
                //if (s_communiSoft == null)
                //    s_communiSoft = new CommuniSoft();
                return s_communiSoft;
            }

            internal set
            {
                s_communiSoft = value;
            }
        } static private CommuniSoft s_communiSoft;
        #endregion //Default

        #region BytesConverterManager
        /// <summary>
        /// 
        /// </summary>
        public BytesConverterManager BytesConverterManager
        {
            get
            {
                if (this._bytesConverterManager == null)
                    this._bytesConverterManager = new BytesConverterManager();
                return this._bytesConverterManager;
            }
        } private BytesConverterManager _bytesConverterManager;
        #endregion //BytesConverterManager

        #region CommuniPortManager
        /// <summary>
        /// 未关联的communiPort集合
        /// </summary>
        public CommuniPortManager CommuniPortManager
        {
            get
            {
                if (this._communiPortManager == null)
                    this._communiPortManager = new CommuniPortManager(this);
                return this._communiPortManager;
            }
        } private CommuniPortManager _communiPortManager;
        #endregion //CommuniPortManager

        #region TaskManager
        /// <summary>
        /// 
        /// </summary>
        public TaskManager TaskManager
        {
            get
            {
                if (this._taskManager == null)
                {
                    TimeSpan ts = TimeSpan.FromSeconds(10);
                    object obj = this._settings["TaskTimeout"];
                    if (obj != null)
                        ts = TimeSpan.Parse(obj.ToString());
                    _taskManager = new TaskManager(this, ts);
                }
                return _taskManager;
            }
        } private TaskManager _taskManager;
        #endregion //TaskManager

        #region HardwareManager
        /// <summary>
        /// 
        /// </summary>
        public HardwareManager HardwareManager
        {
            get
            {
                if (_hardwareManager == null)
                    _hardwareManager = new HardwareManager(this);
                return _hardwareManager;
            }
        }private HardwareManager _hardwareManager;
        #endregion //HardwareManager

        #region SocketListenerManager
        /// <summary>
        /// 
        /// </summary>
        public SocketListenerManager SocketListenerManager
        {
            get
            {
                if (_socketListenerManager == null)
                    _socketListenerManager = new SocketListenerManager(this);
                return _socketListenerManager;
            }
        } private SocketListenerManager _socketListenerManager;
        #endregion //SocketListenerManager


        #region OperaFactory
        ///// <summary>
        ///// 
        ///// </summary>
        //public OperaFactoryBase OperaFactory
        //{
        //    get
        //    {
        //        return _operaFactory;
        //    }
        //    set
        //    {
        //        if (value == null)
        //            throw new ArgumentNullException("OperaFactory");

        //        if (value != this._operaFactory)
        //        {
        //            this._operaFactory = value;
        //        }
        //    }
        //} private OperaFactoryBase _operaFactory;
        #endregion //OperaFactory

        #region CRCerManager
        /// <summary>
        /// 
        /// </summary>
        public CRCerManager CRCerManager
        {
            get
            {
                if (_crcerManager == null)
                    _crcerManager = new CRCerManager();
                return _crcerManager;
            }
        } private CRCerManager _crcerManager;
        #endregion //CRCerManager


        #region FDManager
        /// <summary>
        /// 
        /// </summary>
        public FDManager FDManager
        {
            get
            {
                if (_fdmanager == null)
                    _fdmanager = new FDManager(this);
                return _fdmanager;
            }
        } private FDManager _fdmanager;
        #endregion //FDManager


        #region DeviceDefineCollection
        ///// <summary>
        ///// 
        ///// </summary>
        //public DeviceDefineCollection DeviceDefineCollection
        //{
        //    get 
        //    {
        //        if (_deviceDefineCollection == null)
        //        {
        //            _deviceDefineCollection = new DeviceDefineCollection();
        //        }
        //        return _deviceDefineCollection;
        //    }
        //} private DeviceDefineCollection _deviceDefineCollection;
        #endregion //

        #region DeviceDefineManager
        /// <summary>
        /// 
        /// </summary>
        public DeviceDefineManager DeviceDefineManager
        {
            get
            {
                if (_deviceDefineManager == null)
                {
                    _deviceDefineManager = new DeviceDefineManager(this);
                }
                return _deviceDefineManager;
            }

        } private DeviceDefineManager _deviceDefineManager;
        #endregion //DeviceDefineManager

        #region GetTimer

        /// <summary>
        /// 
        /// </summary>
        private Timer GetTimer()
        {
            if (_timer == null)
            {
                _timer = new Timer();
                _timer.Interval = DefaultTimerInterval;
                _timer.Tick += new EventHandler(_timer_Tick);
            }
            return _timer;
        } private Timer _timer;//= new Timer();
        #endregion //GetTimer

        #region _timer_Tick
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _timer_Tick(object sender, EventArgs e)
        {
            this.TaskManager.Doit();
        }
        #endregion //_timer_Tick

        #region Start
        /// <summary>
        /// 
        /// </summary>
        public void Start()
        {
            GetTimer().Start();
        }
        #endregion //

        #region Stop
        /// <summary>
        /// 
        /// </summary>
        public void Stop()
        {
            GetTimer().Stop();
        }
        #endregion //

        #region Interval
        /// <summary>
        /// 
        /// </summary>
        public int Interval
        {
            get { return GetTimer().Interval; }
            set { GetTimer().Interval = value; }
        }
        #endregion //Interval

        #region IsUseUISynchronizationContext
        /// <summary>
        /// 
        /// </summary>
        static public bool IsUseUISynchronizationContext
        {
            get { return _isUseUISynchronizationContext; }
            set 
            {
                _isUseUISynchronizationContext = value;
            }
        } static private bool _isUseUISynchronizationContext;
        #endregion //IsUseUISynchronizationContext

        #region UISynchronizationContext
        /// <summary>
        /// 获取或设置UI线程上下文
        /// </summary>
        static public SynchronizationContext UISynchronizationContext
        {
            get
            {
                return _uiSynchronizationContext;
            }
            set
            {
                _uiSynchronizationContext = value;
            }
        } static private SynchronizationContext _uiSynchronizationContext;
        #endregion //UISynchronizationContext
    }
}

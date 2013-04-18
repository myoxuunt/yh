using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using Xdgk.Common;
using Xdgk.CF;
using Common;
using PS6216DataImporter;

namespace RWTrans
{
    /// <summary>
    /// 
    /// </summary>
    public class App
    {

        #region Default
        /// <summary>
        /// 
        /// </summary>
        static public App Default
        {
            get
            {
                if (_default == null)
                {
                    _default = new App();
                }
                return _default;
            }
        } static private App _default;
        #endregion //Default

        #region App
        /// <summary>
        /// 
        /// </summary>
        private App()
        {
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            System.AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
        }
        #endregion //App

        #region Run
        /// <summary>
        /// 
        /// </summary>
        public void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(this.MainForm);
        }
        #endregion //Run

        #region CurrentDomain_UnhandledException
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            HandleException(e.ExceptionObject as Exception);
        }
        #endregion //CurrentDomain_UnhandledException

        #region Application_ThreadException
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            HandleException(e.Exception);
        }
        #endregion //Application_ThreadException

        #region HandleException
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ex"></param>
        private void HandleException(Exception ex)
        {
            ExceptionHandler.Handle(ex);
            Environment.Exit(1);
        }
        #endregion //HandleException


        #region Config
        ///// <summary>
        ///// 
        ///// </summary>
        //public Config Config
        //{
        //    get
        //    {
        //        if (_config == null)
        //        {
        //            _config = new Config();
        //        }
        //        return _config;
        //    }
        //} private Config _config;
        #endregion //Config

        #region GetTimer
        ///// <summary>
        ///// 
        ///// </summary>
        //private Timer GetTimer()
        //{
        //    if (_timer == null)
        //    {
        //        _timer = new Timer();
        //        _timer.Tick += new EventHandler(_timer_Tick);
        //        _timer.Interval = (int)(Config.ExecuteTimeSpan.TotalSeconds * 1000);
        //    }
        //    return _timer;
        //} private Timer _timer;
        #endregion //GetTimer

        #region Start
        ///// <summary>
        ///// 
        ///// </summary>
        //public void Start()
        //{
        //    GetTimer().Start();
        //}
        #endregion //Start

        #region _timer_Tick
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void _timer_Tick(object sender, EventArgs e)
        {
            //Logger.Add(strings.TransBegin);
            //Doit();
            //Logger.Add(strings.TransEnd);
            //Logger.AddSeparatLine();
        }
        #endregion //_timer_Tick

        #region Doit
        ///// <summary>
        ///// 
        ///// </summary>
        //public void Doit()
        //{
        //    this.ItemCollection.Clear();

        //    DataType type = DataType.Rain;
        //    DataTable stationTbl = FromDBI.GetRainStationDataTable();
        //    foreach (DataRow row in stationTbl.Rows)
        //    {
        //        Item item = ItemFactory.Create(row, type);
        //        this.ItemCollection.Add(item);

        //    }

        //    type = DataType.Water;
        //    stationTbl = FromDBI.GetWaterStationDataTable();
        //    foreach (DataRow row in stationTbl.Rows)
        //    {
        //        Item item = ItemFactory.Create(row, type);
        //        this.ItemCollection.Add(item);
        //    }


        //    foreach (Item item in ItemCollection)
        //    {
        //        int transCount = item.Transmit();

        //        string msg = string.Format(
        //            strings.TransmitedCount,
        //            item.FromName, transCount
        //            );
        //        Logger.Add(msg);
        //    }
        //}
        #endregion //Doit

        #region ItemFactory
        ///// <summary>
        ///// 
        ///// </summary>
        //private ItemFactory ItemFactory
        //{
        //    get
        //    {
        //        if (_itemFactory == null)
        //        {
        //            _itemFactory = new ItemFactory(this.ToDBI);
        //        }
        //        return _itemFactory;
        //    }
        //} private ItemFactory _itemFactory;
        #endregion //ItemFactory

        #region ItemCollection
        ///// <summary>
        ///// 
        ///// </summary>
        //public ItemCollection ItemCollection
        //{
        //    get
        //    {
        //        if (_itemCollection == null)
        //        {
        //            _itemCollection = new ItemCollection();
        //        }
        //        return _itemCollection;
        //    }
        //    set
        //    {
        //        _itemCollection = value;
        //    }
        //} private ItemCollection _itemCollection;
        #endregion //ItemCollection

        #region FromDBI
        ///// <summary>
        ///// 
        ///// </summary>
        //public FromDBI FromDBI
        //{
        //    get
        //    {
        //        if (_fromDBI == null)
        //        {
        //            _fromDBI = new FromDBI(this.Config.FromConnectionString);
        //        }
        //        return _fromDBI;
        //    }
        //    set
        //    {
        //        _fromDBI = value;
        //    }
        //} private FromDBI _fromDBI;
        #endregion //FromDBI

        private Importer _ps6216DataImporter;
        public Importer GetPS6216DataImporter()
        {
            if (_ps6216DataImporter == null)
            {
                _ps6216DataImporter = new Importer(App.Default.Logger);
            }
            return _ps6216DataImporter;
        }


        #region ToDBIForPs
        /// <summary>
        /// 
        /// </summary>
        public ToDBI ToDBI
        {
            get
            {
                if (_toDBI == null)
                {
                    _toDBI = new ToDBI(this.GetPS6216DataImporter().Config.ToConnectionString);
                }
                return _toDBI;
            }
            set
            {
                _toDBI = value;
            }
        } private ToDBI _toDBI;
        #endregion //ToDBIForPs

        #region MainForm
        /// <summary>
        /// 
        /// </summary>
        public frmMain MainForm
        {
            get
            {
                if (_mainForm == null)
                {
                    _mainForm = new frmMain();
                }
                return _mainForm;
            }
            set
            {
                _mainForm = value;
            }
        } private frmMain _mainForm;
        #endregion //MainForm

        #region Logger
        /// <summary>
        /// 
        /// </summary>
        public Logger Logger
        {
            get
            {
                if (_logger == null)
                {
                    _logger = new Logger();
                    _logger.OutputTextBox = MainForm.GetLoggerTextBox();
                }
                return _logger;
            }
        } private Logger _logger;
        #endregion //Logger

        #region DevieFormaulCollectionMapCollection
        /// <summary>
        /// 
        /// </summary>
        public DevieFormaulCollectionMapCollection DevieFormaulCollectionMapCollection
        {
            get
            {
                DevieFormaulCollectionMapCollection _dfsmaps = DeviceFormaulManager.DevieFormaulCollectionMapCollection;
                //if (!DeviceFormaulManager.IsInitCQFormaul)
                //{
                //    //_dfsmaps = new DevieFormaulCollectionMapCollection();

                //    DataTable stationTbl = FromDBI.GetWaterStationDataTable();
                //    foreach (DataRow row in stationTbl.Rows)
                //    {
                //        Item item = ItemFactory.Create(row, DataType.Water);
                //        DataTable formulaTbl = ToDBI.GetFormulaDataTable(item.ToDeviceID);
                //        _dfsmaps.AddDevice(item.ToDeviceID, formulaTbl.Rows);

                //        // set name
                //        //
                //        _dfsmaps[_dfsmaps.Count - 1].Tag = item.FromName;
                //    }

                //    DeviceFormaulManager.IsInitCQFormaul = true;
                //}
                return _dfsmaps;
            }
        } 
        //private DevieFormaulCollectionMapCollection _dfsmaps;
        #endregion //DevieFormaulCollectionMapCollection
    }
}

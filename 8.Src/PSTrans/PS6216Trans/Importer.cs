using System;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Xdgk.CF;
using Common;

namespace PS6216DataImporter
{
    /// <summary>
    /// 
    /// </summary>
    public class Importer
    {

        /// <summary>
        /// 
        /// </summary>
        //private WriteDelegate _writeDelegate;

        private RWTrans.Logger _logger = null;
        public Importer(RWTrans.Logger logger)
        {
            _logger = logger;
            InitDeviceFormaul();
        }

        private void InitDeviceFormaul()
        {
            if (!DeviceFormaulManager.IsInitPSFormaul)
            {

                DevieFormaulCollectionMapCollection _dfsmaps = DeviceFormaulManager.DevieFormaulCollectionMapCollection;
                foreach (TransItem ti in this.TransItemCollection)
                {
                    ToDBI dbi = (ToDBI)ti.ToDevice.DBI;
                    DataTable fromulaTbl = dbi.GetFormulaDataTable(ti.ToDevice.ID);
                    _dfsmaps.AddDevice(ti.ToDevice.ID, fromulaTbl.Rows);

                    _dfsmaps[_dfsmaps.Count - 1].Tag = "noname(DATA6216)";
                }
                DeviceFormaulManager.IsInitPSFormaul = true;
            }
        }

        private Timer Timer
        {
            get
            {
                if (_timer == null)
                {
                    _timer = new Timer();

                    // 2 minute per time
                    //
                    _timer.Interval = 10 * 1000;
                    _timer.Tick += new EventHandler(_timer_Tick);
                }
                return _timer;
            }
        } private Timer _timer;

        public void Start()
        {
            Timer.Start();
        }

        public void Stop()
        {
            Timer.Stop();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param deviceType="sender"></param>
        /// <param deviceType="e"></param>
        void _timer_Tick(object sender, EventArgs e)
        {
            this.Doit();
        }

        /// <summary>
        /// 
        /// </summary>
        public Config Config
        {
            get
            {
                if (_config == null)
                {
                    _config = CreateConfig();
                }
                return _config;
            }
        } private Config _config;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Config CreateConfig()
        {
            string filename = Path.Combine(Application.StartupPath, "PS6216Import.xml");
            Config config = null;
            try
            {
                config = (Config)Config.Load(typeof(Config), filename);
            }
            catch (Exception ex)
            {
                config = new Config();
                config.FromConnectionString = "f";
                config.ToConnectionString = "t";
                config.ImportInterval = TimeSpan.Parse("00:00:10");

                NameMap nm = new NameMap();
                nm.FromName = "FN";
                nm.ToName = "TN";

                config.NameMapCollection.Add(nm);

                config.Save(filename);
                NUnit.UiKit.UserMessage.DisplayFailure(ex.Message);
                Environment.Exit(1);
            }
            return config;
        }

        /// <summary>
        /// 
        /// </summary>
        private DateTime _lastExecuteDT;

        public void Doit()
        {
            if (Config.Enabled)
            {
                if (NeedExecute())
                {
                    ExecuteImport();
                    _lastExecuteDT = DateTime.Now;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool NeedExecute()
        {
            TimeSpan ts = DateTime.Now - _lastExecuteDT;
            if (ts > _config.ImportInterval || ts < TimeSpan.Zero)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void ExecuteImport()
        {
            foreach (TransItem item in this.TransItemCollection)
            {
                string beginMsg = string.Format("开始传输 - {0} -> {1}", item.FromDevice.Name, item.ToDevice.Name);
                _logger.Add(beginMsg);

                DateTime lastDT = item.ToDevice.ReadLastDataDateTime();
                _logger.Add(string.Format("'{0}' 最后记录时间 '{1}'", item.ToDevice.Name, lastDT));

                DataTable tbl = item.FromDevice.ReadDataTable(lastDT);

                item.ToDevice.WriteDataTable(tbl);

                string msg = string.Format("传输 '{0}' 记录 '{1}' 条", item.ToDevice.Name, tbl.Rows.Count);
                _logger.Add(msg);

                _logger.Add("结束传输");
                _logger.AddSeparatLine();
            }
        }

        #region ImportItemCollection
        /// <summary>
        /// 
        /// </summary>
        public TransItemCollection TransItemCollection
        {
            get
            {
                if (_transItemCollection == null)
                {
                    // create
                    //
                    _transItemCollection = new TransItemCollection();
                    foreach (NameMap nm in Config.NameMapCollection)
                    {
                        TransItem item = TransItemFactory.Create(nm, this.Config.FromDBI, this.Config.ToDBI);
                        _transItemCollection.Add(item);
                    }
                }
                return _transItemCollection;
            }
            set
            {
                _transItemCollection = value;
            }
        } private TransItemCollection _transItemCollection;
        #endregion //ImportItemCollection


    }
}

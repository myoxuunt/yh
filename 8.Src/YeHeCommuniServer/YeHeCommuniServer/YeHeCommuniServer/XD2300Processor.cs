using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Common;
using Xdgk.Communi;
using NLog;

namespace YeHeCommuniServer
{
    /// <summary>
    /// 
    /// </summary>
    public class XD2300Processor
    {
        /// <summary>
        /// 
        /// </summary>
        static private Logger log = LogManager.GetCurrentClassLogger();


        #region Test
        //static bool added = false;
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="xd2300"></param>
        //void AddReadRecordTestTask( XD2300Device xd2300)
        //{
        //    if (added == false)
        //    {
        //        System.Windows.Forms.MessageBox.Show("add test readrecord");
        //        added = true;
                
        //        Opera readRecordOpera = xd2300.DeviceDefine.CreateOpera(XD2300OperaNames.ReadRecord);
        //        readRecordOpera.SendPart["RecordIndex"] = 0x177;
        //        Task t = new Task(xd2300, readRecordOpera, new CycleStrategy (new TimeSpan(0,0,10)));
        //        YeHeCommuniServerApp.Default.CommuniSoft.TaskManager.Tasks.Add(t);
        //    }
        //}
        #endregion //Test


        #region Default
        /// <summary>
        /// 
        /// </summary>
        static public XD2300Processor Default
        {
            get
            {
                if (_default == null)
                {
                    _default = new XD2300Processor();
                }
                return _default;
            }
        } static private XD2300Processor _default;
        #endregion //Default

        
        #region ProcessExecutedTask
        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        /// <param name="pr"></param>
        public void ProcessExecutedTask(Task task, ParseResult pr)
        {
            //AddReadRecordTestTask(task.Device as XD2300Device);

            string logMsg = string.Format("process task {0} {1}", task.Opera.Name, pr.Success );
            log.Debug(logMsg);

            if (pr.Success)
            {
                ProcessSucess(task, pr);
            }
            else
            {
                // task fail
                //
                ProcessFail(task);
            }
        }
        #endregion //ProcessExecutedTask

        #region ProcessFail
        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        private void ProcessFail(Task task)
        {
            XD2300Device xd2300 = task.Device as XD2300Device ;
            if (StringHelper.Equal(task.Opera.Name, XD2300OperaNames.ReadRecord))
            {
                int recordIndex = Convert.ToInt32(task.Opera.SendPart["RecordIndex"]);
                if (recordIndex >= xd2300.LastRecordIndex)
                {
                    AddDownTask(xd2300);
                }
            }
        }
        #endregion //ProcessFail

        #region ProcessSucess
        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        /// <param name="pr"></param>
        private static void ProcessSucess(Task task, ParseResult pr)
        {
            XD2300Device xd2300 = task.Device as XD2300Device;
            if (StringHelper.Equal(task.Opera.Name, OperaNames.ReadReal))
            {
                ProcessReadReal(xd2300, pr);
            }
            else if (StringHelper.Equal(task.Opera.Name, XD2300OperaNames.ReadRecordIndex))
            {
                ProcessReadRecordIndex(xd2300, pr);
            }
            else if (StringHelper.Equal(task.Opera.Name, XD2300OperaNames.ReadRecord))
            {
                ProcessReadRecord(pr, xd2300);
            }
        }
        #endregion //ProcessSucess

        #region ProcessReadRecord
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pr"></param>
        /// <param name="xd2300"></param>
        private static void ProcessReadRecord(ParseResult pr, XD2300Device xd2300)
        {
            int recordIndex = Convert.ToInt32(pr.NameObjects.GetObject("RecordIndex"));
            DateTime dt = Convert.ToDateTime(pr.NameObjects.GetObject("DT"));
            // 11 -> 2011
            //
            dt = FixDateTime(dt);

            int wl1 = Convert.ToInt32(pr.NameObjects.GetObject("WL1"));
            int wl2 = Convert.ToInt32(pr.NameObjects.GetObject("WL2"));

            wl1 = wl1 / 10;
            wl2 = wl2 / 10;
            //DitchData d = new DitchData(wl1, wl2, instantFlux, 0, 0);
            SetAndSaveDitchData(xd2300, dt, wl1, wl2, 0);
            //XD2300Device xd2300 = task.Device as XD2300Device ;
            if (recordIndex >= xd2300.LastRecordIndex)
            {
                AddDownTask(xd2300);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="dt"></param>
        static private DateTime FixDateTime(DateTime dt)
        {
            int year = dt.Year;
            if (year < 0x100)
            {
                dt = dt.AddYears(2000);
            }
            return dt;
        }
        #endregion //ProcessReadRecord

        #region ProcessReadRecordIndex
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pr"></param>
        /// <param name="xd2300"></param>
        private static void ProcessReadRecordIndex(XD2300Device xd2300, ParseResult pr)
        {
            // process read record index
            //
            UInt16 index = Convert.ToUInt16(pr.NameObjects.GetObject("RecordIndex"));

            // create new read record task
            //
            if (xd2300.IsLastRecordIndexValid())
            {
                int readedIndex = xd2300.LastRecordIndex;
                for (int i = readedIndex + 1; i <= index; i++)
                {
                    Opera readRecordOpera = xd2300.DeviceDefine.CreateOpera(XD2300OperaNames.ReadRecord);
                    readRecordOpera.SendPart["RecordIndex"] = i;
                    Task t = new Task(xd2300, readRecordOpera, new ImmediateStrategy());
                    YeHeCommuniServerApp.Default.CommuniSoft.TaskManager.Tasks.Add(t);
                    
                }
            }
            else
            {
                // down 
                //
                AddDownTask(xd2300);
            }

            // set new record index
            //
            xd2300.LastRecordIndex = index;
        }
        #endregion //ProcessReadRecordIndex

        #region ProcessReadReal
        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        /// <param name="pr"></param>
        private static void ProcessReadReal(XD2300Device xd2300, ParseResult pr)
        {
            int wl1 = (Int16)pr.NameObjects.GetObject("WD1");
            int wl2 = (Int16)pr.NameObjects.GetObject("WD2");

            wl1 = wl1 / 10;
            wl2 = wl2 / 10;

            object objTemp = pr.NameObjects.GetObject("voltage");
            int voltage = Convert.ToInt32(objTemp);

            voltage = voltage / 100;

            DateTime dt = DateTime.Now;
            SetAndSaveDitchData(xd2300, dt, wl1, wl2, voltage);

            //AddDownTask(xd2300);
        }
        #endregion //ProcessReadReal

        #region SetAndSaveDitchData
        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        /// <param name="wl1"></param>
        /// <param name="wl2"></param>
        /// <param name="voltage"></param>
        private static void SetAndSaveDitchData(XD2300Device xd2300, DateTime dt, int wl1, int wl2, int voltage)
        {
            float instantFlux = CalcInstantFlux(xd2300.ID, dt, wl1, wl2);
            uint usedAmount = 0;
            //DitchDevice ditchDevice = task.Device as DitchDevice;
            xd2300.DitchData = new DitchData(dt, wl1, wl2, instantFlux, usedAmount, voltage);
            DB.DitchDataDBI.Insert(xd2300, dt, instantFlux, wl1, wl2, usedAmount, voltage);
        }
        #endregion //SetAndSaveDitchData

        #region CalcInstantFlux
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wl1"></param>
        /// <param name="wl2"></param>
        /// <returns></returns>
        private static float CalcInstantFlux(int deviceID, DateTime dt, int wl1, int wl2)
        {
            if (Config.Default.IsUseFluxFormula)
            {
                return YeHeCommuniServerApp.Default.DevieFormaulCollectionMapCollection.CalcInstantFlux(
                    deviceID, dt, wl1, wl2);
            }
            else
            {
                return 0;
            }
        }
        #endregion //CalcInstantFlux

        #region AddDownTask
        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        private static void AddDownTask(XD2300Device xd2300)
        {
            log.Debug("add xd2300 down task");

            // add down command
            //
            Opera downOP = xd2300.DeviceDefine.CreateOpera(XD2300OperaNames.Down);
            Task downTask = new Task(xd2300, downOP, new ImmediateStrategy());
            YeHeCommuniServerApp.Default.CommuniSoft.TaskManager.Tasks.Add(downTask);
        }
        #endregion //AddDownTask

        #region ProcessExecutingTask
        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        internal void ProcessExecutingTask(Task task)
        {
            //if (StringHelper.Equal(task.Opera.Name, "WriteRecordSaveTimeSpan"))
            //{
            //    Opera op = task.Opera;
            //    //object obj = op.SendPart["RecordTimeSpan"];
            //    op.SendPart["RecordSaveTimespan"] = new byte[] { 0x00, 0x0B};
            //}
        }
        #endregion //ProcessExecutingTask

    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Xdgk.Common;
using NUnit.Core;

namespace Xdgk.Communi
{
    /// <summary>
    /// 任务管理器
    /// </summary>
    public class TaskManager
    {
        /// <summary>
        /// 
        /// </summary、>
        static private Logger log = InternalTrace.GetLogger( typeof(TaskManager));

        #region Timeout
        /// <summary>
        /// 获取或设置执行超时时间
        /// </summary>
        public TimeSpan Timeout
        {
            get { return _timeout; }
            set
            {
                // 最小 500ms
                if (value < TimeSpan.FromMilliseconds(500))
                    throw new ArgumentOutOfRangeException("Timeout", value, "must >= 500ms");
                if (value > TimeSpan.FromSeconds(30))
                    throw new ArgumentOutOfRangeException("Timeout", value, "must <= 30s" );

                this._timeout = value;
            }
        } private TimeSpan _timeout = TimeSpan.FromSeconds(10);
        #endregion //Timeout

        #region Events
        /// <summary>
        /// 执行Task之前触发此事件
        /// </summary>
        public event TaskExecutingEventHandler Executing;

        /// <summary>
        /// 执行Task之后触发此事件
        /// </summary>
        public event TaskExecutedEventHandler Executed;

        /// <summary>
        /// 当找不到与设备相关的CommuniPort时候触发此事件
        /// </summary>
        public event NotFindCommuniPortEventHandler NotFindCommuniPort;
        #endregion //

        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        public TaskManager(CommuniSoft soft, TimeSpan timeoutValue)
        {
            if (soft == null)
                throw new ArgumentNullException("communiSoft");
            this.Timeout = timeoutValue;
            this._communiSoft = soft;
        }
        #endregion //Constructor

        #region CommuniSoft
        /// <summary>
        /// 
        /// </summary>
        public CommuniSoft CommuniSoft
        {
            get { return _communiSoft; }
        } private CommuniSoft _communiSoft;
        #endregion //CommuniSoft

        #region Tasks
        /// <summary>
        /// 
        /// </summary>
        public TaskCollection Tasks
        {
            get
            {
                if (this._taskCollection == null)
                    this._taskCollection = new TaskCollection();
                return _taskCollection;
            }
        } private TaskCollection _taskCollection;
        #endregion //Tasks

        #region ExecutingTasks
        /// <summary>
        /// 获取正在执行(已经发送，未接收)的Task列表
        /// </summary>
        public TaskCollection ExecutingTasks
        {
            get
            {
                if (_executingTasks == null)
                    _executingTasks = new TaskCollection();
                return _executingTasks;
            }
        } private TaskCollection _executingTasks;
        #endregion //ExecutingTasks


        #region LogSend
        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        /// <param name="bytes"></param>
        private void LogSend( Task task, byte[] bytes)
        {
            LogHelper(task, bytes, "send");
        }
        #endregion //LogSend

        #region LogHelper
        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        /// <param name="bytes"></param>
        /// <param name="sendOrReceived"></param>
        private static void LogHelper(Task task, byte[] bytes, string sendOrReceived)
        {
            string s = string.Format("{0}-{1} {3}: {2}",
                task.Device.Station.Name,
                task.Device.DeviceType,
                HexStringConverter.Default.ConvertToObject(bytes),
                sendOrReceived );
            log.Debug(s);
        }
        #endregion //LogHelper

        #region LogReceived
        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        /// <param name="bytes"></param>
        private void LogReceived(Task task, byte[] bytes)
        {
            LogHelper(task, bytes, "Received");
        }
        #endregion //LogReceived

        #region Doit
        /// <summary>
        /// 
        /// </summary>
        public void Doit()
        {
            // check sended collection
            // 
            CheckSendedCollection();

            // 
            //
            ProcessTasks();
        }
        #endregion //Doit

        #region ProcessTasks
        /// <summary>
        /// 
        /// </summary>
        private void ProcessTasks()
        {
            TaskCollection checkedTasks = new TaskCollection();

            for (Task task = this.Tasks.Pick(); 
                task != null;
                task = this.Tasks.Pick())
            {
                bool canExecute = false;
                bool executed = false;
                bool executeSuccess = false;

                if (task.NeedExecute())
                {
                    CommuniPort cp = GetCommPort(task.Device);
                    canExecute = cp != null;
                    if (canExecute)
                    {       
                        if (!cp.IsOccupy)
                        {
                            executeSuccess = ExecuteTask(task, cp);
                            executed = true;
                        }
                    }
                    else
                    {
                        // 2010-09-15
                        //
                        //OnNotCommuniPortTask(task);
                        if (CommuniSoft.IsUseUISynchronizationContext)
                        {
                            CommuniSoft.UISynchronizationContext.Post(
                                this.NotCommuniPortTaskCallback, task);
                        }
                        else
                        {
                            this.OnNotCommuniPortTask(task);
                        }
                    }
                }

                AAA(checkedTasks, task, canExecute, executed, executeSuccess);
            }
            this._taskCollection = checkedTasks;
        }
        #endregion //ProcessTasks

        #region NotCommuniPortTaskCallback
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private SendOrPostCallback NotCommuniPortTaskCallback
        {
            get
            {
                return new SendOrPostCallback(this.NotCommuniPortTaskCallbackTarget);
            }
        }
        #endregion //NotCommuniPortTaskCallback


        /// <summary>
        /// 
        /// </summary>
        /// <param name="state"></param>
        private void NotCommuniPortTaskCallbackTarget(object state)
        {
            Task task = state as Task;
            Debug.Assert(task!=null, "task == null, at NotCommuniPortTaskCallbackTarget()");
            OnNotCommuniPortTask(task);    
        }

        /// <summary>
        /// 分配任务到 CheckedTasks 或 ExecutingTasks
        /// </summary>
        /// <param name="checkedTasks"></param>
        /// <param name="task"></param>
        /// <param name="executeSuccess"></param>
        private void AAA(TaskCollection checkedTasks, Task task, bool canExecute, bool executed, bool executeSuccess)
        {
            if (canExecute && executed && executeSuccess)
            {
                this.ExecutingTasks.Add(task);
                return;
            }

            if (task.CanRemove)
            {
                // 2010-06-10
                // fix remove not connected immedia task
                //
                //if (canExecute && !executed)
                //    checkedTasks.Add(task);

                if (!executed)
                {
                    checkedTasks.Add(task);
                }
            }
            else
            {
                checkedTasks.Add(task);
            }

            //if( !canExecute && task.CanRemove )

            //if (canExecute)
            //{
            //    if (executeSuccess)
            //    {
            //        this.ExecutingTasks.Add(task);
            //    }
            //    else
            //    {
            //        if (!task.CanRemove)
            //            checkedTasks.Add(task);
            //    }
            //}
            //else
            //{
            //    checkedTasks.Add(task);
            //}
        }

        #region ProcessExecuteTask
        /// <summary>
        /// 
        /// </summary>
        /// <param name="checkedTasks"></param>
        /// <param name="task"></param>
        /// <param name="cp"></param>
        private bool ExecuteTask(Task task, CommuniPort cp)
        {
            byte[] bytes = task.GetSendBytes();
            bool writeSuccess = cp.Write(bytes);

            if (writeSuccess)
            {
                // log send bytes: station - devicetype - bytes
                // 
                LogSend(task, bytes); 
                cp.Occupy(this.Timeout);
                task.LastExecute = DateTime.Now;

                // 2010-09-15
                //
                //OnExecuting(task);
                if (CommuniSoft.IsUseUISynchronizationContext)
                {
                    CommuniSoft.UISynchronizationContext.Post(
                        this.ExecutingCallback,
                        task);
                }
                else
                {
                    OnExecuting(task);
                }
            }
            return writeSuccess;
        }
        #endregion //ProcessExecuteTask

        #region ExecutingCallback
        /// <summary>
        /// 
        /// </summary>
        private SendOrPostCallback ExecutingCallback
        {
            get
            {
                return new SendOrPostCallback(this.ExecutingCallbackTarget);
            }
        }
        #endregion //ExecutingCallback

        #region ExecutingCallbackTarget
        /// <summary>
        /// 
        /// </summary>
        /// <param name="state"></param>
        private void ExecutingCallbackTarget(object state)
        {
            Task task = state as Task;
            Debug.Assert(task != null, "task == null, at ExecutingCallbackTarget");
            OnExecuting(task);
        }
        #endregion //ExecutingCallbackTarget

        #region OnExecuting
        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        private void OnExecuting(Task task)
        {
            if (this.Executing != null)
            {
                TaskExecutingEventArgs e = new TaskExecutingEventArgs(task);
                Executing(this, e);
            }
        }
        #endregion //OnExecuting

        #region ProcessNotCommuniPortTask
        /// <summary>
        /// 
        /// </summary>
        /// <param name="checkedTasks"></param>
        /// <param name="task"></param>
        private void OnNotCommuniPortTask(Task task)
        {
            // not find cp event
            //
            if (this.NotFindCommuniPort != null)
            {
                NotFindCommuniPortEventArgs e = new NotFindCommuniPortEventArgs(task);
                this.NotFindCommuniPort(this, e);
            }
        }
        #endregion //ProcessNotCommuniPortTask


        #region CheckSendedCollection
        /// <summary>
        /// 
        /// </summary>
        private void CheckSendedCollection()
        {
            TaskCollection temp = new TaskCollection();

            for (Task t = this.ExecutingTasks.Pick();
                t != null;
                t = this.ExecutingTasks.Pick())
            {
                TimeSpan ts = DateTime.Now - t.LastExecute;
                if (ts >= this.Timeout)
                {
                    DoitReceive(t);
                }
                else
                {
                    temp.Add(t);
                }
            }
            this._executingTasks = temp;
        }
        #endregion //CheckSendedCollection

        #region GetCommuniPort
        /// <summary>
        /// return communiPort or null
        /// </summary>
        /// <param name="device"></param>
        /// <returns></returns>
        private CommuniPort GetCommPort(Device device)
        {
            if (device == null)
                throw new ArgumentNullException("device");

            Station station = CommuniSoft.HardwareManager.GetStation(device);
            Debug.Assert(station != null, "station == null");

            //return this.CommuniSoft.CommuniPortManager.FindCommuniPort(station.CommuniType);
            return station.CommuniPort;
        }
        #endregion //GetCommuniPort


        #region DoitReceive
        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        public void DoitReceive(Task task)
        {
            // get match cp with task
            //
            CommuniPort cp = this.GetCommPort(task.Device);

            byte[] bytes = null;
            if (cp != null)
            {
                //cp.Read();
                //bytes = cp.ReceivedBytes;
                bytes = cp.Read();
            }
            //else
            //{
            //    //bytes = null;
            //    bytes = new byte[0];
            //}

            LogReceived(task, bytes);
            
            ParseResult pr = task.ParseReceiced(bytes);
            TaskExecutedEventArgs e = new TaskExecutedEventArgs(task, pr);

            // 2010-09-15
            //
            //OnExecuted(task, pr);
            if (CommuniSoft.IsUseUISynchronizationContext)
            {
                CommuniSoft.UISynchronizationContext.Post(
                    this.ExecutedCallback, e);
            }
            else
            {
                OnExecuted(e);
            }

            // process df
            // 
            if ((bytes != null && bytes.Length > 0))
            {
                if (!pr.Success)
                {
                    this.CommuniSoft.FDManager.Process(cp, bytes);
                }
                else if (pr.Remain != null)
                {
                    this.CommuniSoft.FDManager.Process(cp, pr.Remain);
                }
            }

            if (!task.CanRemove)
            {
                this.Tasks.Add(task);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private SendOrPostCallback ExecutedCallback
        {
            get
            {
                return new SendOrPostCallback(ExecutedCallbackTarget);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="state"></param>
        private void ExecutedCallbackTarget(object state)
        {
            TaskExecutedEventArgs e = state as TaskExecutedEventArgs;
            OnExecuted(e);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        /// <param name="pr"></param>
        //private void OnExecuted(Task task, ParseResult pr)
        private void OnExecuted(TaskExecutedEventArgs e)
        {
            // event
            //
            if (this.Executed != null)
            {
                //TaskExecutedEventArgs e = new TaskExecutedEventArgs(task, pr);
                Executed(this, e);
            }
        }
        #endregion //DoitReceive


        #region GetTasks
        /// <summary>
        /// 
        /// </summary>
        /// <param name="device"></param>
        /// <returns></returns>
        public Task[] GetTasks(Device device)
        {
            List<Task> list = new List<Task>();
            this._executingTasks.GetTasks(device, list);
            this._taskCollection.GetTasks(device, list);

            return list.ToArray();
        }
        #endregion //GetTasks

        #region RemoveTaskByDevice
        /// <summary>
        /// 
        /// </summary>
        public void RemoveTaskByDevice(Device device)
        {
            this.Tasks.RemoveByDevice(device);
            this.ExecutingTasks.RemoveByDevice(device);
        }
        #endregion //RemoveTaskByDevice

        #region RemoveTaskByDeviceCollection
        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceCollection"></param>
        public void RemoveTaskByDeviceCollection(DeviceCollection deviceCollection)
        {
            foreach (Device d in deviceCollection)
            {
                this.RemoveTaskByDevice(d);
            }
        }
        #endregion //RemoveTaskByDeviceCollection
    }
}
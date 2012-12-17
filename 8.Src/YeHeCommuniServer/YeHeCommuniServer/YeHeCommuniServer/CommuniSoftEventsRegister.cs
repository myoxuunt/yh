using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Communi;

namespace YeHeCommuniServer
{
    public class CommuniSoftEventsRegister
    {
        private CommuniSoft _communiSoft;
        private YeHeProcessor _processAddin;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="communiSoft"></param>
        public CommuniSoftEventsRegister(CommuniSoft communiSoft, YeHeProcessor processor)
        {
            if (communiSoft == null)
                throw new ArgumentNullException("communiSoft");

            if(processor == null)
                throw new ArgumentNullException("processor");

            _communiSoft = communiSoft;
            //_processAddin = _communiSoft.ProcessAddinManager.ProcessAddin;
            _processAddin = processor;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Registe()
        {
            _communiSoft.TaskManager.Executing += new TaskExecutingEventHandler(TaskManager_Executing);
            _communiSoft.TaskManager.Executed += new TaskExecutedEventHandler(TaskManager_Executed);
            _communiSoft.FDManager.FDEvent += new FDEventHandler(FDManager_FDEvent);

            foreach (Station st in _communiSoft.HardwareManager.Stations)
            {
                //_communiSoft.HardwareManager.Stations[0].CommuniPortChanged +=
                st.CommuniPortChanged += new EventHandler(CommuniSoftEventsRegister_CommuniPortChanged);
            }
        }

        void CommuniSoftEventsRegister_CommuniPortChanged(object sender, EventArgs e)
        {
            _processAddin.CommuniPortChanged(sender as Station);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FDManager_FDEvent(object sender, FDEventArgs e)
        {
            _processAddin.ProcessFD(e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void TaskManager_Executed(object sender, TaskExecutedEventArgs e)
        {
            _processAddin.ProcessExecutedTask(e.Task, e.ParseResult);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void TaskManager_Executing(object sender, TaskExecutingEventArgs e)
        {
            _processAddin.ProcessExecutingTask(e.Task);
        }
    }
}

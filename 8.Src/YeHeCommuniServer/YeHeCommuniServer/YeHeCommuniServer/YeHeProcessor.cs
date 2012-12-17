using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Communi;
using System.Threading;
using Xdgk.Common;
using NUnit.Core;
using System.Windows.Forms;

namespace YeHeCommuniServer
{
    /// <summary>
    /// 
    /// </summary>
    public class YeHeProcessor 
    {

        /// <summary>
        /// 
        /// </summary>
        static private NUnit.Core.Logger log = InternalTrace.GetLogger(typeof(YeHeProcessor));



        #region ProcessExecutingTask
        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        public void ProcessExecutingTask(Task task)
        {
            //throw new NotImplementedException();
            if (StringHelper.Equal(task.Device.DeviceDefine.DeviceType,
                DeviceDefineConst.DDT_XD2300))
            {
                XD2300Processor.Default.ProcessExecutingTask(task);
            }
        }
        #endregion //ProcessExecutingTask


        #region ProcessExecutedTask
        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        /// <param name="pr"></param>
        public void ProcessExecutedTask(Task task, ParseResult pr)
        {
            if (pr.Success)
            {
                if (StringHelper.Equal(task.Device.DeviceDefine.DeviceType,
                    DeviceDefineConst.DDT_XD221Modbus))
                {
                    XD221ModbusProcessor.Default.ProcessExecutedTask(task, pr);
                }

                // xd221
                //
                if (StringHelper.Equal(task.Device.DeviceDefine.DeviceType,
                    DeviceDefineConst.DDT_XD221))
                {
                    XD221Processor.Defalut.ProcessExecutedTask(task, pr);
                }

                // xd202
                //
                if (StringHelper.Equal(task.Device.DeviceDefine.DeviceType,
                    DeviceDefineConst.DDT_XD202))
                {
                    XD202Processor.Default.ProcessExecutedTask(task, pr);
                }

            }
            // xd2300
            //
            if (StringHelper.Equal(task.Device.DeviceType,
                DeviceDefineConst.DDT_XD2300))
            {
                XD2300Processor.Default.ProcessExecutedTask(task, pr);
            }
        }
        #endregion //ProcessExecutedTask


        #region ProcessFD
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        public void ProcessFD(FDEventArgs e)
        {
            
            // do nothing
            //
        }
        #endregion //ProcessFD


        #region CommuniPortChanged
        /// <summary>
        /// 
        /// </summary>
        /// <param name="station"></param>
        public void CommuniPortChanged(Station station)
        {
            //this.SyncContext.Post(new SendOrPostCallback(CommuniPortChangedSync), station);
            CommuniPortChangedSync(station);
        }
        #endregion //CommuniPortChanged


        #region CommuniPortChangedSync
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        private void CommuniPortChangedSync(object obj)
        {
            Station st = obj as Station;
            //frmMain mainForm = YeHeCommuniServerApp.Default.MainForm;
            //mainForm.Text = (st.CommuniPort != null).ToString();
            //Console.WriteLine(s);

            TreeNode tn = st.Tag as TreeNode;
            if (st.CommuniPort != null)
            {
                tn.ImageKey = "Connect";
                tn.SelectedImageKey = "Connect";
            }
            else
            {
                tn.ImageKey = "DisConnect";
                tn.SelectedImageKey = "DisConnect";
            }
        }
        #endregion //CommuniPortChangedSync
    }
}

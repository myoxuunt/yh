using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Xdgk.Communi;

namespace YeHeCommuniServer
{
    public partial class frmTaskManage : NUnit.UiKit.SettingsDialogBase
    {
        /// <summary>
        /// 
        /// </summary>
        public frmTaskManage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTaskManage_Load(object sender, EventArgs e)
        {
            FillTaskListView();
        }

        /// <summary>
        /// 
        /// </summary>
        private void FillTaskListView()
        {
            TaskManager tm = YeHeCommuniServerApp.Default.CommuniSoft.TaskManager;
            this.lvTask.Items.Clear();
            foreach (Task t in tm.Tasks)
            {
                AddTaskToListView(t);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void AddTaskToListView(Task task)
        {
            string stationName = task.Device.Devices.Station.Name;
            string deviceType = task.Device.Text;
            string taskName = task.Opera.Text;
            string taskType = task.Strategy.ToString();
            string lastExecute = task.LastExecute.ToString();
            string[] items = new string[] { stationName, deviceType, taskName, taskType, lastExecute };
            ListViewItem lvi = new ListViewItem(items);
            lvi.Tag = task;
            this.lvTask.Items.Add(lvi);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillTaskListView();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.lvTask.SelectedItems != null &&
                this.lvTask.SelectedItems.Count > 0)
            {
                ListViewItem lvi = this.lvTask.SelectedItems[0];
                Task selectedTask = lvi.Tag as Task;
                string deleteMsg = string.Format(strings.DeleteTask, selectedTask.Opera.Name);
                DialogResult dr = NUnit.UiKit.UserMessage.Ask(deleteMsg);
                if (dr == DialogResult.No)
                {
                    return;
                }

                YeHeCommuniServerApp.Default.CommuniSoft.TaskManager.Tasks.Remove(selectedTask);

                //
                //
                this.lvTask.Items.Remove(lvi);
            }
            else
            {
                NUnit.UiKit.UserMessage.DisplayFailure(strings.PleaseSelectTask);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDetail_Click(object sender, EventArgs e)
        {
            Task task = GetSelectedTask();
            if (task != null)
            {
            }
            else
            {
                NUnit.UiKit.UserMessage.DisplayFailure(strings.PleaseSelectTask);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Task GetSelectedTask()
        {
            if (this.lvTask.SelectedItems.Count > 0)
            {
                return this.lvTask.SelectedItems[0].Tag as Task;
            }
            return null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}

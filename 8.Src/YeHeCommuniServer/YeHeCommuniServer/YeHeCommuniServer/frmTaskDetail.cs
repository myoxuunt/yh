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
    public partial class frmTaskDetail : NUnit.UiKit.SettingsDialogBase
    {
        private Task _task;
        public frmTaskDetail(Task task)
        {
            if (task == null)
                throw new ArgumentNullException("task");
            this._task = task;

            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTaskDetail_Load(object sender, EventArgs e)
        {
            FillTaskDetail();
        }

        /// <summary>
        /// 
        /// </summary>
        private void FillTaskDetail()
        {
            this._task.LastExecute.ToString();
        }
    }
}

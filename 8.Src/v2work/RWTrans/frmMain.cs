using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RWTrans
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName;
            tssExecuteTimeSpan.Text = string.Format(
                strings.ExecuteTimeSpan,
                App.Default.Config.ExecuteTimeSpan.ToString()
                );

            App.Default.Start();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuExit_Click(object sender, EventArgs e)
        {
            if (NUnit.UiKit.UserMessage.Ask(strings.SureExit) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuAbout_Click(object sender, EventArgs e)
        {
            string message = string.Format(
                "{0}\r\n{1}",
                Application.ProductName,
                Application.ProductVersion);
            NUnit.UiKit.UserMessage.DisplayInfo(message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuClear_Click(object sender, EventArgs e)
        {
            this.txtLog.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal TextBox  GetLoggerTextBox()
        {
            return this.txtLog;
        }

        private void mnuFormula_Click(object sender, EventArgs e)
        {
            frmFormulaManager f = new frmFormulaManager();
            f.ShowDialog();
        }
    }
}

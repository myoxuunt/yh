using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace YHZKPort
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private int m_addCount = 0;

        /// <summary>
        /// 
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            string s = ConfigurationSettings.AppSettings["TransferTS"];
            int sec = int.Parse(s);
            int tmrInterval = sec * 1000;
            this.tmrTransfer.Interval = tmrInterval;
            this.tmrTransfer.Enabled = true;

            this.txtServerUrl.Text = this.GetServerUrl();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        private void AddLog(string s)
        {
            this.m_addCount++;
            if (m_addCount >= 100)
            {
                m_addCount = 0;
                this.txtLog.Clear();
            }
            this.txtLog.AppendText(s);
            this.txtLog.AppendText(Environment.NewLine);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExec_Click(object sender, EventArgs e)
        {
            ExecuteTransfer();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string GetServerUrl()
        {
            return ConfigurationSettings.AppSettings["ServerUrl"];
        }

        /// <summary>
        /// 
        /// </summary>
        private void ExecuteTransfer()
        {
            try
            {
                XDYHService.Service1 server = new YHZKPort.XDYHService.Service1();
                server.Url = GetServerUrl();
                DateTime lastSluiceDataDT = server.GetSluiceDataLastDateTime();
                DataTable tbl = YHZKPortDBI.Default.ExecuteSlucieDataDataTable(lastSluiceDataDT);
                server.InsertSluiceData(tbl);

                string s = string.Format("{0} 服务器最新闸控数据时间 {1}", DateTime.Now, lastSluiceDataDT);
                AddLog(s);

                s = string.Format("{0} 传输记录 {1} 条", DateTime.Now, tbl.Rows.Count );
                AddLog(s);
            }
            catch (Exception ex)
            {
                this.AddLog(DateTime.Now.ToString());
                this.AddLog(ex.ToString());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrTransfer_Tick(object sender, EventArgs e)
        {
            this.ExecuteTransfer();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTest_Click(object sender, EventArgs e)
        {
            this.TestWebServer();
        }

        /// <summary>
        /// 
        /// </summary>
        private void TestWebServer()
        {
            try
            {
                XDYHService.Service1 server = new YHZKPort.XDYHService.Service1();
                server.Url = GetServerUrl();
                string desc = server.GetDescription();
                this.AddLog(DateTime.Now.ToString() + " " + desc);
            }
            catch (Exception ex)
            {
                this.AddLog(DateTime.Now.ToString());
                this.AddLog(ex.ToString());
            }
        }
    }
}

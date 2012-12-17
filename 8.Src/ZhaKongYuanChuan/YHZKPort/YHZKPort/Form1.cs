using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YHZKPort
{
    public partial class Form1 : Form
    {
        private DBcon con;
        private XDYHService.Service1 yhservice;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //con = new DBcon();
            //con.Open();
            //txtServer.Text = con.GetServicePath(); 
            //int spatime=int.Parse(con.GetSendTime());
            //timer1.Interval = spatime * 1000 * 60;
            //timer1.Enabled = false;
            //btnStop.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            TryConnect();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void Form1_MinimumSizeChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int aa = yhservice.GetLastDataID("tblWaterLevel");//tblSluiceData,tblWaterLevel
            //rtxtInfo.AppendText("最后ID..."+aa.ToString() + "\r\n");
            //DataTable dt = GetZMDatas(aa);  //GetWLDatas,GetZMDatas
            //yhservice.UpDateTable(dt, "Zm");//Wl,Zm
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this.Close();
            //this.SendDatas1();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            int spatime = int.Parse(con.GetSendTime());
            timer1.Interval = spatime * 1000 * 60;
            timer1.Enabled = false;
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            if (!TryConnect())
                rtxtInfo.AppendText(DateTime.Now.ToShortTimeString() + "  没有找到服务器，连接失败..." + "\r\n");
            SendDatas();
            timer1.Enabled = true;
            btnState.Enabled = false;
            btnSet.Enabled = false;
            btnStop.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendDatas();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnState.Enabled = true;
            btnSet.Enabled = true;
            timer1.Enabled = false;
        }

        private bool TryConnect()
        {
            //try
            {
                yhservice = new YHZKPort.XDYHService.Service1();
                yhservice.Url = txtServer.Text;

                string TestText = yhservice.GetDescription();
                rtxtInfo.AppendText(TestText + Environment.NewLine);
                //if (TestText == "XDYHService")
                //{
                //    if (con.SetServicePath(txtServer.Text))
                //    {
                //        rtxtInfo.AppendText(DateTime.Now.ToShortTimeString() + "  连接成功..." + "\r\n");
                //        return true;
                //    }
                //    else
                //    {
                //        rtxtInfo.AppendText(DateTime.Now.ToShortTimeString() + "  配置成功，但路径写入错误" + "\r\n");
                //        return false;
                //    }
                //}
                return true;
            }
            //catch (Exception ex)
            {
                //rtxtInfo.AppendText(ex.ToString ());
                //return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        private DataTable GetZMDatas(DateTime dt)
        {
            string str = string.Format(
                "select top 30 * from vSluiceData where dt > '{0}' order by DT", 
                dt );
            return DBcon.Instance.GetDataTable(str);
        }

        private DataTable GetWLDatas(int ID)
        {
            string str = string.Format("select top 30 * from vWaterLevel where SluiceDataID>{0} order by SluiceDataID desc", ID);
            return DBcon.Instance.GetDataTable(str);
        }

        ///// <summary>
        ///// 
        ///// </summary>
        //private void SendDatas1()
        //{
        //    try
        //    {
        //        DateTime dt = new XDYHService.Service1().GetLastDateTime("tblSluiceData");
        //        //DataTable tbl = GEtwldata(dt);
        //        DataTable tbl = GetZMDatas(dt);
        //        new XDYHService.Service1().InsertData("tblSluiceData", tbl);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());

        //    }
        //}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        DataTable GEtwldata(DateTime dt)
        {
            string str = string.Format(
                "select * from vWaterLevelData where DT > '{0}' order by DT", dt);
            return DBcon.Instance.GetDataTable(str);
        }

        private void SendDatas()
        {
            //try
            //{
            //    int serverLastID = yhservice.GetLastDataID("tblSluiceData");
            //    rtxtInfo.AppendText(DateTime.Now.ToShortTimeString() + "  闸控数据表最后ID： " + serverLastID.ToString() + "\r\n");
            //    DataTable dt = GetZMDatas(serverLastID);
            //    //string returnString = yhservice.UpDateTable(dt, "Zm");
            //    //if (returnString == "recordOK")
            //        rtxtInfo.AppendText(DateTime.Now.ToShortTimeString() + "  闸控数据远传成功... " + "\r\n");

            //    serverLastID = yhservice.GetLastDataID("tblWaterLevel");
            //    rtxtInfo.AppendText(DateTime.Now.ToShortTimeString() + "  口门数据表最后ID： " + serverLastID.ToString() + "\r\n");
            //    dt = GetWLDatas(serverLastID);
            //    //returnString = yhservice.UpDateTable(dt, "Wl");
            //    //if (returnString == "recordOK")
            //        rtxtInfo.AppendText(DateTime.Now.ToShortTimeString() + "  口门数据远传成功... " + "\r\n");
            //}
            //catch (Exception ex)
            //{
            //    rtxtInfo.AppendText(DateTime.Now.ToShortTimeString() + "  中心数据服务无响应，检查网络" + "\r\n");
            //    btnStop.Enabled = false;
            //    btnState.Enabled = true;
            //    btnSet.Enabled = true;
            //    timer1.Enabled = false;
            //}
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            //this.yhservice 
            //this.SendDatas1();
        }
    }
}

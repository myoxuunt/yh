using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Xml;

namespace winCom
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.TextBox txtRev;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtZT;
		private System.Windows.Forms.Button btnEnd;
		private System.Windows.Forms.TextBox txtSend;
		private AxMSCommLib.AxMSComm axMSComm2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox txtInfo;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnSend = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.axMSComm2 = new AxMSCommLib.AxMSComm();
			this.txtSend = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtRev = new System.Windows.Forms.TextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtZT = new System.Windows.Forms.TextBox();
			this.btnEnd = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.btnClear = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtInfo = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axMSComm2)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(0, 8);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(64, 23);
			this.btnOpen.TabIndex = 0;
			this.btnOpen.Text = "打开串口";
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(128, 8);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(64, 23);
			this.btnSend.TabIndex = 1;
			this.btnSend.Text = "发送";
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.axMSComm2);
			this.groupBox1.Controls.Add(this.txtSend);
			this.groupBox1.Location = new System.Drawing.Point(0, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(504, 120);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "发送区";
			// 
			// axMSComm2
			// 
			this.axMSComm2.ContainingControl = this;
			this.axMSComm2.Enabled = true;
			this.axMSComm2.Location = new System.Drawing.Point(248, 64);
			this.axMSComm2.Name = "axMSComm2";
			this.axMSComm2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMSComm2.OcxState")));
			this.axMSComm2.Size = new System.Drawing.Size(38, 38);
			this.axMSComm2.TabIndex = 1;
			this.axMSComm2.OnComm += new System.EventHandler(this.axMSComm2_OnComm);
			// 
			// txtSend
			// 
			this.txtSend.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtSend.Location = new System.Drawing.Point(3, 17);
			this.txtSend.Multiline = true;
			this.txtSend.Name = "txtSend";
			this.txtSend.Size = new System.Drawing.Size(498, 100);
			this.txtSend.TabIndex = 0;
			this.txtSend.Text = "";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtRev);
			this.groupBox2.Location = new System.Drawing.Point(0, 160);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(504, 168);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "接收区";
			// 
			// txtRev
			// 
			this.txtRev.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtRev.Location = new System.Drawing.Point(3, 17);
			this.txtRev.Multiline = true;
			this.txtRev.Name = "txtRev";
			this.txtRev.Size = new System.Drawing.Size(498, 148);
			this.txtRev.TabIndex = 0;
			this.txtRev.Text = "";
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(64, 8);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(64, 23);
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "关闭串口";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(328, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "串口状态:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtZT
			// 
			this.txtZT.Location = new System.Drawing.Point(400, 8);
			this.txtZT.Name = "txtZT";
			this.txtZT.ReadOnly = true;
			this.txtZT.Size = new System.Drawing.Size(96, 21);
			this.txtZT.TabIndex = 7;
			this.txtZT.Text = "";
			// 
			// btnEnd
			// 
			this.btnEnd.Location = new System.Drawing.Point(256, 8);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.Size = new System.Drawing.Size(64, 23);
			this.btnEnd.TabIndex = 8;
			this.btnEnd.Text = "退出";
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(192, 8);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(64, 23);
			this.btnClear.TabIndex = 9;
			this.btnClear.Text = "清除";
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtInfo);
			this.groupBox3.Location = new System.Drawing.Point(0, 328);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(504, 168);
			this.groupBox3.TabIndex = 10;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "接收信息";
			// 
			// txtInfo
			// 
			this.txtInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtInfo.Location = new System.Drawing.Point(3, 17);
			this.txtInfo.Multiline = true;
			this.txtInfo.Name = "txtInfo";
			this.txtInfo.Size = new System.Drawing.Size(498, 148);
			this.txtInfo.TabIndex = 0;
			this.txtInfo.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(504, 493);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnEnd);
			this.Controls.Add(this.txtZT);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.btnOpen);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axMSComm2)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmReport());
		}

		private void btnOpen_Click(object sender, System.EventArgs e)
		{
			try
			{
					XmlDocument xDoc=new XmlDocument();
					xDoc.Load("comInfo.xml");
					string strPort=xDoc.DocumentElement.SelectSingleNode("./com").InnerText.Trim();
				    string strSettings=xDoc.DocumentElement.SelectSingleNode("./com").Attributes.GetNamedItem("settings").Value.Trim();
					this.axMSComm2.Settings=strSettings;
					this.axMSComm2.CommPort=short.Parse(strPort);
					this.axMSComm2.DTREnable=true;
					this.axMSComm2.RTSEnable=true;					
					this.axMSComm2.InputMode=MSCommLib.InputModeConstants.comInputModeBinary;
					this.axMSComm2.InputLen =0;
					this.axMSComm2.OnComm+=new EventHandler(axMSComm1_OnComm);
					this.axMSComm2.PortOpen=true;
					this.txtZT.Text="已打开";

					this.timer1.Interval=10;
					this.timer1.Tick+=new EventHandler(timer1_Tick);
					this.timer1.Start();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.axMSComm2.PortOpen=false;
				this.txtZT.Text="已关闭";
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnEnd_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnSend_Click(object sender, System.EventArgs e)
		{
			if(this.axMSComm2.PortOpen==false)
			{
				MessageBox.Show("串口尚未打开！");
				return;
			}
			string strCmd=this.txtSend.Text.Trim();
			this.sendCmd(strCmd);
            this.txtInfo.Text="";
		}

		private bool sendCmd(string strCmd)
		{
			try
			{
				strCmd=strCmd.Trim();
				strCmd=strCmd.Replace("  "," ");
				strCmd=strCmd.Replace("   "," ");
				string[] strsCmd=strCmd.Split(' ');

				byte[] btsCmd=new byte[strsCmd.Length];

				for(int i=0;i<btsCmd.Length;i++)
				{
					btsCmd[i]=Convert.ToByte(strsCmd[i],16);
				}

				this.axMSComm2.Output=btsCmd;
				this.axMSComm2.OutBufferCount=0;

				return true;

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());

				return false;
			}
		}

	
		private int m_iWait=0;
		private string m_strAllowTwo="";

		private void axMSComm1_OnComm(object sender, System.EventArgs e)
		{
			try
			{				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());				
			}
		}

		private void dealCom()
		{
			try
			{
				if(this.m_iWait==0)
				{
					XmlDocument xDoc=new XmlDocument();
					xDoc.Load("comInfo.xml");
					this.m_iWait=int.Parse(xDoc.DocumentElement.SelectSingleNode("./waitTime").Attributes.GetNamedItem("val").Value.Trim());					
				}	
				
				this.sleep(this.m_iWait);
				

				byte[] bts=null;

				if(this.axMSComm2.InBufferCount>0)
				{
					bts=(byte[])this.axMSComm2.Input;
				}

				ArrayList ar=new ArrayList();	
				ar=winCom.CTools.removeEnd(bts);

				if(ar.Count==0)
				{
					return;
				}

				for(int i=0;i<ar.Count;i++)
				{
					string strDatas=ar[i].ToString().Trim();

					if(strDatas=="")					
					{
						continue;
					}

					byte[] btsData=winCom.CTools.cStrToByte(strDatas);
				
					int[] ints=winCom.CTools.cByteToInt(btsData);

					if(CTools.checkCrc(ints,ints.Length))
					{
						this.dispCmd(btsData);		
					}			

				}			 
		
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());				
			}
		}

		private void sleep(int iSec)
		{
			string strTime=System.DateTime.Now.ToString();
			while(DateTime.Parse(strTime).AddMilliseconds(iSec)>System.DateTime.Now)
			{
				System.Windows.Forms.Application.DoEvents();
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				this.timer1.Stop();
				if(this.axMSComm2.InBufferCount>0)
				{
					this.dealCom();
				}
				this.timer1.Start();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnClear_Click(object sender, System.EventArgs e)
		{
			this.txtSend.Text="";
			this.txtRev.Text="";
		}

		private void timer1_Tick_1(object sender, System.EventArgs e)
		{		
		}

		public void farSendCmd(string strCmd)
		{
			this.txtSend.Text=strCmd;
			this.btnSend_Click(null,null);
		}

		public delegate void comRevData(DataTable dtInfo);
		public event comRevData onRev;

		public delegate void revBackInfo(DataTable dtBackInfo);
		public event revBackInfo backInfo;
		

		private bool dispCmd(byte[] btsCmd)
		{
			try
			{
				string strInfo="";

				for(int i=0;i<btsCmd.Length;i++)
				{
					strInfo+=" "+btsCmd[i].ToString("x");
				}

				this.txtRev.Text+="\r\n"+strInfo.Trim();

				if(btsCmd.Length>200)
				{
					DataTable dtInfo=cTool.CExplain.explainHisOrdialData(btsCmd);

					if(dtInfo==null)
					{
						return false;
					}

					for(int i=0;i<dtInfo.Rows.Count;i++)
					{
						string strInfoEx=dtInfo.Rows[i]["info"].ToString();

						this.sleep(2000);

						this.doExp(winCom.CTools.cStrToByte(strInfoEx));
					}

					return true;

				}

				this.doExp(btsCmd);			
				
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}

		private void doExp(byte[] btsCmd)
		{
			try
			{
				DataTable dtExp=new DataTable();

				dtExp=cTool.CExplain.explainOrdialData(btsCmd);

				if(dtExp==null||dtExp.Rows.Count==0)
				{
					dtExp=cTool.CExplain.expReData(btsCmd);
					this.backInfo(dtExp);
					return ;
				}

				bool bHaveTime=false;

				string strAddress="";

				string strAmount="";

				string strWaterLevel="";

				string strTime="";

				for(int i=0;i<dtExp.Rows.Count;i++)
				{
					if(dtExp.Rows[i]["name"].ToString()=="time")
					{
						strTime=dtExp.Rows[i]["Info"].ToString().Trim();
						bHaveTime=true;
					}
					this.dispExp(dtExp.Rows[i]["name"].ToString(),dtExp.Rows[i]["info"].ToString());

					if(dtExp.Rows[i]["name"].ToString().Trim()=="address")
					{
						strAddress=Convert.ToString(Convert.ToInt32(dtExp.Rows[i]["info"].ToString(),16));
						dtExp.Rows.RemoveAt(i);
						i--;
					}

					if(dtExp.Rows[i]["name"].ToString().Trim()=="waterLevel")
					{
						strWaterLevel=dtExp.Rows[i]["Info"].ToString();
						//strAmount=winCom.cCompute.comAmount(
					}					
				}

				string strSql=string.Format("select wellNo,wellName from tbWell where watAddress='{0}'",strAddress);
				DataTable dtWell=new DataTable();

				BengZhan.CDBConnection.getDataTable(ref dtWell,strSql,"dtWell");

			    DataRow	dr=dtExp.NewRow();
				dr["name"]="name";
				dr["info"]=dtWell.Rows[0]["wellName"].ToString();

				dtExp.Rows.Add(dr);

				dr=dtExp.NewRow();
				dr["name"]="watNo";
				dr["info"]=dtWell.Rows[0]["wellNo"].ToString();
				dtExp.Rows.Add(dr);

				//strAmount=winCom.cCompute.comAmount(dtWell.Rows[0]["wellNo"].ToString(),strWaterLevel);

			//	strAmount="0";

				//dr=dtExp.NewRow();
				//dr["name"]="amount";
				//dr["info"]=strAmount;
				//dtExp.Rows.Add(dr);		

				Console.WriteLine(strTime);

				//string strAllAmount=winCom.cCompute.comAllAmount(dtWell.Rows[0]["wellNo"].ToString(),strAmount,strTime);

				//string strAllAmount="0";
				///dr=dtExp.NewRow();
				//dr["name"]="allAmount";
				//dr["info"]=strAllAmount;
				//dtExp.Rows.Add(dr);


			    if(!bHaveTime)
				{
					dr=dtExp.NewRow();
					dr["name"]="time";
					dr["info"]=System.DateTime.Now.ToString();
					dtExp.Rows.Add(dr);
				}		

//				dr=dtExp.NewRow();
//				dr["name"]="allBuyAmount";
//				dr["info"]="0";
//				dtExp.Rows.Add(dr);

//				dr=dtExp.NewRow ();
//				dr["name"]="iniAmount";
//				dr["info"]="0";
//				dtExp.Rows.Add(dr);

//				dr=dtExp.NewRow();
//				dr["name"]="allMony";
//				dr["info"]="0";
//				dtExp.Rows.Add(dr);

//				dr=dtExp.NewRow();
//				dr["name"]="leftMony";
//				dr["info"]="0";
//				dtExp.Rows.Add(dr);

				this.onRev(dtExp);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}


		private DataTable getExpDt(DataTable dtInfo)
		{
			return new DataTable();
		}

		private void dispExp(string strName,string strInfo)
		{
			string strExp=string.Format("name={0} info={1}",strName,strInfo);

			this.txtInfo.Text+="\r\n"+strExp;
		}

		private bool bPaint=false;
		private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			if(!this.bPaint)
			{
				this.btnOpen_Click(null,null);
				this.bPaint=true;
				//this.Hide();
			}
		}

		#region"发送指令"
		
		public void farCmd(string strCmd)
		{
			this.txtSend.Text=strCmd;
			this.btnSend_Click(null,null);
		}
		
		#endregion

		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.Text="通讯数据后台";
			this.WindowState=System.Windows.Forms.FormWindowState.Minimized;
			//this.Visible=false;
			//this.Hide();
		}

		private void axMSComm2_OnComm(object sender, System.EventArgs e)
		{
		
		}

	}
}

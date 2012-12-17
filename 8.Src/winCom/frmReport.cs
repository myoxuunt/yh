using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using winCom.cDealForm;
using System.Xml;
using System.Data ;

namespace winCom
{
	/// <summary>
	/// frmReport 的摘要说明。
	/// </summary>
	public class frmReport : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ComboBox cmbInfo;
		private System.Windows.Forms.Button btnSet;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnCmd;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox txtZhan;
		private System.Windows.Forms.TreeView trvZhan;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Button btnOnTime;
		private System.Windows.Forms.PictureBox imgOnTime;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnReadHis;
		private System.ComponentModel.IContainer components;

		public frmReport()
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
				if(components != null)
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.trvZhan = new System.Windows.Forms.TreeView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnReadHis = new System.Windows.Forms.Button();
			this.imgOnTime = new System.Windows.Forms.PictureBox();
			this.btnOnTime = new System.Windows.Forms.Button();
			this.cmbInfo = new System.Windows.Forms.ComboBox();
			this.btnSet = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnCmd = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.lblName = new System.Windows.Forms.Label();
			this.txtZhan = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGrid1);
			this.groupBox1.Location = new System.Drawing.Point(160, 48);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(720, 472);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "上报信息表";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(3, 17);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(714, 452);
			this.dataGrid1.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.trvZhan);
			this.groupBox2.Location = new System.Drawing.Point(0, 48);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(160, 464);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// trvZhan
			// 
			this.trvZhan.Dock = System.Windows.Forms.DockStyle.Fill;
			this.trvZhan.ImageIndex = -1;
			this.trvZhan.Location = new System.Drawing.Point(3, 17);
			this.trvZhan.Name = "trvZhan";
			this.trvZhan.SelectedImageIndex = -1;
			this.trvZhan.Size = new System.Drawing.Size(154, 444);
			this.trvZhan.TabIndex = 2;
			this.trvZhan.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvZhan_AfterSelect);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnReadHis);
			this.groupBox3.Controls.Add(this.imgOnTime);
			this.groupBox3.Controls.Add(this.btnOnTime);
			this.groupBox3.Controls.Add(this.cmbInfo);
			this.groupBox3.Controls.Add(this.btnSet);
			this.groupBox3.Controls.Add(this.btnExit);
			this.groupBox3.Controls.Add(this.btnClear);
			this.groupBox3.Controls.Add(this.btnCmd);
			this.groupBox3.Location = new System.Drawing.Point(160, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(696, 48);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			// 
			// btnReadHis
			// 
			this.btnReadHis.Location = new System.Drawing.Point(88, 16);
			this.btnReadHis.Name = "btnReadHis";
			this.btnReadHis.Size = new System.Drawing.Size(72, 23);
			this.btnReadHis.TabIndex = 13;
			this.btnReadHis.Text = "读记录";
			this.btnReadHis.Click += new System.EventHandler(this.btnReadHis_Click);
			// 
			// imgOnTime
			// 
			this.imgOnTime.Location = new System.Drawing.Point(248, 19);
			this.imgOnTime.Name = "imgOnTime";
			this.imgOnTime.Size = new System.Drawing.Size(32, 16);
			this.imgOnTime.TabIndex = 12;
			this.imgOnTime.TabStop = false;
			this.imgOnTime.Paint += new System.Windows.Forms.PaintEventHandler(this.imgOnTime_Paint);
			// 
			// btnOnTime
			// 
			this.btnOnTime.Location = new System.Drawing.Point(288, 16);
			this.btnOnTime.Name = "btnOnTime";
			this.btnOnTime.Size = new System.Drawing.Size(64, 24);
			this.btnOnTime.TabIndex = 11;
			this.btnOnTime.Text = "定时招测";
			this.btnOnTime.Click += new System.EventHandler(this.button1_Click);
			// 
			// cmbInfo
			// 
			this.cmbInfo.Location = new System.Drawing.Point(368, 16);
			this.cmbInfo.Name = "cmbInfo";
			this.cmbInfo.Size = new System.Drawing.Size(88, 20);
			this.cmbInfo.TabIndex = 10;
			// 
			// btnSet
			// 
			this.btnSet.Location = new System.Drawing.Point(464, 16);
			this.btnSet.Name = "btnSet";
			this.btnSet.Size = new System.Drawing.Size(72, 23);
			this.btnSet.TabIndex = 9;
			this.btnSet.Text = "操作";
			this.btnSet.Click += new System.EventHandler(this.btnSet_Click_1);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(544, 16);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 8;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(168, 16);
			this.btnClear.Name = "btnClear";
			this.btnClear.TabIndex = 7;
			this.btnClear.Text = "清除";
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
			// 
			// btnCmd
			// 
			this.btnCmd.Location = new System.Drawing.Point(8, 16);
			this.btnCmd.Name = "btnCmd";
			this.btnCmd.TabIndex = 6;
			this.btnCmd.Text = "招测";
			this.btnCmd.Click += new System.EventHandler(this.btnCmd_Click_1);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.lblName);
			this.groupBox4.Controls.Add(this.txtZhan);
			this.groupBox4.Location = new System.Drawing.Point(0, 0);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(160, 48);
			this.groupBox4.TabIndex = 1;
			this.groupBox4.TabStop = false;
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(8, 16);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(64, 23);
			this.lblName.TabIndex = 11;
			this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtZhan
			// 
			this.txtZhan.Location = new System.Drawing.Point(80, 16);
			this.txtZhan.Name = "txtZhan";
			this.txtZhan.Size = new System.Drawing.Size(72, 21);
			this.txtZhan.TabIndex = 1;
			this.txtZhan.Text = "";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
			// 
			// frmReport
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(880, 517);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox4);
			this.Name = "frmReport";
			this.Text = "实时监测";
			this.Resize += new System.EventHandler(this.frmReport_Resize);
			this.Load += new System.EventHandler(this.frmReport_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmReport_Paint);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmReport_Load(object sender, System.EventArgs e)
		{		
			this.iniFrm();
		}

		private System.Timers.Timer m_timeSave;

		private void iniFrm()
		{
			try
			{
				GDBConnection gdbc=new   GDBConnection();
				gdbc.iniSys();
				winCom.cDealForm.CIniGrid cIGrd=new winCom.cDealForm.CIniGrid();	
				this.dataGrid1.ReadOnly=true;
		
				if(cIGrd.iniDataGrid(this.dataGrid1,1)==false)
				{								
				}

				winCom.cDealForm.CIniGrid.getGprsDataTable(ref this.m_dtSave);

				this.m_timeSave=new System.Timers.Timer();
				this.m_timeSave.Elapsed+=new System.Timers.ElapsedEventHandler(m_timeSave_Elapsed);
				this.m_timeSave.Interval=1000;
				this.m_timeSave.Start();

				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("farCmd.xml");


				XmlNode xNodeFarCmd=xDoc.DocumentElement.SelectSingleNode("./farCmd");

				for(int i=0;i<xNodeFarCmd.ChildNodes.Count;i++)
				{
					string strDes=xNodeFarCmd.ChildNodes[i].Attributes.GetNamedItem("des").Value.Trim();
					this.cmbInfo.Items.Add(strDes);
				}

				winCom.cDealForm.CDFrm.paintWell("",this.trvZhan);

				this.removeZhanCe(this.trvZhan);



				xDoc.Load("comInfo.xml");
				string strInter=xDoc.DocumentElement.SelectSingleNode("./onTimeInter").Attributes.GetNamedItem("val").Value.Trim();
				this.timer1.Interval=int.Parse(strInter);
				this.timer1.Tick +=new EventHandler(timer1_Tick);

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}

			
			


		}


		private void removeZhanCe(System.Windows.Forms.TreeView trv)
		{
			for(int i=0;i<trv.Nodes.Count;i++)
			{

				System.Windows.Forms.TreeNode trN=trv.Nodes[i];

				for(int j=0;j<trN.Nodes.Count;j++)
				{
					System.Windows.Forms.TreeNode trNEx=trN.Nodes[j];

					for(int z=0;z<trNEx.Nodes.Count;z++)
					{
						string strWellName=trNEx.Nodes[z].Text.Trim();
						int iDex=strWellName.IndexOf("|");

						string strSql=string.Format("select count(*) from tbWell where wellName='{0}' and not bSal is null",strWellName.Substring(iDex+1));

						string strCount=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();

						if((strCount=="")||(strCount=="0"))
						{
						}
						else
						{
							trNEx.Nodes.RemoveAt(z);
							z--;
						}



						//						if(trNEx.Nodes[z].Text.IndexOf("售水")>=0)
						//						{
						//							
						//						}	
					
					}
				}

			
			}
		}


		private winCom.Form1 m_frmCom=null;

		private void startCom()
		{
            
			winCom.Form1 frm=new Form1();
			frm.Show();
			frm.onRev+=new winCom.Form1.comRevData(frm_onRev);
			frm.backInfo +=new winCom.Form1.revBackInfo(frm_backInfo);
			this.m_frmCom=frm;

		}

		private bool bPaint=false;

		private void frmReport_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			if(!this.bPaint)
			{
				this.startCom();
				this.button1_Click(null,null);
				this.bPaint=true;
			}
		}

		private XmlDocument m_xDocCmd;

		private ArrayList arrFields=new ArrayList();

		private string m_strSendTime="";
		private int m_iSendCount=0;
		private int m_iOneZhanTime=0;
		private ArrayList m_arrSendZhans=new ArrayList();
		private int m_iSleepASend=0;

		private void btnCmd_Click(object sender, System.EventArgs e)
		{
			if(this.m_iSleepASend==0)
			{
				XmlDocument xDoc1=new XmlDocument ();
				xDoc1.Load("comInfo.xml");
				this.m_iSleepASend=int.Parse(xDoc1.DocumentElement.SelectSingleNode("./sleepTime").Attributes.GetNamedItem("val").Value.Trim());
			}

			if(this.Cursor==Cursors.WaitCursor)
			{
				return ;
			}
			if(this.m_xDocCmd==null)
			{
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("farCmd.xml");
				this.m_xDocCmd=xDoc;
			}

            XmlNode xNode=this.m_xDocCmd.DocumentElement.SelectSingleNode("./cmds");
			
			for(int i=0;i<xNode.ChildNodes.Count;i++)
			{
				string strCmd=xNode.ChildNodes[i].Attributes.GetNamedItem("val").Value.Trim();
				string  strSleep=xNode.ChildNodes[i].Attributes.GetNamedItem("sleep").Value.Trim();
				this.m_frmCom.farCmd(strCmd);
				this.sleep(int.Parse(strSleep));

				this.m_arrSendZhans.Add(i.ToString());
				
				string strField=xNode.ChildNodes[i].Attributes.GetNamedItem("field").Value.Trim();

				this.arrFields.Add(strField);

			}

			this.sleep(this.m_iSleepASend);

			this.checkTooLong();

			//this.m_strSendTime=System.DateTime.Now.ToString();
		//	this.m_iSendCount=this.m_arrSendZhans.Count;
					 
		}

		private void checkTooLong()
		{
//			for(int i=0;i<this.m_arrSendZhans.Count;i++)
//			{
//				string strWatNo=this.m_arrSendZhans[i].ToString();
//
//				for(int j=0;j<this.m_arrRevZhans.Count;j++)
//				{
//					string strWatNoRe=this.m_arrRevZhans[j].ToString().Trim();
//
//					if(strWatNoRe==strWatNo)
//					{
//						this.m_arrSendZhans.RemoveAt(i);
//						i--;
//					}
//				}
//			}
//
//			if(this.m_arrSendZhans.Count>0)
//			{
//				frmWarn frmW=new frmWarn();
//				frmW.m_arr=this.m_arrSendZhans;
//				frmW.Show();
//				this.m_arrSendZhans.Clear();
//			}
//
//			this.m_arrRevZhans.Clear();
		}

		private void frm_onRev(System.Data.DataTable dtInfo)
		{
			DataTable dt=(DataTable)this.dataGrid1.DataSource;
			DataRow dr=dt.NewRow();
			
			for(int i=0;i<dtInfo.Rows.Count;i++)
			{
				dr[dtInfo.Rows[i]["name"].ToString()]=dtInfo.Rows[i]["info"].ToString().Trim();
			}

			this.addDr(dt,dr);
			//dt.Rows.Add(dr);			
		}

		private int m_iWaitRowTime=0;

		private DataTable m_dtSave=new DataTable();

		private void addDr(DataTable dt,DataRow dr)
		{
			if(this.m_iWaitRowTime==0)
			{
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("comInfo.xml");
				this.m_iWaitRowTime=int.Parse(xDoc.DocumentElement.SelectSingleNode("./waitRowTime").Attributes.GetNamedItem("val").Value.Trim());
			}

			DateTime dtLast=DateTime.Parse(dr["time"].ToString());
			string strNameLast=dr["name"].ToString().Trim();

			bool bHave=false;

			for(int i=0;i<dt.Rows.Count;i++)
			{
				if(dt.Rows[i]["name"].ToString().Trim()==strNameLast)
				{
					DateTime dtPre=DateTime.Parse(dt.Rows[i]["time"].ToString().Trim());
					dtPre=dtPre.AddSeconds(this.m_iWaitRowTime);

					if(dtPre>dtLast)
					{
						bHave=true;

						for(int j=0;j<dr.Table.Columns.Count;j++)
						{
							if((dr[j].ToString().Trim()!="")&&(dt.Rows[i][j].ToString()==""))
							{
								dt.Rows[i][j]=dr[j].ToString();								
							}
						}
					}
				}				
			}

			//冶河程序改动
			if(!bHave)
			{
				for(int j=0;j<dr.Table.Columns.Count;j++)
				{
					if(dr[j].ToString()=="")
					{
						dr[j]="0";
					}
				}

				dt.Rows.Add(dr);
				this.m_dtSave.ImportRow(dr);
			}
		 }

		private void sleep(int iSec)
		{
			try
			{
				this.Cursor=Cursors.WaitCursor;

				string strTime=System.DateTime.Now.ToString();

				try
				{
					while(DateTime.Parse(strTime).AddMilliseconds(iSec)>System.DateTime.Now)
					{
						System.Windows.Forms.Application.DoEvents();
					}
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.ToString()+"--time:"+strTime);
				}

				
				this.Cursor=Cursors.Default;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			

		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnClear_Click(object sender, System.EventArgs e)
		{
			if(this.Cursor==Cursors.WaitCursor)
			{
				return ;
			}
			DataTable dt=(DataTable)this.dataGrid1.DataSource ;
			dt.Rows.Clear();

		}

		private ArrayList m_arrRevZhans=new ArrayList();

		private void m_timeSave_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			this.m_timeSave.Stop();
			if(this.m_dtSave.Rows.Count!=0)
			{
				winCom.CSaveData csd=new CSaveData();

				for(int i=0;i<this.m_dtSave.Rows.Count;i++)
				{
					this.m_arrRevZhans.Add(this.m_dtSave.Rows[i]["watNo"].ToString());
				}

				csd.saveGprsData(this.m_dtSave);
			}
			this.m_timeSave.Start();
		}


		private ArrayList m_arrBackInfo=new ArrayList();

		private void frm_backInfo(DataTable dtBackInfo)
		{
			for(int i=0;i<dtBackInfo.Rows.Count;i++)			
			{
				this.m_arrBackInfo.Add(dtBackInfo.Rows[i]["info"].ToString());
			}
		}

		private string LoadDan(string Index)
		{
			XmlDocument xDoc=new XmlDocument();
			xDoc.Load("farCmd.xml");
			string strBack="";

			XmlNode xNodeFarCmd=xDoc.DocumentElement.SelectSingleNode("./farCmd");

			for(int i=0;i<xNodeFarCmd.ChildNodes.Count;i++)
			{
				string strDes=xNodeFarCmd.ChildNodes[i].Attributes.GetNamedItem("des").Value.Trim();
				if(strDes==Index)
				{
					strBack=xNodeFarCmd.ChildNodes[i].Attributes.GetNamedItem("dan").Value.Trim();
					return strBack;
				}
			}
			return " ";
		}

		private void btnSet_Click(object sender, System.EventArgs e)
		{
			//Pengw
			string strSql="";
			if(lblName.Text=="站点：")
			{
				strSql=string.Format("select watAddress from tbWell where wellName='{0}'",txtZhan.Text);
			}
			else
			{
				MessageBox.Show("请选择设置站点");
				return;
			}
			DataTable dtWell=null;
			BengZhan.CDBConnection.getDataTable(ref dtWell,strSql,"tbSetWell");
			string strAddress=dtWell.Rows[0]["watAddress"].ToString();
//			strCmd=strCmd.Replace("xx",int.Parse(strAddress).ToString("x"));
			//
				
			if(this.Cursor==Cursors.WaitCursor)
			{
				return ;
			}

			if(this.cmbInfo.Text.IndexOf("清零")>=0)
			{
				this.clearAmount(strAddress);
				return;
			}

			if(this.cmbInfo.Text.Trim()=="")			
			{
				MessageBox.Show("请选择参数类型!");
				return;
			}

			frmSet frmS=new frmSet();

			if(this.cmbInfo.Text.IndexOf("设置")>=0)
			{				
				frmS.m_strInfo=this.cmbInfo.Text.Trim();
				frmS.m_strDan =LoadDan(frmS.m_strInfo);
				frmS.ShowDialog();
			}

			if(frmS.m_strVal=="exit")
			{
				return;
			}

			if(frmS.m_strVal=="")
			{
					frmS.m_strVal="1";
			}

			if(frmS.m_strVal!="")
			{
				XmlDocument xDoc=new XmlDocument();;
				xDoc.Load("farCmd.xml");

				string strXPath=string.Format("./farCmd/setAmount[@des='{0}']",this.cmbInfo.Text.Trim());
				XmlNode xNode=xDoc.DocumentElement.SelectSingleNode(strXPath);

				if(xNode==null)				
				{
					MessageBox.Show("请选择参数类型!");
					return;
				}

				string strCmd=xNode.Attributes.GetNamedItem("val").Value.Trim();

				//wangp
				strCmd=strCmd.Replace("xx",int.Parse(strAddress).ToString("x"));
				//
				string strSleep=xNode.Attributes.GetNamedItem("sleep").Value.Trim();

				bool bHaveCheck=false;

				if(xNode.Attributes.GetNamedItem("bHaveCheck")!=null)
				{
					if(xNode.Attributes.GetNamedItem("bHaveCheck").Value.Trim()=="1")
					{
						bHaveCheck=true;
					}					
				}

				this.m_arrBackInfo.Clear();

				if(bHaveCheck)
				{
					this.m_frmCom.farCmd(strCmd);
				}
				else
				{
					if(this.cmbInfo.Text.IndexOf("卡号")>=0)
					{
						this.setCardNo(strCmd,frmS.m_strVal);
					}
					else
					{
						this.farSetCmd(strCmd,frmS.m_strVal);
					}
				}				

                this.sleep(int.Parse(strSleep));				

				if(this.m_arrBackInfo.Count>0)
				{				
					MessageBox.Show(this.m_arrBackInfo[0].ToString());
				}
				else
				{
					MessageBox.Show("等待超时！");
				}

			}

		}

		#region"getRealData"

		private bool getRealData(int iData,ref string strData)
		{
			try
			{
				if(iData>=0)
				{
					strData=iData.ToString("x");
					
					for(int i=0;i<(4-iData.ToString("x").Length);i++)
					{
						strData="0"+strData;
					}

					return true;
				}
				else
				{
					//未用
					return addSymbol(iData,4,ref strData);
				}
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}

		private bool addSymbol(int iData,int iLen,ref string strData)
		{
			try
			{
				iData=0-iData;

				string strHigh="";
				for(int i=0;i<iLen;i++)
				{
					strHigh=strHigh+"ff";
				}
				Int64 iAnd=Convert.ToInt64(strHigh,16);

				Int64 iData64=Convert.ToInt64(iData^iAnd);

				iData64+=1;

				strData=iData64.ToString("x");

				for(int i=0;i<(8-iData64.ToString("x").Length);i++)
				{
					strData="0"+strData;
				}			

				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}

		#endregion

		private void farSetCmd(string strCmd,string strVal)
		{

			string[] strCmds=strCmd.Split(' ');

			byte[] btsCmd=new byte[strCmds.Length+4];

			for(int i=0;i<strCmds.Length;i++)
			{
				btsCmd[i]=Convert.ToByte(strCmds[i],16);
			}

			int iAllAmount=int.Parse(strVal);
			string strAllAmount="";

			if(this.getRealData(iAllAmount,ref strAllAmount)==false)
			{
				//this.stopCmd();
				return ;
			}
			
			btsCmd[strCmds.Length]=Convert.ToByte(strAllAmount.Substring(2,2),16);
			btsCmd[strCmds.Length+1]=Convert.ToByte(strAllAmount.Substring(0,2),16);

			int[] intsCmd= new int[btsCmd.Length];

			for(int i=0;i<(btsCmd.Length-2);i++)
			{
				intsCmd[i]=Convert.ToInt32(btsCmd[i]);
			}
			
			crc16.crc16 crcObj=new crc16.crc16();
			crcObj.IniCard();

			long lData=crcObj.CRC16_check(intsCmd,intsCmd.Length-2);

			int iHigh=(int)lData/256;
			int iLow=(int)lData&255;

			intsCmd[intsCmd.Length-2]=iHigh;
			intsCmd[intsCmd.Length-1]=iLow;

			for(int i=0;i<btsCmd.Length;i++)
			{
				btsCmd[i]=Convert.ToByte(intsCmd[i]);
			}

			strCmd="";

			for(int i=0;i<btsCmd.Length;i++)
			{
				strCmd=strCmd.Trim()+" "+btsCmd[i].ToString("x").Trim();
			}

			this.m_frmCom.farCmd(strCmd);			
		}

		private void setCardNo(string strCmd,string strVal)
		{
			strVal=this.getWatchNo(strVal);

			strCmd=strCmd.Trim()+" "+strVal;

			strCmd=this.addCrc(strCmd);

			this.m_frmCom.farCmd(strCmd);
		}

		private string getWatchNo(string strWatchNo)
		{
			try
			{
				string strEx="";
				strEx+=strWatchNo.Substring(0,2);
				strEx+=" "+strWatchNo.Substring(2,2);
				strEx+=" "+strWatchNo.Substring(4,2);
				strEx+=" "+strWatchNo.Substring(6,2);
				strEx+=" "+strWatchNo.Substring(8,2);
				strEx+=" "+strWatchNo.Substring(10,2);
				strEx+=" "+strWatchNo.Substring(12,2);
				strEx+=" "+strWatchNo.Substring(14,2);
				//strEx+=" "+strWatchNo.Substring(16,2);
				return strEx.Trim();


			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return "";
			}
		
		}

		public string addCrc(string strSource)		
		{
			try
			{
				strSource=strSource.Replace("  "," ");
				strSource=strSource.Replace("   "," ");
				strSource=strSource.Trim();
				string[] strsSource=strSource.Split(' ');
				if(strsSource.Length==0)
				{
					return "";
				}

				int[] intsSource=new int[strsSource.Length+2];
				for(int i=0;i<strsSource.Length;i++)
				{
					intsSource[i]=Convert.ToInt32(strsSource[i],16);
				}
				crc16.crc16 crc=new crc16.crc16();
				crc.IniCard();
				long lCrc=	crc.CRC16_check(intsSource,strsSource.Length);
				if(lCrc==-1)
				{
					MessageBox.Show(strSource+"  "+"交验错误");
					return "";
				}
				int iCrc=(int)lCrc;
				intsSource[strsSource.Length]=iCrc/256;
				intsSource[strsSource.Length+1]=iCrc&255;

				string strRet="";
				for(int i=0;i<intsSource.Length;i++)
				{
					strRet+=" "+this.c2str(intsSource[i].ToString("x"));
				}

				return strRet;
			}
			catch(Exception ex)
			{
				MessageBox.Show(strSource+"  "+ex.ToString());
				return "";
			}

		}

		private  string c2str(string str)
		{
			if(str.Length==1)
			{
				return "0"+str;
			}
			else
			{
				return str;
			}
		}

		private void clearAmount(string adr)
		{
			XmlDocument xDoc=new XmlDocument();
			xDoc.Load("farCmd.xml");
			XmlNode xNode=xDoc.DocumentElement.SelectSingleNode("./farCmd/setAmount[@des='清零']");

			this.m_arrBackInfo.Clear();

			for(int i=0;i<xNode.ChildNodes.Count;i++)
			{
				string strCmd=xNode.ChildNodes[i].Attributes.GetNamedItem("val").Value.Trim();
				strCmd=strCmd.Replace("xx",int.Parse(adr).ToString("x"));
				string strSleep=xNode.ChildNodes[i].Attributes.GetNamedItem("sleep").Value.Trim();

				//PengW
				string[] strCmds=strCmd.Split(' ');

				byte[] btsCmd=new byte[strCmds.Length+2];

				for(int j=0;j<strCmds.Length;j++)
				{
					btsCmd[j]=Convert.ToByte(strCmds[j],16);
				}


				int[] intsCmd= new int[btsCmd.Length];

				for(int j=0;j<(btsCmd.Length-2);j++)
				{
					intsCmd[j]=Convert.ToInt32(btsCmd[j]);
				}
			
				crc16.crc16 crcObj=new crc16.crc16();
				crcObj.IniCard();

				long lData=crcObj.CRC16_check(intsCmd,intsCmd.Length-2);

				int iHigh=(int)lData/256;
				int iLow=(int)lData&255;

				intsCmd[intsCmd.Length-2]=iHigh;
				intsCmd[intsCmd.Length-1]=iLow;

				for(int j=0;j<btsCmd.Length;j++)
				{
					btsCmd[j]=Convert.ToByte(intsCmd[j]);
				}

				strCmd="";

				for(int j=0;j<btsCmd.Length;j++)
				{
					strCmd=strCmd.Trim()+" "+btsCmd[j].ToString("x").Trim();
				}

				//
				this.m_frmCom.farCmd(strCmd);
				this.sleep(int.Parse(strSleep));
			}

			if(this.m_arrBackInfo.Count==1)
			{
				if((this.m_arrBackInfo[0].ToString().IndexOf("成功")>=0)&&(this.m_arrBackInfo[0].ToString().IndexOf("成功")>=0))
				{
					MessageBox.Show("清零成功!");
					return ;
				}				
			}

			MessageBox.Show("等待超时!");



		}

		private void paintSelectedWell()
		{
			try
			{
				if(this.trvZhan.SelectedNode!=null)				
				{
					if(this.trvZhan.SelectedNode.Parent==null)
					{
						if(this.trvZhan.SelectedNode.Text.IndexOf("操作员")<0)
						{
							this.lblName.Text="管理局：";
							this.txtZhan.Text=this.trvZhan.SelectedNode.Text.Trim();
							return;
						}
					}

					if(this.trvZhan.SelectedNode.Nodes.Count==0)
					{
						if(trvZhan.SelectedNode.Parent==null)
						{
							return;
						}
						if(trvZhan.SelectedNode.Parent==null)
						{
							return;
						}
						if(this.trvZhan.SelectedNode.Text.IndexOf("|")>=0)
						{
							string strWellName=this.trvZhan.SelectedNode.Text.Substring(this.trvZhan.SelectedNode.Text.IndexOf("|")+1);
							this.lblName.Text="站点：";
							this.txtZhan.Text=strWellName;
							return;
						}
						if(this.trvZhan.SelectedNode.Parent!=null)
						{
							if(this.trvZhan.SelectedNode.Parent.Text.IndexOf("操作员")>=0)
							{
								this.lblName.Text="操作员：";
								this.txtZhan.Text=this.trvZhan.SelectedNode.Text.Trim();
								return;
							}
							else
							{
								
							}
						}
						this.lblName.Text="管理处：";
						this.txtZhan.Text=this.trvZhan.SelectedNode.Text.Trim();
						return;
					}
					else
					{
						if(this.trvZhan.SelectedNode.Nodes[0].Text.IndexOf("|")>=0)
						{
							this.lblName.Text="管理处：";
							this.txtZhan.Text=this.trvZhan.SelectedNode.Text;
							return;
						}
					}
				}
				
			
				this.lblName.Text="站点：";
				this.txtZhan.Text="";
								
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}


		private void btnExit_Click_1(object sender, System.EventArgs e)
		{
			this.btnExit_Click(null,null);
		}

		private void btnCmd_Click_1(object sender, System.EventArgs e)
		{
			this.btnReadHis_Click(null,null);
		}

		private void btnSet_Click_1(object sender, System.EventArgs e)
		{
			this.btnSet_Click(null,null);
		}

		private void trvZhan_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			this.paintSelectedWell();
		}

		private void frmReport_Resize(object sender, System.EventArgs e)
		{
			this.groupBox1.Width=this.Width-this.groupBox1.Location.X-15;
			this.groupBox1.Height=this.Height-this.groupBox1.Location.Y-25;
			this.groupBox2.Height=this.Height-this.groupBox2.Location.Y-25;
		}

		private void groupBox1_Enter(object sender, System.EventArgs e)
		{
			

		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if(this.btnOnTime.Text=="定时招测")
			{
				this.btnOnTime.Text="停止定时";
				this.timer1.Start();
			}
			else
			{
				this.btnOnTime.Text="定时招测";	
				this.timer1.Stop();
			}
			this.imgOnTime.Refresh();


		}

		private void imgOnTime_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			if(this.btnOnTime.Text.IndexOf("停止")>=0)
			{
				//已开
				winCom.CTools.DrawCircle(e.Graphics,true);
			}
			else
			{
				//已关
				winCom.CTools.DrawCircle(e.Graphics,false);
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				this.btnCmd_Click_1(null,null);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}			
		}

		private void timer1_Tick_1(object sender, System.EventArgs e)
		{
		
		}

		private void btnClear_Click_1(object sender, System.EventArgs e)
		{
			DataTable dt=(DataTable)this.dataGrid1.DataSource;
			dt.Rows.Clear();
		}

		private void btnReadHis_Click(object sender, System.EventArgs e)
		{
			try
			{
				//string strSql=string.Format("select wellNo,watAddress from tbWell where not watAddress='0' and bSal is null");
				string strSql=string.Format("select wellNo,watAddress from tbWell where  bSal is null");

				DataTable dtWell=new DataTable();

				BengZhan.CDBConnection.getDataTable(ref dtWell,strSql,"dt");

				if(this.m_iSleepASend==0)
				{
					XmlDocument xDoc1=new XmlDocument ();
					xDoc1.Load("comInfo.xml");
					this.m_iSleepASend=int.Parse(xDoc1.DocumentElement.SelectSingleNode("./sleepTime").Attributes.GetNamedItem("val").Value.Trim());
				}

				if(this.Cursor==Cursors.WaitCursor)
				{
					return ;
				}
				if(this.m_xDocCmd==null)
				{
					XmlDocument xDoc=new XmlDocument();
					xDoc.Load("farCmd.xml");
					this.m_xDocCmd=xDoc;
				}
			
				for(int j=0;j<dtWell.Rows.Count;j++)
				{
					string strAddress=dtWell.Rows[j]["watAddress"].ToString().Trim();

					XmlNode xNode=this.m_xDocCmd.DocumentElement.SelectSingleNode("./cmds");
			
					for(int i=0;i<xNode.ChildNodes.Count;i++)
					{
						string strCmd=xNode.ChildNodes[i].Attributes.GetNamedItem("val").Value.Trim();					
						strCmd=strCmd.Replace("xx",int.Parse(strAddress).ToString("x"));
						strCmd=winCom.CTools.addCrc(strCmd);

						string  strSleep=xNode.ChildNodes[i].Attributes.GetNamedItem("sleep").Value.Trim();
						this.m_frmCom.farCmd(strCmd);
						this.sleep(int.Parse(strSleep));

						this.m_arrSendZhans.Add(i.ToString());
				
						string strField=xNode.ChildNodes[i].Attributes.GetNamedItem("field").Value.Trim();

						this.arrFields.Add(strField);

					}
				}

				this.sleep(this.m_iSleepASend);

				this.checkTooLong();

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
		}
	}

}

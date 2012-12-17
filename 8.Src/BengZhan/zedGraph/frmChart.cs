using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BengZhan.zedGraph
{
	/// <summary>
	/// frmChart 的摘要说明。
	/// </summary>
	public class frmChart : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnDisp;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabChart;
		private System.Windows.Forms.TreeView trvDep;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		private string m_strDrawLine2Sql="";
		private string m_strDrawLine1Sql="";
		private string m_strColTitle1="";
		private string m_strColTitle2="";
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.DateTimePicker dtTo;
		private System.Windows.Forms.DateTimePicker dtFrom;
		private System.Windows.Forms.CheckBox chkLeft;
		private string m_strState="";
		private System.Windows.Forms.Label lblInfo;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.Button btnPrint;
		private string m_strTitle="";
		private System.Windows.Forms.CheckBox chkUsed;
		private System.Windows.Forms.CheckBox chkAll;
		private System.Windows.Forms.CheckBox chkFlowAmount;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ComboBox cmbCountry;
		private System.Windows.Forms.Label label2;

		private crc16.CaptureScreen m_cs;

		public frmChart()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmChart));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.trvDep = new System.Windows.Forms.TreeView();
			this.tabChart = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.lblInfo = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chkAll = new System.Windows.Forms.CheckBox();
			this.chkUsed = new System.Windows.Forms.CheckBox();
			this.btnPrint = new System.Windows.Forms.Button();
			this.chkLeft = new System.Windows.Forms.CheckBox();
			this.dtTo = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.dtFrom = new System.Windows.Forms.DateTimePicker();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnDisp = new System.Windows.Forms.Button();
			this.chkFlowAmount = new System.Windows.Forms.CheckBox();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cmbCountry = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.tabChart.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.trvDep);
			this.groupBox1.Location = new System.Drawing.Point(8, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(224, 496);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// trvDep
			// 
			this.trvDep.ImageIndex = -1;
			this.trvDep.Location = new System.Drawing.Point(8, 16);
			this.trvDep.Name = "trvDep";
			this.trvDep.SelectedImageIndex = -1;
			this.trvDep.Size = new System.Drawing.Size(208, 472);
			this.trvDep.TabIndex = 0;
			this.trvDep.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvDep_AfterSelect);
			// 
			// tabChart
			// 
			this.tabChart.Controls.Add(this.tabPage1);
			this.tabChart.Location = new System.Drawing.Point(240, 64);
			this.tabChart.Name = "tabChart";
			this.tabChart.SelectedIndex = 0;
			this.tabChart.Size = new System.Drawing.Size(616, 488);
			this.tabChart.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.White;
			this.tabPage1.Controls.Add(this.lblInfo);
			this.tabPage1.Location = new System.Drawing.Point(4, 21);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(608, 463);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "历史曲线";
			// 
			// lblInfo
			// 
			this.lblInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblInfo.Location = new System.Drawing.Point(16, 16);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(440, 16);
			this.lblInfo.TabIndex = 0;
			this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.chkAll);
			this.groupBox2.Controls.Add(this.chkUsed);
			this.groupBox2.Controls.Add(this.btnPrint);
			this.groupBox2.Controls.Add(this.chkLeft);
			this.groupBox2.Controls.Add(this.dtTo);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.dtFrom);
			this.groupBox2.Controls.Add(this.btnExit);
			this.groupBox2.Controls.Add(this.btnDisp);
			this.groupBox2.Controls.Add(this.chkFlowAmount);
			this.groupBox2.Location = new System.Drawing.Point(240, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(736, 48);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			// 
			// chkAll
			// 
			this.chkAll.Enabled = false;
			this.chkAll.Location = new System.Drawing.Point(424, 16);
			this.chkAll.Name = "chkAll";
			this.chkAll.Size = new System.Drawing.Size(64, 24);
			this.chkAll.TabIndex = 9;
			this.chkAll.Text = "总水量";
			this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
			// 
			// chkUsed
			// 
			this.chkUsed.Location = new System.Drawing.Point(336, 16);
			this.chkUsed.Name = "chkUsed";
			this.chkUsed.Size = new System.Drawing.Size(80, 24);
			this.chkUsed.TabIndex = 8;
			this.chkUsed.Text = "已用水量";
			this.chkUsed.CheckedChanged += new System.EventHandler(this.chkUsed_CheckedChanged);
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(608, 16);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(64, 23);
			this.btnPrint.TabIndex = 7;
			this.btnPrint.Text = "图表打印";
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// chkLeft
			// 
			this.chkLeft.Location = new System.Drawing.Point(256, 19);
			this.chkLeft.Name = "chkLeft";
			this.chkLeft.Size = new System.Drawing.Size(80, 21);
			this.chkLeft.TabIndex = 5;
			this.chkLeft.Text = "剩余水量";
			this.chkLeft.CheckedChanged += new System.EventHandler(this.chkLeft_CheckedChanged);
			// 
			// dtTo
			// 
			this.dtTo.Location = new System.Drawing.Point(144, 17);
			this.dtTo.Name = "dtTo";
			this.dtTo.Size = new System.Drawing.Size(96, 21);
			this.dtTo.TabIndex = 4;
			this.dtTo.ValueChanged += new System.EventHandler(this.dtTo_ValueChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(112, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "至:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtFrom
			// 
			this.dtFrom.Location = new System.Drawing.Point(8, 16);
			this.dtFrom.Name = "dtFrom";
			this.dtFrom.Size = new System.Drawing.Size(104, 21);
			this.dtFrom.TabIndex = 2;
			this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(672, 16);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(56, 23);
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnDisp
			// 
			this.btnDisp.Location = new System.Drawing.Point(544, 16);
			this.btnDisp.Name = "btnDisp";
			this.btnDisp.Size = new System.Drawing.Size(64, 23);
			this.btnDisp.TabIndex = 0;
			this.btnDisp.Text = "图表显示";
			this.btnDisp.Click += new System.EventHandler(this.btnDisp_Click);
			// 
			// chkFlowAmount
			// 
			this.chkFlowAmount.Enabled = false;
			this.chkFlowAmount.Location = new System.Drawing.Point(496, 16);
			this.chkFlowAmount.Name = "chkFlowAmount";
			this.chkFlowAmount.Size = new System.Drawing.Size(48, 24);
			this.chkFlowAmount.TabIndex = 6;
			this.chkFlowAmount.Text = "流量";
			this.chkFlowAmount.CheckedChanged += new System.EventHandler(this.chkFlowAmount_CheckedChanged);
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Location = new System.Drawing.Point(155, 17);
			this.printPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog1.Visible = false;
			this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cmbCountry);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Location = new System.Drawing.Point(8, 8);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(224, 48);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			// 
			// cmbCountry
			// 
			this.cmbCountry.Location = new System.Drawing.Point(84, 13);
			this.cmbCountry.Name = "cmbCountry";
			this.cmbCountry.Size = new System.Drawing.Size(136, 20);
			this.cmbCountry.TabIndex = 3;
			this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(4, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "所属乡镇：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// frmChart
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(984, 558);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.tabChart);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmChart";
			this.Text = "单位用水历史曲线图";
			this.Resize += new System.EventHandler(this.frmChart_Resize);
			this.Load += new System.EventHandler(this.frmChart_Load);
			this.groupBox1.ResumeLayout(false);
			this.tabChart.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmChart_Load(object sender, System.EventArgs e)
		{
			try
			{

				this.dtTo.Value=this.dtFrom.Value.AddDays(1);				
				tools.CPaintForm.paintCountry(this.cmbCountry);
				tools.CPaintForm.paintWell(this.cmbCountry.Text,this.trvDep);
				
				this.chkLeft.Checked=true;			
				this.paintChart("");

				CDBConnection.refreshHis();

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			

		}

		private void PaintForm()
		{

			this.groupBox1.Height=this.Height-this.groupBox1.Top-35;
			this.trvDep.Height=this.groupBox1.Height-20;
			this.tabChart.Height=this.Height-this.tabChart.Top-35;
			this.tabChart.Width=this.Width-this.tabChart.Left-20;

		}

		private void frmChart_Resize(object sender, System.EventArgs e)
		{
			this.PaintForm();
		}

		private void trvDep_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{

		}
		

		//绘制图表
		public bool PaintFrm(string strWellNo)
		{
			try
			{
				string strFrom=String.Format("{0}-{1}-{2}",this.dtFrom.Value.Year.ToString(),this.dtFrom.Value.Month.ToString(),this.dtFrom.Value.Day.ToString());
				string strTo=String.Format("{0}-{1}-{2}",this.dtTo.Value.Year.ToString(),this.dtTo.Value.Month.ToString(),this.dtTo.Value.Day.ToString());
				string strSql=String.Format("select depName from tbWell where wellNo='{0}'",strWellNo);
				string strDepName=CDBConnection.ExecuteScalar(strSql);
				this.lblInfo.Text=String.Format("水井编号：{0} 单位名称：{3} 日期：{1} 至 {2}",strWellNo,strFrom,strTo,strDepName);
				

				DataTable dtLine1=new  DataTable();

				DataTable dtLine2=new DataTable();
			
				if(this.m_strDrawLine1Sql!="")
				{
					//查询第一条线的sql语句
					 strSql=this.m_strDrawLine1Sql;				
					DataTable dt=new DataTable();
					CDBConnection.getDataTable(ref dt,strSql,"tbData");
					dtLine1=dt;
				}  		

				if(this.m_strDrawLine2Sql!="")
				{
					//查询第二条线的sql语句
					 strSql=this.m_strDrawLine2Sql;				
					DataTable dt=new DataTable();
					CDBConnection.getDataTable(ref dt,strSql,"tbData");
					dtLine2=dt;
				}

				ZedGraph.Demo.DateAxisSampleDemo demo = new ZedGraph.Demo.DateAxisSampleDemo();				

				demo.m_dtLine1 =dtLine1;
				demo.m_strTitle="";

				demo.m_dtLine2=dtLine2;
				//第一条线名称
				demo.m_strLine1Name=this.m_strColTitle1;
				//第二条线名称
				demo.m_strLine2Name=this.m_strColTitle2; 
				if(strFrom!=strTo)
				{
					//绘图
					demo.m_strState="month";
				}
				else
				{
					//绘图
					demo.m_strState="Day";

				}
				

				demo.initialDateAxis();

				
			
				if ( demo == null )
					return false;

				this.tabChart.TabPages[0].Controls.Clear();
				this.tabChart.TabPages[0].Controls.Add(this.lblInfo);
				this.tabChart.TabPages[0].Controls.Add(demo.ZedGraphControl);

				//demo.ZedGraphControl.Top=this.label1.Top+this.label1.Height;
				demo.ZedGraphControl.Top=10;
				demo.ZedGraphControl.Left=10;
				demo.ZedGraphControl.Width = tabChart.Width-20;
				demo.ZedGraphControl.Height	= tabChart.Height-40;

				demo.ZedGraphControl.Anchor	= AnchorStyles.Left | AnchorStyles.Top  
					| AnchorStyles.Right | AnchorStyles.Bottom;

				//this.Text				= TitlePrefix + demo.Title;

				//descriptionBox.Text	= demo.Description;

				// tell the control to rescale itself
				demo.ZedGraphControl.AxisChange();

				// redraw the entire form
				this.Invalidate();
				return true;

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}
		
		private void btnDisp_Click(object sender, System.EventArgs e)
		{
			try
			{
				string strWellNo="";
				if(this.trvDep.SelectedNode!=null)
				{
					string strNText=this.trvDep.SelectedNode.Text.Trim();
					if(strNText.IndexOf("|")>0)
					{
						strWellNo=strNText.Substring(0,strNText.IndexOf("|"));
					}				
				}
				this.paintChart(strWellNo);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void chkLeft_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.chkLeft.Checked==true)
			{
				this.chkUsed.Checked=false;
				this.chkAll.Checked=false;
				this.chkFlowAmount.Checked=false;
				this.m_strColTitle1=this.chkLeft.Text;
			}
		}


		private void chkFlow_CheckedChanged(object sender, System.EventArgs e)
		{
//			if(this.chkFlow.Checked==true)
//			{
//				this.chkLeft.Checked=false;
//			}
//			if(this.chkFlow.Checked==false)
//			{
//				this.chkLeft.Checked=true;
//			}
			try
			{
				if(this.trvDep.SelectedNode!=null)
				{
					if(this.trvDep.SelectedNode.Parent!=null)
					{
						if(this.trvDep.SelectedNode.Parent.Parent!=null)
						{
							if(this.trvDep.SelectedNode.Parent.Parent.Parent!=null)
							{
								//水井节点被选中
								string strWellNo=this.trvDep.SelectedNode.Text.Substring(0,3);
								this.paintChart(strWellNo);
								return;
							}
						}

					}				
				}

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnPrint_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.tabChart.BackColor=Color.White;
				crc16.CaptureScreen cs=new crc16.CaptureScreen();
				this.m_cs =cs;
				cs.CaptureScreen(this,this.tabPage1);
				this.printDocument1.DefaultPageSettings.Landscape = true;
				int iWidth  = (int)(21 / 2.54 * 100);
				int iHeight = (int)(29.75 / 2.54 * 100);

				this.printDocument1.DefaultPageSettings.PaperSize=new System.Drawing.Printing.PaperSize("A4", iWidth, iHeight);
				this.printPreviewDialog1.Document=this.printDocument1 ;			
				this.printPreviewDialog1.WindowState = FormWindowState.Maximized;
				this.printPreviewDialog1.ShowDialog();

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
        
		}

		private void printPreviewDialog1_Load(object sender, System.EventArgs e)
		{
			
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawImage(this.m_cs.memoryImage,160,140);
		}

		private void dtFrom_ValueChanged(object sender, System.EventArgs e)
		{
			
		}

		private void dtTo_ValueChanged(object sender, System.EventArgs e)
		{			
		}

		private void chkUsed_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.chkUsed.Checked==true)
			{
				this.chkLeft.Checked=false;
				this.chkAll.Checked=false;
				this.chkFlowAmount.Checked=false;
				this.m_strColTitle1=this.chkUsed.Text;
			}
		}

		private void chkAll_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.chkAll.Checked==true)
			{
				this.chkLeft.Checked=false;
				this.chkUsed.Checked=false;
				this.chkFlowAmount.Checked=false;
				this.m_strColTitle1=this.chkAll.Text;
			}
		}

		private void chkFlowAmount_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.chkFlowAmount.Checked==true)
			{
				this.chkAll.Checked=false;
				this.chkUsed.Checked=false;
				this.chkLeft.Checked=false;
				this.m_strColTitle1=this.chkFlowAmount.Text;
			}
		}
		#region"数据查询区"
		private void paintChart(string strWellNo)
		{
			// 已审
			try
			{
				string strFieldName="";

				if(this.chkAll.Checked==true)
				{
					if(strFieldName!="")
					{
						MessageBox.Show("只能选择一个图表类型！");
						return;
					}
					strFieldName="allWaterAmount";
				}				
				if(this.chkFlowAmount.Checked==true)
				{
					if(strFieldName!="")
					{
						MessageBox.Show("只能选择一个图表类型！");
						return;
					}
					strFieldName="flowWaterAmount";
				}
				if(this.chkLeft.Checked==true)
				{
					if(strFieldName!="")
					{
						MessageBox.Show("只能选择一个图表类型！");
						return;
					}
					strFieldName="leftWaterAmount";
				}
				if(this.chkUsed.Checked==true)
				{
					if(strFieldName!="")
					{
						MessageBox.Show("只能选择一个图表类型！");
						return;
					}
					strFieldName="usedWaterAmount";
				}
				if(strFieldName=="")
				{
					MessageBox.Show("请选择图表类型！");
					return;
				}


				string strFrom=String.Format("{0}-{1}-{2}",this.dtFrom.Value.Year.ToString(),this.dtFrom.Value.Month.ToString(),this.dtFrom.Value.Day.ToString());
				string strTo=String.Format("{0}-{1}-{2}",this.dtTo.Value.Year.ToString(),this.dtTo.Value.Month.ToString(),this.dtTo.Value.Day.ToString());
				if(this.chkLeft.Checked==true)
				{
					this.m_strDrawLine1Sql=this.getDrawLineSql("tbWellAmount",strFieldName,strWellNo,strFrom,strTo);					
				}
				else
				{
					this.m_strDrawLine1Sql=this.getDrawLineSql("tbWellAmount",strFieldName,strWellNo,strFrom,strTo);					
				}				
				
				this.PaintFrm(strWellNo);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
		}
		/// <summary>
		/// 获得图表的历史曲线
		/// </summary>
		/// <param name="strTableName">表名</param>
		/// <param name="strColName">列名</param>
		/// <param name="strWatNo">水井编号</param>
		/// <param name="strDay1">起始时间</param>
		/// <param name="strDay2">终止时间</param>
		/// <returns></returns>
		private string getDrawLineSql(string strTableName,string strColName,string strWatNo,string strDay1,string strDay2)
		{
			//已审
			if(strDay2!="")
			{
				if(strDay1!=strDay2)
				{
					//时间范围（天数）不为0
					//一天内的平均数
					//已用
					string strSql=String.Format("pAmountChart '{0}','{1}','{2}','{3}'",strColName,strWatNo,strDay1,strDay2);				
					return strSql;
				}
				else
				{
					//同一天内
					DateTime dt=Convert.ToDateTime(strDay1);
					string strSql=String.Format("select {0} y,time x from {5} where wellNo='{1}' and year(time)={2} and month(time)={3} and day(time)={4} order by time",strColName,strWatNo,dt.Year.ToString(),dt.Month.ToString(),dt.Day.ToString(),strTableName);
					return strSql;
				}
				
			}
			else
			{
				
			}
			return "";
		}


		#endregion

		private void cmbCountry_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			tools.CPaintForm.paintWell(this.cmbCountry.Text,this.trvDep);
		}

	}
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using BengZhan;
using System.Data;
using System.Data.SqlClient;
using System.Xml;

namespace BengZhan.comReport.zedGraph
{
	/// <summary>
	/// frmSrChart 的摘要说明。
	/// </summary>
	public class frmSrChart : System.Windows.Forms.Form
	{
		public SqlConnection m_sCon;

		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ComboBox cmbCountry;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.DateTimePicker dtTo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtFrom;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnDisp;
		private System.Windows.Forms.TabControl tabChart;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label lblInfo;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TreeView trvDep;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbType;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private ZedGraph.ZedGraphControl zedGraphControl1;
		private System.Windows.Forms.NumericUpDown numStart;
		private System.Windows.Forms.NumericUpDown numEnd;
		private crc16.CaptureScreen m_cs;

		public frmSrChart()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSrChart));
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cmbCountry = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.cmbType = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnPrint = new System.Windows.Forms.Button();
			this.dtTo = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.dtFrom = new System.Windows.Forms.DateTimePicker();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnDisp = new System.Windows.Forms.Button();
			this.tabChart = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
			this.lblInfo = new System.Windows.Forms.Label();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.trvDep = new System.Windows.Forms.TreeView();
			this.numStart = new System.Windows.Forms.NumericUpDown();
			this.numEnd = new System.Windows.Forms.NumericUpDown();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tabChart.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numStart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numEnd)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cmbCountry);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Location = new System.Drawing.Point(0, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(200, 48);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			// 
			// cmbCountry
			// 
			this.cmbCountry.Location = new System.Drawing.Point(84, 13);
			this.cmbCountry.Name = "cmbCountry";
			this.cmbCountry.Size = new System.Drawing.Size(108, 20);
			this.cmbCountry.TabIndex = 3;
			this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(4, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "所属乡镇：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.numEnd);
			this.groupBox2.Controls.Add(this.numStart);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.cmbType);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.btnPrint);
			this.groupBox2.Controls.Add(this.dtTo);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.dtFrom);
			this.groupBox2.Controls.Add(this.btnExit);
			this.groupBox2.Controls.Add(this.btnDisp);
			this.groupBox2.Location = new System.Drawing.Point(208, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(808, 48);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(616, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(64, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "日统计值图表";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// cmbType
			// 
			this.cmbType.Location = new System.Drawing.Point(448, 16);
			this.cmbType.Name = "cmbType";
			this.cmbType.Size = new System.Drawing.Size(96, 20);
			this.cmbType.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(376, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "数据类型：";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "时间范围：";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(680, 16);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(64, 23);
			this.btnPrint.TabIndex = 7;
			this.btnPrint.Text = "打印";
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// dtTo
			// 
			this.dtTo.Location = new System.Drawing.Point(248, 17);
			this.dtTo.Name = "dtTo";
			this.dtTo.Size = new System.Drawing.Size(96, 21);
			this.dtTo.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(216, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "至：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtFrom
			// 
			this.dtFrom.Location = new System.Drawing.Point(88, 16);
			this.dtFrom.Name = "dtFrom";
			this.dtFrom.Size = new System.Drawing.Size(96, 21);
			this.dtFrom.TabIndex = 2;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(744, 16);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(56, 23);
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnDisp
			// 
			this.btnDisp.Location = new System.Drawing.Point(552, 16);
			this.btnDisp.Name = "btnDisp";
			this.btnDisp.Size = new System.Drawing.Size(64, 23);
			this.btnDisp.TabIndex = 0;
			this.btnDisp.Text = "明细图表";
			this.btnDisp.Click += new System.EventHandler(this.btnDisp_Click);
			// 
			// tabChart
			// 
			this.tabChart.Controls.Add(this.tabPage1);
			this.tabChart.Location = new System.Drawing.Point(208, 56);
			this.tabChart.Name = "tabChart";
			this.tabChart.SelectedIndex = 0;
			this.tabChart.Size = new System.Drawing.Size(808, 496);
			this.tabChart.TabIndex = 5;
			this.tabChart.SelectedIndexChanged += new System.EventHandler(this.tabChart_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage1.Controls.Add(this.zedGraphControl1);
			this.tabPage1.Controls.Add(this.lblInfo);
			this.tabPage1.Location = new System.Drawing.Point(4, 21);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(800, 471);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "历史曲线";
			// 
			// zedGraphControl1
			// 
			this.zedGraphControl1.BackColor = System.Drawing.SystemColors.Window;
			this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.zedGraphControl1.IsAutoScrollRange = false;
			this.zedGraphControl1.IsEnableHPan = true;
			this.zedGraphControl1.IsEnableHZoom = true;
			this.zedGraphControl1.IsEnableVPan = true;
			this.zedGraphControl1.IsEnableVZoom = true;
			this.zedGraphControl1.IsPrintFillPage = true;
			this.zedGraphControl1.IsPrintKeepAspectRatio = true;
			this.zedGraphControl1.IsScrollY2 = false;
			this.zedGraphControl1.IsShowContextMenu = true;
			this.zedGraphControl1.IsShowCopyMessage = true;
			this.zedGraphControl1.IsShowCursorValues = false;
			this.zedGraphControl1.IsShowHScrollBar = false;
			this.zedGraphControl1.IsShowPointValues = false;
			this.zedGraphControl1.IsShowVScrollBar = false;
			this.zedGraphControl1.IsZoomOnMouseCenter = false;
			this.zedGraphControl1.Location = new System.Drawing.Point(0, 0);
			this.zedGraphControl1.Name = "zedGraphControl1";
			this.zedGraphControl1.PanButtons = System.Windows.Forms.MouseButtons.Left;
			this.zedGraphControl1.PanButtons2 = System.Windows.Forms.MouseButtons.Middle;
			this.zedGraphControl1.PanModifierKeys2 = System.Windows.Forms.Keys.None;
			this.zedGraphControl1.PointDateFormat = "g";
			this.zedGraphControl1.PointValueFormat = "G";
			this.zedGraphControl1.ScrollMaxX = 0;
			this.zedGraphControl1.ScrollMaxY = 0;
			this.zedGraphControl1.ScrollMaxY2 = 0;
			this.zedGraphControl1.ScrollMinX = 0;
			this.zedGraphControl1.ScrollMinY = 0;
			this.zedGraphControl1.ScrollMinY2 = 0;
			this.zedGraphControl1.Size = new System.Drawing.Size(800, 471);
			this.zedGraphControl1.TabIndex = 1;
			this.zedGraphControl1.ZoomButtons = System.Windows.Forms.MouseButtons.Left;
			this.zedGraphControl1.ZoomButtons2 = System.Windows.Forms.MouseButtons.None;
			this.zedGraphControl1.ZoomModifierKeys = System.Windows.Forms.Keys.None;
			this.zedGraphControl1.ZoomModifierKeys2 = System.Windows.Forms.Keys.None;
			this.zedGraphControl1.ZoomStepFraction = 0.1;
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
			this.printPreviewDialog1.Location = new System.Drawing.Point(17, 17);
			this.printPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog1.Visible = false;
			this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.trvDep);
			this.groupBox1.Location = new System.Drawing.Point(0, 48);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 496);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			// 
			// trvDep
			// 
			this.trvDep.ImageIndex = -1;
			this.trvDep.Location = new System.Drawing.Point(8, 16);
			this.trvDep.Name = "trvDep";
			this.trvDep.SelectedImageIndex = -1;
			this.trvDep.Size = new System.Drawing.Size(184, 472);
			this.trvDep.TabIndex = 0;
			// 
			// numStart
			// 
			this.numStart.Location = new System.Drawing.Point(184, 17);
			this.numStart.Maximum = new System.Decimal(new int[] {
																	 23,
																	 0,
																	 0,
																	 0});
			this.numStart.Name = "numStart";
			this.numStart.Size = new System.Drawing.Size(32, 21);
			this.numStart.TabIndex = 12;
			this.numStart.Value = new System.Decimal(new int[] {
																   8,
																   0,
																   0,
																   0});
			// 
			// numEnd
			// 
			this.numEnd.Location = new System.Drawing.Point(344, 17);
			this.numEnd.Maximum = new System.Decimal(new int[] {
																   23,
																   0,
																   0,
																   0});
			this.numEnd.Name = "numEnd";
			this.numEnd.Size = new System.Drawing.Size(32, 21);
			this.numEnd.TabIndex = 13;
			this.numEnd.Value = new System.Decimal(new int[] {
																 8,
																 0,
																 0,
																 0});
			// 
			// frmSrChart
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(1016, 558);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.tabChart);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmSrChart";
			this.Text = "数据图表";
			this.Resize += new System.EventHandler(this.frmSrChart_Resize);
			this.Load += new System.EventHandler(this.frmSrChart_Load);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.tabChart.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numStart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numEnd)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmSrChart_Load(object sender, System.EventArgs e)
		{
			this.PaintForm();

			openCon();
			CDBConnection.m_sCon=this.m_sCon;
			this.dtTo.Value=this.dtFrom.Value.AddDays(1);				
			BengZhan.tools.CPaintForm.paintCountry(this.cmbCountry);
			BengZhan.tools.CPaintForm.paintWell(this.cmbCountry.Text,this.trvDep);
			paintCmbDataType();

			string strFrom=this.dtFrom .Value.ToShortDateString();
			strFrom=strFrom+" "+this.numStart.Value.ToString().Trim()+":00:00";
			string strTo=this.dtTo.Value.ToShortDateString();
			strTo=strTo+" "+this.numEnd.Value.ToString().Trim()+":00:00";

			string strZhanNo="001";

			string strCDataType=this.cmbType.Text.Trim();
				
			BengZhan.comReport.zedGraph.CmyPaintChart.paintChartDetail(strFrom,strTo,strZhanNo,strCDataType,this.zedGraphControl1);
		
		}
		private bool paintCmbDataType()
		{
			try

			{
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("columnName.xml");
				
				for(int i=0;i<xDoc.DocumentElement.ChildNodes.Count;i++)
				{
					string strCDataType=xDoc.DocumentElement.ChildNodes[i].Attributes.GetNamedItem("des").Value.ToString().Trim();
					if(strCDataType=="时间"||strCDataType=="单位名称")
					{
						continue;
					}
					this.cmbType.Items.Add(strCDataType);
				}
				if(this.cmbType.Items.Count==0)
				{
					return true;
				}
				this.cmbType.Text=this.cmbType.Items[0].ToString();

				 return true;
			}
			catch(Exception ex)
			{
				return false;
			}
		}
		private void PaintForm()
		{

			this.groupBox1.Height=this.Height-this.groupBox1.Top-35;
			this.trvDep.Height=this.groupBox1.Height-20;
			this.tabChart.Height=this.Height-this.tabChart.Top-35;
			this.tabChart.Width=this.Width-this.tabChart.Left-20;

		}
		
		//temp del
		private void openCon()
		{
			try
			{
				if(this.m_sCon==null)
				{
					string strCon=@"server=.\watersysclient;uid=sa;pwd=sa;database=dbbengzhan";

					SqlConnection sCon=new SqlConnection(strCon);

					sCon.Open();

					this.m_sCon=sCon;

				}
		
			}
			catch(Exception e)
			{
				MessageBox.Show(e.ToString());
			}
		}


		private void tabChart_SelectedIndexChanged(object sender, System.EventArgs e)
		{		
		}

		private void cmbCountry_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			BengZhan.tools.CPaintForm.paintWell(this.cmbCountry.Text,this.trvDep);
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmSrChart_Resize(object sender, System.EventArgs e)
		{
			this.PaintForm();
		}

		private void btnDisp_Click(object sender, System.EventArgs e)
		{
			try
			{

				string strFrom=this.dtFrom .Value.ToShortDateString();
				strFrom=strFrom+" "+this.numStart.Value.ToString().Trim()+":00:00";
				string strTo=this.dtTo.Value.ToShortDateString();
				strTo=strTo+" "+this.numEnd.Value.ToString().Trim()+":00:00";

				if(this.trvDep.SelectedNode==null)
				{
					MessageBox.Show("请选中一个站点!");
					return;
				}

				string strZhanInfo=this.trvDep.SelectedNode.Text.Trim();

				if(strZhanInfo.IndexOf("|")<0)
				{
					MessageBox.Show("请选中一个站点!");
					return;
				}
				string strZhanNo=strZhanInfo.Substring(0,strZhanInfo.IndexOf("|"));

				string strCDataType=this.cmbType.Text.Trim();

				if(strCDataType=="")
				{
					MessageBox.Show("数据类型不能为空!");
					return;
				}

				comReport.zedGraph.CmyPaintChart.paintChartDetail(strFrom,strTo,strZhanNo,strCDataType,this.zedGraphControl1);

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			try
			{

				string strFrom=this.dtFrom.Value.ToShortDateString();
				string strTo=this.dtTo.Value.ToShortDateString();

				if(this.trvDep.SelectedNode==null)
				{
					MessageBox.Show("请选中一个站点!");
					return;
				}

				string strZhanInfo=this.trvDep.SelectedNode.Text.Trim();

				if(strZhanInfo.IndexOf("|")<0)
				{
					MessageBox.Show("请选中一个站点!");
					return;
				}
				string strZhanNo=strZhanInfo.Substring(0,strZhanInfo.IndexOf("|"));

				string strCDataType=this.cmbType.Text.Trim();

				if(strCDataType=="")
				{
					MessageBox.Show("数据类型不能为空!");
					return;
				}

				comReport.zedGraph.CmyPaintChart.paintChartAvg(strFrom,strTo,strZhanNo,strCDataType,this.zedGraphControl1);

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
				if(ex.ToString().IndexOf("取消")>=0)
				{
					MessageBox.Show("打印已取消！");
					return;
				}
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
	}
}

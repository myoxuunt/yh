using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;
using System.Data;
namespace CReportDll
{
	/// <summary>
	/// frmChart 的摘要说明。
	/// </summary>
	public class frmChart : System.Windows.Forms.Form
	{
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ComboBox cmbCountry;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabControl tabChart;
		private System.Windows.Forms.TabPage tabPage1;
		private ZedGraph.ZedGraphControl zedGraphControl1;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.NumericUpDown numEnd;
		private System.Windows.Forms.NumericUpDown numStart;
		private System.Windows.Forms.ComboBox cmbType;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnDisp;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TabPage tabPage2;
		private ZedGraph.ZedGraphControl zedGraphControl2;
		private System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.DateTimePicker dtpFrom;
		private System.Windows.Forms.TreeView trvWel;
		private System.Windows.Forms.TextBox txtZhan;
		private System.Windows.Forms.TabPage tabPage3;
		private ZedGraph.ZedGraphControl zedGraphControl3;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

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
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cmbCountry = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tabChart = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
			this.lblInfo = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.zedGraphControl3 = new ZedGraph.ZedGraphControl();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.numEnd = new System.Windows.Forms.NumericUpDown();
			this.numStart = new System.Windows.Forms.NumericUpDown();
			this.cmbType = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnPrint = new System.Windows.Forms.Button();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnDisp = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.trvWel = new System.Windows.Forms.TreeView();
			this.txtZhan = new System.Windows.Forms.TextBox();
			this.groupBox3.SuspendLayout();
			this.tabChart.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numEnd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numStart)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
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
			this.printPreviewDialog1.Location = new System.Drawing.Point(22, 22);
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
			this.groupBox3.Location = new System.Drawing.Point(0, 8);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(184, 48);
			this.groupBox3.TabIndex = 11;
			this.groupBox3.TabStop = false;
			// 
			// cmbCountry
			// 
			this.cmbCountry.Location = new System.Drawing.Point(72, 16);
			this.cmbCountry.Name = "cmbCountry";
			this.cmbCountry.Size = new System.Drawing.Size(108, 20);
			this.cmbCountry.TabIndex = 3;
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
			// tabChart
			// 
			this.tabChart.Controls.Add(this.tabPage1);
			this.tabChart.Controls.Add(this.tabPage2);
			this.tabChart.Controls.Add(this.tabPage3);
			this.tabChart.Location = new System.Drawing.Point(184, 56);
			this.tabChart.Name = "tabChart";
			this.tabChart.SelectedIndex = 0;
			this.tabChart.Size = new System.Drawing.Size(824, 592);
			this.tabChart.TabIndex = 9;
			this.tabChart.SelectedIndexChanged += new System.EventHandler(this.tabChart_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage1.Controls.Add(this.zedGraphControl1);
			this.tabPage1.Controls.Add(this.lblInfo);
			this.tabPage1.Location = new System.Drawing.Point(4, 21);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(816, 567);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "明细图";
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
			this.zedGraphControl1.Size = new System.Drawing.Size(816, 567);
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
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.zedGraphControl2);
			this.tabPage2.Location = new System.Drawing.Point(4, 21);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(816, 567);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "日统计图";
			// 
			// zedGraphControl2
			// 
			this.zedGraphControl2.BackColor = System.Drawing.SystemColors.Window;
			this.zedGraphControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.zedGraphControl2.IsAutoScrollRange = false;
			this.zedGraphControl2.IsEnableHPan = true;
			this.zedGraphControl2.IsEnableHZoom = true;
			this.zedGraphControl2.IsEnableVPan = true;
			this.zedGraphControl2.IsEnableVZoom = true;
			this.zedGraphControl2.IsPrintFillPage = true;
			this.zedGraphControl2.IsPrintKeepAspectRatio = true;
			this.zedGraphControl2.IsScrollY2 = false;
			this.zedGraphControl2.IsShowContextMenu = true;
			this.zedGraphControl2.IsShowCopyMessage = true;
			this.zedGraphControl2.IsShowCursorValues = false;
			this.zedGraphControl2.IsShowHScrollBar = false;
			this.zedGraphControl2.IsShowPointValues = false;
			this.zedGraphControl2.IsShowVScrollBar = false;
			this.zedGraphControl2.IsZoomOnMouseCenter = false;
			this.zedGraphControl2.Location = new System.Drawing.Point(0, 0);
			this.zedGraphControl2.Name = "zedGraphControl2";
			this.zedGraphControl2.PanButtons = System.Windows.Forms.MouseButtons.Left;
			this.zedGraphControl2.PanButtons2 = System.Windows.Forms.MouseButtons.Middle;
			this.zedGraphControl2.PanModifierKeys2 = System.Windows.Forms.Keys.None;
			this.zedGraphControl2.PointDateFormat = "g";
			this.zedGraphControl2.PointValueFormat = "G";
			this.zedGraphControl2.ScrollMaxX = 0;
			this.zedGraphControl2.ScrollMaxY = 0;
			this.zedGraphControl2.ScrollMaxY2 = 0;
			this.zedGraphControl2.ScrollMinX = 0;
			this.zedGraphControl2.ScrollMinY = 0;
			this.zedGraphControl2.ScrollMinY2 = 0;
			this.zedGraphControl2.Size = new System.Drawing.Size(816, 567);
			this.zedGraphControl2.TabIndex = 2;
			this.zedGraphControl2.ZoomButtons = System.Windows.Forms.MouseButtons.Left;
			this.zedGraphControl2.ZoomButtons2 = System.Windows.Forms.MouseButtons.None;
			this.zedGraphControl2.ZoomModifierKeys = System.Windows.Forms.Keys.None;
			this.zedGraphControl2.ZoomModifierKeys2 = System.Windows.Forms.Keys.None;
			this.zedGraphControl2.ZoomStepFraction = 0.1;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.zedGraphControl3);
			this.tabPage3.Location = new System.Drawing.Point(4, 21);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(816, 567);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "月统计图";
			// 
			// zedGraphControl3
			// 
			this.zedGraphControl3.BackColor = System.Drawing.SystemColors.Window;
			this.zedGraphControl3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.zedGraphControl3.IsAutoScrollRange = false;
			this.zedGraphControl3.IsEnableHPan = true;
			this.zedGraphControl3.IsEnableHZoom = true;
			this.zedGraphControl3.IsEnableVPan = true;
			this.zedGraphControl3.IsEnableVZoom = true;
			this.zedGraphControl3.IsPrintFillPage = true;
			this.zedGraphControl3.IsPrintKeepAspectRatio = true;
			this.zedGraphControl3.IsScrollY2 = false;
			this.zedGraphControl3.IsShowContextMenu = true;
			this.zedGraphControl3.IsShowCopyMessage = true;
			this.zedGraphControl3.IsShowCursorValues = false;
			this.zedGraphControl3.IsShowHScrollBar = false;
			this.zedGraphControl3.IsShowPointValues = false;
			this.zedGraphControl3.IsShowVScrollBar = false;
			this.zedGraphControl3.IsZoomOnMouseCenter = false;
			this.zedGraphControl3.Location = new System.Drawing.Point(0, 0);
			this.zedGraphControl3.Name = "zedGraphControl3";
			this.zedGraphControl3.PanButtons = System.Windows.Forms.MouseButtons.Left;
			this.zedGraphControl3.PanButtons2 = System.Windows.Forms.MouseButtons.Middle;
			this.zedGraphControl3.PanModifierKeys2 = System.Windows.Forms.Keys.None;
			this.zedGraphControl3.PointDateFormat = "g";
			this.zedGraphControl3.PointValueFormat = "G";
			this.zedGraphControl3.ScrollMaxX = 0;
			this.zedGraphControl3.ScrollMaxY = 0;
			this.zedGraphControl3.ScrollMaxY2 = 0;
			this.zedGraphControl3.ScrollMinX = 0;
			this.zedGraphControl3.ScrollMinY = 0;
			this.zedGraphControl3.ScrollMinY2 = 0;
			this.zedGraphControl3.Size = new System.Drawing.Size(816, 567);
			this.zedGraphControl3.TabIndex = 0;
			this.zedGraphControl3.ZoomButtons = System.Windows.Forms.MouseButtons.Left;
			this.zedGraphControl3.ZoomButtons2 = System.Windows.Forms.MouseButtons.None;
			this.zedGraphControl3.ZoomModifierKeys = System.Windows.Forms.Keys.None;
			this.zedGraphControl3.ZoomModifierKeys2 = System.Windows.Forms.Keys.None;
			this.zedGraphControl3.ZoomStepFraction = 0.1;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.numEnd);
			this.groupBox2.Controls.Add(this.numStart);
			this.groupBox2.Controls.Add(this.cmbType);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.btnPrint);
			this.groupBox2.Controls.Add(this.dtpTo);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.dtpFrom);
			this.groupBox2.Controls.Add(this.btnExit);
			this.groupBox2.Controls.Add(this.btnDisp);
			this.groupBox2.Location = new System.Drawing.Point(184, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(824, 48);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
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
			this.btnPrint.Location = new System.Drawing.Point(616, 16);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(64, 23);
			this.btnPrint.TabIndex = 7;
			this.btnPrint.Text = "打印";
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// dtpTo
			// 
			this.dtpTo.Location = new System.Drawing.Point(248, 17);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(96, 21);
			this.dtpTo.TabIndex = 4;
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
			// dtpFrom
			// 
			this.dtpFrom.Location = new System.Drawing.Point(88, 16);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.Size = new System.Drawing.Size(96, 21);
			this.dtpFrom.TabIndex = 2;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(680, 16);
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
			this.btnDisp.Text = "确认";
			this.btnDisp.Click += new System.EventHandler(this.btnDisp_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.trvWel);
			this.groupBox1.Location = new System.Drawing.Point(0, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(184, 592);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			// 
			// trvWel
			// 
			this.trvWel.ImageIndex = -1;
			this.trvWel.Location = new System.Drawing.Point(8, 16);
			this.trvWel.Name = "trvWel";
			this.trvWel.SelectedImageIndex = -1;
			this.trvWel.Size = new System.Drawing.Size(168, 568);
			this.trvWel.TabIndex = 0;
			this.trvWel.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvWell_AfterSelect);
			// 
			// txtZhan
			// 
			this.txtZhan.Location = new System.Drawing.Point(8, 16);
			this.txtZhan.Name = "txtZhan";
			this.txtZhan.TabIndex = 0;
			this.txtZhan.Text = "";
			// 
			// frmChart
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(1016, 654);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.tabChart);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmChart";
			this.Text = "数据曲线";
			this.Load += new System.EventHandler(this.frmChart_Load);
			this.groupBox3.ResumeLayout(false);
			this.tabChart.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numEnd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numStart)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private XmlDocument m_xDocRep;

		private void frmChart_Load(object sender, System.EventArgs e)
		{

			BengZhan.tools.CPaintForm.paintCountry(this.cmbCountry);
			BengZhan.tools.CPaintForm.paintWell(this.cmbCountry.Text,this.trvWel);

			if(this.m_xDocRep==null)
			{
				this.m_xDocRep=new XmlDocument();
				this.m_xDocRep.Load("repPrint.xml");
			}

			XmlNode xNode=this.m_xDocRep.DocumentElement.SelectSingleNode("./rep[@val='1']");

			this.cmbCountry.Items.Clear();

			for(int i=0;i<xNode.ChildNodes.Count;i++)
			{
				string strType=xNode.ChildNodes[i].Attributes.GetNamedItem("headerText").Value.Trim();
				string strBChart=xNode.ChildNodes[i].Attributes.GetNamedItem("bChart").Value.Trim();
				if(strBChart.Trim()=="true")
				{
					this.cmbType.Items.Add(strType);
				}
			}
			
		    this.zedGraphControl1.GraphPane.Title="明细图表";
			this.zedGraphControl1.GraphPane.XAxis.Title="时间";
			this.zedGraphControl1.GraphPane.YAxis.Title="流量";
			this.zedGraphControl2.GraphPane.Title="日统计图表";
			this.zedGraphControl2.GraphPane.XAxis.Title="日期";
		    this.zedGraphControl2.GraphPane.YAxis.Title="流量"; 

            this.zedGraphControl3.GraphPane.Title="月统计图表";
			this.zedGraphControl3.GraphPane.XAxis.Title="月份";
			this.zedGraphControl3.GraphPane.YAxis.Title="流量";

			//this.zedGraphControl1.p
		}
		private string m_strSelNodeType="";

		private void btnDisp_Click(object sender, System.EventArgs e)
		{
			if(this.trvWel.SelectedNode==null)
			{
				MessageBox.Show("请选中要进行统计的站点或单位!");
				return;
			}
			bool bBreak=false;

			switch(this.m_strSelNodeType.Trim())
			{
				case "zhan":
				switch(this.tabChart.SelectedIndex)
				{
					case 0:
						//明细表
						this.detailRep();
						bBreak=true;
						break;
					case 1:
						//日统计表
						dayStaticRep();
						bBreak=true;
						break;
					case 2:
						monthStaticRep();
						bBreak=true;
						break;
				}
				break;
				case "dep":
				switch(this.tabChart.SelectedIndex)
				{
					case 0:
						detailRepDep();
						bBreak=true;
						break;						
					case 1:
						this.dayStaticRepDep();
						bBreak=true;
						break;	
					case 2:
						this.dayStaticRepDepMonth();
						bBreak=true;
						break;
				}
					break;
					//else:
					//break;
			}
			if(!bBreak)
			{
				MessageBox.Show("请选中要进行统计的监测站或单位!");
				return;
			}
			//this.paintOneLine();
		}

		private void detailRep()
		{
			try
			{
				string strFrom=this.dtpFrom.Value.ToShortDateString();
				strFrom=strFrom+" "+this.numStart.Value.ToString().Trim()+":00:00";
				string strTo=this.dtpTo.Value.ToShortDateString();
				strTo=strTo+" "+this.numEnd.Value.ToString().Trim()+":00:00";

				if(this.trvWel.SelectedNode==null)
				{
					MessageBox.Show("请选中一个站点!");
					return;
				}

				string strZhanInfo=this.trvWel.SelectedNode.Text.Trim();

				if(strZhanInfo.IndexOf("|")<0)
				{
					MessageBox.Show("请选中一个站点!");
					return;
				}

				string strCDataType=this.cmbType.Text.Trim();

				if(strCDataType=="")
				{
					MessageBox.Show("数据类型不能为空!");
					return;
				}

				string strZhanNo=strZhanInfo.Substring(0,strZhanInfo.IndexOf("|"));	

				BengZhan.comReport.zedGraph.CmyPaintChart.paintChartDetail(strFrom,strTo,strZhanNo,strCDataType,this.zedGraphControl1);
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void dayStaticRep()
		{
			try
			{
				string strFrom=this.dtpFrom.Value.ToShortDateString();
				//strFrom=strFrom+" "+this.numStart.Value.ToString().Trim()+":00:00";
				string strTo=this.dtpTo.Value.ToShortDateString();
				//strTo=strTo+" "+this.numEnd.Value.ToString().Trim()+":00:00";				
				if(this.trvWel.SelectedNode==null)
				{
					MessageBox.Show("请选中一个站点!");
					return;
				}

				string strZhanInfo=this.trvWel.SelectedNode.Text.Trim();

				if(strZhanInfo.IndexOf("|")<0)
				{
					MessageBox.Show("请选中一个站点!");
					return;
				}

				string strCDataType=this.cmbType.Text.Trim();

				if(strCDataType=="")
				{
					MessageBox.Show("数据类型不能为空!");
					return;
				}

				string strZhanNo=strZhanInfo.Substring(0,strZhanInfo.IndexOf("|"));	

				BengZhan.comReport.zedGraph.CmyPaintChart.paintChartAvg(strFrom,strTo,strZhanNo,strCDataType,this.zedGraphControl2);
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void monthStaticRep()
		{
            try
			{
				string strFrom=this.dtpFrom.Value.ToShortDateString();
				//strFrom=strFrom+" "+this.numStart.Value.ToString().Trim()+":00:00";
				string strTo=this.dtpTo.Value.ToShortDateString();
				//strTo=strTo+" "+this.numEnd.Value.ToString().Trim()+":00:00";				
				if(this.trvWel.SelectedNode==null)
				{
					MessageBox.Show("请选中一个站点!");
					return;
				}

				string strZhanInfo=this.trvWel.SelectedNode.Text.Trim();

				if(strZhanInfo.IndexOf("|")<0)
				{
					MessageBox.Show("请选中一个站点!");
					return;
				}

				string strCDataType=this.cmbType.Text.Trim();

				if(strCDataType=="")
				{
					MessageBox.Show("数据类型不能为空!");
					return;
				}

				string strZhanNo=strZhanInfo.Substring(0,strZhanInfo.IndexOf("|"));	

				BengZhan.comReport.zedGraph.CmyPaintChart.paintChartAvgMonth(strFrom,strTo,strZhanNo,strCDataType,this.zedGraphControl3);
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void detailRepDep()
		{
			try
			{
				string strFrom=this.dtpFrom.Value.ToShortDateString();
				strFrom=strFrom+" "+this.numStart.Value.ToString().Trim()+":00:00";
				string strTo=this.dtpTo.Value.ToShortDateString();
				strTo=strTo+" "+this.numEnd.Value.ToString().Trim()+":00:00";

				if(this.trvWel.SelectedNode==null)
				{
					MessageBox.Show("请选中一个站点!");
					return;
				}				

				string strCDataType=this.cmbType.Text.Trim();

				if(strCDataType=="")
				{
					MessageBox.Show("数据类型不能为空!");
					return;
				}		

				BengZhan.comReport.zedGraph.CmyPaintChart.paintChartDetailDep(strFrom,strTo,this.m_strZhanName,strCDataType,this.zedGraphControl1);
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void dayStaticRepDep()
		{
			try
			{
				string strFrom=this.dtpFrom.Value.ToShortDateString();
				//strFrom=strFrom+" "+this.numStart.Value.ToString().Trim()+":00:00";
				string strTo=this.dtpTo.Value.ToShortDateString();
				//strTo=strTo+" "+this.numEnd.Value.ToString().Trim()+":00:00";	

				string strCDataType=this.cmbType.Text.Trim();

				if(strCDataType=="")
				{
					MessageBox.Show("数据类型不能为空!");
					return;
				}
		
				BengZhan.comReport.zedGraph.CmyPaintChart.paintChartAvgDep(strFrom,strTo,this.m_strZhanName ,strCDataType,this.zedGraphControl2);
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void monthStaticRepDep()
		{

		}

	private string m_strZhanName="";

		private void trvWell_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			if(this.trvWel.SelectedNode!=null)
			{
				this.m_strZhanName=this.trvWel.SelectedNode.Text;
			}
			if(this.trvWel.SelectedNode.Nodes.Count==0)
			{
				this.m_strSelNodeType="zhan";
				paintCmb();
				return;
			}
			if(this.trvWel.SelectedNode.Nodes[0].Nodes.Count==0)
			{
				this.m_strSelNodeType="dep";
				paintCmb();
				return;
			}
			this.m_strSelNodeType="";
			paintCmb();
			return;
		}

		private void paintCmb()
		{
			this.cmbType.Text="";
			if(this.m_xDocRep==null)
			{
				this.m_xDocRep=new XmlDocument();
				this.m_xDocRep.Load("repPrint.xml");
			}
			XmlNode xNode=this.m_xDocRep.DocumentElement.SelectSingleNode("./rep[@val='1']");

			switch(this.tabChart.SelectedIndex)
			{
				case 0:
					
					this.cmbType.Items.Clear();

					for(int i=0;i<xNode.ChildNodes.Count;i++)
					{
						string strType=xNode.ChildNodes[i].Attributes.GetNamedItem("headerText").Value.Trim();
						string strBChart=xNode.ChildNodes[i].Attributes.GetNamedItem("bChart").Value.Trim();
						if(strBChart.Trim()=="true")
						{
							string strBDep=xNode.ChildNodes[i].Attributes.GetNamedItem("bDep").Value.Trim();
							
							if(this.m_strSelNodeType!="dep")
							{
								this.cmbType.Items.Add(strType);
							}
							else
							{
								if(strBDep=="true")
								{
									this.cmbType.Items.Add(strType);
								}
							}						
						}
					}
					break;
				case 1:
					xNode=this.m_xDocRep.DocumentElement.SelectSingleNode("./rep[@val='2']");

					this.cmbType.Items.Clear();

					for(int i=0;i<xNode.ChildNodes.Count;i++)
					{
						string strType=xNode.ChildNodes[i].Attributes.GetNamedItem("headerText").Value.Trim();
						string strBChart=xNode.ChildNodes[i].Attributes.GetNamedItem("bChart").Value.Trim();
						if(strBChart.Trim()=="true")
						{
							string strBDep=xNode.ChildNodes[i].Attributes.GetNamedItem("bDep").Value.Trim();
							if(this.m_strSelNodeType=="dep")
							{
								if(strBDep=="true")
								{
									this.cmbType.Items.Add(strType);
								}
							}	
							else
							{
								this.cmbType.Items.Add(strType);
							}
						}
					}
					break;
			}

			if(this.m_strSelNodeType.Trim()!="")
			{
				string strZhanName=this.m_strZhanName.Substring(this.m_strZhanName.IndexOf("|")+1);
				this.tabChart.TabPages[0].Text=strZhanName+"明细图表";
				this.tabChart.TabPages[1].Text=strZhanName+"日统计图表";
				this.tabChart.TabPages[2].Text=strZhanName+"月统计图表";
			}		
		}

	    private crc16.CaptureScreen m_cs;

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

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
		  e.Graphics.DrawImage(this.m_cs.memoryImage,160,140);
		}

		private void tabChart_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.cmbType.Text="";
			if(this.m_xDocRep==null)
			{
				this.m_xDocRep=new XmlDocument();
				this.m_xDocRep.Load("repPrint.xml");
			}
			XmlNode xNode=this.m_xDocRep.DocumentElement.SelectSingleNode("./rep[@val='1']");

			
			switch(this.tabChart.SelectedIndex)
			{
				case 0:
					
					this.cmbType.Items.Clear();

					for(int i=0;i<xNode.ChildNodes.Count;i++)
					{
						string strType=xNode.ChildNodes[i].Attributes.GetNamedItem("headerText").Value.Trim();
						string strBChart=xNode.ChildNodes[i].Attributes.GetNamedItem("bChart").Value.Trim();
						if(strBChart.Trim()=="true")
						{
							string strBDep=xNode.ChildNodes[i].Attributes.GetNamedItem("bDep").Value.Trim();
							
							if(this.m_strSelNodeType!="dep")
							{
								this.cmbType.Items.Add(strType);
							}
							else
							{
								if(strBDep=="true")
								{
									this.cmbType.Items.Add(strType);
								}
							}						
						}
					}
					break;
				case 1:
					xNode=this.m_xDocRep.DocumentElement.SelectSingleNode("./rep[@val='2']");

					this.cmbType.Items.Clear();

					for(int i=0;i<xNode.ChildNodes.Count;i++)
					{
						string strType=xNode.ChildNodes[i].Attributes.GetNamedItem("headerText").Value.Trim();
						string strBChart=xNode.ChildNodes[i].Attributes.GetNamedItem("bChart").Value.Trim();
						if(strBChart.Trim()=="true")
						{
							string strBDep=xNode.ChildNodes[i].Attributes.GetNamedItem("bDep").Value.Trim();
							if(this.m_strSelNodeType=="dep")
							{
								if(strBDep=="true")
								{
									this.cmbType.Items.Add(strType);
								}
							}	
							else
							{
								this.cmbType.Items.Add(strType);
							}
						}
					}
					break;
			}
		}
		private void dayStaticRepDepMonth()
		{
			try
			{
				string strFrom=this.dtpFrom.Value.ToShortDateString();
				//strFrom=strFrom+" "+this.numStart.Value.ToString().Trim()+":00:00";
				string strTo=this.dtpTo.Value.ToShortDateString();
				//strTo=strTo+" "+this.numEnd.Value.ToString().Trim()+":00:00";				
				
				string strDepName=this.trvWel.SelectedNode.Text.Trim();

				string strCDataType=this.cmbType.Text.Trim();

				if(strCDataType=="")
				{
					MessageBox.Show("数据类型不能为空!");
					return;
				}
		
				BengZhan.comReport.zedGraph.CmyPaintChart.paintChartAvgMonthDep(strFrom,strTo,strDepName,strCDataType,this.zedGraphControl3);
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void printPreviewDialog1_Load(object sender, System.EventArgs e)
		{
		
		}

	
	}
}

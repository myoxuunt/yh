using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;

namespace CReportDll.comReport.newRep
{
	/// <summary>
	/// frmChart 的摘要说明。
	/// </summary>
	public class frmChart : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ComboBox cmbCountry;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TreeView trvWel;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.GroupBox groupBox4;
		private ZedGraph.ZedGraphControl zedGraphControl1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnHelp;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Button btnCer;
		private System.Windows.Forms.ComboBox cmbType;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox6;
		private ZedGraph.ZedGraphControl zedGraphControl2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpFrom1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmbType1;
		private System.Windows.Forms.Button btnCer1;
		private System.Windows.Forms.Button btnPrint1;
		private System.Windows.Forms.Button btnHelp1;
		private System.Windows.Forms.Button btnExit1;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.GroupBox groupBox8;
		private ZedGraph.ZedGraphControl zedGraphControl3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btnCer2;
		private System.Windows.Forms.Button btnPrint2;
		private System.Windows.Forms.Button btnHelp2;
		private System.Windows.Forms.Button btnExit2;
		private System.Windows.Forms.ComboBox cmbType2;
		private System.Windows.Forms.TabControl tabChart;
		private System.Windows.Forms.NumericUpDown numEnd;
		private System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.NumericUpDown numStart;
		private System.Windows.Forms.DateTimePicker dtpFrom;
		private System.Windows.Forms.DateTimePicker dtpTo1;
		private System.Windows.Forms.TextBox txtYearFrom;
		private System.Windows.Forms.TextBox txtYearTo;
		private System.Windows.Forms.NumericUpDown numTo;
		private System.Windows.Forms.NumericUpDown numFrom;
		private System.Windows.Forms.TextBox lblZhan;
		private System.Windows.Forms.TextBox txtZhan;
		private System.Windows.Forms.Label lblName;
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
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtZhan = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.cmbCountry = new System.Windows.Forms.ComboBox();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.lblZhan = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.trvWel = new System.Windows.Forms.TreeView();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnHelp = new System.Windows.Forms.Button();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnCer = new System.Windows.Forms.Button();
			this.cmbType = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.numEnd = new System.Windows.Forms.NumericUpDown();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.numStart = new System.Windows.Forms.NumericUpDown();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.btnExit1 = new System.Windows.Forms.Button();
			this.btnHelp1 = new System.Windows.Forms.Button();
			this.btnPrint1 = new System.Windows.Forms.Button();
			this.btnCer1 = new System.Windows.Forms.Button();
			this.cmbType1 = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dtpTo1 = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.dtpFrom1 = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.zedGraphControl3 = new ZedGraph.ZedGraphControl();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.txtYearTo = new System.Windows.Forms.TextBox();
			this.txtYearFrom = new System.Windows.Forms.TextBox();
			this.cmbType2 = new System.Windows.Forms.ComboBox();
			this.btnExit2 = new System.Windows.Forms.Button();
			this.btnHelp2 = new System.Windows.Forms.Button();
			this.btnPrint2 = new System.Windows.Forms.Button();
			this.btnCer2 = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.numTo = new System.Windows.Forms.NumericUpDown();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.numFrom = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.tabChart = new System.Windows.Forms.TabControl();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numEnd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numStart)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.groupBox7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numTo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numFrom)).BeginInit();
			this.tabChart.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtZhan);
			this.groupBox3.Controls.Add(this.lblName);
			this.groupBox3.Location = new System.Drawing.Point(4, 7);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(184, 48);
			this.groupBox3.TabIndex = 16;
			this.groupBox3.TabStop = false;
			// 
			// txtZhan
			// 
			this.txtZhan.Location = new System.Drawing.Point(72, 16);
			this.txtZhan.Name = "txtZhan";
			this.txtZhan.TabIndex = 3;
			this.txtZhan.Text = "";
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(4, 19);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(68, 14);
			this.lblName.TabIndex = 2;
			this.lblName.Text = "站点：";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbCountry
			// 
			this.cmbCountry.Location = new System.Drawing.Point(48, 56);
			this.cmbCountry.Name = "cmbCountry";
			this.cmbCountry.Size = new System.Drawing.Size(108, 20);
			this.cmbCountry.TabIndex = 3;
			this.cmbCountry.Visible = false;
			this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
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
			this.printPreviewDialog1.Location = new System.Drawing.Point(88, 88);
			this.printPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog1.Visible = false;
			// 
			// lblZhan
			// 
			this.lblZhan.Location = new System.Drawing.Point(12, 15);
			this.lblZhan.Name = "lblZhan";
			this.lblZhan.TabIndex = 12;
			this.lblZhan.Text = "";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.trvWel);
			this.groupBox1.Location = new System.Drawing.Point(4, 55);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(184, 592);
			this.groupBox1.TabIndex = 13;
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
			this.trvWel.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvWel_AfterSelect);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.groupBox4);
			this.tabPage1.Location = new System.Drawing.Point(4, 21);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(808, 615);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = " 明细图";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnExit);
			this.groupBox2.Controls.Add(this.btnHelp);
			this.groupBox2.Controls.Add(this.btnPrint);
			this.groupBox2.Controls.Add(this.btnCer);
			this.groupBox2.Controls.Add(this.cmbType);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.numEnd);
			this.groupBox2.Controls.Add(this.dtpTo);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.numStart);
			this.groupBox2.Controls.Add(this.dtpFrom);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(808, 52);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(632, 16);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(56, 24);
			this.btnExit.TabIndex = 25;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
			// 
			// btnHelp
			// 
			this.btnHelp.Location = new System.Drawing.Point(688, 17);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(56, 23);
			this.btnHelp.TabIndex = 24;
			this.btnHelp.Text = "帮助";
			this.btnHelp.Visible = false;
			this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(632, 17);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(56, 23);
			this.btnPrint.TabIndex = 23;
			this.btnPrint.Text = "打印";
			this.btnPrint.Visible = false;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// btnCer
			// 
			this.btnCer.Location = new System.Drawing.Point(576, 17);
			this.btnCer.Name = "btnCer";
			this.btnCer.Size = new System.Drawing.Size(56, 23);
			this.btnCer.TabIndex = 22;
			this.btnCer.Text = "确认";
			this.btnCer.Click += new System.EventHandler(this.btnCer_Click);
			// 
			// cmbType
			// 
			this.cmbType.Location = new System.Drawing.Point(496, 18);
			this.cmbType.Name = "cmbType";
			this.cmbType.Size = new System.Drawing.Size(80, 20);
			this.cmbType.TabIndex = 21;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(408, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 23);
			this.label4.TabIndex = 20;
			this.label4.Text = "时  数据类型：";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numEnd
			// 
			this.numEnd.Location = new System.Drawing.Point(376, 18);
			this.numEnd.Name = "numEnd";
			this.numEnd.Size = new System.Drawing.Size(32, 21);
			this.numEnd.TabIndex = 19;
			// 
			// dtpTo
			// 
			this.dtpTo.Location = new System.Drawing.Point(272, 18);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(104, 21);
			this.dtpTo.TabIndex = 18;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(232, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 23);
			this.label3.TabIndex = 17;
			this.label3.Text = "时 至";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numStart
			// 
			this.numStart.Location = new System.Drawing.Point(200, 18);
			this.numStart.Name = "numStart";
			this.numStart.Size = new System.Drawing.Size(32, 21);
			this.numStart.TabIndex = 16;
			// 
			// dtpFrom
			// 
			this.dtpFrom.Location = new System.Drawing.Point(88, 18);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.Size = new System.Drawing.Size(112, 21);
			this.dtpFrom.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 23);
			this.label1.TabIndex = 14;
			this.label1.Text = "时间范围：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.zedGraphControl1);
			this.groupBox4.Controls.Add(this.cmbCountry);
			this.groupBox4.Location = new System.Drawing.Point(0, 52);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(808, 572);
			this.groupBox4.TabIndex = 1;
			this.groupBox4.TabStop = false;
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
			this.zedGraphControl1.Location = new System.Drawing.Point(3, 17);
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
			this.zedGraphControl1.Size = new System.Drawing.Size(802, 552);
			this.zedGraphControl1.TabIndex = 0;
			this.zedGraphControl1.ZoomButtons = System.Windows.Forms.MouseButtons.Left;
			this.zedGraphControl1.ZoomButtons2 = System.Windows.Forms.MouseButtons.None;
			this.zedGraphControl1.ZoomModifierKeys = System.Windows.Forms.Keys.None;
			this.zedGraphControl1.ZoomModifierKeys2 = System.Windows.Forms.Keys.None;
			this.zedGraphControl1.ZoomStepFraction = 0.1;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupBox6);
			this.tabPage2.Controls.Add(this.groupBox5);
			this.tabPage2.Location = new System.Drawing.Point(4, 21);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(808, 615);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "日统计图";
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.zedGraphControl2);
			this.groupBox6.Location = new System.Drawing.Point(0, 54);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(808, 560);
			this.groupBox6.TabIndex = 1;
			this.groupBox6.TabStop = false;
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
			this.zedGraphControl2.Location = new System.Drawing.Point(3, 17);
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
			this.zedGraphControl2.Size = new System.Drawing.Size(802, 540);
			this.zedGraphControl2.TabIndex = 0;
			this.zedGraphControl2.ZoomButtons = System.Windows.Forms.MouseButtons.Left;
			this.zedGraphControl2.ZoomButtons2 = System.Windows.Forms.MouseButtons.None;
			this.zedGraphControl2.ZoomModifierKeys = System.Windows.Forms.Keys.None;
			this.zedGraphControl2.ZoomModifierKeys2 = System.Windows.Forms.Keys.None;
			this.zedGraphControl2.ZoomStepFraction = 0.1;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.btnExit1);
			this.groupBox5.Controls.Add(this.btnHelp1);
			this.groupBox5.Controls.Add(this.btnPrint1);
			this.groupBox5.Controls.Add(this.btnCer1);
			this.groupBox5.Controls.Add(this.cmbType1);
			this.groupBox5.Controls.Add(this.label7);
			this.groupBox5.Controls.Add(this.dtpTo1);
			this.groupBox5.Controls.Add(this.label6);
			this.groupBox5.Controls.Add(this.dtpFrom1);
			this.groupBox5.Controls.Add(this.label5);
			this.groupBox5.Location = new System.Drawing.Point(0, 0);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(808, 52);
			this.groupBox5.TabIndex = 0;
			this.groupBox5.TabStop = false;
			this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
			// 
			// btnExit1
			// 
			this.btnExit1.Location = new System.Drawing.Point(664, 18);
			this.btnExit1.Name = "btnExit1";
			this.btnExit1.Size = new System.Drawing.Size(56, 23);
			this.btnExit1.TabIndex = 9;
			this.btnExit1.Text = "退出";
			this.btnExit1.Click += new System.EventHandler(this.btnExit1_Click);
			// 
			// btnHelp1
			// 
			this.btnHelp1.Location = new System.Drawing.Point(608, 18);
			this.btnHelp1.Name = "btnHelp1";
			this.btnHelp1.Size = new System.Drawing.Size(56, 23);
			this.btnHelp1.TabIndex = 8;
			this.btnHelp1.Text = "帮助";
			this.btnHelp1.Click += new System.EventHandler(this.btnHelp1_Click);
			// 
			// btnPrint1
			// 
			this.btnPrint1.Location = new System.Drawing.Point(552, 18);
			this.btnPrint1.Name = "btnPrint1";
			this.btnPrint1.Size = new System.Drawing.Size(56, 23);
			this.btnPrint1.TabIndex = 7;
			this.btnPrint1.Text = "打印";
			this.btnPrint1.Click += new System.EventHandler(this.btnPrint1_Click);
			// 
			// btnCer1
			// 
			this.btnCer1.Location = new System.Drawing.Point(496, 18);
			this.btnCer1.Name = "btnCer1";
			this.btnCer1.Size = new System.Drawing.Size(56, 23);
			this.btnCer1.TabIndex = 6;
			this.btnCer1.Text = "确认";
			this.btnCer1.Click += new System.EventHandler(this.btnCer1_Click);
			// 
			// cmbType1
			// 
			this.cmbType1.Location = new System.Drawing.Point(408, 19);
			this.cmbType1.Name = "cmbType1";
			this.cmbType1.Size = new System.Drawing.Size(80, 20);
			this.cmbType1.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(336, 18);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 23);
			this.label7.TabIndex = 4;
			this.label7.Text = "数据类型：";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpTo1
			// 
			this.dtpTo1.Location = new System.Drawing.Point(224, 19);
			this.dtpTo1.Name = "dtpTo1";
			this.dtpTo1.Size = new System.Drawing.Size(104, 21);
			this.dtpTo1.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(200, 18);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(16, 23);
			this.label6.TabIndex = 2;
			this.label6.Text = "至";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dtpFrom1
			// 
			this.dtpFrom1.Location = new System.Drawing.Point(80, 19);
			this.dtpFrom1.Name = "dtpFrom1";
			this.dtpFrom1.Size = new System.Drawing.Size(112, 21);
			this.dtpFrom1.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 18);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "时间范围：";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.groupBox8);
			this.tabPage3.Controls.Add(this.groupBox7);
			this.tabPage3.Location = new System.Drawing.Point(4, 21);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(808, 615);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "月统计图";
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.zedGraphControl3);
			this.groupBox8.Location = new System.Drawing.Point(0, 54);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(808, 560);
			this.groupBox8.TabIndex = 1;
			this.groupBox8.TabStop = false;
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
			this.zedGraphControl3.Location = new System.Drawing.Point(3, 17);
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
			this.zedGraphControl3.Size = new System.Drawing.Size(802, 540);
			this.zedGraphControl3.TabIndex = 0;
			this.zedGraphControl3.ZoomButtons = System.Windows.Forms.MouseButtons.Left;
			this.zedGraphControl3.ZoomButtons2 = System.Windows.Forms.MouseButtons.None;
			this.zedGraphControl3.ZoomModifierKeys = System.Windows.Forms.Keys.None;
			this.zedGraphControl3.ZoomModifierKeys2 = System.Windows.Forms.Keys.None;
			this.zedGraphControl3.ZoomStepFraction = 0.1;
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.txtYearTo);
			this.groupBox7.Controls.Add(this.txtYearFrom);
			this.groupBox7.Controls.Add(this.cmbType2);
			this.groupBox7.Controls.Add(this.btnExit2);
			this.groupBox7.Controls.Add(this.btnHelp2);
			this.groupBox7.Controls.Add(this.btnPrint2);
			this.groupBox7.Controls.Add(this.btnCer2);
			this.groupBox7.Controls.Add(this.label12);
			this.groupBox7.Controls.Add(this.numTo);
			this.groupBox7.Controls.Add(this.label11);
			this.groupBox7.Controls.Add(this.label10);
			this.groupBox7.Controls.Add(this.label9);
			this.groupBox7.Controls.Add(this.numFrom);
			this.groupBox7.Controls.Add(this.label8);
			this.groupBox7.Location = new System.Drawing.Point(0, 0);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(808, 52);
			this.groupBox7.TabIndex = 0;
			this.groupBox7.TabStop = false;
			// 
			// txtYearTo
			// 
			this.txtYearTo.Location = new System.Drawing.Point(208, 18);
			this.txtYearTo.Name = "txtYearTo";
			this.txtYearTo.Size = new System.Drawing.Size(40, 21);
			this.txtYearTo.TabIndex = 15;
			this.txtYearTo.Text = "";
			// 
			// txtYearFrom
			// 
			this.txtYearFrom.Location = new System.Drawing.Point(80, 18);
			this.txtYearFrom.Name = "txtYearFrom";
			this.txtYearFrom.Size = new System.Drawing.Size(40, 21);
			this.txtYearFrom.TabIndex = 14;
			this.txtYearFrom.Text = "";
			// 
			// cmbType2
			// 
			this.cmbType2.Location = new System.Drawing.Point(400, 18);
			this.cmbType2.Name = "cmbType2";
			this.cmbType2.Size = new System.Drawing.Size(88, 20);
			this.cmbType2.TabIndex = 13;
			// 
			// btnExit2
			// 
			this.btnExit2.Location = new System.Drawing.Point(664, 18);
			this.btnExit2.Name = "btnExit2";
			this.btnExit2.Size = new System.Drawing.Size(56, 23);
			this.btnExit2.TabIndex = 12;
			this.btnExit2.Text = "退出";
			this.btnExit2.Click += new System.EventHandler(this.btnExit2_Click);
			// 
			// btnHelp2
			// 
			this.btnHelp2.Location = new System.Drawing.Point(608, 18);
			this.btnHelp2.Name = "btnHelp2";
			this.btnHelp2.Size = new System.Drawing.Size(56, 23);
			this.btnHelp2.TabIndex = 11;
			this.btnHelp2.Text = "帮助";
			this.btnHelp2.Click += new System.EventHandler(this.btnHelp2_Click);
			// 
			// btnPrint2
			// 
			this.btnPrint2.Location = new System.Drawing.Point(552, 18);
			this.btnPrint2.Name = "btnPrint2";
			this.btnPrint2.Size = new System.Drawing.Size(56, 23);
			this.btnPrint2.TabIndex = 10;
			this.btnPrint2.Text = "打印";
			this.btnPrint2.Click += new System.EventHandler(this.btnPrint2_Click);
			// 
			// btnCer2
			// 
			this.btnCer2.Location = new System.Drawing.Point(496, 18);
			this.btnCer2.Name = "btnCer2";
			this.btnCer2.Size = new System.Drawing.Size(56, 23);
			this.btnCer2.TabIndex = 9;
			this.btnCer2.Text = "确认";
			this.btnCer2.Click += new System.EventHandler(this.btnCer2_Click);
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(304, 18);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(96, 24);
			this.label12.TabIndex = 8;
			this.label12.Text = "月  数据类型：";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numTo
			// 
			this.numTo.Location = new System.Drawing.Point(272, 18);
			this.numTo.Name = "numTo";
			this.numTo.Size = new System.Drawing.Size(32, 21);
			this.numTo.TabIndex = 7;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(248, 18);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(24, 23);
			this.label11.TabIndex = 6;
			this.label11.Text = "年";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(120, 18);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(24, 23);
			this.label10.TabIndex = 4;
			this.label10.Text = "年";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(176, 18);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(32, 23);
			this.label9.TabIndex = 3;
			this.label9.Text = "月至";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numFrom
			// 
			this.numFrom.Location = new System.Drawing.Point(144, 18);
			this.numFrom.Name = "numFrom";
			this.numFrom.Size = new System.Drawing.Size(32, 21);
			this.numFrom.TabIndex = 2;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 18);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 23);
			this.label8.TabIndex = 0;
			this.label8.Text = "时间范围：";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tabChart
			// 
			this.tabChart.Controls.Add(this.tabPage1);
			this.tabChart.Controls.Add(this.tabPage2);
			this.tabChart.Controls.Add(this.tabPage3);
			this.tabChart.ItemSize = new System.Drawing.Size(54, 17);
			this.tabChart.Location = new System.Drawing.Point(192, 8);
			this.tabChart.Name = "tabChart";
			this.tabChart.SelectedIndex = 0;
			this.tabChart.Size = new System.Drawing.Size(816, 640);
			this.tabChart.TabIndex = 17;
			this.tabChart.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// frmChart
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(1008, 653);
			this.Controls.Add(this.tabChart);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.lblZhan);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmChart";
			this.Text = "流量图表";
			this.Load += new System.EventHandler(this.frmChart_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmChart_Paint);
			this.groupBox3.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numEnd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numStart)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numTo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numFrom)).EndInit();
			this.tabChart.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void tabChart_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		private void btnExit2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnExit1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnExit_Click_1(object sender, System.EventArgs e)
		{
			this.Close();
		}		

		#region"树形列表管理"

		private void frmChart_Load(object sender, System.EventArgs e)
		{
			BengZhan.tools.CPaintForm.paintCountry(this.cmbCountry);
			BengZhan.tools.CPaintForm.paintWell(this.cmbCountry.Text,this.trvWel);
			this.removeZhanCe(this.trvWel);

			paintType();

			this.zedGraphControl1.GraphPane.Title="明细图表";
			this.zedGraphControl1.GraphPane.XAxis.Title="时间";
			this.zedGraphControl1.GraphPane.YAxis.Title="流量";
			this.zedGraphControl2.GraphPane.Title="日统计图表";
			this.zedGraphControl2.GraphPane.XAxis.Title="日期";
			this.zedGraphControl2.GraphPane.YAxis.Title="流量"; 

			this.zedGraphControl3.GraphPane.Title="月统计图表";
			this.zedGraphControl3.GraphPane.XAxis.Title="月份";
			this.zedGraphControl3.GraphPane.YAxis.Title="流量";

			this.txtYearFrom.Text=System.DateTime.Now.Year.ToString();
			this.txtYearTo.Text=System.DateTime.Now.Year.ToString();

			this.numFrom.Maximum=12;
			this.numFrom.Minimum=0;

			this.numTo.Maximum=12;
			this.numTo.Minimum=0;

			this.numStart.Maximum=23;
			this.numStart.Minimum=0;
			this.numStart.Value=0;

			this.numEnd.Maximum=23;
			this.numEnd.Minimum=0;
			this.numEnd.Value=23;

			this.numFrom.Value=System.DateTime.Now.Month;
			this.numTo.Value=System.DateTime.Now.Month;
 

		}		

		private string m_strZhanName="";
		private string m_strSelNodeType="";
		private void paintSelectedWell()
		{
			try
			{
				if(this.trvWel.SelectedNode!=null)				
				{
					if(this.trvWel.SelectedNode.Nodes.Count==0)
					{
						if(trvWel.SelectedNode.Parent==null)
						{
							return;
						}
						if(this.trvWel.SelectedNode.Text.IndexOf("|")>=0)
						{
							string strWellName=this.trvWel.SelectedNode.Text.Substring(this.trvWel.SelectedNode.Text.IndexOf("|")+1);
							this.lblName.Text="站点：";
							this.txtZhan.Text=strWellName;
							return;
						}
						if(this.trvWel.SelectedNode.Parent!=null)
						{
							if(this.trvWel.SelectedNode.Parent.Text.IndexOf("操作员")>=0)
							{
								this.lblName.Text="操作员：";
								this.txtZhan.Text=this.trvWel.SelectedNode.Text.Trim();
								return;
							}
						}
						this.lblName.Text="管理处：";
						this.txtZhan.Text=this.trvWel.SelectedNode.Text.Trim();
						return;
					}
					else
					{
						if(this.trvWel.SelectedNode.Nodes[0].Text.IndexOf("|")>=0)
						{
							this.lblName.Text="管理处：";
							this.txtZhan.Text=this.trvWel.SelectedNode.Text;
							return;
						}
					}
				}
				
			
				this.lblName.Text="站点：";
				this.txtZhan.Text="";
								
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void trvWel_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			
			this.paintSelectedWell();

			if(this.trvWel.SelectedNode!=null)
			{
				this.m_strZhanName=this.trvWel.SelectedNode.Text;
			}
			if(this.trvWel.SelectedNode.Nodes.Count==0)
			{
				if(trvWel.SelectedNode.Parent==null)
				{
					return;
				}

				if(this.trvWel.SelectedNode.Text.IndexOf("|")>=0)
				{
					this.m_strSelNodeType="zhan";
				}				
				else
				{
					this.m_strSelNodeType="dep";
				}

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

		private void clearCmb()
		{
			this.cmbType.Items.Clear();
			this.cmbType1.Items.Clear();
			this.cmbType2.Items.Clear();
			this.cmbType.Text="";
			this.cmbType1.Text="";
			this.cmbType2.Text="";
		}

		private XmlDocument m_xDocRep;

		private void paintType()
		{
		   this.clearCmb();

			if(this.m_xDocRep==null)
			{
				this.m_xDocRep=new XmlDocument();
				this.m_xDocRep.Load("repPrint.xml");
			}

			//??????????????????????????????????????????

			XmlNode xNode=this.m_xDocRep.DocumentElement.SelectSingleNode("./rep[@val='1']");					
					
					for(int i=0;i<xNode.ChildNodes.Count;i++)
					{
						string strType=xNode.ChildNodes[i].Attributes.GetNamedItem("headerText").Value.Trim();
						string strBChart=xNode.ChildNodes[i].Attributes.GetNamedItem("bChart").Value.Trim();
						if(strBChart.Trim()=="true")
						{						
							this.cmbType.Items.Add(strType);												
						}
					}	
	
			xNode=this.m_xDocRep.DocumentElement.SelectSingleNode("./rep[@val='2']");					
					
			for(int i=0;i<xNode.ChildNodes.Count;i++)
			{
				string strType=xNode.ChildNodes[i].Attributes.GetNamedItem("headerText").Value.Trim();
				string strBChart=xNode.ChildNodes[i].Attributes.GetNamedItem("bChart").Value.Trim();
				if(strBChart.Trim()=="true")
				{						
					this.cmbType1.Items.Add(strType);												
				}
			}	
	
				
			xNode=this.m_xDocRep.DocumentElement.SelectSingleNode("./rep[@val='3']");					
					
			for(int i=0;i<xNode.ChildNodes.Count;i++)
			{
				string strType=xNode.ChildNodes[i].Attributes.GetNamedItem("headerText").Value.Trim();
				string strBChart=xNode.ChildNodes[i].Attributes.GetNamedItem("bChart").Value.Trim();
				if(strBChart.Trim()=="true")
				{						
					this.cmbType2.Items.Add(strType);												
				}
			}		


		 }

		private void paintCmb()
		{			
			if(this.m_strSelNodeType.Trim()!="")
			{
				string strZhanName=this.m_strZhanName.Substring(this.m_strZhanName.IndexOf("|")+1);						
			}		
		}

		private void cmbCountry_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			BengZhan.tools.CPaintForm.paintWell(this.cmbCountry.Text,this.trvWel);
		}

		#endregion

		#region"打印"

		crc16.CaptureScreen m_cs;

		private void btnPrint_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.tabChart.BackColor=Color.White;
				crc16.CaptureScreen cs=new crc16.CaptureScreen();
				this.m_cs =cs;
				cs.CaptureScreen(this,this.zedGraphControl1);
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
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}
		
		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			try
			{
				e.Graphics.DrawImage(this.m_cs.memoryImage,160,140);
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
			
		}
		#endregion

	
		#region"图表"

		#region"明细表"

		private void btnCer_Click(object sender, System.EventArgs e)
		{		
			switch(this.m_strSelNodeType)
			{
				case "zhan":
					detailRep();
					break;
				case "dep":
                    detailRepDep();
					break;
				default:
					MessageBox.Show("请选中要进行统计的监测站或单位!");
					break;
			}
		
		}
		//监测站明细
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
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		//单位明细
		private void detailRepDep()
		{
			try
			{
				return;
				
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}
		#endregion

		#region"日统计"

		private void btnCer1_Click(object sender, System.EventArgs e)
		{
			switch(this.m_strSelNodeType)
			{
				case "zhan":
					dayStaticRep();
					break;
				case "dep":
					dayStaticRepDep();
					break;
					default:
							MessageBox.Show("请选中要进行统计的监测站或单位!");
					break;

			}
			
		}

//监测站
		private void dayStaticRep()
		{
			try
			{
				string strFrom=this.dtpFrom1.Value.ToShortDateString();
				//strFrom=strFrom+" "+this.numStart.Value.ToString().Trim()+":00:00";
				string strTo=this.dtpTo1.Value.ToShortDateString();
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

				string strCDataType=this.cmbType1.Text.Trim();

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
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}
		//单位
		private void dayStaticRepDep()
		{
			try
			{
				string strFrom=this.dtpFrom1.Value.ToShortDateString();
				//strFrom=strFrom+" "+this.numStart.Value.ToString().Trim()+":00:00";
				string strTo=this.dtpTo1.Value.ToShortDateString();
				//strTo=strTo+" "+this.numEnd.Value.ToString().Trim()+":00:00";	

				string strCDataType=this.cmbType1.Text.Trim();

				if(strCDataType=="")
				{
					MessageBox.Show("数据类型不能为空!");
					return;
				}
		
				BengZhan.comReport.zedGraph.CmyPaintChart.paintChartAvgDep(strFrom,strTo,this.m_strZhanName ,strCDataType,this.zedGraphControl2);
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		#endregion	

		#region"月统计"

		private void btnCer2_Click(object sender, System.EventArgs e)
		{
			switch(this.m_strSelNodeType)
			{
				case "zhan":
					monthStaticRep();
					break;
				case "dep":
				dayStaticRepDepMonth();
					break;
				default:
					MessageBox.Show("请选中要进行统计的监测站或单位!");
					break;

			}
		}

		//单位月统计
		private void dayStaticRepDepMonth()
		{
			try
			{
				DateTime dtFrom;
				
				try
				{
					if(this.txtYearFrom.Text.Trim().Length!=4)
					{
						MessageBox.Show("查询起始年份填写有误，其长度应为4位！");
						return;
					}

					string strDtFrom=this.txtYearFrom.Text.Trim()+"-"+this.numFrom.Value.ToString().Trim()+"-1";
					
					dtFrom=DateTime.Parse(strDtFrom);
				}
				catch
				{
					MessageBox.Show("查询起始时间填写有误!");
					return;
				}

				if(this.txtYearTo.Text.Trim().Length!=4)
				{
					MessageBox.Show("查询截止年份填写有误！其长度应为4位！");
					return;
				}
				
				string strDtTo=this.txtYearTo.Text.Trim()+"-"+this.numTo.Value.ToString().Trim()+"-1";
				DateTime dtTo;

				try
				{
					dtTo=DateTime.Parse(strDtTo);
				}
				catch
				{
					MessageBox.Show("查询截止时间填写有误!");
					return;
				}				

				string strFrom=dtFrom.ToShortDateString();
				//strFrom=strFrom+" "+this.numStart.Value.ToString().Trim()+":00:00";
				string strTo=dtTo.ToShortDateString();
				//strTo=strTo+" "+this.numEnd.Value.ToString().Trim()+":00:00";	
				
				string strDepName=this.trvWel.SelectedNode.Text.Trim();

				string strCDataType=this.cmbType2.Text.Trim();

				if(strCDataType=="")
				{
					MessageBox.Show("数据类型不能为空!");
					return;
				}
		
				BengZhan.comReport.zedGraph.CmyPaintChart.paintChartAvgMonthDep(strFrom,strTo,strDepName,strCDataType,this.zedGraphControl3);
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

//监测站月统计
		private void monthStaticRep()
		{
			try
			{
				if(this.txtYearFrom.Text.Trim().Length!=4)
				{
					MessageBox.Show("查询起始年份填写有误，其长度应为4位！");
					return;
				}

				if(this.txtYearTo.Text.Trim().Length!=4)
				{
					MessageBox.Show("查询截止年份填写有误！其长度应为4位！");
					return;
				}

				DateTime dtFrom;
				
				try
				{
					string strDtFrom=this.txtYearFrom.Text.Trim()+"-"+this.numFrom.Value.ToString().Trim()+"-1";
					
					dtFrom=DateTime.Parse(strDtFrom);
				}
				catch
				{
					MessageBox.Show("查询起始时间填写有误!");
					return;
				}
				
				string strDtTo=this.txtYearTo.Text.Trim()+"-"+this.numTo.Value.ToString().Trim()+"-1";
				DateTime dtTo;

				try
				{
					dtTo=DateTime.Parse(strDtTo);
				}
				catch{
					MessageBox.Show("查询截止时间填写有误!");
					return;
				}				

				string strFrom=dtFrom.ToShortDateString();
				//strFrom=strFrom+" "+this.numStart.Value.ToString().Trim()+":00:00";
				string strTo=dtTo.ToShortDateString();
				//strTo=strTo+" "+this.numEnd.Value.ToString().Trim()+":00:00";	

				string strZhanInfo=this.trvWel.SelectedNode.Text.Trim();

				if(strZhanInfo.IndexOf("|")<0)
				{
					MessageBox.Show("请选中一个站点!");
					return;
				}

				string strCDataType=this.cmbType2.Text.Trim();

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
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		#endregion

		private void groupBox5_Enter(object sender, System.EventArgs e)
		{
		
		}

		#endregion

		private void btnPrint1_Click(object sender, System.EventArgs e)
		{
				try
		 {
			 this.tabChart.BackColor=Color.White;
			 crc16.CaptureScreen cs=new crc16.CaptureScreen();
			 this.m_cs =cs;
			 cs.CaptureScreen(this,this.zedGraphControl2);
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
			 cSaveErr.CSaveErr.msgboxErr(ex.ToString());
		 }
		
		}

		private void btnPrint2_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.tabChart.BackColor=Color.White;
				crc16.CaptureScreen cs=new crc16.CaptureScreen();
				this.m_cs =cs;
				cs.CaptureScreen(this,this.zedGraphControl3);
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
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void btnHelp_Click(object sender, System.EventArgs e)
		{
		Help.ShowHelp(this,"help.chm");
		}

		private void btnHelp1_Click(object sender, System.EventArgs e)
		{
		Help.ShowHelp(this,"help.chm");
		}

		private void btnHelp2_Click(object sender, System.EventArgs e)
		{
	Help.ShowHelp(this,"help.chm");	
		}

		private bool bPaint=false;

		private void frmChart_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{

			if(!this.bPaint)
			{
				this.tabChart.TabPages.RemoveAt(1);
				this.tabChart.TabPages.RemoveAt(1);
				this.bPaint=true;
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

	
		

		
	

	}
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Xml;

namespace CReportDll.comReport.newRep
{
	/// <summary>
	/// frmReport 的摘要说明。
	/// </summary>
	public class frmReport : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGrid dgPrint;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.DataGrid dataGrid3;
		private System.Windows.Forms.GroupBox grp1;
		private System.Windows.Forms.TreeView trvWel;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cmbCountry;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.NumericUpDown numEnd;
		private System.Windows.Forms.NumericUpDown numStart;
		private System.Windows.Forms.Button btnDis;
		private System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpFrom;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnCer1;
		private System.Windows.Forms.Button btnPrint1;
		private System.Windows.Forms.Button btnHelp1;
		private System.Windows.Forms.Button btnExit1;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lbl;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnCer2;
		private System.Windows.Forms.Button btnPrint2;
		private System.Windows.Forms.Button btnHelp2;
		private System.Windows.Forms.Button btnExit2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.NumericUpDown numTo;
		private System.Windows.Forms.NumericUpDown numFrom;
		private System.Windows.Forms.TextBox txtYearTo;
		private System.Windows.Forms.TextBox txtYearFrom;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DateTimePicker dtpTo1;
		private System.Windows.Forms.DateTimePicker dtpFrom1;
		private System.Windows.Forms.TextBox txtZhan;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Label lblWait;
		private System.Windows.Forms.Button button1;

		public string m_strWellNo="";

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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblWait = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.btnPrint = new System.Windows.Forms.Button();
			this.numEnd = new System.Windows.Forms.NumericUpDown();
			this.numStart = new System.Windows.Forms.NumericUpDown();
			this.btnDis = new System.Windows.Forms.Button();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.btnExit = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dgPrint = new System.Windows.Forms.DataGrid();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.cmbCountry = new System.Windows.Forms.ComboBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.btnExit1 = new System.Windows.Forms.Button();
			this.btnHelp1 = new System.Windows.Forms.Button();
			this.btnPrint1 = new System.Windows.Forms.Button();
			this.btnCer1 = new System.Windows.Forms.Button();
			this.dtpTo1 = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpFrom1 = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.dataGrid2 = new System.Windows.Forms.DataGrid();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.btnExit2 = new System.Windows.Forms.Button();
			this.btnHelp2 = new System.Windows.Forms.Button();
			this.btnPrint2 = new System.Windows.Forms.Button();
			this.btnCer2 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.numTo = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.txtYearTo = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.numFrom = new System.Windows.Forms.NumericUpDown();
			this.lbl = new System.Windows.Forms.Label();
			this.txtYearFrom = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.dataGrid3 = new System.Windows.Forms.DataGrid();
			this.grp1 = new System.Windows.Forms.GroupBox();
			this.trvWel = new System.Windows.Forms.TreeView();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtZhan = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.button1 = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numEnd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numStart)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgPrint)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
			this.tabPage3.SuspendLayout();
			this.groupBox7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numTo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numFrom)).BeginInit();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).BeginInit();
			this.grp1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(176, 8);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(840, 640);
			this.tabControl1.TabIndex = 16;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Controls.Add(this.groupBox3);
			this.tabPage1.Location = new System.Drawing.Point(4, 21);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(832, 615);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "明细表";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.lblWait);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.btnPrint);
			this.groupBox1.Controls.Add(this.numEnd);
			this.groupBox1.Controls.Add(this.numStart);
			this.groupBox1.Controls.Add(this.btnDis);
			this.groupBox1.Controls.Add(this.dtpTo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.dtpFrom);
			this.groupBox1.Controls.Add(this.btnExit);
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(832, 48);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			// 
			// lblWait
			// 
			this.lblWait.Location = new System.Drawing.Point(736, 16);
			this.lblWait.Name = "lblWait";
			this.lblWait.Size = new System.Drawing.Size(88, 23);
			this.lblWait.TabIndex = 13;
			this.lblWait.Text = "正在检索数据......";
			this.lblWait.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblWait.Visible = false;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(8, 16);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(64, 23);
			this.label10.TabIndex = 11;
			this.label10.Text = "时间范围:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(408, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(16, 23);
			this.label9.TabIndex = 10;
			this.label9.Text = "时";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(488, 15);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(56, 23);
			this.btnPrint.TabIndex = 8;
			this.btnPrint.Text = "打印";
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// numEnd
			// 
			this.numEnd.Location = new System.Drawing.Point(376, 16);
			this.numEnd.Maximum = new System.Decimal(new int[] {
																   12,
																   0,
																   0,
																   0});
			this.numEnd.Minimum = new System.Decimal(new int[] {
																   1,
																   0,
																   0,
																   0});
			this.numEnd.Name = "numEnd";
			this.numEnd.Size = new System.Drawing.Size(32, 21);
			this.numEnd.TabIndex = 7;
			this.numEnd.Value = new System.Decimal(new int[] {
																 8,
																 0,
																 0,
																 0});
			// 
			// numStart
			// 
			this.numStart.Location = new System.Drawing.Point(184, 16);
			this.numStart.Maximum = new System.Decimal(new int[] {
																	 12,
																	 0,
																	 0,
																	 0});
			this.numStart.Minimum = new System.Decimal(new int[] {
																	 1,
																	 0,
																	 0,
																	 0});
			this.numStart.Name = "numStart";
			this.numStart.Size = new System.Drawing.Size(32, 21);
			this.numStart.TabIndex = 6;
			this.numStart.Value = new System.Decimal(new int[] {
																   8,
																   0,
																   0,
																   0});
			// 
			// btnDis
			// 
			this.btnDis.Location = new System.Drawing.Point(432, 15);
			this.btnDis.Name = "btnDis";
			this.btnDis.Size = new System.Drawing.Size(56, 23);
			this.btnDis.TabIndex = 3;
			this.btnDis.Text = "确定";
			this.btnDis.Click += new System.EventHandler(this.btnDis_Click);
			// 
			// dtpTo
			// 
			this.dtpTo.Location = new System.Drawing.Point(264, 16);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(112, 21);
			this.dtpTo.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(216, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "时至：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpFrom
			// 
			this.dtpFrom.Location = new System.Drawing.Point(72, 16);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.Size = new System.Drawing.Size(112, 21);
			this.dtpFrom.TabIndex = 0;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(600, 15);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(56, 23);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dgPrint);
			this.groupBox3.Controls.Add(this.dataGrid1);
			this.groupBox3.Controls.Add(this.cmbCountry);
			this.groupBox3.Location = new System.Drawing.Point(0, 48);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(832, 568);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			// 
			// dgPrint
			// 
			this.dgPrint.DataMember = "";
			this.dgPrint.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgPrint.Location = new System.Drawing.Point(48, 152);
			this.dgPrint.Name = "dgPrint";
			this.dgPrint.TabIndex = 1;
			this.dgPrint.Visible = false;
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(3, 17);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(826, 548);
			this.dataGrid1.TabIndex = 0;
			// 
			// cmbCountry
			// 
			this.cmbCountry.Location = new System.Drawing.Point(48, 64);
			this.cmbCountry.Name = "cmbCountry";
			this.cmbCountry.Size = new System.Drawing.Size(96, 20);
			this.cmbCountry.TabIndex = 1;
			this.cmbCountry.Visible = false;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupBox6);
			this.tabPage2.Controls.Add(this.groupBox4);
			this.tabPage2.Location = new System.Drawing.Point(4, 21);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(832, 615);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "日统计表";
			this.tabPage2.Visible = false;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.btnExit1);
			this.groupBox6.Controls.Add(this.btnHelp1);
			this.groupBox6.Controls.Add(this.btnPrint1);
			this.groupBox6.Controls.Add(this.btnCer1);
			this.groupBox6.Controls.Add(this.dtpTo1);
			this.groupBox6.Controls.Add(this.label4);
			this.groupBox6.Controls.Add(this.dtpFrom1);
			this.groupBox6.Controls.Add(this.label3);
			this.groupBox6.Location = new System.Drawing.Point(0, 0);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(832, 48);
			this.groupBox6.TabIndex = 1;
			this.groupBox6.TabStop = false;
			// 
			// btnExit1
			// 
			this.btnExit1.Location = new System.Drawing.Point(528, 15);
			this.btnExit1.Name = "btnExit1";
			this.btnExit1.Size = new System.Drawing.Size(56, 23);
			this.btnExit1.TabIndex = 7;
			this.btnExit1.Text = "退出";
			this.btnExit1.Click += new System.EventHandler(this.btnExit1_Click_1);
			// 
			// btnHelp1
			// 
			this.btnHelp1.Location = new System.Drawing.Point(472, 15);
			this.btnHelp1.Name = "btnHelp1";
			this.btnHelp1.Size = new System.Drawing.Size(56, 23);
			this.btnHelp1.TabIndex = 6;
			this.btnHelp1.Text = "帮助";
			this.btnHelp1.Click += new System.EventHandler(this.btnHelp1_Click);
			// 
			// btnPrint1
			// 
			this.btnPrint1.Location = new System.Drawing.Point(416, 15);
			this.btnPrint1.Name = "btnPrint1";
			this.btnPrint1.Size = new System.Drawing.Size(56, 23);
			this.btnPrint1.TabIndex = 5;
			this.btnPrint1.Text = "打印";
			this.btnPrint1.Click += new System.EventHandler(this.btnPrint1_Click);
			// 
			// btnCer1
			// 
			this.btnCer1.Location = new System.Drawing.Point(360, 15);
			this.btnCer1.Name = "btnCer1";
			this.btnCer1.Size = new System.Drawing.Size(56, 23);
			this.btnCer1.TabIndex = 4;
			this.btnCer1.Text = "确认";
			this.btnCer1.Click += new System.EventHandler(this.btnCer1_Click);
			// 
			// dtpTo1
			// 
			this.dtpTo1.Location = new System.Drawing.Point(232, 16);
			this.dtpTo1.Name = "dtpTo1";
			this.dtpTo1.Size = new System.Drawing.Size(112, 21);
			this.dtpTo1.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(208, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(16, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "至";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpFrom1
			// 
			this.dtpFrom1.Location = new System.Drawing.Point(80, 16);
			this.dtpFrom1.Name = "dtpFrom1";
			this.dtpFrom1.Size = new System.Drawing.Size(112, 21);
			this.dtpFrom1.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "时间范围:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.dataGrid2);
			this.groupBox4.Location = new System.Drawing.Point(0, 48);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(832, 568);
			this.groupBox4.TabIndex = 0;
			this.groupBox4.TabStop = false;
			// 
			// dataGrid2
			// 
			this.dataGrid2.DataMember = "";
			this.dataGrid2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid2.Location = new System.Drawing.Point(3, 17);
			this.dataGrid2.Name = "dataGrid2";
			this.dataGrid2.Size = new System.Drawing.Size(826, 548);
			this.dataGrid2.TabIndex = 0;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.groupBox7);
			this.tabPage3.Controls.Add(this.groupBox5);
			this.tabPage3.Location = new System.Drawing.Point(4, 21);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(832, 615);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "月统计表";
			this.tabPage3.Visible = false;
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.btnExit2);
			this.groupBox7.Controls.Add(this.btnHelp2);
			this.groupBox7.Controls.Add(this.btnPrint2);
			this.groupBox7.Controls.Add(this.btnCer2);
			this.groupBox7.Controls.Add(this.label8);
			this.groupBox7.Controls.Add(this.numTo);
			this.groupBox7.Controls.Add(this.label7);
			this.groupBox7.Controls.Add(this.txtYearTo);
			this.groupBox7.Controls.Add(this.label6);
			this.groupBox7.Controls.Add(this.numFrom);
			this.groupBox7.Controls.Add(this.lbl);
			this.groupBox7.Controls.Add(this.txtYearFrom);
			this.groupBox7.Controls.Add(this.label5);
			this.groupBox7.Location = new System.Drawing.Point(0, 0);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(832, 48);
			this.groupBox7.TabIndex = 1;
			this.groupBox7.TabStop = false;
			this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
			// 
			// btnExit2
			// 
			this.btnExit2.Location = new System.Drawing.Point(512, 16);
			this.btnExit2.Name = "btnExit2";
			this.btnExit2.Size = new System.Drawing.Size(56, 23);
			this.btnExit2.TabIndex = 12;
			this.btnExit2.Text = "退出";
			this.btnExit2.Click += new System.EventHandler(this.btnExit2_Click);
			// 
			// btnHelp2
			// 
			this.btnHelp2.Location = new System.Drawing.Point(456, 16);
			this.btnHelp2.Name = "btnHelp2";
			this.btnHelp2.Size = new System.Drawing.Size(56, 23);
			this.btnHelp2.TabIndex = 11;
			this.btnHelp2.Text = "帮助";
			this.btnHelp2.Click += new System.EventHandler(this.btnHelp2_Click);
			// 
			// btnPrint2
			// 
			this.btnPrint2.Location = new System.Drawing.Point(400, 16);
			this.btnPrint2.Name = "btnPrint2";
			this.btnPrint2.Size = new System.Drawing.Size(56, 23);
			this.btnPrint2.TabIndex = 10;
			this.btnPrint2.Text = "打印";
			this.btnPrint2.Click += new System.EventHandler(this.btnPrint2_Click);
			// 
			// btnCer2
			// 
			this.btnCer2.Location = new System.Drawing.Point(344, 16);
			this.btnCer2.Name = "btnCer2";
			this.btnCer2.Size = new System.Drawing.Size(56, 23);
			this.btnCer2.TabIndex = 9;
			this.btnCer2.Text = "确认";
			this.btnCer2.Click += new System.EventHandler(this.btnCer2_Click);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(320, 17);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(16, 23);
			this.label8.TabIndex = 8;
			this.label8.Text = "月";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numTo
			// 
			this.numTo.Location = new System.Drawing.Point(288, 17);
			this.numTo.Maximum = new System.Decimal(new int[] {
																  12,
																  0,
																  0,
																  0});
			this.numTo.Minimum = new System.Decimal(new int[] {
																  1,
																  0,
																  0,
																  0});
			this.numTo.Name = "numTo";
			this.numTo.Size = new System.Drawing.Size(32, 21);
			this.numTo.TabIndex = 7;
			this.numTo.Value = new System.Decimal(new int[] {
																1,
																0,
																0,
																0});
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(264, 17);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(16, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "年";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtYearTo
			// 
			this.txtYearTo.Location = new System.Drawing.Point(216, 16);
			this.txtYearTo.Name = "txtYearTo";
			this.txtYearTo.Size = new System.Drawing.Size(40, 21);
			this.txtYearTo.TabIndex = 5;
			this.txtYearTo.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(176, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 23);
			this.label6.TabIndex = 4;
			this.label6.Text = "月至";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numFrom
			// 
			this.numFrom.Location = new System.Drawing.Point(136, 16);
			this.numFrom.Maximum = new System.Decimal(new int[] {
																	12,
																	0,
																	0,
																	0});
			this.numFrom.Minimum = new System.Decimal(new int[] {
																	1,
																	0,
																	0,
																	0});
			this.numFrom.Name = "numFrom";
			this.numFrom.Size = new System.Drawing.Size(32, 21);
			this.numFrom.TabIndex = 3;
			this.numFrom.Value = new System.Decimal(new int[] {
																  1,
																  0,
																  0,
																  0});
			// 
			// lbl
			// 
			this.lbl.Location = new System.Drawing.Point(112, 16);
			this.lbl.Name = "lbl";
			this.lbl.Size = new System.Drawing.Size(16, 23);
			this.lbl.TabIndex = 2;
			this.lbl.Text = "年";
			this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtYearFrom
			// 
			this.txtYearFrom.Location = new System.Drawing.Point(72, 16);
			this.txtYearFrom.Name = "txtYearFrom";
			this.txtYearFrom.Size = new System.Drawing.Size(40, 21);
			this.txtYearFrom.TabIndex = 1;
			this.txtYearFrom.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "时间范围:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.dataGrid3);
			this.groupBox5.Location = new System.Drawing.Point(0, 48);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(832, 568);
			this.groupBox5.TabIndex = 0;
			this.groupBox5.TabStop = false;
			// 
			// dataGrid3
			// 
			this.dataGrid3.DataMember = "";
			this.dataGrid3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGrid3.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid3.Location = new System.Drawing.Point(3, 17);
			this.dataGrid3.Name = "dataGrid3";
			this.dataGrid3.Size = new System.Drawing.Size(826, 548);
			this.dataGrid3.TabIndex = 0;
			// 
			// grp1
			// 
			this.grp1.Controls.Add(this.trvWel);
			this.grp1.Location = new System.Drawing.Point(0, 51);
			this.grp1.Name = "grp1";
			this.grp1.Size = new System.Drawing.Size(176, 596);
			this.grp1.TabIndex = 13;
			this.grp1.TabStop = false;
			// 
			// trvWel
			// 
			this.trvWel.ImageIndex = -1;
			this.trvWel.Location = new System.Drawing.Point(8, 16);
			this.trvWel.Name = "trvWel";
			this.trvWel.SelectedImageIndex = -1;
			this.trvWel.Size = new System.Drawing.Size(160, 576);
			this.trvWel.TabIndex = 0;
			this.trvWel.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvWel_AfterSelect);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtZhan);
			this.groupBox2.Controls.Add(this.lblName);
			this.groupBox2.Location = new System.Drawing.Point(0, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(176, 48);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			// 
			// txtZhan
			// 
			this.txtZhan.Location = new System.Drawing.Point(72, 16);
			this.txtZhan.Name = "txtZhan";
			this.txtZhan.Size = new System.Drawing.Size(96, 21);
			this.txtZhan.TabIndex = 1;
			this.txtZhan.Text = "";
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(8, 19);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(64, 14);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "站点：";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(544, 15);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(56, 23);
			this.button1.TabIndex = 14;
			this.button1.Text = "删除";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmReport
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(1016, 654);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.grp1);
			this.Name = "frmReport";
			this.Text = "监测站流量统计表";
			this.Load += new System.EventHandler(this.frmReport_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmReport_Paint);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numEnd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numStart)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgPrint)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numTo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numFrom)).EndInit();
			this.groupBox5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).EndInit();
			this.grp1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion		

		#region"界面管理"

		string m_strDtFrom="";
		string m_strDtTo="";

		#region"树形管理"

		private string m_strZhanName="";
		private string m_strSelNodeType="";
		private void paintSelectedWell()
		{
			try
			{
				if(this.trvWel.SelectedNode!=null)				
				{

					if(this.trvWel.SelectedNode.Parent==null)
					{
						if(this.trvWel.SelectedNode.Text.IndexOf("操作员")<0)
						{
							this.lblName.Text="管理局：";
							this.txtZhan.Text=this.trvWel.SelectedNode.Text.Trim();
							return;
						}
					}

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
							else
							{
								
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
			if(this.trvWel.SelectedNode.Parent==null)
			{
				if(this.trvWel.SelectedNode.Text.IndexOf("操作员")<0)
				{
					this.m_strSelNodeType="country";
					return;
				}
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
				return;
			}
			if(this.trvWel.SelectedNode.Nodes[0].Nodes.Count==0)
			{
				this.m_strSelNodeType="dep";			
				return;
			}
			this.m_strSelNodeType="";
			return;			
		}
		#endregion

		XmlDocument m_xDocPrint;
		
		private void clearBlankRow(DataTable dt)
		{
			if(dt.Rows.Count==1)
			{
				return;
			}
			for(int i=0;i<dt.Rows.Count;i++)
			{
				bool bDel=true;
				for(int j=0;j<dt.Columns.Count;j++)
				{
					if(dt.Rows[i][j]==null)
					{						
						continue;
					}
					if(dt.Rows[i][j].ToString().Trim()=="")
					{
						continue;
					}
					bDel=false;
				}
				if(bDel)
				{
					dt.Rows.RemoveAt(i);
					i--;
				}
			}
		}

		
		private void btnPrint_Click(object sender, System.EventArgs e)
		{		
			this.printDetail();
		}

		private void btnExit1_Click(object sender, System.EventArgs e)
		{
		   this.Close();
		}

		private void btnExit2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnExit1_Click_1(object sender, System.EventArgs e)
		{
			this.Close();
		}
		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmReport_Load(object sender, System.EventArgs e)
		{

			BengZhan.tools.CPaintForm.paintCountry(this.cmbCountry);
			BengZhan.tools.CPaintForm.paintWell(this.cmbCountry.Text,this.trvWel);

			this.removeZhanCe(this.trvWel);

			this.txtYearFrom.Text=System.DateTime.Now.Year.ToString();
			this.txtYearTo.Text=System.DateTime.Now.Year.ToString();

			this.numFrom.Maximum=12;
			this.numFrom.Minimum=1;

			this.numTo.Maximum=12;
			this.numTo.Minimum=1;

			this.numStart.Maximum=23;
			this.numStart.Minimum=0;

			this.numStart.Value=0;

			this.numEnd.Maximum=23;
			this.numEnd.Minimum=0;

			this.numEnd.Value=23;

			this.numFrom.Value=System.DateTime.Now.Month;
			this.numTo.Value=System.DateTime.Now.Month;

			this.paintGrid();

			paintOneLine();

			this.txtYearFrom.Text=System.DateTime.Now.Year.ToString();
			this.txtYearTo.Text=System.DateTime.Now.Year.ToString();
			this.numFrom.Value=int.Parse(System.DateTime.Now.Month.ToString());
			this.numTo.Value=int.Parse(System.DateTime.Now.Month.ToString());

			iniContMenu();

			if(this.m_strWellNo.Trim()!="")
			{
				string strSql=string.Format("select wellName from tbWell where wellNo='{0}'",this.m_strWellNo.Trim());
				string strWellName="";
				strWellName=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();
				this.lblName.Text="站点：";
				this.m_strSelNodeType="zhan";
				this.txtZhan.Text=strWellName;
				this.btnDis_Click(null,null);
			}

			this.paintType();

		
		}

		private void paintType()
		{

			
		}

		public void clearRow(DataTable dt)
		{
			if(dt==null)
			{
				return;
			}
			for(int i=0;i<dt.Rows.Count;i++)
			{
				bool bDel=true;
				for(int j=0;j<dt.Columns.Count;j++)
				{
					if(dt.Rows[i][j].ToString().Trim()!="")
					{
						bDel=false;
					}
				}
				if(bDel)
				{
					dt.Rows.RemoveAt(i);
					i--;
				}
			}
		}

		private void paintOneLine()
		{
			DataTable dt=(DataTable)this.dataGrid1.DataSource;
			this.clearRow(dt);

			if(this.tabControl1.SelectedIndex==0)
			{
				if(dt!=null)
				{
					DataRow dr=dt.NewRow();
					for(int i=0;i<dt.Columns.Count;i++)
					{
						dr[i]="";
					}
					dt.Rows.Add(dr);
				}

			}
			
			
			dt=(DataTable)this.dataGrid2.DataSource;
			this.clearRow(dt);

			if(this.tabControl1.SelectedIndex==1)
			{
				if(dt!=null)
				{
					DataRow dr=dt.NewRow();
					for(int i=0;i<dt.Columns.Count;i++)
					{
						dr[i]="";
					}
					dt.Rows.Add(dr);
				}
			}	
	
			dt=(DataTable)this.dataGrid3.DataSource;
			this.clearRow(dt);

			if(this.tabControl1.SelectedIndex==2)
			{
				if(dt!=null)
				{
					DataRow dr=dt.NewRow();
					for(int i=0;i<dt.Columns.Count;i++)
					{
						dr[i]="";
					}
					dt.Rows.Add(dr);
				}

			}		
		}

	private XmlDocument m_xDocRep=null;
		private bool paintGrid()
		{
			try
			{
				if(this.m_xDocRep==null)
				{
					this.m_xDocRep=new XmlDocument();
					this.m_xDocRep.Load("report.xml");
				}

				XmlNode xNodeRep=this.m_xDocRep.DocumentElement.SelectSingleNode("./report[@name='tb1']");

				string strSql=xNodeRep.Attributes.GetNamedItem("sql").Value.Trim();

				DataTable dt=new DataTable();

				//BengZhan.CDBConnection.getDataTable(ref dt,strSql,"tb1");

				DataGridTableStyle dgts=new DataGridTableStyle();
				
				for(int i=0;i<xNodeRep.ChildNodes.Count;i++)
				{

					DataGridColoredTextBoxColumn dgtb;
					XmlNode xNodeHeader=xNodeRep.ChildNodes[i];
					string strText=xNodeHeader.Attributes.GetNamedItem("text").Value.Trim();
					string strField=xNodeHeader.Attributes.GetNamedItem("field").Value.Trim();
					string strWidth=xNodeHeader.Attributes.GetNamedItem("width").Value.Trim();

					dgtb=new DataGridColoredTextBoxColumn();
					dgtb.HeaderText=strText;
					dgtb.MappingName=strField;

					dt.Columns.Add(strField);

					int iWidth=int.Parse(strWidth);
					dgtb.Width=iWidth;

					dgts.GridColumnStyles.Add(dgtb);
					
				}		
			
				this.dataGrid1.TableStyles.Clear();
				this.dataGrid1.TableStyles.Add(dgts);

				dgts.AllowSorting=false;
				this.dataGrid1.AllowSorting=false;

				this.dataGrid1.DataSource=dt;

				this.dataGrid1.ReadOnly=true;

				this.dataGrid1.CaptionText="明细表";
				
				xNodeRep=this.m_xDocRep.DocumentElement.SelectSingleNode("./report[@name='tb2']");
				dgts=new DataGridTableStyle();	
				dt=new DataTable();
				for(int i=0;i<xNodeRep.ChildNodes.Count;i++)
				{

					DataGridColoredTextBoxColumn dgtb;
					XmlNode xNodeHeader=xNodeRep.ChildNodes[i];
					string strText=xNodeHeader.Attributes.GetNamedItem("text").Value.Trim();
					string strField=xNodeHeader.Attributes.GetNamedItem("field").Value.Trim();
					string strWidth=xNodeHeader.Attributes.GetNamedItem("width").Value.Trim();

					dgtb=new DataGridColoredTextBoxColumn();
					dgtb.HeaderText=strText;
					dgtb.MappingName=strField;

					dt.Columns.Add(strField);

					int iWidth=int.Parse(strWidth);
					dgtb.Width=iWidth;

					dgts.GridColumnStyles.Add(dgtb);
					
				}		

				this.dataGrid2.TableStyles.Clear();
				this.dataGrid2.TableStyles.Add(dgts);
				this.dataGrid2.DataSource=dt;
				this.dataGrid2.CaptionText="日统计表";
				this.dataGrid2.ReadOnly=true;

				xNodeRep=this.m_xDocRep.DocumentElement.SelectSingleNode("./report[@name='tb3']");
				dgts=new DataGridTableStyle();	
				dt=new DataTable();

				for(int i=0;i<xNodeRep.ChildNodes.Count;i++)
				{
					DataGridColoredTextBoxColumn dgtb;
					XmlNode xNodeHeader=xNodeRep.ChildNodes[i];
					string strText=xNodeHeader.Attributes.GetNamedItem("text").Value.Trim();
					string strField=xNodeHeader.Attributes.GetNamedItem("field").Value.Trim();
					string strWidth=xNodeHeader.Attributes.GetNamedItem("width").Value.Trim();

					dgtb=new DataGridColoredTextBoxColumn();
					dgtb.HeaderText=strText;
					dgtb.MappingName=strField;

					dt.Columns.Add(strField);

					int iWidth=int.Parse(strWidth);
					dgtb.Width=iWidth;

					dgts.GridColumnStyles.Add(dgtb);
					
				}		

				this.dataGrid3.TableStyles.Clear();
				this.dataGrid3.TableStyles.Add(dgts);
				this.dataGrid3.DataSource=dt;
				this.dataGrid3.CaptionText="月统计表";
				this.dataGrid3.ReadOnly=true;

				///this.dataGrid3.CaptionText="月统计表";				
				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}

		private void btnPrint1_Click(object sender, System.EventArgs e)
		{
			this.printDay();
		}	
	
		public bool bDelNull=true;

		//明细显示
		private void btnDis_Click(object sender, System.EventArgs e)
		{	
		
			this.Cursor=Cursors.WaitCursor;
			this.start();

			switch(this.m_strSelNodeType)
			{
				case "zhan":
					//监测站明细
					this.detailRep();
					break;
				case "dep":
					//单位明细
                    detailRepDep();
					break;
				case "country":
					//乡镇明细
					this.detailRepCountry();
					break;
				default:
					if(this.trvWel.SelectedNode!=null)
					{
						break;
					}
					MessageBox.Show("请选中要进行统计的监测站或单位!");
					break;
			}	

			DataTable dt=(DataTable)this.dataGrid1.DataSource;

			if(this.bDelNull)
			{
				this.clearNullDr(ref dt);				
			}

			dt=(DataTable)this.dataGrid1.DataSource;

			this.addSumRow(ref dt);
	
			this.paintOneLine();
			this.Cursor=Cursors.Default;
			this.end();

		}

		private void clearNullDr(ref DataTable dt)
		{
			try
			{
				
				for(int i=0;i<dt.Rows.Count;i++)
				{

					bool bNull=true;

					for(int j=0;j<dt.Columns.Count;j++)
					{
						if(dt.Columns[j].ColumnName.Trim()!="wellName")
						{
							if(dt.Rows[i][j]==null)
							{
								continue;
							}
							if(dt.Rows[i][j].ToString().Trim()=="")							
							{
								continue;
							}
							bNull=false;
						}
					}

					if(bNull)					
					{
						dt.Rows.RemoveAt(i);
						i--;
					}
				}
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}


		//日统计
		private void btnCer1_Click(object sender, System.EventArgs e)
		{
			switch(this.m_strSelNodeType)			
			{
				case "zhan":
					this.dayStaticRep();
					break;
				case "dep":
					this.dayStaticRepDep();
					break;
				default:
					if(this.trvWel.SelectedNode!=null)
					{
						this.dayStaticRepCountry();
						break;
					}
	MessageBox.Show("请选中要进行统计的监测站或单位!");
					break;

			}
			DataTable dt=(DataTable)this.dataGrid2.DataSource;
			this.addSumRow2(ref dt);
			this.paintOneLine();
		}

		//月统计
		private void btnCer2_Click(object sender, System.EventArgs e)
		{	
			switch(this.m_strSelNodeType)
			{
				case "zhan":
					this.monthStaticRep();
					break;
				case "dep":
					this.monthStaticRepDep();
					break;
				default:
					if(this.trvWel.SelectedNode!=null)
					{
						this.monthStaticRepCountry();
						break;
					}
MessageBox.Show("请选中要进行统计的监测站或单位!");

					break;
			}
			DataTable dt=(DataTable)this.dataGrid3.DataSource;
			this.addSumRow2(ref dt);
			this.paintOneLine();
		}


		private void btnPrint2_Click(object sender, System.EventArgs e)
		{	
			this.printMonth();
		}		

		private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{

					if(this.tabControl1.SelectedIndex!=0)
					{
						this.tabControl1.SelectedIndex=0;
					}

				this.paintOneLine();
				//this.dataGrid3.CaptionText="月统计表";
				//this.dataGrid2.CaptionText="日统计表";
				//this.dataGrid1.CaptionText="明细表";
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}	
		}		
		
		#endregion

		#region"报表"

		#region"明细表"

		//监测站明细表
		private void detailRep()
		{
			try
			{
				string strFrom=this.dtpFrom.Value.ToShortDateString();
				strFrom=strFrom+" "+this.numStart.Value.ToString().Trim()+":00:00";
				string strTo=this.dtpTo.Value.ToShortDateString();
				strTo=strTo+" "+this.numEnd.Value.ToString().Trim()+":00:00";

				string strZhanName=this.txtZhan.Text.Trim();

				string strSql=string.Format("select wellNo from tbWell where wellName='{0}'",strZhanName);
				string strZhanNo=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();							

				DataTable dtDetail=new DataTable();

				if(BengZhan.comReport.CReports.getDtDetailReport(strZhanNo,strFrom,strTo,ref dtDetail)==false)
				{
					return;
				}

				DataTable dt=(DataTable)this.dataGrid1.DataSource;
		
				dt.Rows.Clear();
						
				for(int i=0;i<dtDetail.Rows.Count;i++)
				{
					DataRow dr=dt.NewRow();
	
					
					
					for(int j=0;j<dt.Columns.Count;j++)
					{
						string strColName=dt.Columns[j].ColumnName;
					
						dr[strColName]=dtDetail.Rows[i][strColName].ToString();						
					}

					dt.Rows.Add(dr);
				}

				string strCapText=string.Format("监测站：{0}    时间范围：{1}至{2}    流量明细表",strZhanName,strFrom,strTo);
				this.dataGrid1.CaptionText=strCapText;
				this.m_strDtFrom=strFrom;
				this.m_strDtTo=strTo;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		public void detailRepDep(ref DataTable dtRepDep,string strFrom,string strTo,string strDepName)
		{
			try
			{  
				DateTime dtTo=DateTime.Parse(strTo);
				dtTo=dtTo.AddMinutes(1);
				strTo=dtTo.ToString();
             
				string strSql=string.Format("select wellNo from tbWell where depName='{0}' order by wellNo",strDepName);       
				DataTable dtWN=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtWN,strSql,"wellName");  


				DataTable dtRt=null; 
				DataTable dtDetail=null;

				for(int i=0;i<dtWN.Rows.Count;i++)				
				{
					string strWellNo=dtWN.Rows[i]["wellNo"].ToString().Trim();
					DataTable dtDetailF=new DataTable();
					if(BengZhan.comReport.CReports.getDtDetailReportDay(strWellNo,strFrom,strTo,ref dtDetailF)==false)
					{
						return;
					}
					BengZhan.comReport.CReports.copyDt(dtDetailF,ref dtRt);
				}         
				dtDetail=dtRt;
    

                
                dtRepDep=dtDetail;                                                                                                                                                                                                                                                                                                                                                           
			

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		//单位明细表
		private void detailRepDep()
		{
			try
			{
				string strFrom=this.dtpFrom.Value.ToShortDateString();
				strFrom=strFrom+" "+this.numStart.Value.ToString().Trim()+":00:00";
				string strTo=this.dtpTo.Value.ToShortDateString();
				strTo=strTo+" "+this.numEnd.Value.ToString().Trim()+":00:00";
			
				string strDepName=this.trvWel.SelectedNode.Text.Trim();      
                
                string strSql=string.Format("select wellNo from tbWell where depName='{0}' order by wellNo",strDepName);       
                DataTable dtWN=new DataTable();
                BengZhan.CDBConnection.getDataTable(ref dtWN,strSql,"wellName");  


                DataTable dtRt=null; 
				DataTable dtDetail=null;

				for(int i=0;i<dtWN.Rows.Count;i++)				
				{
					string strWellNo=dtWN.Rows[i]["wellNo"].ToString().Trim();
					DataTable dtDetailF=new DataTable();
					if(BengZhan.comReport.CReports.getDtDetailReport(strWellNo,strFrom,strTo,ref dtDetailF)==false)
					{
						return;
					}
					BengZhan.comReport.CReports.copyDt(dtDetailF,ref dtRt);
				}         
                dtDetail=dtRt;                                                                                                                                                                                                                                                                                                                                                                                               
			
				this.drawDg1(dtDetail);

				string strCapText=string.Format("单位：{0}    时间范围：{1}至{2}    监测站流量明细表",strDepName,strFrom,strTo);
				this.dataGrid1.CaptionText=strCapText;
				this.m_strDtFrom=strFrom;
				this.m_strDtTo=strTo;

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		//乡镇
		private void detailRepCountry()
		{
			try
			{
				string strFrom=this.dtpFrom.Value.ToShortDateString();
				strFrom=strFrom+" "+this.numStart.Value.ToString().Trim()+":00:00";
				string strTo=this.dtpTo.Value.ToShortDateString();
				strTo=strTo+" "+this.numEnd.Value.ToString().Trim()+":00:00";		
				
				string strCountryName=this.trvWel.SelectedNode.Text.Trim();

				string strSql=string.Format("select wellNo from tbWell,tbDep where tbWell.depName=tbDep.depShortName and tbDep.countryName='{0}' order by wellNo",strCountryName);
				DataTable dtN=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtN,strSql,"dtN");

				DataTable dt=(DataTable)this.dataGrid1.DataSource;		
				dt.Rows.Clear();						


				DataTable dtRt=null;
				DataTable dtDetail=null;
				for(int i=0;i<dtN.Rows.Count;i++)
				{
					string strWellNo=dtN.Rows[i]["wellNo"].ToString().Trim();
					DataTable dtDetailF=new DataTable();
					if(BengZhan.comReport.CReports.getDtDetailReport(strWellNo,strFrom,strTo,ref dtDetailF)==false)
					{
						return;
					}
					BengZhan.comReport.CReports.copyDt(dtDetailF,ref dtRt);
				}
				dtDetail=dtRt;

				this.drawDg1(dtDetail);		

				string strCapText=string.Format("乡镇：{0}    时间范围：{1}至{2}    监测站流量明细表",strCountryName,strFrom,strTo);
				this.dataGrid1.CaptionText=strCapText;
				this.m_strDtFrom=strFrom;
				this.m_strDtTo=strTo;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}


		#endregion

		#region"日统计表"

		//监测站
		private void dayStaticRep()
		{
			try
			{
				string strFrom=this.dtpFrom1.Value.ToShortDateString();		
				string strTo=this.dtpTo1.Value.ToShortDateString();			

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

				string strZhanNo=strZhanInfo.Substring(0,strZhanInfo.IndexOf("|"));	
			
				DataTable dtAvg=new DataTable();

				if(BengZhan.comReport.CReports.getDtAvgReport(strZhanNo,strFrom,strTo,ref dtAvg)==false)
				{
					return;
				}

				DataTable dt=(DataTable)this.dataGrid2.DataSource;	
			
				dt.Rows.Clear();					
		
				for(int i=0;i<dtAvg.Rows.Count;i++)
				{
					DataRow dr=dt.NewRow();					
					for(int j=0;j<dt.Columns.Count;j++)
					{
						string strColName=dt.Columns[j].ColumnName;
						dr[strColName]=dtAvg.Rows[i][strColName].ToString();
					}
					dt.Rows.Add(dr);
				}

				string strCapText=string.Format("监测站：{0}    时间范围：{1}至{2}    监测站流量日统计表",this.m_strZhanName,strFrom,strTo);
				this.dataGrid2.CaptionText=strCapText;
				this.m_strDtFrom=strFrom;
				this.m_strDtTo=strTo;
				
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
				string strTo=this.dtpTo1.Value.ToShortDateString();	
		
				string strDepName=this.trvWel.SelectedNode.Text.Trim();	
				string strSql=string.Format("select wellNo from tbWell where depName='{0}' order by wellNo",strDepName);

				DataTable dtN=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtN,strSql,"dtN");


				DataTable dtAvg=null;
				DataTable dtRt=null;
				for(int i=0;i<dtN.Rows.Count;i++)
				{
					string strWellNo=dtN.Rows[i]["wellNo"].ToString().Trim();
					DataTable dtAvgF=new DataTable();
					if(BengZhan.comReport.CReports.getDtAvgReport(strWellNo,strFrom,strTo,ref dtAvgF)==false)
					{
						return;
					}
					BengZhan.comReport.CReports.copyDt(dtAvgF,ref dtRt);
				}
				dtAvg=dtRt;	

				DataTable dt=(DataTable)this.dataGrid2.DataSource;			
				dt.Rows.Clear();					
		
				for(int i=0;i<dtAvg.Rows.Count;i++)
				{
					DataRow dr=dt.NewRow();					
					for(int j=0;j<dt.Columns.Count;j++)
					{
						string strColName=dt.Columns[j].ColumnName;
						dr[strColName]=dtAvg.Rows[i][strColName].ToString();
					}
					dt.Rows.Add(dr);
				}

				string strCapText=string.Format("单位：{0}    时间范围：{1}至{2}    监测站流量日统计表",strDepName,strFrom,strTo);
				this.dataGrid2.CaptionText=strCapText;
				this.m_strDtFrom=strFrom;
				this.m_strDtTo=strTo;
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		//乡镇
		private void dayStaticRepCountry()
		{
			try
			{
				string strFrom=this.dtpFrom1.Value.ToShortDateString();		
				string strTo=this.dtpTo1.Value.ToShortDateString();	
		
				string strCountryName=this.trvWel.SelectedNode.Text.Trim();	
				string strSql=string.Format("select wellNo from tbWell,tbDep where tbWell.depName=tbDep.depShortName and tbDep.countryName='{0}' order by wellNo",strCountryName);

				DataTable dtN=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtN,strSql,"dtN");


				DataTable dtAvg=null;
				DataTable dtRt=null;
				for(int i=0;i<dtN.Rows.Count;i++)
				{
					string strWellNo=dtN.Rows[i]["wellNo"].ToString().Trim();
					DataTable dtAvgF=new DataTable();
					if(BengZhan.comReport.CReports.getDtAvgReport(strWellNo,strFrom,strTo,ref dtAvgF)==false)
					{
						return;
					}
					BengZhan.comReport.CReports.copyDt(dtAvgF,ref dtRt);
				}
				dtAvg=dtRt;	

				DataTable dt=(DataTable)this.dataGrid2.DataSource;			
				dt.Rows.Clear();					
		
				for(int i=0;i<dtAvg.Rows.Count;i++)
				{
					DataRow dr=dt.NewRow();					
					for(int j=0;j<dt.Columns.Count;j++)
					{
						string strColName=dt.Columns[j].ColumnName;
						dr[strColName]=dtAvg.Rows[i][strColName].ToString();
					}
					dt.Rows.Add(dr);
				}

				string strCapText=string.Format("乡镇：{0}    时间范围：{1}至{2}    监测站流量日统计表",strCountryName,strFrom,strTo);
				this.dataGrid2.CaptionText=strCapText;
				this.m_strDtFrom=strFrom;
				this.m_strDtTo=strTo;
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		#endregion

		#region"月统计表"	
		//监测站
		private void monthStaticRep()
		{
			try
			{

				DateTime dtFrom=new DateTime();
				DateTime dtTo=new DateTime();

				if(this.txtYearFrom.Text.Trim().Length!=4)
				{
					MessageBox.Show("年份输入有误！其长度应为4位！");
					return;
				}

				try
				{
					string strTime=string.Format("{0}-{1}-{2}",this.txtYearFrom.Text.Trim(),this.numFrom.Value.ToString().Trim(),"1");
					dtFrom=DateTime.Parse(strTime);
					strTime=string.Format("{0}-{1}-{2}",this.txtYearTo.Text.Trim(),this.numTo.Value.ToString().Trim(),"1");
					dtTo=DateTime.Parse(strTime);
				}
				catch(Exception ex)
				{
					MessageBox.Show("查询时间范围填写有误！");
				}

				string strFrom=dtFrom.ToShortDateString();		
				string strTo=dtTo.ToShortDateString();			

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

				string strZhanNo=strZhanInfo.Substring(0,strZhanInfo.IndexOf("|"));	
			
				DataTable dtAvg=new DataTable();

				if(BengZhan.comReport.CReports.getDtMonthAvgReport(strZhanNo,strFrom,strTo,ref dtAvg)==false)
				{
					return;
				}

				DataTable dt=(DataTable)this.dataGrid3.DataSource;	
			
				dt.Rows.Clear();					
		
				for(int i=0;i<dtAvg.Rows.Count;i++)
				{
					DataRow dr=dt.NewRow();					
					for(int j=0;j<dt.Columns.Count;j++)
					{
						string strColName=dt.Columns[j].ColumnName;
						dr[strColName]=dtAvg.Rows[i][strColName].ToString();
					}
					dt.Rows.Add(dr);
				}

				string strFromMon=string.Format("{0}年{1}月",dtFrom.Year.ToString().Trim(),dtFrom.Month.ToString().Trim());
				string strToMon=string.Format("{0}年{1}月",dtTo.Year.ToString().Trim(),dtTo.Month.ToString().Trim());
				string strCapText=string.Format("监测站：{0}    时间范围：{1}至{2}    流量月统计表",this.m_strZhanName,strFromMon,strToMon);
				this.dataGrid3.CaptionText=strCapText;
				this.m_strDtFrom=strFromMon;
				this.m_strDtTo=strToMon;
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}


		//单位
		private void monthStaticRepDep()
		{
			try
			{
				DateTime dtFrom=new DateTime();
				DateTime dtTo=new DateTime();

				if(this.txtYearFrom.Text.Trim().Length!=4)
				{
					MessageBox.Show("年份输入有误！其长度应为4位！");
					return;
				}

				try
				{
					string strTime=string.Format("{0}-{1}-{2}",this.txtYearFrom.Text.Trim(),this.numFrom.Value.ToString().Trim(),"1");
					dtFrom=DateTime.Parse(strTime);
					strTime=string.Format("{0}-{1}-{2}",this.txtYearTo.Text.Trim(),this.numTo.Value.ToString().Trim(),"1");
					dtTo=DateTime.Parse(strTime);
				}
				catch(Exception ex)
				{
					MessageBox.Show("查询时间范围填写有误！");
				}
				string strFrom=dtFrom.ToShortDateString();		
				string strTo=dtTo.ToShortDateString();	

				string strDepName=this.trvWel.SelectedNode.Text.Trim();

				string strSql=string.Format("select wellNo from tbWell where depName='{0}' order by wellNo",strDepName);
				DataTable dtN=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtN,strSql,"dtN");

				DataTable dtRt=null;
				DataTable dtAvg=null;

				for(int i=0;i<dtN.Rows.Count;i++)
				{
					string strWellNo=dtN.Rows[i]["wellNo"].ToString().Trim();								
					DataTable dtAvgF=new DataTable();
					if(BengZhan.comReport.CReports.getDtMonthAvgReport(strWellNo,strFrom,strTo,ref dtAvgF)==false)
					{
						return;
					}
					BengZhan.comReport.CReports.copyDt(dtAvgF,ref dtRt);
				}

				dtAvg=dtRt;

				DataTable dt=(DataTable)this.dataGrid3.DataSource;			
				dt.Rows.Clear();			
		
				for(int i=0;i<dtAvg.Rows.Count;i++)
				{
					DataRow dr=dt.NewRow();					
					for(int j=0;j<dt.Columns.Count;j++)
					{
						string strColName=dt.Columns[j].ColumnName;
						dr[strColName]=dtAvg.Rows[i][strColName].ToString();
					}
					dt.Rows.Add(dr);
				}

				string strFromMon=string.Format("{0}年{1}月",dtFrom.Year.ToString().Trim(),dtFrom.Month.ToString().Trim());
				string strToMon=string.Format("{0}年{1}月",dtTo.Year.ToString().Trim(),dtTo.Month.ToString().Trim());
				string strCapText=string.Format("单位：{0}    时间范围：{1}至{2}    监测站流量月统计表",strDepName,strFromMon,strToMon);
				this.dataGrid3.CaptionText=strCapText;
				this.m_strDtFrom=strFromMon;
				this.m_strDtTo=strToMon;
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		//乡镇月统计表

		private void monthStaticRepCountry()
		{
			try
			{
				DateTime dtFrom=new DateTime();
				DateTime dtTo=new DateTime();

				if(this.txtYearFrom.Text.Trim().Length!=4)
				{
					MessageBox.Show("年份输入有误！其长度应为4位！");
					return;
				}

				try
				{
					string strTime=string.Format("{0}-{1}-{2}",this.txtYearFrom.Text.Trim(),this.numFrom.Value.ToString().Trim(),"1");
					dtFrom=DateTime.Parse(strTime);
					strTime=string.Format("{0}-{1}-{2}",this.txtYearTo.Text.Trim(),this.numTo.Value.ToString().Trim(),"1");
					dtTo=DateTime.Parse(strTime);
				}
				catch(Exception ex)
				{
					MessageBox.Show("查询时间范围填写有误！");
				}

				string strFrom=dtFrom.ToShortDateString();		
				string strTo=dtTo.ToShortDateString();	

				string strCountryName=this.trvWel.SelectedNode.Text.Trim();

				string strSql=string.Format("select wellNo from tbWell,tbDep where tbWell.depName=tbDep.depShortName and tbDep.countryName='{0}' order by wellNo",strCountryName);
				DataTable dtN=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtN,strSql,"dtN");

				DataTable dtRt=null;
				DataTable dtAvg=null;

				for(int i=0;i<dtN.Rows.Count;i++)
				{
					string strWellNo=dtN.Rows[i]["wellNo"].ToString().Trim();								
					DataTable dtAvgF=new DataTable();
					if(BengZhan.comReport.CReports.getDtMonthAvgReport(strWellNo,strFrom,strTo,ref dtAvgF)==false)
					{
						return;
					}
					BengZhan.comReport.CReports.copyDt(dtAvgF,ref dtRt);
				}

				dtAvg=dtRt;

				DataTable dt=(DataTable)this.dataGrid3.DataSource;			
				dt.Rows.Clear();			
		
				for(int i=0;i<dtAvg.Rows.Count;i++)
				{
					DataRow dr=dt.NewRow();					
					for(int j=0;j<dt.Columns.Count;j++)
					{
						string strColName=dt.Columns[j].ColumnName;
						dr[strColName]=dtAvg.Rows[i][strColName].ToString();
					}
					dt.Rows.Add(dr);
				}

				string strFromMon=string.Format("{0}年{1}月",dtFrom.Year.ToString().Trim(),dtFrom.Month.ToString().Trim());
				string strToMon=string.Format("{0}年{1}月",dtTo.Year.ToString().Trim(),dtTo.Month.ToString().Trim());
				string strCapText=string.Format("乡镇：{0}    时间范围：{1}至{2}    监测站流量月统计表",strCountryName,strFromMon,strToMon);
				this.dataGrid3.CaptionText=strCapText;
				this.m_strDtFrom=strFromMon;
				this.m_strDtTo=strToMon;
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}


		
#endregion			

		private void btnExp_Click(object sender, System.EventArgs e)
		{
		
		}	

		#endregion

		#region"打印"

		private string strPrintTitle="";
		private void printMonth()
		{
			try
			{
				string strCaption=this.dataGrid3.CaptionText.Trim();
				if(strCaption.IndexOf("：")<0)				
				{
					MessageBox.Show("请先点击[确定]按钮！");
					return;
				}
				this.strPrintTitle=this.dataGrid3.CaptionText.Replace("监测站流量月统计表","");

				if(this.m_xDocPrint==null)
				{
					this.m_xDocPrint=new XmlDocument();
					this.m_xDocPrint.Load("repPrint.xml");
				}

				XmlNode xNode=this.m_xDocPrint.DocumentElement.SelectSingleNode("./rep[@val='3']");

				DataGridTableStyle dgts=new DataGridTableStyle();
				DataTable dt=new DataTable();
				for(int i=0;i<xNode.ChildNodes.Count;i++)
				{
					string strField=xNode.ChildNodes[i].Attributes.GetNamedItem("field").Value.Trim();
					string strHeader=xNode.ChildNodes[i].Attributes.GetNamedItem("headerText").Value.Trim();
					string strWidth=xNode.ChildNodes[i].Attributes.GetNamedItem("width").Value.Trim();

					dt.Columns.Add(strField);
					
					DataGridColoredTextBoxColumn dgtc=new DataGridColoredTextBoxColumn();
					dgtc.Width=int.Parse(strWidth);
					dgtc.HeaderText=strHeader;
					dgtc.MappingName=strField;
					dgts.GridColumnStyles.Add(dgtc);

				}
				this.dgPrint.TableStyles.Clear();
				this.dgPrint.TableStyles.Add(dgts);
				this.dgPrint.DataSource=dt;

				DataTable dtPrint=(DataTable)this.dgPrint.DataSource;
				DataTable dtDetail=(DataTable)this.dataGrid3.DataSource;

				for(int i=0;i<dtDetail.Rows.Count;i++)
				{
					dtPrint.ImportRow(dtDetail.Rows[i]);
				}
				this.clearBlankRow(dtPrint);		 
		
				cutePrint.cutePrinter dgp=new cutePrint.cutePrinter(this.dgPrint,"监测站流量月统计表",30);
				int iTimeMinus=int.Parse(xNode.Attributes.GetNamedItem("iTimeMinus").Value.Trim());
				dgp.iTimeMinus=iTimeMinus;
		
				dgp.leftMargin=int.Parse(xNode.Attributes.GetNamedItem("leftMargin").Value.Trim());				
				dgp.strTitle=this.strPrintTitle;
				dgp.Print();
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void  printDay()
		{
			try
			{
				string strCaption=this.dataGrid2.CaptionText.Trim();
				if(strCaption.IndexOf("：")<0)				
				{
					MessageBox.Show("请先点击[确定]按钮！");
					return;
				}
				this.strPrintTitle=this.dataGrid2.CaptionText.Replace("监测站流量日统计表","");	
				

				if(this.m_xDocPrint==null)
				{
					this.m_xDocPrint=new XmlDocument();
					this.m_xDocPrint.Load("repPrint.xml");
				}

				XmlNode xNode=this.m_xDocPrint.DocumentElement.SelectSingleNode("./rep[@val='2']");

				DataGridTableStyle dgts=new DataGridTableStyle();
				DataTable dt=new DataTable();
				for(int i=0;i<xNode.ChildNodes.Count;i++)
				{
					string strField=xNode.ChildNodes[i].Attributes.GetNamedItem("field").Value.Trim();
					string strHeader=xNode.ChildNodes[i].Attributes.GetNamedItem("headerText").Value.Trim();
					string strWidth=xNode.ChildNodes[i].Attributes.GetNamedItem("width").Value.Trim();

					dt.Columns.Add(strField);
					
					DataGridColoredTextBoxColumn dgtc=new DataGridColoredTextBoxColumn();
					dgtc.Width=int.Parse(strWidth);
					dgtc.HeaderText=strHeader;
					dgtc.MappingName=strField;
					dgts.GridColumnStyles.Add(dgtc);

				}
				this.dgPrint.TableStyles.Clear();
				this.dgPrint.TableStyles.Add(dgts);
				this.dgPrint.DataSource=dt;

				DataTable dtPrint=(DataTable)this.dgPrint.DataSource;
				DataTable dtDetail=(DataTable)this.dataGrid2.DataSource;

				for(int i=0;i<dtDetail.Rows.Count;i++)
				{
					dtPrint.ImportRow(dtDetail.Rows[i]);
				}	
				this.clearBlankRow(dtPrint);	 
		
				cutePrint.cutePrinter dgp=new cutePrint.cutePrinter(this.dgPrint,"监测站流量日统计表",30);
				int iTimeMinus=int.Parse(xNode.Attributes.GetNamedItem("iTimeMinus").Value.Trim());
				dgp.iTimeMinus=iTimeMinus;
				
				dgp.leftMargin=int.Parse(xNode.Attributes.GetNamedItem("leftMargin").Value.Trim());
				
				dgp.strTitle=this.strPrintTitle;

				dgp.Print();
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}			
		}

		private void printDetail()
		{
			try
			{				
				string strCaption=this.dataGrid1.CaptionText.Trim();
				if(strCaption.IndexOf("：")<0)				
				{
					MessageBox.Show("请先点击[确定]按钮！");
					return;
				}
				this.strPrintTitle=this.dataGrid1.CaptionText.Replace("监测站流量明细表","");	
				
				if(this.m_xDocPrint==null)
				{
					this.m_xDocPrint=new XmlDocument();
					this.m_xDocPrint.Load("repPrint.xml");
				}

				XmlNode xNode=this.m_xDocPrint.DocumentElement.SelectSingleNode("./rep[@val='1']");

				DataGridTableStyle dgts=new DataGridTableStyle();
				DataTable dt=new DataTable();
				for(int i=0;i<xNode.ChildNodes.Count;i++)
				{
					string strField=xNode.ChildNodes[i].Attributes.GetNamedItem("field").Value.Trim();
					string strHeader=xNode.ChildNodes[i].Attributes.GetNamedItem("headerText").Value.Trim();
					string strWidth=xNode.ChildNodes[i].Attributes.GetNamedItem("width").Value.Trim();

					dt.Columns.Add(strField);
					
					DataGridColoredTextBoxColumn dgtc=new DataGridColoredTextBoxColumn();
					dgtc.Width=int.Parse(strWidth);
					dgtc.HeaderText=strHeader;
					dgtc.MappingName=strField;
					dgts.GridColumnStyles.Add(dgtc);

				}
				this.dgPrint.TableStyles.Clear();
				this.dgPrint.TableStyles.Add(dgts);
				this.dgPrint.DataSource=dt;

				DataTable dtPrint=(DataTable)this.dgPrint.DataSource;
				DataTable dtDetail=(DataTable)this.dataGrid1.DataSource;

				for(int i=0;i<dtDetail.Rows.Count;i++)
				{
					dtPrint.ImportRow(dtDetail.Rows[i]);
				}						 
				this.clearBlankRow(dtPrint);

				cutePrint.cutePrinter dgp=new cutePrint.cutePrinter(this.dgPrint,"流量明细表",30);
				//string[] header={"","","","","","","","","","","",""};
				//dgp.setHeader(header);
				int iTimeMinus=int.Parse(xNode.Attributes.GetNamedItem("iTimeMinus").Value.Trim());
				dgp.iTimeMinus=iTimeMinus;
				dgp.leftMargin=int.Parse(xNode.Attributes.GetNamedItem("leftMargin").Value.Trim());				
				dgp.strTitle=this.strPrintTitle;

				dgp.Print();

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}			
		}

		#endregion

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

		private void groupBox7_Enter(object sender, System.EventArgs e)
		{
		
		}	

		#region"右键弹出菜单"
		
		private void iniContMenu()
		{
			try
			{	
				return;
				
				this.contextMenu1 = new System.Windows.Forms.ContextMenu();

				System.Windows.Forms.MenuItem menuItem1 = new System.Windows.Forms.MenuItem();
				//System.Windows.Forms.MenuItem menuItem2=new MenuItem();


				// Initialize contextMenu1
				this.contextMenu1.MenuItems.AddRange(
					new System.Windows.Forms.MenuItem[] {menuItem1});

				// Initialize menuItem1
				menuItem1.Index = 0;
				menuItem1.Text = "不显示空行";
				menuItem1.Click += new System.EventHandler(this.menuItem_Click);
				menuItem1.Checked=true;

				this.ContextMenu=this.contextMenu1;

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void menuItem_Click(object Sender, EventArgs e) 
		{	
			try
			{
			
				System.Windows.Forms.MenuItem mi=(System.Windows.Forms.MenuItem)Sender;

				if(mi.Checked)
				{
					mi.Checked=false;
				}
				else
				{
					mi.Checked=true;
				}

				switch(mi.Text.Trim())				
				{
					case "不显示空行":
						this.bDelNull=mi.Checked;
						break;				
				}
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}
		

		#endregion

		#region"合计计算"

		private void addSumRow(ref DataTable dt)
		{
			try
			{
				double dSAllBuy=0;
				double dSAllAmount=0;
				double dAVAmount=0;
				double dCount=0;   
				double dLevel=0;

				bool bHave=false;

				for(int i=0;i<dt.Rows.Count;i++)				
				{
					if(dt.Rows[i]["wellName"].ToString().Trim().IndexOf("统计")>=0)
					{

						bHave=true;

						try
						{	
		
//							if((dt.Columns["allBuyAmount"]==null)||(dt.Columns["allAmount"]==null)||(dt.Columns["amount"]==null)||(dt.Columns["waterLevel"]==null))
//							{
//								return ;
//							}

							if((dt.Columns["allBuyAmount"]!=null)&&(!this.bNull(dt.Rows[i]["allBuyAmount"])))
							{
								dSAllBuy+=double.Parse(dt.Rows[i]["allBuyAmount"].ToString());
							}
									
							if((dt.Columns["allAmount"]!=null)&&(!this.bNull(dt.Rows[i]["allAmount"])))
							{
								dSAllAmount+=double.Parse(dt.Rows[i]["allAmount"].ToString());
							}

							if((dt.Columns["amount"]!=null)&&(!this.bNull(dt.Rows[i]["amount"])))
							{
								dAVAmount+=double.Parse(dt.Rows[i]["amount"].ToString());
							}
	
							if((dt.Columns["waterLevel"]!=null)&&(!this.bNull(dt.Rows[i]["waterLevel"])))
							{
								dLevel+=double.Parse(dt.Rows[i]["waterLevel"].ToString());
							}						
						}
						catch
						{
							MessageBox.Show("有无效数据或数据累加和过大，无法进行合计。");
						}						
						
						dCount++;
					}
				}

				if(dCount==0)
				{
					return;
				}

				dAVAmount=dAVAmount/dCount;
				dAVAmount=Math.Round(dAVAmount,2);
				dLevel=dLevel/dCount;
				dLevel=Math.Round(dLevel,2);

				if(bHave)
				{

					DataRow dr=dt.NewRow();

//					if((dr.Table.Columns["wellName"]==null)||(dr.Table.Columns["allBuyAmount"]==null)||(dr.Table.Columns["allAmount"]==null)||(dr.Table.Columns["amount"]==null)||(dr.Table.Columns["waterLevel"]==null))
//					{
//						return;
//					}

					for(int i=0;i<dr.Table.Columns.Count;i++)
					{
						dr[i]="";
					}

					dr["wellName"]="合计";

					if(dt.Columns["allBuyAmount"]!=null)
					{
						dr["allBuyAmount"]=dSAllBuy;
					}

					if(dt.Columns["allAmount"]!=null)
					{
						dr["allAmount"]=dSAllAmount;
					}

					if(dt.Columns["amount"]!=null)
					{
						dr["amount"]=dAVAmount;
					}

					if(dt.Columns["waterLevel"]!=null)
					{
						dr["waterLevel"]=dLevel;
					}		
			
					dt.Rows.Add(dr);

				}				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString()+" 统计异常 ");
			}
		}

		private void addSumRow2(ref DataTable dt)
		{
			try
			{
				double dSAllBuy=0;
				double dSAllAmount=0;
				double dAVAmount=0;
				double dCount=0;   
				double dLevel=0;

				bool bHave=false;

				for(int i=0;i<dt.Rows.Count;i++)				
				{
					

						bHave=true;

						try
						{	
		
							if(dt.Columns["allAmount"]==null)
							{
								return ;
							}

									
							if(!this.bNull(dt.Rows[i]["allAmount"]))
							{
								dSAllAmount+=double.Parse(dt.Rows[i]["allAmount"].ToString());
							}
								
						}
						catch
						{
							MessageBox.Show("有无效数据或数据累加和过大，无法进行合计。");
						}						
						
						dCount++;
					
				}		

				if(bHave)
				{

					DataRow dr=dt.NewRow();

					if((dr.Table.Columns["wellName"]==null)||(dr.Table.Columns["allAmount"]==null))
					{
						return;
					}

					for(int i=0;i<dr.Table.Columns.Count;i++)
					{
						dr[i]="";
					}

					dr["wellName"]="合计";
				
					dr["allAmount"]=dSAllAmount;
				

					dt.Rows.Add(dr);

				}				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString()+" 统计异常 ");
			}
		}

		private bool bNull(object o)
		{
			if(o==null)
			{
				return true;
			}
			if(o.ToString().Trim()=="")
			{
				return true;
			}
			return false;
		}

		#endregion

		#region"newwork"

		private void start()
		{
			this.lblWait.Visible=true;
		}
		private void end()
		{
			this.lblWait.Visible=false;
		}

		private void drawDg1(DataTable dt)
		{
			try
			{

				DataTable dtN=new DataTable();

				for(int i=0;i<this.dataGrid1.TableStyles[0].GridColumnStyles.Count;i++)
				{
					dtN.Columns.Add(this.dataGrid1.TableStyles[0].GridColumnStyles[i].MappingName.Trim());
				}
				for(int i=0;i<dt.Rows.Count;i++)
				{
					dtN.ImportRow(dt.Rows[i]);
				}

				this.dataGrid1.DataSource=dtN;

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}
		#endregion

		private bool bPaint=false;

		private void frmReport_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			if(!this.bPaint)
			{
				this.tabControl1.TabPages.RemoveAt(1);
				this.tabControl1.TabPages.RemoveAt(1);
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

		private void button1_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(NoRecordDataGrid()) {return;}
			
				int row=dataGrid1.CurrentCell.RowNumber;
				int col=0;
				string Name=dataGrid1[row,col].ToString().Trim();
				if(Name==null)
				{
					MessageBox.Show("请正确选择需要删除的数据行!","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return ;
				}

				if(MessageBox.Show("确定要删除该行数据?","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question)!=DialogResult.Yes){	return ;}
			
				string delTime=dataGrid1[row,5].ToString().Trim();
				string delamount=dataGrid1[row,2].ToString().Trim();
				string strSql=string.Format("delete from waterDatas where name='{0}' and time='{1}' and amount='{2}'",Name,delTime,delamount);

				BengZhan.CDBConnection.ExecuteSql(strSql);

				btnDis_Click(null,null);
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		private bool NoRecordDataGrid()
		{
			return -1==dataGrid1.CurrentRowIndex;
		}
	

	}
}

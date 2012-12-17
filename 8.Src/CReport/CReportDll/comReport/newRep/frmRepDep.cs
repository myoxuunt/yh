using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Xml;

namespace CReportDll.comReport.newRep
{
	/// <summary>
	/// frmRepDep 的摘要说明。
	/// </summary>
	public class frmRepDep : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox grp1;
		private System.Windows.Forms.TreeView trvWel;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtZhan;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnHelp;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.NumericUpDown numEnd;
		private System.Windows.Forms.NumericUpDown numStart;
		private System.Windows.Forms.Button btnDis;
		private System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpFrom;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGrid dgPrint;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.ComboBox cmbCountry;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Button btnExit1;
		private System.Windows.Forms.Button btnHelp1;
		private System.Windows.Forms.Button btnPrint1;
		private System.Windows.Forms.Button btnCer1;
		private System.Windows.Forms.DateTimePicker dtpTo1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpFrom1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.Button btnExit2;
		private System.Windows.Forms.Button btnHelp2;
		private System.Windows.Forms.Button btnPrint2;
		private System.Windows.Forms.Button btnCer2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown numTo;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtYearTo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown numFrom;
		private System.Windows.Forms.Label lbl;
		private System.Windows.Forms.TextBox txtYearFrom;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.DataGrid dataGrid3;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.ComponentModel.IContainer components;

		public frmRepDep()
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
			this.grp1 = new System.Windows.Forms.GroupBox();
			this.trvWel = new System.Windows.Forms.TreeView();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtZhan = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnHelp = new System.Windows.Forms.Button();
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
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
			this.grp1.SuspendLayout();
			this.groupBox2.SuspendLayout();
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
			this.SuspendLayout();
			// 
			// grp1
			// 
			this.grp1.Controls.Add(this.trvWel);
			this.grp1.Location = new System.Drawing.Point(0, 53);
			this.grp1.Name = "grp1";
			this.grp1.Size = new System.Drawing.Size(176, 596);
			this.grp1.TabIndex = 17;
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
			this.groupBox2.Location = new System.Drawing.Point(0, 5);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(176, 48);
			this.groupBox2.TabIndex = 18;
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
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(176, 10);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(840, 640);
			this.tabControl1.TabIndex = 19;
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
			this.groupBox1.Controls.Add(this.btnHelp);
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
			// btnHelp
			// 
			this.btnHelp.Location = new System.Drawing.Point(536, 15);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(56, 23);
			this.btnHelp.TabIndex = 12;
			this.btnHelp.Text = "帮助";
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
			this.btnPrint.Location = new System.Drawing.Point(480, 15);
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
																   23,
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
																	 23,
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
			this.btnDis.Location = new System.Drawing.Point(424, 15);
			this.btnDis.Name = "btnDis";
			this.btnDis.Size = new System.Drawing.Size(56, 23);
			this.btnDis.TabIndex = 3;
			this.btnDis.Text = "确认";
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
			this.btnExit.Location = new System.Drawing.Point(592, 15);
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
			this.btnExit1.Click += new System.EventHandler(this.btnExit1_Click);
			// 
			// btnHelp1
			// 
			this.btnHelp1.Location = new System.Drawing.Point(472, 15);
			this.btnHelp1.Name = "btnHelp1";
			this.btnHelp1.Size = new System.Drawing.Size(56, 23);
			this.btnHelp1.TabIndex = 6;
			this.btnHelp1.Text = "帮助";
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
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// frmRepDep
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(1016, 654);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.grp1);
			this.Controls.Add(this.groupBox2);
			this.Name = "frmRepDep";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "单位流量统计表";
			this.Load += new System.EventHandler(this.frmRepDep_Load);
			this.grp1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
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
			this.ResumeLayout(false);

		}
		#endregion

		private void frmRepDep_Load(object sender, System.EventArgs e)
		{
			this.paintFrm();
			this.txtYearFrom.Text=System.DateTime.Now.Year.ToString();
			this.txtYearTo.Text=System.DateTime.Now.Year.ToString();
			this.numFrom.Value=int.Parse(System.DateTime.Now.Month.ToString());
			this.numTo.Value=int.Parse(System.DateTime.Now.Month.ToString());
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnExit1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnExit2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		#region"画界面"

		XmlDocument m_xDocRep=null;

		private bool paintGrid()
		{
			try
			{
				if(this.m_xDocRep==null)
				{
					this.m_xDocRep=new XmlDocument();
					this.m_xDocRep.Load(@"dep\report.xml");
				}

				XmlNode xNodeRep=this.m_xDocRep.DocumentElement.SelectSingleNode("./report[@name='tb1']");

				string strSql=xNodeRep.Attributes.GetNamedItem("sql").Value.Trim();

				DataTable dt=new   DataTable();	
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
				this.dataGrid1.DataSource=dt;

				this.dataGrid1.ReadOnly=true;

				this.dataGrid1.CaptionText="单位统计表";
				
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
				this.dataGrid2.CaptionText="单位日统计表";
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
				this.dataGrid3.CaptionText="单位月统计表";
				this.dataGrid3.ReadOnly=true;
						
				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}

		private void paintFrm()
		{
			try
			{
				if(BengZhan.CDBConnection.m_sCon==null)
				{
					XmlDocument xDoc=new XmlDocument();
					xDoc.Load("Server.xml");
					string strCon=xDoc.DocumentElement.SelectSingleNode("./strCon").InnerText.Trim();
					SqlConnection sCon=new SqlConnection(strCon);
					sCon.Open();
					BengZhan.CDBConnection.m_sCon=sCon;
				}

				this.paintTrvDep(ref this.trvWel);
				paintGrid();
				this.paintOneLine();

                
			}	
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void paintTrvDep(ref System.Windows.Forms.TreeView trv)
		{
			try
			{
				string strSql=string.Format("select distinct countryName from tbDep");
				DataTable dtCountry=new  DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtCountry,strSql,"tbDep");
				
				for(int i=0;i<dtCountry.Rows.Count;i++)
				{
					string strCountryName=dtCountry.Rows[i]["countryName"].ToString().Trim();
					int iDex=trv.Nodes.Add(new System.Windows.Forms.TreeNode(strCountryName));

					strSql=string.Format("select depShortName from tbDep where countryName='{0}'",strCountryName);
					DataTable dtDep=new DataTable();
					BengZhan.CDBConnection.getDataTable(ref dtDep,strSql,"dtDep");

					for(int j=0;j<dtDep.Rows.Count;j++)
					{
						trv.Nodes[iDex].Nodes.Add(dtDep.Rows[j]["depShortName"].ToString().Trim());
					}
				}					  
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
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
			try
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
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}		
		}
		#endregion

		private void trvWel_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			try
			{

				if(this.trvWel.SelectedNode==null)
				{
					return;
				}

				this.txtZhan.Text=this.trvWel.SelectedNode.Text.Trim();

				string strZhan=this.txtZhan.Text;

				if(this.trvWel.SelectedNode.Parent==null)				
				{
					this.lblName.Text="乡镇：";
				}
				else
				{
					this.lblName.Text="单位：";
				}


			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
		
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

		private void btnDis_Click(object sender, System.EventArgs e)
		{
			if(this.lblName.Text.IndexOf("单位")>=0)
			{
				this.disStatcDep();
			}
			else
			{
				this.disStatcCountry();
			}
			
		}

		private void btnCer1_Click(object sender, System.EventArgs e)
		{
			if(this.lblName.Text.IndexOf("单位")>=0)
			{
				this.dayStaticDep();
			}
			else
			{
				this.dayStaticCountry();
			}
		}

		#region"报表"

		#region"明细表"

		private void disStatcDep()
		{
			try
			{

				string strFrom=this.dtpFrom.Value.ToShortDateString();
				strFrom=strFrom+" "+this.numStart.Value.ToString().Trim()+":00:00";
				string strTo=this.dtpTo.Value.ToShortDateString();
				strTo=strTo+" "+this.numEnd.Value.ToString().Trim()+":00:00";

				string strDepName=this.txtZhan.Text.Trim();

				DataTable dtRep=new DataTable();
				if(!this.getDtStaticDep(strDepName,strFrom,strTo,ref dtRep))
				{
					return;
				}

				string strTitle=string.Format("单位:{0}   时间范围: {1} 至 {2}",strDepName,strFrom,strTo);
					
				this.paintGridE(dtRep,strTitle,1);

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void disStatcCountry()
		{
			try
			{

				string strFrom=this.dtpFrom.Value.ToShortDateString();
				strFrom=strFrom+" "+this.numStart.Value.ToString().Trim()+":00:00";
				string strTo=this.dtpTo.Value.ToShortDateString();
				strTo=strTo+" "+this.numEnd.Value.ToString().Trim()+":00:00";

				string strCountryName=this.txtZhan.Text.Trim();

				string strSql=string.Format("select depShortName from tbDep where CountryName='{0}'",strCountryName);

				DataTable dtDep=new DataTable();

				BengZhan.CDBConnection.getDataTable(ref dtDep,strSql,"dtDep");

				DataTable dtDisp=null;
				for(int i=0;i<dtDep.Rows.Count;i++)
				{
					string strDepName=dtDep.Rows[i]["depShortName"].ToString().Trim();
					DataTable dtRep=new DataTable();
					if(!this.getDtStaticDep(strDepName,strFrom,strTo,ref dtRep))
					{
						return;
					}
					BengZhan.comReport.CReports.copyDt(dtRep,ref dtDisp);
				}

					
				string strTitle=string.Format("乡镇:{0}   时间范围: {1} 至 {2}",strCountryName,strFrom,strTo);
					
				this.paintGridE(dtDisp,strTitle,1);

			}
			catch(Exception ex)

			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
			}

		private bool getDtStaticDep(string strDepName,string strFrom,string strEnd,ref DataTable dtDep)
		{
			try
			{
				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();
				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;
				sCmd.CommandText="staticDep";
				sCmd.CommandType =CommandType.StoredProcedure;

				sCmd.Parameters.Add("@depName",SqlDbType.NVarChar,40);
				sCmd.Parameters.Add("@startTime",SqlDbType.NVarChar,40);
				sCmd.Parameters.Add("@endTime",SqlDbType.NVarChar,40);

				sCmd.Parameters["@depName"].Value=strDepName;
				sCmd.Parameters["@startTime"].Value=strFrom;
				sCmd.Parameters["@endTime"].Value=strEnd;

				SqlDataAdapter sda=new SqlDataAdapter();
				sda.SelectCommand=sCmd;
				sda.Fill(dtDep);
sCon.Close();
				return true;

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}

		private void paintGridE(DataTable dtDep,string strTitle,int iGridNum)		
		{
			try
			{
				DataTable dt=null;
				switch(iGridNum)
				{
					case 1:
						this.dataGrid1.CaptionText=strTitle+"    单位用水统计表";
						dt=(DataTable)this.dataGrid1.DataSource;
						dt.Rows.Clear();
						for(int i=0;i<dtDep.Rows.Count;i++)				
						{
							dt.ImportRow(dtDep.Rows[i]);
						}
						this.paintOneLine();
						break;
					case 2:
						this.dataGrid2.CaptionText=strTitle;
						dt=(DataTable)this.dataGrid2.DataSource;
						dt.Rows.Clear();
						for(int i=0;i<dtDep.Rows.Count;i++)				
						{
							dt.ImportRow(dtDep.Rows[i]);
						}
						this.paintOneLine();
						break;
					case 3:
						this.dataGrid3.CaptionText=strTitle;
						dt=(DataTable)this.dataGrid3.DataSource;
						dt.Rows.Clear();
						for(int i=0;i<dtDep.Rows.Count;i++)				
						{
							dt.ImportRow(dtDep.Rows[i]);
						}
						this.paintOneLine();
						break;
				}
				

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

	

		#endregion

		#region"日统计表"

		private void dayStaticDep()		
		{
			try
			{

				string strDepName=this.txtZhan.Text;
				string strFrom=this.dtpFrom1.Value.ToShortDateString();
				string strTo=this.dtpTo1.Value.ToShortDateString();
				DataTable dtAvg=new DataTable();
				BengZhan.comReport.CReports.getDtAvgReportDep(strDepName,strFrom,strTo,ref  dtAvg);
				
				string strTitle=string.Format("单位:{0}    时间范围： {1} 至 {2}  单位用水日统计表",strDepName,strFrom,strTo);		

				this.paintGridE(dtAvg,strTitle,2);
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void dayStaticCountry()
		{
			try
			{

				string strCountryName=this.txtZhan.Text;
				string strSql=string.Format("select depShortName from tbDep where countryName='{0}'",strCountryName);
				DataTable dtDep=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtDep,strSql,"depDt");

				string strFrom=this.dtpFrom1.Value.ToShortDateString();
				string strTo=this.dtpTo1.Value.ToShortDateString();

				DataTable dtRet=null;

				for(int i=0;i<dtDep.Rows.Count;i++)
				{
					string strDepName=dtDep.Rows[i]["depShortName"].ToString().ToString().Trim();
					
					DataTable dtAvg=new DataTable();
					BengZhan.comReport.CReports.getDtAvgReportDep(strDepName,strFrom,strTo,ref  dtAvg);
					BengZhan.comReport.CReports.copyDt(dtAvg,ref dtRet);
				}
			
				string strTitle=string.Format("乡镇:{0}    时间范围： {1} 至 {2}  单位用水日统计表",strCountryName,strFrom,strTo);	
				this.paintGridE(dtRet,strTitle,2);

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		#endregion

		#region"月统计表"

		private void monthStaticDep()
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

				string strFromDisp="";
				string strToDisp="";

				try
				{
					string strTime=string.Format("{0}-{1}-{2}",this.txtYearFrom.Text.Trim(),this.numFrom.Value.ToString().Trim(),"1");
					strFromDisp=string.Format("{0}年{1}月",this.txtYearFrom.Text.Trim(),this.numFrom.Value.ToString().Trim());
					dtFrom=DateTime.Parse(strTime);
					strTime=string.Format("{0}-{1}-{2}",this.txtYearTo.Text.Trim(),this.numTo.Value.ToString().Trim(),"1");
					dtTo=DateTime.Parse(strTime);
					strToDisp=string.Format("{0}年{1}月",this.txtYearTo.Text.Trim(),this.numTo.Value.ToString().Trim());
				}
				catch(Exception ex)
				{
					MessageBox.Show("查询时间范围填写有误！");
				}

				string strFrom=dtFrom.ToShortDateString();		
				string strTo=dtTo.ToShortDateString();

				DataTable dtMonthDep=null;

				string strDepName=this.txtZhan.Text.Trim();
				BengZhan.comReport.CReports.getDtMonthAvgReportDep(strDepName,strFrom,strTo,ref dtMonthDep);

				string strTitle=string.Format("单位:{0}    时间范围:{1} 至 {2}    单位用水月统计表",strDepName,strFromDisp,strToDisp);

				this.paintGridE(dtMonthDep,strTitle,3);

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}		
		}

		private void monthStaticCountry()		
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

				string strFromDisp="";
				string strToDisp="";

				try
				{
					string strTime=string.Format("{0}-{1}-{2}",this.txtYearFrom.Text.Trim(),this.numFrom.Value.ToString().Trim(),"1");
					strFromDisp=string.Format("{0}年{1}月",this.txtYearFrom.Text.Trim(),this.numFrom.Value.ToString().Trim());
					dtFrom=DateTime.Parse(strTime);
					strTime=string.Format("{0}-{1}-{2}",this.txtYearTo.Text.Trim(),this.numTo.Value.ToString().Trim(),"1");
					dtTo=DateTime.Parse(strTime);
					strToDisp=string.Format("{0}年{1}月",this.txtYearTo.Text.Trim(),this.numTo.Value.ToString().Trim());
				}
				catch(Exception ex)
				{
					MessageBox.Show("查询时间范围填写有误！");
				}
				string strFrom=dtFrom.ToShortDateString();		
				string strTo=dtTo.ToShortDateString();

				string strCountryName=this.txtZhan.Text.Trim();

				string strSql=string.Format("select depShortName from tbDep where countryName='{0}'",strCountryName);

				DataTable dtDep=null;
				BengZhan.CDBConnection.getDataTable(ref dtDep,strSql,"dtDep");

				DataTable dtDisp=null;
				for(int i=0;i<dtDep.Rows.Count;i++)
				{
					string strDepName=dtDep.Rows[i]["depShortName"].ToString().Trim();
					DataTable dtMonthDep=null;			
					BengZhan.comReport.CReports.getDtMonthAvgReportDep(strDepName,strFrom,strTo,ref dtMonthDep);
					BengZhan.comReport.CReports.copyDt(dtMonthDep,ref dtDisp);
				}
						 

				string strTitle=string.Format("乡镇:{0}    时间范围:{1} 至 {2}    单位用水月统计表",strCountryName,strFromDisp,strToDisp);

				this.paintGridE(dtDisp,strTitle,3);

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}


		#endregion

		private void btnCer2_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.lblName.Text.IndexOf("单位")>=0)
				{
					this.monthStaticDep();
				}
				else
				{
					this.monthStaticCountry();
				}

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
			
		}
	
		#endregion

		private void btnPrint_Click(object sender, System.EventArgs e)
		{
			printDetail();
		}

		string strPrintTitle;
		XmlDocument m_xDocPrint;

		private void printDetail()
		{
			try
			{				
				string strCaption=this.dataGrid1.CaptionText.Trim();
				if((strCaption.IndexOf("：")<0)&&(strCaption.IndexOf(":")<0))				
				{
					MessageBox.Show("请先点击[确定]按钮！");
					return;
				}
				this.strPrintTitle=this.dataGrid1.CaptionText.Replace("单位用水统计表","");	
				
				if(this.m_xDocPrint==null)
				{
					this.m_xDocPrint=new XmlDocument();
					this.m_xDocPrint.Load(@"dep\repPrint.xml");
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

				cutePrint.cutePrinter dgp=new cutePrint.cutePrinter(this.dgPrint,"单位用水统计表",30);
			
				int iTimeMinus=int.Parse(xNode.Attributes.GetNamedItem("iTimeMinus").Value.Trim());
				dgp.iTimeMinus=iTimeMinus;
				dgp.leftMargin=int.Parse(xNode.Attributes.GetNamedItem("leftMargin").Value.Trim());				
				dgp.strTitle=this.strPrintTitle;
				dgp.bLandScape=false;

				dgp.Print();

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}			
		}

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

		private void  printDay()
		{
			try
			{
				string strCaption=this.dataGrid2.CaptionText.Trim();
				if(strCaption.IndexOf("：")<0&&strCaption.IndexOf(":")<0)				
				{
					MessageBox.Show("请先点击[确定]按钮！");
					return;
				}

				this.strPrintTitle=this.dataGrid2.CaptionText.Replace("单位用水日统计表","");				

				if(this.m_xDocPrint==null)
				{
					this.m_xDocPrint=new XmlDocument();
					this.m_xDocPrint.Load(@"dep\repPrint.xml");
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
		
				cutePrint.cutePrinter dgp=new cutePrint.cutePrinter(this.dgPrint,"单位用水日统计表",30);
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

		private void printMonth()
		{
			try
			{
				string strCaption=this.dataGrid3.CaptionText.Trim();
				if(strCaption.IndexOf("：")<0&&strCaption.IndexOf(":")<0)				
				{
					MessageBox.Show("请先点击[确定]按钮！");
					return;
				}
				this.strPrintTitle=this.dataGrid3.CaptionText.Replace("单位用水月统计表","");
				


				if(this.m_xDocPrint==null)
				{
					this.m_xDocPrint=new XmlDocument();
					this.m_xDocPrint.Load(@"dep\repPrint.xml");
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
		
				cutePrint.cutePrinter dgp=new cutePrint.cutePrinter(this.dgPrint,"单位用水月统计表",30);
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


		private void btnPrint1_Click(object sender, System.EventArgs e)
		{
			 this.printDay();
		}

		private void btnPrint2_Click(object sender, System.EventArgs e)
		{
			this.printMonth();
		}

	}
}

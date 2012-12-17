using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;
using System.Data;
using System.Data.SqlClient;

namespace CReportDll.comReport.newRep
{
	/// <summary>
	/// frmSalReportDep 的摘要说明。
	/// </summary>
	public class frmSalReportDep : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.TextBox txtZhan;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.DataGrid dgPrint;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.GroupBox groupBox11;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnHelp;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.NumericUpDown numEnd;
		private System.Windows.Forms.NumericUpDown numStart;
		private System.Windows.Forms.Button btnCer;
		private System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpFrom;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dtpTo1;
		private System.Windows.Forms.DateTimePicker dtpFrom1;
		private System.Windows.Forms.Button btnExit1;
		private System.Windows.Forms.Button btnHelp1;
		private System.Windows.Forms.Button btnPrint1;
		private System.Windows.Forms.Button btnCer1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.DataGrid dataGrid3;
		private System.Windows.Forms.GroupBox groupBox12;
		private System.Windows.Forms.Button btnExit2;
		private System.Windows.Forms.Button btnHelp2;
		private System.Windows.Forms.Button btnPrint2;
		private System.Windows.Forms.Button btnCer2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.NumericUpDown numTo;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtYearTo;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.NumericUpDown numFrom;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtYearFrom;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TreeView trvWel;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.ErrorProvider errorProvider2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cmbCountry;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.ComponentModel.IContainer components;

		public frmSalReportDep()
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
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.txtZhan = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.dgPrint = new System.Windows.Forms.DataGrid();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.groupBox11 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnHelp = new System.Windows.Forms.Button();
			this.btnPrint = new System.Windows.Forms.Button();
			this.numEnd = new System.Windows.Forms.NumericUpDown();
			this.numStart = new System.Windows.Forms.NumericUpDown();
			this.btnCer = new System.Windows.Forms.Button();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.btnExit = new System.Windows.Forms.Button();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.dataGrid2 = new System.Windows.Forms.DataGrid();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtpTo1 = new System.Windows.Forms.DateTimePicker();
			this.dtpFrom1 = new System.Windows.Forms.DateTimePicker();
			this.btnExit1 = new System.Windows.Forms.Button();
			this.btnHelp1 = new System.Windows.Forms.Button();
			this.btnPrint1 = new System.Windows.Forms.Button();
			this.btnCer1 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.groupBox10 = new System.Windows.Forms.GroupBox();
			this.dataGrid3 = new System.Windows.Forms.DataGrid();
			this.groupBox12 = new System.Windows.Forms.GroupBox();
			this.btnExit2 = new System.Windows.Forms.Button();
			this.btnHelp2 = new System.Windows.Forms.Button();
			this.btnPrint2 = new System.Windows.Forms.Button();
			this.btnCer2 = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.numTo = new System.Windows.Forms.NumericUpDown();
			this.label11 = new System.Windows.Forms.Label();
			this.txtYearTo = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.numFrom = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.txtYearFrom = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.trvWel = new System.Windows.Forms.TreeView();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.errorProvider2 = new System.Windows.Forms.ErrorProvider();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmbCountry = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
			this.groupBox6.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.groupBox8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgPrint)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.groupBox11.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numEnd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numStart)).BeginInit();
			this.tabPage5.SuspendLayout();
			this.groupBox9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.tabPage6.SuspendLayout();
			this.groupBox10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).BeginInit();
			this.groupBox12.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numTo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numFrom)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.txtZhan);
			this.groupBox6.Controls.Add(this.lblName);
			this.groupBox6.Location = new System.Drawing.Point(0, 3);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(176, 48);
			this.groupBox6.TabIndex = 31;
			this.groupBox6.TabStop = false;
			// 
			// txtZhan
			// 
			this.txtZhan.Location = new System.Drawing.Point(72, 16);
			this.txtZhan.Name = "txtZhan";
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
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Controls.Add(this.tabPage6);
			this.tabControl1.Location = new System.Drawing.Point(176, 11);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(840, 640);
			this.tabControl1.TabIndex = 32;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged_1);
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.groupBox8);
			this.tabPage4.Controls.Add(this.groupBox11);
			this.tabPage4.Location = new System.Drawing.Point(4, 21);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(832, 615);
			this.tabPage4.TabIndex = 0;
			this.tabPage4.Text = "明细表";
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.dgPrint);
			this.groupBox8.Controls.Add(this.dataGrid1);
			this.groupBox8.Controls.Add(this.comboBox1);
			this.groupBox8.Location = new System.Drawing.Point(0, 48);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(832, 568);
			this.groupBox8.TabIndex = 28;
			this.groupBox8.TabStop = false;
			// 
			// dgPrint
			// 
			this.dgPrint.DataMember = "";
			this.dgPrint.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgPrint.Location = new System.Drawing.Point(112, 136);
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
			// comboBox1
			// 
			this.comboBox1.Location = new System.Drawing.Point(56, 64);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(96, 20);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.Visible = false;
			// 
			// groupBox11
			// 
			this.groupBox11.Controls.Add(this.label5);
			this.groupBox11.Controls.Add(this.label1);
			this.groupBox11.Controls.Add(this.btnHelp);
			this.groupBox11.Controls.Add(this.btnPrint);
			this.groupBox11.Controls.Add(this.numEnd);
			this.groupBox11.Controls.Add(this.numStart);
			this.groupBox11.Controls.Add(this.btnCer);
			this.groupBox11.Controls.Add(this.dtpTo);
			this.groupBox11.Controls.Add(this.label4);
			this.groupBox11.Controls.Add(this.dtpFrom);
			this.groupBox11.Controls.Add(this.btnExit);
			this.groupBox11.Location = new System.Drawing.Point(0, 0);
			this.groupBox11.Name = "groupBox11";
			this.groupBox11.Size = new System.Drawing.Size(832, 48);
			this.groupBox11.TabIndex = 27;
			this.groupBox11.TabStop = false;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(432, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(24, 24);
			this.label5.TabIndex = 12;
			this.label5.Text = "时";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 23);
			this.label1.TabIndex = 11;
			this.label1.Text = "时间范围：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnHelp
			// 
			this.btnHelp.Location = new System.Drawing.Point(576, 15);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(56, 23);
			this.btnHelp.TabIndex = 10;
			this.btnHelp.Text = "帮助";
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(520, 15);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(56, 23);
			this.btnPrint.TabIndex = 8;
			this.btnPrint.Text = "打印";
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// numEnd
			// 
			this.numEnd.Location = new System.Drawing.Point(392, 16);
			this.numEnd.Maximum = new System.Decimal(new int[] {
																   23,
																   0,
																   0,
																   0});
			this.numEnd.Name = "numEnd";
			this.numEnd.Size = new System.Drawing.Size(32, 21);
			this.numEnd.TabIndex = 7;
			this.numEnd.Value = new System.Decimal(new int[] {
																 9,
																 0,
																 0,
																 0});
			// 
			// numStart
			// 
			this.numStart.Location = new System.Drawing.Point(192, 16);
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
			// btnCer
			// 
			this.btnCer.Location = new System.Drawing.Point(464, 15);
			this.btnCer.Name = "btnCer";
			this.btnCer.Size = new System.Drawing.Size(56, 23);
			this.btnCer.TabIndex = 3;
			this.btnCer.Text = "确认";
			this.btnCer.Click += new System.EventHandler(this.btnCer_Click);
			// 
			// dtpTo
			// 
			this.dtpTo.Location = new System.Drawing.Point(280, 16);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(112, 21);
			this.dtpTo.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(224, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 23);
			this.label4.TabIndex = 1;
			this.label4.Text = "时至：";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpFrom
			// 
			this.dtpFrom.Location = new System.Drawing.Point(80, 16);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.Size = new System.Drawing.Size(112, 21);
			this.dtpFrom.TabIndex = 0;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(632, 15);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(56, 23);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.groupBox9);
			this.tabPage5.Controls.Add(this.groupBox1);
			this.tabPage5.Location = new System.Drawing.Point(4, 21);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new System.Drawing.Size(832, 615);
			this.tabPage5.TabIndex = 1;
			this.tabPage5.Text = "日统计表";
			this.tabPage5.Visible = false;
			// 
			// groupBox9
			// 
			this.groupBox9.Controls.Add(this.dataGrid2);
			this.groupBox9.Location = new System.Drawing.Point(0, 48);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(832, 568);
			this.groupBox9.TabIndex = 2;
			this.groupBox9.TabStop = false;
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
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtpTo1);
			this.groupBox1.Controls.Add(this.dtpFrom1);
			this.groupBox1.Controls.Add(this.btnExit1);
			this.groupBox1.Controls.Add(this.btnHelp1);
			this.groupBox1.Controls.Add(this.btnPrint1);
			this.groupBox1.Controls.Add(this.btnCer1);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(832, 48);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// dtpTo1
			// 
			this.dtpTo1.Location = new System.Drawing.Point(216, 17);
			this.dtpTo1.Name = "dtpTo1";
			this.dtpTo1.Size = new System.Drawing.Size(104, 21);
			this.dtpTo1.TabIndex = 9;
			// 
			// dtpFrom1
			// 
			this.dtpFrom1.Location = new System.Drawing.Point(72, 16);
			this.dtpFrom1.Name = "dtpFrom1";
			this.dtpFrom1.Size = new System.Drawing.Size(104, 21);
			this.dtpFrom1.TabIndex = 8;
			// 
			// btnExit1
			// 
			this.btnExit1.Location = new System.Drawing.Point(496, 16);
			this.btnExit1.Name = "btnExit1";
			this.btnExit1.Size = new System.Drawing.Size(56, 23);
			this.btnExit1.TabIndex = 7;
			this.btnExit1.Text = "退出";
			this.btnExit1.Click += new System.EventHandler(this.btnExit1_Click);
			// 
			// btnHelp1
			// 
			this.btnHelp1.Location = new System.Drawing.Point(440, 16);
			this.btnHelp1.Name = "btnHelp1";
			this.btnHelp1.Size = new System.Drawing.Size(56, 23);
			this.btnHelp1.TabIndex = 6;
			this.btnHelp1.Text = "帮助";
			// 
			// btnPrint1
			// 
			this.btnPrint1.Location = new System.Drawing.Point(384, 16);
			this.btnPrint1.Name = "btnPrint1";
			this.btnPrint1.Size = new System.Drawing.Size(56, 23);
			this.btnPrint1.TabIndex = 5;
			this.btnPrint1.Text = "打印";
			this.btnPrint1.Click += new System.EventHandler(this.btnPrint1_Click);
			// 
			// btnCer1
			// 
			this.btnCer1.Location = new System.Drawing.Point(328, 16);
			this.btnCer1.Name = "btnCer1";
			this.btnCer1.Size = new System.Drawing.Size(56, 23);
			this.btnCer1.TabIndex = 4;
			this.btnCer1.Text = "确认";
			this.btnCer1.Click += new System.EventHandler(this.btnCer1_Click);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(184, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(24, 23);
			this.label7.TabIndex = 2;
			this.label7.Text = "至";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 23);
			this.label6.TabIndex = 0;
			this.label6.Text = "时间范围：";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tabPage6
			// 
			this.tabPage6.Controls.Add(this.groupBox10);
			this.tabPage6.Controls.Add(this.groupBox12);
			this.tabPage6.Location = new System.Drawing.Point(4, 21);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Size = new System.Drawing.Size(832, 615);
			this.tabPage6.TabIndex = 2;
			this.tabPage6.Text = "月统计表";
			this.tabPage6.Visible = false;
			// 
			// groupBox10
			// 
			this.groupBox10.Controls.Add(this.dataGrid3);
			this.groupBox10.Location = new System.Drawing.Point(0, 48);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new System.Drawing.Size(832, 568);
			this.groupBox10.TabIndex = 2;
			this.groupBox10.TabStop = false;
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
			// groupBox12
			// 
			this.groupBox12.Controls.Add(this.btnExit2);
			this.groupBox12.Controls.Add(this.btnHelp2);
			this.groupBox12.Controls.Add(this.btnPrint2);
			this.groupBox12.Controls.Add(this.btnCer2);
			this.groupBox12.Controls.Add(this.label12);
			this.groupBox12.Controls.Add(this.numTo);
			this.groupBox12.Controls.Add(this.label11);
			this.groupBox12.Controls.Add(this.txtYearTo);
			this.groupBox12.Controls.Add(this.label10);
			this.groupBox12.Controls.Add(this.numFrom);
			this.groupBox12.Controls.Add(this.label9);
			this.groupBox12.Controls.Add(this.txtYearFrom);
			this.groupBox12.Controls.Add(this.label8);
			this.groupBox12.Location = new System.Drawing.Point(0, 0);
			this.groupBox12.Name = "groupBox12";
			this.groupBox12.Size = new System.Drawing.Size(832, 48);
			this.groupBox12.TabIndex = 1;
			this.groupBox12.TabStop = false;
			// 
			// btnExit2
			// 
			this.btnExit2.Location = new System.Drawing.Point(512, 16);
			this.btnExit2.Name = "btnExit2";
			this.btnExit2.Size = new System.Drawing.Size(56, 23);
			this.btnExit2.TabIndex = 13;
			this.btnExit2.Text = "退出";
			this.btnExit2.Click += new System.EventHandler(this.btnExit2_Click);
			// 
			// btnHelp2
			// 
			this.btnHelp2.Location = new System.Drawing.Point(456, 16);
			this.btnHelp2.Name = "btnHelp2";
			this.btnHelp2.Size = new System.Drawing.Size(56, 23);
			this.btnHelp2.TabIndex = 12;
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
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(320, 16);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(16, 23);
			this.label12.TabIndex = 8;
			this.label12.Text = "月";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numTo
			// 
			this.numTo.Location = new System.Drawing.Point(288, 16);
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
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(264, 17);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(24, 23);
			this.label11.TabIndex = 6;
			this.label11.Text = "年";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtYearTo
			// 
			this.txtYearTo.Location = new System.Drawing.Point(216, 17);
			this.txtYearTo.Name = "txtYearTo";
			this.txtYearTo.Size = new System.Drawing.Size(40, 21);
			this.txtYearTo.TabIndex = 5;
			this.txtYearTo.Text = "";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(176, 17);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(32, 23);
			this.label10.TabIndex = 4;
			this.label10.Text = "月至";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numFrom
			// 
			this.numFrom.Location = new System.Drawing.Point(136, 17);
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
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(112, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(24, 23);
			this.label9.TabIndex = 2;
			this.label9.Text = "年";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtYearFrom
			// 
			this.txtYearFrom.Location = new System.Drawing.Point(72, 16);
			this.txtYearFrom.Name = "txtYearFrom";
			this.txtYearFrom.Size = new System.Drawing.Size(40, 21);
			this.txtYearFrom.TabIndex = 1;
			this.txtYearFrom.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 24);
			this.label8.TabIndex = 0;
			this.label8.Text = "时间范围：";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.trvWel);
			this.groupBox3.Location = new System.Drawing.Point(0, 51);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(176, 600);
			this.groupBox3.TabIndex = 33;
			this.groupBox3.TabStop = false;
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
			// errorProvider2
			// 
			this.errorProvider2.ContainerControl = this;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmbCountry);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(0, 5);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(176, 48);
			this.groupBox2.TabIndex = 30;
			this.groupBox2.TabStop = false;
			// 
			// cmbCountry
			// 
			this.cmbCountry.Location = new System.Drawing.Point(72, 16);
			this.cmbCountry.Name = "cmbCountry";
			this.cmbCountry.Size = new System.Drawing.Size(96, 20);
			this.cmbCountry.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "所属乡镇：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// frmSalReportDep
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(1016, 654);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Name = "frmSalReportDep";
			this.Text = "单位购水统计表";
			this.Load += new System.EventHandler(this.frmSalReportDep_Load);
			this.groupBox6.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgPrint)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.groupBox11.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numEnd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numStart)).EndInit();
			this.tabPage5.ResumeLayout(false);
			this.groupBox9.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.tabPage6.ResumeLayout(false);
			this.groupBox10.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).EndInit();
			this.groupBox12.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numTo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numFrom)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region"dealWindow"

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

		XmlDocument m_xDocRep;

		private bool paintGrid()
		{
			try
			{
				if(this.m_xDocRep==null)
				{
					this.m_xDocRep=new XmlDocument();
					this.m_xDocRep.Load(@"dep\salRep.xml");
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

				this.dataGrid1.CaptionText="单位购水统计表";
				
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
				this.dataGrid2.CaptionText="单位购水日统计表";
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
				this.dataGrid3.CaptionText="单位购水月统计表";
				this.dataGrid3.ReadOnly=true;
						
				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}


		private void frmSalReportDep_Load(object sender, System.EventArgs e)
		{
			this.paintFrm();
			this.trvWel.SelectedNode=this.trvWel.Nodes[0];
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
				this.paintNum();
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void paintNum()
		{
			try
			{
				this.txtYearFrom.Text=System.DateTime.Now.Year.ToString();
				this.txtYearTo.Text=System.DateTime.Now.Year.ToString();

				this.numEnd.Maximum=23;
				this.numStart.Maximum=23;
			

				this.numStart.Minimum=0;
				this.numEnd.Minimum=0;


				this.numStart.Value=0;
				this.numEnd.Value=23;
				this.numFrom.Value=System.DateTime.Now.Month;
				this.numTo.Value=System.DateTime.Now.Month;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		string m_strSelNodeType="";

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
							this.lblName.Text="乡镇：";
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
						this.lblName.Text="单位：";
						this.txtZhan.Text=this.trvWel.SelectedNode.Text.Trim();
						return;
					}
					else
					{
						if(this.trvWel.SelectedNode.Nodes[0].Text.IndexOf("|")>=0)
						{
							this.lblName.Text="单位：";
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
			try
			{
				this.paintSelectedWell();
				if(this.trvWel.SelectedNode!=null)
				{				
				}
				if(this.trvWel.SelectedNode.Nodes.Count==0)
				{
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

		#endregion

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

		private void tabControl1_SelectedIndexChanged_1(object sender, System.EventArgs e)
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

		private void btnCer_Click(object sender, System.EventArgs e)
		{
			if(this.trvWel.SelectedNode.Text.IndexOf("列表")>=0)			
			{
				return;
			}

			if(this.lblName.Text.IndexOf("单位")>=0)
			{
				detailRepDep();
			}				
			else
			{
				this.detailRepCountry();				
			}	
		
			this.paintOneLine();
		}

		#region"报表"

		#region"明细统计"

		private void detailRepCountry()
		{
			try			
			{
				string strFrom=this.dtpFrom.Value.ToShortDateString();
				strFrom=strFrom+" "+this.numStart.Value.ToString().Trim()+":00:00";
				string strTo=this.dtpTo.Value.ToShortDateString();
				strTo=strTo+" "+this.numEnd.Value.ToString().Trim()+":00:00";

				string strCountryName=this.txtZhan.Text.Trim();
				string strSql=string.Format("select depShortName from tbDep where countryName='{0}'",strCountryName);
				DataTable dtDep=new DataTable();

				BengZhan.CDBConnection.getDataTable(ref dtDep,strSql,"depName");

				DataTable dtRet=new DataTable();
				DataTable dtDetail=new DataTable();

				for(int i=0;i<dtDep.Rows.Count;i++)
				{
					string strDepName=dtDep.Rows[i]["depShortName"].ToString().Trim();
					if(this.getDtStatcDep(strDepName,strFrom,strTo,ref dtDetail)==false)
					{
						return;
					}
					BengZhan.comReport.CReports.copyDt(dtDetail,ref dtRet);
				}
				dtDetail=dtRet;

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
				string strCapText=string.Format("乡镇：{0}    {1}至{2}    单位购水统计表",strCountryName,strFrom,strTo);
				this.dataGrid1.CaptionText=strCapText;			
				this.paintOneLine();

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
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

				string strDepName=this.txtZhan.Text.Trim();	

				DataTable dtDetail=new DataTable();

				if(this.getDtStatcDep(strDepName,strFrom,strTo,ref dtDetail)==false)
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

				string strCapText=string.Format("单位：{0}    {1}至{2}    单位购水统计表",strDepName,strFrom,strTo);
				this.dataGrid1.CaptionText=strCapText;
			
				this.paintOneLine();

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private bool getDtStatcDep(string strDepName,string strFrom,string strEnd,ref DataTable dtStatcDep)
		{
			try
			{
				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();

				dtStatcDep=new DataTable();

				SqlCommand sCmd=new SqlCommand();
				sCmd.CommandType=CommandType.StoredProcedure;
				sCmd.Connection=sCon;
				sCmd.CommandText="staticDepSal";

				sCmd.Parameters.Add("@depName",SqlDbType.NVarChar,40);
				sCmd.Parameters.Add("@startTime",SqlDbType.NVarChar,40);
				sCmd.Parameters.Add("@endTime",SqlDbType.NVarChar,40);
				sCmd.Parameters["@depName"].Value=strDepName;
				sCmd.Parameters["@startTime"].Value=strFrom;
				sCmd.Parameters["@endTime"].Value=strEnd;

				SqlDataAdapter sda=new SqlDataAdapter();
				sda.SelectCommand=sCmd;

				sda.Fill(dtStatcDep);

				sCon.Close();

				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}

		#endregion

		#region"日统计"

		private void dayStaticDep()
		{
			try
			{
				string strDepName=this.txtZhan.Text.Trim();
				string strFrom=this.dtpFrom1.Value.ToShortDateString();		
				string strTo=this.dtpTo1.Value.ToShortDateString();
				DataTable dtAvg=new DataTable();
				CReportDll.comReport.CSalReport.getDtAvgReportDep(strDepName,strFrom,strTo,ref dtAvg);

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
				
				string strTitle=string.Format("单位:{0}    时间范围  {1}  至  {2}    单位购水日统计表",strDepName,strFrom,strTo);

				this.dataGrid2.CaptionText=strTitle;

                
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
				string strCountryName=this.txtZhan.Text.Trim();
				string strSql=string.Format("select depShortName from  tbDep where countryName='{0}'",strCountryName);
				DataTable dtDep=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtDep,strSql,"dtDep");

				string strFrom=this.dtpFrom1.Value.ToShortDateString();		
				string strTo=this.dtpTo1.Value.ToShortDateString();

				DataTable dtRet=new DataTable();
				DataTable dtAvg=new DataTable();

				for(int i=0;i<dtDep.Rows.Count;i++)
				{
					string strDepName=dtDep.Rows[i]["depShortName"].ToString().Trim();
					
					dtAvg=new DataTable();
					CReportDll.comReport.CSalReport.getDtAvgReportDep(strDepName,strFrom,strTo,ref dtAvg);
					BengZhan.comReport.CReports.copyDt(dtAvg,ref dtRet);
				}

				dtAvg=dtRet;						
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
				
				string strTitle=string.Format("乡镇:{0}    时间范围  {1}  至  {2}     单位购水日统计表",strCountryName,strFrom,strTo);

				this.dataGrid2.CaptionText=strTitle;

                
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
				string strDepName=this.txtZhan.Text.Trim();

				DateTime dtFrom=new DateTime();
				DateTime dtTo=new DateTime();

				if(this.txtYearFrom.Text.Trim().Length!=4)
				{
					MessageBox.Show("查询起始年份输入有误，其长度应为4位！");
					return;
				}

				if(this.txtYearTo.Text.Trim().Length!=4)
				{
					MessageBox.Show("查询截止年份输入有误，其长度应为4位！");
					return;
				}

				try
				{
					string strTime=this.txtYearFrom.Text.Trim()+"-"+this.numFrom.Value.ToString().Trim()+"-1";
					dtFrom=DateTime.Parse(strTime);
					strTime=this.txtYearTo.Text.Trim()+"-"+this.numTo.Value.ToString().Trim()+"-1";
					dtTo=DateTime.Parse(strTime);
				}
				catch(Exception e)
				{
					MessageBox.Show("查询起始、截止时间输入有误！");
				}

				string strFrom=dtFrom.ToShortDateString();		
				string strTo=dtTo.ToShortDateString();	

				DataTable dtAvgMonth=new DataTable();

				DataTable dtAvg=new DataTable();

				CReportDll.comReport.CSalReport.getDtAvgReportDepMonth(strDepName,strFrom,strTo,ref dtAvgMonth);

				dtAvg=dtAvgMonth; 			
				
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

				
				strFrom=dtFrom.Year.ToString()+"年"+dtFrom.Month.ToString()+"月";
				
				strTo=dtTo.Year.ToString()+"年"+dtTo.Month.ToString()+"月";

this.dataGrid3.CaptionText=string.Format("单位：{0}      时间范围：  {1}  至  {2}    单位购水月统计表",strDepName,strFrom,strTo);

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
					MessageBox.Show("查询起始年份输入有误，其长度应为4位！");
					return;
				}

				if(this.txtYearTo.Text.Trim().Length!=4)
				{
					MessageBox.Show("查询截止年份输入有误，其长度应为4位！");
					return;
				}

				try
				{
					string strTime=this.txtYearFrom.Text.Trim()+"-"+this.numFrom.Value.ToString().Trim()+"-1";
					dtFrom=DateTime.Parse(strTime);
					strTime=this.txtYearTo.Text.Trim()+"-"+this.numTo.Value.ToString().Trim()+"-1";
					dtTo=DateTime.Parse(strTime);
				}
				catch(Exception e)
				{
					MessageBox.Show("查询起始、截止时间输入有误！");
				}

				string strFrom=dtFrom.ToShortDateString();		
				string strTo=dtTo.ToShortDateString();	

				string strCountryName=this.txtZhan.Text.Trim();
				string strSql=string.Format("select depShortName from tbDep where countryName='{0}'",strCountryName);
				DataTable dtDep=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtDep,strSql,"depName");

				DataTable dtRet=new DataTable();
				DataTable dtAvg=new DataTable();

				for(int i=0;i<dtDep.Rows.Count;i++)
				{
					string strDepName=dtDep.Rows[i]["depShortName"].ToString().Trim();
					CReportDll.comReport.CSalReport.getDtAvgReportDepMonth(strDepName,strFrom,strTo,ref dtAvg);
					BengZhan.comReport.CReports.copyDt(dtAvg,ref dtRet);
				}

				dtAvg=dtRet;

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

				
				strFrom=dtFrom.Year.ToString()+"年"+dtFrom.Month.ToString()+"月";
				
				strTo=dtTo.Year.ToString()+"年"+dtTo.Month.ToString()+"月";

				this.dataGrid3.CaptionText=string.Format("乡镇：{0}      时间范围： {1}  至  {2}    单位购水月统计表",strCountryName,strFrom,strTo);


			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		#endregion

		#endregion

		private void btnCer1_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.lblName.Text.IndexOf("单位")>=0)				
				{
					this.dayStaticDep();
				}
				else
				{
					this.dayStaticCountry();
				}

				this.paintOneLine();
			}
			catch(Exception ex)			
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

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
				this.paintOneLine();
			}
			catch(Exception ex)			
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		#region"打印"

		private void btnPrint_Click(object sender, System.EventArgs e)
		{
			this.printDetail();
		}

		private void btnPrint1_Click(object sender, System.EventArgs e)
		{
			this.printDay();		
		}

		private void btnPrint2_Click(object sender, System.EventArgs e)
		{
				this.printMonth();	
		}

		XmlDocument m_xDocPrint;

		private void printDetail()
		{
			try
			{
				if(this.m_xDocPrint==null)
				{
					this.m_xDocPrint=new XmlDocument();
					this.m_xDocPrint.Load(@"dep\salRepPrint.xml");
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

				for(int i=0;i<this.dgPrint.TableStyles[0].GridColumnStyles.Count;i++)
				{
					this.dgPrint.TableStyles[0].GridColumnStyles[i].HeaderText="text"+i.ToString();
					this.dgPrint.TableStyles[0].GridColumnStyles[i].MappingName="field"+i.ToString();
				}

				for(int i=0;i<this.dataGrid1.TableStyles[0].GridColumnStyles.Count;i++)
				{
					this.dgPrint.TableStyles[0].GridColumnStyles[i].MappingName=this.dataGrid1.TableStyles[0].GridColumnStyles[i].MappingName;
					this.dgPrint.TableStyles[0].GridColumnStyles[i].HeaderText=this.dataGrid1.TableStyles[0].GridColumnStyles[i].HeaderText;
				}

				DataTable dtPrint=(DataTable)this.dgPrint.DataSource;
				DataTable dtDetail=(DataTable)this.dataGrid1.DataSource;

				for(int i=0;i<dtDetail.Rows.Count;i++)
				{
					dtPrint.ImportRow(dtDetail.Rows[i]);
				}						 
				this.clearBlankRow(dtPrint);

				string strTitle=this.dataGrid1.CaptionText.Trim();
				string strTitleE="";

				if(strTitle.IndexOf("操作员")>=0)				
				{
					strTitleE="操作员售水明细表";
				}
				else
				{
					strTitleE="单位购水统计表";
				}
				strTitle=strTitle.Replace(strTitleE,"");				

				cutePrint.cutePrinter dgp=new cutePrint.cutePrinter(this.dgPrint,strTitleE,30);
				
				int iTimeMinus=int.Parse(xNode.Attributes.GetNamedItem("iTimeMinus").Value.Trim());
				dgp.iTimeMinus=iTimeMinus;
				dgp.leftMargin=int.Parse(xNode.Attributes.GetNamedItem("leftMargin").Value.Trim());
				dgp.strTitle=strTitle;
				dgp.bLandScape=false;
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
				if(this.m_xDocPrint==null)
				{
					this.m_xDocPrint=new XmlDocument();
					this.m_xDocPrint.Load(@"dep\salRepPrint.xml");
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

				for(int i=0;i<this.dgPrint.TableStyles[0].GridColumnStyles.Count;i++)
				{
					this.dgPrint.TableStyles[0].GridColumnStyles[i].HeaderText="text"+i.ToString();
					this.dgPrint.TableStyles[0].GridColumnStyles[i].MappingName="field"+i.ToString();
				}

				for(int i=0;i<this.dataGrid2.TableStyles[0].GridColumnStyles.Count;i++)
				{
					this.dgPrint.TableStyles[0].GridColumnStyles[i].MappingName=this.dataGrid2.TableStyles[0].GridColumnStyles[i].MappingName;
					this.dgPrint.TableStyles[0].GridColumnStyles[i].HeaderText=this.dataGrid2.TableStyles[0].GridColumnStyles[i].HeaderText;
				}


				DataTable dtPrint=(DataTable)this.dgPrint.DataSource;
				DataTable dtDetail=(DataTable)this.dataGrid2.DataSource;

				for(int i=0;i<dtDetail.Rows.Count;i++)
				{
					dtPrint.ImportRow(dtDetail.Rows[i]);
				}	
				this.clearBlankRow(dtPrint);	
 
				string strTitle=this.dataGrid2.CaptionText.Trim();
				string strTitleE="";
				if(strTitle.IndexOf("操作员")>=0)
				{
					strTitleE="操作员售水日统计表";
				}
				else
				{
					strTitleE="单位购水日统计表";
				}
				strTitle=strTitle.Replace(strTitleE,"");

		
				cutePrint.cutePrinter dgp=new cutePrint.cutePrinter(this.dgPrint,strTitleE,30);
				int iTimeMinus=int.Parse(xNode.Attributes.GetNamedItem("iTimeMinus").Value.Trim());
				dgp.iTimeMinus=iTimeMinus;
				dgp.leftMargin=int.Parse(xNode.Attributes.GetNamedItem("leftMargin").Value.Trim());
				dgp.strTitle=strTitle;
				dgp.bLandScape=false;
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
				if(this.m_xDocPrint==null)
				{
					this.m_xDocPrint=new XmlDocument();
					this.m_xDocPrint.Load(@"dep\salRepPrint.xml");
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

				for(int i=0;i<this.dgPrint.TableStyles[0].GridColumnStyles.Count;i++)
				{
					this.dgPrint.TableStyles[0].GridColumnStyles[i].HeaderText="text"+i.ToString();
					this.dgPrint.TableStyles[0].GridColumnStyles[i].MappingName="field"+i.ToString();
				}

				for(int i=0;i<this.dataGrid3.TableStyles[0].GridColumnStyles.Count;i++)
				{
					this.dgPrint.TableStyles[0].GridColumnStyles[i].MappingName=this.dataGrid3.TableStyles[0].GridColumnStyles[i].MappingName;
					this.dgPrint.TableStyles[0].GridColumnStyles[i].HeaderText=this.dataGrid3.TableStyles[0].GridColumnStyles[i].HeaderText;
				}

				DataTable dtPrint=(DataTable)this.dgPrint.DataSource;
				DataTable dtDetail=(DataTable)this.dataGrid3.DataSource;


				for(int i=0;i<dtDetail.Rows.Count;i++)
				{
					dtPrint.ImportRow(dtDetail.Rows[i]);
				}	
				this.clearBlankRow(dtPrint);	
 
				string strTitle=this.dataGrid3.CaptionText.Trim();
				string strTitleE="";

				if(strTitle.IndexOf("操作员")>=0)
				{
					strTitleE="操作员售水月统计表";
					strTitle=strTitle.Substring(0,strTitle.IndexOf("操作员售水月统计表"));
				}
				else
				{
					strTitleE="单位购水日统计表";
					strTitle=strTitle.Substring(0,strTitle.IndexOf("单位购水月统计表"));
				}
		
				cutePrint.cutePrinter dgp=new cutePrint.cutePrinter(this.dgPrint,strTitleE,30);
				int iTimeMinus=int.Parse(xNode.Attributes.GetNamedItem("iTimeMinus").Value.Trim());
				dgp.iTimeMinus=iTimeMinus;	
				dgp.leftMargin=int.Parse(xNode.Attributes.GetNamedItem("leftMargin").Value.Trim());
				dgp.strTitle=strTitle;	
						dgp.bLandScape=false;
				dgp.Print();
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}			
		}

		#endregion
		
		
	}
}

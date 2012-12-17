using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Data.OleDb;

namespace CReportDll.comReport.newRep
{
	/// <summary>
	/// frmSalReport 的摘要说明。
	/// </summary>
	public class frmSalReport : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.ErrorProvider errorProvider2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cmbCountry;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.GroupBox groupBox11;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox12;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btnCer2;
		private System.Windows.Forms.Button btnPrint2;
		private System.Windows.Forms.Button btnHelp2;
		private System.Windows.Forms.Button btnExit2;
		private System.Windows.Forms.NumericUpDown numTo;
		private System.Windows.Forms.TextBox txtYearTo;
		private System.Windows.Forms.NumericUpDown numFrom;
		private System.Windows.Forms.TextBox txtYearFrom;
		private System.Windows.Forms.NumericUpDown numEnd;
		private System.Windows.Forms.NumericUpDown numStart;
		private System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.DateTimePicker dtpFrom;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnExit1;
		private System.Windows.Forms.Button btnHelp1;
		private System.Windows.Forms.Button btnPrint1;
		private System.Windows.Forms.Button btnCer1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.DataGrid dataGrid3;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnHelp;
		private System.Windows.Forms.Button btnCer;
		private System.Windows.Forms.DataGrid dgPrint;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TreeView trvWel;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.TextBox txtZhan;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.DateTimePicker dtpFrom1;
		private System.Windows.Forms.DateTimePicker dtpTo1;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.GroupBox groupBox13;
		private System.Windows.Forms.DataGrid dataGrid5;
		private System.Windows.Forms.NumericUpDown numTo1;
		private System.Windows.Forms.TextBox txtYearTo1;
		private System.Windows.Forms.NumericUpDown numFrom1;
		private System.Windows.Forms.TextBox txtYearFrom1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button btnP5;
		private System.Windows.Forms.Button btnCer5;
		private System.Windows.Forms.Button btnE5;
		private System.Windows.Forms.NumericUpDown numHT;
		private System.Windows.Forms.NumericUpDown numHF;
		private System.Windows.Forms.DateTimePicker dtpT;
		private System.Windows.Forms.DateTimePicker dtpF;
		private System.Windows.Forms.DataGrid dgURep;
		private System.ComponentModel.IContainer components;

		public frmSalReport()
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
			this.errorProvider2 = new System.Windows.Forms.ErrorProvider();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmbCountry = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.dgPrint = new System.Windows.Forms.DataGrid();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
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
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox13 = new System.Windows.Forms.GroupBox();
			this.dataGrid5 = new System.Windows.Forms.DataGrid();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.label17 = new System.Windows.Forms.Label();
			this.numTo1 = new System.Windows.Forms.NumericUpDown();
			this.label18 = new System.Windows.Forms.Label();
			this.txtYearTo1 = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.numFrom1 = new System.Windows.Forms.NumericUpDown();
			this.label20 = new System.Windows.Forms.Label();
			this.txtYearFrom1 = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
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
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.dgURep = new System.Windows.Forms.DataGrid();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.btnP5 = new System.Windows.Forms.Button();
			this.numHT = new System.Windows.Forms.NumericUpDown();
			this.numHF = new System.Windows.Forms.NumericUpDown();
			this.btnCer5 = new System.Windows.Forms.Button();
			this.dtpT = new System.Windows.Forms.DateTimePicker();
			this.label14 = new System.Windows.Forms.Label();
			this.dtpF = new System.Windows.Forms.DateTimePicker();
			this.btnE5 = new System.Windows.Forms.Button();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.trvWel = new System.Windows.Forms.TreeView();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.groupBox6.SuspendLayout();
			this.groupBox2.SuspendLayout();
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
			this.tabPage2.SuspendLayout();
			this.groupBox13.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid5)).BeginInit();
			this.groupBox7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numTo1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numFrom1)).BeginInit();
			this.tabPage6.SuspendLayout();
			this.groupBox10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).BeginInit();
			this.groupBox12.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numTo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numFrom)).BeginInit();
			this.tabPage1.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgURep)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numHT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numHF)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.txtZhan);
			this.groupBox6.Controls.Add(this.lblName);
			this.groupBox6.Location = new System.Drawing.Point(0, 0);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(176, 48);
			this.groupBox6.TabIndex = 27;
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
			this.lblName.Click += new System.EventHandler(this.label3_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.Location = new System.Drawing.Point(56, 64);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(96, 20);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.Visible = false;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// errorProvider2
			// 
			this.errorProvider2.ContainerControl = this;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmbCountry);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(0, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(176, 48);
			this.groupBox2.TabIndex = 23;
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
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage6);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Location = new System.Drawing.Point(176, 8);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.ShowToolTips = true;
			this.tabControl1.Size = new System.Drawing.Size(840, 640);
			this.tabControl1.TabIndex = 28;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
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
			this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(520, 15);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(56, 23);
			this.btnPrint.TabIndex = 8;
			this.btnPrint.Text = "打印";
			this.btnPrint.Click += new System.EventHandler(this.button3_Click);
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
																   9,
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
			this.btnCer.Click += new System.EventHandler(this.button4_Click);
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
			this.btnExit.Click += new System.EventHandler(this.button5_Click);
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
			this.btnHelp1.Click += new System.EventHandler(this.btnHelp1_Click);
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
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupBox13);
			this.tabPage2.Controls.Add(this.groupBox7);
			this.tabPage2.Location = new System.Drawing.Point(4, 21);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(832, 615);
			this.tabPage2.TabIndex = 4;
			this.tabPage2.Text = "本月用水统计表";
			// 
			// groupBox13
			// 
			this.groupBox13.Controls.Add(this.dataGrid5);
			this.groupBox13.Location = new System.Drawing.Point(0, 48);
			this.groupBox13.Name = "groupBox13";
			this.groupBox13.Size = new System.Drawing.Size(832, 568);
			this.groupBox13.TabIndex = 1;
			this.groupBox13.TabStop = false;
			// 
			// dataGrid5
			// 
			this.dataGrid5.DataMember = "";
			this.dataGrid5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGrid5.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid5.Location = new System.Drawing.Point(3, 17);
			this.dataGrid5.Name = "dataGrid5";
			this.dataGrid5.Size = new System.Drawing.Size(826, 548);
			this.dataGrid5.TabIndex = 0;
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.button5);
			this.groupBox7.Controls.Add(this.button6);
			this.groupBox7.Controls.Add(this.button7);
			this.groupBox7.Controls.Add(this.button8);
			this.groupBox7.Controls.Add(this.label17);
			this.groupBox7.Controls.Add(this.numTo1);
			this.groupBox7.Controls.Add(this.label18);
			this.groupBox7.Controls.Add(this.txtYearTo1);
			this.groupBox7.Controls.Add(this.label19);
			this.groupBox7.Controls.Add(this.numFrom1);
			this.groupBox7.Controls.Add(this.label20);
			this.groupBox7.Controls.Add(this.txtYearFrom1);
			this.groupBox7.Controls.Add(this.label21);
			this.groupBox7.Location = new System.Drawing.Point(0, 0);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(832, 48);
			this.groupBox7.TabIndex = 0;
			this.groupBox7.TabStop = false;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(512, 16);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(56, 23);
			this.button5.TabIndex = 26;
			this.button5.Text = "退出";
			this.button5.Click += new System.EventHandler(this.button5_Click_1);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(456, 16);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(56, 23);
			this.button6.TabIndex = 25;
			this.button6.Text = "帮助";
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(400, 16);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(56, 23);
			this.button7.TabIndex = 24;
			this.button7.Text = "打印";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(344, 16);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(56, 23);
			this.button8.TabIndex = 23;
			this.button8.Text = "确认";
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(320, 16);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(16, 23);
			this.label17.TabIndex = 22;
			this.label17.Text = "月";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numTo1
			// 
			this.numTo1.Location = new System.Drawing.Point(288, 16);
			this.numTo1.Maximum = new System.Decimal(new int[] {
																   12,
																   0,
																   0,
																   0});
			this.numTo1.Minimum = new System.Decimal(new int[] {
																   1,
																   0,
																   0,
																   0});
			this.numTo1.Name = "numTo1";
			this.numTo1.Size = new System.Drawing.Size(32, 21);
			this.numTo1.TabIndex = 21;
			this.numTo1.Value = new System.Decimal(new int[] {
																 2,
																 0,
																 0,
																 0});
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(264, 16);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(24, 23);
			this.label18.TabIndex = 20;
			this.label18.Text = "年";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtYearTo1
			// 
			this.txtYearTo1.Location = new System.Drawing.Point(216, 16);
			this.txtYearTo1.Name = "txtYearTo1";
			this.txtYearTo1.Size = new System.Drawing.Size(40, 21);
			this.txtYearTo1.TabIndex = 19;
			this.txtYearTo1.Text = "";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(176, 16);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(32, 23);
			this.label19.TabIndex = 18;
			this.label19.Text = "月至";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numFrom1
			// 
			this.numFrom1.Location = new System.Drawing.Point(136, 16);
			this.numFrom1.Maximum = new System.Decimal(new int[] {
																	 12,
																	 0,
																	 0,
																	 0});
			this.numFrom1.Minimum = new System.Decimal(new int[] {
																	 1,
																	 0,
																	 0,
																	 0});
			this.numFrom1.Name = "numFrom1";
			this.numFrom1.Size = new System.Drawing.Size(32, 21);
			this.numFrom1.TabIndex = 17;
			this.numFrom1.Value = new System.Decimal(new int[] {
																   2,
																   0,
																   0,
																   0});
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(112, 16);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(24, 23);
			this.label20.TabIndex = 16;
			this.label20.Text = "年";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtYearFrom1
			// 
			this.txtYearFrom1.Location = new System.Drawing.Point(72, 16);
			this.txtYearFrom1.Name = "txtYearFrom1";
			this.txtYearFrom1.Size = new System.Drawing.Size(40, 21);
			this.txtYearFrom1.TabIndex = 15;
			this.txtYearFrom1.Text = "";
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(8, 16);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(72, 24);
			this.label21.TabIndex = 14;
			this.label21.Text = "时间范围：";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tabPage6
			// 
			this.tabPage6.Controls.Add(this.groupBox10);
			this.tabPage6.Controls.Add(this.groupBox12);
			this.tabPage6.Location = new System.Drawing.Point(4, 21);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Size = new System.Drawing.Size(832, 615);
			this.tabPage6.TabIndex = 2;
			this.tabPage6.Text = "累计用水月统计表";
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
																2,
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
																  2,
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
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox5);
			this.tabPage1.Controls.Add(this.groupBox4);
			this.tabPage1.Location = new System.Drawing.Point(4, 21);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(832, 615);
			this.tabPage1.TabIndex = 5;
			this.tabPage1.Text = "用水统计表";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.dgURep);
			this.groupBox5.Location = new System.Drawing.Point(0, 48);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(832, 568);
			this.groupBox5.TabIndex = 1;
			this.groupBox5.TabStop = false;
			// 
			// dgURep
			// 
			this.dgURep.DataMember = "";
			this.dgURep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgURep.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgURep.Location = new System.Drawing.Point(3, 17);
			this.dgURep.Name = "dgURep";
			this.dgURep.Size = new System.Drawing.Size(826, 548);
			this.dgURep.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.label13);
			this.groupBox4.Controls.Add(this.button1);
			this.groupBox4.Controls.Add(this.btnP5);
			this.groupBox4.Controls.Add(this.numHT);
			this.groupBox4.Controls.Add(this.numHF);
			this.groupBox4.Controls.Add(this.btnCer5);
			this.groupBox4.Controls.Add(this.dtpT);
			this.groupBox4.Controls.Add(this.label14);
			this.groupBox4.Controls.Add(this.dtpF);
			this.groupBox4.Controls.Add(this.btnE5);
			this.groupBox4.Location = new System.Drawing.Point(0, 0);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(832, 48);
			this.groupBox4.TabIndex = 0;
			this.groupBox4.TabStop = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(432, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 24);
			this.label3.TabIndex = 23;
			this.label3.Text = "时";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(8, 16);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(72, 23);
			this.label13.TabIndex = 22;
			this.label13.Text = "时间范围：";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(576, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(56, 23);
			this.button1.TabIndex = 21;
			this.button1.Text = "帮助";
			// 
			// btnP5
			// 
			this.btnP5.Location = new System.Drawing.Point(520, 16);
			this.btnP5.Name = "btnP5";
			this.btnP5.Size = new System.Drawing.Size(56, 23);
			this.btnP5.TabIndex = 20;
			this.btnP5.Text = "打印";
			this.btnP5.Click += new System.EventHandler(this.btnP5_Click);
			// 
			// numHT
			// 
			this.numHT.Location = new System.Drawing.Point(392, 17);
			this.numHT.Maximum = new System.Decimal(new int[] {
																  23,
																  0,
																  0,
																  0});
			this.numHT.Name = "numHT";
			this.numHT.Size = new System.Drawing.Size(32, 21);
			this.numHT.TabIndex = 19;
			this.numHT.Value = new System.Decimal(new int[] {
																9,
																0,
																0,
																0});
			// 
			// numHF
			// 
			this.numHF.Location = new System.Drawing.Point(192, 17);
			this.numHF.Maximum = new System.Decimal(new int[] {
																  23,
																  0,
																  0,
																  0});
			this.numHF.Name = "numHF";
			this.numHF.Size = new System.Drawing.Size(32, 21);
			this.numHF.TabIndex = 18;
			this.numHF.Value = new System.Decimal(new int[] {
																9,
																0,
																0,
																0});
			// 
			// btnCer5
			// 
			this.btnCer5.Location = new System.Drawing.Point(464, 16);
			this.btnCer5.Name = "btnCer5";
			this.btnCer5.Size = new System.Drawing.Size(56, 23);
			this.btnCer5.TabIndex = 16;
			this.btnCer5.Text = "确认";
			this.btnCer5.Click += new System.EventHandler(this.btnCer5_Click);
			// 
			// dtpT
			// 
			this.dtpT.Location = new System.Drawing.Point(280, 17);
			this.dtpT.Name = "dtpT";
			this.dtpT.Size = new System.Drawing.Size(112, 21);
			this.dtpT.TabIndex = 15;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(224, 16);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(48, 23);
			this.label14.TabIndex = 14;
			this.label14.Text = "时至：";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpF
			// 
			this.dtpF.Location = new System.Drawing.Point(80, 17);
			this.dtpF.Name = "dtpF";
			this.dtpF.Size = new System.Drawing.Size(112, 21);
			this.dtpF.TabIndex = 13;
			// 
			// btnE5
			// 
			this.btnE5.Location = new System.Drawing.Point(632, 16);
			this.btnE5.Name = "btnE5";
			this.btnE5.Size = new System.Drawing.Size(56, 23);
			this.btnE5.TabIndex = 17;
			this.btnE5.Text = "退出";
			this.btnE5.Click += new System.EventHandler(this.btnE5_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.trvWel);
			this.groupBox3.Location = new System.Drawing.Point(0, 48);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(176, 600);
			this.groupBox3.TabIndex = 29;
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
			this.trvWel.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvWel_AfterSelect_1);
			// 
			// frmSalReport
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(1016, 654);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox2);
			this.Name = "frmSalReport";
			this.Text = "售水统计表";
			this.Load += new System.EventHandler(this.frmSalReport_Load);
			this.groupBox6.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
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
			this.tabPage2.ResumeLayout(false);
			this.groupBox13.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid5)).EndInit();
			this.groupBox7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numTo1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numFrom1)).EndInit();
			this.tabPage6.ResumeLayout(false);
			this.groupBox10.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).EndInit();
			this.groupBox12.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numTo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numFrom)).EndInit();
			this.tabPage1.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgURep)).EndInit();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numHT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numHF)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion		

		#region"界面管理"

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


		private void trvWel_AfterSelect_1(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{

			this.paintSelectedWell();

			this.trvWel_AfterSelect(sender,e);
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnExit2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnExit1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		
		private void btnPrint1_Click(object sender, System.EventArgs e)
		{
			this.printDay();
		}

		public string m_strWellNo="";

		private void button4_Click(object sender, System.EventArgs e)
		{

			if(this.trvWel.SelectedNode.Text.IndexOf("列表")>=0)			
			{
				return;
			}

			switch(this.m_strSelNodeType)
			{
				case "zhan":
					detailRep();
					break;
				case "dep":
					detailRepDep();
					break;
				case "manaPer":
					//detailRepManaPer();
					break;
				default:
					if(this.lblName.Text.IndexOf("乡镇")>=0)
					{
						this.detailRepCountry();
						break;
					}
					MessageBox.Show("请选中要进行统计的监测站、单位或操作员!");
					break;
			}

			DataTable dt=(DataTable)this.dataGrid1.DataSource;

			if(this.bDelNull)
			{
				this.clearNullDr(ref dt);
			}
			
			if(this.lblName.Text.IndexOf("操作员")<0)
			{
				dt=(DataTable)this.dataGrid1.DataSource;
				this.addSumRow(ref dt);
			}		

			this.paintOneLine();

		}

		#region"合计计算"

		private void addSumRowEx(ref DataTable dt)
		{
			try
			{
				this.clearNullDr(ref dt);
				DataRow dr=dt.NewRow();
				if(dt.Rows.Count==0)
				{
					return;
				}

				for(int j=0;j<dt.Columns.Count;j++)
				{
					if(dt.Columns[j].ColumnName!="time"&&j!=0&&dt.Columns[j].ColumnName!="time1")
					{
						double dAmount=0;
						for(int i=0;i<dt.Rows.Count;i++)
						{
							if(dt.Rows[i][j]!=null&&dt.Rows[i][j].ToString()!="")
							{
								dAmount+=double.Parse(dt.Rows[i][j].ToString());
							}						
						}
						dr[j]=dAmount.ToString();
					}
					else
					{
						//Console.WriteLine(dt.Rows[0][j].ToString());
						//dr[j]=dt.Rows[0][j].ToString();
						dr[0]="单位合计";
					}					
				}
				dt.Rows.Add(dr);
					  
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void addSumRow1(ref DataTable dt)
		{
			try
			{
				this.clearNullDr(ref dt);

				double dSalAmount=0;
				double dSalMony=0;

				for(int i=0;i<dt.Rows.Count;i++)				
				{
					if(dt.Rows[i]["wellName"].ToString().Trim().IndexOf("统计")>=0)
					{
						try
						{						
							if(!this.bNull(dt.Rows[i]["salAmount"]))
							{
								dSalAmount+=double.Parse(dt.Rows[i]["salAmount"].ToString());
							}
									
							if(!this.bNull(dt.Rows[i]["salMony"]))
							{
								dSalMony+=double.Parse(dt.Rows[i]["salMony"].ToString());
							}
							
						}
						catch
						{
							MessageBox.Show("有无效数据或数据累加和过大，无法进行合计。");
						}						
					
					}
				}

				if(dt.Rows.Count>0)
				{
					DataRow dr=dt.NewRow();

					for(int i=0;i<dr.Table.Columns.Count;i++)
					{
						dr[i]="";
					}

					dr[0]="单位合计";

					dr["salAmount"]=dSalAmount;
					dr["salMony"]=dSalMony;

					dt.Rows.Add(dr);
				}				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void addSumRow(ref DataTable dt)
		{
			try
			{
				this.clearNullDr(ref dt);

				double dSalAmount=0;
				double dSalMony=0;

				for(int i=0;i<dt.Rows.Count;i++)				
				{
					if(dt.Rows[i]["wellName"].ToString().Trim().IndexOf("统计")>=0)
					{
						try
						{						
							if(!this.bNull(dt.Rows[i]["salAmount"]))
							{
								dSalAmount+=double.Parse(dt.Rows[i]["salAmount"].ToString());
							}
									
							if(!this.bNull(dt.Rows[i]["salMony"]))
							{
								dSalMony+=double.Parse(dt.Rows[i]["salMony"].ToString());
							}
							
						}
						catch
						{
							MessageBox.Show("有无效数据或数据累加和过大，无法进行合计。");
						}						
					
					}
				}

				if(dt.Rows.Count>0)
				{
					DataRow dr=dt.NewRow();

					for(int i=0;i<dr.Table.Columns.Count;i++)
					{
						dr[i]="";
					}

					dr[0]="总计";

					dr["salAmount"]=dSalAmount;
					dr["salMony"]=dSalMony;

					dt.Rows.Add(dr);
				}				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
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

		bool m_bManaPer=false;
		bool m_bWell=false;

		private void checkManaPer()
		{
			if(this.trvWel.SelectedNode.Parent!=null)
			{
				if(this.trvWel.SelectedNode.Parent.Text.IndexOf("操作员")>=0)
				{
					paintManaPerTitle();
					this.m_strSelNodeType="manaPer";
					return;
				}
			}
			else
			{
				if(this.trvWel.SelectedNode.Text.IndexOf("操作员")>=0)
				{
					
				}
				else
				{
paintWellTitle();
					return;
				}
			}
			paintWellTitle();
		}

		private void paintWellTitle()
		{
			try
			{
				XmlNode xNode=this.m_xDocRep.DocumentElement.SelectSingleNode("report[@name='exp1' and @val='well']");

				for(int i=0;i<xNode.ChildNodes.Count;i++)			
				{
					string strIndex=xNode.ChildNodes[i].Attributes.GetNamedItem("index").Value.Trim();
					int iIndex=int.Parse(strIndex);
				
					this.dataGrid1.TableStyles[0].GridColumnStyles[iIndex].MappingName="field"+iIndex.ToString();
					this.dataGrid1.TableStyles[0].GridColumnStyles[iIndex].HeaderText="text"+iIndex.ToString();					
				}

				for(int i=0;i<xNode.ChildNodes.Count;i++)
				{
					string strIndex=xNode.ChildNodes[i].Attributes.GetNamedItem("index").Value.Trim();
					int iIndex=int.Parse(strIndex);

					string strColName=xNode.ChildNodes[i].Attributes.GetNamedItem("field").Value.Trim();
					string strColText=xNode.ChildNodes[i].Attributes.GetNamedItem("text").Value.Trim();

					this.dataGrid1.TableStyles[0].GridColumnStyles[iIndex].MappingName=strColName;
					this.dataGrid1.TableStyles[0].GridColumnStyles[iIndex].HeaderText=strColText;	

				}

				xNode=this.m_xDocRep.DocumentElement.SelectSingleNode("report[@name='exp2' and @val='well']");

				for(int i=0;i<xNode.ChildNodes.Count;i++)			
				{
					string strIndex=xNode.ChildNodes[i].Attributes.GetNamedItem("index").Value.Trim();
					int iIndex=int.Parse(strIndex);
				
					this.dataGrid2.TableStyles[0].GridColumnStyles[iIndex].MappingName="field"+iIndex.ToString();
					this.dataGrid2.TableStyles[0].GridColumnStyles[iIndex].HeaderText="text"+iIndex.ToString();					
				}

				for(int i=0;i<xNode.ChildNodes.Count;i++)
				{
					string strIndex=xNode.ChildNodes[i].Attributes.GetNamedItem("index").Value.Trim();
					int iIndex=int.Parse(strIndex);

					string strColName=xNode.ChildNodes[i].Attributes.GetNamedItem("field").Value.Trim();
					string strColText=xNode.ChildNodes[i].Attributes.GetNamedItem("text").Value.Trim();

					this.dataGrid2.TableStyles[0].GridColumnStyles[iIndex].MappingName=strColName;
					this.dataGrid2.TableStyles[0].GridColumnStyles[iIndex].HeaderText=strColText;	

				}
				xNode=this.m_xDocRep.DocumentElement.SelectSingleNode("report[@name='exp3' and @val='well']");

				for(int i=0;i<xNode.ChildNodes.Count;i++)			
				{
					string strIndex=xNode.ChildNodes[i].Attributes.GetNamedItem("index").Value.Trim();
					int iIndex=int.Parse(strIndex);
				
					this.dataGrid3.TableStyles[0].GridColumnStyles[iIndex].MappingName="field"+iIndex.ToString();
					this.dataGrid3.TableStyles[0].GridColumnStyles[iIndex].HeaderText="text"+iIndex.ToString();					
				}

				for(int i=0;i<xNode.ChildNodes.Count;i++)
				{
					string strIndex=xNode.ChildNodes[i].Attributes.GetNamedItem("index").Value.Trim();
					int iIndex=int.Parse(strIndex);

					string strColName=xNode.ChildNodes[i].Attributes.GetNamedItem("field").Value.Trim();
					string strColText=xNode.ChildNodes[i].Attributes.GetNamedItem("text").Value.Trim();

					this.dataGrid3.TableStyles[0].GridColumnStyles[iIndex].MappingName=strColName;
					this.dataGrid3.TableStyles[0].GridColumnStyles[iIndex].HeaderText=strColText;	

				}	
				
				if(this.m_bManaPer)
				{
					this.clearRows(this.dataGrid1);
					this.clearRows(this.dataGrid2);
					this.clearRows(this.dataGrid3);
				}
	
				this.m_bManaPer=false;
				this.m_bWell=true;

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void paintManaPerTitle()
		{
			try
			{
				XmlNode xNode=this.m_xDocRep.DocumentElement.SelectSingleNode("report[@name='exp1' and @val='manaPer']");		

				for(int i=0;i<xNode.ChildNodes.Count;i++)			
				{
					string strIndex=xNode.ChildNodes[i].Attributes.GetNamedItem("index").Value.Trim();
					int iIndex=int.Parse(strIndex);
				
					this.dataGrid1.TableStyles[0].GridColumnStyles[iIndex].MappingName="field"+iIndex.ToString();
					this.dataGrid1.TableStyles[0].GridColumnStyles[iIndex].HeaderText="text"+iIndex.ToString();		
			
					
				}

				for(int i=0;i<xNode.ChildNodes.Count;i++)
				{
					string strIndex=xNode.ChildNodes[i].Attributes.GetNamedItem("index").Value.Trim();
					int iIndex=int.Parse(strIndex);

					string strColName=xNode.ChildNodes[i].Attributes.GetNamedItem("field").Value.Trim();
					string strColText=xNode.ChildNodes[i].Attributes.GetNamedItem("text").Value.Trim();

					this.dataGrid1.TableStyles[0].GridColumnStyles[iIndex].MappingName=strColName;
					this.dataGrid1.TableStyles[0].GridColumnStyles[iIndex].HeaderText=strColText;				
				}
			

				xNode=this.m_xDocRep.DocumentElement.SelectSingleNode("report[@name='exp2' and @val='manaPer']");

				for(int i=0;i<xNode.ChildNodes.Count;i++)			
				{
					string strIndex=xNode.ChildNodes[i].Attributes.GetNamedItem("index").Value.Trim();
					int iIndex=int.Parse(strIndex);
				
					this.dataGrid2.TableStyles[0].GridColumnStyles[iIndex].MappingName="field"+iIndex.ToString();
					this.dataGrid2.TableStyles[0].GridColumnStyles[iIndex].HeaderText="text"+iIndex.ToString();	
				
					

				}			

				for(int i=0;i<xNode.ChildNodes.Count;i++)
				{
					string strIndex=xNode.ChildNodes[i].Attributes.GetNamedItem("index").Value.Trim();
					int iIndex=int.Parse(strIndex);

					string strColName=xNode.ChildNodes[i].Attributes.GetNamedItem("field").Value.Trim();
					string strColText=xNode.ChildNodes[i].Attributes.GetNamedItem("text").Value.Trim();

					this.dataGrid2.TableStyles[0].GridColumnStyles[iIndex].MappingName=strColName;
					this.dataGrid2.TableStyles[0].GridColumnStyles[iIndex].HeaderText=strColText;	
				
				}
			

				xNode=this.m_xDocRep.DocumentElement.SelectSingleNode("report[@name='exp3' and @val='manaPer']");

				for(int i=0;i<xNode.ChildNodes.Count;i++)			
				{
					string strIndex=xNode.ChildNodes[i].Attributes.GetNamedItem("index").Value.Trim();
					int iIndex=int.Parse(strIndex);
				
					this.dataGrid3.TableStyles[0].GridColumnStyles[iIndex].MappingName="field"+iIndex.ToString();
					this.dataGrid3.TableStyles[0].GridColumnStyles[iIndex].HeaderText="text"+iIndex.ToString();	
				
				}

				for(int i=0;i<xNode.ChildNodes.Count;i++)
				{
					string strIndex=xNode.ChildNodes[i].Attributes.GetNamedItem("index").Value.Trim();
					int iIndex=int.Parse(strIndex);

					string strColName=xNode.ChildNodes[i].Attributes.GetNamedItem("field").Value.Trim();
					string strColText=xNode.ChildNodes[i].Attributes.GetNamedItem("text").Value.Trim();

					this.dataGrid3.TableStyles[0].GridColumnStyles[iIndex].MappingName=strColName;
					this.dataGrid3.TableStyles[0].GridColumnStyles[iIndex].HeaderText=strColText;	
					

				}	

				

				if(this.m_bWell)
				{
					this.clearRows(this.dataGrid1);
					this.clearRows(this.dataGrid2);
					this.clearRows(this.dataGrid3);
				}
	
				this.m_bManaPer=true;
				this.m_bWell=false;

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

	

	     string m_strZhanName="";

		string m_strSelNodeType="";
		
		private void trvWel_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			if(this.trvWel.SelectedNode!=null)
			{
				this.m_strZhanName=this.trvWel.SelectedNode.Text;
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
			//	checkManaPer();
				return;
			}
			if(this.trvWel.SelectedNode.Nodes[0].Nodes.Count==0)
			{
				this.m_strSelNodeType="dep";
			//	checkManaPer();
				return;
			}
			//checkManaPer();
			this.m_strSelNodeType="";
			return;			
		}

		private void btnCer1_Click(object sender, System.EventArgs e)
		{
			if(this.trvWel.SelectedNode.Text.IndexOf("列表")>=0)			
			{
				return;
			}
			switch(this.m_strSelNodeType)
			{
				case "zhan":
					this.dayStaticRep();
					break;
				case "dep":
						dayStaticRepDep();
					break;
				case "manaPer":
						avgRepManaPer();
					break;
				default:
					if(this.lblName.Text.IndexOf("乡镇")>=0 )					
					{
						this.dayStaticRepCountry();
						break;
					}
					//MessageBox.Show("请选中要进行统计的监测站、单位或操作员!");
					break;
			}
			this.paintOneLine();
		}
		
		XmlDocument m_xDocRep;

		public bool bDelNull=true;

		private bool paintGrid()
		{
			try
			{
				if(this.m_xDocRep==null)
				{
					this.m_xDocRep=new XmlDocument();
					this.m_xDocRep.Load("salRep.xml");
				}

				XmlNode xNodeRep=this.m_xDocRep.DocumentElement.SelectSingleNode("./report[@name='tb11']");

				string strSql=xNodeRep.Attributes.GetNamedItem("sql").Value.Trim();

				DataTable dt=new   DataTable();

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
					//Console.WriteLine(strText);
					//Console.WriteLine(strField);
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
					this.dataGrid1.AllowSorting=false;

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

				xNodeRep=this.m_xDocRep.DocumentElement.SelectSingleNode("./report[@name='tb31']");
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

				//5本月够水站统计
				xNodeRep=this.m_xDocRep.DocumentElement.SelectSingleNode("./report[@name='tb4']");
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

				this.dataGrid5.TableStyles.Clear();
				this.dataGrid5.TableStyles.Add(dgts);
				this.dataGrid5.DataSource=dt;
				this.dataGrid5.CaptionText="监测站本月购水统计表";
				this.dataGrid5.ReadOnly=true;

				//usedWRep
				xNodeRep=this.m_xDocRep.DocumentElement.SelectSingleNode("./report[@name='usedWRep']");
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

				this.dgURep.TableStyles.Clear();
				this.dgURep.TableStyles.Add(dgts);
				this.dgURep.AllowSorting=false;
				this.dgURep.DataSource=dt;
				this.dgURep.CaptionText="用水统计表";
				this.dgURep.ReadOnly=true;
				
				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}

		private void frmSalReport_Load(object sender, System.EventArgs e)
		{
		//	this.tabControl1.TabPages[1].Hide ;
			this.numHF.Value=8;
			this.numHT.Value=8;

			this.txtYearFrom.Text=System.DateTime.Now.Year.ToString();
			this.txtYearTo.Text=System.DateTime.Now.Year.ToString();

			this.txtYearFrom1.Text=System.DateTime.Now.Year.ToString();
			this.txtYearTo1.Text=System.DateTime.Now.Year.ToString();

			this.numEnd.Maximum=23;
			this.numStart.Maximum=23;
	
			this.numStart.Minimum=0;
			this.numEnd.Minimum=0;
			
			this.numStart.Value=0;
			this.numEnd.Value=23;

			this.numFrom.Value=System.DateTime.Now.Month;
			this.numTo.Value=System.DateTime.Now.Month;

			this.numFrom1.Value=System.DateTime.Now.Month;
			this.numTo1.Value=System.DateTime.Now.Month;
		

			BengZhan.tools.CPaintForm.paintCountry(this.cmbCountry);
			BengZhan.tools.CPaintForm.paintWell(this.cmbCountry.Text,this.trvWel);
			
			this.paintGrid();
			this.paintOneLine();

		//	paintSalers(ref this.trvWel);
			this.trvWel.SelectedNode=this.trvWel.Nodes[0];	

			if(this.m_strWellNo.Trim()!="")
		{
				//this.selectTvN();
		}		
	
			//this.tabControl1.SelectedIndex=4;
			
		}

		private void selectTvN()
		{
			try
			{
				for(int i=0;i<this.trvWel.Nodes[0].Nodes.Count;i++)
				{
					for(int j=0;j<this.trvWel.Nodes[0].Nodes[i].Nodes.Count;j++)
					{
						string strInfo=this.trvWel.Nodes[0].Nodes[i].Nodes[j].Text.Trim();
						string strNo=strInfo.Substring(0,strInfo.IndexOf("|"));
						if(strNo==this.m_strWellNo.Trim())
						{
							this.trvWel.SelectedNode=this.trvWel.Nodes[0].Nodes[i].Nodes[j];
						}
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

		private void clearRows(System.Windows.Forms.DataGrid dg)
		{
			try
			{
				DataTable dt=(DataTable)dg.DataSource;
				dt.Rows.Clear();
				this.paintOneLine();
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
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

			if(this.tabControl1.SelectedIndex==3)
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
	
			

			dt=(DataTable)this.dataGrid5.DataSource;
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
		
			dt=(DataTable)this.dgURep.DataSource;
			this.clearRow(dt);

			if(this.tabControl1.SelectedIndex==4)
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

		private void tabControl2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(this.tabControl1.SelectedIndex!=0)
			{
				this.tabControl1.SelectedIndex=0;
			}
		    this.paintOneLine();
		}

		#endregion	

		#region"售水统计表"
			
		#region"明细表"

		private void detailRepManaPer()
		{
			try
			{
				string strFrom=this.dtpFrom.Value.ToShortDateString();
				strFrom=strFrom+" "+this.numStart.Value.ToString().Trim()+":00:00";
				string strTo=this.dtpTo.Value.ToShortDateString();
				strTo=strTo+" "+this.numEnd.Value.ToString().Trim()+":00:00";

				string strManaPer=this.trvWel.SelectedNode.Text;					

				DataTable dtDetail=new DataTable();

				if(CReportDll.comReport.CSalReport.getDtDetailReportMana(strManaPer,strFrom,strTo,ref dtDetail)==false)
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

				string strCapText=string.Format("操作员：{0}    {1}至{2}    操作员售水明细表",strManaPer,strFrom,strTo);
				this.dataGrid1.CaptionText=strCapText;
				this.m_strDtFrom=strFrom;
				this.m_strDtTo=strTo;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		public static void paintSalers(ref System.Windows.Forms.TreeView trv)
		{
			try
			{

				string strSql=string.Format("select userID,userName from tbUsers");
				DataTable dtUsers=new  DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtUsers,strSql,"tbUsers");

				System.Windows.Forms.TreeNode tn=new TreeNode();
				tn.Text="操作员列表";

				for(int i=0;i<dtUsers.Rows.Count;i++)
				{
					tn.Nodes.Add(dtUsers.Rows[i]["userName"].ToString());
				}

				trv.Nodes.Add(tn);
			
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
			
				string strDepName=this.txtZhan.Text.Trim();;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
		    	DataTable dtDetail=new DataTable();

				string strSql=string.Format("select wellNo from tbWell where depName='{0}' order by wellNo",strDepName);
				DataTable dtDep=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtDep,strSql,"depDt");

				DataTable dtRet=null;

				for(int i=0;i<dtDep.Rows.Count;i++)
				{
					string strZhanNo=dtDep.Rows[i]["wellNo"].ToString().Trim();
					dtDetail=new DataTable();
					if(CReportDll.comReport.CSalReport.getDtDetailReport(strZhanNo,strFrom,strTo,ref dtDetail)==false)
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

				string strCapText=string.Format("单位：{0}    {1}至{2}    监测站购水明细表",strDepName,strFrom,strTo);
				this.dataGrid1.CaptionText=strCapText;
				this.m_strDtFrom=strFrom;
				this.m_strDtTo=strTo;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void detailRepCountry()
		{

			try
			{
				string strFrom=this.dtpFrom.Value.ToShortDateString();
				strFrom=strFrom+" "+this.numStart.Value.ToString().Trim()+":00:00";
				string strTo=this.dtpTo.Value.ToShortDateString();
				strTo=strTo+" "+this.numEnd.Value.ToString().Trim()+":00:00";
			
				string strCountryName=this.txtZhan.Text.Trim();;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
				DataTable dtDetail=new DataTable();

				string strSql=string.Format("select depShortName from tbDep where  countryName='{0}'",strCountryName);
				DataTable dtDep=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtDep,strSql,"depDt");

				DataTable dtRet=null;

				for(int x=0;x<dtDep.Rows.Count;x++)
				{

					string strDepName=dtDep.Rows[x]["depShortName"].ToString().Trim();
					strSql=string.Format("select wellNo from tbWell where depName='{0}' order by wellNo",strDepName);
					DataTable dtWell=new DataTable();
					BengZhan.CDBConnection.getDataTable(ref dtWell,strSql,"wellDt");

					DataTable dtDepD=new DataTable();

					for(int y=0;y<dtWell.Rows.Count;y++)
					{
						string strZhanNo=dtWell.Rows[y]["wellNo"].ToString().Trim();
						dtDetail=new DataTable();
						if(CReportDll.comReport.CSalReport.getDtDetailReport(strZhanNo,strFrom,strTo,ref dtDetail)==false)
						{
							return;
						}
						BengZhan.comReport.CReports.copyDt(dtDetail,ref dtDepD);
					}

					this.addSumRow1(ref dtDepD);
					BengZhan.comReport.CReports.copyDt(dtDepD,ref dtRet);

				}
				
				dtDetail=dtRet;	
				if(dtDetail==null)
				{
					dtDetail=new DataTable();
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

				string strCapText=string.Format("乡镇：{0}    {1}至{2}    监测站购水明细表",strCountryName,strFrom,strTo);
				this.dataGrid1.CaptionText=strCapText;
				this.m_strDtFrom=strFrom;
				this.m_strDtTo=strTo;

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}

		}

		
		//明细表
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

				if(CReportDll.comReport.CSalReport.getDtDetailReport(strZhanNo,strFrom,strTo,ref dtDetail)==false)
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

				string strCapText=string.Format("监测站：{0}    {1}至{2}    监测站购水明细表",strZhanName,strFrom,strTo);
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

		#region"日统计"
		//操作员
		private void avgRepManaPer()		
		{
			try
			{
				string strFrom=this.dtpFrom1.Value.ToShortDateString();

				string strTo=this.dtpTo1.Value.ToShortDateString();
				

				string strManaPer=this.trvWel.SelectedNode.Text;					

				DataTable dtDetail=new DataTable();

				if(CReportDll.comReport.CSalReport.getDtAvgReportMana(strManaPer,strFrom,strTo,ref dtDetail)==false)
				{
					return;
				}

				DataTable dt=(DataTable)this.dataGrid2.DataSource;
		
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

				string strCapText=string.Format("操作员：{0}    {1}至{2}    售水日统计表",strManaPer,strFrom,strTo);
				this.dataGrid2.CaptionText=strCapText;
				this.m_strDtFrom=strFrom;
				this.m_strDtTo=strTo;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void dayStaticRepCountry()
		{
			try
			{
				string strFrom=this.dtpFrom1.Value.ToShortDateString();		
				string strTo=this.dtpTo1.Value.ToShortDateString();	
		
				string strCountryName=this.txtZhan.Text.Trim();		
				string strSql=string.Format("select wellNo from tbWell,tbDep where tbWell.depName=tbDep.depShortName and countryName='{0}' order by wellNo",strCountryName);

				DataTable dtDep=new DataTable();

				BengZhan.CDBConnection.getDataTable(ref dtDep,strSql,"dtDep");

				DataTable dtAvg=new DataTable();
				DataTable dtRet=new DataTable();

				for(int i=0;i<dtDep.Rows.Count;i++)				
				{				
					string strZhanNo=dtDep.Rows[i]["wellNo"].ToString().Trim();
					dtAvg=new DataTable();
					CReportDll.comReport.CSalReport.getDtAvgReport(strZhanNo,strFrom,strTo,ref dtAvg);
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

				string strCapText=string.Format("乡镇：{0}    {1}至{2}    监测站购水日统计表",strCountryName,strFrom,strTo);
				this.dataGrid2.CaptionText=strCapText;

				this.m_strDtFrom=strFrom;
				this.m_strDtTo=strTo;
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		//日统计表
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

				string strZhanName=this.txtZhan.Text.Trim();
				string strSql=string.Format("select wellNo from tbWell where wellName='{0}'",strZhanName);

				string strZhanNo=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();
			
				DataTable dtAvg=new DataTable();

				if(CReportDll.comReport.CSalReport.getDtAvgReport(strZhanNo,strFrom,strTo,ref dtAvg)==false)
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

				string strCapText=string.Format("监测站：{0}    {1}至{2}    监测站购水日统计表",strZhanName,strFrom,strTo);
				this.dataGrid2.CaptionText=strCapText;
				this.m_strDtFrom=strFrom;
				this.m_strDtTo=strTo;
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		//日统计表
		private void dayStaticRepDep()
		{
			try
			{
				string strFrom=this.dtpFrom1.Value.ToShortDateString();		
				string strTo=this.dtpTo1.Value.ToShortDateString();	
		
				string strDepName=this.txtZhan.Text.Trim();		
				string strSql=string.Format("select wellNo from tbWell where depName='{0}' order by wellNo",strDepName);

				DataTable dtDep=new DataTable();

				BengZhan.CDBConnection.getDataTable(ref dtDep,strSql,"dtDep");

				DataTable dtAvg=new DataTable();
				DataTable dtRet=new DataTable();

				for(int i=0;i<dtDep.Rows.Count;i++)				
				{
					
					string strZhanNo=dtDep.Rows[i]["wellNo"].ToString().Trim();
					dtAvg=new DataTable();
					CReportDll.comReport.CSalReport.getDtAvgReport(strZhanNo,strFrom,strTo,ref dtAvg);
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

				string strCapText=string.Format("单位：{0}    {1}至{2}    监测站购水日统计表",strDepName,strFrom,strTo);
				this.dataGrid2.CaptionText=strCapText;

				this.m_strDtFrom=strFrom;
				this.m_strDtTo=strTo;
				
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
				string strFrom=this.dtpFrom.Value.ToShortDateString();		
				string strTo=this.dtpTo.Value.ToShortDateString();	
		
				string strCountryName=this.txtZhan.Text.Trim();		
				string strSql=string.Format("select wellNo from tbWell,tbDep where tbWell.depName=tbDep.depShortName and countryName='{0}'",strCountryName);

				DataTable dtDep=new DataTable();

				BengZhan.CDBConnection.getDataTable(ref dtDep,strSql,"dtDep");

				DataTable dtAvg=new DataTable();
				DataTable dtRet=new DataTable();

				for(int i=0;i<dtDep.Rows.Count;i++)				
				{
					
					string strZhanNo=dtDep.Rows[i]["wellNo"].ToString().Trim();
					dtAvg=new DataTable();
					CReportDll.comReport.CSalReport.getDtAvgReport(strZhanNo,strFrom,strTo,ref dtAvg);
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

				string strCapText=string.Format("乡镇：{0}    {1}至{2}    监测站购水日统计表",strCountryName,strFrom,strTo);
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

		private void monthStaticRepCountry()		
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


				int iYearF1=0;
				int iYearT1=0;

				try
				{
					iYearF1=int.Parse(this.txtYearFrom.Text.Trim());
					iYearT1=int.Parse(this.txtYearTo.Text.Trim());
				}
				catch
				{
					MessageBox.Show("查询起止年份输入有误!");
					return;
				}

				if(iYearT1<iYearF1)
				{
					MessageBox.Show("查询起止年份输入有误!");
					return;
				}

int iIns=(int.Parse(this.txtYearTo1.Text.Trim())-int.Parse(this.txtYearFrom1.Text.Trim()))*12+int.Parse(this.numTo1.Value.ToString())-int.Parse(this.numFrom1.Value.ToString());				

				string strSql=string.Format("select depShortName from tbDep where CountryName='{0}'",this.txtZhan.Text.Trim());
				DataTable dtDep=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtDep,strSql,"dtDep");

				DataTable dtAvg=new DataTable();
				DataTable dtRet=new DataTable();

				for(int i=0;i<dtDep.Rows.Count;i++)
				{

					string strDepName=dtDep.Rows[i]["depShortName"].ToString().Trim();			
					
					for(int x=0;x<=iIns;x++)
					{
						string strTime=this.txtYearFrom1.Text.Trim()+"-"+this.numFrom1.Value.ToString().Trim()+"-1";
						dtFrom=DateTime.Parse(strTime);
						dtTo=dtFrom.AddMonths(x);

						string strFrom=dtTo.ToShortDateString();		
						string strTo=dtTo.ToShortDateString();							
		
						strSql=string.Format("select wellNo from tbWell where depName='{0}'",strDepName);

						DataTable dtWell=new DataTable();
						BengZhan.CDBConnection.getDataTable(ref dtWell,strSql,"dtDep");	
					
						DataTable dtAvgEx=new DataTable();

						for(int y=0;y<dtWell.Rows.Count;y++)
						{
							string strZhanNo=dtWell.Rows[y]["wellNo"].ToString().Trim();

							if(CReportDll.comReport.CSalReport.getDtAllReportMonth(strZhanNo,strFrom,strTo,ref dtAvg)==false)
							{
								return;
							}

							DataTable dtAvg1=new DataTable();
							if(getAmMonth(strZhanNo,strFrom,strTo,ref dtAvg1)==false)
							{
								return;
							}				
							DataTable dtNew=new DataTable();
				
							if(this.mergeDtEx(dtAvg,dtAvg1,ref dtNew)==false)
							{
								return;
							}

							BengZhan.comReport.CReports.copyDt(dtNew,ref dtAvgEx);												

						}

						this.addSumRowEx(ref dtAvgEx);
						BengZhan.comReport.CReports.copyDt(dtAvgEx,ref dtRet);
					}			
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

				dtTo=dtFrom.AddMonths(iIns);

				
				string strFromEx=string.Format("{0}-{1}-1 8:00",dtFrom.Year.ToString(),dtFrom.Month.ToString());				
				string strToEx=string.Format("{0}-{1}-1 8:00",dtTo.AddMonths(1).Year.ToString(),Convert.ToString(dtTo.AddMonths(1).Month));
				
				string strCapText=string.Format("乡镇：{0}    {1}至{2}    累计用水月统计表",this.txtZhan.Text.Trim(),strFromEx,strToEx);
				
				this.dataGrid3.CaptionText=strCapText;
				this.m_strDtFrom=strFromEx;
				this.m_strDtTo=strToEx;
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void monthStaticRepDep()
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

				int iYearF1=0;
				int iYearT1=0;

				try
				{
					iYearF1=int.Parse(this.txtYearFrom.Text.Trim());
					iYearT1=int.Parse(this.txtYearTo.Text.Trim());

				}
				catch
				{
					MessageBox.Show("查询起止年份输入有误!");
					return;
				}


				if(iYearT1<iYearF1)
				{
					MessageBox.Show("查询起止年份输入有误!");
					return;
				}

				int iIns=(int.Parse(this.txtYearTo.Text.Trim())-int.Parse(this.txtYearFrom.Text.Trim()))*12+int.Parse(this.numTo.Value.ToString())-int.Parse(this.numFrom.Value.ToString());

				DataTable dtAvgEx=new DataTable();

				string strDepName=this.txtZhan.Text.Trim();

				for(int x=0;x<=iIns;x++)
				{					
					string strTime=this.txtYearFrom.Text.Trim()+"-"+this.numFrom.Value.ToString().Trim()+"-1";
					dtFrom=DateTime.Parse(strTime);
					dtFrom=dtFrom.AddMonths(x);
					dtTo=dtFrom;

					string strFrom=dtTo.ToShortDateString();		
					string strTo=dtTo.ToShortDateString();					
		
					string strSql=string.Format("select wellNo from tbWell where depName='{0}' order by wellNo",strDepName);

					DataTable dtDep=new DataTable();
					BengZhan.CDBConnection.getDataTable(ref dtDep,strSql,"dtDep");					
					
					DataTable dtRet=new DataTable();

					for(int i=0;i<dtDep.Rows.Count;i++)
					{
						string strZhanNo=dtDep.Rows[i]["wellNo"].ToString().Trim();	
	
						DataTable dtAvg=new DataTable();

						if(CReportDll.comReport.CSalReport.getDtAllReportMonth(strZhanNo,strFrom,strTo,ref dtAvg)==false)
						{
							return;
						}

						DataTable dtMonth=new DataTable();
						if(this.getAmMonth(strZhanNo,strFrom,strTo,ref dtMonth)==false)
						{
							return;
						}

						DataTable dtNew=new DataTable();

						if(this.mergeDtEx(dtAvg,dtMonth,ref dtNew)==false)
						{
							return;
						}

						dtAvg=dtNew;

						BengZhan.comReport.CReports.copyDt(dtAvg,ref dtRet);

					}

					this.addSumRowEx(ref dtRet);
					BengZhan.comReport.CReports.copyDt(dtRet,ref dtAvgEx);

				}	

				DataTable dt=(DataTable)this.dataGrid3.DataSource;	
			
				dt.Rows.Clear();					
		
				for(int i=0;i<dtAvgEx.Rows.Count;i++)
				{
					DataRow dr=dt.NewRow();					
					for(int j=0;j<dt.Columns.Count;j++)
					{
						string strColName=dt.Columns[j].ColumnName;
						dr[strColName]=dtAvgEx.Rows[i][strColName].ToString();
					}
					dt.Rows.Add(dr);
				}

			string	strFromEx=string.Format("{0}-{1}-1 8:00",dtFrom.Year.ToString(),dtFrom.Month.ToString());				
			string	strToEx=string.Format("{0}-{1}-1 8:00",dtTo.AddMonths(1).Year.ToString(),Convert.ToString(dtTo.AddMonths(1).Month));
				
				string strCapText=string.Format("单位：{0}    {1}至{2}    累计用水月统计表",strDepName,strFromEx,strToEx);
				
				this.dataGrid3.CaptionText=strCapText;
				this.m_strDtFrom=strFromEx;
				this.m_strDtTo=strToEx;
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}



		private void avgRepManaPerMonth()
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

				string strManaPer=this.txtZhan.Text.Trim();					

				DataTable dtDetail=new DataTable();

				if(CReportDll.comReport.CSalReport.getDtAvgReportManaMonth(strManaPer,strFrom,strTo,ref dtDetail)==false)
				{
					return;
				}

				DataTable dt=(DataTable)this.dataGrid3.DataSource;
		
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

				strFrom=dtFrom.Year.ToString()+"年"+dtFrom.Month.ToString()+"月";
			
				strTo=dtTo.Year.ToString()+"年"+dtTo.Month.ToString()+"月";
			
				string strCapText=string.Format("操作员：{0}    {1}至{2}    操作员售水月统计表",strManaPer,strFrom,strTo);
				this.dataGrid3.CaptionText=strCapText;

				this.m_strDtFrom=strFrom;
				this.m_strDtTo=strTo;

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		//private void 

		private void monthStaticRep()
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

				string strZhanName=this.txtZhan.Text.Trim();
				string strSql=string.Format("select wellNo from tbWell where wellName='{0}'",strZhanName);

				string strZhanNo=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();		

				int iYearF1=0;
				int iYearT1=0;

				try
				{
					iYearF1=int.Parse(this.txtYearFrom.Text.Trim());
					iYearT1=int.Parse(this.txtYearTo.Text.Trim());

				}
				catch
				{
					MessageBox.Show("查询起止年份输入有误!");
					return;
				}


				if(iYearT1<iYearF1)
				{
					MessageBox.Show("查询起止年份输入有误!");
					return;
				}

				int iIns=(int.Parse(this.txtYearTo.Text.Trim())-int.Parse(this.txtYearFrom.Text.Trim()))*12+int.Parse(this.numTo.Value.ToString())-int.Parse(this.numFrom.Value.ToString());

				DataTable dtAvgEx=new DataTable();

				for(int x=0;x<=iIns;x++)
				{
					string strTime=this.txtYearFrom.Text.Trim()+"-"+this.numFrom.Value.ToString().Trim()+"-1";
					dtFrom=DateTime.Parse(strTime);
					dtFrom=dtFrom.AddMonths(x);
					dtTo=dtFrom;

					strFrom=dtTo.ToShortDateString();		
					strTo=dtTo.ToShortDateString();
			
					DataTable dtAvg=new DataTable();

					if(CReportDll.comReport.CSalReport.getDtAllReportMonth(strZhanNo,strFrom,strTo,ref dtAvg)==false)
					{
						return;
					}

					DataTable dtMonth=new DataTable();

					if(this.getAmMonth(strZhanNo,strFrom,strTo,ref dtMonth)==false)
					{
						return;
					}

					DataTable dtNew=new DataTable();

					if(this.mergeDtEx(dtAvg,dtMonth,ref dtNew)==false)
					{
						return;
					}
                    
					BengZhan.comReport.CReports.copyDt(dtNew,ref dtAvgEx);
				}						  

				///DataTable dtAvg=dtAvgEx;

				DataTable dt=(DataTable)this.dataGrid3.DataSource;	
			
				dt.Rows.Clear();					
		
				for(int i=0;i<dtAvgEx.Rows.Count;i++)
				{
					DataRow dr=dt.NewRow();					
					for(int j=0;j<dt.Columns.Count;j++)
					{
						string strColName=dt.Columns[j].ColumnName;
						dr[strColName]=dtAvgEx.Rows[i][strColName].ToString();				
					}
					dt.Rows.Add(dr);
				}

				strFrom=string.Format("{0}-{1}-1 8:00",dtFrom.Year.ToString(),dtFrom.Month.ToString());				
				strTo=string.Format("{0}-{1}-1 8:00",dtTo.AddMonths(1).Year.ToString(),Convert.ToString(dtTo.AddMonths(1).Month));
		
				string strCapText=string.Format("监测站：{0}    {1}至{2}    累计用水月统计表",this.m_strZhanName,strFrom,strTo);
				this.dataGrid3.CaptionText=strCapText;

				this.m_strDtFrom=strFrom;
				this.m_strDtTo=strTo;
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		#endregion

		private void btnCer2_Click(object sender, System.EventArgs e)
		{			
			if(this.trvWel.SelectedNode.Text.IndexOf("列表")>=0)			
			{
				return;
			}
			switch(this.m_strSelNodeType)
			{
				case "zhan":
					this.monthStaticRep();
					break;
				case "dep":
					this.monthStaticRepDep();
					break;
				case "manaPer":
					//this.avgRepManaPerMonth();
					break;
				default:
					if(this.lblName.Text.IndexOf("乡镇")>=0)
					{
						this.monthStaticRepCountry();
						break;
					}
					MessageBox.Show("请选中要进行统计的监测站、单位或操作员!");
					break;
			}
			this.paintOneLine();
		}

		XmlDocument m_xDocPrint;
		
		string m_strDtFrom="";
string m_strDtTo="";

		#endregion

		#region"报表打印"

		private void printDetail()
		{
			try
			{
				if(this.m_xDocPrint==null)
				{
					this.m_xDocPrint=new XmlDocument();
					this.m_xDocPrint.Load("salRepPrint.xml");
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

//				for(int i=0;i<this.dgPrint.TableStyles[0].GridColumnStyles.Count;i++)
//				{
//					this.dgPrint.TableStyles[0].GridColumnStyles[i].HeaderText="text"+i.ToString();
//					this.dgPrint.TableStyles[0].GridColumnStyles[i].MappingName="field"+i.ToString();
//				}
//
//				for(int i=0;i<this.dataGrid1.TableStyles[0].GridColumnStyles.Count;i++)
//				{
//					this.dgPrint.TableStyles[0].GridColumnStyles[i].MappingName=this.dataGrid1.TableStyles[0].GridColumnStyles[i].MappingName;
//					this.dgPrint.TableStyles[0].GridColumnStyles[i].HeaderText=this.dataGrid1.TableStyles[0].GridColumnStyles[i].HeaderText;
//				}

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
					strTitleE="监测站购水明细表";
				}
				strTitle=strTitle.Replace(strTitleE,"");				

				cutePrint.cutePrinter dgp=new cutePrint.cutePrinter(this.dgPrint,strTitleE,30);
				
				int iTimeMinus=int.Parse(xNode.Attributes.GetNamedItem("iTimeMinus").Value.Trim());
				dgp.iTimeMinus=iTimeMinus;
				dgp.leftMargin=int.Parse(xNode.Attributes.GetNamedItem("leftMargin").Value.Trim());
		dgp.strTitle=strTitle;
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
					this.m_xDocPrint.Load("salRepPrint.xml");
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
					strTitleE="监测站购水日统计表";
				}
				strTitle=strTitle.Replace(strTitleE,"");

		
				cutePrint.cutePrinter dgp=new cutePrint.cutePrinter(this.dgPrint,strTitleE,30);
				int iTimeMinus=int.Parse(xNode.Attributes.GetNamedItem("iTimeMinus").Value.Trim());
				dgp.iTimeMinus=iTimeMinus;
				dgp.leftMargin=int.Parse(xNode.Attributes.GetNamedItem("leftMargin").Value.Trim());
	dgp.strTitle=strTitle;
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
					this.m_xDocPrint.Load("salRepPrint.xml");
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
 
				string strTitle=this.dataGrid3.CaptionText.Trim();
				string strTitleE="";

				if(strTitle.IndexOf("操作员")>=0)
				{
					strTitleE="操作员售水月统计表";
					strTitle=strTitle.Substring(0,strTitle.IndexOf("操作员售水月统计表"));
				}
				else
				{
					strTitleE="累计用水月统计表";
					strTitle=strTitle.Substring(0,strTitle.IndexOf("累计用水月统计表"));
				}
		
				cutePrint.cutePrinter dgp=new cutePrint.cutePrinter(this.dgPrint,strTitleE,30);
				int iTimeMinus=int.Parse(xNode.Attributes.GetNamedItem("iTimeMinus").Value.Trim());
				dgp.iTimeMinus=iTimeMinus;	
				dgp.leftMargin=int.Parse(xNode.Attributes.GetNamedItem("leftMargin").Value.Trim());
				dgp.strTitle=strTitle;	
				dgp.Print();
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}			
		}
		private void printMonth2()
		{
			try
			{
				if(this.m_xDocPrint==null)
				{
					this.m_xDocPrint=new XmlDocument();
					this.m_xDocPrint.Load("salRepPrint.xml");
				}

				XmlNode xNode=this.m_xDocPrint.DocumentElement.SelectSingleNode("./rep[@val='4']");

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
				DataTable dtDetail=(DataTable)this.dataGrid5.DataSource;


				for(int i=0;i<dtDetail.Rows.Count;i++)
				{
					dtPrint.ImportRow(dtDetail.Rows[i]);
				}	
				this.clearBlankRow(dtPrint);	
 
				string strTitle=this.dataGrid5.CaptionText.Trim();
				string strTitleE="";

				if(strTitle.IndexOf("操作员")>=0)
				{
					strTitleE="操作员售水月统计表";
					strTitle=strTitle.Substring(0,strTitle.IndexOf("操作员售水月统计表"));
				}
				else
				{
					strTitleE="本月用水统计表";
					strTitle=strTitle.Substring(0,strTitle.IndexOf("本月用水统计表"));
				}
		
				cutePrint.cutePrinter dgp=new cutePrint.cutePrinter(this.dgPrint,strTitleE,30);
				int iTimeMinus=int.Parse(xNode.Attributes.GetNamedItem("iTimeMinus").Value.Trim());
				dgp.iTimeMinus=iTimeMinus;	
				dgp.leftMargin=int.Parse(xNode.Attributes.GetNamedItem("leftMargin").Value.Trim());
				dgp.strTitle=strTitle;	
				dgp.Print();
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}			
		}

		

		#endregion

		private void button3_Click(object sender, System.EventArgs e)
		{
			this.printDetail();
		}

		private void btnExp1_Click(object sender, System.EventArgs e)
		{
			try
			{
				SaveFileDialog openFileDialog1 = new SaveFileDialog();
				openFileDialog1.Filter = "excel文件|*.xls"; 
				openFileDialog1.Title = "导出到excel文件"; 
				openFileDialog1.InitialDirectory=@"c:\";
				openFileDialog1.FileName="datas.xls";

				string strFileName="";
 
				// Show the Dialog. 
				// If the user clicked OK in the dialog and 
				// a .CUR file was selected, open it. 
				if (openFileDialog1.ShowDialog() == DialogResult.OK) 
				{ 
					if(openFileDialog1.FileName!= "") 
					{ 
						strFileName=openFileDialog1.FileName;
					
					} 
					else
					{
						return;
					}
				}
				else
				{
					return;
				}

				if(strFileName.IndexOf(".xls")<=0)
				{
					MessageBox.Show("文件类型有误！");
					return;
				}

				Directory.SetCurrentDirectory(Application.StartupPath);

				File.Delete(strFileName);
				File.Copy("bkData.xls",strFileName);
				
				string strTableName="";

				switch(this.tabControl1.SelectedIndex)
				{
					case 0:
						BengZhan.comReport.CReports.m_dtExport=(DataTable)this.dataGrid1.DataSource;
						this.dgPrint=this.dataGrid1;
						strTableName="明细表";
						break;
					case 1:
						BengZhan.comReport.CReports.m_dtExport=(DataTable)this.dataGrid2.DataSource;
						this.dgPrint=this.dataGrid2;
						strTableName="日统计表";
						break;
					case 2:
						BengZhan.comReport.CReports.m_dtExport=(DataTable)this.dataGrid3.DataSource;
						this.dgPrint=this.dataGrid3;
						strTableName="月统计表";
						break;
				}
			
				//this.crpvWater.ExportReport();
				if(BengZhan.comReport.CReports.m_dtExport==null)
				{
					MessageBox.Show("没有可导出的数据!");
					return;
				}

				Hashtable ht=new Hashtable();

				for(int i=0;i<this.dgPrint.TableStyles[0].GridColumnStyles.Count;i++)
				{

					string strText=this.dgPrint.TableStyles[0].GridColumnStyles[i].HeaderText.Trim();
					string strField=this.dgPrint.TableStyles[0].GridColumnStyles[i].MappingName.Trim();

					ht.Add(strField,strText);
				}
			
				string strCon=String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR=YES;'",strFileName);

				OleDbConnection odbCon=new OleDbConnection(strCon);
				odbCon.Open();
				string strSql=string.Format("create table {0}(",strTableName);
				System.Text.StringBuilder sbCreate=new System.Text.StringBuilder(strSql);

				OleDbCommand odc=new OleDbCommand();
				odc.CommandText=strSql;
				odc.Connection=odbCon;			

				DataTable dtExport=BengZhan.comReport.CReports.m_dtExport;	
			
				bool bCreate=false;
			
				for(int i=0;i<dtExport.Rows.Count;i++)
				{
					System.Text.StringBuilder sbInsert=new System.Text.StringBuilder(string.Format("insert into [{0}$](",strTableName));
					for(int j=0;j<dtExport.Columns.Count;j++)
					{
						string strColCName="";
						string strColEName="";
						strColEName=dtExport.Columns[j].ColumnName.Trim();
						strColCName=ht[strColEName].ToString().Trim();
						sbInsert.Append(strColCName);
						sbCreate.Append(string.Format("{0} text",strColCName));
						if(j!=(dtExport.Columns.Count-1))
						{
							sbInsert.Append(",");
							sbCreate.Append(",");
						}                    					
					}

					sbInsert.Append(")values(");
					sbCreate.Append(")");

					for(int j=0;j<dtExport.Columns.Count;j++)
					{
						string strColCName="";
						string strColEName="";
						strColEName=dtExport.Columns[j].ColumnName.Trim();
						strColCName=ht[strColEName].ToString().Trim();
						string strVal=dtExport.Rows[i][j].ToString();
						sbInsert.Append("'");
						sbInsert.Append(strVal);
						sbInsert.Append("'");
						if(j!=(dtExport.Columns.Count-1))
						{
							sbInsert.Append(",");
						}              
					}
					sbInsert.Append(")");

					odc.CommandText=sbCreate.ToString();
					if(!bCreate)
					{
						odc.ExecuteNonQuery();
						bCreate=true;

					}
				
					odc.CommandText=sbInsert.ToString();
					odc.ExecuteNonQuery();

				}		
				odbCon.Close();
				MessageBox.Show("导出完成!");
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}	
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			try
			{
				SaveFileDialog openFileDialog1 = new SaveFileDialog();
				openFileDialog1.Filter = "excel文件|*.xls"; 
				openFileDialog1.Title = "导出到excel文件"; 
				openFileDialog1.InitialDirectory=@"c:\";
				openFileDialog1.FileName="datas.xls";

				string strFileName="";
 
				// Show the Dialog. 
				// If the user clicked OK in the dialog and 
				// a .CUR file was selected, open it. 
				if (openFileDialog1.ShowDialog() == DialogResult.OK) 
				{ 
					if(openFileDialog1.FileName!= "") 
					{ 
						strFileName=openFileDialog1.FileName;
					
					} 
					else
					{
						return;
					}
				}
				else
				{
					return;
				}

				if(strFileName.IndexOf(".xls")<=0)
				{
					MessageBox.Show("文件类型有误！");
					return;
				}

				Directory.SetCurrentDirectory(Application.StartupPath);

				File.Delete(strFileName);
				File.Copy("bkData.xls",strFileName);
				
				string strTableName="";
			
				BengZhan.comReport.CReports.m_dtExport=(DataTable)this.dataGrid1.DataSource;
				this.dgPrint=this.dataGrid1;
				strTableName="明细表";						
			
				//this.crpvWater.ExportReport();
				if(BengZhan.comReport.CReports.m_dtExport==null)
				{
					MessageBox.Show("没有可导出的数据!");
					return;
				}

				Hashtable ht=new Hashtable();

				for(int i=0;i<this.dgPrint.TableStyles[0].GridColumnStyles.Count;i++)
				{

					string strText=this.dgPrint.TableStyles[0].GridColumnStyles[i].HeaderText.Trim();
					string strField=this.dgPrint.TableStyles[0].GridColumnStyles[i].MappingName.Trim();

					ht.Add(strField,strText);
				}
			
				string strCon=String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR=YES;'",strFileName);

				OleDbConnection odbCon=new OleDbConnection(strCon);
				odbCon.Open();
				string strSql=string.Format("create table {0}(",strTableName);
				System.Text.StringBuilder sbCreate=new System.Text.StringBuilder(strSql);

				OleDbCommand odc=new OleDbCommand();
				odc.CommandText=strSql;
				odc.Connection=odbCon;	

				odc.CommandText=strSql;

				DataTable dtExport=BengZhan.comReport.CReports.m_dtExport;	
			
				bool bCreate=false;
			
				for(int i=0;i<dtExport.Rows.Count;i++)
				{
					System.Text.StringBuilder sbInsert=new System.Text.StringBuilder(string.Format("insert into [{0}$](",strTableName));
					for(int j=0;j<dtExport.Columns.Count;j++)
					{
						string strColCName="";
						string strColEName="";
						strColEName=dtExport.Columns[j].ColumnName.Trim();
						strColCName=ht[strColEName].ToString().Trim();
						sbInsert.Append(strColCName);
						sbCreate.Append(string.Format("{0} text",strColCName));
						if(j!=(dtExport.Columns.Count-1))
						{
							sbInsert.Append(",");
							sbCreate.Append(",");
						}                    					
					}

					sbInsert.Append(")values(");
					sbCreate.Append(")");

					for(int j=0;j<dtExport.Columns.Count;j++)
					{
						string strColCName="";
						string strColEName="";
						strColEName=dtExport.Columns[j].ColumnName.Trim();
						strColCName=ht[strColEName].ToString().Trim();
						string strVal=dtExport.Rows[i][j].ToString();
						sbInsert.Append("'");
						sbInsert.Append(strVal);
						sbInsert.Append("'");
						if(j!=(dtExport.Columns.Count-1))
						{
							sbInsert.Append(",");
						}              
					}
					sbInsert.Append(")");

					odc.CommandText=sbCreate.ToString();
					if(!bCreate)
					{
						odc.ExecuteNonQuery();
						bCreate=true;

					}
				
					odc.CommandText=sbInsert.ToString();
					odc.ExecuteNonQuery();

				}				
				odbCon.Close();
				MessageBox.Show("导出完成!");
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}


		private void btnPrint2_Click(object sender, System.EventArgs e)
		{

			DataTable dt=(DataTable)this.dataGrid3.DataSource;
			DataTable dtE=dt.Copy();
			this.clearNullDr(ref dtE);
			if(dtE.Rows.Count<=0)
			{
				MessageBox.Show("没有可打印的数据!");
				return;
			}

			this.printMonth();
		}

		private void label3_Click(object sender, System.EventArgs e)
		{
		
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


		#region"右键弹出菜单"
		
		private void iniContMenu()
		{
			try
			{	
				
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

		private void clearNullDr(ref DataTable dt)
		{
			try
			{
				
				for(int i=0;i<dt.Rows.Count;i++)
				{

					bool bNull=true;

					for(int j=0;j<dt.Columns.Count;j++)
					{
						if((dt.Columns[j].ColumnName.Trim()!="wellName")&&(dt.Columns[j].ColumnName.Trim()!="salPer"))
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

		#region"newwork"

		private bool addSumN(ref DataTable dt)
		{
			try
			{
				DataTable dtN=dt.Clone();

				for(int i=0;i<dtN.Columns.Count;i++)
				{
					string strColName=dtN.Columns[i].ColumnName.Trim();
					if((strColName!="wellName")&&(strColName!="time")&&(strColName!="salPer"))
					{
						dtN.Columns[i].DataType=System.Type.GetType("System.Double");
					}
				}

				if(!this.copyDtN(dt,ref dtN))
				{
					return false;
				}

				if(dtN.Rows.Count==0)
				{
					return true;
				}

				DataRow dr=dtN.NewRow();
				dr["wellName"]="单位合计";
				dr["time"]="";	

				for(int i=0;i<dtN.Columns.Count;i++)
				{
					if((dtN.Columns[i].ColumnName.Trim()!="wellName")&&(dtN.Columns[i].ColumnName.Trim()!="time")&&(dtN.Columns[i].ColumnName.Trim()!="salPer"))
					{					
						object o=dtN.Compute(string.Format("sum({0})",dtN.Columns[i].ColumnName),"");
						
						if((o!=null)&&(o.ToString()!=""))
						{
							dr[dtN.Columns[i].ColumnName]=o.ToString();
						}						
					}
				}

				dtN.Rows.Add(dr);

				this.copyDtN(dtN,ref dt);


				return true;
			}
			catch(Exception ex)			
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}

		private bool getAmMonthDep(string strDepName,string strFrom,string strTo,ref DataTable dt)
		{
			try
			{
				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();
				string strProc="p_sr_amDep";
				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;
				sCmd.CommandType=CommandType.StoredProcedure;
				sCmd.CommandText=strProc;
				sCmd.Parameters.Add("@depName",SqlDbType.NVarChar,20);
				sCmd.Parameters.Add("@strStartTime",SqlDbType.NVarChar,40);
				sCmd.Parameters.Add("@strEndTime",SqlDbType.NVarChar,40);

				sCmd.Parameters["@depName"].Value=strDepName;
				sCmd.Parameters["@strStartTime"].Value=strFrom;
				sCmd.Parameters["@strEndTime"].Value=strTo;

				SqlDataAdapter sda=new SqlDataAdapter();
				sda.SelectCommand=sCmd;

				dt=new DataTable();
				sda.Fill(dt);			
				sCon.Close();
			
				return true;

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}

		private bool getAmMonth(string strZhanNo,string strFrom,string strTo,ref DataTable dt)
		{
			try
			{
				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();
				
				string strSql=string.Format("select name as wellName,allMony,leftMony,allAmount,leftAmount,time  from  waterDatasMonth where watNo='{0}' and time between '{1}' and '{2}'",strZhanNo,strFrom,strTo);

				string strProc="p_sr_am";
				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;
				sCmd.CommandType=CommandType.StoredProcedure;
				sCmd.CommandText=strProc;
				sCmd.Parameters.Add("@zhanNo",SqlDbType.NVarChar,20);
				sCmd.Parameters.Add("@strStartTime",SqlDbType.NVarChar,40);
				sCmd.Parameters.Add("@strEndTime",SqlDbType.NVarChar,40);

				sCmd.Parameters["@zhanNo"].Value=strZhanNo;
				sCmd.Parameters["@strStartTime"].Value=strFrom;
				sCmd.Parameters["@strEndTime"].Value=strTo;

				SqlDataAdapter sda=new SqlDataAdapter();
				sda.SelectCommand=sCmd;

				dt=new DataTable();
				sda.Fill(dt);	
		
//				for(int i=0;i<dt.Rows.Count;i++)
//				{
//					string strTime =dt.Rows[i]["time"].ToString().Trim();
//					//DateTime dtTime=DateTime.Parse(strTime);
//					//dtTime=dtTime.AddMonths(-1);
//		//strTime=string.Format("{0}-{1}-{2} 8:00",dtTime.Year.ToString(),Convert.ToString(dtTime.Month+1),"1");
//					dt.Rows[i]["time"]=dtTime.ToString();
//				}
						 
				sCon.Close();
				return true;

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}	
		}

		private bool mergeDtEx(DataTable dtSa,DataTable dtAm,ref DataTable dt)
		{
			try
			{
				dt=dtSa.Clone();

				dt.Columns.Remove("salPer");
				dt.Columns.Add("allMony");
				dt.Columns.Add("leftMony");
				dt.Columns.Add("allAmount");
				dt.Columns.Add("leftAmount");
				dt.Columns.Add("allBuyAmount");
				dt.Columns.Add("allUsedMony");

				if(dtAm.Rows.Count==0)
				{
					if(dtSa.Rows.Count!=0)
					{
						DataRow dr=dt.NewRow();

						//dr["allMony"]=dtAm.Rows[i]["allMony"].ToString();

						dr["allAmount"]="0";
						dr["wellName"]=dtSa.Rows[0]["wellName"].ToString();

						string strSql=string.Format("select price1 from tbWell where wellName='{0}'",dr["wellName"].ToString().Trim());
						string strPrice=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();					

						dr["allUsedMony"]=double.Parse(dr["allAmount"].ToString())*double.Parse(strPrice);					
					
					DateTime dtime=DateTime.Parse(dtSa.Rows[0]["time"].ToString());		
					dtime=dtime.AddMonths(1);

					dr["time"]=string.Format("{0}-{1}-1 0:00",dtime.Year.ToString(),dtime.Month.ToString());

						string strWellName=dtSa.Rows[0]["wellName"].ToString().Trim();
						string strTime=dtSa.Rows[0]["time"].ToString().Trim();

						DataRow drSa=null;

						if(this.getSalDrEx(dtSa,strWellName,strTime,ref drSa))
						{
							dr["allMony"]=drSa["salMony"].ToString();
							dr["allBuyAmount"]=drSa["salAmount"].ToString();
							double dLeftMony=double.Parse(dr["allMony"].ToString())-double.Parse(dr["allUsedMony"].ToString());
							dr["leftMony"]=dLeftMony.ToString();
							double dLeftAmount=double.Parse(dr["allBuyAmount"].ToString())-double.Parse(dr["allAmount"].ToString());
							dr["leftAmount"]=dLeftAmount.ToString();
						}   
						else
						{
							dr["allMony"]="0";
							dr["allBuyAmount"]="0";
							double dLeftMony=double.Parse(dr["allMony"].ToString())-double.Parse(dr["allUsedMony"].ToString());
							dr["leftMony"]=dLeftMony.ToString();
							double dLeftAmount=double.Parse(dr["allBuyAmount"].ToString())-double.Parse(dr["allAmount"].ToString());
							dr["leftAmount"]=dLeftAmount.ToString();
						}
						dt.Rows.Add(dr);

						return true;
					}
				}

				for(int i=0;i<dtAm.Rows.Count;i++)
				{
					DataRow dr=dt.NewRow();

					//dr["allMony"]=dtAm.Rows[i]["allMony"].ToString();

					dr["allAmount"]=dtAm.Rows[i]["allAmount"].ToString();
					dr["wellName"]=dtAm.Rows[i]["wellName"].ToString();

					string strSql=string.Format("select price1 from tbWell where wellName='{0}'",dr["wellName"].ToString().Trim());
					string strPrice=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();					

					dr["allUsedMony"]=double.Parse(dr["allAmount"].ToString())*double.Parse(strPrice);

					//dr["leftAmount"]=dtAm.Rows[i]["leftAmount"].ToString();
					//dr["leftMony"]=dtAm.Rows[i]["leftMony"].ToString();
				

					if(dtAm.Rows[i]["time"].ToString().IndexOf(":")<0)
					{
						dtAm.Rows[i]["time"]=dtAm.Rows[i]["time"].ToString().Replace("-","年");
						//dtAm.Rows[i]["time"]=dtAm.Rows[i]["time"].ToString()+"月";
					}
					
					DateTime dtime=DateTime.Parse(dtAm.Rows[i]["time"].ToString());		
					dtime=dtime.AddMonths(1);

					dr["time"]=string.Format("{0}-{1}-1 0:00",dtime.Year.ToString(),dtime.Month.ToString());

					string strWellName=dtAm.Rows[i]["wellName"].ToString().Trim();
					string strTime=dtAm.Rows[i]["time"].ToString().Trim();

					DataRow drSa=null;

					if(this.getSalDrEx(dtSa,strWellName,strTime,ref drSa))
					{
						dr["allMony"]=drSa["salMony"].ToString();
						dr["allBuyAmount"]=drSa["salAmount"].ToString();
						double dLeftMony=double.Parse(dr["allMony"].ToString())-double.Parse(dr["allUsedMony"].ToString());
						dr["leftMony"]=dLeftMony.ToString();
						double dLeftAmount=double.Parse(dr["allBuyAmount"].ToString())-double.Parse(dr["allAmount"].ToString());
						dr["leftAmount"]=dLeftAmount.ToString();
					}   
					else
					{
						dr["allMony"]="0";
						dr["allBuyAmount"]="0";
						double dLeftMony=double.Parse(dr["allMony"].ToString())-double.Parse(dr["allUsedMony"].ToString());
						dr["leftMony"]=dLeftMony.ToString();
						double dLeftAmount=double.Parse(dr["allBuyAmount"].ToString())-double.Parse(dr["allAmount"].ToString());
						dr["leftAmount"]=dLeftAmount.ToString();
					}
					dt.Rows.Add(dr);
				}

				//this.addSumN(ref dt);
						  
				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				Application.Exit();
				return false;
			}
		}

		private bool mergeDt(DataTable dtSa,DataTable dtAm,ref DataTable dt)
		{
			try
			{
				dt=dtSa.Clone();

				dt.Columns.Remove("salPer");
				dt.Columns.Add("allMony");
				dt.Columns.Add("leftMony");
				dt.Columns.Add("allAmount");
				dt.Columns.Add("leftAmount");
				dt.Columns.Add("allBuyAmount");
				dt.Columns.Add("allUsedMony");


				if(dtAm.Rows.Count==0)
				{
					if(dtSa.Rows.Count!=0)
					{
						DataRow dr=dt.NewRow();

						//dr["allMony"]=dtAm.Rows[i]["allMony"].ToString();

						dr["allAmount"]="0";
						dr["wellName"]=dtSa.Rows[0]["wellName"].ToString();

						string strSql=string.Format("select price1 from tbWell where wellName='{0}'",dr["wellName"].ToString().Trim());
						string strPrice=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();

						dr["allUsedMony"]=double.Parse(dr["allAmount"].ToString())*double.Parse(strPrice);				
					
						DateTime dtime=DateTime.Parse(dtSa.Rows[0]["time"].ToString());
				
						if(dtime.Month==System.DateTime.Now.Month)					
						{
							dr["time"]=string.Format("{0}-{1}-{2} 0:00 至 {3}-{4}-{5} 23:00",dtime.Year.ToString(),dtime.Month.ToString(),"1",dtime.Year.ToString(),Convert.ToString(dtime.Month),System.DateTime.Now.Day.ToString());
						}
						else
						{
							dr["time"]=string.Format("{0}-{1}-{2} 0:00 至 {3}-{4}-{5} 23:00",dtime.Year.ToString(),dtime.Month.ToString(),"1",dtime.Year.ToString(),Convert.ToString(dtime.Month),dtime.AddMonths(1).AddDays(-1).Day.ToString());
						}
					

						string strWellName=dtSa.Rows[0]["wellName"].ToString().Trim();
						string strTime=dtSa.Rows[0]["time"].ToString().Trim();
		

						DataRow drSa=null;

						if(this.getSaDr(dtSa,strWellName,strTime,ref drSa))
						{
							dr["allMony"]=drSa["salMony"].ToString();
							dr["allBuyAmount"]=drSa["salAmount"].ToString();
							double dLeftMony=double.Parse(dr["allMony"].ToString())-double.Parse(dr["allUsedMony"].ToString());
							dr["leftMony"]=dLeftMony.ToString();
							double dLeftAmount=double.Parse(dr["allBuyAmount"].ToString())-double.Parse(dr["allAmount"].ToString());
							dr["leftAmount"]=dLeftAmount.ToString();
						} 			
						dt.Rows.Add(dr);
						return true;
					}
				}

				for(int i=0;i<dtAm.Rows.Count;i++)
				{
					DataRow dr=dt.NewRow();

					//dr["allMony"]=dtAm.Rows[i]["allMony"].ToString();

					dr["allAmount"]=dtAm.Rows[i]["allAmount"].ToString();
					dr["wellName"]=dtAm.Rows[i]["wellName"].ToString();

					string strSql=string.Format("select price1 from tbWell where wellName='{0}'",dr["wellName"].ToString().Trim());
					string strPrice=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();

					dr["allUsedMony"]=double.Parse(dr["allAmount"].ToString())*double.Parse(strPrice);

					//dr["leftAmount"]=dtAm.Rows[i]["leftAmount"].ToString();
					//dr["leftMony"]=dtAm.Rows[i]["leftMony"].ToString();
				

					if(dtAm.Rows[i]["time"].ToString().IndexOf(":")<0)
					{
						dtAm.Rows[i]["time"]=dtAm.Rows[i]["time"].ToString().Replace("-","年");
						//dtAm.Rows[i]["time"]=dtAm.Rows[i]["time"].ToString()+"月";
					}
					
					DateTime dtime=DateTime.Parse(dtAm.Rows[i]["time"].ToString());
				
					if(dtime.Month==System.DateTime.Now.Month)					
					{
						dr["time"]=string.Format("{0}-{1}-{2} 0:00 至 {3}-{4}-{5} 23:00",dtime.Year.ToString(),dtime.Month.ToString(),"1",dtime.Year.ToString(),Convert.ToString(dtime.Month),System.DateTime.Now.Day.ToString());
					}
					else
					{
						dr["time"]=string.Format("{0}-{1}-{2} 0:00 至 {3}-{4}-{5} 23:00",dtime.Year.ToString(),dtime.Month.ToString(),"1",dtime.Year.ToString(),Convert.ToString(dtime.Month),dtime.AddMonths(1).AddDays(-1).Day.ToString());
					}
					

					string strWellName=dtAm.Rows[i]["wellName"].ToString().Trim();
					string strTime=dtAm.Rows[i]["time"].ToString().Trim();
		

					DataRow drSa=null;

					if(this.getSaDr(dtSa,strWellName,strTime,ref drSa))
					{
						dr["allMony"]=drSa["salMony"].ToString();
						dr["allBuyAmount"]=drSa["salAmount"].ToString();
						double dLeftMony=double.Parse(dr["allMony"].ToString())-double.Parse(dr["allUsedMony"].ToString());
						dr["leftMony"]=dLeftMony.ToString();
						double dLeftAmount=double.Parse(dr["allBuyAmount"].ToString())-double.Parse(dr["allAmount"].ToString());
						dr["leftAmount"]=dLeftAmount.ToString();
					}   
					else
					{
						dr["allMony"]="0";
						dr["allBuyAmount"]="0";
						double dLeftMony=double.Parse(dr["allMony"].ToString())-double.Parse(dr["allUsedMony"].ToString());
						dr["leftMony"]=dLeftMony.ToString();
						double dLeftAmount=double.Parse(dr["allBuyAmount"].ToString())-double.Parse(dr["allAmount"].ToString());
						dr["leftAmount"]=dLeftAmount.ToString();
					}
					dt.Rows.Add(dr);
				}

				//this.addSumN(ref dt);
						  
				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				Application.Exit();
				return false;
			}
			
		}
		private bool mergeDt1(DataTable dtSa,DataTable dtAm,ref DataTable dt)
		{
			try
			{
				if(dtSa==null)
				{
					return false;
				}
				dt=dtSa.Clone();

				dt.Columns.Remove("salPer");
				dt.Columns.Add("allMony");
				dt.Columns.Add("leftMony");
				dt.Columns.Add("allAmount");
				dt.Columns.Add("leftAmount");
				dt.Columns.Add("allBuyAmount");
				dt.Columns.Add("allUsedMony");

				dt.Columns["time"].DataType=Type.GetType("System.String");

				for(int i=0;i<dt.Columns.Count;i++)
				{
					dt.Columns[i].DataType=Type.GetType("System.String");
				}

				if(dtAm.Rows.Count==0)
				{
					if(dtSa.Rows.Count!=0)
					{
						DataRow dr=dt.NewRow();

						//dr["allMony"]=dtAm.Rows[i]["allMony"].ToString();

						dr["allAmount"]="0";
						dr["wellName"]=dtSa.Rows[0]["wellName"].ToString();

						string strSql=string.Format("select price1 from tbWell where wellName='{0}'",dr["wellName"].ToString().Trim());
						string strPrice=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();					

						dr["allUsedMony"]=double.Parse(dr["allAmount"].ToString())*double.Parse(strPrice);

						//dr["leftAmount"]=dtAm.Rows[i]["leftAmount"].ToString();
						//dr["leftMony"]=dtAm.Rows[i]["leftMony"].ToString();
				

//						if(dtSa.Rows[i]["time"].ToString().IndexOf(":")<0)
//						{
//							dtSa.Rows[i]["time"]=dtSa.Rows[i]["time"].ToString().Replace("-","年");
//							//dtAm.Rows[i]["time"]=dtAm.Rows[i]["time"].ToString()+"月";
//						}
					
						DateTime dtime=DateTime.Parse(dtSa.Rows[0]["time"].ToString());	
			
						string strTime=dtSa.Rows[0]["time"].ToString();
						DateTime dtTime=DateTime.Parse(strTime);
						strTime=string.Format("{0}-{1}-{2} {3}:00",dtTime.Year.ToString(),dtTime.Month.ToString(),dtTime.Day.ToString(),dtTime.Hour.ToString());
						string strTime1=dtSa.Rows[0]["time1"].ToString();
						dtTime=DateTime.Parse(strTime1);
						strTime1=string.Format("{0}-{1}-{2} {3}:00",dtTime.Year.ToString(),dtTime.Month.ToString(),dtTime.Day.ToString(),dtTime.Hour.ToString());

						dr["time"]=string.Format("{0} 至 {1}",strTime,strTime1);

						string strWellName=dtSa.Rows[0]["wellName"].ToString().Trim();
						strTime=dtSa.Rows[0]["time"].ToString().Trim();

						DataRow drSa=null;

						if(this.getSalDr1(dtSa,strWellName,strTime,ref drSa))
						{
							dr["allMony"]=drSa["salMony"].ToString();
							dr["allBuyAmount"]=drSa["salAmount"].ToString();
							double dLeftMony=double.Parse(dr["allMony"].ToString())-double.Parse(dr["allUsedMony"].ToString());
							dr["leftMony"]=dLeftMony.ToString();
							double dLeftAmount=double.Parse(dr["allBuyAmount"].ToString())-double.Parse(dr["allAmount"].ToString());
							dr["leftAmount"]=dLeftAmount.ToString();
						}   
						else
						{
							dr["allMony"]="0";
							dr["allBuyAmount"]="0";
							double dLeftMony=double.Parse(dr["allMony"].ToString())-double.Parse(dr["allUsedMony"].ToString());
							dr["leftMony"]=dLeftMony.ToString();
							double dLeftAmount=double.Parse(dr["allBuyAmount"].ToString())-double.Parse(dr["allAmount"].ToString());
							dr["leftAmount"]=dLeftAmount.ToString();
						}
						dt.Rows.Add(dr);
					}
				}

				for(int i=0;i<dtAm.Rows.Count;i++)
				{
					DataRow dr=dt.NewRow();

					//dr["allMony"]=dtAm.Rows[i]["allMony"].ToString();

					dr["allAmount"]=dtAm.Rows[i]["allAmount"].ToString();
					dr["wellName"]=dtAm.Rows[i]["wellName"].ToString();

					string strSql=string.Format("select price1 from tbWell where wellName='{0}'",dr["wellName"].ToString().Trim());
					string strPrice=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();					

					dr["allUsedMony"]=double.Parse(dr["allAmount"].ToString())*double.Parse(strPrice);

					//dr["leftAmount"]=dtAm.Rows[i]["leftAmount"].ToString();
					//dr["leftMony"]=dtAm.Rows[i]["leftMony"].ToString();
				

					if(dtAm.Rows[i]["time"].ToString().IndexOf(":")<0)
					{
						dtAm.Rows[i]["time"]=dtAm.Rows[i]["time"].ToString().Replace("-","年");
						//dtAm.Rows[i]["time"]=dtAm.Rows[i]["time"].ToString()+"月";
					}
					
					DateTime dtime=DateTime.Parse(dtAm.Rows[i]["time"].ToString());	
			
					string strTime=dtAm.Rows[i]["time"].ToString();
					DateTime dtTime=DateTime.Parse(strTime);
					strTime=string.Format("{0}-{1}-{2} {3}:00",dtTime.Year.ToString(),dtTime.Month.ToString(),dtTime.Day.ToString(),dtTime.Hour.ToString());
					string strTime1=dtAm.Rows[i]["time1"].ToString();
					dtTime=DateTime.Parse(strTime1);
					strTime1=string.Format("{0}-{1}-{2} {3}:00",dtTime.Year.ToString(),dtTime.Month.ToString(),dtTime.Day.ToString(),dtTime.Hour.ToString());

					dr["time"]=string.Format("{0} 至 {1}",strTime,strTime1);

					string strWellName=dtAm.Rows[i]["wellName"].ToString().Trim();
	strTime=dtAm.Rows[i]["time"].ToString().Trim();

					DataRow drSa=null;

					if(this.getSalDr1(dtSa,strWellName,strTime,ref drSa))
					{
						dr["allMony"]=drSa["salMony"].ToString();
						dr["allBuyAmount"]=drSa["salAmount"].ToString();
						double dLeftMony=double.Parse(dr["allMony"].ToString())-double.Parse(dr["allUsedMony"].ToString());
						dr["leftMony"]=dLeftMony.ToString();
						double dLeftAmount=double.Parse(dr["allBuyAmount"].ToString())-double.Parse(dr["allAmount"].ToString());
						dr["leftAmount"]=dLeftAmount.ToString();
					}   
					else
					{
						dr["allMony"]="0";
						dr["allBuyAmount"]="0";
						double dLeftMony=double.Parse(dr["allMony"].ToString())-double.Parse(dr["allUsedMony"].ToString());
						dr["leftMony"]=dLeftMony.ToString();
						double dLeftAmount=double.Parse(dr["allBuyAmount"].ToString())-double.Parse(dr["allAmount"].ToString());
						dr["leftAmount"]=dLeftAmount.ToString();
					}
					dt.Rows.Add(dr);
				}

				//尚未招测
				if(dtAm.Rows.Count==0)
				{
					for(int i=0;i<dtSa.Rows.Count;i++)
					{
							DataRow dr=dt.NewRow();
						dr["wellName"]=dtSa.Rows[i]["wellName"].ToString();
						
						    dr["allMony"]=dtSa.Rows[i]["salMony"].ToString();
						    dr["allBuyAmount"]=dtSa.Rows[i]["salAmount"].ToString();

						string strTime=dtSa.Rows[i]["time"].ToString();
						DateTime dtTime=DateTime.Parse(strTime);
						strTime=string.Format("{0}-{1}-{2} {3}:00",dtTime.Year.ToString(),dtTime.Month.ToString(),dtTime.Day.ToString(),dtTime.Hour.ToString());
						string strTime1=dtSa.Rows[i]["time1"].ToString();
						dtTime=DateTime.Parse(strTime1);
						strTime1=string.Format("{0}-{1}-{2} {3}:00",dtTime.Year.ToString(),dtTime.Month.ToString(),dtTime.Day.ToString(),dtTime.Hour.ToString());

						dr["time"]=string.Format("{0} 至 {1}",strTime,strTime1);

						    dt.Rows.Add(dr);
						}
				}

				//this.addSumN(ref dt);
						  
				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				Application.Exit();
				return false;
			}
			
		}

		private bool getSalDr1(DataTable dtSa,string strWellName,string strTime,ref DataRow Dr)
		{
			try
			{

				for(int i=0;i<dtSa.Rows.Count;i++)
				{
					if(dtSa.Rows[i]["wellName"].ToString().Trim()==strWellName)
					{
						DateTime dtimeSa=DateTime.Parse(dtSa.Rows[i]["time"].ToString());
						DateTime dtimeAm=DateTime.Parse(strTime);

						if((dtimeSa.Year==dtimeAm.Year)&&(dtimeSa.Month==dtimeAm.Month))
						{
							Dr=dtSa.Rows[i];
							return true;
						}
					}
				}
						  
				return false;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}			
		}

		private bool getSalDrEx(DataTable dtSa,string strWellName,string strTime,ref DataRow Dr)
		{
			try
			{

				for(int i=0;i<dtSa.Rows.Count;i++)
				{
					if(dtSa.Rows[i]["wellName"].ToString().Trim()==strWellName)
					{
						DateTime dtimeSa=DateTime.Parse(dtSa.Rows[i]["time"].ToString());
						DateTime dtimeAm=DateTime.Parse(strTime);

						if((dtimeSa.Year==dtimeAm.Year)&&((dtimeSa.Month-1)==dtimeAm.Month))
						{
							Dr=dtSa.Rows[i];
							return true;
						}
					}
				}
						  
				return false;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}			
		}


		private bool getSaDr(DataTable dtSa,string strWellName,string strTime,ref DataRow Dr)
		{
			try
			{

				for(int i=0;i<dtSa.Rows.Count;i++)
				{
					if(dtSa.Rows[i]["wellName"].ToString().Trim()==strWellName)
					{
						DateTime dtimeSa=DateTime.Parse(dtSa.Rows[i]["time"].ToString());
						DateTime dtimeAm=DateTime.Parse(strTime);

						if((dtimeSa.Year==dtimeAm.Year)&&(dtimeSa.Month==dtimeAm.Month))
						{
							Dr=dtSa.Rows[i];
							return true;
						}
					}
				}
						  
				return false;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}			
		}

		private bool copyDtN(DataTable dt,ref DataTable dtN)
		{
			try
			{
				dtN.Rows.Clear();

				for(int i=0;i<dt.Rows.Count;i++)
				{
					DataRow dr=dtN.NewRow();
					for(int j=0;j<dr.Table.Columns.Count;j++)
					{
						string strColName=dr.Table.Columns[j].ColumnName;
						
						try
						{
							if((dt.Rows[i][strColName]!=null)&&(dt.Rows[i][strColName].ToString()!=""))
							{
								dr[j]=dt.Rows[i][strColName].ToString();
							}							
						}
						catch
						{							
						}						
					}
					dtN.Rows.Add(dr);
				}

				return true;

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}	
		
		private void button5_Click_1(object sender, System.EventArgs e)
		{
			this.Close();
		}

		//本月购水统计
		private void button8_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.trvWel.SelectedNode.Text.IndexOf("列表")>=0)			
				{
					return;
				}
				switch(this.m_strSelNodeType)
				{
					case "zhan":
						this.monthStaticRep1();
						break;
					case "dep":
						this.monthStaticRepDep1();
						break;
					case "manaPer":
						//this.avgRepManaPerMonth();
						break;
					default:
						if(this.lblName.Text.IndexOf("乡镇")>=0)
						{
						this.monthStaticRepCountry1();
							break;
						}
						MessageBox.Show("请选中要进行统计的监测站、单位或操作员!");
						break;
				}
				this.paintOneLine();
			}
			catch(Exception ex)
			{
cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		#region"本月统计"

		private void monthStaticRep1()
		{
			try
			{
				DateTime dtFrom=new DateTime();
				DateTime dtTo=new DateTime();

				if(this.txtYearFrom1.Text.Trim().Length!=4)
				{
					MessageBox.Show("查询起始年份输入有误，其长度应为4位！");
					return;
				}

				if(this.txtYearTo1.Text.Trim().Length!=4)
				{
					MessageBox.Show("查询截止年份输入有误，其长度应为4位！");
					return;
				}

				try
				{
					string strTime=this.txtYearFrom1.Text.Trim()+"-"+this.numFrom1.Value.ToString().Trim()+"-1";
					dtFrom=DateTime.Parse(strTime);
					strTime=this.txtYearTo1.Text.Trim()+"-"+this.numTo1.Value.ToString().Trim()+"-1";
					dtTo=DateTime.Parse(strTime);
				}
				catch(Exception e)
				{
					MessageBox.Show("查询起始、截止时间输入有误！");
				}

				string strFrom=dtFrom.ToShortDateString();		
				string strTo=dtTo.ToShortDateString();	

				string strZhanName=this.txtZhan.Text.Trim();
				string strSql=string.Format("select wellNo from tbWell where wellName='{0}'",strZhanName);


				int iYearF1=0;
				int iYearT1=0;

				try
				{
					iYearF1=int.Parse(this.txtYearFrom1.Text.Trim());
					iYearT1=int.Parse(this.txtYearTo1.Text.Trim());

				}
				catch
				{
					MessageBox.Show("查询起止年份输入有误!");
					return;
				}


				if(iYearT1<iYearF1)
				{
					MessageBox.Show("查询起止年份输入有误!");
					return;
				}

				int iIns=(int.Parse(this.txtYearTo1.Text.Trim())-int.Parse(this.txtYearFrom1.Text.Trim()))*12+int.Parse(this.numTo1.Value.ToString())-int.Parse(this.numFrom1.Value.ToString());
				DataTable dtAvgEx=new DataTable();
				
				for(int x=0;x<=iIns;x++)
				{
					string strZhanNo=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();
					string strTime=this.txtYearFrom1.Text.Trim()+"-"+this.numFrom1.Value.ToString().Trim()+"-1";
					dtFrom=DateTime.Parse(strTime);
					dtTo=dtFrom.AddMonths(x);

					strFrom=dtTo.ToShortDateString();		
					strTo=dtTo.ToShortDateString();		

					DataTable dtAvg=new DataTable();

					if(CReportDll.comReport.CSalReport.getDtAvgReportMonth(strZhanNo,strFrom,strTo,ref dtAvg)==false)
					{
						return;
					}

					DataTable dtAvg1=new DataTable();
					if(BengZhan.comReport.CReports.getDtMonthAvgReport(strZhanNo,strFrom,strTo,ref dtAvg1)==false)
					{
						return;
					}		

				
					DataTable dtNew=new DataTable();
				
					if(this.mergeDt(dtAvg,dtAvg1,ref dtNew)==false)
					{
						return;
					}


					dtAvg=dtNew;
					BengZhan.comReport.CReports.copyDt(dtAvg,ref dtAvgEx);

				}


					 
				DataTable dt=(DataTable)this.dataGrid5.DataSource;	
			
				dt.Rows.Clear();					
		
				for(int i=0;i<dtAvgEx.Rows.Count;i++)
				{
					DataRow dr=dt.NewRow();					
					for(int j=0;j<dt.Columns.Count;j++)
					{
						string strColName=dt.Columns[j].ColumnName;
						dr[strColName]=dtAvgEx.Rows[i][strColName].ToString();				
					}
					dt.Rows.Add(dr);
				}


				strFrom=string.Format("{0}-{1}-1 8:00",dtFrom.Year.ToString(),dtFrom.Month.ToString());				
				strTo=string.Format("{0}-{1}-1 8:00",dtTo.AddMonths(1).Year.ToString(),Convert.ToString(dtTo.AddMonths(1).Month));
		
				string strCapText=string.Format("监测站：{0}    {1}至{2}    本月用水统计表",this.m_strZhanName,strFrom,strTo);
				this.dataGrid5.CaptionText=strCapText;

				this.m_strDtFrom=strFrom;
				this.m_strDtTo=strTo;
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}
		
		private void monthStaticRepDep1()
		{
			try
			{
				DateTime dtFrom=new DateTime();
				DateTime dtTo=new DateTime();

				if(this.txtYearFrom1.Text.Trim().Length!=4)
				{
					MessageBox.Show("查询起始年份输入有误，其长度应为4位！");
					return;
				}

				if(this.txtYearTo1.Text.Trim().Length!=4)
				{
					MessageBox.Show("查询截止年份输入有误，其长度应为4位！");
					return;
				}

				try
				{
					string strTime=this.txtYearFrom1.Text.Trim()+"-"+this.numFrom1.Value.ToString().Trim()+"-1";
					dtFrom=DateTime.Parse(strTime);
					strTime=this.txtYearTo1.Text.Trim()+"-"+this.numTo1.Value.ToString().Trim()+"-1";
					dtTo=DateTime.Parse(strTime);
				}
				catch(Exception e)
				{
					MessageBox.Show("查询起始、截止时间输入有误！");
				}

				int iYearF1=0;
				int iYearT1=0;

				try
				{
					iYearF1=int.Parse(this.txtYearFrom1.Text.Trim());
					iYearT1=int.Parse(this.txtYearTo1.Text.Trim());

				}
				catch
				{
					MessageBox.Show("查询起止年份输入有误!");
					return;
				}


					if(iYearT1<iYearF1)
					{
						MessageBox.Show("查询起止年份输入有误!");
						return;
					}

					int iIns=(int.Parse(this.txtYearTo1.Text.Trim())-int.Parse(this.txtYearFrom1.Text.Trim()))*12+int.Parse(this.numTo1.Value.ToString())-int.Parse(this.numFrom1.Value.ToString());
					
				    DataTable dtAvg=new DataTable();
					DataTable dtRet=new DataTable();

				string strDepName=this.txtZhan.Text.Trim();		
					
					for(int x=0;x<=iIns;x++)
					{

						string strTime=this.txtYearFrom1.Text.Trim()+"-"+this.numFrom1.Value.ToString().Trim()+"-1";
						dtFrom=DateTime.Parse(strTime);
						dtTo=dtFrom.AddMonths(x);

						string strFrom=dtTo.ToShortDateString();		
						string strTo=dtTo.ToShortDateString();							
		
						string strSql=string.Format("select wellNo from tbWell where depName='{0}'",strDepName);

						DataTable dtDep=new DataTable();
						BengZhan.CDBConnection.getDataTable(ref dtDep,strSql,"dtDep");	
					
						DataTable dtAvgEx=new DataTable();

						for(int i=0;i<dtDep.Rows.Count;i++)
						{

							string strZhanNo=dtDep.Rows[i]["wellNo"].ToString().Trim();

							if(CReportDll.comReport.CSalReport.getDtAvgReportMonth(strZhanNo,strFrom,strTo,ref dtAvg)==false)
							{
								return;
							}

							DataTable dtAvg1=new DataTable();
							if(BengZhan.comReport.CReports.getDtMonthAvgReport(strZhanNo,strFrom,strTo,ref dtAvg1)==false)
							{
								return;
							}		

				
							DataTable dtNew=new DataTable();
				
							if(this.mergeDt(dtAvg,dtAvg1,ref dtNew)==false)
							{
								return;
							}

BengZhan.comReport.CReports.copyDt(dtNew,ref dtAvgEx);

							//dtAvg=dtNew;						

						}

						this.addSumRowEx(ref dtAvgEx);
						BengZhan.comReport.CReports.copyDt(dtAvgEx,ref dtRet);

					}			

				dtAvg=dtRet;

				DataTable dt=(DataTable)this.dataGrid5.DataSource;	
			
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

				dtTo=dtFrom.AddMonths(iIns);

				
				string strFromEx=string.Format("{0}-{1}-1 8:00",dtFrom.Year.ToString(),dtFrom.Month.ToString());				
				string strToEx=string.Format("{0}-{1}-1 8:00",dtTo.AddMonths(1).Year.ToString(),Convert.ToString(dtTo.AddMonths(1).Month));
				
				string strCapText=string.Format("单位：{0}    {1}至{2}    本月用水统计表",strDepName,strFromEx,strToEx);
				
				this.dataGrid5.CaptionText=strCapText;
				this.m_strDtFrom=strFromEx;
				this.m_strDtTo=strToEx;
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void monthStaticRepCountry1()
		{
			try
			{
				DateTime dtFrom=new DateTime();
				DateTime dtTo=new DateTime();

				if(this.txtYearFrom1.Text.Trim().Length!=4)
				{
					MessageBox.Show("查询起始年份输入有误，其长度应为4位！");
					return;
				}

				if(this.txtYearTo1.Text.Trim().Length!=4)
				{
					MessageBox.Show("查询截止年份输入有误，其长度应为4位！");
					return;
				}

				try
				{
					string strTime=this.txtYearFrom1.Text.Trim()+"-"+this.numFrom1.Value.ToString().Trim()+"-1";
					dtFrom=DateTime.Parse(strTime);
					strTime=this.txtYearTo1.Text.Trim()+"-"+this.numTo1.Value.ToString().Trim()+"-1";
					dtTo=DateTime.Parse(strTime);
				}
				catch(Exception e)
				{
					MessageBox.Show("查询起始、截止时间输入有误！");
				}	

				int iYearF1=0;
				int iYearT1=0;

				try
				{
					iYearF1=int.Parse(this.txtYearFrom1.Text.Trim());
					iYearT1=int.Parse(this.txtYearTo1.Text.Trim());
				}
				catch
				{
					MessageBox.Show("查询起止年份输入有误!");
					return;
				}

				if(iYearT1<iYearF1)
				{
					MessageBox.Show("查询起止年份输入有误!");
					return;
				}

				int iIns=(int.Parse(this.txtYearTo1.Text.Trim())-int.Parse(this.txtYearFrom1.Text.Trim()))*12+int.Parse(this.numTo1.Value.ToString())-int.Parse(this.numFrom1.Value.ToString());				

				string strSql=string.Format("select depShortName from tbDep where CountryName='{0}'",this.txtZhan.Text.Trim());
				DataTable dtDep=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtDep,strSql,"dtDep");

				DataTable dtAvg=new DataTable();
				DataTable dtRet=new DataTable();

				for(int i=0;i<dtDep.Rows.Count;i++)
				{

					string strDepName=dtDep.Rows[i]["depShortName"].ToString().Trim();			
					
					for(int x=0;x<=iIns;x++)
					{

						string strTime=this.txtYearFrom1.Text.Trim()+"-"+this.numFrom1.Value.ToString().Trim()+"-1";
						dtFrom=DateTime.Parse(strTime);
						dtTo=dtFrom.AddMonths(x);

						string strFrom=dtTo.ToShortDateString();		
						string strTo=dtTo.ToShortDateString();							
		
						strSql=string.Format("select wellNo from tbWell where depName='{0}'",strDepName);

			            DataTable dtWell=new DataTable();
						BengZhan.CDBConnection.getDataTable(ref dtWell,strSql,"dtDep");	
					
						DataTable dtAvgEx=new DataTable();

						for(int y=0;y<dtWell.Rows.Count;y++)
						{
							string strZhanNo=dtWell.Rows[y]["wellNo"].ToString().Trim();

							if(CReportDll.comReport.CSalReport.getDtAvgReportMonth(strZhanNo,strFrom,strTo,ref dtAvg)==false)
							{
								return;
							}

							DataTable dtAvg1=new DataTable();
							if(BengZhan.comReport.CReports.getDtMonthAvgReport(strZhanNo,strFrom,strTo,ref dtAvg1)==false)
							{
								return;
							}				
							DataTable dtNew=new DataTable();
				
							if(this.mergeDt(dtAvg,dtAvg1,ref dtNew)==false)
							{
								return;
							}

							BengZhan.comReport.CReports.copyDt(dtNew,ref dtAvgEx);												

						}

						this.addSumRowEx(ref dtAvgEx);
						BengZhan.comReport.CReports.copyDt(dtAvgEx,ref dtRet);
					}			
				}			

				dtAvg=dtRet;

				DataTable dt=(DataTable)this.dataGrid5.DataSource;	
			
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

				dtTo=dtFrom.AddMonths(iIns);

				
				string strFromEx=string.Format("{0}-{1}-1 8:00",dtFrom.Year.ToString(),dtFrom.Month.ToString());				
				string strToEx=string.Format("{0}-{1}-1 8:00",dtTo.AddMonths(1).Year.ToString(),Convert.ToString(dtTo.AddMonths(1).Month));
				
				string strCapText=string.Format("乡镇：{0}    {1}至{2}    本月用水统计表",this.txtZhan.Text.Trim(),strFromEx,strToEx);
				
				this.dataGrid5.CaptionText=strCapText;
				this.m_strDtFrom=strFromEx;
				this.m_strDtTo=strToEx;

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		//本月打印
		private void button7_Click(object sender, System.EventArgs e)
		{		
			try
			{
				DataTable dt=(DataTable)this.dataGrid5.DataSource;
				DataTable dtE=dt.Copy();
				this.clearNullDr(ref dtE);
				if(dtE.Rows.Count<=0)
				{
					MessageBox.Show("没有可打印的数据!");
					return;
				}

				this.printMonth2();
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}	  
		}

		#endregion


		#region"单位本月统计"

		private void button9_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		
		#endregion

		#region"use water compute"

		private void btnCer5_Click(object sender, System.EventArgs e)
		{
			try
			{
				DataTable dtDisp=new DataTable();

				string strFrom=this.dtpF.Value.ToShortDateString();
				strFrom=strFrom+" "+this.numHF.Value.ToString().Trim()+":00:00";
				string strTo=this.dtpT.Value.ToShortDateString();
				strTo=strTo+" "+this.numHT.Value.ToString().Trim()+":00:00";

				string strZhanName=this.txtZhan.Text.Trim();

				if(this.lblName.Text.IndexOf("单位")>=0)
				{
					this.dispDepRep(strZhanName,strFrom,strTo);
				}
				if(this.lblName.Text.IndexOf("站点")>=0)
				{
					this.dispZhanRep(strZhanName,strFrom,strTo,ref dtDisp,true);
				}
				if(this.lblName.Text.IndexOf("乡镇")>=0)
				{
					this.dispCountryRep(strZhanName,strFrom,strTo);
				}
				this.paintOneLine();
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void dispDepRep(string strDepName,string strFrom,string strTo)
		{
			try
			{
				string strSql=string.Format("select wellName from tbWell where depName='{0}' order by wellNo",strDepName);
				DataTable dtWell=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtWell,strSql,"dtWell");
				DataTable dtDisp=new DataTable();
				DataTable dtAvg=new DataTable();

				for(int i=0;i<dtWell.Rows.Count;i++)			
				{
					string strZhanName=dtWell.Rows[i]["wellName"].ToString();
					this.dispZhanRep(strZhanName,strFrom,strTo,ref dtDisp,false);
					BengZhan.comReport.CReports.copyDt(dtDisp,ref dtAvg);
				}
				//DataTable dtAvg=(DataTable)this.dgURep.DataSource;
				this.addSumRowEx(ref dtAvg);
			
				DataTable dt=(DataTable)this.dgURep.DataSource;
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
	
				string strCapText=string.Format("单位：{0}  {1}至{2}   用水统计表",strDepName,strFrom,strTo);
				this.dgURep.CaptionText=strCapText;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void dispCountryRep(string strCountryName,string strFrom,string strTo)
		{
			try
			{
				string strSql=string.Format("select depShortName from tbDep where countryName='{0}'",strCountryName);
				DataTable dtDep=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtDep,strSql,"depDt");

				DataTable dtRet=new DataTable();
				
				for(int i=0;i<dtDep.Rows.Count;i++)
				{
					DataTable dtAvg=new DataTable();
					string strDepName=dtDep.Rows[i]["depShortName"].ToString().Trim();
                    strSql=string.Format("select wellName from tbWell where depName='{0}' order by wellNo",strDepName);
					DataTable dtWell=new DataTable();
					BengZhan.CDBConnection.getDataTable(ref dtWell,strSql,"dtWell");
					for(int j=0;j<dtWell.Rows.Count;j++)
					{
						string strWellName=dtWell.Rows[j]["wellName"].ToString().Trim();
						DataTable dtDisp=new DataTable();
						this.dispZhanRep(strWellName,strFrom,strTo,ref dtDisp,false);
						//this.addSumRowEx(ref dtDisp);
						BengZhan.comReport.CReports.copyDt(dtDisp,ref dtAvg);
					}
					this.addSumRowEx(ref dtAvg);
					BengZhan.comReport.CReports.copyDt(dtAvg,ref dtRet);

				}

				DataTable dt=(DataTable)this.dgURep.DataSource;
				dt.Rows.Clear();
				for(int i=0;i<dtRet.Rows.Count;i++)
				{
					DataRow dr=dt.NewRow();					
					for(int j=0;j<dt.Columns.Count;j++)
					{
						string strColName=dt.Columns[j].ColumnName;
						dr[strColName]=dtRet.Rows[i][strColName].ToString();				
					}
					dt.Rows.Add(dr);
				}	
	
				string strCapText=string.Format("乡镇：{0}    {1}至{2}    用水统计表",strCountryName,strFrom,strTo);
				this.dgURep.CaptionText=strCapText;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void dispZhanRep(string strZhanName,string strFrom,string strTo,ref DataTable dtDisp,bool bDisp)
		{
			try
			{
				string strSql=string.Format("select wellNo from tbWell where wellName='{0}'",strZhanName);

				string strZhanNo=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();		

				DataTable dtAvg=new DataTable();

				if(CReportDll.comReport.CSalReport.getDtAvgReportNew(strZhanNo,strFrom,strTo,ref dtAvg)==false)
				{
					return;
				}

				DataTable dtAvg1=new DataTable();
				if(BengZhan.comReport.CReports.getDtNewAvgReport(strZhanNo,strFrom,strTo,ref dtAvg1)==false)
				{
					return;
				}		

				
				DataTable dtNew=new DataTable();
				
				if(this.mergeDt1(dtAvg,dtAvg1,ref dtNew)==false)
				{
					return;
				}


				dtAvg=dtNew;

				DataTable dt=(DataTable)this.dgURep.DataSource;	
			
				dt.Rows.Clear();	

				if(bDisp)
				{
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
				}				

				dtDisp=dtAvg;

			//	strFrom=string.Format("{0}-{1}-1 8:00",dtFrom.Year.ToString(),dtFrom.Month.ToString());				
				//strTo=string.Format("{0}-{1}-1 8:00",dtTo.Year.ToString(),Convert.ToString(dtTo.AddMonths(1).Month));
		
				string strCapText=string.Format("监测站：{0}    {1}至{2}    监测站本月用水统计表",strZhanName,strFrom,strTo);
				this.dgURep.CaptionText=strCapText;

				this.m_strDtFrom=strFrom;
				this.m_strDtTo=strTo;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void btnE5_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnP5_Click(object sender, System.EventArgs e)
		{
			try
			{
				DataTable dt=(DataTable)this.dgURep.DataSource;
				DataTable dtE=dt.Copy();
				this.clearNullDr(ref dtE);
				if(dtE.Rows.Count<=0)
				{
					MessageBox.Show("没有可打印的数据!");
					return;
				}

				this.printMonth3();
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}	  
		} 
		private void printMonth3()
		{
			try
			{
				if(this.m_xDocPrint==null)
				{
					this.m_xDocPrint=new XmlDocument();
					this.m_xDocPrint.Load("salRepPrint.xml");
				}

				XmlNode xNode=this.m_xDocPrint.DocumentElement.SelectSingleNode("./rep[@val='UWRep']");

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
				DataTable dtDetail=(DataTable)this.dgURep.DataSource;


				for(int i=0;i<dtDetail.Rows.Count;i++)
				{
					dtPrint.ImportRow(dtDetail.Rows[i]);
				}	
				this.clearBlankRow(dtPrint);	
 
				string strTitle=this.dgURep.CaptionText.Trim();
				string strTitleE="";

				if(strTitle.IndexOf("操作员")>=0)
				{
					strTitleE="操作员售水月统计表";
					strTitle=strTitle.Substring(0,strTitle.IndexOf("操作员售水月统计表"));
				}
				else
				{
					strTitleE="用水统计表";
					strTitle=strTitle.Substring(0,strTitle.IndexOf("用水统计表"));
				}
		
				cutePrint.cutePrinter dgp=new cutePrint.cutePrinter(this.dgPrint,strTitleE,30);
				int iTimeMinus=int.Parse(xNode.Attributes.GetNamedItem("iTimeMinus").Value.Trim());
				dgp.iTimeMinus=iTimeMinus;	
				dgp.leftMargin=int.Parse(xNode.Attributes.GetNamedItem("leftMargin").Value.Trim());
				dgp.strTitle=strTitle;	
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

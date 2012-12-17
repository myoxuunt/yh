using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;
using System.Data ;
using System.Data.SqlClient;


namespace CReportDll.comReport.newRep
{
	/// <summary>
	/// frmMonthStac 的摘要说明。
	/// </summary>
	public class frmMonthStac : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TreeView trvWel;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.TextBox txtZhan;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.ComboBox cmbYue1;
		private System.Windows.Forms.Button btnCer;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.ComboBox cmbYue2;
		private System.Windows.Forms.TextBox txtYearFrom1;
		private System.Windows.Forms.TextBox txtYearTo1;
		private System.Windows.Forms.GroupBox groupBox30;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.LinkLabel lnkInfo;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtp2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbH;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown numFrom1;
		private System.Windows.Forms.NumericUpDown numTo1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListView listView3;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ListView listView4;
		private System.Windows.Forms.ComboBox cmbMonth;
		private System.Windows.Forms.DataGrid dg3;
		private System.Windows.Forms.DataGrid dg2;
		private System.Windows.Forms.DataGrid dg1;
		private System.Windows.Forms.Button btnPrint1;
		private System.Windows.Forms.Button btnClose1;
		private System.ComponentModel.IContainer components;

		public frmMonthStac()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmMonthStac));
			this.groupBox30 = new System.Windows.Forms.GroupBox();
			this.trvWel = new System.Windows.Forms.TreeView();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.txtZhan = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.groupBox10 = new System.Windows.Forms.GroupBox();
			this.cmbMonth = new System.Windows.Forms.ComboBox();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnCer = new System.Windows.Forms.Button();
			this.cmbYue2 = new System.Windows.Forms.ComboBox();
			this.txtYearTo1 = new System.Windows.Forms.TextBox();
			this.cmbYue1 = new System.Windows.Forms.ComboBox();
			this.txtYearFrom1 = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
			this.lblInfo = new System.Windows.Forms.Label();
			this.lnkInfo = new System.Windows.Forms.LinkLabel();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.btnClose1 = new System.Windows.Forms.Button();
			this.btnPrint1 = new System.Windows.Forms.Button();
			this.cmbH = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dtp2 = new System.Windows.Forms.DateTimePicker();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.listView4 = new System.Windows.Forms.ListView();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.listView3 = new System.Windows.Forms.ListView();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dg1 = new System.Windows.Forms.DataGrid();
			this.listView2 = new System.Windows.Forms.ListView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dg3 = new System.Windows.Forms.DataGrid();
			this.dg2 = new System.Windows.Forms.DataGrid();
			this.numFrom1 = new System.Windows.Forms.NumericUpDown();
			this.numTo1 = new System.Windows.Forms.NumericUpDown();
			this.listView1 = new System.Windows.Forms.ListView();
			this.groupBox30.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox10.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dg3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dg2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numFrom1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numTo1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox30
			// 
			this.groupBox30.Controls.Add(this.trvWel);
			this.groupBox30.Location = new System.Drawing.Point(0, 51);
			this.groupBox30.Name = "groupBox30";
			this.groupBox30.Size = new System.Drawing.Size(176, 600);
			this.groupBox30.TabIndex = 31;
			this.groupBox30.TabStop = false;
			// 
			// trvWel
			// 
			this.trvWel.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.trvWel.ImageIndex = -1;
			this.trvWel.Location = new System.Drawing.Point(8, 16);
			this.trvWel.Name = "trvWel";
			this.trvWel.SelectedImageIndex = -1;
			this.trvWel.Size = new System.Drawing.Size(160, 576);
			this.trvWel.TabIndex = 0;
			this.trvWel.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvWel_AfterSelect);
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.txtZhan);
			this.groupBox6.Controls.Add(this.lblName);
			this.groupBox6.Location = new System.Drawing.Point(0, 3);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(176, 48);
			this.groupBox6.TabIndex = 30;
			this.groupBox6.TabStop = false;
			// 
			// txtZhan
			// 
			this.txtZhan.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtZhan.Location = new System.Drawing.Point(48, 16);
			this.txtZhan.Name = "txtZhan";
			this.txtZhan.Size = new System.Drawing.Size(120, 21);
			this.txtZhan.TabIndex = 1;
			this.txtZhan.Text = "";
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(8, 19);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(48, 14);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "站点：";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox10
			// 
			this.groupBox10.Controls.Add(this.cmbMonth);
			this.groupBox10.Controls.Add(this.button5);
			this.groupBox10.Controls.Add(this.button4);
			this.groupBox10.Controls.Add(this.btnExit);
			this.groupBox10.Controls.Add(this.btnPrint);
			this.groupBox10.Controls.Add(this.btnCer);
			this.groupBox10.Controls.Add(this.cmbYue2);
			this.groupBox10.Controls.Add(this.txtYearTo1);
			this.groupBox10.Controls.Add(this.cmbYue1);
			this.groupBox10.Controls.Add(this.txtYearFrom1);
			this.groupBox10.Location = new System.Drawing.Point(736, 3);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new System.Drawing.Size(8, 48);
			this.groupBox10.TabIndex = 32;
			this.groupBox10.TabStop = false;
			this.groupBox10.Visible = false;
			// 
			// cmbMonth
			// 
			this.cmbMonth.Location = new System.Drawing.Point(8, 17);
			this.cmbMonth.Name = "cmbMonth";
			this.cmbMonth.Size = new System.Drawing.Size(72, 20);
			this.cmbMonth.TabIndex = 13;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(240, 16);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(56, 23);
			this.button5.TabIndex = 12;
			this.button5.Text = "欠费户";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(136, 16);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(48, 23);
			this.button4.TabIndex = 11;
			this.button4.Text = "年结";
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(296, 16);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(52, 23);
			this.btnExit.TabIndex = 10;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(184, 16);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(52, 23);
			this.btnPrint.TabIndex = 9;
			this.btnPrint.Text = "打印";
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// btnCer
			// 
			this.btnCer.Location = new System.Drawing.Point(80, 16);
			this.btnCer.Name = "btnCer";
			this.btnCer.Size = new System.Drawing.Size(52, 23);
			this.btnCer.TabIndex = 8;
			this.btnCer.Text = "月结";
			this.btnCer.Click += new System.EventHandler(this.btnCer_Click);
			// 
			// cmbYue2
			// 
			this.cmbYue2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.cmbYue2.Location = new System.Drawing.Point(184, 17);
			this.cmbYue2.Name = "cmbYue2";
			this.cmbYue2.Size = new System.Drawing.Size(8, 20);
			this.cmbYue2.TabIndex = 7;
			this.cmbYue2.Visible = false;
			// 
			// txtYearTo1
			// 
			this.txtYearTo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtYearTo1.Location = new System.Drawing.Point(96, 16);
			this.txtYearTo1.Name = "txtYearTo1";
			this.txtYearTo1.Size = new System.Drawing.Size(8, 21);
			this.txtYearTo1.TabIndex = 5;
			this.txtYearTo1.Text = "";
			this.txtYearTo1.Visible = false;
			// 
			// cmbYue1
			// 
			this.cmbYue1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.cmbYue1.Location = new System.Drawing.Point(8, 16);
			this.cmbYue1.Name = "cmbYue1";
			this.cmbYue1.Size = new System.Drawing.Size(24, 20);
			this.cmbYue1.TabIndex = 3;
			this.cmbYue1.Text = "2007.12";
			this.cmbYue1.Visible = false;
			// 
			// txtYearFrom1
			// 
			this.txtYearFrom1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtYearFrom1.Location = new System.Drawing.Point(8, 17);
			this.txtYearFrom1.Name = "txtYearFrom1";
			this.txtYearFrom1.Size = new System.Drawing.Size(24, 21);
			this.txtYearFrom1.TabIndex = 1;
			this.txtYearFrom1.Text = "";
			this.txtYearFrom1.Visible = false;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// lblInfo
			// 
			this.lblInfo.Location = new System.Drawing.Point(664, 7);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(184, 40);
			this.lblInfo.TabIndex = 34;
			this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click_1);
			// 
			// lnkInfo
			// 
			this.lnkInfo.Location = new System.Drawing.Point(664, 8);
			this.lnkInfo.Name = "lnkInfo";
			this.lnkInfo.Size = new System.Drawing.Size(128, 40);
			this.lnkInfo.TabIndex = 35;
			this.lnkInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lnkInfo.Visible = false;
			this.lnkInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkInfo_LinkClicked);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.btnClose1);
			this.groupBox5.Controls.Add(this.btnPrint1);
			this.groupBox5.Controls.Add(this.cmbH);
			this.groupBox5.Controls.Add(this.label5);
			this.groupBox5.Controls.Add(this.label1);
			this.groupBox5.Controls.Add(this.dtp2);
			this.groupBox5.Controls.Add(this.button3);
			this.groupBox5.Controls.Add(this.button2);
			this.groupBox5.Location = new System.Drawing.Point(176, 3);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(480, 48);
			this.groupBox5.TabIndex = 36;
			this.groupBox5.TabStop = false;
			this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
			// 
			// btnClose1
			// 
			this.btnClose1.Location = new System.Drawing.Point(400, 16);
			this.btnClose1.Name = "btnClose1";
			this.btnClose1.Size = new System.Drawing.Size(54, 23);
			this.btnClose1.TabIndex = 11;
			this.btnClose1.Text = "退出";
			this.btnClose1.Click += new System.EventHandler(this.btnClose1_Click);
			// 
			// btnPrint1
			// 
			this.btnPrint1.Location = new System.Drawing.Point(344, 16);
			this.btnPrint1.Name = "btnPrint1";
			this.btnPrint1.Size = new System.Drawing.Size(54, 23);
			this.btnPrint1.TabIndex = 10;
			this.btnPrint1.Text = "打印";
			this.btnPrint1.Click += new System.EventHandler(this.btnPrint1_Click);
			// 
			// cmbH
			// 
			this.cmbH.Location = new System.Drawing.Point(176, 16);
			this.cmbH.Name = "cmbH";
			this.cmbH.Size = new System.Drawing.Size(40, 20);
			this.cmbH.TabIndex = 9;
			this.cmbH.Text = "15";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(216, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(16, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "时";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "截止时间:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtp2
			// 
			this.dtp2.Location = new System.Drawing.Point(72, 16);
			this.dtp2.Name = "dtp2";
			this.dtp2.Size = new System.Drawing.Size(104, 21);
			this.dtp2.TabIndex = 4;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(288, 16);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(52, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "招测";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(232, 16);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(52, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "总帐";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox4);
			this.panel1.Controls.Add(this.splitter2);
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Controls.Add(this.splitter1);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Location = new System.Drawing.Point(176, 50);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(840, 606);
			this.panel1.TabIndex = 40;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.listView4);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox4.Location = new System.Drawing.Point(363, 371);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(477, 235);
			this.groupBox4.TabIndex = 48;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "groupBox4";
			// 
			// listView4
			// 
			this.listView4.BackColor = System.Drawing.SystemColors.Info;
			this.listView4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView4.Font = new System.Drawing.Font("宋体", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.listView4.GridLines = true;
			this.listView4.Location = new System.Drawing.Point(3, 17);
			this.listView4.Name = "listView4";
			this.listView4.Size = new System.Drawing.Size(471, 215);
			this.listView4.TabIndex = 0;
			this.listView4.View = System.Windows.Forms.View.Details;
			this.listView4.DoubleClick += new System.EventHandler(this.listView4_DoubleClick);
			this.listView4.SelectedIndexChanged += new System.EventHandler(this.listView4_SelectedIndexChanged);
			// 
			// splitter2
			// 
			this.splitter2.Location = new System.Drawing.Point(360, 371);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(3, 235);
			this.splitter2.TabIndex = 47;
			this.splitter2.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.listView3);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox3.Location = new System.Drawing.Point(0, 371);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(360, 235);
			this.groupBox3.TabIndex = 46;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "groupBox3";
			// 
			// listView3
			// 
			this.listView3.BackColor = System.Drawing.SystemColors.Info;
			this.listView3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView3.Font = new System.Drawing.Font("宋体", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.listView3.GridLines = true;
			this.listView3.Location = new System.Drawing.Point(3, 17);
			this.listView3.Name = "listView3";
			this.listView3.Size = new System.Drawing.Size(354, 215);
			this.listView3.TabIndex = 0;
			this.listView3.View = System.Windows.Forms.View.Details;
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter1.Location = new System.Drawing.Point(0, 368);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(840, 3);
			this.splitter1.TabIndex = 45;
			this.splitter1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dg1);
			this.groupBox1.Controls.Add(this.listView2);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.dg3);
			this.groupBox1.Controls.Add(this.dg2);
			this.groupBox1.Controls.Add(this.numFrom1);
			this.groupBox1.Controls.Add(this.numTo1);
			this.groupBox1.Controls.Add(this.listView1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(840, 368);
			this.groupBox1.TabIndex = 41;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "本月用水统计";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_2);
			// 
			// dg1
			// 
			this.dg1.DataMember = "";
			this.dg1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dg1.Location = new System.Drawing.Point(384, 200);
			this.dg1.Name = "dg1";
			this.dg1.TabIndex = 7;
			this.dg1.Visible = false;
			// 
			// listView2
			// 
			this.listView2.Location = new System.Drawing.Point(384, 128);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(8, 8);
			this.listView2.TabIndex = 6;
			this.listView2.Visible = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Location = new System.Drawing.Point(256, 104);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(8, 24);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "groupBox2";
			this.groupBox2.Visible = false;
			// 
			// dg3
			// 
			this.dg3.DataMember = "";
			this.dg3.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dg3.Location = new System.Drawing.Point(168, 152);
			this.dg3.Name = "dg3";
			this.dg3.TabIndex = 4;
			this.dg3.Visible = false;
			// 
			// dg2
			// 
			this.dg2.DataMember = "";
			this.dg2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dg2.Location = new System.Drawing.Point(560, 120);
			this.dg2.Name = "dg2";
			this.dg2.TabIndex = 3;
			this.dg2.Visible = false;
			// 
			// numFrom1
			// 
			this.numFrom1.Location = new System.Drawing.Point(320, 88);
			this.numFrom1.Name = "numFrom1";
			this.numFrom1.Size = new System.Drawing.Size(32, 21);
			this.numFrom1.TabIndex = 2;
			this.numFrom1.Visible = false;
			// 
			// numTo1
			// 
			this.numTo1.Location = new System.Drawing.Point(320, 17);
			this.numTo1.Name = "numTo1";
			this.numTo1.Size = new System.Drawing.Size(40, 21);
			this.numTo1.TabIndex = 1;
			this.numTo1.Visible = false;
			// 
			// listView1
			// 
			this.listView1.BackColor = System.Drawing.SystemColors.Info;
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.Font = new System.Drawing.Font("宋体", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(3, 17);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(834, 348);
			this.listView1.TabIndex = 0;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_2);
			// 
			// frmMonthStac
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(1018, 655);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.lnkInfo);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.groupBox10);
			this.Controls.Add(this.groupBox30);
			this.Controls.Add(this.groupBox6);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmMonthStac";
			this.Text = "总账统计表";
			this.Load += new System.EventHandler(this.frmMonthStac_Load);
			this.groupBox30.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox10.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dg3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dg2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numFrom1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numTo1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion


		#region"drawFrom"

		private string iniMinTime()
		{
			try
			{
//				string strSql=string.Format("select time from tbMinTime");
//				string strTime=BengZhan.CDBConnection.ExecuteScalar(strSql);
//				if(strTime==null||strTime.Trim()=="")				
//				{
//					strSql=string.Format("select min(time) from waterDatas");
//					strTime=BengZhan.CDBConnection.ExecuteScalar(strSql);
//
//					DateTime dtTime=DateTime.Parse(strTime);
//					dtTime.AddDays(-1);
//					strSql=string.Format("insert into tbMinTime(time)values('{0}')",dtTime.ToString());
//					BengZhan.CDBConnection.ExecuteSql(strSql);
//				}
//				strSql=string.Format("select time from tbMinTime");
//				string strMinTime=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();
//				return strMinTime;
				//	this.panel1.Height=this.Height-this.panel1.Location.Y-5;
				return "";


			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return "";

			}
		}

		public static string m_strDispErrInfo="";

		private void iniH()
		{
			for(int i=0;i<=23;i++)
			{
this.cmbH.Items.Add(i.ToString());
			}
			this.cmbH.Text=Convert.ToString(System.DateTime.Now.Hour+1);
		}

		private void frmMonthStac_Load(object sender, System.EventArgs e)
		{
			//this.txtDate.Text=System.DateTime.Now.ToShortDateString();
			//this.dtp1.Value=DateTime.Parse("2007-8-1");;

			this.iniH();

			this.dtp2.Value=System.DateTime.Now;

			//this.nmH.Value=System.DateTime.Now.Hour;

			this.iniMinTime();

			BengZhan.tools.CPaintForm.paintWell("",this.trvWel);
			this.iniFrm();
			this.trvWel.SelectedNode=this.trvWel.Nodes[0];
			this.iniSys();
			this.startTimeFresh();
			this.dispGroup();
			this.clearLsv();

		}
		private void dispGroup()
		{

			XmlDocument xDoc=new XmlDocument();
			xDoc.Load("iniLsv.xml");

			int iHeight=int.Parse(xDoc.DocumentElement.SelectSingleNode("./lsv[@id='1']").Attributes.GetNamedItem("height").Value.Trim());

			//this.groupBox3.Height=0;
			this.groupBox2.Height=0;
			//this.groupBox4.Height=0;

			//this.groupBox3.Visible=false;
			this.groupBox2.Visible=false;
			//this.groupBox4.Visible=false;

			this.groupBox1.Height=this.Height-this.groupBox1.Location.Y-iHeight-this.groupBox3.Height;
			this.groupBox30.Height=this.Height-this.groupBox30.Location.Y-iHeight ;
			this.trvWel.Dock=System.Windows.Forms.DockStyle.Fill;			
			//this.groupBox1.Dock=System.Windows.Forms.DockStyle.Fill;
			//this.groupBox1.Text="";
			//this.listView1.ca

			//this.panel1.Location=new Point(this.panel1.Location.X,this.panel1.Location.Y+10);
		}

		private string m_strTitle3="";

		
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
			this.paintSelectedWell();
		}

		
		private void btnExit_Click(object sender, System.EventArgs e)
		{
		
			this.Close();
	
			//	this.Close();

		}

		private void iniFrm()
		{
			try
			{
				this.cmbYue1.Items.Clear();
				this.cmbYue2.Items.Clear();

				this.cmbYue1.Items.Add("1月");
				this.cmbYue1.Items.Add("2月");
				this.cmbYue1.Items.Add("3月");
				this.cmbYue1.Items.Add("4月");
				this.cmbYue1.Items.Add("5月");
				this.cmbYue1.Items.Add("6月");
				this.cmbYue1.Items.Add("7月");
				this.cmbYue1.Items.Add("8月");
				this.cmbYue1.Items.Add("9月");
				this.cmbYue1.Items.Add("10月");
				this.cmbYue1.Items.Add("11月");
				this.cmbYue1.Items.Add("12月");

				this.cmbYue2.Items.Add("1月");
				this.cmbYue2.Items.Add("2月");
				this.cmbYue2.Items.Add("3月");
				this.cmbYue2.Items.Add("4月");
				this.cmbYue2.Items.Add("5月");
				this.cmbYue2.Items.Add("6月");
				this.cmbYue2.Items.Add("7月");
				this.cmbYue2.Items.Add("8月");
				this.cmbYue2.Items.Add("9月");
				this.cmbYue2.Items.Add("10月");
				this.cmbYue2.Items.Add("11月");
				this.cmbYue2.Items.Add("12月");

				this.cmbMonth.Items.Clear();

				for(int i=1;i<=12;i++)
				{
					this.cmbMonth.Items.Add(System.DateTime.Now.AddYears(-1).Year.ToString()+"."+i.ToString());
				}
				for(int i=1;i<=12;i++)
				{
					this.cmbMonth.Items.Add(System.DateTime.Now.Year.ToString()+"."+i.ToString());
				}

				this.cmbMonth.Text=System.DateTime.Now.AddMonths(-1).Year.ToString()+"."+System.DateTime.Now.AddMonths(-1).Month.ToString();
						 
				//this

			this.txtYearTo1.Text=System.DateTime.Now.Year.ToString();
				this.cmbYue2.Text=string.Format("{0}月",System.DateTime.Now.Month.ToString());

				DateTime dt=System.DateTime.Now.AddMonths(-1);
				this.txtYearFrom1.Text=dt.Year.ToString();
				this.cmbYue1.Text=string.Format("{0}月",dt.Month.ToString());
				//this.iniListV(this.listView1,1);
				this.iniListV(this.listView2,2);
				this.iniListV(this.listView3,3);
				this.iniListV(this.listView4,5);
				this.iniListV(this.listView1,11);
				//usedW
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		
		private DataTable m_dtAllSa;

		private void iniGrid(string strXFileName,System.Windows.Forms.DataGrid dg,string strRepName)
		{
			try
			{
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load(strXFileName);
				
				//5本月够水站统计
				XmlNode xNodeRep=xDoc.DocumentElement.SelectSingleNode(string.Format("./report[@name='{0}']",strRepName));
				DataGridTableStyle dgts=new DataGridTableStyle();	
				DataTable dtE=new DataTable();

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

					dtE.Columns.Add(strField);

					int iWidth=int.Parse(strWidth);
					dgtb.Width=iWidth;

					dgts.GridColumnStyles.Add(dgtb);
					
				}

				dg.TableStyles.Clear();
				dg.TableStyles.Add(dgts);
				dg.DataSource=dtE;
				//dg.CaptionText=xNodeRep.Attributes.GetNamedItem("Title").Value.Trim();
				dg.ReadOnly=true;

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		XmlDocument m_xDocLsv;

		private void iniListV(System.Windows.Forms.ListView lsv,int iDex)
		{
			try
			{
				lsv.Columns.Clear();

				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("iniLsv.xml");

				this.m_xDocLsv=xDoc;

				XmlNode xNode=xDoc.DocumentElement.SelectSingleNode(string.Format("./lsv[@id='{0}']",iDex.ToString()));

				for(int i=0;i<xNode.ChildNodes.Count;i++)
				{
					string strText=xNode.ChildNodes[i].Attributes.GetNamedItem("text").Value.Trim();
					string strWidth=xNode.ChildNodes[i].Attributes.GetNamedItem("width").Value.Trim();
					lsv.Columns.Add(strText,int.Parse(strWidth),System.Windows.Forms.HorizontalAlignment.Left);
				}

				if(iDex==1||iDex==11)
				{				
					this.groupBox1.Text=xNode.Attributes.GetNamedItem("Title").Value.Trim();					
				}

				if(iDex==2)
				{
					if(this.m_dtAllSa==null)
					{
						this.m_dtAllSa=new DataTable();
						for(int i=0;i<xNode.ChildNodes.Count;i++)						
						{
							this.m_dtAllSa.Columns.Add(xNode.ChildNodes[i].Attributes.GetNamedItem("field").Value.Trim());
						}

					}
					this.groupBox2.Text=xNode.Attributes.GetNamedItem("Title").Value.Trim();
				}
				if(iDex==3)
				{
					this.groupBox3.Text=xNode.Attributes.GetNamedItem("Title").Value.Trim();
				}
				if(iDex==5)
				{
					this.groupBox4.Text=xNode.Attributes.GetNamedItem("Title").Value.Trim();
				}


			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		#endregion

		private bool bInTable(string strMonth)
		{
			for(int i=0;i<this.cmbYue1.Items.Count;i++)
			{
				if(this.cmbYue1.Items[i].ToString().Trim()==strMonth)
				{
					return true;
				}
			}
			return false;
		 }

		private void clearLsv()
		{
			this.listView1.Items.Clear();
		this.listView2.Items.Clear();
			this.listView3.Items.Clear();
			this.listView4.Items.Clear();

	
			this.groupBox3.Text="售水明细表 ";
			this.groupBox1.Text="用水总帐统计表 ";
			this.groupBox4.Text="用水明细表 ";

		}

		private void btnCer_Click(object sender, System.EventArgs e)
		{

			if(this.lblInfo.Text.IndexOf("....")>=0)
			{
				MessageBox.Show("正在进行远程招测,请稍候执行该操作!");
				return;
			}

			this.lblInfo.Text="";
			this.errorProvider1.SetError(this.lblInfo,"");

			if(this.bInTable(this.cmbYue1.Text.Trim()))
			{
			}
			else
			{
				MessageBox.Show("查询起始月份输入有误!");
				return;
			}
			if(this.bInTable(this.cmbYue2.Text.Trim()))
			{
			}
			else
			{
				MessageBox.Show("查询截至月份输入有误!");
				return;
			}

			this.numFrom1.Value=int.Parse(this.cmbYue1.Text.Replace("月",""));
			this.numTo1.Value=int.Parse(this.cmbYue2.Text.Replace("月",""));
            
			if(this.txtZhan.Text.Trim()=="")
			{
				//MessageBox.Show("");
				return;
			}
			this.clearLsv();
			this.Cursor=Cursors.WaitCursor;

			this.iniListV(this.listView1,1);

			if(this.lblName.Text.IndexOf("站点")>=0)
			{
				//监测站统计
				this.disPZhan(this.listView1);
			}
			if(this.lblName.Text.IndexOf("单位")>=0)
			{
				this.disPDep(this.listView1);
			}
			if(this.lblName.Text.IndexOf("乡镇")>=0)
			{
				this.disPCountry(this.listView1);
			}

			this.Cursor=Cursors.Default;

			this.paintColor();
		}

		private void disPZhan(System.Windows.Forms.ListView lsv)
		{

			lsv.Items.Clear();

			DataTable dtZhan=new DataTable();
			DataTable dtZhan1=new DataTable();
			this.monthStaticRep1(ref dtZhan,ref dtZhan1);

			if(dtZhan==null)
			{
				return;
			}

			this.paintList(this.listView3,3,dtZhan);			
			this.paintList(this.listView4,5,dtZhan1);

		}

		private void disPDep(System.Windows.Forms.ListView lsv)
		{
			DataTable dtDep=new DataTable();
			this.monthStaticRepDep1(ref dtDep);
			if(dtDep==null)
			{
				return;
			}
			this.paintList(lsv,1,dtDep);
		}

		private void disPCountry(System.Windows.Forms.ListView lsv)
		{
			DataTable dtCountry=new DataTable();
			this.monthStaticRepCountry1(ref dtCountry);
			if(dtCountry==null)
			{
				return;
			}
			this.paintList(lsv,1,dtCountry);
		}

		private void paintListEx(System.Windows.Forms.ListView lsv,int iDex,DataTable dtZhan)
		{
			try
			{
				if(iDex==2)
				{
					this.addColCha(ref dtZhan);
				}

				lsv.Items.Clear();

				for(int i=0;i<dtZhan.Rows.Count;i++)			
				{				
					for(int j=0;j<lsv.Columns.Count;j++)
					{

						string strText=lsv.Columns[j].Text.Trim();
						string strField="";
						this.getColName(iDex,strText,ref strField);

						if(j==0)
						{						
							lsv.Items.Add(dtZhan.Rows[i][strField].ToString().Trim());
							lsv.Items[i].BackColor=Color.White;
						}
						else
						{
							if(dtZhan.Rows[i][strField].ToString().Trim().IndexOf("-")==0)
							{
								lsv.Items[i].SubItems.Add(this.getFormatValue(dtZhan.Rows[i][strField].ToString().Trim()));		
								if(lsv.Items[i].Text.IndexOf("合计")>=0)
								{
									lsv.Items[i].UseItemStyleForSubItems=false;
									lsv.Items[i].SubItems[j].ForeColor=Color.Red;	
									lsv.Items[i].SubItems[j].BackColor=Color.White;
								}							
							}	
							else
							{
								lsv.Items[i].SubItems.Add(this.getFormatValue(dtZhan.Rows[i][strField].ToString().Trim()));	
									lsv.Items[i].SubItems[j].BackColor=Color.White;
							}
						}
					}				
				}
				this.paintColor();
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void addColCha(ref DataTable dt)
		{
			try
			{
				//dt.Columns.Add("leftAmountCha");
//				for(int i=0;i<dt.Rows.Count;i++)
//				{
//					double dLeftAmountIC=double.Parse(dt.Rows[i]["leftAmountIC"].ToString());
//					double dLeftAmountMana=double.Parse(dt.Rows[i]["leftAmountMana"].ToString());
//					double dLeftAmountCha=dLeftAmountIC-dLeftAmountMana;
//					dt.Rows[i]["leftAmountCha"]=this.getFormatValue(dLeftAmountCha.ToString());
//				}
			}
			catch(Exception ex)
			{
cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void paintList(System.Windows.Forms.ListView lsv,int iDex,DataTable dtZhan)
		{
			try
			{
				if(lsv==this.listView3)
				{
					this.addPriceForMonth(ref dtZhan);
				}
				if(lsv==this.listView4)
				{
					this.addPrice(ref dtZhan,false);
				} 

				if(lsv==this.listView1)
				{	
					this.addPrice(ref dtZhan,false,false);
				}


				cDealReport.replace2Str(ref dtZhan);
				if(iDex==2)
				{
						this.addColCha(ref dtZhan);
				}

				if(dtZhan.Rows.Count==0)
				{
					return;
				}			

				lsv.Items.Clear();

				for(int i=0;i<dtZhan.Rows.Count;i++)			
				{				
					for(int j=0;j<lsv.Columns.Count;j++)
					{

						string strText=lsv.Columns[j].Text.Trim();
						string strField="";
						this.getColName(iDex,strText,ref strField);
			
						if(j==0)
						{						
							lsv.Items.Add(dtZhan.Rows[i][strField].ToString().Trim());
						}
						else
						{
							if(dtZhan.Rows[i][strField].ToString().Trim().IndexOf("-")==0)
							{
								lsv.Items[i].SubItems.Add(this.getFormatValue(dtZhan.Rows[i][strField].ToString().Trim()));		
								if(lsv.Items[i].Text.Trim().IndexOf("合计")>=0)
								{
									lsv.Items[i].UseItemStyleForSubItems=false;
									lsv.Items[i].SubItems[j].ForeColor=Color.Red;		
								}													
							}	
							else
							{
								lsv.Items[i].SubItems.Add(this.getFormatValue(dtZhan.Rows[i][strField].ToString().Trim()));							
							}
						}
					}				
				}
	
				this.paintColor();
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private string getFormatValue(string strVal)
		{
			strVal=strVal.Trim();

			if(strVal.IndexOf(".")>=0)
			{
				if((strVal.IndexOf(".")+3)<=strVal.Length)
				{
					return strVal.Substring(0,strVal.IndexOf(".")+3);
				}
				else
				{
					return strVal;
				}				
			}

			return strVal;

		}

		private bool getColName(int iDex,string strColText,ref string strColName)
		{
			

				string strXPath=string.Format("./lsv[@id='{0}']",iDex.ToString().Trim());

				XmlNode xNode=this.m_xDocLsv.DocumentElement.SelectSingleNode(strXPath);

				for(int i=0;i<xNode.ChildNodes.Count;i++)
				{

					string strText=xNode.ChildNodes[i].Attributes.GetNamedItem("text").Value.Trim();
				strColName=xNode.ChildNodes[i].Attributes.GetNamedItem("field").Value.Trim();

					if(strText==strColText)
					{
							return true;
					}				

			}

			return false;
		}
		
		#region"本月统计"

		#region"变量"
		string m_strDtFrom="";
		string m_strDtTo="";
		string m_strZhanName="";
		XmlDocument m_xDocPrint;
		#endregion

		#region"tools function"

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

		#region"print function"

		//本月打印
		private void button7_Click(object sender, System.EventArgs e)
		{		
			try
			{
			//	DataTable dt=(DataTable)this.dataGrid5.DataSource;
//				DataTable dtE=dt.Copy();
//				this.clearNullDr(ref dtE);
//				if(dtE.Rows.Count<=0)
//				{
//					MessageBox.Show("没有可打印的数据!");
//					return;
//				}
//
//				this.printMonth2();
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
//				if(this.m_xDocPrint==null)
//				{
//					this.m_xDocPrint=new XmlDocument();
//					this.m_xDocPrint.Load("salRepPrint.xml");
//				}
//
//				XmlNode xNode=this.m_xDocPrint.DocumentElement.SelectSingleNode("./rep[@val='4']");
//
//				DataGridTableStyle dgts=new DataGridTableStyle();
//				DataTable dt=new DataTable();
//				for(int i=0;i<xNode.ChildNodes.Count;i++)
//				{
//					string strField=xNode.ChildNodes[i].Attributes.GetNamedItem("field").Value.Trim();
//				
//					string strHeader=xNode.ChildNodes[i].Attributes.GetNamedItem("headerText").Value.Trim();
//					string strWidth=xNode.ChildNodes[i].Attributes.GetNamedItem("width").Value.Trim();
//
//					dt.Columns.Add(strField);
//					
//					DataGridColoredTextBoxColumn dgtc=new DataGridColoredTextBoxColumn();
//					dgtc.Width=int.Parse(strWidth);
//					dgtc.HeaderText=strHeader;
//					dgtc.MappingName=strField;
//					dgts.GridColumnStyles.Add(dgtc);
//
//				}
//				this.dgPrint.TableStyles.Clear();
//				this.dgPrint.TableStyles.Add(dgts);
//				this.dgPrint.DataSource=dt;
//
//				DataTable dtPrint=(DataTable)this.dgPrint.DataSource;
//			//	DataTable dtDetail=(DataTable)this.dataGrid5.DataSource;
//
//
//				for(int i=0;i<dtDetail.Rows.Count;i++)
//				{
//					dtPrint.ImportRow(dtDetail.Rows[i]);
//				}	
//				this.clearBlankRow(dtPrint);	
// 
//			//	string strTitle=this.dataGrid5.CaptionText.Trim();
//				string strTitleE="";
//
//				if(strTitle.IndexOf("操作员")>=0)
//				{
//					strTitleE="操作员售水月统计表";
//					strTitle=strTitle.Substring(0,strTitle.IndexOf("操作员售水月统计表"));
//				}
//				else
//				{
//					strTitleE="本月用水统计表";
//					strTitle=strTitle.Substring(0,strTitle.IndexOf("本月用水统计表"));
//				}
//		
//				cutePrint.cutePrinter dgp=new cutePrint.cutePrinter(this.dgPrint,strTitleE,30);
//				int iTimeMinus=int.Parse(xNode.Attributes.GetNamedItem("iTimeMinus").Value.Trim());
//				dgp.iTimeMinus=iTimeMinus;	
//				dgp.leftMargin=int.Parse(xNode.Attributes.GetNamedItem("leftMargin").Value.Trim());
//				dgp.strTitle=strTitle;	
//				dgp.Print();
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}			
		}

		#endregion


		#endregion

		//监测站月统计
		private void monthStaticRep1(ref DataTable dt1,ref DataTable dt2)
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
					
					string strTime=this.txtYearFrom1.Text.Trim()+"-"+this.cmbYue1.Text.Replace("月","").Trim()+"-1 0:00";
					dtFrom=DateTime.Parse(strTime);
					strTime=this.txtYearTo1.Text.Trim()+"-"+this.cmbYue2.Text.Replace("月","").Trim()+"-1 23:00";					
					dtTo=DateTime.Parse(strTime);
					dtTo.AddMonths(1).AddDays(-1);
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
				DataTable dtAvgEx1=new DataTable();
				
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
				
//					if(this.mergeDt(dtAvg,dtAvg1,ref dtNew)==false)
//					{
//						return;
//					}


					dtAvg=dtNew;
					BengZhan.comReport.CReports.copyDt(dtAvg,ref dtAvgEx);
					BengZhan.comReport.CReports.copyDt(dtAvg1,ref dtAvgEx1);

				}


			dt1=dtAvgEx;
				dt2=dtAvgEx1;

				//DataTable dt=(DataTable)this.dataGrid5.DataSource;	
			
			//	dt.Rows.Clear();					
		
//				for(int i=0;i<dtAvgEx.Rows.Count;i++)
//				{
//					DataRow dr=dt.NewRow();					
//					for(int j=0;j<dt.Columns.Count;j++)
//					{
//						string strColName=dt.Columns[j].ColumnName;
//						dr[strColName]=dtAvgEx.Rows[i][strColName].ToString();				
//					}
//					dt.Rows.Add(dr);
//				}

//				dt1=dtAvgEx;
//

				strFrom=string.Format("{0}-{1}-1 0:00",dtFrom.Year.ToString(),dtFrom.Month.ToString());					
				strTo=string.Format("{0}-{1}-1 0:00",dtTo.AddMonths(1).Year.ToString(),Convert.ToString(dtTo.AddMonths(1).Month));//3

				dtTo=DateTime.Parse(strTo);
				dtTo=dtTo.AddDays(-1);

				strTo=string.Format("{0}-{1}-{2} 23:00",dtTo.Year.ToString(),dtTo.Month.ToString(),dtTo.Day.ToString());
		
				string strCapText=string.Format("监测站：{0}    时间范围：{1}至{2}    本月用水统计表",strZhanName,strFrom,strTo);
				//this.dataGrid5.CaptionText=strCapText;

				strCapText=string.Format("本月用水统计表  时间范围：{0}至{1}",strFrom,strTo);

				this.groupBox1.Text=strCapText;

				this.m_strDtFrom=strFrom;
				this.m_strDtTo=strTo;
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
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


		
		
		private void monthStaticRepDep1(ref DataTable dtDepRep)
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
		
					string strSql=string.Format("select wellNo from tbWell where depName='{0}' order by wellNo",strDepName);

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

				//DataTable dt=(DataTable)this.dataGrid5.DataSource;	
			
				//dt.Rows.Clear();					
		
//				for(int i=0;i<dtAvg.Rows.Count;i++)
//				{
//					DataRow dr=dt.NewRow();					
//					for(int j=0;j<dt.Columns.Count;j++)
//					{
//						string strColName=dt.Columns[j].ColumnName;
//						dr[strColName]=dtAvg.Rows[i][strColName].ToString();
//					}
//					dt.Rows.Add(dr);
//				}

				dtDepRep=dtAvg;

				dtTo=dtFrom.AddMonths(iIns);
				
				string strFromEx=string.Format("{0}-{1}-1 0:00",dtFrom.Year.ToString(),dtFrom.Month.ToString());					
				string strToEx=string.Format("{0}-{1}-1 0:00",dtTo.AddMonths(1).Year.ToString(),Convert.ToString(dtTo.AddMonths(1).Month));//2

				dtTo=DateTime.Parse(strToEx);
				dtTo=dtTo.AddDays(-1);

				strToEx=string.Format("{0}-{1}-{2} 23:00",dtTo.Year.ToString(),dtTo.Month.ToString(),dtTo.Day.ToString());
				
				string strCapText=string.Format("单位：{0}    时间范围：{1}至{2}    本月用水统计表",strDepName,strFromEx,strToEx);
				
				//this.dataGrid5.CaptionText=strCapText;

				strCapText=string.Format("本月用水统计表  时间范围：{0}至{1}",strFromEx,strToEx);
				this.groupBox1.Text=strCapText;

				this.m_strDtFrom=strFromEx;
				this.m_strDtTo=strToEx;
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void monthStaticRepCountry1(ref DataTable dtCountryRep)
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
		
						strSql=string.Format("select wellNo from tbWell where depName='{0}' order by wellNo",strDepName);

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

				//DataTable dt=(DataTable)this.dataGrid5.DataSource;	
			
//				dt.Rows.Clear();					
//		
//				for(int i=0;i<dtAvg.Rows.Count;i++)
//				{
//					DataRow dr=dt.NewRow();					
//					for(int j=0;j<dt.Columns.Count;j++)
//					{
//						string strColName=dt.Columns[j].ColumnName;
//						dr[strColName]=dtAvg.Rows[i][strColName].ToString();
//					}
//					dt.Rows.Add(dr);
//				}

				dtCountryRep=dtAvg;

				dtTo=dtFrom.AddMonths(iIns);

				
				string strFromEx=string.Format("{0}-{1}-1 0:00",dtFrom.Year.ToString(),dtFrom.Month.ToString());					
				string strToEx=string.Format("{0}-{1}-1 0:00",dtTo.AddMonths(1).Year.ToString(),Convert.ToString(dtTo.AddMonths(1).Month));//1

				dtTo=DateTime.Parse(strToEx);
				dtTo=dtTo.AddDays(-1);

				strToEx=string.Format("{0}-{1}-{2} 23:00",dtTo.Year.ToString(),dtTo.Month.ToString(),dtTo.Day.ToString());
				
				string strCapText=string.Format("乡镇：{0}    时间范围：{1}至{2}    本月用水统计表",this.txtZhan.Text.Trim(),strFromEx,strToEx);
				
				//this.dataGrid5.CaptionText=strCapText;

				strCapText=string.Format("本月用水统计表  时间范围：{0}至{1}",strFromEx,strToEx);
				this.groupBox1.Text=strCapText;

				this.m_strDtFrom=strFromEx;
				this.m_strDtTo=strToEx;

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}



		#endregion		

		private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
			//	this.listView2.Items.Clear();
				this.listView3.Items.Clear();
				this.listView4.Items.Clear();

				if(this.listView1.SelectedItems.Count==0)
				{
					return;
				}

				if(this.listView1.SelectedItems[0].Text.IndexOf("单位")>=0)
				{
					int iDex=this.listView1.SelectedItems[0].Index;
					iDex--;

                    string strZhanName=this.listView1.Items[iDex].Text.Trim();
					string strDepName="";
					string strSqlT=string.Format("select depName from tbWell where wellName='{0}'",strZhanName);
					strDepName=BengZhan.CDBConnection.ExecuteScalar(strSqlT);
					string strTimeS=this.listView1.Items[iDex].SubItems[7].Text.Trim();
					this.showDepRep(strDepName,strTimeS);
					
					this.m_strTitle3="单位："+strDepName;
                    			
				}
				else
				{
					string strZhanName=this.listView1.SelectedItems[0].Text.Trim();
					string strTimeS=this.listView1.SelectedItems[0].SubItems[7].Text.Trim();
					this.showZhanRep(strZhanName,strTimeS);
						this.m_strTitle3="监测站："+strZhanName;
				}			
				this.paintColor();
					this.showAmountDetail();
								this.paintColor();


			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}	  
			if(this.listView1.SelectedItems.Count==0)
			{
				return;
			}			
		}

		private void showDepRep(string strDepName,string strTimeS)
		{
			try
			{
				string strSql=string.Format("select wellName,wellNo from tbWell where depName='{0}' order by wellNo",strDepName);
				DataTable dtWell=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtWell,strSql,"dtWell");

				DataTable dtAvgEx=new DataTable();

				for(int i=0;i<dtWell.Rows.Count;i++)
				{
					string strWellName=dtWell.Rows[i]["wellName"].ToString().Trim();
					DataTable dtShow=new  DataTable();
					this.showZhanRep(strWellName,strTimeS,ref dtShow);  
				//	Console.WriteLine(dtShow.Rows.Count.ToString());					
						BengZhan.comReport.CReports.copyDt(dtShow,ref dtAvgEx);    
					//Console.WriteLine(dtAvgEx.Rows.Count.ToString());
				}

				if(dtAvgEx.Rows.Count>0)
				{
					DataRow dr=dtAvgEx.NewRow();
					for(int i=0;i<dtAvgEx.Columns.Count;i++)
					{
						if((i!=0)&&(i!=(dtAvgEx.Columns.Count-1)))
						{
				
							try
							{
								dr[i]=this.sumCol(dtAvgEx,i);
							}
							catch(Exception ex)
							{
								//Console.WriteLine(this.sumCol(dtAvgEx,i));
								//Console.WriteLine(dtAvgEx.Columns[i].ColumnName);
								//Console.WriteLine(ex.ToString());
							}
						
						}
						else
						{
							dr[0]="单位合计";
						}
					
					}
					dtAvgEx.Rows.Add(dr);
				}	


				//this.paintList(this.listView2,2,dtAvgEx);
				this.showSalDetail(strDepName,strTimeS);

									 
			 }
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void showSalDetail(string strDepName,string  strTimeS)
		{
			try
			{
				string strTime=strTimeS;

				if(strTime.Trim()=="")
				{
					return ;
				}

				string[] strTimes=strTime.Split('至');
				strTime=strTimes[0].Trim();

				DateTime dt=DateTime.Parse(strTime);

				string strSql=string.Format("select wellName from tbWell where depName='{0}' order by wellNo",strDepName);
				DataTable dtWell=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtWell,strSql,"dt");

				DataTable dtRet=new DataTable();

				for(int i=0;i<dtWell.Rows.Count;i++)
				{
					DataTable dtRep=new DataTable();
					string strWellName=dtWell.Rows[i]["wellName"].ToString().Trim();
					strSql=string.Format("select wellName,price,salMony,salAmount,time,salPer,allSalAmount as allSalAmountAfter,(allSalAmount-salAmount) as allSalAmountBefore from tbWell,tbSal where tbSal.wellNo=tbWell.wellNo and wellname='{0}' and year(time)={1} and month(time)={2} order by time",strWellName,dt.Year.ToString(),dt.Month.ToString());
					BengZhan.CDBConnection.getDataTable(ref dtRep,strSql,"dt");
					this.addSum(ref dtRep);

BengZhan.comReport.CReports.copyDt(dtRep,ref dtRet);
				}

				this.addSumEx(ref dtRet);
			//	DataRow dr=dtRet.NewRow();

//				dr["wellName"]="单位合计";
//                dr["salMony"]=this.sumCol(dtRet,2);
//				dr["salAmount"]=this.sumCol(dtRet,3	);
//				dtRet.Rows.Add(dr);

				if(dtRet.Rows.Count==1)				
				{
					return;
				}

			this.paintList(this.listView3,3,dtRet);						 
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}			
		}

		private string sumCol(DataTable dt,int iCol)
		{
			try
			{
				double iSum=0;
				for(int i=0;i<dt.Rows.Count;i++)
				{
					if((dt.Columns[iCol]!=null)&&(dt.Columns[iCol].ColumnName.Trim()!="time")&&(dt.Columns[iCol].ColumnName.Trim()!="leftAmountCha"))
					{	
						try
						{				
							if(cDealReport.bAllNum(dt.Rows[i][iCol].ToString()))
							
							{
								iSum+=double.Parse(dt.Rows[i][iCol].ToString());
							}
							
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.ToString()+"  "+dt.Rows[i][iCol].ToString());
						}
						
					}
				}
				return iSum.ToString();
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return "";
			}
			
		}


		private string sumColEx(DataTable dt,int iCol)
		{
			try
			{
				double iSum=0;
				for(int i=0;i<dt.Rows.Count;i++)
				{
					if(dt.Rows[i][0].ToString().Trim()=="合计")
					{
						if((dt.Columns[iCol]!=null)&&(dt.Columns[iCol].ColumnName.Trim()!="time"))
						{	
							if(dt.Rows[i][iCol].ToString().Trim()!="")
							{
								if(cDealReport.bAllNum(dt.Rows[i][iCol].ToString()))
								{
										iSum+=double.Parse(dt.Rows[i][iCol].ToString());
								}
							
							}
						
						}
					}				
				}
				return iSum.ToString();
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return "";
			}
			
		}

		private void showZhanRep(string strZhanName,string strTimeS,ref DataTable dtRet)
		{
			try
			{
				string strWellName=strZhanName;
				string strTime=strTimeS;

				if(strTime.Trim()=="")
				{
					return ;
				}

				
				string[] strTimes=strTime.Split('至');
				strTime=strTimes[0].Trim();

				string strTimeTo=strTimes[1].Trim();

				this.groupBox3.Text=string.Format("售水明细表  时间范围：{0} 至 {1}",strTime,strTimeTo);

				DateTime dt=DateTime.Parse(strTime);

				string strSql=string.Format("select name wellName,allBuyAmount,allMony,leftAmount,leftMony,allAmount,allAmount*price1 allUsedMony,time from waterDatasMonth,tbWell where waterDatasMonth.name=tbWell.wellName and month(time)={0} and year(time)={1} and wellName='{2}'",dt.Month.ToString(),dt.Year.ToString(),strWellName);

				DataTable dtRep=new DataTable();

				BengZhan.CDBConnection.getDataTable(ref dtRep,strSql,"dt");
				this.m_dtAllSa.Rows.Clear();

				if(dtRep.Rows.Count>0)
				{

					//this.m_dtAllSa.Rows.Clear();

					DataRow dr=this.m_dtAllSa.NewRow();

					strTime=dtRep.Rows[0]["time"].ToString().Trim();
					strSql=string.Format("select wellNo from tbWell where wellName='{0}'",strWellName);
					string strWellNo=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();

					strSql=string.Format("select allSalAmount from tbSal where time=(select max(time) from tbSal where wellNo='{0}' and time<='{1}') and wellNo='{0}'",strWellNo,strTime);

					string strAllSalAmount=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();

					strSql=string.Format("select price1 from tbWell where wellNo='{0}'",strWellNo);

					string strPrice=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();

					if(strAllSalAmount.Trim()=="")					
					{
						strAllSalAmount="0";
					}

					double dAllSalAmount=double.Parse(strAllSalAmount);
					double dAllSalMony=dAllSalAmount*double.Parse(strPrice);
					double dLeftIC=dAllSalAmount-double.Parse(dtRep.Rows[0]["allAmount"].ToString());

					dr["wellName"]=strWellName;
					dr["leftAmountIC"]=dLeftIC.ToString();
					dr["leftAmountMana"]=dtRep.Rows[0]["leftAmount"].ToString();
					dr["allBuyMony"]=dAllSalMony.ToString();
					dr["allBuyAmount"]=dAllSalAmount.ToString();
					dr["allUsedMony"]=dtRep.Rows[0]["allUsedMony"].ToString();
					dr["allAmount"]=dtRep.Rows[0]["allAmount"].ToString();
					dr["time"]=strTime;

					this.m_dtAllSa.Rows.Add(dr);
				
					//this.paintList(this.listView2, 2,this.m_dtAllSa);
				}
				dtRet=this.m_dtAllSa.Copy();

				//this.paintList(this.listView2,2,dtRep);
//				strSql=string.Format("select wellName,price,salMony,salAmount,time,salPer from tbWell,tbSal where tbSal.wellNo=tbWell.wellNo and wellname='{0}' and year(time)={1} and month(time)={2}",strWellName,dt.Year.ToString(),dt.Month.ToString());
//				BengZhan.CDBConnection.getDataTable(ref dtRep,strSql,"dt");

				//dtRet=dtRep;
				//this.paintList(this.listView3,3,dtRep);

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}	
			
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
		
		}

		private bool clearLsv2()
		{
			try
			{
				for(int i=0;i<this.listView1.Items.Count;i++)
				{
					string strName="";
					if(i>0)
					{
						strName=this.listView1.Items[i-1].SubItems[0].Text.Trim();
					}
					if(this.listView1.Items[i].SubItems[0].Text.Trim()==strName)
					{
						return false;
					//	this.listView2.Items.RemoveAt(i);
						//i--;
					}
				}
				return true;
					  }
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}

		private void paintSumRowLsv2()		
		{
			try
			{
				if(this.listView1.Items.Count<=0)
				{
					return;
				}
			

				for(int i=0;i<this.listView1.Items.Count;i++)				
				{
					if(this.listView1.Items[i].Text.Trim()=="合计")
					{
						this.listView1.Items.RemoveAt(i);
						i--;
					}
				}

					
			
//
//				if(!this.clearLsv2())
//				{
//					return;
//				}


				 //this.listView1.Items.Add("合计");
				System.Windows.Forms.ListViewItem lst=new ListViewItem("合计");
				
				//int iCount=this.listView1.Items.Count-1;

				for(int j=1;j<this.listView1.Items[0].SubItems.Count-1;j++)
				{					
				
					double dSum=0;					
	
					for(int i=0;i<this.listView1.Items.Count-1;i++)
					{
						dSum+=double.Parse(this.listView1.Items[i].SubItems[j].Text.Trim());
					}
					
				lst.SubItems.Add("");

					lst.SubItems[j].Text=dSum.ToString();

					if(lst.SubItems[j].Text.Trim().IndexOf("-")>=0)					
					{	//lsv.Items[i].UseItemStyleForSubItems=false;
						lst.UseItemStyleForSubItems=false;
					lst.SubItems[j].ForeColor=Color.Red;
					}

				}



				this.listView1.Items.Insert(0,lst);

				//this.listView1.Items[iCount].SubItems.Add("");

						  
			}
			catch(Exception ex)
			{
cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private bool fillDgFrmLsv(System.Windows.Forms.ListView lsv,System.Windows.Forms.DataGrid dg,int iDex)
		{
			try
			{
				DataTable dt=(DataTable)dg.DataSource;

				if(dt==null)
				{
					return false;
				}
				else
				{
					dt.Rows.Clear();

					for(int i=0;i<lsv.Items.Count;i++)				
					{
						DataRow dr=dt.NewRow();

						for(int j=0;j<lsv.Items[i].SubItems.Count;j++)
						{
							string strColName=lsv.Columns[j].Text.Trim();
							this.getColName(iDex,strColName,ref strColName);
							dr[strColName]=lsv.Items[i].SubItems[j].Text;
						}

						dt.Rows.Add(dr);
					}
				}

				if(iDex==2)
				{
					string strTitle=this.groupBox1.Text;;
					if(strTitle.IndexOf(" ")<0)
					{
						dg.CaptionText=strTitle;
						return true;
					}
				string	strTitle1=strTitle.Substring(0,strTitle.IndexOf(" "));
					dg.CaptionText=strTitle.Replace(strTitle1,"")+" "+strTitle1;
				}

				if(iDex==5)
				{
					string strTitle=this.groupBox4.Text;
					if(strTitle.IndexOf(" ")<0)
					{
						dg.CaptionText=strTitle;
						return true;
					}
					string strTitle1=strTitle.Substring(0,strTitle.IndexOf(" "));
					dg.CaptionText=strTitle.Replace(strTitle1,"")+" "+strTitle1;
				}

				if(iDex==3)
				{
					if(this.listView3.Items.Count>0)					
					{				
					
						dg.CaptionText=this.groupBox3.Text.Trim().Replace("售水明细表","");
						dg.CaptionText+="  售水明细表";
					}
				}

				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
			
		}

		private void btnPrint_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.lblInfo.Text.IndexOf("....")>=0)
				{
					MessageBox.Show("正在进行远程招测,请稍候执行该操作!");
					return;
				}
				if((this.listView1.Items.Count==0)&&(this.listView4.Items.Count==0)&&(this.listView3.Items.Count==0))		
				{
					MessageBox.Show("没有可打印的数据！");
				return;
			}

				this.Cursor=Cursors.WaitCursor;

				this.iniGrid("salRep.xml",this.dg1,"tb3");
				this.iniGrid("salRep.xml",this.dg2,"tb11");
				this.iniGrid("salRep.xml",this.dg3,"tbDa");

			this.fillDgFrmLsv(this.listView1,this.dg1,2);
			this.fillDgFrmLsv(this.listView3,this.dg2,3);
			this.fillDgFrmLsv(this.listView4,this.dg3,5);
						

				frmPrint frmPr=new frmPrint();

				frmPr.dataGrid2=this.dg1;
				frmPr.dataGrid3=this.dg2;
				frmPr.dataGrid4=this.dg3;

				this.Cursor=Cursors.Default;

				frmPr.ShowDialog();

				this.Cursor=Cursors.Default;
			
			}
			catch(Exception ex)
			{
				this.Cursor=Cursors.Default;

				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void groupBox3_Enter(object sender, System.EventArgs e)
		{
		
		}

		private int iTimeLong=0;
		private string strStartTime="";
		private DataTable m_dtErrZ;

		private XmlDocument m_xDocWZs;

		private string m_strDepName="";

		private void btnCmd_Click(object sender, System.EventArgs e)
		{

			if(ComSoft.frmMonitorEx.m_dtFarCmd==null)
			{
				MessageBox.Show("请先打开实时监测界面!");
				return;
			}

			if(!ComSoft.frmMonitorEx.m_cGprsComTEx.getReady())
			{
				MessageBox.Show("设备正忙,请稍候!");
				return;
			}
			if(this.lblInfo.Text.IndexOf("....")>=0)
			{
				MessageBox.Show("正在进行远程招测,请稍候执行该操作!");
				return;
			}
			

			if((this.lblName.Text.IndexOf("单位")<0))
			{
				MessageBox.Show("请选择要招测的单位!");
				return;
			}
//			if(this.lblName.Text.IndexOf("站点")<0)
//			{
//				MessageBox.Show("请选中要招测的站点!");
//				return;
//			}
//			if(this.trvWel.SelectedNode==null)
//			{
//				MessageBox.Show("请选中要招测的站点!");
//				return;
//			}
//			if(this.trvWel.SelectedNode.Text.IndexOf("|")<0)
//			{
//				MessageBox.Show("请选中要招测的站点!");
//				return;
//			}	

			this.clearLsv();

			this.bTooLong=false;
	
			this.groupBox1.Text=string.Format("总帐统计表  截止时间:{0}",System.DateTime.Now.ToString());

			if(this.lblName.Text.IndexOf("单位")>=0)
			{
				//单位招测

				this.m_strDepName=this.txtZhan.Text.Trim();

				string strZhanInfo=this.trvWel.SelectedNode.Text;

				//			string strZhanNo=strZhanInfo.Substring(0,strZhanInfo.IndexOf("|"));
				//			string strZhanName=strZhanInfo.Substring(strZhanInfo.IndexOf("|")+1);

				string strSql=string.Format("select wellNo,wellName from tbWell where  depName='{0}' order by wellNo",this.txtZhan.Text.Trim());
				DataTable dtWell=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtWell,strSql,"dt");

				this.m_dtAllSa.Rows.Clear();

				this.clearDtWell(ref dtWell);

				this.m_strStartTime=System.DateTime.Now.ToString();
				this.iTimeLong=this.m_iInter*(dtWell.Rows.Count)+1800;

				DataTable dtFarC=new DataTable();

				dtFarC.Columns.Add("zhanNo");
				dtFarC.Columns.Add("zhanName");


				for(int i=0;i<dtWell.Rows.Count;i++)
				{
					string	strZhanNo=dtWell.Rows[i]["wellNo"].ToString().Trim();
					string strZhanName=dtWell.Rows[i]["wellName"].ToString().Trim();
					DataRow dr=dtFarC.NewRow();
					dr["zhanNo"]=strZhanNo;
					dr["zhanName"]=strZhanName;
					dtFarC.Rows.Add(dr);			
					//	System.Threading.Thread.Sleep(1000);					
				}		
	
				this.farCmdAll(dtFarC);

			}
			else
			{
				//监测站招测

				string strZhanInfo=this.trvWel.SelectedNode.Text;

				string strZhanNo=strZhanInfo.Substring(0,strZhanInfo.IndexOf("|"));
				string strZhanName=strZhanInfo.Substring(strZhanInfo.IndexOf("|")+1);

				this.m_dtAllSa.Rows.Clear();

				this.m_strStartTime=System.DateTime.Now.ToString();
				this.iTimeLong=this.m_iInter*(1)+1800;

				DataTable dtFarC=new DataTable();

				dtFarC.Columns.Add("zhanNo");
				dtFarC.Columns.Add("zhanName");

				DataRow dr=dtFarC.NewRow();
				dr["zhanNo"]=strZhanNo;
				dr["zhanName"]=strZhanName;
				dtFarC.Rows.Add(dr);

				this.farCmdAll(dtFarC);		
				
				//this.farCmd(strZhanNo,strZhanName);
					//	System.Threading.Thread.Sleep(1000);			

			}		

		}

		private DataTable m_dtFarCmded;
		private string m_strStartTime="";

		private int m_iInter=0;

		private void iniSys()
		{
			if(this.m_dtFarCmded==null)
			{
				this.m_dtFarCmded=new DataTable();
				this.m_dtFarCmded.Columns.Add("watNo");
				this.m_dtFarCmded.Columns.Add("time");
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("Info.xml");
				this.m_iInter=int.Parse(xDoc.DocumentElement.SelectSingleNode("./remoteInter").Attributes.GetNamedItem("val").Value.Trim());
				this.m_dtErrZ=new DataTable();
this.m_dtErrZ.Columns.Add("zhanName");
				this.m_xDocWZs=new XmlDocument();
				this.m_xDocWZs.Load("newDoc/warnZ.xml");
				xDoc.Load("iniLsv.xml");
				frmMonthStac.m_strDispErrInfo=xDoc.DocumentElement.SelectSingleNode("./dispErrInfo").Attributes.GetNamedItem("val").Value.Trim();
			}
		}

		private void clearDtWell(ref DataTable dtWell)
		{
			try
			{
				for(int i=0;i<dtWell.Rows.Count;i++)				
				{
					string strWellName=dtWell.Rows[i]["wellName"].ToString().Trim();
					for(int j=0;j<this.m_xDocWZs.DocumentElement.ChildNodes.Count;j++)
					{
						string strName=this.m_xDocWZs.DocumentElement.ChildNodes[j].Attributes.GetNamedItem("Name").Value.Trim();
						if(strWellName==strName)
						{
							dtWell.Rows.RemoveAt(i);
							i--;
						}
					}
				 }
			 }
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}


		private DataTable m_dtSended;

		private bool farCmdAll(DataTable dt)
		{
			if(ComSoft.frmMonitorEx.m_cGprsComTEx==null)
			{
				return false;
			}

			for(int i=0;i<dt.Rows.Count;i++)
			{

				string strZhanNo=dt.Rows[i]["zhanNo"].ToString().Trim();
				string strZhanName=dt.Rows[i]["zhanName"].ToString().Trim();
				this.farCmd(strZhanNo,strZhanName);

			}

			return true;
		}

		public void farCmd(string strZhanNo,string strZhanName)
		{
			try
			{
				if(this.m_timeSend==null)
				{
					this.m_timeSend=new Timer();
					this.m_timeSend.Tick+=new EventHandler(m_timeSend_Tick);
					this.m_timeSend.Interval=this.m_iInter;
					this.m_timeSend.Start();
					this.m_dtSend=new DataTable();

					this.m_dtSend.Columns.Add("zhanNo");
					this.m_dtSend.Columns.Add("zhanName");		
			
					this.m_dtSended=new DataTable();
					this.m_dtSended.Columns.Add("zhanNo");
					this.m_dtSended.Columns.Add("zhanName");

				}
//
//				if(ComSoft.frmMonitorEx.m_dtFarCmd==null)
//				{
//				    MessageBox.Show("请先打开实时监测界面!");
//					return;
//				}

				DataRow dr=this.m_dtSend.NewRow();

				dr["zhanNo"]=strZhanNo;
				dr["zhanName"]=strZhanName;

				this.m_dtSend.Rows.Add(dr);

				DataRow drEx=this.m_dtSended.NewRow();
				drEx["zhanNo"]=strZhanNo;
				drEx["zhanName"]=strZhanName;
				this.m_dtSended.Rows.Add(drEx);

				this.lblInfo.Width=200;
				this.lblInfo.Text="正在进行远程招测请稍候......";
				this.lnkInfo.Visible=false;


				dr=ComSoft.frmMonitorEx.m_dtFarCmd.NewRow();
				dr["watNo"]=strZhanNo;
				dr["time"]=System.DateTime.Now.ToString();
				ComSoft.frmMonitorEx.m_dtFarCmd.Rows.Add(dr);

				dr=this.m_dtFarCmded.NewRow();
				dr["watNo"]=strZhanNo;
				dr["time"]=System.DateTime.Now.ToString().Trim();
				m_dtFarCmded.Rows.Add(dr);
	            
				this.m_strStartTime=System.DateTime.Now.ToString();
				
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		#region"定时发数"

		private System.Windows.Forms.Timer m_timeSend;

		#endregion

		#region"招测结果刷新"

		private System.Windows.Forms.Timer m_timeRefresh;

		public static DataTable m_dtRev;

		private string m_strCmdZhan="";

		private void startTimeFresh()		
		{
			if(m_dtRev==null)
			{
				m_dtRev=new DataTable();
			}
			
			if(this.m_timeRefresh==null)
			{
				this.m_timeRefresh=new Timer();
				this.m_timeRefresh.Interval=1000;
				this.m_timeRefresh.Tick+=new EventHandler(m_timeRefresh_Tick);
				this.m_timeRefresh.Start();
			}			
		}

		private void fresh(string strWellName)
		{
//			this.dispGrid(strWellName);
//			this.dispLastAmount(strWellName);
//			this.dispSalAmount(strWellName);
//			this.dispChaZhan();
//			this.paintOneLine();
			//this.lblInfo.Text="";
		}

		private void m_timeRefresh_Tick(object sender, EventArgs e)
		{
			try
			{
				this.m_timeRefresh.Stop();

				if(this.m_strStartTime=="")				
				{
					this.m_timeRefresh.Start();
					return ;
				}

				//this.clearCmded(ref this.m_dtFarCmded);

				DataTable dtSave=new DataTable();

				if(ComSoft.frmMonitorEx.m_dtFarRev==null&&ComSoft.frmMonitorEx.m_dtFarErr==null)				
				{
					this.m_timeRefresh.Start();
					return;
				}

				dtSave=ComSoft.frmMonitorEx.m_dtFarRev.Clone();

				for(int i=0;i<ComSoft.frmMonitorEx.m_dtFarRev.Rows.Count;i++)
				{
					if(this.revRow(ComSoft.frmMonitorEx.m_dtFarRev.Rows[i]["name"].ToString().Trim(),ComSoft.frmMonitorEx.m_dtFarRev.Rows[i]["time"].ToString().Trim()))					
					{
						
						string strNameEx=ComSoft.frmMonitorEx.m_dtFarRev.Rows[i]["name"].ToString().Trim();
						dtSave.ImportRow(ComSoft.frmMonitorEx.m_dtFarRev.Rows[i]);
						ComSoft.frmMonitorEx.m_dtFarRev.Rows.RemoveAt(i);
						i--;					
					}
					else
					{
						
						ComSoft.frmMonitorEx.m_dtFarRev.Rows.RemoveAt(i);
						i--;
					}
				}

				for(int i=0;i<ComSoft.frmMonitorEx.m_dtFarErr.Rows.Count;i++)
				{
					string strGprsNo=ComSoft.frmMonitorEx.m_dtFarErr.Rows[i]["gprsNo"].ToString();
					string strName="";
					string strNo="";
					GprsSoft.dealForm.CDBConnection.getNameByNo(strGprsNo,ref strName);
					if(this.revRowErr(strName,ComSoft.frmMonitorEx.m_dtFarErr.Rows[i]["errTime"].ToString()))					
					{	
									
						ComSoft.frmMonitorEx.m_dtFarErr.Rows.RemoveAt(i);
						i--;
						this.longTimeWarn();						
					}
					else
					{							
	
						ComSoft.frmMonitorEx.m_dtFarErr.Rows.RemoveAt(i);
						i--;
					}
				}

				if(dtSave.Rows.Count>0)
				{
					//this.lblInfo.Text="";	
					this.showManaDatas(dtSave);
					//this.saveLastData(dtSave);					
				}

				this.decTooLong();

				this.m_timeRefresh.Start();
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void clearCmded(ref DataTable dt)
		{
			try
			{
				if(dt!=null)
				{
					for(int i=0;i<dt.Rows.Count;i++)
					{
						string strTime=dt.Rows[i]["time"].ToString();
						DateTime dt1=DateTime.Parse(strTime);
						if(dt1.AddSeconds(45)<System.DateTime.Now)
						{
							dt.Rows.RemoveAt(i);
							i--;
						}
					}
				}
				if(dt.Rows.Count==0)
				{
					if(this.lblInfo.Text.IndexOf("超时")<0)
					{
						//this.lblInfo.Text="";
						this.errorProvider1.SetError(this.lblInfo,"");
					}					
				}
				if(this.lblInfo.Text.IndexOf(".....")>=0)
				{
//					if(this.m_strStartTime.Trim()!="")
//					{
//						if(DateTime.Parse(this.m_strStartTime.Trim()).AddSeconds(15)<System.DateTime.Now)
//						{
//							this.longTimeWarn();							
//						}
//					}
				}
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}			
		}

		private bool revRowErr(string strName,string strTime)
		{
			try

			{
				string strWatNo="";
				GprsSoft.dealForm.CDBConnection.getNoByName(strName,ref strWatNo);

				for(int i=0;i<this.m_dtFarCmded.Rows.Count;i++)
				{
					if(this.m_dtFarCmded.Rows[i]["watNo"].ToString().Trim()==strWatNo)
					{
						string strTime1=this.m_dtFarCmded.Rows[i]["time"].ToString().Trim();
					
						if(DateTime.Parse(strTime1)<DateTime.Parse(strTime))
						{
							//reved one row
							this.m_dtFarCmded.Rows.RemoveAt(i);
							i--;
							return true;
						}
						else
						{
							return false;
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

		private bool revRow(string strName,string strTime)
		{
			try
			{
				string strWatNo="";
				GprsSoft.dealForm.CDBConnection.getNoByName(strName,ref strWatNo);

				for(int i=0;i<this.m_dtFarCmded.Rows.Count;i++)
				{
					if(this.m_dtFarCmded.Rows[i]["watNo"].ToString().Trim()==strWatNo)
					{
					//	Console.WriteLine(strWatNo);

						string strTime1=this.m_dtFarCmded.Rows[i]["time"].ToString().Trim();
						int iDex=strTime.LastIndexOf(":");
						strTime=strTime.Substring(0,iDex);
					
						if(DateTime.Parse(strTime1)<DateTime.Parse(strTime))
						{
							//reved one row
							this.m_dtFarCmded.Rows.RemoveAt(i);
							i--;
							return true;
						}
						else
						{
							
							int iInter=this.getInterInstance();

							if(DateTime.Parse(strTime1).AddSeconds(0-iInter)<DateTime.Parse(strTime))
							{
								this.m_dtFarCmded.Rows.RemoveAt(i);
								i--;
								return true;
							}
							else
							{
								return false;
							}

							return false;
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

		private void longTimeWarn()
		{
			try
			{
				//this.lblInfo.Text="等待超时";
				//this.lblInfo.Width=90;
				//this.errorProvider1.SetError(this.lblInfo,this.lblInfo.Text);
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}	 
		}

		private bool saveLastData(DataTable dtGprs)
		{
			try
			{
				DataTable dtGprsData=dtGprs.Copy();
				dtGprsData.Columns.Remove("isRead");
				dtGprsData.Columns.Remove("gprsNo");
			//	dtGprs.Rows.Clear();			

				if(dtGprsData==null)
				{
					return false;
				}
				if(dtGprsData.Rows.Count<=0)
				{
					return false;
				}
				string strTableName="waterDatasMonth";				
				
				for(int i=0;i<dtGprsData.Rows.Count;i++)
				{
					string strWatNo=dtGprsData.Rows[i]["watNo"].ToString().Trim();
					string strSqlDel=String.Format("delete from {0} where watNo='{1}'",strTableName,strWatNo);
					SqlCommand sCmdDel=new SqlCommand();
					sCmdDel.CommandText=strSqlDel;
					SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
					sCon.Open();
					sCmdDel.Connection=sCon;
					sCmdDel.ExecuteNonQuery();
					sCon.Close();

					string strSql=String.Format("insert into {0}(",strTableName);
					System.Text.StringBuilder sbSql=new System.Text.StringBuilder(strSql);
					//i rowN
					for(int j=0;j<dtGprsData.Columns.Count;j++)
					{	
						//j colN
						string strFieldName=dtGprsData.Columns[j].ColumnName;
						sbSql.Append(strFieldName);
						sbSql.Append(",");
					}
					strSql=sbSql.ToString().Trim();
					strSql=strSql.Substring(0,strSql.Length-1);
					strSql=strSql+")values(";
					sbSql=new System.Text.StringBuilder(strSql);
					
					for(int j=0;j<dtGprsData.Columns.Count;j++)
					{	
						//j colN
						string strFieldName=dtGprsData.Columns[j].ColumnName;
						sbSql.Append("@"+strFieldName);
						sbSql.Append(",");
					}
					strSql=sbSql.ToString().Trim();
					strSql=strSql.Substring(0,strSql.Length-1);
					strSql=strSql+")";
					
					sCon.Open();
					SqlCommand sCmd=new SqlCommand();
					sCmd.CommandText=strSql;
					sCmd.Connection=sCon;

					for(int j=0;j<dtGprsData.Columns.Count;j++)
					{	
						//j colN
						string strFieldName=dtGprsData.Columns[j].ColumnName;
						string strParamName="@"+dtGprsData.Columns[j].ColumnName;
						SqlParameter sParam=sCmd.Parameters.Add(strParamName,SqlDbType.NVarChar,40);
						sParam.Value=dtGprsData.Rows[i][strFieldName].ToString();				
					}					
					sCmd.ExecuteNonQuery();	
					sCon.Close();
					
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

		private void lblInfo_Click(object sender, System.EventArgs e)
		{
			try
			{
				string strInfo="";

				ArrayList al=new ArrayList();

				if(this.lnkInfo.Text.IndexOf("超时")>=0)			
				{
					
					for(int i=0;i<this.m_dtErrZ.Rows.Count;i++)
					{
						al.Add(this.m_dtErrZ.Rows[i]["zhanName"].ToString());
						strInfo+=this.m_dtErrZ.Rows[i]["zhanName"].ToString()+",";
					}
					if(strInfo.IndexOf(",")<0)
					{
						return;
					}

					strInfo=strInfo.Substring(0,strInfo.LastIndexOf(","));
				}

				if(al.Count==0)
				{
					return;
				}

				string[] strZhanName=new string[al.Count];

				for(int i=0;i<al.Count;i++)
				{
					strZhanName[i]=al[i].ToString().Trim();
				}			
						 
				strInfo+="通讯异常.";
				MessageBox.Show(strInfo);

				this.dispSalDetail(strZhanName,System.DateTime.Now.ToString());

				this.dispAmDetail(strZhanName,System.DateTime.Now.ToString());


			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}

		

		}

		//发送列表
		private DataTable m_dtSend;

		private void m_timeSend_Tick(object sender, EventArgs e)
		{
			try
			{

				this.m_timeSend.Stop();

				if(this.m_dtSend.Rows.Count>0)
				{

//	string strZhanNo=this.m_dtSend.Rows[0]["zhanNo"].ToString();
//					this.m_dtSend.Rows.RemoveAt(0);
//
//					
//
//					this.errorProvider1.SetError(this.lblInfo,"");

				}
			
				this.m_timeSend.Start();

			}
			catch(Exception ex)
			
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}		
		}

		private void decTooLong()
		{

			if(this.m_strStartTime.Trim()!="")
			{
				DateTime dtStart=DateTime.Parse(this.m_strStartTime.Trim());
				DateTime dtNow=System.DateTime.Now;
				
				//Console.WriteLine(dtNow.ToString());
				//Console.WriteLine(dtStart.AddSeconds(this.iTimeLong).ToString());

				if(this.iTimeLong<8000)
				{
					this.iTimeLong=8000;
				}

				if(dtStart.AddMilliseconds(this.getTooLong())<dtNow)
				{				
					this.showTooLong();
					//this.m_strStartTime="";
				}
			}
				//???????????????
		}
		private bool bTooLong=false;

		private void showTooLongInfo(string strZhanName)
		{
			try
			{
//				DataRow dr=this.m_dtAllSa.NewRow();
//
//				string strTime="";
//
//				int inDex=strTime.LastIndexOf(":");
//				strTime=strTime.Substring(0,inDex);
//
//				//strSql=string.Format("select wellNo from tbWell where wellName='{0}'",strWellName);
//				string strWellName=strZhanName;
//				string strSqlEE=string.Format("select wellNo from tbWell where wellName='{0}'",strWellName);
//
//				string strWellNo=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();
//
//				string strSql=string.Format("select allSalAmount from tbSal where time=(select max(time) from tbSal where wellNo='{0}' and time<='{1}') and wellNo='{0}'",strWellNo,strTime);
//
//				string strAllSalAmount=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();
//
//				strSql=string.Format("select price1 from tbWell where wellNo='{0}'",strWellNo);
//
//				string strPrice=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();
//
//				if(strAllSalAmount.Trim()=="")
//				{
//					strAllSalAmount="0";
//				}
//
//				strSql=string.Format("select depName from tbWell where wellName='{0}'",strWellName);
//				string strDepName=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();
//
//				double dAllSalAmount=double.Parse(strAllSalAmount);
//				double dAllSalMony=dAllSalAmount*double.Parse(strPrice);
//
//				double dLeftIC=dAllSalAmount-double.Parse(dtRep.Rows[j]["allAmount"].ToString());
//				double dLeftMony=dLeftIC*double.Parse(strPrice);
//
//				double dAllAmount=double.Parse(dtRep.Rows[j]["allAmount"].ToString());
//				double dAllUsedMony=dAllAmount*double.Parse(strPrice);
//
//				dr["wellName"]=strWellName;
//				dr["leftAmount"]=dLeftIC.ToString();
//				dr["leftMony"]=dLeftMony.ToString();
//				dr["allMony"]=dAllSalMony.ToString();
//				dr["allBuyAmount"]=dAllSalAmount.ToString();
//				dr["allUsedMony"]=dAllUsedMony.ToString();
//				dr["allAmount"]=dtRep.Rows[j]["allAmount"].ToString();
//				dr["time"]=strTime;
//
//				this.m_dtAllSa.Rows.Add(dr);
//
//				cDealReport cdr=new cDealReport();
//				this.removeSum(ref this.m_dtAllSa);
//				string strTimeEx=cDealReport.getMaxTime(this.m_dtAllSa);
//				cdr.addSum(ref this.m_dtAllSa,-1,strDepName);
//
//				//this.m_dtAllSa.Rows[0]["time"]=strTimeEx;
//				
//				this.paintList(this.listView1, 2,this.m_dtAllSa);
//
//				this.paintTime();
								
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void showTooLong()
		{

			//this.m_dtSended.Rows.Clear();

			if(this.bTooLong)
			{
				this.lblInfo.Text="超时";
				this.lnkInfo.Text="等待超时"; 
				this.lnkInfo.Visible=true;
				this.errorProvider1.SetError(this.lnkInfo,"通讯异常");
			}
	
			if(this.m_dtFarCmded!=null)
			{
				this.m_dtFarCmded.Rows.Clear();
			}
	
			DataTable dt=this.m_dtSended.Copy();
			this.m_dtSended.Rows.Clear();

			if(!this.bTooLong)
			{

				this.iTimeLong=this.m_iInter*(dt.Rows.Count)+1800;

				for(int i=0;i<dt.Rows.Count;i++)
				{
					string strZhanNo=dt.Rows[i]["zhanNo"].ToString().Trim();
					string strZhanName=dt.Rows[i]["zhanName"].ToString().Trim();
					this.farCmd(strZhanNo,strZhanName);
				}

			//	this.bTooLong=false;
			}
			else
			{
				this.m_dtErrZ.Rows.Clear();

				for(int i=0;i<dt.Rows.Count;i++)
				{
					string strZhanName=dt.Rows[i]["zhanName"].ToString().Trim();
					DataRow dr=this.m_dtErrZ.NewRow();
					dr["zhanName"]=strZhanName;
					this.m_dtErrZ.Rows.Add(dr);
				}
			
				this.m_strStartTime="";
				this.bTooLong=false;
				
			}

			this.bTooLong=true;

	   }

		private void allReved()
		{
			this.lblInfo.Text="";
			this.m_strStartTime="";
			this.iTimeLong=0;
			this.bTooLong=false;
		}

		private void btnClear_Click(object sender, System.EventArgs e)
		{
			
			if(this.lblInfo.Text.IndexOf("....")>=0)
			{
				MessageBox.Show("正在进行远程招测,请稍候执行该操作!");
				return;
			}
			this.listView1.Items.Clear();
			//this.listView2.Items.Clear();
			this.listView3.Items.Clear();
			this.listView4.Items.Clear();
		}



		private void lblInfo_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
		
		}

		private void lblInfo_Click_1(object sender, System.EventArgs e)
		{
			this.lblInfo.Text="";
	
		}

		private void lnkInfo_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			
			lblInfo_Click(null,null);
			this.lnkInfo.Text="";
			this.lblInfo.Text="";
			this.errorProvider1.SetError(this.lnkInfo,"");
			 
		}

		private void addSum(ref DataTable dtAvgEx)
		{
			try
			{
				DataRow dr=dtAvgEx.NewRow();

				for(int i=0;i<dtAvgEx.Columns.Count;i++)
				{
					if((i!=0)&&(i!=(dtAvgEx.Columns.Count-1))&&(dtAvgEx.Columns[i].ColumnName!="time")&&(dtAvgEx.Columns[i].ColumnName!="salPer")&&(dtAvgEx.Columns[i].ColumnName!="price")&&(dtAvgEx.Columns[i].ColumnName!="allSalAmountBefore")&&(dtAvgEx.Columns[i].ColumnName!="allSalAmountAfter"))
					{
						try
						{
							dr[i]=this.sumCol(dtAvgEx,i);
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.ToString()+dtAvgEx.Columns[i].ColumnName+i.ToString()+dtAvgEx.Columns.Count.ToString());
						}
						
					}
					else
					{
						dr[0]="合计";
					}					
				}

				if(dtAvgEx.Rows.Count>0)
				{
					dtAvgEx.Rows.Add(dr);					
				}

                
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString().Trim());
			}
		}


		private void addSumEx(ref DataTable dtAvgEx)
		{
			try
			{
				DataRow dr=dtAvgEx.NewRow();
				bool bHave=false;

				for(int i=0;i<dtAvgEx.Columns.Count;i++)
				{
					if((i!=0)&&(i!=(dtAvgEx.Columns.Count-1))&&(dtAvgEx.Columns[i].ColumnName!="time")&&(dtAvgEx.Columns[i].ColumnName!="salPer")&&(dtAvgEx.Columns[i].ColumnName!="price")&&(dtAvgEx.Columns[i].ColumnName!="allSalAmountBefore")&&(dtAvgEx.Columns[i].ColumnName!="allSalAmountAfter"))
					{
						try
						{
							dr[i]=this.sumColEx(dtAvgEx,i);
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.ToString()+dtAvgEx.Columns[i].ColumnName+i.ToString()+dtAvgEx.Columns.Count.ToString());
						}
						
					}
					else
					{
						dr[0]="总计";
					}	
					bHave=true;
			
				}

				if(bHave)
				{
					dtAvgEx.Rows.Add(dr);
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}



			
		}

		private void showAllSales(string strDepName,string strTimeS)
		{

			try
			{
				//string strSql=string.Format("select wellName from tbWell where depName='{0}' order by wellNo",strDepName);
				//DataTable dtWells=new DataTable();
				//BengZhan.CDBConnection.getDataTable(ref dtWells,strSql,"dtW");

				string strSql=string.Format("select distinct month(time) mon,year(time) yea from tbSal,tbWell where tbSal.wellNo=tbSal.wellNo and  depName='{0}' and time<='{1}'",strDepName,strTimeS);
				DataTable dtMonth=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtMonth,strSql,"dtMonth");

				DataTable dtShow=new DataTable();
				DataTable dtRep=new DataTable();

				for(int j=0;j<dtMonth.Rows.Count;j++)
				{
				

					string strYear=dtMonth.Rows[j]["yea"].ToString().Trim();
					string strMonth=dtMonth.Rows[j]["mon"].ToString().Trim();	
					//Console.WriteLine(strMonth);

						strSql=string.Format("select wellName,price,salMony,salAmount,time,salPer,allSalAmount as allSalAmountAfter,(allSalAmount-salAmount) as allSalAmountBefore from tbWell,tbSal where tbSal.wellNo=tbWell.wellNo and depName='{0}' and year(time)='{1}' and month(time)='{2}' order by time",strDepName,strYear,strMonth);

						DataTable dtDetail=new DataTable();

						BengZhan.CDBConnection.getDataTable(ref dtDetail,strSql,"dt");
						this.addSum(ref dtDetail);		
						BengZhan.comReport.CReports.copyDt(dtDetail,ref dtRep);
				}

				//+++++++++++++++++++++++++++++++++++
					
				this.addSumEx(ref dtRep);

						  //	BengZhan.CDBConnection			
						 
			this.paintList(this.listView3,3,dtRep);
//
this.groupBox3.Text=string.Format("售水明细表  截止时间:{0}",strTimeS);

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void listView2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(this.listView2.SelectedItems.Count==0)
				{
					return;
				}

				if(this.lblInfo.Text.IndexOf("....")>=0)
				{
					return;
				}

				this.listView4.Items.Clear();

				if(this.listView2.SelectedItems[0].Text.IndexOf("合计")<0)
				{
					//	string strTime=this.listView2.SelectedItems[0].SubItems[7].Text.Trim();
					int iCount=this.listView2.Items[0].SubItems.Count;
					iCount--;
					string strTime=this.listView2.SelectedItems[0].SubItems[iCount].Text.Trim();
					string strName=this.listView2.SelectedItems[0].SubItems[0].Text.Trim();

					string strSql=string.Format("select wellName,price,salMony,salAmount,time,salPer,allSalAmount as allSalAmountAfter,(allSalAmount-salAmount) as allSalAmountBefore from tbWell,tbSal where tbSal.wellNo=tbWell.wellNo and wellname='{0}' and time<='{1}' order by time",strName,strTime);

					DataTable dtDetail=new DataTable();

					BengZhan.CDBConnection.getDataTable(ref dtDetail,strSql,"dt");
					this.addSum(ref dtDetail);

					this.paintList(this.listView3,3,dtDetail);


					this.groupBox3.Text=string.Format("售水明细表  截止时间:{0}",strTime);
					this.m_strTitle3="监测站："+strName;


				}
				else
				{
					//string strTime=this.listView2.SelectedItems[0].SubItems[7].Text.Trim();
					int iCount=this.listView2.Items[0].SubItems.Count;
					iCount--;
				string strTime=this.listView2.SelectedItems[0].SubItems[iCount].Text.Trim();
				string strName=this.listView2.SelectedItems[0].SubItems[0].Text.Trim();

					int iDex=this.listView2.SelectedItems[0].Index;
					iDex--;
					strName=this.listView2.Items[iDex].Text.Trim();
					strTime=this.listView2.Items[iDex].SubItems[iCount].Text.Trim();
					strTime=this.getMaxTime();

					string strSql=string.Format("select depName from tbWell where wellName='{0}'",strName);	

					string strDepName=BengZhan.CDBConnection.ExecuteScalar(strSql);

				this.showAllSales(strDepName,strTime);
					this.m_strTitle3="单位："+strDepName;		

				//	BengZhan.CDBConnection.getDataTable(ref dtDep,strSql,"dtDep");
                    
				}



				this.paintColor();
this.showAmountDetail();
				this.paintColor();


			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private string getMaxTime()
		{
//			try
//			{
//				string strTime="";
//
//				int iCount=this.listView2.Columns.Count;
//
//				for(int i=0;i<this.listView2.Items.Count;i++)
//				{
//					string strTimeTemp=this.listView2.Items[i].SubItems[iCount-1].Text.Trim();
//					if(strTimeTemp.Trim()=="")
//					{
//					}
//					else
//					{
//						if(strTime=="")
//						{
//							strTime=strTimeTemp;
//						}
//						else
//						{
//							if(DateTime.Parse(strTimeTemp)>DateTime.Parse(strTime))
//							{
//								strTime=strTimeTemp;
//							}
//						}
//					}
//				}
//
//				return strTime;
//					  }
//			catch(Exception ex)
//			{
//				MessageBox.Show(ex.ToString());
//				return "";
//			}
			return "";
		}

		private void paintColorLsv4()
		{
			try
			{
				for(int i=0;i<this.listView4.Items.Count;i++)
				{
					int iCount=this.listView4.Items[i].SubItems.Count;
					if(this.listView4.Items[i].SubItems[iCount-1].Text.Trim().IndexOf("至")>=0)
					{
						if(this.listView4.Items[i].Text.IndexOf("总计")>=0)
						{
						}
						else
						{
							this.listView4.Items[i].BackColor=Color.White;
						}					
					}
					else
					{
						this.listView4.Items[i].SubItems[iCount-2].Text="";
					}
				}
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}


		private void paintColor(System.Windows.Forms.ListView lsv,string strTitle,Color c)
		{
			for(int i=0;i<lsv.Items.Count;i++)
			{
				if(lsv.Items[i].Text.IndexOf(strTitle)>=0)
				{
					for(int j=0;j<lsv.Items[i].SubItems.Count;j++)
					{
						lsv.Items[i].SubItems[j].BackColor=c;
					}
				}	
			}
		}

		private void allLine()
		{

		}

		private void paintColor()
		{
			try
			{
				//this.showAmountDetail();


						this.paintColor(this.listView1,"合计",Color.White);
				this.paintColor(this.listView1,"总计",Color.Silver);
						this.paintColor(this.listView2,"合计",Color.White);
						this.paintColor(this.listView3,"合计",Color.White);
				this.paintColor(this.listView3,"总计",Color.Silver);
				this.paintColor(this.listView4,"合计",Color.White);
				this.paintColor(this.listView4,"总计",Color.Silver);

//				dg.CaptionText=this.groupBox3.Text.Trim().Replace("售水明细表","");
//				dg.CaptionText+="  售水明细表";
//				dg.CaptionText=this.m_strTitle3+"  "+dg.CaptionText;

				string strTitle=this.groupBox3.Text.Trim();

							this.clearTimes();

				if(strTitle.IndexOf("时间范围")>=0)
				{
					int iDex=strTitle.IndexOf("时间范围");
					strTitle=strTitle.Substring(iDex);
				}
				else
				{
					if(strTitle.IndexOf("截止时间")>=0)
					{
						int iDex=strTitle.IndexOf("截止时间");
						strTitle=strTitle.Substring(iDex);
					}
					else
					{
						return;
					}
				}
			
				
				strTitle=string.Format("售水明细表  {0}  {1}",this.m_strTitle3,strTitle);
				this.groupBox3.Text=strTitle;

				this.paintColorLsv4();
				//strTitle	
	


			 }
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void clearTimes()
		{
//			try
//			{
//				for(int i=0;i<this.listView1.Items.Count;i++)			
//				{
//					int iCount=this.listView1.Items[i].SubItems.Count;
//					iCount--;
//					if(this.listView1.Items[i].SubItems[iCount].Text.Trim()!="")
//					{
//						string strTime=this.listView1.Items[i].SubItems[iCount].Text.Trim();
//						string[] strTimes=strTime.Split('至');
//						Console.WriteLine(strTime);
//						DateTime dtTo=new DateTime();
//						try
//						{
//
//							dtTo=DateTime.Parse(strTimes[1]);
//
//						}
//						catch(Exception ex)
//						{
//							MessageBox.Show(ex.ToString()+"--"+strTimes[1]+"--"+strTimes[0]);
//						}
//		
//						if(dtTo.Month==System.DateTime.Now.Month)
//						{
//							strTime=string.Format("{0}  23:00",System.DateTime.Now.ToShortDateString());
//							strTime=string.Format("{0}  至  {1}",strTimes[0],strTime);
//							this.listView1.Items[i].SubItems[iCount].Text=strTime;
//						}				
//					}
//				}
//			}
//			catch(Exception ex)
//			{
//				MessageBox.Show(ex.ToString());
//			}			
		}

		private string m_strIdex="";

		private void listView1_Click(object sender, System.EventArgs e)
		{

			if(this.listView1.SelectedItems.Count==0)
			{
				return;
			}

			if((this.m_strIdex=="")||this.m_strIdex.Trim()==this.listView1.SelectedItems[0].Index.ToString())
			{				
				this.listView1_SelectedIndexChanged(null,null);
			}
			this.m_strIdex=this.listView1.SelectedItems[0].Index.ToString();
			
		}

		private string m_strIDex1="";

		private void listView2_Click(object sender, System.EventArgs e)
		{
//			if(this.listView2.SelectedItems.Count==0)
//			{
//				return;
//			}
//		
//			if((this.m_strIDex1=="")||this.m_strIDex1.Trim()==this.listView2.SelectedItems[0].Index.ToString())
//			{
//				
//				this.listView2_SelectedIndexChanged(null,null);
//			}
//				this.m_strIDex1=this.listView2.SelectedItems[0].Index.ToString();
		
		}

		private void listView3_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		#region"amountDetail"

		private string replace2str(string str)
		{
			str=str.Replace("   "," ");
			str=str.Replace("    "," ");
			str=str.Replace("  "," ");
			return str;
		}

		private void showAmountDetail()
		{
			try
			{
				if((this.groupBox3.Text.IndexOf("监测站")>=0)&&(this.groupBox3.Text.IndexOf("时间范围")>=0))
				{

					//显示站点
					string strTitle=this.groupBox3.Text.Trim();
					strTitle=this.replace2str(strTitle);

				//	string[] strsTitle=strTitle.Split(' ');

					string strZhanName="";
					string strTime1="";
					string strTime2="";

					int iDexZhan=strTitle.IndexOf("监测站");
					int iDexTime=strTitle.IndexOf("时间范围");

					strZhanName=strTitle.Substring(iDexZhan,(iDexTime-iDexZhan)).Trim();
					strZhanName=strZhanName.Substring(4);

					strTime1=strTitle.Substring(iDexTime).Trim();
					strTime1=strTime1.Substring(5);

					string[] strsTime=strTime1.Split('至');

					strTime1=strsTime[0].Trim();
					strTime2=strsTime[1].Trim();                   

					DataTable dtDetail=new DataTable();

					string strSql=string.Format("select wellNo from tbWell where wellName='{0}'",strZhanName);

				string strZhanNo=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();		

					if(BengZhan.comReport.CReports.getDtDetailReportDay(strZhanNo,strTime1,strTime2,ref dtDetail)==false)
					{
						return;
					}				

					if(dtDetail.Rows.Count<=1)
					{
						return;
					}

					dtDetail.Columns.Add("leftAmountIC");
					dtDetail.Columns.Add("usedMony");;

					for(int i=0;i<dtDetail.Rows.Count;i++)
					{
						string strTime=dtDetail.Rows[i]["time"].ToString().Trim();
						string strWellName=dtDetail.Rows[i]["wellName"].ToString().Trim();
string strAllAmount=dtDetail.Rows[i]["allAmount"].ToString().Trim();

						strSql=string.Format("select max(cast(allSalAmount as decimal(19,2))) from tbSal,tbWell  where tbWell.wellNo=tbSal.wellNo and wellName='{0}' and time<='{1}'",strWellName,strTime);
						string strAllSalAmount=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();			

						if((strAllSalAmount==null)||strAllSalAmount.Trim()=="")
						{
							continue;
						}

						strSql=string.Format("select price1 from tbWell where wellName='{0}'",strWellName);
						string strPrice=BengZhan.CDBConnection.ExecuteScalar(strSql);
						double dPrice=double.Parse(strPrice);

						double dAllSalAmount=double.Parse(strAllSalAmount);
						double dAllAmount=double.Parse(strAllAmount);
						double dAllMony=dAllAmount*dPrice;
						double dLeftAmount=dAllSalAmount-dAllAmount;

						dtDetail.Rows[i]["leftAmountIC"]=dLeftAmount.ToString();
						dtDetail.Rows[i]["usedMony"]=dAllMony.ToString();
					}
						
					this.paintList(this.listView4,5,dtDetail);				
				}

				if((this.groupBox3.Text.IndexOf("单位")>=0)&&(this.groupBox3.Text.IndexOf("时间范围")>=0))
				{

					//显示站点
					string strTitle=this.groupBox3.Text.Trim();
					strTitle=this.replace2str(strTitle);

					//	string[] strsTitle=strTitle.Split(' ');

					string strDepName="";
					string strTime1="";
					string strTime2="";


					int iDexZhan=strTitle.IndexOf("单位");
					int iDexTime=strTitle.IndexOf("时间范围");

					strDepName=strTitle.Substring(iDexZhan,(iDexTime-iDexZhan)).Trim();
					strDepName=strDepName.Substring(3);

					strTime1=strTitle.Substring(iDexTime).Trim();
					strTime1=strTime1.Substring(5);

					string[] strsTime=strTime1.Split('至');

					strTime1=strsTime[0].Trim();
					strTime2=strsTime[1].Trim();                   

					DataTable dtDetail=new DataTable();

					frmReport frmRep=new frmReport();
					frmRep.detailRepDep(ref dtDetail,strTime1,strTime2,strDepName);

					dtDetail.Columns.Add("leftAmountIC");
					dtDetail.Columns.Add("usedMony");;

					for(int i=0;i<dtDetail.Rows.Count;i++)
					{
						string strTime=dtDetail.Rows[i]["time"].ToString().Trim();
						string strWellName=dtDetail.Rows[i]["wellName"].ToString().Trim();
						string strAllAmount=dtDetail.Rows[i]["allAmount"].ToString().Trim();

						
						string strSql=string.Format("select price1 from tbWell where wellName='{0}'",strWellName);
						string strPrice=BengZhan.CDBConnection.ExecuteScalar(strSql);

						if((strPrice==null)||strPrice.Trim()=="")
						{
							continue;
						}

						strSql=string.Format("select max(cast(allSalAmount as decimal(19,2))) from tbSal,tbWell  where tbWell.wellNo=tbSal.wellNo and wellName='{0}' and time<='{1}'",strWellName,strTime);
						string strAllSalAmount=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();			

						if((strAllSalAmount==null)||strAllSalAmount.Trim()=="")
						{
							continue;
						}

						double dPrice=double.Parse(strPrice);

						double dAllSalAmount=double.Parse(strAllSalAmount);
						double dAllAmount=double.Parse(strAllAmount);
						double dAllMony=dAllAmount*dPrice;
						double dLeftAmount=dAllSalAmount-dAllAmount;

						dtDetail.Rows[i]["leftAmountIC"]=dLeftAmount.ToString();
						dtDetail.Rows[i]["usedMony"]=dAllMony.ToString();
					}			
						
					this.paintList(this.listView4,5,dtDetail);				
				}

				if((this.groupBox3.Text.IndexOf("监测站")>=0)&&(this.groupBox3.Text.IndexOf("截止时间")>=0))
				{

					//显示站点
					string strTitle=this.groupBox3.Text.Trim();
					strTitle=this.replace2str(strTitle);

					//	string[] strsTitle=strTitle.Split(' ');

					string strZhanName="";
					string strTime1="";
					string strTime2="";

					int iDexZhan=strTitle.IndexOf("监测站");
					int iDexTime=strTitle.IndexOf("截止时间");

					strZhanName=strTitle.Substring(iDexZhan,(iDexTime-iDexZhan)).Trim();
					strZhanName=strZhanName.Substring(4);

					strTime1=strTitle.Substring(iDexTime).Trim();
					strTime1=strTime1.Substring(5);

					string strSql=string.Format("select time from tbMinTime");
					strTime2=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();

					string strTime3="";
					strTime3=strTime1;
					strTime1=strTime2;
					strTime2=strTime3;
					//	string strTime2=BengZhan.CDBConnection.

					//string[] strsTime=strTime1.Split('至');

					//	strTime1=strsTime[0].Trim();
					//strTime2=strsTime[1].Trim();                   

					DataTable dtDetail=new DataTable();

				strSql=string.Format("select wellNo from tbWell where wellName='{0}'",strZhanName);

					string strZhanNo=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();		

					if(BengZhan.comReport.CReports.getDtDetailReportDay(strZhanNo,strTime1,strTime2,ref dtDetail)==false)
					{
						return;
					}				

					if(dtDetail.Rows.Count<=1)
					{
						return;
					}

					dtDetail.Columns.Add("leftAmountIC");
		//			dtDetail.Columns.Add("usedMony");;

//					for(int i=0;i<dtDetail.Rows.Count;i++)
//					{
//						string strTime=dtDetail.Rows[i]["time"].ToString().Trim();
//						string strWellName=dtDetail.Rows[i]["wellName"].ToString().Trim();
//						string strAllAmount=dtDetail.Rows[i]["allAmount"].ToString().Trim();
//
//						strSql=string.Format("select max(cast(allSalAmount as decimal(19,2))) from tbSal,tbWell  where tbWell.wellNo=tbSal.wellNo and wellName='{0}' and time<='{1}'",strWellName,strTime);
//						string strAllSalAmount=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();			
//
//						if((strAllSalAmount==null)||strAllSalAmount.Trim()=="")
//						{
//							continue;
//						}
//
//						strSql=string.Format("select price1 from tbWell where wellName='{0}'",strWellName);
//						string strPrice=BengZhan.CDBConnection.ExecuteScalar(strSql);
//						double dPrice=double.Parse(strPrice);
//
//						double dAllSalAmount=double.Parse(strAllSalAmount);
//						double dAllAmount=double.Parse(strAllAmount);
//						double dAllMony=dAllAmount*dPrice;
//						double dLeftAmount=dAllSalAmount-dAllAmount;
//
//						dtDetail.Rows[i]["leftAmountIC"]=dLeftAmount.ToString();
//						dtDetail.Rows[i]["usedMony"]=dAllMony.ToString();
//					}
						
					this.paintList(this.listView4,5,dtDetail);				
				}

				if((this.groupBox3.Text.IndexOf("单位")>=0)&&(this.groupBox3.Text.IndexOf("截止时间")>=0))
				{
					//显示站点
					string strTitle=this.groupBox3.Text.Trim();
					strTitle=this.replace2str(strTitle);

					//	string[] strsTitle=strTitle.Split(' ');

					string strDepName="";
					string strTime1="";
					string strTime2="";

					int iDexZhan=strTitle.IndexOf("单位");
					int iDexTime=strTitle.IndexOf("截止时间");

					strDepName=strTitle.Substring(iDexZhan,(iDexTime-iDexZhan)).Trim();
					strDepName=strDepName.Substring(3);

					strTime1=strTitle.Substring(iDexTime).Trim();
					strTime1=strTime1.Substring(5);

					string strSql=string.Format("select time from tbMinTime");
					strTime2=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();

					string strTime3="";
					strTime3=strTime1;
					strTime1=strTime2;
					strTime2=strTime3;	

					cDealReport cdr=new cDealReport();
	
					DataTable dtDetail=cdr.getDepDetailByEnd(strDepName,strTime2);
					if(dtDetail==null)
					{
						return;
					}
						
					this.paintList(this.listView4,5,dtDetail);				

					this.groupBox4.Text=string.Format("用水明细表  单位:{0}  截止时间:{1}",strDepName,strTime2);
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		#endregion

		private void groupBox1_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void cmbYue1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.cmbYue2.Text=this.cmbYue1.Text;
		}

		private void groupBox2_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void groupBox4_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void groupBox1_Enter_1(object sender, System.EventArgs e)
		{
		
		}

		private void button2_Click(object sender, System.EventArgs e)
		{

			try
			{
				this.clearLsv();

				this.iniListV(this.listView1,2);
				DateTime dt=this.dtp2.Value;
		
				string	strEndTime=string.Format("{0} {1}:00:00",dt.ToShortDateString(),this.cmbH.Text.Trim());	
				string strTime="";
				
				if(this.lblName.Text.IndexOf("站")>=0)
				{
					//监测站
					CReportDll.comReport.newRep.cDealReport cdr=new cDealReport();
					DataTable dtSh=	cdr.getStaticRepEx(this.txtZhan.Text.Trim(),strEndTime,ref strTime);

					if(dtSh==null)
					{
						return;
					}

					if(dtSh.Rows.Count==0)
					{
						return;
					}
	
					this.paintList(this.listView1,2,dtSh);			
				}

				if(this.lblName.Text.IndexOf("单位")>=0)
				{
					string strDepName=this.txtZhan.Text.Trim();

					CReportDll.comReport.newRep.cDealReport cdr=new cDealReport();
					DataTable dtSh=	cdr.getStaticRepDepEx(this.txtZhan.Text.Trim(),strEndTime);

					if(dtSh==null)
					{
						return;
					}

					if(dtSh.Rows.Count==0)
					{
						return;
					}
	
					this.paintList(this.listView1,2,dtSh);		
				}

				if(this.lblName.Text.IndexOf("乡镇")>=0)
				{
					string strCountryName=this.txtZhan.Text.Trim();

					CReportDll.comReport.newRep.cDealReport cdr=new cDealReport();
					DataTable dtSh=	cdr.getStaticRepCountry(this.txtZhan.Text.Trim(),strEndTime);

					if(dtSh==null)
					{
						return;
					}

					if(dtSh.Rows.Count==0)
					{
						return;
					}
	
					this.paintList(this.listView1,2,dtSh);	
				}	
		
				this.groupBox1.Text=string.Format("用水总帐统计表  截止时间:{0}",strEndTime);

				this.paintTime();

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}	

		}

		private void listView1_SelectedIndexChanged_1(object sender, System.EventArgs e)
		{
		
		}

		#region"总帐"

		//显示控制器历史记录
		private DataTable showZhanRep(string strZhanName,string strTimeS)
		{
			try
			{
				string strWellName=strZhanName;
				string strTime=strTimeS;

				if(strTime.Trim()=="")
				{
					return null;
				}
				
				string[] strTimes=strTime.Split('至');
				strTime=strTimes[0].Trim();

				string strTimeTo=strTimes[1].Trim();

				this.groupBox3.Text=string.Format("售水明细表  时间范围：{0} 至 {1}",strTime,strTimeTo);

				DateTime dt=DateTime.Parse(strTime);

				string strSql=string.Format("select name wellName,allBuyAmount,allMony,leftAmount,leftMony,allAmount,allAmount*price1 allUsedMony,time from waterDatasMonth,tbWell where waterDatasMonth.name=tbWell.wellName and month(time)={0} and year(time)={1} and wellName='{2}'",dt.Month.ToString(),dt.Year.ToString(),strWellName);

				DataTable dtRep=new DataTable();

				BengZhan.CDBConnection.getDataTable(ref dtRep,strSql,"dt");

				if(dtRep.Rows.Count>0)
				{

					this.m_dtAllSa.Rows.Clear();

					DataRow dr=this.m_dtAllSa.NewRow();

					strTime=dtRep.Rows[0]["time"].ToString().Trim();
					strSql=string.Format("select wellNo from tbWell where wellName='{0}'",strWellName);
					string strWellNo=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();

					strSql=string.Format("select allSalAmount from tbSal where time=(select max(time) from tbSal where wellNo='{0}' and time<='{1}') and wellNo='{0}'",strWellNo,strTime);

					string strAllSalAmount=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();

					strSql=string.Format("select price1 from tbWell where wellNo='{0}'",strWellNo);

					string strPrice=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();

					if(strAllSalAmount.Trim()=="")					
					{
						strAllSalAmount="0";
					}

					double dAllSalAmount=double.Parse(strAllSalAmount);
					double dAllSalMony=dAllSalAmount*double.Parse(strPrice);
					double dLeftIC=dAllSalAmount-double.Parse(dtRep.Rows[0]["allAmount"].ToString());

					dr["wellName"]=strWellName;
					dr["leftAmountIC"]=dLeftIC.ToString();
					dr["leftAmountMana"]=dtRep.Rows[0]["leftAmount"].ToString();
					dr["allBuyMony"]=dAllSalMony.ToString();
					dr["allBuyAmount"]=dAllSalAmount.ToString();
					dr["allUsedMony"]=dtRep.Rows[0]["allUsedMony"].ToString();
					dr["allAmount"]=dtRep.Rows[0]["allAmount"].ToString();
					dr["time"]=strTime;

					this.m_dtAllSa.Rows.Add(dr);

					DataTable dtSRet=this.m_dtAllSa.Copy();
					this.m_dtAllSa.Rows.Clear();

					return dtSRet;
				
					//this.paintList(this.listView2, 2,this.m_dtAllSa);
				}

				return null;

				//this.paintList(this.listView2,2,dtRep);
				strSql=string.Format("select wellName,price,salMony,salAmount,time,salPer,allSalAmount as allSalAmountAfter,(allSalAmount-salAmount) as allSalAmountBefore from tbWell,tbSal where tbSal.wellNo=tbWell.wellNo and wellname='{0}' and year(time)={1} and month(time)={2} order by time",strWellName,dt.Year.ToString(),dt.Month.ToString());
				BengZhan.CDBConnection.getDataTable(ref dtRep,strSql,"dt");
				this.addSum(ref dtRep);

				this.paintList(this.listView3,3,dtRep);

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return null;
			}			
		}

		#endregion

		#region"远程招测"

		private void button3_Click(object sender, System.EventArgs e)
		{
			this.clearLsv();
			this.groupBox1.Text=string.Format("总帐统计表  截止时间:{0}",System.DateTime.Now.ToString());
			this.listView1.Items.Clear();
			this.iniListV(this.listView1,2);

			this.btnCmd_Click(null,null);
		}

		private void showManaDatas(DataTable dtRep)
		{
				try
				{
						if(dtRep==null)
						{
							return;
						}

						if(dtRep.Rows.Count>0)
						{
							for(int j=0;j<dtRep.Rows.Count;j++)
							{
								//this.m_dtAllSa.Rows.Clear();

								DataRow dr=this.m_dtAllSa.NewRow();

								string strTime=dtRep.Rows[j]["time"].ToString().Trim();
								int inDex=strTime.LastIndexOf(":");
								strTime=strTime.Substring(0,inDex);
								//strSql=string.Format("select wellNo from tbWell where wellName='{0}'",strWellName);
								string strWellName=dtRep.Rows[j]["name"].ToString().Trim();

								string strWellNo=dtRep.Rows[j]["watNo"].ToString().Trim();

								string strSql=string.Format("select allSalAmount from tbSal where time=(select max(time) from tbSal where wellNo='{0}' and time<='{1}') and wellNo='{0}'",strWellNo,strTime);

								string strAllSalAmount=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();

								strSql=string.Format("select price1 from tbWell where wellNo='{0}'",strWellNo);

								string strPrice=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();

								if(strAllSalAmount.Trim()=="")
								{
									strAllSalAmount="0";
								}

								strSql=string.Format("select depName from tbWell where wellName='{0}'",strWellName);
								string strDepName=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();

								double dAllSalAmount=double.Parse(strAllSalAmount);
								double dAllSalMony=dAllSalAmount*double.Parse(strPrice);
								double dLeftIC=dAllSalAmount-double.Parse(dtRep.Rows[j]["allAmount"].ToString());
								double dLeftMony=dLeftIC*double.Parse(strPrice);

								double dAllAmount=double.Parse(dtRep.Rows[j]["allAmount"].ToString());
								double dAllUsedMony=dAllAmount*double.Parse(strPrice);

								dr["wellName"]=strWellName;
								dr["leftAmount"]=dLeftIC.ToString();
								dr["leftMony"]=dLeftMony.ToString();
								dr["allMony"]=dAllSalMony.ToString();
								dr["allBuyAmount"]=dAllSalAmount.ToString();
								dr["allUsedMony"]=dAllUsedMony.ToString();
								dr["allAmount"]=dtRep.Rows[j]["allAmount"].ToString();
								dr["time"]=strTime;

								this.m_dtAllSa.Rows.Add(dr);

								cDealReport cdr=new cDealReport();
								this.removeSum(ref this.m_dtAllSa);
								string strTimeEx=cDealReport.getMaxTime(this.m_dtAllSa);
								cdr.addSum(ref this.m_dtAllSa,-1,strDepName);
								//this.m_dtAllSa.Rows[0]["time"]=strTimeEx;
				
								this.paintList(this.listView1, 2,this.m_dtAllSa);

								this.paintTime();
								//this.paintSumRowLsv2();
					
								for(int i=0;i<this.m_dtSended.Rows.Count;i++)					
								{
									string strWellNameEx=this.m_dtSended.Rows[i]["zhanName"].ToString().Trim();
									if(strWellNameEx==strWellName.Trim())
									{
										this.m_dtSended.Rows.RemoveAt(i);
										i--;
									}
								}

								if(this.m_dtSended.Rows.Count==0)
								{
									this.lblInfo.Text="";
									this.allReved();
								}
							}						
						}
					}
					catch(Exception ex)
					{
						cSaveErr.CSaveErr.msgboxErr(ex.ToString());
					}
		}

		private void removeSum(ref DataTable dt)
		{
			if((dt==null)||(dt.Columns["wellName"]==null)||(dt.Rows.Count==0))
			{
				return;
			}
			for(int i=0;i<dt.Rows.Count;i++)
			{
				if(dt.Rows[i]["wellName"].ToString().IndexOf("合计")>=0)
				{
					dt.Rows.RemoveAt(i);
					return ;
				}
			}
				  }

		#endregion

		#region"察看明细"

		private void listView1_SelectedIndexChanged_2(object sender, System.EventArgs e)
		{
			try
			{
				if(this.listView1.SelectedItems.Count==0)
				{
					return;
				}

				string strZhanName=this.listView1.SelectedItems[0].Text.Trim();
				int iCount=this.listView1.Items[0].SubItems.Count;
				string strTime=this.listView1.SelectedItems[0].SubItems[iCount-1].Text.Trim();

				if(strZhanName.IndexOf("合计")>=0)
				{

					strZhanName=strZhanName.Replace("合计","");
					//单位
					DataTable dtAllSalesDep=new DataTable();
					cDealReport cdr=new cDealReport();
					dtAllSalesDep=cdr.getAllSalesDep(strZhanName,strTime);	
					 CReportDll.comReport.newRep.cDealReport.changeDataType(ref dtAllSalesDep);	
					this.paintList(this.listView3,3,dtAllSalesDep);
					this.groupBox3.Text="售水明细表"+" "+"单位:"+strZhanName+" "+"截止时间:"+strTime;

				}
				else
				{
					iCount=this.listView1.Items[0].SubItems.Count;
					iCount--;
					strTime=this.listView1.SelectedItems[0].SubItems[iCount].Text.Trim();
					string strName=this.listView1.SelectedItems[0].SubItems[0].Text.Trim();

					if(strTime.IndexOf("至")>=0)
					{
						string[] strsTime=strTime.Split('至');
						strTime=strsTime[1].Trim();
					}

					string strSql=string.Format("select wellName,cast(price as nvarchar(10)) price,salMony,salAmount,time,salPer,allSalAmount as allSalAmountAfter,(allSalAmount-salAmount) as allSalAmountBefore from tbWell,tbSal where tbSal.wellNo=tbWell.wellNo and wellname='{0}' and time<='{1}' order by time",strName,strTime);

					DataTable dtDetail=new DataTable();

					BengZhan.CDBConnection.getDataTable(ref dtDetail,strSql,"dt");
					this.addSum(ref dtDetail);

					this.paintList(this.listView3,3,dtDetail);

					this.groupBox3.Text=string.Format("售水明细表 监测站:{1} 截止时间:{0}",strTime,strName);
					//this.m_strTitle3="监测站："+strName;

				}

				this.showAmountDetail();

				this.groupBox3.Text=string.Format("售水明细表  截止时间:{0}",strTime);
				this.groupBox4.Text=string.Format("用水明细表  截止时间:{0}",strTime);

				//Console.WriteLine(this.groupBox3.Text);

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void listView4_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		private void listView4_DoubleClick(object sender, System.EventArgs e)
		{
//			Console.WriteLine("hello");
//			if(this.groupBox1.Visible)
//			{
//				this.groupBox1.Visible=false;
//				this.groupBox3.Visible=false;
//			}
//			else
//			{
//				this.groupBox1.Visible=true;
//				this.groupBox3.Visible=true;
//			}
			
		}

		private void groupBox1_Enter_2(object sender, System.EventArgs e)
		{
		
		}

		private void btnClose1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnPrint1_Click(object sender, System.EventArgs e)
		{
			this.btnPrint_Click(null,null);
		}

		private void groupBox5_Enter(object sender, System.EventArgs e)
		{
		
		}

		#region"售水明细"

		#endregion


		
		#endregion

		#region"阶梯水价新增加部分"

		private void addPrice(ref DataTable dt,bool bRemove)
		{
			try
			{
				frmMonthStacYear frmMST=new frmMonthStacYear();
				frmMST.addPriceForDetail(ref dt);
			}
			catch(Exception ex){MessageBox.Show(ex.ToString());}
		}
		private void addPriceForMonth(ref DataTable dt)
		{
			frmMonthStacYear frmMSY=new frmMonthStacYear();
			frmMSY.addPriceForMonth(ref dt);
		}
		/// <summary>
		/// bAddPrice 的意义是是否份二显示应用阶梯水价的站点
		/// </summary>
		/// <param name="dt"></param>
		/// <param name="bRemove"></param>
		/// <param name="bAddPrice"></param>
		private void addPrice(ref DataTable dt,bool bRemove,bool bAddPrice)
		{
			//frmMonthStacYear frmMSY=new frmMonthStacYear();
			//frmMSY.addPriceForSum(ref dt);		
		}

		private void paintTime()
		{
			try
			{
				if(this.listView1.Items.Count>0)
				{
				}
				else
				{
					return;
				}

				int iCount=this.listView1.Items[0].SubItems.Count;
				iCount--;

				string strText=this.groupBox1.Text.Trim();

				string strTime=strText.Substring(strText.IndexOf("截止时间")+5);

				for(int i=0;i<this.listView1.Items.Count;i++)
				{
					if(this.listView1.Items[i].SubItems[iCount].Text.Trim()=="")
					{
						this.listView1.Items[i].SubItems[iCount].Text=strTime;
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}

		
	}
		#endregion

		#region"其他工具函数"
		int m_iInterStance=-1;
		int m_iTooLong=-1;

		private int getTooLong()
		{
			try
			{
				if(this.m_iTooLong==-1)
				{
					XmlDocument xDoc=new XmlDocument();
					xDoc.Load("Info.xml");
					this.m_iTooLong=int.Parse(xDoc.DocumentElement.SelectSingleNode("./decTooLong").Attributes.GetNamedItem("val").Value.Trim());
				}

				return this.m_iTooLong;

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return 0;
			}
		}
		private int getInterInstance()
		{
			try
			{
				if(this.m_iInterStance==-1)
				{
					XmlDocument xDoc=new XmlDocument();
					xDoc.Load("Info.xml");
					this.m_iInterStance=int.Parse(xDoc.DocumentElement.SelectSingleNode("./interInstance").Attributes.GetNamedItem("val").Value.Trim());
				}
				return this.m_iInterStance;
			}
			catch{
				return 0;
			}
		}
		#endregion

		#region"明细表显示"

		private void dispSalDetail(string[] strName,string strTime)
		{
			try
			{
				DataTable dtDetail=new DataTable();

				for(int i=0;i<strName.Length;i++)
				{

					DataTable dtDetailTemp=new DataTable();

					string strSql=string.Format("select wellName,cast(price as nvarchar(10)) price,salMony,salAmount,time,salPer,allSalAmount as allSalAmountAfter,(allSalAmount-salAmount) as allSalAmountBefore from tbWell,tbSal where tbSal.wellNo=tbWell.wellNo and wellname='{0}' and time<='{1}' order by time",strName[i],strTime);			

					BengZhan.CDBConnection.getDataTable(ref dtDetailTemp,strSql,"dt");

					this.addSum(ref dtDetailTemp);

					BengZhan.comReport.CReports.copyDt(dtDetailTemp,ref dtDetail);
				}			
						 
				this.paintList(this.listView3,3,dtDetail);

				//this.groupBox3.Text=string.Format("售水明细表 监测站:{1} 截止时间:{0}",strTime,strName);

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
		}

		private void dispAmDetail(string[] strName,string strTime)
		{
			try
			{

				DataTable dtDetail=new DataTable();

				for(int i=0;i<strName.Length;i++)
				{
					DataTable dtDetailTemp=this.getAmDetail(strName[i],strTime);

					if(dtDetailTemp==null)
					{
					}
					else
					{
						BengZhan.comReport.CReports.copyDt(dtDetailTemp,ref dtDetail);
					}

				}

				this.paintList(this.listView4,5,dtDetail);	

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private DataTable getAmDetail(string strName,string strTime)
		{
			try
			{

				//显示站点	

				string strSql=string.Format("select time from tbMinTime");
				string strTime1=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();

				string strTime2=strTime;           

				DataTable dtDetail=new DataTable();

				strSql=string.Format("select wellNo from tbWell where wellName='{0}'",strName);

				string strZhanNo=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();		

				if(BengZhan.comReport.CReports.getDtDetailReportDay(strZhanNo,strTime1,strTime2,ref dtDetail)==false)
				{
					return null;
				}				

				if(dtDetail.Rows.Count<=1)
				{
					return null;
				}

				dtDetail.Columns.Add("leftAmountIC");
						
				return dtDetail;

				//this.paintList(this.listView4,5,dtDetail);		

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return null;
			}
		}



		#endregion

	}
}

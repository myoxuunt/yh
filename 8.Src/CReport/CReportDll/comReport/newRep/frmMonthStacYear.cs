using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;
using System.Data;

namespace CReportDll.comReport.newRep
{
	/// <summary>
	/// frmMonthStacYear 的摘要说明。
	/// </summary>
	public class frmMonthStacYear : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox30;
		private System.Windows.Forms.TreeView trvWel;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Button btnCer;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.LinkLabel lnkInfo;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.TextBox txtZhan;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ComboBox cmbYue2;
		private System.Windows.Forms.TextBox txtYearTo1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGrid dataGrid5;
		private System.Windows.Forms.DataGrid dataGrid4;
		private System.Windows.Forms.DataGrid dataGrid7;
		private System.Windows.Forms.DataGrid dataGrid6;
		private System.Windows.Forms.TextBox numFrom1;
		private System.Windows.Forms.TextBox numTo1;
		private CReportDll.comReport.newRep.cNumText txtYearFrom11;
		private System.Windows.Forms.ComboBox cmbYue1;
		private System.Windows.Forms.TextBox txtYearFrom1;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Splitter splitter3;
		private System.Windows.Forms.ListView listView3;
		private System.Windows.Forms.ListView listView4;
		private System.Windows.Forms.GroupBox groupBox13;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGrid dg1;
		private System.Windows.Forms.DataGrid dg2;
		private System.Windows.Forms.DataGrid dg3;
		private System.Windows.Forms.DataGrid dg4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox chkDep;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button button5;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmMonthStacYear()
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
			this.groupBox30 = new System.Windows.Forms.GroupBox();
			this.trvWel = new System.Windows.Forms.TreeView();
			this.groupBox10 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnCer = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
			this.lnkInfo = new System.Windows.Forms.LinkLabel();
			this.lblInfo = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.dg4 = new System.Windows.Forms.DataGrid();
			this.listView4 = new System.Windows.Forms.ListView();
			this.splitter3 = new System.Windows.Forms.Splitter();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dg3 = new System.Windows.Forms.DataGrid();
			this.listView3 = new System.Windows.Forms.ListView();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.dataGrid6 = new System.Windows.Forms.DataGrid();
			this.dataGrid7 = new System.Windows.Forms.DataGrid();
			this.dataGrid4 = new System.Windows.Forms.DataGrid();
			this.panel2 = new System.Windows.Forms.Panel();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dg2 = new System.Windows.Forms.DataGrid();
			this.listView2 = new System.Windows.Forms.ListView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dg1 = new System.Windows.Forms.DataGrid();
			this.dataGrid5 = new System.Windows.Forms.DataGrid();
			this.listView1 = new System.Windows.Forms.ListView();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.txtZhan = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.groupBox13 = new System.Windows.Forms.GroupBox();
			this.button5 = new System.Windows.Forms.Button();
			this.chkDep = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.numTo1 = new System.Windows.Forms.TextBox();
			this.numFrom1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbYue1 = new System.Windows.Forms.ComboBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.cmbYue2 = new System.Windows.Forms.ComboBox();
			this.txtYearTo1 = new System.Windows.Forms.TextBox();
			this.txtYearFrom1 = new System.Windows.Forms.TextBox();
			this.groupBox30.SuspendLayout();
			this.groupBox10.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg4)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid4)).BeginInit();
			this.panel2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg2)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid5)).BeginInit();
			this.groupBox6.SuspendLayout();
			this.groupBox13.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox30
			// 
			this.groupBox30.Controls.Add(this.trvWel);
			this.groupBox30.Location = new System.Drawing.Point(0, 50);
			this.groupBox30.Name = "groupBox30";
			this.groupBox30.Size = new System.Drawing.Size(176, 600);
			this.groupBox30.TabIndex = 37;
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
			// groupBox10
			// 
			this.groupBox10.Controls.Add(this.label3);
			this.groupBox10.Controls.Add(this.btnExit);
			this.groupBox10.Controls.Add(this.btnPrint);
			this.groupBox10.Controls.Add(this.btnCer);
			this.groupBox10.Controls.Add(this.label2);
			this.groupBox10.Controls.Add(this.label1);
			this.groupBox10.Location = new System.Drawing.Point(880, 2);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new System.Drawing.Size(8, 48);
			this.groupBox10.TabIndex = 38;
			this.groupBox10.TabStop = false;
			this.groupBox10.Visible = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(432, 32);
			this.label3.Name = "label3";
			this.label3.TabIndex = 11;
			this.label3.Text = "label3";
			this.label3.Visible = false;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(272, 16);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(58, 23);
			this.btnExit.TabIndex = 10;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(212, 16);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(58, 23);
			this.btnPrint.TabIndex = 9;
			this.btnPrint.Text = "打印";
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// btnCer
			// 
			this.btnCer.Location = new System.Drawing.Point(152, 16);
			this.btnCer.Name = "btnCer";
			this.btnCer.Size = new System.Drawing.Size(58, 23);
			this.btnCer.TabIndex = 8;
			this.btnCer.Text = "确认";
			this.btnCer.Click += new System.EventHandler(this.btnCer_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(128, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "年";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "年份：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// lnkInfo
			// 
			this.lnkInfo.Location = new System.Drawing.Point(832, 7);
			this.lnkInfo.Name = "lnkInfo";
			this.lnkInfo.Size = new System.Drawing.Size(176, 40);
			this.lnkInfo.TabIndex = 41;
			this.lnkInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lnkInfo.Visible = false;
			// 
			// lblInfo
			// 
			this.lblInfo.Location = new System.Drawing.Point(832, 7);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(176, 40);
			this.lblInfo.TabIndex = 40;
			this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox4);
			this.panel1.Controls.Add(this.splitter3);
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Controls.Add(this.splitter2);
			this.panel1.Controls.Add(this.dataGrid6);
			this.panel1.Controls.Add(this.dataGrid7);
			this.panel1.Controls.Add(this.dataGrid4);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(176, 55);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(840, 595);
			this.panel1.TabIndex = 39;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.dg4);
			this.groupBox4.Controls.Add(this.listView4);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox4.Location = new System.Drawing.Point(386, 291);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(454, 304);
			this.groupBox4.TabIndex = 7;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "用水明细";
			// 
			// dg4
			// 
			this.dg4.DataMember = "";
			this.dg4.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dg4.Location = new System.Drawing.Point(48, 72);
			this.dg4.Name = "dg4";
			this.dg4.TabIndex = 1;
			this.dg4.Visible = false;
			// 
			// listView4
			// 
			this.listView4.BackColor = System.Drawing.SystemColors.Info;
			this.listView4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView4.Font = new System.Drawing.Font("宋体", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.listView4.FullRowSelect = true;
			this.listView4.GridLines = true;
			this.listView4.Location = new System.Drawing.Point(3, 17);
			this.listView4.Name = "listView4";
			this.listView4.Size = new System.Drawing.Size(448, 284);
			this.listView4.TabIndex = 0;
			this.listView4.View = System.Windows.Forms.View.Details;
			this.listView4.SelectedIndexChanged += new System.EventHandler(this.listView4_SelectedIndexChanged);
			// 
			// splitter3
			// 
			this.splitter3.Location = new System.Drawing.Point(384, 291);
			this.splitter3.Name = "splitter3";
			this.splitter3.Size = new System.Drawing.Size(2, 304);
			this.splitter3.TabIndex = 6;
			this.splitter3.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dg3);
			this.groupBox3.Controls.Add(this.listView3);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox3.Location = new System.Drawing.Point(0, 291);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(384, 304);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "售水明细";
			// 
			// dg3
			// 
			this.dg3.DataMember = "";
			this.dg3.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dg3.Location = new System.Drawing.Point(168, 64);
			this.dg3.Name = "dg3";
			this.dg3.TabIndex = 1;
			this.dg3.Visible = false;
			// 
			// listView3
			// 
			this.listView3.BackColor = System.Drawing.SystemColors.Info;
			this.listView3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView3.Font = new System.Drawing.Font("宋体", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.listView3.GridLines = true;
			this.listView3.Location = new System.Drawing.Point(3, 17);
			this.listView3.Name = "listView3";
			this.listView3.Size = new System.Drawing.Size(378, 284);
			this.listView3.TabIndex = 0;
			this.listView3.View = System.Windows.Forms.View.Details;
			// 
			// splitter2
			// 
			this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter2.Location = new System.Drawing.Point(0, 288);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(840, 3);
			this.splitter2.TabIndex = 4;
			this.splitter2.TabStop = false;
			// 
			// dataGrid6
			// 
			this.dataGrid6.DataMember = "";
			this.dataGrid6.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid6.Location = new System.Drawing.Point(64, 320);
			this.dataGrid6.Name = "dataGrid6";
			this.dataGrid6.TabIndex = 3;
			this.dataGrid6.Visible = false;
			// 
			// dataGrid7
			// 
			this.dataGrid7.DataMember = "";
			this.dataGrid7.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid7.Location = new System.Drawing.Point(112, 368);
			this.dataGrid7.Name = "dataGrid7";
			this.dataGrid7.TabIndex = 2;
			this.dataGrid7.Visible = false;
			// 
			// dataGrid4
			// 
			this.dataGrid4.DataMember = "";
			this.dataGrid4.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid4.Location = new System.Drawing.Point(224, 336);
			this.dataGrid4.Name = "dataGrid4";
			this.dataGrid4.TabIndex = 1;
			this.dataGrid4.Visible = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.splitter1);
			this.panel2.Controls.Add(this.groupBox2);
			this.panel2.Controls.Add(this.groupBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(840, 288);
			this.panel2.TabIndex = 0;
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(384, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(2, 288);
			this.splitter1.TabIndex = 2;
			this.splitter1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dg2);
			this.groupBox2.Controls.Add(this.listView2);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(384, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(456, 288);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "用水月结";
			// 
			// dg2
			// 
			this.dg2.DataMember = "";
			this.dg2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dg2.Location = new System.Drawing.Point(48, 112);
			this.dg2.Name = "dg2";
			this.dg2.TabIndex = 1;
			this.dg2.Visible = false;
			// 
			// listView2
			// 
			this.listView2.BackColor = System.Drawing.SystemColors.Info;
			this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView2.Font = new System.Drawing.Font("宋体", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.listView2.FullRowSelect = true;
			this.listView2.GridLines = true;
			this.listView2.Location = new System.Drawing.Point(3, 17);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(450, 268);
			this.listView2.TabIndex = 0;
			this.listView2.View = System.Windows.Forms.View.Details;
			this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGrid1);
			this.groupBox1.Controls.Add(this.dg1);
			this.groupBox1.Controls.Add(this.dataGrid5);
			this.groupBox1.Controls.Add(this.listView1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(384, 288);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "售水月结";
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 16);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(416, 256);
			this.dataGrid1.TabIndex = 4;
			this.dataGrid1.Visible = false;
			// 
			// dg1
			// 
			this.dg1.DataMember = "";
			this.dg1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dg1.Location = new System.Drawing.Point(120, 120);
			this.dg1.Name = "dg1";
			this.dg1.TabIndex = 2;
			this.dg1.Visible = false;
			// 
			// dataGrid5
			// 
			this.dataGrid5.DataMember = "";
			this.dataGrid5.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid5.Location = new System.Drawing.Point(80, 192);
			this.dataGrid5.Name = "dataGrid5";
			this.dataGrid5.TabIndex = 1;
			this.dataGrid5.Visible = false;
			// 
			// listView1
			// 
			this.listView1.BackColor = System.Drawing.SystemColors.Info;
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.Font = new System.Drawing.Font("宋体", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(3, 17);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(378, 268);
			this.listView1.TabIndex = 0;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.txtZhan);
			this.groupBox6.Controls.Add(this.lblName);
			this.groupBox6.Location = new System.Drawing.Point(0, 2);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(176, 48);
			this.groupBox6.TabIndex = 36;
			this.groupBox6.TabStop = false;
			// 
			// txtZhan
			// 
			this.txtZhan.BackColor = System.Drawing.SystemColors.ControlLightLight;
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
			// groupBox13
			// 
			this.groupBox13.Controls.Add(this.button5);
			this.groupBox13.Controls.Add(this.chkDep);
			this.groupBox13.Controls.Add(this.label4);
			this.groupBox13.Controls.Add(this.numTo1);
			this.groupBox13.Controls.Add(this.numFrom1);
			this.groupBox13.Controls.Add(this.label6);
			this.groupBox13.Controls.Add(this.label5);
			this.groupBox13.Controls.Add(this.cmbYue1);
			this.groupBox13.Controls.Add(this.button4);
			this.groupBox13.Controls.Add(this.button1);
			this.groupBox13.Controls.Add(this.button2);
			this.groupBox13.Controls.Add(this.button3);
			this.groupBox13.Controls.Add(this.cmbYue2);
			this.groupBox13.Controls.Add(this.txtYearTo1);
			this.groupBox13.Controls.Add(this.txtYearFrom1);
			this.groupBox13.Location = new System.Drawing.Point(176, 2);
			this.groupBox13.Name = "groupBox13";
			this.groupBox13.Size = new System.Drawing.Size(752, 48);
			this.groupBox13.TabIndex = 42;
			this.groupBox13.TabStop = false;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(648, 16);
			this.button5.Name = "button5";
			this.button5.TabIndex = 20;
			this.button5.Text = "button5";
			this.button5.Visible = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// chkDep
			// 
			this.chkDep.Location = new System.Drawing.Point(304, 16);
			this.chkDep.Name = "chkDep";
			this.chkDep.Size = new System.Drawing.Size(112, 24);
			this.chkDep.TabIndex = 19;
			this.chkDep.Text = "只显示单位信息";
			this.chkDep.CheckedChanged += new System.EventHandler(this.chkDep_CheckedChanged);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(144, 17);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(16, 23);
			this.label4.TabIndex = 18;
			this.label4.Text = "至";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numTo1
			// 
			this.numTo1.Location = new System.Drawing.Point(568, 16);
			this.numTo1.Name = "numTo1";
			this.numTo1.Size = new System.Drawing.Size(8, 21);
			this.numTo1.TabIndex = 17;
			this.numTo1.Text = "";
			this.numTo1.Visible = false;
			this.numTo1.TextChanged += new System.EventHandler(this.numTo1_TextChanged);
			// 
			// numFrom1
			// 
			this.numFrom1.Location = new System.Drawing.Point(560, 17);
			this.numFrom1.Name = "numFrom1";
			this.numFrom1.Size = new System.Drawing.Size(8, 21);
			this.numFrom1.TabIndex = 16;
			this.numFrom1.Text = "";
			this.numFrom1.Visible = false;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(216, 15);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(16, 23);
			this.label6.TabIndex = 15;
			this.label6.Text = "年";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(64, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(16, 23);
			this.label5.TabIndex = 14;
			this.label5.Text = "年";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label5.Visible = false;
			// 
			// cmbYue1
			// 
			this.cmbYue1.Location = new System.Drawing.Point(80, 16);
			this.cmbYue1.Name = "cmbYue1";
			this.cmbYue1.Size = new System.Drawing.Size(64, 20);
			this.cmbYue1.TabIndex = 13;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(488, 16);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(48, 23);
			this.button4.TabIndex = 11;
			this.button4.Text = "年结";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(600, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(52, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "退出";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(544, 16);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(52, 23);
			this.button2.TabIndex = 9;
			this.button2.Text = "打印";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(432, 16);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(52, 23);
			this.button3.TabIndex = 8;
			this.button3.Text = "月结";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// cmbYue2
			// 
			this.cmbYue2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.cmbYue2.Location = new System.Drawing.Point(232, 16);
			this.cmbYue2.Name = "cmbYue2";
			this.cmbYue2.Size = new System.Drawing.Size(56, 20);
			this.cmbYue2.TabIndex = 7;
			// 
			// txtYearTo1
			// 
			this.txtYearTo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtYearTo1.Location = new System.Drawing.Point(168, 16);
			this.txtYearTo1.Name = "txtYearTo1";
			this.txtYearTo1.Size = new System.Drawing.Size(48, 21);
			this.txtYearTo1.TabIndex = 5;
			this.txtYearTo1.Text = "";
			// 
			// txtYearFrom1
			// 
			this.txtYearFrom1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtYearFrom1.Location = new System.Drawing.Point(16, 16);
			this.txtYearFrom1.Name = "txtYearFrom1";
			this.txtYearFrom1.Size = new System.Drawing.Size(48, 21);
			this.txtYearFrom1.TabIndex = 1;
			this.txtYearFrom1.Text = "";
			// 
			// frmMonthStacYear
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(1016, 652);
			this.Controls.Add(this.groupBox13);
			this.Controls.Add(this.groupBox10);
			this.Controls.Add(this.lnkInfo);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox30);
			this.Name = "frmMonthStacYear";
			this.Text = "月结统计表";
			this.Load += new System.EventHandler(this.frmMonthStacYear_Load);
			this.groupBox30.ResumeLayout(false);
			this.groupBox10.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dg4)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dg3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid4)).EndInit();
			this.panel2.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dg2)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid5)).EndInit();
			this.groupBox6.ResumeLayout(false);
			this.groupBox13.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void groupBox3_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void iniFrm()
		{

			this.cmbYue2.Items.Clear();
			this.cmbYue1.Items.Clear();

			DateTime dt=System.DateTime.Now ;
			dt=dt.AddMonths(-1);
			this.txtYearFrom1.Text=dt.Year.ToString();
			this.txtYearTo1.Text=dt.Year.ToString();
			this.cmbYue1.Text=dt.Month.ToString()+"月";
			this.cmbYue2.Text=dt.Month.ToString()+"月";
			for(int i=1;i<=12;i++)
			{
				string strYue=i.ToString()+"月";
				this.cmbYue2.Items.Add(strYue);
				this.cmbYue1.Items.Add(strYue);
			}

		}

		private void frmMonthStacYear_Load(object sender, System.EventArgs e)
		{
			this.txtYearFrom1.Text=System.DateTime.Now.Year.ToString();
			BengZhan.tools.CPaintForm.paintWell("",this.trvWel);
			this.iniListV(this.listView1,"3");
			this.iniListV(this.listView2,"5");
			this.iniListV(this.listView3,"3");
			this.iniListV(this.listView4,"5");
			this.trvWel.SelectedNode=this.trvWel.Nodes[0];
			this.iniFrm();
			//this.label3.Text=this.groupBox1.Text;
			//this.label4.Text=this.groupBox2.Text;
		}

		private XmlDocument m_xDocLsv;

		private void iniListV(System.Windows.Forms.ListView lsv,string iDex)
		{
			try
			{
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("iniLsv.xml");

				this.m_xDocLsv=xDoc;

				XmlNode xNode=xDoc.DocumentElement.SelectSingleNode(string.Format("./lsv[@id='{0}']",iDex.ToString()));

				for(int i=0;i<xNode.ChildNodes.Count;i++)
				{
					string strText=xNode.ChildNodes[i].Attributes.GetNamedItem("text").Value.Trim();
					double dWidth=double.Parse(xNode.ChildNodes[i].Attributes.GetNamedItem("width").Value.Trim());
			
					if(i==(xNode.ChildNodes.Count-2))
					{
						//dWidth=0;
					}
						
					string strWidth=dWidth.ToString();
					lsv.Columns.Add(strText,int.Parse(strWidth),System.Windows.Forms.HorizontalAlignment.Left);
				}
					
				if(iDex=="2")
				{
					if(this.m_dtAllSa==null)
					{
						this.m_dtAllSa=new DataTable();
						for(int i=0;i<xNode.ChildNodes.Count;i++)						
						{
							this.m_dtAllSa.Columns.Add(xNode.ChildNodes[i].Attributes.GetNamedItem("field").Value.Trim());
						}

					}
					//this.groupBox2.Text=xNode.Attributes.GetNamedItem("Title").Value.Trim();
				}


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
					

						string strTimeSa=dtSa.Rows[i]["time"].ToString();
						string strTimeAm=strTime;

						if(strTimeSa.Trim()==strTimeAm.Trim())
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
						dr["allAmount"]="0";
						dr["wellName"]=dtSa.Rows[0]["wellName"].ToString();

						string strSql=string.Format("select price1 from tbWell where wellName='{0}'",dr["wellName"].ToString().Trim());
						string strPrice=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();

						dr["allUsedMony"]=double.Parse(dr["allAmount"].ToString())*double.Parse(strPrice);				

						//					if(dtAm.Rows[i]["time"].ToString().IndexOf(":")<0)
						//					{
						//						dtAm.Rows[i]["time"]=dtAm.Rows[i]["time"].ToString().Replace("-","年");
						//						//dtAm.Rows[i]["time"]=dtAm.Rows[i]["time"].ToString()+"月";
						//					}
					
						//	DateTime dtime=DateTime.Parse(dtAm.Rows[i]["time"].ToString());				

						//	dr["time"]=string.Format("{0}-{1}-{2} 0:00 至 {3}-{4}-{5} 0:00",dtime.Year.ToString(),dtime.Month.ToString(),"1",dtime.Year.ToString(),Convert.ToString(dtime.Month+1),"1");

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
						
						dr["time"]=strTime;

						dt.Rows.Add(dr);
						return true;

					}
				}

				for(int i=0;i<dtAm.Rows.Count;i++)
				{
					DataRow dr=dt.NewRow();
					dr["allAmount"]=dtAm.Rows[i]["allAmount"].ToString();
					dr["wellName"]=dtAm.Rows[i]["wellName"].ToString();

					string strSql=string.Format("select price1 from tbWell where wellName='{0}'",dr["wellName"].ToString().Trim());
					string strPrice=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();

					dr["allUsedMony"]=double.Parse(dr["allAmount"].ToString())*double.Parse(strPrice);				

//					if(dtAm.Rows[i]["time"].ToString().IndexOf(":")<0)
//					{
//						dtAm.Rows[i]["time"]=dtAm.Rows[i]["time"].ToString().Replace("-","年");
//						//dtAm.Rows[i]["time"]=dtAm.Rows[i]["time"].ToString()+"月";
//					}
					
				//	DateTime dtime=DateTime.Parse(dtAm.Rows[i]["time"].ToString());				

				//	dr["time"]=string.Format("{0}-{1}-{2} 0:00 至 {3}-{4}-{5} 0:00",dtime.Year.ToString(),dtime.Month.ToString(),"1",dtime.Year.ToString(),Convert.ToString(dtime.Month+1),"1");

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

					dr["time"]=strTime;

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

		//监测站月统计
		private void monthStaticRep1(ref DataTable dt1)
		{
			try
			{
				if(this.txtYearFrom1.Text.Trim().Length!=4)
				{
					MessageBox.Show("查询起始年份输入有误，其长度应为4位！");
					return;
				}

				string strZhanName=this.txtZhan.Text.Trim();
				string strSql=string.Format("select wellNo from tbWell where wellName='{0}'",strZhanName);	
				
					string strZhanNo=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();	
			DataTable	dtAvg=new DataTable();

					if(CReportDll.comReport.CSalReport.getDtAvgReportYear(strZhanNo,this.txtYearFrom1.Text.Trim(),ref dtAvg)==false)
					{
						return;
					}

					DataTable dtAvg1=new DataTable();
					if(BengZhan.comReport.CReports.getDtYearAvgReport(strZhanNo,this.txtYearFrom1.Text.Trim(),ref dtAvg1)==false)
					{
						return;
					}		

				
					DataTable dtNew=new DataTable();				
					if(this.mergeDt(dtAvg,dtAvg1,ref dtNew)==false)
					{
						return;
					}
					 dt1=dtNew;
			//	DataTable dt=(DataTable)this.dataGrid5.DataSource;	
			
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

			//	dt1=dtAvgEx;


			//	strFrom=string.Format("{0}-{1}-1 0:00",dtFrom.Year.ToString(),dtFrom.Month.ToString());					
			//	strTo=string.Format("{0}-{1}-1 0:00",dtTo.AddMonths(1).Year.ToString(),Convert.ToString(dtTo.AddMonths(1).Month));//3

			//	dtTo=DateTime.Parse(strTo);
			//	dtTo=dtTo.AddDays(-1);

			//	strTo=string.Format("{0}-{1}-{2} 23:00",dtTo.Year.ToString(),dtTo.Month.ToString(),dtTo.Day.ToString());
		
			//	string strCapText=string.Format("监测站：{0}    时间范围：{1}至{2}    本月用水统计表",strZhanName,strFrom,strTo);
			//	this.dataGrid5.CaptionText=strCapText;

			//	strCapText=string.Format("本月用水统计表  时间范围：{0}至{1}",strFrom,strTo);

			//	this.groupBox1.Text=strCapText;

			//	this.m_strDtFrom=strFrom;
			//	this.m_strDtTo=strTo;
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}



		private bool getColName(string iDex,string strColText,ref string strColName)
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
		private void paintList(System.Windows.Forms.ListView lsv,string iDex,DataTable dtZhan)
		{
			try
			{

				if(lsv!=this.listView4)
				{
					
						this.addPriceForMonth(ref dtZhan);
								
				}
				else
				{
					this.addPriceForDetail(ref dtZhan);
				}

				cDealReport.replace2Str(ref dtZhan);

				lsv.Items.Clear();

				if(dtZhan==null)
				{
					return;
				}

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
								lsv.Items[i].UseItemStyleForSubItems=false;
								lsv.Items[i].SubItems[j].ForeColor=Color.Red;								
							}	
							else
							{
								lsv.Items[i].SubItems.Add(this.getFormatValue(dtZhan.Rows[i][strField].ToString().Trim()));							
							}
						}
					}				
				}

				//this.paintColor();
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}
		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void clearLsv()
		{
			this.listView1.Items.Clear();
			this.listView2.Items.Clear();
			this.listView3.Items.Clear();
			this.listView4.Items.Clear();
			this.groupBox1.Text="售水月结统计表";
			this.groupBox2.Text="用水月结统计表";
			this.groupBox3.Text="售水明细表";
			this.groupBox4.Text="用水明细表";
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
					if((dt.Columns[j].ColumnName!="time")&&(j!=0&&(dt.Columns[j].ColumnName!="time1")&&(dt.Columns[j].ColumnName!="salPer")))
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


		private void btnCer_Click(object sender, System.EventArgs e)
		{
		
			if(this.txtYearFrom1.Text.Trim().Length!=4)			
			{
				MessageBox.Show("年份输入有误！");
				return;
			}

			string strYear=this.txtYearFrom1.Text.Trim();

		this.clearLsv();
	this.Cursor=Cursors.WaitCursor;

			if(this.lblName.Text.IndexOf("站点")>=0)
			{
				//监测站统计
				this.disPZhan(this.listView1);
			}

			if(this.lblName.Text.IndexOf("单位")>=0)
			{
				this.disPDepYear();
			}
			if(this.lblName.Text.IndexOf("乡镇")>=0)
			{
				this.disPCountryYear();
			}
			this.Cursor=Cursors.Default;

			this.paintColor();

			this.Cursor=Cursors.Default;

			if((!cDealReport.bAllNum(this.txtYearTo1.Text))||(this.txtYearTo1.Text.Trim().Length!=4))
			{
				MessageBox.Show("统计年份填写有误!");
				return;
			}

			this.groupBox1.Text=string.Format("年度售水统计表  统计年份:{0}",this.txtYearTo1.Text);
			this.groupBox2.Text=string.Format("年度用水统计表  统计年份:{0}",this.txtYearTo1.Text);

			
	}	
		private void monthStaticRepDepYear(ref DataTable dtSa,ref DataTable dtAm)
		{
			try
			{
				if(this.txtYearFrom1.Text.Trim().Length!=4)
				{
					MessageBox.Show("查询起始年份输入有误，其长度应为4位！");
					return;
				}			

				string strSql=string.Format("select depShortName from tbDep where CountryName='{0}'",this.txtZhan.Text.Trim());
				DataTable dtDep=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtDep,strSql,"dtDep");			

					string strDepName=this.txtZhan.Text.Trim();		
		
					strSql=string.Format("select wellNo from tbWell where depName='{0}'",strDepName);

					DataTable dtWell=new DataTable();
					BengZhan.CDBConnection.getDataTable(ref dtWell,strSql,"dtDep");	
					
					///	DataTable dtAvgEx=new DataTable();
					DataTable dtSa1=new DataTable();
					DataTable dtAm1=new DataTable();

					for(int y=0;y<dtWell.Rows.Count;y++)
					{
						string strZhanNo=dtWell.Rows[y]["wellNo"].ToString().Trim();
						DataTable dtSa2=new DataTable();
						DataTable dtAm2=new DataTable();

						if(CReportDll.comReport.CSalReport.getDtAvgReportYear(strZhanNo,this.txtYearFrom1.Text.Trim(),ref dtSa2)==false)
						{
							return;
						}

						if(BengZhan.comReport.CReports.getDtYearAvgReport(strZhanNo,this.txtYearFrom1.Text.Trim(),ref dtAm2)==false)
						{
							return;
						}				
						//							DataTable dtNew=new DataTable();
						//				
						//							if(this.mergeDt(dtAvg,dtAvg1,ref dtNew)==false)
						//							{
						//								return;
						//							}

						BengZhan.comReport.CReports.copyDt(dtSa2,ref dtSa1);	
						BengZhan.comReport.CReports.copyDt(dtAm2,ref dtAm1);	
								

					}	
		
					cDealReport cdr=new cDealReport();

					cdr.addSum(ref dtSa1,-1,strDepName);
					cDealReport.changeDataType(ref dtSa1);
					cDealReport.clearTime(ref dtSa1,true);
					cdr.addTime(ref dtSa1,true);
					
					cdr.addSum(ref dtAm1,-1,strDepName);
					cDealReport.changeDataType(ref dtAm1);
					cDealReport.clearTime(ref dtAm1,true);
					cdr.addTime(ref dtAm1,true);

					BengZhan.comReport.CReports.copyDt(dtSa1,ref dtSa);
					BengZhan.comReport.CReports.copyDt(dtAm1,ref dtAm);			

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}
		private void monthStaticRepCountryYear(ref DataTable dtSa,ref DataTable dtAm)
		{
			try
			{
				if(this.txtYearFrom1.Text.Trim().Length!=4)
				{
					MessageBox.Show("查询起始年份输入有误，其长度应为4位！");
					return;
				}			

				string strSql=string.Format("select depShortName from tbDep where CountryName='{0}'",this.txtZhan.Text.Trim());
				DataTable dtDep=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtDep,strSql,"dtDep");

			
				for(int i=0;i<dtDep.Rows.Count;i++)
				{

					string strDepName=dtDep.Rows[i]["depShortName"].ToString().Trim();		
		
						strSql=string.Format("select wellNo from tbWell where depName='{0}'",strDepName);

						DataTable dtWell=new DataTable();
						BengZhan.CDBConnection.getDataTable(ref dtWell,strSql,"dtDep");	
					
					///	DataTable dtAvgEx=new DataTable();
					DataTable dtSa1=new DataTable();
					DataTable dtAm1=new DataTable();

						for(int y=0;y<dtWell.Rows.Count;y++)
						{
							string strZhanNo=dtWell.Rows[y]["wellNo"].ToString().Trim();
							DataTable dtSa2=new DataTable();
							DataTable dtAm2=new DataTable();

							if(CReportDll.comReport.CSalReport.getDtAvgReportYear(strZhanNo,this.txtYearFrom1.Text.Trim(),ref dtSa2)==false)
							{
							return;
							}

							if(BengZhan.comReport.CReports.getDtYearAvgReport(strZhanNo,this.txtYearFrom1.Text.Trim(),ref dtAm2)==false)
							{
								return;
							}				
//							DataTable dtNew=new DataTable();
//				
//							if(this.mergeDt(dtAvg,dtAvg1,ref dtNew)==false)
//							{
//								return;
//							}

							BengZhan.comReport.CReports.copyDt(dtSa2,ref dtSa1);	
BengZhan.comReport.CReports.copyDt(dtAm2,ref dtAm1);	
								

						}	
		
					cDealReport cdr=new cDealReport();

					cdr.addSum(ref dtSa1,-1,strDepName);
					cDealReport.changeDataType(ref dtSa1);
					cDealReport.clearTime(ref dtSa1,true);
					cdr.addTime(ref dtSa1,true);
					
					cdr.addSum(ref dtAm1,-1,strDepName);
					cDealReport.changeDataType(ref dtAm1);
					cDealReport.clearTime(ref dtAm1,true);
					cdr.addTime(ref dtAm1,true);

					BengZhan.comReport.CReports.copyDt(dtSa1,ref dtSa);
					BengZhan.comReport.CReports.copyDt(dtAm1,ref dtAm);

		
					//		BengZhan.comReport.			
				}			

			//	dtAvg=dtRet;

			//	DataTable dt=(DataTable)this.dataGrid5.DataSource;	
			
			//	dt.Rows.Clear();					
		
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

			//	dtTo=dtFrom.AddMonths(iIns);

				
//				string strFromEx=string.Format("{0}-{1}-1 8:00",dtFrom.Year.ToString(),dtFrom.Month.ToString());				
//				string strToEx=string.Format("{0}-{1}-1 8:00",dtTo.AddMonths(1).Year.ToString(),Convert.ToString(dtTo.AddMonths(1).Month));
//				
//				string strCapText=string.Format("乡镇：{0}    {1}至{2}    本月用水统计表",this.txtZhan.Text.Trim(),strFromEx,strToEx);
//				
//				//this.dataGrid5.CaptionText=strCapText;
//				//this.m_strDtFrom=strFromEx;
//				//this.m_strDtTo=strToEx;
				//dtTo=dtRet;

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
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

		private void txtYearFrom1_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void trvWel_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
		this.paintSelectedWell();
		}

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
		private bool fillDgFrmLsv(System.Windows.Forms.ListView lsv,System.Windows.Forms.DataGrid dg,string  iDex)
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



				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
			
		}

		private void iniTitle(frmPrint frmPr)
		{
			try
			{
				this.dg1.CaptionText=this.groupBox1.Text;
				this.dg2.CaptionText=this.groupBox2.Text;
				this.dg3.CaptionText=this.groupBox3.Text;
				this.dg4.CaptionText=this.groupBox4.Text;


				string strTitle=this.groupBox1.Text+" ";
				strTitle=strTitle.Substring(0, strTitle.IndexOf(" "));
			frmPr.m_strTitle1=strTitle;

				strTitle=this.groupBox2.Text+" ";
				strTitle=strTitle.Substring(0,strTitle.IndexOf(" "));
				frmPr.m_strTitle2=strTitle;

				strTitle=this.groupBox3.Text+" ";
				strTitle=strTitle.Substring(0,strTitle.IndexOf(" "));
				frmPr.m_strTitle3=strTitle;

				strTitle=this.groupBox4.Text+" ";
				strTitle=strTitle.Substring(0,strTitle.IndexOf(" "));
				frmPr.m_strTitle4=strTitle;




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
				if((this.listView1.Items.Count==0)&&(this.listView2.Items.Count==0)&&(this.listView3.Items.Count==0)&&(this.listView4.Items.Count==0))
				{
					MessageBox.Show("没有可打印的数据！");
					return;
				}

				this.Cursor=Cursors.WaitCursor;

				//this.iniGrid("salRep.xml",this.dg1,"tb3");
				this.iniGrid("salRep.xml",this.dg1,"tb11");
				this.iniGrid("salRep.xml",this.dg2,"tbDa");
				this.iniGrid("salRep.xml",this.dg3,"tb11");
				this.iniGrid("salRep.xml",this.dg4,"tbDa");			

				this.fillDgFrmLsv(this.listView1,this.dg1,"3");
				this.fillDgFrmLsv(this.listView2,this.dg2,"5");
				this.fillDgFrmLsv(this.listView3,this.dg3,"3");
				this.fillDgFrmLsv(this.listView4,this.dg4,"5");

			//	this.fillDgFrmLsv(this.listView4,this.dg3,5);
						

				frmPrint frmPr=new frmPrint();
				this.iniTitle( frmPr);

				frmPr.dataGrid2=this.dg1;
				frmPr.dataGrid3=this.dg2;
				frmPr.dataGrid4=this.dg3;
				frmPr.dataGrid5=this.dg4;
				//frmPr.dataGrid4=this.dg3;				

				this.Cursor=Cursors.Default;
				frmPr.bAllBLand=false;

				frmPr.ShowDialog();			

				this.Cursor=Cursors.Default;

				
			}
			catch(Exception ex)
			{
				this.Cursor=Cursors.Default;

				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}
		private void showSalDetail(string strDepName,string  strTimeS)
		{
			try
			{
				//string strSql=string.Format("select wellName from tbWell where depName='{0}' order by wellNo",strDepName);
				//DataTable dtWells=new DataTable();
				//BengZhan.CDBConnection.getDataTable(ref dtWells,strSql,"dtW");

				string strSql=string.Format("select distinct month(time) mon,year(time) yea from tbSal,tbWell where tbSal.wellNo=tbSal.wellNo and  depName='{0}' and year(time)='{1}'",strDepName,strTimeS);
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
						 
				this.paintList(this.listView2,"3",dtRep);
				//
				//this.groupBox3.Text=string.Format("售水明细表  截止时间:{0}",strTimeS);

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
			
		}
		private string sumColEx(DataTable dt,int iCol)
		{
			try
			{
				double iSum=0;
				for(int i=0;i<dt.Rows.Count;i++)
				{
					if(dt.Rows[i][0].ToString().Trim().IndexOf("合计")>=0)
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

		private void addSumEx(ref DataTable dtAvgEx,string strCountryName)
		{
			try
			{
				if(dtAvgEx==null)
				{
					return;
				}
//				if()
//				{
//				}
				DataRow dr=dtAvgEx.NewRow();
				bool bHave=false;

				for(int i=0;i<dtAvgEx.Columns.Count;i++)
				{
					if(dtAvgEx.Columns[i].ColumnName.Trim()=="usedMony")
					{
						//Console.WriteLine(dtAvgEx.Columns[i].ToString());
					}
				

					if((i!=0)&&((i!=(dtAvgEx.Columns.Count-1))||(dtAvgEx.Columns[i].ColumnName.Trim()=="usedMony"))&&(dtAvgEx.Columns[i].ColumnName!="time")&&(dtAvgEx.Columns[i].ColumnName!="salPer")&&(dtAvgEx.Columns[i].ColumnName!="price")&&(dtAvgEx.Columns[i].ColumnName!="allSalAmountBefore")&&(dtAvgEx.Columns[i].ColumnName!="allSalAmountAfter"))
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
						dr[0]=strCountryName+"总计";
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
		
		private void addSumEx(ref DataTable dtAvgEx)
		{
			try
			{
				DataRow dr=dtAvgEx.NewRow();
				bool bHave=false;

				for(int i=0;i<dtAvgEx.Columns.Count;i++)
				{
					if(dtAvgEx.Columns[i].ColumnName.Trim()=="usedMony")
					{
							//Console.WriteLine(dtAvgEx.Columns[i].ToString());
					}
				

					if((i!=0)&&((i!=(dtAvgEx.Columns.Count-1))||(dtAvgEx.Columns[i].ColumnName.Trim()=="usedMony"))&&(dtAvgEx.Columns[i].ColumnName!="time")&&(dtAvgEx.Columns[i].ColumnName!="salPer")&&(dtAvgEx.Columns[i].ColumnName!="price")&&(dtAvgEx.Columns[i].ColumnName!="allSalAmountBefore")&&(dtAvgEx.Columns[i].ColumnName!="allSalAmountAfter"))
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
		
		private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
				this.listView2.Items.Clear();		


				if(this.listView1.SelectedItems.Count==0)
				{
					return;
				}

				if(this.listView1.SelectedItems[0].SubItems[7].Text.Trim()!="")
				{
					this.txtYearFrom1.Text=this.listView1.SelectedItems[0].SubItems[7].Text.Trim().Substring(0,4);
				}
				else
				{
					this.txtYearFrom1.Text=this.listView1.Items[0].SubItems[7].Text.Trim().Substring(0,4);
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
					this.showDepRep(strDepName,this.txtYearFrom1.Text.Trim());
					
					//this.m_strTitle3="单位："+strDepName;
                    			
				}
				else
				{
					string strZhanName=this.listView1.SelectedItems[0].Text.Trim();
					string strTimeS=this.listView1.SelectedItems[0].SubItems[7].Text.Trim();
					this.showZhanRep(strZhanName,this.txtYearFrom1.Text.Trim());
					//this.m_strTitle3="监测站："+strZhanName;
				}
				this.paintColor();

				string strEnd="";

				if(this.txtYearFrom1.Text.Trim()==System.DateTime.Now.Year.ToString())
				{
					strEnd=System.DateTime.Now.ToString();
				}
				else
				{
					strEnd=string.Format("{0}-12-31 23:00",this.txtYearFrom1.Text.Trim());
				}

				//this.groupBox2.Text=this.label4.Text+" "+this.lblName.Text.Trim()+this.txtZhan.Text+"  "+"截止时间:"+strEnd;


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
				this.showSalDetail(strDepName,strTimeS);									 
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}


		//显示控制器历史记录
		private void showZhanRep(string strZhanName,string strTimeS)
		{
			try
			{
				string strWellName=strZhanName;
				string strTime=strTimeS;

				if(strTime.Trim()=="")
				{
					return ;
				}
			DataTable dtRep=new DataTable();
				string strSql=string.Format("select wellName,price,salMony,salAmount,time,salPer,allSalAmount as allSalAmountAfter,(allSalAmount-salAmount) as allSalAmountBefore from tbWell,tbSal where tbSal.wellNo=tbWell.wellNo and wellname='{0}' and year(time)={1}  order by time",strWellName,strTimeS);
				BengZhan.CDBConnection.getDataTable(ref dtRep,strSql,"dt");
				this.addSum(ref dtRep);

				this.paintList(this.listView2,"3",dtRep);

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
		private DataTable m_dtAllSa=null;


		private void showZhanRep(string strZhanName,string strYear,ref DataTable dtRet)
		{
			try
			{
				string strWellName=strZhanName;
				string strTime=strYear;

				if(strTime.Trim()=="")
				{
					return ;
				}		

				//this.groupBox3.Text=string.Format("售水明细表  时间范围：{0} 至 {1}",strTime,strTimeTo);

				string strSql=string.Format("select name wellName,allBuyAmount,allMony,leftAmount,leftMony,allAmount,allAmount*price1 allUsedMony,time from waterDatasMonth,tbWell where waterDatasMonth.name=tbWell.wellName and year(time)={0} and wellName='{1}'",strYear,strWellName);

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
		private void clearTimes()
		{
			try
			{
				if(this.listView1.Items.Count==0)
				{
					return ;
				}

				string strEnd="";

				for(int i=0;i<this.listView1.Items.Count;i++)
				{
					int iCount=this.listView1.Items[0].SubItems.Count;

					if(this.listView1.Items[i].SubItems[iCount-1].Text.Trim().Length==4)
					{
						if(this.listView1.Items[i].SubItems[iCount-1].Text.Trim()!=System.DateTime.Now.Year.ToString())
						{
							string strTimes=string.Format("{0}-1-1 0:00 至 {0}-12-31 23:00",this.listView1.Items[i].SubItems[iCount-1].Text.Trim());
							this.listView1.Items[i].SubItems[iCount-1].Text=strTimes;
							strEnd=string.Format("{0}-12-31 23:00",this.listView1.Items[i].SubItems[iCount-1].Text.Trim());
						}
						else
						{
							string strTimes=string.Format("{0}-1-1 0:00 至 {0}-{1}-{2} {3}:00",this.listView1.Items[i].SubItems[iCount-1].Text.Trim(),System.DateTime.Now.Month.ToString(),System.DateTime.Now.Day.ToString(),System.DateTime.Now.Hour.ToString());
							this.listView1.Items[i].SubItems[iCount-1].Text=strTimes;
							strEnd=string.Format("{0}-{1}-{2} {3}:00",this.listView1.Items[i].SubItems[iCount-1].Text.Trim(),System.DateTime.Now.Month.ToString(),System.DateTime.Now.Day.ToString(),System.DateTime.Now.Hour.ToString());
						}
					}					
				}

             //   this.groupBox1.Text=this.label3.Text+" "+this.lblName.Text.Trim()+this.txtZhan.Text+"  "+"年份:"+this.txtYearFrom1.Text;
				// this.groupBox2.Text=this.label4.Text+" "+this.lblName.Text.Trim()+this.txtZhan.Text+"  "+"截止时间:"+strEnd;
			 
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void groupBox2_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private bool bInTable(string strMonth)
		{
			for(int i=0;i<this.cmbYue1.Items.Count;i++)
			{
				if(this.cmbYue1.Items[i].ToString().Trim()==strMonth)
				{
					return true;
				}
			}
			return true;
		}

		private void paintTs()
		{
			try
			{

			}
			catch(Exception ex)
			{

			}
		}



		private void button3_Click(object sender, System.EventArgs e)
		{

			bool bChecked=false;

			if(this.chkDep.Checked)
			{
				this.chkDep.Checked=false;
				bChecked=true;
			}

			if((this.lblName.Text.IndexOf("乡镇")>=0)||(this.lblName.Text.IndexOf("单位")>=0))
			{

			}
			else
			{
				MessageBox.Show("请选择要查询单位或乡镇！");
				return;
			}

			this.clearLsv();			

			//this.cmbYue1.Text=this.cmbYue2.Text;
		//	this.txtYearFrom1.Text=this.txtYearTo1.Text;

//			if(this.lblInfo.Text.IndexOf("....")>=0)
//			{
//				MessageBox.Show("正在进行远程招测,请稍候执行该操作!");
//				return;
//			}
//
//			this.lblInfo.Text="";
//			this.errorProvider1.SetError(this.lblInfo,"");
//
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

			if((!cDealReport.bAllNum(this.txtYearTo1.Text))||(this.txtYearTo1.Text.Trim().Length!=4))
			{
				MessageBox.Show("统计年份填写有误!");
				return;
			}

			this.numFrom1.Text=int.Parse(this.cmbYue1.Text.Replace("月","")).ToString();
			this.numTo1.Text=int.Parse(this.cmbYue2.Text.Replace("月","")).ToString();        


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

			string strFrom=string.Format("{0}-{1}-1 0:00",this.txtYearFrom1.Text.Trim(),this.numFrom1.Text.Trim());
			string strTo=string.Format("{0}-{1}-1 23:00",this.txtYearTo1.Text.Trim(),this.numTo1.Text.Trim());

			DateTime dtToEx=DateTime.Parse(strTo);
			dtToEx=dtToEx.AddMonths(1).AddDays(-1);

			strTo=string.Format("{0}-{1}-{2} 23:59",dtToEx.Year.ToString(),dtToEx.Month.ToString(),dtToEx.Day.ToString());


			this.groupBox1.Text=string.Format("售水月结统计表  时间范围:{0}至{1}",strFrom,strTo);
			this.groupBox2.Text=string.Format("用水月结统计表  时间范围:{0}至{1}",strFrom,strTo);


		    this.paintColor();

			this.changeTime();

			if(bChecked)
			{
				this.chkDep.Checked=true;
			}

		}

		#region"月结"

		#region"乡镇"
		private void monthStaticRepCountry1(ref DataTable dtSa,ref DataTable dtAm)
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
					string strTime=this.txtYearFrom1.Text.Trim()+"-"+this.numFrom1.Text.Trim()+"-1 0:00";
					dtFrom=DateTime.Parse(strTime);
					strTime=this.txtYearTo1.Text.Trim()+"-"+this.numTo1.Text.Trim()+"-1 23:59";
					dtTo=DateTime.Parse(strTime);
					dtTo=dtTo.AddMonths(1);
					dtTo=dtTo.AddDays(-1);
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

				int iIns=(int.Parse(this.txtYearTo1.Text.Trim())-int.Parse(this.txtYearFrom1.Text.Trim()))*12+int.Parse(this.numTo1.Text.Trim())-int.Parse(this.numFrom1.Text.Trim());				

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

						string strTime=this.txtYearFrom1.Text.Trim()+"-"+this.numFrom1.Text.Trim()+"-1";
						dtFrom=DateTime.Parse(strTime);
						dtTo=dtFrom.AddMonths(x);

						string strFrom=string.Format("{0}-{1}-{2} 0:00",dtTo.Year.ToString(),dtTo.Month.ToString(),dtTo.Day.ToString());

						dtTo=dtTo.AddMonths(1);
						dtTo=dtTo.AddDays(-1);

						string strTo=string.Format("{0}-{1}-{2} 23:59",dtTo.Year.ToString(),dtTo.Month.ToString(),dtTo.Day.ToString());
						//string strTo=dtTo.ToShortDateString();							
		
						strSql=string.Format("select wellNo from tbWell where depName='{0}' order by wellNo",strDepName);

						DataTable dtWell=new DataTable();
						BengZhan.CDBConnection.getDataTable(ref dtWell,strSql,"dtDep");	
					
						DataTable dtAvgEx=new DataTable();

						DataTable dtSa2=new DataTable();
					DataTable dtAm2=new DataTable();

						for(int y=0;y<dtWell.Rows.Count;y++)
						{
							DataTable dtSa1=new DataTable();
							//DataTable dtAm1=new DataTable();

							string strZhanNo=dtWell.Rows[y]["wellNo"].ToString().Trim();

							if(CReportDll.comReport.CSalReport.getDtAvgReportMonth(strZhanNo,strFrom,strTo,ref dtSa1)==false)
							{
								return;
							}				
							
							BengZhan.comReport.CReports.copyDt(dtSa1,ref dtSa2);						
						}

cDealReport cdr=new cDealReport();

						cdr.addSum(ref dtSa2,-1,strDepName);
						cDealReport.changeDataType(ref dtSa2);
						cDealReport.clearTime(ref dtSa2,true);

						cdr.addTime(ref dtSa2,true);
			
						BengZhan.comReport.CReports.copyDt(dtSa2,ref dtSa);			
					}			
				}			


				dtTo=dtFrom.AddMonths(iIns);

				
				string strFromEx=string.Format("{0}-{1}-1 0:00",dtFrom.Year.ToString(),dtFrom.Month.ToString());					
				string strToEx=string.Format("{0}-{1}-1 0:00",dtTo.AddMonths(1).Year.ToString(),Convert.ToString(dtTo.AddMonths(1).Month));//1

				dtTo=DateTime.Parse(strToEx);
				dtTo=dtTo.AddDays(-1);

				strToEx=string.Format("{0}-{1}-{2} 23:00",dtTo.Year.ToString(),dtTo.Month.ToString(),dtTo.Day.ToString());
				
				string strCapText=string.Format("乡镇：{0}    时间范围：{1}至{2}    本月用水统计表",this.txtZhan.Text.Trim(),strFromEx,strToEx);
				
				//this.dataGrid5.CaptionText=strCapText;

				strCapText=string.Format("本月用水统计表  时间范围：{0}至{1}",strFromEx,strToEx);
				//this.groupBox1.Text=strCapText;

				///this.m_strDtFrom=strFromEx;
				//this.m_strDtTo=strToEx;

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}


		#endregion

		#region"单位月结"

		private void monthStaticRepDep0Ex(string strDepName,ref DataTable dtDepSa,ref DataTable dtDepAm)
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
					string strTime=this.txtYearFrom1.Text.Trim()+"-"+this.numFrom1.Text.Trim()+"-1";
					dtFrom=DateTime.Parse(strTime);
					strTime=this.txtYearTo1.Text.Trim()+"-"+this.numTo1.Text.Trim()+"-1";
					dtTo=DateTime.Parse(strTime);
					dtTo=dtTo.AddMonths(1);
					dtTo=dtTo.AddDays(-1);
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

				int iIns=(int.Parse(this.txtYearTo1.Text.Trim())-int.Parse(this.txtYearFrom1.Text.Trim()))*12+int.Parse(this.numTo1.Text.Trim())-int.Parse(this.numFrom1.Text.Trim());
					
				DataTable dtAvg=new DataTable();
				DataTable dtRet=new DataTable();

				//string strDepName=this.txtZhan.Text.Trim();		
					
				for(int x=0;x<=iIns;x++)
				{

					string strTime=this.txtYearFrom1.Text.Trim()+"-"+this.numFrom1.Text.Trim()+"-1 0:00";
					dtFrom=DateTime.Parse(strTime);
					dtTo=dtFrom.AddMonths(x);

					string strFrom=dtFrom.ToString();		
					//string strTo=dtTo.ToString();		
					
					string strTo=string.Format("{0}-{1}-{2} 23:00",dtFrom.Year.ToString(),dtFrom.Month.ToString(),dtFrom.AddMonths(1).AddDays(-1).Day.ToString());
		
					string strSql=string.Format("select wellNo from tbWell where depName='{0}' order by wellNo",strDepName);

					DataTable dtDep=new DataTable();
					BengZhan.CDBConnection.getDataTable(ref dtDep,strSql,"dtDep");	
					
					DataTable dtAvgEx=new DataTable();

					DataTable dtDepAm1=new DataTable();
					DataTable dtDepSa1=new DataTable();

					for(int i=0;i<dtDep.Rows.Count;i++)
					{

						string strZhanNo=dtDep.Rows[i]["wellNo"].ToString().Trim();

						if(CReportDll.comReport.CSalReport.getDtAvgReportMonth(strZhanNo,strFrom,strTo,ref dtAvg)==false)
						{
							return;
						}

						BengZhan.comReport.CReports.copyDt(dtAvg,ref dtDepSa1);							

					}

					cDealReport cdr=new cDealReport();


					cdr.addSum(ref dtDepSa1,-1,strDepName);
				
					cDealReport.changeDataType(ref dtDepSa1);
					cDealReport.clearTime(ref dtDepSa1,true);
					//	Console.WriteLine(strDepName);
					cdr.addTime(ref dtDepSa1,true);
				
					BengZhan.comReport.CReports.copyDt(dtDepSa1,ref dtDepSa);

				}

				dtTo=dtFrom.AddMonths(iIns);
				
				string strFromEx=string.Format("{0}-{1}-1 0:00",dtFrom.Year.ToString(),dtFrom.Month.ToString());					
				string strToEx=string.Format("{0}-{1}-1 0:00",dtTo.AddMonths(1).Year.ToString(),Convert.ToString(dtTo.AddMonths(1).Month));//2

				dtTo=DateTime.Parse(strToEx);
				dtTo=dtTo.AddDays(-1);

				strToEx=string.Format("{0}-{1}-{2} 23:00",dtTo.Year.ToString(),dtTo.Month.ToString(),dtTo.Day.ToString());
				
				string strCapText=string.Format("单位：{0}    时间范围：{1}至{2}    本月用水统计表",strDepName,strFromEx,strToEx);
				
				//this.dataGrid5.CaptionText=strCapText;

				strCapText=string.Format("本月用水统计表  时间范围：{0}至{1}",strFromEx,strToEx);
				//	this.groupBox1.Text=strCapText;

				//this.m_strDtFrom=strFromEx;
				//this.m_strDtTo=strToEx;
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}


		private void monthStaticRepDep0(ref DataTable dtDepSa,ref DataTable dtDepAm)
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
					string strTime=this.txtYearFrom1.Text.Trim()+"-"+this.numFrom1.Text.Trim()+"-1";
					dtFrom=DateTime.Parse(strTime);
					strTime=this.txtYearTo1.Text.Trim()+"-"+this.numTo1.Text.Trim()+"-1";
					dtTo=DateTime.Parse(strTime);
					dtTo=dtTo.AddMonths(1);
					dtTo=dtTo.AddDays(-1);
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

				int iIns=(int.Parse(this.txtYearTo1.Text.Trim())-int.Parse(this.txtYearFrom1.Text.Trim()))*12+int.Parse(this.numTo1.Text.Trim())-int.Parse(this.numFrom1.Text.Trim());
					
				DataTable dtAvg=new DataTable();
				DataTable dtRet=new DataTable();

				string strDepName=this.txtZhan.Text.Trim();		
					
				for(int x=0;x<=iIns;x++)
				{

					string strTime=this.txtYearFrom1.Text.Trim()+"-"+this.numFrom1.Text.Trim()+"-1 0:00";
					dtFrom=DateTime.Parse(strTime);
					dtTo=dtFrom.AddMonths(x);

					string strFrom=dtFrom.ToString();		
					//string strTo=dtTo.ToString();		
					
					string strTo=string.Format("{0}-{1}-{2} 23:00",dtFrom.Year.ToString(),dtFrom.Month.ToString(),dtFrom.AddMonths(1).AddDays(-1).Day.ToString());
		
					string strSql=string.Format("select wellNo from tbWell where depName='{0}' order by wellNo",strDepName);

					DataTable dtDep=new DataTable();
					BengZhan.CDBConnection.getDataTable(ref dtDep,strSql,"dtDep");	
					
					DataTable dtAvgEx=new DataTable();

					DataTable dtDepAm1=new DataTable();
					DataTable dtDepSa1=new DataTable();

					for(int i=0;i<dtDep.Rows.Count;i++)
					{

						string strZhanNo=dtDep.Rows[i]["wellNo"].ToString().Trim();

						if(CReportDll.comReport.CSalReport.getDtAvgReportMonth(strZhanNo,strFrom,strTo,ref dtAvg)==false)
						{
							return;
						}

						BengZhan.comReport.CReports.copyDt(dtAvg,ref dtDepSa1);							

					}

					cDealReport cdr=new cDealReport();


					cdr.addSum(ref dtDepSa1,-1,strDepName);
				
					cDealReport.changeDataType(ref dtDepSa1);
					cDealReport.clearTime(ref dtDepSa1,true);
					//	Console.WriteLine(strDepName);
					cdr.addTime(ref dtDepSa1,true);
				
					BengZhan.comReport.CReports.copyDt(dtDepSa1,ref dtDepSa);

				}


				dtTo=dtFrom.AddMonths(iIns);
				
				string strFromEx=string.Format("{0}-{1}-1 0:00",dtFrom.Year.ToString(),dtFrom.Month.ToString());					
				string strToEx=string.Format("{0}-{1}-1 0:00",dtTo.AddMonths(1).Year.ToString(),Convert.ToString(dtTo.AddMonths(1).Month));//2

				dtTo=DateTime.Parse(strToEx);
				dtTo=dtTo.AddDays(-1);

				strToEx=string.Format("{0}-{1}-{2} 23:00",dtTo.Year.ToString(),dtTo.Month.ToString(),dtTo.Day.ToString());
				
				string strCapText=string.Format("单位：{0}    时间范围：{1}至{2}    本月用水统计表",strDepName,strFromEx,strToEx);
				
				//this.dataGrid5.CaptionText=strCapText;

				strCapText=string.Format("本月用水统计表  时间范围：{0}至{1}",strFromEx,strToEx);
				//	this.groupBox1.Text=strCapText;

				//this.m_strDtFrom=strFromEx;
				//this.m_strDtTo=strToEx;
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void monthStaticRepDep1Ex(string strDepName,ref DataTable dtDepSa,ref DataTable dtDepAm)
		{
			try
			{
				dtDepSa=new DataTable();
				dtDepAm=new DataTable();

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
					string strTime=this.txtYearFrom1.Text.Trim()+"-"+this.numFrom1.Text.Trim()+"-1";
					dtFrom=DateTime.Parse(strTime);
					strTime=this.txtYearTo1.Text.Trim()+"-"+this.numTo1.Text.Trim()+"-1";
					dtTo=DateTime.Parse(strTime);
					dtTo=dtTo.AddMonths(1);
					dtTo=dtTo.AddDays(-1);
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

				//	int iIns=(int.Parse(this.txtYearTo1.Text.Trim())-int.Parse(this.txtYearFrom1.Text.Trim()))*12+int.Parse(this.numTo1.Text.Trim())-int.Parse(this.numFrom1.Text.Trim());
					
				//		DataTable dtAvg=new DataTable();
				DataTable dtRet=new DataTable();

			//	string strDepName=this.txtZhan.Text.Trim();						
		
				string strSql=string.Format("select wellNo,wellName from tbWell where depName='{0}' order by wellNo",strDepName);

				DataTable dtDep=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtDep,strSql,"dtDep");	
					
				DataTable dtAvgEx=new DataTable();	

				int insE=0;

				for(int i=0;i<dtDep.Rows.Count;i++)
				{

					DataTable dtDepAm1=new DataTable();
					DataTable dtDepSa1=new DataTable();

					int iIns=(int.Parse(this.txtYearTo1.Text.Trim())-int.Parse(this.txtYearFrom1.Text.Trim()))*12+int.Parse(this.numTo1.Text.Trim())-int.Parse(this.numFrom1.Text.Trim());
					string	strWellNameEx=dtDep.Rows[i]["wellName"].ToString().Trim();

					insE=iIns;

					for(int x=0;x<=iIns;x++)
					{

						string strTime=this.txtYearFrom1.Text.Trim()+"-"+this.numFrom1.Text.Trim()+"-1 0:00";
						dtFrom=DateTime.Parse(strTime);
						dtTo=dtFrom.AddMonths(x);
						dtFrom=dtFrom.AddMonths(x);

						string strFrom=dtFrom.ToString();		
						//string strTo=dtTo.ToString();		
					
						string strTo=string.Format("{0}-{1}-{2} 23:00",dtFrom.Year.ToString(),dtFrom.Month.ToString(),dtFrom.AddMonths(1).AddDays(-1).Day.ToString());
						string strZhanNo=dtDep.Rows[i]["wellNo"].ToString().Trim();

						DataTable dtAvg=new DataTable();
						DataTable dtAvg1=new DataTable();

						if(CReportDll.comReport.CSalReport.getDtAvgReportMonth(strZhanNo,strFrom,strTo,ref dtAvg)==false)
						{
							return;
						}
						BengZhan.comReport.CReports.copyDt(dtAvg,ref dtDepSa1);				

					}

					cDealReport cdr=new cDealReport();

					cdr.addSum(ref dtDepSa1,-1,strWellNameEx);				
					cDealReport.changeDataType(ref dtDepSa1);
					cDealReport.clearTime(ref dtDepSa1,true);
					//	Console.WriteLine(strDepName);
					cdr.addTime(ref dtDepSa1,true);

					//	BengZhan.comReport.CReports.copyDt(dtDepAm1,ref dtDepAm);
					BengZhan.comReport.CReports.copyDt(dtDepSa1,ref dtDepSa);

				}

				cDealReport cdrE=new cDealReport();				   

				cDealReport.changeDataType(ref dtDepAm);
				// cDealReport.clearTime(ref dtDepAm,true);
				//	Console.WriteLine(strDepName);
				//  cdrE.addTime(ref dtDepAm,true);
				cdrE.addSum(ref dtDepSa,-1,strDepName,0.5);		
		
				cDealReport.changeDataType(ref dtDepSa);
				//cDealReport.clearTime(ref dtDepSa,true);
				//	Console.WriteLine(strDepName);
				cdrE.addTime(ref dtDepSa,true);

				if(insE>0)				
				{
					this.removeZhan(ref dtDepSa);
					//this.removeZhan(ref dtDepAm);
				}

				dtTo=dtFrom.AddMonths(insE);
				
				string strFromEx=string.Format("{0}-{1}-1 0:00",dtFrom.Year.ToString(),dtFrom.Month.ToString());					
				string strToEx=string.Format("{0}-{1}-1 0:00",dtTo.AddMonths(1).Year.ToString(),Convert.ToString(dtTo.AddMonths(1).Month));//2

				dtTo=DateTime.Parse(strToEx);
				dtTo=dtTo.AddDays(-1);

				strToEx=string.Format("{0}-{1}-{2} 23:00",dtTo.Year.ToString(),dtTo.Month.ToString(),dtTo.Day.ToString());
				
				string strCapText=string.Format("单位：{0}    时间范围：{1}至{2}    本月用水统计表",strDepName,strFromEx,strToEx);
				
				//this.dataGrid5.CaptionText=strCapText;

				strCapText=string.Format("本月用水统计表  时间范围：{0}至{1}",strFromEx,strToEx);
				//	this.groupBox1.Text=strCapText;

				//this.m_strDtFrom=strFromEx;
				//this.m_strDtTo=strToEx;
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void monthStaticRepDep1(ref DataTable dtDepSa,ref DataTable dtDepAm)
		{
			try
			{
				dtDepSa=new DataTable();
				dtDepAm=new DataTable();

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
					string strTime=this.txtYearFrom1.Text.Trim()+"-"+this.numFrom1.Text.Trim()+"-1";
					dtFrom=DateTime.Parse(strTime);
					strTime=this.txtYearTo1.Text.Trim()+"-"+this.numTo1.Text.Trim()+"-1";
					dtTo=DateTime.Parse(strTime);
					dtTo=dtTo.AddMonths(1);
					dtTo=dtTo.AddDays(-1);
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

			//	int iIns=(int.Parse(this.txtYearTo1.Text.Trim())-int.Parse(this.txtYearFrom1.Text.Trim()))*12+int.Parse(this.numTo1.Text.Trim())-int.Parse(this.numFrom1.Text.Trim());
					
		//		DataTable dtAvg=new DataTable();
				DataTable dtRet=new DataTable();

				string strDepName=this.txtZhan.Text.Trim();						
		
			    string strSql=string.Format("select wellNo,wellName from tbWell where depName='{0}' order by wellNo",strDepName);

				DataTable dtDep=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtDep,strSql,"dtDep");	
					
				DataTable dtAvgEx=new DataTable();	

				int insE=0;

					for(int i=0;i<dtDep.Rows.Count;i++)
					{

						DataTable dtDepAm1=new DataTable();
						DataTable dtDepSa1=new DataTable();

						int iIns=(int.Parse(this.txtYearTo1.Text.Trim())-int.Parse(this.txtYearFrom1.Text.Trim()))*12+int.Parse(this.numTo1.Text.Trim())-int.Parse(this.numFrom1.Text.Trim());
					string	strWellNameEx=dtDep.Rows[i]["wellName"].ToString().Trim();

						insE=iIns;

						for(int x=0;x<=iIns;x++)
						{

							string strTime=this.txtYearFrom1.Text.Trim()+"-"+this.numFrom1.Text.Trim()+"-1 0:00";
							dtFrom=DateTime.Parse(strTime);
							dtTo=dtFrom.AddMonths(x);
							dtFrom=dtFrom.AddMonths(x);

							string strFrom=dtFrom.ToString();		
							//string strTo=dtTo.ToString();		
					
							string strTo=string.Format("{0}-{1}-{2} 23:00",dtFrom.Year.ToString(),dtFrom.Month.ToString(),dtFrom.AddMonths(1).AddDays(-1).Day.ToString());
							string strZhanNo=dtDep.Rows[i]["wellNo"].ToString().Trim();

							DataTable dtAvg=new DataTable();
							DataTable dtAvg1=new DataTable();

							if(CReportDll.comReport.CSalReport.getDtAvgReportMonth(strZhanNo,strFrom,strTo,ref dtAvg)==false)
							{
								return;
							}
							BengZhan.comReport.CReports.copyDt(dtAvg,ref dtDepSa1);				

						}

						cDealReport cdr=new cDealReport();

						cdr.addSum(ref dtDepSa1,-1,strWellNameEx);				
						cDealReport.changeDataType(ref dtDepSa1);
						cDealReport.clearTime(ref dtDepSa1,true);
						//	Console.WriteLine(strDepName);
						cdr.addTime(ref dtDepSa1,true);

					//	BengZhan.comReport.CReports.copyDt(dtDepAm1,ref dtDepAm);
						BengZhan.comReport.CReports.copyDt(dtDepSa1,ref dtDepSa);

					}

				    cDealReport cdrE=new cDealReport();				   

				    cDealReport.changeDataType(ref dtDepAm);
				   // cDealReport.clearTime(ref dtDepAm,true);
				//	Console.WriteLine(strDepName);
			      //  cdrE.addTime(ref dtDepAm,true);
				    cdrE.addSum(ref dtDepSa,-1,strDepName,0.5);		
		
				   cDealReport.changeDataType(ref dtDepSa);
			    	//cDealReport.clearTime(ref dtDepSa,true);
				//	Console.WriteLine(strDepName);
				    cdrE.addTime(ref dtDepSa,true);

				if(insE>0)				
				{
					this.removeZhan(ref dtDepSa);
					//this.removeZhan(ref dtDepAm);
				}

				 dtTo=dtFrom.AddMonths(insE);
				
				string strFromEx=string.Format("{0}-{1}-1 0:00",dtFrom.Year.ToString(),dtFrom.Month.ToString());					
				string strToEx=string.Format("{0}-{1}-1 0:00",dtTo.AddMonths(1).Year.ToString(),Convert.ToString(dtTo.AddMonths(1).Month));//2

				dtTo=DateTime.Parse(strToEx);
				dtTo=dtTo.AddDays(-1);

				strToEx=string.Format("{0}-{1}-{2} 23:00",dtTo.Year.ToString(),dtTo.Month.ToString(),dtTo.Day.ToString());
				
				string strCapText=string.Format("单位：{0}    时间范围：{1}至{2}    本月用水统计表",strDepName,strFromEx,strToEx);
				
				//this.dataGrid5.CaptionText=strCapText;

				strCapText=string.Format("本月用水统计表  时间范围：{0}至{1}",strFromEx,strToEx);
			//	this.groupBox1.Text=strCapText;

				//this.m_strDtFrom=strFromEx;
				//this.m_strDtTo=strToEx;
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}
		#endregion

		#region"监测站月统计"
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
					
					string strTime=this.txtYearFrom1.Text.Trim()+"-"+this.cmbYue1.Text.Replace("月","").Trim()+"-1";
					this.numFrom1.Text=this.cmbYue1.Text.Replace("月","");
					dtFrom=DateTime.Parse(strTime);
					strTime=this.txtYearTo1.Text.Trim()+"-"+this.cmbYue2.Text.Replace("月","").Trim()+"-1";
					this.numTo1.Text=this.cmbYue2.Text.Replace("月","").Trim();
					dtTo=DateTime.Parse(strTime);
					dtTo=dtTo.AddMonths(1);
					dtTo=dtTo.AddDays(-1);
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

				int iIns=(int.Parse(this.txtYearTo1.Text.Trim())-int.Parse(this.txtYearFrom1.Text.Trim()))*12+int.Parse(this.numTo1.Text.Trim())-int.Parse(this.numFrom1.Text.Trim());
				DataTable dtAvgEx=new DataTable();
				DataTable dtAvgEx1=new DataTable();
				
				for(int x=0;x<=iIns;x++)
				{
					string strZhanNo=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();
					string strTime=this.txtYearFrom1.Text.Trim()+"-"+this.numFrom1.Text.Trim()+"-1";
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

				//this.groupBox1.Text=strCapText;

				//	this.m_strDtFrom=strFrom;
				//this.m_strDtTo=strTo;
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}
		
		private void disPZhan(System.Windows.Forms.ListView lsv)
		{

			lsv.Items.Clear();

			DataTable dtZhanSa=new DataTable();
			DataTable dtZhanAm=new DataTable();

			this.monthStaticRep1(ref dtZhanSa,ref dtZhanAm);

			cDealReport.clearTime(ref dtZhanSa,true);
			cDealReport.clearTime(ref dtZhanAm,true);
//			this.monthStaticRep1(ref dtZhan);
//
//			if(dtZhan==null)
//			{
//				return;
//			}

		//	this.paintList(lsv,"year",dtZhan);		
			this.paintList(this.listView1,"3",dtZhanSa);
			this.paintList(this.listView2,"5",dtZhanAm);
		}
		private void disPDep(System.Windows.Forms.ListView lsv)
		{

			DataTable dtDepSa=new DataTable();
			DataTable dtDepAm=new DataTable();

			if((this.cmbYue1.Text.Trim()==this.cmbYue2.Text.Trim())&&(this.txtYearFrom1.Text.Trim()==this.txtYearTo1.Text.Trim()))		
			{
				this.monthStaticRepDep0(ref dtDepSa,ref dtDepAm);
			}
			else
			{
				this.monthStaticRepDep1(ref dtDepSa,ref dtDepAm);
			}

			string strDepName=this.txtZhan.Text.Trim();

			dtDepAm=dispDepStacMonth(strDepName);
            
			
			//cDealReport.clearTime(ref dtDepSa,true);
			//cDealReport.clearTime(ref dtDepAm,true);
			if(this.chkDep.Checked)
			{
				this.removeZhan1(ref dtDepSa);
				this.removeZhan1(ref dtDepAm);
			}

			this.paintList(this.listView1,"3",dtDepSa);
			this.paintList(this.listView2,"5",dtDepAm);
		}

		private void disPCountry(System.Windows.Forms.ListView lsv)
		{

			DataTable dtSa=new DataTable();
			DataTable dtAm=new DataTable();

			//this.monthStaticRepCountry1(ref dtSa,ref dtAm);	
	
			string strCountryName=this.txtZhan.Text.Trim();
			string strSql=string.Format("select depShortName from tbDep where countryName='{0}'",strCountryName);
			DataTable dtDep=new DataTable();
			BengZhan.CDBConnection.getDataTable(ref dtDep,strSql,"dp");

			if(this.cmbYue1.Text.Trim()==this.cmbYue2.Text.Trim())			
			{
				for(int i=0;i<dtDep.Rows.Count;i++)
				{
					string strDepName=dtDep.Rows[i]["depShortName"].ToString().Trim();
					DataTable dtSaEx=new DataTable();
					DataTable dtAmEx=new DataTable();
					this.monthStaticRepDep0Ex(strDepName,ref dtSaEx,ref dtAmEx);
					BengZhan.comReport.CReports.copyDt(dtSaEx,ref dtSa);
				}
			}
			else
			{
				for(int i=0;i<dtDep.Rows.Count;i++)
				{
					string strDepName=dtDep.Rows[i]["depShortName"].ToString().Trim();
					DataTable dtSaEx=new DataTable();
					DataTable dtAmEx=new DataTable();
					this.monthStaticRepDep1Ex(strDepName,ref dtSaEx,ref dtAmEx);
					BengZhan.comReport.CReports.copyDt(dtSaEx,ref dtSa);
				}
			}

			dtAm=this.dispCountryStacMonth(this.txtZhan.Text.Trim());

		//	cDealReport.clearTime(ref dtSa,true);
	//	cDealReport.clearTime(ref dtAm,true);

			this.addSumEx(ref dtAm,this.txtZhan.Text.Trim());
			this.addSumEx(ref dtSa,this.txtZhan.Text.Trim());			

			if(this.chkDep.Checked)
			{
				this.removeZhan1(ref dtAm);
				this.removeZhan1(ref dtSa);
			}

		    this.dataGrid1.DataSource=dtSa;

            
			this.paintList(this.listView1,"3",dtSa);
			this.paintList(this.listView2,"5",dtAm);
		
			//this.paintList(lsv,1,dtCountry);
		}

		private void disPCountryYear()
		{

			DataTable dtSa=new DataTable();
			DataTable dtAm=new DataTable();
			this.monthStaticRepCountryYear(ref dtSa,ref dtAm);

			this.addSumEx(ref dtSa,this.txtZhan.Text.Trim());
			this.addSumEx(ref dtAm,this.txtZhan.Text.Trim());

			if(this.chkDep.Checked)
			{
				this.removeZhan1(ref dtSa);
				this.removeZhan1(ref dtAm);
			}


			//	cDealReport.clearTime(ref dtSa,true);
			//	cDealReport.clearTime(ref dtAm,true);

			this.paintList(this.listView1,"3",dtSa);
			this.paintList(this.listView2,"5",dtAm);

		}

		private void disPDepYear()
		{
			DataTable dtSa=new DataTable();
			DataTable dtAm=new DataTable();

			this.monthStaticRepDepYear(ref dtSa,ref dtAm);

			//	cDealReport.clearTime(ref dtSa,true);
			//	cDealReport.clearTime(ref dtAm,true);

			if(this.chkDep.Checked)
			{
				this.removeZhan1(ref dtSa);
				this.removeZhan1(ref dtAm);
			}

			this.paintList(this.listView1,"3",dtSa);
			this.paintList(this.listView2,"5",dtAm);			

		}

		#endregion
		
		#endregion

		#region"明细"

		#endregion

		#region"通用"

		private void removeNZ(ref DataTable dt)
		{
			try
			{
				if(dt==null)
				{
					return;
				}
				for(int i=0;i<dt.Rows.Count;i++)
				{
					if(dt.Rows[i]["time"].ToString().IndexOf("至")<0)					
					{
						dt.Rows.RemoveAt(i);
						i--;
						continue;
					}
					if(dt.Rows[i][0].ToString().IndexOf("总计")>=0)
					{
						dt.Rows.RemoveAt(i);
						i--;
					}
				}			
			 }
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void removeZhan1(ref DataTable dt)
		{
			try
			{
				for(int i=0;i<dt.Rows.Count;i++)
				{
					if((dt.Rows[i]["wellName"].ToString().IndexOf("合计")<0)&&(dt.Rows[i]["wellName"].ToString().IndexOf("总计")<0))
					{
						dt.Rows.RemoveAt(i);
						i--;
					}
				}							
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void removeZhan(ref DataTable dt)
		{
			try
			{
				for(int i=0;i<dt.Rows.Count;i++)
				{
					if(dt.Rows[i]["wellName"].ToString().IndexOf("合计")<0)
					{
						dt.Rows.RemoveAt(i);
						i--;
					}
				}

				if(dt.Rows.Count>=2)
				{
					for(int i=0;i<dt.Rows.Count-1;i++)				
					{
						dt.Rows[i]["wellName"]=dt.Rows[i]["wellName"].ToString().Replace("合计","");
					}
				}
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
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

		private void paintColor()
		{
			try
			{
				//this.showAmountDetail();


				this.paintColor(this.listView1,"合计",Color.White);
				this.paintColor(this.listView1,"总计",Color.Silver);
				this.paintColor(this.listView2,"合计",Color.White);
				this.paintColor(this.listView2,"总计",Color.Silver);
				this.paintColor(this.listView3,"合计",Color.White);
				this.paintColor(this.listView3,"总计",Color.Silver);
				this.paintColor(this.listView4,"合计",Color.White);
				this.paintColor(this.listView4,"总计",Color.Silver);
				this.paintColorLsv4();
				
                	


			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		private void button5_Click(object sender, System.EventArgs e)
		{		
		//	this.dataGrid1.DataSource=dtCountry;
		}



		private void button2_Click(object sender, System.EventArgs e)
		{
			this.btnPrint_Click(null,null);
		}

		private void listView2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(this.listView2.SelectedItems.Count==0)
				{
					return;
				}

				if(this.listView2.SelectedItems[0].Text.Trim().IndexOf("总计")>=0)
				{
					return;
				}

				int iCount=this.listView2.Items[0].SubItems.Count;
				iCount--;

				string strZhanName=this.listView2.SelectedItems[0].Text.Trim();
				string strTime=this.listView2.SelectedItems[0].SubItems[iCount].Text.Trim();
				string strTimeS=this.listView2.SelectedItems[0].SubItems[iCount].Text.Trim();

			 iCount=this.listView2.Items[0].SubItems.Count;

				if(strZhanName.IndexOf("合计")>=0)
				{
					strZhanName=strZhanName.Replace("合计","");
					//单位
					DataTable dtAllSalesDep=new DataTable();
					cDealReport cdr=new cDealReport();

					if(strTime.IndexOf("至")>=0)
					{
						string[] strsTime=strTime.Split('至');
						strTime=strsTime[0];
						string strTime1=strsTime[1];
						dtAllSalesDep=cdr.getDepDetailByEnd(strZhanName,strTime,strTime1);
						this.paintList(this.listView4,"5",dtAllSalesDep);
						//this.groupBox3.Text="售水明细表"+" "+"单位:"+strZhanName+" "+"截止时间:"+strTime;
					}						
				}
				else
				{
					iCount=this.listView2.Items[0].SubItems.Count;
					iCount--;
					strTime=this.listView2.SelectedItems[0].SubItems[iCount].Text.Trim();
					string strName=this.listView2.SelectedItems[0].SubItems[0].Text.Trim();

					string strFromTime="";
					string strToTime="";

					if(strTime.IndexOf("至")>=0)
					{
						string[] strsTime=strTime.Split('至');
						strFromTime=strsTime[0].Trim();
						strToTime=strsTime[1].Trim();
					}

					string strSql=string.Format("select wellNo from tbWell where wellName='{0}'",strName);
					string strWellNo=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();
					DataTable dtDetailF=new DataTable();

					if(BengZhan.comReport.CReports.getDtDetailReportDay(strWellNo,strFromTime,strToTime,ref dtDetailF)==false)
					{
						return;
					}
					//this.addSum(ref dtDetailF);
					this.paintList(this.listView4,"5",dtDetailF);


					//this.groupBox3.Text=string.Format("售水明细表 监测站:{1} 截止时间:{0}",strTime,strName);
					//this.m_strTitle3="监测站："+strName;

				}

				this.groupBox4.Text=string.Format("用水明细  时间范围:{0}",strTimeS);

				this.paintColor();

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			
			if((this.lblName.Text.IndexOf("乡镇")>=0)||(this.lblName.Text.IndexOf("单位")>=0))
			{

			}
			else
			{
				MessageBox.Show("请选择要查询单位或乡镇！");
				return;
			}

			
			this.cmbYue1.Text=this.cmbYue2.Text;
			this.txtYearFrom1.Text=this.txtYearTo1.Text;
			
			this.clearLsv();
			this.btnCer_Click(null,null);
		}

		private void listView1_SelectedIndexChanged_1(object sender, System.EventArgs e)
		{
			try
			{
				if(this.listView1.SelectedItems.Count==0)
				{
					return;
				}

				if(this.listView1.SelectedItems[0].Text.Trim().IndexOf("总计")>=0)
				{
					return;
				}

				string strZhanName=this.listView1.SelectedItems[0].Text.Trim();
				int iCount=this.listView1.Items[0].SubItems.Count;
				string strTime=this.listView1.SelectedItems[0].SubItems[iCount-1].Text.Trim();
				string strTimes=this.listView1.SelectedItems[0].SubItems[iCount-1].Text.Trim();

				if(strZhanName.IndexOf("合计")>=0)
				{
					strZhanName=strZhanName.Replace("合计","");
					//单位
					DataTable dtAllSalesDep=new DataTable();
					cDealReport cdr=new cDealReport();

					if(strTime.IndexOf("至")>=0)
					{
						string[] strsTime=strTime.Split('至');
						 strTime=strsTime[0];
						string strTime1=strsTime[1];
						dtAllSalesDep=cdr.getAllSalesDep(strZhanName,strTime,strTime1);
						this.paintList(this.listView3,"3",dtAllSalesDep);
						//this.groupBox3.Text="售水明细表"+" "+"单位:"+strZhanName+" "+"截止时间:"+strTime;
					}						
				}
				else
				{
					iCount=this.listView1.Items[0].SubItems.Count;
					iCount--;
					strTime=this.listView1.SelectedItems[0].SubItems[iCount].Text.Trim();
					string strName=this.listView1.SelectedItems[0].SubItems[0].Text.Trim();

					string strFromTime="";
					string strToTime="";

					if(strTime.IndexOf("至")>=0)
					{
						string[] strsTime=strTime.Split('至');
						strFromTime=strsTime[0].Trim();
						strToTime=strsTime[1].Trim();
					}

					string strSql=string.Format("select wellName,cast(price as nvarchar(10)),salMony,salAmount,time,salPer,allSalAmount as allSalAmountAfter,(allSalAmount-salAmount) as allSalAmountBefore from tbWell,tbSal where tbSal.wellNo=tbWell.wellNo and wellname='{0}' and time>='{1}' and time<='{2}' order by time",strName,strFromTime,strToTime);

					DataTable dtDetail=new DataTable();

					BengZhan.CDBConnection.getDataTable(ref dtDetail,strSql,"dt");
					this.addSum(ref dtDetail);

					this.paintList(this.listView3,"3",dtDetail);


					//this.groupBox3.Text=string.Format("售水明细表 监测站:{1} 截止时间:{0}",strTime,strName);
					//this.m_strTitle3="监测站："+strName;

				}

				this.groupBox3.Text=string.Format("售水明细  时间范围:{0}",strTimes);
				this.paintColor();
		}

			//	this.showAmountDetail();}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
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

		private void changeTime()
		{
			try
			{		
				string strText=this.groupBox1.Text.Trim();

				int iDex=this.groupBox1.Text.IndexOf(":");
				string strTime=this.groupBox1.Text.Substring(iDex+1).Trim();

				int iColDex=0;

				if(this.listView1.Items.Count==0)
				{
					return;
				}

				iColDex=this.listView1.Items[0].SubItems.Count;
				iColDex--;


				for(int i=0;i<this.listView1.Items.Count;i++)
				{
					if(this.listView1.Items[i].SubItems[iColDex].Text.Trim()!="")
					{
						this.listView1.Items[i].SubItems[iColDex].Text=strTime;
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		#endregion

		#region"新增单位月结"

		#region"dep"

		private void dispDepStacMonth()
		{
			this.numFrom1.Text=int.Parse(this.cmbYue1.Text.Replace("月","")).ToString();
			this.numTo1.Text=int.Parse(this.cmbYue2.Text.Replace("月","")).ToString();
			string strDepName=this.trvWel.SelectedNode.Text.Trim();
		

			try
			{
				string strTime=this.txtYearFrom1.Text.Trim()+"-"+this.numFrom1.Text.Trim()+"-1";
				DateTime dtFrom=DateTime.Parse(strTime);
				strTime=this.txtYearTo1.Text.Trim()+"-"+this.numTo1.Text.Trim()+"-1";
				DateTime dtTo=DateTime.Parse(strTime);

				dtTo=dtTo.AddMonths(1);
				dtTo=dtTo.AddDays(-1);

				string strZhanName=strDepName;
				//单位
				DataTable dtAllSalesDep=new DataTable();
				cDealReport cdr=new cDealReport();

		
				//string[] strsTime=strTime.Split('至');
				strTime=dtFrom.ToString();
				string strTime1=dtTo.ToString();
				dtAllSalesDep=cdr.getDepDetailByEnd1(strZhanName,strTime,strTime1);
				this.removeNZ(ref dtAllSalesDep);
				this.dataGrid1.DataSource=dtAllSalesDep;
				this.paintList(this.listView2,"5",dtAllSalesDep);
				//this.paintList(this.listView4,"5",dtAllSalesDep);
				//this.groupBox3.Text="售水明细表"+" "+"单位:"+strZhanName+" "+"截止时间:"+strTime;
			}
			catch(Exception ee)
			{
				MessageBox.Show("查询起始、截止时间输入有误！");
			}
			this.paintColor();
		}

		#endregion

		private void chkDep_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.chkDep.Checked)
			{
				//this.clearLsv();

				this.removeZhanItem(this.listView1);
				this.removeZhanItem(this.listView2);
				this.listView4.Items.Clear();
				this.listView3.Items.Clear();
			}
		}

		#region"country"

		private DataTable dispCountryStacMonth(string strCountryName)
		{
			try
			{
				//string strCountryName=this.trvWel.SelectedNode.Text.Trim();
				string strSql=string.Format("select depShortName from tbDep where countryName='{0}'",strCountryName);
				DataTable dt=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dt,strSql,"dep");

				DataTable dtCountry=new DataTable();
			
				for(int i=0;i<dt.Rows.Count;i++)
				{
					string strDepName=dt.Rows[i]["depShortName"].ToString();
					DataTable dtRep=this.dispDepStacMonth(strDepName);
					BengZhan.comReport.CReports.copyDt(dtRep,ref dtCountry);
				}

				if((dtCountry==null)||(dtCountry.Columns.Count==0))
				{
					return null;
				}

				return dtCountry;

				//this.paintList(this.listView2,"5",dtCountry);	
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return null;
			}
		}

		private void dispCountryStacMonth()
		{
			try
			{
				string strCountryName=this.trvWel.SelectedNode.Text.Trim();
				string strSql=string.Format("select depShortName from tbDep where countryName='{0}'",strCountryName);
				DataTable dt=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dt,strSql,"dep");

				DataTable dtCountry=new DataTable();
			
				for(int i=0;i<dt.Rows.Count;i++)
				{
					string strDepName=dt.Rows[i]["depShortName"].ToString();
					DataTable dtRep=this.dispDepStacMonth(strDepName);
					BengZhan.comReport.CReports.copyDt(dtRep,ref dtCountry);
				}

				if((dtCountry==null)||(dtCountry.Columns.Count==0))
				{
					return;
				}

				this.paintList(this.listView2,"5",dtCountry);	
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}		
		}
		private DataTable dispDepStacMonth(string strDepName)
		{
			this.numFrom1.Text=int.Parse(this.cmbYue1.Text.Replace("月","")).ToString();
			this.numTo1.Text=int.Parse(this.cmbYue2.Text.Replace("月","")).ToString();
			//string strDepName=this.trvWel.SelectedNode.Text.Trim();
		

			try
			{
				string strTime=this.txtYearFrom1.Text.Trim()+"-"+this.numFrom1.Text.Trim()+"-1";
				DateTime dtFrom=DateTime.Parse(strTime);
				strTime=this.txtYearTo1.Text.Trim()+"-"+this.numTo1.Text.Trim()+"-1";
				DateTime dtTo=DateTime.Parse(strTime);

				dtTo=dtTo.AddMonths(1);
				dtTo=dtTo.AddDays(-1);

				string strZhanName=strDepName;
				//单位
				DataTable dtAllSalesDep=new DataTable();
				cDealReport cdr=new cDealReport();
		
				//string[] strsTime=strTime.Split('至');
				strTime=dtFrom.ToString();
				string strTime1=dtTo.ToString();
				dtAllSalesDep=cdr.getDepDetailByEnd1(strZhanName,strTime,strTime1);
				this.removeNZ(ref dtAllSalesDep);
				return dtAllSalesDep;
				//this.dataGrid1.DataSource=dtAllSalesDep;
				//this.paintList(this.listView2,"5",dtAllSalesDep);
				//this.paintList(this.listView4,"5",dtAllSalesDep);
				//this.groupBox3.Text="售水明细表"+" "+"单位:"+strZhanName+" "+"截止时间:"+strTime;
			}
			catch(Exception ee)
			{
				MessageBox.Show("查询起始、截止时间输入有误！");
				return null;
			}
			//this.paintColor();
		}



		#endregion

		#endregion

		#region"阶梯水价补充部分"

		private DataTable m_dtPrice;

		private DataTable m_dtJTPrice;

		private void iniDtPrice()
		{
			try
			{
				if(this.m_dtPrice==null)
				{
					string strSql=string.Format("select wellName,wellNo,price1 as price from tbWell");
					DataTable dt=new DataTable();
					BengZhan.CDBConnection.getDataTable(ref dt,strSql,"dtPrice");
					this.m_dtPrice=dt;
				}	
				if(this.m_dtJTPrice==null)
				{
					this.m_dtJTPrice=new DataTable();
					string strSql=string.Format("select wellName,wellNo,price1,price2,xi1,xi2 from tbPrice");
					DataTable dt=new DataTable();
					BengZhan.CDBConnection.getDataTable(ref dt,strSql,"tbPrice");
					this.m_dtJTPrice=dt;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private string getPrice(string strWellName)
		{
			try
			{
			   //  this.iniDtPrice();
				for(int i=0;i<this.m_dtPrice.Rows.Count;i++)
				{
					if(this.m_dtPrice.Rows[i]["wellName"].ToString().Trim()==strWellName)
					{
						string strPrice=this.m_dtPrice.Rows[i]["price"].ToString().Trim();
						return strPrice;
					}
				}
				return "";
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
				return "";
			}			
		}

		private DataRow  getJTPrice(string strWellName)
		{
			try
			{
				for(int i=0;i<this.m_dtJTPrice.Rows.Count;i++)
				{
					if(this.m_dtJTPrice.Rows[i]["wellName"].ToString().Trim()==strWellName)
					{
						return this.m_dtJTPrice.Rows[i];
					}
				}
				return null;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return null;
			}
		}

		#region"阶梯水价添加"

		//月结表填阶梯水价
		public void addPriceForMonth(ref DataTable dt)
		{
			try
			{
				this.iniDtPrice();

				if(dt==null)
				{
					return;
				}

				if(dt.Columns["price"]==null)
				{
					dt.Columns.Add("price");
				}	
			
				double dAllUsedMonyEx=0;	
				double dSumUsedMony=0;

				for(int i=0;i<dt.Rows.Count;i++)
				{

					string strWellName=dt.Rows[i]["wellName"].ToString().Trim();
					string strTime=dt.Rows[i]["time"].ToString().Trim();
					
					DataRow dr=this.getJTPrice(strWellName);


					string strXi1="";
					string strXi2="";
					string strPrice1="";
					string strPrice2="";

					if(dr==null)
					{
						//	continue;
					}
					else
					{
						 strXi1=dr["xi1"].ToString();
						 strXi2=dr["xi2"].ToString();
						 strPrice1=dr["price1"].ToString();
						 strPrice2=dr["price2"].ToString();
					}	
			
				
					//DataRow dr=dt.NewRow();
					
					if(dt.Columns["salAmount"]!=null)
					{

						if((strXi1=="")||(strXi1.Trim()=="1"))
						{
							continue;
						}

						//售水月结统计

						string strAllSalAmount=dt.Rows[i]["salAmount"].ToString();
						double dAllSalAmount=double.Parse(strAllSalAmount);
						double dAllSalAmount1=dAllSalAmount*double.Parse(strXi1);
						double dAllSalAmount2=dAllSalAmount*double.Parse(strXi2);						

						string strAllSalMony=dt.Rows[i]["salMony"].ToString();
						double dAllSalMony=double.Parse(strAllSalMony);
						double dAllSalMony1=dAllSalMony*double.Parse(strXi1);
						double dAllSalMony2=dAllSalMony*double.Parse(strXi2);

						DataRow dr1=dt.NewRow();
						dr1["wellName"]=strWellName;
						dr1["salAmount"]=dAllSalAmount1.ToString();
						dr1["salMony"]=dAllSalMony1.ToString();
						dr1["price"]=strPrice1;
						dr1["time"]=dt.Rows[i]["time"].ToString();


						dt.Rows.InsertAt(dr1,i);
						i++;

						DataRow dr2=dt.NewRow();
						dr2["wellName"]=strWellName;
						dr2["salAmount"]=dAllSalAmount2.ToString();
						dr2["salMony"]=dAllSalMony2.ToString();
						dr2["time"]=dt.Rows[i]["time"].ToString();
						dr2["price"]=strPrice2;
						dt.Rows.InsertAt(dr2,i);

						i++;
						dt.Rows.RemoveAt(i);
						i--;
					}

					if(dt.Columns["allAmount"]!=null)
					{
						//用水统计表
						
						string strAllAmount=dt.Rows[i]["allAmount"].ToString().Trim();
						string strUsedMony=dt.Rows[i]["usedMony"].ToString().Trim();


						if(strXi1==""||strXi1.Trim()=="1")
						{

							if(strWellName.Trim()=="")
							{
								continue;
							}

							if((strWellName.IndexOf("合计")<0)&&(strWellName.IndexOf("总计")<0))
							{
								if(strXi1.Trim()=="1")
								{
									dSumUsedMony+=double.Parse(strUsedMony);										
								}		
								
								dAllUsedMonyEx+=double.Parse(strUsedMony);					
							}		
							else
							{
								if(strWellName.IndexOf("合计")>0)
								{
									if(dSumUsedMony!=0)
									{
										dt.Rows[i]["usedMony"]=dSumUsedMony.ToString();
									
										dSumUsedMony=0;
									}						
								}
								else
								{
									if(strWellName.IndexOf("总计")>=0)
									{
										dt.Rows[i]["usedMony"]=dAllUsedMonyEx.ToString();
										dAllUsedMonyEx=0;
									}
								}
									
							}

						

							continue;

						}


						double dAllAmount=double.Parse(strAllAmount);
						double dAllAmount1=dAllAmount*double.Parse(strXi1);
						double dAllAmount2=dAllAmount*double.Parse(strXi2);

						double dUsedMony=double.Parse(strUsedMony);
						double dUsedMony1=dAllAmount1*double.Parse(strPrice1);
						double dUsedMony2=dAllAmount2*double.Parse(strPrice2);


						dSumUsedMony+=dUsedMony1;
						dSumUsedMony+=dUsedMony2;
						dAllUsedMonyEx+=dUsedMony1;
						dAllUsedMonyEx+=dUsedMony2;

						
						DataRow dr1=dt.NewRow();
						dr1["allAmount"]=dAllAmount1.ToString();
						dr1["usedMony"]=dUsedMony1.ToString();
						dr1["price"]=strPrice1;
						dr1["wellName"]=strWellName;
						dr1["time"]=dt.Rows[i]["time"].ToString();
						dt.Rows.InsertAt(dr1,i);
						i++;

						DataRow dr2=dt.NewRow();
						dr2["wellName"]=strWellName;
						dr2["allAmount"]=dAllAmount2.ToString();
						dr2["usedMony"]=dUsedMony2.ToString();
						dr2["price"]=strPrice2;
						dr2["time"]=dt.Rows[i]["time"].ToString();
						dt.Rows.InsertAt(dr2,i);

						i++;
						dt.Rows.RemoveAt(i);
						i--;	
				
					}
				}

				for(int i=0;i<dt.Rows.Count;i++)
				{
					string strWellName=dt.Rows[i]["wellName"].ToString().Trim();
					if((dt.Rows[i]["price"]==null)||(dt.Rows[i]["price"].ToString().Trim()==""))
					{
						string strPrice=this.getPrice(strWellName);
						
						try
						{
							dt.Rows[i]["price"]=strPrice;
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.ToString()+"    ---    "+strPrice);
						}
						
					}					
				}	
				  
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		public void addPriceForDetail(ref DataTable dt)
		{
			try
			{
				this.iniDtPrice();

				if(dt.Columns["price"]==null)
				{
					dt.Columns.Add("price");
				}

				double dAllUsedMonyEx=0;	
				double dSumUsedMony=0;

				for(int i=0;i<dt.Rows.Count;i++)
				{
					string strWellName=dt.Rows[i]["wellName"].ToString().Trim();
					//Console.WriteLine(strWellName+"  "+dt.Rows[i]["allAmount"].ToString());
					string strTime=dt.Rows[i]["time"].ToString().Trim();
					
					if(strTime.IndexOf("至")<0)
					{
						//不是汇总行
						continue;
					}


					DataRow dr=this.getJTPrice(strWellName);
					
					string strXi1="";
					string strXi2="";
					string strPrice1="";
					string strPrice2="";

					
					if(dr==null)
					{
						//continue;
					}
					else
					{
						strXi1=dr["xi1"].ToString();
						strXi2=dr["xi2"].ToString();
						strPrice1=dr["price1"].ToString();
						strPrice2=dr["price2"].ToString();
					}
	
					double dUsedMonyEx=0;

					//DataRow dr=dt.NewRow();
					
					if(dt.Columns["salAmount"]!=null)
					{
						//售水统计

						if(strXi1=="")
						{
							continue;
						}

						string strAllSalAmount=dt.Rows[i]["salAmount"].ToString();
						double dAllSalAmount=double.Parse(strAllSalAmount);
						double dAllSalAmount1=dAllSalAmount*double.Parse(strXi1);
						double dAllSalAmount2=dAllSalAmount*double.Parse(strXi2);						

						string strAllSalMony=dt.Rows[i]["salMony"].ToString();
						double dAllSalMony=double.Parse(strAllSalMony);
						double dAllSalMony1=dAllSalMony*double.Parse(strXi1);
						double dAllSalMony2=dAllSalMony*double.Parse(strXi2);

						DataRow dr1=dt.NewRow();
						dr1["wellName"]=strWellName;
						dr1["salAmount"]=dAllSalAmount1.ToString();
						dr1["salMony"]=dAllSalMony1.ToString();
						dr1["price"]=strPrice1;
						dr1["time"]=dt.Rows[i]["time"].ToString();


						dt.Rows.InsertAt(dr1,i);
						i++;

						DataRow dr2=dt.NewRow();
						dr2["wellName"]=strWellName;
						dr2["salAmount"]=dAllSalAmount2.ToString();
						dr2["salMony"]=dAllSalMony2.ToString();
						dr2["time"]=dt.Rows[i]["time"].ToString();
						dt.Rows.InsertAt(dr2,i);


						i++;
						dt.Rows.RemoveAt(i);
						i--;
					}

					if(dt.Columns["allAmount"]!=null)
					{
						//用水统计表	

							string strAllAmount=dt.Rows[i]["allAmount"].ToString().Trim();
							string strUsedMony=dt.Rows[i]["usedMony"].ToString().Trim();

						
						if(strXi1==""||strXi1.Trim()=="1")
						{

							if(strWellName.Trim()=="")
							{
								continue;
							}

							if((strWellName.IndexOf("合计")<0)&&(strWellName.IndexOf("总计")<0))
							{
								if(strXi1.Trim()=="1")
								{
									dSumUsedMony+=double.Parse(strUsedMony);									
								}
								dAllUsedMonyEx+=double.Parse(strUsedMony);						
							}		
							else
							{
								if(dSumUsedMony!=0)
								{
									dt.Rows[i]["usedMony"]=dSumUsedMony.ToString();
									dSumUsedMony=0;
								}								
							}

							if(strWellName.IndexOf("总计")>=0)
							{								
								dt.Rows[i]["usedMony"]=dAllUsedMonyEx.ToString();
								dAllUsedMonyEx=0;
							}

							continue;

						}	

							double dAllAmount=double.Parse(strAllAmount);
							double dAllAmount1=dAllAmount*double.Parse(strXi1);
							double dAllAmount2=dAllAmount*double.Parse(strXi2);

							double dUsedMony=double.Parse(strUsedMony);
							double dUsedMony1=dAllAmount1*double.Parse(strPrice1);
							double dUsedMony2=dAllAmount2*double.Parse(strPrice2);

							dUsedMonyEx=dUsedMony1+dUsedMony2;

			
							dAllUsedMonyEx+=dUsedMonyEx;
							dSumUsedMony+=dUsedMonyEx;
													

							DataRow dr1=dt.NewRow();
							dr1["allAmount"]=dAllAmount1.ToString();
							dr1["usedMony"]=dUsedMony1.ToString();
							dr1["price"]=strPrice1;
							dr1["wellName"]=strWellName;
							dr1["time"]=dt.Rows[i]["time"].ToString();
							dt.Rows.InsertAt(dr1,i);
							i++;

							DataRow dr2=dt.NewRow();
							dr2["wellName"]=strWellName;
							dr2["allAmount"]=dAllAmount2.ToString();
							dr2["usedMony"]=dUsedMony2.ToString();
							dr2["price"]=strPrice2;
							dr2["time"]=dt.Rows[i]["time"].ToString();
							dt.Rows.InsertAt(dr2,i);

							i++;

				
							dt.Rows[i]["wellName"]=dt.Rows[i]["wellName"].ToString().Trim()+"合计";		
						   dt.Rows[i]["usedMony"]=dUsedMonyEx.ToString();
										
		
					}
				}

				for(int i=0;i<dt.Rows.Count;i++)
				{
					string strWellName=dt.Rows[i]["wellName"].ToString().Trim();
					if((dt.Rows[i]["price"]==null)||(dt.Rows[i]["price"].ToString().Trim()==""))
					{
						string strPrice=this.getPrice(strWellName);
						
						try
						{
							dt.Rows[i]["price"]=strPrice;
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.ToString()+"    ---    "+strPrice);
						}
						
					}					
				}					  
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}


		//总帐统计表添加阶梯水价
		public void addPriceForSum(ref DataTable dt)
		{
			try
			{
				this.iniDtPrice();

				if(dt.Columns["price"]==null)
				{
					dt.Columns.Add("price");
				}

				double dAllUsedMonyEx=0;	
				double dSumUsedMony=0;

				for(int i=0;i<dt.Rows.Count;i++)
				{

					string strWellName=dt.Rows[i]["wellName"].ToString().Trim();
					string strTime=dt.Rows[i]["time"].ToString().Trim();					

					
					DataRow dr=this.getJTPrice(strWellName);


					string strXi1="";
					string strXi2="";
					string strPrice1="";
					string strPrice2="";

					if(dr==null)
					{
						continue;
					}
					else
					{
						 strXi1=dr["xi1"].ToString();
						 strXi2=dr["xi2"].ToString();
						 strPrice1=dr["price1"].ToString();
						 strPrice2=dr["price2"].ToString();
					}					

					double dUsedMonyEx=0;				


					if(dt.Columns["allAmount"]!=null)
					{
						//用水统计表

						string strAllAmount=dt.Rows[i]["allAmount"].ToString().Trim();
						string strUsedMony="";

						try
						{
							strUsedMony=dt.Rows[i]["allUsedMony"].ToString().Trim();
						}
						catch(Exception ex)
						{
							for(int z=0;z<dt.Columns.Count;z++)
							{
								Console.WriteLine(dt.Columns[z].ColumnName);
							}
									 
							MessageBox.Show(ex.ToString());
						}
						
						if(strXi1==""||strXi1.Trim()=="1")
						{

							if(strWellName.Trim()=="")
							{
								continue;
							}

							if((strWellName.IndexOf("合计")<0)&&(strWellName.IndexOf("总计")<0))
							{
								if(strXi1.Trim()=="1")
								{
									dSumUsedMony+=double.Parse(strUsedMony);
								}									
								dAllUsedMonyEx+=double.Parse(strUsedMony);								
							}		
							else
							{
								if(dSumUsedMony!=0)
								{
									dt.Rows[i]["allUsedMony"]=dSumUsedMony.ToString();
									double dAllMonyHeji=double.Parse(dt.Rows[i]["allMony"].ToString());
									dt.Rows[i]["leftMony"]=Convert.ToString(dAllMonyHeji-dSumUsedMony);
									dSumUsedMony=0;
								}			
							}

							if(strWellName.IndexOf("总计")>=0)
							{
								dt.Rows[i]["usedMony"]=dAllUsedMonyEx.ToString();
								dAllUsedMonyEx=0;
							}

							continue;

						}	
						
						string strAllMony=dt.Rows[i]["allMony"].ToString().Trim();
						

							double dAllAmount=double.Parse(strAllAmount);
							double dAllAmount1=dAllAmount*double.Parse(strXi1);
							double dAllAmount2=dAllAmount*double.Parse(strXi2);

					
							double dUsedMony1=dAllAmount1*double.Parse(strPrice1);
							double dUsedMony2=dAllAmount2*double.Parse(strPrice2);

							double dAllMony=double.Parse(strAllMony);
							double dAllMony1=dAllMony*double.Parse(strXi1);
							double dAllMony2=dAllMony*double.Parse(strXi2);

							double dLeftAmount=double.Parse(dt.Rows[i]["leftAmount"].ToString());
							double dLeftAmount1=dLeftAmount*double.Parse(strXi1);
							double dLeftAmount2=dLeftAmount*double.Parse(strXi2);

							DataRow dr1=dt.NewRow();
							dr1["allMony"]=dAllMony1.ToString();
							dr1["allAmount"]=dAllAmount1.ToString();
						dr1["leftMony"]=Convert.ToString(dAllMony1-dUsedMony1);
						dr1["leftAmount"]=dLeftAmount1.ToString();
						dr1["wellName"]=dt.Rows[i]["wellName"].ToString();
						dr1["time"]=dt.Rows[i]["time"].ToString();

						dt.Rows.InsertAt(dr1,i);
						i++;

						DataRow dr2=dt.NewRow();
						dr2["allMony"]=dAllMony2.ToString();
						dr2["allAmount"]=dAllAmount2.ToString();
						dr2["leftMony"]=Convert.ToString(dAllMony2-dUsedMony2);
						dr2["leftAmount"]=dLeftAmount2.ToString();
						dr2["wellName"]=dt.Rows[i]["wellName"].ToString();
						dr2["time"]=dt.Rows[i]["time"].ToString();

						dt.Rows.InsertAt(dr2,i);
						i++;


						dUsedMonyEx=dUsedMony1+dUsedMony2;

					
						dAllUsedMonyEx+=dUsedMonyEx;
						dSumUsedMony+=dUsedMonyEx;
						
						dt.Rows.RemoveAt(i);
						i--;	
					
					}
				}

				for(int i=0;i<dt.Rows.Count;i++)
				{
					string strWellName=dt.Rows[i]["wellName"].ToString().Trim();
					if((dt.Rows[i]["price"]==null)||(dt.Rows[i]["price"].ToString().Trim()==""))
					{
						string strPrice=this.getPrice(strWellName);
						//Console.WriteLine(strPrice);
						try
						{
							dt.Rows[i]["price"]=strPrice;
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.ToString()+"    ---    "+strPrice);
						}
						
					}					
				}					  
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		#endregion 	

		private double getSumVal(DataTable dt,int iStart,int iLen)
		{

			try
			{
				double dSum=0;

				for(int i=iStart;i<(iStart+iLen);i++)
				{
					//Console.WriteLine(dt.Rows[i]["usedMony"].ToString());
					dSum+=double.Parse(dt.Rows[i]["usedMony"].ToString());
				}

				return dSum;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return -1;
			}
		}
		private void removeZhanItem(System.Windows.Forms.ListView lsv)
		{
			try
			{
				for(int i=0;i<lsv.Items.Count;i++)
				{
					if((lsv.Items[i].Text.IndexOf("合计")>=0)||(lsv.Items[i].Text.IndexOf("总计")>=0))
					{
					}
					else
					{
						lsv.Items.RemoveAt(i);
						i--;
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		#endregion		

		private void numTo1_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void listView4_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		}
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
namespace BengZhan.bengzhans
{
	/// <summary>
	/// frmDataEditItems 的摘要说明。
	/// </summary>
	public class frmDataEditItems : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbName;
		private System.Windows.Forms.DateTimePicker dtDate;
		private System.Windows.Forms.NumericUpDown numHour;
		private System.Windows.Forms.NumericUpDown numMin;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label labType;
		private System.Windows.Forms.Label lab;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtCL;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtWaterLevel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private string m_sName;
		private System.Windows.Forms.Button btnQu;
		private System.Windows.Forms.TextBox txtLS;
		private System.Windows.Forms.TextBox txtLLS;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtLLH;
		private System.Windows.Forms.Label label13;
		private int m_sID=0;
		private int m_Type=0;
		private double b=0;
		private double m=0;
		private double i=0;
		private double w=0;
		private System.Windows.Forms.Label labBase;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label labTop;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label labI;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label labM;
		private System.Windows.Forms.Label label21;
		private bool m_Edit=false;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label labMidW;
		private System.Windows.Forms.TextBox txtWaterLevel2;
		private System.Windows.Forms.TextBox txtBXELLS;
		private System.Windows.Forms.TextBox txtBXELLH;
		private string m_Value="";
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Button btnExit2;
		private System.Windows.Forms.Button btnOK2;
		private System.Windows.Forms.TextBox txtWaterLevel3;
		private System.Windows.Forms.TextBox txtLRLLS;
		private System.Windows.Forms.TextBox txtLRLLH;
		private DateTime m_dt;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.TextBox txtLRLS;
		private System.Windows.Forms.Label label33;
		private string m_wll;
		private string m_DataID;
		public frmDataEditItems(string sName,string Value,DateTime dt,string wll,string dID)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			m_sName=sName;
			m_Value=Value;
			m_Edit=true;
			m_dt=dt;
			m_wll=wll;
			m_DataID=dID;
			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		public frmDataEditItems()
		{
			InitializeComponent();
			m_Edit=false;
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
			this.cmbName = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dtDate = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.numHour = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.numMin = new System.Windows.Forms.NumericUpDown();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label25 = new System.Windows.Forms.Label();
			this.txtBXELLH = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.txtBXELLS = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.txtWaterLevel2 = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.labMidW = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.labType = new System.Windows.Forms.Label();
			this.lab = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.labI = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.labM = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.labTop = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.txtLLH = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtLLS = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtLS = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtCL = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtWaterLevel = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnQu = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.labBase = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button3 = new System.Windows.Forms.Button();
			this.txtLRLLH = new System.Windows.Forms.TextBox();
			this.label31 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.txtLRLLS = new System.Windows.Forms.TextBox();
			this.label28 = new System.Windows.Forms.Label();
			this.txtWaterLevel3 = new System.Windows.Forms.TextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.btnExit2 = new System.Windows.Forms.Button();
			this.btnOK2 = new System.Windows.Forms.Button();
			this.label32 = new System.Windows.Forms.Label();
			this.txtLRLS = new System.Windows.Forms.TextBox();
			this.label33 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numHour)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmbName
			// 
			this.cmbName.Location = new System.Drawing.Point(88, 11);
			this.cmbName.Name = "cmbName";
			this.cmbName.Size = new System.Drawing.Size(240, 20);
			this.cmbName.TabIndex = 0;
			this.cmbName.Text = "comboBox1";
			this.cmbName.SelectedIndexChanged += new System.EventHandler(this.cmbName_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "测站名称：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "录入时间：";
			// 
			// dtDate
			// 
			this.dtDate.Location = new System.Drawing.Point(88, 40);
			this.dtDate.Name = "dtDate";
			this.dtDate.Size = new System.Drawing.Size(120, 21);
			this.dtDate.TabIndex = 3;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(248, 40);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(16, 23);
			this.label9.TabIndex = 12;
			this.label9.Text = "时";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numHour
			// 
			this.numHour.Location = new System.Drawing.Point(208, 40);
			this.numHour.Maximum = new System.Decimal(new int[] {
																	23,
																	0,
																	0,
																	0});
			this.numHour.Name = "numHour";
			this.numHour.Size = new System.Drawing.Size(40, 21);
			this.numHour.TabIndex = 11;
			this.numHour.Value = new System.Decimal(new int[] {
																  8,
																  0,
																  0,
																  0});
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(312, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 23);
			this.label3.TabIndex = 14;
			this.label3.Text = "分";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numMin
			// 
			this.numMin.Location = new System.Drawing.Point(272, 40);
			this.numMin.Maximum = new System.Decimal(new int[] {
																   59,
																   0,
																   0,
																   0});
			this.numMin.Name = "numMin";
			this.numMin.Size = new System.Drawing.Size(40, 21);
			this.numMin.TabIndex = 13;
			this.numMin.Value = new System.Decimal(new int[] {
																 30,
																 0,
																 0,
																 0});
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(8, 72);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(328, 400);
			this.tabControl1.TabIndex = 15;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.labType);
			this.tabPage1.Controls.Add(this.lab);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Controls.Add(this.btnExit);
			this.tabPage1.Controls.Add(this.btnOK);
			this.tabPage1.Location = new System.Drawing.Point(4, 21);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(320, 375);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "公式计算数据";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label25);
			this.groupBox2.Controls.Add(this.txtBXELLH);
			this.groupBox2.Controls.Add(this.label24);
			this.groupBox2.Controls.Add(this.label22);
			this.groupBox2.Controls.Add(this.label23);
			this.groupBox2.Controls.Add(this.txtBXELLS);
			this.groupBox2.Controls.Add(this.label20);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.txtWaterLevel2);
			this.groupBox2.Controls.Add(this.label18);
			this.groupBox2.Controls.Add(this.labMidW);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Location = new System.Drawing.Point(8, 40);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(304, 288);
			this.groupBox2.TabIndex = 25;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "巴歇尔量水槽";
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(252, 84);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(17, 17);
			this.label25.TabIndex = 56;
			this.label25.Text = "米";
			// 
			// txtBXELLH
			// 
			this.txtBXELLH.Location = new System.Drawing.Point(88, 236);
			this.txtBXELLH.Name = "txtBXELLH";
			this.txtBXELLH.ReadOnly = true;
			this.txtBXELLH.Size = new System.Drawing.Size(128, 21);
			this.txtBXELLH.TabIndex = 55;
			this.txtBXELLH.Text = "0";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(8, 240);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(66, 17);
			this.label24.TabIndex = 54;
			this.label24.Text = "计算流量：";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(224, 240);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(72, 17);
			this.label22.TabIndex = 53;
			this.label22.Text = "立方米/小时";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(230, 196);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(60, 17);
			this.label23.TabIndex = 52;
			this.label23.Text = "立方米/秒";
			// 
			// txtBXELLS
			// 
			this.txtBXELLS.Location = new System.Drawing.Point(88, 192);
			this.txtBXELLS.Name = "txtBXELLS";
			this.txtBXELLS.ReadOnly = true;
			this.txtBXELLS.Size = new System.Drawing.Size(128, 21);
			this.txtBXELLS.TabIndex = 51;
			this.txtBXELLS.Text = "0";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(8, 196);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(66, 17);
			this.label20.TabIndex = 50;
			this.label20.Text = "计算流量：";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 136);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(288, 24);
			this.button1.TabIndex = 49;
			this.button1.Text = "计算";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtWaterLevel2
			// 
			this.txtWaterLevel2.Location = new System.Drawing.Point(88, 80);
			this.txtWaterLevel2.Name = "txtWaterLevel2";
			this.txtWaterLevel2.Size = new System.Drawing.Size(128, 21);
			this.txtWaterLevel2.TabIndex = 48;
			this.txtWaterLevel2.Text = "0";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(8, 84);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(66, 17);
			this.label18.TabIndex = 47;
			this.label18.Text = "测量水位：";
			// 
			// labMidW
			// 
			this.labMidW.AutoSize = true;
			this.labMidW.Location = new System.Drawing.Point(88, 40);
			this.labMidW.Name = "labMidW";
			this.labMidW.Size = new System.Drawing.Size(66, 17);
			this.labMidW.TabIndex = 45;
			this.labMidW.Text = "读数据类型";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(8, 40);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(66, 17);
			this.label16.TabIndex = 46;
			this.label16.Text = "渠底宽度：";
			// 
			// labType
			// 
			this.labType.AutoSize = true;
			this.labType.Location = new System.Drawing.Point(88, 16);
			this.labType.Name = "labType";
			this.labType.Size = new System.Drawing.Size(91, 17);
			this.labType.TabIndex = 0;
			this.labType.Text = "读数据渠道类型";
			// 
			// lab
			// 
			this.lab.AutoSize = true;
			this.lab.Location = new System.Drawing.Point(16, 16);
			this.lab.Name = "lab";
			this.lab.Size = new System.Drawing.Size(66, 17);
			this.lab.TabIndex = 18;
			this.lab.Text = "渠道类型：";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.labI);
			this.groupBox1.Controls.Add(this.label19);
			this.groupBox1.Controls.Add(this.labM);
			this.groupBox1.Controls.Add(this.label21);
			this.groupBox1.Controls.Add(this.labTop);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.txtLLH);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.txtLLS);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtLS);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtCL);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtWaterLevel);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.btnQu);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.labBase);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Location = new System.Drawing.Point(8, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(304, 288);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "明渠均匀流计算";
			// 
			// labI
			// 
			this.labI.AutoSize = true;
			this.labI.Location = new System.Drawing.Point(232, 56);
			this.labI.Name = "labI";
			this.labI.Size = new System.Drawing.Size(66, 17);
			this.labI.TabIndex = 43;
			this.labI.Text = "读数据类型";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(160, 56);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(66, 17);
			this.label19.TabIndex = 44;
			this.label19.Text = "纵坡系数：";
			// 
			// labM
			// 
			this.labM.AutoSize = true;
			this.labM.Location = new System.Drawing.Point(80, 56);
			this.labM.Name = "labM";
			this.labM.Size = new System.Drawing.Size(66, 17);
			this.labM.TabIndex = 41;
			this.labM.Text = "读数据类型";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(8, 56);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(66, 17);
			this.label21.TabIndex = 42;
			this.label21.Text = "边坡系数：";
			// 
			// labTop
			// 
			this.labTop.AutoSize = true;
			this.labTop.Location = new System.Drawing.Point(232, 24);
			this.labTop.Name = "labTop";
			this.labTop.Size = new System.Drawing.Size(66, 17);
			this.labTop.TabIndex = 39;
			this.labTop.Text = "读数据类型";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(160, 24);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(66, 17);
			this.label17.TabIndex = 40;
			this.label17.Text = "开口宽度：";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(224, 256);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(72, 17);
			this.label12.TabIndex = 38;
			this.label12.Text = "立方米/小时";
			// 
			// txtLLH
			// 
			this.txtLLH.Location = new System.Drawing.Point(88, 252);
			this.txtLLH.Name = "txtLLH";
			this.txtLLH.ReadOnly = true;
			this.txtLLH.Size = new System.Drawing.Size(128, 21);
			this.txtLLH.TabIndex = 37;
			this.txtLLH.Text = "0";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(8, 256);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(66, 17);
			this.label13.TabIndex = 36;
			this.label13.Text = "计算流量：";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(230, 224);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(60, 17);
			this.label10.TabIndex = 35;
			this.label10.Text = "立方米/秒";
			// 
			// txtLLS
			// 
			this.txtLLS.Location = new System.Drawing.Point(88, 220);
			this.txtLLS.Name = "txtLLS";
			this.txtLLS.ReadOnly = true;
			this.txtLLS.Size = new System.Drawing.Size(128, 21);
			this.txtLLS.TabIndex = 34;
			this.txtLLS.Text = "0";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(8, 224);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(66, 17);
			this.label11.TabIndex = 33;
			this.label11.Text = "计算流量：";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(243, 192);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 17);
			this.label7.TabIndex = 32;
			this.label7.Text = "米/秒";
			// 
			// txtLS
			// 
			this.txtLS.Location = new System.Drawing.Point(88, 188);
			this.txtLS.Name = "txtLS";
			this.txtLS.ReadOnly = true;
			this.txtLS.Size = new System.Drawing.Size(128, 21);
			this.txtLS.TabIndex = 31;
			this.txtLS.Text = "0";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(8, 192);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(66, 17);
			this.label8.TabIndex = 30;
			this.label8.Text = "计算流速：";
			// 
			// txtCL
			// 
			this.txtCL.Location = new System.Drawing.Point(88, 123);
			this.txtCL.Name = "txtCL";
			this.txtCL.Size = new System.Drawing.Size(128, 21);
			this.txtCL.TabIndex = 29;
			this.txtCL.Text = "0";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 127);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 17);
			this.label6.TabIndex = 28;
			this.label6.Text = "糙率系数：";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(252, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(17, 17);
			this.label5.TabIndex = 27;
			this.label5.Text = "米";
			// 
			// txtWaterLevel
			// 
			this.txtWaterLevel.Location = new System.Drawing.Point(88, 92);
			this.txtWaterLevel.Name = "txtWaterLevel";
			this.txtWaterLevel.Size = new System.Drawing.Size(128, 21);
			this.txtWaterLevel.TabIndex = 26;
			this.txtWaterLevel.Text = "0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 17);
			this.label4.TabIndex = 25;
			this.label4.Text = "测量水位：";
			// 
			// btnQu
			// 
			this.btnQu.Location = new System.Drawing.Point(228, 120);
			this.btnQu.Name = "btnQu";
			this.btnQu.Size = new System.Drawing.Size(64, 24);
			this.btnQu.TabIndex = 24;
			this.btnQu.Text = "查糙率表";
			this.btnQu.Click += new System.EventHandler(this.btnQu_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(8, 152);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(288, 24);
			this.button2.TabIndex = 18;
			this.button2.Text = "计算";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// labBase
			// 
			this.labBase.AutoSize = true;
			this.labBase.Location = new System.Drawing.Point(80, 24);
			this.labBase.Name = "labBase";
			this.labBase.Size = new System.Drawing.Size(66, 17);
			this.labBase.TabIndex = 25;
			this.labBase.Text = "读数据类型";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(8, 24);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(66, 17);
			this.label15.TabIndex = 26;
			this.label15.Text = "渠底宽度：";
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(232, 344);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(72, 24);
			this.btnExit.TabIndex = 17;
			this.btnExit.Text = "取消";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(160, 344);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(72, 24);
			this.btnOK.TabIndex = 16;
			this.btnOK.Text = "保存";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label32);
			this.tabPage2.Controls.Add(this.txtLRLS);
			this.tabPage2.Controls.Add(this.label33);
			this.tabPage2.Controls.Add(this.button3);
			this.tabPage2.Controls.Add(this.txtLRLLH);
			this.tabPage2.Controls.Add(this.label31);
			this.tabPage2.Controls.Add(this.label30);
			this.tabPage2.Controls.Add(this.label29);
			this.tabPage2.Controls.Add(this.txtLRLLS);
			this.tabPage2.Controls.Add(this.label28);
			this.tabPage2.Controls.Add(this.txtWaterLevel3);
			this.tabPage2.Controls.Add(this.label27);
			this.tabPage2.Controls.Add(this.label14);
			this.tabPage2.Controls.Add(this.btnExit2);
			this.tabPage2.Controls.Add(this.btnOK2);
			this.tabPage2.Location = new System.Drawing.Point(4, 21);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(320, 375);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "测量录入数据";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(16, 200);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(288, 24);
			this.button3.TabIndex = 65;
			this.button3.Text = "计算";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// txtLRLLH
			// 
			this.txtLRLLH.Location = new System.Drawing.Point(88, 244);
			this.txtLRLLH.Name = "txtLRLLH";
			this.txtLRLLH.ReadOnly = true;
			this.txtLRLLH.Size = new System.Drawing.Size(128, 21);
			this.txtLRLLH.TabIndex = 64;
			this.txtLRLLH.Text = "0";
			this.txtLRLLH.TextChanged += new System.EventHandler(this.txtLRLLH_TextChanged);
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Location = new System.Drawing.Point(8, 248);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(66, 17);
			this.label31.TabIndex = 63;
			this.label31.Text = "测量流量：";
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(232, 248);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(72, 17);
			this.label30.TabIndex = 62;
			this.label30.Text = "立方米/小时";
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(238, 144);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(60, 17);
			this.label29.TabIndex = 61;
			this.label29.Text = "立方米/秒";
			// 
			// txtLRLLS
			// 
			this.txtLRLLS.Location = new System.Drawing.Point(88, 140);
			this.txtLRLLS.Name = "txtLRLLS";
			this.txtLRLLS.Size = new System.Drawing.Size(128, 21);
			this.txtLRLLS.TabIndex = 60;
			this.txtLRLLS.Text = "0";
			this.txtLRLLS.TextChanged += new System.EventHandler(this.txtLRLLS_TextChanged);
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(8, 64);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(66, 17);
			this.label28.TabIndex = 59;
			this.label28.Text = "测量水位：";
			// 
			// txtWaterLevel3
			// 
			this.txtWaterLevel3.Location = new System.Drawing.Point(88, 60);
			this.txtWaterLevel3.Name = "txtWaterLevel3";
			this.txtWaterLevel3.Size = new System.Drawing.Size(128, 21);
			this.txtWaterLevel3.TabIndex = 58;
			this.txtWaterLevel3.Text = "0";
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(8, 144);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(66, 17);
			this.label27.TabIndex = 57;
			this.label27.Text = "测量流量：";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(260, 64);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(17, 17);
			this.label14.TabIndex = 56;
			this.label14.Text = "米";
			// 
			// btnExit2
			// 
			this.btnExit2.Location = new System.Drawing.Point(232, 344);
			this.btnExit2.Name = "btnExit2";
			this.btnExit2.Size = new System.Drawing.Size(72, 24);
			this.btnExit2.TabIndex = 19;
			this.btnExit2.Text = "取消";
			this.btnExit2.Click += new System.EventHandler(this.btnExit2_Click);
			// 
			// btnOK2
			// 
			this.btnOK2.Location = new System.Drawing.Point(160, 344);
			this.btnOK2.Name = "btnOK2";
			this.btnOK2.Size = new System.Drawing.Size(72, 24);
			this.btnOK2.TabIndex = 18;
			this.btnOK2.Text = "保存";
			this.btnOK2.Click += new System.EventHandler(this.btnOK2_Click);
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Location = new System.Drawing.Point(251, 104);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(35, 17);
			this.label32.TabIndex = 68;
			this.label32.Text = "米/秒";
			// 
			// txtLRLS
			// 
			this.txtLRLS.Location = new System.Drawing.Point(88, 100);
			this.txtLRLS.Name = "txtLRLS";
			this.txtLRLS.Size = new System.Drawing.Size(128, 21);
			this.txtLRLS.TabIndex = 67;
			this.txtLRLS.Text = "0";
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Location = new System.Drawing.Point(8, 104);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(66, 17);
			this.label33.TabIndex = 66;
			this.label33.Text = "测量流速：";
			// 
			// frmDataEditItems
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(346, 480);
			this.ControlBox = false;
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.numMin);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.numHour);
			this.Controls.Add(this.dtDate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "frmDataEditItems";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "手工录入数据";
			this.Load += new System.EventHandler(this.frmDataEditItems_Load);
			((System.ComponentModel.ISupportInitialize)(this.numHour)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void LoadStationInfo()
		{
			try
			{
				string strSql=string.Format("select * from tbw_WellInfo where WellID='{0}'",m_sID.ToString());
				DataTable dtWell=null;
				CDBConnection.getDataTable(ref dtWell,strSql,"tbw_WellInfo");
				b=double.Parse(dtWell.Rows[0]["BaseW"].ToString());
				m=double.Parse(dtWell.Rows[0]["BPm"].ToString());
				i=double.Parse(dtWell.Rows[0]["ZPi"].ToString());
				w=double.Parse(dtWell.Rows[0]["middleW"].ToString());
				m_Type=int.Parse(dtWell.Rows[0]["DataType"].ToString());
				if(m_Type==0)
				{
					labType.Text="明渠均匀流";
					this.groupBox1.Visible=true;
					groupBox2.Visible=false;
				}
				else
				{
					labType.Text="巴歇尔量水槽";
					this.groupBox2.Visible=true;
					groupBox1.Visible=false;
				}

				labBase.Text=b.ToString();
				labTop.Text=dtWell.Rows[0]["TopW"].ToString();
				labM.Text=m.ToString();
				labI.Text=i.ToString();
				labMidW.Text=w.ToString();
			}
			catch
			{
			}
		}

		private void frmDataEditItems_Load(object sender, System.EventArgs e)
		{
			try
			{
				string strSql="";
				DataTable dtWell=null;
				if(m_Edit)
				{
					cmbName.Text=m_sName;
					txtWaterLevel.Text=m_Value;
					txtWaterLevel2.Text=m_Value;
					dtDate.Value=m_dt;
					numHour.Value=m_dt.Hour ;
					numMin.Value=m_dt.Minute;

//					this.txtDT.Text=m_dt.ToString();
					txtWaterLevel3.Text=m_Value;
					txtLRLLH.Text=m_wll;
				}
				else
				{
					dtDate.Value=DateTime.Now;
					numHour.Value=DateTime.Now.Hour;
					numMin.Value=DateTime.Now.Minute;
					strSql=string.Format("select wellNo,wellName from tbWell");
					CDBConnection.getDataTable(ref dtWell,strSql,"tbWell");
					for(int i=0;i<dtWell.Rows.Count;i++)
					{
						cmbName.Items.Add(dtWell.Rows[i]["wellName"].ToString());
					}
					cmbName.Text=cmbName.Items[0].ToString();
				}
				strSql=string.Format("select wellNo,wellName from tbWell where wellName='{0}'",m_sName);
				CDBConnection.getDataTable(ref dtWell,strSql,"tbWell");
				m_sID=int.Parse(dtWell.Rows[0]["wellNo"].ToString());
				LoadStationInfo();
			}
			catch
			{
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			try
			{
				double h=0;
				double n=0;
				try
				{
					h=double.Parse(txtWaterLevel.Text.Trim());
					n=double.Parse(txtCL.Text.Trim());
				}
				catch
				{
					MessageBox.Show("数据输入格式错误");
					return;
				}
				double A=(b+m*h)*h;//过水面积
				double middle=0;
				middle=Math.Pow(m,2);
				double x=Math.Pow((1+middle),0.5);//湿周
				x=b+2*h*x;
				double R=A/x;//水利半径
				double middle1=1;
				double middle2=6;
				middle=middle1/middle2;
				double C=Math.Pow(R,middle);//谢才系数
				C=C/n;
				middle=R/i;
				double LS=Math.Pow(middle,0.5); //流速
				LS=Math.Round(LS *C,4);

				double LL=A*LS; //流量 单位 m3/s
				middle=Math.Round(LL,4);
				txtLLS.Text=middle.ToString();
				LL=Math.Round(LL*3600,2);   //转换单位  m3/h

				txtLS.Text=LS.ToString();
				txtLLH.Text=LL.ToString();
			}
			catch
			{
			}
		}

		private bool checkdatas()
		{
			try
			{
				double check=0;
				if(txtLLH.Text.Trim()!="非数字")
				{
					check=double.Parse(txtLLH.Text.Trim());
					check=double.Parse(txtLLS.Text.Trim());
					check=double.Parse(txtLS.Text.Trim());
					check=double.Parse(txtWaterLevel.Text.Trim());
				}
				else
					return false;

				if(txtBXELLH.Text.Trim()!="非数字")
				{
					check=double.Parse(txtBXELLH.Text.Trim());
					check=double.Parse(txtBXELLS.Text.Trim());
					check=double.Parse(txtWaterLevel2.Text.Trim());
				}
				else
					return false;
				if(txtLRLLH.Text.Trim()!="非数字")
				{
					check=double.Parse(txtWaterLevel3.Text.Trim());
					check=double.Parse(txtLRLLH.Text.Trim());
					check=double.Parse(txtLRLS.Text.Trim());
					check=double.Parse(txtLRLLS.Text.Trim());
				}
				else
					return false;
			}
			catch
			{
				MessageBox.Show("数据格式不符");
				return false;
			}
			return true;
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void cmbName_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
				m_sName=cmbName.Text;
				string strSql=string.Format("select wellNo,wellName from tbWell where wellName='{0}'",m_sName);
				DataTable dtWell=null;
				CDBConnection.getDataTable(ref dtWell,strSql,"tbWell");
				m_sID=int.Parse(dtWell.Rows[0]["wellNo"].ToString());
				LoadStationInfo();
			}

			catch
			{
			}
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(!checkdatas())
				{
					return;
				}
				DateTime dt=DateTime.Parse(dtDate.Value.ToShortDateString()+" "+numHour.Value.ToString()+":"+numMin.Value.ToString()+":00");
				string strSql="";
				if(m_Type==0)
				{
					if(!m_Edit)
					{
						strSql=string.Format("insert into tbw_waterDatas(watNo,name,allAmount,amount,waterLevel,Speed,Samount,time,exp) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",this.m_sID.ToString(),this.m_sName,"0",this.txtLLH.Text.Trim(),this.txtWaterLevel.Text.Trim(),txtLS.Text.Trim(),txtLLS.Text.Trim(),dt.ToString(),"手动添加数据");
					}
					else
					{
						strSql=string.Format("update tbw_waterDatas set watNo='{0}',name='{1}',allAmount='{2}',amount='{3}',waterLevel='{4}',Speed='{5}',Samount='{6}',time='{7}',exp='{8}' where ID='{9}'",this.m_sID.ToString(),this.m_sName,"0",this.txtLLH.Text.Trim(),this.txtWaterLevel.Text.Trim(),this.txtLS.Text.Trim(),this.txtLLS.Text.Trim(),dt.ToString(),"手动添加数据",m_DataID);
					}
				}
				else
				{
					if(!m_Edit)
					{
						strSql=string.Format("insert into tbw_waterDatas(watNo,name,allAmount,amount,waterLevel,Speed,Samount,time,exp) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",this.m_sID.ToString(),this.m_sName,"0",this.txtBXELLH.Text.Trim(),this.txtWaterLevel2.Text.Trim(),"0",txtBXELLS.Text.Trim(),dt.ToString(),"手动添加数据");
					}
					else
					{
						strSql=string.Format("update tbw_waterDatas set watNo='{0}',name='{1}',allAmount='{2}',amount='{3}',waterLevel='{4}',Speed='{5}',Samount='{6}',time='{7}',exp='{8}' where ID='{9}'",this.m_sID.ToString(),this.m_sName,"0",this.txtBXELLH.Text.Trim(),this.txtWaterLevel2.Text.Trim(),"0",this.txtBXELLS.Text.Trim(),dt.ToString(),"手动添加数据",m_DataID);
					}
				}
				BengZhan.CDBConnection.ExecuteSql(strSql);
				this.Close();
			}
			catch
			{
				this.Close();
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			try
			{
				double h=0;
			
				try
				{
					h=double.Parse(txtWaterLevel2.Text.Trim());
				}
				catch
				{
					MessageBox.Show("数据输入格式错误");
					return;
				}

				double mindata=Math.Pow(w,0.026);
				mindata=mindata*1.569;
				double mindata1=0.305;
				double QLL=h/mindata1;
				QLL=Math.Pow(QLL,mindata);
				mindata1=0.372;
				QLL=QLL*w*mindata1;
				mindata1=Math.Round(QLL,4);
				txtBXELLS.Text=mindata1.ToString();
				QLL=QLL*3600;
				QLL=Math.Round(QLL,2);
				txtBXELLH.Text=QLL.ToString();
			}
			catch
			{
			}
		}

		private void btnExit2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void txtLRLLS_TextChanged(object sender, System.EventArgs e)
		{
			
		}

		private void txtLRLLH_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void btnOK2_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(!checkdatas())
				{
					return;
				}
				DateTime dt=DateTime.Parse(dtDate.Value.ToShortDateString()+" "+numHour.Value.ToString()+":"+numMin.Value.ToString()+":00");
				string strSql="";
				if(!m_Edit)
				{
					strSql=string.Format("insert into tbw_waterDatas(watNo,name,allAmount,amount,waterLevel,Speed,Samount,time,exp) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",this.m_sID.ToString(),this.m_sName,"0",this.txtLRLLH.Text.Trim(),this.txtWaterLevel3.Text.Trim(),this.txtLRLS.Text.Trim(),this.txtLRLLS.Text.Trim(),dt.ToString(),"手动添加数据");
				}
				else
				{
					strSql=string.Format("update tbw_waterDatas set watNo='{0}',name='{1}',allAmount='{2}',amount='{3}',waterLevel='{4}',Speed='{5}',Samount='{6}',time='{7}',exp='{8}' where ID='{9}'",this.m_sID.ToString(),this.m_sName,"0",this.txtLRLLH.Text.Trim(),this.txtWaterLevel3.Text.Trim(),this.txtLRLS.Text.Trim(),this.txtLRLLS.Text.Trim(),dt.ToString(),"手动添加数据",m_DataID);
				}
				BengZhan.CDBConnection.ExecuteSql(strSql);
				this.Close();
			}
			catch
			{
				this.Close();
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			double lrLLS;
			try
			{
				lrLLS=double.Parse(txtLRLLS.Text.Trim());
			}
			catch
			{
				return;
			}
			double lrLLH=lrLLS*3600;
			txtLRLLH.Text=lrLLH.ToString();
		}

		private void btnQu_Click(object sender, System.EventArgs e)
		{
			frmGLDatas f=new frmGLDatas();
			f.ShowDialog();
		}
	}
}

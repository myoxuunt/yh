using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BengZhan.bengzhans
{
	/// <summary>
	/// frmBengZhanEdit 的摘要说明。
	/// </summary>
	public class frmBengZhanEdit : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtWellNo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtWellName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtGprsNo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtAddress;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public bool m_bInserted=false;
		public bool m_bEdit=false;
		public string m_strWellNo="";
		private System.Windows.Forms.TextBox txtDepShortName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtX;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtY;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtICNo;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtWatNo;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtWarnLevel;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtXi;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtIniAmount;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtDes;
		private System.Windows.Forms.CheckBox chkJTS;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ComboBox cmbPrice;
		private System.Windows.Forms.TextBox txtPrice1;
		private System.Windows.Forms.TextBox txtPrice2;
		private System.Windows.Forms.Button button1;
		public string m_strDepName="";

		//标志是否

		public frmBengZhanEdit()
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtPrice2 = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.txtPrice1 = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.cmbPrice = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.chkJTS = new System.Windows.Forms.CheckBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtIniAmount = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtXi = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtWarnLevel = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtWatNo = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtY = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtX = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtDepShortName = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtGprsNo = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtWellName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtWellNo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.txtICNo = new System.Windows.Forms.TextBox();
			this.txtDes = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtPrice2);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.txtPrice1);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.cmbPrice);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.chkJTS);
			this.groupBox1.Controls.Add(this.txtPrice);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.txtIniAmount);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.txtXi);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.txtWarnLevel);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.txtWatNo);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.txtY);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtX);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtDepShortName);
			this.groupBox1.Controls.Add(this.txtAddress);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtGprsNo);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtWellName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtWellNo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(464, 280);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// txtPrice2
			// 
			this.txtPrice2.Location = new System.Drawing.Point(328, 240);
			this.txtPrice2.Name = "txtPrice2";
			this.txtPrice2.Size = new System.Drawing.Size(128, 21);
			this.txtPrice2.TabIndex = 33;
			this.txtPrice2.Text = "";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(240, 240);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(80, 23);
			this.label16.TabIndex = 32;
			this.label16.Text = "范围外水价：";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPrice1
			// 
			this.txtPrice1.Location = new System.Drawing.Point(112, 240);
			this.txtPrice1.Name = "txtPrice1";
			this.txtPrice1.Size = new System.Drawing.Size(120, 21);
			this.txtPrice1.TabIndex = 31;
			this.txtPrice1.Text = "";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(16, 240);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(88, 23);
			this.label15.TabIndex = 30;
			this.label15.Text = "范围内水价：";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbPrice
			// 
			this.cmbPrice.Location = new System.Drawing.Point(328, 208);
			this.cmbPrice.Name = "cmbPrice";
			this.cmbPrice.Size = new System.Drawing.Size(128, 20);
			this.cmbPrice.TabIndex = 29;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(232, 208);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 23);
			this.label6.TabIndex = 28;
			this.label6.Text = "百分比：";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// chkJTS
			// 
			this.chkJTS.Location = new System.Drawing.Point(112, 208);
			this.chkJTS.Name = "chkJTS";
			this.chkJTS.Size = new System.Drawing.Size(120, 24);
			this.chkJTS.TabIndex = 27;
			this.chkJTS.Text = "应用阶梯水价";
			this.chkJTS.CheckedChanged += new System.EventHandler(this.chkJTS_CheckedChanged);
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(328, 176);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(128, 21);
			this.txtPrice.TabIndex = 26;
			this.txtPrice.Text = "";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(248, 176);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(80, 23);
			this.label14.TabIndex = 25;
			this.label14.Text = "水价：";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtIniAmount
			// 
			this.txtIniAmount.Location = new System.Drawing.Point(328, 144);
			this.txtIniAmount.Name = "txtIniAmount";
			this.txtIniAmount.Size = new System.Drawing.Size(128, 21);
			this.txtIniAmount.TabIndex = 24;
			this.txtIniAmount.Text = "";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(240, 144);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(88, 23);
			this.label13.TabIndex = 23;
			this.label13.Text = "初始计费值：";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtXi
			// 
			this.txtXi.Location = new System.Drawing.Point(112, 176);
			this.txtXi.Name = "txtXi";
			this.txtXi.Size = new System.Drawing.Size(120, 21);
			this.txtXi.TabIndex = 22;
			this.txtXi.Text = "";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(8, 176);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(104, 23);
			this.label12.TabIndex = 21;
			this.label12.Text = "脉冲系数：";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtWarnLevel
			// 
			this.txtWarnLevel.Location = new System.Drawing.Point(328, 112);
			this.txtWarnLevel.Name = "txtWarnLevel";
			this.txtWarnLevel.Size = new System.Drawing.Size(128, 21);
			this.txtWarnLevel.TabIndex = 20;
			this.txtWarnLevel.Text = "";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(240, 112);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(88, 23);
			this.label11.TabIndex = 19;
			this.label11.Text = "报警下限：";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtWatNo
			// 
			this.txtWatNo.Location = new System.Drawing.Point(112, 144);
			this.txtWatNo.Name = "txtWatNo";
			this.txtWatNo.Size = new System.Drawing.Size(120, 21);
			this.txtWatNo.TabIndex = 18;
			this.txtWatNo.Text = "";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(16, 143);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(96, 23);
			this.label10.TabIndex = 17;
			this.label10.Text = "控制器编号：";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtY
			// 
			this.txtY.Location = new System.Drawing.Point(328, 80);
			this.txtY.Name = "txtY";
			this.txtY.Size = new System.Drawing.Size(128, 21);
			this.txtY.TabIndex = 16;
			this.txtY.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(248, 80);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 16);
			this.label8.TabIndex = 15;
			this.label8.Text = "y坐标：";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtX
			// 
			this.txtX.Location = new System.Drawing.Point(112, 112);
			this.txtX.Name = "txtX";
			this.txtX.Size = new System.Drawing.Size(120, 21);
			this.txtX.TabIndex = 14;
			this.txtX.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 112);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(104, 23);
			this.label7.TabIndex = 13;
			this.label7.Text = "x坐标：";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDepShortName
			// 
			this.txtDepShortName.Location = new System.Drawing.Point(112, 48);
			this.txtDepShortName.Name = "txtDepShortName";
			this.txtDepShortName.Size = new System.Drawing.Size(120, 21);
			this.txtDepShortName.TabIndex = 12;
			this.txtDepShortName.Text = "";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(112, 80);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(120, 21);
			this.txtAddress.TabIndex = 9;
			this.txtAddress.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 82);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 16);
			this.label5.TabIndex = 8;
			this.label5.Text = "设备地址：";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtGprsNo
			// 
			this.txtGprsNo.Location = new System.Drawing.Point(328, 48);
			this.txtGprsNo.Name = "txtGprsNo";
			this.txtGprsNo.Size = new System.Drawing.Size(128, 21);
			this.txtGprsNo.TabIndex = 7;
			this.txtGprsNo.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(264, 50);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "GPRS号：";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "所管理处名称：";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtWellName
			// 
			this.txtWellName.Location = new System.Drawing.Point(328, 22);
			this.txtWellName.Name = "txtWellName";
			this.txtWellName.Size = new System.Drawing.Size(128, 21);
			this.txtWellName.TabIndex = 3;
			this.txtWellName.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(240, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "站名称：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtWellNo
			// 
			this.txtWellNo.Location = new System.Drawing.Point(112, 16);
			this.txtWellNo.Name = "txtWellNo";
			this.txtWellNo.Size = new System.Drawing.Size(120, 21);
			this.txtWellNo.TabIndex = 1;
			this.txtWellNo.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "站编号：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(312, 296);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(80, 23);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "保存";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(392, 296);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(80, 23);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 304);
			this.label9.Name = "label9";
			this.label9.TabIndex = 3;
			this.label9.Text = "ICNo:";
			this.label9.Visible = false;
			// 
			// txtICNo
			// 
			this.txtICNo.Location = new System.Drawing.Point(120, 304);
			this.txtICNo.Name = "txtICNo";
			this.txtICNo.ReadOnly = true;
			this.txtICNo.TabIndex = 4;
			this.txtICNo.Text = "textBox1";
			this.txtICNo.Visible = false;
			// 
			// txtDes
			// 
			this.txtDes.Location = new System.Drawing.Point(80, 288);
			this.txtDes.Name = "txtDes";
			this.txtDes.TabIndex = 5;
			this.txtDes.Text = "";
			this.txtDes.Visible = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(232, 296);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "高级设置";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmBengZhanEdit
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(490, 327);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtDes);
			this.Controls.Add(this.txtICNo);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmBengZhanEdit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "监测站信息编辑";
			this.Load += new System.EventHandler(this.frmBengZhanEdit_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmBengZhanEdit_Load(object sender, System.EventArgs e)
		{
			try
			{
				if(this.m_bEdit==false)
				{
					//生成监测站编号
					string strSql="select tbNo from tbDel where tbName='tbWell'";				

					string strWellNo=CDBConnection.ExecuteScalar(strSql);

					if(strWellNo.Trim()!="")
					{
						this.txtWellNo.Text=strWellNo;
					}
					else
					{

						strSql="select count(*) from tbWell";					
						int iCount=0;						
						iCount=Convert.ToInt32(CDBConnection.ExecuteScalar(strSql));						
						iCount=iCount+1;

						strWellNo=cStr(iCount.ToString());					
						this.txtWellNo.Text  =strWellNo;						
					}
					this.txtDepShortName.Text=this.m_strDepName;
				}
				else
				{
					string strSql=String.Format("select wellNo,wellName,depName,gprsNo,watAddress,wellDes,ICNo,iniAmount,watchNo,xi,warnAmount,price1,x,y from tbWell where wellNo='{0}'",this.m_strWellNo);
					DataTable dtWell=null;
					CDBConnection.getDataTable(ref dtWell,strSql,"tbWell");

					this.txtWellNo.Text=dtWell.Rows[0]["wellNo"].ToString();
					this.txtWellName.Text=dtWell.Rows[0]["wellName"].ToString();
					string strAddress=dtWell.Rows[0]["watAddress"].ToString();
					int iAddress=Convert.ToInt32(strAddress);
					strAddress=iAddress.ToString("x");
					this.txtAddress.Text=strAddress;
					this.txtDes.Text=dtWell.Rows[0]["wellDes"].ToString();
					this.txtGprsNo.Text=dtWell.Rows[0]["gprsNo"].ToString();
					this.txtDepShortName.Text=dtWell.Rows[0]["depName"].ToString();
					this.txtICNo.Text=dtWell.Rows[0]["ICNo"].ToString();

					this.txtIniAmount.Text=dtWell.Rows[0]["iniAmount"].ToString().Trim();
					this.txtWatNo.Text=dtWell.Rows[0]["watchNo"].ToString().Trim();
					this.txtWarnLevel.Text=dtWell.Rows[0]["warnAmount"].ToString().Trim();
					this.txtXi.Text=dtWell.Rows[0]["xi"].ToString().Trim();
					this.txtX.Text=dtWell.Rows[0]["x"].ToString().Trim();
					this.txtY.Text=dtWell.Rows[0]["y"].ToString().Trim();
					this.txtPrice.Text=dtWell.Rows[0]["price1"].ToString().Trim();				}	
			
				paintJTPrice();
				addCmbPrice();
			}

			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}		
		}
	
		private void btnSave_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.m_bEdit)
				{

					DialogResult	result = MessageBox.Show(this, "警告:修改站点信息将对实时监测和报表统计造成影响是否继续?", "系统提示",MessageBoxButtons.YesNo,
					MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, 
					MessageBoxOptions.RightAlign);

					if(result != DialogResult.Yes)
					{						
						return;
					}
					else
					{
					
					}

				}
		
				if(this.chkJTS.Checked)
				{
					if(!this.paintPrice())
					{
						return;
					}
				}

				if(this.txtPrice.Text.Trim()=="")
				{
					MessageBox.Show("水价不能为空！");
					return;
				}

				if(this.txtWatNo.Text.Trim()=="")
				{
					MessageBox.Show("请填入控制器编号。");
					return;
				}

				try
				{
					double dPrice=double.Parse(this.txtPrice.Text.Trim());
				}
				catch
				{
					MessageBox.Show("水价不是有效数字！");
					return ;
				}

				string strSqlE=string.Format("select count(*) from tbWell where watchNo='{0}' and not wellNo='{1}'",this.txtWatNo.Text.Trim(),this.txtWellNo.Text.Trim());
				string strCount=BengZhan.CDBConnection.ExecuteScalar(strSqlE);
				if(strCount.Trim()!="0")
				{
					MessageBox.Show("该控制器编号已录入！");
					return;
				}

				if(this.txtWellName.Text.Trim()=="")
				{
					MessageBox.Show("请填入监测站名称！");
					return;
				}

				if(this.txtGprsNo.Text.Trim()=="")
				{
					MessageBox.Show("请输入GPRS号！");
					return;
				}

				if(this.txtAddress.Text.Trim()=="")
				{
					MessageBox.Show("请输入设备地址！");
					return;
				}
				if(this.txtGprsNo.Text.Trim().Length!=11)
				{
					MessageBox.Show("GPRS号长度有误!");
					return;
				}
				
				string strSql=String.Format("select count(*) from tbWell where wellName='{0}' and not wellNo='{1}'",this.txtWellName.Text.Trim(),this.txtWellNo.Text.Trim());
				string strCountE=CDBConnection.ExecuteScalar(strSql);
				if(strCountE.Trim()!="0")
				{
					MessageBox.Show("该监测站名称已录入！");
					return;
				}

				strSql=String.Format("select count(*) from tbWell where gprsNo='{0}' and not wellNo='{1}'",this.txtGprsNo.Text.Trim(),this.txtWellNo.Text.Trim());
				strCount=CDBConnection.ExecuteScalar(strSql);
				if(strCount!="0")
				{
					MessageBox.Show("该GPRS号已存在！");
					return;
				}	

				string strWatchType="";

				strSql=String.Format("select watchType from tbWell where wellNo='{0}'",this.txtWellNo.Text.Trim());
				strWatchType=BengZhan.CDBConnection.ExecuteScalar(strSql);
                				
				strSql=String.Format("delete from tbWell where wellNo='{0}'",this.txtWellNo.Text.Trim());
				CDBConnection.ExecuteSql(strSql);
				
				string strX="";
				if(this.txtX.Text.Trim()=="")
				{
					strX="null";
				}
				else
				{
					try
					{
						double dX=Convert.ToDouble(this.txtX.Text.Trim());
						strX=dX.ToString();
					}
					catch(Exception ex)
					{
						MessageBox.Show("你所填入的x坐标不是有效数字！");
						return;
					}
				}

				string strY="";
				if(this.txtY.Text.Trim()=="")
				{
					strY="null";
				}
				else
				{
					try
					{
						double dY=Convert.ToDouble(this.txtY.Text.Trim());
						strY=dY.ToString();
					}
					catch(Exception ex)
					{
						MessageBox.Show("你所填入的x坐标不是有效数字！");
						return;
					}
				}

				//地址十六进制
				string strAddress=this.txtAddress.Text.Trim();
				int iAddress=Convert.ToInt32(strAddress,16);
				strAddress=iAddress.ToString();

				strSql=String.Format("insert into tbWell(wellNo,wellName,depName,gprsNo,watAddress,wellDes,x,y,ICNo,watchType) values('{0}','{1}','{2}','{3}','{4}','{5}',{6},{7},'{8}','{9}')",this.txtWellNo.Text.Trim(),this.txtWellName.Text.Trim(),this.txtDepShortName.Text.Trim(),this.txtGprsNo.Text.Trim(),strAddress,this.txtDes.Text.Trim(),strX,strY,this.txtICNo.Text.Trim(),strWatchType);
				CDBConnection.ExecuteSql(strSql);

				strSql=String.Format("delete from tbDel where tbName='{0}' and tbNo='{1}'","tbWell",this.txtWellNo.Text.Trim());
				CDBConnection.ExecuteSql(strSql);

				strSql=string.Format("update tbWell set iniAmount='{0}',watchNo='{1}',xi='{2}',warnAmount='{3}',price1='{5}' where wellNo='{4}'",this.txtIniAmount.Text.Trim(),this.txtWatNo.Text.Trim(),this.txtXi.Text.Trim(),this.txtWarnLevel.Text.Trim(),this.txtWellNo.Text.Trim(),this.txtPrice.Text.Trim());
				BengZhan.CDBConnection.ExecuteSql(strSql);

                
				if(this.chkJTS.Checked)
				{
					strSql=string.Format("update tbWell set bjt='true' where wellNo='{0}'",this.txtWellNo.Text.Trim());
					BengZhan.CDBConnection.ExecuteSql(strSql);
					this.saveJTPrice();						
				}		

				this.m_bInserted=true;
				this.Close();

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		
		}
		private string cStr(string str)
		{
			if(str.Length==1)
			{
				return "00"+str;
			}
			if(str.Length==2)
			{
				return "0"+str;
			}
			
			return str;			
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
				this.Close();
		}

		private void chkJTS_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.chkJTS.Checked)
			{
				this.cmbPrice.Enabled=true;
				this.txtPrice1.ReadOnly=false;
				this.txtPrice2.ReadOnly=false;
				this.txtPrice.ReadOnly=true;
				this.txtPrice.Text="";
			}
			else
			{
				this.txtPrice.ReadOnly=false;
			}
		}

		private bool paintPrice()
		{
			try
			{
				if(this.cmbPrice.Text=="")
				{
					MessageBox.Show("请选择一个百分比！");
					return false;
				}

				if(this.txtPrice2.Text.Trim()=="")			
				{
					MessageBox.Show("范围外水价不许为空!");
					return false;
				}

				if(this.txtPrice1.Text.Trim()=="")
				{
					MessageBox.Show("范围内水价不许为空!");
					return false;
				}
			
				string strBai=this.cmbPrice.Text.Replace("%","");
				double dBai=double.Parse(strBai)/100;
				dBai=Math.Round(dBai,1);
				double dXi2=1-dBai;
				dXi2=Math.Round(dXi2,1);

				if(this.cmbPrice.Text.Trim()=="100%")
				{
					dBai=1;
					dXi2=0;
				}

				string strPrice1=this.txtPrice1.Text.Trim();
				string strPrice2=this.txtPrice2.Text.Trim();
                
				
				double dPrice=0;
				try
				{
					dPrice=double.Parse(strPrice1)*dBai+double.Parse(strPrice2)*dXi2;
				}
				catch(Exception ex)
				{
					MessageBox.Show("您填写的水价不是有效数字!");
					return false;
				}

				this.txtPrice.Text=dPrice.ToString();
				this.txtPrice.ForeColor=this.txtPrice.BackColor;


				return true;					

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
			
		}

		private void paintJTPrice()
		{
			try
			{
				this.txtPrice2.ReadOnly=true;
				this.txtPrice1.ReadOnly=true;
				this.cmbPrice.Enabled=false;

				string strSql=string.Format("select xi1,price1,xi2,price2 from tbPrice where wellName='{0}'",this.txtWellName.Text.Trim());
				DataTable dt=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dt,strSql,"tbPrice");

				if(dt.Rows.Count>0)
				{
					this.chkJTS.Checked=true;
					this.txtPrice.Text="";
					this.cmbPrice.Text=Convert.ToString(double.Parse(dt.Rows[0]["xi1"].ToString())*100)+"%";
					this.txtPrice1.Text=dt.Rows[0]["price1"].ToString();    
					this.txtPrice2.Text=dt.Rows[0]["price2"].ToString();
				}			
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void addCmbPrice()
		{
			this.cmbPrice.Items.Add("10%");
			this.cmbPrice.Items.Add("20%");
			this.cmbPrice.Items.Add("30%");
			this.cmbPrice.Items.Add("40%");
			this.cmbPrice.Items.Add("50%");
			this.cmbPrice.Items.Add("60%");
			this.cmbPrice.Items.Add("70%");
			this.cmbPrice.Items.Add("80%");
			this.cmbPrice.Items.Add("90%");
			this.cmbPrice.Items.Add("100%");
		}
		
		private void saveJTPrice()
		{
			try
			{
					
				string strSql=string.Format("delete from tbPrice where wellName='{0}'",this.txtWellName.Text.Trim());

				BengZhan.CDBConnection.ExecuteSql(strSql);
				string strBai=this.cmbPrice.Text.Replace("%","");
				double dBai=double.Parse(strBai)/100;
				dBai=Math.Round(dBai,1);
				double dXi2=1-dBai;
				dXi2=Math.Round(dXi2,1);

				if(this.cmbPrice.Text.Trim()=="100%")
				{
					dBai=1;
					dXi2=0;
				}

			 strSql=string.Format("insert into tbPrice(wellName,wellNo,xi1,xi2,price1,price2)values('{0}','{1}','{2}','{3}','{4}','{5}')",this.txtWellName.Text.Trim(),this.txtWellNo.Text.Trim(),dBai.ToString(),dXi2.ToString(),this.txtPrice1.Text.Trim(),this.txtPrice2.Text.Trim());
				BengZhan.CDBConnection.ExecuteSql(strSql);	

				strSql=string.Format("select wellNo,wellName from tbWell where depName=(select depName from tbWell where wellNo='{0}')",this.txtWellNo.Text.Trim());
				DataTable dtWell=new DataTable();

				BengZhan.CDBConnection.getDataTable(ref dtWell,strSql,"dtWell");

				for(int i=0;i<dtWell.Rows.Count;i++)
				{
					string strWellNo=dtWell.Rows[i]["wellNo"].ToString().Trim();
					string strZhanName=dtWell.Rows[i]["wellName"].ToString().Trim();
					strSql=string.Format("select count(*) from tbPrice where wellNo='{0}'",strWellNo);
					string strCount=BengZhan.CDBConnection.ExecuteScalar(strSql);
					if(strCount.Trim()=="")
					{
						strCount="0";
					}
					if(int.Parse(strCount)<=0)
					{
						strSql=string.Format("select price1 from tbWell where wellNo='{0}'",strWellNo);
						string strPrice=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();
						strSql=string.Format("insert into tbPrice(wellName,wellNo,xi1,price1,xi2,price2)values('{0}','{1}','1','{2}','0','0')",strZhanName,strWellNo,strPrice);
						BengZhan.CDBConnection.ExecuteSql(strSql);
					}
				}

				strSql=string.Format("delete  from tbPrice1 where wellNo='{0}'",this.txtWellNo.Text.Trim());
				BengZhan.CDBConnection.ExecuteSql(strSql);
			
				strSql=string.Format("insert into tbPrice1(wellNo,xi1,price2)values('{0}','{1}','{2}')",this.txtWellNo.Text.Trim(),dBai.ToString(),this.txtPrice1.Text.Trim());
				BengZhan.CDBConnection.ExecuteSql(strSql);
				strSql=string.Format("insert into tbPrice1(wellNo,xi1,price2)values('{0}','{1}','{2}')",this.txtWellNo.Text.Trim(),dXi2.ToString(),this.txtPrice2.Text.Trim());
				BengZhan.CDBConnection.ExecuteSql(strSql);
                				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			int w_wid=int.Parse(txtWellNo.Text.Trim());
			string strSql=String.Format("select count(*) from tbw_WellInfo where WellID='{0}'",txtWellNo.Text.Trim());
			string strCountE=CDBConnection.ExecuteScalar(strSql);
			bool isedit=m_bEdit;
			if(strCountE.Trim()!="0")
			{
				isedit=true;
			}
			else
			{
				isedit=false;
			}
			frmAdvancedInfo f=new frmAdvancedInfo(isedit,w_wid,this.txtWellName.Text.Trim());
			f.ShowDialog();
		}
	}
}

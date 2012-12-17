using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BengZhan.bengzhans
{
	/// <summary>
	/// frmAdvancedInfo 的摘要说明。
	/// </summary>
	public class frmAdvancedInfo : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private bool m_bool=false;
		private int m_wellID=0;
		private System.Windows.Forms.ComboBox cmdType;
		private System.Windows.Forms.TextBox txtZPi;
		private System.Windows.Forms.TextBox txtBPm;
		private System.Windows.Forms.TextBox txtTopW;
		private System.Windows.Forms.TextBox txtBaseW;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtmiddleW;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private string m_Name="";

		public frmAdvancedInfo(bool isedit,int wellID,string wellName)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			m_bool=isedit;
			m_wellID=wellID;
			m_Name=wellName;
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
			this.cmdType = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtZPi = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtBPm = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtTopW = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtBaseW = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtmiddleW = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdType
			// 
			this.cmdType.Items.AddRange(new object[] {
														 "明渠均匀流",
														 "巴歇尔量水槽"});
			this.cmdType.Location = new System.Drawing.Point(128, 12);
			this.cmdType.Name = "cmdType";
			this.cmdType.Size = new System.Drawing.Size(220, 20);
			this.cmdType.TabIndex = 0;
			this.cmdType.Text = "选择渠道类型";
			this.cmdType.SelectedIndexChanged += new System.EventHandler(this.cmdType_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.txtZPi);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtBPm);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtTopW);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtBaseW);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(16, 48);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(332, 192);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "明渠均匀流参数录入";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(116, 152);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(23, 17);
			this.label9.TabIndex = 11;
			this.label9.Text = "1：";
			// 
			// txtZPi
			// 
			this.txtZPi.Location = new System.Drawing.Point(152, 148);
			this.txtZPi.Name = "txtZPi";
			this.txtZPi.Size = new System.Drawing.Size(140, 21);
			this.txtZPi.TabIndex = 10;
			this.txtZPi.Text = "0";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(116, 112);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(23, 17);
			this.label8.TabIndex = 9;
			this.label8.Text = "1：";
			// 
			// txtBPm
			// 
			this.txtBPm.Location = new System.Drawing.Point(152, 108);
			this.txtBPm.Name = "txtBPm";
			this.txtBPm.Size = new System.Drawing.Size(140, 21);
			this.txtBPm.TabIndex = 8;
			this.txtBPm.Text = "0";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(300, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(17, 17);
			this.label7.TabIndex = 7;
			this.label7.Text = "米";
			// 
			// txtTopW
			// 
			this.txtTopW.Location = new System.Drawing.Point(112, 68);
			this.txtTopW.Name = "txtTopW";
			this.txtTopW.Size = new System.Drawing.Size(180, 21);
			this.txtTopW.TabIndex = 6;
			this.txtTopW.Text = "0";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(300, 32);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(17, 17);
			this.label6.TabIndex = 5;
			this.label6.Text = "米";
			// 
			// txtBaseW
			// 
			this.txtBaseW.Location = new System.Drawing.Point(112, 28);
			this.txtBaseW.Name = "txtBaseW";
			this.txtBaseW.Size = new System.Drawing.Size(180, 21);
			this.txtBaseW.TabIndex = 4;
			this.txtBaseW.Text = "0";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(66, 17);
			this.label5.TabIndex = 3;
			this.label5.Text = "纵坡系数：";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 17);
			this.label4.TabIndex = 2;
			this.label4.Text = "边坡系数：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 17);
			this.label3.TabIndex = 1;
			this.label3.Text = "开口宽度：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "渠底宽度：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "选择渠道类型：";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(224, 252);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(60, 24);
			this.button1.TabIndex = 3;
			this.button1.Text = "保存";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(284, 252);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(60, 24);
			this.button2.TabIndex = 4;
			this.button2.Text = "取消";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.txtmiddleW);
			this.groupBox2.Location = new System.Drawing.Point(16, 48);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(332, 192);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "巴歇尔量水槽参数录入";
			// 
			// txtmiddleW
			// 
			this.txtmiddleW.Location = new System.Drawing.Point(112, 88);
			this.txtmiddleW.Name = "txtmiddleW";
			this.txtmiddleW.Size = new System.Drawing.Size(180, 21);
			this.txtmiddleW.TabIndex = 0;
			this.txtmiddleW.Text = "0";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(302, 92);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(17, 17);
			this.label10.TabIndex = 9;
			this.label10.Text = "米";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(14, 92);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(66, 17);
			this.label11.TabIndex = 8;
			this.label11.Text = "喉道宽度：";
			// 
			// frmAdvancedInfo
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(364, 288);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cmdType);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "frmAdvancedInfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "测站参数信息";
			this.Load += new System.EventHandler(this.frmAdvancedInfo_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void LoadWellInfo()
		{
			try
			{
				string strSql=String.Format("select * from tbw_WellInfo where WellID='{0}'",this.m_wellID);
				DataTable dtWell=null;
				CDBConnection.getDataTable(ref dtWell,strSql,"tbw_WellInfo");

				int dataType=int.Parse(dtWell.Rows[0]["DataType"].ToString());
				if(dataType==0)
				{
					cmdType.Text="明渠均匀流";
					this.txtBaseW.Text=dtWell.Rows[0]["BaseW"].ToString();
					this.txtTopW.Text=dtWell.Rows[0]["TopW"].ToString();
					this.txtZPi.Text=dtWell.Rows[0]["ZPi"].ToString();
					this.txtBPm.Text=dtWell.Rows[0]["BPm"].ToString();
					this.groupBox2.Visible=false;
					this.groupBox1.Visible=true;
				}
				else
				{
					cmdType.Text="巴歇尔量水槽";
					this.txtmiddleW.Text=dtWell.Rows[0]["middleW"].ToString();
					this.groupBox1.Visible=false;
					this.groupBox2.Visible=true;
				}
			}
			catch
			{
			}
		}

		private bool CheckDatas()
		{
			try
			{
				float fd=float.Parse(txtBaseW.Text.Trim());
				fd=float.Parse(txtTopW.Text.Trim());
				fd=float.Parse(txtBPm.Text.Trim());
				fd=float.Parse(txtZPi.Text.Trim());
				fd=float.Parse(txtmiddleW.Text.Trim());
				return true;
			}
			catch
			{
				return false;
			}
		}

		private void EditDatas()
		{
			DialogResult	result = MessageBox.Show(this, "警告:修改站点信息将对实时监测和报表统计造成影响是否继续?", "系统提示",MessageBoxButtons.YesNo,
				MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, 
				MessageBoxOptions.RightAlign);

			if(result != DialogResult.Yes)
			{						
				return;
			}

			int intType=0;
			if(!CheckDatas())
			{
				MessageBox.Show("录入字段格式不符,请重新录入");
				return;
			}

			if(cmdType.Text=="明渠均匀流")
			{
				intType=0;
			}
			else
			{
				intType=1;
			}
			try
			{
				string strSql=string.Format("update tbw_WellInfo set BaseW='{0}',TopW='{1}',BPm='{2}',ZPi='{3}',DataType='{4}',middleW='{5}' where WellID='{6}'",this.txtBaseW.Text.Trim(),this.txtTopW.Text.Trim(),this.txtBPm.Text.Trim(),this.txtZPi.Text.Trim(),intType.ToString(),txtmiddleW.Text.Trim(),this.m_wellID.ToString());
				BengZhan.CDBConnection.ExecuteSql(strSql);
			}
			catch
			{
			}

		}

		private void AddDatas()
		{
			if(!CheckDatas())
			{
				MessageBox.Show("录入字段格式不符,请重新录入");
				return;
			}
			int intType=0;
			if(cmdType.Text=="明渠均匀流")
			{
				intType=0;				
			}
			else if(cmdType.Text=="巴歇尔量水槽")
			{
				intType=1;
			}
			else
			{
				MessageBox.Show("请选择渠道类型");
				return;
			}
			try
			{
				string strSql=string.Format("insert into tbw_WellInfo(WellID,BaseW,TopW,BPm,ZPi,DataType,middleW) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",this.m_wellID.ToString(),this.txtBaseW.Text.Trim(),this.txtTopW.Text.Trim(),this.txtBPm.Text.Trim(),this.txtZPi.Text.Trim(),intType.ToString(),txtmiddleW.Text.Trim());
				BengZhan.CDBConnection.ExecuteSql(strSql);
			}
			catch
			{
			}
		}

		private void frmAdvancedInfo_Load(object sender, System.EventArgs e)
		{
			this.Text=m_Name+"高级参数信息编辑";
			this.groupBox1.Visible=true;
			this.groupBox2.Visible=false;
			if(m_bool)
			{
				LoadWellInfo();
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if(m_bool)
				EditDatas();
			else
				AddDatas();
			this.Close();
		}

		private void cmdType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(cmdType.Text=="明渠均匀流")
			{
				this.groupBox1.Visible=true;
				this.groupBox2.Visible=false;
			}
			else if(cmdType.Text=="巴歇尔量水槽")
			{
				this.groupBox1.Visible=false;
				this.groupBox2.Visible=true;
			}
		}
	}
}

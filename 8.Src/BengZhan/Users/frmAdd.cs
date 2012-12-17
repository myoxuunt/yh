using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using BengZhan.controls;
namespace BengZhan.Users
{
	/// <summary>
	/// frmAdd 的摘要说明。
	/// </summary>
	public class frmAdd : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUserID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtUserPwd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPwdCer;
		private System.Windows.Forms.Button btnInsert;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		
		//标志是否保存
		public bool m_bInserted=false;

		//用户编号
		public string m_strUserID="";
		private BengZhan.controls.myCmb  cmbManagers;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox chkPower;
		
		//判断是否为修改用户信息
		public bool m_bEdit=false;

		public frmAdd()
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
			this.cmbManagers = new BengZhan.controls.myCmb();
			this.label5 = new System.Windows.Forms.Label();
			this.chkPower = new System.Windows.Forms.CheckBox();
			this.txtPwdCer = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtUserPwd = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUserID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnInsert = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbManagers);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.chkPower);
			this.groupBox1.Controls.Add(this.txtPwdCer);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtUserPwd);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtUserName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtUserID);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(280, 192);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// cmbManagers
			// 
			this.cmbManagers.Location = new System.Drawing.Point(112, 160);
			this.cmbManagers.Name = "cmbManagers";
			this.cmbManagers.Size = new System.Drawing.Size(88, 20);
			this.cmbManagers.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(208, 160);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "的权限";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// chkPower
			// 
			this.chkPower.Location = new System.Drawing.Point(32, 160);
			this.chkPower.Name = "chkPower";
			this.chkPower.Size = new System.Drawing.Size(72, 24);
			this.chkPower.TabIndex = 8;
			this.chkPower.Text = "应用：";
			this.chkPower.CheckedChanged += new System.EventHandler(this.checkPower_CheckedChanged);
			// 
			// txtPwdCer
			// 
			this.txtPwdCer.Location = new System.Drawing.Point(112, 128);
			this.txtPwdCer.Name = "txtPwdCer";
			this.txtPwdCer.PasswordChar = '*';
			this.txtPwdCer.Size = new System.Drawing.Size(144, 21);
			this.txtPwdCer.TabIndex = 7;
			this.txtPwdCer.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(32, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "密码确认：";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtUserPwd
			// 
			this.txtUserPwd.Location = new System.Drawing.Point(112, 96);
			this.txtUserPwd.Name = "txtUserPwd";
			this.txtUserPwd.PasswordChar = '*';
			this.txtUserPwd.Size = new System.Drawing.Size(144, 21);
			this.txtUserPwd.TabIndex = 5;
			this.txtUserPwd.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(32, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "用户密码：";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(112, 64);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(144, 21);
			this.txtUserName.TabIndex = 3;
			this.txtUserName.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "用户名：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtUserID
			// 
			this.txtUserID.Location = new System.Drawing.Point(112, 32);
			this.txtUserID.Name = "txtUserID";
			this.txtUserID.Size = new System.Drawing.Size(144, 21);
			this.txtUserID.TabIndex = 1;
			this.txtUserID.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "用户ID：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnInsert
			// 
			this.btnInsert.Location = new System.Drawing.Point(128, 208);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(64, 23);
			this.btnInsert.TabIndex = 1;
			this.btnInsert.Text = "添加";
			this.btnInsert.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(224, 208);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(64, 24);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// frmAdd
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(298, 240);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnInsert);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmAdd";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "用户添加";
			this.Load += new System.EventHandler(this.frmAdd_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.txtUserID.Text.Trim()=="")
				{
					MessageBox.Show("请填写用户ID");
					return;
				}
				if(this.txtUserName.Text.Trim()=="")
				{
					MessageBox.Show("请填写用户名!");
					return;
				}
				if(this.txtUserPwd.Text.Trim()=="")
				{
					MessageBox.Show("请填写用户密码!");
					return;
				}
				if(this.txtUserPwd.Text.Trim()!=this.txtPwdCer.Text.Trim())
				{
					MessageBox.Show("密码与确认密码不同!");
					return;
				}

				if(this.chkPower.Checked==true)
				{
					if(this.cmbManagers.Text.Trim()=="")
					{
						MessageBox.Show("请选择具有相同权限的管理员，或去掉应用权限项！");
						return;
					}
				}
				else
				{
					if(this.cmbManagers.Text.Trim()!="")
					{
						MessageBox.Show("请选中应用权限框，或清除所选的管理员！");
						return;
					}
				}

				if(this.m_bEdit==false)
				{
					//添加用户	
					this.fInserUsers();
				
				}	
				else
				{
					//修改
					string strSql=String.Format("delete from tbUsers where userID='{0}'",this.txtUserID.Text.Trim());
					CDBConnection.ExecuteSql(strSql);
					this.fInserUsers();
				}

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		private void fInserUsers()
		{
			try
			{
				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();

				string strSql=String.Format("select count(*) from tbUsers where userID='{0}'",this.txtUserID.Text.Trim());
				SqlCommand sCmd=new  SqlCommand();
				sCmd.CommandText=strSql;
				sCmd.Connection=sCon;
				
				string strCount="";
				if(sCmd.ExecuteScalar()!=null)
				{
					strCount=sCmd.ExecuteScalar().ToString();
				}

				int iCount=Convert.ToInt32(strCount);
				if(iCount>0)
				{
					MessageBox.Show("用户已存在！");
					return;
				}

				strSql=String.Format("insert into tbUsers(userID,userName,userPwd,parentManager) values('{0}','{1}','{2}','{3}')",this.txtUserID.Text.Trim(),this.txtUserName.Text.Trim(),this.txtUserPwd.Text.Trim(),this.cmbManagers.Text.Trim());
				sCmd.CommandText=strSql;
				sCmd.ExecuteNonQuery();
				sCon.Close();
				this.m_bInserted =true;
				this.Close();

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void frmAdd_Load(object sender, System.EventArgs e)
		{
			try
			{
				iniCmbManagers();

				if(this.m_bEdit==true)
				{
					this.txtUserID.ReadOnly=true;
					string strSql=String.Format("select  userName,userPwd,parentManager from tbUsers where userID='{0}'",this.m_strUserID.Trim());
					DataTable dt=new  DataTable();
					CDBConnection.getDataTable(ref dt,strSql,"tbUsers");

					this.txtUserID.Text=this.m_strUserID;
					this.txtUserName.Text=dt.Rows[0]["userName"].ToString();
					this.txtUserPwd.Text=dt.Rows[0]["userPwd"].ToString();
					this.txtPwdCer.Text =this.txtUserPwd.Text;		
					this.cmbManagers.Text=dt.Rows[0]["parentManager"].ToString().Trim();
					if(this.cmbManagers.Text.Trim()!="")
					{
						this.chkPower.Checked=true;
					}
					this.chkPower.Enabled=false;
					this.cmbManagers.Enabled=false;

					strSql=String.Format("select userName from tbUsers where parentManager='{0}'",this.txtUserName.Text.Trim());
					string strUName=CDBConnection.ExecuteScalar(strSql).Trim();
					if(strUName!="")
					{
						this.txtUserName.ReadOnly=true;
					}
				}	

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
		}

		private void checkPower_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.chkPower.Checked==true)
			{
				if(this.cmbManagers.Text.Trim()=="")
				{
					MessageBox.Show("请选择一名管理员！");
					this.chkPower.Checked=false;
					return;
				}
				
			}
		}
		private bool iniCmbManagers()
		{
			try
			{
				
				string strSql=String.Format("select userName from tbUsers");
				DataTable dt=null;
				CDBConnection.getDataTable(ref dt,strSql,"tbUsers");
				if(dt==null)
				{
					return false;
				}
				this.cmbManagers.Items.Clear();

				for(int i=0;i<dt.Rows.Count;i++)
				{
					string strManagerName=dt.Rows[i]["userName"].ToString();
					this.cmbManagers.Items.Add(strManagerName);
				}

				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}
	}
}

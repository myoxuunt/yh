using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace BengZhan
{
	/// <summary>
	/// FrmChangePwd 的摘要说明。
	/// </summary>
	public class FrmChangePwd : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnCer;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtPwdCer;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPwd;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUserID;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// 功能：修改密码
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmChangePwd()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmChangePwd));
			this.btnCer = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtPwdCer = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPwd = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUserID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCer
			// 
			this.btnCer.Location = new System.Drawing.Point(136, 168);
			this.btnCer.Name = "btnCer";
			this.btnCer.TabIndex = 9;
			this.btnCer.Text = "确定";
			this.btnCer.Click += new System.EventHandler(this.btnCer_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(216, 168);
			this.button2.Name = "button2";
			this.button2.TabIndex = 10;
			this.button2.Text = "退出";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtPwdCer);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtPwd);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtUserName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtUserID);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(288, 160);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			// 
			// txtPwdCer
			// 
			this.txtPwdCer.Location = new System.Drawing.Point(116, 122);
			this.txtPwdCer.Name = "txtPwdCer";
			this.txtPwdCer.PasswordChar = '*';
			this.txtPwdCer.Size = new System.Drawing.Size(152, 21);
			this.txtPwdCer.TabIndex = 15;
			this.txtPwdCer.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(20, 122);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 16);
			this.label4.TabIndex = 14;
			this.label4.Text = "确认新密码：";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPwd
			// 
			this.txtPwd.Location = new System.Drawing.Point(116, 90);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.PasswordChar = '*';
			this.txtPwd.Size = new System.Drawing.Size(152, 21);
			this.txtPwd.TabIndex = 13;
			this.txtPwd.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(20, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 16);
			this.label3.TabIndex = 12;
			this.label3.Text = "新密码：";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(116, 58);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.ReadOnly = true;
			this.txtUserName.Size = new System.Drawing.Size(152, 21);
			this.txtUserName.TabIndex = 11;
			this.txtUserName.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(28, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 16);
			this.label2.TabIndex = 10;
			this.label2.Text = "用户名称：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtUserID
			// 
			this.txtUserID.Location = new System.Drawing.Point(116, 26);
			this.txtUserID.Name = "txtUserID";
			this.txtUserID.ReadOnly = true;
			this.txtUserID.Size = new System.Drawing.Size(152, 21);
			this.txtUserID.TabIndex = 9;
			this.txtUserID.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(36, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 8;
			this.label1.Text = "用户ID：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FrmChangePwd
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(298, 200);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnCer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmChangePwd";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "修改密码";
			this.Load += new System.EventHandler(this.FrmChangePwd_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Close();

		}

		private void btnCer_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.txtPwd.Text.Trim()=="")
				{
					MessageBox.Show("请输入新密码！");
					return;
				}
				if(this.txtPwd.Text.Trim()!=this.txtPwdCer.Text.Trim())
				{
					MessageBox.Show("密码与确认密码不同！");
					return;
				}

				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();

				//更改操作员密码
				//this.txtPwd.Text.Trim() ：新密码
				string strSql=String.Format("update tbUsers set userPwd='{0}' where userID='{1}'",this.txtPwd.Text.Trim(),CDBConnection.m_strUserID);
				SqlCommand sCmd=new SqlCommand();
				sCmd.CommandText =strSql;
				sCmd.Connection =sCon;
				sCmd.ExecuteNonQuery();
				MessageBox.Show("密码更改成功！");
				sCon.Close();
				this.Close();

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void FrmChangePwd_Load(object sender, System.EventArgs e)
		{
			this.txtUserID.Text=CDBConnection.m_strUserID;
			this.txtUserName.Text=CDBConnection.m_strUserName;
		}
	}
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data ;
namespace BengZhan.Users
{
	/// <summary>
	/// frmUsers 的摘要说明。
	/// </summary>
	public class frmUsers : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ListView lsvUsers;
		private System.Windows.Forms.Button btnDel;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmUsers()
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
			this.lsvUsers = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lsvUsers);
			this.groupBox1.Location = new System.Drawing.Point(8, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(448, 320);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// lsvUsers
			// 
			this.lsvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					   this.columnHeader1,
																					   this.columnHeader2,
																					   this.columnHeader3});
			this.lsvUsers.FullRowSelect = true;
			this.lsvUsers.GridLines = true;
			this.lsvUsers.Location = new System.Drawing.Point(8, 16);
			this.lsvUsers.Name = "lsvUsers";
			this.lsvUsers.Size = new System.Drawing.Size(432, 296);
			this.lsvUsers.TabIndex = 0;
			this.lsvUsers.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "用户ID";
			this.columnHeader1.Width = 124;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "用户名";
			this.columnHeader2.Width = 126;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "用户密码";
			this.columnHeader3.Width = 165;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnDel);
			this.groupBox2.Controls.Add(this.btnExit);
			this.groupBox2.Controls.Add(this.btnEdit);
			this.groupBox2.Controls.Add(this.btnAdd);
			this.groupBox2.Location = new System.Drawing.Point(8, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(344, 48);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(176, 16);
			this.btnDel.Name = "btnDel";
			this.btnDel.TabIndex = 3;
			this.btnDel.Text = "删除";
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(256, 16);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(88, 16);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.TabIndex = 1;
			this.btnEdit.Text = "修改";
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(8, 16);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "添加";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// frmUsers
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(464, 382);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmUsers";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "用户管理";
			this.Load += new System.EventHandler(this.frmUsers_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			frmAdd frmAd=new frmAdd();
			frmAd.ShowDialog();
			if(frmAd.m_bInserted==true)
			{
				this.paintFrm();
			}
		}

		private void frmUsers_Load(object sender, System.EventArgs e)
		{
			this.paintFrm();
		
		}
		private void paintFrm()
		{
			try
			{
				string strSql=String.Format("select userID,userName,userPwd from tbUsers");
				DataTable dt=new  DataTable();
				CDBConnection.getDataTable(ref dt,strSql,"tbUser");
				this.lsvUsers.Items.Clear();

				for(int i=0;i<dt.Rows.Count;i++)
				{
					this.lsvUsers.Items.Add(dt.Rows[i]["userID"].ToString());
					this.lsvUsers.Items[i].SubItems.Add(dt.Rows[i]["userName"].ToString());
					this.lsvUsers.Items[i].SubItems.Add(dt.Rows[i]["userPwd"].ToString());
				}

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			


		}

		private void btnDel_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.lsvUsers.SelectedItems.Count==0)
				{
					MessageBox.Show("请选中要删除的用户！");
					return;
				}
				string strParentManager=this.lsvUsers.SelectedItems[0].SubItems[1].Text;
				string strSql=String.Format("select userName from tbUsers where parentManager='{0}'",strParentManager);
				string strUserName=CDBConnection.ExecuteScalar(strSql);
				
				if(strUserName.Trim()!="")
				{
					string strInfo=String.Format("操作员：{0}已应用其操作权限不能将其删除！",strUserName);
					MessageBox.Show(strInfo);
					return;
				}
				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();

				strSql=String.Format("delete from tbUsers where userID='{0}'",this.lsvUsers.SelectedItems[0].Text.Trim());
				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;
				sCmd.CommandText=strSql;
				sCmd.ExecuteNonQuery();
				sCon.Close();

				strSql=String.Format("delete from userMenu where userId='{0}'",this.lsvUsers.SelectedItems[0].Text.Trim());
				this.paintFrm();

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
		}

		private void btnEdit_Click(object sender, System.EventArgs e)
		{
			if(this.lsvUsers.SelectedItems.Count==0)
			{
				MessageBox.Show("请选中要删除的用户！");
				return;
			}
			frmAdd frmAddObj=new frmAdd();
			frmAddObj.m_bEdit=true;
			frmAddObj.m_strUserID =this.lsvUsers.SelectedItems[0].Text;
			frmAddObj.ShowDialog();
			if(frmAddObj.m_bInserted==true)
			{
				this.paintFrm();
			}

		}
	}
}

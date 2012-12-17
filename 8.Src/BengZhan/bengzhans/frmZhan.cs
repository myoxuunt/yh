using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace BengZhan.bengzhans
{
	/// <summary>
	/// frmZhan 的摘要说明。
	/// </summary>
	public class frmZhan : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnCer;
		private System.Windows.Forms.TextBox txtZhan;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDep;
		private System.Windows.Forms.TextBox txtZhanNew;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmZhan()
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
			this.txtDep = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtZhanNew = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtZhan = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnCer = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtDep);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtZhanNew);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtZhan);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(0, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(272, 120);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// txtDep
			// 
			this.txtDep.Location = new System.Drawing.Point(144, 88);
			this.txtDep.Name = "txtDep";
			this.txtDep.TabIndex = 5;
			this.txtDep.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(32, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "该站所在单位名称:";
			// 
			// txtZhanNew
			// 
			this.txtZhanNew.Location = new System.Drawing.Point(144, 56);
			this.txtZhanNew.Name = "txtZhanNew";
			this.txtZhanNew.TabIndex = 3;
			this.txtZhanNew.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(32, 56);
			this.label2.Name = "label2";
			this.label2.TabIndex = 2;
			this.label2.Text = "监测站的新名称:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtZhan
			// 
			this.txtZhan.Location = new System.Drawing.Point(144, 24);
			this.txtZhan.Name = "txtZhan";
			this.txtZhan.ReadOnly = true;
			this.txtZhan.TabIndex = 1;
			this.txtZhan.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 24);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "监测站名称:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(208, 136);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(56, 23);
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "取消";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnCer
			// 
			this.btnCer.Location = new System.Drawing.Point(144, 136);
			this.btnCer.Name = "btnCer";
			this.btnCer.Size = new System.Drawing.Size(56, 23);
			this.btnCer.TabIndex = 2;
			this.btnCer.Text = "确认";
			this.btnCer.Click += new System.EventHandler(this.btnCer_Click);
			// 
			// frmZhan
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(272, 165);
			this.Controls.Add(this.btnCer);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmZhan";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "监测站名称";
			this.Load += new System.EventHandler(this.frmZhan_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		public string m_strZhanNo="";

		private void label1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnCer_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.txtZhanNew.Text.Trim()=="")
				{
					MessageBox.Show("监测站的新名称不允许伟空!");
					return;
				}
				if(this.txtDep.Text.Trim()=="")
				{
					MessageBox.Show("单位名称不许为空!");
					return;
				}

				this.Cursor=Cursors.WaitCursor;

			    string strSql=string.Format("select depName from tbWell where wellName='{0}'",this.txtZhan.Text.Trim());
				string strDepName=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();

				strSql=string.Format("update tbPrice set wellName='{0}' where wellName='{1}'",this.txtZhanNew.Text.Trim(),this.txtZhan.Text.Trim());
				BengZhan.CDBConnection.ExecuteSql(strSql);

				strSql=string.Format("update tbDep set depName='{0}',depShortName='{0}' where depName='{1}'",this.txtDep.Text.Trim(),strDepName);
				BengZhan.CDBConnection.ExecuteSql(strSql);

				strSql=string.Format("update tbWell set depName='{0}' where depName='{1}'",this.txtDep.Text.Trim(),strDepName);
				BengZhan.CDBConnection.ExecuteSql(strSql);

				strSql=string.Format("update tbWell set wellName='{0}' where wellName='{1}'",this.txtZhanNew.Text.Trim(),this.txtZhan.Text.Trim());
				BengZhan.CDBConnection.ExecuteSql(strSql);
				strSql=string.Format("update waterdataslast set name='{0}' where name='{1}'",this.txtZhanNew.Text.Trim(),this.txtZhan.Text.Trim());
				BengZhan.CDBConnection.ExecuteSql(strSql);
				strSql=string.Format("update waterdatasday set name='{0}' where name='{1}'",this.txtZhanNew.Text.Trim(),this.txtZhan.Text.Trim());
				BengZhan.CDBConnection.ExecuteSql(strSql);
				strSql=string.Format("update waterdatas set name='{0}' where name='{1}'",this.txtZhanNew.Text.Trim(),this.txtZhan.Text.Trim());
				BengZhan.CDBConnection.ExecuteSql(strSql);
				strSql=string.Format("update waterdatasmonth set name='{0}' where name='{1}'",this.txtZhanNew.Text.Trim(),this.txtZhan.Text.Trim());
				BengZhan.CDBConnection.ExecuteSql(strSql);

				this.Cursor=Cursors.Default;

				MessageBox.Show("修改完成!");
				this.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void frmZhan_Load(object sender, System.EventArgs e)
		{

			string strSql=string.Format("select wellName from tbWell where wellNo='{0}'",this.m_strZhanNo.Trim());
			string strWellName=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();
            this.txtZhan.Text=strWellName;
			strSql=string.Format("select depName from tbWell where wellNo='{0}'",this.m_strZhanNo.Trim());
			string strDepName=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();
			this.txtDep.Text=strDepName;

		}
	}
}

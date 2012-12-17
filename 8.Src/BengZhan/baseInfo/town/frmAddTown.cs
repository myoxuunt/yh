using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BengZhan.baseInfo.town
{
	/// <summary>
	/// frmAddTown 的摘要说明。
	/// </summary>
	public class frmAddTown : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTownName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDes;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnExit;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		public bool m_bInserted=false;

		public frmAddTown()
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
			this.txtDes = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTownName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtDes);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtTownName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(0, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(288, 112);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// txtDes
			// 
			this.txtDes.Location = new System.Drawing.Point(128, 72);
			this.txtDes.Name = "txtDes";
			this.txtDes.Size = new System.Drawing.Size(144, 21);
			this.txtDes.TabIndex = 5;
			this.txtDes.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "备注:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtTownName
			// 
			this.txtTownName.Location = new System.Drawing.Point(128, 32);
			this.txtTownName.Name = "txtTownName";
			this.txtTownName.Size = new System.Drawing.Size(144, 21);
			this.txtTownName.TabIndex = 3;
			this.txtTownName.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "县名称:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(128, 136);
			this.btnSave.Name = "btnSave";
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "保存";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(208, 136);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// frmAddTown
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 168);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmAddTown";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "添加县级信息";
			this.Load += new System.EventHandler(this.frmAddTown_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmAddTown_Load(object sender, System.EventArgs e)
		{
			
		}
		
		private void btnSave_Click(object sender, System.EventArgs e)
		{
			try

			{
				
				if(this.txtTownName.Text.Trim()=="")
				{
					MessageBox.Show("县级名称不能为空!");
					return;
				}


				string strSql=String.Format("select count(*) from tbTown where townName='{0}'",this.txtTownName.Text.Trim());
				string strCount=CDBConnection.ExecuteScalar(strSql);
				int iCount=Convert.ToInt32(strCount);
				if(iCount>0)
				{
					MessageBox.Show("该县级名称已存在!");
					return;
				}

				strSql=String.Format("insert into tbTown(townName,townDes) values('{0}','{1}')",this.txtTownName.Text.Trim(),this.txtDes.Text.Trim());
				CDBConnection.ExecuteSql(strSql);				
				
				this.m_bInserted =true;
				this.Close();

                
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}

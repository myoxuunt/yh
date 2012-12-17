using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace BengZhan.baseInfo.country
{
	/// <summary>
	/// frmAddCountry 的摘要说明。
	/// </summary>
	public class frmAddCountry : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtDes;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtCountryName;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTownName;

		public bool m_bInserted=false;

		//县名称
		public string m_strTownName="";

		public frmAddCountry()
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
			this.txtTownName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDes = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCountryName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtTownName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtDes);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtCountryName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(16, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(288, 128);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			// 
			// txtTownName
			// 
			this.txtTownName.Location = new System.Drawing.Point(128, 24);
			this.txtTownName.Name = "txtTownName";
			this.txtTownName.Size = new System.Drawing.Size(144, 21);
			this.txtTownName.TabIndex = 7;
			this.txtTownName.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 24);
			this.label4.Name = "label4";
			this.label4.TabIndex = 6;
			this.label4.Text = "管理局名称：";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDes
			// 
			this.txtDes.Location = new System.Drawing.Point(128, 96);
			this.txtDes.Name = "txtDes";
			this.txtDes.Size = new System.Drawing.Size(144, 21);
			this.txtDes.TabIndex = 5;
			this.txtDes.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "备注：";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCountryName
			// 
			this.txtCountryName.Location = new System.Drawing.Point(128, 56);
			this.txtCountryName.Name = "txtCountryName";
			this.txtCountryName.Size = new System.Drawing.Size(144, 21);
			this.txtCountryName.TabIndex = 3;
			this.txtCountryName.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "管理局简称：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(224, 152);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(144, 152);
			this.btnSave.Name = "btnSave";
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "保存";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// frmAddCountry
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(322, 184);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmAddCountry";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.frmAddCountry_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			try

			{
				
				if(this.txtCountryName.Text.Trim()=="")
				{
					MessageBox.Show("管理局名称不能为空!");
					return;
				}

				
				string strSql=String.Format("select count(*) from tbCountry where countryName='{0}'",this.txtCountryName.Text.Trim());
				string strCount=CDBConnection.ExecuteScalar(strSql);
				int iCount=Convert.ToInt32(strCount);
				if(iCount>0)
				{
					MessageBox.Show("该管理局名称已存在!");
					return;
				}


				strSql=String.Format("insert into tbCountry(CountryName,CountryDes,townName) values('{0}','{1}','{2}')",this.txtCountryName.Text.Trim(),this.txtDes.Text.Trim(),this.txtTownName.Text.Trim());
				CDBConnection.ExecuteSql(strSql);				

				this.m_bInserted =true;
				this.Close();

                
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmAddCountry_Load(object sender, System.EventArgs e)
		{
			try
			{
				this.txtTownName.Text=this.m_strTownName ;					
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
	}
}

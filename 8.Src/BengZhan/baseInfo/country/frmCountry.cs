using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data ;
namespace BengZhan.baseInfo.country
{
	/// <summary>
	/// frmCountry 的摘要说明。
	/// </summary>
	public class frmCountry : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListView lsvCountry;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmCountry()
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
			this.btnExit = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnInsert = new System.Windows.Forms.Button();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lsvCountry = new System.Windows.Forms.ListView();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnExit);
			this.groupBox1.Controls.Add(this.btnDel);
			this.groupBox1.Controls.Add(this.btnInsert);
			this.groupBox1.Location = new System.Drawing.Point(8, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(272, 40);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(176, 12);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(80, 23);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(88, 12);
			this.btnDel.Name = "btnDel";
			this.btnDel.TabIndex = 1;
			this.btnDel.Text = "删除";
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// btnInsert
			// 
			this.btnInsert.Location = new System.Drawing.Point(8, 12);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.TabIndex = 0;
			this.btnInsert.Text = "添加";
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "备注";
			this.columnHeader3.Width = 146;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "管理局名称";
			this.columnHeader2.Width = 142;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lsvCountry);
			this.groupBox2.Location = new System.Drawing.Point(8, 40);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(488, 328);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			// 
			// lsvCountry
			// 
			this.lsvCountry.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						 this.columnHeader2,
																						 this.columnHeader4,
																						 this.columnHeader3});
			this.lsvCountry.FullRowSelect = true;
			this.lsvCountry.GridLines = true;
			this.lsvCountry.Location = new System.Drawing.Point(8, 16);
			this.lsvCountry.Name = "lsvCountry";
			this.lsvCountry.Size = new System.Drawing.Size(472, 304);
			this.lsvCountry.TabIndex = 0;
			this.lsvCountry.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "管理局简称";
			this.columnHeader4.Width = 137;
			// 
			// frmCountry
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(504, 374);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCountry";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "管理局信息";
			this.Load += new System.EventHandler(this.frmCountry_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmCountry_Load(object sender, System.EventArgs e)
		{
			try
			{
				this.paintFrm();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
		
		}
		private void paintFrm()
		{
			try
			{
				string strSql=String.Format("select CountryName,CountryDes,townName from tbCountry");

				DataTable dtCountry=null;
				CDBConnection.getDataTable(ref dtCountry,strSql,"btCountry");

				this.lsvCountry.Items.Clear();

				for(int i=0;i<dtCountry.Rows.Count;i++)
				{

					this.lsvCountry.Items.Add(dtCountry.Rows[i]["countryName"].ToString());					
					this.lsvCountry.Items[i].SubItems.Add(dtCountry.Rows[i]["townName"].ToString());
					this.lsvCountry.Items[i].SubItems.Add(dtCountry.Rows[i]["countryDes"].ToString());

				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			

		}

		private void btnInsert_Click(object sender, System.EventArgs e)
		{
			try
			{				
				
				frmAddCountry frmAddCountryObj=new frmAddCountry();			
				frmAddCountryObj.m_strTownName ="";
				frmAddCountryObj.ShowDialog();

				if(frmAddCountryObj.m_bInserted==true)
				{
					this.paintFrm();
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
				if(this.lsvCountry.SelectedItems.Count==0)
				{
					MessageBox.Show("请选中要删除的管理局!");
					return;
				}

				string strCountryName=this.lsvCountry.SelectedItems[0].Text.Trim();
//
				string strSql=String.Format("select count(*) from tbDep where countryName='{0}'",strCountryName);
				string strCount=CDBConnection.ExecuteScalar(strSql);
				if(strCount!="0")
				{
					MessageBox.Show("该管理局以下已录入管理处,请先将其下的管理处信息删除!");
					return;
				}

				strSql=String.Format("delete from tbCountry where countryName='{0}'",strCountryName);
				CDBConnection.ExecuteSql(strSql);			

				this.paintFrm();
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

		private void cmbTown_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.paintFrm();
		}


	}
}

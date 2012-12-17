using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data ;
namespace BengZhan.baseInfo.town
{
	/// <summary>
	/// frmTown 的摘要说明。
	/// </summary>
	public class frmTown : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ListView lsvTown;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTown()
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lsvTown = new System.Windows.Forms.ListView();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnExit);
			this.groupBox1.Controls.Add(this.btnDel);
			this.groupBox1.Controls.Add(this.btnInsert);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(264, 40);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(168, 12);
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
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lsvTown);
			this.groupBox2.Location = new System.Drawing.Point(8, 48);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(376, 280);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// lsvTown
			// 
			this.lsvTown.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					  this.columnHeader2,
																					  this.columnHeader3});
			this.lsvTown.FullRowSelect = true;
			this.lsvTown.GridLines = true;
			this.lsvTown.Location = new System.Drawing.Point(8, 16);
			this.lsvTown.Name = "lsvTown";
			this.lsvTown.Size = new System.Drawing.Size(360, 256);
			this.lsvTown.TabIndex = 0;
			this.lsvTown.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "县名称";
			this.columnHeader2.Width = 155;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "备注";
			this.columnHeader3.Width = 176;
			// 
			// frmTown
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(394, 336);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTown";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "县级信息";
			this.Load += new System.EventHandler(this.frmTown_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnDel_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.lsvTown.SelectedItems.Count==0)
				{
					MessageBox.Show("请选中要删除的县!");
					return;
				}				
				
				string strSql=String.Format("select count(*) from tbCountry where townName='{0}'",this.lsvTown.SelectedItems[0].SubItems[0].Text.Trim());
				string strCount=CDBConnection.ExecuteScalar(strSql);
				if(strCount.Trim()!="0")
				{
					MessageBox.Show("该县以下已录入乡镇信息不能删除！");
					return;
				}

				string strTownName=this.lsvTown.SelectedItems[0].Text.Trim();
				strSql=String.Format("delete from tbTown where townName='{0}'",strTownName);
				CDBConnection.ExecuteSql(strSql);
				
				this.paintFrm();

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			

		}

		private void frmTown_Load(object sender, System.EventArgs e)
		{
			this.paintFrm();
		
		}

		private void btnInsert_Click(object sender, System.EventArgs e)
		{
			frmAddTown frmAddTownObj=new  frmAddTown();
			frmAddTownObj.ShowDialog();

			if(frmAddTownObj.m_bInserted==true)
			{
				this.paintFrm();
			}


		}
		private void paintFrm()
		{
			try
			{
				string strSql=String.Format("select townName,townDes from tbTown");
				DataTable dtTown=null;
				CDBConnection.getDataTable(ref dtTown,strSql,"btTown");

				this.lsvTown.Items.Clear();

				for(int i=0;i<dtTown.Rows.Count;i++)
				{
					this.lsvTown.Items.Add(dtTown.Rows[i]["townName"].ToString());
					this.lsvTown.Items[i].SubItems.Add(dtTown.Rows[i]["townDes"].ToString());					
				}

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


	}
}

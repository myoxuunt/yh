using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using  System.Data;


namespace BengZhan.deps
{
	/// <summary>
	/// frmSalZhans 的摘要说明。
	/// </summary>
	public class frmSalZhans : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView lsvDep;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ComboBox cmbCountry;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ListView lsvChu;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmSalZhans()
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
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lsvDep = new System.Windows.Forms.ListView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cmbCountry = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.lsvChu = new System.Windows.Forms.ListView();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "售水单价";
			this.columnHeader3.Width = 85;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "所属管理处";
			this.columnHeader4.Width = 85;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "管理所编号";
			this.columnHeader1.Width = 90;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "管理所名称";
			this.columnHeader2.Width = 110;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lsvDep);
			this.groupBox1.Location = new System.Drawing.Point(184, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(448, 416);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			// 
			// lsvDep
			// 
			this.lsvDep.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					 this.columnHeader1,
																					 this.columnHeader2,
																					 this.columnHeader4,
																					 this.columnHeader3});
			this.lsvDep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lsvDep.FullRowSelect = true;
			this.lsvDep.GridLines = true;
			this.lsvDep.Location = new System.Drawing.Point(3, 17);
			this.lsvDep.Name = "lsvDep";
			this.lsvDep.Size = new System.Drawing.Size(442, 396);
			this.lsvDep.TabIndex = 0;
			this.lsvDep.View = System.Windows.Forms.View.Details;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cmbCountry);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Location = new System.Drawing.Point(0, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(184, 40);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			// 
			// cmbCountry
			// 
			this.cmbCountry.Location = new System.Drawing.Point(88, 14);
			this.cmbCountry.Name = "cmbCountry";
			this.cmbCountry.Size = new System.Drawing.Size(96, 20);
			this.cmbCountry.TabIndex = 1;
			this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "所属管理局 :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnExit);
			this.groupBox2.Controls.Add(this.btnDel);
			this.groupBox2.Controls.Add(this.btnEdit);
			this.groupBox2.Controls.Add(this.btnAdd);
			this.groupBox2.Location = new System.Drawing.Point(184, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(336, 40);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(248, 11);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(80, 24);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(168, 12);
			this.btnDel.Name = "btnDel";
			this.btnDel.TabIndex = 2;
			this.btnDel.Text = "删除";
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(88, 12);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.TabIndex = 1;
			this.btnEdit.Text = "修改";
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(8, 12);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "添加";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.lsvChu);
			this.groupBox4.Location = new System.Drawing.Point(0, 40);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(184, 416);
			this.groupBox4.TabIndex = 6;
			this.groupBox4.TabStop = false;
			// 
			// lsvChu
			// 
			this.lsvChu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					 this.columnHeader5});
			this.lsvChu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lsvChu.FullRowSelect = true;
			this.lsvChu.GridLines = true;
			this.lsvChu.Location = new System.Drawing.Point(3, 17);
			this.lsvChu.MultiSelect = false;
			this.lsvChu.Name = "lsvChu";
			this.lsvChu.Size = new System.Drawing.Size(178, 396);
			this.lsvChu.TabIndex = 0;
			this.lsvChu.View = System.Windows.Forms.View.Details;
			this.lsvChu.Click += new System.EventHandler(this.lsvChu_Click);
			this.lsvChu.SelectedIndexChanged += new System.EventHandler(this.lsvChu_SelectedIndexChanged);
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "管理处";
			this.columnHeader5.Width = 173;
			// 
			// frmSalZhans
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(632, 461);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSalZhans";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "售水站信息";
			this.Load += new System.EventHandler(this.frmSalZhans_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void paintFrm(string strDepName)		
		{
			string strSql=string.Format("select wellNo,wellName,depName,price1 from tbWell where depName='{0}' and bSal='true'",strDepName);

			DataTable dtWell=new  DataTable();

			BengZhan.CDBConnection.getDataTable(ref dtWell,strSql,"dtWell");

			this.lsvDep.Items.Clear();

			for(int i=0;i<dtWell.Rows.Count;i++)
			{

				this.lsvDep.Items.Add(dtWell.Rows[i]["wellNo"].ToString());
				this.lsvDep.Items[i].SubItems.Add(dtWell.Rows[i]["wellName"].ToString().Replace("sal",""));
				this.lsvDep.Items[i].SubItems.Add(dtWell.Rows[i]["depName"].ToString());
				this.lsvDep.Items[i].SubItems.Add(dtWell.Rows[i]["price1"].ToString());

			}


		}

		private void frmSalZhans_Load(object sender, System.EventArgs e)
		{
			string strSql=string.Format("select countryName from tbCountry");

			this.cmbCountry.Items.Clear();

			DataTable dtCountry=new DataTable();

			BengZhan.CDBConnection.getDataTable(ref dtCountry,strSql,"dtCountry");

			for(int i=0;i<dtCountry.Rows.Count;i++)
			{
				this.cmbCountry.Items.Add(dtCountry.Rows[i]["countryName"].ToString());
			}

					  
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void cmbCountry_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string strSql=string.Format("select depName from tbDep where countryName='{0}'",this.cmbCountry.Text.Trim());
			DataTable dtDep=new DataTable();

			BengZhan.CDBConnection.getDataTable(ref dtDep,strSql,"dtDep");

			this.lsvChu.Items.Clear();

			for(int i=0;i<dtDep.Rows.Count;i++)			
			{
				this.lsvChu.Items.Add(dtDep.Rows[i]["depName"].ToString().Trim());
			}

					  //this.paintFrm(this.cmbCountry.Text.Trim());
		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{

			if(this.lsvChu.SelectedItems.Count==0)
			{
				MessageBox.Show("请选择新加站点所属管理处！");
				return;
			}

			string strDepName=this.lsvChu.SelectedItems[0].Text.Trim();
			
			frmSalZhansEdit frmSZE=new frmSalZhansEdit();

			frmSZE.m_strCountryName=strDepName;

			frmSZE.ShowDialog();

			this.lsvChu_Click(null,null);



		}

		private void lsvChu_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(this.lsvChu.SelectedItems.Count==0)
			{
				return;
			}

			string strName=this.lsvChu.SelectedItems[0].Text.Trim();


			this.paintFrm(strName);

			
		}

		private void btnDel_Click(object sender, System.EventArgs e)
		{
			if(this.lsvDep.SelectedItems.Count==0)
			{
				MessageBox.Show("请选择要删除的管理所！");
				return;
			}

			string strWellNo=this.lsvDep.SelectedItems[0].Text.Trim();
			
			string strSql=string.Format("delete from tbWell where wellNo='{0}'",strWellNo);

			BengZhan.CDBConnection.ExecuteSql(strSql);

			MessageBox.Show("删除完成！");

			this.lsvChu_Click(null,null);

		}

		private void btnEdit_Click(object sender, System.EventArgs e)
		{
			if(this.lsvDep.SelectedItems.Count==0)
			{
				MessageBox.Show("请选择要修改的管理所！");
				return;
			}

			string strWellNo=this.lsvDep.SelectedItems[0].Text.Trim();
			string strDepName=this.lsvDep.SelectedItems[0].SubItems[1].Text.Trim();
			string strCountryName=this.lsvDep.SelectedItems[0].SubItems[2].Text.Trim();


			frmSalZhansEdit frmSZE=new frmSalZhansEdit();

			frmSZE.strDepName=strDepName;
			frmSZE.m_strCountryName=strCountryName;
			frmSZE.m_bEdit=true;
			frmSZE.m_strWellNo=strWellNo;

			frmSZE.ShowDialog();

		}

		private void lsvChu_Click(object sender, System.EventArgs e)
		{
			this.lsvChu_SelectedIndexChanged(null,null);
		}


	}
}

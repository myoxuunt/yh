using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BengZhan.hangYe
{
	/// <summary>
	/// frmHangYeType 的摘要说明。
	/// </summary>
	public class frmHangYeType : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListView lsvHangYe;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmHangYeType()
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
			this.btnAdd = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lsvHangYe = new System.Windows.Forms.ListView();
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
			this.groupBox1.Controls.Add(this.btnAdd);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(304, 40);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(216, 12);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(112, 12);
			this.btnDel.Name = "btnDel";
			this.btnDel.TabIndex = 1;
			this.btnDel.Text = "删除";
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(16, 12);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "添加";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lsvHangYe);
			this.groupBox2.Location = new System.Drawing.Point(8, 48);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(384, 304);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// lsvHangYe
			// 
			this.lsvHangYe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.columnHeader2,
																						this.columnHeader3});
			this.lsvHangYe.FullRowSelect = true;
			this.lsvHangYe.GridLines = true;
			this.lsvHangYe.Location = new System.Drawing.Point(8, 16);
			this.lsvHangYe.Name = "lsvHangYe";
			this.lsvHangYe.Size = new System.Drawing.Size(368, 280);
			this.lsvHangYe.TabIndex = 0;
			this.lsvHangYe.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "行业名称";
			this.columnHeader2.Width = 180;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "行业性质";
			this.columnHeader3.Width = 159;
			// 
			// frmHangYeType
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(400, 358);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmHangYeType";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "行业性质";
			this.Load += new System.EventHandler(this.frmHangYeType_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmHangYeType_Load(object sender, System.EventArgs e)
		{
			this.paintFrm();
		
		}

		private void paintFrm()
		{
			try
			{
				string strSql=String.Format("select HangYeName,HangYeType from tbHangYe");
				DataTable dtHangYe=null;
				CDBConnection.getDataTable(ref dtHangYe,strSql,"btTown");

				this.lsvHangYe.Items.Clear();

				for(int i=0;i<dtHangYe.Rows.Count;i++)
				{	
					this.lsvHangYe.Items.Add(dtHangYe.Rows[i]["HangYeName"].ToString());					
					this.lsvHangYe.Items[i].SubItems.Add(dtHangYe.Rows[i]["HangYeType"].ToString());
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			frmHangYeAdd frmHangYeAddObj=new  frmHangYeAdd();
			frmHangYeAddObj.ShowDialog();

			if(frmHangYeAddObj.m_bInserted==true)
			{
				this.paintFrm();
			}

		}

		private void btnDel_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.lsvHangYe.SelectedItems.Count==0)
				{
					MessageBox.Show("请选中要删除的行业!");
					return;
				}				
				
			
				string strHangYeName=this.lsvHangYe.SelectedItems[0].Text.Trim();
				string strSql=String.Format("delete from tbHangYe where HangYeName='{0}'",strHangYeName);
				CDBConnection.ExecuteSql(strSql);
				
				this.paintFrm();

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

	}
}

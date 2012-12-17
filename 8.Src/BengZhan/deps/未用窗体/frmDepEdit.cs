using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BengZhan.deps
{
	/// <summary>
	/// frmDepEdit 的摘要说明。
	/// </summary>
	public class frmDepEdit : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.ComboBox cmbCountry;
		private System.Windows.Forms.TextBox txtDepName;
		private System.Windows.Forms.TextBox txtContactPer;
		private System.Windows.Forms.TextBox txtContactTel;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtDes;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public bool m_bEdit=false;
		//单位简称
		public string m_strDepShortName="";

		public bool m_bInserted=false;
		private System.Windows.Forms.TextBox txtDepShortName;
		private System.Windows.Forms.ComboBox cmbHangYe;
		private System.Windows.Forms.Label label4;
		public string m_strCountryName="";

		public frmDepEdit()
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
			this.label8 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtContactTel = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtContactPer = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbCountry = new System.Windows.Forms.ComboBox();
			this.cmbHangYe = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDepName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDepShortName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtDes);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtAddress);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtContactTel);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtContactPer);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.cmbCountry);
			this.groupBox1.Controls.Add(this.cmbHangYe);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtDepName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtDepShortName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(456, 152);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// txtDes
			// 
			this.txtDes.Location = new System.Drawing.Point(328, 88);
			this.txtDes.Name = "txtDes";
			this.txtDes.Size = new System.Drawing.Size(112, 21);
			this.txtDes.TabIndex = 16;
			this.txtDes.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(232, 88);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(88, 18);
			this.label8.TabIndex = 15;
			this.label8.Text = "备注：";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(328, 120);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(112, 21);
			this.txtAddress.TabIndex = 14;
			this.txtAddress.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(248, 120);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 23);
			this.label7.TabIndex = 13;
			this.label7.Text = "地址：";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtContactTel
			// 
			this.txtContactTel.Location = new System.Drawing.Point(328, 56);
			this.txtContactTel.Name = "txtContactTel";
			this.txtContactTel.Size = new System.Drawing.Size(112, 21);
			this.txtContactTel.TabIndex = 12;
			this.txtContactTel.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(224, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(96, 16);
			this.label6.TabIndex = 11;
			this.label6.Text = "联系电话：";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtContactPer
			// 
			this.txtContactPer.Location = new System.Drawing.Point(104, 88);
			this.txtContactPer.Name = "txtContactPer";
			this.txtContactPer.Size = new System.Drawing.Size(104, 21);
			this.txtContactPer.TabIndex = 10;
			this.txtContactPer.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "联系人：";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbCountry
			// 
			this.cmbCountry.Location = new System.Drawing.Point(104, 56);
			this.cmbCountry.Name = "cmbCountry";
			this.cmbCountry.Size = new System.Drawing.Size(104, 20);
			this.cmbCountry.TabIndex = 8;
			// 
			// cmbHangYe
			// 
			this.cmbHangYe.ItemHeight = 12;
			this.cmbHangYe.Location = new System.Drawing.Point(328, 56);
			this.cmbHangYe.Name = "cmbHangYe";
			this.cmbHangYe.Size = new System.Drawing.Size(112, 20);
			this.cmbHangYe.TabIndex = 7;
			this.cmbHangYe.Visible = false;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(224, 58);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "行业（性质）：";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label4.Visible = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "所属管理局：";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDepName
			// 
			this.txtDepName.Location = new System.Drawing.Point(328, 24);
			this.txtDepName.Name = "txtDepName";
			this.txtDepName.Size = new System.Drawing.Size(112, 21);
			this.txtDepName.TabIndex = 3;
			this.txtDepName.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(224, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "管理处名称：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDepShortName
			// 
			this.txtDepShortName.Location = new System.Drawing.Point(104, 24);
			this.txtDepShortName.Name = "txtDepShortName";
			this.txtDepShortName.Size = new System.Drawing.Size(104, 21);
			this.txtDepShortName.TabIndex = 1;
			this.txtDepShortName.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "管理处简称：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(264, 168);
			this.btnSave.Name = "btnSave";
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "保存";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(392, 168);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// frmDepEdit
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(474, 200);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmDepEdit";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "编辑管理处信息";
			this.Load += new System.EventHandler(this.frmDepEdit_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmDepEdit_Load(object sender, System.EventArgs e)
		{
			try
			{
				string strSql=String.Format("select countryName from tbCountry");
				DataTable dtCountry=null;
				CDBConnection.getDataTable(ref dtCountry,strSql,"dtCountry");

				this.cmbCountry.Items.Clear();
				for(int i=0;i<dtCountry.Rows.Count;i++)
				{
					this.cmbCountry.Items.Add(dtCountry.Rows[i]["countryName"].ToString());
				}

				if(this.cmbCountry.Items.Count>0)
				{
					this.cmbCountry.Text=this.cmbCountry.Items[0].ToString();					
				}
				else
				{
					this.cmbCountry.Text="";
				}

				this.cmbHangYe.Items.Clear();

				strSql="select hangYeName from tbHangYe";
				DataTable dtHangYe=null;
				CDBConnection.getDataTable(ref dtHangYe,strSql,"HangYe");				
				for(int i=0;i<dtHangYe.Rows.Count;i++)
				{
					this.cmbHangYe.Items.Add(dtHangYe.Rows[i]["HangYeName"].ToString());
				}

				if(this.cmbHangYe.Items.Count>0)
				{
					this.cmbHangYe.Text=this.cmbHangYe.Items[0].ToString();
				}
				else
				{
					this.cmbHangYe.Text="";
				}

				if(this.m_bEdit==false)
				{				
					this.cmbCountry.Text=this.m_strCountryName;
				}
				else
				{
					strSql=String.Format("select depShortName,depName,CountryName,HangYeName,ContactPer,ContactTel,address,des from tbDep where depShortName='{0}'",this.m_strDepShortName.Trim());
					DataTable dtDep=null;

					if(CDBConnection.getDataTable(ref dtDep,strSql,"dep")==false)
					{
						return;
					}
					if(dtDep.Rows.Count>0)
					{
						this.txtDepShortName.Text=dtDep.Rows[0]["depShortName"].ToString();
						this.txtDepShortName.ReadOnly =true;
						this.txtDepName.Text=dtDep.Rows[0]["depName"].ToString();
						this.txtAddress.Text=dtDep.Rows[0]["address"].ToString();
						this.txtContactPer.Text=dtDep.Rows[0]["ContactPer"].ToString();
						this.txtContactTel.Text=dtDep.Rows[0]["ContactTel"].ToString();
						this.txtDes.Text=dtDep.Rows[0]["des"].ToString();
						this.cmbHangYe.Text=dtDep.Rows[0]["HangYeName"].ToString();
						this.cmbCountry.Text=dtDep.Rows[0]["CountryName"].ToString();
					}
					

				}				
			
		}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			try

			{
				if(this.txtDepShortName.Text.Trim()=="")
				{
					MessageBox.Show("管理处简称不能为空!");
					return;
				}
				if(this.txtDepName.Text.Trim()=="")
				{
					MessageBox.Show("管理处名称不能为空!");
					return;
				}
                
				string strSql="";
				if(this.m_bEdit==true)
				{
					strSql=String.Format("delete from tbDep where depShortName='{0}'",this.txtDepShortName.Text.Trim());
					CDBConnection.ExecuteSql(strSql);
				}
			
				
				strSql=String.Format("select count(*) from tbDep where depName='{0}'",this.txtDepName.Text.Trim());
				string strCount=CDBConnection.ExecuteScalar(strSql);
				int iCount=Convert.ToInt32(strCount);
				if(iCount>0)
				{
					MessageBox.Show("该管理处名称已存在!");
					return;
				}

				strSql=String.Format("select count(*) from tbDep where depShortName='{0}'",this.txtDepShortName.Text.Trim());
				strCount=CDBConnection.ExecuteScalar(strSql);
				if(strCount!="0")
				{
					MessageBox.Show("该管理处简称已存在!");
					return;
				}

				strSql=String.Format("insert into tbDep(DepShortName,depName,countryName,hangYeName,contactPer,contactTel,address,des) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",this.txtDepShortName.Text.Trim(),this.txtDepName.Text.Trim(),this.cmbCountry.Text.Trim(),this.cmbHangYe.Text.Trim(),this.txtContactPer.Text.Trim(),this.txtContactTel.Text.Trim(),this.txtAddress.Text.Trim(),this.txtDes.Text.Trim());
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

	}
}

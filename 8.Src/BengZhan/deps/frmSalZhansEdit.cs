using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BengZhan.deps
{
	/// <summary>
	/// frmSalZhansEdit 的摘要说明。
	/// </summary>
	public class frmSalZhansEdit : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDepName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNo;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.TextBox txtCountry;

		public string m_strCountryName="";

		public frmSalZhansEdit()
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
			this.txtCountry = new System.Windows.Forms.TextBox();
			this.txtNo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDepName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtCountry);
			this.groupBox1.Controls.Add(this.txtNo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtPrice);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtDepName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(224, 152);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			// 
			// txtCountry
			// 
			this.txtCountry.Location = new System.Drawing.Point(104, 56);
			this.txtCountry.Name = "txtCountry";
			this.txtCountry.ReadOnly = true;
			this.txtCountry.Size = new System.Drawing.Size(104, 21);
			this.txtCountry.TabIndex = 21;
			this.txtCountry.Text = "";
			// 
			// txtNo
			// 
			this.txtNo.Location = new System.Drawing.Point(104, 24);
			this.txtNo.Name = "txtNo";
			this.txtNo.TabIndex = 20;
			this.txtNo.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 19;
			this.label1.Text = "管理所编号:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(104, 120);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(104, 21);
			this.txtPrice.TabIndex = 18;
			this.txtPrice.Text = "";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 120);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 23);
			this.label9.TabIndex = 17;
			this.label9.Text = "售水单价:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "所属管理处：";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDepName
			// 
			this.txtDepName.Location = new System.Drawing.Point(104, 88);
			this.txtDepName.Name = "txtDepName";
			this.txtDepName.Size = new System.Drawing.Size(104, 21);
			this.txtDepName.TabIndex = 3;
			this.txtDepName.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "管理所名称：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(176, 168);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(56, 23);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(112, 168);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(56, 23);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "保存";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// frmSalZhansEdit
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(240, 205);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSalZhansEdit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "售水站点信息编辑";
			this.Load += new System.EventHandler(this.frmSalZhansEdit_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

	//	private string m_strCountryName="";

		//private void 

		public string strDepName="";

		private void frmSalZhansEdit_Load(object sender, System.EventArgs e)
		{		
			//this.txtDepName.Text=this.m_strCountryName;

			if(this.m_bEdit)
			{
				this.txtNo.Text=this.m_strWellNo;
				this.txtDepName.Text=this.strDepName;
				this.txtCountry.Text=this.m_strCountryName;
				this.txtDepName.ReadOnly=true;
				return;
			}
			this.txtCountry.Text=this.m_strCountryName;

			this.txtNo.Text=this.getWellNo();

			//string strSql=string.Format("select d");
		}

		public bool m_bEdit=false;
		public string m_strWellNo="";



		private void paintFrm()
		{
			if(this.m_bEdit)
			{

				string strSql=string.Format("select wellName,depName,price1 from tbWell where wellNo='{0}'",this.m_strWellNo);

				DataTable dtWell=new   DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtWell,strSql,"ddtWell");

				this.txtDepName.Text=dtWell.Rows[0]["wellName"].ToString().Trim();

				this.txtCountry.Text=dtWell.Rows[0]["depName"].ToString().Trim();

				this.txtPrice.Text=dtWell.Rows[0]["price1"].ToString().Trim();


			}
			else			
			{
				string strWellNo=this.getWellNo();
				this.txtNo.Text=strWellNo;
			}
		}

		private string getWellNo()
		{

			string strSql="select tbNo from tbDel where tbName='tbWell'";				

			string strWellNo=CDBConnection.ExecuteScalar(strSql);

			if(strWellNo.Trim()!="")
			{
				return strWellNo;
			}
			else
			{

				strSql="select count(*) from tbWell";					
				int iCount=0;						
				iCount=Convert.ToInt32(CDBConnection.ExecuteScalar(strSql));						
				iCount=iCount+1;

				strWellNo=cStr(iCount.ToString());					
				return strWellNo;						
			}
		}

		private string cStr(string str)
		{
			if(str.Length==1)
			{
				return "00"+str;
			}
			if(str.Length==2)
			{
				return "0"+str;
			}
			
			return str;			
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.txtDepName.Text.Trim()=="")
				{
					MessageBox.Show("请输入管理所名称！");
					return;
				}

				if(this.txtPrice.Text.Trim()=="")
				{
					MessageBox.Show("请输入售水单价！");
					return;
				}

				string strSql=string.Format("select count(*) from tbWell where wellName='{0}'",this.txtDepName.Text.Trim());
				string strCount=BengZhan.CDBConnection.ExecuteScalar(strSql);
				if((strCount.Trim()=="")||(strCount=="0"))
				{
					
				}
				else
				{
					MessageBox.Show("请更改管理所名称，该名称已录入！");
					return;
				}


				 strSql=string.Format("delete from tbWell where wellNo='{0}'",this.txtNo.Text.Trim());
				BengZhan.CDBConnection.ExecuteSql(strSql);

				 strSql=string.Format("insert into tbWell(wellNo,wellName,price1,bSal,depName)values('{0}','{1}','{2}','{3}','{4}')",this.txtNo.Text.Trim(),this.txtDepName.Text.Trim(),this.txtPrice.Text.Trim(),"true",this.txtCountry.Text.Trim());
				BengZhan.CDBConnection.ExecuteSql(strSql);

				MessageBox.Show("保存完成!");

				this.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BengZhan.hangYe
{
	/// <summary>
	/// frmPrice 的摘要说明。
	/// </summary>
	public class frmPrice : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ComboBox cmbType;
		private System.Windows.Forms.ListView lsvDep;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmPrice()
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
			this.cmbType = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lsvDep = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbType);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(256, 48);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Visible = false;
			// 
			// cmbType
			// 
			this.cmbType.Location = new System.Drawing.Point(120, 16);
			this.cmbType.Name = "cmbType";
			this.cmbType.Size = new System.Drawing.Size(121, 20);
			this.cmbType.TabIndex = 1;
			this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "所属行业：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lsvDep);
			this.groupBox2.Location = new System.Drawing.Point(8, 48);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(256, 216);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Visible = false;
			// 
			// lsvDep
			// 
			this.lsvDep.CheckBoxes = true;
			this.lsvDep.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					 this.columnHeader1});
			this.lsvDep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lsvDep.FullRowSelect = true;
			this.lsvDep.GridLines = true;
			this.lsvDep.Location = new System.Drawing.Point(3, 17);
			this.lsvDep.Name = "lsvDep";
			this.lsvDep.Size = new System.Drawing.Size(250, 196);
			this.lsvDep.TabIndex = 0;
			this.lsvDep.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "单位";
			this.columnHeader1.Width = 217;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtPrice);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Location = new System.Drawing.Point(8, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(128, 48);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(56, 16);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(64, 21);
			this.txtPrice.TabIndex = 1;
			this.txtPrice.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "水价：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btnExit);
			this.groupBox4.Controls.Add(this.btnSave);
			this.groupBox4.Location = new System.Drawing.Point(136, 0);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(128, 48);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(64, 16);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(56, 24);
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click_2);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(8, 16);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(56, 24);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "保存";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// frmPrice
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(274, 55);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmPrice";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "水价管理";
			this.Load += new System.EventHandler(this.frmPrice_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnSet_Click(object sender, System.EventArgs e)
		{
			if(this.txtPrice.Text.Trim()=="")
			{
				MessageBox.Show("水价不允许为空！");
				return;
			}
			if(!this.isChars(this.txtPrice.Text.Trim()))
			{
				MessageBox.Show("水价填写有误！");
				return;
			}

//			if(this.cmbPType.Text.IndexOf("系统")>=0)
//			{
//				if(MessageBox.Show(this,"设置系统水价，将修改所有监测站水价为该值！是否继续?","系统提示",MessageBoxButtons.YesNo)!=DialogResult.Yes)
//				{
//					return;
//				}
//				string strSql=string.Format("update tbWell set price='{0}'",this.txtPrice.Text.Trim());
//				BengZhan.CDBConnection.ExecuteSql(strSql);
//			}
//			else
//			{
//				if(MessageBox.Show(this,"设置单位水价，将修改属于该单位的所有监测站的水价为该值！是否继续?","系统提示",MessageBoxButtons.YesNo)!=DialogResult.Yes)
//				{
//					return;
//				}
//				string strSql=string.Format("update tbWell set price='{0}'  where depName='{1}'",this.txtPrice.Text.Trim(),this.cmbPType.Text.Trim().Replace("水价",""));
//				BengZhan.CDBConnection.ExecuteSql(strSql);
//			} 
          	MessageBox.Show("设置成功！");		
		}

		private bool isChars(string strChars)
		{
			for(int i=0;i<strChars.Length;i++)
			{
				string strChar=strChars.Substring(i,1);
				if(strChar==".")
				{
					continue;
				}
				if(!char.IsNumber(Convert.ToChar(strChar)))
				{
					return false;
				}
			}
			return true;
		}

		private void frmPrice_Load(object sender, System.EventArgs e)
		{
			try
			{
				this.cmbType.Items.Clear();
				this.lsvDep.Items.Clear();

				this.cmbType.Items.Add("所有单位");	
			
				string strSql=string.Format("select HangYeName from tbHangYe");
				DataTable dt=new   DataTable();
				BengZhan.CDBConnection.getDataTable(ref dt,strSql,"tbHangYe");
				for(int i=0;i<dt.Rows.Count;i++)
				{
					this.cmbType.Items.Add(dt.Rows[i]["HangYeName"].ToString());
				}
				this.cmbType.Text=this.cmbType.Items[0].ToString();

	
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnExit_Click_1(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnExit_Click_2(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void cmbType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
				this.lsvDep.Items.Clear();
				//this.cmbType.Items.Clear();
				string strSql=string.Format("select depShortName from tbDep where HangYeName='{0}'",this.cmbType.Text.Trim());
				DataTable dt=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dt,strSql,"tbDep");
				for(int i=0;i<dt.Rows.Count;i++)
				{
					this.lsvDep.Items.Add(dt.Rows[i][0].ToString().Trim());
						this.lsvDep.Items[i].Checked=true;
				}
				if(this.cmbType.Text.Trim()=="所有单位")
				{
					strSql=string.Format("select depShortName from tbDep");
					BengZhan.CDBConnection.getDataTable(ref dt,strSql,"tbDep");
					for(int i=0;i<dt.Rows.Count;i++)					
					{
						this.lsvDep.Items.Add(dt.Rows[i][0].ToString().Trim());
						this.lsvDep.Items[i].Checked=true;
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
			if(this.txtPrice.Text.Trim()=="")
			{
				MessageBox.Show("水价不允许为空！");
				return;
			}
			if(!this.isChars(this.txtPrice.Text.Trim()))
			{
				MessageBox.Show("水价填写有误！");
				return;
			}

			try
			{
				double dPrice=double.Parse(this.txtPrice.Text);
			}
			catch
			{
				MessageBox.Show("单价不是有效数据！");
				return;
			}

			if(MessageBox.Show(this,"保存水价，将修改属于所选单位的所有监测站的水价为该值！是否继续?","系统提示",MessageBoxButtons.YesNo)!=DialogResult.Yes)
			{
				return;
			}

			string strSql=string.Format("update tbWell set price1='{0}'",this.txtPrice.Text.Trim());
			BengZhan.CDBConnection.ExecuteSql(strSql);

			MessageBox.Show("设置成功！");	
	
		}
	}
}

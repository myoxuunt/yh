using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace winCom
{
	/// <summary>
	/// frmSet 的摘要说明。
	/// </summary>
	public class frmSet : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnCer;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAllAmount;
		private System.Windows.Forms.Label labDan;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmSet()
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
			this.txtAllAmount = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCer = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.labDan = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.labDan);
			this.groupBox1.Controls.Add(this.txtAllAmount);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(368, 96);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// txtAllAmount
			// 
			this.txtAllAmount.Location = new System.Drawing.Point(136, 36);
			this.txtAllAmount.Name = "txtAllAmount";
			this.txtAllAmount.Size = new System.Drawing.Size(136, 21);
			this.txtAllAmount.TabIndex = 1;
			this.txtAllAmount.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCer
			// 
			this.btnCer.Location = new System.Drawing.Point(216, 136);
			this.btnCer.Name = "btnCer";
			this.btnCer.TabIndex = 1;
			this.btnCer.Text = "确定";
			this.btnCer.Click += new System.EventHandler(this.btnCer_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(296, 136);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// labDan
			// 
			this.labDan.AutoSize = true;
			this.labDan.Location = new System.Drawing.Point(280, 40);
			this.labDan.Name = "labDan";
			this.labDan.Size = new System.Drawing.Size(42, 17);
			this.labDan.TabIndex = 2;
			this.labDan.Text = "label2";
			this.labDan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// frmSet
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(378, 189);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnCer);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSet";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "设参";
			this.Load += new System.EventHandler(this.frmSet_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.m_strVal="exit";
			this.Close();
		}

		public string m_strVal="";

		private void btnCer_Click(object sender, System.EventArgs e)
		{
			if(this.label1.Text.IndexOf("卡号")>=0)
			{
				this.m_strVal=this.txtAllAmount.Text.Trim();
				this.Close();
				return ;
			}

			if(this.txtAllAmount.Text.IndexOf("-")>0)
			{
				MessageBox.Show("数据输入有误！");
				return ;
			}

			try
			{

				int iAllAmount=int.Parse(this.txtAllAmount.Text);
				iAllAmount=iAllAmount;
				this.m_strVal=iAllAmount.ToString();
				this.Close();
				return;

			}
			catch
			{
				MessageBox.Show("数据输入有误！");
				return ;
			}	
			this.m_strVal=this.txtAllAmount.Text.Trim();

			this.Close();
		}

		public string m_strInfo="";

		public string m_strDan="";

		private void frmSet_Load(object sender, System.EventArgs e)
		{
			this.label1.Text=this.m_strInfo.Replace("设置","")+"：";	
			this.labDan.Text=m_strDan;
		}
	}
}

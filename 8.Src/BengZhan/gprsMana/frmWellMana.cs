using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace BengZhan.gprsMana
{
	/// <summary>
	/// frmWellMana 的摘要说明。
	/// </summary>
	public class frmWellMana : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.TextBox txtWellNo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDepName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtLeftAmount;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtUsedAmount;
		private System.Windows.Forms.Button btnAsk;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public string m_strWellNo="";
		public New.laidianDisplay.ManaGprs.CGprsComTest m_cGprsComT;

		private string m_strGprsNo="";
		private string m_strAddress="";


		public frmWellMana()
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
			this.btnAsk = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtWellNo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDepName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtLeftAmount = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtUsedAmount = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtUsedAmount);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtLeftAmount);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtDepName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtWellNo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(424, 112);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// btnAsk
			// 
			this.btnAsk.Location = new System.Drawing.Point(120, 120);
			this.btnAsk.Name = "btnAsk";
			this.btnAsk.TabIndex = 1;
			this.btnAsk.Text = "远程招测";
			this.btnAsk.Click += new System.EventHandler(this.btnAsk_Click);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(200, 120);
			this.btnStart.Name = "btnStart";
			this.btnStart.TabIndex = 2;
			this.btnStart.Text = "启动";
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(280, 120);
			this.btnStop.Name = "btnStop";
			this.btnStop.TabIndex = 3;
			this.btnStop.Text = "停止";
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(360, 120);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "监测站编号：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtWellNo
			// 
			this.txtWellNo.Location = new System.Drawing.Point(104, 32);
			this.txtWellNo.Name = "txtWellNo";
			this.txtWellNo.ReadOnly = true;
			this.txtWellNo.TabIndex = 1;
			this.txtWellNo.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(216, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "单位名称：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDepName
			// 
			this.txtDepName.Location = new System.Drawing.Point(296, 32);
			this.txtDepName.Name = "txtDepName";
			this.txtDepName.ReadOnly = true;
			this.txtDepName.Size = new System.Drawing.Size(120, 21);
			this.txtDepName.TabIndex = 3;
			this.txtDepName.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "剩余水量：";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtLeftAmount
			// 
			this.txtLeftAmount.Location = new System.Drawing.Point(104, 72);
			this.txtLeftAmount.Name = "txtLeftAmount";
			this.txtLeftAmount.ReadOnly = true;
			this.txtLeftAmount.TabIndex = 5;
			this.txtLeftAmount.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(208, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "已用水量：";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtUsedAmount
			// 
			this.txtUsedAmount.Location = new System.Drawing.Point(296, 72);
			this.txtUsedAmount.Name = "txtUsedAmount";
			this.txtUsedAmount.ReadOnly = true;
			this.txtUsedAmount.Size = new System.Drawing.Size(120, 21);
			this.txtUsedAmount.TabIndex = 7;
			this.txtUsedAmount.Text = "";
			// 
			// frmWellMana
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(440, 150);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.btnAsk);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmWellMana";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "远程控制";
			this.Load += new System.EventHandler(this.frmWellMana_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmWellMana_Load(object sender, System.EventArgs e)
		{
			try
			{
				this.txtWellNo.Text =this.m_strWellNo;
				string strSql=String.Format("select depName from tbWell where wellNo='{0}'",this.m_strWellNo);
				string strDepName=CDBConnection.ExecuteScalar(strSql);
				this.txtDepName.Text=strDepName;
				strSql=String.Format("select gprsNo from tbWell where wellNo='{0}'",this.m_strWellNo);
				string strGprsNo=CDBConnection.ExecuteScalar(strSql);
				strSql=String.Format("select watAddress from tbWell where wellNo='{0}'",this.m_strWellNo);
				string strAddress=CDBConnection.ExecuteScalar(strSql);
				this.m_strAddress=strAddress;
				
				if(strGprsNo.Trim()==""||strGprsNo==null)
				{
					this.Close();
				}
				
				this.m_strGprsNo =strGprsNo;
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
		}

		private void btnAsk_Click(object sender, System.EventArgs e)
		{
            this.m_cGprsComT.oneCom(this.m_strWellNo,this.m_strGprsNo);		
		}
	}
}

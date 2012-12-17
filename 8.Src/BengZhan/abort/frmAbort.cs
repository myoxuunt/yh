using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;

namespace BengZhan.abort
{
	/// <summary>
	/// frmAbort 的摘要说明。
	/// </summary>
	public class frmAbort : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnCer;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.Label lblWarn;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmAbort()
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnCer = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.lblInfo = new System.Windows.Forms.Label();
			this.lblWarn = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(56, 32);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(56, 48);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(8, 96);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(424, 8);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// btnCer
			// 
			this.btnCer.Location = new System.Drawing.Point(272, 160);
			this.btnCer.Name = "btnCer";
			this.btnCer.TabIndex = 2;
			this.btnCer.Text = "确定";
			this.btnCer.Click += new System.EventHandler(this.btnCer_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(352, 160);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// lblInfo
			// 
			this.lblInfo.Location = new System.Drawing.Point(144, 16);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(280, 72);
			this.lblInfo.TabIndex = 4;
			this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblWarn
			// 
			this.lblWarn.Location = new System.Drawing.Point(8, 112);
			this.lblWarn.Name = "lblWarn";
			this.lblWarn.Size = new System.Drawing.Size(416, 40);
			this.lblWarn.TabIndex = 5;
			// 
			// frmAbort
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(440, 189);
			this.Controls.Add(this.lblWarn);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnCer);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAbort";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.frmAbort_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnCer_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmAbort_Load(object sender, System.EventArgs e)
		{
			string strInfo="";
			string strSoftName="";
			string strWarn="";
			this.getSoftAbout(ref strInfo,ref strSoftName,ref strWarn);
			this.pictureBox1.Image=Image.FromFile("abort.bmp");
			this.lblInfo.Text=strInfo;
			this.Text="关于"+strSoftName;
			this.lblWarn.Text=strWarn;
		}
		//软件abort信息
		private bool getSoftAbout(ref string strAbout,ref string strSoftNameEx,ref string strWarnEx)
		{
			try
			{
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("Server.xml");

				string strXPath=String.Format(@"./abort/softName");

				string strSoftName=xDoc.DocumentElement.SelectSingleNode(strXPath).Attributes.GetNamedItem("val").Value.ToString().Trim();
				strXPath=String.Format(@"./abort/version");
				string strVer=xDoc.DocumentElement.SelectSingleNode(strXPath).Attributes.GetNamedItem("val").Value.ToString().Trim();
				strXPath=String.Format(@"./abort/own");
				string strOwn=xDoc.DocumentElement.SelectSingleNode(strXPath).Attributes.GetNamedItem("val").Value.ToString().Trim();
				strXPath=String.Format(@"./abort/warn");
				string strWarn=xDoc.DocumentElement.SelectSingleNode(strXPath).Attributes.GetNamedItem("val").Value.ToString().Trim();
				strWarnEx=strWarn;
				strXPath=String.Format(@"./abort/user");
				string strUser=xDoc.DocumentElement.SelectSingleNode(strXPath).Attributes.GetNamedItem("val").Value.ToString().Trim();
			
				strAbout=strSoftName+"\r\n"+strVer+"\r\n"+strOwn+"\r\n"+strUser;	
	
				strSoftNameEx=strSoftName;		
			

				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}
	}
}

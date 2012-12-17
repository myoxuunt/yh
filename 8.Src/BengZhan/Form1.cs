using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Xml;
using System.Data.SqlClient;


namespace BengZhan
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPwd;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnDbCon;
		private System.Windows.Forms.Button btnHelp;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		public Form m_frm;
	
		public Form1()
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
				if (components != null) 
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
			this.lblInfo = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPwd = new System.Windows.Forms.TextBox();
			this.btnDbCon = new System.Windows.Forms.Button();
			this.btnHelp = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblInfo
			// 
			this.lblInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblInfo.Location = new System.Drawing.Point(2, 0);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(286, 56);
			this.lblInfo.TabIndex = 0;
			this.lblInfo.Text = "灌区管理系统";
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(0, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(280, 8);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Location = new System.Drawing.Point(0, 144);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(280, 8);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(0, 160);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(66, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "登录";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(214, 160);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(66, 23);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "用户ID：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(112, 72);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(144, 21);
			this.txtUserName.TabIndex = 6;
			this.txtUserName.Text = "admin";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "用户口令：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPwd
			// 
			this.txtPwd.Location = new System.Drawing.Point(112, 112);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.PasswordChar = '*';
			this.txtPwd.Size = new System.Drawing.Size(144, 21);
			this.txtPwd.TabIndex = 8;
			this.txtPwd.Text = "";
			this.txtPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPwd_KeyPress);
			this.txtPwd.TextChanged += new System.EventHandler(this.txtPwd_TextChanged);
			// 
			// btnDbCon
			// 
			this.btnDbCon.Location = new System.Drawing.Point(72, 160);
			this.btnDbCon.Name = "btnDbCon";
			this.btnDbCon.Size = new System.Drawing.Size(66, 23);
			this.btnDbCon.TabIndex = 9;
			this.btnDbCon.Text = "连接测试";
			this.btnDbCon.Click += new System.EventHandler(this.btnDbCon_Click);
			// 
			// btnHelp
			// 
			this.btnHelp.Enabled = false;
			this.btnHelp.Location = new System.Drawing.Point(144, 160);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(66, 23);
			this.btnHelp.TabIndex = 10;
			this.btnHelp.Text = "帮助";
			this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.ClientSize = new System.Drawing.Size(282, 191);
			this.Controls.Add(this.btnHelp);
			this.Controls.Add(this.btnDbCon);
			this.Controls.Add(this.txtPwd);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblInfo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "系统登录";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		
		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.exXml();

			if(CDBConnection.m_sCon!=null)
			{
				this.btnDbCon.Enabled=false;
			}


			string strTitle="";
			if(this.getSoftAbout(ref strTitle)==true)
			{
				this.lblInfo.Text=strTitle;
			}


			XmlDocument xDoc=new XmlDocument();
			xDoc.Load("Server.xml");
			this.txtUserName.Text=xDoc.DocumentElement.SelectSingleNode("./load").Attributes.GetNamedItem("name").Value.Trim();



			//this.button1_Click(null,null);

			//this.lblInfo.Text="水务局水资源管理系统\r\n版本：1.0\r\n版权所有:唐山现代";

		}
		//软件abort信息
		private bool getSoftAbout(ref string strAbout)
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
				
				strAbout=strSoftName+"\r\n"+strVer;		
		
				frmWaterSys.m_softName=strSoftName;

				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{			
			this.Close();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.m_frm!=null)
				{
					this.m_frm.Close();
				}

				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("Server.xml");
				string strCon=xDoc.DocumentElement.SelectSingleNode("./strCon").InnerText.Trim();
				SqlConnection sCon=new  SqlConnection(strCon); 

				try
				{
						sCon.Open(); 
					BengZhan.CDBConnection.m_strCon=strCon;
				}
				catch(Exception ex)
				{
					MessageBox.Show("连接失败，请测试连接！");
					return ;
				}

				CDBConnection.m_sCon =sCon;

				string strSql=String.Format("select count(*) from tbUsers where userID='{0}' and userPwd='{1}'",this.txtUserName.Text.Trim(),this.txtPwd.Text.Trim());
				sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();
				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;
				sCmd.CommandText=strSql;
				string strCount=sCmd.ExecuteScalar().ToString();
				sCon.Close();
				int iCount=Convert.ToInt32(strCount);
				if(iCount<=0)
				{
					MessageBox.Show("用户ID或密码有误！");
					return;
				}

			
				CDBConnection.m_strUserID=this.txtUserName.Text.Trim();

				strSql=String.Format("select userName from tbUsers where userID='{0}'",CDBConnection.m_strUserID);
				CDBConnection.m_strUserName=CDBConnection.ExecuteScalar(strSql);		
		
				xDoc=new XmlDocument();
				xDoc.Load("Server.xml");

				xDoc.DocumentElement.SelectSingleNode("./load").Attributes.GetNamedItem("name").Value=CDBConnection.m_strUserID;
				xDoc.Save("Server.xml");
				
				if(BengZhan.tools.DBConnection.m_App!=null)
				{
					this.Close();
					return;
				}
				BengZhan.tools.DBConnection.m_App =this;
				this.Hide();
				this.Visible=false;

				
				frmWaterSys frmWaterSysObj=new frmWaterSys();
				frmWaterSysObj.WindowState =System.Windows.Forms.FormWindowState.Maximized;

				frmWaterSysObj.Show();	

				if(xDoc.DocumentElement.SelectSingleNode("./app")==null)
				{
					return;
				}
			
				string strFile=xDoc.DocumentElement.SelectSingleNode("./app").Attributes.GetNamedItem("val").Value.Trim();

				System.Diagnostics.Process p=new System.Diagnostics.Process();
				
				p.StartInfo.WorkingDirectory=strFile;
				p.StartInfo.FileName="bengzhan.exe";
				//Info.WorkingDirectory
				p.Start();
			
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());				
			}  
		}

		private void btnDbCon_Click(object sender, System.EventArgs e)
		{

			BengZhan.database.frmIniDB  frmIniDB=new BengZhan.database.frmIniDB();
			frmIniDB.ShowDialog();


		}

		private void btnHelp_Click(object sender, System.EventArgs e)
		{
			Help.ShowHelp(this,"help.chm");
		}

		private void exXml()
		{
			try
			{				
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load(@"ini\sysIni.xml");

				string strAbort=xDoc.DocumentElement.SelectSingleNode("./abort").InnerXml.Trim();

				xDoc.Load("server.xml");
				xDoc.DocumentElement.SelectSingleNode("./abort").InnerXml=strAbort;
				xDoc.Save("server.xml");

				xDoc.Load("Info.xml");
				xDoc.DocumentElement.SelectSingleNode("./disBackInfo").Attributes.GetNamedItem("val").Value="false";
				xDoc.Save("Info.xml");

				xDoc.Load("PSIC.xml");
				xDoc.DocumentElement.SelectSingleNode("./bDisp").Attributes.GetNamedItem("val").Value="false";
				xDoc.Save("PSIC.xml");
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}            	

		}

		//系统初始
		private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		//	this.button1_Click(null,null);
		}

		private void txtPwd_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(char.IsWhiteSpace(e.KeyChar))
			{
				this.button1_Click(null,null);
			}
		}

		private void txtPwd_TextChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}

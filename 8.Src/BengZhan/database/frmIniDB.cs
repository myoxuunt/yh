using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
using GprsSoft.serverMonitor;

namespace BengZhan.database
{
	/// <summary>
	/// frmIniDB 的摘要说明。
	/// </summary>
	public class frmIniDB : System.Windows.Forms.Form
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Button btnCon;
		private System.Windows.Forms.ComboBox cmbDB;
		private System.Windows.Forms.TextBox txtUserPwd;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtUserID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox chkServ;

		private string m_strCon="";
		private bool m_bMonOpen=false;
	

		public frmIniDB()
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
			this.btnCon = new System.Windows.Forms.Button();
			this.cmbDB = new System.Windows.Forms.ComboBox();
			this.txtUserPwd = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtUserID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.chkServ = new System.Windows.Forms.CheckBox();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCon
			// 
			this.btnCon.Location = new System.Drawing.Point(64, 128);
			this.btnCon.Name = "btnCon";
			this.btnCon.Size = new System.Drawing.Size(64, 23);
			this.btnCon.TabIndex = 6;
			this.btnCon.Text = "测试连接";
			this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
			// 
			// cmbDB
			// 
			this.cmbDB.ItemHeight = 12;
			this.cmbDB.Location = new System.Drawing.Point(112, 16);
			this.cmbDB.Name = "cmbDB";
			this.cmbDB.Size = new System.Drawing.Size(152, 20);
			this.cmbDB.TabIndex = 16;
			// 
			// txtUserPwd
			// 
			this.txtUserPwd.Location = new System.Drawing.Point(112, 80);
			this.txtUserPwd.Name = "txtUserPwd";
			this.txtUserPwd.PasswordChar = '*';
			this.txtUserPwd.Size = new System.Drawing.Size(152, 21);
			this.txtUserPwd.TabIndex = 15;
			this.txtUserPwd.Text = "sa";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 16);
			this.label3.TabIndex = 14;
			this.label3.Text = "用户密码：";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtUserID
			// 
			this.txtUserID.Location = new System.Drawing.Point(112, 48);
			this.txtUserID.Name = "txtUserID";
			this.txtUserID.Size = new System.Drawing.Size(152, 21);
			this.txtUserID.TabIndex = 13;
			this.txtUserID.Text = "sa";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 16);
			this.label2.TabIndex = 12;
			this.label2.Text = "用户ID：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 23);
			this.label1.TabIndex = 11;
			this.label1.Text = "服务器实例名：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmbDB);
			this.groupBox2.Controls.Add(this.txtUserPwd);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.txtUserID);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(8, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(288, 112);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "数据库";
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(216, 128);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(72, 23);
			this.btnExit.TabIndex = 7;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(128, 128);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 23);
			this.button1.TabIndex = 14;
			this.button1.Text = "初始化数据库";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// chkServ
			// 
			this.chkServ.Location = new System.Drawing.Point(8, 128);
			this.chkServ.Name = "chkServ";
			this.chkServ.Size = new System.Drawing.Size(48, 24);
			this.chkServ.TabIndex = 15;
			this.chkServ.Text = "服务";
			this.chkServ.Visible = false;
			this.chkServ.CheckedChanged += new System.EventHandler(this.chkServ_CheckedChanged);
			// 
			// frmIniDB
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(298, 160);
			this.Controls.Add(this.chkServ);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnCon);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmIniDB";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "初始化数据库连接";
			this.Load += new System.EventHandler(this.frmIniDB_Load);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();		
		}

		private void frmIniDB_Load(object sender, System.EventArgs e)
		{
			try
			{
				string strComputerName=System.Net.Dns.GetHostName();
				cmbDB.Items.Add(strComputerName);
				

				strComputerName=String.Format(@"{0}\{1}",strComputerName,"waterSysClient");
				cmbDB.Items.Add(strComputerName);
	
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("Server.xml");

				
				string strServer=xDoc.DocumentElement.SelectSingleNode("./server").InnerText.Trim();
				this.cmbDB.Text=strServer;

				xDoc.Load("Info.xml");
				
				
				string strName=xDoc.DocumentElement.SelectSingleNode("./tcpServer").Attributes.GetNamedItem("name").Value.ToString().Trim();
				this.Height=192;
				this.Width=304;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		
		}

		private void btnCon_Click(object sender, System.EventArgs e)
		{
			try
			{

				if(this.cmbDB.Text.Trim()=="")
				{
					MessageBox.Show("请填写数据库实例名！");
					return;
				}
				if(this.txtUserID.Text.Trim()=="")
				{
					MessageBox.Show("请填写用户名！");
					return;
				}
				string strCon=String.Format("Data Source={0};initial catalog={1};user id={2};password={3}",this.cmbDB.Text.Trim(),"dbBengZhan",this.txtUserID.Text.Trim(),this.txtUserPwd.Text.Trim());
				SqlConnection sCon=new SqlConnection(strCon);
				sCon.Open();	
				sCon.Close();
				this.m_strCon=strCon;
				CDBConnection.m_strCon=strCon;
				MessageBox.Show("连接成功！");		
				this.setCon();
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("Server.xml");
				xDoc.DocumentElement.SelectSingleNode("./SqlCon/Server").InnerText=this.cmbDB.Text.Trim();
				xDoc.DocumentElement.SelectSingleNode("./SqlCon/DataBase").InnerText="dbBengZhan";
				xDoc.DocumentElement.SelectSingleNode("./SqlCon/uid").InnerText=this.txtUserID.Text.Trim();

xDoc.DocumentElement.SelectSingleNode("./SqlCon/pwd").InnerText=this.txtUserPwd.Text.Trim();
				xDoc.Save("Server.xml");

			}
			catch(Exception ex)
			{				
				try
				{
					string strCon=String.Format("Data Source={0};initial catalog={1};user id={2};password={3}",this.cmbDB.Text.Trim(),"master",this.txtUserID.Text.Trim(),this.txtUserPwd.Text.Trim());
					SqlConnection sCon=new SqlConnection(strCon);
					sCon.Open();
					this.m_strCon=strCon;
					MessageBox.Show("服务器上无数据，请进行数据初始化操作！");
					this.setCon();
				}
				catch(Exception exe)
				{
					MessageBox.Show("数据库连接失败！");
				}				
			}
			
		}

		private void btnSet_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.m_strCon==null)
				{
					MessageBox.Show("请先测试连接！");
					return;
				}

				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("Server.xml");

				XmlNode xNode=xDoc.DocumentElement.SelectSingleNode("./strCon");
				xNode.InnerText=this.m_strCon;

				xNode=xDoc.DocumentElement.SelectSingleNode("./server");
				xNode.InnerText=this.cmbDB.Text.Trim();
				xDoc.Save("Server.xml");
				//MessageBox.Show("设置完成！");

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			try
			{
					if(this.m_strCon=="")
					{
						MessageBox.Show("请先测试连接！");
						return;
					}

					SqlConnection sCon=new SqlConnection(this.m_strCon);
				sCon.Open();
				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;
				sCmd.CommandText="use master";
				sCmd.ExecuteNonQuery();
				string strSql=String.Format("select count(*) from sysdatabases where name='{0}'","dbBengZhan");
				sCmd.CommandText=strSql;
				string strCount=sCmd.ExecuteScalar().ToString();
				if(strCount!="0")
				{
					MessageBox.Show("数据库已存在，请先进入系统再进行备份还原！");
					return;
				}

			frmBackRestoreDB frmBackResDB=new frmBackRestoreDB();
			frmBackResDB.m_bIni=true;
				frmBackResDB.m_bRestore=true;
			frmBackResDB.ShowDialog(); 
				sCon.Close();

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		
		}	
		//设置连接
		private void setCon()
		{
			try
			{
				if(this.m_strCon==null)
				{
					MessageBox.Show("请先测试连接！");
					return;
				}

				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("Server.xml");

				XmlNode xNode=xDoc.DocumentElement.SelectSingleNode("./strCon");
				xNode.InnerText=this.m_strCon;

				xNode=xDoc.DocumentElement.SelectSingleNode("./server");
				xNode.InnerText=this.cmbDB.Text.Trim();
				xDoc.Save("Server.xml");

				xDoc.Load("Info.xml");
				xDoc.DocumentElement.SelectSingleNode("./sConStr").InnerText=this.m_strCon;
				xDoc.Save("Info.xml");
				//MessageBox.Show("设置完成！");

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}

		}

		private void btnSetServ_Click(object sender, System.EventArgs e)
		{
			

		}

		private void chkServ_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.chkServ.Checked==true)
			{
				frmSetServices frmSSObj=new frmSetServices();
				frmSSObj.ShowDialog();			
			}
			else
			{				
			}
		}

		
	

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		
		#region"画圆"
		// Draws a circle on the control surface
		protected void DrawCircle(Graphics g)
		{
			
				if(this.m_bMonOpen==true)
				{
					// Create solid brush
					SolidBrush blueBrush = new SolidBrush(Color.Red);

					// Draw Ellipse to screen
					g.FillEllipse( blueBrush, 0, 0, 10, 10 );

					// Now tidy up
					blueBrush.Dispose();
				}
				else
			
				{
					// Create solid brush
					SolidBrush blueBrush = new SolidBrush(Color.Black);

					// Draw Ellipse to screen
					g.FillEllipse( blueBrush, 0, 0, 10, 10 );

					// Now tidy up
					blueBrush.Dispose();

				}

			
		}
		#endregion

		private void imgMon_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			this.DrawCircle(e.Graphics);
		}
	}
}

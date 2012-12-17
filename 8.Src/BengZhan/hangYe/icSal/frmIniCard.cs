using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;
using icSal;
namespace BengZhan.icSal
{
	/// <summary>
	/// frmIniCard 的摘要说明。
	/// </summary>
	public class frmIniCard : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtDepName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtICNo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtWellNo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnIni;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.TextBox txtPwdOld;
		private System.Windows.Forms.TextBox txtPwdNew;

		public string m_WellNo="";
		public string m_DepName="";
		private AxMSCommLib.AxMSComm axMSComm1;		

		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmIniCard()
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
			this.txtDepName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtICNo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtWellNo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnIni = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.txtPwdOld = new System.Windows.Forms.TextBox();
			this.txtPwdNew = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtDepName);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtICNo);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtWellNo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(312, 120);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// txtDepName
			// 
			this.txtDepName.Location = new System.Drawing.Point(120, 56);
			this.txtDepName.Name = "txtDepName";
			this.txtDepName.ReadOnly = true;
			this.txtDepName.Size = new System.Drawing.Size(168, 21);
			this.txtDepName.TabIndex = 5;
			this.txtDepName.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "单位名称：";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtICNo
			// 
			this.txtICNo.Location = new System.Drawing.Point(120, 88);
			this.txtICNo.Name = "txtICNo";
			this.txtICNo.ReadOnly = true;
			this.txtICNo.Size = new System.Drawing.Size(168, 21);
			this.txtICNo.TabIndex = 3;
			this.txtICNo.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "ic卡号：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtWellNo
			// 
			this.txtWellNo.Location = new System.Drawing.Point(120, 24);
			this.txtWellNo.Name = "txtWellNo";
			this.txtWellNo.ReadOnly = true;
			this.txtWellNo.Size = new System.Drawing.Size(168, 21);
			this.txtWellNo.TabIndex = 1;
			this.txtWellNo.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "站编号：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnIni
			// 
			this.btnIni.Location = new System.Drawing.Point(128, 136);
			this.btnIni.Name = "btnIni";
			this.btnIni.TabIndex = 2;
			this.btnIni.Text = "发卡";
			this.btnIni.Click += new System.EventHandler(this.btnIni_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(216, 136);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// txtPwdOld
			// 
			this.txtPwdOld.Location = new System.Drawing.Point(8, 136);
			this.txtPwdOld.Name = "txtPwdOld";
			this.txtPwdOld.Size = new System.Drawing.Size(40, 21);
			this.txtPwdOld.TabIndex = 5;
			this.txtPwdOld.Text = "ff ff ff ff ff ff";
			this.txtPwdOld.Visible = false;
			// 
			// txtPwdNew
			// 
			this.txtPwdNew.Location = new System.Drawing.Point(56, 136);
			this.txtPwdNew.Name = "txtPwdNew";
			this.txtPwdNew.Size = new System.Drawing.Size(40, 21);
			this.txtPwdNew.TabIndex = 6;
			this.txtPwdNew.Text = "10 11 12 13 14 15";
			this.txtPwdNew.Visible = false;
			// 
			// frmIniCard
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(328, 166);
			this.Controls.Add(this.txtPwdNew);
			this.Controls.Add(this.txtPwdOld);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnIni);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmIniCard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "IC卡发放";
			this.Load += new System.EventHandler(this.frmIniCard_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnIni_Click(object sender, System.EventArgs e)
		{
			cIC cicObj=null;			
					
			cicObj=new cIC(this.axMSComm1);
			if(cicObj.openPort()==true)
			{				
				string strCardNo="";
				if(cicObj.iniCard(ref strCardNo)==false)
				{
					MessageBox.Show("发卡失败,失败原因:IC卡未在感应区内或者已对该卡进行发卡操作!");				
				}
				else
				{						
					this.txtICNo.Text=strCardNo;
					MessageBox.Show("发卡完成!");
					this.saveData(this.txtWellNo.Text,this.txtICNo.Text.Trim(),this.txtDepName.Text.Trim());					
				}
				cicObj.closePort();
			}			
		}
		

		private bool saveData(string strWellNo,string strICNo,string strDepName)
		{
			string strSql=String.Format("delete from tbIC where icNo='{0}'",strICNo);
			CDBConnection.ExecuteSql(strSql);
			strSql=String.Format("insert into tbIC(wellNo,icNo,depName) values('{0}','{1}','{2}')",strWellNo,strICNo,strDepName);
			CDBConnection.ExecuteSql(strSql);
			return true;
		}

		private void frmIniCard_Load(object sender, System.EventArgs e)
		{
			try
			{
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("icSys/icSys.xml");

				xDoc.DocumentElement.SelectSingleNode("./sysForm").Attributes.GetNamedItem("val").Value="sendIC";
				xDoc.Save("icSys/icSys.xml");

				NFrmIC.frmIC   frmIC=new NFrmIC.frmIC();
				frmIC.m_strSalerName=BengZhan.CDBConnection.m_strUserName;
				frmIC.m_strWellNo=this.m_WellNo;
				frmIC.ShowDialog();
				this.Close();
				return;

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		
			//以下不用

			this.txtDepName.Text=this.m_DepName;
			this.txtWellNo.Text=this.m_WellNo;
		}
		private bool getPortLv(ref byte iPort,ref short iLv,ref byte iShanQuNo,ref byte iKuaiNo,ref byte iDataKuaiNo)
		{
			try
			{
				XmlDocument xDoc=new   XmlDocument();
				xDoc.Load("IC.xml");

				string strPort=xDoc.DocumentElement.SelectSingleNode("./iPort").Attributes.GetNamedItem("val").Value.ToString().Trim();
				string strLv=xDoc.DocumentElement.SelectSingleNode("./iLv").Attributes.GetNamedItem("val").Value.ToString().Trim();
				string strIShanQuNo=xDoc.DocumentElement.SelectSingleNode("./iShanQuNo").Attributes.GetNamedItem("val").Value.ToString().Trim();
				string strIKuaiNo=xDoc.DocumentElement.SelectSingleNode("./iKuaiNo").Attributes.GetNamedItem("val").Value.ToString().Trim();
				string strIDataKuaiNo=xDoc.DocumentElement.SelectSingleNode("./iDataKuaiNo").Attributes.GetNamedItem("val").Value.ToString().Trim();

				iPort=Convert.ToByte(strPort);
				iLv=Convert.ToInt16(strLv);
				iShanQuNo=Convert.ToByte(strIShanQuNo);
				iKuaiNo=Convert.ToByte(strIKuaiNo);
				iDataKuaiNo=Convert.ToByte(strIDataKuaiNo);

				int iKuaiNoEx=iShanQuNo*4+iKuaiNo;
				int iDataKuaiNoEx=iShanQuNo*4+iDataKuaiNo;

				iKuaiNo=Convert.ToByte(iKuaiNoEx);
				iDataKuaiNo=Convert.ToByte(iDataKuaiNoEx);

				return true;

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}			
		}
		private bool writeZeroAmount()
		{
			try
			{
				

				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}			
			
		}
		private string getPwdA()
		{			
			string strPwd;
			strPwd=this.txtPwdOld.Text.Trim();
			strPwd=strPwd.Replace(" ","");
			if(strPwd.Length!=12)
			{
				MessageBox.Show("密码长度有误");
				return "";
			}
			return strPwd;
		}
		private string getPwdB()
		{
			string strPwd;
			strPwd=this.txtPwdNew.Text.Trim();
			strPwd=strPwd.Replace(" ","");
			if(strPwd.Length!=12)
			{
				MessageBox.Show("密码长度有误");
				return "";
			}
			return strPwd;
		}		
	}
}

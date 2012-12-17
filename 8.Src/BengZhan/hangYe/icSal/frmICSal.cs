using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Xml;
using icSal;

namespace BengZhan.icSal
{
	/// <summary>
	/// frmICSal 的摘要说明。
	/// </summary>
	public class frmICSal : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnRead;
		private System.Windows.Forms.Button btnWrite;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnBrush;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtWellNo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtICNo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDepName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtMony;
		private System.Windows.Forms.TextBox txtAmount;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		private double m_dPrice=0;
		private double m_dSalMony=0;
		
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtLeftAmount;
		private AxMSCommLib.AxMSComm axMSComm1;
		private AxMSCommLib.AxMSComm axMSComm2;
	
		
		private double m_dAmount=0;



		public frmICSal()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmICSal));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtDepName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtICNo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtWellNo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnRead = new System.Windows.Forms.Button();
			this.btnWrite = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnBrush = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtLeftAmount = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtMony = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.axMSComm2 = new AxMSCommLib.AxMSComm();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axMSComm2)).BeginInit();
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
			this.groupBox1.Location = new System.Drawing.Point(8, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(312, 120);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// txtDepName
			// 
			this.txtDepName.Location = new System.Drawing.Point(120, 88);
			this.txtDepName.Name = "txtDepName";
			this.txtDepName.ReadOnly = true;
			this.txtDepName.Size = new System.Drawing.Size(168, 21);
			this.txtDepName.TabIndex = 5;
			this.txtDepName.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "单位名称：";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtICNo
			// 
			this.txtICNo.Location = new System.Drawing.Point(120, 24);
			this.txtICNo.Name = "txtICNo";
			this.txtICNo.ReadOnly = true;
			this.txtICNo.Size = new System.Drawing.Size(168, 21);
			this.txtICNo.TabIndex = 3;
			this.txtICNo.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "ic卡号：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtWellNo
			// 
			this.txtWellNo.Location = new System.Drawing.Point(120, 56);
			this.txtWellNo.Name = "txtWellNo";
			this.txtWellNo.ReadOnly = true;
			this.txtWellNo.Size = new System.Drawing.Size(168, 21);
			this.txtWellNo.TabIndex = 1;
			this.txtWellNo.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "站编号：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnRead
			// 
			this.btnRead.Location = new System.Drawing.Point(8, 288);
			this.btnRead.Name = "btnRead";
			this.btnRead.TabIndex = 1;
			this.btnRead.Text = "读卡";
			this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
			// 
			// btnWrite
			// 
			this.btnWrite.Location = new System.Drawing.Point(88, 288);
			this.btnWrite.Name = "btnWrite";
			this.btnWrite.TabIndex = 2;
			this.btnWrite.Text = "充值";
			this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(248, 288);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnBrush
			// 
			this.btnBrush.Enabled = false;
			this.btnBrush.Location = new System.Drawing.Point(168, 288);
			this.btnBrush.Name = "btnBrush";
			this.btnBrush.TabIndex = 4;
			this.btnBrush.Text = "减值";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtLeftAmount);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.txtPrice);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txtMony);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txtAmount);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(8, 128);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(312, 152);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			// 
			// txtLeftAmount
			// 
			this.txtLeftAmount.Location = new System.Drawing.Point(120, 120);
			this.txtLeftAmount.Name = "txtLeftAmount";
			this.txtLeftAmount.ReadOnly = true;
			this.txtLeftAmount.Size = new System.Drawing.Size(176, 21);
			this.txtLeftAmount.TabIndex = 7;
			this.txtLeftAmount.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 120);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "卡中水量：";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(120, 56);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(176, 21);
			this.txtPrice.TabIndex = 5;
			this.txtPrice.Text = "";
			this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(96, 24);
			this.label6.TabIndex = 4;
			this.label6.Text = "售水单价：";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtMony
			// 
			this.txtMony.Location = new System.Drawing.Point(120, 24);
			this.txtMony.Name = "txtMony";
			this.txtMony.Size = new System.Drawing.Size(176, 21);
			this.txtMony.TabIndex = 3;
			this.txtMony.Text = "";
			this.txtMony.TextChanged += new System.EventHandler(this.txtMony_TextChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 16);
			this.label5.TabIndex = 2;
			this.label5.Text = "售水金额：";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtAmount
			// 
			this.txtAmount.Location = new System.Drawing.Point(120, 88);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.ReadOnly = true;
			this.txtAmount.Size = new System.Drawing.Size(176, 21);
			this.txtAmount.TabIndex = 1;
			this.txtAmount.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "售水量：";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// axMSComm2
			// 
			this.axMSComm2.Enabled = true;
			this.axMSComm2.Location = new System.Drawing.Point(312, 120);
			this.axMSComm2.Name = "axMSComm2";
			this.axMSComm2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMSComm2.OcxState")));
			this.axMSComm2.Size = new System.Drawing.Size(38, 38);
			this.axMSComm2.TabIndex = 6;
			// 
			// frmICSal
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(330, 320);
			this.Controls.Add(this.axMSComm2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnBrush);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnWrite);
			this.Controls.Add(this.btnRead);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmICSal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "IC卡售水";
			this.Load += new System.EventHandler(this.frmICSal_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axMSComm2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnRead_Click(object sender, System.EventArgs e)
		{
			try
			{
				cIC cicObj=new cIC(this.axMSComm1);
				if(cicObj.openPort()==true)
				{
					string strCardNo="";
					string strSal="";
					if(cicObj.readCard(ref strCardNo,ref strSal)==false)
					{
						MessageBox.Show("读卡失败,失败原因:IC卡未在感应区内或者未对该卡进行发卡操作!");
					}
					else
					{
						this.txtICNo.Text=strCardNo;
						this.txtLeftAmount.Text=strSal;
					}
					cicObj.closePort();
				}				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}	
			
			string strWellNo="";
			string strDepName="";
			this.getDepName(this.txtICNo.Text,ref strWellNo,ref strDepName);
			this.txtWellNo.Text=strWellNo;
			this.txtDepName.Text=strDepName;

		}
		

		private void txtPrice_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(this.txtPrice.Text.Trim()=="")
				{
					this.m_dPrice=0;
					return;
				}
				this.m_dPrice =Convert.ToDouble(txtPrice.Text.Trim());
				if(this.m_dPrice!=0&&this.m_dSalMony!=0)
				{
					double dAmount=this.m_dSalMony/this.m_dPrice;
					dAmount=Math.Round(dAmount,0);
					this.txtAmount.Text =dAmount.ToString();
				}
			}
			catch(Exception ex)
			{
				this.m_dPrice=0;
				return;
			}
		}

		private void txtMony_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(this.txtMony.Text.Trim()=="")
				{
					this.m_dSalMony=0;	
					this.txtAmount.Text="0";					
					return;
				}
				else
				{
					this.m_dSalMony=Convert.ToDouble(this.txtMony.Text.Trim());
					
					if(this.m_dPrice!=0&&this.m_dSalMony!=0)
					{
						double dAmount=this.m_dSalMony/this.m_dPrice;
						dAmount=Math.Round(dAmount,0);
						this.txtAmount.Text =dAmount.ToString();
					}				
				}
				
			}
			catch(Exception ex)
			{
				this.m_dSalMony=0;	
				this.txtAmount.Text="0";				
				return;
			}
		}

		private void btnWrite_Click(object sender, System.EventArgs e)
		{
			if(this.txtICNo.Text.Trim()=="")
			{
				MessageBox.Show("请先进行读卡操作!");
				return;
			}
			if(this.txtDepName.Text.Trim()=="")
			{
				MessageBox.Show("请先对该卡进行发卡操作！");
				return;
			}
			if(this.txtLeftAmount.Text.Trim()=="")
			{
				MessageBox.Show("请先进行读卡操作!");
				return;
			}

			if(this.txtAmount.Text.Trim()=="")
			{
				MessageBox.Show("售水量不能为空！");
				return;
			}
			
			double dVal=Convert.ToDouble(this.txtAmount.Text);	
			double dMax=0xffffffff;
			if(dVal>dMax)
			{
				MessageBox.Show("售水量值过大！");
				return;
			}

			try
			{
				if(this.txtAmount.Text.Trim()=="")
				{
					MessageBox.Show("售水量不能为空!");
					return;
				}

				Double dSal=Convert.ToDouble(this.txtAmount.Text.Trim());

				cIC cicObj=new cIC(this.axMSComm1);
				if(cicObj.openPort()==true)
				{				
					string strSal="";
					if(cicObj.salWater(dSal.ToString(),ref strSal)==false)
					{
						MessageBox.Show("充值失败!");
					}
					else
					{						
						this.txtLeftAmount.Text=strSal;
						MessageBox.Show("充值完成！");
						if(this.SaveDatas()==false)
						{
							MessageBox.Show("保存售水信息时失败！");
						}
					}
					cicObj.closePort();
				}				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}            
		}
		private void getDepName(string strICNo,ref string strWellNo,ref string strDepName)
		{
			string strSql=String.Format("select wellNo,depName from tbIC where icNo='{0}'",strICNo);
			DataTable dt=null;
			CDBConnection.getDataTable(ref dt,strSql,"dtIC");
			if(dt==null)
			{
				return;
			}
			if(dt.Rows.Count<=0)
			{
				return;
			}
			strWellNo=dt.Rows[0]["wellNo"].ToString();
			strDepName=dt.Rows[0]["depName"].ToString();
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
		private bool SaveDatas()
		{
			try
			{
				string strPrice=this.txtPrice.Text.Trim();
				string strMony=this.txtMony.Text.Trim();
				string strAmount=this.txtAmount.Text.Trim();
				
				string strPer=CDBConnection.m_strUserName;
				string strTime=System.DateTime.Now.ToString();

				string strWellNo=this.txtWellNo.Text.Trim();
                
				string strSql=String.Format("insert into tbSal(wellNo,price,salMony,salAmount,time,salPer) values('{0}','{1}','{2}','{3}','{4}','{5}')",strWellNo,strPrice,strMony,strAmount,strTime,strPer);
				CDBConnection.ExecuteSql(strSql);

				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}

		private void frmICSal_Load(object sender, System.EventArgs e)
		{
		
		}

	}
}

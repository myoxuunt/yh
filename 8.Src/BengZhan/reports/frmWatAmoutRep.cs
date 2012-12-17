using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace BengZhan.reports
{
	/// <summary>
	/// frmWatAmoutRep 的摘要说明。
	/// </summary>
	public class frmWatAmoutRep : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox grp1;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crpvWater;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dtpFrom;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.Button btnDis;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnStastic;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbCountry;
		private System.Windows.Forms.TreeView trvWel;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmWatAmoutRep()
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
			this.grp1 = new System.Windows.Forms.GroupBox();
			this.trvWel = new System.Windows.Forms.TreeView();
			this.crpvWater = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnStastic = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnDis = new System.Windows.Forms.Button();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmbCountry = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.grp1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// grp1
			// 
			this.grp1.Controls.Add(this.trvWel);
			this.grp1.Location = new System.Drawing.Point(8, 56);
			this.grp1.Name = "grp1";
			this.grp1.Size = new System.Drawing.Size(240, 456);
			this.grp1.TabIndex = 0;
			this.grp1.TabStop = false;
			// 
			// trvWel
			// 
			this.trvWel.ImageIndex = -1;
			this.trvWel.Location = new System.Drawing.Point(8, 16);
			this.trvWel.Name = "trvWel";
			this.trvWel.SelectedImageIndex = -1;
			this.trvWel.Size = new System.Drawing.Size(224, 432);
			this.trvWel.TabIndex = 0;
			this.trvWel.Click += new System.EventHandler(this.trvWel_Click);
			this.trvWel.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvWel_AfterSelect);
			// 
			// crpvWater
			// 
			this.crpvWater.ActiveViewIndex = -1;
			this.crpvWater.Location = new System.Drawing.Point(264, 64);
			this.crpvWater.Name = "crpvWater";
			this.crpvWater.ReportSource = null;
			this.crpvWater.ShowExportButton = false;
			this.crpvWater.Size = new System.Drawing.Size(472, 456);
			this.crpvWater.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnStastic);
			this.groupBox1.Controls.Add(this.btnExit);
			this.groupBox1.Controls.Add(this.btnDis);
			this.groupBox1.Controls.Add(this.dtpTo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.dtpFrom);
			this.groupBox1.Location = new System.Drawing.Point(256, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(552, 48);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// btnStastic
			// 
			this.btnStastic.Location = new System.Drawing.Point(384, 16);
			this.btnStastic.Name = "btnStastic";
			this.btnStastic.Size = new System.Drawing.Size(88, 23);
			this.btnStastic.TabIndex = 5;
			this.btnStastic.Text = "日统计";
			this.btnStastic.Click += new System.EventHandler(this.btnStastic_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(472, 16);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnDis
			// 
			this.btnDis.Location = new System.Drawing.Point(296, 15);
			this.btnDis.Name = "btnDis";
			this.btnDis.Size = new System.Drawing.Size(88, 23);
			this.btnDis.TabIndex = 3;
			this.btnDis.Text = "明细显示";
			this.btnDis.Click += new System.EventHandler(this.btnDis_Click);
			// 
			// dtpTo
			// 
			this.dtpTo.Location = new System.Drawing.Point(176, 16);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(112, 21);
			this.dtpTo.TabIndex = 2;
			this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(128, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "至：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpFrom
			// 
			this.dtpFrom.Location = new System.Drawing.Point(8, 16);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.Size = new System.Drawing.Size(112, 21);
			this.dtpFrom.TabIndex = 0;
			this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmbCountry);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(8, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(240, 48);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			// 
			// cmbCountry
			// 
			this.cmbCountry.Location = new System.Drawing.Point(88, 16);
			this.cmbCountry.Name = "cmbCountry";
			this.cmbCountry.Size = new System.Drawing.Size(136, 20);
			this.cmbCountry.TabIndex = 1;
			this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "所属乡镇：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// frmWatAmoutRep
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(832, 534);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.crpvWater);
			this.Controls.Add(this.grp1);
			this.Name = "frmWatAmoutRep";
			this.Resize += new System.EventHandler(this.frmWatAmoutRep_Resize);
			this.Load += new System.EventHandler(this.frmWatAmoutRep_Load);
			this.grp1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmWatAmoutRep_Load(object sender, System.EventArgs e)
		{
			try
			{
				
				this.dtpTo.Value=this.dtpFrom.Value.AddDays(1);
				//CDBConnection.refreshHis();
				this.paintFrmSize();
				tools.CPaintForm.paintCountry(this.cmbCountry);	
				tools.CPaintForm.paintWell(this.cmbCountry.Text,this.trvWel);	
				this.paintReport();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		//填充窗体控件
		private void paintFrmSize()
		{
			try
			{
				this.grp1.Height=this.Height-this.grp1.Top-40;
				this.trvWel.Height=this.grp1.Height-25;
				this.crpvWater.Width=this.Width-this.crpvWater.Left-20;
				this.crpvWater.Height=this.Height-this.crpvWater.Top-40;
				this.crpvWater.DisplayGroupTree=false;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}

		}

		private void frmWatAmoutRep_Resize(object sender, System.EventArgs e)
		{		
			this.paintFrmSize();			
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		// 报表显示
		private void paintReport()
		{
			try
			{
				if(this.trvWel.SelectedNode==null)
				{
					//未选择监测站
					this.paintReport("");
					return;
				}
				string strNText=this.trvWel.SelectedNode.Text;
				if(strNText.IndexOf("|")>0)
				{
					string strWellNo=strNText.Substring(0,strNText.IndexOf("|"));
					string strWellName=strNText.Substring(0,strNText.IndexOf("|")+1);
					this.paintReport(strWellNo);
				}
				else
				{
					//未选择监测站
					this.paintReport("");
				}				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		
		private void btnDis_Click(object sender, System.EventArgs e)
		{
			this.paintReport();
		}
		
		private void trvWel_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			//this.paintReport();
		}

		private void trvWel_Click(object sender, System.EventArgs e)
		{
			//this.paintReport();		
		}

		private void dtpFrom_ValueChanged(object sender, System.EventArgs e)
		{
			//this.paintReport();
		}

		private void dtpTo_ValueChanged(object sender, System.EventArgs e)
		{
			//this.paintReport();
		}

		#region "报表显示"
		private void paintReport(string strWellNo)
		{
			//已审
			try
			{
				string strFrom=String.Format("{0}-{1}-{2}",this.dtpFrom.Value.Year.ToString(),this.dtpFrom.Value.Month.ToString(),this.dtpFrom.Value.Day.ToString());
				string strTo=String.Format("{0}-{1}-{2}",this.dtpTo.Value.Year.ToString(),this.dtpTo.Value.Month.ToString(),this.dtpTo.Value.Day.ToString());

				string strTitle=String.Format("时间范围：{0}至{1}",strFrom,strTo);

				string[] strText=new string[7];
				strText[0]="监测站编号";
				strText[1]="单位名称";
				strText[2]="已用水量";
				strText[3]="剩余水量";
				strText[4]="总水量";
				strText[5]="流量";
				strText[6]="上报时间";

				printDoc.crpPrint crpPrintObj=new BengZhan.printDoc.crpPrint();
				CrystalDecisions.CrystalReports.Engine.TextObject toTitle=(CrystalDecisions.CrystalReports.Engine.TextObject)crpPrintObj.ReportDefinition.ReportObjects["txtTime"];
				toTitle.Text=strTitle;
				for(int i=0;i<7;i++)
				{
					int iNum=i+1;
					string strTextTitle="Text"+iNum.ToString();
					CrystalDecisions.CrystalReports.Engine.TextObject to=(CrystalDecisions.CrystalReports.Engine.TextObject)crpPrintObj.ReportDefinition.ReportObjects[strTextTitle];					
					to.Text=strText[i].ToString();
				}	
					
				//*************************************************Sql查询部分***************
				//wellNo不为空
				string strSql=String.Format("select wellNo as Field1,depName as Field2,usedWaterAmount as Field3,leftWaterAmount as Field4,allWaterAmount as Field5,flowWaterAmount as Field6,time as Field7 from tbWellAmount where (cast(floor(cast(time as float)) as datetime) between '{0}' and '{1}') and wellNo='{2}' order by time",strFrom,strTo,strWellNo);				
				if(strWellNo.Trim()=="")
				{
					//wellNo为空
					strSql=String.Format("select wellNo as Field1,depName as Field2,usedWaterAmount as Field3,leftWaterAmount as Field4,allWaterAmount as Field5,flowWaterAmount as Field6,time as Field7 from tbWellAmount where (cast(floor(cast(time as float)) as datetime) between '{0}' and '{1}')  order by time",strFrom,strTo);
				}
				//****************************************************************************

				
				DataTable dt=null;
				CDBConnection.getDataTable(ref dt,strSql,"tbWellAmount");
				
				crpPrintObj.SetDataSource(dt);
				this.crpvWater.ReportSource=crpPrintObj;


			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		/// <summary>
		/// 日统计
		/// </summary>
		/// <param name="strWellNo"></param>
		private void paintDayStatic(string strWellNo)
		{
			//已审
			try
			{
				string strFrom=String.Format("{0}-{1}-{2}",this.dtpFrom.Value.Year.ToString(),this.dtpFrom.Value.Month.ToString(),this.dtpFrom.Value.Day.ToString());
				string strTo=String.Format("{0}-{1}-{2}",this.dtpTo.Value.Year.ToString(),this.dtpTo.Value.Month.ToString(),this.dtpTo.Value.Day.ToString());

				string strTitle=String.Format("时间范围：{0}至{1}",strFrom,strTo);

				string[] strText=new string[7];
				strText[0]="监测站编号";
				strText[1]="单位名称";
				strText[2]="已用水量";
				strText[3]="剩余水量";
				strText[4]="总水量";
				strText[5]="流量";
				strText[6]="上报时间";

				printDoc.crpPrint crpPrintObj=new BengZhan.printDoc.crpPrint();
				CrystalDecisions.CrystalReports.Engine.TextObject toTitle=(CrystalDecisions.CrystalReports.Engine.TextObject)crpPrintObj.ReportDefinition.ReportObjects["txtTime"];
				toTitle.Text=strTitle;
				for(int i=0;i<7;i++)
				{
					int iNum=i+1;
					string strTextTitle="Text"+iNum.ToString();
					CrystalDecisions.CrystalReports.Engine.TextObject to=(CrystalDecisions.CrystalReports.Engine.TextObject)crpPrintObj.ReportDefinition.ReportObjects[strTextTitle];					
					to.Text=strText[i].ToString();
				}	

				DataTable dt=new DataTable();				
				dt=this.getStaticDt(strWellNo,strFrom,strTo);

				crpPrintObj.SetDataSource(dt);
				this.crpvWater.ReportSource=crpPrintObj;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		private DataTable getStaticDt(string strWellNo,string strStartTime,string strEndTime)
		{
			try
			{
				
				DataTable dt=new DataTable();

				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=CDBConnection.m_sCon;
				sCmd.CommandText="pAmountReport";
				sCmd.CommandType=CommandType.StoredProcedure;
				sCmd.Parameters.Add("@strWellNo",SqlDbType.NVarChar,20).Value=strWellNo;
				sCmd.Parameters.Add("@strStartTime",SqlDbType.NVarChar,20).Value=strStartTime;
				sCmd.Parameters.Add("@strEndTime",SqlDbType.NVarChar,20).Value=strEndTime;

				DataSet ds=new DataSet();
				SqlDataAdapter sda=new SqlDataAdapter();
				sda.SelectCommand=sCmd;
				sda.Fill(ds,"report");
				dt=ds.Tables["report"];
				
				return dt;				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return null;
			}
		}


		#endregion

		private void btnStastic_Click(object sender, System.EventArgs e)
		{	
			try
			{
				if(this.trvWel.SelectedNode!=null)
				{
					//未选择监测站
					this.paintDayStatic("");
					return;
				}
				string strNText=this.trvWel.SelectedNode.Text;
				if(strNText.IndexOf("|")>0)
				{
					string strWellNo=strNText.Substring(0,strNText.IndexOf("|"));
					string strWellName=strNText.Substring(0,strNText.IndexOf("|")+1);
					this.paintDayStatic(strWellNo);
				}
				else
				{
					//未选择监测站
					this.paintDayStatic("");
				}				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void cmbCountry_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			tools.CPaintForm.paintWell(this.cmbCountry.Text,this.trvWel);
		}	
	}
}

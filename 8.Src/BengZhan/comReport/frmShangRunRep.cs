using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BengZhan;
using CrystalDecisions.Windows.Forms;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace BengZhan.comReport
{
	/// <summary>
	/// frmShangRunRep 的摘要说明。
	/// </summary>
	public class frmShangRunRep : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cmbCountry;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox grp1;
		private System.Windows.Forms.TreeView trvWel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnStastic;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnDis;
		private System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpFrom;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crpvWater;

		public SqlConnection m_sCon;
		private System.Windows.Forms.NumericUpDown numStart;
		private System.Windows.Forms.NumericUpDown numEnd;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Button btnExport;

		
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmShangRunRep()
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmbCountry = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.grp1 = new System.Windows.Forms.GroupBox();
			this.trvWel = new System.Windows.Forms.TreeView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.numEnd = new System.Windows.Forms.NumericUpDown();
			this.numStart = new System.Windows.Forms.NumericUpDown();
			this.btnStastic = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnDis = new System.Windows.Forms.Button();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.crpvWater = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnExport = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			this.grp1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numEnd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numStart)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmbCountry);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(8, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(224, 40);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			// 
			// cmbCountry
			// 
			this.cmbCountry.Location = new System.Drawing.Point(88, 16);
			this.cmbCountry.Name = "cmbCountry";
			this.cmbCountry.Size = new System.Drawing.Size(128, 20);
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
			// grp1
			// 
			this.grp1.Controls.Add(this.trvWel);
			this.grp1.Location = new System.Drawing.Point(8, 56);
			this.grp1.Name = "grp1";
			this.grp1.Size = new System.Drawing.Size(224, 480);
			this.grp1.TabIndex = 4;
			this.grp1.TabStop = false;
			// 
			// trvWel
			// 
			this.trvWel.ImageIndex = -1;
			this.trvWel.Location = new System.Drawing.Point(8, 16);
			this.trvWel.Name = "trvWel";
			this.trvWel.SelectedImageIndex = -1;
			this.trvWel.Size = new System.Drawing.Size(208, 456);
			this.trvWel.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnExport);
			this.groupBox1.Controls.Add(this.btnPrint);
			this.groupBox1.Controls.Add(this.numEnd);
			this.groupBox1.Controls.Add(this.numStart);
			this.groupBox1.Controls.Add(this.btnStastic);
			this.groupBox1.Controls.Add(this.btnExit);
			this.groupBox1.Controls.Add(this.btnDis);
			this.groupBox1.Controls.Add(this.dtpTo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.dtpFrom);
			this.groupBox1.Location = new System.Drawing.Point(240, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(672, 48);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			// 
			// numEnd
			// 
			this.numEnd.Location = new System.Drawing.Point(296, 16);
			this.numEnd.Maximum = new System.Decimal(new int[] {
																   23,
																   0,
																   0,
																   0});
			this.numEnd.Name = "numEnd";
			this.numEnd.Size = new System.Drawing.Size(32, 21);
			this.numEnd.TabIndex = 7;
			this.numEnd.Value = new System.Decimal(new int[] {
																 8,
																 0,
																 0,
																 0});
			// 
			// numStart
			// 
			this.numStart.Location = new System.Drawing.Point(120, 16);
			this.numStart.Maximum = new System.Decimal(new int[] {
																	 23,
																	 0,
																	 0,
																	 0});
			this.numStart.Name = "numStart";
			this.numStart.Size = new System.Drawing.Size(32, 21);
			this.numStart.TabIndex = 6;
			this.numStart.Value = new System.Decimal(new int[] {
																   8,
																   0,
																   0,
																   0});
			// 
			// btnStastic
			// 
			this.btnStastic.Location = new System.Drawing.Point(400, 15);
			this.btnStastic.Name = "btnStastic";
			this.btnStastic.Size = new System.Drawing.Size(64, 23);
			this.btnStastic.TabIndex = 5;
			this.btnStastic.Text = "日统计值显示";
			this.btnStastic.Click += new System.EventHandler(this.btnStastic_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(584, 15);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(64, 23);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnDis
			// 
			this.btnDis.Location = new System.Drawing.Point(336, 15);
			this.btnDis.Name = "btnDis";
			this.btnDis.Size = new System.Drawing.Size(64, 23);
			this.btnDis.TabIndex = 3;
			this.btnDis.Text = "明细显示";
			this.btnDis.Click += new System.EventHandler(this.btnDis_Click);
			// 
			// dtpTo
			// 
			this.dtpTo.Location = new System.Drawing.Point(184, 16);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(112, 21);
			this.dtpTo.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(152, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 23);
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
			// 
			// crpvWater
			// 
			this.crpvWater.ActiveViewIndex = -1;
			this.crpvWater.Location = new System.Drawing.Point(248, 64);
			this.crpvWater.Name = "crpvWater";
			this.crpvWater.ReportSource = null;
			this.crpvWater.ShowExportButton = false;
			this.crpvWater.Size = new System.Drawing.Size(496, 472);
			this.crpvWater.TabIndex = 5;
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(464, 15);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(56, 23);
			this.btnPrint.TabIndex = 8;
			this.btnPrint.Text = "打印";
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// btnExport
			// 
			this.btnExport.Location = new System.Drawing.Point(520, 15);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(64, 23);
			this.btnExport.TabIndex = 9;
			this.btnExport.Text = "导出";
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// frmShangRunRep
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(936, 557);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.grp1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.crpvWater);
			this.Name = "frmShangRunRep";
			this.Text = "报表";
			this.Load += new System.EventHandler(this.frmShangRunRep_Load);
			this.groupBox2.ResumeLayout(false);
			this.grp1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numEnd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numStart)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmShangRunRep_Load(object sender, System.EventArgs e)
		{
	
			this.dtpTo.Value=this.dtpFrom.Value.AddDays(1);			
			this.paintFrmSize();

			openCon();
			CDBConnection.m_sCon=this.m_sCon;

			BengZhan.tools.CPaintForm.paintCountry(this.cmbCountry);
			BengZhan.tools.CPaintForm.paintWell(this.cmbCountry.Text,this.trvWel);

			this.paintRep("001");

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

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}


		//temp del
		private void openCon()
		{
			try
			{

				if(this.m_sCon==null)
				{
					string strCon=@"server=.\watersysclient;uid=sa;pwd=sa;database=dbbengzhan";

					SqlConnection sCon=new SqlConnection(strCon);

					sCon.Open();

					this.m_sCon=sCon;

				}

			}
			catch(Exception e)
			{
				MessageBox.Show(e.ToString());
			}
			



		}

		private void cmbCountry_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			BengZhan.tools.CPaintForm.paintWell(this.cmbCountry.Text,this.trvWel);
		}

		private void btnDis_Click(object sender, System.EventArgs e)
		{

			try
			{
				string strFrom=this.dtpFrom.Value.ToShortDateString();
				strFrom=strFrom+" "+this.numStart.Value.ToString().Trim()+":00:00";
				string strTo=this.dtpTo.Value.ToShortDateString();
				strTo=strTo+" "+this.numEnd.Value.ToString().Trim()+":00:00";

				if(this.trvWel.SelectedNode==null)
				{
					MessageBox.Show("请选中一个站点!");
					return;
				}

				string strZhanInfo=this.trvWel.SelectedNode.Text.Trim();

				if(strZhanInfo.IndexOf("|")<0)
				{
					MessageBox.Show("请选中一个站点!");
					return;
				}

				string strZhanNo=strZhanInfo.Substring(0,strZhanInfo.IndexOf("|"));

				DataTable dt=new DataTable();

				if(comReport.CReports.getDtDetailReport(strZhanNo,strFrom,strTo,ref dt)==false)
				{
					return;
				}

                Hashtable ht=new Hashtable();

				if(comReport.CReports.getHtTitles("colNames.xml",ref ht)==false)
				{
					return;
				}     				
				

				BengZhan.comReport._9.crp9 crp=new BengZhan.comReport._9.crp9();
				DataTable dtDetail=new DataTable();

				if(comReport.CReports.getDtDetailReport(strZhanNo,strFrom,strTo,ref dtDetail)==false)
				{
					return;
				}

				string strTime=String.Format("{0}至{1}",strFrom,strTo);

				

				comReport.CReports.showReport(this.crpvWater,dtDetail,ht,crp,"供热明细表",strTime);				

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}

		}
		private void paintRep(string strZhanNo)
		{
			try
			{
				string strFrom=this.dtpFrom.Value.ToShortDateString();
				strFrom=strFrom+" "+this.numStart.Value.ToString().Trim()+":00:00";
				string strTo=this.dtpTo.Value.ToShortDateString();
				strTo=strTo+" "+this.numEnd.Value.ToString().Trim()+":00:00";	

				DataTable dt=new DataTable();

				if(comReport.CReports.getDtDetailReport(strZhanNo,strFrom,strTo,ref dt)==false)
				{
					return;
				}

				Hashtable ht=new Hashtable();

				if(comReport.CReports.getHtTitles("colNames.xml",ref ht)==false)
				{
					return;
				}     				
				

				BengZhan.comReport._9.crp9 crp=new BengZhan.comReport._9.crp9();
				DataTable dtDetail=new DataTable();

				if(comReport.CReports.getDtDetailReport(strZhanNo,strFrom,strTo,ref dtDetail)==false)
				{
					return;
				}

				string strTime=String.Format("{0}至{1}",strFrom,strTo);

				comReport.CReports.showReport(this.crpvWater,dtDetail,ht,crp,"供热明细表",strTime);				

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}


		}

		private void btnStastic_Click(object sender, System.EventArgs e)
		{
			try
			{

				string strFrom=this.dtpFrom.Value.ToShortDateString();
				string strTo=this.dtpTo.Value.ToShortDateString();

				if(this.trvWel.SelectedNode==null)
				{
					MessageBox.Show("请选中一个站点!");
					return;
				}

				string strZhanInfo=this.trvWel.SelectedNode.Text.Trim();

				if(strZhanInfo.IndexOf("|")<0)
				{
					MessageBox.Show("请选中一个站点!");
					return;
				}

				string strZhanNo=strZhanInfo.Substring(0,strZhanInfo.IndexOf("|"));

				DataTable dt=new DataTable();

				if(comReport.CReports.getDtDetailReport(strZhanNo,strFrom,strTo,ref dt)==false)
				{
					return;
				}

				Hashtable ht=new Hashtable();

				if(comReport.CReports.getHtTitles("colNames.xml",ref ht)==false)
				{
					return;
				}     				
				

				BengZhan.comReport._9.crp9 crp=new BengZhan.comReport._9.crp9();
				DataTable dtAvg=new DataTable();

				if(comReport.CReports.getDtAvgReport(strZhanNo,strFrom,strTo,ref dtAvg)==false)
				{
					return;
				}

				string strTime=String.Format("{0}至{1}",strFrom,strTo);

				comReport.CReports.showReport(this.crpvWater,dtAvg,ht,crp,"供热日平均值表",strTime);				

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnPrint_Click(object sender, System.EventArgs e)
		{
			this.crpvWater.PrintReport();
		}

		private void btnExport_Click(object sender, System.EventArgs e)
		{
			this.crpvWater.ExportReport();
		}

		

		#region"明细显示"


		#endregion


	}
}

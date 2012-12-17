using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace BengZhan.warn
{
	/// <summary>
	/// frmWarnRep 的摘要说明。
	/// </summary>
	public class frmWarnRep : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox grp1;
		private System.Windows.Forms.TreeView trvWel;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cmbCountry;
		private System.Windows.Forms.Label label2;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crpvWater;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnDis;
		private System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpFrom;
		private System.Windows.Forms.NumericUpDown numStart;
		private System.Windows.Forms.NumericUpDown numEnd;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmWarnRep()
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmbCountry = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.crpvWater = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnDis = new System.Windows.Forms.Button();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.numStart = new System.Windows.Forms.NumericUpDown();
			this.numEnd = new System.Windows.Forms.NumericUpDown();
			this.grp1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numStart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numEnd)).BeginInit();
			this.SuspendLayout();
			// 
			// grp1
			// 
			this.grp1.Controls.Add(this.trvWel);
			this.grp1.Location = new System.Drawing.Point(16, 56);
			this.grp1.Name = "grp1";
			this.grp1.Size = new System.Drawing.Size(240, 480);
			this.grp1.TabIndex = 8;
			this.grp1.TabStop = false;
			// 
			// trvWel
			// 
			this.trvWel.ImageIndex = -1;
			this.trvWel.Location = new System.Drawing.Point(8, 16);
			this.trvWel.Name = "trvWel";
			this.trvWel.SelectedImageIndex = -1;
			this.trvWel.Size = new System.Drawing.Size(224, 456);
			this.trvWel.TabIndex = 0;
			this.trvWel.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvWel_AfterSelect);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmbCountry);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(16, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(240, 40);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			// 
			// cmbCountry
			// 
			this.cmbCountry.Location = new System.Drawing.Point(88, 16);
			this.cmbCountry.Name = "cmbCountry";
			this.cmbCountry.Size = new System.Drawing.Size(144, 20);
			this.cmbCountry.TabIndex = 1;
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
			// crpvWater
			// 
			this.crpvWater.ActiveViewIndex = -1;
			this.crpvWater.Location = new System.Drawing.Point(272, 64);
			this.crpvWater.Name = "crpvWater";
			this.crpvWater.ReportSource = null;
			this.crpvWater.ShowExportButton = false;
			this.crpvWater.Size = new System.Drawing.Size(496, 472);
			this.crpvWater.TabIndex = 9;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numEnd);
			this.groupBox1.Controls.Add(this.numStart);
			this.groupBox1.Controls.Add(this.btnExit);
			this.groupBox1.Controls.Add(this.btnDis);
			this.groupBox1.Controls.Add(this.dtpTo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.dtpFrom);
			this.groupBox1.Location = new System.Drawing.Point(264, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(520, 48);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(440, 16);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnDis
			// 
			this.btnDis.Location = new System.Drawing.Point(344, 15);
			this.btnDis.Name = "btnDis";
			this.btnDis.Size = new System.Drawing.Size(88, 23);
			this.btnDis.TabIndex = 3;
			this.btnDis.Text = "明细显示";
			this.btnDis.Click += new System.EventHandler(this.btnDis_Click);
			// 
			// dtpTo
			// 
			this.dtpTo.Location = new System.Drawing.Point(192, 16);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(112, 21);
			this.dtpTo.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(152, 16);
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
			// 
			// numStart
			// 
			this.numStart.Location = new System.Drawing.Point(120, 17);
			this.numStart.Name = "numStart";
			this.numStart.Size = new System.Drawing.Size(32, 21);
			this.numStart.TabIndex = 5;
			// 
			// numEnd
			// 
			this.numEnd.Location = new System.Drawing.Point(304, 16);
			this.numEnd.Name = "numEnd";
			this.numEnd.Size = new System.Drawing.Size(32, 21);
			this.numEnd.TabIndex = 6;
			// 
			// frmWarnRep
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(944, 549);
			this.Controls.Add(this.grp1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.crpvWater);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmWarnRep";
			this.Text = "监测站异常表";
			this.Load += new System.EventHandler(this.frmWarnRep_Load);
			this.grp1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numStart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numEnd)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmWarnRep_Load(object sender, System.EventArgs e)
		{
			BengZhan.tools.CPaintForm.paintCountry(this.cmbCountry);
			BengZhan.tools.CPaintForm.paintWell(this.cmbCountry.Text,this.trvWel);
			this.dtpTo.Value=this.dtpFrom.Value.AddDays(1);
			this.paintFrmSize();
			showCry();
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
		public static bool getWellNo(System.Windows.Forms.TreeView trv,ref string strWellNo)
		{
			if(trv.SelectedNode==null)
			{
				MessageBox.Show("请选择一个监测站!");
				return false;
			}
			if(trv.SelectedNode.Text.IndexOf("|")<=0)
			{
				MessageBox.Show("请选择一个监测站!");
				return false;
			}
			string strInfo=trv.SelectedNode.Text.Trim();
			strWellNo=strInfo.Substring(0,strInfo.IndexOf("|"));
			return true;
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnDis_Click(object sender, System.EventArgs e)
		{
			try
			{
				string strWellNo="";
				if(getWellNo(this.trvWel,ref strWellNo)==false)
				{
					return;
				}

				string strFrom=this.dtpFrom.Value.ToShortDateString();
				strFrom=strFrom+" "+this.numStart.Value.ToString().Trim()+":00:00";
				string strTo=this.dtpTo.Value.ToShortDateString();
				strTo=strTo+" "+this.numEnd.Value.ToString().Trim()+":00:00";

				SqlCommand sCmd=new SqlCommand();
				sCmd.CommandType=CommandType.StoredProcedure;
				sCmd.CommandText="p_sr_warnDetail";
				sCmd.Connection=CDBConnection.m_sCon;

				sCmd.Parameters.Add("@strFrom",SqlDbType.NVarChar,40);
				sCmd.Parameters.Add("@strTo",SqlDbType.NVarChar,40);
				sCmd.Parameters.Add("@strZhanNo",SqlDbType.NVarChar,20);

				sCmd.Parameters["@strFrom"].Value=strFrom;
				sCmd.Parameters["@strTo"].Value=strTo;
				sCmd.Parameters["@strZhanNo"].Value=strWellNo;

				DataTable dt=new DataTable();

				DataSet ds=new DataSet();

                SqlDataAdapter sda=new SqlDataAdapter();
				sda.SelectCommand=sCmd;
				sda.Fill(ds,"dtWarn");
				dt=ds.Tables["dtWarn"];

				Hashtable ht=new Hashtable();
				ht.Add("field1","单位名称");
				ht.Add("field2","参数名称");
				ht.Add("field3","参数值");
				ht.Add("field4","报警信息");
				ht.Add("field5","上报时间");

				//BengZhan.comReport._5.crp5 crp=new BengZhan.comReport._5.crp5();
				ReportDocument crp=new ReportDocument();
				crp.Load("crp5.rpt");
				string strTime=String.Format("时间范围:{0}至{1}",strFrom,strTo);				
				BengZhan.comReport.CReports.showReport5(this.crpvWater,dt,ht,crp,"报警信息表",strTime);

				
				//ht.Add("");
				//ht.Add("");
				

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}	

		}
		private bool showCry()
		{
			try
			{
				string strWellNo="001";
				
				string strFrom=this.dtpFrom.Value.ToShortDateString();
				strFrom=strFrom+" "+this.numStart.Value.ToString().Trim()+":00:00";
				string strTo=this.dtpTo.Value.ToShortDateString();
				strTo=strTo+" "+this.numEnd.Value.ToString().Trim()+":00:00";

				SqlCommand sCmd=new SqlCommand();
				sCmd.CommandType=CommandType.StoredProcedure;
				sCmd.CommandText="p_sr_warnDetail";
				sCmd.Connection=CDBConnection.m_sCon;

				sCmd.Parameters.Add("@strFrom",SqlDbType.NVarChar,40);
				sCmd.Parameters.Add("@strTo",SqlDbType.NVarChar,40);
				sCmd.Parameters.Add("@strZhanNo",SqlDbType.NVarChar,20);

				sCmd.Parameters["@strFrom"].Value=strFrom;
				sCmd.Parameters["@strTo"].Value=strTo;
				sCmd.Parameters["@strZhanNo"].Value=strWellNo;

				DataTable dt=new DataTable();

				DataSet ds=new DataSet();

				SqlDataAdapter sda=new SqlDataAdapter();
				sda.SelectCommand=sCmd;
				sda.Fill(ds,"dtWarn");
				dt=ds.Tables["dtWarn"];

				Hashtable ht=new Hashtable();
				ht.Add("field1","单位名称");
				ht.Add("field2","参数名称");
				ht.Add("field3","参数值");
				ht.Add("field4","报警信息");
				ht.Add("field5","上报时间");

				ReportDocument crp=new ReportDocument();
				crp.Load("crp5.rpt");

				//BengZhan.comReport._5.crp5 crp=new BengZhan.comReport._5.crp5();
				string strTime=String.Format("时间范围:{0}至{1}",strFrom,strTo);				
				BengZhan.comReport.CReports.showReport5(this.crpvWater,dt,ht,crp,"报警信息表",strTime);
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}

		private void trvWel_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
		
		}
	}
}

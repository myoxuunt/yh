using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;
using System.Data;
using System.Data.SqlClient;

namespace CReportDll
{
	/// <summary>
	/// frmDataRep 的摘要说明。
	/// </summary>
	public class frmDataRep : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cmbCountry;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox grp1;
		private System.Windows.Forms.TreeView trvWel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown numEnd;
		private System.Windows.Forms.NumericUpDown numStart;
		private System.Windows.Forms.Button btnDis;
		private System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpFrom;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.DataGrid dataGrid3;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Button btnExp;
		private System.Windows.Forms.Button btnExit;
		private System.ComponentModel.IContainer components;

		public frmDataRep()
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
			this.components = new System.ComponentModel.Container();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmbCountry = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.grp1 = new System.Windows.Forms.GroupBox();
			this.trvWel = new System.Windows.Forms.TreeView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnExp = new System.Windows.Forms.Button();
			this.btnPrint = new System.Windows.Forms.Button();
			this.numEnd = new System.Windows.Forms.NumericUpDown();
			this.numStart = new System.Windows.Forms.NumericUpDown();
			this.btnDis = new System.Windows.Forms.Button();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.btnExit = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.dataGrid2 = new System.Windows.Forms.DataGrid();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.dataGrid3 = new System.Windows.Forms.DataGrid();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
			this.groupBox2.SuspendLayout();
			this.grp1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numEnd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numStart)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
			this.tabPage3.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmbCountry);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(0, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(176, 48);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// cmbCountry
			// 
			this.cmbCountry.Location = new System.Drawing.Point(72, 16);
			this.cmbCountry.Name = "cmbCountry";
			this.cmbCountry.Size = new System.Drawing.Size(96, 20);
			this.cmbCountry.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "所属乡镇：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// grp1
			// 
			this.grp1.Controls.Add(this.trvWel);
			this.grp1.Location = new System.Drawing.Point(0, 56);
			this.grp1.Name = "grp1";
			this.grp1.Size = new System.Drawing.Size(176, 596);
			this.grp1.TabIndex = 8;
			this.grp1.TabStop = false;
			this.grp1.Enter += new System.EventHandler(this.grp1_Enter);
			// 
			// trvWel
			// 
			this.trvWel.ImageIndex = -1;
			this.trvWel.Location = new System.Drawing.Point(8, 16);
			this.trvWel.Name = "trvWel";
			this.trvWel.SelectedImageIndex = -1;
			this.trvWel.Size = new System.Drawing.Size(160, 576);
			this.trvWel.TabIndex = 0;
			this.trvWel.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvWel_AfterSelect);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnExp);
			this.groupBox1.Controls.Add(this.btnPrint);
			this.groupBox1.Controls.Add(this.numEnd);
			this.groupBox1.Controls.Add(this.numStart);
			this.groupBox1.Controls.Add(this.btnDis);
			this.groupBox1.Controls.Add(this.dtpTo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.dtpFrom);
			this.groupBox1.Controls.Add(this.btnExit);
			this.groupBox1.Location = new System.Drawing.Point(176, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(568, 48);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// btnExp
			// 
			this.btnExp.Location = new System.Drawing.Point(448, 15);
			this.btnExp.Name = "btnExp";
			this.btnExp.Size = new System.Drawing.Size(56, 23);
			this.btnExp.TabIndex = 9;
			this.btnExp.Text = "导出";
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(392, 15);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(56, 23);
			this.btnPrint.TabIndex = 8;
			this.btnPrint.Text = "打印";
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
			// btnDis
			// 
			this.btnDis.Location = new System.Drawing.Point(336, 15);
			this.btnDis.Name = "btnDis";
			this.btnDis.Size = new System.Drawing.Size(56, 23);
			this.btnDis.TabIndex = 3;
			this.btnDis.Text = "确认";
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
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(504, 15);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(56, 23);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(176, 64);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(840, 592);
			this.tabControl1.TabIndex = 12;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox3);
			this.tabPage1.Location = new System.Drawing.Point(4, 21);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(832, 567);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "明细表";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dataGrid1);
			this.groupBox3.Location = new System.Drawing.Point(0, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(832, 568);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(3, 17);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(826, 548);
			this.dataGrid1.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupBox4);
			this.tabPage2.Location = new System.Drawing.Point(4, 21);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(832, 567);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "日统计表";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.dataGrid2);
			this.groupBox4.Location = new System.Drawing.Point(0, 0);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(832, 568);
			this.groupBox4.TabIndex = 0;
			this.groupBox4.TabStop = false;
			// 
			// dataGrid2
			// 
			this.dataGrid2.DataMember = "";
			this.dataGrid2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid2.Location = new System.Drawing.Point(3, 17);
			this.dataGrid2.Name = "dataGrid2";
			this.dataGrid2.Size = new System.Drawing.Size(826, 548);
			this.dataGrid2.TabIndex = 0;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.groupBox5);
			this.tabPage3.Location = new System.Drawing.Point(4, 21);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(832, 567);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "月统计表";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.dataGrid3);
			this.groupBox5.Location = new System.Drawing.Point(0, 0);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(832, 568);
			this.groupBox5.TabIndex = 0;
			this.groupBox5.TabStop = false;
			// 
			// dataGrid3
			// 
			this.dataGrid3.DataMember = "";
			this.dataGrid3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGrid3.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid3.Location = new System.Drawing.Point(3, 17);
			this.dataGrid3.Name = "dataGrid3";
			this.dataGrid3.Size = new System.Drawing.Size(826, 548);
			this.dataGrid3.TabIndex = 0;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// frmDataRep
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(1016, 654);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.grp1);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmDataRep";
			this.Text = "流量统计";
			this.Load += new System.EventHandler(this.frmDataRep_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmDataRep_Paint);
			this.groupBox2.ResumeLayout(false);
			this.grp1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numEnd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numStart)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private string m_strYe="";

		private void frmDataRep_Load(object sender, System.EventArgs e)
		{
			BengZhan.tools.CPaintForm.paintCountry(this.cmbCountry);
			BengZhan.tools.CPaintForm.paintWell(this.cmbCountry.Text,this.trvWel);
			this.paintGrid();
			paintOneLine();
			
		}
		private XmlDocument m_xDocRep=null;

		private bool paintGrid()
		{
			try
			{
				if(this.m_xDocRep==null)
				{
					this.m_xDocRep=new XmlDocument();
					this.m_xDocRep.Load("report.xml");
				}

				XmlNode xNodeRep=this.m_xDocRep.DocumentElement.SelectSingleNode("./report[@name='tb1']");

				string strSql=xNodeRep.Attributes.GetNamedItem("sql").Value.Trim();

				DataTable dt=new   DataTable();

				//BengZhan.CDBConnection.getDataTable(ref dt,strSql,"tb1");

				DataGridTableStyle dgts=new DataGridTableStyle();

				
				for(int i=0;i<xNodeRep.ChildNodes.Count;i++)
				{

					DataGridTextBoxColumn dgtb;
					XmlNode xNodeHeader=xNodeRep.ChildNodes[i];
					string strText=xNodeHeader.Attributes.GetNamedItem("text").Value.Trim();
					string strField=xNodeHeader.Attributes.GetNamedItem("field").Value.Trim();
					string strWidth=xNodeHeader.Attributes.GetNamedItem("width").Value.Trim();

					dgtb=new DataGridTextBoxColumn();
					dgtb.HeaderText=strText;
					dgtb.MappingName=strField;

					dt.Columns.Add(strField);

					int iWidth=int.Parse(strWidth);
					dgtb.Width=iWidth;

					dgts.GridColumnStyles.Add(dgtb);
					
				}		
			
				this.dataGrid1.TableStyles.Clear();
				this.dataGrid1.TableStyles.Add(dgts);
				this.dataGrid1.DataSource=dt;

				this.dataGrid1.ReadOnly=true;

				this.dataGrid1.CaptionText="明细表";
				
				xNodeRep=this.m_xDocRep.DocumentElement.SelectSingleNode("./report[@name='tb2']");
				dgts=new DataGridTableStyle();	
				dt=new DataTable();
				for(int i=0;i<xNodeRep.ChildNodes.Count;i++)
				{

					DataGridTextBoxColumn dgtb;
					XmlNode xNodeHeader=xNodeRep.ChildNodes[i];
					string strText=xNodeHeader.Attributes.GetNamedItem("text").Value.Trim();
					string strField=xNodeHeader.Attributes.GetNamedItem("field").Value.Trim();
					string strWidth=xNodeHeader.Attributes.GetNamedItem("width").Value.Trim();

					dgtb=new DataGridTextBoxColumn();
					dgtb.HeaderText=strText;
					dgtb.MappingName=strField;

					dt.Columns.Add(strField);

					int iWidth=int.Parse(strWidth);
					dgtb.Width=iWidth;

					dgts.GridColumnStyles.Add(dgtb);
					
				}		

				this.dataGrid2.TableStyles.Clear();
				this.dataGrid2.TableStyles.Add(dgts);
				this.dataGrid2.DataSource=dt;
				this.dataGrid2.CaptionText="日统计表";
				this.dataGrid2.ReadOnly=true;

				xNodeRep=this.m_xDocRep.DocumentElement.SelectSingleNode("./report[@name='tb3']");
				dgts=new DataGridTableStyle();	
				dt=new DataTable();

				for(int i=0;i<xNodeRep.ChildNodes.Count;i++)
				{
					DataGridTextBoxColumn dgtb;
					XmlNode xNodeHeader=xNodeRep.ChildNodes[i];
					string strText=xNodeHeader.Attributes.GetNamedItem("text").Value.Trim();
					string strField=xNodeHeader.Attributes.GetNamedItem("field").Value.Trim();
					string strWidth=xNodeHeader.Attributes.GetNamedItem("width").Value.Trim();

					dgtb=new DataGridTextBoxColumn();
					dgtb.HeaderText=strText;
					dgtb.MappingName=strField;

					dt.Columns.Add(strField);

					int iWidth=int.Parse(strWidth);
					dgtb.Width=iWidth;

					dgts.GridColumnStyles.Add(dgtb);
					
				}		

				this.dataGrid3.TableStyles.Clear();
				this.dataGrid3.TableStyles.Add(dgts);
				this.dataGrid3.DataSource=dt;
				this.dataGrid3.CaptionText="月统计表";
				this.dataGrid3.ReadOnly=true;

				///this.dataGrid3.CaptionText="月统计表";				
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}

		private void groupBox1_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void groupBox2_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void grp1_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void crpvWater_Load(object sender, System.EventArgs e)
		{
		
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmDataRep_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		this.errorProvider1.SetError(this,"test errprovider");
		}

		private void btnExit_Click_1(object sender, System.EventArgs e)
		{
			this.btnExit_Click(null,null);
		}
 
		private string m_strSelNodeType="";

		private void btnDis_Click(object sender, System.EventArgs e)
		{
			if(this.trvWel.SelectedNode==null)
			{
				MessageBox.Show("请选中要进行统计的站点,单位或城区!");
				return;
			}

			switch(this.m_strSelNodeType.Trim())
			{
				case "zhan":
				switch(this.tabControl1.SelectedIndex)
				{
					case 0:
						//明细表
						this.detailRep();
						break;
					case 1:
						//日统计表
						dayStaticRep();
						break;
					case 2:
						monthStaticRep();
						break;
					
				}
				break;
				case "dep":
				switch(this.tabControl1.SelectedIndex)
				{
					case 0:

						break;
						
					case 1:
						break;
					case 2:
						break;
				}
					break;
			}
			
			this.paintOneLine();
		}

		private string m_strZhanName="";

		private void monthStaticRep()
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

				//BengZhan.comReport._9.crp9 crp=new BengZhan.comReport._9.crp9();

				//ReportDocument crp=new ReportDocument();
				//crp.Load("crp8.rpt");

				DataTable dtAvg=new DataTable();

				if(BengZhan.comReport.CReports.getDtMonthAvgReport(strZhanNo,strFrom,strTo,ref dtAvg)==false)
				{
					return;
				}

				DataTable dt=(DataTable)this.dataGrid3.DataSource;	
			
				dt.Rows.Clear();					
		
				for(int i=0;i<dtAvg.Rows.Count;i++)
				{
					DataRow dr=dt.NewRow();					
					for(int j=0;j<dt.Columns.Count;j++)
					{
						string strColName=dt.Columns[j].ColumnName;
						dr[strColName]=dtAvg.Rows[i][strColName].ToString();
					}
					dt.Rows.Add(dr);
				}

				string strFromMon=string.Format("{0}年{1}月",this.dtpFrom.Value.Year.ToString().Trim(),this.dtpTo.Value.Month.ToString().Trim());
				string strToMon=string.Format("{0}年{1}月",this.dtpFrom.Value.Year.ToString().Trim(),this.dtpTo.Value.Month.ToString().Trim());
				string strCapText=string.Format("{0}    {1}至{2}    流量月统计表",this.m_strZhanName,strFromMon,strToMon);
				this.dataGrid3.CaptionText=strCapText;
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void dayStatiRepDep()
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

				//BengZhan.comReport._9.crp9 crp=new BengZhan.comReport._9.crp9();

				//ReportDocument crp=new ReportDocument();
				//crp.Load("crp8.rpt");

				DataTable dtAvg=new DataTable();

				if(BengZhan.comReport.CReports.getDtAvgReport(strZhanNo,strFrom,strTo,ref dtAvg)==false)
				{
					return;
				}

				DataTable dt=(DataTable)this.dataGrid2.DataSource;	
			
				dt.Rows.Clear();					
		
				for(int i=0;i<dtAvg.Rows.Count;i++)
				{
					DataRow dr=dt.NewRow();					
					for(int j=0;j<dt.Columns.Count;j++)
					{
						string strColName=dt.Columns[j].ColumnName;
						dr[strColName]=dtAvg.Rows[i][strColName].ToString();
					}
					dt.Rows.Add(dr);
				}

				string strCapText=string.Format("{0}    {1}至{2}    流量日统计表",this.m_strZhanName,strFrom,strTo);
				this.dataGrid2.CaptionText=strCapText;
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}

		}
		//日统计表
		private void dayStaticRep()
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

				//BengZhan.comReport._9.crp9 crp=new BengZhan.comReport._9.crp9();

				//ReportDocument crp=new ReportDocument();
				//crp.Load("crp8.rpt");

				DataTable dtAvg=new DataTable();

				if(BengZhan.comReport.CReports.getDtAvgReport(strZhanNo,strFrom,strTo,ref dtAvg)==false)
				{
					return;
				}

				DataTable dt=(DataTable)this.dataGrid2.DataSource;	
			
				dt.Rows.Clear();					
		
				for(int i=0;i<dtAvg.Rows.Count;i++)
				{
					DataRow dr=dt.NewRow();					
					for(int j=0;j<dt.Columns.Count;j++)
					{
						string strColName=dt.Columns[j].ColumnName;
						dr[strColName]=dtAvg.Rows[i][strColName].ToString();
					}
					dt.Rows.Add(dr);
				}

				string strCapText=string.Format("{0}    {1}至{2}    流量日统计表",this.m_strZhanName,strFrom,strTo);
				this.dataGrid2.CaptionText=strCapText;
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		//明细表
		private void detailRep()
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

				//BengZhan.comReport._9.crp9 crp=new BengZhan.comReport._9.crp9();

				//ReportDocument crp=new ReportDocument();
				//crp.Load("crp8.rpt");

				DataTable dtDetail=new DataTable();

				if(BengZhan.comReport.CReports.getDtDetailReport(strZhanNo,strFrom,strTo,ref dtDetail)==false)
				{
					return;
				}

				DataTable dt=(DataTable)this.dataGrid1.DataSource;
		
				dt.Rows.Clear();
						
				for(int i=0;i<dtDetail.Rows.Count;i++)
				{
					DataRow dr=dt.NewRow();					
					for(int j=0;j<dt.Columns.Count;j++)
					{
						string strColName=dt.Columns[j].ColumnName;
                        dr[strColName]=dtDetail.Rows[i][strColName].ToString();
					}
					dt.Rows.Add(dr);
				}

				string strCapText=string.Format("{0}    {1}至{2}    流量明细表",this.m_strZhanName,strFrom,strTo);
				this.dataGrid1.CaptionText=strCapText;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void paintOneLine()
		{
			DataTable dt=(DataTable)this.dataGrid1.DataSource;
			this.clearRow(dt);

			if(this.tabControl1.SelectedIndex==0)
			{
				if(dt!=null)
				{
					DataRow dr=dt.NewRow();
					for(int i=0;i<dt.Columns.Count;i++)
					{
						dr[i]="";
					}
					dt.Rows.Add(dr);
				}

			}
			
			
			dt=(DataTable)this.dataGrid2.DataSource;
				this.clearRow(dt);

			if(this.tabControl1.SelectedIndex==1)
			{
				if(dt!=null)
				{
					DataRow dr=dt.NewRow();
					for(int i=0;i<dt.Columns.Count;i++)
					{
						dr[i]="";
					}
					dt.Rows.Add(dr);
				}
	}	
	
			dt=(DataTable)this.dataGrid3.DataSource;
			this.clearRow(dt);

			if(this.tabControl1.SelectedIndex==2)
			{
				if(dt!=null)
				{
					DataRow dr=dt.NewRow();
					for(int i=0;i<dt.Columns.Count;i++)
					{
						dr[i]="";
					}
					dt.Rows.Add(dr);
				}

			}		
		}

		public void clearRow(DataTable dt)
		{
			if(dt==null)
			{
				return;
			}

			

			for(int i=0;i<dt.Rows.Count;i++)
			{
				bool bDel=true;
				for(int j=0;j<dt.Columns.Count;j++)
				{
					if(dt.Rows[i][j].ToString().Trim()!="")
					{
						bDel=false;
					}
				}
				if(bDel)
				{
					dt.Rows.RemoveAt(i);
					i--;
				}
					  }
				  }

		private void trvWel_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			if(this.trvWel.SelectedNode!=null)
			{
				this.m_strZhanName=this.trvWel.SelectedNode.Text;
			}
			
		}

		private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
		
				this.paintOneLine();
				//this.dataGrid3.CaptionText="月统计表";
				//this.dataGrid2.CaptionText="日统计表";
				//this.dataGrid1.CaptionText="明细表";
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
		}

		private void btnPrint_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}

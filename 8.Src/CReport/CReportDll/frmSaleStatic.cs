using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Data.OleDb;
using System.Xml;

namespace CReportDll
{
	/// <summary>
	/// frmSaleStatic 的摘要说明。
	/// </summary>
	public class frmSaleStatic : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox grp1;
		private System.Windows.Forms.TreeView trvWel;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cmbCountry;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnExp;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.NumericUpDown numEnd;
		private System.Windows.Forms.NumericUpDown numStart;
		private System.Windows.Forms.Button btnDis;
		private System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpFrom;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGrid dgPrint;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.DataGrid dataGrid3;
		private System.Windows.Forms.Button btnClear;
		private System.ComponentModel.IContainer components;

		public frmSaleStatic()
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
			this.grp1 = new System.Windows.Forms.GroupBox();
			this.trvWel = new System.Windows.Forms.TreeView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmbCountry = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
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
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dgPrint = new System.Windows.Forms.DataGrid();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.dataGrid2 = new System.Windows.Forms.DataGrid();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.dataGrid3 = new System.Windows.Forms.DataGrid();
			this.btnClear = new System.Windows.Forms.Button();
			this.grp1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numEnd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numStart)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgPrint)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
			this.tabPage3.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).BeginInit();
			this.SuspendLayout();
			// 
			// grp1
			// 
			this.grp1.Controls.Add(this.trvWel);
			this.grp1.Location = new System.Drawing.Point(0, 51);
			this.grp1.Name = "grp1";
			this.grp1.Size = new System.Drawing.Size(176, 605);
			this.grp1.TabIndex = 13;
			this.grp1.TabStop = false;
			// 
			// trvWel
			// 
			this.trvWel.ImageIndex = -1;
			this.trvWel.Location = new System.Drawing.Point(8, 16);
			this.trvWel.Name = "trvWel";
			this.trvWel.SelectedImageIndex = -1;
			this.trvWel.Size = new System.Drawing.Size(160, 584);
			this.trvWel.TabIndex = 0;
			this.trvWel.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvWel_AfterSelect);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmbCountry);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(0, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(176, 48);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
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
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnClear);
			this.groupBox1.Controls.Add(this.btnExp);
			this.groupBox1.Controls.Add(this.btnPrint);
			this.groupBox1.Controls.Add(this.numEnd);
			this.groupBox1.Controls.Add(this.numStart);
			this.groupBox1.Controls.Add(this.btnDis);
			this.groupBox1.Controls.Add(this.dtpTo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.dtpFrom);
			this.groupBox1.Controls.Add(this.btnExit);
			this.groupBox1.Location = new System.Drawing.Point(176, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(632, 48);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			// 
			// btnExp
			// 
			this.btnExp.Location = new System.Drawing.Point(448, 15);
			this.btnExp.Name = "btnExp";
			this.btnExp.Size = new System.Drawing.Size(56, 23);
			this.btnExp.TabIndex = 9;
			this.btnExp.Text = "导出";
			this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(392, 15);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(56, 23);
			this.btnPrint.TabIndex = 8;
			this.btnPrint.Text = "打印";
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
			this.btnExit.Location = new System.Drawing.Point(560, 15);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(56, 23);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(176, 59);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(840, 592);
			this.tabControl1.TabIndex = 16;
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
			this.groupBox3.Controls.Add(this.dgPrint);
			this.groupBox3.Controls.Add(this.dataGrid1);
			this.groupBox3.Location = new System.Drawing.Point(0, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(832, 568);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			// 
			// dgPrint
			// 
			this.dgPrint.DataMember = "";
			this.dgPrint.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgPrint.Location = new System.Drawing.Point(48, 152);
			this.dgPrint.Name = "dgPrint";
			this.dgPrint.TabIndex = 1;
			this.dgPrint.Visible = false;
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
			this.tabPage2.Visible = false;
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
			this.tabPage3.Visible = false;
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
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(504, 15);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(56, 23);
			this.btnClear.TabIndex = 10;
			this.btnClear.Text = "清空";
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// frmSaleStatic
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(1016, 654);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.grp1);
			this.Controls.Add(this.groupBox2);
			this.Name = "frmSaleStatic";
			this.Text = "售水统计";
			this.Load += new System.EventHandler(this.frmSaleStatic_Load);
			this.grp1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numEnd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numStart)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgPrint)).EndInit();
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
		private void frmSaleStatic_Load(object sender, System.EventArgs e)
		{
		        BengZhan.tools.CPaintForm.paintCountry(this.cmbCountry);
				BengZhan.tools.CPaintForm.paintWell(this.cmbCountry.Text,this.trvWel);
			    paintSalers(ref this.trvWel);
			this.paintGrid();
			paintOneLine();

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
		XmlDocument m_xDocRep;
		
		private bool paintGrid()
		{
			try
			{
				if(this.m_xDocRep==null)
				{
					this.m_xDocRep=new XmlDocument();
					this.m_xDocRep.Load("salRep.xml");
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
		public static void paintSalers(ref System.Windows.Forms.TreeView trv)
		{
			try
			{

				string strSql=string.Format("select userID,userName from tbUsers");
				DataTable dtUsers=new  DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtUsers,strSql,"tbUsers");

				System.Windows.Forms.TreeNode tn=new TreeNode();
				tn.Text="操作员列表";

				for(int i=0;i<dtUsers.Rows.Count;i++)
				{
					tn.Nodes.Add(dtUsers.Rows[i]["userName"].ToString());
				}

				trv.Nodes.Add(tn);
			
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

		private void btnExp_Click(object sender, System.EventArgs e)
		{
			try
			{
				SaveFileDialog openFileDialog1 = new SaveFileDialog();
				openFileDialog1.Filter = "excel文件|*.xls"; 
				openFileDialog1.Title = "导出到excel文件"; 
				openFileDialog1.InitialDirectory=@"c:\";
				openFileDialog1.FileName="datas.xls";

				string strFileName="";
 
				// Show the Dialog. 
				// If the user clicked OK in the dialog and 
				// a .CUR file was selected, open it. 
				if (openFileDialog1.ShowDialog() == DialogResult.OK) 
				{ 
					if(openFileDialog1.FileName!= "") 
					{ 
						strFileName=openFileDialog1.FileName;
					
					} 
					else
					{
						return;
					}
				}
				else
				{
					return;
				}

				if(strFileName.IndexOf(".xls")<=0)
				{
					MessageBox.Show("文件类型有误！");
					return;
				}

				Directory.SetCurrentDirectory(Application.StartupPath);

				File.Delete(strFileName);
				File.Copy("bkData.xls",strFileName);
				
				string strTableName="";

				switch(this.tabControl1.SelectedIndex)
				{
					case 0:
						BengZhan.comReport.CReports.m_dtExport=(DataTable)this.dataGrid1.DataSource;
						this.dgPrint=this.dataGrid1;
						strTableName="明细表";
						break;
					case 1:
						BengZhan.comReport.CReports.m_dtExport=(DataTable)this.dataGrid2.DataSource;
						this.dgPrint=this.dataGrid2;
						strTableName="日统计表";
						break;
					case 2:
						BengZhan.comReport.CReports.m_dtExport=(DataTable)this.dataGrid3.DataSource;
						this.dgPrint=this.dataGrid3;
						strTableName="月统计表";
						break;
				}
			
				//this.crpvWater.ExportReport();
				if(BengZhan.comReport.CReports.m_dtExport==null)
				{
					MessageBox.Show("没有可导出的数据!");
					return;
				}

				Hashtable ht=new Hashtable();

				for(int i=0;i<this.dgPrint.TableStyles[0].GridColumnStyles.Count;i++)
				{

					string strText=this.dgPrint.TableStyles[0].GridColumnStyles[i].HeaderText.Trim();
					string strField=this.dgPrint.TableStyles[0].GridColumnStyles[i].MappingName.Trim();

					ht.Add(strField,strText);
				}
			
				string strCon=String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR=YES;'",strFileName);

				OleDbConnection odbCon=new OleDbConnection(strCon);
				odbCon.Open();
				string strSql=string.Format("create table {0}(",strTableName);
				System.Text.StringBuilder sbCreate=new System.Text.StringBuilder(strSql);

				OleDbCommand odc=new OleDbCommand();
				odc.CommandText=strSql;
				odc.Connection=odbCon;			

				DataTable dtExport=BengZhan.comReport.CReports.m_dtExport;	
			
				bool bCreate=false;
			
				for(int i=0;i<dtExport.Rows.Count;i++)
				{
					System.Text.StringBuilder sbInsert=new System.Text.StringBuilder(string.Format("insert into [{0}$](",strTableName));
					for(int j=0;j<dtExport.Columns.Count;j++)
					{
						string strColCName="";
						string strColEName="";
						strColEName=dtExport.Columns[j].ColumnName.Trim();
						strColCName=ht[strColEName].ToString().Trim();
						sbInsert.Append(strColCName);
						sbCreate.Append(string.Format("{0} text",strColCName));
						if(j!=(dtExport.Columns.Count-1))
						{
							sbInsert.Append(",");
							sbCreate.Append(",");
						}                    					
					}

					sbInsert.Append(")values(");
					sbCreate.Append(")");

					for(int j=0;j<dtExport.Columns.Count;j++)
					{
						string strColCName="";
						string strColEName="";
						strColEName=dtExport.Columns[j].ColumnName.Trim();
						strColCName=ht[strColEName].ToString().Trim();
						string strVal=dtExport.Rows[i][j].ToString();
						sbInsert.Append("'");
						sbInsert.Append(strVal);
						sbInsert.Append("'");
						if(j!=(dtExport.Columns.Count-1))
						{
							sbInsert.Append(",");
						}              
					}
					sbInsert.Append(")");

					odc.CommandText=sbCreate.ToString();
					if(!bCreate)
					{
						odc.ExecuteNonQuery();
						bCreate=true;

					}
				
					odc.CommandText=sbInsert.ToString();
					odc.ExecuteNonQuery();

				}		
				odbCon.Close();
				MessageBox.Show("导出完成!");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		     this.paintOneLine();
		}

		private void btnDis_Click(object sender, System.EventArgs e)
		{
			if(this.m_strSelNodeType.Trim()=="")
			{
				MessageBox.Show("请选中要进行统计的站点,单位!");
				return;
			}
			bool bBreak=false;

			switch(this.m_strSelNodeType.Trim())
			{
				case "zhan":
				switch(this.tabControl1.SelectedIndex)
				{
					case 0:
						//明细表
						this.detailRep();
						bBreak=true;
						break;
					case 1:
						//日统计表
						dayStaticRep();
						bBreak=true;
						break;
					case 2:
						monthStaticRep();
						bBreak=true;
						break;
					
				}
					break;
				case "dep":
				switch(this.tabControl1.SelectedIndex)
				{
					case 0:
						detailRepDep();
						bBreak=true;
						break;						
					case 1:
						this.dayStaticRepDep();
						bBreak=true;
						break;
					case 2:
						this.monthStaticRepDep();
						bBreak=true;
						break;
				}
					break;
				case "manaPer":
				switch(this.tabControl1.SelectedIndex)
				{
				case 0:
					detailRepManaPer();
						bBreak=true;
					break;
					case 1:
							avgRepManaPer();
                            bBreak=true;
						break;
					case 2:
						avgRepManaPerMonth();
						bBreak=true;
						break;

				}
					break;
			}
			if(!bBreak)
			{
				MessageBox.Show("请选中要进行统计的监测站或单位或操作员!");
				return;
			}
			this.paintOneLine();
		}

		private void avgRepManaPerMonth()
		{
			try
			{
				string strFrom=this.dtpFrom.Value.ToShortDateString();
				string strTo=this.dtpTo.Value.ToShortDateString();				

				string strManaPer=this.trvWel.SelectedNode.Text;					

				DataTable dtDetail=new DataTable();

				if(CReportDll.comReport.CSalReport.getDtAvgReportManaMonth(strManaPer,strFrom,strTo,ref dtDetail)==false)
				{
					return;
				}

				DataTable dt=(DataTable)this.dataGrid3.DataSource;
		
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

				strFrom=strFrom.Substring(0,7).Replace("-","年");
				strFrom=strFrom+"月";
				strTo=strTo.Substring(0,7).Replace("-","年");
				strTo=strTo+"月";

				string strCapText=string.Format("{0}    {1}至{2}    售水月统计表",strManaPer,strFrom,strTo);
				this.dataGrid3.CaptionText=strCapText;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void avgRepManaPer()		
		{
			try
			{
				string strFrom=this.dtpFrom.Value.ToShortDateString();

				string strTo=this.dtpTo.Value.ToShortDateString();
				

				string strManaPer=this.trvWel.SelectedNode.Text;					

				DataTable dtDetail=new DataTable();

				if(CReportDll.comReport.CSalReport.getDtAvgReportMana(strManaPer,strFrom,strTo,ref dtDetail)==false)
				{
					return;
				}

				DataTable dt=(DataTable)this.dataGrid2.DataSource;
		
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

				string strCapText=string.Format("{0}    {1}至{2}    售水明细表",strManaPer,strFrom,strTo);
				this.dataGrid2.CaptionText=strCapText;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private string  m_strZhanName="";
		private string m_strSelNodeType="";

		private void trvWel_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			if(this.trvWel.SelectedNode!=null)
			{
				this.m_strZhanName=this.trvWel.SelectedNode.Text;
			}
			if(this.trvWel.SelectedNode.Nodes.Count==0)
			{
				this.m_strSelNodeType="zhan";
				checkManaPer();
				return;
			}
			if(this.trvWel.SelectedNode.Nodes[0].Nodes.Count==0)
			{
				this.m_strSelNodeType="dep";
				checkManaPer();
				return;
			}
			this.m_strSelNodeType="";
			return;			
		}

		private void checkManaPer()
		{

			if(this.trvWel.SelectedNode.Text.IndexOf("操作员")>=0)
			{
				this.m_strSelNodeType="";
				return;
			}
			if(this.trvWel.SelectedNode.Parent!=null)
			{
				if(this.trvWel.SelectedNode.Parent.Text.IndexOf("操作员")>=0)
				{
					this.m_strSelNodeType="manaPer";
					return;
				}
			}
		}
		private void detailRepManaPer()
		{
			try
			{
				string strFrom=this.dtpFrom.Value.ToShortDateString();
				strFrom=strFrom+" "+this.numStart.Value.ToString().Trim()+":00:00";
				string strTo=this.dtpTo.Value.ToShortDateString();
				strTo=strTo+" "+this.numEnd.Value.ToString().Trim()+":00:00";

				string strManaPer=this.trvWel.SelectedNode.Text;					

				DataTable dtDetail=new DataTable();

				if(CReportDll.comReport.CSalReport.getDtDetailReportMana(strManaPer,strFrom,strTo,ref dtDetail)==false)
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

				string strCapText=string.Format("{0}    {1}至{2}    售水明细表",this.m_strZhanName,strFrom,strTo);
				this.dataGrid1.CaptionText=strCapText;
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

				DataTable dtDetail=new DataTable();

				if(CReportDll.comReport.CSalReport.getDtDetailReport(strZhanNo,strFrom,strTo,ref dtDetail)==false)
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

				string strCapText=string.Format("{0}    {1}至{2}    购水明细表",this.m_strZhanName,strFrom,strTo);
				this.dataGrid1.CaptionText=strCapText;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		//单位明细表
		private void detailRepDep()
		{
			try
			{
				string strFrom=this.dtpFrom.Value.ToShortDateString();
				strFrom=strFrom+" "+this.numStart.Value.ToString().Trim()+":00:00";
				string strTo=this.dtpTo.Value.ToShortDateString();
				strTo=strTo+" "+this.numEnd.Value.ToString().Trim()+":00:00";
			
				string strDepName=this.trvWel.SelectedNode.Text.Trim();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
			
				DataTable dtDetail=new DataTable();

				if(CReportDll.comReport.CSalReport.getDtDetailReportDep(strDepName,strFrom,strTo,ref dtDetail)==false)
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

				string strCapText=string.Format("{0}    {1}至{2}    流量明细表",strDepName,strFrom,strTo);
				this.dataGrid1.CaptionText=strCapText;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	
		private void btnClear_Click(object sender, System.EventArgs e)
		{
			DataTable dt=(DataTable)this.dataGrid1.DataSource;
			dt.Rows.Clear();
			dt=(DataTable)this.dataGrid2.DataSource;
			dt.Rows.Clear();
			dt=(DataTable)this.dataGrid3.DataSource;
			dt.Rows.Clear();
	   this.paintOneLine();
		}

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
			
				DataTable dtAvg=new DataTable();

				if(CReportDll.comReport.CSalReport.getDtAvgReportMonth(strZhanNo,strFrom,strTo,ref dtAvg)==false)
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
						if(strColName=="time")
						{
								dr[strColName]=dtAvg.Rows[i][strColName].ToString().Replace("-","月");
						}
						else
						{
								dr[strColName]=dtAvg.Rows[i][strColName].ToString();
						}
					
					}
					dt.Rows.Add(dr);
				}

				strFrom=strFrom.Substring(0,7).Replace("-","年");
				strFrom=strFrom+"月";
				strTo=strTo.Substring(0,7).Replace("-","年");
				strTo=strTo+"月";
				string strCapText=string.Format("{0}    {1}至{2}    购水月统计表",this.m_strZhanName,strFrom,strTo);
				this.dataGrid3.CaptionText=strCapText;
				
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

			
				DataTable dtAvg=new DataTable();

				if(CReportDll.comReport.CSalReport.getDtAvgReport(strZhanNo,strFrom,strTo,ref dtAvg)==false)
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

				string strCapText=string.Format("{0}    {1}至{2}    购水日统计表",this.m_strZhanName,strFrom,strTo);
				this.dataGrid2.CaptionText=strCapText;
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void monthStaticRepDep()
		{
			try
			{
				string strFrom=this.dtpFrom.Value.ToShortDateString();		
				string strTo=this.dtpTo.Value.ToShortDateString();	
		
				string strDepName=this.trvWel.SelectedNode.Text.Trim();				

				DataTable dtAvg=new DataTable();

				if(CReportDll.comReport.CSalReport.getDtAvgReportDepMonth(strDepName,strFrom,strTo,ref dtAvg)==false)
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
				strFrom=strFrom.Substring(0,7).Replace("-","年");
				strFrom=strFrom+"月";
				strTo=strTo.Substring(0,7).Replace("-","年");
				strTo=strTo+"月";

				string strCapText=string.Format("{0}    {1}至{2}    流量日统计表",strDepName,strFrom,strTo);
				this.dataGrid3.CaptionText=strCapText;
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		//日统计表
		private void dayStaticRepDep()
		{
			try
			{
				string strFrom=this.dtpFrom.Value.ToShortDateString();		
				string strTo=this.dtpTo.Value.ToShortDateString();	
		
				string strDepName=this.trvWel.SelectedNode.Text.Trim();				

				DataTable dtAvg=new DataTable();

				if(CReportDll.comReport.CSalReport.getDtAvgReportDep(strDepName,strFrom,strTo,ref dtAvg)==false)
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

				string strCapText=string.Format("{0}    {1}至{2}    流量日统计表",strDepName,strFrom,strTo);
				this.dataGrid2.CaptionText=strCapText;
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}


	}
}

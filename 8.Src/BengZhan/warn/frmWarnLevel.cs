using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BengZhan.warn
{
	/// <summary>
	/// frmWarnLevel 的摘要说明。
	/// </summary>
	public class frmWarnLevel : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbCountry;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox grp1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnSet;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ListView lsvWarn;
		private System.Windows.Forms.TreeView trvDep;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmWarnLevel()
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
			this.cmbCountry = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.grp1 = new System.Windows.Forms.GroupBox();
			this.trvDep = new System.Windows.Forms.TreeView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnSet = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lsvWarn = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.groupBox1.SuspendLayout();
			this.grp1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbCountry);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(8, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(224, 48);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// cmbCountry
			// 
			this.cmbCountry.Location = new System.Drawing.Point(88, 13);
			this.cmbCountry.Name = "cmbCountry";
			this.cmbCountry.Size = new System.Drawing.Size(136, 20);
			this.cmbCountry.TabIndex = 3;
			this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "所属乡镇：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// grp1
			// 
			this.grp1.Controls.Add(this.trvDep);
			this.grp1.Location = new System.Drawing.Point(8, 56);
			this.grp1.Name = "grp1";
			this.grp1.Size = new System.Drawing.Size(224, 488);
			this.grp1.TabIndex = 4;
			this.grp1.TabStop = false;
			// 
			// trvDep
			// 
			this.trvDep.ImageIndex = -1;
			this.trvDep.Location = new System.Drawing.Point(8, 16);
			this.trvDep.Name = "trvDep";
			this.trvDep.SelectedImageIndex = -1;
			this.trvDep.Size = new System.Drawing.Size(208, 464);
			this.trvDep.TabIndex = 0;
			this.trvDep.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvDep_AfterSelect);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnExit);
			this.groupBox2.Controls.Add(this.btnSet);
			this.groupBox2.Location = new System.Drawing.Point(240, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(312, 48);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(96, 16);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnSet
			// 
			this.btnSet.Location = new System.Drawing.Point(8, 16);
			this.btnSet.Name = "btnSet";
			this.btnSet.TabIndex = 0;
			this.btnSet.Text = "编辑";
			this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.lsvWarn);
			this.groupBox3.Location = new System.Drawing.Point(240, 56);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(664, 488);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			// 
			// lsvWarn
			// 
			this.lsvWarn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					  this.columnHeader1,
																					  this.columnHeader4,
																					  this.columnHeader2,
																					  this.columnHeader3,
																					  this.columnHeader5});
			this.lsvWarn.FullRowSelect = true;
			this.lsvWarn.GridLines = true;
			this.lsvWarn.Location = new System.Drawing.Point(8, 16);
			this.lsvWarn.MultiSelect = false;
			this.lsvWarn.Name = "lsvWarn";
			this.lsvWarn.Size = new System.Drawing.Size(648, 464);
			this.lsvWarn.TabIndex = 0;
			this.lsvWarn.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "站名称";
			this.columnHeader1.Width = 153;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "参数名称";
			this.columnHeader4.Width = 105;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "报警下限";
			this.columnHeader2.Width = 148;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "报警上限";
			this.columnHeader3.Width = 120;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "报警值";
			this.columnHeader5.Width = 116;
			// 
			// frmWarnLevel
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(912, 549);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.grp1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmWarnLevel";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "报警参数设定";
			this.Load += new System.EventHandler(this.frmWarnLevel_Load);
			this.groupBox1.ResumeLayout(false);
			this.grp1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmWarnLevel_Load(object sender, System.EventArgs e)
		{
			tools.CPaintForm.paintCountry(this.cmbCountry);
			BengZhan.tools.CPaintForm.paintWell(this.cmbCountry.Text,this.trvDep);
		}

		private void cmbCountry_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.trvDep.Nodes.Clear();	
			BengZhan.tools.CPaintForm.paintWell(this.cmbCountry.Text,this.trvDep);
		}

		private void trvDep_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			try
			{
				string strWellNo="";
				if(getWellNo(this.trvDep,ref strWellNo)==false)
				{
					return;
				}
				string strSql=String.Format("select wellName,depName,tbWarnDes.paramDes paramName,iLow,iHigh,trueVal from tbWell,tbWarn,tbWarnDes where tbWarn.wellNo=tbWell.wellNo and tbWarn.paramName=tbWarnDes.paramName and tbWell.wellNo='{0}'",strWellNo);
				DataTable dtWarn=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtWarn,strSql,"tbWarn");

				this.lsvWarn.Items.Clear();

				int j=0;
				for(int i=0;i<dtWarn.Rows.Count;i++)
				{
					this.lsvWarn.Items.Add(dtWarn.Rows[i]["wellName"].ToString());
					this.lsvWarn.Items[j].SubItems.Add(dtWarn.Rows[i]["paramName"].ToString());
					this.lsvWarn.Items[j].SubItems.Add(dtWarn.Rows[i]["iLow"].ToString());
					this.lsvWarn.Items[j].SubItems.Add(dtWarn.Rows[i]["iHigh"].ToString());
					this.lsvWarn.Items[j].SubItems.Add(dtWarn.Rows[i]["trueVal"].ToString());
					j++;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void paintParams()
		{
			try
			{
				string strWellNo="";
				if(getWellNo(this.trvDep,ref strWellNo)==false)
				{
					return;
				}
				string strSql=String.Format("select tbWell.wellName depName,tbWarnDes.paramDes paramName,iLow,iHigh,trueVal from tbWell,tbWarn,tbWarnDes where tbWarn.wellNo=tbWell.wellNo and tbWarn.paramName=tbWarnDes.paramName and tbWell.wellNo='{0}'",strWellNo);
				DataTable dtWarn=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtWarn,strSql,"tbWarn");

				this.lsvWarn.Items.Clear();

				int j=0;
				for(int i=0;i<dtWarn.Rows.Count;i++)
				{
					this.lsvWarn.Items.Add(dtWarn.Rows[i]["depName"].ToString());
					this.lsvWarn.Items[j].SubItems.Add(dtWarn.Rows[i]["paramName"].ToString());
					this.lsvWarn.Items[j].SubItems.Add(dtWarn.Rows[i]["iLow"].ToString());
					this.lsvWarn.Items[j].SubItems.Add(dtWarn.Rows[i]["iHigh"].ToString());
					this.lsvWarn.Items[j].SubItems.Add(dtWarn.Rows[i]["trueVal"].ToString());
					j++;
				}

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
				//MessageBox.Show("请选择一个监测站!");
				return false;
			}
			if(trv.SelectedNode.Text.IndexOf("|")<=0)
			{
				//MessageBox.Show("请选择一个监测站!");
				return false;
			}
			string strInfo=trv.SelectedNode.Text.Trim();
			strWellNo=strInfo.Substring(0,strInfo.IndexOf("|"));
			return true;
		}

		private void btnSet_Click(object sender, System.EventArgs e)
		{
			if(this.lsvWarn.SelectedItems.Count<=0)
			{
				MessageBox.Show("请选择一行要编辑的参数！");
				return;
			}
			
			string strZhanName=this.lsvWarn.SelectedItems[0].Text.Trim();
			string strParamName=this.lsvWarn.SelectedItems[0].SubItems[1].Text.Trim();
			string strILow=this.lsvWarn.SelectedItems[0].SubItems[2].Text.Trim();
			string strIHigh=this.lsvWarn.SelectedItems[0].SubItems[3].Text.Trim();

			frmSetWarnLev frmSWObj=new frmSetWarnLev();
			frmSWObj.m_strParamName=strParamName;
			frmSWObj.m_strZhanName=strZhanName;
			frmSWObj.m_strILow=strILow;
			frmSWObj.m_strIHigh=strIHigh;
			frmSWObj.ShowDialog();

			this.paintParams();
				
			
		}
	}
}

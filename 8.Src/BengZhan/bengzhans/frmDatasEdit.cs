using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Xml;

namespace BengZhan.bengzhans
{
	/// <summary>
	/// frmDatasEdit 的摘要说明。
	/// </summary>
	public class frmDatasEdit : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtZhan;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.GroupBox grp1;
		private System.Windows.Forms.TreeView trvWel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label lblWait;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.NumericUpDown numEnd;
		private System.Windows.Forms.NumericUpDown numStart;
		private System.Windows.Forms.Button btnDis;
		private System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpFrom;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGrid dataGrid1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public string m_strWellNo="";
		private string m_strSelNodeType="country";
		private DateTime dtb;
		private DateTime dte;

		public frmDatasEdit()
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
			this.txtZhan = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.grp1 = new System.Windows.Forms.GroupBox();
			this.trvWel = new System.Windows.Forms.TreeView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.lblWait = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.numEnd = new System.Windows.Forms.NumericUpDown();
			this.numStart = new System.Windows.Forms.NumericUpDown();
			this.btnDis = new System.Windows.Forms.Button();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.btnExit = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			this.grp1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numEnd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numStart)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtZhan);
			this.groupBox2.Controls.Add(this.lblName);
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(176, 48);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			// 
			// txtZhan
			// 
			this.txtZhan.Location = new System.Drawing.Point(72, 16);
			this.txtZhan.Name = "txtZhan";
			this.txtZhan.Size = new System.Drawing.Size(96, 21);
			this.txtZhan.TabIndex = 1;
			this.txtZhan.Text = "";
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(8, 19);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(64, 14);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "管理局：";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// grp1
			// 
			this.grp1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.grp1.Controls.Add(this.trvWel);
			this.grp1.Location = new System.Drawing.Point(0, 48);
			this.grp1.Name = "grp1";
			this.grp1.Size = new System.Drawing.Size(176, 448);
			this.grp1.TabIndex = 16;
			this.grp1.TabStop = false;
			// 
			// trvWel
			// 
			this.trvWel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.trvWel.ImageIndex = -1;
			this.trvWel.Location = new System.Drawing.Point(3, 17);
			this.trvWel.Name = "trvWel";
			this.trvWel.SelectedImageIndex = -1;
			this.trvWel.Size = new System.Drawing.Size(170, 428);
			this.trvWel.TabIndex = 0;
			this.trvWel.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvWel_AfterSelect);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.groupBox4);
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Location = new System.Drawing.Point(184, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(744, 496);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox4.Controls.Add(this.dataGrid1);
			this.groupBox4.Location = new System.Drawing.Point(8, 56);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(728, 432);
			this.groupBox4.TabIndex = 17;
			this.groupBox4.TabStop = false;
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(3, 17);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(722, 412);
			this.dataGrid1.TabIndex = 1;
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.btnDel);
			this.groupBox3.Controls.Add(this.btnEdit);
			this.groupBox3.Controls.Add(this.lblWait);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.btnAdd);
			this.groupBox3.Controls.Add(this.numEnd);
			this.groupBox3.Controls.Add(this.numStart);
			this.groupBox3.Controls.Add(this.btnDis);
			this.groupBox3.Controls.Add(this.dtpTo);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.dtpFrom);
			this.groupBox3.Controls.Add(this.btnExit);
			this.groupBox3.Location = new System.Drawing.Point(8, 8);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(728, 48);
			this.groupBox3.TabIndex = 16;
			this.groupBox3.TabStop = false;
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(600, 15);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(56, 23);
			this.btnDel.TabIndex = 15;
			this.btnDel.Text = "删除";
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(544, 15);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(56, 23);
			this.btnEdit.TabIndex = 14;
			this.btnEdit.Text = "编辑";
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// lblWait
			// 
			this.lblWait.Location = new System.Drawing.Point(736, 16);
			this.lblWait.Name = "lblWait";
			this.lblWait.Size = new System.Drawing.Size(88, 23);
			this.lblWait.TabIndex = 13;
			this.lblWait.Text = "正在检索数据......";
			this.lblWait.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblWait.Visible = false;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(8, 16);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(64, 23);
			this.label10.TabIndex = 11;
			this.label10.Text = "时间范围:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(408, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(16, 23);
			this.label9.TabIndex = 10;
			this.label9.Text = "时";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(488, 15);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(56, 23);
			this.btnAdd.TabIndex = 8;
			this.btnAdd.Text = "添加";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// numEnd
			// 
			this.numEnd.Location = new System.Drawing.Point(376, 16);
			this.numEnd.Maximum = new System.Decimal(new int[] {
																   12,
																   0,
																   0,
																   0});
			this.numEnd.Minimum = new System.Decimal(new int[] {
																   1,
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
			this.numStart.Location = new System.Drawing.Point(184, 16);
			this.numStart.Maximum = new System.Decimal(new int[] {
																	 12,
																	 0,
																	 0,
																	 0});
			this.numStart.Minimum = new System.Decimal(new int[] {
																	 1,
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
			this.btnDis.Location = new System.Drawing.Point(432, 15);
			this.btnDis.Name = "btnDis";
			this.btnDis.Size = new System.Drawing.Size(56, 23);
			this.btnDis.TabIndex = 3;
			this.btnDis.Text = "查询";
			this.btnDis.Click += new System.EventHandler(this.btnDis_Click);
			// 
			// dtpTo
			// 
			this.dtpTo.Location = new System.Drawing.Point(264, 16);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(112, 21);
			this.dtpTo.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(216, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "时至：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpFrom
			// 
			this.dtpFrom.Location = new System.Drawing.Point(72, 16);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.Size = new System.Drawing.Size(112, 21);
			this.dtpFrom.TabIndex = 0;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(656, 15);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(56, 23);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// frmDatasEdit
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(936, 502);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.grp1);
			this.Name = "frmDatasEdit";
			this.Text = "frmDatasEdit";
			this.Load += new System.EventHandler(this.frmDatasEdit_Load);
			this.groupBox2.ResumeLayout(false);
			this.grp1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numEnd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numStart)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void LoadTr()
		{
			try
			{
				string strSql=string.Format("select * from tbCountry");
				DataTable dtWell=null;
				CDBConnection.getDataTable(ref dtWell,strSql,"tbCountry");
				txtZhan.Text=dtWell.Rows[0]["countryName"].ToString();

				strSql=string.Format("select distinct depName from tbWell");
				CDBConnection.getDataTable(ref dtWell,strSql,"tbdepName");
				for (int z = 0; z < dtWell.Rows.Count; z++)
				{
					TreeNode tn = new TreeNode(dtWell.Rows[z]["depName"].ToString());
					trvWel.Nodes.Add(tn);
				}

				strSql=string.Format("select wellName,depName from tbWell");
				CDBConnection.getDataTable(ref dtWell,strSql,"tbwellName");
				for (int i = 0; i < dtWell.Rows.Count; i++)
				{
					for (int j = 0; j < trvWel.Nodes.Count; j++)
					{
						if (dtWell.Rows[i]["depName"].ToString().Trim() == trvWel.Nodes[j].Text)
						{
							TreeNode tn = new TreeNode(dtWell.Rows[i]["wellName"].ToString());
							trvWel.Nodes[j].Nodes.Add(tn);
						}
					}
				}
			}
			catch
			{
			}
		}

		private void LoadDGtitle()
		{
			DataGridTableStyle tbs= new DataGridTableStyle();
			string[] colNames = new string[] { "ID","name", "amount", "waterLevel","Speed","Samount", "exp", "time"};
			string[] showNames = new string[] { "序号","监测站名称", "流量(立方米/小时)", "水位(米)", "流速(米/秒)","瞬时流量(立方米/秒)","备注", "上报时间" };

			for (int i = 0; i < colNames.Length; i++)
			{
				DataGridTextBoxColumn clm=new DataGridTextBoxColumn();
				clm.MappingName=colNames[i];
				clm.HeaderText=showNames[i];
				if(i==0)
					clm.Width=30;
				else
					clm.Width=150;
				tbs.GridColumnStyles.Add(clm);
				
			}
			
				tbs.MappingName ="tbDatas";
			
			
			dataGrid1.TableStyles.Add(tbs);

		}

		private bool CheckDT()
		{
			dtb=DateTime.Parse(dtpFrom.Value.ToShortDateString()+" "+numStart.Value.ToString()+":00:00");
			dte=DateTime.Parse(dtpTo.Value.ToShortDateString()+" "+numEnd.Value.ToString()+":00:00");
			if(dtb<dte)
				return true;
			else
				return false;
		}

		private void ReadDatas()
		{
			try
			{
				string strSql="";
				switch(m_strSelNodeType)
				{
					case "zhan":
						strSql=string.Format("select * from tbw_waterDatas where name='{0}' and time between '{1}' and '{2}' order by time",trvWel.SelectedNode.Text,dtb.ToString(),dte.ToString());
						break;
					case "country":
						strSql=string.Format("select * from tbw_waterDatas where name in(select wellName from tbWell where depName='{0}') and time between '{1}' and '{2}'",trvWel.SelectedNode.Text,dtb.ToString(),dte.ToString());
						break;
					default:
						return;
				}
				DataTable dtWell=null;
				CDBConnection.getDataTable(ref dtWell,strSql,"tbDatas");
				
				this.dataGrid1.DataSource=dtWell.DefaultView;
			}
			catch(Exception ex)
			{
//				MessageBox.Show(ex.ToString());
			}
		}

		private void frmDatasEdit_Load(object sender, System.EventArgs e)
		{
			this.numStart.Maximum=23;
			this.numStart.Minimum=0;

			this.numStart.Value=0;

			this.numEnd.Maximum=23;
			this.numEnd.Minimum=0;

			this.numEnd.Value=23;

			dtb=DateTime.Parse(dtpFrom.Value.ToShortDateString()+" "+numStart.Value.ToString()+":00:00");
			dte=DateTime.Parse(dtpTo.Value.ToShortDateString()+" "+numEnd.Value.ToString()+":00:00");

			LoadTr();
			LoadDGtitle();
			
		}

		private bool NoRecordDataGrid()
		{
			return -1==dataGrid1.CurrentRowIndex;
		}

		private void btnDis_Click(object sender, System.EventArgs e)
		{
			if(this.trvWel.SelectedNode==null)
			{
				MessageBox.Show("请选中要进行统计的监测站或单位!");
				return;
			}
			if(!CheckDT())
			{
				MessageBox.Show("时间条件选择错误!");
				return;
			}		
			ReadDatas();
		}

		private void trvWel_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			if(this.trvWel.SelectedNode.Parent==null)
			{
				this.m_strSelNodeType="country";
				return;
			}
			else
			{
				this.m_strSelNodeType="zhan";
				return;
			}
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			frmDataEditItems f=new frmDataEditItems();
			f.ShowDialog();
			ReadDatas();
		}

		private void btnEdit_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(NoRecordDataGrid()) {return;}
			
				int row=dataGrid1.CurrentCell.RowNumber;
				int col=1;
				string Name=dataGrid1[row,col].ToString().Trim();
				string wValue=dataGrid1[row,3].ToString().Trim();
				DateTime dt=DateTime.Parse(dataGrid1[row,7].ToString().Trim());
				string wLL=dataGrid1[row,2].ToString().Trim();
				string editID=dataGrid1[row,0].ToString().Trim();
				frmDataEditItems f=new frmDataEditItems(Name,wValue,dt,wLL,editID);
				f.ShowDialog();
				ReadDatas();
			}
			catch
			{
			}
		}

		private void btnDel_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(NoRecordDataGrid()) {return;}
			
				int row=dataGrid1.CurrentCell.RowNumber;
				int col=0;
//				string Name=dataGrid1[row,col].ToString().Trim();
//				if(Name==null)
//				{
//					MessageBox.Show("请正确选择需要删除的数据行!","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
//					return ;
//				}
//
//				if(MessageBox.Show("确定要删除该行数据?","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question)!=DialogResult.Yes){	return ;}
//			
//				string delTime=dataGrid1[row,5].ToString().Trim();
//				string delamount=dataGrid1[row,2].ToString().Trim();
//				string strSql=string.Format("delete from waterDatas where name='{0}' and time='{1}' and amount='{2}'",Name,delTime,delamount);

				string DelID=dataGrid1[row,col].ToString().Trim();
				if(DelID==null)
				{
					MessageBox.Show("请正确选择需要删除的数据行!","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return ;
				}

				if(MessageBox.Show("确定要删除该行数据?","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question)!=DialogResult.Yes){	return ;}
				string strSql=string.Format("delete from waterDatas where ID='{0}'",DelID);
				BengZhan.CDBConnection.ExecuteSql(strSql);
				ReadDatas();
			}
			catch
			{
			}
		}
	}
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BengZhan.bengzhans
{
	/// <summary>
	/// frmBengZhans 的摘要说明。
	/// </summary>
	public class frmBengZhans : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListView lsvWell;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TreeView trvDep;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbCountry;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.Button btnSendCard;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ColumnHeader columnHeader13;
		private System.Windows.Forms.Button btnEditName;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmBengZhans()
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
			this.btnEditName = new System.Windows.Forms.Button();
			this.btnSendCard = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lsvWell = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.trvDep = new System.Windows.Forms.TreeView();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.cmbCountry = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnEditName);
			this.groupBox1.Controls.Add(this.btnSendCard);
			this.groupBox1.Controls.Add(this.btnExit);
			this.groupBox1.Controls.Add(this.btnPrint);
			this.groupBox1.Controls.Add(this.btnDel);
			this.groupBox1.Controls.Add(this.btnEdit);
			this.groupBox1.Controls.Add(this.btnAdd);
			this.groupBox1.Location = new System.Drawing.Point(208, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(448, 40);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// btnEditName
			// 
			this.btnEditName.Location = new System.Drawing.Point(264, 16);
			this.btnEditName.Name = "btnEditName";
			this.btnEditName.TabIndex = 6;
			this.btnEditName.Text = "修改名称";
			this.btnEditName.Visible = false;
			this.btnEditName.Click += new System.EventHandler(this.btnEditName_Click);
			// 
			// btnSendCard
			// 
			this.btnSendCard.Location = new System.Drawing.Point(232, 24);
			this.btnSendCard.Name = "btnSendCard";
			this.btnSendCard.TabIndex = 5;
			this.btnSendCard.Text = "发卡";
			this.btnSendCard.Visible = false;
			this.btnSendCard.Click += new System.EventHandler(this.btnSendCard_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(272, 12);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(72, 23);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(360, 8);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.TabIndex = 3;
			this.btnPrint.Text = "打印";
			this.btnPrint.Visible = false;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(176, 12);
			this.btnDel.Name = "btnDel";
			this.btnDel.TabIndex = 2;
			this.btnDel.Text = "删除";
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(88, 12);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.TabIndex = 1;
			this.btnEdit.Text = "修改";
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(8, 12);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "添加";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lsvWell);
			this.groupBox2.Location = new System.Drawing.Point(208, 40);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(800, 472);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// lsvWell
			// 
			this.lsvWell.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					  this.columnHeader1,
																					  this.columnHeader2,
																					  this.columnHeader3,
																					  this.columnHeader4,
																					  this.columnHeader5,
																					  this.columnHeader7,
																					  this.columnHeader8,
																					  this.columnHeader6,
																					  this.columnHeader9,
																					  this.columnHeader10,
																					  this.columnHeader11,
																					  this.columnHeader13});
			this.lsvWell.FullRowSelect = true;
			this.lsvWell.GridLines = true;
			this.lsvWell.Location = new System.Drawing.Point(8, 16);
			this.lsvWell.Name = "lsvWell";
			this.lsvWell.Size = new System.Drawing.Size(784, 448);
			this.lsvWell.TabIndex = 0;
			this.lsvWell.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "站编号";
			this.columnHeader1.Width = 92;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "站名称";
			this.columnHeader2.Width = 94;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "所属管理处名称";
			this.columnHeader3.Width = 126;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "GPRS号";
			this.columnHeader4.Width = 69;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "设备地址";
			this.columnHeader5.Width = 75;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "x坐标";
			this.columnHeader7.Width = 58;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "y坐标";
			this.columnHeader8.Width = 46;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "水价";
			this.columnHeader6.Width = 50;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "初始计费值";
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "控制器编号";
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "脉冲系数";
			// 
			// columnHeader13
			// 
			this.columnHeader13.Text = "报警下限";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.trvDep);
			this.groupBox3.Location = new System.Drawing.Point(8, 40);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(200, 472);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			// 
			// trvDep
			// 
			this.trvDep.ImageIndex = -1;
			this.trvDep.Location = new System.Drawing.Point(8, 8);
			this.trvDep.Name = "trvDep";
			this.trvDep.SelectedImageIndex = -1;
			this.trvDep.Size = new System.Drawing.Size(184, 456);
			this.trvDep.TabIndex = 0;
			this.trvDep.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvDep_AfterSelect);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.cmbCountry);
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Location = new System.Drawing.Point(8, 0);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(200, 40);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			// 
			// cmbCountry
			// 
			this.cmbCountry.Location = new System.Drawing.Point(80, 14);
			this.cmbCountry.Name = "cmbCountry";
			this.cmbCountry.Size = new System.Drawing.Size(112, 20);
			this.cmbCountry.TabIndex = 1;
			this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "管理局：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// frmBengZhans
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(1010, 520);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmBengZhans";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "监测站信息";
			this.Load += new System.EventHandler(this.frmBengZhans_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmBengZhans_Load(object sender, System.EventArgs e)
		{
			this.paintCountry();
			this.paintDep();
			//this.paintTvwDep();
 			this.paintFrm();
			
		}

		//填充treeview
		private void paintTvwDep()
		{
			try
			{
				string strSql="select townName from tbTown";
				DataTable dtTown=null;
				CDBConnection.getDataTable(ref dtTown,strSql,"tbTown");
				for(int i=0;i<dtTown.Rows.Count;i++)
				{
					string strTownName=dtTown.Rows[i]["townName"].ToString();
					this.trvDep.Nodes.Add(dtTown.Rows[i]["townName"].ToString());
					DataTable dtCountry=null;
					strSql=String.Format("select countryName from tbCountry where townName='{0}'",strTownName);
					CDBConnection.getDataTable(ref dtCountry,strSql,"tbCountry");

					for(int j=0;j<dtCountry.Rows.Count;j++)
					{
						this.trvDep.Nodes[i].Nodes.Add(dtCountry.Rows[j]["countryName"].ToString());
						string strCountryName=dtCountry.Rows[j]["countryName"].ToString();
						strSql=String.Format("select depShortName from tbDep where countryName='{0}'",strCountryName);
						DataTable dtDep=null;
						CDBConnection.getDataTable(ref dtDep,strSql,"dtDep");
						for(int z=0;z<dtDep.Rows.Count;z++)
						{
							this.trvDep.Nodes[i].Nodes[j].Nodes.Add(dtDep.Rows[z]["depShortName"].ToString());
						}
					}
				}

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		private void paintFrm()
		{
			try
			{
				if(this.trvDep.SelectedNode==null)
				{
					return;
				}
				else
				{
					if(this.trvDep.SelectedNode.Parent ==null)
					{
						return;			
					}					
				}

				string strDepName=this.trvDep.SelectedNode.Text.Trim();

				string strSql=String.Format("select wellNo,wellName,depName,gprsNo,watAddress,wellDes,x,y,price1,iniAmount,watchNo,xi,warnAmount,bjt from tbWell where depName='{0}' and not gprsNo is null and  bSal is null",strDepName);
				DataTable dtWell=null;
				CDBConnection.getDataTable(ref dtWell,strSql,"tbWell");
			
				this.lsvWell.Items.Clear();
				for(int i=0;i<dtWell.Rows.Count;i++)
				{
					this.lsvWell.Items.Add(dtWell.Rows[i]["wellNo"].ToString());
					this.lsvWell.Items[i].SubItems.Add(dtWell.Rows[i]["wellName"].ToString());
					this.lsvWell.Items[i].SubItems.Add(dtWell.Rows[i]["DepName"].ToString());
					this.lsvWell.Items[i].SubItems.Add(dtWell.Rows[i]["gprsNo"].ToString());
					string strAddress=dtWell.Rows[i]["watAddress"].ToString();
					int iAddress=Convert.ToInt32(strAddress);
					strAddress=iAddress.ToString("x");
					this.lsvWell.Items[i].SubItems.Add(strAddress);					
					this.lsvWell.Items[i].SubItems.Add(dtWell.Rows[i]["x"].ToString());
					this.lsvWell.Items[i].SubItems.Add(dtWell.Rows[i]["y"].ToString());
					
					if(dtWell.Rows[i]["bjt"].ToString()=="true")
					{		
						this.lsvWell.Items[i].SubItems.Add("应用阶梯水价");
					}	
					else
					{
						this.lsvWell.Items[i].SubItems.Add(dtWell.Rows[i]["price1"].ToString());
					}
					
					this.lsvWell.Items[i].SubItems.Add(dtWell.Rows[i]["iniAmount"].ToString());
					this.lsvWell.Items[i].SubItems.Add(dtWell.Rows[i]["watchNo"].ToString().Trim());
					this.lsvWell.Items[i].SubItems.Add(dtWell.Rows[i]["xi"].ToString());
		

					this.lsvWell.Items[i].SubItems.Add(dtWell.Rows[i]["warnAmount"].ToString().Trim());
				}

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

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			try
			{
				
				
				frmBengZhanEdit frmBengZhanEditObj=new frmBengZhanEdit();
				string strDepName="";
				if(this.trvDep.SelectedNode!=null)
				{
					if(this.trvDep.SelectedNode.Parent!=null)
					{									
						strDepName=this.trvDep.SelectedNode.Text.Trim();					
					}
				}
				if(strDepName=="")
				{
					MessageBox.Show("请选中监测站所属单位！");
					return;
				}
				frmBengZhanEditObj.m_strDepName=strDepName;
				frmBengZhanEditObj.ShowDialog();
				if(frmBengZhanEditObj.m_bInserted==true)
				{
					this.paintFrm();
				}

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnEdit_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.lsvWell.SelectedItems.Count==0)
				{
					MessageBox.Show("请选择需要修改的监测站信息！");
					return;
				}
				frmBengZhanEdit frmBengZhanEditObj=new frmBengZhanEdit();
				frmBengZhanEditObj.m_bEdit=true;
				frmBengZhanEditObj.m_strWellNo=this.lsvWell.SelectedItems[0].Text.Trim();
				frmBengZhanEditObj.ShowDialog();
				if(frmBengZhanEditObj.m_bInserted==true)
				{
					this.paintFrm();
				}


			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnDel_Click(object sender, System.EventArgs e)
		{
			try
			{

				if(MessageBox.Show("删除操作可能对数据统计造成影响，是否继续？","删除",MessageBoxButtons.OKCancel)!=DialogResult.OK)
				{
					return;
				}

				//return;

				if(this.lsvWell.SelectedItems.Count==0)
				{
					MessageBox.Show("请选中要删除的监测站！");
					return;
				}

				string strWellNo=this.lsvWell.SelectedItems[0].Text.Trim();

				string strSql=String.Format("select count(*) from (select * from tbWellAmount where wellNo='{0}' union select * from tbWellAmount where wellNo='{0}') temp",strWellNo);
				string strCount=CDBConnection.ExecuteScalar(strSql);
				
//				if(strCount!="")
//				{
//					int iCount=Convert.ToInt32(strCount);
//					if(iCount>0)
//					{
//						if(MessageBox.Show("流量信息表中已有该监测站的信息,继续操作将造成历史记录混乱，是否继续？","删除",MessageBoxButtons.OKCancel)!=DialogResult.OK)
//						{
//							return;
//						}
//
//					}
//				}

				strSql=String.Format("select count(*) from tbSal where wellNo='{0}'",strWellNo);
				strCount=CDBConnection.ExecuteScalar(strSql);
//				if(strCount!="")
//				{
//					int iCount=Convert.ToInt32(strCount);
//					if(iCount>0)
//					{
//						if(MessageBox.Show("售水历史记录表中已有该监测站的信息,继续操作将造成历史记录混乱，是否继续？","删除",MessageBoxButtons.OKCancel)!=DialogResult.OK)
//						{
//							return;
//						}
//
//					}
//				}


				strSql=String.Format("delete from tbWell where wellNo='{0}'",strWellNo);
				CDBConnection.ExecuteSql(strSql);	

				strSql=String.Format("delete from tbw_WellInfo where WellID='{0}'",strWellNo);
				CDBConnection.ExecuteSql(strSql);
//
				strSql=String.Format("insert into tbDel(tbNo,tbName) values('{0}','{1}')",strWellNo,"tbWell");
				CDBConnection.ExecuteSql(strSql);	
			
				this.paintFrm();



			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
		}

		private void trvDep_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			this.paintFrm();
		}

		private void btnPrint_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.lsvWell.SelectedItems.Count<=0)
				{
					MessageBox.Show("请选择要打印的监测站！");
					return;
				}

				DataTable dtDep=new DataTable();
				dtDep.Columns.Add(new DataColumn("field1"));
				dtDep.Columns.Add(new DataColumn("field2"));

				DataRow dr=dtDep.NewRow();
				dr["field1"]="监测站编码";
				dr["field2"]=this.lsvWell.SelectedItems[0].SubItems[0].Text;
				dtDep.Rows.Add(dr);

				dr=dtDep.NewRow();
				dr["field1"]="监测站名称";
				dr["field2"]=this.lsvWell.SelectedItems[0].SubItems[1].Text;
				dtDep.Rows.Add(dr);

				dr=dtDep.NewRow();
				dr["field1"]="所属单位";
				dr["field2"]=this.lsvWell.SelectedItems[0].SubItems[2].Text;
				dtDep.Rows.Add(dr);

				dr=dtDep.NewRow();
				dr["field1"]="GPRS号";
				dr["field2"]=this.lsvWell.SelectedItems[0].SubItems[3].Text;
				dtDep.Rows.Add(dr);

				dr=dtDep.NewRow();
				dr["field1"]="设备地址";
				dr["field2"]=this.lsvWell.SelectedItems[0].SubItems[4].Text;
				dtDep.Rows.Add(dr);

				dr=dtDep.NewRow();
				dr["field1"]="x坐标";
				dr["field2"]=this.lsvWell.SelectedItems[0].SubItems[5].Text;
				dtDep.Rows.Add(dr);				
				
				dr=dtDep.NewRow();
				dr["field1"]="y坐标";
				dr["field2"]=this.lsvWell.SelectedItems[0].SubItems[6].Text;
				dtDep.Rows.Add(dr);	

				dr=dtDep.NewRow();
				dr["field1"]="初始计费值";
				dr["field2"]=this.lsvWell.SelectedItems[0].SubItems[8].Text;
				dtDep.Rows.Add(dr);

				dr=dtDep.NewRow();
				dr["field1"]="控制器编号";
				dr["field2"]=this.lsvWell.SelectedItems[0].SubItems[9].Text;
				dtDep.Rows.Add(dr);

				dr=dtDep.NewRow();
				dr["field1"]="脉冲系数";
				dr["field2"]=this.lsvWell.SelectedItems[0].SubItems[10].Text;
				dtDep.Rows.Add(dr);

				dr=dtDep.NewRow();
				dr["field1"]="报警下限";
				dr["field2"]=this.lsvWell.SelectedItems[0].SubItems[11].Text;
				dtDep.Rows.Add(dr);

				dr=dtDep.NewRow();
				dr["field1"]="备注信息";
				dr["field2"]=this.lsvWell.SelectedItems[0].SubItems[7].Text;
				dtDep.Rows.Add(dr);	

				CDGPrintDll.frmDgPrint frmDgP=new CDGPrintDll.frmDgPrint();
				frmDgP.iniDgPrint(dtDep,"监测站信息表",System.DateTime.Now.ToString());

				frmDgP.print(false);
	
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		#region"画界面函数"
		private void paintCountry()
		{
			try
			{
				//绘制乡镇信息
				string strSql="select countryName from tbCountry";
				DataTable dtCountry=null;
				CDBConnection.getDataTable(ref dtCountry,strSql,"tbCountry");
				this.cmbCountry.Items.Clear();
				for(int i=0;i<dtCountry.Rows.Count;i++)
				{
					this.cmbCountry.Items.Add(dtCountry.Rows[i]["countryName"].ToString());
				}
				this.cmbCountry.Items.Add("");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		//单位
		private void paintDep()
		{
			try
			{
				string strSql="";
				if(this.cmbCountry.Text.Trim()=="")
				{
					strSql=String.Format("select depShortName from tbDep");					
				}
				else
				{
					strSql=String.Format("select depShortName from tbDep where CountryName='{0}'",this.cmbCountry.Text.Trim());
				}
				DataTable dtDep=null;

				CDBConnection.getDataTable(ref dtDep,strSql,"tbDep");

				this.trvDep.Nodes.Clear();
				this.trvDep.Nodes.Add("用水单位列表");

				for(int i=0;i<dtDep.Rows.Count;i++)
				{
					this.trvDep.Nodes[0].Nodes.Add(dtDep.Rows[i]["depShortName"].ToString());
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		#endregion

		private void cmbCountry_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.paintDep();
		}

		private void btnSendCard_Click(object sender, System.EventArgs e)
		{
			
			if(this.lsvWell.SelectedItems.Count<=0)
			{
				MessageBox.Show("请选择要发卡的监测站！");
				return;
			}
			this.Cursor=Cursors.WaitCursor;
			string strWellNo=this.lsvWell.SelectedItems[0].SubItems[0].Text.Trim();
			string strDepName=this.lsvWell.SelectedItems[0].SubItems[2].Text.Trim();

			BengZhan.icSal.frmIniCard frmIni=new BengZhan.icSal.frmIniCard();
			frmIni.m_WellNo=strWellNo;
			frmIni.m_DepName=strDepName;
 			frmIni.ShowDialog();
			this.Cursor=Cursors.Default;
		}

		private void btnEditName_Click(object sender, System.EventArgs e)
		{

			if(this.lsvWell.SelectedItems.Count<=0)
			{
				MessageBox.Show("请选择要发卡的监测站！");
				return;
			}
			
			string strWellNo=this.lsvWell.SelectedItems[0].SubItems[0].Text.Trim();		
			string strDepName=this.lsvWell.SelectedItems[0].SubItems[2].Text.Trim();

			frmZhan frmZO=new frmZhan();
			frmZO.m_strZhanNo=strWellNo;
			frmZO.ShowDialog();

			string strSql=string.Format("select depname from tbWell where wellNo='{0}'",strWellNo);
			string strWellName=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();

			cmbCountry_SelectedIndexChanged(null,null);

			for(int i=0;i<this.trvDep.Nodes[0].Nodes.Count;i++)
			{
				if(this.trvDep.Nodes[0].Nodes[i].Text.Trim().IndexOf(strWellName)>=0)				
				{
					this.trvDep.SelectedNode=this.trvDep.Nodes[0].Nodes[i];
				}
			}

			this.trvDep_AfterSelect(null,null);
					  
			

		}
	}
}

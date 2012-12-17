using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
namespace BengZhan.salWaterRep
{
	/// <summary>
	/// frm 的摘要说明。
	/// </summary>
	public class frmSalWaterRep : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDisp;
		private System.Windows.Forms.Button btnExit;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crpSalWater;
		private System.Windows.Forms.GroupBox grp1;
		private System.Windows.Forms.DateTimePicker dtpFrom;
		private System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbCountry;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TreeView trv;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmSalWaterRep()
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
			this.trv = new System.Windows.Forms.TreeView();
			this.crpSalWater = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnDisp = new System.Windows.Forms.Button();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbCountry = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.grp1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// grp1
			// 
			this.grp1.Controls.Add(this.trv);
			this.grp1.Location = new System.Drawing.Point(8, 64);
			this.grp1.Name = "grp1";
			this.grp1.Size = new System.Drawing.Size(224, 488);
			this.grp1.TabIndex = 0;
			this.grp1.TabStop = false;
			// 
			// trv
			// 
			this.trv.ImageIndex = -1;
			this.trv.Location = new System.Drawing.Point(8, 16);
			this.trv.Name = "trv";
			this.trv.SelectedImageIndex = -1;
			this.trv.Size = new System.Drawing.Size(208, 464);
			this.trv.TabIndex = 0;
			this.trv.Click += new System.EventHandler(this.trv_Click);
			this.trv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trv_AfterSelect);
			// 
			// crpSalWater
			// 
			this.crpSalWater.ActiveViewIndex = -1;
			this.crpSalWater.Location = new System.Drawing.Point(240, 64);
			this.crpSalWater.Name = "crpSalWater";
			this.crpSalWater.ReportSource = null;
			this.crpSalWater.ShowExportButton = false;
			this.crpSalWater.Size = new System.Drawing.Size(536, 456);
			this.crpSalWater.TabIndex = 1;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnExit);
			this.groupBox2.Controls.Add(this.btnDisp);
			this.groupBox2.Controls.Add(this.dtpTo);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.dtpFrom);
			this.groupBox2.Location = new System.Drawing.Point(240, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(488, 48);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(400, 17);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnDisp
			// 
			this.btnDisp.Location = new System.Drawing.Point(296, 17);
			this.btnDisp.Name = "btnDisp";
			this.btnDisp.TabIndex = 3;
			this.btnDisp.Text = "统计报表";
			this.btnDisp.Click += new System.EventHandler(this.btnDisp_Click);
			// 
			// dtpTo
			// 
			this.dtpTo.Location = new System.Drawing.Point(176, 16);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(96, 21);
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
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbCountry);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(224, 48);
			this.groupBox1.TabIndex = 3;
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
			// frmSalWaterRep
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(832, 542);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.crpSalWater);
			this.Controls.Add(this.grp1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmSalWaterRep";
			this.Text = "售水情况";
			this.Load += new System.EventHandler(this.frmSalWaterRep_Load);
			this.grp1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmSalWaterRep_Load(object sender, System.EventArgs e)
		{
			this.dtpTo.Value=this.dtpFrom.Value.AddDays(1);
			this.paintFrmSize();
			tools.CPaintForm.paintCountry(this.cmbCountry);
			this.paintTrvWell();
			this.paintReport("","");

		}
		//填充窗体控件
		private void paintFrmSize()
		{
			try
			{
				this.grp1.Height=this.Height-this.grp1.Top-40;
				this.trv.Height=this.grp1.Height-25;
				this.crpSalWater.Width=this.Width-this.crpSalWater.Left-20;
				this.crpSalWater.Height=this.Height-this.crpSalWater.Top-40;
				this.crpSalWater.DisplayGroupTree=false;

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		//
		private  bool paintTrvWell()
		{
			try
			{
				this.trv.Nodes.Clear();

				tools.CPaintForm.paintWell(this.cmbCountry.Text,this.trv);
				
				this.trv.Nodes.Add("所有操作员");
				string strSql="select userName from tbUsers";
				DataTable dt=null;
				CDBConnection.getDataTable(ref dt,strSql,"tbUsers");

				for(int i=0;i<dt.Rows.Count;i++)
				{
					this.trv.Nodes[1].Nodes.Add(dt.Rows[i]["userName"].ToString());
				}
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}
		//
		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		
		private void dtpTo_ValueChanged(object sender, System.EventArgs e)
		{
			//this.paintReport();
		}

		private void dtpFrom_ValueChanged(object sender, System.EventArgs e)
		{
			//this.paintReport();
		}

		private void trv_Click(object sender, System.EventArgs e)
		{
			//this.paintReport();
		}		
		private void btnDisp_Click(object sender, System.EventArgs e)
		{

			this.paintReport();	
		}

		private void trv_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			//this.paintReport();			
		}
		// 报表显示
		private void paintReport()
		{
			try
			{
				string strWellNo="";
				string strManaName="";

				if(this.trv.SelectedNode!=null)
				{
					string strNText=this.trv.SelectedNode.Text;
					if(strNText.IndexOf("|")>0)
					{
						strWellNo=strNText.Substring(0,strNText.IndexOf("|"));
					}
					else
					{
						if(this.trv.SelectedNode.Parent!=null)
						{
							strManaName=this.trv.SelectedNode.Text.Trim();
						}
					}
				}
				if(strWellNo.Trim()!="")
				{
					this.paintReport(strWellNo,"");
					return;
				}
				if(strManaName.Trim()!="")
				{
					//操作员统计
					this.paintReport("",strManaName);
					return;
				}
				//未选择监测站,显示所有
				this.paintReport("","");			
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void cmbCountry_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.paintTrvWell();
		}
		//*******************数据库操作区*****************
		#region"数据库查询"
/// <summary>
/// 已审
/// </summary>
/// <param name="strWellNo">监测站编号</param>
/// <param name="strUserName">操作员名称</param>
		private void paintReport(string strWellNo,string strUserName)
		{
			try
			{
				string strFrom=String.Format("{0}-{1}-{2}",this.dtpFrom.Value.Year.ToString(),this.dtpFrom.Value.Month.ToString(),this.dtpFrom.Value.Day.ToString());
				string strTo=String.Format("{0}-{1}-{2}",this.dtpTo.Value.Year.ToString(),this.dtpTo.Value.Month.ToString(),this.dtpTo.Value.Day.ToString());
				string strTitle="";
				
				
				//监测站统计sql1******************************sql语句
				string strSql=String.Format("select tbSal.wellNo as Field1,depName as Field2,price as Field3,salMony as Field4,salAmount as Field5,salPer as Field6,time as Field7 from tbSal,tbWell where (cast(floor(cast(time as float)) as datetime) between '{0}' and '{1}') and tbSal.wellNo=tbWell.wellNo and tbSal.wellNo='{2}' order by time",strFrom,strTo,strWellNo);
				strTitle="单位购水统计表";
				if(strWellNo.Trim()=="")
				{
					if(strUserName.Trim()=="")
					{
						//无查询条件sql2
						strSql=String.Format("select tbSal.wellNo as Field1,depName as Field2,price as Field3,salMony as Field4,salAmount as Field5,salPer as Field6,time as Field7 from tbSal,tbWell where (cast(floor(cast(time as float)) as datetime) between '{0}' and '{1}') and tbSal.wellNo=tbWell.wellNo order by time",strFrom,strTo);						
					}
					else
					{						
						//操作员统计sql3*****
						strSql=String.Format("select tbSal.wellNo as Field1,depName as Field2,price as Field3,salMony as Field4,salAmount as Field5,salPer as Field6,time as Field7 from tbSal,tbWell where (cast(floor(cast(time as float)) as datetime) between '{0}' and '{1}') and tbSal.wellNo=tbWell.wellNo and tbSal.salPer='{2}' order by time",strFrom,strTo,strUserName);
						strTitle="操作员售水统计表";
					}
					
				}
				//**************************************

				
				//统计合计
				DataTable dt=null;
				CDBConnection.getDataTable(ref dt,strSql,"tbSalWater");				
				double iSalAmount=0,iSalMony=0;
				for(int i=0;i<dt.Rows.Count;i++)
				{
					iSalAmount=iSalAmount+Convert.ToDouble(dt.Rows[i]["Field5"]);
					iSalMony=iSalMony+Convert.ToDouble(dt.Rows[i]["Field4"]);
				}
				DataRow dr=dt.NewRow();
				dr["Field1"]="合计";
				dr["Field4"]=iSalMony.ToString();
				dr["Field5"]=iSalAmount.ToString();
				dt.Rows.Add(dr);
				//************************

				//报表显示
				string strTime=String.Format("时间范围：{0}至{1}",strFrom,strTo);
				string[] strText=new string[7];
				strText[0]="监测站编号";
				strText[1]="单位名称";
				strText[2]="售水单价";
				strText[3]="售水金额";
				strText[4]="售水量";
				strText[5]="售水人";
				strText[6]="售水时间";

				printDoc.crpPrint crpPrintObj=new BengZhan.printDoc.crpPrint();
				CrystalDecisions.CrystalReports.Engine.TextObject toTitle=(CrystalDecisions.CrystalReports.Engine.TextObject)crpPrintObj.ReportDefinition.ReportObjects["txtTime"];
				toTitle.Text=strTime;
				toTitle=(CrystalDecisions.CrystalReports.Engine.TextObject)crpPrintObj.ReportDefinition.ReportObjects["txtTitle"];
				if(strTitle!="")
				{
					toTitle.Text=strTitle;
				}				
				for(int i=0;i<7;i++)
				{
					int iNum=i+1;
					string strTextTitle="Text"+iNum.ToString();
					CrystalDecisions.CrystalReports.Engine.TextObject to=(CrystalDecisions.CrystalReports.Engine.TextObject)crpPrintObj.ReportDefinition.ReportObjects[strTextTitle];					
					to.Text=strText[i].ToString();
				}	
						
				crpPrintObj.SetDataSource(dt);
				this.crpSalWater.ReportSource=crpPrintObj;


			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		#endregion
		//************************************************


	}
}

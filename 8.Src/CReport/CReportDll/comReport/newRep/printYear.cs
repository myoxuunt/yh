using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml ;
using System.Data ;

namespace CReportDll.comReport.newRep
{
	/// <summary>
	/// frmPrint 的摘要说明。
	/// </summary>
	public class frmPrintYear : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.DataGrid dgPrint;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		private  System.Windows.Forms.DataGrid dataGrid1;
		public System.Windows.Forms.DataGrid dataGrid2;
		public System.Windows.Forms.DataGrid dataGrid3;
		public	System.Windows.Forms.DataGrid dataGrid4;
		private System.Windows.Forms.CheckBox checkBox2;
		public System.Windows.Forms.DataGrid dataGrid5;

		public frmPrintYear()
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
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.dgPrint = new System.Windows.Forms.DataGrid();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgPrint)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(256, 104);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// checkBox3
			// 
			this.checkBox3.Location = new System.Drawing.Point(24, 64);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(224, 24);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "checkBox3";
			this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(24, 32);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(224, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "checkBox1";
			this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(120, 112);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(64, 23);
			this.btnPrint.TabIndex = 1;
			this.btnPrint.Text = "打印";
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(192, 112);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(64, 24);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// dgPrint
			// 
			this.dgPrint.DataMember = "";
			this.dgPrint.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgPrint.Location = new System.Drawing.Point(0, 112);
			this.dgPrint.Name = "dgPrint";
			this.dgPrint.TabIndex = 3;
			this.dgPrint.Visible = false;
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(24, 64);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(224, 24);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "checkBox2";
			this.checkBox2.Visible = false;
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// frmPrintYear
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(258, 143);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgPrint);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmPrintYear";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "选择打印项";
			this.Load += new System.EventHandler(this.frmPrint_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgPrint)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnPrint_Click(object sender, System.EventArgs e)
		{
			int iCount=0;
			if(this.checkBox1.Checked)
			{
				iCount++;
			}
			if(this.checkBox2.Checked )
			{
				iCount++;
			}
			if(this.checkBox3.Checked )
			{
				iCount++;
			}

			if(iCount<1)
			{
				MessageBox.Show("请选中要打印的表!");
				return;
			}
			if(iCount>1)
			{
				MessageBox.Show("一次只能打印一张表!");
				return;
			}
			int iDex=0;
			if(this.checkBox1.Checked)
			{
				this.dataGrid1=this.dataGrid2;
				iDex=1;
			}
			if(this.checkBox2.Checked)
			{
				this.dataGrid1=this.dataGrid3 ;
				iDex=2;
			}
			if(this.checkBox3.Checked)
			{
				this.dataGrid1=this.dataGrid4;
				iDex=3;
			}	

			this.print(iDex);

		}

		private System.Xml.XmlDocument m_xDocPrint;

		private void print(int iDex)
		{
			try
			{
				DataTable dtZ=(DataTable)this.dataGrid1.DataSource;
				if(dtZ==null)
				{
					MessageBox.Show("没有可打印数据！");
					return;
				}
				if(dtZ.Rows.Count==0)
				{
					MessageBox.Show("没有可打印数据！");
					return;
					
				}
				if(this.m_xDocPrint==null)
				{
					this.m_xDocPrint=new XmlDocument();
					this.m_xDocPrint.Load("iniRepP.xml");
				}

				XmlNode xNode=this.m_xDocPrint.DocumentElement.SelectSingleNode(string.Format("./report[@name='tb{0}']",iDex.ToString()));

				DataGridTableStyle dgts=new DataGridTableStyle();
				DataTable dt=new DataTable();
				for(int i=0;i<xNode.ChildNodes.Count;i++)
				{
					string strField=xNode.ChildNodes[i].Attributes.GetNamedItem("field").Value.Trim();
					string strHeader=xNode.ChildNodes[i].Attributes.GetNamedItem("text").Value.Trim();
					string strWidth=xNode.ChildNodes[i].Attributes.GetNamedItem("width").Value.Trim();

					dt.Columns.Add(strField);
					
					DataGridColoredTextBoxColumn dgtc=new DataGridColoredTextBoxColumn();
					dgtc.Width=int.Parse(strWidth);
					dgtc.HeaderText=strHeader;
					dgtc.MappingName=strField;
					dgts.GridColumnStyles.Add(dgtc);

				}
				this.dgPrint.TableStyles.Clear();
				this.dgPrint.TableStyles.Add(dgts);
				this.dgPrint.DataSource=dt;

				for(int i=0;i<this.dgPrint.TableStyles[0].GridColumnStyles.Count;i++)
				{
					this.dgPrint.TableStyles[0].GridColumnStyles[i].HeaderText="text"+i.ToString();
					this.dgPrint.TableStyles[0].GridColumnStyles[i].MappingName="field"+i.ToString();
				}

				for(int i=0;i<this.dataGrid1.TableStyles[0].GridColumnStyles.Count;i++)
				{
					this.dgPrint.TableStyles[0].GridColumnStyles[i].MappingName=this.dataGrid1.TableStyles[0].GridColumnStyles[i].MappingName;
					this.dgPrint.TableStyles[0].GridColumnStyles[i].HeaderText=this.dataGrid1.TableStyles[0].GridColumnStyles[i].HeaderText;
				}

				DataTable dtPrint=(DataTable)this.dgPrint.DataSource;
				DataTable dtDetail=(DataTable)this.dataGrid1.DataSource;

				for(int i=0;i<dtDetail.Rows.Count;i++)
				{
					dtPrint.ImportRow(dtDetail.Rows[i]);
				}						 
				this.clearBlankRow(dtPrint);

				string strTitle=this.dataGrid1.CaptionText.Trim();

				if(strTitle.Trim()!="")
				{
					int iStart=strTitle.LastIndexOf(" ");
					string strTitleEx=strTitle.Substring(iStart);
					strTitle=strTitle.Substring(0,iStart);

					cutePrint.cutePrinter dgp=new cutePrint.cutePrinter(this.dgPrint,strTitleEx.Trim(),30);
				
					int iTimeMinus=int.Parse(xNode.Attributes.GetNamedItem("iTimeMinus").Value.Trim());
					dgp.iTimeMinus=iTimeMinus;
					dgp.leftMargin=int.Parse(xNode.Attributes.GetNamedItem("leftMargin").Value.Trim());
					dgp.strTitle=strTitle.Trim();
					dgp.Print();
				}
				else
				{
					cutePrint.cutePrinter dgp=new cutePrint.cutePrinter(this.dgPrint,xNode.Attributes.GetNamedItem("title").Value.Trim(),30);
				
					int iTimeMinus=int.Parse(xNode.Attributes.GetNamedItem("iTimeMinus").Value.Trim());
					dgp.iTimeMinus=iTimeMinus;
					dgp.leftMargin=int.Parse(xNode.Attributes.GetNamedItem("leftMargin").Value.Trim());
					dgp.strTitle=" ";
					dgp.Print();
				}
	
			

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}			
		}

		private void clearBlankRow(DataTable dt)
		{
			if(dt.Rows.Count==1)
			{
				return;
			}
			for(int i=0;i<dt.Rows.Count;i++)
			{
				bool bDel=true;
				for(int j=0;j<dt.Columns.Count;j++)
				{
					if(dt.Rows[i][j]==null)
					{						
						continue;
					}
					if(dt.Rows[i][j].ToString().Trim()=="")
					{
						continue;
					}
					bDel=false;
				}
				if(bDel)
				{
					dt.Rows.RemoveAt(i);
					i--;
				}
			}
		}

		private void frmPrint_Load(object sender, System.EventArgs e)
		{
			try
			{
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("iniRepP.xml");

				string strTitle=xDoc.DocumentElement.SelectSingleNode("./report[@name='tbn']").Attributes.GetNamedItem("title").Value.Trim() ;
				this.checkBox1.Text=strTitle;
				strTitle=xDoc.DocumentElement.SelectSingleNode("./report[@name='tb2']").Attributes.GetNamedItem("title").Value.Trim() ;
				this.checkBox2.Text=strTitle;
				strTitle=xDoc.DocumentElement.SelectSingleNode("./report[@name='tb3']").Attributes.GetNamedItem("title").Value.Trim() ;
				this.checkBox3.Text=strTitle;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void checkBox1_Click(object sender, System.EventArgs e)
		{
			

		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.checkBox2.Checked==true)
			{
				this.checkBox1.Checked=false;
				this.checkBox3.Checked=false;
				
			}
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.checkBox1.Checked==true)
			{
				this.checkBox2.Checked=false;
				this.checkBox3.Checked=false;
				
			}
		}

		private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.checkBox3.Checked==true)
			{
				this.checkBox2.Checked=false;
				this.checkBox1.Checked=false;
				
			}
		}

		private void checkBox4_CheckedChanged(object sender, System.EventArgs e)
		{
		}
	}
}

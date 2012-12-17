using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace BengZhan.warn
{
	/// <summary>
	/// frmSetWarnLev 的摘要说明。
	/// </summary>
	public class frmSetWarnLev : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnCer;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtZhanName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtParamName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtILow;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtIHigh;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public string m_strIHigh;
		public string m_strILow;
		public string m_strZhanName;
		public string m_strParamName;

		public frmSetWarnLev()
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
			this.txtIHigh = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtILow = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtParamName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtZhanName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCer = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtIHigh);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtILow);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtParamName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtZhanName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(288, 152);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// txtIHigh
			// 
			this.txtIHigh.Location = new System.Drawing.Point(144, 120);
			this.txtIHigh.Name = "txtIHigh";
			this.txtIHigh.Size = new System.Drawing.Size(112, 21);
			this.txtIHigh.TabIndex = 7;
			this.txtIHigh.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 119);
			this.label4.Name = "label4";
			this.label4.TabIndex = 6;
			this.label4.Text = "报警上限：";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtILow
			// 
			this.txtILow.Location = new System.Drawing.Point(144, 88);
			this.txtILow.Name = "txtILow";
			this.txtILow.Size = new System.Drawing.Size(112, 21);
			this.txtILow.TabIndex = 5;
			this.txtILow.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 87);
			this.label3.Name = "label3";
			this.label3.TabIndex = 4;
			this.label3.Text = "报警下限：";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtParamName
			// 
			this.txtParamName.Location = new System.Drawing.Point(144, 56);
			this.txtParamName.Name = "txtParamName";
			this.txtParamName.ReadOnly = true;
			this.txtParamName.Size = new System.Drawing.Size(112, 21);
			this.txtParamName.TabIndex = 3;
			this.txtParamName.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 55);
			this.label2.Name = "label2";
			this.label2.TabIndex = 2;
			this.label2.Text = "参数名称：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtZhanName
			// 
			this.txtZhanName.Location = new System.Drawing.Point(144, 24);
			this.txtZhanName.Name = "txtZhanName";
			this.txtZhanName.ReadOnly = true;
			this.txtZhanName.Size = new System.Drawing.Size(112, 21);
			this.txtZhanName.TabIndex = 1;
			this.txtZhanName.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 24);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "站名称：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCer
			// 
			this.btnCer.Location = new System.Drawing.Point(120, 168);
			this.btnCer.Name = "btnCer";
			this.btnCer.TabIndex = 1;
			this.btnCer.Text = "确定";
			this.btnCer.Click += new System.EventHandler(this.btnCer_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(216, 168);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// frmSetWarnLev
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(304, 197);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnCer);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSetWarnLev";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "报警参数设定";
			this.Load += new System.EventHandler(this.frmSetWarnLev_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmSetWarnLev_Load(object sender, System.EventArgs e)
		{
			this.txtIHigh.Text =this.m_strIHigh ;
			this.txtILow.Text=this.m_strILow ;
			this.txtParamName.Text=this.m_strParamName;
			this.txtZhanName.Text=this.m_strZhanName;	
			paintFrm();
		}

		private void paintFrm()
		{
			try
			{
				string strSql=string.Format("select paramType from tbWarnDes where paramDes='{0}'",this.m_strParamName);
				string strParamType=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();
     
				if(strParamType=="string")
				{
					this.label4.Visible=false;
					this.txtIHigh.Visible=false;
					this.label3.Text="报警值：";
					this.groupBox1.Height=this.groupBox1.Height-25;
					this.btnCer.Location=new Point(this.btnCer.Location.X,this.btnCer.Location.Y-25);
					this.btnExit.Location=new Point(this.btnExit.Location.X,this.btnExit.Location.Y-25);
					this.Height=this.Height-25;
					strSql=string.Format("select trueVal from tbWarn,tbWell,tbWarnDes where wellName='{0}' and paramDes='{1}' and tbWell.wellNo=tbWarn.wellNo and tbWarn.paramName=tbWarnDes.paramName",this.m_strZhanName,this.m_strParamName);
					this.txtILow.Text=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();
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

		private bool setParamVal()
		{
			try{

				if(this.label4.Visible!=false)
				{
					return true;
				}

				string strSql=String.Format("update tbWarn  set trueVal='{0}' from tbWarn,tbWarnDes where tbWarn.wellNo =(select wellNo from tbWell where wellName='{1}') and tbWarnDes.paramDes='{2}' and tbWarn.paramName=tbWarnDes.paramName",this.txtILow.Text.Trim(),this.m_strZhanName,this.m_strParamName);
				if(BengZhan.CDBConnection.ExecuteSql(strSql)==false)
				{
					return false;
				}

				if(this.txtILow.Text.Trim()!="")				
				{
					string strFormula=string.Format("''{0}''!=''{1}''","{0}",this.txtILow.Text.Trim());
					strSql=string.Format("update tbWarn set formula='{0}' from tbWarn,tbWarnDes where tbWarn.paramName=tbWarnDes.paramName and tbWarn.wellNo=(select wellNo from tbWell where wellName='{1}') and tbWarnDes.paramDes='{2}'",strFormula,this.m_strZhanName,this.m_strParamName);
					BengZhan.CDBConnection.ExecuteSql(strSql);
				}		
				else
				{
					string strFormula=string.Format("");
					strSql=string.Format("update tbWarn set formula='{0}' from tbWarn,tbWarnDes where tbWarn.paramName=tbWarnDes.paramName and tbWarn.wellNo=(select wellNo from tbWell where wellName='{1}') and tbWarnDes.paramDes='{2}'",strFormula,this.m_strZhanName,this.m_strParamName);
					BengZhan.CDBConnection.ExecuteSql(strSql);
				}

				MessageBox.Show("报警参数设置成功，新的报警参数将在系统重新启动后启用！");
				this.Close();

				return false;
			}
			catch(Exception ex)
			
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}

		private void btnCer_Click(object sender, System.EventArgs e)
		{

			if(!this.setParamVal())
			{
				return;
			}

			string strILow="";
			if(this.txtILow.Text.Trim()!="")
			{
				try
				{
					double dILow=Convert.ToDouble(this.txtILow.Text.Trim());
					strILow=dILow.ToString();
				}
				catch(Exception ex)
				{
					MessageBox.Show("报警下限不是有效数据！");
					return;
				}				
			}
			string strIHigh="";
			if(this.txtIHigh.Text.Trim()!="")
			{
				try
				{
					double dIHigh=Convert.ToDouble(this.txtIHigh.Text.Trim());
					strIHigh=dIHigh.ToString();

				}
				catch(Exception ex)
				{
					MessageBox.Show("报警上限不是有效数字！");
					return;
				}
			}
		
			string strSql=String.Format("update tbWarn set ilow='{0}',iHigh='{1}' from tbWarn,tbWarnDes where tbWarn.paramName=tbWarnDes.paramName and tbWarn.wellNo =(select wellNo from tbWell where wellName='{2}') and tbWarnDes.paramDes='{3}'",this.txtILow.Text.Trim(),this.txtIHigh.Text.Trim(),this.txtZhanName.Text.Trim(),this.txtParamName.Text.Trim());
			if(BengZhan.CDBConnection.ExecuteSql(strSql)==false)
			{
				return;
			}

			string strFormula="";

			if(this.txtILow.Text.Trim()!="")
			{
				strFormula=string.Format("{0}>{1}","{0}",this.txtILow.Text.Trim());
			}

			if(this.txtIHigh.Text.Trim()!="")
			{
				if(strFormula!="")
				{
					strFormula=string.Format("{0}&&{1}<{2}",strFormula,"{0}",this.txtIHigh.Text.Trim());
				}
				else
				{
					strFormula=string.Format("{1}<{2}","{0}",this.txtIHigh.Text.Trim());
				}
			}
       
			strSql=string.Format("update tbWarn set formula='{0}' from tbWarn,tbWarnDes where tbWarn.paramName=tbWarnDes.paramName and tbWarn.wellNo=(select wellNo from tbWell where wellName='{1}') and tbWarnDes.paramDes='{2}'",strFormula,this.m_strZhanName,this.m_strParamName);

			BengZhan.CDBConnection.ExecuteSql(strSql);

		
			MessageBox.Show("报警参数设置成功，新的报警参数将在系统重新启动后启用！");
			this.Close();
		}

	}
}

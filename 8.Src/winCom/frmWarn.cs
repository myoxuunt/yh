using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;


namespace winCom
{
	/// <summary>
	/// frmWarn 的摘要说明。
	/// </summary>
	public class frmWarn : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnCer;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmWarn()
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
			this.btnCer = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCer
			// 
			this.btnCer.Location = new System.Drawing.Point(200, 176);
			this.btnCer.Name = "btnCer";
			this.btnCer.TabIndex = 0;
			this.btnCer.Text = "确定";
			this.btnCer.Click += new System.EventHandler(this.btnCer_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(280, 120);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// frmWarn
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 221);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCer);
			this.Name = "frmWarn";
			this.Text = "通讯异常站";
			this.Load += new System.EventHandler(this.frmWarn_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnCer_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		public ArrayList m_arr=new ArrayList();	

		private void frmWarn_Load(object sender, System.EventArgs e)
		{
			string str="";

			if(this.m_arr==null)
			{
				this.Close();
				return;
			}

			for(int i=0;i<this.m_arr.Count;i++)
			{
				str+=this.m_arr[i].ToString();
			}

			this.m_arr.Clear();

			this.label1.Text=str;
		}
	}
}

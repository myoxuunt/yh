using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;

namespace BengZhan.warn.onTimeSet
{
	/// <summary>
	/// frmTime 的摘要说明。
	/// </summary>
	public class frmTime : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.NumericUpDown numMin;
		private System.Windows.Forms.NumericUpDown numHour;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTime()
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
			this.btnAdd = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.numMin = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.numHour = new System.Windows.Forms.NumericUpDown();
			this.btnExit = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numHour)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(88, 80);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(72, 23);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "添加";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numMin);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.numHour);
			this.groupBox1.Location = new System.Drawing.Point(16, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(232, 56);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// numMin
			// 
			this.numMin.Location = new System.Drawing.Point(184, 21);
			this.numMin.Maximum = new System.Decimal(new int[] {
																   23,
																   0,
																   0,
																   0});
			this.numMin.Name = "numMin";
			this.numMin.Size = new System.Drawing.Size(32, 21);
			this.numMin.TabIndex = 7;
			this.numMin.Value = new System.Decimal(new int[] {
																 8,
																 0,
																 0,
																 0});
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(128, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "分钟：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(20, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "小时：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numHour
			// 
			this.numHour.Location = new System.Drawing.Point(80, 22);
			this.numHour.Maximum = new System.Decimal(new int[] {
																	23,
																	0,
																	0,
																	0});
			this.numHour.Name = "numHour";
			this.numHour.Size = new System.Drawing.Size(40, 21);
			this.numHour.TabIndex = 4;
			this.numHour.Value = new System.Decimal(new int[] {
																  8,
																  0,
																  0,
																  0});
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(168, 80);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(64, 23);
			this.btnExit.TabIndex = 6;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// frmTime
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(274, 111);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnAdd);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTime";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "添加招测时间";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numHour)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			XmlDocument xDoc=new XmlDocument();
			xDoc.Load("timer.xml");

			for(int i=0;i<xDoc.DocumentElement.ChildNodes.Count;i++)
			{
				XmlNode xNode=xDoc.DocumentElement.ChildNodes[i];
				string strHour=xNode.Attributes.GetNamedItem("hour").Value.ToString().Trim();
				string strMin=xNode.Attributes.GetNamedItem("min").Value.ToString().Trim();

				if(strHour==this.numHour.Value.ToString().Trim())
				{
					if(strMin==this.numMin.Value.ToString().Trim())
					{
						MessageBox.Show("该时间已存在！");
						return;
					}
				}
			}		

			string strInfo=String.Format(@"<time index='1' hour='{0}' min='{1}' sendHour='' sendMin='' sendDay=''></time>",this.numHour.Value.ToString().Trim(),this.numMin.Value.ToString().Trim());
			xDoc.DocumentElement.InnerXml=xDoc.DocumentElement.InnerXml+strInfo;
			xDoc.Save("timer.xml");

			MessageBox.Show("添加成功，新的设置将在软件重新启动后生效！");
			this.Close();
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}

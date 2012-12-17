using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace WindowsApplication23
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtB;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtI;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtH;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtN;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtM;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtQ;
		private System.Windows.Forms.Button btnCom;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
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
				if (components != null) 
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtB = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtI = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtH = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtN = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtM = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtQ = new System.Windows.Forms.TextBox();
			this.btnCom = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "底宽b:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtB
			// 
			this.txtB.Location = new System.Drawing.Point(88, 32);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(64, 21);
			this.txtB.TabIndex = 1;
			this.txtB.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "底坡i:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtI
			// 
			this.txtI.Location = new System.Drawing.Point(88, 64);
			this.txtI.Name = "txtI";
			this.txtI.Size = new System.Drawing.Size(64, 21);
			this.txtI.TabIndex = 3;
			this.txtI.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(168, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "水深H:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtH
			// 
			this.txtH.Location = new System.Drawing.Point(224, 32);
			this.txtH.Name = "txtH";
			this.txtH.TabIndex = 5;
			this.txtH.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(160, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "糙率n:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtN
			// 
			this.txtN.Location = new System.Drawing.Point(224, 64);
			this.txtN.Name = "txtN";
			this.txtN.TabIndex = 7;
			this.txtN.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(0, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "边坡m:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtM
			// 
			this.txtM.Location = new System.Drawing.Point(80, 96);
			this.txtM.Name = "txtM";
			this.txtM.Size = new System.Drawing.Size(72, 21);
			this.txtM.TabIndex = 9;
			this.txtM.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(168, 104);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "流量Q:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtQ
			// 
			this.txtQ.Location = new System.Drawing.Point(224, 96);
			this.txtQ.Name = "txtQ";
			this.txtQ.Size = new System.Drawing.Size(104, 21);
			this.txtQ.TabIndex = 11;
			this.txtQ.Text = "";
			// 
			// btnCom
			// 
			this.btnCom.Location = new System.Drawing.Point(184, 152);
			this.btnCom.Name = "btnCom";
			this.btnCom.Size = new System.Drawing.Size(56, 23);
			this.btnCom.TabIndex = 12;
			this.btnCom.Text = "计算";
			this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(248, 152);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(64, 24);
			this.btnExit.TabIndex = 13;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(64, 144);
			this.button1.Name = "button1";
			this.button1.TabIndex = 14;
			this.button1.Text = "button1";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(344, 189);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnCom);
			this.Controls.Add(this.txtQ);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtM);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtN);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtH);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtI);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnCom_Click(object sender, System.EventArgs e)
		{
			//底坡
			double dI=0;

			if(this.txtI.Text.Trim()!="")
			{
				dI=double.Parse(this.txtI.Text.Trim());
			}

			//底宽
			double dB=0;

			if(this.txtB.Text.Trim()!="")
			{
				dB=double.Parse(this.txtB.Text.Trim());
			}

			//水深
			double dH=0;

			if(this.txtH.Text.Trim()!="")
			{
				dH=double.Parse(this.txtH.Text.Trim());
			}
			
			//糙率
			double dN=0;

			if(this.txtN.Text.Trim()!="")
			{
				dN=double.Parse(this.txtN.Text.Trim());
			}

			//边坡系数
			double dM=0;

			if(this.txtM.Text.Trim()!="")
			{
				dM=double.Parse(this.txtM.Text.Trim());
			}
			
			double dA=(dB+dM*dH)*dH; //过水断面积

			double dX=dB+2*dH*System.Math.Sqrt(1+System.Math.Pow(dM,2)); //湿周

			double dR=dA/dX ;   //水利半径

			double dC=System.Math.Pow(dR,1/6)/dN;

			Console.WriteLine(dC.ToString());

			double dQ=dA*dC*System.Math.Sqrt(dR*dI);		

			this.txtQ.Text=dQ.ToString();

			Console.WriteLine("da "+dA.ToString());
			Console.WriteLine("dX "+dX.ToString());
			Console.WriteLine("dr "+dR.ToString());
			Console.WriteLine("dC "+dC.ToString());


		}

		private void button1_Click(object sender, System.EventArgs e)
		{
				double dC=System.Math.Pow(0.92,1/6)/0.025;
			MessageBox.Show(dC.ToString());
		}
	}
}

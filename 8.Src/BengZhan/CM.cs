using System;
using System.Windows;
using System.Windows.Forms ;
using System.Data;
using System.Data.SqlClient;

namespace BengZhan
{
	/// <summary>
	/// CM 的摘要说明。
	/// </summary>
	public class CM
	{
		public CM()
		{			
		}
		[STAThread]

		static void Main() 
		{
			try
			{
//				decApp.CDecApp cda=new decApp.CDecApp();
//
//				if(cda.PrevInstance())
//				{
//					MessageBox.Show("本系统已运行!");
//					return;
//				}

				Application.Run(new BengZhan.Form1());
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
		}

		private static void openCon()
		{
			string strCon=@"server=tsxd-fbto7jl3fu\watersysclient;database=dbbengzhan;uid=sa;pwd=sa";
			SqlConnection sCon=new SqlConnection(strCon);
			sCon.Open();
			BengZhan.CDBConnection.m_sCon=sCon;
		}

	}
}

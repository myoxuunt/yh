using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;

namespace BengZhan.dingFengReLi
{
	/// <summary>
	/// CMain 的摘要说明。
	/// </summary>
	public class CMainEx
	{
			
		private static bool m_bDingFeng=false;

		public CMainEx()
		{		
		}	
		[STAThread]
		static void Main() 
		{
			try
			{

				openCon();
				Application.Run(new CReportDll.comReport.newRep.frmReport());
				return;
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("startForm.xml");
				if(xDoc.DocumentElement.SelectSingleNode("./startForm").Attributes.GetNamedItem("val").Value.Trim()=="report")
				{
					//***************顶峰系统显示
					CReportDll.comReport.newRep.frmReport frmRepO=new CReportDll.comReport.newRep.frmReport();
					//frmRepO.m_sCon=BengZhan.CDBConnection.m_sCon;
					Application.Run(frmRepO);
					//Application.Run(new winRep.Form1());
					//**************************
				}
				else
				{
					if(xDoc.DocumentElement.SelectSingleNode("./startForm").Attributes.GetNamedItem("val").Value.Trim()=="chart")
					{
						CReportDll.comReport.newRep.frmChart frmC=new CReportDll.comReport.newRep.frmChart();
						frmC.ShowDialog();;
						//					CReportDll.frmChart frmChartO=new CReportDll.frmChart();
						//					Application.Run(frmChartO);
					}
					else
					{
						CReportDll.comReport.newRep.frmSalReport frmSSO=new CReportDll.comReport.newRep.frmSalReport();
						frmSSO.ShowDialog();
					}
				
				}

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
			
			
		}

		#region"数据库连接"

		private static bool openCon()
		{

			SqlConnection sCon=new SqlConnection();			
			CMainEx.openCon(ref sCon);
			CDBConnection.m_sCon=sCon;
			return true;

		}
		private static bool openCon(ref SqlConnection sCon)
		{
			try
			{
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("Info.xml");
				string strCon=xDoc.DocumentElement.SelectSingleNode("./sConStr").InnerText.Trim();
				BengZhan.CDBConnection.m_strCon=strCon;

				SqlConnection sConEx=new SqlConnection(strCon);
				sConEx.Open();
				sCon=sConEx;
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show("数据库连接失败！");
				return false;
			}
		}
		private static bool bDingFeng()
		{
			try
			{
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("Info.xml");
				string strBDingFeng=xDoc.DocumentElement.SelectSingleNode("./bDingFeng").Attributes.GetNamedItem("val").Value.ToString().Trim();
				if(strBDingFeng=="true")
				{
					return true;
				}
				else
				{
					return false;
				}
													 
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}

		#endregion
		
	}
}

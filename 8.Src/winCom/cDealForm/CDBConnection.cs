using System;
using System.Data ;
using System.Data.SqlClient ;
using System.Windows.Forms ;
using System.Xml ;
using System.Threading ;
using System.Collections;
//using New.laidianDisplay;

namespace BengZhan
{
	/// <summary>
	/// 建立数据库连接
	/// </summary>
	public class CDBConnection
	{

		//public static BengZhan.Form1 m_App;
		//主程序数据库连接

		public static SqlConnection m_sCon;
		public static string m_strCon="";

		//public static BengZhan.Form1 m_App;

		public static string m_strUserID;
		public static string m_strUserName;

		//水井信息,gprs号对照表
		public static DataTable m_dtWellInfo=null;
		//报警下限
		public static int m_iWarnLevel=0;
		//售水信息表
		public static DataTable m_dtSal=null;
		//指令集
		public static Hashtable m_htCmds=null;
		//接收的异常
		public static DataTable m_dtErr;

		//客户端监听类
		//public static GprsSoft.serverMonitor.CServer  m_cServerMonObj;

		public static bool m_bServer=false;	
		public static bool m_bClient=false;

		public CDBConnection()
		{
			
		}
		public bool initialCon()
		{
			try
			{
				string strSql="select wellNo,depName,gprsNo from tbWell";
				CDBConnection.getDataTable(ref CDBConnection.m_dtWellInfo,strSql,"tbWell");

				//报警下限
				strSql=String.Format("select val from tbInfo where des='报警下限'");
				string strWarnLevel=CDBConnection.ExecuteScalar(strSql);
				CDBConnection.m_iWarnLevel=Convert.ToInt32(strWarnLevel);

				//初始化售水表
				this.iniSalDt(ref CDBConnection.m_dtSal);
				//初始化指令集
				this.iniCmds(ref CDBConnection.m_htCmds);

				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("Info.xml");

				string strServerType=xDoc.DocumentElement.SelectSingleNode("./tcpServer").Attributes.GetNamedItem("name").Value.ToString().Trim();
				if(strServerType=="server")
				{
					CDBConnection.m_bServer=true;
				}
				else
				{
					if(strServerType=="client")
					{
						CDBConnection.m_bClient=true;
					}
				}

				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}
		//private static string m_strCon="";

		private static bool iniCon()
		{
			try
			{
				if(m_strCon.Trim()=="")
				{
					XmlDocument xDoc=new XmlDocument();
					xDoc.Load("Server.xml");
					string strCon=xDoc.DocumentElement.SelectSingleNode("./strCon").InnerText.Trim();
					m_strCon=strCon;
				}
				return true;
	
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}
		/// <summary>
		/// 获得数据表
		/// </summary>
		/// <param name="dt"></param>
		/// <param name="strSql"></param>
		/// <param name="strTableName"></param>
		/// <returns></returns>
		public static bool getDataTable(ref DataTable dt,string strSql,string strTableName)
		{
			try
			{
				try
				{
					iniCon();

					SqlConnection sCon=new SqlConnection(m_strCon);
					sCon.Open();

					DataSet ds=new DataSet();
					SqlCommand sCmd=new  SqlCommand();
					sCmd.Connection =sCon;
					sCmd.CommandText =strSql;
					SqlDataAdapter sda=new SqlDataAdapter();
					sda.SelectCommand =sCmd;
					sda.Fill(ds,strTableName);

					dt=ds.Tables[strTableName];		
	
					sCon.Close();


					return true;
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.ToString());
					Application.Exit();
					//MessageBox.Show(ex.ToString());
					return false;
				}
		
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}

		}
		
		public static bool ExecuteSql(string strSql)
		{
			try
			{
				iniCon();

				SqlConnection sCon=new SqlConnection(m_strCon);
				sCon.Open();

				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection =sCon ;
				sCmd.CommandText =strSql;
				sCmd.ExecuteNonQuery();

				sCon.Close();
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				Application.Exit();
				//MessageBox.Show(ex.ToString());
				return false;
			}
		}
		public static string ExecuteScalar(string strSql)
		{
			try
			{
				iniCon();

				SqlConnection sCon=new SqlConnection(m_strCon);
				sCon.Open();

				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection =sCon ;
				sCmd.CommandText =strSql;
				if(sCmd.ExecuteScalar()!=null)
				{
					string strRet=sCmd.ExecuteScalar().ToString();
					sCon.Close();
					return strRet;
				}
				else
				{
					sCon.Close();
					return "";
				}
			}catch(Exception ex)	
			{
				MessageBox.Show(ex.ToString());
				Application.Exit();
				//MessageBox.Show(ex.ToString());
				return "";
			}

	
		}
		//初始化售水记录表
		private bool iniSalDt(ref DataTable dt)
		{
			try
			{
				DataTable dtEx=new DataTable();
				dtEx.Columns.Add(new DataColumn("wellNo"));
				dtEx.Columns.Add(new DataColumn("GprsNo"));
				dtEx.Columns.Add(new DataColumn("salMony"));
				dtEx.Columns.Add(new DataColumn("price"));
				dtEx.Columns.Add(new DataColumn("salAmount"));
				dtEx.Columns.Add(new DataColumn("Address"));
				dtEx.Columns.Add(new DataColumn("time"));
				dt=dtEx;
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}
		//初始化指令集
		private bool iniCmds(ref Hashtable ht)
		{
			try
			{
				Hashtable htEx=new Hashtable();
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("BengZhanCmd.xml");
				
				string strAskCmd=xDoc.DocumentElement.SelectSingleNode("./Asks/Ask[@name='salWater']").Attributes.GetNamedItem("valEx").Value.Trim();
				string strStartCmd=xDoc.DocumentElement.SelectSingleNode("./Asks/Ask[@name='startWell']").Attributes.GetNamedItem("valEx").Value.Trim();
				string strStopCmd=xDoc.DocumentElement.SelectSingleNode("./Asks/Ask[@name='stopWell']").Attributes.GetNamedItem("valEx").Value.Trim();
				htEx.Add("salWater",strAskCmd);
				htEx.Add("startWell",strStartCmd);
				htEx.Add("stopWell",strStopCmd);
				ht=htEx;
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}
		//插入上报异常
		public static bool insertErr(DataTable dtErr)
		{
			try
			{
				if(CDBConnection.m_dtErr==null)
				{
					CDBConnection.m_dtErr=new DataTable();
					CDBConnection.m_dtErr.Columns.Add(new DataColumn("gprsNo"));
					CDBConnection.m_dtErr.Columns.Add(new DataColumn("err"));
					CDBConnection.m_dtErr.Columns.Add(new DataColumn("errTime"));
				}
				for(int i=0;i<dtErr.Rows.Count;i++)
				{
					DataRow dr=CDBConnection.m_dtErr.NewRow();
					dr["gprsNo"]=dtErr.Rows[i]["gprsNo"].ToString();
					dr["err"]=dtErr.Rows[i]["err"].ToString();
					dr["errTime"]=dtErr.Rows[i]["errTime"].ToString();
					CDBConnection.m_dtErr.Rows.Add(dr);
				}
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}

		}


		#region"将数据库中最近信息表插入到历史表中"
		public static bool refreshHis()
		{
			try
			{
//				string strSql=String.Format("select wellNo,depName,usedWaterAmount,leftWaterAmount,allWaterAmount,flowWaterAmount,time from tbWellAmountLast");
//				DataTable dtLast=null;
//				CDBConnection.getDataTable(ref dtLast,strSql,"wellAmountLast");
//				
//				for(int i=0;i<dtLast.Rows.Count;i++)
//				{
//					DateTime dtTime=Convert.ToDateTime(dtLast.Rows[i]["time"].ToString());
//					string strWellNo=dtLast.Rows[i]["wellNo"].ToString();
//					string strDepName=dtLast.Rows[i]["depName"].ToString();
//					string strUsedWaterAmount=dtLast.Rows[i]["usedWaterAmount"].ToString();
//					string strLeftWaterAmount=dtLast.Rows[i]["leftWaterAmount"].ToString();
//					string strAllWaterAmount=dtLast.Rows[i]["allWaterAmount"].ToString();
//					string strFlowWaterAmount=dtLast.Rows[i]["flowWaterAmount"].ToString();					
//
//					strSql=String.Format("delete from tbWellAmount where wellNo='{0}' and year(time)='{1}' and month(time)='{2}' and day(time)='{3}'",dtLast.Rows[i]["wellNo"].ToString(),dtTime.Year.ToString(),dtTime.Month.ToString(),dtTime.Day.ToString());
//					if(GDBConnection.m_bSaveHis==false)
//					{
//						//不保存历史
//						CDBConnection.ExecuteSql(strSql);
//					}					
//					strSql=String.Format("insert into tbWellAmount(wellNo,depName,usedWaterAmount,leftWaterAmount,allWaterAmount,flowWaterAmount,time) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",strWellNo,strDepName,strUsedWaterAmount,strLeftWaterAmount,strAllWaterAmount,strFlowWaterAmount,dtTime.ToString());
//					CDBConnection.ExecuteSql(strSql);
//				}	
//				strSql="delete from tbWellAmountLast";
//				CDBConnection.ExecuteSql(strSql);
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

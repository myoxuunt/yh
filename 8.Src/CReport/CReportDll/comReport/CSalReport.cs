using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Forms;

namespace CReportDll.comReport
{
	/// <summary>
	/// CSalReport 的摘要说明。
	/// </summary>
	public class CSalReport
	{
		public CSalReport()
		{			
		}
		public static bool getDtAvgReportDepMonth(string strDepName,string strStartTime,string strEndTime,ref DataTable dtAllRep)
		{
			try
			{
				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();
				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;

				sCmd.CommandType=CommandType.StoredProcedure;
				sCmd.CommandText="p_sr_avgSalRepDepMonth";

				sCmd.Parameters.Add("@depName",SqlDbType.NVarChar,100);

				sCmd.Parameters.Add("@strStartTime",SqlDbType.NVarChar,20);

				sCmd.Parameters.Add("@strEndTime",SqlDbType.NVarChar,20);

				sCmd.Parameters["@depName"].Value=strDepName;
				sCmd.Parameters["@strStartTime"].Value=strStartTime;
				sCmd.Parameters["@strEndTime"].Value=strEndTime;

				DataSet ds=new DataSet();
				SqlDataAdapter sda=new SqlDataAdapter();
				sda.SelectCommand=sCmd;
				sda.Fill(ds,"dt");
				dtAllRep=ds.Tables["dt"];

				for(int i=0;i<dtAllRep.Rows.Count;i++)
				{
					string strTime=dtAllRep.Rows[i]["time"].ToString().Trim();
					strTime=strTime.Replace("-","年");
					strTime=strTime+"月";
dtAllRep.Rows[i]["time"]=strTime;
				}
sCon.Close();
				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}
		public static bool getDtAvgReportDep(string strDepName,string strStartTime,string strEndTime,ref DataTable dtAllRep)
		{
			try
			{
				DateTime dtStart=DateTime.Parse(strStartTime);
				DateTime dtEnd=DateTime.Parse(strEndTime);

				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();

				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;

				sCmd.CommandType=CommandType.StoredProcedure;
				sCmd.CommandText="p_sr_avgSalRepDep";

				sCmd.Parameters.Add("@depName",SqlDbType.NVarChar,100);

				sCmd.Parameters.Add("@strStartTime",SqlDbType.NVarChar,20);

				sCmd.Parameters.Add("@strEndTime",SqlDbType.NVarChar,20);

				sCmd.Parameters["@depName"].Value=strDepName;
				sCmd.Parameters["@strStartTime"].Value=dtStart.ToShortDateString();
				sCmd.Parameters["@strEndTime"].Value=dtEnd.ToShortDateString();
				DataSet ds=new DataSet();
				SqlDataAdapter sda=new SqlDataAdapter();
				sda.SelectCommand=sCmd;
				sda.Fill(ds,"dt");

				dtAllRep=ds.Tables["dt"];

				sCon.Close();

				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}
		public static bool getDtAvgReport(string strZhanNo,string strStartTime,string strEndTime,ref DataTable dtAllRep)
		{
			try
			{
				DateTime dtStart=DateTime.Parse(strStartTime);
				DateTime dtEnd=DateTime.Parse(strEndTime);

				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();

				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;

				sCmd.CommandType=CommandType.StoredProcedure;
				sCmd.CommandText="p_sr_avgSalRep";

				sCmd.Parameters.Add("@zhanNo",SqlDbType.NVarChar,20);

				sCmd.Parameters.Add("@strStartTime",SqlDbType.NVarChar,20);

				sCmd.Parameters.Add("@strEndTime",SqlDbType.NVarChar,20);

				sCmd.Parameters["@zhanNo"].Value=strZhanNo;
				sCmd.Parameters["@strStartTime"].Value=dtStart.ToShortDateString();
				sCmd.Parameters["@strEndTime"].Value=dtEnd.ToShortDateString();

				DataSet ds=new DataSet();
				SqlDataAdapter sda=new SqlDataAdapter();
				sda.SelectCommand=sCmd;
				sda.Fill(ds,"dt");

				dtAllRep=ds.Tables["dt"];

				sCon.Close();

				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}	
	
		public static bool getDtAllReportMonth(string strZhanNo,string strStartTime,string strEndTime,ref DataTable dtAllRep)
		{
			try
			{
				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();

				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;

				sCmd.CommandType=CommandType.StoredProcedure;
				sCmd.CommandText="p_sr_allSalRepMonth";

				sCmd.Parameters.Add("@zhanNo",SqlDbType.NVarChar,20);

				sCmd.Parameters.Add("@strStartTime",SqlDbType.NVarChar,20);

				sCmd.Parameters.Add("@strEndTime",SqlDbType.NVarChar,20);

				sCmd.Parameters["@zhanNo"].Value=strZhanNo;
				sCmd.Parameters["@strStartTime"].Value=strStartTime;

				DateTime dtEnd=Convert.ToDateTime(strEndTime);
				dtEnd=dtEnd.AddMonths(1);
				strEndTime=string.Format("{0}-{1}-1 0:00",dtEnd.Year.ToString(),dtEnd.Month.ToString());
				sCmd.Parameters["@strEndTime"].Value=strEndTime;

				DataSet ds=new DataSet();
				SqlDataAdapter sda=new SqlDataAdapter();
				sda.SelectCommand=sCmd;
				sda.Fill(ds,"dt");

				dtAllRep=ds.Tables["dt"];

//				for(int i=0;i<dtAllRep.Rows.Count;i++)
//				{
//					string strTime=dtAllRep.Rows[i]["time"].ToString();
//					strTime=strTime.Replace("-","年");
//					strTime=strTime+"月";
//					dtAllRep.Rows[i]["time"]=strTime;
//				}

				sCon.Close();
				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}


		public static bool getDtAvgReportNew(string strZhanNo,string strStartTime,string strEndTime,ref DataTable dtAllRep)
		{
			try
			{
				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();

				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;

				sCmd.CommandType=CommandType.StoredProcedure;
				sCmd.CommandText="p_sr_avgSalRepNew";

				sCmd.Parameters.Add("@zhanNo",SqlDbType.NVarChar,20);

				sCmd.Parameters.Add("@strStartTime",SqlDbType.NVarChar,20);

				sCmd.Parameters.Add("@strEndTime",SqlDbType.NVarChar,20);

				sCmd.Parameters["@zhanNo"].Value=strZhanNo;
				sCmd.Parameters["@strStartTime"].Value=strStartTime;
				sCmd.Parameters["@strEndTime"].Value=strEndTime;

				DataSet ds=new DataSet();
				SqlDataAdapter sda=new SqlDataAdapter();
				sda.SelectCommand=sCmd;
				sda.Fill(ds,"dt");

				dtAllRep=ds.Tables["dt"];

//				for(int i=0;i<dtAllRep.Rows.Count;i++)
//				{
//					string strTime=dtAllRep.Rows[i]["time"].ToString();
//					strTime=strTime.Replace("-","年");
//					strTime=strTime+"月";
//					dtAllRep.Rows[i]["time"]=strTime;
//				}

				sCon.Close();
				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}

		public static bool getDtAvgReportYear(string strZhanNo,string strYear,ref DataTable dtAllRep)
		{
			try
			{
				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();

				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;

				sCmd.CommandType=CommandType.StoredProcedure;
				sCmd.CommandText="p_sr_avgSalRepYear";

				sCmd.Parameters.Add("@zhanNo",SqlDbType.NVarChar,20);

				sCmd.Parameters.Add("@Year",SqlDbType.NVarChar,20);
			

				sCmd.Parameters["@zhanNo"].Value=strZhanNo;
				sCmd.Parameters["@Year"].Value=strYear;
	

				DataSet ds=new DataSet();
				SqlDataAdapter sda=new SqlDataAdapter();
				sda.SelectCommand=sCmd;
				sda.Fill(ds,"dt");

				dtAllRep=ds.Tables["dt"];

				dtAllRep.Columns.Add("time",Type.GetType("System.String"));
			dtAllRep.Columns.Add("time1",Type.GetType("System.String"));

				for(int i=0;i<dtAllRep.Rows.Count;i++)
				{
					 strYear=dtAllRep.Rows[i]["year"].ToString();
					string strTime=string.Format("{0}-1-1 0:00",strYear);
					string strTime1=string.Format("{0}-12-1 23:59",strYear);
					DateTime dt1=DateTime.Parse(strTime1);
					strTime1=dt1.AddMonths(1).AddDays(-1).ToString();
					dtAllRep.Rows[i]["time"]=strTime;
					dtAllRep.Rows[i]["time1"]=strTime1;
				}

				sCon.Close();
				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}


		public static bool getDtAvgReportMonth(string strZhanNo,string strStartTime,string strEndTime,ref DataTable dtAllRep)
		{
			try
			{
				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();

				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;

				sCmd.CommandType=CommandType.StoredProcedure;
				sCmd.CommandText="p_sr_avgSalRepMonth";

				sCmd.Parameters.Add("@zhanNo",SqlDbType.NVarChar,20);

				sCmd.Parameters.Add("@strStartTime",SqlDbType.NVarChar,20);

				sCmd.Parameters.Add("@strEndTime",SqlDbType.NVarChar,20);

				sCmd.Parameters["@zhanNo"].Value=strZhanNo;
				sCmd.Parameters["@strStartTime"].Value=strStartTime;
				sCmd.Parameters["@strEndTime"].Value=strEndTime;

				DataSet ds=new DataSet();
				SqlDataAdapter sda=new SqlDataAdapter();
				sda.SelectCommand=sCmd;
				sda.Fill(ds,"dt");

				dtAllRep=ds.Tables["dt"];

//				for(int i=0;i<dtAllRep.Rows.Count;i++)
//				{
//					string strTime=dtAllRep.Rows[i]["time"].ToString();
//
//					//strTime=strTime.Replace("-","年");
//					//strTime=strTime+"月";
//
//
//					DateTime dtTo=DateTime.Parse(strTime);
//
//					dtTo=dtTo.AddMonths(1);
//					dtTo=dtTo.AddDays(-1);
//
//					string strFrom=string.Format("{0}-{1}-{2} 0:00",dtTo.Year.ToString(),dtTo.Month.ToString(),"1");
//					string strTo=string.Format("{0}-{1}-{2} 23:00",dtTo.Year.ToString(),dtTo.Month.ToString(),dtTo.Day.ToString());
//                    dtAllRep.Rows[i]["time"]=strFrom;
//					dtAllRep.Rows[i]["time1"]=strTo;
//				}

			sCon.Close();
				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}
		//单位明细
		public static bool getDtDetailReportDep(string strDepName,string strStartTime,string strEndTime,ref DataTable dtDetailRep)
		{
			try
			{
				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();

				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;
				sCmd.CommandType=CommandType.StoredProcedure;
				sCmd.CommandText="p_sr_detailSaleRepDep";

				sCmd.Parameters.Add("@depName",SqlDbType.NVarChar,100);

				sCmd.Parameters.Add("@strStartTime",SqlDbType.NVarChar,40);

				sCmd.Parameters.Add("@strEndTime",SqlDbType.NVarChar,40);

				sCmd.Parameters["@depName"].Value=strDepName;
				sCmd.Parameters["@strStartTime"].Value=strStartTime;
				sCmd.Parameters["@strEndTime"].Value=strEndTime;

				DataSet ds=new DataSet();
				SqlDataAdapter sda=new SqlDataAdapter();
				sda.SelectCommand=sCmd;
				sda.Fill(ds,"dt");

				dtDetailRep=ds.Tables["dt"];

				sCon.Close();

				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}
		//明细
		public static bool getDtDetailReport(string strZhanNo,string strStartTime,string strEndTime,ref DataTable dtDetailRep)
		{
			try
			{
				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();

				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;
				sCmd.CommandType=CommandType.StoredProcedure;
				sCmd.CommandText="p_sr_detailSaleRep";

				sCmd.Parameters.Add("@zhanNo",SqlDbType.NVarChar,20);

				sCmd.Parameters.Add("@strStartTime",SqlDbType.NVarChar,40);

				sCmd.Parameters.Add("@strEndTime",SqlDbType.NVarChar,40);

				sCmd.Parameters["@zhanNo"].Value=strZhanNo;
				sCmd.Parameters["@strStartTime"].Value=strStartTime;
				sCmd.Parameters["@strEndTime"].Value=strEndTime;

				DataSet ds=new DataSet();
				SqlDataAdapter sda=new SqlDataAdapter();
				sda.SelectCommand=sCmd;
				sda.Fill(ds,"dt");

				dtDetailRep=ds.Tables["dt"];

				sCon.Close();

				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}
        //操作员售水明细
		//单位明细
		public static bool getDtDetailReportMana(string strDepName,string strStartTime,string strEndTime,ref DataTable dtDetailRep)
		{
			try
			{
				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();

				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;
				sCmd.CommandType=CommandType.StoredProcedure;
				sCmd.CommandText="p_sr_detailSaleRepMana";

				sCmd.Parameters.Add("@manaPer",SqlDbType.NVarChar,100);

				sCmd.Parameters.Add("@strStartTime",SqlDbType.NVarChar,40);

				sCmd.Parameters.Add("@strEndTime",SqlDbType.NVarChar,40);

				sCmd.Parameters["@manaPer"].Value=strDepName;
				sCmd.Parameters["@strStartTime"].Value=strStartTime;
				sCmd.Parameters["@strEndTime"].Value=strEndTime;

				DataSet ds=new DataSet();
				SqlDataAdapter sda=new SqlDataAdapter();
				sda.SelectCommand=sCmd;
				sda.Fill(ds,"dt");

				dtDetailRep=ds.Tables["dt"];
sCon.Close();
				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}
		//操作员日统计
		public static bool getDtAvgReportMana(string strDepName,string strStartTime,string strEndTime,ref DataTable dtDetailRep)
		{
			try
			{
				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();
				DateTime dtStart=DateTime.Parse(strStartTime);
				DateTime dtEnd=DateTime.Parse(strEndTime);
				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;
				sCmd.CommandType=CommandType.StoredProcedure;
				sCmd.CommandText="p_sr_avgSalRepMana";

				sCmd.Parameters.Add("@manaPer",SqlDbType.NVarChar,100);

				sCmd.Parameters.Add("@strStartTime",SqlDbType.NVarChar,20);

				sCmd.Parameters.Add("@strEndTime",SqlDbType.NVarChar,20);

				sCmd.Parameters["@manaPer"].Value=strDepName;
				sCmd.Parameters["@strStartTime"].Value=dtStart.ToShortDateString();
				sCmd.Parameters["@strEndTime"].Value=dtEnd.ToShortDateString();

				DataSet ds=new DataSet();
				SqlDataAdapter sda=new SqlDataAdapter();
				sda.SelectCommand=sCmd;
				sda.Fill(ds,"dt");

				dtDetailRep=ds.Tables["dt"];
				sCon.Close();

				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}

		public static bool getDtAvgReportManaMonth(string strDepName,string strStartTime,string strEndTime,ref DataTable dtDetailRep)
		{
			try
			{
				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();

				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;
				sCmd.CommandType=CommandType.StoredProcedure;
				sCmd.CommandText="p_sr_avgSalRepManaMonth";

				sCmd.Parameters.Add("@manaPer",SqlDbType.NVarChar,100);

				sCmd.Parameters.Add("@strStartTime",SqlDbType.NVarChar,20);

				sCmd.Parameters.Add("@strEndTime",SqlDbType.NVarChar,20);

				sCmd.Parameters["@manaPer"].Value=strDepName;
				sCmd.Parameters["@strStartTime"].Value=strStartTime;
				sCmd.Parameters["@strEndTime"].Value=strEndTime;

				DataSet ds=new DataSet();
				SqlDataAdapter sda=new SqlDataAdapter();
				sda.SelectCommand=sCmd;
				sda.Fill(ds,"dt");

				dtDetailRep=ds.Tables["dt"];

				for(int i=0;i<dtDetailRep.Rows.Count;i++)
				{
					string strTime=dtDetailRep.Rows[i]["time"].ToString();
					strTime=strTime.Replace("-","年");
					strTime+="月";
					dtDetailRep.Rows[i]["time"]=strTime;
				}
				sCon.Close();

						  return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}

	}
}

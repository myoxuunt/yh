using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Forms; 

namespace BengZhan.comReport
{
	/// <summary>
	///图表数据查询类
	/// </summary>
	public class CChart
	{
		public CChart()
		{			
		}
		//明细
		public static bool getDtDetailReport(string strZhanNo,string strStartTime,string strEndTime,ref DataTable dtDetailRep)
		{
			try
			{
				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=BengZhan.CDBConnection.m_sCon;
				sCmd.CommandType=CommandType.StoredProcedure;
				sCmd.CommandText="p_sr_detailChart";

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

				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}
		public static bool getDtAvgReport(string strZhanNo,string strStartTime,string strEndTime,ref DataTable dtAllRep)
		{
			try
			{
				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=BengZhan.CDBConnection.m_sCon;

				sCmd.CommandType=CommandType.StoredProcedure;
				sCmd.CommandText="p_sr_avgChart";

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

				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}

	}
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Forms;
using System.Collections;
using System.Xml;
//using CrystalDecisions.CrystalReports.Engine;


namespace BengZhan.comReport
{
	/// <summary>
	/// CReports 的摘要说明。
	/// </summary>
	public class CReports
	{
		private SqlConnection m_sCon;

		public static DataTable m_dtExport;

		public CReports(SqlConnection sCon)
		{
			this.m_sCon=sCon;
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
				sCmd.CommandText="p_sr_detailRepDep";

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



		public static bool getDtDetailReportMonth(string strZhanNo,string strStartTime,string strEndTime,ref DataTable dtDetailRep)
		{
			return true;
		}

		//天
		public static bool getDtDetailReportDay(string strZhanNo,string strStartTime,string strEndTime,ref DataTable dtDetailRep)
		{
			try
			{
				DateTime dtEnd=DateTime.Parse(strEndTime);
				dtEnd=dtEnd.AddMinutes(1);
				strEndTime=dtEnd.ToString();

				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();
				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;
				sCmd.CommandType=CommandType.StoredProcedure;
				sCmd.CommandText="p_sr_detailRepMonth";

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
				sCmd.CommandText="p_sr_detailRep";

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

		public static bool getDtNewAvgReport(string strZhanNo,string strStartTime,string strEndTime,ref DataTable dtAllRep)		
		{
			try
			{
				DateTime dtStart=Convert.ToDateTime(strStartTime);
				DateTime dtEnd=Convert.ToDateTime(strEndTime);
				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();

				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;

				sCmd.CommandType=CommandType.StoredProcedure;
				sCmd.CommandText="p_sr_avgRepNew";

				sCmd.Parameters.Add("@zhanNo",SqlDbType.NVarChar,20);

				sCmd.Parameters.Add("@iStartTime",SqlDbType.NVarChar,40);

				sCmd.Parameters.Add("@iEndTime",SqlDbType.NVarChar,40);

				sCmd.Parameters["@zhanNo"].Value=strZhanNo;
				sCmd.Parameters["@iStartTime"].Value=dtStart;
				sCmd.Parameters["@iEndTime"].Value=dtEnd;

				DataSet ds=new DataSet();
				SqlDataAdapter sda=new SqlDataAdapter();
				sda.SelectCommand=sCmd;
				sda.Fill(ds,"dt");

				dtAllRep=ds.Tables["dt"];

//				for(int i=0;i<dtAllRep.Rows.Count;i++)
//				{
//					string strTime=dtAllRep.Rows[i]["time"].ToString().Trim();
//					strTime=strTime.Replace("-","年");
//					strTime=strTime+"月";
//					
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

		public static bool getDtMonthAvgReport(string strZhanNo,string strStartTime,string strEndTime,ref DataTable dtAllRep)
		{
			try
			{
				DateTime dtStart=Convert.ToDateTime(strStartTime);
				DateTime dtEnd=Convert.ToDateTime(strEndTime);
				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();

				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;

				sCmd.CommandType=CommandType.StoredProcedure;
				sCmd.CommandText="p_sr_avgRepMon";

				sCmd.Parameters.Add("@zhanNo",SqlDbType.NVarChar,20);

				sCmd.Parameters.Add("@iStartTime",SqlDbType.NVarChar,40);

				sCmd.Parameters.Add("@iEndTime",SqlDbType.NVarChar,40);

				sCmd.Parameters["@zhanNo"].Value=strZhanNo;
				sCmd.Parameters["@iStartTime"].Value=dtStart;
				sCmd.Parameters["@iEndTime"].Value=dtEnd;

				DataSet ds=new DataSet();
				SqlDataAdapter sda=new SqlDataAdapter();
				sda.SelectCommand=sCmd;
				sda.Fill(ds,"dt");

				dtAllRep=ds.Tables["dt"];

//				for(int i=0;i<dtAllRep.Rows.Count;i++)
//				{
//					string strTime=dtAllRep.Rows[i]["time"].ToString().Trim();
//					strTime=strTime.Replace("-","年");
//					strTime=strTime+"月";
//					
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

		public static bool getDtYearAvgReport(string strZhanNo,string strYear,ref DataTable dtAllRep)
		{
			try
			{	
				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();

				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;

				sCmd.CommandType=CommandType.StoredProcedure;
				sCmd.CommandText="p_sr_avgRepYear";

				sCmd.Parameters.Add("@zhanNo",SqlDbType.NVarChar,20);

				sCmd.Parameters.Add("@Year",SqlDbType.NVarChar,40);

				
				sCmd.Parameters["@zhanNo"].Value=strZhanNo;
				sCmd.Parameters["@Year"].Value=strYear;
			
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

		public static bool getDtMonthAvgReportDep(string strZhanNo,string strStartTime,string strEndTime,ref DataTable dtAllRep)
		{
			try
			{ 
				DateTime dtStart=Convert.ToDateTime(strStartTime);
				DateTime dtEnd=Convert.ToDateTime(strEndTime);
				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();

				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;

				sCmd.CommandType=CommandType.StoredProcedure;
				sCmd.CommandText="p_sr_avgRepMonthDep";

				sCmd.Parameters.Add("@depName",SqlDbType.NVarChar,20);

				sCmd.Parameters.Add("@strStartTime",SqlDbType.NVarChar,40);

				sCmd.Parameters.Add("@strEndTime",SqlDbType.NVarChar,40);

				sCmd.Parameters["@depName"].Value=strZhanNo;
				sCmd.Parameters["@strStartTime"].Value=dtStart;
				sCmd.Parameters["@strEndTime"].Value=dtEnd;

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
				sCmd.CommandText="p_sr_avgRepDep";

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
				sCmd.CommandText="p_sr_avgRep";

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
		
		//9列显示
//		public static bool showReport(CrystalDecisions.Windows.Forms.CrystalReportViewer crpvWater,DataTable dtRep,Hashtable htRep,ReportDocument crp,string strTitle,string strTime)
//		{
//			try
//			{
//
//				if(dtRep==null)
//				{
//					return false;
//				}
//
//				if(htRep==null)
//				{
//					return false;
//				}
//
//				for(int i=0;i<crp.ReportDefinition.ReportObjects.Count;i++)
//				{
//					if(crp.ReportDefinition.ReportObjects[i] is CrystalDecisions.CrystalReports.Engine.TextObject)
//					{
//						
//						CrystalDecisions.CrystalReports.Engine.TextObject to=(CrystalDecisions.CrystalReports.Engine.TextObject)crp.ReportDefinition.ReportObjects[i];
//						if(to.Text.IndexOf("field")>=0)
//						{
//							to.Text=htRep[to.Text.Trim()].ToString();
//						}
//						if(to.Text.Trim()=="")
//						{
//							to.Text=strTitle;
//						}
//						if(to.Text.Trim()=="time")
//						{
//							to.Text=strTime;
//						}
//					}
//				}
//
//				m_dtExport=dtRep.Copy();
//
//
//				for(int i=0;i<dtRep.Columns.Count;i++)
//				{
//					int j=i+1;
//					string strField="field"+j.ToString();
//					dtRep.Columns[i].ColumnName=strField;
//				}
//
//				crp.SetDataSource(dtRep);
//			
//				crpvWater.ReportSource=crp;
//
//				return true;
//			}
//			catch(Exception ex)
//			{
//				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
//				return false;
//			}
//		}

		//5列显示

//		public static bool showReport5(CrystalDecisions.Windows.Forms.CrystalReportViewer crpvWater,DataTable dtRep,Hashtable htRep,ReportDocument crp,string strTitle,string strTime)
//		{
//			try
//			{
//
//				if(dtRep==null)
//				{
//					return false;
//				}
//
//				if(htRep==null)
//				{
//					return false;
//				}
//
//				for(int i=0;i<crp.ReportDefinition.ReportObjects.Count;i++)
//				{
//					if(crp.ReportDefinition.ReportObjects[i] is CrystalDecisions.CrystalReports.Engine.TextObject)
//					{						
//						CrystalDecisions.CrystalReports.Engine.TextObject to=(CrystalDecisions.CrystalReports.Engine.TextObject)crp.ReportDefinition.ReportObjects[i];
//						if(to.Text.IndexOf("field")>=0)
//						{
//							to.Text=htRep[to.Text.Trim()].ToString();
//						}
//						if(to.Text.Trim()=="")
//						{
//							to.Text=strTitle;
//						}
//						if(to.Text.Trim()=="time")
//						{
//							to.Text=strTime;
//						}
//					}
//				}
//
//				m_dtExport=dtRep.Copy();
//
//				for(int i=0;i<dtRep.Columns.Count;i++)
//				{
//					int j=i+1;
//					string strField="field"+j.ToString();
//					dtRep.Columns[i].ColumnName=strField;
//				}
//
//				crp.SetDataSource(dtRep);
//				
//
//				crpvWater.ReportSource=crp;
//
//				return true;
//			}
//			catch(Exception ex)
//			{
//				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
//				return false;
//			}
//		}
		public static bool getHtTitles(string strPath,ref Hashtable ht)
		{

			try
			{
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load(strPath);

				Hashtable htColNames=new   Hashtable();
				
				for(int i=0;i<xDoc.DocumentElement.ChildNodes.Count;i++)
				{
					htColNames.Add(xDoc.DocumentElement.ChildNodes[i].Attributes.GetNamedItem("name").Value.ToString(),xDoc.DocumentElement.ChildNodes[i].Attributes.GetNamedItem("des").Value.ToString());
					
				}
				ht=htColNames;

				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}

		}

		#region"新加乡镇统计"

		public static bool getDtDetailReportCountry(string strCountryName,string strStartTime,string strEndTime,ref DataTable dtDetailRep)
		{
			try
			{
				string strSql=string.Format("select depShortName from tbDep where countryName='{0}'",strCountryName);
				DataTable dt=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dt,strSql,"depNames");
				DataTable dtEx=null;

				for(int i=0;i<dt.Rows.Count;i++)
				{

					string strDepName=dt.Rows[i]["depShortName"].ToString().Trim();
					DataTable dtRep=new DataTable();
					if(getDtDetailReportDep(strDepName,strStartTime,strEndTime,ref dtRep)==false)
					{
						return false;
					}

					if(copyDt(dtRep,ref dtEx)==false)
					{
						return false;
					}                   
				}

dtDetailRep=dtEx;
				
				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}

		}

		#region"工具函数"

		private static bool addStaticRow(ref DataTable dt)
		{
			try
			{
				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}
		
		public static bool copyDt(DataTable dtFrom,ref DataTable dtTo)
		{
			try
			{
				if(dtFrom==null)
				{
					//dtTo=new DataTable();
					return true;
				}

				if(dtFrom.Columns.Count==0)
				{
					return false;
				}

				if(dtTo==null)
				{
					dtTo=dtFrom.Copy();
					return true;
				}

				if(dtTo.Columns.Count==0)
				{
					dtTo=dtFrom.Copy();
					return true;
				}	
				
				if(dtTo.Columns.Count!=dtFrom.Columns.Count)
				{
					MessageBox.Show("表头不符!");
					return false;
				}

				if(dtTo.Rows.Count==0)
				{
				   dtTo=dtFrom.Copy();
					return true;
			    }

				DataTable dtToEx=dtTo.Clone();
				for(int i=0;i<dtToEx.Columns.Count;i++)
				{
					dtToEx.Columns[i].DataType=Type.GetType("System.String");
				}

				copyDtEx(dtTo,ref dtToEx);
				dtTo=dtToEx;

				 for(int i=0;i<dtFrom.Rows.Count;i++)
				{
					dtTo.ImportRow(dtFrom.Rows[i]);
				}

				 return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}			
		}

		public static bool copyDtEx(DataTable dtFrom,ref DataTable dtTo)
		{
			try
			{
				if(dtFrom==null)
				{
					//dtTo=new DataTable();
					return true;
				}
				if(dtTo==null)
				{
					dtTo=dtFrom.Copy();
					return true;
				}
				
				if(dtTo.Columns.Count!=dtFrom.Columns.Count)
				{
					//dtTo=dtFrom.Copy();
					MessageBox.Show("表头不符!");
					return false;
				}	

				for(int i=0;i<dtFrom.Rows.Count;i++)
				{
					DataRow dr=dtTo.NewRow();

					for(int j=0;j<dtTo.Columns.Count;j++)
					{
						string strColName=dr.Table.Columns[j].ColumnName.Trim() ;
						try
						{
							dr[j]=dtFrom.Rows[i][strColName].ToString().Trim();
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.ToString()+strColName);
						}
						
					}

					dtTo.Rows.Add(dr);	
				}
				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}			
		}
		#endregion

		#endregion


	}
}

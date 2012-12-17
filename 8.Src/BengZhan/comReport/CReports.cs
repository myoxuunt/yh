using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Forms;
using System.Collections;
using System.Xml;


namespace BengZhan.comReport
{
	/// <summary>
	/// CReports 的摘要说明。
	/// </summary>
	public class CReports
	{
		private SqlConnection m_sCon;

		public CReports(SqlConnection sCon)
		{
			this.m_sCon=sCon;
		}

		//明细
		public static bool getDtDetailReport(string strZhanNo,string strStartTime,string strEndTime,ref DataTable dtDetailRep)
		{
			try
			{
				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=BengZhan.CDBConnection.m_sCon;
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
				sCmd.CommandText="p_sr_avgRep";

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
		
		//9列显示
		public static bool showReport(CrystalDecisions.Windows.Forms.CrystalReportViewer crpvWater,DataTable dtRep,Hashtable htRep,BengZhan.comReport._9.crp9 crp,string strTitle,string strTime)
		{
			try
			{

				if(dtRep==null)
				{
					return false;
				}

				if(htRep==null)
				{
					return false;
				}

				for(int i=0;i<crp.Section2.ReportObjects.Count;i++)
				{
					if(crp.Section2.ReportObjects[i] is CrystalDecisions.CrystalReports.Engine.TextObject)
					{
						
						CrystalDecisions.CrystalReports.Engine.TextObject to=(CrystalDecisions.CrystalReports.Engine.TextObject)crp.Section2.ReportObjects[i];
						if(to.Text.IndexOf("field")>=0)
						{
							to.Text=htRep[to.Text.Trim()].ToString();
						}
						if(to.Text.Trim()=="")
						{
							to.Text=strTitle;
						}
						if(to.Text.Trim()=="time")
						{
							to.Text=strTime;
						}
					}
				}

				for(int i=0;i<dtRep.Columns.Count;i++)
				{
					int j=i+1;
					string strField="field"+j.ToString();
					dtRep.Columns[i].ColumnName=strField;
				}

				 crp.SetDataSource(dtRep);

				crpvWater.ReportSource=crp;

				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}

		//8列显示
		public static bool showReport8(CrystalDecisions.Windows.Forms.CrystalReportViewer crpvWater,DataTable dtRep,Hashtable htRep,BengZhan.comReport.crp._8.crp8  crp,string strTitle,string strTime)
		{
			try
			{

				if(dtRep==null)
				{
					return false;
				}

				if(htRep==null)
				{
					return false;
				}

				for(int i=0;i<crp.Section2.ReportObjects.Count;i++)
				{
					if(crp.Section2.ReportObjects[i] is CrystalDecisions.CrystalReports.Engine.TextObject)
					{
						
						CrystalDecisions.CrystalReports.Engine.TextObject to=(CrystalDecisions.CrystalReports.Engine.TextObject)crp.Section2.ReportObjects[i];
						if(to.Text.IndexOf("field")>=0)
						{
							to.Text=htRep[to.Text.Trim()].ToString();
						}
						if(to.Text.Trim()=="")
						{
							to.Text=strTitle;
						}
						if(to.Text.Trim()=="time")
						{
							to.Text=strTime;
						}
					}
				}

				for(int i=0;i<dtRep.Columns.Count;i++)
				{
					int j=i+1;
					string strField="field"+j.ToString();
					dtRep.Columns[i].ColumnName=strField;
				}

				crp.SetDataSource(dtRep);

				crpvWater.ReportSource=crp;

				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}

		//5列显示

		public static bool showReport5(CrystalDecisions.Windows.Forms.CrystalReportViewer crpvWater,DataTable dtRep,Hashtable htRep,BengZhan.comReport._5.crp5 crp,string strTitle,string strTime)
		{
			try
			{

				if(dtRep==null)
				{
					return false;
				}

				if(htRep==null)
				{
					return false;
				}

				for(int i=0;i<crp.Section2.ReportObjects.Count;i++)
				{
					if(crp.Section2.ReportObjects[i] is CrystalDecisions.CrystalReports.Engine.TextObject)
					{						
						CrystalDecisions.CrystalReports.Engine.TextObject to=(CrystalDecisions.CrystalReports.Engine.TextObject)crp.Section2.ReportObjects[i];
						if(to.Text.IndexOf("field")>=0)
						{
							to.Text=htRep[to.Text.Trim()].ToString();
						}
						if(to.Text.Trim()=="")
						{
							to.Text=strTitle;
						}
						if(to.Text.Trim()=="time")
						{
							to.Text=strTime;
						}
					}
				}

				for(int i=0;i<dtRep.Columns.Count;i++)
				{
					int j=i+1;
					string strField="field"+j.ToString();
					dtRep.Columns[i].ColumnName=strField;
				}

				crp.SetDataSource(dtRep);

				crpvWater.ReportSource=crp;

				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}




		public static bool getHtTitles(string strPath,ref Hashtable ht)
		{

			try
			{
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("columnName.xml");

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
				MessageBox.Show(ex.ToString());
				return false;
			}

		}



	}
}

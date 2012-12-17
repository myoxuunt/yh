using System;
using System.Windows;
using System.Windows.Forms;
using System.Data;
using System.Xml;

namespace BengZhan.comReport.zedGraph
{
	/// <summary>
	/// CmyPaintChart 的摘要说明。
	/// </summary>
	public class CmyPaintChart
	{
		public CmyPaintChart()
		{
			
		}	

		private static bool getEDataType(string strCDataType,ref string strEDataType)
		{
			try
			{
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("columnName.xml");

				for(int i=0;i<xDoc.DocumentElement.ChildNodes.Count;i++)
				{
					if(xDoc.DocumentElement.ChildNodes[i].Attributes.GetNamedItem("des").Value.ToString().Trim()==strCDataType)
					{
						strEDataType=xDoc.DocumentElement.ChildNodes[i].Attributes.GetNamedItem("ename").Value.ToString().Trim();
						return true;
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
		
		//绘制图表
		public static bool paintChartDetail(string strFrom,string strTo,string strWellNo,string strCDataType,ZedGraph.ZedGraphControl zedChart)
		{
			try
			{
				DataTable dtDetail=new DataTable();

				if(BengZhan.comReport.CChart.getDtDetailReport(strWellNo,strFrom,strTo,ref dtDetail)==false)
				{
					return false;
				}

				if(dtDetail==null)
				{
					return false;
				}

				string strDataType="";
				if(getEDataType(strCDataType,ref strDataType)==false)
				{
					return false;
				}

				DataTable dtChart=new DataTable();
				dtChart.Columns.Add("x");
				dtChart.Columns.Add("y");

				for(int i=0;i<dtDetail.Rows.Count;i++)
				{
					DataRow dr=dtChart.NewRow();
					dr["x"]=dtDetail.Rows[i]["time"].ToString().Trim();
					dr["y"]=dtDetail.Rows[i][strDataType].ToString().Trim();
					dtChart.Rows.Add(dr);
				}

				string strSql=String.Format("select depName from tbWell where wellNo='{0}'",strWellNo);
				string strDepName=BengZhan.CDBConnection.ExecuteScalar(strSql);

				string strTitle=String.Format("明细帐图表  单位:{0}  时间范围{1}至{2}",strDepName,strFrom,strTo);
                

				return paintChart(dtChart,strCDataType,"时间","Day",strTitle,zedChart);                				
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}


		public static bool paintChartAvg(string strFrom,string strTo,string strWellNo,string strCDataType,ZedGraph.ZedGraphControl zedChart)
		{
			try
			{		
				DataTable dtAvg=new DataTable();

				if(BengZhan.comReport.CChart.getDtAvgReport(strWellNo,strFrom,strTo,ref dtAvg)==false)
				{
					return false;
				}

				if(dtAvg==null)
				{
					return false;
				}

				string strDataType="";
				if(getEDataType(strCDataType,ref strDataType)==false)
				{
					return false;
				}

				DataTable dtChart=new DataTable();
				dtChart.Columns.Add("x");
				dtChart.Columns.Add("y");

				for(int i=0;i<dtAvg.Rows.Count;i++)
				{
					DataRow dr=dtChart.NewRow();
					dr["x"]=dtAvg.Rows[i]["time"].ToString().Trim();
					dr["y"]=dtAvg.Rows[i][strDataType].ToString().Trim();
					dtChart.Rows.Add(dr);
				}

				string strSql=String.Format("select depName from tbWell where wellNo='{0}'",strWellNo);
				string strDepName=BengZhan.CDBConnection.ExecuteScalar(strSql);

				string strTitle=String.Format("日统计值图表  单位:{0}  时间范围{1}至{2}",strDepName,strFrom,strTo);

				return paintChart(dtChart,strCDataType,"日期","month",strTitle,zedChart);        
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}
	
		private static bool paintChart(DataTable dtLine1,string strLineName,string strXTitle,string strState,string strTitle,ZedGraph.ZedGraphControl zedChart)
		{
			try
			{
				//lblInfo.Text=strTitle;

				ZedGraph.Demo.DateAxisSampleDemo demo = new ZedGraph.Demo.DateAxisSampleDemo();				

				demo.m_dtLine1 =dtLine1;				

				demo.m_dtLine2=new DataTable();
				//第一条线名称
				demo.m_strLine1Name=strLineName;
				//第二条线名称
				demo.m_strLine2Name="";				
				demo.m_strState=strState;
				demo.m_strTitle=strTitle;
				demo.m_xAxisTitle=strXTitle;

				demo.initialDateAxis(zedChart);			
			
				if ( demo == null )
					return false;			
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

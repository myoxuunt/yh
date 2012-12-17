using System;
using System.Windows;
using System.Windows.Forms;
using System.Data;

namespace CReportDll.comReport.newRep
{
	/// <summary>
	/// 报表管理
	/// </summary>
	public class cDealReport
	{
		
		public cDealReport()
		{		
		}

		#region"通用函数"

		public static bool replace2Str(ref DataTable dt)
		{
			if((dt==null)||(dt.Columns["time"]==null))
			{
				return true;
			}
			for(int i=0;i<dt.Rows.Count;i++)
			{
				if(dt.Rows[i]["time"].ToString().IndexOf("至")>=0)
				{
					dt.Rows[i]["time"]=dt.Rows[i]["time"].ToString().Replace("  "," ");
dt.Rows[i]["time"]=dt.Rows[i]["time"].ToString().Replace("   "," ");
				}
			}

			return true;
				  }

		private void clearNullDr(ref DataTable dt)
		{
			if(dt==null)
			{
				return;
			}

			for(int i=0;i<dt.Rows.Count;i++)
			{
				bool bHave=false;
				for(int j=0;j<dt.Columns.Count;j++)
				{
					if(dt.Columns[j].ColumnName!="wellName")
					{
						if(dt.Rows[i][j]==null||dt.Rows[i][j].ToString().Trim()=="")
						{
							continue;
						}
						bHave=true;
					}	
				}

				if(!bHave){
					dt.Rows.RemoveAt(i);
					i--;
				}
				
					  }
				  }

		public static string getMinTime(DataTable dt)
		{
			if((dt==null)||(dt.Rows.Count==0)||dt.Columns["time"]==null)
			{
				return "";
			}

			string strTime="";

			for(int i=0;i<dt.Rows.Count;i++)
			{
				string strTimeTemp=dt.Rows[i]["time"].ToString().Trim();
				if(strTimeTemp=="")
				{
					continue;
				}
				if(strTimeTemp.IndexOf("至")>=0)
				{
					string[] strs=strTimeTemp.Split('至');
					strTimeTemp=strs[0];
					//continue;
				}
				if(strTime=="")				
				{
					strTime=strTimeTemp;
					continue;
				}
				if(DateTime.Parse(strTime)<DateTime.Parse(strTimeTemp))
				{
					continue;
				}
				strTime=strTimeTemp;
			}

			return strTime;
		}

		public static string getMinTimeEx(DataTable dt)
		{
			if((dt==null)||(dt.Rows.Count==0)||dt.Columns["time"]==null)
			{
				return "";
			}

			string strTime="";

			for(int i=0;i<dt.Rows.Count;i++)
			{
				if(dt.Rows[i]["wellName"].ToString().IndexOf("合计")<0)continue;
				string strTimeTemp=dt.Rows[i]["time"].ToString().Trim();
				if(strTimeTemp=="")
				{
					continue;
				}
				if(strTimeTemp.IndexOf("至")>=0)
				{
					string[] strs=strTimeTemp.Split('至');
					strTimeTemp=strs[0];
					//continue;
				}
				if(strTime=="")				
				{
					strTime=strTimeTemp;
					continue;
				}
				if(DateTime.Parse(strTime)<DateTime.Parse(strTimeTemp))
				{
					continue;
				}
				strTime=strTimeTemp;
			}

			return strTime;
		}
		
		public static string getMaxTimeEx(DataTable dt)
		{
			if((dt==null)||(dt.Rows.Count==0)||dt.Columns["time"]==null)
			{
				return "";
			}

			string strTime="";

			for(int i=0;i<dt.Rows.Count;i++)
			{
				if(dt.Rows[i]["wellName"].ToString().IndexOf("合计")<0)continue;
				string strTimeTemp=dt.Rows[i]["time"].ToString().Trim();
				if(strTimeTemp=="")
				{
					continue;
				}
				if(strTimeTemp.IndexOf("至")>=0)
				{
					string[] strs=strTimeTemp.Split('至');
					strTimeTemp=strs[1];
					//continue;
				}
				if(strTime=="")				
				{
					strTime=strTimeTemp;
					continue;
				}
				if(DateTime.Parse(strTime)>DateTime.Parse(strTimeTemp))
				{
					continue;
				}
				strTime=strTimeTemp;
			}

			return strTime;
		}

		public static string getMaxTime(DataTable dt)
		{
			try
			{
				if((dt==null)||(dt.Rows.Count==0)||dt.Columns["time"]==null)
				{
					return "";
				}

				string strTime="";

				for(int i=0;i<dt.Rows.Count;i++)
				{
					string strTimeTemp=dt.Rows[i]["time"].ToString().Trim();
					if(strTimeTemp=="")
					{
						continue;
					}
					if(strTimeTemp.IndexOf("至")>=0)
					{
						string[] strs=strTimeTemp.Split('至');
						strTimeTemp=strs[1];
						//continue;
					}
					if(strTime=="")				
					{
						strTime=strTimeTemp;
						continue;
					}
					if(DateTime.Parse(strTime)>DateTime.Parse(strTimeTemp))
					{
						continue;
					}
					strTime=strTimeTemp;
				}

				return strTime;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return "";
			}			
		}

		public static bool bAllNum(string str)
		{
			str=str.Trim();

			if((str==null)||(str=="")||(str=="."))
			{
				return false;
			}

			char[] chars=str.ToCharArray();
			for(int i=0;i<chars.Length;i++)			
			{
				if(char.IsDigit(chars[i]))
				{
				}
				else
				{
					if(chars[i]=='.')
					{
					}
					else
					{
						if(chars[i]=='-')						
						{
						}
						else
						{
			return false;
						}
			
					}
				}
			}
					  return true;
		}

		private static bool changeTime(ref DataTable dt)
		{
			try
			{
				for(int i=0;i<dt.Rows.Count;i++)
				{
					string strTimeTemp=dt.Rows[i]["time"].ToString();
					dt.Rows[i]["time"]=dt.Rows[i]["time1"].ToString();
					dt.Rows[i]["time1"]=strTimeTemp;
				}
				return true;
			 }
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}

		public static void changeDataType(ref DataTable dt)
		{
			DataTable dtEx=dt.Clone();

			for(int i=0;i<dt.Columns.Count;i++)
			{
				dtEx.Columns[i].DataType=Type.GetType("System.String");
			}

			BengZhan.comReport.CReports.copyDtEx(dt,ref dtEx);		
			dt=dtEx.Copy();

			
				  }

		public static void clearTime(ref DataTable dt,bool bChangeTime)
		{
			try
			{

				if(dt.Columns["time"]==null)
				{
					return;
				}

				DataTable dtEx=dt.Clone();

				for(int i=0;i<dtEx.Columns.Count;i++)
				{
					dtEx.Columns[i].DataType=Type.GetType("System.String");
				}
						  //dtEx.Columns["time"].DataType=Type.GetType("System.String");
						  //	dtEx.Columns["time1"].DataType=Type.GetType("System.String");			

						  BengZhan.comReport.CReports.copyDtEx(dt,ref dtEx);	

				if(bChangeTime)
				{
					changeTime(ref dtEx);
				}

				dt=dtEx.Copy();

				for(int i=0;i<dt.Rows.Count;i++)
				{	
					if(dt.Columns["wellName"]==null)
					{
						continue;
					}
						
					string strWellName=dt.Rows[i]["wellName"].ToString().Trim();
					bool bCheck=true;

					if(strWellName.IndexOf("合计")>=0||strWellName.IndexOf("总计")>=0)
					{
						bCheck=false;
					}
			
					string strEndTime=dt.Rows[i]["time"].ToString();
					string strTime1=dt.Rows[i]["time1"].ToString().Trim();

					string strFromTime="";
					
					if(bCheck)
					{
						strFromTime=strTime1;
					}
					else
					{
						//strFromTime=strFrom;
					}									

					if(strEndTime.Trim()!="")
					{

						if(strFromTime.IndexOf(":")!=strFromTime.LastIndexOf(":"))
						{
							int iDexF=strFromTime.LastIndexOf(":");
							if(iDexF>=0)
							{
								strFromTime=strFromTime.Substring(0,iDexF);
							}
						}
						if(strEndTime.IndexOf(":")!=strEndTime.LastIndexOf(":"))
						{

							int iDexE=strEndTime.LastIndexOf(":");

							if(iDexE>=0)
							{
								strEndTime=strEndTime.Substring(0,iDexE);
							}
						}				
							string strTime=string.Format("{0} 至 {1}",strFromTime,strEndTime);
					
							dt.Rows[i]["time"]=strTime;	
					
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		private void clearTime(ref DataTable dt,string strFrom)
		
		{
			try
			{
				if(dt.Columns["time"]==null)
				{
					return;
				}

				DataTable dtEx=dt.Clone();
				dtEx.Columns["time"].DataType=Type.GetType("System.String");
						dtEx.Columns["time1"].DataType=Type.GetType("System.String");

				BengZhan.comReport.CReports.copyDtEx(dt,ref dtEx);		
				dt=dtEx.Copy();

			for(int i=0;i<dt.Rows.Count;i++)
				{	
						
				string strWellName=dt.Rows[i]["wellName"].ToString().Trim();
				bool bCheck=true;
				if(strWellName.IndexOf("合计")>=0||strWellName.IndexOf("总计")>=0)
				{
					bCheck=false;
				}
			
					string strEndTime=dt.Rows[i]["time"].ToString();
					string strTime1=dt.Rows[i]["time1"].ToString().Trim();

				string strFromTime="";
					
				if(bCheck)
				{
					strFromTime=strTime1;
				}
				else
				{
					strFromTime=strFrom;
				}

									

					if(strEndTime.Trim()!="")
					{

						if(strFromTime.IndexOf(":")!=strFromTime.LastIndexOf(":"))
						{
							int iDexF=strFromTime.LastIndexOf(":");
							if(iDexF>=0)
							{
								strFromTime=strFromTime.Substring(0,iDexF);
							}
							}
						if(strEndTime.IndexOf(":")!=strEndTime.LastIndexOf(":")){

							int iDexE=strEndTime.LastIndexOf(":");

							if(iDexE>=0)
							{
								strEndTime=strEndTime.Substring(0,iDexE);
							}
						}
						string strTime=string.Format("{0} 至 {1}",strFromTime,strEndTime);
						dt.Rows[i]["time"]=strTime;
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private string sumCol1(DataTable dt,int iCol)
		{
			try
			{
				double iSum=0;

				for(int i=0;i<dt.Rows.Count;i++)
				{
					if((dt.Rows[i]["time"].ToString().Trim().IndexOf("至")>=0))
					{
						if((dt.Columns[iCol]!=null)&&(dt.Columns[iCol].ColumnName.Trim()!="time"))
						{	
							if(bAllNum(dt.Rows[i][iCol].ToString().Trim()))
							{
								iSum+=double.Parse(dt.Rows[i][iCol].ToString());
							}						
						}
					}				
				}
				return iSum.ToString();
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return "";
			}
		}

		private string sumColEx(DataTable dt,int iCol)
		{
			try
			{
				double iSum=0;

				for(int i=0;i<dt.Rows.Count;i++)
				{
					if((dt.Rows[i][0].ToString().Trim().IndexOf("合计")>=0)||(dt.Rows[i][0].ToString().Trim().IndexOf("统计")>=0))
					{
						if((dt.Columns[iCol]!=null)&&(dt.Columns[iCol].ColumnName.Trim()!="time"))
						{	
							if(bAllNum(dt.Rows[i][iCol].ToString().Trim()))
							{
								iSum+=double.Parse(dt.Rows[i][iCol].ToString());
							}						
						}
					}				
				}
				return iSum.ToString();
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return "";
			}			
		}

		public void addSum1(ref DataTable dtAvgEx,int iRowIndex,string strDepName,string strTitle)
		{
			try
			{
				DataRow dr=dtAvgEx.NewRow();
				bool bHave=false;

				for(int i=0;i<dtAvgEx.Columns.Count;i++)
				{
					if((i!=0)&&(dtAvgEx.Columns[i].ColumnName!="time")&&(dtAvgEx.Columns[i].ColumnName!="salPer")&&(dtAvgEx.Columns[i].ColumnName!="price")&&(dtAvgEx.Columns[i].ColumnName!="allSalAmountBefore")&&(dtAvgEx.Columns[i].ColumnName!="allSalAmountAfter"))
					{
						try
						{
							dr[i]=this.sumCol1(dtAvgEx,i);
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.ToString()+dtAvgEx.Columns[i].ColumnName+i.ToString()+dtAvgEx.Columns.Count.ToString());
						}
						
					}
					else
					{
						dr[0]=strDepName+strTitle;
						string strMinTime=getMinTime(dtAvgEx);
						string strMaxTime=getMaxTime(dtAvgEx);
						dr["time"]=string.Format("{0} 至 {1}",strMinTime,strMaxTime);
					}	
					bHave=true;
			
				}

				if(bHave)
				{
					if(iRowIndex>=0)
					{
						dtAvgEx.Rows.InsertAt(dr,iRowIndex);
					}	
					else
					{
						dtAvgEx.Rows.Add(dr);
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}			
		}


		public void addSumEx(ref DataTable dtAvgEx,int iRowIndex,string strDepName)
		{
			try
			{
				DataRow dr=dtAvgEx.NewRow();
				bool bHave=false;

				for(int i=0;i<dtAvgEx.Columns.Count;i++)
				{
					if((i!=0)&&(dtAvgEx.Columns[i].ColumnName!="time")&&(dtAvgEx.Columns[i].ColumnName!="salPer")&&(dtAvgEx.Columns[i].ColumnName!="price")&&(dtAvgEx.Columns[i].ColumnName!="allSalAmountBefore")&&(dtAvgEx.Columns[i].ColumnName!="allSalAmountAfter"))
					{
						try
						{
							dr[i]=this.sumColEx(dtAvgEx,i);
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.ToString()+dtAvgEx.Columns[i].ColumnName+i.ToString()+dtAvgEx.Columns.Count.ToString());
						}
						
					}
					else
					{
						dr[0]=strDepName+"总计";
						//string strMinTime=getMinTimeEx(dtAvgEx);
						//string strMaxTime=getMaxTimeEx(dtAvgEx);
						//string strTime=string.Format("{0} 至 {1}",strMinTime.Trim(),strMaxTime.Trim());
						//dr["time"]=strTime;
					}	
					bHave=true;
			
				}

				if(bHave)
				{
					if(iRowIndex>=0)
					{
						dtAvgEx.Rows.InsertAt(dr,iRowIndex);
					}	
					else
					{
						dtAvgEx.Rows.Add(dr);
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}			
		}

		public void addSumEx1(ref DataTable dtAvgEx,int iRowIndex,string strDepName)
		{
			try
			{
				DataRow dr=dtAvgEx.NewRow();
				bool bHave=false;

				for(int i=0;i<dtAvgEx.Columns.Count;i++)
				{
					if((i!=0)&&(dtAvgEx.Columns[i].ColumnName!="time")&&(dtAvgEx.Columns[i].ColumnName!="salPer")&&(dtAvgEx.Columns[i].ColumnName!="price")&&(dtAvgEx.Columns[i].ColumnName!="allSalAmountBefore")&&(dtAvgEx.Columns[i].ColumnName!="allSalAmountAfter"))
					{
						try
						{
							dr[i]=this.sumColEx(dtAvgEx,i);
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.ToString()+dtAvgEx.Columns[i].ColumnName+i.ToString()+dtAvgEx.Columns.Count.ToString());
						}
						
					}
					else
					{
						dr[0]=strDepName+"总计";
						string strMinTime=getMinTimeEx(dtAvgEx);
						string strMaxTime=getMaxTimeEx(dtAvgEx);
						string strTime=string.Format("{0} 至 {1}",strMinTime.Trim(),strMaxTime.Trim());
						dr["time"]=strTime;
					}	
					bHave=true;
			
				}

				if(bHave)
				{
					if(iRowIndex>=0)
					{
						dtAvgEx.Rows.InsertAt(dr,iRowIndex);
					}	
					else
					{
						dtAvgEx.Rows.Add(dr);
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}			
		}



		private string sumCol(DataTable dt,int iCol)
		{
			try
			{
				double iSum=0;
				for(int i=0;i<dt.Rows.Count;i++)
				{
					if((dt.Columns[iCol]!=null)&&(dt.Columns[iCol].ColumnName.Trim()!="time")&&(dt.Columns[iCol].ColumnName.Trim()!="leftAmountCha"))
					{	
						try
						{	
							if(bAllNum(dt.Rows[i][iCol].ToString()))
							{
								if(cDealReport.bAllNum(dt.Rows[i][iCol].ToString()))
								{
									iSum+=double.Parse(dt.Rows[i][iCol].ToString());
								}
							}							
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.ToString()+"  "+dt.Rows[i][iCol].ToString());
						}
						
					}
				}
				return iSum.ToString();
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return "";
			}
			
		}

		private void addSum(ref DataTable dtAvgEx,string strDepName)
		{
			try
			{
		
				DataRow dr=dtAvgEx.NewRow();

				for(int i=0;i<dtAvgEx.Columns.Count;i++)
				{
					if((i!=0)&&(i!=(dtAvgEx.Columns.Count-1))&&(dtAvgEx.Columns[i].ColumnName!="time")&&(dtAvgEx.Columns[i].ColumnName!="salPer")&&(dtAvgEx.Columns[i].ColumnName!="price")&&(dtAvgEx.Columns[i].ColumnName!="allSalAmountBefore")&&(dtAvgEx.Columns[i].ColumnName!="allSalAmountAfter"))
					{
						try
						{
							dr[i]=this.sumCol(dtAvgEx,i);
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.ToString()+dtAvgEx.Columns[i].ColumnName+i.ToString()+dtAvgEx.Columns.Count.ToString());
						}
						
					}
					else
					{
						dr[0]=strDepName+"合计";
					}					
				}

				if(dtAvgEx.Rows.Count>0)
				{
					dtAvgEx.Rows.Add(dr);					
				}

                
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString().Trim());
			}
		}

		public void addSum(ref DataTable dtAvgEx,int iDex,string strDepName,double dXi)
		{
			try
			{
				DataRow dr=dtAvgEx.NewRow();

				for(int i=0;i<dtAvgEx.Columns.Count;i++)
				{
					if((i!=0)&&(i!=(dtAvgEx.Columns.Count-1))&&(dtAvgEx.Columns[i].ColumnName!="time")&&(dtAvgEx.Columns[i].ColumnName!="salPer")&&(dtAvgEx.Columns[i].ColumnName!="price")&&(dtAvgEx.Columns[i].ColumnName!="allSalAmountBefore")&&(dtAvgEx.Columns[i].ColumnName!="allSalAmountAfter"))
					{
						try
						{
							dr[i]=Convert.ToString(double.Parse(this.sumCol(dtAvgEx,i))*dXi);
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.ToString()+dtAvgEx.Columns[i].ColumnName+i.ToString()+dtAvgEx.Columns.Count.ToString());
						}
						
					}
					else
					{
						dr[0]=strDepName+"合计";
					}					
				}

				if(dtAvgEx.Rows.Count>0)
				{
					if(iDex>=0)
					{
						dtAvgEx.Rows.InsertAt(dr,iDex);	
					}
					else
					{
						dtAvgEx.Rows.Add(dr);
					}
									
				}                
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString().Trim());
			}
		}


		public void addSum(ref DataTable dtAvgEx,int iDex,string strDepName)
		{
			try
			{
				DataRow dr=dtAvgEx.NewRow();

				for(int i=0;i<dtAvgEx.Columns.Count;i++)
				{
					if((i!=0)&&(i!=(dtAvgEx.Columns.Count-1))&&(dtAvgEx.Columns[i].ColumnName!="time")&&(dtAvgEx.Columns[i].ColumnName!="salPer")&&(dtAvgEx.Columns[i].ColumnName!="price")&&(dtAvgEx.Columns[i].ColumnName!="allSalAmountBefore")&&(dtAvgEx.Columns[i].ColumnName!="allSalAmountAfter"))
					{
						try
						{
							dr[i]=this.sumCol(dtAvgEx,i);
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.ToString()+dtAvgEx.Columns[i].ColumnName+i.ToString()+dtAvgEx.Columns.Count.ToString());
						}
						
					}
					else
					{
						dr[0]=strDepName+"合计";
					}					
				}

				if(dtAvgEx.Rows.Count>0)
				{
					if(iDex>=0)
					{
						dtAvgEx.Rows.InsertAt(dr,iDex);	
					}
					else
					{
						dtAvgEx.Rows.Add(dr);
					}
									
				}                
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString().Trim());
			}
		}

		#endregion

		#region"总帐统计"

		#region"查询入口"

		public DataTable getStaticRepCountry(string strCountryName,string strFromTime,string strEndTime)
		{
			try
			{
				string strSql=string.Format("select depShortName from tbDep where CountryName='{0}'",strCountryName);
				DataTable dtDeps=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtDeps,strSql,"dt");
				DataTable dtCountry=new DataTable();

				for(int i=0;i<dtDeps.Rows.Count;i++)
				{
				
					string strDepName=dtDeps.Rows[i]["depShortName"].ToString().Trim();
					DataTable dtDep=this.getStaticRepDep(strDepName,strFromTime,strEndTime);		
					BengZhan.comReport.CReports.copyDt(dtDep,ref dtCountry);
				}

				if((dtCountry==null)||(dtCountry.Rows.Count==0))
				{
					return null;
				}

				//this.addSumEx(ref dtCountry,0);

				//dtCountry.Rows[0][0]=strCountryName+"总计";
				//dtCountry.Rows[0]["time"]=strEndTime;

				this.clearTime(ref dtCountry,strFromTime);
 
				return dtCountry;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return null;
			}
		}

		//单位
		public DataTable getStaticRepDepEx(string strDepName,string strFromTime,string strEndTime)
		{
			try
			{
				string strSql=string.Format("select wellName from tbWell where depName='{0}' order by wellNo",strDepName);
				DataTable dtWell=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtWell,strSql,"dt");
				DataTable dtShDep=new DataTable();

				//合计行
//				for(int i=0;i<dtWell.Rows.Count;i++)
//				{
//					string strWellName=dtWell.Rows[i]["wellName"].ToString().Trim();
//
//					CReportDll.comReport.newRep.cDealReport cdr=new cDealReport();
//					string[] strTime=null;
//
//					DataTable dtSh=	cdr.getStaticRepByE(strWellName,strFromTime,strEndTime,ref strTime);
//
//					if(strTime==null)
//					{
//						continue;
//					}					
//						
//					BengZhan.comReport.CReports.copyDt(dtSh,ref dtShDep);
//				}
//
//				if(dtShDep.Rows.Count==0)
//				{
//					return null;
//				}
//
//				this.addSum(ref dtShDep,"");
//
//				int iCount=dtShDep.Rows.Count-1;
//				for(int i=0;i<iCount;i++)				
//				{
//					dtShDep.Rows.RemoveAt(0);
//				}
//
//				if(dtShDep.Rows.Count==0)
//				{
//					return null;
//				}
//				
//				dtShDep.Rows[0][0]=strDepName+"合计";
//				dtShDep.Rows[0]["time"]=strEndTime;


				//站明细
				for(int i=0;i<dtWell.Rows.Count;i++)
				{
					string strWellName=dtWell.Rows[i]["wellName"].ToString().Trim();

					CReportDll.comReport.newRep.cDealReport cdr=new cDealReport();
					string[] strTime=null;

					DataTable dtSh=	cdr.getStaticRep(strWellName,strFromTime,strEndTime,ref strTime);

					if(strTime==null)
					{
						continue;
					}					
						
					BengZhan.comReport.CReports.copyDt(dtSh,ref dtShDep);
				}

				if(dtShDep.Rows.Count==0)
				{
					return null;
				}				
				
				this.addSum(ref dtShDep,-1,strDepName);
				this.clearTime(ref dtShDep,strFromTime);
				return dtShDep;


			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return null;
			}
		}


		//单位
		private DataTable getStaticRepDep(string strDepName,string strFromTime,string strEndTime)
		{
			try
			{
				string strSql=string.Format("select wellName from tbWell where depName='{0}' order by wellNo",strDepName);
				DataTable dtWell=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtWell,strSql,"dt");
				DataTable dtShDep=new DataTable();

				//合计行
//				for(int i=0;i<dtWell.Rows.Count;i++)
//				{
//					string strWellName=dtWell.Rows[i]["wellName"].ToString().Trim();
//
//					CReportDll.comReport.newRep.cDealReport cdr=new cDealReport();
//					string[] strTime=null;
//
//					DataTable dtSh=	cdr.getStaticRepByE(strWellName,strFromTime,strEndTime,ref strTime);
//
//					if(strTime==null)
//					{
//						continue;
//					}					
//						
//					BengZhan.comReport.CReports.copyDt(dtSh,ref dtShDep);
//				}
//
//				if(dtShDep.Rows.Count==0)
//				{
//					return null;
//				}
//
//				this.addSum(ref dtShDep,"");
//
//				int iCount=dtShDep.Rows.Count-1;
//				for(int i=0;i<iCount;i++)				
//				{
//					dtShDep.Rows.RemoveAt(0);
//				}
//
//				if(dtShDep.Rows.Count==0)
//				{
//					return null;
//				}
//				
//				dtShDep.Rows[0][0]=strDepName+"合计";
//				dtShDep.Rows[0]["time"]=strEndTime;


				//站明细
				for(int i=0;i<dtWell.Rows.Count;i++)
				{
					string strWellName=dtWell.Rows[i]["wellName"].ToString().Trim();

					CReportDll.comReport.newRep.cDealReport cdr=new cDealReport();
					string[] strTime=null;

					DataTable dtSh=	cdr.getStaticRep(strWellName,strFromTime,strEndTime,ref strTime);

					if(strTime==null)
					{
						continue;
					}			
		
					
						
					BengZhan.comReport.CReports.copyDt(dtSh,ref dtShDep);
				}

				if(dtShDep.Rows.Count==0)
				{
					return null;
				}				
this.addSum(ref dtShDep,-1,strDepName);
				//this.clearTime(ref dtShDep,strFromTime);
					return dtShDep;


			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return null;
			}
		}

		//站
		public DataTable getStaticRepEx(string strWellName,string strFromTime,string strEndTime,ref string[] strTimes)
		{
			try
			{
				DataTable dtRep=new DataTable();
				 strTimes=this.StaticRep(strWellName,strFromTime,strEndTime,ref dtRep);

				if(strTimes==null)
				{
					return null;
				}

				strFromTime=strTimes[0];
				strEndTime=strTimes[1];

				DataTable dtSalRep=new DataTable();
				this.StaticSalRep(strWellName,strFromTime,strEndTime,ref dtSalRep);

				DataTable dtRet=new DataTable();

				this.mergeDt(dtRep,dtSalRep,ref dtRet);

				this.clearTime(ref dtRet,strFromTime);

				return dtRet;
		
				//return dtSalRep;		
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return null;
			}
		}
		#endregion

		//站
		private DataTable getStaticRep(string strWellName,string strFromTime,string strEndTime,ref string[] strTimes)
		{
			try
			{
				DataTable dtRep=new DataTable();
				strTimes=this.StaticRep(strWellName,strFromTime,strEndTime,ref dtRep);

				if(strTimes==null)
				{
					return null;
				}

				strFromTime=strTimes[0];
				strEndTime=strTimes[1];

				DataTable dtSalRep=new DataTable();
				this.StaticSalRep(strWellName,strFromTime,strEndTime,ref dtSalRep);

				DataTable dtRet=new DataTable();

				this.mergeDt(dtRep,dtSalRep,ref dtRet);

				//this.clearTime(ref dtRet,strFromTime);

				return dtRet;
		
				//return dtSalRep;		
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return null;
			}
		}
		
//站
		private DataTable getStaticRepByE(string strWellName,string strFromTime,string strEndTime,ref string[] strTimes)
		{
			try
			{
				DataTable dtRep=new DataTable();
				 strTimes=this.StaticRep(strWellName,strFromTime,strEndTime,ref dtRep);

				if(strTimes==null)
				{
					return null;
				}

				DataTable dtSalRep=new DataTable();
				this.StaticSalRep(strWellName,strFromTime,strEndTime,ref dtSalRep);

				DataTable dtRet=new DataTable();

				this.mergeDt(dtRep,dtSalRep,ref dtRet);

				return dtRet;
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
				return null;
			}
		}

		private string[] StaticRep(string strWellName,string strFromTime,string strEndTime,ref DataTable dtRet)
		{
			try
			{
				string strSql=string.Format("select price1 from tbWell where wellName='{0}'",strWellName);
				string strPrice1=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();

				if(strPrice1=="")
				{
					return null;
				}

			 strSql=string.Format("select name wellName,(max(allBuyAmount)-min(allBuyAmount))allBuyAmount,(max(allMony)-min(allMony))allMony,(max(leftAmount)-min(leftAmount))leftAmount,(max(leftMony)-min(leftMony))leftMony,(max(allAmount)-min(allAmount))allAmount,cast((max(allAmount)-min(allAmount))as decimal(17,2))*{2} allUsedMony,max(time) time,min(time) time1 from waterDatasDay,tbWell where waterDatasDay.name=tbWell.wellName and time<='{0}' and time>='{3}' and wellName='{1}'  group by waterDatasDay.name",strEndTime,strWellName,strPrice1,strFromTime);

			//	DataTable dtRep=new DataTable();

				BengZhan.CDBConnection.getDataTable(ref dtRet,strSql,"dt");

				if(dtRet.Rows.Count==0)
				{
					return null;
				}
				else
				{
					string strTime=dtRet.Rows[0]["time"].ToString().Trim();
					string strTime1=dtRet.Rows[0]["time1"].ToString().Trim();
					string[] strTimes=new string[2];
					strTimes[0]=strTime1;
					strTimes[1]=strTime;
					return strTimes;
					//return strTime;
				}

				return null;

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return null;
			}

		}

		private bool StaticSalRep(string strWellName,string strFromTime,string strEndTime,ref DataTable dtRet)
		{
			try
			{
				string strSql=string.Format("select price1 from tbWell where wellName='{0}'",strWellName);
				string strPrice1=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();
				if(strPrice1=="")
				{
					return false;
				}

 strSql=string.Format("select '{1}' as wellName,sum(cast(salAmount as decimal(15,2))) allSalAmount,sum(cast(salAmount as decimal(15,2)))*{2} allSalMony,'{0}' time from tbWell,tbSal where tbWell.wellNo=tbSal.wellNo and tbWell.wellName='{1}' and  time<='{0}' and time>='{3}'",strEndTime,strWellName,strPrice1,strFromTime);
				BengZhan.CDBConnection.getDataTable(ref dtRet,strSql,"dt");

				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}

		private bool mergeDt(DataTable dtAm,DataTable dtSa,ref DataTable dtRet)
		{
			try
			{
				if(dtAm.Rows.Count<=0)
				{
					return false;
				}

				BengZhan.comReport.CReports.copyDt(dtAm,ref dtRet);

				for(int i=0;i<dtRet.Rows.Count;i++)
				{
					string strWellName=dtRet.Rows[i]["wellName"].ToString().Trim();

                    string strAllSalAmount="";
					string strAllSalMony="";

					for(int j=0;j<dtSa.Rows.Count;j++)
					{
						if(dtSa.Rows[j]["wellName"].ToString().Trim()==strWellName)						
						{
							strAllSalAmount=dtSa.Rows[j]["allSalAmount"].ToString();
							strAllSalMony=dtSa.Rows[j]["allSalMony"].ToString();
							if(strAllSalAmount.Trim()=="")
							{
								strAllSalAmount="0";
								strAllSalMony="0";
							}
						}
					}

					if(strAllSalAmount.Trim()!="")
					{
						double dAllSalAmount=double.Parse(strAllSalAmount);
						double dAllSalMony=double.Parse(strAllSalMony);
						double dAllAmount=double.Parse(dtRet.Rows[i]["allAmount"].ToString());
						double dAllMony=double.Parse(dtRet.Rows[i]["allUsedMony"].ToString().Trim());
						double dLeftAmount=dAllSalAmount-dAllAmount;
						double dLeftMony=dAllSalMony-dAllMony;
						dtRet.Rows[i]["leftAmount"]=dLeftAmount.ToString();
						dtRet.Rows[i]["leftMony"]=dLeftMony.ToString();
						dtRet.Rows[i]["allBuyAmount"]=dAllSalAmount.ToString();
						dtRet.Rows[i]["allMony"]=dAllSalMony.ToString();
						//return true;
					}	
					else
					{
						//dtRet.Rows[i]["leftAmount"]="";
					//	dtRet.Rows[i]["leftMony"]="";
					}
				}				

				 return false;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}
		#endregion

		#region"截止时间总帐"

		public DataTable getStaticRepCountry(string strCountryName,string strEndTime)
		{
			try
			{
				string strSql=string.Format("select depShortName from tbDep where CountryName='{0}'",strCountryName);
				DataTable dtDeps=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtDeps,strSql,"dt");
				DataTable dtCountry=new DataTable();

				for(int i=0;i<dtDeps.Rows.Count;i++)
				{
				
					string strDepName=dtDeps.Rows[i]["depShortName"].ToString().Trim();
					DataTable dtDep=this.getStaticRepDep(strDepName,strEndTime);		
					BengZhan.comReport.CReports.copyDt(dtDep,ref dtCountry);
				}

				if((dtCountry==null)||(dtCountry.Rows.Count==0))
				{
					return null;
				}

//				this.addSumEx(ref dtCountry,0);
//
//				dtCountry.Rows[0][0]=strCountryName+"总计";
//				dtCountry.Rows[0]["time"]=strEndTime;

				//this.addStaticSalRep(

				//this.clearTime(ref dtCountry,strFromTime);
 
				return dtCountry;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return null;
			}
		}

		//单位
		public DataTable getStaticRepDepEx(string strDepName,string strEndTime)
		{
			try
			{
				string strSql=string.Format("select wellName from tbWell where depName='{0}' order by wellNo",strDepName);
				DataTable dtWell=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtWell,strSql,"dt");
				DataTable dtShDep=new DataTable();

				//合计行
//				for(int i=0;i<dtWell.Rows.Count;i++)
//				{
//					string strWellName=dtWell.Rows[i]["wellName"].ToString().Trim();
//
//					CReportDll.comReport.newRep.cDealReport cdr=new cDealReport();
//					string strTime=null;
//
//					DataTable dtSh=	cdr.getStaticRepByE(strWellName,strEndTime,ref strTime);
//
//					if(strTime.Trim()=="")
//					{
//						continue;
//					}					
//						
//					BengZhan.comReport.CReports.copyDt(dtSh,ref dtShDep);
//				}
//
//				if(dtShDep.Rows.Count==0)
//				{
//					return null;
//				}
//
//				this.addSum(ref dtShDep,"");
//
//				int iCount=dtShDep.Rows.Count-1;
//				for(int i=0;i<iCount;i++)				
//				{
//					dtShDep.Rows.RemoveAt(0);
//				}
//
//				if(dtShDep.Rows.Count==0)
//				{
//					return null;
//				}
//				
//				dtShDep.Rows[0][0]=strDepName+"合计";
//				dtShDep.Rows[0]["time"]=strEndTime;


				//站明细
				for(int i=0;i<dtWell.Rows.Count;i++)
				{
					string strWellName=dtWell.Rows[i]["wellName"].ToString().Trim();

					CReportDll.comReport.newRep.cDealReport cdr=new cDealReport();
					string strTime=null;

					DataTable dtSh=	cdr.getStaticRep(strWellName,strEndTime,ref strTime);

					if(strTime.Trim()=="")
					{
						continue;
					}					
						
					BengZhan.comReport.CReports.copyDt(dtSh,ref dtShDep);
				}

				if(dtShDep.Rows.Count==0)
				{
					return null;
				}			
	
				this.addSum(ref dtShDep,-1,strDepName);
				this.addTime(ref dtShDep);


				for(int i=0;i<dtShDep.Rows.Count;i++)
				{
					Console.WriteLine(dtShDep.Rows[i]["wellName"].ToString());
					Console.WriteLine(dtShDep.Rows[i]["allUsedMony"].ToString());
				}

						  //this.clearTime(ref dtShDep,strFromTime);
						  return dtShDep;


			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return null;
			}
		}

		//private 

		//单位
		private DataTable getStaticRepDep(string strDepName,string strEndTime)
		{
			try
			{
				string strSql=string.Format("select wellName from tbWell where depName='{0}' order by wellNo",strDepName);
				DataTable dtWell=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtWell,strSql,"dt");
				DataTable dtShDep=new DataTable();

				//合计行
//				for(int i=0;i<dtWell.Rows.Count;i++)
//				{
//					string strWellName=dtWell.Rows[i]["wellName"].ToString().Trim();
//
//					CReportDll.comReport.newRep.cDealReport cdr=new cDealReport();
//					string strTime=null;
//
//					DataTable dtSh=	cdr.getStaticRepByE(strWellName,strEndTime,ref strTime);
//
//					if(strTime.Trim()=="")
//					{
//						continue;
//					}					
//						
//					BengZhan.comReport.CReports.copyDt(dtSh,ref dtShDep);
//				}
//
//				if(dtShDep.Rows.Count==0)
//				{
//					return null;
//				}
//
//				this.addSum(ref dtShDep,"");
//
//				int iCount=dtShDep.Rows.Count-1;
//				for(int i=0;i<iCount;i++)				
//				{
//					dtShDep.Rows.RemoveAt(0);
//				}
//
//				if(dtShDep.Rows.Count==0)
//				{
//					return null;
//				}
//				
//				dtShDep.Rows[0][0]=strDepName+"合计";
//				dtShDep.Rows[0]["time"]=strEndTime;


				//站明细
				for(int i=0;i<dtWell.Rows.Count;i++)
				{
					string strWellName=dtWell.Rows[i]["wellName"].ToString().Trim();

					CReportDll.comReport.newRep.cDealReport cdr=new cDealReport();
					string strTime=null;

					DataTable dtSh=	cdr.getStaticRep(strWellName,strEndTime,ref strTime);

					if(strTime.Trim()=="")
					{
						continue;
					}					
						
					BengZhan.comReport.CReports.copyDt(dtSh,ref dtShDep);
				}

				if(dtShDep.Rows.Count==0)
				{
					return null;
				}	
			
				this.addSum(ref dtShDep,-1,strDepName);
				this.addTime(ref dtShDep);

				//this.clearTime(ref dtShDep,strFromTime);
				return dtShDep;


			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return null;
			}
		}

		public void addTime(ref DataTable dt,bool bHaveZ)
		{
			try
			{
				if((dt==null)||(dt.Columns["time"]==null))
				{
					return;
				}
				if(dt.Columns["time"].DataType!=Type.GetType("System.String"))
				{			
					return;
				}
				if(dt.Rows.Count>1)
				{
					string strMinTime=getMinTime(dt);
				
					string strMaxTime=getMaxTime(dt);

					for(int i=0;i<dt.Rows.Count;i++)
					{
						if(dt.Rows[i][0].ToString().IndexOf("合计")>=0)
						{
							 dt.Rows[i]["time"]=string.Format("{0} 至 {1}",strMinTime,strMaxTime);
						}						
					}						 
		
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return;
			}
			
		}

		private void addTime(ref DataTable dt)
		{
			if(dt.Rows.Count>1)
			{
				string strMaxTime=getMaxTime(dt);
				dt.Rows[0]["time"]=strMaxTime;
			}
		}

		//站
		public DataTable getStaticRepEx(string strWellName,string strEndTime,ref string strTimes)
		{
			try
			{
				DataTable dtRep=new DataTable();
				strTimes=this.StaticRep(strWellName,strEndTime,ref dtRep);

				if(strTimes.Trim()=="")
				{
					return null;
				}

			//	strFromTime=strTimes[0];
				strEndTime=strTimes;

				DataTable dtSalRep=new DataTable();
				this.StaticSalRep(strWellName,strEndTime,ref dtSalRep);

				DataTable dtRet=new DataTable();

				this.mergeDt(dtRep,dtSalRep,ref dtRet);

			//	this.clearTime(ref dtRet,strFromTime);

				return dtRet;
		
				//return dtSalRep;		
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return null;
			}
		}

		//站
		private DataTable getStaticRepByE(string strWellName,string strEndTime,ref string strTimes)
		{
			try
			{
				DataTable dtRep=new DataTable();
				strTimes=this.StaticRep(strWellName,strEndTime,ref dtRep);

				if(strTimes.Trim()=="")
				{
					return null;
				}

				DataTable dtSalRep=new DataTable();
				this.StaticSalRep(strWellName,strEndTime,ref dtSalRep);

				DataTable dtRet=new DataTable();

				this.mergeDt(dtRep,dtSalRep,ref dtRet);

				return dtRet;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return null;
			}
		}


		//站
		private DataTable getStaticRep(string strWellName,string strEndTime,ref string strTimes)
		{
			try
			{
				string strEndTimeEx=strEndTime;

				DataTable dtRep=new DataTable();
				strTimes=this.StaticRep(strWellName,strEndTime,ref dtRep);

				if(strTimes.Trim()=="")
				{
					return null;
				}	
	
				strEndTime=strTimes;


				DataTable dtSalRep=new DataTable();
				this.StaticSalRep(strWellName,strEndTime,ref dtSalRep);

				DataTable dtRet=new DataTable();

				this.mergeDt(dtRep,dtSalRep,ref dtRet);

				//this.clearTime(ref dtRet,strFromTime);

				this.addStaticSalRep(strWellName,strEndTime,strEndTimeEx,ref dtRet);

				return dtRet;
		
				//return dtSalRep;		
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return null;
			}
		}	
		
		private string StaticRep(string strWellName,string strEndTime,ref DataTable dtRet)
		{
			try
			{
				string strSql=string.Format("select price1 from tbWell where wellName='{0}'",strWellName);
				string strPrice1=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();

				if(strPrice1=="")
				{
					return "";
				}

				strSql=string.Format("select name wellName,(max(allBuyAmount)-min(allBuyAmount))allBuyAmount,(max(allMony)-min(allMony))allMony,(max(leftAmount)-min(leftAmount))leftAmount,(max(leftMony)-min(leftMony))leftMony,(max(allAmount)-min(allAmount))allAmount,cast((max(allAmount)-min(allAmount))as decimal(17,2))*{2} allUsedMony,max(time) time,min(time) time1 from waterDatasDay where Name='{1}' and  time<='{0}'  group by waterDatasDay.name",strEndTime,strWellName,strPrice1);

				//	DataTable dtRep=new DataTable();

				BengZhan.CDBConnection.getDataTable(ref dtRet,strSql,"dt");

				if(dtRet.Rows.Count==0)
				{
					return "";
				}
				else
				{
					string strTime=dtRet.Rows[0]["time"].ToString().Trim();
					string strTime1=dtRet.Rows[0]["time1"].ToString().Trim();
					string[] strTimes=new string[2];
					strTimes[0]=strTime;
					strTimes[1]=strTime1;
				return strTimes[0];
					//return strTime;
				}

				return "";

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return "";
			}

		}

		private bool StaticSalRep(string strWellName,string strEndTime,ref DataTable dtRet)
		{
			try
			{
				string strSql=string.Format("select price1 from tbWell where wellName='{0}'",strWellName);
				string strPrice1=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();
				if(strPrice1=="")
				{
					return false;
				}

				strSql=string.Format("select '{1}' as wellName,sum(cast(salAmount as decimal(15,2))) allSalAmount,sum(cast(salAmount as decimal(15,2)))*{2} allSalMony,'{0}' time from tbWell,tbSal where tbWell.wellNo=tbSal.wellNo and tbWell.wellName='{1}' and  time<='{0}' ",strEndTime,strWellName,strPrice1);
				BengZhan.CDBConnection.getDataTable(ref dtRet,strSql,"dt");

				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}

		#endregion

		#region"添加读取失败"

		private bool addStaticSalRep(string strWellName,string strFromTime,string strEndTime,ref DataTable dtRet)
		{
			try
			{
				DataTable dtEx=dtRet.Clone();

				for(int i=0;i<dtEx.Columns.Count;i++)
				{
					dtEx.Columns[i].DataType=Type.GetType("System.String");
				}					

				BengZhan.comReport.CReports.copyDtEx(dtRet,ref dtEx);		
				dtRet=dtEx.Copy();


				if(DateTime.Parse(strEndTime)<=DateTime.Parse(strFromTime))
				{
					return true;
				}

				string strSql=string.Format("select price1 from tbWell where wellName='{0}'",strWellName);
				string strPrice1=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();
				if(strPrice1=="")
				{
					return false;
				}
				
				dtEx=new DataTable();
				strSql=string.Format("select '{1}' as wellName,sum(cast(salAmount as decimal(15,2))) allSalAmount,sum(cast(salAmount as decimal(15,2)))*{2} allSalMony, min(time) time,max(time) time1 from tbWell,tbSal where tbWell.wellNo=tbSal.wellNo and tbWell.wellName='{1}' and  time<='{0}' and time>'{3}'",strEndTime,strWellName,strPrice1,strFromTime);
				BengZhan.CDBConnection.getDataTable(ref dtEx,strSql,"dt");

				if(dtEx.Rows.Count==0)				
				{
					return true;
				}

				for(int i=0;i<dtEx.Rows.Count;i++)				
				{
					if(dtEx.Rows[i]["allSalAmount"]==null||dtEx.Rows[i]["allSalAmount"].ToString().Trim()=="")
					{
						continue;
					}

					DataRow dr =dtRet.NewRow();
					dr["wellName"]=strWellName;
					dr["allMony"]=dtEx.Rows[i]["allSalMony"].ToString().Trim();
					dr["allBuyAmount"]=dtEx.Rows[i]["allSalAmount"].ToString().Trim();

					string strTimeTemp=dtEx.Rows[i]["time"].ToString().Trim();
					string strTimeTemp1=dtEx.Rows[i]["time1"].ToString().Trim();
					DateTime dt1=DateTime.Parse(strTimeTemp1);
					strEndTime=dt1.AddHours(1).ToString();

					int iDex1=strTimeTemp.LastIndexOf(":");
					int iDex2=strEndTime.LastIndexOf(":");
					dr["time"]=string.Format("{0} 至 {1}",strTimeTemp.Substring(0,iDex1),strEndTime.Substring(0,iDex2));
					dr["allAmount"]=frmMonthStac.m_strDispErrInfo;
					dr["allUsedMony"]=frmMonthStac.m_strDispErrInfo;
					dr["leftAmount"]=dr["allBuyAmount"].ToString();
					dr["leftMony"]=dr["allMony"].ToString();
					dtRet.Rows.Add(dr);

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

		#region"明细"

		#region"截止时间售水明细"

		private bool clearAllSalesByTime(ref DataTable dt,string strTime)
		{
			try
			{
				if((dt==null)||(dt.Rows.Count==0)||(dt.Columns["time"]==null))
				{
					return false;
				}
				for(int i=0;i<dt.Rows.Count;i++					)
				{
					string strTimeTemp=dt.Rows[i]["time"].ToString();
					if(DateTime.Parse(strTimeTemp)>DateTime.Parse(strTime))
					{
						dt.Rows.RemoveAt(i);
						i--;
					}
				}
				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}
		
		private DataTable getSalDetailDep()
		{
			return null;
		}

		public DataTable getAllSalesDep(string strDepName,string strFromTime,string strToTime)
		{

			try
			{
				string strSql=string.Format("select distinct month(time) mon,year(time) yea from tbSal,tbWell where tbSal.wellNo=tbSal.wellNo and  depName='{0}' and time>='{1}' and time<='{2}'  order by year(time) desc,month(time) desc",strDepName,strFromTime,strToTime);
				DataTable dtMonth=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtMonth,strSql,"dtMonth");

				DataTable dtShow=new DataTable();
				DataTable dtRep=new DataTable();

				for(int j=0;j<dtMonth.Rows.Count;j++)
				{				

					string strYear=dtMonth.Rows[j]["yea"].ToString().Trim();
					string strMonth=dtMonth.Rows[j]["mon"].ToString().Trim();				

					strSql=string.Format("select wellName,cast(price as nvarchar(10)),salMony,salAmount,time,salPer,allSalAmount as allSalAmountAfter,(allSalAmount-salAmount) as allSalAmountBefore from tbWell,tbSal where tbSal.wellNo=tbWell.wellNo and depName='{0}' and year(time)='{1}' and month(time)='{2}' order by time",strDepName,strYear,strMonth);

					DataTable dtDetail=new DataTable();

					BengZhan.CDBConnection.getDataTable(ref dtDetail,strSql,"dt");
					//if(!	this.clearAllSalesByTime(ref dtDetail,strTimeS))continue;
					this.addSum(ref dtDetail,strDepName);		
					BengZhan.comReport.CReports.copyDt(dtDetail,ref dtRep);
				}

				//+++++++++++++++++++++++++++++++++++
					
				this.addSumEx(ref dtRep,-1,strDepName);
				return dtRep;
			
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return null;
			}
		}


		public DataTable getAllSalesDep(string strDepName,string strTimeS)
		{

			try
			{
				string strSql=string.Format("select distinct month(time) mon,year(time) yea from tbSal,tbWell where tbSal.wellNo=tbSal.wellNo and  depName='{0}' and time<='{1}'  order by year(time) desc,month(time) desc",strDepName,strTimeS);
				DataTable dtMonth=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtMonth,strSql,"dtMonth");

				DataTable dtShow=new DataTable();
				DataTable dtRep=new DataTable();

				for(int j=0;j<dtMonth.Rows.Count;j++)
				{				

					string strYear=dtMonth.Rows[j]["yea"].ToString().Trim();
					string strMonth=dtMonth.Rows[j]["mon"].ToString().Trim();				

					strSql=string.Format("select wellName,price,salMony,salAmount,time,salPer,allSalAmount as allSalAmountAfter,(allSalAmount-salAmount) as allSalAmountBefore from tbWell,tbSal where tbSal.wellNo=tbWell.wellNo and depName='{0}' and year(time)='{1}' and month(time)='{2}' order by time",strDepName,strYear,strMonth);

					DataTable dtDetail=new DataTable();

					BengZhan.CDBConnection.getDataTable(ref dtDetail,strSql,"dt");
					if(!	this.clearAllSalesByTime(ref dtDetail,strTimeS))continue;
					this.addSum(ref dtDetail,strDepName);		
					BengZhan.comReport.CReports.copyDt(dtDetail,ref dtRep);
				}

				//+++++++++++++++++++++++++++++++++++
					
				this.addSumEx(ref dtRep,-1,strDepName);
				return dtRep;
			
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return null;
			}
		}

//		private DataTable getSalDetailDep()
//		{
//			return null;
//		}

		private DataTable getSalDetail(string strWellName,string strEndTime)
		{
			try
			{
				DataTable dtDetail=new DataTable();
				this.StaticSaDetail(strWellName,strEndTime,ref dtDetail);
				return dtDetail;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return null;
			}
		}

		private bool StaticSaDetail(string strWellName,string strEndTime,ref DataTable dtDetail)
		{
			try
			{
				string strSql=string.Format("select salAmount,salMony from tbSal,tbWell where tbSal.wellNo=tbWell.wellNo and time<='{0}' and wellName='{1}' order by time",strEndTime,strWellName);
				BengZhan.CDBConnection.getDataTable(ref dtDetail,strSql,"dt");
				
				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		} 

		#endregion

		#region"流量明细"
		#region"流量明细"

		#region"单位截止时间"		

	
		public DataTable getDepDetailByEnd(string strDepName,string strEndTime) 
		{
			try
			{
			string	 strSql=string.Format("select time from tbMinTime");
				string strFromTime=BengZhan.CDBConnection.ExecuteScalar(strSql);
                
				DataTable  dtDetail=this.getDepDetailByEnd(strDepName,strFromTime,strEndTime);

				dtDetail.Columns.Add("leftAmountIC");
				

//				for(int i=0;i<dtDetail.Rows.Count;i++)
//				{
//					string strTime=dtDetail.Rows[i]["time"].ToString().Trim();
//					string strWellName=dtDetail.Rows[i]["wellName"].ToString().Trim();
//					string strAllAmount=dtDetail.Rows[i]["allAmount"].ToString().Trim();
//
//					strSql=string.Format("select price1 from tbWell where wellName='{0}'",strWellName);
//					string strPrice=BengZhan.CDBConnection.ExecuteScalar(strSql);
//
//					if((strPrice==null)||strPrice.Trim()=="")
//					{
//						continue;
//					}
//
////					if((strTime.Trim().Length!=16)&&(strTime.Trim().Length!=19))
////					{
////						continue;
////					}
////
////					strSql=string.Format("select max(cast(allSalAmount as decimal(19,2))) from tbSal,tbWell  where tbWell.wellNo=tbSal.wellNo and wellName='{0}' and time<='{1}'",strWellName,strTime);
////					string strAllSalAmount=BengZhan.CDBConnection.ExecuteScalar(strSql).Trim();			
////
////					if((strAllSalAmount==null)||strAllSalAmount.Trim()=="")
////					{
////						continue;
////					}
////
//double dPrice=double.Parse(strPrice);
////
////					double dAllSalAmount=double.Parse(strAllSalAmount);
//double dAllAmount=double.Parse(strAllAmount);
//					double dAllMony=dAllAmount*dPrice;
////					double dLeftAmount=dAllSalAmount-dAllAmount;
////
////					dtDetail.Rows[i]["leftAmountIC"]=dLeftAmount.ToString();
//					dtDetail.Rows[i]["usedMony"]=dAllMony.ToString();
//					Console.WriteLine(strWellName);
//					Console.WriteLine(strTime);
//					Console.WriteLine(dAllMony.ToString());
//					
//				}		

				return dtDetail;
				//return dtDepDetail; 
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return null;
			}
		}



		public DataTable getDepDetailByEnd1(string strDepName,string strFromTime,string strEndTime)
		{
			try
			{
				string strTime1=strFromTime;
				string strTime2=strEndTime;
				
				DataTable dtDetail=new DataTable();

				int i=0;
				DateTime dtFrom=DateTime.Parse(strFromTime);
				DateTime dtTo=DateTime.Parse(strEndTime);

				//int 	iMonth=(dtTo.Year-dtFrom.Year)*12+dtTo.Month-dtFrom.Month;//new add for desc				
		
						frmReport frmRep=new frmReport();
						DataTable dtRet=new DataTable();
						frmRep.detailRepDep(ref dtRet,strFromTime,strEndTime,strDepName);

						this.clearNullDr(ref dtRet);
				if(dtRet==null)
				{
					return null;
				}
						if(dtRet.Rows.Count==0)
						{
							
						}
						else
						{
							this.addSum1(ref dtRet,-1,strDepName,"合计");
							BengZhan.comReport.CReports.copyDt(dtRet,ref dtDetail);			
						}				

				this.addSumEx1(ref dtDetail,-1,strDepName);
				
				return dtDetail;				
			}
			catch(Exception ex)
			
			{
				MessageBox.Show(ex.ToString());
				return null;
			}
			
		}


		public DataTable getDepDetailByEnd(string strDepName,string strFromTime,string strEndTime)
		{
			try
			{
				string strTime1=strFromTime;
				string strTime2=strEndTime;
				
				DataTable dtDetail=new DataTable();

				int i=0;
				DateTime dtFrom=DateTime.Parse(strFromTime);
				DateTime dtTo=DateTime.Parse(strEndTime);

			int 	iMonth=(dtTo.Year-dtFrom.Year)*12+dtTo.Month-dtFrom.Month;//new add for desc

				//while(dtFrom.AddMonths(i)<=dtTo)		//new delete for desc		
				for(i=iMonth;i>=0;i--)//new add for desc
				{		
					if(i==0)
					{
						string strFromEx=strFromTime;
						strFromTime=string.Format("{0}-{1}-1 23:59",dtFrom.Year.ToString(),dtFrom.Month.ToString());
						dtFrom=DateTime.Parse(strFromTime);
						dtFrom=dtFrom.AddMonths(1).AddDays(-1);
						
						string strEndEx=string.Format("{0}-{1}-{2} 23:00",dtFrom.Year.ToString(),dtFrom.Month.ToString(),dtFrom.Day.ToString());
						if(DateTime.Parse(strEndEx)>=dtTo)
						{
							strEndEx=dtTo.ToString();
						}
						frmReport frmRep=new frmReport();
						DataTable dtRet=new DataTable();
						frmRep.detailRepDep(ref dtRet,strFromEx,strEndEx,strDepName);
					this.clearNullDr(ref dtRet);
						if(dtRet.Rows.Count==0)
						{
							
						}
						else
						{
							this.addSum1(ref dtRet,-1,strDepName,"合计");
							BengZhan.comReport.CReports.copyDt(dtRet,ref dtDetail);			
						}						
					}
					else
					{
						string strFromEx=string.Format("{0}-{1}-1",dtFrom.AddMonths(i).Year,dtFrom.AddMonths(i).Month);
						//dtFrom=DateTime.Parse(strFromEx);

						DateTime dtTemp=DateTime.Parse(strFromEx);

						string strEndEx=string.Format("{0}-{1}-{2} 23:59",dtTemp.Year.ToString(),dtTemp.Month.ToString(),dtTemp.AddMonths(1).AddDays(-1).Day);
						if(DateTime.Parse(strEndEx)>=dtTo)
						{
							strEndEx=dtTo.ToString();
						}
						frmReport frmRep=new frmReport();
						DataTable dtRet=new DataTable();
						frmRep.detailRepDep(ref dtRet,strFromEx,strEndEx,strDepName);
						this.clearNullDr(ref dtRet);
						if(dtRet.Rows.Count==0)
						{
						}
						else
						{
							this.addSum1(ref dtRet,-1,strDepName,"合计");
							BengZhan.comReport.CReports.copyDt(dtRet,ref dtDetail);
						}					
					}	
					//i++;
				}

				this.addSumEx1(ref dtDetail,-1,strDepName);
				
				return dtDetail;
				
			}

			catch(Exception ex)
			
			{
				MessageBox.Show(ex.ToString());
				return null;
			}
			
		}

		#endregion

		#endregion
		#endregion
		#endregion

		
				
	}
}

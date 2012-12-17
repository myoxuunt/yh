using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Windows;
using System.IO;
using System.Xml ;

namespace BengZhan.AutoBackup
{
	/// <summary>
	/// CAutoBackup 的摘要说明。
	/// </summary>
	public class CAutoBackup
	{
		public static SqlConnection m_sCon;

		public CAutoBackup()
		{		
		}
		public void iniCon()
		{
			if(CAutoBackup.m_sCon==null)
			{
				string strScon=@"server=.\waterSysClient;database=dbBengZhan;uid=sa;pwd=sa";
				SqlConnection sCon=new SqlConnection(strScon);
				sCon.Open();
				CAutoBackup.m_sCon=sCon;
			}
		}
		public void getFileName(ref string strFileName)
		{
			SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
			sCon.Open();
			SqlCommand sCmd=new SqlCommand();
			sCmd.Connection=sCon;
			string strSql="select fileName from dataBaseBack";
			sCmd.CommandText=strSql;
			if(sCmd.ExecuteScalar()!=null)
			{
				strFileName=sCmd.ExecuteScalar().ToString().Trim();
			}
			else
			{
				strFileName="";
			}
			sCon.Close();
			
		}
		public void autoBackup()
		{
			try
			{
				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();
				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;				
				sCmd.CommandText="select dtBackup from tbBack";

				string strSql="select dtBackup from tbBack";
				sCmd.CommandText =strSql;
				if(sCmd.ExecuteScalar()==null)
				{
					//this.Cursor=Cursors.WaitCursor; 
					
					string strErr="";
					string strFileName="";
					if(backUp(ref strErr,ref strFileName)==false)
					{
						//this.Cursor =Cursors.Default ;
						MessageBox.Show(strErr);
					}
					else
					{
						if(strFileName.Trim()=="")
						{
							return;
						}
						//string strInfo=String.Format("数据库备份完成！备份文件为{0}！",strFileName);
					//	MessageBox.Show(strInfo);
					}
					sCmd.CommandText="insert into tbBack values(getdate())";
					sCmd.ExecuteNonQuery();
				}
				else
				{
					string strNow=sCmd.ExecuteScalar().ToString();
					sCmd.CommandText="select getdate()";
					string strNowDate=sCmd.ExecuteScalar().ToString();
					if(strNow.Substring(0,strNow.IndexOf(" "))!=strNowDate.Substring(0,strNowDate.IndexOf(" ")))
					{
						//this.Cursor=Cursors.WaitCursor; 
						
						string strErr="";
						string strFileName="";
						if(backUp(ref strErr,ref strFileName)==false)
						{
							//this.Cursor =Cursors.Default ;
							MessageBox.Show(strErr);
						}
						else
						{
							if(strFileName.Trim()=="")
							{
								return;
							}
							//string strInfo=String.Format("数据库备份完成！备份文件为{0}!",strFileName);
							//MessageBox.Show(strInfo);
						}
						sCmd.CommandText="update tbBack set dtBackup=getdate()";
						sCmd.ExecuteNonQuery();
					}
				}
				sCon.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
					
		}
		//备份数据库
		public bool backUp(ref string strErr,ref string strFileNameEx)
		{
			try
			{
				XmlDocument xDoc=new   XmlDocument();
				xDoc.Load("Info.xml");

				string strDir=xDoc.DocumentElement.SelectSingleNode("./directory").Attributes.GetNamedItem("val").Value.Trim();
				string strDirFile=xDoc.DocumentElement.SelectSingleNode("./directory").Attributes.GetNamedItem("file").Value.Trim();

				if(xDoc.DocumentElement.SelectSingleNode("./allowBack").Attributes.GetNamedItem("val").Value.Trim()=="true")
				{
				}
				else
				{
					return false;
				}

				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();
			
				SqlCommand sCmd=new SqlCommand();
				string strSql="select dataBaseName,fileName from dataBaseBack";
				sCmd.CommandText =strSql;
				sCmd.Connection =sCon ;
				SqlDataReader sdr=sCmd.ExecuteReader();
				
				string strDBName="";
				string strFileName="";

				while(sdr.Read())
				{
					strDBName=sdr.GetString(sdr.GetOrdinal("dataBaseName"));
					strFileName=sdr.GetString(sdr.GetOrdinal("fileName"));
					strFileNameEx=strFileName;
				}
				sdr.Close();

				if(File.Exists(strFileName))
				{
					File.Delete(strFileName);
				}
				else
				{
					strFileNameEx="";
					return true;
				}				

				sCmd.CommandText="pr_backup_db";
				sCmd.CommandType=CommandType.StoredProcedure;
				sCmd.Parameters.Add("@backup_db_name",strDBName);
				sCmd.Parameters.Add("@filename",strFileName);
				sCmd.ExecuteNonQuery();
				sCon.Close();

//				if(System.IO.Directory.Exists(strDir))
//				{					
//					System.IO.File.Copy(strFileName,strDirFile,true);					
//				}
								
				return true;
			}
			catch(Exception ex)
			{
				strErr=ex.ToString();
				return false;
			}
		}
		public bool bSetFileName(string strDataBaseName,string strFileName)
		{	
			try
			{
				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();
			//	SqlConnection sCon=CAutoBackup.m_sCon;				
				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;
				sCmd.CommandText="delete from databaseback insert into dataBaseBack(dataBaseName,fileName)values(@backup_db_name,@filename)";			
				sCmd.Parameters.Add("@backup_db_name",strDataBaseName);
				sCmd.Parameters.Add("@filename",strFileName);
				sCmd.ExecuteNonQuery();
				sCon.Close();
				//MessageBox.Show("设置完成！");				
				return true;
			}
			catch(Exception ex)
			{
				string strErr=ex.ToString();
				MessageBox.Show(strErr);
				return false;
			}
		}
		//备份数据库
		public bool backUp(string strDBName,string strFileName,ref string strErr)
		{
			try
			{
				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();			
				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;
				sCmd.CommandText="pr_backup_db";
				sCmd.CommandType=CommandType.StoredProcedure;
				sCmd.Parameters.Add("@backup_db_name",strDBName);
				sCmd.Parameters.Add("@filename",strFileName);
				sCmd.ExecuteNonQuery();
				sCon.Close();
				MessageBox.Show("备份完成！");				
				return true;
			}
			catch(Exception ex)
			{
				strErr=ex.ToString();
				MessageBox.Show(strErr);
				return false;
			}
		}
		//执行sql脚本文件
		public bool executeSqlFile(string strFileName)
		{
			try
			{
				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();
				StreamReader sr = new StreamReader(strFileName);
				string strSqlFile=sr.ReadToEnd();
				strSqlFile=strSqlFile.Replace(@"\r","");
				strSqlFile=strSqlFile.Replace(@"\n","");				
				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;
				sCmd.CommandText=strSqlFile;
				sCmd.ExecuteNonQuery();		
				sCon.Close();
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

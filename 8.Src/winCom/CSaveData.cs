using System;
using System.Windows;
using System.Windows.Forms;
using winCom.cDealForm;
using System.Data;
using System.Data.SqlClient;


namespace winCom
{
	/// <summary>
	/// CSaveData 的摘要说明。
	/// </summary>
	public class CSaveData
	{

		public CSaveData()
		{			
		}

		//保存数据
		public bool saveGprsData(DataTable dtGprs)		
		{
			try
			{
				if(dtGprs.Columns["leftAmountIC"]!=null)
				{
					dtGprs.Columns.Remove("leftAmountIC");
				}
				

				DataTable dtGprsData=dtGprs.Copy();
				dtGprs.Rows.Clear();

				dtGprsData.Columns.Remove("GprsNo");
				dtGprsData.Columns.Remove("IsRead");

				if(dtGprsData==null)
				{
					return false;
				}
				if(dtGprsData.Rows.Count<=0)
				{
					return false;
				}
				string strTableName=GDBConnection.m_strSystemName+"Datas";				
				
				for(int i=0;i<dtGprsData.Rows.Count;i++)
				{
					string strWatNoTemp=dtGprsData.Rows[i]["watNo"].ToString().Trim();

					string strSql=String.Format("insert into {0}(",strTableName);
					System.Text.StringBuilder sbSql=new System.Text.StringBuilder(strSql);
					//i rowN
					for(int j=0;j<dtGprsData.Columns.Count;j++)
					{	
						//j colN
						string strFieldName=dtGprsData.Columns[j].ColumnName;
						sbSql.Append(strFieldName);
						sbSql.Append(",");
					}
					strSql=sbSql.ToString().Trim();
					strSql=strSql.Substring(0,strSql.Length-1);
					strSql=strSql+")values(";
					sbSql=new System.Text.StringBuilder(strSql);
					
					for(int j=0;j<dtGprsData.Columns.Count;j++)
					{	
						//j colN
						string strFieldName=dtGprsData.Columns[j].ColumnName;
						sbSql.Append("@"+strFieldName);
						sbSql.Append(",");
					}
					strSql=sbSql.ToString().Trim();
					strSql=strSql.Substring(0,strSql.Length-1);
					strSql=strSql+")";

					SqlConnection sCon=new SqlConnection();
					sCon.ConnectionString=GDBConnection.m_strCon;
					sCon.Open();
					
					SqlCommand sCmd=new SqlCommand();
					sCmd.CommandText=strSql;
					sCmd.Connection=sCon;

					for(int j=0;j<dtGprsData.Columns.Count;j++)
					{	
						//j colN
						string strFieldName=dtGprsData.Columns[j].ColumnName;
						string strParamName="@"+dtGprsData.Columns[j].ColumnName;

						//报警
						//this.warnData(strWatNoTemp,strFieldName,dtGprsData.Rows[i][strFieldName].ToString().Trim());

						SqlParameter sParam=sCmd.Parameters.Add(strParamName,SqlDbType.NVarChar,40);
						sParam.Value=dtGprsData.Rows[i][strFieldName].ToString();	
	
						Console.WriteLine(string.Format("{0}--{1}",strParamName,dtGprsData.Rows[i][strFieldName].ToString()));
					}	
				
					sCmd.ExecuteNonQuery();		
			
					sCon.Close();
				}
				
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

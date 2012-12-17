using System;
using System.Data ;
using System.Windows;
using System.Windows.Forms;
using BengZhan;

namespace winCom.cDealForm
{
	/// <summary>
	/// CDFrm 的摘要说明。
	/// </summary>
	public class CDFrm
	{
		public CDFrm()
		{			
		}
		//泵站
		public static void paintWell(string strCountryName,System.Windows.Forms.TreeView trvDep1)
		{
			try
			{
				string strSql="";

				if(strCountryName.Trim()=="")
				{
					strSql=String.Format("select depShortName from tbDep");					
				}
				else
				{
					strSql=String.Format("select depShortName from tbDep where CountryName='{0}'",strCountryName.Trim());
				}				

				strSql=string.Format("select countryName from tbCountry");
				DataTable dtCountry=new DataTable();
				BengZhan.CDBConnection.getDataTable(ref dtCountry,strSql,"dtCountry");

				for(int x=0;x<dtCountry.Rows.Count;x++)
				{
					strCountryName=dtCountry.Rows[x]["countryName"].ToString().Trim();
					System.Windows.Forms.TreeNode trvDep=trvDep1.Nodes.Add(strCountryName);

					strSql=String.Format("select depShortName from tbDep where CountryName='{0}'",strCountryName.Trim());
					DataTable dtDep=new DataTable();
					CDBConnection.getDataTable(ref dtDep,strSql,"tbDep");	
		
					for(int i=0;i<dtDep.Rows.Count;i++)
					{
					
						int iNIndex=trvDep.Nodes.Add(new System.Windows.Forms.TreeNode(dtDep.Rows[i]["depShortName"].ToString()));
						string strShortName=dtDep.Rows[i]["depShortName"].ToString().Trim();
						strSql=String.Format("select wellNo,wellName from tbWell where depName='{0}' order by wellNo",strShortName);
						DataTable dtWell=null;
						CDBConnection.getDataTable(ref dtWell,strSql,"tbWell");
					
						for(int j=0;j<dtWell.Rows.Count;j++)
						{
							string strNodeText=String.Format("{0}|{1}",dtWell.Rows[j]["wellNo"].ToString(),dtWell.Rows[j]["wellName"].ToString());
							trvDep.Nodes[iNIndex].Nodes.Add(strNodeText);
						}
					}
				}
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
		}
	}
}

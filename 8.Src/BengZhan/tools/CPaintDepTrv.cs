using System;
using System.Data ;
using System.Windows.Forms;

namespace BengZhan.tools
{
	/// <summary>
	///ÃÓ≥‰º‡≤‚’æ–≈œ¢
	/// </summary>
	public class CPaintDepTrv
	{
		public CPaintDepTrv()
		{
			
		}
		//ªÊ÷∆µ•Œª ˜
		public bool paintTrVDep(System.Windows.Forms.TreeView  trvDep)
		{
			try
			{
				string strSql="select townName from tbTown";
				DataTable dtTown=null;
				CDBConnection.getDataTable(ref dtTown,strSql,"tbTown");
				for(int i=0;i<dtTown.Rows.Count;i++)
				{
					string strTownName=dtTown.Rows[i]["townName"].ToString();
					trvDep.Nodes.Add(dtTown.Rows[i]["townName"].ToString());
					DataTable dtCountry=null;
					strSql=String.Format("select countryName from tbCountry where townName='{0}'",strTownName);
					CDBConnection.getDataTable(ref dtCountry,strSql,"tbCountry");

					for(int j=0;j<dtCountry.Rows.Count;j++)
					{
						trvDep.Nodes[i].Nodes.Add(dtCountry.Rows[j]["countryName"].ToString());
						string strCountryName=dtCountry.Rows[j]["countryName"].ToString();
						strSql=String.Format("select depShortName from tbDep where countryName='{0}'",strCountryName);
						DataTable dtDep=null;
						CDBConnection.getDataTable(ref dtDep,strSql,"dtDep");
						for(int z=0;z<dtDep.Rows.Count;z++)
						{
							trvDep.Nodes[i].Nodes[j].Nodes.Add(dtDep.Rows[z]["depShortName"].ToString());
						}
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
		//ªÊ÷∆º‡≤‚’æ ˜
		public bool paintTrvWell(System.Windows.Forms.TreeView trvWell)
		{
			try
			{
				trvWell.Nodes.Clear();
				string strSql="select townName from tbTown";
				DataTable dtTown=null;
				CDBConnection.getDataTable(ref dtTown,strSql,"tbTown");
				for(int i=0;i<dtTown.Rows.Count;i++)
				{
					string strTownName=dtTown.Rows[i]["townName"].ToString();
					trvWell.Nodes.Add(dtTown.Rows[i]["townName"].ToString());
					DataTable dtCountry=null;
					strSql=String.Format("select countryName from tbCountry where townName='{0}'",strTownName);
					CDBConnection.getDataTable(ref dtCountry,strSql,"tbCountry");

					for(int j=0;j<dtCountry.Rows.Count;j++)
					{
						trvWell.Nodes[i].Nodes.Add(dtCountry.Rows[j]["countryName"].ToString());
						string strCountryName=dtCountry.Rows[j]["countryName"].ToString();
						strSql=String.Format("select depShortName from tbDep where countryName='{0}'",strCountryName);
						DataTable dtDep=null;
						CDBConnection.getDataTable(ref dtDep,strSql,"dtDep");
						for(int z=0;z<dtDep.Rows.Count;z++)
						{
							trvWell.Nodes[i].Nodes[j].Nodes.Add(dtDep.Rows[z]["depShortName"].ToString());
							strSql=String.Format("select wellNo,wellName from tbWell where depName='{0}'",dtDep.Rows[z]["depShortName"].ToString());
							DataTable dtWell=null;
							CDBConnection.getDataTable(ref dtWell,strSql,"tbWell");

							for(int y=0;y<dtWell.Rows.Count;y++)
							{
								string strWellNo=dtWell.Rows[y]["wellNo"].ToString();
								string strWellName=dtWell.Rows[y]["wellName"].ToString();
								strWellName=String.Format("{0}|{1}",strWellNo,strWellName);
								trvWell.Nodes[i].Nodes[j].Nodes[z].Nodes.Add(strWellName);
							}
						}
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
		//ªÊ÷∆º‡≤‚’æ ˜Ω·µ„
		public bool paintTrvWell(System.Windows.Forms.TreeNode  trvWell)
		{
			try
			{
				string strSql="select townName from tbTown";
				DataTable dtTown=null;
				CDBConnection.getDataTable(ref dtTown,strSql,"tbTown");
				for(int i=0;i<dtTown.Rows.Count;i++)
				{
					string strTownName=dtTown.Rows[i]["townName"].ToString();
					trvWell.Nodes.Add(dtTown.Rows[i]["townName"].ToString());
					DataTable dtCountry=null;
					strSql=String.Format("select countryName from tbCountry where townName='{0}'",strTownName);
					CDBConnection.getDataTable(ref dtCountry,strSql,"tbCountry");

					for(int j=0;j<dtCountry.Rows.Count;j++)
					{
						trvWell.Nodes[i].Nodes.Add(dtCountry.Rows[j]["countryName"].ToString());
						string strCountryName=dtCountry.Rows[j]["countryName"].ToString();
						strSql=String.Format("select depShortName from tbDep where countryName='{0}'",strCountryName);
						DataTable dtDep=null;
						CDBConnection.getDataTable(ref dtDep,strSql,"dtDep");
						for(int z=0;z<dtDep.Rows.Count;z++)
						{
							trvWell.Nodes[i].Nodes[j].Nodes.Add(dtDep.Rows[z]["depShortName"].ToString());
							strSql=String.Format("select wellNo,wellName from tbWell where depName='{0}'",dtDep.Rows[z]["depShortName"].ToString());
							DataTable dtWell=null;
							CDBConnection.getDataTable(ref dtWell,strSql,"tbWell");

							for(int y=0;y<dtWell.Rows.Count;y++)
							{
								string strWellNo=dtWell.Rows[y]["wellNo"].ToString();
								string strWellName=dtWell.Rows[y]["wellName"].ToString();
								strWellName=String.Format("{0}|{1}",strWellNo,strWellName);
								trvWell.Nodes[i].Nodes[j].Nodes[z].Nodes.Add(strWellName);
							}
						}
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


	}
}

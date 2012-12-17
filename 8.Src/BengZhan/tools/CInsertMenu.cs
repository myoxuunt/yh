using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace BengZhan
{
	/// <summary>
	/// CInsertMenu 的摘要说明。
	/// </summary>
	public class CInsertMenu
	{
		public CInsertMenu()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
		public void InsertMenuText(MainMenu mMenu)
		{
			try
			{
				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();
				int iCount=mMenu.MenuItems.Count;
				for(int i=0;i<iCount;i++)
				{
					MenuItem mItem=mMenu.MenuItems[i];
					string strParentText=mItem.Text.Trim();
					string strSql=String.Format("insert into MenuInfo values('{0}','{1}')",strParentText,"");
					SqlCommand sCmd=new SqlCommand();
					sCmd.Connection=sCon;
					sCmd.CommandType=CommandType.Text;
					sCmd.CommandText=strSql;					
					sCmd.ExecuteNonQuery();
					for(int j=0;j<mItem.MenuItems.Count;j++)
					{
						
						MenuItem mItemChild=mItem.MenuItems[j];
						string strChildText=mItemChild.Text.Trim();
						if(strChildText=="退出（&E）")
						{
							continue;
						}
						strSql=String.Format("insert into MenuInfo values('{0}','{1}')",strChildText,strParentText);
						sCmd=new SqlCommand();
						sCmd.Connection=sCon;
						sCmd.CommandType=CommandType.Text;
						sCmd.CommandText=strSql;
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
		public void EnableMenu(MainMenu mMenu)
		{
			try
			{
				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();
				string strUserID=CDBConnection.m_strUserID;

				string strSql=String.Format("select parentManager from tbUsers where userID='{0}'",strUserID);
				string strParentManager=CDBConnection.ExecuteScalar(strSql);
				if(strParentManager.Trim()!="")
				{
					strSql=String.Format("select userID from tbUsers where userName='{0}'",strParentManager.Trim());
					string strUID=CDBConnection.ExecuteScalar(strSql).Trim();
					strUserID=strUID;
				}

				strSql=String.Format("select menuName from userMenu where UserID='{0}'",strUserID);
				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;
				sCmd.CommandText=strSql;
				DataSet ds=new DataSet();
				SqlDataAdapter sda=new SqlDataAdapter();
				sda.SelectCommand=sCmd;
				sda.Fill(ds,"userMenu");
				DataTable dtUserMenu=ds.Tables["userMenu"];

				for(int i=0;i<mMenu.MenuItems.Count;i++)
				{

					mMenu.MenuItems[i].Enabled=false;
					mMenu.MenuItems[i].Visible=false;

					string strParent=mMenu.MenuItems[i].Text.Trim();
					for(int x=0;x<dtUserMenu.Rows.Count;x++)
					{
						if(strParent==dtUserMenu.Rows[x][0].ToString().Trim())
						{
							mMenu.MenuItems[i].Enabled=true;
							mMenu.MenuItems[i].Visible=true;
							break;
						}
					}

					for(int j=0;j<mMenu.MenuItems[i].MenuItems.Count;j++)
					{
						mMenu.MenuItems[i].MenuItems[j].Visible=false;
						mMenu.MenuItems[i].MenuItems[j].Enabled=false;

						for(int y=0;y<dtUserMenu.Rows.Count;y++)
						{
							string strChild=mMenu.MenuItems[i].MenuItems[j].Text.Trim();							
								
							if(strChild==dtUserMenu.Rows[y][0].ToString().Trim())
							{
								mMenu.MenuItems[i].MenuItems[j].Visible=true;
								mMenu.MenuItems[i].MenuItems[j].Enabled=true;

								break;
							}							
						}
					}
				}

//				for(int i=0;i<mMenu.MenuItems.Count;i++)
//				{
//					mMenu.MenuItems[i].Enabled=true;
//					mMenu.MenuItems[i].Visible=true;
//
//				}
				sCon.Close();

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		//toolber权限
		public void enableToolbar(System.Windows.Forms.ToolBar  tb,System.Windows.Forms.MainMenu mainMen)
		{
			try
			{
				for(int i=0;i<tb.Buttons.Count;i++)
				{
					string strTbText=tb.Buttons[i].Text.Trim();

					for(int x=0;x<mainMen.MenuItems.Count;x++)
					{
						for(int y=0;y<mainMen.MenuItems[x].MenuItems.Count;y++)
						{
							string strMnuText=mainMen.MenuItems[x].MenuItems[y].Text.Trim();
							if(strMnuText==strTbText)
							{
								tb.Buttons[i].Enabled=mainMen.MenuItems[x].MenuItems[y].Enabled;
							}
						}
					}				
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}		
		}
		public bool  enableToolbar(string strTbText,System.Windows.Forms.MainMenu mainMen)
		{
			try
			{
				for(int x=0;x<mainMen.MenuItems.Count;x++)
				{
					for(int y=0;y<mainMen.MenuItems[x].MenuItems.Count;y++)
					{
						string strMnuText=mainMen.MenuItems[x].MenuItems[y].Text.Trim();
						if(strMnuText==strTbText)
						{
							return mainMen.MenuItems[x].MenuItems[y].Enabled;
						}
					}
				}
				return false;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				Application.Exit();
				return false;
			}
					}
	}
}

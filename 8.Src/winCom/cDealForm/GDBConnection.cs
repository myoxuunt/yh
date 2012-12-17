using System;
using System.Data ;
using System.Windows;
using System.Windows.Forms;
using System.Xml ;


namespace winCom.cDealForm
{
	/// <summary>
	/// GDBConnection 的摘要说明。
	/// </summary>
	public class GDBConnection
	{

		public static DataTable m_dtWarn=null;

		public static string m_strSystemName="water";
		public static string m_strCon="";


		public GDBConnection()
		{			
		}

		public void iniSys()
		{

			this.iniDtWarn(ref m_dtWarn);
			XmlDocument xDoc=new XmlDocument();
			xDoc.Load("Server.xml");
			m_strCon=xDoc.DocumentElement.SelectSingleNode("./strCon").InnerText.Trim();

		}

		//初始化报警列表
		private bool iniDtWarn(ref DataTable dtWarn)
		{

			try
			{
				
				DataTable dt=new DataTable();
				dt.Columns.Add(new DataColumn("fieldName"));
				dt.Columns.Add(new DataColumn("lowVal"));
				dt.Columns.Add(new DataColumn("highVal"));

				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("PrintFields.xml");

				XmlNode xNode=xDoc.DocumentElement.SelectSingleNode("./table");
				
				for(int i=0;i<xNode.ChildNodes.Count;i++)
				{
					DataRow dr=dt.NewRow();
					dr["fieldName"]=xNode.ChildNodes[i].Attributes.GetNamedItem("name").Value.ToString().Trim();
					
					if(xNode.ChildNodes[i].Attributes.GetNamedItem("lowVal")!=null)
					{
						dr["lowVal"]=xNode.ChildNodes[i].Attributes.GetNamedItem("lowVal").Value.ToString().Trim();
					}
					if(xNode.ChildNodes[i].Attributes.GetNamedItem("highVal")!=null)					
					{
						dr["highVal"]=xNode.ChildNodes[i].Attributes.GetNamedItem("highVal").Value.ToString().Trim();
					}
					dt.Rows.Add(dr);
				}
				dtWarn=dt;
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

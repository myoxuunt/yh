using System;
using System.Data ;
using System.Windows;
using System.Windows.Forms ;
using System.Xml;

namespace cTool
{
	/// <summary>
	/// CExplain 的摘要说明。
	/// </summary>
	public class CExplain
	{

		public CExplain()
		{			
		}

		public static XmlDocument m_xDocE;

		private static byte[] addBytes(byte[] bts1,byte[] bts2)
		{
			byte[] bts3=new byte[bts1.Length+bts2.Length];

			for(int i=0;i<bts1.Length;i++)
			{
				bts3[i]=bts1[i];
			}

			for(int i=bts1.Length;i<(bts1.Length+bts2.Length);i++)
			{
				bts3[i]=bts2[i-bts1.Length];
			}

			return bts3;

		}

		private static int m_iLen=0;
		private static int m_iPos=0;

		public static DataTable explainHisOrdialData(byte[] bts)
		{
			try
			{
				if(m_iPos==0)
				{
					XmlDocument xDoc=new XmlDocument();
					xDoc.Load("comInfo.xml");

					m_iLen=int.Parse(xDoc.DocumentElement.SelectSingleNode("./iLen").Attributes.GetNamedItem("val").Value.Trim());
					m_iPos=int.Parse(xDoc.DocumentElement.SelectSingleNode("./iPos").Attributes.GetNamedItem("val").Value.Trim());

				}


				byte[] btHead=new byte[m_iPos];
				
				for(int i=0;i<m_iPos;i++)
				{
					btHead[i]=bts[i];
				}

				DataTable dtInfo=new DataTable();

				dtInfo.Columns.Add("id");
				dtInfo.Columns.Add("info");

				for(int i=0;i<10;i++)
				{
					int iStart=i*m_iLen+m_iPos;

					byte[] btDatas=new byte[m_iLen];

					for(int j=0;j<m_iLen;j++)
					{
						btDatas[j]=bts[iStart+j];
					}	
					
					btDatas=addBytes(btHead,btDatas);

					string strData=winCom.CTools.cByteToStr(btDatas);

					DataRow dr=dtInfo.NewRow();

					dr["id"]=i.ToString();
					dr["info"]=strData;

					dtInfo.Rows.Add(dr);

				}

				return dtInfo;
			}
			catch(Exception ex)
			{
//				MessageBox.Show(ex.ToString());
				return null;
			}
		
		}

		private static int m_iAddressPos=-1;

		/// <summary>
		/// 解释原始数据存入
		/// </summary>
		/// <param name="dtOrdial"></param>
		/// <returns></returns>
		public static DataTable explainOrdialData(byte[] bts)
		{

			try
			{

				Console.WriteLine(winCom.CTools.cByteToStr(bts));

				if(bts==null)
				{
					return null;
				}

				if(m_xDocE==null)
				{
					m_xDocE=new XmlDocument();
					m_xDocE.Load("explain.xml");
				}

				XmlNode xNode=m_xDocE.DocumentElement.SelectSingleNode("./explainDatas");

				DataTable dtExp=new DataTable();
				dtExp.Columns.Add("name");
				dtExp.Columns.Add("info");

				for(int i=0;i<xNode.ChildNodes.Count;i++)
				{
					XmlNode xNodeE=xNode.ChildNodes[i];

					string strName=xNodeE.Attributes.GetNamedItem("fieldName").Value.Trim();
					string strType=xNodeE.Attributes.GetNamedItem("dataType").Value.Trim();
					string strValPos=xNodeE.Attributes.GetNamedItem("valPos").Value.Trim();
					string strValLen=xNodeE.Attributes.GetNamedItem("valLen").Value.Trim();
					string strVal=xNodeE.Attributes.GetNamedItem("val").Value.Trim();
					string strStartPos=xNodeE.Attributes.GetNamedItem("startPos").Value.Trim();
					string strLen=xNodeE.Attributes.GetNamedItem("len").Value.Trim();
					string strXi=xNodeE.Attributes.GetNamedItem("xi").Value.Trim();
					string strSymbol=xNodeE.Attributes.GetNamedItem("symbol").Value.Trim();

					if(winCom.CTools.checkExVal(bts,strValPos,strValLen,strVal))
					{
						if(strType=="time")
						{
							string strRealData=winCom.CTools.getRealData(bts,strStartPos,strLen);
							string strInfo=winCom.CTools.expTime(strRealData);
							DataRow dr=dtExp.NewRow();
							dr["name"]=strName;
							dr["info"]=strInfo;
							dtExp.Rows.Add(dr);
						}
						if(strType=="BCD")
						{
							string strRealData=winCom.CTools.getRealData(bts,strStartPos,strLen);
							string strInfo=winCom.CTools.expBCD(strRealData,strXi,strSymbol,int.Parse(strLen));
							DataRow dr=dtExp.NewRow();
							dr["name"]=strName;
							dr["info"]=strInfo;
							dtExp.Rows.Add(dr);
						}	

						if(strType=="opposeBCD4")
						{
							string strRealData=winCom.CTools.getRealData(bts,strStartPos,strLen);
							string strInfo=winCom.CTools.expOppBCD4(strRealData,strXi,strSymbol,int.Parse(strLen));
							DataRow dr=dtExp.NewRow();
							dr["name"]=strName;
							dr["info"]=strInfo;
							dtExp.Rows.Add(dr);
						}

						if(strType=="BCD2")
						{
							string strRealData=winCom.CTools.getRealData(bts,strStartPos,strLen);
							string strInfo=winCom.CTools.expBCD2(strRealData,strXi,strSymbol,int.Parse(strLen));
							DataRow dr=dtExp.NewRow();
							dr["name"]=strName;
							dr["info"]=strInfo;
							dtExp.Rows.Add(dr);
						}
						if(strType=="opposeBCD")
						{
							string strRealData=winCom.CTools.getRealData(bts,strStartPos,strLen);
							string strInfo=winCom.CTools.expOppBCD(strRealData,strXi,strSymbol,int.Parse(strLen));
							DataRow dr=dtExp.NewRow();
							dr["name"]=strName;
							dr["info"]=strInfo;
							dtExp.Rows.Add(dr);
						}
						if(strType=="opposeBCD2")
						{
							string strRealData=winCom.CTools.getRealData(bts,strStartPos,strLen);
							string strInfo=winCom.CTools.expOppBCD2(strRealData,strXi,strSymbol,int.Parse(strLen));
							DataRow dr=dtExp.NewRow();
							dr["name"]=strName;
							dr["info"]=strInfo;
							dtExp.Rows.Add(dr);
						}
						if(strType=="string")
						{

							string strValue=xNodeE.Attributes.GetNamedItem("value").Value.Trim();
							string strValDes=xNodeE.Attributes.GetNamedItem("valDes").Value.Trim();

							string strRealData=winCom.CTools.getRealData(bts,strStartPos,strLen);
							string strInfo=winCom.CTools.expString(strRealData,strValue,strValDes);

							DataRow dr=dtExp.NewRow();
							dr["name"]=strName;
							dr["info"]=strInfo;
							dtExp.Rows.Add(dr);
						}
					}                    				
				}

				if(dtExp.Rows.Count>0)
				{
					if(m_iAddressPos<0)
					{
						XmlDocument xDoc=new XmlDocument();
						xDoc.Load("comInfo.xml");
						m_iAddressPos=int.Parse(xDoc.DocumentElement.SelectSingleNode("./address").Attributes.GetNamedItem("val").Value.Trim());
					}
					string strAddress=bts[m_iAddressPos].ToString("x");

					DataRow dr=dtExp.NewRow();
					dr["name"]="address";
					dr["info"]=strAddress;
					dtExp.Rows.Add(dr);

				}

				for(int i=0;i<dtExp.Rows.Count;i++)
				{
					Console.WriteLine(dtExp.Rows[i]["name"].ToString());
					Console.WriteLine(dtExp.Rows[i]["info"].ToString());
				}
				
				 return dtExp;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return null;
			}
		}	
	
		public static DataTable expReData(byte[] bts)
		{
			try
			{
				if(bts==null)
				{
					return null;
				}

				if(m_xDocE==null)
				{
					m_xDocE=new XmlDocument();
					m_xDocE.Load("explain.xml");
				}

				XmlNode xNode=m_xDocE.DocumentElement.SelectSingleNode("./backInfo");

				DataTable dtExp=new DataTable();
				dtExp.Columns.Add("name");
				dtExp.Columns.Add("info");

				for(int i=0;i<xNode.ChildNodes.Count;i++)
				{
					XmlNode xNodeE=xNode.ChildNodes[i];

					string strReStart=xNodeE.Attributes.GetNamedItem("reStart").Value.Trim();
					string strReLen=xNodeE.Attributes.GetNamedItem("reLen").Value.Trim();
					string strReVal=xNodeE.Attributes.GetNamedItem("reVal").Value.Trim();
					string strDes=xNodeE.Attributes.GetNamedItem("des").Value.Trim();

					if(winCom.CTools.checkExVal(bts,strReStart,strReLen,strReVal))
					{
						DataRow dr=dtExp.NewRow();
						dr["name"]="backInfo";
						dr["info"]=strDes;
						dtExp.Rows.Add(dr);
					}                    				
				}
				
				return dtExp;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return null;
			}
		}

	}
}

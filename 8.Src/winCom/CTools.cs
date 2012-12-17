using System;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;
using System.Xml;
using System.Collections;


namespace winCom
{
	/// <summary>
	/// CTools 的摘要说明。
	/// </summary>
	public class CTools
	{

		public CTools()
		{			
		}


		#region"dealData"

		//处理有符号数，正数不变，负数-1，取反，加负号

		public static bool addSymbol(ref Int64 iData,int iLen)
		{
			//已审核
			try
			{
				string cHigh="80";
				string  cLow="7f";

				for(int i=0;i<iLen-1;i++)
				{
					cHigh=cHigh+"00";
					cLow=cLow+"ff";
				}

				Int64 iHigh=Convert.ToInt64(cHigh,16);
				Int64 iLow=Convert.ToInt64(cLow,16);

				string strHigh="";
				for(int i=0;i<iLen;i++)
				{
					strHigh=strHigh+"ff";
				}
				Int64 iAnd=Convert.ToInt64(strHigh,16);

				//一次供水温度			
				Int64 iRes=iData&iHigh;				

				if(iRes>0)
				{
					//负数
					iData=iData-1;
					//取反
					iData=iData^iAnd;
					//加上负号
					iData=0-iData;
				}
				else
				{
					iData=iData&iLow;
				}
				return true;		
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}


		public static int crc16(int[] ints,int iLen)
		{
			crc16.crc16  crc16Obj=new crc16.crc16();
			crc16Obj.IniCard();
			long lCrc16=crc16Obj.CRC16_check(ints,iLen);
			int iCrc16=Convert.ToInt32(lCrc16);
			return iCrc16;
		}

		public static bool checkCrc(int[] ints,int iLen)
		{
			if(ints.Length<3)
			{
				return false;
			}

			crc16.crc16  crc16Obj=new crc16.crc16();
			crc16Obj.IniCard();
			long lCrc16=crc16Obj.CRC16_check(ints,iLen-2);
			int iCrc16=Convert.ToInt32(lCrc16);

			int i1=iCrc16/256;
			int i2=iCrc16&255;

			if(ints[iLen-2]==i1)
			{
				if(ints[iLen-1]==i2)
				{
					return true;
				}
			}
			return false;
		}

		public static string cByteToStr(byte[] bts)
		{
			string str="";

			if(bts==null)			
			{
				return str;
			}
			else
			{
				for(int i=0;i<bts.Length;i++)
				{
					str+=" "+c2str(bts[i].ToString("x"));
				}
				return str.Trim();
			}
		}

		public static byte[] cIntToByte(int[] ints)
		{
			if(ints==null)
			{
				return null;
			}
			byte[] bts=new byte[ints.Length ];

			for(int i=0;i<ints.Length;i++)
			{
				bts[i]=Convert.ToByte(ints[i]);
			}

			return bts;
		}

		public static int[] cByteToInt(byte[] bts)
		{
			
			if(bts==null)
			{
				return null;
			}

			int[] ints=new int[bts.Length];

			for(int i=0;i<bts.Length;i++)
			{
				ints[i]=Convert.ToInt32(bts[i]);
			}

			return ints;
		}

		public static byte[] cStrToByte(string strDatas)
		{
			string[] strsData=strDatas.Trim().Split(' ');

			byte[] btsData=new byte[strsData.Length];

			for(int i=0;i<strsData.Length;i++)
			{
				btsData[i]=Convert.ToByte(strsData[i],16);
			}

			return btsData;

		}


		private static string c2str(string str)
		{
			if(str.Length==1)
			{
				return "0"+str;
			}
			else
			{
				return str;
			}
		}

		#endregion

		#region"expData"

		public static bool checkExVal(byte[] bts,string strValPos,string strValLen,string strVal)
		{
			int iPos=int.Parse(strValPos)+int.Parse(strValLen);

			if(bts.Length<iPos)
			{
				return false;
			}

			string strValEx="";

			for(int i=int.Parse(strValPos);i<(int.Parse(strValPos)+int.Parse(strValLen));i++)
			{
				strValEx+=c2str(bts[i].ToString("x"))+" ";
			}

			if(strValEx.Trim()==strVal)
			{
				return true;
			}
			else
			{
				return false;
			}
			return false;

		}

		public static string getRealData(byte[] bts,string strStartPos,string strLen)
		{
			string strValEx="";

			for(int i=int.Parse(strStartPos);i<(int.Parse(strStartPos)+int.Parse(strLen));i++)
			{
				strValEx+=c2str(bts[i].ToString("x"))+" ";
			}

			return strValEx;
		}


		#endregion

		#region"协议驱动"

		private static bool allO(string[] strsData)
		{
			bool bAll0=true;

			for(int i=0;i<strsData.Length;i++)
			{
				if(int.Parse(strsData[i])!=0)
				{
					bAll0=false;
				}
			}

			return bAll0;
		}
		
		public static string expTime(string strDatas) 
		{
			try
			{
				strDatas=strDatas.Trim();

				string[] strsData=strDatas.Split(' ');

				if(allO(strsData))
				{
					return System.DateTime.Now.ToString();
				}

				if(strsData.Length!=6)
				{
					return "";
				}
				string strYear="20"+strsData[0];
				string strMonth=strsData[1];
				string strDay=strsData[2];
				string strHour=strsData[3];
				string strMunite=strsData[4];
				string strSend=strsData[5];

				string strTime=string.Format("{0}-{1}-{2} {3}:{4}:{5}",strYear,strMonth,strDay,strHour,strMunite,strSend);

				return strTime;
			}
			catch
			{
				string badTime="2000-1-1 00:00:00";
				return badTime;
			}

		}

		public static string expBCD(string strDatas,string strXi,string strSymbol,int iLen)
		{
			strDatas=strDatas.Replace(" ","");

			if(strSymbol=="0")
			{
				Int64 iData=Convert.ToInt64(strDatas,16);
				double dData=iData*double.Parse(strXi);
				return dData.ToString();
			}
			else
			{
				int iData=Convert.ToInt32(strDatas,16);				
				double dData=iData*double.Parse(strXi);
				return dData.ToString();				
			}
			
		}

		public static string expBCD2(string strDatas,string strXi,string strSymbol,int iLen)
		{
			strDatas=strDatas.Replace(" ","");

			if(strSymbol=="0")
			{
				Int64 iData=Convert.ToUInt16(strDatas,16);
				double dData=iData*double.Parse(strXi);
				return dData.ToString();
			}
			else
			{
				int iData=Convert.ToInt16(strDatas,16);				
				double dData=iData*double.Parse(strXi);
				return dData.ToString();				
			}
		}

		public static string expOppBCD4(string strDatas,string strXi,string strSymbol,int iLen)
		{
			string[] strsData=strDatas.Split(' ');
			string[] strsData1=new string[strsData.Length];

			if(iLen==4)
			{
				strsData1[0]=strsData[3];
				strsData1[1]=strsData[2];
				strsData1[2]=strsData[1];
				strsData1[3]=strsData[0];			
			}

			strDatas="";

			for(int i=0;i<4;i++)
			{
				strDatas+=strsData1[i];
			}

			double iData=0;

			if(strSymbol=="1")
			{
				iData=Convert.ToInt64(strDatas,16);	
			}
			else
			{
				iData=Convert.ToUInt64(strDatas,16);
			}			

			double dData=iData*double.Parse(strXi);

			return dData.ToString();
		}




		public static string expOppBCD2(string strDatas,string strXi,string strSymbol,int iLen)
		{
			string[] strsData=strDatas.Split(' ');
			string[] strsData1=new string[strsData.Length];

			if(iLen==2)
			{
				strsData1[0]=strsData[1];
				strsData1[1]=strsData[0];			
			}

			strDatas="";

			for(int i=0;i<2;i++)
			{
				strDatas+=strsData1[i];
			}

			long iData=0;

			if(strSymbol=="1")
			{
				iData=Convert.ToInt16(strDatas,16);	
			}
			else
			{
				iData=Convert.ToUInt16(strDatas,16);
			}			

			double dData=iData*double.Parse(strXi);

			return dData.ToString();
		}

		public static string expOppBCD(string strDatas,string strXi,string strSymbol,int iLen)
		{
			string[] strsData=strDatas.Split(' ');
			string[] strsData1=new string[strsData.Length];

			if(iLen==4)
			{
				strsData1[0]=strsData[3];
				strsData1[1]=strsData[2];
				strsData1[2]=strsData[1];
				strsData1[3]=strsData[0];
			}

			strDatas="";

			for(int i=0;i<4;i++)
			{
				strDatas+=strsData1[i];
			}

			long iData=0;

			if(strSymbol=="1")
			{
				iData=Convert.ToInt32(strDatas,16);	
			}
			else
			{
				iData=Convert.ToUInt32(strDatas,16);
			}			

			double dData=iData*double.Parse(strXi);

			return dData.ToString();
		}

		public static string expString(string strDatas,string strVal,string strValDes)
		{
			strDatas=strDatas.Trim();

			string[] strsVal=strVal.Split(',');
			string[] strsValDes=strValDes.Split(',');

			for(int i=0;i<strsVal.Length;i++)			
			{
				if(strsVal[i]==strDatas)
				{
					return strsValDes[i];
				}
			}
			return "";

		}


		#endregion

		#region"tool"

		private static string m_strEnd="";

		public static ArrayList  removeEnd(byte[] bts)
		{
			if(m_strEnd=="")
			{
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("comInfo.xml");
				m_strEnd=xDoc.DocumentElement.SelectSingleNode("./addEnd").Attributes.GetNamedItem("val").Value.Trim();
			}

			string strDatas=cByteToStr(bts);
			bool bEnd=false;
			ArrayList ar=new ArrayList();

			if(m_strEnd=="")
			{
				ar.Add(strDatas);
				return ar;
			}


			while(!bEnd)
			{

				if(strDatas=="")
				{
					return ar;
				}

				int iIndex=strDatas.IndexOf(m_strEnd);

				if(iIndex<0)
				{
					return ar;
				}

				string strTemp=strDatas.Substring(0,iIndex);

				ar.Add(strTemp.Trim());

				strDatas=strDatas.Substring(iIndex+m_strEnd.Length).Trim();

			}

			return ar;

		}

		public static void DrawCircle(Graphics g,bool bOpen)
		{

			if(bOpen==true)
			{
				SolidBrush blueBrush = new SolidBrush(Color.Red);

				// Draw Ellipse to screen
				g.FillEllipse( blueBrush, 0, 0, 10, 10 );

				// Now tidy up
				blueBrush.Dispose();

			}
			else
			{
				SolidBrush blueBrush = new SolidBrush(Color.Black);

				// Draw Ellipse to screen
				g.FillEllipse( blueBrush, 0, 0, 10, 10 );

				// Now tidy up
				blueBrush.Dispose();
			}			
		}

		public static string addCrc(string strSource)		
		{
			try
			{
				strSource=strSource.Replace("  "," ");
				strSource=strSource.Replace("   "," ");
				strSource=strSource.Trim();
				string[] strsSource=strSource.Split(' ');
				if(strsSource.Length==0)
				{
					return "";
				}

				int[] intsSource=new int[strsSource.Length+2];
				for(int i=0;i<strsSource.Length;i++)
				{
					intsSource[i]=Convert.ToInt32(strsSource[i],16);
				}
				crc16.crc16 crc=new crc16.crc16();
				crc.IniCard();
				long lCrc=	crc.CRC16_check(intsSource,strsSource.Length);
				if(lCrc==-1)
				{
					MessageBox.Show(strSource+"  "+"交验错误");
					return "";
				}
				int iCrc=(int)lCrc;
				intsSource[strsSource.Length]=iCrc/256;
				intsSource[strsSource.Length+1]=iCrc&255;

				string strRet="";
				for(int i=0;i<intsSource.Length;i++)
				{
					strRet+=" "+c2str(intsSource[i].ToString("x"));
				}

				return strRet;
			}
			catch(Exception ex)
			{
				MessageBox.Show(strSource+"  "+ex.ToString());
				return "";
			}

		}


		#endregion




        
		
	}
}

using System;
using System.Windows.Forms;
using System.Windows;
using System.Xml;

namespace icSal
{
	/// <summary>
	/// cIC 的摘要说明。
	/// </summary>
	public class cIC
	{
		public AxMSCommLib.AxMSComm axMSComm1;	
		public XmlDocument m_xDocIC;

		public cIC(AxMSCommLib.AxMSComm axMSCommEx)
		{
			this.axMSComm1=axMSCommEx;
		}
		public bool  openPort()
		{			
			try
			{
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("IC.xml");
				this.m_xDocIC=xDoc;

				string strPort=xDoc.DocumentElement.SelectSingleNode("./Com/port").Attributes.GetNamedItem("val").Value.ToString();
				string strSettings=xDoc.DocumentElement.SelectSingleNode("./Com/settings").Attributes.GetNamedItem("val").Value.ToString();
				this.axMSComm1.CommPort=Convert.ToInt16(strPort);
				this.axMSComm1.Settings=strSettings;
				this.axMSComm1.InputMode=MSCommLib.InputModeConstants.comInputModeBinary;
				this.axMSComm1.RThreshold=1;
				this.axMSComm1.PortOpen=true;
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}		
		}

		public bool closePort()
		{	
			if(this.axMSComm1!=null)
			{
				if(this.axMSComm1.PortOpen==true)
				{
					this.axMSComm1.PortOpen=false;
				}
			}	
			return true;
		}

		public bool iniCard(ref string strCardNo)
		{
			try
			{
				string strCmd=this.getCmd("iniCard");
				cSetParam csp=new cSetParam(this.axMSComm1);
				csp.setParams(strCmd);
				System.Threading.Thread.Sleep(1000);
				byte[] btRead=(byte[])this.axMSComm1.Input;
				int iLen=btRead.Length-2;

				if(iLen<1)				
				{
					return false;
				}
				
				int[] iRead=new int[iLen];

				for(int i=0;i<iLen;i++)
				{
					iRead[i]=Convert.ToInt32(btRead[i]);
				}
				
				crc16.crc16 crc16Obj=new crc16.crc16();
				crc16Obj.IniCard();
				long lEnd=crc16Obj.CRC16_check(iRead,iLen);
				int iEnd=Convert.ToInt32(lEnd);
				int iEndEx=btRead[btRead.Length-2]*256+btRead[btRead.Length-1];
				
				if(iEnd!=iEndEx)
				{
					return false;
				}

				string strOrdial="";
				for(int i=0;i<iRead.Length;i++)
				{
					strOrdial=strOrdial+" "+iRead[i].ToString("x");
				}

				if(this.iniCard(strOrdial,ref strCardNo)==false)
				{
					return false;
				}	
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}

		private bool iniCard(string strOrdial,ref string strCardNo)
		{
			try
			{

				strOrdial=strOrdial.Trim();				

				string[] strDatas=strOrdial.Split(' ');

				if(strDatas.Length==10)
				{
					return false;
				}

				string strXPath="./iniCard";
				XmlNode xNode=this.m_xDocIC.DocumentElement.SelectSingleNode(strXPath);
				xNode=xNode.SelectSingleNode("./param[@name='icNo']");
				string strIStart=xNode.Attributes.GetNamedItem("iStart").Value.ToString().Trim();
				string strILen=xNode.Attributes.GetNamedItem("iLen").Value.ToString().Trim();
				int iStart=Convert.ToInt32(strIStart);
				int iLen=Convert.ToInt32(strILen);
				
				if((strDatas.Length-1)<(iStart+iLen-1))
				{
					return false;
				}

				string strOrdialEx="";
				for(int i=iStart;i<iStart+iLen;i++)
				{					
					strOrdialEx+=this.c2Str(strDatas[i]);
				}
				strOrdialEx=strOrdialEx.Trim();
				strCardNo=strOrdialEx;				
				return true;		
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}

		public bool salWater(string strSal,ref string strLeftAmount)
		{
			try
			{
				string strSalAmount=strSal;
				int dSalAmount=Convert.ToInt32(strSalAmount);

				strSalAmount=dSalAmount.ToString("x");

				strSalAmount=this.getSalAmount(strSalAmount);

				if(strSalAmount=="")
				{
					MessageBox.Show("写卡失败！");
					return false;
				}

				string strSalWater=this.getCmd("salWater");

				strSalWater=strSalWater.Trim()+" "+strSalAmount.Trim()+" 00";
				ComSoft.setParams.CSetParams csp=new ComSoft.setParams.CSetParams();
				string strSalWaterEx="";

				if(csp.sendCmdNoCrc("",strSalWater,ref strSalWaterEx)==false)
				{
					return false;
				}

				cSetParam csparam=new cSetParam(this.axMSComm1);
				csparam.setParams(strSalWaterEx);

				System.Threading.Thread.Sleep(400);

				byte[] btRead=(byte[])this.axMSComm1.Input;
				int iLen=btRead.Length-2;
				
				if(iLen<1)				
				{
					return false;
				}
				
				int[] iRead=new int[iLen];

				for(int i=0;i<iLen;i++)
				{
					iRead[i]=Convert.ToInt32(btRead[i]);
				}
				
				crc16.crc16 crc16Obj=new crc16.crc16();
				crc16Obj.IniCard();
				long lEnd=crc16Obj.CRC16_check(iRead,iLen);
				int iEnd=Convert.ToInt32(lEnd);
				int iEndEx=btRead[btRead.Length-2]*256+btRead[btRead.Length-1];
				
				if(iEnd!=iEndEx)
				{
					return false;
				}

				string strOrdial="";
				for(int i=0;i<iRead.Length;i++)
				{
					strOrdial=strOrdial+" "+iRead[i].ToString("x");
				}

				if(this.writeCard(strOrdial,ref strLeftAmount)==false)
				{
					return false;
				}
				return true;
                
			}
			catch(Exception ex)
			
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}
		private string getSalAmount(string strSalAmount)
		{
			try
			{
				if(strSalAmount.Length>8)
				{
					return "";
				}

				if(strSalAmount.Length==8)
				{
					string strHigh=strSalAmount.Substring(0,1);
					int iHigh=Convert.ToInt32(strHigh);
					if(iHigh>=8)
					{
						MessageBox.Show("所售水量过大！");
						return "";
					}
				}

				int iLen=strSalAmount.Length;
				for(int i=1;i<=(8-iLen);i++)
				{
					strSalAmount="0"+strSalAmount;
				}

				string strSalAmountEx="";

				for(int i=0;i<strSalAmount.Length/2;i++)
				{
					strSalAmountEx=strSalAmountEx+" "+strSalAmount.Substring(i*2,2);
				}
				strSalAmountEx=strSalAmountEx.Trim();
				
				return strSalAmountEx;

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return "";
			}
		}

		public bool readCard(ref string strCardNo,ref string strSal)
		{	
			try
			{
				string strCmd=this.getCmd("readCard");
				cSetParam csp=new cSetParam(this.axMSComm1);
				csp.setParams(strCmd);
				System.Threading.Thread.Sleep(400);
				byte[] btRead=(byte[])this.axMSComm1.Input;
				int iLen=btRead.Length-2;

				if(iLen<1)				
				{
					return false;
				}
				
				int[] iRead=new int[iLen];

				for(int i=0;i<iLen;i++)
				{
					iRead[i]=Convert.ToInt32(btRead[i]);
				}
				
				crc16.crc16 crc16Obj=new crc16.crc16();
				crc16Obj.IniCard();
				long lEnd=crc16Obj.CRC16_check(iRead,iLen);
				int iEnd=Convert.ToInt32(lEnd);
				int iEndEx=btRead[btRead.Length-2]*256+btRead[btRead.Length-1];
				
				if(iEnd!=iEndEx)
				{
					return false;
				}

				string strOrdial="";
				for(int i=0;i<iRead.Length;i++)
				{
					strOrdial=strOrdial+" "+iRead[i].ToString("x");
				}

				if(this.readCard(strOrdial,ref strCardNo,ref strSal)==false)
				{
					return false;
				}			

				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}				
		}
		private string getCmd(string strCmdName)
		{
			try
			{
				XmlDocument xDoc=this.m_xDocIC;			
				string strXPath=String.Format("./{0}",strCmdName);
				string strCmd=xDoc.DocumentElement.SelectSingleNode(strXPath).Attributes.GetNamedItem("val").Value.ToString().Trim();				
				return strCmd;				
			}
			catch(Exception ex)
			{

				MessageBox.Show(ex.ToString());
				return "";
			}
		}
		#region"业务"
		//读卡操作
		private bool readCard(string strOrdial,ref string strICNo,ref string strLeftAmount)
		{
			try
			{
				strOrdial=strOrdial.Trim();
				string strXPath="./readCard";
				XmlNode xNode=this.m_xDocIC.DocumentElement.SelectSingleNode(strXPath);
				xNode=xNode.SelectSingleNode("./param[@name='cardNo']");
				string strIStart=xNode.Attributes.GetNamedItem("iStart").Value.ToString().Trim();
				string strILen=xNode.Attributes.GetNamedItem("iLen").Value.ToString().Trim();
				int iStart=Convert.ToInt32(strIStart);
				int iLen=Convert.ToInt32(strILen);
				string[] strDatas=strOrdial.Split(' ');

				if(strDatas.Length==10)
				{
					return false;
				}

				if((strDatas.Length-1)<(iStart+iLen-1))
				{
					return false;
				}
				string strOrdialEx="";
				for(int i=iStart;i<iStart+iLen;i++)
				{					
					strOrdialEx+=this.c2Str(strDatas[i]);
				}
				strOrdialEx=strOrdialEx.Trim();
				strICNo=strOrdialEx;

				xNode=this.m_xDocIC.DocumentElement.SelectSingleNode(strXPath);
				xNode=xNode.SelectSingleNode("./param[@name='leftAmount']");

				strIStart=xNode.Attributes.GetNamedItem("iStart").Value.ToString().Trim();
				strILen=xNode.Attributes.GetNamedItem("iLen").Value.ToString().Trim();
				iStart=Convert.ToInt32(strIStart);
				iLen=Convert.ToInt32(strILen);
				strDatas=strOrdial.Split(' ');

				if((strDatas.Length-1)<(iStart+iLen-1))
				{
					return false;
				}
				strOrdialEx="";
				for(int i=iStart;i<iStart+iLen;i++)
				{					
					strOrdialEx+=this.c2Str(strDatas[i]);
				}
				strOrdialEx=strOrdialEx.Trim();
				strLeftAmount=Convert.ToUInt32(strOrdialEx,16).ToString();
				
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}
		//写卡接收
		private bool writeCard(string strOrdial,ref string strLeftAmount)
		{
			try
			{

				strOrdial=strOrdial.Trim();				

				string[] strDatas=strOrdial.Split(' ');

				if(strDatas.Length==10)
				{
					return false;
				}

				string strXPath="./salWater";
				XmlNode xNode=this.m_xDocIC.DocumentElement.SelectSingleNode(strXPath);
				xNode=xNode.SelectSingleNode("./param[@name='leftAmount']");
				string strIStart=xNode.Attributes.GetNamedItem("iStart").Value.ToString().Trim();
				string strILen=xNode.Attributes.GetNamedItem("iLen").Value.ToString().Trim();
				int iStart=Convert.ToInt32(strIStart);
				int iLen=Convert.ToInt32(strILen);
				
				if((strDatas.Length-1)<(iStart+iLen-1))
				{
					return false;
				}

				string strOrdialEx="";
				for(int i=iStart;i<iStart+iLen;i++)
				{					
					strOrdialEx+=this.c2Str(strDatas[i]);
				}
				strOrdialEx=strOrdialEx.Trim();
				strLeftAmount=Convert.ToInt32(strOrdialEx,16).ToString();
				
				return true;		
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}
		#endregion
		private string c2Str(string str)
		{
			if(str.Length<2)
			{
				return "0"+str;
			}
			else
			{
				return str;
			}
			return str;
		}
	}
}

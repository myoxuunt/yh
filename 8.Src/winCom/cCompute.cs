using System;
using System.Data;
using System.Xml;
using System.Windows;
using System.Windows.Forms;

namespace winCom
{
	/// <summary>
	/// cCompute 的摘要说明。
	/// </summary>
	public class cCompute
	{
		public cCompute()
		{			
		}

		private static int m_iInter=0;

		public static string comAllAmount(string strWatNo,string strAmount,string strTimeNow)
		{
			try
			{
				if(m_iInter==0)
				{
					XmlDocument xDoc=new XmlDocument();
					xDoc.Load("comInfo.xml");
					m_iInter=int.Parse(xDoc.DocumentElement.SelectSingleNode("./interT").Attributes.GetNamedItem("val").Value.Trim());
				}

				string strSql=string.Format("select amount,time,allAmount from waterdataslast where watNo='{0}'",strWatNo);
				DataTable dtLast=new DataTable();;
				BengZhan.CDBConnection.getDataTable(ref dtLast,strSql,"dtLast");

				if((dtLast==null)||(dtLast.Rows.Count==0))
				{
					dtLast=new DataTable();
					dtLast.Columns.Add("amount");
					dtLast.Columns.Add("time");
					dtLast.Columns.Add("allAmount");

					DataRow dr=dtLast.NewRow();
					dr["amount"]="0";
					dr["time"]=System.DateTime.Now.ToString();
					dr["allAmount"]="0";

					dtLast.Rows.Add(dr);
				}

				string strTime=dtLast.Rows[0]["time"].ToString().Trim();
				string strAmountHis=dtLast.Rows[0]["amount"].ToString().Trim();

				DateTime dtHis=DateTime.Parse(strTime);
				DateTime dtNow=DateTime.Parse(strTimeNow);

				TimeSpan sp=dtNow-dtHis;

				if((sp.Days>0)||(sp.Hours>2))
				{
					return dtLast.Rows[0]["allAmount"].ToString();
				}
				else
				{
					string strAllAmount=dtLast.Rows[0]["allAmount"].ToString();
					double dAllAmount=double.Parse(strAllAmount);

					int iHour=sp.Hours;
					int iMunite=sp.Minutes;
					int iSend=sp.Seconds;

					iSend=iHour*3600+iMunite*60+iSend;
				
					double dAmount=double.Parse(strAmount);

					dAmount=dAmount/3600;

					double dAllAmountCha=dAmount*iSend;

					dAllAmount=dAllAmount+dAllAmountCha;

					return dAllAmount.ToString();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return "0";
			}
			
		
		}

		public static string comAmount(string strWatNo,string strWaterLevel)
		{
			try
			{
				string strSql=string.Format("select vB,vI,vN,vM from tbCompute where watNo='{0}'",strWatNo);
				DataTable dtCom=new DataTable();

				BengZhan.CDBConnection.getDataTable(ref dtCom,strSql,"dtCom");

				string strVb=dtCom.Rows[0]["vB"].ToString().Trim();

				string strVi=dtCom.Rows[0]["vI"].ToString().Trim();

				string strVn=dtCom.Rows[0]["vN"].ToString().Trim();

				string strVm=dtCom.Rows[0]["vM"].ToString().Trim();


				return comAmount(strVb,strWaterLevel,strVn,strVm,strVi);

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return "0";
			}
			

		}

		public static string comAmount(string strB,string strH,string strN,string strM,string strI)
		{
			try
			{
				//底坡
				double dI=0;

				if(strI.Trim()!="")
				{
					dI=double.Parse(strI.Trim());
				}

				//底宽
				double dB=0;

				if(strB.Trim()!="")
				{
					dB=double.Parse(strB.Trim());
				}

				//水深
				double dH=0;

				if(strH.Trim()!="")
				{
					dH=double.Parse(strH.Trim());
				}
			
				//糙率
				double dN=0;

				if(strN.Trim()!="")
				{
					dN=double.Parse(strN.Trim());
				}

				//边坡系数
				double dM=0;

				if(strM.Trim()!="")
				{
					dM=double.Parse(strM.Trim());
				}
			
				double dA=(dB+dM*dH)*dH; //过水断面积

				double dX=dB+2*dH*System.Math.Sqrt(1+System.Math.Pow(dM,2)); //湿周

				double dR=dA/dX ;   //水利半径

				double dC=System.Math.Pow(dR,1/6)/dN;

				Console.WriteLine(dC.ToString());

				double dQ=dA*dC*System.Math.Sqrt(dR*dI);	
	
				dQ=System.Math.Round(dQ,2);

				dQ=dQ*3600;;

				return dQ.ToString();

				Console.WriteLine("da "+dA.ToString());
				Console.WriteLine("dX "+dX.ToString());
				Console.WriteLine("dr "+dR.ToString());
				Console.WriteLine("dC "+dC.ToString());

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return "0";
			}
			
		}
	}
}

using System;
using System.Windows;
using System.Windows.Forms;
using System.Drawing ;
using System.Xml;

namespace CReportDll.comReport.newRep
{
	/// <summary>
	/// CGrid 的摘要说明。
	/// </summary>
	public class CGrid
	{

		

		public CGrid()
		{			
		}		
	}

	public class DataGridColoredTextBoxColumn : DataGridTextBoxColumn
	{

		public delegate Color delegateGetColorRowCol(int row, int col);
		public static XmlDocument m_xDocW;

		private delegateGetColorRowCol _getColorRowCol;
		private int _column;
		private string _colName;

		public DataGridColoredTextBoxColumn()
		{
		}

		protected override object GetColumnValueAtRow(CurrencyManager dataSource, int rowNum)
		{
			try
			{
				Object o=null;
				try
				{
					o=base.GetColumnValueAtRow(dataSource,rowNum);

				}
				catch(Exception ex)

				{
					cSaveErr.CSaveErr.insertErr(ex.ToString());
return "";
				}

				
				if(o==null)
				{
					return "";
				}

				if(o.ToString()=="")
				{
					return "";
				}

				if(o.ToString().IndexOf(".")>=0)
				{
					if(o.ToString().Length>o.ToString().IndexOf(".")+3)
					{
						return o.ToString().Substring(0,o.ToString().IndexOf(".")+3);
					}
				}

				return o.ToString();
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return "";
			}
		}

		public DataGridColoredTextBoxColumn(delegateGetColorRowCol getcolorRowCol, int column,string strColName)
		{
			_getColorRowCol = getcolorRowCol;
			_column = column;
			_colName=strColName;
		}			
			
		protected override void Paint(System.Drawing.Graphics g, System.Drawing.Rectangle bounds, System.Windows.Forms.CurrencyManager source, int rowNum, System.Drawing.Brush backBrush, System.Drawing.Brush foreBrush, bool alignToRight)
		{
			// the idea is to conditionally set the foreBrush and/or backbrush
			// depending upon some crireria on the cell value
			// Here, we use a delegate to retrieve the color				
			//backBrush = new SolidBrush(_getColorRowCol(rowNum, this._column));
			//foreBrush = new SolidBrush(Color.Black);
			try
			{

				this._colName=this.MappingName;

				string strLow="";
				string strHigh="";
				this.getLowHighVal(this._colName,ref strLow,ref strHigh);	

				if(strLow!="")
				{
						
					string strVal = (string) 
						GetColumnValueAtRow(source, rowNum);

					if(strVal.Trim()=="")
					{
						strVal="0";
					}

					double dVal=Convert.ToDouble(strVal);
					double dLow=Convert.ToDouble(strLow);
					if(dVal<dLow)
					{
						//小于下限
						Color c=Color.Red;
						ComSoft.warn.CWarn.doWarn(rowNum,this._colName,ref c);
						//;backBrush =new SolidBrush(c);
						foreBrush=new SolidBrush(Color.Red);
					}
				}
				if(strHigh!="")
				{
					string strVal = (string) 
						GetColumnValueAtRow(source, rowNum);

					if(strVal.Trim()=="")
					{
						strVal="0";
					}

					double dVal=Convert.ToDouble(strVal);
					double dHigh=Convert.ToDouble(strHigh);
					if(dVal>=dHigh)
					{
						//大于上限
						Color c=Color.Red;
						ComSoft.warn.CWarn.doWarn(rowNum,this._colName,ref c);
						//backBrush =new SolidBrush(c);

						foreBrush=new SolidBrush(Color.Red);
					}
				}

				if(this._colName=="waterLevel")
				{
					string strVal = (string) 
						GetColumnValueAtRow(source, rowNum);
					if(strVal==null)
					{
					}
					else
					{
						if((strVal!="200.00")&&(strVal!="200"))
						{
							foreBrush=new SolidBrush(Color.Blue);
						}
					}
				}

				if(this._colName=="leftMony")
				{
					string strVal=(string)GetColumnValueAtRow(source,rowNum);
					if(strVal!=null&&strVal.Trim()!="")
					{
						if(strVal.IndexOf("-")>=0)
						{
							foreBrush=new  SolidBrush(Color.Red);
						}
					}
				}
			
				if(this._colName=="salMony")
				{
					string strVal = (string) 
						GetColumnValueAtRow(source, rowNum);
					if(strVal==null)
					{
					}
					else
					{
						if(strVal.Trim()!="")
						{
							if(double.Parse(strVal)<0)
							{
								foreBrush=new  SolidBrush(Color.Red);
							}
						}
						
					}
				}

				if(this._colName=="warnState")
				{
					string strVal = (string) 
						GetColumnValueAtRow(source, rowNum);
					if(strVal==null)
					{
					}
					else
					{
						if(strVal.Trim()=="报警")
						{
							foreBrush=new SolidBrush(Color.Red);
						}
					}
				}

				if(this._colName.Trim()=="exp")
				{
					string strVal=(string)GetColumnValueAtRow(source,rowNum);
					if(strVal==null)
					{

					}
					else
					{
						if(strVal.IndexOf("故障")>=0)
						{
							foreBrush=new SolidBrush(Color.Red);
						}
					}
				}

			}			
			catch(Exception ex){ cSaveErr.CSaveErr.msgboxErr(ex.ToString()); }
			finally
			{
				// make sure the base class gets called to do the drawing with
				// the possibly changed brushes
				base.Paint(g, bounds, source, rowNum, backBrush, foreBrush, alignToRight);
			}
		}

		private bool getLowHighVal(string strFieldName,ref string strLowVal,ref string strHighVal)
		{
			try
			{

				if(m_xDocW==null)
				{
					m_xDocW=new XmlDocument();
					m_xDocW.Load(@"dep\warn.xml");
				}

					
				for(int i=0;i<m_xDocW.DocumentElement.ChildNodes.Count;i++)
				{				
					string strFieldNameV=m_xDocW.DocumentElement.ChildNodes[i].Attributes.GetNamedItem("field").Value.Trim();
					if(strFieldName==strFieldNameV)
					{
						strLowVal=m_xDocW.DocumentElement.ChildNodes[i].Attributes.GetNamedItem("lowVal").Value.Trim();
						strHighVal=m_xDocW.DocumentElement.ChildNodes[i].Attributes.GetNamedItem("highVal").Value.Trim();
						return true;
					}						
				}	
				
				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}
	}
}

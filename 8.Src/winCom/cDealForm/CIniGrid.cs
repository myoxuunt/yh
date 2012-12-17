using System;
using System.Windows ;
using System.Windows.Forms ;
using System.Data ;
using System.Collections;
using System.Xml;
using System.Drawing ;

namespace winCom.cDealForm
{
	/// <summary>
	/// CIniGrid 的摘要说明。
	/// </summary>
	/// 

	#region"CIniGrid"

	public class CIniGrid
	{

		public CIniGrid()
		{			
		}

		public void iniDGDataSource(DataGrid dataGrid1)
		{
			//初始化数据源
			try
			{
				DataTable dt=null;
				getGprsDataTable(ref dt);
				dataGrid1.DataSource=dt;
			}
			catch(Exception ex)
			{

			}
		}
		public static bool getGprsDataTable(ref DataTable dt)
		{
			try
			{
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("PrintFields.xml");
				XmlNode xNode=xDoc.DocumentElement.SelectSingleNode("./table");

				DataTable dtNew =new DataTable("dtGprsData");

				for(int i=0;i<xNode.ChildNodes.Count;i++)
				{
					string strFieldName=xNode.ChildNodes[i].Attributes.GetNamedItem("name").Value.Trim();					
					DataColumn dtCol=new DataColumn(strFieldName);
					dtNew.Columns.Add(dtCol);					
				}
				dtNew.Columns.Add(new DataColumn("GprsNo"));
				//标志是否已处理
				dtNew.Columns.Add(new DataColumn("IsRead"));
				dt=dtNew;				
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}

		/// <summary>
		/// 功能：获得水资源信息表结构
		/// iPos:表示为第几张表
		/// </summary>
		/// <returns></returns>
		public static bool getGprsData(ref DataTable dtGprsData,ref ArrayList alColsCaption,int iPos)
		{
			try
			{

				XmlDocument xDoc=new XmlDocument();
				xDoc.Load(@"PrintFieldsEx.xml");
				
				DataTable dt=new DataTable();
				ArrayList al=new ArrayList();

				string strXPath=String.Format("./table[@iPos='{0}']",iPos.ToString());
				XmlNode xNodeField=xDoc.DocumentElement.SelectSingleNode(strXPath);

				if(xNodeField==null)
				{
					return false;
				}
				
				if(xNodeField.ChildNodes.Count<=0)
				{
					return false;
				}

				for(int i=0;i<xNodeField.ChildNodes.Count;i++)
				{
					string strFieldName=xNodeField.ChildNodes[i].Attributes.GetNamedItem("name").Value.Trim();
					string strFieldDes=xNodeField.ChildNodes[i].InnerText.Trim();
					dt.Columns.Add(new DataColumn(strFieldName));
					al.Add(strFieldDes);
				}

				dt.TableName="waterSys"+iPos.ToString();	
				dtGprsData=dt;
				alColsCaption=al;
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}
		//初始化表头与显示信息
		public  bool iniDataGrid(DataGrid dataGrid1,int iPos)
		{
			try
			{	
				this.iniDGDataSource(dataGrid1);

				// Create a table style that will hold the new column style 
				// that we set and also tie it to our customer's table from our DB
				DataGridTableStyle tableStyle = new DataGridTableStyle();

				DataTable dt=(DataTable)dataGrid1.DataSource;

				tableStyle.MappingName =dt.TableName;

				DataTable dtGprsData=null;
				ArrayList alColsCap=null;

				//报表格式初始化
				if(getGprsData(ref dtGprsData,ref alColsCap,iPos)==false)
				{
					return false;
				}
				
				// since the dataset has things like field name and number of columns,
				// we will use those to create new columnstyles for the columns in our DB table
				int numCols = dtGprsData.Columns.Count;
				DataGridColoredTextBoxColumn aColumnTextColumn ;
				delegateGetColorRowCol d = new delegateGetColorRowCol(MyGetColorRowCol);

				int[] iColWidths=null;
				getColWidths(ref iColWidths);

				for(int i = 0; i < numCols; i++)
				{				
					aColumnTextColumn = new DataGridColoredTextBoxColumn(d, i,dtGprsData.Columns[i].ColumnName);
					aColumnTextColumn.HeaderText = alColsCap[i].ToString();
					aColumnTextColumn.Width=iColWidths[i]-2;					
					aColumnTextColumn.MappingName = dtGprsData.Columns[i].ColumnName;
					tableStyle.GridColumnStyles.Add(aColumnTextColumn);
				}			

				// make the dataGrid use our new tablestyle and bind it to our table
				dataGrid1.TableStyles.Clear();

				tableStyle.AllowSorting=false;
				//tableStyle.
				dataGrid1.AllowSorting=false;
				dataGrid1.TableStyles.Add(tableStyle);

				DataRow dr=dt.NewRow();
				for(int i=0;i<dt.Columns.Count;i++)
				{						
					dr[i]="";						
				}
				dt.Rows.Add(dr);
				
				//tableStyle.RowHeadersVisible=false;
				dataGrid1.DataSource = dt;

				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}
		//method to be passed into the coloumn style that determines the color
		public Color MyGetColorRowCol(int row, int col)
		{
			// just conditionally set colors based on row, col values...			
			Color c = Color.White;			
			c=Color.Red;		
			return c;
		}	
		//获得列宽
		private static bool getColWidths(ref int[] colWidths)
		{
			try
			{
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("PrintFieldsEx.xml");
				XmlNode xNode=xDoc.DocumentElement.SelectSingleNode("./table[@iPos='1']");
				
				int[] iWidths=new int[xNode.ChildNodes.Count];
				for(int i=0;i<xNode.ChildNodes.Count;i++)
				{
					string strColWidth=xNode.ChildNodes[i].Attributes.GetNamedItem("colWidth").Value.ToString().Trim();
					iWidths[i]=Convert.ToInt32(strColWidth);
				}
				colWidths=iWidths;
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}
	}



	#endregion	

	#region"DataGridColoredTextBoxColumn"

	public delegate Color delegateGetColorRowCol(int row, int col);

	public class DataGridColoredTextBoxColumn : DataGridTextBoxColumn
	{

		public static  DataTable g_dtMap;

		private delegateGetColorRowCol _getColorRowCol;
		private int _column;
		private string _colName;

		public DataGridColoredTextBoxColumn(delegateGetColorRowCol getcolorRowCol, int column,string strColName)
		{
			_getColorRowCol = getcolorRowCol;
			_column = column;
			_colName=strColName;
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
					MessageBox.Show(ex.ToString());
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

				return o.ToString();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return "";
			}
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
				string strLow="";
				string strHigh="";

				Color cc=this.getLowHighVal(this._colName,rowNum,ref strLow,ref strHigh);

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
						//							ComSoft.warn.CWarn.doWarn(rowNum,this._colName,ref c);
						//							//backBrush =new SolidBrush(c);
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
						
						//backBrush =new SolidBrush(c);
						foreBrush=new SolidBrush(Color.Red);
					}
				}

				if(this._colName=="waterLevel")					
				{
					string strVal = (string) 
						GetColumnValueAtRow(source, rowNum);

					if(strVal!=null)
					{
						if((strVal!="200.00")&&(strVal!="200"))
						{
							foreBrush=new SolidBrush(Color.Blue);
						}
					}
				}

				if(this._colName=="warnState")
				{
					string strVal = (string) 
						GetColumnValueAtRow(source, rowNum);

					if(strVal.IndexOf("报警")>=0)
					{							
						foreBrush=new SolidBrush(Color.Red);
						//CBeep.CBeep.beepWarn();
					}
				}
				if(this._colName=="bOff")
				{
					string strVal = (string) 
						GetColumnValueAtRow(source, rowNum);

					if(strVal.IndexOf("报警")>=0)
					{							
						foreBrush=new SolidBrush(Color.Red);
						//CBeep.CBeep.beepWarn();
					}
				}

				if(this._colName=="exp")
				{
					string strVal = (string) 
						GetColumnValueAtRow(source, rowNum);

					if(strVal.IndexOf("故障")>=0)
					{							
						foreBrush=new SolidBrush(Color.Red);		
						//CBeep.CBeep.beepWarn();
					}
					if((strVal.IndexOf("异常")>=0)||(strVal.IndexOf("报警")>=0))
					{
						foreBrush=new SolidBrush(Color.Red);
					}
				}

				if(this._colName=="leftMony")
				{
					string strVal=(string)GetColumnValueAtRow(source,rowNum);
					if(strVal.Trim()!=""&&double.Parse(strVal)<0)
					{
						foreBrush=new SolidBrush(Color.Red);
					}
				}

				if(cc==Color.Blue)
				{
					foreBrush=new SolidBrush(cc);
				}		

			}			
			catch(Exception ex){ MessageBox.Show(ex.ToString()); }
			finally
			{
				// make sure the base class gets called to do the drawing with
				// the possibly changed brushes
				base.Paint(g, bounds, source, rowNum, backBrush, foreBrush, alignToRight);
			}
		}

		private Color getLowHighVal(string strFieldName,int iRowNum,ref string strLowVal,ref string strHighVal)
		{
			try
			{
				for(int i=0;i<GDBConnection.m_dtWarn.Rows.Count;i++)
				{
					if(GDBConnection.m_dtWarn.Rows[i]["fieldName"].ToString().Trim()==strFieldName)
					{
						strLowVal=GDBConnection.m_dtWarn.Rows[i]["lowVal"].ToString();
						strHighVal=GDBConnection.m_dtWarn.Rows[i]["highVal"].ToString();
					}
				}


				if(g_dtMap!=null)
				{
					if(strFieldName=="leftAmountIC")
					{
						if(g_dtMap.Columns["leftAmountIC"]!=null)
						{								
									
							if(g_dtMap.Rows[iRowNum]["leftAmount"].ToString().Trim()=="")
							{
								return Color.Black;
							}
							if(g_dtMap.Rows[iRowNum]["leftAmountIC"].ToString().Trim()=="")
							{
								return Color.Black;
							}

							double dLeftAmount=double.Parse(g_dtMap.Rows[iRowNum]["leftAmount"].ToString());
							double dLeftAmountIC=double.Parse(g_dtMap.Rows[iRowNum]["leftAmountIC"].ToString());
							double dCha=dLeftAmountIC-dLeftAmount;
							
							if((dCha<=2)&&(dCha>=-2))
							{								
								return Color.Black;
							}
							else
							{							
								return Color.Blue;
							}
						}
					}
				}
				else
				{
					return	Color.Black;
				}
				return Color.Black;				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return Color.Black;
				//return false;
			}
		}
	}
	#endregion

}

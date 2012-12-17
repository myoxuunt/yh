using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Data;

using System.Windows.Forms;

namespace  cutePrint
{
	public class cutePrinter
	{
		public string dtB;
		public string dtE;
		public string strTitle="";

		private DataGrid dataGrid;
		private PrintDocument printDocument;
		private PageSetupDialog pageSetupDialog;
		private PrintPreviewDialog printPreviewDialog;
		public bool bLandScape=true;

		private string title="";
  
		int currentPageIndex=0;
		int rowCount=0;
		int pageCount=0;

		int titleSize=20;//标题大小
		bool isCustomHeader=false;
  
		//Brush alertBrush=new SolidBrush(Color.Red);

		string[] header=null;//如果自定义就填入字符串，如果需要斜线分隔，就用\表示，例如：个数#名字 其中#为splitChar
		string[] uplineHeader=null;//上行文字数组
		int[] upLineHeaderIndex=null;//上行的文字index,如果没有上行就设为-1；
		//		bool isEveryPagePrintHead=true;//是否每一页都要打印列头。

		//public frmDataPrint m_frm=null;
		public bool isEveryPagePrintTitle=false;//是否每一页都要打印标题。
		public int headerHeight=20;//列标题高度。
		public int topMargin=50; //顶边距 表头到顶的距离
		public int cellTopMargin=3;//单元格顶边距
		public int cellLeftMargin=4;//单元格左边距
		public char splitChar='#';//当header要用斜线表示的时候
		public string falseStr="×";//如果传进来的dataGrid中有 false,把其转换得字符。
		public string trueStr="√";//如果传进来的dataGrid中有 true,把其转换得字符。
		public int pageRowCount=25;//每页行数
		public int rowGap = 22;//行高
		public int colGap = 4;//每列间隔
		public int leftMargin = 50;//左边距
		public Font titleFont=new Font("Arial",20);//表头字体
		public Font font = new Font("Arial", 9);//正文字体
		public Font headerFont = new Font("Arial", 9, FontStyle.Bold);//列名标题
		public Font footerFont=new Font("Arial",8);//页脚显示页数的字体
		public Font upLineFont=new Font("Arial",9, FontStyle.Bold);//当header分两行显示的时候，上行显示的字体。
		public Font underLineFont=new Font("Arial",9);//当header分两行显示的时候，下行显示的字体。
		public Brush brush = new SolidBrush(Color.Black);//画刷
		public bool isAutoPageRowCount=false;//是否自动计算行数。
		public int buttomMargin=80;//底边距
		public bool needPrintPageIndex=true;//是否打印页脚页数

		//我添加的属性
		public int iTimeMinus=0;

		//string filterStr="";

		public cutePrinter(DataGrid dataGrid,string title,int titleSize)
		{ 
			try
			{
				this.title=title;
				this.titleSize=titleSize;

				this.dataGrid = dataGrid; 
				printDocument = new PrintDocument();
				printDocument.PrintPage += new PrintPageEventHandler(this.printDocument_PrintPage);

			}
			catch(Exception e)
			{
				MessageBox.Show(e.ToString());
			}
		} 
		public cutePrinter(DataGrid dataGrid,string title)
		{ 

			try
			{
				this.title=title;

				this.dataGrid = dataGrid; 
				printDocument = new PrintDocument();
				printDocument.PrintPage += new PrintPageEventHandler(this.printDocument_PrintPage);
			}
			catch(Exception e)
			{
				MessageBox.Show(e.ToString());
			}
		} 
		public cutePrinter(DataGrid dataGrid)
		{ 
			try
			{
				this.dataGrid = dataGrid; 
				printDocument = new PrintDocument();
				printDocument.PrintPage += new PrintPageEventHandler(this.printDocument_PrintPage);
			}
			catch(Exception e)
			{
				MessageBox.Show(e.ToString());
			}
		} 

		public bool setTowLineHeader(string[] upLineHeader,int[] upLineHeaderIndex)
		{
			try
			{
				this.uplineHeader=upLineHeader;
				this.upLineHeaderIndex=upLineHeaderIndex;
				this.isCustomHeader=true;
				return true;
			}
			catch(Exception e)
			{
				MessageBox.Show(e.ToString());
				return false;
			}
		}
		public bool setHeader(string[] header)
		{
			try
			{
				this.header=header;
				return true;
			}
			catch(Exception e)
			{
				MessageBox.Show(e.ToString());
				return false;

			}

		}

		private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			try
			{
				int width=e.PageBounds.Width;
				int height=e.PageBounds.Height;

				if(this.isAutoPageRowCount)
					pageRowCount=(int)((height-this.topMargin-titleSize-this.headerFont.Height-this.headerHeight-this.buttomMargin)/this.rowGap);

				pageCount=(int)(rowCount/pageRowCount);
				if(rowCount%pageRowCount>0)
					pageCount++;

				int xoffset=(int)((width-e.Graphics.MeasureString(this.title,this.titleFont).Width)/2);
				int colCount = 0;
				int x = 0;
				int y =topMargin;
				string cellValue = ""; 

				int startRow=currentPageIndex*pageRowCount;
				int endRow=startRow+this.pageRowCount<rowCount?startRow+pageRowCount:rowCount;
				int currentPageRowCount=endRow-startRow;


				if(this.currentPageIndex==0 || this.isEveryPagePrintTitle)
				{
					e.Graphics.DrawString(this.title,titleFont,brush,xoffset,y);
					y+=titleSize;
					//			}
					//------增加打印行,只加到第一页
					y += rowGap;
					x = leftMargin;

					//			dt=DateTime.Now.Year+DateTime.Now.Month+DateTime.Now.Day;
					//									e.Graphics.DrawString("报表日期："+DateTime.Now.Year+"年"+DateTime.Now.Month+"月"+DateTime.Now.Day+"日",font,brush,x,y);
					
					if(this.strTitle=="")
					{
						e.Graphics.DrawString("时间范围："+dtB+"至"+dtE,font,brush,x-this.iTimeMinus,y);
					}
					else
					{
						e.Graphics.DrawString(this.strTitle,font,brush,x-this.iTimeMinus,y);
					}
					
					
					//-----------
				}
				colCount = dataGrid.TableStyles[0].GridColumnStyles.Count;

				y += rowGap+10;
				x = leftMargin;


				DrawLine(new Point(x,y),new Point(x,y+currentPageRowCount*rowGap+this.headerHeight),e.Graphics);//最左边的竖线

				int lastIndex=-1;
				int lastLength=0;
				int indexj=-1;

				for(int j = 0; j < colCount; j++)
				{
					int colWidth=dataGrid.TableStyles[0].GridColumnStyles[j].Width;
					if( colWidth> 0)
					{
						indexj++;
						if(this.header==null || this.header[indexj]=="")
							cellValue = dataGrid.TableStyles[0].GridColumnStyles[j].HeaderText; 
						else
							cellValue=header[indexj];

						if(this.isCustomHeader)
						{
							if(this.upLineHeaderIndex[indexj]!=lastIndex)
							{
      
								if(lastLength>0 && lastIndex>-1)//开始画上一个upline
								{
									string upLineStr=this.uplineHeader[lastIndex];
									int upXOffset=(int)((lastLength-e.Graphics.MeasureString(upLineStr,this.upLineFont).Width)/2);
									if(upXOffset<0)
										upXOffset=0;
									e.Graphics.DrawString(upLineStr,this.upLineFont,brush,x-lastLength+upXOffset,y+(int)(this.cellTopMargin/2));

									DrawLine(new Point(x-lastLength,y+(int)(this.headerHeight/2)),new Point(x,y+(int)(this.headerHeight/2)),e.Graphics);//中线
									DrawLine(new Point(x,y),new Point(x,y+(int)(this.headerHeight/2)),e.Graphics);
								}
								lastIndex=this.upLineHeaderIndex[indexj];
								lastLength=colWidth+colGap;
							}
							else
							{
								lastLength+=colWidth+colGap;
							}
						}

						//int currentY=y+cellTopMargin;
     
     
						int Xoffset=10;
						int Yoffset=20;
						int leftWordIndex=cellValue.IndexOf(this.splitChar);
						if(this.upLineHeaderIndex!=null && this.upLineHeaderIndex[indexj]>-1)
						{
      
							if(leftWordIndex>0)
							{
								string leftWord=cellValue.Substring(0,leftWordIndex);
								string rightWord=cellValue.Substring(leftWordIndex+1,cellValue.Length-leftWordIndex-1);
								//上面的字
								Xoffset=(int)(colWidth+colGap-e.Graphics.MeasureString(rightWord,this.upLineFont).Width);
								Yoffset=(int)(this.headerHeight/2-e.Graphics.MeasureString("a",this.underLineFont).Height);

       
								//Xoffset=6;
								//Yoffset=10;
								e.Graphics.DrawString(rightWord,this.underLineFont,brush,x+Xoffset-4,y+(int)(this.headerHeight/2));
								e.Graphics.DrawString(leftWord,this.underLineFont,brush,x+2,y+(int)(this.headerHeight/2)+(int)(this.cellTopMargin/2)+Yoffset-2);
								DrawLine(new Point(x,y+(int)(this.headerHeight/2)),new Point(x+colWidth+colGap,y+headerHeight),e.Graphics);
								x += colWidth + colGap; 
								DrawLine(new Point(x,y+(int)(this.headerHeight/2)),new Point(x,y+currentPageRowCount*rowGap+this.headerHeight),e.Graphics);
							}
							else
							{

								e.Graphics.DrawString(cellValue, headerFont, brush, x, y+(int)(this.headerHeight/2)+(int)(this.cellTopMargin/2));     
								x += colWidth + colGap; 
								DrawLine(new Point(x,y+(int)(this.headerHeight/2)),new Point(x,y+currentPageRowCount*rowGap+this.headerHeight),e.Graphics);
							}
      
						}
						else
						{
							if(leftWordIndex>0)
							{
								string leftWord=cellValue.Substring(0,leftWordIndex);
								string rightWord=cellValue.Substring(leftWordIndex+1,cellValue.Length-leftWordIndex-1);
								//上面的字
								Xoffset=(int)(colWidth+colGap-e.Graphics.MeasureString(rightWord,this.upLineFont).Width);
								Yoffset=(int)(this.headerHeight-e.Graphics.MeasureString("a",this.underLineFont).Height);

								e.Graphics.DrawString(rightWord,this.headerFont,brush,x+Xoffset-4,y+2);
								e.Graphics.DrawString(leftWord,this.headerFont,brush,x+2,y+Yoffset-4);
								DrawLine(new Point(x,y),new Point(x+colWidth+colGap,y+headerHeight),e.Graphics);
								x += colWidth + colGap; 
								DrawLine(new Point(x,y),new Point(x,y+currentPageRowCount*rowGap+this.headerHeight),e.Graphics);
							}
							else
							{
								Xoffset=(int)((colWidth+cellLeftMargin-e.Graphics.MeasureString(cellValue,this.upLineFont).Width)/2);
								if(Xoffset<0) Xoffset=0;
								Yoffset=(int)((this.headerHeight+cellTopMargin-e.Graphics.MeasureString(cellValue,this.underLineFont).Height)/2);
								//							
								e.Graphics.DrawString(cellValue, headerFont, brush, x+Xoffset, y+Yoffset);
								//							e.Graphics.DrawString(cellValue, headerFont, brush, x, y+cellTopMargin);      
								x += colWidth + colGap; 
								DrawLine(new Point(x,y),new Point(x,y+currentPageRowCount*rowGap+this.headerHeight),e.Graphics);
							}
       
						}

					}
				} 
				////循环结束，画最后一个的upLine
				if(this.isCustomHeader)
				{
        
					if(lastLength>0 && lastIndex>-1)//开始画上一个upline
					{
						string upLineStr=this.uplineHeader[lastIndex];
						int upXOffset=(int)((lastLength-e.Graphics.MeasureString(upLineStr,this.upLineFont).Width)/2);
						if(upXOffset<0)
							upXOffset=0;
						e.Graphics.DrawString(upLineStr,this.upLineFont,brush,x-lastLength+upXOffset,y+(int)(this.cellTopMargin/2));

						DrawLine(new Point(x-lastLength,y+(int)(this.headerHeight/2)),new Point(x,y+(int)(this.headerHeight/2)),e.Graphics);//中线
						DrawLine(new Point(x,y),new Point(x,y+(int)(this.headerHeight/2)),e.Graphics);
					} 
    
				}
  
				int rightBound=x;

				DrawLine(new Point(leftMargin,y),new Point(rightBound,y),e.Graphics);         //最上面的线

				//DrawLine(new Point(leftMargin,y+this.headerHeight),new Point(rightBound,y+this.headerHeight),e.Graphics);//列名的下面的线

				y+=this.headerHeight;


				//print all rows
				for(int i = startRow; i < endRow; i++)
				{
    
					x = leftMargin;
					for(int j = 0; j < colCount; j++)
					{
						if(dataGrid.TableStyles[0].GridColumnStyles[j].Width > 0)
						{
							cellValue = dataGrid[i,j].ToString(); 
							if(cellValue=="False")
								cellValue=falseStr;
							if(cellValue=="True")
								cellValue=trueStr;
       
							e.Graphics.DrawString(cellValue, font, brush, x+this.cellLeftMargin, y+cellTopMargin);
							x += dataGrid.TableStyles[0].GridColumnStyles[j].Width + colGap;
							y = y + rowGap * (cellValue.Split(new char[] {'\r', '\n'}).Length - 1); 
						}
					} 
					DrawLine(new Point(leftMargin,y),new Point(rightBound,y),e.Graphics);
					y += rowGap;
				}
				DrawLine(new Point(leftMargin,y),new Point(rightBound,y),e.Graphics);

				currentPageIndex++;

				if(this.needPrintPageIndex)
					e.Graphics.DrawString("共 "+pageCount.ToString()+" 页,当前第 "+this.currentPageIndex.ToString()+" 页",this.footerFont,brush,width-200,(int)(height-this.buttomMargin/2-this.footerFont.Height));

				string s = cellValue;
				string f3 = cellValue;


    
				if(currentPageIndex<pageCount)
				{
					e.HasMorePages=true;     
				}
				else
				{
					e.HasMorePages=false;
					this.currentPageIndex=0;
    
				}
				//iPageNumber+=1;
   
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());

			}


		}
		private void DrawLine(Point sp,Point ep,Graphics gp)
		{

			try
			{
				Pen pen=new Pen(Color.Black);
				gp.DrawLine(pen,sp,ep);
			}
			catch(Exception e)
			{
				MessageBox.Show(e.ToString());
			}
		}

		public PrintDocument GetPrintDocument()
		{
			return printDocument;
		}

 

		public void Print()
		{   
			rowCount=0;

			//if(dataGrid.DataSource.GetType().ToString() == "System.Data.DataView")
		if(dataGrid.DataSource.GetType().ToString() == "System.Data.DataTable")
			{
		rowCount = ((DataTable)dataGrid.DataSource).Rows.Count;
				//rowCount = ((DataView)dataGrid.DataSource).Count;
			}
			else if(dataGrid.DataSource.GetType().ToString() == "System.Collections.ArrayList")
			{
				rowCount = ((ArrayList)dataGrid.DataSource).Count;
			}


			try
			{
//				pageSetupDialog = new PageSetupDialog();
//		
//				pageSetupDialog.Document = printDocument;
//				pageSetupDialog.PageSettings.Landscape=true;

				printDocument.DefaultPageSettings.Landscape=this.bLandScape;
			
				int iWidth  = (int)(21 / 2.54 * 100);
				int iHeight = (int)(29.75 / 2.54 * 100);

							


				printDocument.DefaultPageSettings.PaperSize=new System.Drawing.Printing.PaperSize("A4", iWidth, iHeight);
//				pageSetupDialog.ShowDialog();

				//---------定时打印
				
				//				printDocument.DefaultPageSettings.Landscape = true;
				//				printDocument.Print();
				//				MessageBox.Show("打印完成","日报表打印");

 


				printPreviewDialog = new PrintPreviewDialog();
				printPreviewDialog.Document = printDocument;
				printPreviewDialog.WindowState = FormWindowState.Maximized;	
				printPreviewDialog.Height=iHeight;
				printPreviewDialog.Width=iWidth;
   
					//printPreviewDialog.s
				printPreviewDialog.ShowDialog();
			}
			catch(Exception e)
			{
				throw new Exception("Printer error." + e.Message);
			}

		}

		public void PrintEx()
		{   
			rowCount=0;

			//if(dataGrid.DataSource.GetType().ToString() == "System.Data.DataView")
			if(dataGrid.DataSource.GetType().ToString() == "System.Data.DataTable")
			{
				rowCount = ((DataTable)dataGrid.DataSource).Rows.Count;
				//rowCount = ((DataView)dataGrid.DataSource).Count;
			}
			else if(dataGrid.DataSource.GetType().ToString() == "System.Collections.ArrayList")
			{
				rowCount = ((ArrayList)dataGrid.DataSource).Count;
			}


			try
			{
				//				pageSetupDialog = new PageSetupDialog();
				//		
				//				pageSetupDialog.Document = printDocument;
				//				pageSetupDialog.PageSettings.Landscape=true;

				printDocument.DefaultPageSettings.Landscape=this.bLandScape;
			
				int iWidth  = (int)(21 / 2.54 * 100);
				int iHeight = (int)(29.75 / 2.54 * 100);

							


				printDocument.DefaultPageSettings.PaperSize=new System.Drawing.Printing.PaperSize("A4", iWidth, iHeight);
				printDocument.Print();
				//				pageSetupDialog.ShowDialog();

				//---------定时打印
				
				//				printDocument.DefaultPageSettings.Landscape = true;
				//				printDocument.Print();
				//				MessageBox.Show("打印完成","日报表打印");

 


			//	printDialog = new PrintDialog();
			///	printPreviewDialog.Document = printDocument;
				///printPreviewDialog.WindowState = FormWindowState.Maximized;	
				//printPreviewDialog.Height=iHeight;
				//printPreviewDialog.Width=iWidth;
   
				//printPreviewDialog.s
				//printPreviewDialog.
			}
			catch(Exception e)
			{
				throw new Exception("Printer error." + e.Message);
			}

		}
	} 
}

//用法示例，显示结果如顶图。





using System;
using System.Windows.Forms;
using System.Data;
namespace BengZhan.printDoc
{
	/// <summary>
	/// cPrint 的摘要说明。
	/// </summary>
	public class cPrint
	{
		public cPrint()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
		public bool printDt(DataTable dt)
		{
			try
			{
				string strTitle=String.Format("打印时间:{0}",System.DateTime.Now.ToString());

				string[] strText=new string[7];
				strText[0]="监测站编号";
				strText[1]="单位名称";
				strText[2]="已用水量";
				strText[3]="剩余水量";
				strText[4]="总水量";
				strText[5]="流量";
				strText[6]="上报时间";

				printDoc.crpPrint crpPrintObj=new BengZhan.printDoc.crpPrint();
				CrystalDecisions.CrystalReports.Engine.TextObject toTitle=(CrystalDecisions.CrystalReports.Engine.TextObject)crpPrintObj.ReportDefinition.ReportObjects["txtTime"];
				toTitle.Text=strTitle;
				for(int i=0;i<7;i++)
				{
					int iNum=i+1;
					string strTextTitle="Text"+iNum.ToString();
					CrystalDecisions.CrystalReports.Engine.TextObject to=(CrystalDecisions.CrystalReports.Engine.TextObject)crpPrintObj.ReportDefinition.ReportObjects[strTextTitle];					
					to.Text=strText[i].ToString();
				}	


				DataTable dtPrint=new  DataTable();
				dtPrint.Columns.Add(new DataColumn("Field1"));
				dtPrint.Columns.Add(new DataColumn("Field2"));
				dtPrint.Columns.Add(new DataColumn("Field3"));
				dtPrint.Columns.Add(new DataColumn("Field4"));
				dtPrint.Columns.Add(new DataColumn("Field5"));
				dtPrint.Columns.Add(new DataColumn("Field6"));
				dtPrint.Columns.Add(new DataColumn("Field7"));

				for(int i=0;i<dt.Rows.Count;i++)
				{
					DataRow dr=dtPrint.NewRow();
					dr["Field1"]=dt.Rows[i][0].ToString();
					dr["Field2"]=dt.Rows[i][1].ToString();
					dr["Field3"]=dt.Rows[i][2].ToString();
					dr["Field4"]=dt.Rows[i][3].ToString();
					dr["Field5"]=dt.Rows[i][4].ToString();
					dr["Field6"]=dt.Rows[i][5].ToString();
						dr["Field7"]=dt.Rows[i][7].ToString();
					dtPrint.Rows.Add(dr);
				}

				
				crpPrintObj.SetDataSource(dtPrint);
				//打印窗体
				Form rptForm = new Form();
				rptForm.Text = "预览";
				rptForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
				rptForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
				CrystalDecisions.Windows.Forms.CrystalReportViewer rptView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
				rptForm.Controls.Add(rptView);			
				rptView.Dock = System.Windows.Forms.DockStyle.Fill;
				rptView.ReportSource=crpPrintObj;
				rptView.ShowCloseButton=true;
				rptForm.ShowDialog();			 
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

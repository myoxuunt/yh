//============================================================================
//ZedGraph Class Library - A Flexible Charting Library for .Net
//Copyright (C) 2005 John Champion and Jerry Vos
//
//This library is free software; you can redistribute it and/or
//modify it under the terms of the GNU Lesser General Public
//License as published by the Free Software Foundation; either
//version 2.1 of the License, or (at your option) any later version.
//
//This library is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//Lesser General Public License for more details.
//
//You should have received a copy of the GNU Lesser General Public
//License along with this library; if not, write to the Free Software
//Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
//=============================================================================

using System;
using System.Drawing;
using System.Collections;
using System.Data;

using ZedGraph;

namespace ZedGraph.Demo
{
	/// <summary>
	/// 绘制历史曲线类
	/// </summary>
	public class DateAxisSampleDemo : DemoBase
	{
		public string m_strTitle="";

		public string m_xAxisTitle="Date";

		public string m_yAxisTitle="";

		public string m_strLine1Name="";

		public string m_strLine2Name="";

		//值:Day日期格式{0}-{1}-{3} Hour时间格式 {0}:{1}:{2}
		public string m_strState="";

		public DataTable m_dtLine1=new DataTable();

		public DataTable m_dtLine2=new DataTable();


		public DateAxisSampleDemo() : base( "Code Project Date Axis Sample",
			"Date Axis Sample", DemoType.Tutorial )
		{
			
		}
		public void initialDateAxis()
		{

			if(this.m_dtLine1==null&&this.m_dtLine2==null)
			{
				return;
			}


			GraphPane myPane = base.GraphPane;

			// Set the titles and axis labels
			myPane.Title = this.m_strTitle;

			myPane.XAxis.Title = "日期";

			myPane.YAxis.Title = this.m_yAxisTitle;
			   
			// Make up some data points based on the Sine function
			PointPairList list = new PointPairList();

			for ( int i=0; i<this.m_dtLine1.Rows.Count; i++ )
			{

				DateTime dt=Convert.ToDateTime(this.m_dtLine1.Rows[i]["x"].ToString());

				double x = (double) new XDate( dt.Year,dt.Month, dt.Day);

				double y = Convert.ToDouble(this.m_dtLine1.Rows[i]["y"].ToString());
				
				list.Add( x, y );
			}

			PointPairList list1=new PointPairList();			
			
			for ( int i=0; i<this.m_dtLine2.Rows.Count; i++ )
			{

				DateTime dt=Convert.ToDateTime(this.m_dtLine2.Rows[i]["x"].ToString());
				
				double x = (double) new XDate(dt.Year,dt.Month,dt.Day,dt.Hour,dt.Minute,dt.Second);

				double y = Convert.ToDouble(this.m_dtLine2.Rows[i]["y"].ToString());
				
				list1.Add( x, y );
				
			}

			int iCount=0;
			string[] strXLabels;

			if(this.m_dtLine2.Rows.Count>this.m_dtLine1.Rows.Count)
			{
				iCount=this.m_dtLine2.Rows.Count;
				strXLabels=new string[iCount];
				for(int i=0;i<iCount;i++)
				{
					DateTime dt=Convert.ToDateTime(this.m_dtLine2.Rows[i]["x"].ToString());

					if(this.m_strState!="Day")
						strXLabels[i]=String.Format("{0}-{1}-{2}",dt.Year.ToString(),dt.Month.ToString(),dt.Day.ToString());
					else
						strXLabels[i]=String.Format("{0}:{1}:{2}",dt.Hour.ToString(),dt.Minute.ToString(),dt.Second.ToString());


				}
			}
			else
			{
				iCount=this.m_dtLine1.Rows.Count;
				strXLabels=new string[iCount];
				for(int i=0;i<iCount;i++)
				{
					DateTime dt=Convert.ToDateTime(this.m_dtLine1.Rows[i]["x"].ToString());

					if(this.m_strState!="Day")
						strXLabels[i]=String.Format("{0}-{1}-{2}",dt.Year.ToString(),dt.Month.ToString(),dt.Day.ToString());
					else
						strXLabels[i]=String.Format("{0}:{1}:{2}",dt.Hour.ToString(),dt.Minute.ToString(),dt.Second.ToString());

				}
			}
			// Generate a red curve with diamond
			// symbols, and "My Curve" in the legend
			LineItem myCurve = myPane.AddCurve( this.m_strLine1Name,
				list, Color.Red, SymbolType.Diamond );

			myCurve = myPane.AddCurve( this.m_strLine2Name,
				list1, Color.Green , SymbolType.Diamond );

			
				myPane.XAxis.Type = AxisType.Text;
				myPane.XAxis.TextLabels=strXLabels;
              


			base.ZedGraphControl.AxisChange();

		}
	}
}

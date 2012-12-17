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
using System.Windows;
using System.Windows.Forms;

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

		public void initialDateAxisMonth(ZedGraph.ZedGraphControl zedChart)
		{
			try
			{
				if(this.m_dtLine1==null&&this.m_dtLine2==null)
				{
					return;
				}

				GraphPane myPane = zedChart.GraphPane;

				// Set the titles and axis labels
				myPane.Title = this.m_strTitle;
				//myPane.

				myPane.XAxis.Title =this.m_xAxisTitle;

				myPane.YAxis.Title = this.m_yAxisTitle;

				double[] dDatas=new double[this.m_dtLine1.Rows.Count];
				for(int i=0;i<this.m_dtLine1.Rows.Count;i++)
				{
					dDatas[i]=double.Parse(m_dtLine1.Rows[i]["y"].ToString().Trim());
				}
				string[] strLabels=new string[this.m_dtLine1.Rows.Count];
				for(int i=0;i<this.m_dtLine1.Rows.Count;i++)
				{
					strLabels[i]=m_dtLine1.Rows[i]["x"].ToString().Trim();
				}
				myPane.CurveList.Clear();
				LineItem myCurve = myPane.AddCurve(this.m_strLine1Name,
					null, dDatas, Color.Black, SymbolType.Circle);
				myPane.XAxis.Type = AxisType.Text;
				// Set the XAxis labels
				myPane.XAxis.TextLabels = strLabels;
				//myPane.XAxis.ScaleFontSpec.Angle = 40;
				myPane.XAxis.ScaleFontSpec.Size=10;
				myPane.YAxis.ScaleFontSpec.Size=10;
				myCurve.Symbol.Size = 4;
				zedChart.AxisChange();
				zedChart.Invalidate();
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}

		public void initialDateAxis(ZedGraph.ZedGraphControl zedChart)
		{			
			try
			{
				if(this.m_dtLine1==null&&this.m_dtLine2==null)
				{
					return;
				}

				GraphPane myPane = zedChart.GraphPane;

				// Set the titles and axis labels
				myPane.Title = this.m_strTitle;
				//myPane.

				myPane.XAxis.Title =this.m_xAxisTitle;

				myPane.YAxis.Title = this.m_yAxisTitle;

				double[] dDatas=new double[this.m_dtLine1.Rows.Count];
				for(int i=0;i<this.m_dtLine1.Rows.Count;i++)
				{
					dDatas[i]=double.Parse(m_dtLine1.Rows[i]["y"].ToString().Trim());
				}
				string[] strLabels=new string[this.m_dtLine1.Rows.Count];
				for(int i=0;i<this.m_dtLine1.Rows.Count;i++)
				{
					if(this.isO(i))
							{
						strLabels[i]=m_dtLine1.Rows[i]["x"].ToString().Trim();
							}
					
				}
				myPane.CurveList.Clear();
				LineItem myCurve = myPane.AddCurve(this.m_strLine1Name,
					null, dDatas, Color.Black, SymbolType.Circle);
				myPane.XAxis.Type = AxisType.Text;
				// Set the XAxis labels
				myPane.XAxis.TextLabels = strLabels;
				//myPane.XAxis.ScaleFontSpec.Angle = 40;
				myPane.XAxis.ScaleFontSpec.Size=10;
				myPane.YAxis.ScaleFontSpec.Size=10;
			    myCurve.Symbol.Size = 4;
				zedChart.AxisChange();
				zedChart.Invalidate();

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
			}
		}
		private bool isO(int i)
		{
			int iMod=i%2;
			if(iMod>0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	}
}

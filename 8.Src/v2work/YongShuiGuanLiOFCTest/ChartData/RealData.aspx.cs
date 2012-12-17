using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using YongShuiGuanLiDBI;
using OpenFlashChart;

namespace YongShuiGuanLiOFCTest.ChartData
{
    public partial class RealData : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            OpenFlashChart.OpenFlashChart chart = new OpenFlashChart.OpenFlashChart();

            DataTable tbl = DitchDataReal.GetDitchDataRealDataTable();

            Line line1 = new Line();
            Line line2 = new Line();
            //List<AxisLabel> lbls = new List<AxisLabel>();
            List<string> lbls = new List<string>();
            
            foreach (DataRow row in tbl.Rows)
            {
                // TODO:
                //
                int wl1 = Convert.ToInt32(row["wl1"]);
                int wl2 = Convert.ToInt32(row["wl2"]);
                string dt = row["dt"].ToString();
                string[] temp = dt.Split(' ');
                dt = temp[0] + "\n"+ temp[1];

                line1.Values.Add(wl1);
                line1.Values.Add(wl2);
                //line1.AppendValue(wl1);
                //line2.AppendValue(wl2);

                line1.Colour = "#00ff00";

                line1.Set_Key("七亩水位", 2);
                line2.Set_Key("牛山水位", 4);


                //AxisLabel label = new AxisLabel(dt);
                string label = dt.ToString();
                //label.Rotate = "270";
                lbls.Add(label);
            }

            //chart.X_Axis.Labels.AxisLabelValues = lbls;
            chart.X_Axis.Labels.SetLabels(lbls);

            //chart.X_Legend.Text = "X";
            //chart.X_Legend = new Legend("时间");
            //chart.Y_Legend = new Legend("水位");

            chart.AddElement(line1);
            chart.AddElement(line2);
            chart.Y_Axis.Min = 0d;
            chart.Y_Axis.Max = 90d;

            chart.Title.Text = "实时水位";
            chart.Tooltip = new ToolTip("#key# : #val# cm" );
            //chart.X_Axis.Labels.Values.

            Response.CacheControl = "no-cache";
            Response.Write(chart.ToString());
            Response.End();
        }
    }
}

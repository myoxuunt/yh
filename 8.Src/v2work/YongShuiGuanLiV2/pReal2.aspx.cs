using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using ZedGraph;
using System.Drawing;
using YongShuiGuanLiDBI;

namespace YongShuiGuanLiV2
{
    public partial class pReal2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region

            //this.ZedGraphWeb1.RenderMode = RenderModeType.RawImage;
            //this.ZedGraphWeb1.RenderGraph += new ZedGraph.Web.ZedGraphWebControlEventHandler(ZedGraphWeb1_RenderGraph);
            //}

            //void ZedGraphWeb1_RenderGraph(ZedGraph.Web.ZedGraphWeb webObject, Graphics g, MasterPane pane)
            //{
            //    // Get the GraphPane so we can work with it
            //    GraphPane myPane = pane[0];

            //    // Set the title and axis labels
            //    myPane.Title.Text = "Cat Stats";
            //    myPane.YAxis.Title.Text = "Big Cats";
            //    myPane.XAxis.Title.Text = "Population";

            //    // Make up some data points
            //    string[] labels = { "Panther", "Lion", "Cheetah", "Cougar", "Tiger", "Leopard" };
            //    double[] x = { 100, 115, 75, 22, 98, 40 };
            //    double[] x2 = { 120, 175, 95, 57, 113, 110 };
            //    double[] x3 = { 204, 192, 119, 80, 134, 156 };

            //    // Generate a red bar with "Curve 1" in the legend
            //    BarItem myCurve = myPane.AddBar("Here", x, null, Color.Red);
            //    // Fill the bar with a red-white-red color gradient for a 3d look
            //    myCurve.Bar.Fill = new Fill(Color.Red, Color.White, Color.Red, 90f);

            //    // Generate a blue bar with "Curve 2" in the legend
            //    myCurve = myPane.AddBar("There", x2, null, Color.Blue);
            //    // Fill the bar with a Blue-white-Blue color gradient for a 3d look
            //    myCurve.Bar.Fill = new Fill(Color.Blue, Color.White, Color.Blue, 90f);

            //    // Generate a green bar with "Curve 3" in the legend
            //    myCurve = myPane.AddBar("Elsewhere", x3, null, Color.Green);
            //    // Fill the bar with a Green-white-Green color gradient for a 3d look
            //    myCurve.Bar.Fill = new Fill(Color.Green, Color.White, Color.Green, 90f);

            //    // Draw the Y tics between the labels instead of at the labels
            //    myPane.YAxis.MajorTic.IsBetweenLabels = true;

            //    // Set the YAxis labels
            //    myPane.YAxis.Scale.TextLabels = labels;
            //    // Set the YAxis to Text type
            //    myPane.YAxis.Type = AxisType.Text;

            //    // Set the bar type to stack, which stacks the bars by automatically accumulating the values
            //    myPane.BarSettings.Type = BarType.Stack;

            //    // Make the bars horizontal by setting the BarBase to "Y"
            //    myPane.BarSettings.Base = BarBase.Y;

            //    // Fill the axis background with a color gradient
            //    myPane.Chart.Fill = new Fill(Color.White,
            //        Color.FromArgb(255, 255, 166), 45.0F);

            //    pane.AxisChange(g);
            //}
            #endregion //
            //DataTable tbl = DitchDataReal.GetDitchDataRealDataTable();
            //this.UCZedChart1.SetTable(tbl);
        }
    }
}

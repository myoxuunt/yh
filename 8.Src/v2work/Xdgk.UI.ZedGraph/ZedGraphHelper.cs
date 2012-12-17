using System;
using System.Collections.Generic;
using System.Text;
using ZedGraph;
using System.Drawing;
//using ZedGraph.Web;

namespace Xdgk.UI.Z
{
    /// <summary>
    /// 
    /// </summary>
    public class ZedGraphHelper
    {


        #region ZedGraphHelper
        /// <summary>
        /// 
        /// </summary>
        public ZedGraphHelper()
        {

        }
        #endregion //ZedGraphHelper


        #region GraphPaneConfig
        /// <summary>
        /// 
        /// </summary>
        public GraphPaneConfig GraphPaneConfig
        {
            get
            {
                return _graphPaneConfig;
            }
            set
            {
                _graphPaneConfig = value;
            }
        } private GraphPaneConfig _graphPaneConfig;
        #endregion //GraphPaneConfig

        #region DataSource
        /// <summary>
        /// 
        /// </summary>
        public object DataSource
        {
            get
            {
                return _dataSource;
            }
            set
            {
                _dataSource = value;
            }
        } private object _dataSource;
        #endregion //DataSource



        #region ZedGraphWeb
        /// <summary>
        /// 
        /// </summary>
        public ZedGraph.Web.ZedGraphWeb ZedGraphWeb
        {
            get { return _zedGraphWeb; }
            set
            {
                _zedGraphWeb = value;
                _zedGraphWeb.RenderGraph += new ZedGraph.Web.ZedGraphWebControlEventHandler(_zedGraphWeb_RenderGraph);
            }
        }private ZedGraph.Web.ZedGraphWeb _zedGraphWeb;
        #endregion //ZedGraphWeb


        #region _zedGraphWeb_RenderGraph
        /// <summary>
        /// 
        /// </summary>
        /// <param name="webObject"></param>
        /// <param name="g"></param>
        /// <param name="pane"></param>
        void _zedGraphWeb_RenderGraph(
            ZedGraph.Web.ZedGraphWeb webObject,
            System.Drawing.Graphics g,
            ZedGraph.MasterPane pane)
        {
            // TODO:
            //
            //pane[
            this.Draw(pane[0], this.DataSource);
        }
        #endregion //_zedGraphWeb_RenderGraph


        #region Draw
        /// <summary>
        /// 
        /// </summary>
        public void Draw(ZedGraph.GraphPane pane, object dataSource)
        {
            if (this.GraphPaneConfig == null)
            {
                return;
            }

            if (this.DataSource == null)
            {
                return;
            }

            this.GraphPaneConfig.ConfigGraphPane(pane);
            foreach (CurveConfigBase cfg in this.GraphPaneConfig.CurveConfigBaseCollection)
            {
                CurveDataCollection cds = cfg.Create(dataSource);
                foreach (CurveData cd in cds)
                {
                    switch (this.GraphPaneConfig.CurItemType)
                    {
                        case CurveItemType.Line:
                            if (this.GraphPaneConfig.XAxisType == ZedGraph.AxisType.Date)
                            {
                                ZedGraph.LineItem curve = pane.AddCurve(cd.Name, cd.PointList, cd.Color);
                                curve.Symbol.Fill = new ZedGraph.Fill(Color.White);
                            }
                            else if (this.GraphPaneConfig.XAxisType == ZedGraph.AxisType.Text)
                            {
                                LineItem curve = pane.AddCurve(cd.Name, null, cd.YValues, cd.Color);
                                pane.XAxis.Scale.TextLabels = cd.XAxisLabels;
                                curve.Symbol.Fill = new Fill(Color.White);
                            }
                            break;

                        case CurveItemType.Bar:
                            pane.AddBar(cd.Name, null, cd.YValues, cd.Color);
                            pane.XAxis.Scale.TextLabels = cd.XAxisLabels;
                            break;

                        case CurveItemType.Pie:
                            pane.AddPieSlices(cd.YValues, cd.XAxisLabels);
                            break;
                    }
                }
            }
        }
        #endregion //Draw
    }
}

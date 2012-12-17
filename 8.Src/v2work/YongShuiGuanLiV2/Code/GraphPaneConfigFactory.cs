using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using YongShuiGuanLiDBI.DBNames.Complex;
using Xdgk.UI.Z;
namespace YongShuiGuanLiV2
{
    /// <summary>
    /// 
    /// </summary>
    public class GraphPaneConfigFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public GraphPaneConfig CreateNeedDistributeGraphPaneConfig()
        {
            ColorProvider cp = new ColorProvider();

            GraphPaneConfig cfg = new GraphPaneConfig();
            cfg.XAxisType = ZedGraph.AxisType.Text;

            cfg.XTitle = strings.WaterUserName;
            cfg.YTitle = strings.Amount;
            cfg.CurItemType = CurveItemType.Bar;


            SingleCurveConfig scc = new SingleCurveConfig();
            scc.Name = strings.NeedAmount;
            scc.Color = cp.GetNextColor();
            scc.XDataField = tblNeedDistribute.WaterUserName;
            scc.YDataField = tblNeedDistribute.NeedAmount;
            cfg.CurveConfigBaseCollection.Add(scc);

            scc = new SingleCurveConfig();
            scc.Name = strings.DistributeAmount;
            scc.Color = cp.GetNextColor();
            scc.XDataField = tblNeedDistribute.WaterUserName;
            scc.YDataField = tblNeedDistribute.DistributeAmount;
            cfg.CurveConfigBaseCollection.Add(scc);

            scc = new SingleCurveConfig();
            scc.Name = strings.UsedAmount;
            scc.Color = cp.GetNextColor();
            scc.XDataField = tblNeedDistribute.WaterUserName;
            scc.YDataField = tblNeedDistribute.UsedAmount;
            cfg.CurveConfigBaseCollection.Add(scc);

            return cfg;
        }
       
    }
}

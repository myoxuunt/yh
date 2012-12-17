using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Xdgk.UI;
using YongShuiGuanLiDBI.DBNames.Complex;

namespace YongShuiGuanLiV2
{
    /// <summary>
    /// 
    /// </summary>
    public class GridViewConfigFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public GridViewConfig CreateNeedDistributeGridViewConfig()
        {
            GridViewConfig c = new GridViewConfig();
            //c.GridViewColumnConfigCollection.AddBoundField("", "");

            c.GridViewColumnConfigCollection.AddBoundField(strings.WaterUserName, "WaterUserName");
            c.GridViewColumnConfigCollection.AddBoundField(strings.NeedBegin, "NeedBegin");
            c.GridViewColumnConfigCollection.AddBoundField(strings.NeedEnd, "NeedEnd");
            c.GridViewColumnConfigCollection.AddBoundField(strings.NeedAmount, "NeedAmount");
            c.GridViewColumnConfigCollection.AddBoundField(strings.DistributeAmount, "DistributeAmount");
            c.GridViewColumnConfigCollection.AddBoundField(strings.UsedAmount, "UsedAmount");

            return c;
        }
    }
}

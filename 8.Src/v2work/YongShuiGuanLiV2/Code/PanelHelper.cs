using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace YongShuiGuanLiV2
{
    /// <summary>
    /// 
    /// </summary>
    public class PanelHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="panel"></param>
        static public void InitPanelForGridView(Panel panel)
        {
            string isInited = panel.Attributes["Inited"];
            if (string.IsNullOrEmpty(isInited))
            {
                panel.Height = 400;
                panel.ScrollBars = ScrollBars.Vertical;
                panel.Attributes["Inited"] = "1";
            }
        }
    }
}

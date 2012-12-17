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
    public class MasterPageHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        static public void SetTitle(Page page, string title)
        {
            page.Title = title;
            SetMasterPageTitle(page.Master, title);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        static public void SetMasterPageTitle (MasterPage master, string title)
        {
            Site1 site1 = master as Site1;
            if (site1 != null)
            {
                site1.TitleLabelText = title;
            }
        }
    }
}

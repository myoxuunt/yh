using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace YongShuiGuanLiV2
{
    public class GridViewColumnFormatString
    {
        /// <summary>
        /// 
        /// </summary>
        static public string FloatFormatString
        {
            get { return "{0:f2}";}
        }
    }
}

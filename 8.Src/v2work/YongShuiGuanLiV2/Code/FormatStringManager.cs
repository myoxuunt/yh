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
    public class FormatStringManager
    {
        #region FloatValueFormatString
        /// <summary>
        /// 
        /// </summary>
        static public string FloatValueFormatString
        {
            get
            {
                if (_floatValueFormatString == null)
                {
                    _floatValueFormatString = string.Empty;
                }
                return _floatValueFormatString;
            }
            set
            {
                _floatValueFormatString = value;
            }
        } static private string _floatValueFormatString = "{0:F2}";
        #endregion //FloatValueFormatString

    }
}

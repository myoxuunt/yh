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
    public class ColumnNameText
    {
        #region Name
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        } private string _name;
        #endregion //Name

        #region Text
        /// <summary>
        /// 
        /// </summary>
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        } private string _text;
        #endregion //Text


        /// <summary>
        /// 
        /// </summary>
        public Unit Width
        {
            get
            {
                if (_width == null)
                {
                    _width = new Unit();
                }
                return _width;
            }
            set
            {
                _width = value;
            }
        } private Unit _width;
    }


}

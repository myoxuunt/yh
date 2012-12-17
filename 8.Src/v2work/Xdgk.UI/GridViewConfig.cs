using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace Xdgk.UI
{


    #region GridViewConfig
    /// <summary>
    ///
    /// </summary>
    public class GridViewConfig
    {

        // TODO: 2011-05-27
        //
        public GridViewColumnConfigCollection GridViewColumnConfigCollection
        {
            get
            {
                if (_gridViewColumnConfigCollection == null)
                {
                    _gridViewColumnConfigCollection = new GridViewColumnConfigCollection();
                }
                return _gridViewColumnConfigCollection;
            }
            set
            {
                _gridViewColumnConfigCollection = value;
            }
        } private GridViewColumnConfigCollection _gridViewColumnConfigCollection;

        /// <summary>
        /// 
        /// </summary>
        public bool AutoGenerateColumns
        {
            get { return _autoGenerateColumns; }
            set { _autoGenerateColumns = value; }
        } private bool _autoGenerateColumns;


        #region AllowSorting
        /// <summary>
        /// 
        /// </summary>
        public bool AllowSorting
        {
            get
            {
                return _allowSorting;
            }
            set
            {
                _allowSorting = value;
            }
        } private bool _allowSorting;
        #endregion //AllowSorting

        #region AllowPaging
        /// <summary>
        /// 
        /// </summary>
        public bool AllowPaging
        {
            get
            {
                return _allowPaging;
            }
            set
            {
                _allowPaging = value;
            }
        } private bool _allowPaging;
        #endregion //AllowPaging

        #region PageSize
        /// <summary>
        /// 
        /// </summary>
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = value;
            }
        } private int _pageSize = 10;
        #endregion //PageSize


        #region Caption
        /// <summary>
        /// 
        /// </summary>
        public string Caption
        {
            get
            {
                if (_caption == null)
                {
                    _caption = string.Empty;
                }
                return _caption;
            }
            set
            {
                _caption = value;
            }
        } private string _caption;
        #endregion //Caption

        /// <summary>
        /// 
        /// </summary>
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        } 
        // -20 panel scorllbar width
        //
        private int _width = 1000 - 20;

    }
    #endregion //GridViewConfig



    #region GridViewColumnConfigCollection
    /// <summary>
    /// 
    /// </summary>
    public class GridViewColumnConfigCollection : Xdgk.Common.Collection<GridViewColumnConfig>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="HeaderText"></param>
        /// <param name="dataFieldName"></param>
        /// <returns></returns>
        public GridViewColumnConfig AddBoundField(string HeaderText, string dataFieldName)
        {
            return AddBoundField(HeaderText, dataFieldName, null);
        }

        /// <summary>
        /// 添加BoundFiled, 支持排序,
        /// </summary>
        /// <param name="HeaderText"></param>
        /// <param name="dataFieldName"></param>
        /// <returns></returns>
        public GridViewColumnConfig AddBoundField(string HeaderText, string dataFieldName, 
            string dataFormatString)
        {
            GridViewColumnConfig c = new GridViewColumnConfig();
            c.HeaderText = HeaderText;
            c.DataTextField = dataFieldName;
            c.GridViewColumnTypeEnum = GridViewColumnTypeEnum.BoundField;
            c.SortExpression = dataFieldName;
            c.DataFormatString = dataFormatString;

            this.Add(c);
            return c;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="headerText"></param>
        /// <returns></returns>
        public GridViewColumnConfig AddTemplateField(string headerText, ITemplate itemTemplate)
        {
            GridViewColumnConfig c = new GridViewColumnConfig();
            c.GridViewColumnTypeEnum = GridViewColumnTypeEnum.TemplateField;
            c.HeaderText = headerText;
            c.ItemTemplate = itemTemplate;
            this.Add(c);
            return c;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="headerText"></param>
        /// <returns></returns>
        public GridViewColumnConfig AddHyperLinkField(string headerText, string hyperLinkText,
            string[] dataNavigateUrlFields, string dataNavigateUrlFormatString)
        {
            GridViewColumnConfig c = new GridViewColumnConfig();
            c.DataNavigateUrlFields = dataNavigateUrlFields; 
            c.DataNavigateUrlFormatString = dataNavigateUrlFormatString;
            c.HeaderText = headerText;
            c.HyperLinkText = hyperLinkText;
            c.GridViewColumnTypeEnum = GridViewColumnTypeEnum.HyperLinkField;
            this.Add(c);
            return c;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="headerText"></param>
        /// <returns></returns>
        public GridViewColumnConfig AddEditCommandField(string headerText)
        {
            GridViewColumnConfig c = new GridViewColumnConfig();
            c.GridViewColumnTypeEnum = GridViewColumnTypeEnum.CommandField;
            c.HeaderText = headerText;
            c.ShowEditButton = true;
            this.Add(c);
            return c; 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="headerText"></param>
        /// <returns></returns>
        public GridViewColumnConfig AddEditDeleteCommandField(string headerText)
        {
            GridViewColumnConfig c = new GridViewColumnConfig();
            c.GridViewColumnTypeEnum = GridViewColumnTypeEnum.CommandField;
            c.HeaderText = headerText;
            c.ShowEditButton = true;
            c.ShowDeleteButton = true;
            this.Add(c);
            return c;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="headerText"></param>
        /// <returns></returns>
        public GridViewColumnConfig AddInsertEditDeleteField(string headerText)
        {
            GridViewColumnConfig c = new GridViewColumnConfig();
            c.GridViewColumnTypeEnum = GridViewColumnTypeEnum.CommandField;
            c.HeaderText = headerText;
            c.ShowEditButton = true;
            c.ShowDeleteButton = true;
            c.ShowInsertButton = true;
            this.Add(c);
            return c;
        }


    }
    #endregion //

}

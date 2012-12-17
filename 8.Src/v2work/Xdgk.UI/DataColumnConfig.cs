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

    /// <summary>
    /// 
    /// </summary>
    public class GridViewColumnConfig
    {
        #region HeaderText
        /// <summary>
        /// 
        /// </summary>
        public string HeaderText
        {
            get
            {
                if (_headerText == null)
                {
                    _headerText = string.Empty;
                }
                return _headerText;
            }
            set
            {
                _headerText = value;
            }
        } private string _headerText;
        #endregion //HeaderText


        #region DataFormatString
        /// <summary>
        /// 
        /// </summary>
        public string DataFormatString
        {
            get { return _dataFormatString; }
            set { _dataFormatString = value; }
        } private string _dataFormatString;
        #endregion //DataFormatString

        #region DataTextField
        /// <summary>
        /// 
        /// </summary>
        public string DataTextField
        {
            get
            {
                if (_dataTextField == null)
                {
                    _dataTextField = string.Empty;
                }
                return _dataTextField;
            }
            set
            {
                _dataTextField = value;
            }
        } private string _dataTextField;
        #endregion //DataTextField

        #region Visible
        /// <summary>
        /// 
        /// </summary>
        public bool Visible
        {
            get
            {
                return _visible;
            }
            set
            {
                _visible = value;
            }
        } private bool _visible = true;
        #endregion //Visible

        #region SortExpression
        /// <summary>
        /// 
        /// </summary>
        public string SortExpression
        {
            get
            {
                if (_sortExpression == null)
                {
                    _sortExpression = string.Empty;
                }
                return _sortExpression;
            }
            set
            {
                _sortExpression = value;
            }
        } private string _sortExpression;
        #endregion //SortExpression

        //#region DataColumnType
        ///// <summary>
        ///// 
        ///// </summary>
        //public Type DataColumnType
        //{
        //    get
        //    {
        //        return _dataColumnType;
        //    }
        //    set
        //    {
        //        _dataColumnType = value;
        //    }
        //} private Type _dataColumnType;
        //#endregion //DataColumnType

        #region GridViewColumnTypeEnum
        /// <summary>
        /// 
        /// </summary>
        public GridViewColumnTypeEnum GridViewColumnTypeEnum
        {
            get
            {
                return _gridViewColumnTypeEnum;
            }
            set
            {
                _gridViewColumnTypeEnum = value;
            }
        } private GridViewColumnTypeEnum _gridViewColumnTypeEnum;
        #endregion //GridViewColumnTypeEnum


        #region Create
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal DataControlField Create()
        {
            //DataControlField dcf = null;
            //BoundField bf = new BoundField();
            //HyperLinkField h = new HyperLinkField();
            
            //dcf = h;
            //return dcf;

            return GridViewColumnFactory.Create(this);
        }
        #endregion //Create


        #region HyperLinkText
        /// <summary>
        /// 
        /// </summary>
        public string HyperLinkText
        {
            get 
            {
                if (_hyperLinkText == null)
                {
                    _hyperLinkText = string.Empty;
                }
                return _hyperLinkText;
            }
            set { _hyperLinkText = value; }
        } private string _hyperLinkText;
        #endregion //HyperLinkText


        #region DataNavigateUrlFields
        /// <summary>
        /// 
        /// </summary>
        /// <remarks >
        /// for hyper link field
        /// </remarks>
        public string[] DataNavigateUrlFields
        {
            get
            {
                if (_dataNavigateUrlFields == null)
                {
                    _dataNavigateUrlFields = new string[0];
                }
                return _dataNavigateUrlFields;
            }
            set
            {
                _dataNavigateUrlFields = value;
            }
        } private string[] _dataNavigateUrlFields;
        #endregion //DataNavigateUrlFields


        #region DataNavigateUrlFormatString
        /// <summary>
        /// 
        /// </summary>
        /// <remarks >
        /// for hyper link field
        /// </remarks>
        public string DataNavigateUrlFormatString
        {
            get
            {
                return _dataNavigateUrlFormatString;
            }
            set
            {
                _dataNavigateUrlFormatString = value;
            }
        } private string _dataNavigateUrlFormatString;
        #endregion //DataNavigateUrlFormatString

        #region for command button
        #region ShowEditButton
        /// <summary>
        /// 
        /// </summary>
        public bool ShowEditButton
        {
            get
            {
                return _showEditButton;
            }
            set
            {
                _showEditButton = value;
            }
        } private bool _showEditButton;
        #endregion //ShowEditButton

        #region ShowDeleteButton
        /// <summary>
        /// 
        /// </summary>
        public bool ShowDeleteButton
        {
            get
            {
                return _showDeleteButton;
            }
            set
            {
                _showDeleteButton = value;
            }
        } private bool _showDeleteButton;
        #endregion //ShowDeleteButton

        #region ShowSelectButton
        /// <summary>
        /// 
        /// </summary>
        public bool ShowSelectButton
        {
            get
            {
                return _showSelectButton;
            }
            set
            {
                _showSelectButton = value;
            }
        } private bool _showSelectButton;
        #endregion //ShowSelectButton

        #region ShowInsertButton
        /// <summary>
        /// 
        /// </summary>
        public bool ShowInsertButton
        {
            get
            {
                return _showInsertButton;
            }
            set
            {
                _showInsertButton = value;
            }
        } private bool _showInsertButton;
        #endregion //ShowInsertButton
        #endregion //for command button

        /// <summary>
        /// 
        /// </summary>
        public object TemplateControl
        {
            get { return _templateControl; }
            set { _templateControl = value; }
        } private object _templateControl;

        /// <summary>
        /// 
        /// </summary>
        public ITemplate ItemTemplate
        {
            get { return _itemTemplate; }
            set { _itemTemplate = value; }
        } private ITemplate _itemTemplate;

    }
}

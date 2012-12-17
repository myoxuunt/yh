using System;
using System.Drawing;
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
    /// <returns></returns>
    public delegate object DataSourceDelegate ();

    /// <summary>
    /// 
    /// </summary>
    public delegate void SortingDelegate();

    #region GridViewHelper
    /// <summary>
    /// 
    /// </summary>
    public class GridViewHelper
    {

        /// <summary>
        /// 
        /// </summary>
        private const string ISSETGRIDVIEWCONFIG = "IsSetGridViewConfig";


        #region DataSourceDelegate
        /// <summary>
        /// 
        /// </summary>
        public DataSourceDelegate DataSourceDelegate
        {
            get { return _dataSourceDelegate; }
            set { _dataSourceDelegate = value; }
        } private DataSourceDelegate _dataSourceDelegate;
        #endregion //DataSourceDelegate

        public SortingDelegate SortingDelegate
        {
            get { return _sortingDelegate; }
            set { _sortingDelegate = value; }
        } private SortingDelegate _sortingDelegate;

        #region GridViewHelper
        /// <summary>
        /// 
        /// </summary>
        /// <param name="gd"></param>
        /// <param name="dataSource"></param>
        /// <param name="cfg"></param>
        //public GridViewHelper(GridView gd, object dataSource, GridViewConfig cfg)
        public GridViewHelper(GridView gd)
        {
            _gd = gd;
            SetGridStyle(_gd);
            //gd.Width = 800;
            //_ds = dataSource;

            // register events 
            //
            gd.Sorting += new GridViewSortEventHandler(gd_Sorting);
            gd.PageIndexChanging += new GridViewPageEventHandler(gd_PageIndexChanging);
        }
        #endregion //GridViewHelper

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gd"></param>
        private void SetGridStyle(GridView gd)
        {
            gd.BackColor = Color.White;
            //gd.CellSpacing = 9;
            gd.CellPadding = 4;
            gd.BorderColor = Color.FromArgb(0xdedfde);
            gd.BorderStyle = BorderStyle.None;
            gd.ForeColor = Color.Black;
            gd.GridLines = GridLines.Both;

            gd.RowStyle.BackColor = Color.FromArgb(0xf7f7de);
            gd.FooterStyle.BackColor = Color.FromArgb(0xcccc99);

            gd.HeaderStyle.BackColor = Color.FromArgb(0x6b696b);
            gd.HeaderStyle.Font.Bold = true;
            gd.HeaderStyle.ForeColor = Color.White;

            gd.AlternatingRowStyle.BackColor = Color.White;
        }


        #region gd_PageIndexChanging
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void gd_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            HttpContext.Current.Trace.Warn("pageIndexChanging...");
            _gd.PageIndex = e.NewPageIndex;
            Bind();
        }
        #endregion //gd_PageIndexChanging


        #region DataSource
        /// <summary>
        /// 
        /// </summary>
        public object DataSource
        {
            get
            {
                return _ds;
            }
            set
            {
                _ds = value;
            }
        } private object _ds;
        #endregion //DataSource


        #region GridView
        /// <summary>
        /// 
        /// </summary>
        public GridView GridView
        {
            get
            {
                return _gd;
            }
            set
            {
                _gd = value;
            }
        } private GridView _gd;
        #endregion //GridView


        #region GridViewConfig
        /// <summary>
        /// 
        /// </summary>
        /// <param name="?"></param>
        //public void SetGridViewConfgi(GridViewConfig cfg)
        public GridViewConfig GridViewConfig
        {
            get
            {
                return _cfg;
            }
            set
            {
                _cfg = value;

                _gd.AutoGenerateColumns = _cfg.AutoGenerateColumns;
                _gd.AllowSorting = _cfg.AllowSorting;
                _gd.AllowPaging = _cfg.AllowPaging;
                _gd.PageSize = _cfg.PageSize;
                //_gd.Caption = _cfg.Caption;
                _gd.Width = _cfg.Width;

                //_gd.Columns.Clear();
                foreach (GridViewColumnConfig columnCfg in _cfg.GridViewColumnConfigCollection)
                {
                    DataControlField dcf = columnCfg.Create();
                    _gd.Columns.Add(dcf);
                }

                this._gd.Attributes[ISSETGRIDVIEWCONFIG] = "1";
            }
        } private GridViewConfig _cfg;
        #endregion //GridViewConfig


        #region Bind
        /// <summary>
        /// 
        /// </summary>
        /// <param name="gd"></param>
        /// <param name="dataSource"></param>
        /// <param name="cfg"></param>
        public void Bind()
        {
            if (this.DataSource == null)
            {
                if (this.DataSourceDelegate != null)
                {
                    _ds = this.DataSourceDelegate();
                }
            }

            DataTable tbl = _ds as DataTable;
            if (tbl == null)
            {
                _gd.DataSource = _ds;
                _gd.DataBind();
            }
            else
            {
                string sortDir = _gd.Attributes["SortDirection"];
                string sortExpress = _gd.Attributes["SortExpression"];

                if (!string.IsNullOrEmpty(sortExpress))
                {
                    tbl.DefaultView.Sort = string.Format("{0} {1}", sortExpress, sortDir);

                    System.Web.HttpContext.Current.Trace.Warn("Sort: " + tbl.DefaultView.Sort);
                }

                //_gd.DataSource = _ds;
                _gd.DataSource = tbl.DefaultView;
                _gd.DataBind();
            }
        }
        #endregion //Bind

        #region gd_Sorting
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void gd_Sorting(object sender, GridViewSortEventArgs e)
        {
            string oldSortDir = _gd.Attributes["SortDirection"];
            string oldSortExpress = _gd.Attributes["SortExpression"];

            string newSortDir = "";
            string newSortExpress = "";

            if (oldSortExpress == e.SortExpression)
            {
                if (oldSortDir == "ASC")
                {
                    newSortDir = "DESC";
                }
                else
                {
                    newSortDir = "ASC";
                }
            }
            else
            {
                newSortDir = "ASC";
                newSortExpress = e.SortExpression;
            }

            _gd.Attributes["SortDirection"] = newSortDir;
            _gd.Attributes["SortExpression"] = e.SortExpression;

            //Bind();
            if (SortingDelegate != null)
            {
                SortingDelegate();
            }
        }
        #endregion //gd_Sorting


        #region IsSetGridViewConfig
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsSetGridViewConfig()
        {
            string s = _gd.Attributes[ISSETGRIDVIEWCONFIG];
            return !string.IsNullOrEmpty(s);
        }
        #endregion //IsSetGridViewConfig



        #region AddDeleteColumn
        /// <summary>
        /// 
        /// </summary>
        //public void AddDeleteColumn(GridViewDeleteEventHandler handle)
        public void AddDeleteColumn()
        {
            CommandField delete = new CommandField();
            delete.ShowDeleteButton = true;
            //delete.HeaderText = "[Delete]";

            // TODO: 
            //
            delete.DeleteText = "<div onclick=\"JavaScript:return confirm('确定删除吗？')\">删除</div>";

            //CommandField edit = new CommandField();
            //edit.ShowEditButton = true;

            _gd.Columns.Add(delete);
            //_gd.RowDeleting += handle;
            //gridview.Columns.Add(edit);
        }
        #endregion //AddDeleteColumn

        //void _gd_RowDeleting(object sender, GridViewDeleteEventArgs e)
        //{
        //    e.rowin
        //    //throw new NotImplementedException();
        //}
    }
    #endregion //GridViewHelper
}

using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using YongShuiGuanLiDBI;
using Xdgk.UI;
using Xdgk.UI.Z;


namespace YongShuiGuanLiV2
{
    /// <summary>
    /// 
    /// </summary>
    public partial class pCompare : System.Web.UI.Page
    {
        #region H1
        /// <summary>
        /// 
        /// </summary>
        private Xdgk.UI.GridViewHelper H1
        {
            get
            {
                if (_h1 == null)
                {
                    _h1 = new Xdgk.UI.GridViewHelper(this.GridView1);
                    if (!_h1.IsSetGridViewConfig())
                    {
                        _h1.GridViewConfig = this.GetGridViewConfig();
                    }
                }
                return _h1;
            }
        } Xdgk.UI.GridViewHelper _h1;
        #endregion //H1

        #region H2
        /// <summary>
        /// 
        /// </summary>
        Xdgk.UI.GridViewHelper H2
        {
            get
            {
                if (_h2 == null)
                {
                    _h2 = new Xdgk.UI.GridViewHelper(this.GridView2);
                    if (!_h2.IsSetGridViewConfig())
                    {
                        _h2.GridViewConfig = GetGridViewConfig();
                    }
                }
                return _h2;
            }
        } Xdgk.UI.GridViewHelper _h2;
        #endregion //H2

        #region Page_Load
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            string t = null;
            if (this.DataEnum == DataEnum.Amount)
            {
                t = Titles.CompareAmount;
            }
            else if (this.DataEnum == DataEnum.WL)
            {
                t = Titles.CompareWL;
            }
            MasterPageHelper.SetTitle(this, t);
            // 2011-06-09
            //
            //object obj = H1;
            //obj = H2;

            this.UCCompareCondition1.QueryEvent += new EventHandler(UCCompareCondition1_QueryEvent);
            if (!IsPostBack)
            {
                //H1.GridViewConfig = GetGridViewConfig();
                //H2.GridViewConfig = GetGridViewConfig();


            }

            this.UCZedChart1.GraphPaneConfig = GetGraphPaneConfig();
        }
        #endregion //Page_Load

        #region GetWLOrAmountNameByDataEnum
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string GetWLOrAmountNameByDataEnum()
        {
            if (DataEnum == DataEnum.WL)
            {
                return YongShuiGuanLiDBI.DBNames.vDitchDataDay.AVGWL;
            }
            else if (DataEnum == DataEnum.Amount)
            {
                return YongShuiGuanLiDBI.DBNames.vDitchDataDay.DayAmount;
            }
            throw new InvalidOperationException("GetWLOrAmountNameByDataEnum()");
        }
        #endregion


        #region GetGridViewColumnNameByDataEnum
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string GetGridViewColumnNameByDataEnum()
        {
            if (DataEnum == DataEnum.WL)
            {
                return strings.WL;
            }
            else if (DataEnum == DataEnum.Amount)
            {
                return strings.Amount;
            }
            throw new InvalidOperationException("GetGridViewColumnNameByDataEnum()");
        }
        #endregion //GetGridViewColumnNameByDataEnum


        #region GetYTitle
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string GetYTitle()
        {
            string yTitle = string.Empty;
            if (this.DataEnum == DataEnum.WL)
            {
                yTitle = strings.WLWithUnit;
            }
            else if (this.DataEnum == DataEnum.Amount)
            {
                yTitle = strings.Amount;
            }
            else if (this.DataEnum == DataEnum.Flux)
            {
                yTitle = strings.InstantFluxWithUnit;
            }
            return yTitle;
        }
        #endregion //GetYTitle

        #region GetGraphPaneConfig
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Xdgk.UI.Z.GraphPaneConfig GetGraphPaneConfig()
        {
            GraphPaneConfig c = new GraphPaneConfig();

            string title = DataEnumClass.GetDataEnumString(this.DataEnum ) + "比较曲线";
            c.Title = title;
            c.XTitle = strings.DT;
            c.YTitle = this.GetYTitle();

            MultiCurveConfig mccfg = new MultiCurveConfig();
            mccfg.NameField = YongShuiGuanLiDBI.DBNames.vDitchDataDay.StationName;
            mccfg.XDataField = YongShuiGuanLiDBI.DBNames.vDitchDataDay.DT;
            mccfg.YDataField = GetWLOrAmountNameByDataEnum();

            c.CurveConfigBaseCollection.Add(mccfg);

            return c; 
        }
        #endregion //

        #region GetGridViewConfig
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Xdgk.UI.GridViewConfig GetGridViewConfig()
        {
            GridViewConfig cfg = new GridViewConfig();
            cfg.Caption = "cap";
            cfg.GridViewColumnConfigCollection.AddBoundField(strings.StationName, YongShuiGuanLiDBI.DBNames.vDitchDataDay.StationName);
            cfg.GridViewColumnConfigCollection.AddBoundField(strings.DT, YongShuiGuanLiDBI.DBNames.vDitchDataDay.DT);

            cfg.GridViewColumnConfigCollection.AddBoundField(
                GetGridViewColumnNameByDataEnum (), 
                GetWLOrAmountNameByDataEnum());
            //cfg.AllowPaging = true;
            //cfg.PageSize = 40;
            cfg.Width = this.GetGridViewWidth();

            return cfg;
        }
        #endregion //GetGridViewConfig


        #region GetGridViewWidth
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private int GetGridViewWidth()
        {
            return 500;
        }
        #endregion //GetGridViewWidth

        #region UCCompareCondition1_QueryEvent
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCCompareCondition1_QueryEvent(object sender, EventArgs e)
        {
            Query();
        }
        #endregion //UCCompareCondition1_QueryEvent

        #region Query
        /// <summary>
        /// 
        /// </summary>
        private void Query()
        {
            StationClass s1 = this.UCCompareCondition1.Station1;
            StationClass s2 = this.UCCompareCondition1.Station2;

            if (s1 == null || s2 == null)
                throw new InvalidOperationException("station1 or station2 is null");

            DataTable st1Tbl = this.UCCompareCondition1.ReadStation1WLDataTable();
            DataTable st2Tbl = this.UCCompareCondition1.ReadStation2WLDataTable();
            DataTable st1and2 = st1Tbl.Copy ();
            st1and2 .Merge ( st2Tbl );

            this.UCZedChart1.DataSource = st1and2;


            //this.GridView1.DataSource = st1Tbl;
            //this.GridView1.DataBind();
            this.H1.DataSource = st1Tbl;
            this.H1.Bind();


            //this.GridView2.DataSource = st2Tbl;
            //this.GridView2.DataBind();
            this.H2.DataSource = st2Tbl;
            this.H2.Bind();

            this.UCZedChart1.DataSource = st1and2;
        }
        #endregion //Query


        #region DataEnum
        /// <summary>
        /// 
        /// </summary>
        private DataEnum DataEnum
        {
            get
            {
                // return wl or amount
                //
                DataEnum de = DataEnumClass.GetDataEnumFromQueryString(
                    this.Request.QueryString, QueryStringNames.DataEnum);
                if (de == DataEnum.Flux)
                {
                    de = DataEnum.WL;
                }
                return de;
            }
        }
        #endregion //DataEnum


    }
}

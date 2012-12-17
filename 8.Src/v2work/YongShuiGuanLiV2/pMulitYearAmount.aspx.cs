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
using Xdgk.UI;
using Xdgk.UI.Z;

namespace YongShuiGuanLiV2
{
    /// <summary>
    /// 
    /// </summary>
    public partial class pMulitYearAmount : System.Web.UI.Page
    {
        #region H
        /// <summary>
        ///
        /// 
        /// </summary>
        private Xdgk.UI.GridViewHelper H
        {
            get
            {
                if (_h == null)
                {
                    _h = new Xdgk.UI.GridViewHelper(this.GridView1);
                    if (!_h.IsSetGridViewConfig())
                    {
                        _h.GridViewConfig = GetGridViewConfig();
                    }
                }
                return _h;
            }
        } Xdgk.UI.GridViewHelper _h;
        #endregion //H

        #region GetGridViewConfig
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private GridViewConfig GetGridViewConfig()
        {
            GridViewConfig c = new GridViewConfig();
            c.AutoGenerateColumns = true;
            return c;
        }
        #endregion //GetGridViewConfig

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            MasterPageHelper.SetTitle(this, Titles.MulitYearAmount);
            this.UCMulitYearCondition1.QueryEvent += new EventHandler(UCMulitYearCondition1_QueryEvent);
            if (!IsPostBack)
            {
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCMulitYearCondition1_QueryEvent(object sender, EventArgs e)
        {
            DataTable tbl = this.UCMulitYearCondition1.WaterUserCollection.GetMultiYearAmount(this.UCMulitYearCondition1.BeginYear,
                this.UCMulitYearCondition1.EndYear);

            // TODO: bind data
            //
            //this.GridView1.DataSource = tbl;
            //this.GridView1.DataBind();
            H.DataSource = tbl;
            H.Bind();

            //
            this.UCZedChart1.GraphPaneConfig = GetGraphPaneConfig(tbl);
            this.UCZedChart1.DataSource = tbl;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Xdgk.UI.Z.GraphPaneConfig GetGraphPaneConfig(DataTable tbl)
        {
            ColorProvider cp = new ColorProvider();
            GraphPaneConfig cfg = new GraphPaneConfig();
            cfg.Title = "历年用水量曲线";
            cfg.XTitle = strings.DT;
            cfg.YTitle = strings.Amount + "(m3)";
            cfg.XAxisType = ZedGraph.AxisType.Text;

            for (int i = 1; i < tbl.Columns.Count; i++)
            {
                SingleCurveConfig scc = new SingleCurveConfig();
                scc.Name = tbl.Columns[i].ColumnName;
                scc.Color = cp.GetNextColor();
                scc.XDataField = "年份";
                scc.YDataField = tbl.Columns[i].ColumnName;

                cfg.CurveConfigBaseCollection.Add(scc);
            }

            return cfg;
        }
    }
}

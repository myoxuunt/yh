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
    public partial class pMulitDuringAmount : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            MasterPageHelper.SetTitle(this, Titles.MulitDuringAmount);
            this.UCConditionYear1.QueryEvent += new EventHandler(UCConditionYear1_QueryEvent);
            if (!IsPostBack)
            {
            }
        }
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
        void UCConditionYear1_QueryEvent(object sender, EventArgs e)
        {
            int year = this.UCConditionYear1.Year;
            DuringWaterCollection d = DuringWaterFactory.CreateDuringWaterCollection();
            DataTable tbl = this.UCConditionYear1.WaterUser.LowLevelWaterUserCollection.GetMultiDuringAmount(year, d);

            //this.GridView1.DataSource = tbl;
            //this.GridView1.DataBind();
            H.DataSource = tbl;
            H.Bind();

            this.UCZedChart1.GraphPaneConfig = GetGraphPaneConfig(tbl);
            this.UCZedChart1.DataSource = tbl;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tbl"></param>
        /// <returns></returns>
        private Xdgk.UI.Z.GraphPaneConfig GetGraphPaneConfig(DataTable tbl)
        {
            ColorProvider cp = new ColorProvider();
            GraphPaneConfig cfg = new GraphPaneConfig();
            cfg.Title = "放水季用水量曲线";
            cfg.XTitle = strings.DuringWater;
            cfg.YTitle = strings.AmountWithUnit;
            cfg.XAxisType = ZedGraph.AxisType.Text;

            for (int i = 3; i < tbl.Columns.Count; i++)
            {
                SingleCurveConfig scc = new SingleCurveConfig();
                scc.Name = tbl.Columns[i].ColumnName;
                scc.XDataField = "放水季";
                scc.YDataField = tbl.Columns[i].ColumnName;
                scc.Color = cp.GetNextColor();

                cfg.CurveConfigBaseCollection.Add(scc);
            }
            return cfg;
        }
    }
}

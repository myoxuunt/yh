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
    public partial class pNeedDistributeLowLevel : System.Web.UI.Page
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
            return GridViewConfigFactory.CreateNeedDistributeGridViewConfig();
        }
        #endregion //GetGridViewConfig

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            MasterPageHelper.SetTitle(this, Titles.NeedDistributeLowLevel);
            this.UCChildWaterUserDTTwo1.QueryEvent += new EventHandler(UCChildWaterUserDTTwo1_QueryEvent);
            if (!IsPostBack)
            {
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCChildWaterUserDTTwo1_QueryEvent(object sender, EventArgs e)
        {
            DataTable r = null;
            DateTime begin = this.UCChildWaterUserDTTwo1.Begin;
            DateTime end = this.UCChildWaterUserDTTwo1.End;

            WaterUserCollection wus = this.UCChildWaterUserDTTwo1.WaterUserCollection;
            foreach (WaterUserClass w in wus)
            {
                DataTable t = w.GetNeedDistributeDataTable(begin, end);
                if (r == null)
                {
                    r = t;
                }
                else
                {
                    r.Merge(t);
                }
            }

            H.DataSource = r;
            H.Bind();

            this.UCZedChart1.GraphPaneConfig = GetGraphPaneConfig();
            this.UCZedChart1.DataSource = r;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Xdgk.UI.Z.GraphPaneConfig GetGraphPaneConfig()
        {
             GraphPaneConfig cfg = GraphPaneConfigFactory.CreateNeedDistributeGraphPaneConfig();
            cfg.Title = "需配水统计表";
            return cfg;
        }
    }
}

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


using YongShuiGuanLiDBI.DBNames.Complex;
namespace YongShuiGuanLiV2
{
    public partial class pNeedDistribute : System.Web.UI.Page
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
            MasterPageHelper.SetTitle(this, Titles.NeedDistribute);
            this.UCDTTwoOnly1.QueryEvent += new EventHandler(UCDTTwoOnly1_QueryEvent);
            if (!IsPostBack)
            {
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCDTTwoOnly1_QueryEvent(object sender, EventArgs e)
        {
            DateTime begin = this.UCDTTwoOnly1.Begin;
            DateTime end = this.UCDTTwoOnly1.End;

            WaterUserClass w = SessionManager.LoginSession.WaterUser;
            if (w != null)
            {
                DataTable tbl = w.GetNeedDistributeDataTable(begin, end);

                /*
                // -- test
                int colcount = tbl.Columns.Count;
                tbl.Rows[0][colcount - 1] = 100;
                tbl.Rows[0][colcount - 2] = 150;

                DataRow nr =  tbl.NewRow();
                nr["waterUserName"] = "n1";
                nr["NeedBegin"] = DateTime.Now;
                nr["needEnd"] = DateTime.Now;
                nr["NeedAmount"] = 30;
                nr["DistributeAmount"] = 40;
                nr["UsedAmount"] = 50;
                //nr.s
                tbl.Rows.Add(nr);


                 nr =  tbl.NewRow();
                nr["waterUserName"] = "n2";
                nr["NeedBegin"] = DateTime.Now;
                nr["needEnd"] = DateTime.Now;
                nr["NeedAmount"] = 30;
                nr["DistributeAmount"] = 40;
                nr["UsedAmount"] = 70;
                tbl.Rows.Add(nr);
                // -- test
                 */
                H.DataSource = tbl;
                H.Bind();


                // TODO: 2011-6-16
                //
                this.UCZedChart1.GraphPaneConfig = GetGraphPaneConfig();
                this.UCZedChart1.DataSource = tbl;
            }
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

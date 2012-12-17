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

namespace YongShuiGuanLiV2
{
    /// <summary>
    /// 
    /// </summary>
    public partial class pWaterPlanList : System.Web.UI.Page
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
                        _h.AddDeleteColumn();
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
            c.GridViewColumnConfigCollection.AddBoundField(strings.NeedWaterUser, "WaterUserName");
            c.GridViewColumnConfigCollection.AddBoundField(strings.NeedBegin, YongShuiGuanLiDBI.DBNames.tblNeedWater.NeedBeginDT);
            c.GridViewColumnConfigCollection.AddBoundField(strings.NeedEnd, YongShuiGuanLiDBI.DBNames.tblNeedWater.NeedEndDT);
            c.GridViewColumnConfigCollection.AddBoundField(strings.NeedAmount, YongShuiGuanLiDBI.DBNames.tblNeedWater.NeedAmount);
            c.GridViewColumnConfigCollection.AddBoundField(strings.Remark, YongShuiGuanLiDBI.DBNames.tblNeedWater.Remark);
            c.GridViewColumnConfigCollection.AddHyperLinkField("", "编辑",
                new string[] { YongShuiGuanLiDBI.DBNames.tblNeedWater.NeedWaterID},
                "pNeedWaterItem.aspx?needWaterID={0}");

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
                MasterPageHelper.SetTitle(this, Titles.NeedWaterList);
            this.GridView1.RowDeleting += new GridViewDeleteEventHandler(GridView1_RowDeleting);
            this.UCDTTwoOnly1.QueryEvent += new EventHandler(UCDTTwoOnly1_QueryEvent);
            if( !IsPostBack )
            {
                Bind();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            object obj = this.GridView1.DataKeys[e.RowIndex].Value;
            int id = Convert.ToInt32(obj);
            //DuringWaterDBI.DeleteDuring(id);
            NeedWaterDBI.Deleted(id);
            Bind();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCDTTwoOnly1_QueryEvent(object sender, EventArgs e)
        {
            Bind();
        }

        /// <summary>
        /// 
        /// </summary>
        private void Bind()
        {
            WaterUserClass wu = SessionManager.LoginSession.WaterUser;
            if (wu != null)
            {
                DateTime begin = this.UCDTTwoOnly1.Begin;
                DateTime end = this.UCDTTwoOnly1.End;
                DataTable tbl = wu.GetNeedWaterDataTable(begin, end);

                // TODO
                //
                //this.GridView1.DataSource = tbl;
                //this.GridView1.DataBind();

                H.DataSource = tbl;
                H.Bind();
            }
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //protected void btnAddWaterPlan_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("pNeedWaterItem.aspx");
        //}
    }
}

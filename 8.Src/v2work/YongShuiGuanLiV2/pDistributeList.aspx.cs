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
    public partial class pDistributeList : System.Web.UI.Page
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
                    if (!_h.IsSetGridViewConfig ())
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
            c.GridViewColumnConfigCollection.AddBoundField(strings.WaterUserName, "WaterUserName");
            c.GridViewColumnConfigCollection.AddBoundField(strings.NeedBegin, YongShuiGuanLiDBI.DBNames.tblNeedWater.NeedBeginDT);
            c.GridViewColumnConfigCollection.AddBoundField(strings.NeedEnd, YongShuiGuanLiDBI.DBNames.tblNeedWater.NeedEndDT);
            c.GridViewColumnConfigCollection.AddBoundField(strings.NeedAmount, YongShuiGuanLiDBI.DBNames.tblNeedWater.NeedAmount);
            c.GridViewColumnConfigCollection.AddBoundField(strings.DistributeBegin, YongShuiGuanLiDBI.DBNames.tblDistributeWater.DistributeBeginDT);
            c.GridViewColumnConfigCollection.AddBoundField(strings.DistributeEnd , YongShuiGuanLiDBI.DBNames.tblDistributeWater.DistributeEndDT );
            c.GridViewColumnConfigCollection.AddBoundField(strings.DistributeAmount, YongShuiGuanLiDBI.DBNames.tblDistributeWater.DistributeAmount );

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

            MasterPageHelper.SetTitle(this, Titles.DistributeList);
            this.UCDTTwoOnly1.QueryEvent += new EventHandler(UCDTTwoOnly1_QueryEvent);
            if (!IsPostBack)
            {
                Bind();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCDTTwoOnly1_QueryEvent(object sender, EventArgs e)
        {
            if (IsValid)
            {
                Bind();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void Bind()
        {
            DateTime b = this.UCDTTwoOnly1.Begin;
            DateTime e = this.UCDTTwoOnly1.End;

            WaterUserClass w = SessionManager.LoginSession.WaterUser;
            if (w != null)
            {
                DataTable t = w.GetDistributeWaterDataTable(b, e);
                H.DataSource = t;
                H.Bind();
            }
        }
    }
}

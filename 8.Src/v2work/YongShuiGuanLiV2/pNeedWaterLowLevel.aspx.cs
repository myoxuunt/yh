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

namespace YongShuiGuanLiV2
{
    public partial class pNeedWaterLowLevel : System.Web.UI.Page
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
            // TODO: 2011-6-15 
            //
            GridViewConfig c = new GridViewConfig();
            c.GridViewColumnConfigCollection.AddBoundField(strings.NeedWaterUser, "WaterUserName");
            c.GridViewColumnConfigCollection.AddBoundField(strings.NeedBegin, YongShuiGuanLiDBI.DBNames.tblNeedWater.NeedBeginDT);
            c.GridViewColumnConfigCollection.AddBoundField(strings.NeedEnd, YongShuiGuanLiDBI.DBNames.tblNeedWater.NeedEndDT);
            c.GridViewColumnConfigCollection.AddBoundField(strings.NeedAmount, YongShuiGuanLiDBI.DBNames.tblNeedWater.NeedAmount);
            c.GridViewColumnConfigCollection.AddBoundField(strings.Remark, YongShuiGuanLiDBI.DBNames.tblNeedWater.Remark);
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
                MasterPageHelper.SetTitle(this, Titles.NeedWaterLowLevel);
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
            DateTime begin = this.UCChildWaterUserDTTwo1.Begin ;
            DateTime end = this.UCChildWaterUserDTTwo1 .End ;
            DataTable t = this.UCChildWaterUserDTTwo1.WaterUserCollection.GetNeedWaterDataTable(
                begin, end);

            H.DataSource = t;
            H.Bind();


        }
    }
}

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
using YongShuiGuanLiDBI;

namespace YongShuiGuanLiV2
{
    public partial class pDuringWaterDefine : System.Web.UI.Page
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
            GridViewColumnConfig cc = null;
            Xdgk.UI.GridViewConfig c = new GridViewConfig();
            c.GridViewColumnConfigCollection.AddBoundField("放水季名称", YongShuiGuanLiDBI.DBNames.tblDuringWater.Name);
            
            cc = c.GridViewColumnConfigCollection.AddBoundField("开始日期", YongShuiGuanLiDBI.DBNames.tblDuringWater.BeginDT);
            cc.DataFormatString = "{0:MM}-{0:dd}";

            cc = c.GridViewColumnConfigCollection.AddBoundField("结束日期", YongShuiGuanLiDBI.DBNames.tblDuringWater.EndDT );
            cc.DataFormatString = "{0:MM}-{0:dd}";
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
            MasterPageHelper.SetTitle(this, Titles.DuringWaterDefine);
            DataTable tbl = DuringWaterDBI.GetDuringDataTable();
            H.DataSource = tbl;
            H.Bind();
        }
    }
}

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
    public partial class pDitchDataChangeLog : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            MasterPageHelper.SetTitle(this, "修改记录");
            if (!IsPostBack)
            {
                Query();
            }
        }

        private string WaterUserName
        {
            get
            {
                WaterUserClass c = SessionManager.LoginSession.WaterUser;
                if (c != null)
                {
                    return c.Name;
                }
                else
                {
                    return string.Empty;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void Query()
        {
            DataTable tbl = DitchData10MinuteChangeLogDBI.GetChangeLog(WaterUserName);
            //H.GridView = this.GridView1;
            //H.GrIdviewconfig = GetGridViewConfig();
            H.DataSource = tbl;
            H.Bind();
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
            c.GridViewColumnConfigCollection.AddBoundField(strings.ChannelName,
                "ChannelName");
            c.GridViewColumnConfigCollection.AddBoundField(strings.StationName,
                "StationName");
            c.GridViewColumnConfigCollection.AddBoundField("修改时间",
                "ChangeDT");
            c.GridViewColumnConfigCollection.AddBoundField(strings.DT,
                "DT");
            c.GridViewColumnConfigCollection.AddBoundField("原值",
                "OldWL");
            c.GridViewColumnConfigCollection.AddBoundField("修改值",
                "NewWL");
            c.GridViewColumnConfigCollection.AddBoundField("修改人",
                "LoginName");

            return c;
        }
        #endregion //GetGridViewConfig

    }
}

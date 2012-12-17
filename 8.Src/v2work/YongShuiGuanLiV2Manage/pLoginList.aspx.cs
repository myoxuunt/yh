using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using YongShuiGuanLiDBI;
using Xdgk.UI;

namespace YongShuiGuanLiV2Manage
{
    public partial class pLoginList : System.Web.UI.Page
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
            c.Width = 400;
            c.GridViewColumnConfigCollection.AddBoundField("用户名", YongShuiGuanLiDBI.DBNames.tb_User.Name );
            c.GridViewColumnConfigCollection.AddBoundField("相关单位", "WaterUserName");
            //c.GridViewColumnConfigCollection.add
            c.GridViewColumnConfigCollection.AddHyperLinkField("", "编辑",
                new string[]{"UserID"},
                "pLoginItem.aspx?UserID={0}");
            return c;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DataKey dk = this.GridView1.DataKeys[e.RowIndex];
            int userid = Convert.ToInt32(dk.Value);
            UserDBI.DeleteUser(userid);

            Bind();
        }
        #endregion //GetGridViewConfig

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            this.GridView1.DataKeyNames = new string[] { YongShuiGuanLiDBI.DBNames.tb_User.UserID };
            this.GridView1.RowDeleting += new GridViewDeleteEventHandler(GridView1_RowDeleting);
            if (!IsPostBack)
            {
                Bind();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void Bind()
        {
            DataTable tbl = UserDBI.GetUserDataTable();
            //this.GridView1.DataSource = tbl;
            //this.GridView1.DataBind();
            H.DataSource = tbl;
            H.Bind();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAddLogin_Click(object sender, EventArgs e)
        {
            string s = string.Format("~/pLoginItem.aspx");
            Response.Redirect(s);
        }

        // edit
        //
        //{
        //        Guid guid = Guid.NewGuid();

        //        UserClass u = new UserClass();
        //        u = UserClass.CreateUser(3);
        //        Session[guid.ToString()] = u;
        //        string s = string.Format("~/pLoginItem.aspx?key={0}", guid);
        //        Response.Redirect(s);
        //    }
    }
}

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

namespace YongShuiGuanLiV2
{
    /// <summary>
    /// 
    /// </summary>
    public partial class WaterUserList : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            this.GridView1.AutoGenerateColumns = false;
            if (!IsPostBack)
            {
                Bind();
                BindNewWaterUserLevel();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void BindNewWaterUserLevel()
        {
            this.ddlNewWaterUserLevel.DataSource = WaterUserLevel.All;
            this.ddlNewWaterUserLevel.DataTextField = "LevelName";
            this.ddlNewWaterUserLevel.DataValueField = "LevelOrdinal";
            this.ddlNewWaterUserLevel.DataBind();
        }

        /// <summary>
        /// 
        /// </summary>
        private void Bind()
        {
            GridViewHelper.SetGridViewColumn(this.GridView1, ColumnNameTextManager.WaterUserListColumnNames);
            GridViewHelper.AddEditDeleteColumn(this.GridView1);
            DataTable tbl = WaterUserDBI.GetWaterUserDataTable();
            this.GridView1.DataSource = tbl;
            this.GridView1.DataBind();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbAdd_Click(object sender, EventArgs e)
        {
            WaterUserSession ws = SessionManager.WaterUserSession;

            WaterUserLevel newWaterUserLevel = GetSelectedWaterUserLevel();
            YongShuiGuanLiDBI.WaterUserClass newWaterUser = WaterUserFactory.CreateWaterUser(newWaterUserLevel);
            ws.WaterUser = newWaterUser;

            Response.Redirect("WaterUser.aspx");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private WaterUserLevel GetSelectedWaterUserLevel()
        {
            string selValue = this.ddlNewWaterUserLevel.SelectedValue;
            int waterUserLevelOrdinal = Convert.ToInt32(selValue);
            return WaterUserLevel.GetWaterUserLevel((WaterUserLevelEnum)waterUserLevelOrdinal);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int index = e.NewEditIndex;
            if (index != -1)
            {
                object obj = this.GridView1.DataKeys[index].Value;
                int waterUserID = Convert.ToInt32(obj);
                YongShuiGuanLiDBI.WaterUserClass wu = WaterUserFactory.CreateWaterUserByID(waterUserID);
                SessionManager.WaterUserSession.WaterUser = wu;
                Response.Redirect(PageNames.WaterUser);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                //this.GridView1.Rows
                object obj = this.GridView1.DataKeys[index].Value;
                int wateruserID = Convert.ToInt32(obj);
                WaterUserDBI.DeleteWaterUser(wateruserID);

                Bind();
            }
        }

    }
}

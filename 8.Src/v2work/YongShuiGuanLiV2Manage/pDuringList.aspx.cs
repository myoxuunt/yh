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
    /// <summary>
    /// 
    /// </summary>
    public partial class pDuringList : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

            Xdgk.UI.GridViewHelper h = new Xdgk.UI.GridViewHelper(this.GridView1);

            this.GridView1.RowEditing += new GridViewEditEventHandler(GridView1_RowEditing);
            this.GridView1.RowDeleting += new GridViewDeleteEventHandler(GridView1_RowDeleting);
            this.GridView1.DataKeyNames = new string[] { YongShuiGuanLiDBI.DBNames.tblDuringWater.DuringWaterID};
            if (!IsPostBack)
            {
                h.GridViewConfig = GetViewConfig();
                YongShuiGuanLiDBI.GridViewHelper.AddEditDeleteColumn(this.GridView1);
            }

            //GridViewHelper.AddEditDeleteColumn(this.GridView1);

            DataTable t = DuringWaterDBI.GetDuringDataTable();
            ////this.GridView1.DataSource = t;
            //this.GridView1.DataBind();
            h.DataSource = t;
            h.Bind();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private GridViewConfig GetViewConfig()
        {
            GridViewColumnConfig cc = null;
            Xdgk.UI.GridViewConfig c = new GridViewConfig();
            c.Width = 400;
            c.GridViewColumnConfigCollection.AddBoundField("放水季名称", YongShuiGuanLiDBI.DBNames.tblDuringWater.Name);
            
            cc = c.GridViewColumnConfigCollection.AddBoundField("开始日期", YongShuiGuanLiDBI.DBNames.tblDuringWater.BeginDT);
            cc.DataFormatString = "{0:MM}-{0:dd}";

            cc = c.GridViewColumnConfigCollection.AddBoundField("结束日期", YongShuiGuanLiDBI.DBNames.tblDuringWater.EndDT );
            cc.DataFormatString = "{0:MM}-{0:dd}";
            return c;
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
            DuringWaterDBI.DeleteDuring(id);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            object obj = this.GridView1.DataKeys[e.NewEditIndex].Value;
            int id = Convert.ToInt32(obj);
            string s = string.Format ("pDuringItem.aspx?DuringID={0}", id);
            Response.Redirect (s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("pDuringItem.aspx");
        }

    }
}

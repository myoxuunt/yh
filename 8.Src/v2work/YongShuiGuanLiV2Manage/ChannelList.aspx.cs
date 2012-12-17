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

namespace YongShuiGuanLiV2Manage
{
    public partial class ChannelList : System.Web.UI.Page
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Trace.Warn("Page_Load, IsPostback = " + this.IsPostBack);
            this.GridView1.AutoGenerateColumns = false;

            if (!IsPostBack)
            {
                AddColumns();
                Fill();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private void Fill()
        {
            DataTable tbl = ChannelDBI.GetChannelDataTable();
            this.GridView1.DataSource = tbl;
            this.GridView1.DataBind();
        }


        /// <summary>
        /// 
        /// </summary>
        void AddColumns()
        {
            GridViewHelper.SetGridViewColumn(this.GridView1, ColumnNameTextManager.ChannelList);
            GridViewHelper.AddEditDeleteColumn(this.GridView1);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAddChannel_Click(object sender, EventArgs e)
        {
            SessionManager.ChannelSession.Clear();

            SessionManager.ChannelSession.ADEState = Xdgk.Common.ADEState.Add;

            string url = "channel.aspx";
            Response.Redirect(url);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int index = e.NewEditIndex;
            object value = this.GridView1.DataKeys[index].Value;
            int id = Convert.ToInt32(value);

            SessionManager.ChannelSession.ADEState = Xdgk.Common.ADEState.Edit;
            SessionManager.ChannelSession.SetChannalInfo(id);
            //SessionManager.ChannelSession.ChannelName = this.GridView1.Rows[index].Cells[

            string redirectString = "Channel.aspx";
            Response.Redirect(redirectString);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Trace.Warn("GridView1.DataKeys.Count = " + this.GridView1.DataKeys.Count );
            Trace.Warn("GridView1_RowDeleting RowIndex = " + e.RowIndex );
            // TODO: 
            //
            int index = e.RowIndex;
            object value = this.GridView1.DataKeys[index].Value;
            int id = Convert.ToInt32(value);

            ChannelDBI.DeleteChannel(id);
            Fill();
        }
    }
}

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
    public partial class ChannelSelect : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

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
            ChannelCollection cc = ChannelFactory.CreateChannelCollection();
            this.clChannel.DataSource = cc;
            this.clChannel.DataTextField = "ChannelName";
            this.clChannel.DataValueField = "ChannelID";
            this.DataBind();


            ChannelCollection selectedCC =  SessionManager .WaterUserSession .WaterUser.ChannelCollection ;
            foreach (ChannelClass c in selectedCC)
            {
                foreach (ListItem item in this.clChannel.Items)
                {
                    if (c.ChannelID == Convert.ToInt32(item.Value))
                    {
                        item.Selected = true;
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("WaterUser.aspx");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOK_Click(object sender, EventArgs e)
        {
            ChannelCollection cc = SessionManager.WaterUserSession.WaterUser.ChannelCollection;
            cc.Clear();
            foreach (ListItem item in this.clChannel.Items)
            {
                if (item.Selected)
                {
                    int id = Convert.ToInt32(item.Value);
                    ChannelClass c = ChannelFactory.CreateChannel(id);
                    cc.Add(c);
                }
            }
            Response.Redirect("WaterUser.aspx");
        }
    }
}

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
    public partial class StationSelect : System.Web.UI.Page
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
            else
            {
                foreach (ListItem item in this.cblStation.Items)
                {
                    string s = string.Format("{0} {1} {2}",
                        item.Selected, item.Text, item.Value);
                    Trace.Warn(s);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void Bind()
        {
            ChannelSession cs = SessionManager.ChannelSession;
            StationCollection stations = cs.GetCandidateStationList();

            //DataTable tbl = StationDBI.GetNotAssociateStationDataTable();
            this.cblStation.DataSource = stations;
            this.cblStation.DataTextField = "StationName";
            this.cblStation.DataValueField = "StationID";
            this.cblStation.DataBind();

            //int[] ids = SessionManager.GetSelectedStationIDs();
            //foreach (ListItem item in this.cblStation.Items)
            //{
            //    int id = int.Parse (item.Value );
            //    if( Array.IndexOf(ids, id )!= -1 )
            //    {
            //        item.Selected = true;
            //    }
            //}
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            string redirect = "channel.aspx";
            Response.Redirect(redirect);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOK_Click(object sender, EventArgs e)
        {
            ChannelSession cs = SessionManager.ChannelSession;

            //ArrayList list = new ArrayList();
            foreach (ListItem item in this.cblStation.Items)
            {
                if (item.Selected)
                {
                    int stationID = Convert.ToInt32(item.Value);
                    cs.StationCollection.AddByStationID(stationID);
                }
            }
            Response.Redirect("Channel.aspx");
        }
    }
}

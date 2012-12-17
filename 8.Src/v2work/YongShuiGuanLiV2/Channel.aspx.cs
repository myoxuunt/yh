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
    public partial class Channel : System.Web.UI.Page
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
                //Trace.Write(IsAdd().ToString());

                //if (IsEdit())
                //{
                    FillEditChannel();
                //}
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string n = this.txtChannelName.Text.Trim () ;
            int ignoreID = GetEditChannelID();
            bool b = ChannelDBI.ExistChannelName(n, ignoreID);
            if (b)
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private int GetEditChannelID()
        {
            return SessionManager.ChannelSession.ChannelID;

            //string idString = Request.QueryString[QueryStringNames.ID];
            //object obj = Session[QueryStringNames.ID];
            //if (obj != null)
            //{
            //    return Convert.ToInt32(obj);
            //}
            //else
            //{
            //    return -1;
            //}
            //string idString = obj as string;

            //if (idString != null)
            //{
            //    int id = Convert.ToInt32(idString);
            //    return id;
            //}
            //else
            //{
            //    return -1;
            //}
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsEdit()
        {
            //string ade = Request.QueryString[QueryStringNames.ID];

            //if (ade != null)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return SessionManager.ChannelSession.ADEState == Xdgk.Common.ADEState.Edit;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsAdd()
        {
            return SessionManager.ChannelSession.ADEState == Xdgk.Common.ADEState.Add;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOK_Click(object sender, EventArgs e)
        {
            //if (CustomValidator1.IsValid)
            if (IsValid)
            {
                ChannelSession cs = SessionManager.ChannelSession;
                string n = this.txtChannelName.Text.Trim();
                string r = this.txtChannelRemark.Text.Trim();

                cs.ChannelName = n;
                cs.ChannelRemark = r;

                cs.Save();

                //if (IsAdd())
                //{
                //    ChannelDBI.AddChannel(n, r, GetStationIDs());
                //}
                //else
                //{
                //    // edit
                //    //
                //    ChannelDBI.EditChannel(GetEditChannelID(), n, r, GetStationIDs());

                //}
                Response.Redirect("channelList.aspx");
            }

        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //private int[] GetStationIDs()
        //{
        //    //object obj = this.lstStaion.DataSource;
        //    //return null;
        //    ArrayList list = new ArrayList();
        //    foreach (ListItem item in lstStaion.Items)
        //    {
        //        list.Add(Convert.ToInt32(item.Value));
        //    }
        //    return (int[])list.ToArray(typeof(int));
        //}
        
        /// <summary>
        /// 
        /// </summary>
        private void FillEditChannel()
        {
            //DataTable tbl = ChannelDBI.GetChannelDataTable(channelID);
            //if( tbl.Rows.Count >0 )
            //{
            //    DataRow row = tbl.Rows[0];
            //    this.txtChannelName.Text = row["ChannelName"].ToString().Trim();
            //    FillStationList(channelID);
            //    this.txtChannelRemark.Text = row["Remark"].ToString().Trim();
            //}
            ChannelSession cs =  SessionManager.ChannelSession;
            this.txtChannelName.Text = cs.ChannelName;
            this.txtChannelRemark.Text = cs.ChannelRemark;

            //this.lstStaion.DataSource = cs.StationCollection;
            //this.lstStaion.DataTextField = "StationName";
            //this.lstStaion.DataValueField = "StationID";
            //this.lstStaion.DataBind();
            FillStationList();

        }

        /// <summary>
        /// 
        /// </summary>
        private void FillStationList()
        {
            ChannelSession cs = SessionManager.ChannelSession;

            this.lstStaion.DataSource = cs.StationCollection;
            this.lstStaion.DataTextField = "StationName";
            this.lstStaion.DataValueField = "StationID";
            this.lstStaion.DataBind();
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="channelID"></param>
        //private void FillStationList(int channelID)
        //{
        //    object obj = Session[SessionNames.SelectedStationIDs];
        //    int[] exStationIDs = null;
        //    if (obj != null)
        //    {
        //        exStationIDs = (int[])obj;
        //    }
        //    DataTable tbl = ChannelDBI.GetStationDataTable(channelID, exStationIDs);
        //    this.lstStaion.DataSource = tbl;
        //    this.lstStaion.DataTextField = "Name";
        //    this.lstStaion.DataValueField = "StationID";
        //    this.lstStaion.DataBind();
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAddStation_Click(object sender, EventArgs e)
        {
            SessionManager.ChannelSession.ChannelName = this.txtChannelName.Text;
            SessionManager.ChannelSession.ChannelRemark = this.txtChannelRemark.Text;

            string s = "stationSelect.aspx";
            Response.Redirect(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDeleteStation_Click(object sender, EventArgs e)
        {
            int index = lstStaion.SelectedIndex;
            if (index != -1)
            {
                SessionManager.ChannelSession.StationCollection.RemoveAt(index);

                //ChannelSession cs = SessionManager.ChannelSession;
                //this.lstStaion.DataSource = cs.StationCollection;
                //this.lstStaion.DataTextField = "StationName";
                //this.lstStaion.DataValueField = "StationID";
                //this.lstStaion.DataBind();
                this.FillStationList();
            }
        }

        protected void txtChannelName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

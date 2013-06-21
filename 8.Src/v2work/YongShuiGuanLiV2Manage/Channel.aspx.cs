using System;
using System.Drawing;
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
                FillEditChannel();
            }
            else
            {
                SaveStationColor();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string n = this.txtChannelName.Text.Trim();
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
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsEdit()
        {
            return SessionManager.ChannelSession.ADEState == Xdgk.Common.ADEStatus.Edit;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsAdd()
        {
            return SessionManager.ChannelSession.ADEState == Xdgk.Common.ADEStatus.Add;
        }


        /// <summary>
        /// 
        /// </summary>
        private void SaveStationColor()
        {
            StationCollection ss = SessionManager.ChannelSession.StationCollection;
            for( int i=0;i<this.dlStation.Items.Count ; i++)
            {
                DataListItem item = this.dlStation.Items[i];
                TextBox txtColor = item.Controls[3] as TextBox;
                StationClass station = ss[i];
                station.Color = ConvertStringToColor(txtColor.Text);
            }

        }

        /// <summary>
        /// #ff00ff, #f0f  => color
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private Color ConvertStringToColor(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                Color r = Color.White;
                WebColorConverter wcc = new WebColorConverter();
                text.Trim();
                text = text.Replace("#", "");
                if (text.Length == 6)
                {
                    r = (Color)wcc.ConvertFromString("#" + text);
                }
                if (text.Length == 3)
                {
                    text = string.Format("{0}{0}{1}{1}{2}{2}",
                        text[0], text[1], text[2]);
                    r = (Color)wcc.ConvertFromString("#" + text);
                }
                return r;
            }
            return Color.White;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                ChannelSession cs = SessionManager.ChannelSession;
                string n = this.txtChannelName.Text.Trim();
                string r = this.txtChannelRemark.Text.Trim();

                cs.ChannelName = n;
                cs.ChannelRemark = r;
                cs.Save();

                Response.Redirect("channelList.aspx");
            }

        }

        /// <summary>
        /// 
        /// </summary>
        private void FillEditChannel()
        {
            ChannelSession cs = SessionManager.ChannelSession;
            this.txtChannelName.Text = cs.ChannelName;
            this.txtChannelRemark.Text = cs.ChannelRemark;

            FillStationList();

        }

        /// <summary>
        /// 
        /// </summary>
        private void FillStationList()
        {
            ChannelSession cs = SessionManager.ChannelSession;

            this.dlStation.DataSource = cs.StationCollection;
            this.dlStation.DataBind();
        }

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
            int index = this.GetSelectedStationIndex();
            if (index != -1)
            {
                SessionManager.ChannelSession.StationCollection.RemoveAt(index);

                this.FillStationList();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int GetSelectedStationIndex()
        {
            int r = -1;
            foreach (DataListItem item in this.dlStation.Items)
            {
                CheckBox chk = item.Controls[1] as CheckBox;
                if (chk.Checked)
                {
                    r = item.ItemIndex;
                }
            }
            return r;
        }

        protected void txtChannelName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("channelList.aspx");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnStationUp_Click(object sender, EventArgs e)
        {
            int index = //lstStaion.SelectedIndex;
                this.GetSelectedStationIndex();
            if (index != -1)
            {
                SessionManager.ChannelSession.StationCollection.Up(index);
                this.FillStationList();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnStationDown_Click(object sender, EventArgs e)
        {
            int index = GetSelectedStationIndex();
            if (index != -1)
            {
                SessionManager.ChannelSession.StationCollection.Down(index);
                this.FillStationList();
            }
        }
    }
}

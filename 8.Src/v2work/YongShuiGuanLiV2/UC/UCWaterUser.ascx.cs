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
    public partial class UCWaterUser : System.Web.UI.UserControl
    {
        #region Page_Load
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        #endregion //Page_Load

        /// <summary>
        /// 
        /// </summary>
        /// <param name="wu"></param>
        public void Bind(WaterUserClass wu)
        {
            this._wu = wu;

            Bind();
            OutputDebugInfo();
        }

        /// <summary>
        /// 
        /// </summary>
        public WaterUserClass WU
        {
            get
            {
                return _wu;
            }
        }
        private WaterUserClass _wu;

        #region OutputDebugInfo
        /// <summary>
        /// 
        /// </summary>
        private void OutputDebugInfo()
        {
            string s = string.Format(
                "waterUserLevel: {0}, waterUserType: {1}",
                WU.WaterUserLevel.LevelName, 
                WU.WaterUserType.WaterUserTypeName);
            this.TextBox1.Text = s;
        }
        #endregion //OutputDebugInfo


        #region Bind
        /// <summary>
        /// 
        /// </summary>
        private void Bind()
        {
            this.txtWaterUserName.Text = WU.Name;

            this.ddlWaterUserLevel.DataSource = new object[] { WU.WaterUserLevel };
            this.ddlWaterUserLevel.DataTextField = "LevelName";
            this.ddlWaterUserLevel.DataValueField = "WaterUserLevelID";
            this.ddlWaterUserLevel.DataBind();
            
            // water user type 
            //
            this.ddlWaterUserType.DataSource = new object[] { WU.WaterUserType };
            this.ddlWaterUserType.DataTextField = "WaterUserTypeName";
            this.ddlWaterUserType.DataValueField = "WaterUserTypeID";
            this.ddlWaterUserType.DataBind();

            // parent water user
            //
            //if (WU.ParentWaterUser != null)
            //{
            //    this.ddlParentWaterUser.DataSource = new object[] { WU.ParentWaterUser };
            //    this.ddlParentWaterUser.DataTextField = "Name";
            //    this.ddlParentWaterUser.DataValueField = "WaterUserID";
            //    this.ddlParentWaterUser.DataBind();
            //}
            // in 
            //
            //this.lstIN.DataSource = WU.InDeviceCollection.StationCollection;
            this.lstIN.DataSource = WU.InDeviceCollection;
            this.lstIN.DataTextField = "StationName";
            this.lstIN.DataValueField = "DeviceID";
            this.lstIN.DataBind();

            // out
            //
            //this.lstOut.DataSource = WU.OutDeviceCollection.StationCollection;
            this.lstOut.DataSource = WU.OutDeviceCollection;
            this.lstOut.DataTextField = "StationName";
            this.lstOut.DataValueField = "DeviceID";
            this.lstOut.DataBind();

            // channel 
            //
            this.lstChannel.DataSource = WU.ChannelCollection;
            this.lstChannel.DataTextField = "ChannelName";
            this.lstChannel.DataValueField = "ChannelID";
            this.DataBind ();

            //this.lstLowLevelWaterUser .DataSource = WU.
            //this.lstLowLevelWaterUser.DataSource = WU.LowLevelWaterUserCollection;
            //this.lstLowLevelWaterUser.DataTextField = "Name";
            //this.lstLowLevelWaterUser.DataValueField = "WaterUserID";
            //this.lstLowLevelWaterUser.DataBind();

            // remark
            //
            this.txtRemark.Text = WU.Remark;
            this.txtUnitPrice.Text = WU.UnitPrice.ToString();
            // visible controls
            //
            //bool isManager = WU.WaterUserLevel.IsManager();
            //VisibleControls(isManager);
        }
        #endregion //Bind


        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="manager"></param>
        //private void VisibleControls(bool isManager)
        //{
        //    this.ddlWaterUserLevel.Visible = isManager;
        //    this.lblWaterUserLevel.Visible = isManager;

        //    this.lblChannel.Visible = isManager;
        //    this.lstChannel.Visible = isManager;

        //    this.ddlWaterUserType.Visible = !isManager;
        //    this.lblWaterUserType.Visible = !isManager;
        //}

        //#region WS
        ///// <summary>
        ///// 
        ///// </summary>
        //private WaterUserSession WS
        //{
        //    get
        //    {
        //        return SessionManager.WaterUserSession;
        //    }
        //}
        //#endregion //WS


        #region btnOK_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOK_Click(object sender, EventArgs e)
        {
            //if (this.IsValid)
            {
                WU.Name = this.txtWaterUserName.Text;
                //WU.WaterUserLevelEnum 

                //int typeid = Convert.ToInt32(this.ddlWaterUserType.SelectedValue);
                //WU.WaterUserTypeID = typeid;
                //WU.WaterUserLevel = 

                // todo: no hava parent
                //
                //int parentid = Convert.ToInt32(this.ddlParentWaterUser.SelectedValue);
                //WU.ParentWaterUserID = parentid;

                WU.Remark = this.txtRemark.Text;
                //WS.Save();
                WU.Save();
                Response.Redirect("WaterUserList.aspx");
            }
        }
        #endregion //btnOK_Click


        #region btnCancel_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("WaterUserList.aspx");
        }
        #endregion //btnCancel_Click


        #region btnAddIn_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAddIn_Click(object sender, EventArgs e)
        {
            string s = string.Format("InOutStationSelect.aspx?InOut=in");
            Response.Redirect(s);
        }
        #endregion //btnAddIn_Click


        #region btnDeleteIn_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDeleteIn_Click(object sender, EventArgs e)
        {
            int index = this.lstIN.SelectedIndex;
            if (index != -1)
            {
                int selectedInID = Convert.ToInt32(this.lstIN.SelectedValue);
                WU.InDeviceCollection.RemoveByID(selectedInID);
                this.lstIN.Items.RemoveAt(index);
            }
        }
        #endregion //btnDeleteIn_Click


        #region btnAddOut_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAddOut_Click(object sender, EventArgs e)
        {
            string s = string.Format("InOutStationSelect.aspx?InOut=out");
            Response.Redirect(s);
        }
        #endregion //btnAddOut_Click


        #region ddlWaterUserType_SelectedIndexChanged
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ddlWaterUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlWaterUserType.SelectedIndex != -1)
            {
                string selValue= ddlWaterUserType.SelectedValue;
                int selID = Convert.ToInt32(selValue);
                WU.WaterUserType = WaterUserTypeFactory.CreateWaterUserTypeByID(selID);
            }
        }
        #endregion //ddlWaterUserType_SelectedIndexChanged


        #region btnAddChannel_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAddChannel_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChannelSelect.aspx");
        }
        #endregion //btnAddChannel_Click


        //#region txtWaterUserName_TextChanged
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //protected void txtWaterUserName_TextChanged(object sender, EventArgs e)
        //{
        //    WU.Name = this.txtWaterUserName.Text.Trim();
        //}
        //#endregion //txtWaterUserName_TextChanged


        #region btnDeleteOut_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDeleteOut_Click(object sender, EventArgs e)
        {
            int index = lstOut.SelectedIndex;
            if (index != -1)
            {
                int selectedOutID = Convert.ToInt32(lstOut.SelectedValue);

                WU.OutDeviceCollection.RemoveByID(selectedOutID);
                this.lstOut.Items.RemoveAt(index);

            }
        }
        #endregion //btnDeleteOut_Click


        #region btnDeleteChannel_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDeleteChannel_Click(object sender, EventArgs e)
        {
            int index = lstChannel.SelectedIndex;
            if (index != -1)
            {
                int selectedChannelID = Convert.ToInt32(lstChannel.SelectedValue);
                WU.ChannelCollection.RemoveByID(selectedChannelID);

                lstChannel.Items.RemoveAt(index);
            }
        }
        #endregion //btnDeleteChannel_Click

        #region cvExistWaterUserName_ServerValidate
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        protected void cvExistWaterUserName_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string newWaterUserName = this.txtWaterUserName.Text.Trim();
            bool exist = WaterUserDBI.ExistWaterUserName(newWaterUserName, WU.WaterUserID);
            args.IsValid = exist == false;
        }
        #endregion //cvExistWaterUserName_ServerValidate
    }
}

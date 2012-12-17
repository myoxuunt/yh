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
    public partial class WaterUser : System.Web.UI.Page
    {
        #region Page_Load
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (WS.WaterUser == null)
            {
                Response.Redirect("wateruserlist.aspx");
            }

            //this.Button1.Text = "&Create";
            //this.Button2.Text = "&Edit";
            if (!IsPostBack)
            {
                // TODO: control visible by wateruser level 
                //


                // 1. fill data source
                //
                BindWaterUserType();


                // 2. current wateruser info
                // 
                Bind();
                BindManagementOrganization();
            }
            OutputDebugInfo();
        }
        #endregion //Page_Load


        #region OutputDebugInfo
        /// <summary>
        /// 
        /// </summary>
        private void OutputDebugInfo()
        {
            string s = string.Format(
                "waterUserLevel: {0}, waterUserType: {1}",
                WS.WaterUser.WaterUserLevel.LevelName, 
                WS.WaterUser.WaterUserType.WaterUserTypeName);
            this.TextBox1.Text = s;
        }
        #endregion //OutputDebugInfo


        #region BindManagementOrganization
        /// <summary>
        /// 
        /// </summary>
        private void BindManagementOrganization()
        {
            // TODO:
            //
            //DataTable tbl = WaterUserDBI.GetManagementOrganization();
            //this.ddlParentWaterUser.DataSource = tbl;
            WaterUserCollection wuc =  WaterUserFactory.CreateManagementWaterUserCollection();
            this.ddlParentWaterUser.DataSource = wuc;
            
            this.ddlParentWaterUser.DataTextField = "Name";
            this.ddlParentWaterUser.DataValueField = "WaterUserID";
            this.ddlParentWaterUser.DataBind();


            if (WS.WaterUser.ParentWaterUser != null)
            {
                this.ddlParentWaterUser.SelectedValue = WS.WaterUser.ParentWaterUser.WaterUserID.ToString();
            }
            else
            {
                this.ddlParentWaterUser.BackColor = System.Drawing.Color.Red;
            }
        }
        #endregion //BindManagementOrganization


        #region BindWaterUserType
        /// <summary>
        /// 
        /// </summary>
        private void BindWaterUserType()
        {
            this.ddlWaterUserType.DataSource = WaterUserTypeFactory.All;
            this.ddlWaterUserType.DataTextField = "WaterUserTypeName";
            this.ddlWaterUserType.DataValueField = "WaterUserTypeID";
            this.ddlWaterUserType.DataBind();

            // TODO: 2011-05-19 null exception
            //
            //this.ddlWaterUserType.SelectedValue = WS.WaterUser.WaterUserType.WaterUserTypeID.ToString();
        }
        #endregion //BindWaterUserType


        #region Bind
        /// <summary>
        /// 
        /// </summary>
        private void Bind()
        {
            //if (WS.ADEState == Xdgk.Common.ADEState.Edit)
            //{
            this.txtWaterUserName.Text = WS.WaterUser.Name;

            // set wateru user type
            //
            this.ddlWaterUserType.SelectedValue = WS.WaterUser.WaterUserType.WaterUserTypeID.ToString();

            //
            //
            BindManagementOrganization();

            // in 
            //
            //this.lstIN.DataSource = WS.WaterUser.InDeviceCollection.StationCollection;
            this.lstIN.DataSource = WS.WaterUser.InDeviceCollection;
            this.lstIN.DataTextField = "StationName";
            this.lstIN.DataValueField = "DeviceID";
            this.lstIN.DataBind();

            // out
            //
            //this.lstOut.DataSource = WS.WaterUser.OutDeviceCollection.StationCollection;
            this.lstOut.DataSource = WS.WaterUser.OutDeviceCollection;
            this.lstOut.DataTextField = "StationName";
            this.lstOut.DataValueField = "DeviceID";
            this.lstOut.DataBind();

            // channel 
            //
            this.lstChannel.DataSource = WS.WaterUser.ChannelCollection;
            this.lstChannel.DataTextField = "ChannelName";
            this.lstChannel.DataValueField = "ChannelID";
            //this.DataBind ();
            this.lstChannel.DataBind();

            // TODO: low level waterUser
            //
            //this.lstLowLevelWaterUser .DataSource = WS.WaterUser.
            this.lstLowLevelWaterUser.DataSource = WS.WaterUser.LowLevelWaterUserCollection;
            this.lstLowLevelWaterUser.DataTextField = "Name";
            this.lstLowLevelWaterUser.DataValueField = "WaterUserID";
            this.lstLowLevelWaterUser.DataBind();

            // remark
            //
            this.txtRemark.Text = WS.WaterUser.Remark;
            //}
        }
        #endregion //Bind


        #region WS
        /// <summary>
        /// 
        /// </summary>
        private WaterUserSession WS
        {
            get
            {
                return SessionManager.WaterUserSession;
            }
        }
        #endregion //WS


        #region btnOK_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (this.IsValid)
            {
                WS.WaterUser.Name = this.txtWaterUserName.Text;
                WS.WaterUser.Remark = this.txtRemark.Text;

                //WS.WaterUser.WaterUserLevelEnum 

                //int typeid = Convert.ToInt32(this.ddlWaterUserType.SelectedValue);
                //WS.WaterUser.WaterUserTypeID = typeid;
                //WS.WaterUser.WaterUserLevel = 

                // todo: 2011-04-09
                // no hava parent, ex: guan li ju wateruser
                //
                WaterUserLevel thisLevel = WS.WaterUser.WaterUserLevel;
                if (!thisLevel.IsTopManager())
                {
                    int parentid = Convert.ToInt32(this.ddlParentWaterUser.SelectedValue);
                    //WS.WaterUser.ParentWaterUserID = parentid;
                    WS.WaterUser.ParentWaterUser = WaterUserFactory.CreateWaterUserByID(parentid);

                    // parent water user level ordinal must > this water user level ordinal
                    //
                    WaterUserLevel parentLevel = WS.WaterUser.ParentWaterUser.WaterUserLevel;
                    if (!WaterUserLevel.Greater(parentLevel, thisLevel))
                    {
                        string errmsg = string.Format("level error : {0} < {1}",
                            parentLevel.LevelOrdinal, thisLevel.LevelOrdinal
                            );
                        //throw new InvalidOperationException(errmsg);
                        this.cvWaterUserLevel.IsValid = false;
                        return;
                    }
                }

                //WS.Save();
                WS.WaterUser.Save();
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
                WS.WaterUser.InDeviceCollection.RemoveByID(selectedInID);
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
                WS.WaterUser.WaterUserType = WaterUserTypeFactory.CreateWaterUserTypeByID(selID);
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


        #region txtWaterUserName_TextChanged
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void txtWaterUserName_TextChanged(object sender, EventArgs e)
        {
            WS.WaterUser.Name = this.txtWaterUserName.Text.Trim();
        }
        #endregion //txtWaterUserName_TextChanged


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

                WS.WaterUser.OutDeviceCollection.RemoveByID(selectedOutID);
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
                WS.WaterUser.ChannelCollection.RemoveByID(selectedChannelID);

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
            bool exist = WaterUserDBI.ExistWaterUserName(newWaterUserName, WS.WaterUser.WaterUserID);
            args.IsValid = exist == false;
        }
        #endregion //cvExistWaterUserName_ServerValidate

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ddlParentWaterUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            // todo: no hava parent
            //
            int parentid = Convert.ToInt32(this.ddlParentWaterUser.SelectedValue);
            //WS.WaterUser.ParentWaterUserID = parentid;
            WS.WaterUser.ParentWaterUser = WaterUserFactory.CreateWaterUserByID(parentid);
        }
    }
}

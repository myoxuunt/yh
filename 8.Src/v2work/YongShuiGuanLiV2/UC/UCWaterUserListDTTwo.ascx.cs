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

namespace YongShuiGuanLiV2.UC
{
    public partial class UCWaterUserListDTTwo : System.Web.UI.UserControl
    {

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler QueryEvent; 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //protected void Page_Load(object sender, EventArgs e)
        protected void Page_Init(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                YongShuiGuanLiLib.ValidatorMessageCreater.CreateSQLDateTimeMessage(
                    this.cvBegin);
                YongShuiGuanLiLib.ValidatorMessageCreater.CreateSQLDateTimeMessage(
                    this.cvEnd);

                this.txtBegin.Text = YongShuiGuanLiLib.DateTimeHelper.GetYesterday().ToString();
                this.txtEnd.Text = YongShuiGuanLiLib.DateTimeHelper.GetTomorrow().ToString();
                // fill water user list
                //
                //OrganizationDataBinder .DataBind (
                //StationDataBinder .DataBind ( 
                WaterUserClass wu = SessionManager.LoginSession.WaterUser ;
                WaterUserDataBinder.DataBind(wu, this.cblWaterUserList);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        protected void cvBegin_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = SQLDateTimeValidator.VerifyDateTime(this.txtBegin.Text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        protected void cvEnd_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = SQLDateTimeValidator.VerifyDateTime(this.txtEnd.Text);
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime Begin
        {
            get { return DateTime.Parse (this.txtBegin.Text );}
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime End
        {
            get { return DateTime.Parse (this.txtEnd.Text );}
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnQuery_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                if (this.QueryEvent != null)
                {
                    QueryEvent(this, EventArgs.Empty);
                }
            }
        }


        /// <summary>
        /// 获取选中的用水户的列表
        /// </summary>
        public WaterUserCollection WaterUserCollection
        {
            get
            {
                WaterUserCollection wus = new WaterUserCollection();
                // TODO: 2011-05-25 create select wateruser list
                //
                foreach( ListItem li in this.cblWaterUserList.Items )
                {
                    if (li.Selected)
                    {
                        int waterUserID = Convert.ToInt32(li.Value);
                        WaterUserClass u = WaterUserFactory.CreateWaterUserByID(waterUserID);
                        wus.Add(u);
                    }
                }
                return wus;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ddlOrganization_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
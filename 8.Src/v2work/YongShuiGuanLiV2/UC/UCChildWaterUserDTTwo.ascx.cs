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
using YongShuiGuanLiLib;

namespace YongShuiGuanLiV2.UC
{
    public partial class UCChildWaterUserDTTwo : System.Web.UI.UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        public event EventHandler QueryEvent;


        #region Page_Init
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Init(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                ValidatorMessageCreater.CreateSQLDateTimeMessage(this.cvBegin);
                ValidatorMessageCreater.CreateSQLDateTimeMessage(this.cvEnd);

                this.txtBegin.Text = YongShuiGuanLiLib.DateTimeHelper.GetYesterday().ToString();
                this.txtEnd.Text = YongShuiGuanLiLib.DateTimeHelper.GetTomorrow().ToString();

                //OrganizationDataBinder.DataBind(this.ddlOrganization);
                //StationDataBinder.DataBind(this.ddlStation, this.ddlOrganization, this.IsAddAll);
                WaterUserClass wu = SessionManager.LoginSession.WaterUser;
                if (wu != null)
                {
                    OrganizationDataBinder.BindLowLevelWaterUser(wu, this.ddlOrganization);
                }
            }
        }
        #endregion //Page_Init


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


        #region cvBegin_ServerValidate
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        protected void cvBegin_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = SQLDateTimeValidator.VerifyDateTime(this.txtBegin.Text);
        }
        #endregion //cvBegin_ServerValidate


        #region cvEnd_ServerValidate
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        protected void cvEnd_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = SQLDateTimeValidator.VerifyDateTime(this.txtEnd.Text);
        }
        #endregion //cvEnd_ServerValidate

        //#region 
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //public bool IsSelectedAll()
        //{
        //    bool selectedAll = true;

        //    //int index = ddlStation.SelectedIndex;
        //    //if (index != -1)
        //    //{
        //    //    int id = Convert.ToInt32(ddlStation.SelectedValue);
        //    //    if (id == 0)
        //    //    {
        //    //        selectedAll = true;
        //    //    }
        //    //    else
        //    //    {
        //    //        selectedAll = false;
        //    //    }
        //    //}
        //    return selectedAll;
        //}
        //#endregion //


        #region WaterUser
        /// <summary>
        /// 
        /// </summary>
        public WaterUserCollection  WaterUserCollection
        {
            get
            {
                WaterUserCollection wus = new WaterUserCollection();
                if (this.ddlOrganization.Items.Count > 0)
                {
                    int id = int.Parse(this.ddlOrganization.SelectedValue);
                    if (id != 0)
                    {
                        WaterUserClass wu = WaterUserFactory.CreateWaterUserByID(id);
                        wus.Add(wu);
                    }
                    else
                    {
                        WaterUserClass wu = SessionManager.LoginSession.WaterUser;
                        if (wu != null)
                        {
                            return wu.LowLevelWaterUserCollection;
                        }
                    }
                }
                return wus;
            }
            //
            //set 
            //{
            //    if (value == null)
            //    {
            //        throw new ArgumentNullException("WaterUser");
            //    }
            //    int id = value.WaterUserID;

            //    // TODO: 2011-05-27 has waterUser in ddl?
            //    //
            //    this.ddlOrganization.SelectedValue = id.ToString();
            //}
        }
        #endregion //WaterUser

        #region Begin
        /// <summary>
        /// 
        /// </summary>
        public DateTime Begin
        {
            get { return DateTime.Parse (this.txtBegin.Text );}
            set { this.txtBegin.Text = value.ToString(); }
        }
        #endregion //Begin


        #region End
        /// <summary>
        /// 
        /// </summary>
        public DateTime End
        {
            get { return DateTime.Parse (this.txtEnd.Text );}
            set
            {
                this.txtEnd.Text = value.ToString();
            }
        }
        #endregion //End

        #region IsAddAll
        /// <summary>
        /// 
        /// </summary>
        public bool IsAddAll
        {
            get { return _isAddAll; }
            set 
            {
                //_isAddAll = value; 

                _isAddAll = value;
                ListItem allListItem = this.ddlOrganization.Items.FindByValue("0");
                if (_isAddAll)
                {
                    if (allListItem == null)
                    {
                        // add
                        //
                        this.ddlOrganization.Items.Add(new ListItem(NameIDPair.ALL.Name,
                            NameIDPair.ALL.ID.ToString()));
                    }
                }
                else
                {
                    if (allListItem != null)
                    {
                        this.ddlOrganization.Items.Remove(allListItem);
                    }
                }
            }
        }private bool _isAddAll = true;
        #endregion //IsAddAll


        #region btnQuery_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnQuery_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                if (QueryEvent != null)
                {
                    QueryEvent(this, EventArgs.Empty);
                }
            }
        }
        #endregion //btnQuery_Click
    }
}

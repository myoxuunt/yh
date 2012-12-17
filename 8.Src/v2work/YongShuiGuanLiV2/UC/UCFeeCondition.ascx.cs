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
    public partial class UCFeeCondition : System.Web.UI.UserControl
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
        protected void Page_Init(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.txtBegin.Text = YongShuiGuanLiLib.DateTimeHelper.GetYesterday().ToString();
                this.txtEnd.Text = YongShuiGuanLiLib.DateTimeHelper.GetTomorrow().ToString();

                WaterUserDataBinder.DataBind(SessionManager.LoginSession.WaterUser, this.ddlWaterUser);
                this.ddlWaterUser.Items.Insert(0, new ListItem("<全部>", "0"));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnquery_click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                if (this.QueryEvent != null)
                {
                    this.QueryEvent(this, EventArgs.Empty);
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public DateTime Begin
        {
            get
            {
                return DateTime.Parse(this.txtBegin.Text);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime End 
        {
            get
            {
                return DateTime.Parse(this.txtEnd.Text);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public WaterUserCollection SelectedWaterUserCollection
        {
            get
            {
                WaterUserCollection wus = new WaterUserCollection();
                ListItem li = this.ddlWaterUser.SelectedItem;

                if (li != null)
                {
                    int id = Convert.ToInt32(li.Value);
                    if (id <= 0)
                    {
                        if (SessionManager.LoginSession.WaterUser != null)
                        {
                            return SessionManager.LoginSession.WaterUser.LowLevelWaterUserCollection;
                        }
                    }
                    else
                    {
                        WaterUserClass u = WaterUserFactory.CreateWaterUserByID(id);
                        wus.Add(u);
                    }
                }

                return wus;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        protected void cvBegin_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = YongShuiGuanLiV2.SQLDateTimeValidator.VerifyDateTime(this.txtBegin.Text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        protected void cvEnd_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = YongShuiGuanLiV2.SQLDateTimeValidator.VerifyDateTime(this.txtEnd.Text);
        }
    }
}
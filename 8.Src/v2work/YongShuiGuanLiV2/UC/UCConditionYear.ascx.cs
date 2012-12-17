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
    public partial class UCConditionYear : System.Web.UI.UserControl
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
                    this.cvDate);
                this.txtDate.Text = DateTime.Now.Year.ToString();

                OrganizationDataBinder.DataBind(this.ddlOrganization);
                StationDataBinder.DataBind(this.ddlStation, this.ddlOrganization, false);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnQuery_Click(object sender, EventArgs e)
        {
            if (this.QueryEvent != null)
            {
                QueryEvent(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Year 
        {
            get
            {
                return int.Parse(txtDate.Text);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public WaterUserClass WaterUser
        {
            get
            {
                int id = int.Parse(this.ddlOrganization.SelectedValue);
                WaterUserClass wu = WaterUserFactory.CreateWaterUserByID(id);
                return wu;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public StationClass Station
        {
            get
            {
                if (this.ddlStation.Items.Count > 0)
                {
                    int stationID = int.Parse(this.ddlStation.SelectedValue);
                    StationClass c = StationFactory.CreateStationByStationID(stationID);
                    return c;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        protected void cvBegin_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = SQLDateTimeValidator.VerifyYear(this.txtDate.Text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ddlOrganization_SelectedIndexChanged(object sender, EventArgs e)
        {
            StationDataBinder.DataBind(this.ddlStation, this.ddlOrganization, false);
        }
    }
}
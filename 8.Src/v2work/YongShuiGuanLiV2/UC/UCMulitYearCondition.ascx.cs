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
using YongShuiGuanLiDBI ;

namespace YongShuiGuanLiV2.UC
{
    public partial class UCMulitYearCondition : System.Web.UI.UserControl
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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                OrganizationDataBinder.DataBind(this.ddlOrganization);
                int year = DateTime.Now.Year ;
                for (int i = year - 10; i <= year + 10; i++)
                {
                    this.ddlBeginYear.Items.Add(i.ToString());
                    this.ddlEndYear.Items.Add(i.ToString());
                }
            }
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
                    this.QueryEvent(this, EventArgs.Empty);
                }
            }
        }

        #region BeginYear
        /// <summary>
        /// 
        /// </summary>
        public int BeginYear
        {
            get
            {
                return Convert.ToInt32(this.ddlBeginYear.Text);
            }
            set
            {
                this.ddlBeginYear.Text = value.ToString();
            }
        }
        #endregion //BeginYear

        #region EndYear
        /// <summary>
        /// 
        /// </summary>
        public int EndYear
        {
            get
            {
                return Convert.ToInt32(this.ddlEndYear.Text);
            }
            set
            {
                this.ddlEndYear.Text = value.ToString();
            }
        }
        #endregion //EndYear

        #region WaterUserCollection
        /// <summary>
        /// 
        /// </summary>
        public WaterUserCollection WaterUserCollection
        {
            get
            {
                string sel = this.ddlOrganization.SelectedValue;
                if (!string.IsNullOrEmpty(sel))
                {
                    int id = Convert.ToInt32(sel);
                    WaterUserClass w = WaterUserFactory.CreateWaterUserByID(id);
                    return w.LowLevelWaterUserCollection;
                }
                else{
                    return new WaterUserCollection();
                }
            }
        }
        #endregion //
    }
}
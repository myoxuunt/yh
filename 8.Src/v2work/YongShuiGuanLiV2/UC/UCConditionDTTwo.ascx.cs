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
    /// <summary>
    /// 
    /// </summary>
    public partial class UCConditionDTTwo : System.Web.UI.UserControl
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
            Trace.Warn("UCConditionDTTwo page_init()");
            if (!IsPostBack)
            {
                ValidatorMessageCreater.CreateSQLDateTimeMessage(this.cvBegin);
                ValidatorMessageCreater.CreateSQLDateTimeMessage(this.cvEnd);
                this.txtBegin.Text = YongShuiGuanLiLib.DateTimeHelper.GetYesterday().ToString();
                this.txtEnd.Text = YongShuiGuanLiLib.DateTimeHelper.GetTomorrow().ToString();

                OrganizationDataBinder.DataBind(this.ddlOrganization);
                StationDataBinder.DataBind(this.ddlStation, this.ddlOrganization, this.IsAddAll);
            }
        }

        #region Page_Load
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Trace.Warn("UCConditionDTTwo page_load()");
        }
        #endregion //Page_Load


        #region IsAddAll
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 默认添加 全部
        /// </remarks>
        public bool IsAddAll
        {
            get { return _isAddAll; }
            set 
            {
                _isAddAll = value;
                ListItem allListItem = this.ddlStation.Items.FindByValue("0");
                if (_isAddAll)
                {
                    if (allListItem == null)
                    {
                        // add
                        //
                        this.ddlStation.Items.Add(new ListItem(NameIDPair.ALL.Name,
                            NameIDPair.ALL.ID.ToString()));
                    }
                }
                else
                {
                    if (allListItem != null)
                    {
                        this.ddlStation.Items.Remove(allListItem);
                    }
                }
            }
        }private bool _isAddAll = true;
        #endregion //IsAddAll


        #region ddlOrganization_SelectedIndexChanged
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ddlOrganization_SelectedIndexChanged(object sender, EventArgs e)
        {
            StationDataBinder.DataBind(this.ddlStation, this.ddlOrganization, this.IsAddAll);
        }
        #endregion //ddlOrganization_SelectedIndexChanged


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
                if (ddlOrganization.SelectedItem != null &&
                    ddlStation.SelectedItem != null)
                {
                    if (this.QueryEvent != null)
                    {
                        this.QueryEvent(this, EventArgs.Empty);
                    }
                }
            }
        }
        #endregion //btnQuery_Click


        #region cvBegin_ServerValidate
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        protected void cvBegin_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid =  SQLDateTimeValidator.VerifyDateTime(this.txtBegin.Text);
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
        

        #region WaterUser
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
            // TODO: 2011-05-26 set current waterUser
            //
            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("WaterUser");
                }
                int id = value.WaterUserID;

                // TODO: 2011-05-27 has waterUser in ddl?
                //
                this.ddlOrganization.SelectedValue = id.ToString();
            }
        }
        #endregion //WaterUser


        #region Stations
        /// <summary>
        /// 获取先选中的站点的集合
        /// </summary>
        public StationCollection Stations
        {
            get
            {
                if (this.ddlStation.Items.Count == 0)
                {
                    return new StationCollection();
                }

                if (this.ddlStation.SelectedItem.Text == NameIDPair.ALL.Name)
                {
                    return this.WaterUser.ChannelCollection.StationCollection;
                }
                else
                {
                    int stationID = int.Parse(this.ddlStation.SelectedValue);
                    StationClass c = StationFactory.CreateStationByStationID(stationID);
                    StationCollection temp = new StationCollection();
                    temp.Add(c);
                    return temp;
                }
            }
            set
            {
                // 设置当前选中站点为 Stations[0]
                //
                if (value != null && value.Count > 0)
                {
                    StationClass c = value[0];
                    // TODO: 2011-05-26 ddlStation include stationID?
                    //
                    if (IsExistStation(c.StationID))
                    {
                        this.ddlStation.SelectedValue = c.StationID.ToString();
                    }
                    else
                    {
                        Trace.Warn("not find station in ddlStation: " + c.StationName);
                    }
                }
            }
        }
        #endregion //Stations

        #region IsExistStation
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stationID"></param>
        /// <returns></returns>
        private bool IsExistStation(int stationID)
        {
            ListItem item = this.ddlStation.Items.FindByValue(stationID.ToString());
            if (item != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        #endregion


        #region IsSelectedAllStation
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsSelectedAllStation()
        {
            bool selectedAll = true;

            int index = ddlStation.SelectedIndex;
            if (index != -1)
            {
                int id = Convert.ToInt32(ddlStation.SelectedValue);
                if (id == 0)
                {
                    selectedAll = true;
                }
                else
                {
                    selectedAll = false;
                }
            }
            return selectedAll;
        }
        #endregion //IsSelectedAllStation


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

    }
}

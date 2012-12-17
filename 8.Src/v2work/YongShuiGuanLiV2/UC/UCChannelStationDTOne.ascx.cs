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
    public partial class UCChannelStationDTOne : System.Web.UI.UserControl
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
                YongShuiGuanLiLib.ValidatorMessageCreater.CreateSQLDateTimeMessage(this.cvBegin);
                //YongShuiGuanLiLib.ValidatorMessageCreater.CreateSQLDateTimeMessage(this.cvEnd);

                this.txtBegin.Text = (DateTime.Now.Date - TimeSpan.FromDays(1d)).ToShortDateString();
                //this.txtEnd.Text = (DateTime.Now.Date + TimeSpan.FromDays(1d)).ToString();

                WaterUserClass wu = SessionManager.LoginSession.WaterUser;
                if (wu != null)
                {
                    ListItemCollection ds = new ListItemCollection();
                    foreach (ChannelClass c in wu.ChannelCollection)
                    {
                        string id = c.ChannelID.ToString();
                        string name = c.ChannelName;
                        ListItem li = new ListItem();
                        li.Text = name;
                        li.Value = id;
                        ds.Add(li);
                    }
                    this.ddlChannel.DataTextField = "Text";
                    this.ddlChannel.DataValueField = "Value";
                    this.ddlChannel.DataSource = ds;
                    this.ddlChannel.DataBind();

                    ddlChannel_SelectedIndexChanged(this, EventArgs.Empty);
                }
            }
        }
        #endregion //Page_Init


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
                if (this.QueryEvent != null)
                {
                    QueryEvent(this, EventArgs.Empty);
                }
            }
        }
        #endregion //btnQuery_Click

        #region Begin
        /// <summary>
        /// 
        /// </summary>
        public DateTime Begin
        {
            get { return DateTime.Parse(this.txtBegin.Text); }
            set { this.txtBegin.Text = value.ToString(); }
        }
        #endregion //Begin


        #region GetWaterUser
        private WaterUserClass GetWaterUser()
        {
            return SessionManager.LoginSession.WaterUser;
        }
        #endregion //GetWaterUser


        #region ddlChannel_SelectedIndexChanged
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ddlChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListItem item = this.ddlChannel.SelectedItem;
            if (item != null)
            {
                int id = int.Parse(item.Value);
                WaterUserClass wu = GetWaterUser();
                if (wu != null)
                {
                    ChannelClass ch = wu.ChannelCollection.GetChannelByID(id);
                    if (ch != null)
                    {
                        ListItemCollection stationList = GetStationListItemCollection(ch.StationCollection);
                        this.cblStation.DataTextField = "Text";
                        this.cblStation.DataValueField = "Value";
                        this.cblStation.DataSource = stationList;
                        this.cblStation.DataBind();

                        foreach (ListItem stitem in this.cblStation.Items)
                        {
                            stitem.Selected = IsSelectAllStation;
                        }
                    }
                }
            }
        }
        #endregion //ddlChannel_SelectedIndexChanged

        private const string IS_SELECT_ALL_STATION = "IsSelectAllStation";
        /// <summary>
        /// 
        /// </summary>
        public bool IsSelectAllStation
        {
            get
            {
                object val = this.ViewState[IS_SELECT_ALL_STATION];
                if (val != null)
                {
                    return Convert.ToBoolean(val);
                }
                else
                {
                    return true;
                }
            }
            set 
            {
                this.ViewState[IS_SELECT_ALL_STATION] = value;
            }
        } 
        //private bool _isSelectAllStation = true;

        #region GetStationListItemCollection
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stations"></param>
        /// <returns></returns>
        private ListItemCollection GetStationListItemCollection(StationCollection stations)
        {
            ListItemCollection r = new ListItemCollection();
            foreach (StationClass s in stations)
            {
                int id = s.StationID;
                string name = s.StationName;
                ListItem item = new ListItem(name, id.ToString());
                //item.Selected = true;
                r.Add(item);
            }
            return r;
        }
        #endregion //GetStationListItemCollection


        #region cvBegin_ServerValidate
        protected void cvBegin_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = SQLDateTimeValidator.VerifyDateTime(this.txtBegin.Text);
        }
        #endregion //cvBegin_ServerValidate


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


        #region SelectedStationCollection
        public StationClass SelectedStation
        {
            get
            {
                StationCollection stations= SelectedStationCollection ;
                if (stations.Count > 0)
                {
                    return stations[0];
                }
                else
                {
                    return null;
                }
                
            }
            set
            {
                if (value != null)
                {
                    StationCollection stations = new StationCollection();
                    stations.Add(value);

                    SelectedStationCollection = stations;
                }
            }

        }
        /// <summary>
        /// 
        /// </summary>
        public StationCollection SelectedStationCollection
        {
            get
            {
                StationCollection selected = new StationCollection();
                foreach (ListItem item in this.cblStation.Items)
                {
                    if (item.Selected)
                    {
                        int stationID = int.Parse(item.Value);
                        StationClass st = StationFactory.CreateStationByStationID(stationID);
                        selected.Add(st);
                    }
                }
                return selected;
            }
            set
            {
                if (value != null && value.Count > 0)
                {
                    foreach (StationClass s in value)
                    {
                        int id = s.StationID;
                        foreach (ListItem item in cblStation.Items)
                        {
                            if (item.Value == id.ToString())
                            {
                                item.Selected = true;
                            }
                        }
                    }
                }
            }
        }
        #endregion //SelectedStationCollection


        #region SelectedChannelCollection
        /// <summary>
        /// 
        /// </summary>
        public ChannelClass SelectedChannel
        {
            get
            {
                ChannelCollection channels = this.SelectedChannelCollection;
                if (channels.Count > 0)
                {
                    return channels[0];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (value != null)
                {
                    ChannelCollection channels = new ChannelCollection();
                    channels.Add(value);

                    this.SelectedChannelCollection = channels;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ChannelCollection SelectedChannelCollection
        {
            get
            {
                ChannelCollection c = new ChannelCollection();
                if (this.ddlChannel.SelectedItem != null)
                {
                    int channelID = int.Parse(this.ddlChannel.SelectedValue);
                    ChannelClass channel = ChannelFactory.CreateChannel(channelID);
                    c.Add(channel);
                }
                return c;
            }
            set
            {
                if (value != null && value.Count > 0)
                {
                    ChannelClass c = value[0];
                    int id = c.ChannelID;
                    this.ddlChannel.SelectedValue = id.ToString();

                    ddlChannel_SelectedIndexChanged(this, EventArgs.Empty);
                }
            }
        }
        #endregion //

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        protected void cvSelectionStation_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (IsSelectOneStation)
            {
                args.IsValid = this.SelectedStationCollection.Count == 1;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsSelectOneStation
        {
            get { return _isSelectOneStation; }
            set 
            {
                _isSelectOneStation = value;
                if (_isSelectOneStation)
                {
                    this.cvSelectionStation.Text = "*";
                    this.cvSelectionStation.ErrorMessage = "只能选择一个站点";
                }
            }
        } private bool _isSelectOneStation;
    }
}
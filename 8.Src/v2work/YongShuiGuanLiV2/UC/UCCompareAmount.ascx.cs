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
    public partial class UCCompareAmount : System.Web.UI.UserControl
    {

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler QueryEvent;

        #region WU
        /// <summary>
        /// 
        /// </summary>
        private WaterUserClass WU
        {
            get 
            {
                return SessionManager.LoginSession.WaterUser;
            }
        }
        #endregion //WU

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
                if (WU != null)
                {
                    ChannelDataBinder.DataBind(WU, this.DropDownList1);
                    BindStationCheckBoxList();

                    // fill year
                    //
                    for (int year = DateTime.Now.Year - 10;
                        year < DateTime.Now.Year + 10;
                        year++)
                    {
                        this.ddlYear.Items.Add(
                            new ListItem(year.ToString(), year.ToString())
                            );
                    }


                    this.rbYear.Checked = true;
                    this.rbYear_CheckedChanged(this, EventArgs.Empty);
                }

                // fill water during
                //
                DuringWaterCollection duringWaters = DuringWaterFactory.CreateDuringWaterCollection();
                this.ddlWaterDuring.DataSource = duringWaters;
                this.ddlWaterDuring.DataTextField = "Name";
                this.ddlWaterDuring.DataValueField = "ID";
                this.ddlWaterDuring.DataBind();

                // set default value
                //
                this.UCShiDuan1.DuringBegin = YongShuiGuanLiLib.DateTimeHelper.GetYesterday();
                this.UCShiDuan1.DuringEnd = YongShuiGuanLiLib.DateTimeHelper.GetYesterday();
                this.UCDanRi1.Day = DateTime.Now;
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

        #region btnOK_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (this.QueryEvent != null)
            {
                this.QueryEvent(this, EventArgs.Empty);
            }
        }
        #endregion //btnOK_Click

        #region Begin
        /// <summary>
        /// 
        /// </summary>
        public DateTime Begin
        {
            get
            {
                DateTime dt = DateTime.Parse ("2000-1-1");
                switch (this.RangeType)
                {
                    case RangeType.Day :
                        dt = this.Day;
                        break;

                    case RangeType.During :
                        dt = this.DuringWater.GetBeginDTWithYear(this.Year);
                        break;

                    case RangeType.Range:
                        dt = this.DuringBegin;
                        break;

                    case RangeType.Year :
                        dt = new DateTime(this.Year, 1, 1, 0, 0, 0);
                        break;
                }

                return dt;
            }
        }
        #endregion //Begin

        #region End
        /// <summary>
        /// 
        /// </summary>
        public DateTime End
        {
            get
            {
                DateTime dt = DateTime.Parse ("2000-1-1");
                switch (this.RangeType)
                {
                    case RangeType.Day :
                        dt = this.Day + TimeSpan.FromDays (1d);
                        break;

                    case RangeType.During :
                        dt = this.DuringWater.GetEndDTWithYear(this.Year);
                        break;

                    case RangeType.Range:
                        dt = this.DuringEnd ;
                        break;

                    case RangeType.Year :
                        dt = new DateTime(this.Year + 1, 1, 1, 0, 0, 0);
                        break;
                }

                return dt;

            }
        }
        #endregion //End

        #region  RangeType
        /// <summary>
        /// 
        /// </summary>
        public RangeType RangeType
        {
            get
            {
                RangeType rt = RangeType.Year;
                if (this.rbYear.Checked)
                {
                    rt = RangeType.Year;
                }
                if (this.rbWaterDuring.Checked)
                {
                    rt = RangeType.During;
                }
                if (this.rbShiDuan.Checked)
                {
                    rt = RangeType.Range;
                }
                if (this.rbDay.Checked)
                {
                    rt = RangeType.Day;
                }

                return rt;
            }
        }
        #endregion RangeType

        #region Year
        /// <summary>
        /// 
        /// </summary>
        public int Year
        {
            get
            { 
                string s = this.ddlYear.SelectedValue.ToString();
                return Convert.ToInt32(s);
            }
        }
        #endregion //Year

        #region DuringWater
        /// <summary>
        /// 
        /// </summary>
        public DuringWaterClass DuringWater
        {
            get
            {
                string s = this.ddlWaterDuring.SelectedItem.Value;
                int dwID = Convert.ToInt32(s);
                DuringWaterClass dw = DuringWaterFactory.CreateDuringWater(dwID);
                return dw;

            }
        }
        #endregion //DuringWater

        #region DuringBegin
        /// <summary>
        /// 
        /// </summary>
        public DateTime DuringBegin
        {
            get
            {
                //return Convert.ToDateTime(this.txtBegin.Text);
                return this.UCShiDuan1.DuringBegin;
            }
            set
            {
                this.UCShiDuan1.DuringEnd = value;
            }
        }
        #endregion //DuringBegin

        #region DuringEnd
        /// <summary>
        /// 
        /// </summary>
        public DateTime DuringEnd
        {
            get
            {
                //return Convert.ToDateTime(this.txtEnd.Text);
                return this.UCShiDuan1.DuringEnd;
            }
            set
            {
                this.UCShiDuan1.DuringEnd = value;
            }
        }
        #endregion //DuringEnd

        #region Day
        /// <summary>
        /// 
        /// </summary>
        public DateTime Day
        {
            get
            {
                //return Convert.ToDateTime(this.txtDay.Text);
                return this.UCDanRi1.Day;
            }
            set
            {
                this.UCDanRi1.Day = value;
            }
        }
        #endregion //Day

        #region SelectedChannelCollection
        /// <summary>
        /// 
        /// </summary>
        public ChannelCollection SelectedChannelCollection
        {
            get
            {
                ChannelCollection c = new ChannelCollection();
                if (this.DropDownList1 .SelectedItem != null)
                {
                    int channelID = int.Parse(this.DropDownList1 .SelectedValue);
                    ChannelClass channel = ChannelFactory.CreateChannel(channelID);
                    c.Add(channel);
                }
                return c;
            }
        }
        #endregion //SelectedChannelCollection

        #region SelectedStationCollection
        /// <summary>
        /// 
        /// </summary>
        public StationCollection SelectedStationCollection
        {
            get
            {
                StationCollection stations = new StationCollection();
                foreach (ListItem item in this.cblStation.Items)
                {
                    if (item.Selected)
                    {
                        int id = Convert.ToInt32(item.Value);
                        StationClass st = StationFactory.CreateStationByStationID(id);
                        stations.Add(st);
                    }
                }
                return stations;
            }
        }
        #endregion //SelectedStationCollection

        #region rb buttons click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void rbYear_CheckedChanged(object sender, EventArgs e)
        {
            this.panelYear.Visible = true;
            this.panelWaterDuring.Visible = false;
            this.panelShiDuan.Visible = false;
            this.panelDay.Visible = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void rbWaterDuring_CheckedChanged(object sender, EventArgs e)
        {
            this.panelYear.Visible = true;
            this.panelWaterDuring.Visible = true;
            this.panelShiDuan.Visible = false;
            this.panelDay.Visible = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void rbShiDuan_CheckedChanged(object sender, EventArgs e)
        {
            this.panelYear.Visible = false;
            this.panelWaterDuring.Visible = false;
            this.panelShiDuan.Visible = true;
            this.UCShiDuan1.AjaxStartupScript(this.UpdatePanel1);
            this.panelDay.Visible = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void rbDay_CheckedChanged(object sender, EventArgs e)
        {
            this.panelYear.Visible = false;
            this.panelWaterDuring.Visible = false;
            this.panelShiDuan.Visible = false;
            this.panelDay.Visible = true;
            this.UCDanRi1.AjaxStartupScript(this.UpdatePanel1);
        }
        #endregion //

        #region DropDownList1_SelectedIndexChanged
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindStationCheckBoxList();
        }
        #endregion //DropDownList1_SelectedIndexChanged

        #region GetFilterDeviceTypeArray
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string[] GetFilterDeviceTypeArray()
        {
            Type pageType = this.Page.GetType();
            string propertyName = "DeviceTypeFilter";
            System.Reflection.PropertyInfo pi = pageType.GetProperty(propertyName);
            if (pi != null)
            {
                object obj = pi.GetValue(this.Page, null);
                return obj as string[];
            }
            return null;
        }
        #endregion //GetFilterDeviceTypeArray

        #region BindStationCheckBoxList
        /// <summary>
        /// 
        /// </summary>
        private void BindStationCheckBoxList()
        {
            ListItem li = this.DropDownList1.SelectedItem;
            if (li != null)
            {
                string value = li.Value;
                int channelID = Convert.ToInt32(value);
                string[] deviceTypeFilter = this.GetFilterDeviceTypeArray();
                if (deviceTypeFilter != null && deviceTypeFilter.Length > 0)
                {
                    ChannelDataBinder.StationOfChannelBind(channelID, cblStation, 
                        deviceTypeFilter, IsSelectedStation );
                }
                else
                {
                    ChannelDataBinder.StationOfChannelBind(channelID, cblStation,
                        IsSelectedStation);
                }
            }
        }
        #endregion //BindStationCheckBoxList

        #region IsSelectedStation
        /// <summary>
        /// 
        /// </summary>
        public bool IsSelectedStation
        {
            get 
            {
                object value = this.ViewState["IsSelectedStation"];
                if (value != null)
                {
                    return Convert.ToBoolean(value);
                }
                else
                {
                    this.ViewState["IsSelectedStation"] = true;
                    return true;
                }

            }
            set { this.ViewState ["IsSelectedStation"]= value; }
        } 
        //private bool _isSelectedStation = true;
        #endregion //IsSelectedStation

        #region BindStationCheckBoxList
        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceTypes"></param>
        public void BindStationCheckBoxList(string[] deviceTypes)
        {
            ListItem li = this.DropDownList1.SelectedItem;
            if (li != null)
            {
                string value = li.Value;
                int channelID = Convert.ToInt32(value);

                ChannelDataBinder.StationOfChannelBind(channelID, cblStation, deviceTypes);
            }
        }
        #endregion //BindStationCheckBoxList

        #region SelectedChannelName
        /// <summary>
        /// 
        /// </summary>
        public string SelectedChannelName
        {
            get
            {
                return this.DropDownList1.SelectedItem.Text;
            }
        }
        #endregion //SelectedChannelName
    }
}

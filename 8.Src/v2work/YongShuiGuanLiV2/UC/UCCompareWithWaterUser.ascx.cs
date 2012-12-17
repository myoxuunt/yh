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
    public partial class UCCompareWithWaterUser : System.Web.UI.UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        public event EventHandler QueryEvent;


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
                    OrganizationDataBinder.BindLowLevelWaterUser(WU, this.cblLLWaterUser);

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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (this.QueryEvent != null)
            {
                this.QueryEvent(this, EventArgs.Empty);
            }
        }

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
        }
        #endregion //

        /// <summary>
        /// 
        /// </summary>
        public WaterUserCollection SelectedWaterUserCollection
        {
            get
            {
                WaterUserCollection wus = new WaterUserCollection();

                foreach ( ListItem li in  this.cblLLWaterUser .Items )
                {
                    if (li.Selected)
                    {
                        int waterUserID = Convert.ToInt32(li.Value);
                        WaterUserClass u= WaterUserFactory.CreateWaterUserByID(waterUserID);
                        wus.Add(u);
                    }
                }
                return wus;
            }
        }
    }
}
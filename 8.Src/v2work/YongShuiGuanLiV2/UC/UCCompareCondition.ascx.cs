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
using YongShuiGuanLiLib;

namespace YongShuiGuanLiV2.UC
{
    public partial class UCCompareCondition : System.Web.UI.UserControl
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
                this.txtDateBegin.Text = YongShuiGuanLiLib.DateTimeHelper.GetYesterday().ToString();
                this.txtDateBegin2.Text = YongShuiGuanLiLib.DateTimeHelper.GetYesterday().ToString();

                this.txtDateEnd.Text = YongShuiGuanLiLib.DateTimeHelper.GetTomorrow().ToString();
                this.txtDateEnd2.Text = YongShuiGuanLiLib.DateTimeHelper.GetTomorrow().ToString();

                if (SessionManager.LoginSession.WaterUser != null)
                {
                    int ID = SessionManager.LoginSession.WaterUser.WaterUserID;
                    StationDataBinder.DataBind(this.ddlStation, ID, false);
                    StationDataBinder.DataBind(this.ddlStation2, ID, false);
                }
            }
        }
        #endregion //Page_Init


        #region Station1
        /// <summary>
        /// 
        /// </summary>
        public StationClass Station1
        {
            get
            {
                string selVal = this.ddlStation.SelectedValue;
                int stationID = int.Parse (selVal );
                StationClass sc = StationFactory.CreateStationByStationID(stationID);
                return sc;

            }
        }
        #endregion //Station1

        #region Read station1 data table
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable ReadStation1WLDataTable()
        {
            //int deviceid = this.Station1.DeviceCollection[0].DeviceID;
            if (this.Station1.DeviceCollection.Count > 0)
            {
                return this.Station1.DeviceCollection[0].GetDayDitchData(this.Begin, this.End);
            }
            return null;
            
        }
        #endregion

        #region Read station2 data table
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable ReadStation2WLDataTable()
        {
            //int deviceid = this.Station1.DeviceCollection[0].DeviceID;
            if (this.Station2.DeviceCollection.Count > 0)
            {
                return this.Station2.DeviceCollection[0].GetDayDitchData(this.Begin2, this.End2);
            }
            return null;
            
        }
        #endregion


        #region Station2
        /// <summary>
        /// 
        /// </summary>
        public StationClass Station2
        {
            get
            {
                string selVal = this.ddlStation2.SelectedValue;
                int stationID = int.Parse (selVal );
                StationClass sc = StationFactory.CreateStationByStationID(stationID);
                return sc;
            }
        }
        #endregion //Station2


        #region Begin
        /// <summary>
        /// 
        /// </summary>
        public DateTime Begin
        {
            get
            {
                return Convert.ToDateTime(this.txtDateBegin.Text);
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
                
                return Convert.ToDateTime(this.txtDateEnd.Text);
            }
        }
        #endregion //End
        


        #region Begin2
        /// <summary>
        /// 
        /// </summary>
        public DateTime Begin2
        {
            get
            {
                return Convert.ToDateTime(this.txtDateBegin2.Text);
            }
        }
        #endregion //Begin2


        #region End2
        /// <summary>
        /// 
        /// </summary>
        public DateTime End2
        {
            get
            {
                
                return Convert.ToDateTime(this.txtDateEnd2.Text);
            }
        }
        #endregion //End2


        #region btnQuery_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnQuery_Click(object sender, EventArgs e)
        {
            ValidatorMessageCreater.CreateSQLDateTimeMessage(this.cvDateBegin);
            ValidatorMessageCreater.CreateSQLDateTimeMessage(this.cvDateEnd);
            ValidatorMessageCreater.CreateSQLDateTimeMessage(this.cvDateBegin2);
            ValidatorMessageCreater.CreateSQLDateTimeMessage(this.cvDateEnd2);

            if (Page.IsValid)
            {
                if (this.QueryEvent != null)
                {
                    QueryEvent(this, EventArgs.Empty);
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
            args.IsValid = SQLDateTimeValidator.VerifyDateTime(this.txtDateBegin.Text);
        }

        protected void cvEnd_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = SQLDateTimeValidator.VerifyDateTime(this.txtDateEnd.Text );
        }

        protected void cvBegin2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = SQLDateTimeValidator.VerifyDateTime(this.txtDateBegin2.Text);
        }

        protected void cvEnd2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = SQLDateTimeValidator.VerifyDateTime(this.txtDateEnd2.Text );
        }

        #endregion //cvBegin_ServerValidate
    }
}

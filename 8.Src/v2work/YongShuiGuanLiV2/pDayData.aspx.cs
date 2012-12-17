using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using YongShuiGuanLiDBI;

namespace YongShuiGuanLiV2
{
    /// <summary>
    /// 
    /// </summary>
    public partial class pDayData : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        public DeviceAlarmManager DeviceAlarmManager
        {
            get
            {
                if (_deviceAlarmManager == null)
                {
                    _deviceAlarmManager = new DeviceAlarmManager();
                }
                return _deviceAlarmManager;
            }
        } private DeviceAlarmManager _deviceAlarmManager;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (WU == null)
            {
                return;
            }

            this.GridView1.DataKeyNames = new string[] { "DitchData10MinuteID" };
            this.UCChannelStationDTOne1.QueryEvent += new EventHandler(UCChannelStationDTOne1_QueryEvent);
            this.GridView1.RowEditing += new GridViewEditEventHandler(GridView1_RowEditing);
            this.GridView1.RowCancelingEdit += new GridViewCancelEditEventHandler(GridView1_RowCancelingEdit);
            this.GridView1.RowUpdating += new GridViewUpdateEventHandler(GridView1_RowUpdating);
            this.GridView1.PageIndexChanging += new GridViewPageEventHandler(GridView1_PageIndexChanging);
            this.GridView1.RowDataBound += new GridViewRowEventHandler(GridView1_RowDataBound);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //e.Row.dat
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.RowIndex != this.GridView1.EditIndex)
                {
                    int n = int.Parse(e.Row.Cells[GetWLColumnIndex()].Text);
                    if ((n < 0) ||
                        (IsBeyondScopeOfAlarm(e.Row.DataItem)))
                    {
                        e.Row.Cells[GetWLColumnIndex()].BackColor = System.Drawing.Color.Red;
                    }
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataItem"></param>
        /// <returns></returns>
        private bool IsBeyondScopeOfAlarm(object dataItem)
        {
            DataRowView rowview = dataItem as DataRowView;
            int deviceid = Convert.ToInt32(rowview["DeviceID"]);
            int wl = Convert.ToInt32(rowview["wl1"]);
            return IsBeyondScopeOfAlarm(deviceid, wl);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceID"></param>
        /// <returns></returns>
        private bool IsBeyondScopeOfAlarm(int deviceID, int wl)
        {
            return this.DeviceAlarmManager.IsBeyondScopeOfAlarm(deviceID, wl);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private int GetWLColumnIndex()
        {
            if (UserClass != null)
            {
                if (UserClass.AllowEditData)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView1.PageIndex = e.NewPageIndex;
            this.Query();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        private string GetUpdatingText(int row, int col)
        {
            string s = ((TextBox)(this.GridView1.Rows[row].Cells[col].Controls[0])).Text.ToString().Trim();
            return s;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string userName = WU.Name;

            string wl = GetUpdatingText(e.RowIndex, GetWLColumnIndex());
            int r;
            bool b = int.TryParse(wl, out r);


            if (b)
            {
                int dataid = Convert.ToInt32(this.GridView1.DataKeys[e.RowIndex].Value);
                DitchData10MinuteChangeLogDBI.AddDitchData10MinuteChangeItem(dataid, r, userName);

                DitchData10MinuteDBI.UpdateWL1(dataid, r);
                //throw new NotImplementedException();
                this.GridView1.EditIndex = -1;
                this.Query();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //throw new NotImplementedException();
            this.GridView1.EditIndex = -1;
            this.Query();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            this.GridView1.EditIndex = e.NewEditIndex;
            this.Query();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCChannelStationDTOne1_QueryEvent(object sender, EventArgs e)
        {
            Query();
        }

        /// <summary>
        /// 
        /// </summary>
        private void Query()
        {
            DateTime begin = this.UCChannelStationDTOne1.Begin;
            begin = begin.Date;
            DateTime end = begin + TimeSpan.FromDays(1d);
            DataTable tbl = this.UCChannelStationDTOne1.SelectedStationCollection.GetDitchDataTable(
                begin, end);

            this.GridView1.Columns.Clear();
            Xdgk.UI.GridViewHelper h = new Xdgk.UI.GridViewHelper(this.GridView1);
            h.DataSource = tbl;
            h.GridViewConfig = getGridViewConfig();
            h.Bind();

            //this.GridView1.DataSource = tbl;
            //this.GridView1.DataBind();

            string selChannel = this.UCChannelStationDTOne1.SelectedChannelCollection[0].ChannelName;
            string chartTitle = string.Format("{0} {1}日水位", begin.ToShortDateString(), selChannel);
            string yTitle = "水位(cm)";

            //DataTableHelper
            //this.UCAMChart1.SetLineChartInfo(tbl,
            //this.UCAMChart1.SetDayLineChartInfo (tbl,
            //"StationName", "DT", "WL1", chartTitle, yTitle);
            this.UCAMChart1.SetLineChartInfo(tbl, "StationName", "DT", "WL1",
                chartTitle, yTitle);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Xdgk.UI.GridViewConfig getGridViewConfig()
        {
            //CommandField editColumn = new CommandField();
            //editColumn.ShowEditButton = true;

            //this.GridView1.Columns.Add(editColumn);

            Xdgk.UI.GridViewConfig cfg = new Xdgk.UI.GridViewConfig();
            cfg.AllowPaging = true;
            cfg.PageSize = 15;

            //cfg.GridViewColumnConfigCollection.Add();
            if (UserClass.AllowEditData)
            {
                cfg.GridViewColumnConfigCollection.AddEditCommandField(string.Empty);
            }

            cfg.GridViewColumnConfigCollection.AddBoundField(strings.ChannelName,
                "ChannelName");

            cfg.GridViewColumnConfigCollection.AddBoundField(strings.StationName,
                "StationName");

            cfg.GridViewColumnConfigCollection.AddBoundField(strings.DT,
                "DT");

            cfg.GridViewColumnConfigCollection.AddBoundField(strings.WL,
                "WL1");
            return cfg;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public UserClass UserClass
        {
            get
            {
                return SessionManager.LoginSession.User;
            }
        }
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
    }

}

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
using Xdgk.UI;
using Xdgk.UI.AMCharts;

namespace YongShuiGuanLiV2
{
    public partial class pFluxHistory2 : System.Web.UI.Page
    {

        #region Page_Load
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            // TODO:
            //
            MasterPageHelper.SetTitle(this, DataEnumClass.GetDataEnumString(this.DataEnum));
            this.UCChannelStationDT1.QueryEvent += new EventHandler(UCChannelStationDT1_QueryEvent);
            if (!IsPostBack)
            {
                ChannelStationDTCondition c;
                bool hasIDParam = GetChannelStationDTCondition(out c);
                if (hasIDParam)
                {
                    this.UCChannelStationDT1.SelectedChannelCollection = c.ChannelCollection;
                    this.UCChannelStationDT1.SelectedStationCollection = c.StationCollection;
                    this.UCChannelStationDT1.Begin = c.Begin;
                    this.UCChannelStationDT1.End = c.End;

                    MasterPageHelper.SetTitle(this, DataEnumClass.GetDataEnumString(c.DataEnum));
                    Query();
                }
                else
                {
                    MasterPageHelper.SetTitle(this, DataEnumClass.GetDataEnumString(this.DataEnum));
                }
            }
            else
            {
                this.UCAMChart1.Visible = false;
            }
        }
        #endregion //Page_Load

        #region GetChannelStationDTCondition
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool GetChannelStationDTCondition(out ChannelStationDTCondition c)
        {
            c = null;

            string[] names = new string[] { "id" };
            Type[] types = new Type[] { typeof(string) };
            object[] result = new object[1];

            bool b = QueryStringParamPicker.Pick(this.Request.QueryString, names, types, out result);
            if (b)
            {
                string id = result[0] as string;
                c = Session[id] as ChannelStationDTCondition;
                if (c == null)
                {
                    b = false;
                }


            }

            return b;
        }
        #endregion //GetChannelStationDTCondition

        #region H
        /// <summary>
        ///
        /// 
        /// </summary>
        private Xdgk.UI.GridViewHelper H
        {
            get
            {
                if (_h == null)
                {
                    _h = new Xdgk.UI.GridViewHelper(this.GridView1);
                    if (!_h.IsSetGridViewConfig())
                    {
                        _h.GridViewConfig = GetGridViewConfig();
                    }
                }
                return _h;
            }
        } Xdgk.UI.GridViewHelper _h;
        #endregion //H

        #region GetGridViewConfig
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private GridViewConfig GetGridViewConfig()
        {
            GridViewConfig c = new GridViewConfig();

            return c;
        }
        #endregion //GetGridViewConfig

        #region UCChannelStationDT1_QueryEvent
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCChannelStationDT1_QueryEvent(object sender, EventArgs e)
        {
            Query();
        }
        #endregion //UCChannelStationDT1_QueryEvent

        #region Query
        /// <summary>
        /// 
        /// </summary>
        private void Query()
        {
            StationCollection selected = this.UCChannelStationDT1.SelectedStationCollection;
            DateTime begin = this.UCChannelStationDT1.Begin;
            DateTime end = this.UCChannelStationDT1.End;

            if (this.UCChannelStationDT1.IsDateTimePoint)
            {
                DataTable t = selected.GetDitchDataSection(end);
                string valueName = string.Empty;
                switch (this.DataEnum)
                {
                    case DataEnum.WL:
                        valueName = "WL1";
                        break;

                    case DataEnum.Flux:
                        valueName = YongShuiGuanLiDBI.DBNames.vDitchData.InstantFlux;
                        break;

                    case DataEnum.Amount:
                        valueName = YongShuiGuanLiDBI.DBNames.vDitchDataDay.DayAmount;
                        break;
                }
                this.UCAMChart1.SetColumnChartInfo(t, "StationName", valueName, "DT");
            }
            else
            {
                switch (this.DataEnum)
                {
                    case DataEnum.WL:
                        QueryWL(selected, begin, end);
                        break;

                    case DataEnum.Flux:
                        QueryFlux(selected, begin, end);
                        break;

                    case DataEnum.Amount:
                        QueryAmount(selected, begin, end);
                        break;
                }
            }

            this.UCAMChart1.Visible = true;
        }
        #endregion //Query

        #region QueryAmount
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selected"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        private void QueryAmount(StationCollection selected, DateTime begin, DateTime end)
        {
            DataTable tbl = selected.GetAmountDataTable(begin, end);
            this.UCAMChart1.SetLineChartInfo(tbl,
                YongShuiGuanLiDBI.DBNames.vDitchDataDay.StationName,
                YongShuiGuanLiDBI.DBNames.vDitchDataDay.DT,
                YongShuiGuanLiDBI.DBNames.vDitchDataDay.DayAmount);

            this.GridView1.DataSource = tbl;
            this.GridView1.DataBind();
        }
        #endregion //QueryAmount

        #region QueryFlux
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selected"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        private void QueryFlux(StationCollection selected, DateTime begin, DateTime end)
        {
            DataTable tbl = selected.GetFluxDataTable(begin, end);
            this.UCAMChart1.SetLineChartInfo(tbl,
                YongShuiGuanLiDBI.DBNames.vDitchData.StationName,
                YongShuiGuanLiDBI.DBNames.vDitchData.DT,
                YongShuiGuanLiDBI.DBNames.vDitchData.InstantFlux);

            this.GridView1.DataSource = tbl;
            this.GridView1.DataBind();

        }
        #endregion //QueryFlux

        #region QueryWL
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selected"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        private void QueryWL(StationCollection selected, DateTime begin, DateTime end)
        {
            DataTable tbl = selected.GetWL1DataTable(begin, end);

            this.UCAMChart1.SetLineChartInfo(tbl,
                YongShuiGuanLiDBI.DBNames.vDitchData.StationName,
                YongShuiGuanLiDBI.DBNames.vDitchData.DT,
                YongShuiGuanLiDBI.DBNames.vDitchData.WL1);

            this.GridView1.DataSource = tbl;
            this.GridView1.DataBind();
        }
        #endregion //QueryWL

        #region DataEnum
        /// <summary>
        /// 
        /// </summary>
        private DataEnum DataEnum
        {
            get
            {
                ChannelStationDTCondition c;
                bool b = GetChannelStationDTCondition(out c);
                if (b)
                {
                    return c.DataEnum;
                }
                else
                {
                    return DataEnumClass.GetDataEnumFromQueryString(
                        this.Request.QueryString, QueryStringNames.DataEnum);
                }
            }
        }
        #endregion //DataEnum

        #region ToSamePage
        /// <summary>
        /// 
        /// </summary>
        /// <param name="de"></param>
        private void ToSamePage(DataEnum de)
        {
            ChannelStationDTCondition c = new ChannelStationDTCondition();
            c.ChannelCollection = this.UCChannelStationDT1.SelectedChannelCollection;
            c.StationCollection = this.UCChannelStationDT1.SelectedStationCollection;
            c.Begin = this.UCChannelStationDT1.Begin;
            c.End = this.UCChannelStationDT1.End;
            c.DataEnum = de;

            Guid guid = Guid.NewGuid();
            string guidstring = guid.ToString();
            Session[guidstring] = c;

            string url = string.Format("pDataHistroy2.aspx?id={0}", guidstring);
            //string url = string.Format("pdefault.aspx?id={0}", guidstring);
            //Response.Redirect(url, false);
            WindowsHelper.OpenInNewWindows(this.Response, url);
        }
        #endregion //ToSamePage

        #region lbWL_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbWL_Click(object sender, EventArgs e)
        {
            ToSamePage(DataEnum.WL);
        }
        #endregion //lbWL_Click

        #region lbFlux_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbFlux_Click(object sender, EventArgs e)
        {
            ToSamePage(DataEnum.Flux);
        }
        #endregion //lbFlux_Click

        #region lbAmount_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbAmount_Click(object sender, EventArgs e)
        {
            ToSamePage(DataEnum.Amount);
        }
        #endregion //lbAmount_Click
    }
}

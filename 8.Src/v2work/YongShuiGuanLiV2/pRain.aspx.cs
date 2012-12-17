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

namespace YongShuiGuanLiV2
{
    public partial class pRain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string t = "雨情信息";
            MasterPageHelper.SetTitle(this, t);

            this.UCRain1.QueryEvent += new EventHandler(UCRain1_QueryEvent);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCRain1_QueryEvent(object sender, EventArgs e)
        {
            Query();
        }

        /// <summary>
        /// 
        /// </summary>
        private void Query()
        {
            int[] deviceIDs = this.UCRain1.SelectedStationCollection.GetDeviceCollection().GetDeviceIDs();
            if (deviceIDs.Length == 1)
            {

                RangeType rt = this.UCRain1.RangeType;
                DateTime begin = this.UCRain1.Begin;
                DateTime end = this.UCRain1.End;

                DataTable tbl = null;

                switch (rt)
                {
                    case RangeType.Real:
                        tbl = RainDBI.GetData(begin, end, deviceIDs);
                        break;

                    case RangeType.Day:
                    case RangeType.Month:
                    case RangeType.Year:
                        tbl = RainDBI.GetDayData(begin, end, deviceIDs);
                        break;

                }

                H.DataSource = tbl;
                H.Bind();
            }
            else
            {
                ClientScript.RegisterStartupScript (
                    this.GetType (), "key", 
                    JavaScriptHelper.GetAlertScript ("只能选择一个测点.")
                    );
            }
        }
        
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private GridViewConfig GetGridViewConfig()
        {

            GridViewConfig c = new GridViewConfig();

            c.GridViewColumnConfigCollection.AddBoundField(
                "名称", "Name");

            c.GridViewColumnConfigCollection.AddBoundField(
                "时间", "DT");

            c.GridViewColumnConfigCollection.AddBoundField(
                strings.RainFillWithUnit, "RainFill", GridViewColumnFormatString.FloatFormatString);

            return c;
        }
    }
}

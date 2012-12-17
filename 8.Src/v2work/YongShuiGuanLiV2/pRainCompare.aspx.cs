using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using YongShuiGuanLiDBI;
using Xdgk.UI;

namespace YongShuiGuanLiV2
{
    public partial class pRainCompare : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            MasterPageHelper.SetTitle(this, "雨情对比");
            this.UCRain1.RealRangeTypeVisbile = false;
            this.UCRain1.QueryEvent += new EventHandler(UCRain1_QueryEvent);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCRain1_QueryEvent(object sender, EventArgs e)
        {
            int[] deviceIDs = this.UCRain1.SelectedStationCollection.GetDeviceCollection().GetDeviceIDs();
            DateTime begin = this.UCRain1.Begin;
            DateTime end = this.UCRain1.End;

            DataTable tbl = RainDBI.GetSumData(deviceIDs , begin, end);
            DataTable r = new DataTable();
            r.Columns.Add("Name", typeof(string));
            r.Columns.Add("RainFill", typeof(float));

            foreach (StationClass s in this.UCRain1.SelectedStationCollection)
            {
                string name = s.StationName;
                double rainfill = FindRainFill(tbl, name);

                DataRow newRow = r.NewRow();
                newRow["Name"] = name;
                newRow["rainFill"] = rainfill;
                r.Rows.Add(newRow);
            }
            
            FixRainFillDot(r);
            this.UCAMChart1.SetColumnChartInfo(r, "Name", "RainFill", "", "LineName", GetTitle(), 
                strings.RainFillWithUnit, "F2");

            H.DataSource = r;
            H.Bind();

        }

        float FindRainFill(DataTable tbl, string name)
        {
            DataRow[] rows = tbl.Select("name = '" + name + "'");
            if (rows.Length > 0)
            {
                return Convert.ToSingle(rows[0]["RainFill"]);
            }
            else
            {
                return 0f;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tbl"></param>
        private void FixRainFillDot(DataTable tbl)
        {
            foreach ( DataRow row in tbl.Rows )
            {
                float value = Convert.ToSingle(row["RainFill"]);
                value =  (float)Math.Round(value, 2);
                row["RainFill"] = value;
            }
        }

        private string GetTitle()
        {
            // TODO:
            //
            string title = "";
            RangeType rt = this.UCRain1.RangeType;
            DateTime begin = this.UCRain1.Begin;
            switch (rt)
            {
                case  RangeType.Year :
                    title = string.Format("{0}年 雨量对比", begin.Year );
                    break;

                case RangeType.Month :
                    title = string.Format("{0}年{1}月 雨量对比", begin.Year, begin.Month  );
                    break;

                case RangeType.Day :
                    title = string.Format("{0} 雨量对比", begin.ToShortDateString());
                    break;
            }
            return title;
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
                strings.RainFillWithUnit, "RainFill", GridViewColumnFormatString.FloatFormatString);

            return c;
        }
    }
}

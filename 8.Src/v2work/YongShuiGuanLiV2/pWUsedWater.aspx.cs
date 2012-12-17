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
using Xdgk.UI;
using YongShuiGuanLiDBI;

namespace YongShuiGuanLiV2
{
    public partial class pWUsedWater : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UCWUsedWater11.QueryEvent += new EventHandler(UCWUsedWater11_QueryEvent);
            this.UCWUsedWater11.QueryEvent2 += new EventHandler(UCWUsedWater11_QueryEvent2);
            MasterPageHelper.SetTitle(this, "用水统计");
        }

        void UCWUsedWater11_QueryEvent(object sender, EventArgs e)
        {
            sUsedWater UserIDs = this.UCWUsedWater11.GetWaterUserIDS();
            DateTime begin = this.UCWUsedWater11.DuringBegin;
            DateTime end = this.UCWUsedWater11.DuringEnd;

            QueryData(UserIDs, begin, end);
        }
        void UCWUsedWater11_QueryEvent2(object sender, EventArgs e)
        {
            sUsedWater UserIDs = this.UCWUsedWater11.GetChannelIDS();
            DateTime begin = this.UCWUsedWater11.DuringBegin;
            DateTime end = this.UCWUsedWater11.DuringEnd;

            QueryData2(UserIDs, begin, end);
        }
        private double CountChannelAmount(int ChannelID, DateTime bg, DateTime ed)
        {
            int InDevices = ChannelDBI.GetInDeviceIds(ChannelID);
            int OutDevices = ChannelDBI.GetOutDeviceIds(ChannelID);
            double InData = 0;
            double OutData = 0;
            
            DataTable dtin = DitchDataDBI.GetData(bg, ed, InDevices);
            if (dtin.Rows.Count != 0)
                InData = InData + double.Parse(dtin.Rows[dtin.Rows.Count - 1]["UsedAmount"].ToString()) - double.Parse(dtin.Rows[0]["UsedAmount"].ToString());



            DataTable dtout = DitchDataDBI.GetData(bg, ed, OutDevices);
            if (dtout.Rows.Count != 0)
                OutData = OutData + double.Parse(dtout.Rows[dtout.Rows.Count - 1]["UsedAmount"].ToString()) - double.Parse(dtout.Rows[0]["UsedAmount"].ToString());
           

            return InData - OutData;
        }
        private double CountUsedAmount(int WaterUserID,DateTime bg,DateTime ed)
        {
            int[] InDevices = WaterUserInDBI.GetInDeviceIds(WaterUserID);
            int[] OutDevices = WaterUserOutDBI.GetOutDeviceIds(WaterUserID);
            double InData = 0;
            double OutData = 0;
            for (int i = 0; i < InDevices.Length; i++)
            {
                DataTable dtin = DitchDataDBI.GetData(bg, ed, InDevices[i]);
                if (dtin.Rows.Count != 0)
                    InData = InData + double.Parse(dtin.Rows[dtin.Rows.Count - 1]["UsedAmount"].ToString()) - double.Parse(dtin.Rows[0]["UsedAmount"].ToString());
            }

            for (int o = 0; o < OutDevices.Length; o++)
            {
                DataTable dtout = DitchDataDBI.GetData(bg, ed, OutDevices[o]);
                if (dtout.Rows.Count != 0)
                    OutData = OutData + double.Parse(dtout.Rows[dtout.Rows.Count - 1]["UsedAmount"].ToString()) - double.Parse(dtout.Rows[0]["UsedAmount"].ToString());
            }

            return InData - OutData;
        }
        private void QueryData2(sUsedWater UserIDS, DateTime begin, DateTime end)
        {
            DataTable resultTable = CreateResultDataTable();
            string[] UID = UserIDS.UID.Split(new char[] { '-' });
            string[] UName = UserIDS.UName.Split(new char[] { '-' });
            for (int i = 0; i < UID.Length; i++)
            {
                if (UID[i] != "")
                {
                    double Amount = CountChannelAmount(int.Parse(UID[i]), begin, end);
                    CreateAndAddRow(resultTable, UName[i], begin, end, (int)Amount);
                }
            }
            BindDataToChart(resultTable);
            BindDataToGridView(resultTable);
        }

        private void QueryData(sUsedWater UserIDS, DateTime begin, DateTime end)
        {
            DataTable resultTable = CreateResultDataTable();
            string[] UID = UserIDS.UID.Split(new char[]{'-'});
            string[] UName = UserIDS.UName.Split(new char[] { '-' });
            for (int i = 0; i < UID.Length; i++)
            {
                if (UID[i] != "")
                {
                    double Amount = CountUsedAmount(int.Parse(UID[i]),begin,end);
                    CreateAndAddRow(resultTable, UName[i], begin, end, (int)Amount);
                }
            }
            BindDataToChart(resultTable);
            BindDataToGridView(resultTable);
        }
        private void BindDataToChart(DataTable resultTable)
        {
            this.UCAMChart1.SetColumnChartInfo(resultTable, "StationName", "UsedAmount",
                "BeginDT", "line-name", GetColumnChartTitle(), "");
        }
        private string GetColumnChartTitle()
        {
            string s = string.Format(
                "{0}  用水量对比",
                GetDateTimePartOfTitle());
            return s;

        }
        private void BindDataToGridView(DataTable yeartable)
        {
            H.DataSource = yeartable;
            H.Bind();
        }
        private DataTable CreateResultDataTable()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("StationName", typeof(string));
            tbl.Columns.Add("BeginDT", typeof(DateTime));
            tbl.Columns.Add("EndDT", typeof(DateTime));
            tbl.Columns.Add("UsedAmount", typeof(int));

            return tbl;
        }

        private void CreateAndAddRow(DataTable source, string stationName, DateTime begin,
            DateTime end, int usedAmount)
        {
            DataRow row = source.NewRow();
            row["StationName"] = stationName;
            row["BeginDT"] = begin;
            row["EndDT"] = end;
            row["UsedAmount"] = usedAmount;

            source.Rows.Add(row);
        }
        private GridViewConfig GetGridViewConfig()
        {
            GridViewConfig c = new GridViewConfig();
            c.GridViewColumnConfigCollection.AddBoundField("名称" ,"StationName");
            c.GridViewColumnConfigCollection.AddBoundField("开始时间", "BeginDT");
            c.GridViewColumnConfigCollection.AddBoundField("结束时间", "EndDT");
            c.GridViewColumnConfigCollection.AddBoundField("用水量", "UsedAmount");
            return c;
        }

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
        }
        Xdgk.UI.GridViewHelper _h;
        private string GetDateTimePartOfTitle()
        {
            string r = string.Empty;
            r = string.Format("{0} ~ {1}",
                        this.UCWUsedWater11.DuringBegin,
                        this.UCWUsedWater11.DuringEnd);
            return r;
        }
    }

    public struct sUsedWater
    {
       public  string UID;
      public   string UName;
    }
}

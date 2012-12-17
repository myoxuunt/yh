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
using Xdgk.CF;

namespace YongShuiGuanLiV2
{
    public partial class pIFCalc : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            MasterPageHelper.SetTitle(this, "重新计算");
            this.UCCompareAmount1.QueryEvent += new EventHandler(UCCompareAmount1_QueryEvent);
            //this.UCCompareAmount1.
            if (!IsPostBack)
            {
                this.panelFormula.Visible = false;
                this.panelNoFormula.Visible = false;
            }
        }

        private bool Check()
        { 
            if (this.UCCompareAmount1.SelectedStationCollection.Count != 1)
            {
                string js = JavaScriptHelper.GetAlertScript("只能选择一个测点");
                this.ClientScript.RegisterStartupScript(this.GetType(), "key", js);
                return false;
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCCompareAmount1_QueryEvent(object sender, EventArgs e)
        {
            Query();
        }

        private void Query()
        {
            if (Check())
            {
                DataTable tbl = GetData();
                H.DataSource = tbl;
                H.Bind();

                H2.DataSource = this.DeviceFormulaCollectionMap.FormulaCollection;
                H2.Bind();

                if (this.DeviceFormulaCollectionMap.FormulaCollection.Count > 0)
                {
                    this.panelFormula.Visible = true;
                    this.panelNoFormula.Visible = false;
                }
                else
                {
                    this.panelFormula.Visible = false;
                    this.panelNoFormula.Visible = true;
                }
            }
        }

        private DataTable GetData()
        {
            DateTime begin = UCCompareAmount1.Begin;
            DateTime end = UCCompareAmount1.End;

            StationClass station = this.UCCompareAmount1.SelectedStationCollection[0];
            DataTable tbl = station.DeviceCollection[0].GetDitchData(begin, end);
            return tbl;
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
                    _h.GridViewConfig = GetGridViewConfig();
                }
                return _h;
            }
        } Xdgk.UI.GridViewHelper _h;
        #endregion //H

       #region H2
        /// <summary>
        ///
        /// 
        /// </summary>
        private Xdgk.UI.GridViewHelper H2
        {
            get
            {
                if (_h2 == null)
                {
                    _h2 = new Xdgk.UI.GridViewHelper(this.GridView2);
                    _h2.GridViewConfig = GetGridViewConfig2();
                }
                return _h2;
            }
        } Xdgk.UI.GridViewHelper _h2;
        #endregion //H2

        #region GetGridViewConfig
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private GridViewConfig GetGridViewConfig()
        {
            Xdgk.UI.GridViewConfig cfg = new Xdgk.UI.GridViewConfig();
            this.GridView1.Columns.Clear();
            cfg.AutoGenerateColumns = false;

            cfg.GridViewColumnConfigCollection.AddBoundField(strings.StationName,
                YongShuiGuanLiDBI.DBNames.vDitchData.StationName);

            cfg.GridViewColumnConfigCollection.AddBoundField(strings.DT, YongShuiGuanLiDBI.DBNames.vDitchData.DT);
            cfg.GridViewColumnConfigCollection.AddBoundField(strings.WLWithUnit , YongShuiGuanLiDBI.DBNames.vDitchData.WL1);
            cfg.GridViewColumnConfigCollection.AddBoundField(strings.InstantFluxWithUnit, YongShuiGuanLiDBI.DBNames.vDitchData.InstantFlux);
            return cfg;
        }
        #endregion //GetGridViewConfig

        #region GetGridViewConfig2
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private GridViewConfig GetGridViewConfig2()
        {
            Xdgk.UI.GridViewConfig cfg = new Xdgk.UI.GridViewConfig();
            this.GridView2.Columns.Clear();
            cfg.AutoGenerateColumns = false;

            cfg.GridViewColumnConfigCollection.AddBoundField("开始日期", "BeginString");
            cfg.GridViewColumnConfigCollection.AddBoundField("结束日期", "EndString");
            cfg.GridViewColumnConfigCollection.AddBoundField("计算公式", "FormulaExpress");
            return cfg;
        }
        #endregion //GetGridViewConfig2

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Calc_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                DataTable tbl = this.GetData();
                foreach (DataRow row in tbl.Rows)
                {
                    int dataID = Convert.ToInt32(row["ditchdataid"]);
                    DateTime dt = Convert.ToDateTime(row["dt"]);
                    int wl1 = Convert.ToInt32(row["wl1"]);
                    float flux = this.DeviceFormulaCollectionMap.FormulaCollection.CalcInstantFlux(dt, wl1, 0);

                    DitchDataDBI.Update(dataID, wl1, 0, flux);
                }

                Query();

                this.ClientScript.RegisterStartupScript(
                    this.GetType(),
                    "calcsuccess",
                    JavaScriptHelper.GetAlertScript("重新计算成功")
                    );
            }
        }

        
        #region DeviceFormulaCollectionMap
        private DeviceFormulaCollectionMap DeviceFormulaCollectionMap
        {
            get
            {
                if (_deviceFormulaCollectionMap == null)
                {
                    DeviceClass device = this.UCCompareAmount1.SelectedStationCollection[0].DeviceCollection[0];
                    _deviceFormulaCollectionMap = DeviceFormulaFactory.CreateDeviceFormulaCollectionMap(device.DeviceID);
                }
                return _deviceFormulaCollectionMap;
            }
        } private DeviceFormulaCollectionMap _deviceFormulaCollectionMap;
        #endregion //DeviceFormulaCollectionMap
    }
}

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
using Xdgk.CF;
using Xdgk.UI;

namespace YongShuiGuanLiV2
{
    public partial class pWLModify : System.Web.UI.Page
    {

        #region Members
        private int _queryDeviceID;
        private DateTime _queryDateTime;
        #endregion //

        #region Page_Load
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UCChannelStationDTOne1.IsSelectOneStation = true;
            MasterPageHelper.SetTitle(this, "水位修改");

            this.UCChannelStationDTOne1.QueryEvent += new EventHandler(UCChannelStationDTOne1_QueryEvent);

            if (!IsPostBack)
            {
                if (GetQueryParams())
                {
                    this.Device = DeviceFactory.CreateDevice(_queryDeviceID);
                    StationClass station = this.Device.StationClass;

                    this.UCChannelStationDTOne1.SelectedChannel = station.Channel;
                    this.UCChannelStationDTOne1.SelectedStation = station;

                    DateTime begin = _queryDateTime.Date;
                    DateTime end = begin.Add(TimeSpan.FromDays(1d));

                    QueryData(_queryDeviceID, begin, end);
                }
            }
            else
            {
                //this.Device = this.UCChannelStationDTOne1.SelectedStation.DeviceCollection[0];
            }
        }
        #endregion //Page_Load

        #region UCChannelStationDTOne1_QueryEvent
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCChannelStationDTOne1_QueryEvent(object sender, EventArgs e)
        {
            this.QueryData();
        }
        #endregion //UCChannelStationDTOne1_QueryEvent

        #region QueryData
        /// <summary>
        /// 
        /// </summary>
        private void QueryData()
        {
            StationCollection selectedStations = this.UCChannelStationDTOne1.SelectedStationCollection;

            if (selectedStations.Count > 0)
            {
                if (selectedStations.Count > 1)
                {
                    // TODO: selected count must == 1
                    //
                }
                else
                {
                    StationClass station = selectedStations[0];
                    int deviceID = station.DeviceCollection[0].DeviceID;
                    DateTime dt = this.UCChannelStationDTOne1.Begin;
                    DateTime begin = dt.Date;
                    DateTime end = begin.AddDays(1d);
                    QueryData(deviceID, begin, end);
                }
            }
        }
        #endregion //QueryData

        #region QueryData
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_queryDeviceID"></param>
        /// <param name="_queryDateTime"></param>
        private void QueryData(int deviceID, DateTime begin, DateTime end)
        {
            DataTable tbl = DitchDataDBI.GetWLFluxTable(begin, end, deviceID);
            //this.GridView1.DataSource = tbl;
            //this.GridView1.DataBind();
            H.DataSource = tbl;
            H.Bind();

            if (tbl.Rows.Count > 0)
            {
                this.btnModify.Visible = true;
                this.lblEditPassword.Visible = true;
                this.txtEditPassword.Visible = true;
            }
            else
            {
                this.btnModify.Visible = false;
                this.lblEditPassword.Visible = false;
                this.txtEditPassword.Visible = false;
            }
        }
        #endregion //QueryData

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

        #region GetGridViewConfig
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private GridViewConfig GetGridViewConfig()
        {
            GridViewConfig c = new GridViewConfig();
            c.AutoGenerateColumns = false;
            return c;
        }
        #endregion //GetGridViewConfig

        #region GetQueryParams
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool GetQueryParams()
        {
            object[] result = null;
            bool b = QueryStringParamPicker.Pick(this.Request.QueryString,
                new string[] { "DeviceID", "DT" },
                new Type[] { typeof(int), typeof(DateTime) },
                out result);

            if (b)
            {
                _queryDeviceID = (int)result[0];
                _queryDateTime = (DateTime)result[1];


            }
            return b;
        }
        #endregion //GetQueryParams


        private bool CheckNewWL()
        {
            bool result = true;

            //int DATE_COLUMN_INDEX = 1;
            int NEW_WL_COLUMN_INDEX = 4;

            int NEW_WL_VALUE_CONTROL_INDEX = 1;
            //return;
            foreach (GridViewRow row in this.GridView1.Rows)
            {
                int index = row.RowIndex;

                TextBox txtNewWL = (TextBox)row.Cells[NEW_WL_COLUMN_INDEX].Controls[NEW_WL_VALUE_CONTROL_INDEX];
                string newWL = txtNewWL.Text;
                if (newWL.Length > 0)
                {
                    int newWLValue = 0;
                    bool b = int.TryParse(newWL, out newWLValue);
                    if (!b)
                    {
                        txtNewWL.ForeColor = System.Drawing.Color.Red;
                        result = false;
                    }
                }
            }
            return result;
        }

        #region btnModify_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnModify_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                if (CheckNewWL())
                {
                    if (CheckEditPassword())
                    {
                        this.Device = this.UCChannelStationDTOne1.SelectedStation.DeviceCollection[0];

                        int DATE_COLUMN_INDEX = 1;
                        int NEW_WL_COLUMN_INDEX = 4;

                        int NEW_WL_VALUE_CONTROL_INDEX = 1;
                        //return;
                        foreach (GridViewRow row in this.GridView1.Rows)
                        {
                            int index = row.RowIndex;

                            TextBox txtNewWL = (TextBox)row.Cells[NEW_WL_COLUMN_INDEX].Controls[NEW_WL_VALUE_CONTROL_INDEX];
                            string newWL = txtNewWL.Text;
                            if (newWL.Length > 0)
                            {
                                int newWLValue = Convert.ToInt32(newWL);
                                int dataID = Convert.ToInt32(this.GridView1.DataKeys[index].Value);
                                DateTime dt = Convert.ToDateTime(row.Cells[DATE_COLUMN_INDEX].Text);
                                float instantFlux = CalcInstantFlux(dt, newWLValue);


                                DitchDataDBI.Update(dataID, newWLValue, 0, instantFlux);
                            }
                        }

                        // re query
                        //
                        QueryData();

                        this.ClientScript.RegisterStartupScript(
                            this.GetType(),
                            "modifysuccess",
                            JavaScriptHelper.GetAlertScript("数据修改成功")
                            );
                    }
                    else
                    {
                        // password error
                        ClientScript.RegisterStartupScript(this.GetType(), "passworderror", GetScript("修改密码错误"));
                    }
                }
                else
                {
                    // data error
                    ClientScript.RegisterStartupScript(this.GetType(), "dataerror", GetScript("数据错误"));
                }

            }
        }
        #endregion //btnModify_Click

        private string GetScript(string p)
        {
            string s = "<script type=\"text/javascript\"> alert('{0}'); </script>";
            s = string.Format(s, p);

            return s;
        }

        #region DeviceID
        /// <summary>
        /// 
        /// </summary>
        public int DeviceID
        {
            get
            {
                return _deviceID;
            }
            set
            {
                _deviceID = value;
            }
        } private int _deviceID;
        #endregion //DeviceID

        #region Device
        /// <summary>
        /// 
        /// </summary>
        public DeviceClass Device
        {
            get
            {
                return _device;
            }
            set
            {
                _device = value;
            }
        } private DeviceClass _device;
        #endregion //Device


        #region DeviceFormulaCollectionMap
        private DeviceFormulaCollectionMap DeviceFormulaCollectionMap
        {
            get
            {
                if (_deviceFormulaCollectionMap == null)
                {
                    _deviceFormulaCollectionMap = DeviceFormulaFactory.CreateDeviceFormulaCollectionMap(this.Device.DeviceID);
                }
                return _deviceFormulaCollectionMap;
            }
        } private DeviceFormulaCollectionMap _deviceFormulaCollectionMap;
        #endregion //DeviceFormulaCollectionMap

        #region CalcInstantFlux
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wl"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        private float CalcInstantFlux(DateTime dt, int wl)
        {
            return this.DeviceFormulaCollectionMap.FormulaCollection.CalcInstantFlux(dt, wl, 0);
        }
        #endregion //CalcInstantFlux

        #region UpdateData
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataID"></param>
        /// <param name="wl1"></param>
        /// <param name="instantFlux"></param>
        private void UpdateData(int dataID, int wl1, float instantFlux)
        {
            //TODO:
            //
            DitchDataDBI.Update(dataID, wl1, 0, instantFlux);
        }
        #endregion //UpdateData

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        protected void cvEditPassword_ServerValidate(object source, ServerValidateEventArgs args)
        {
            //bool r = false;
            //if (this.txtEditPassword.Text == SessionManager.LoginSession.User.EditPassword)
            //{
            //    r = true;
            //}
            //args.IsValid = r;
        }

        private bool CheckEditPassword()
        {
            bool r = false;
            if (this.txtEditPassword.Text == SessionManager.LoginSession.User.EditPassword)
            {
                r = true;
            }
            return r;

        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class DeviceFormulaFactory
    {
        static public DeviceFormulaCollectionMap CreateDeviceFormulaCollectionMap(int deviceID)
        {
            DeviceFormulaCollectionMap _deviceFormulaCollectionMap = new DeviceFormulaCollectionMap(deviceID);
            DataTable formulaDataTable = FormulaDBI.GetDataTable(deviceID);
            foreach (DataRow row in formulaDataTable.Rows)
            {
                DateTime begin = Convert.ToDateTime(row["DTBegin"]);
                DateTime end = Convert.ToDateTime(row["DTEnd"]);
                string formula = row["formula"].ToString();

                if (formula.Length > 0)
                {
                    Xdgk.CF.Formula item = new Xdgk.CF.Formula(deviceID,
                        begin, end, formula);

                    _deviceFormulaCollectionMap.FormulaCollection.Add(item);
                }
            }
            return _deviceFormulaCollectionMap;
        }
    }

}

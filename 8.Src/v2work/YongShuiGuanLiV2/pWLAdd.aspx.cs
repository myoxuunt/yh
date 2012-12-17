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
using Xdgk.UI;
using YongShuiGuanLiDBI;
using Xdgk.CF;

namespace YongShuiGuanLiV2
{
    public partial class pWLAdd : System.Web.UI.Page
    {

        #region Page_Load
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            MasterPageHelper.SetTitle(this, "水位增加");
            this.UCWLAdd1.IsSelectOneStation = true;
            this.UCWLAdd1.QueryEvent += new EventHandler(UCWLAdd1_QueryEvent);

            if (!IsPostBack)
            {
                //this.UCWLAdd1.IsSelectAllStation = false;
                this.panelOpera.Visible = false;
            }

        }
        #endregion //Page_Load

        #region UCWLAdd1_QueryEvent
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCWLAdd1_QueryEvent(object sender, EventArgs e)
        {
            DateTime dt = this.UCWLAdd1.Begin.Date;
            int interval = this.UCWLAdd1.RecordInterval;
            int baseWL = this.UCWLAdd1.BaseWL;

            string stationName = this.UCWLAdd1.SelectedStation.StationName;
            int deviceID = this.UCWLAdd1.SelectedStation.DeviceCollection[0].DeviceID;

            DataTable tbl = Generic(stationName, deviceID, dt, interval, baseWL);

            H.DataSource = tbl;
            H.Bind();

            //this.lblEditPassword.Visible = true;
            //this.txtEditPassword.Visible = true;
            //this.btnModify.Visible = true;
            this.panelOpera.Visible = true; 
        }
        #endregion //UCWLAdd1_QueryEvent

        #region Generic
        private DataTable Generic(string stationName, int deviceID, DateTime dt, int interval, int baseWL)
        {
            
            DataTable tbl = new DataTable();
            tbl.ExtendedProperties["deviceID"] = deviceID;
            tbl.Columns.Add("StationName", typeof(string));
            tbl.Columns.Add("DT", typeof(DateTime));
            tbl.Columns.Add("WL", typeof(int));

            TimeSpan ts = TimeSpan.FromMinutes(interval);

            DateTime rowdt = dt.Date;
            do
            {
                DataRow row = tbl.NewRow();
                row[0] = stationName;
                row[1] = rowdt;
                row[2] = baseWL;
                tbl.Rows.Add(row);
                rowdt += ts;
            } while (rowdt.Date == dt.Date);

            return tbl;
        }
        #endregion //Generic
       
        #region CheckInput 
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            bool result = true;

            foreach (GridViewRow row in this.GridView1.Rows)
            {
                int index = row.RowIndex;

                TextBox txtDT= (TextBox)row.Cells[1].Controls[1];
                DateTime dt;
                bool bDT = DateTime.TryParse(txtDT.Text, out dt);
                if (!bDT)
                {
                    result = false;
                    txtDT.ForeColor = System.Drawing.Color.Red;
                }

                TextBox txtNewWL = (TextBox)row.Cells[2].Controls[1];
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
        #endregion //CheckInput

        #region btnModify_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnModify_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                if (CheckEditPassword())
                {

                    this.Device = this.UCWLAdd1.SelectedStation.DeviceCollection[0];
                    int deviceID = this.UCWLAdd1.SelectedStation.DeviceCollection[0].DeviceID;

                    // delete history of the day
                    //
                    if (this.chkDeleteHistory.Checked)
                    {
                        DateTime dt = this.UCWLAdd1.Begin.Date;
                        DitchDataDBI.DeleteDay(deviceID, dt);
                    }

                    foreach (GridViewRow row in this.GridView1.Rows)
                    {
                        TextBox txtDT = row.Cells[1].Controls[1] as TextBox;
                        TextBox txtWL = row.Cells[2].Controls[1] as TextBox;

                        DateTime dt = Convert.ToDateTime(txtDT.Text);
                        int wl1 = Convert.ToInt32(txtWL.Text);

                        float flux = CalcInstantFlux(dt, wl1);
                        DitchDataDBI.Insert(deviceID, dt, wl1, 0, flux);
                    }

                    // alert success msg
                    //
                    string addSuccessMsg = "数据添加成功";
                    string js = JavaScriptHelper.GetAlertScript(addSuccessMsg);
                    this.ClientScript.RegisterStartupScript(
                        this.GetType(),
                        "addSuccess",
                        js );

                }
                else
                {
                    ClientScript.RegisterStartupScript(
                        this.GetType(), "passworderror",
                        JavaScriptHelper.GetAlertScript("修改密码错误"));
                }
            }
            else
            {
                string js = JavaScriptHelper.GetAlertScript("输入数据错误!");
                this.ClientScript.RegisterStartupScript(this.GetType(), "key", js);
            }
        }
        #endregion //btnModify_Click


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

        #region CheckEditPassword
        private bool CheckEditPassword()
        {
            return SessionManager.LoginSession.User.CheckEditPassword(this.txtEditPassword.Text);
        }
        #endregion //CheckEditPassword

        #region Device
        private DeviceClass Device
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
        /// <summary>
        /// 
        /// </summary>
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
    }
}

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
    public partial class pFormula : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDuringWater();
                if (IsEdit())
                {
                    Bind();
                }
                else
                {
                    this.txtStationName.Text = this.GetDevice().StationName;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void BindDuringWater()
        {
            DataTable dwtbl = DuringWaterDBI.GetDuringDataTable();
            NameIDPairCollection nameids = NameIDPairFactory.Create(dwtbl,
                YongShuiGuanLiDBI.DBNames.tblDuringWater.Name,
                YongShuiGuanLiDBI.DBNames.tblDuringWater.DuringWaterID);
            nameids.Insert(0, NameIDPair.ALL);

            this.ddlDuringWaterName.DataSource = nameids;
            this.ddlDuringWaterName.DataTextField = "Name";
            this.ddlDuringWaterName.DataValueField = "ID";
            this.ddlDuringWaterName.DataBind();
        }

        /// <summary>
        /// 
        /// </summary>
        private void Bind()
        {
            Formula f = FormulaFactory.Create(this.FormulaID);
            this.txtStationName.Text = f.Device.StationName;
            this.txtBegin.Text  = f.BeginString;
            this.txtEnd.Text = f.EndString;
            this.txtFormula.Text  = f.FormulaString;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOK_Click(object sender, EventArgs e)
        {
            //DeviceClass device = GetDevice();
            Formula f = GetFormula();
            f.BeginString = this.txtBegin.Text;
            f.EndString = this.txtEnd.Text;
            f.FormulaString = this.txtFormula.Text;
            f.Save();

            RedirectToProjectPage();
        }

        /// <summary>
        /// 
        /// </summary>
        private void RedirectToProjectPage()
        {
            Response.Redirect("pProject.aspx");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Formula GetFormula()
        {
            Formula f = null;
            if (IsEdit())
            {
                f = FormulaFactory.Create(this.FormulaID);
            }
            else
            {
                f = new Formula();
                f.Device = GetDevice();
            }
            return f;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private DeviceClass GetDevice()
        {
            if (IsAdd())
            {
                int deviceid = GetDeviceID();
                return DeviceFactory.CreateDevice(deviceid);
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private int GetDeviceID()
        {
            return QueryStringParamPicker.PickInt32Param(this.Request.QueryString,
                QueryStringNames.DeviceDI,
                0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            RedirectToProjectPage();
        }

        /// <summary>
        /// 
        /// </summary>
        public int FormulaID
        {
            get 
            {
                int formulaID = QueryStringParamPicker.PickInt32Param(
                    this.Request.QueryString,
                    QueryStringNames.FormulaID, 
                    0);

                return formulaID; 
            }
        }
        //  set { _formulaID = value; }
        // }
        // private int _formulaID;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsAdd()
        {
            return FormulaID == 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsEdit()
        {
            return FormulaID > 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ddlDuringWaterName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sel = this.ddlDuringWaterName.SelectedValue;
            int dwid = int.Parse(sel);

            if (dwid != 0)
            {
                DuringWaterClass dw = DuringWaterFactory.CreateDuringWater(dwid);
                this.txtBegin.Text = dw.BeginString;
                this.txtEnd.Text = dw.EndString;
            }
            else
            {
                this.txtBegin.Text = "01-01";
                this.txtEnd.Text = "12-31";
            }
        }
    }
}

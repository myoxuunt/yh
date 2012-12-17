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
using Xdgk.UI;

namespace YongShuiGuanLiV2.UC
{
    public partial class UCStation : System.Web.UI.UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        public void Bind(StationClass s)
        {
            this.txtStationName.Text = s.StationName;
            this.txtDeviceType.Text = s.DeviceCollection[0].DeviceType;

            DeviceClass device = s.DeviceCollection[0];
            BindAlarm(device);
            //AddTestFormula(device);
            BindFormula(device);
            SaveDeviceID(device.DeviceID);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="device"></param>
        private void BindAlarm(DeviceClass device)
        {
            if (device.DeviceAlarm != null)
            {
                if (device.DeviceAlarm.HasHighLimit)
                {
                    this.txtAlarmHighLimit.Text = device.DeviceAlarm.HighLimit.ToString();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void SaveDeviceID(int deviceID)
        {
            this.HiddenField1.Value = deviceID.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        private int LoadDeviceID()
        {
            return int.Parse(this.HiddenField1.Value);
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="d"></param>
        //private void AddTestFormula(DeviceClass d)
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Formula f = new Formula();
        //        f.Begin = DateTime.Now;
        //        f.End = DateTime.Now;
        //        f.FormulaString = "1+1+2-4";
        //        d.FormulaCollection.Add(f);
        //    }
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="device"></param>
        private void BindFormula(DeviceClass device)
        {
            H.DataSource = device.FormulaCollection;
            H.Bind();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOK_Click(object sender, EventArgs e)
        {

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
                    _h = new Xdgk.UI.GridViewHelper(this.gvFormula);
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
            c.Width = 400;

            c.GridViewColumnConfigCollection.AddEditDeleteCommandField("");
            c.GridViewColumnConfigCollection.AddBoundField("开始时间",
                "BeginString");
            c.GridViewColumnConfigCollection.AddBoundField("结束时间",
                "EndString");
            c.GridViewColumnConfigCollection.AddBoundField("流量公式",
                "FormulaString");

            return c;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnNewFormula_Click(object sender, EventArgs e)
        {
            string s = string.Format (
                "pFormula.aspx?DeviceID={0}",
                LoadDeviceID());

            Response.Redirect(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvFormula_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = e.RowIndex;
            int formulaID = int.Parse(this.gvFormula.DataKeys[index].Value.ToString ());
            FormulaDBI.Delete(formulaID);
            RedirectToProjectPage();
        }

        /// <summary>
        /// 
        /// </summary>
        private void RedirectToProjectPage()
        {
            string s = "pProject.aspx";
            Response.Redirect(s);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvFormula_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int formulaID = GetEditFormulaID(e.NewEditIndex);
            string s = string.Format(
                "pFormula.aspx?FormulaID={0}",
                formulaID);

            Response.Redirect(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private int GetEditFormulaID(int index)
        {
            int id = int.Parse(this.gvFormula.DataKeys[index].Value.ToString());
            return id;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnModifyAlarm_Click(object sender, EventArgs e)
        {
            int r;
            if (int.TryParse(this.txtAlarmHighLimit.Text, out r))
            {
                int highLimit = r;
                DeviceAlarmDBI.Save(LoadDeviceID(),
                    highLimit);
            }
            else
            {
                
            }
        }
    }
}
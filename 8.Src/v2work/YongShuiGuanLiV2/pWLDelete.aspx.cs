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
    public partial class pWLDelete : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UCChannelStationDTOne1.IsSelectOneStation = true;
            this.UCChannelStationDTOne1.IsSelectAllStation = false;

            MasterPageHelper.SetTitle(this, "水位删除");

            this.UCChannelStationDTOne1.QueryEvent += new EventHandler(UCChannelStationDTOne1_QueryEvent);

            if (!IsPostBack)
            {
                this.panelOpera.Visible = false;
            }
        }

        void UCChannelStationDTOne1_QueryEvent(object sender, EventArgs e)
        {
            QueryData();
        }

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


        #region QueryData
        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceID"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        private void QueryData(int deviceID, DateTime begin, DateTime end)
        {
            DataTable tbl = DitchDataDBI.GetWLFluxTable(begin, end, deviceID);
            // AddDeletedColumn
            //
            AddDeletedColumn(tbl);

            H.DataSource = tbl;
            H.Bind();

            bool b = tbl.Rows.Count > 0;
            this.panelOpera.Visible = b ;
        }
        #endregion //QueryData

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tbl"></param>
        private void AddDeletedColumn(DataTable tbl)
        {
            tbl.Columns.Add("Deleted", typeof(bool));
            foreach (DataRow row in tbl.Rows)
            {
                row["deleted"] = true;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnModify_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                // check password 
                //
                if (CheckEditPassword())
                {
                    foreach (GridViewRow row in this.GridView1.Rows)
                    {
                        int dataID;
                        bool deleted;
                        GetDataIDAndDeleted(row, out dataID, out deleted);

                        if (deleted)
                        {
                            DitchDataDBI.Delete(dataID);
                        }
                    }

                    this.ClientScript.RegisterStartupScript (
                        this.GetType (),
                        "deletsuccess",
                        JavaScriptHelper.GetAlertScript ("数据删除成功")
                        );
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "passworderror", GetScript("修改密码错误"));
                }
            }
        }

        private string GetScript(string p)
        {
            string s = "<script type=\"text/javascript\"> alert('{0}'); </script>";
            s = string.Format(s, p);

            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <param name="dataID"></param>
        /// <param name="deleted"></param>
        private void GetDataIDAndDeleted(GridViewRow row, out int dataID, out bool deleted)
        {
            dataID = 0;
            deleted = false;

            int DELETED_IDX = 4;
            CheckBox chk = row.Cells[DELETED_IDX].Controls[1] as CheckBox;
            deleted = chk.Checked;
            dataID = Convert.ToInt32(this.GridView1.DataKeys[row.RowIndex].Value);
        }

        private bool CheckEditPassword()
        {
            return SessionManager.LoginSession.User.CheckEditPassword(this.txtEditPassword.Text);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        protected void cvEditPassword_ServerValidate(object source, ServerValidateEventArgs args)
        {
            // TODO: check password
        }
    }
}

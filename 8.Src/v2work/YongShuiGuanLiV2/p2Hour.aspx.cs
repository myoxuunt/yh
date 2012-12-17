using System;
using System.IO;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using WebChart;
using Xdgk.UI;
using YongShuiGuanLiDBI;

namespace YongShuiGuanLiV2
{
    /// <summary>
    /// 
    /// </summary>
    public partial class p2Hour : System.Web.UI.Page
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            string t = string.Empty;
            switch (this.DataEnum)
            {
                case DataEnum.WL :
                    t = Titles.WL2Hour;
                    break;
                case DataEnum.Flux :
                    t = Titles.Flux2Hour;
                    break;
            }
            MasterPageHelper.SetTitle(this, t);
            this.UCConditionDTOne1.QueryEvent += new EventHandler(UCConditionDTOne1_QueryEvent);

            if (!IsPostBack)
            {
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCConditionDTOne1_QueryEvent(object sender, EventArgs e)
        {
            Query();
        }


        /// <summary>
        /// 
        /// </summary>
        private void Query()
        {
            if (IsValid)
            {
                DateTime dt = this.UCConditionDTOne1.Date.Date;
                WaterUserClass w = this.UCConditionDTOne1.WaterUser;
                DataTable tbl = w.GetDitchDataDayDataTable(dt);
                //this.GridView1.DataSource = tbl;
                //this.GridView1.DataBind();
                this.lblGridViewCaption.Text = GetGridViewCaption();
                H.DataSource = tbl;
                H.Bind();
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

        #region GetGridViewConfig
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private GridViewConfig GetGridViewConfig()
        {
            GridViewConfig c = new GridViewConfig();
            c.AutoGenerateColumns = true;            
            return c;
        }
        #endregion //GetGridViewConfig

        /// <summary>
        /// 
        /// </summary>
        private DataEnum DataEnum
        {
            get
            { 
                return DataEnumClass.GetDataEnumFromQueryString(this.Request.QueryString, 
                    QueryStringNames.DataEnum);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string GetGridViewCaption()
        {
            string f = string.Empty;
            switch (this.DataEnum)
            {
                case DataEnum.WL :
                    f = "{0} {1} 日水位";
                    break;

                case DataEnum.Flux :
                    f = "{0} {1} 日流量";
                    break;
            }

            string s = string.Format(
                f, 
                this.UCConditionDTOne1.Date.Date,
                this.UCConditionDTOne1.WaterUser.ChannelCollection[0].ChannelName);
            return s;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                DateTime dt = this.UCConditionDTOne1.Date.Date;
                WaterUserClass w = this.UCConditionDTOne1.WaterUser;
                DataTable tbl = w.GetDitchDataDayDataTable(dt);
                string filename = "Export/" + Path.GetRandomFileName() + ".csv";
                CSVExporter.Export(this, tbl, this.lblGridViewCaption.Text, filename);
            }
        }
    }
}

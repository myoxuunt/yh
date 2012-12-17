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

namespace YongShuiGuanLiV2.UC
{
    public partial class UCChart : System.Web.UI.UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            //this.OpenFlashChartControl1 = new OpenFlashChart.OpenFlashChartControl();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Bind()
        {
            ExternalSWFBinder.Bind(this.OpenFlashChartControl1);
            string dataPageName = PageNames.ChartCommData;
            this.OpenFlashChartControl1.DataFile = dataPageName;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageName"></param>
        public void Bind(string pageName)
        {
            ExternalSWFBinder.Bind(this.OpenFlashChartControl1);
            this.OpenFlashChartControl1.DataFile = pageName;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Hide()
        {
            this.Panel1.Visible = false;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Show()
        {
            this.Panel1.Visible = true;
        }
    }
}
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
    public partial class UCDanRi : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime Day
        {
            get
            {
                return Convert.ToDateTime(this.txtDay.Text);
            }
            set
            {
                this.txtDay.Text = value.ToShortDateString();
            }
        }
        public void AjaxStartupScript(UpdatePanel control)
        {
            ScriptManager.RegisterClientScriptBlock(
                control,
                this.GetType(),
                "key",
                GetScript(),
                true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string GetScript()
        {
            string s1 = string.Format(
                "setup_calender('{0}', '{1}');",
                this.btnDay.ClientID,
                this.txtDay.ClientID
                );

            return s1;

        }
    }
}
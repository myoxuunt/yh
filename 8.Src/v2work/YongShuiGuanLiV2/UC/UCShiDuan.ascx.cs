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
    public partial class UCShiDuan : System.Web.UI.UserControl
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
        public DateTime DuringBegin
        {
            get
            {
                return Convert.ToDateTime(this.txtBegin.Text);
            }
            set
            {
                this.txtBegin.Text = value.ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime DuringEnd
        {
            get
            {
                return Convert.ToDateTime(this.txtEnd.Text);
            }
            set
            {
                this.txtEnd.Text = value.ToString();
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
                "setup_calender_with_datetime('{0}', '{1}');",
                this.btnBegin.ClientID,
                this.txtBegin.ClientID
                );

            string s2 = string.Format(
                "setup_calender_with_datetime('{0}', '{1}');",
                this.btnEnd.ClientID,
                this.txtEnd.ClientID
                );

            return s1 + s2;

        }
    }
}
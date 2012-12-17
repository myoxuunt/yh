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
    /// <summary>
    /// 
    /// </summary>
    public partial class UCDTTwoOnly : System.Web.UI.UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        public event EventHandler QueryEvent;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Init(object sender, EventArgs e)
        {
            YongShuiGuanLiLib.ValidatorMessageCreater.CreateSQLDateTimeMessage(
                this.cvBegin);
            YongShuiGuanLiLib.ValidatorMessageCreater.CreateSQLDateTimeMessage(
                this.cvEnd);
            
            this.txtBegin.Text = new DateTime(DateTime.Now.Year, 1, 1).ToString();
            this.txtEnd.Text = new DateTime(DateTime.Now.Year + 1, 1, 1).ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        protected void cvBegin_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = SQLDateTimeValidator.VerifyDateTime(this.txtBegin.Text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        protected void cvEnd_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = SQLDateTimeValidator.VerifyDateTime(this.txtEnd.Text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnQuery_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                if (QueryEvent != null)
                {
                    QueryEvent(this, EventArgs.Empty);
                }
            }
        }


        #region Begin
        /// <summary>
        /// 
        /// </summary>
        public DateTime Begin
        {
            get { return DateTime.Parse (this.txtBegin.Text );}
            set { this.txtBegin.Text = value.ToString(); }
        }
        #endregion //Begin


        #region End
        /// <summary>
        /// 
        /// </summary>
        public DateTime End
        {
            get { return DateTime.Parse (this.txtEnd.Text );}
            set
            {
                this.txtEnd.Text = value.ToString();
            }
        }
        #endregion //End
    }
}
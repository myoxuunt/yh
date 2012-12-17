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
    public partial class pNeedWaterItem : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            MasterPageHelper.SetTitle(this, Titles.NeedWaterNew);
            YongShuiGuanLiLib.ValidatorMessageCreater.CreateSQLDateTimeMessage(this.cvBegin);
            YongShuiGuanLiLib.ValidatorMessageCreater.CreateSQLDateTimeMessage(this.cvEnd);

            if (!IsPostBack)
            {
                int id = this.NeedWaterID;
                if (id != 0)
                {
                    NeedWaterClass need = NeedWaterClass.CreateByID(id);
                    this.txtBegin.Text = need.Begin.ToString();
                    this.txtEnd.Text = need.End.ToString();
                    this.txtUsedAmount.Text = need.NeedAmount.ToString();
                    this.txtRemark.Text = need.Reamrk;
                    this.txtWaterUser.Text = need.WaterUserClass.Name;

                    MasterPageHelper.SetTitle(this, Titles.NeedWaterEdit);
                }
                else
                {
                    WaterUserClass u = SessionManager.LoginSession.WaterUser ;
                    if (u != null)
                    {
                        this.txtWaterUser.Text = u.Name;
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private int NeedWaterID
        {
            get
            {
                string s = Request.QueryString["NeedWaterID"] ;
                if (!string.IsNullOrEmpty(s))
                {
                    return Convert.ToInt32(s);
                }
                else
                {
                    return 0;
                }
            }
        } 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                //string wuName = this.txtWaterUser.Text;
                //WaterUserClass wu = WaterUserFactory.CreateWaterUserByID 
                WaterUserClass wu = SessionManager.LoginSession.WaterUser;
                if (wu != null)
                {
                    int waterUserID = wu.WaterUserID;

                    NeedWaterClass n = new NeedWaterClass();
                    n.NeedWaterID = this.NeedWaterID;
                    n.Begin = Convert.ToDateTime(this.txtBegin.Text);
                    n.End = Convert.ToDateTime(this.txtEnd.Text);
                    n.NeedAmount = Convert.ToInt32(this.txtUsedAmount.Text);
                    n.Reamrk = this.txtRemark.Text.Trim();

                    n.Save(waterUserID);

                    Response.Redirect("pNeedWaterList.aspx");
                }
            }
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
        /// <param name="source"></param>
        /// <param name="args"></param>
        protected void cvUsedAmount_ServerValidate(object source, ServerValidateEventArgs args)
        {
            int r;
            bool b = int.TryParse ( this.txtUsedAmount .Text , out r);
            args.IsValid = b;
        }
    }
}

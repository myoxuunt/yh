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
using YongShuiGuanLiDBI ;

namespace YongShuiGuanLiV2
{
    public partial class pDistributeItem : System.Web.UI.Page
    {


        #region Page_Load
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            MasterPageHelper.SetTitle(this, Titles.DistributeItemNew);
            if (!IsPostBack)
            {
                YongShuiGuanLiLib.ValidatorMessageCreater.CreateSQLDateTimeMessage(this.cvBegin);
                YongShuiGuanLiLib.ValidatorMessageCreater.CreateSQLDateTimeMessage(this.cvEnd);

                DistributeClass d = this.DistributeClass;
                this.txtWaterUser.Text = d.NeedWaterClass.WaterUserClass.Name;
                this.txtNeedBegin.Text = d.NeedWaterClass.Begin.ToString();
                this.txtNeedEnd.Text = d.NeedWaterClass.End.ToString();
                this.txtNeedRemark.Text = d.NeedWaterClass.Reamrk.ToString();
                this.txtNeedAmount.Text = d.NeedWaterClass.NeedAmount.ToString();

                if (!d.IsNew())
                {
                    this.txtDistributeAmount.Text = d.DistributeAmount.ToString();
                    this.txtDistributeBegin.Text = d.Begin.ToString();
                    this.txtDistributeEnd.Text = d.End.ToString();
                    this.txtDistributeRemark.Text = d.Remark;

                    MasterPageHelper.SetTitle(this, Titles.DistributeItemEdit);
                }
            }
        }
        #endregion //Page_Load


        #region btnOK_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                DistributeClass d = this.DistributeClass;
                d.Begin = Convert.ToDateTime(this.txtDistributeBegin.Text);
                d.End = Convert.ToDateTime(this.txtDistributeEnd.Text);
                d.DistributeAmount = Convert.ToInt32(this.txtDistributeAmount.Text);
                d.Remark = this.txtDistributeRemark.Text;
                d.Save();
                Response.Redirect("pDistributeList.aspx");
            }
        }
        #endregion //btnOK_Click


        #region DistributeClass
        /// <summary>
        /// 
        /// </summary>
        private DistributeClass DistributeClass
        {
            get
            {
                int id = GetDistributeWaterID();
                if (id == 0)
                {
                    id = GetNeedWaterID();
                    if (id == 0)
                    {
                        throw new InvalidOperationException("querystring must include needWaterid or distributeWaterID");
                    }
                    else
                    {
                        NeedWaterClass need = NeedWaterClass.CreateByID(id);
                        _d = DistributeClass.CreateByNeedWater(need);
                    }
                }
                else
                {
                    _d = DistributeClass.CreateByID(id);
                }

                return _d;
            }
        } private DistributeClass _d;
        #endregion //DistributeClass


        #region GetNeedWaterID
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private int GetNeedWaterID()
        {
            return QueryStringParamPicker.PickInt32Param(Request.QueryString, "NeedWaterID", 0);
        }
        #endregion //GetNeedWaterID


        #region GetDistributeWaterID
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private int GetDistributeWaterID()
        {
            return QueryStringParamPicker.PickInt32Param(Request.QueryString, "DistributeWaterID", 0);
        }
        #endregion //GetDistributeWaterID


        #region cvBegin_ServerValidate
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        protected void cvBegin_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = SQLDateTimeValidator.VerifyDateTime(this.txtDistributeBegin.Text);
        }
        #endregion //cvBegin_ServerValidate


        #region cvEnd_ServerValidate
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        protected void cvEnd_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = SQLDateTimeValidator.VerifyDateTime(this.txtDistributeEnd.Text);
        }
        #endregion //cvEnd_ServerValidate

        

        #region cvDistributeAmount_ServerValidate
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        protected void cvDistributeAmount_ServerValidate(object source, ServerValidateEventArgs args)
        {
            int r ;
            bool b = int.TryParse(this.txtDistributeAmount.Text, out r);
            args.IsValid = b;
        }
        #endregion //cvDistributeAmount_ServerValidate
    }
}

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
    public partial class pFeeItem : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            string t = null;
            if (this.IsInsert())
            {
                t = "水费计收";
            }
            else
            {
                t = "水费修改";
            }
            MasterPageHelper.SetTitle(this, t);

            if (!IsPostBack)
            {
                YongShuiGuanLiLib.ValidatorMessageCreater.CreateSQLDateTimeMessage(
                    this.cvBegin);
                YongShuiGuanLiLib.ValidatorMessageCreater.CreateSQLDateTimeMessage(
                    this.cvEnd);

                this.cvName.Text = "*";
                this.cvName.ErrorMessage = "收费名称不能为空";

                this.cvUnitPrice.Text = "*";
                this.cvUnitPrice.ErrorMessage = "无效的数字";

                this.cvTotalPrice.Text = "*";
                this.cvTotalPrice.ErrorMessage = "无效的数字";

                this.cvUsedTotal.Text = "*";
                this.cvUsedTotal.ErrorMessage = "无效的数字";

                // wateruser bind
                //
                WaterUserClass wu = SessionManager.LoginSession.WaterUser;
                if (wu != null)
                {
                    WaterUserDataBinder.DataBind(wu, this.ddlWaterUser);
                }

                if (this.IsUpdate())
                {
                    DataTable tbl = FeeDBI.GetFeeDataTableWithFeeID(this.EditID);
                    if (tbl.Rows.Count > 0)
                    {
                        FillFeeInfo(tbl.Rows[0]);
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataRow"></param>
        private void FillFeeInfo(DataRow dataRow)
        {
            this.WaterUserID = Convert.ToInt32(dataRow["WaterUserID"]);
            this.FeeName = dataRow["FeeName"].ToString();
            this.Begin = Convert.ToDateTime(dataRow["BeginDT"]);
            this.End = Convert.ToDateTime(dataRow["EndDT"]);

            //int tianshu = 0;
            //TimeSpan ts =  this.End - this.Begin;
            //tianshu = Convert.ToInt32(ts.TotalDays);

            this.TianShu = Convert.ToInt32(dataRow["NumberOfDay"]);
            this.UnitPrice = Convert.ToDouble(dataRow["UnitPrice"]);

            this.WaterAmount = Convert.ToDouble(dataRow["waterAmount"]);
            this.WaterLost = Convert.ToDouble(dataRow["waterLost"]);
            this.UsedAmount = Convert.ToDouble (dataRow["usedWater"]);

            this.UsedPrice = Convert.ToDouble(dataRow["UsedPrice"]);
            this.PayPrice = Convert.ToDouble (dataRow["PayPrice"]);
            this.LeftPrice = Convert.ToDouble(dataRow["LeftPrice"]);
            this.Remark = dataRow["Remark"].ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (this.IsValid)
            {
                if (IsInsert())
                {
                    Insert();
                }
                else
                {
                    Update();
                }
                Response.Redirect("pFeeHistory.aspx");
            }
        }
       
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsUpdate()
        {
            return !IsInsert();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsInsert()
        {
            return this.EditID == 0;
        }

        /// <summary>
        /// 
        /// </summary>
        private void Insert()
        {
            FeeDBI.InsertFee(
                this.WaterUserID,
                this.FeeName,
                this.Begin, 
                this.End, 
                this.TianShu ,
                this.UnitPrice,
                this.WaterAmount,
                this.WaterLost ,
                this.UsedAmount,
                this.UsedPrice,
                this.PayPrice, 
                this.LeftPrice ,
                this.Remark );
                
        }

        /// <summary>
        /// 
        /// </summary>
        private void Update()
        {
            FeeDBI.UpdateFee (
                this.EditID ,
                this.WaterUserID,
                this.FeeName,
                this.Begin, 
                this.End, 
                this.TianShu ,
                this.UnitPrice,
                this.WaterAmount,
                this.WaterLost ,
                this.UsedAmount,
                this.UsedPrice,
                this.PayPrice, 
                this.LeftPrice ,
                this.Remark );
        }

        /// <summary>
        /// 
        /// </summary>
        public int EditID
        {
            get
            {
                return QueryStringParamPicker.PickInt32Param(this.Request.QueryString, "FeeID", 0);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public WaterUserClass SelectedWaterUser
        {
            get
            {
                int waterUserID = this.WaterUserID;
                WaterUserClass wu = WaterUserFactory.CreateWaterUserByID(waterUserID);
                return wu;
            }
        } 

        #region WaterUserID
        /// <summary>
        /// 
        /// </summary>
        public int WaterUserID
        {
            get
            {
                ListItem li = this.ddlWaterUser.SelectedItem;
                return Convert.ToInt32(li.Value);
            }
            set
            {
                foreach (ListItem li in this.ddlWaterUser.Items)
                {
                    int id = Convert.ToInt32(li.Value);
                    if (id == value)
                    {
                        li.Selected = true;
                    }
                }
            }
        } 
        #endregion //WaterUserID

        #region FeeName
        /// <summary>
        /// 
        /// </summary>
        public string FeeName
        {
            get
            {
                return this.txtFeeName.Text.Trim();
            }
            set
            {
                if (value == null)
                    value = string.Empty;
                
                this.txtFeeName.Text = value.Trim();
            }
        } 
        #endregion //FeeName

        #region Begin
        /// <summary>
        /// 
        /// </summary>
        public DateTime Begin
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
        #endregion //Begin

        #region TianShu
        /// <summary>
        /// 
        /// </summary>
        public int TianShu
        {
            get 
            {
                int r = 1;
                if (int.TryParse(this.txtTianShu.Text, out r))
                {

                    return r;
                }
                else
                {
                    return 1;
                }
            }
            set 
            {
                this.txtTianShu.Text = value.ToString();
            }
        }
        #endregion //TianShu

        #region End
        /// <summary>
        /// 
        /// </summary>
        public DateTime End
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
        #endregion //End

        #region UnitPrice
        /// <summary>
        /// 
        /// </summary>
        public double UnitPrice
        {
            get
            {
                return Convert.ToDouble(this.txtUnitPrice.Text);
            }
            set
            {
                this.txtUnitPrice.Text = value.ToString("F2");
            }
        } 
        #endregion //UnitPrice

        #region 
        /// <summary>
        /// 
        /// </summary>
        public double UsedPrice
        {
            get
            {
                return Convert.ToDouble(txtUsedPrice.Text);
            }
            set
            {
                this.txtUsedPrice.Text = value.ToString("F2");
            }
        }
        #endregion //TotalPrice

        #region PayPrice
        /// <summary>
        /// 
        /// </summary>
        public double PayPrice
        {
            get
            {
                return Convert.ToDouble(txtPayPrice.Text);
            }
            set
            {
                txtPayPrice.Text = value.ToString("F2");
            }
        }
        #endregion 

        #region leftPrice
        /// <summary>
        /// 
        /// </summary>
        public double LeftPrice
        {
            get
            {
                return Convert.ToDouble(txtLeftPrice.Text);
            }
            set
            {
                txtLeftPrice.Text = value.ToString("F2");
            }
        }
        #endregion 

        public double WaterLost
        {
            get
            {
                return double.Parse ( txtWaterLost.Text );
            }
            set 
            {
                txtWaterLost.Text = value.ToString("f2");
        }
        }
        public double WaterAmount
        {
            get
            {
                return double.Parse(txtWaterAmount.Text);
            }
            set
            {
                txtWaterAmount.Text = value.ToString("F2");
            }
        }
        #region UsedAmount
        /// <summary>
        /// 
        /// </summary>
        public double UsedAmount
        {
            get
            {
                return Convert.ToDouble(txtUsedAmount.Text);
            }
            set
            {
                this.txtUsedAmount.Text = value.ToString("F2");
            }
        } 
        #endregion //UsedAmount

        #region PayAmount
        /// <summary>
        /// 
        /// </summary>
        public double PayAmount
        {
            get
            {
                return Convert.ToDouble(txtUsedAmount.Text);
            }
            set
            {
                this.txtUsedAmount.Text = value.ToString("F2");
            }
        }
        #endregion //UsedAmount

        #region Remark
        /// <summary>
        /// 
        /// </summary>
        public string Remark
        {
            get
            {
                return txtRemark.Text;
            }
            set
            {
                txtRemark.Text = value;
            }
        } 
        #endregion //Remark

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        protected void cvBegin_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = SQLDateTimeValidator.VerifyDateTime(this.txtBegin.Text );
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

        protected void cvName_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = this.txtFeeName.Text.Trim().Length > 0;
        }

        protected void cvUnitPrice_ServerValidate(object source, ServerValidateEventArgs args)
        {
            double r;
            args.IsValid = double.TryParse(this.txtUnitPrice.Text, out r);
        }

        protected void cvTotalPrice_ServerValidate(object source, ServerValidateEventArgs args)
        {
            //double r;
            //args.IsValid = double.TryParse(this.txtTotalPrice.Text, out r);
        }

        protected void cvUsedTotal_ServerValidate(object source, ServerValidateEventArgs args)
        {
            double r;
            args.IsValid = double.TryParse(this.txtUsedAmount.Text, out r);
        }


        /// <summary>
        /// calc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDays_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                txtTianShu.Text = CountDay();
                double waterAmount = CountWaterAmount();
                double waterLost = double.Parse(txtWaterLost.Text);
                double usedWater = waterAmount - waterLost;
                double usedPrice = ToOne(usedWater) * double.Parse(txtUnitPrice.Text);


                //waterAmount = ToTenThousand(waterAmount);
                //usedWater = ToTenThousand(usedWater);

                txtWaterAmount.Text = waterAmount.ToString("F2");
                txtUsedAmount.Text = usedWater.ToString("F2");
                txtUsedPrice.Text = usedPrice.ToString("F2");

                //double UsedP=double.Parse(txtUnitPrice.Text)*waterAmount;
                //txtTotalPrice.Text = UsedP.ToString();
            }
        }

        private string CountDay()
        {
            this.Begin = Convert.ToDateTime(this.txtBegin.Text);
            this.End = Convert.ToDateTime(txtEnd.Text);
            TimeSpan ts = End - Begin;
            return ts.Days.ToString();
        }

        
        private double CountWaterAmount()
        {
            WaterUserClass wu = SelectedWaterUser;
            double usedAmount = wu.CalcUsedAmount(this.Begin, this.End);
            usedAmount = ToTenThousand(usedAmount);
            return usedAmount;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnLeft_Click(object sender, EventArgs e)
        {
            double usedPrice = double.Parse(txtUsedPrice.Text);
            double payPrice = double.Parse(txtPayPrice.Text);
            double leftPice = payPrice - usedPrice;
            txtLeftPrice.Text = leftPice.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private double ToTenThousand(double value)
        {
            double result = value / 10000d;
            string s = result.ToString("F2");
            result = Convert.ToDouble(s);
            return result;
        }

        private double ToOne(double value)
        {
            double result = value * 10000d;
            return result;
        }
    }
}

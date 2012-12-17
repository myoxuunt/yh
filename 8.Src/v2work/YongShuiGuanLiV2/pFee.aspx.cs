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
using Xdgk.UI;
using YongShuiGuanLiDBI;

namespace YongShuiGuanLiV2
{
    public partial class pFee : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            MasterPageHelper.SetTitle(this, "应收实收统计");
            this.UCFeeCondition1.QueryEvent += new EventHandler(UCFeeCondition1_QueryEvent);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCFeeCondition1_QueryEvent(object sender, EventArgs e)
        {
            Query();
        }

        /// <summary>
        /// 
        /// </summary>
        private void Query()
        {
            DateTime begin = this.UCFeeCondition1.Begin;
            DateTime end = this.UCFeeCondition1.End;
            WaterUserCollection wus = this.UCFeeCondition1.SelectedWaterUserCollection;
            //wus[0].CalcUsedAmount(
            DataTable tbl = wus.GetFeeDataTable(begin, end);
            H.DataSource = tbl;
            H.Bind();

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
            string feeFormatString = "{0:f2}";
            GridViewConfig c = new GridViewConfig();
            c.GridViewColumnConfigCollection.AddBoundField(strings.WaterUserName,
                "WaterUserName");
            c.GridViewColumnConfigCollection.AddBoundField("开始时间",
                "Begin");
            c.GridViewColumnConfigCollection.AddBoundField("结束时间",
                "End");
            c.GridViewColumnConfigCollection.AddBoundField("单价",
                "Price", feeFormatString );
            c.GridViewColumnConfigCollection.AddBoundField("水量",
                "UsedAmount");
            c.GridViewColumnConfigCollection.AddBoundField("应缴水费",
                "UsedFee", feeFormatString );
            c.GridViewColumnConfigCollection.AddBoundField("实缴水费",
                "PayedFee", feeFormatString );
            c.GridViewColumnConfigCollection.AddBoundField("欠缴水费",
                "RemaindFee", feeFormatString);
            return c;
        }
        #endregion //GetGridViewConfig
    }

}

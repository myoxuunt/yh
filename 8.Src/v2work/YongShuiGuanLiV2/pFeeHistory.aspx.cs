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
using Xdgk.UI;

namespace YongShuiGuanLiV2
{
    // TODO: fee sum
    // 
    public partial class pFeeHistory : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            MasterPageHelper.SetTitle(this, "水费查询");
            this.UCFeeCondition1.QueryEvent += new EventHandler(UCFeeCondition1_QueryEvent);
            if (!IsPostBack)
            {
                ShowOrHideControls(false);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCFeeCondition1_QueryEvent(object sender, EventArgs e)
        {
            Query();
            ShowOrHideControls(true);
        }

        /// <summary>
        /// 
        /// </summary>
        private void Query()
        {
            DateTime begin = this.UCFeeCondition1.Begin;
            DateTime end = this.UCFeeCondition1.End;
            WaterUserCollection wus = this.UCFeeCondition1.SelectedWaterUserCollection;
            DataTable tbl = wus.GetFeeHistoryDataTable(begin, end);
            //AddTianShuColumn(tbl);
            H.DataSource = tbl;
            H.Bind();

            CountTotal(tbl);
        }

        private void CountTotal(DataTable dt)
        {
            //double allTotalPrice = 0; //应付总费
            double allWaterAmount = 0; //总水量
            double allUsedAmount = 0;//结算总水量
            double allPayPrice = 0;//已付总水费
            double allLeftPrice = 0;//剩余总水费

            if (dt.Rows.Count > 0)
            {
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    allWaterAmount = allWaterAmount + double.Parse(dt.Rows[i]["WaterAmount"].ToString());
                    allUsedAmount = allUsedAmount + double.Parse(dt.Rows[i]["UsedWater"].ToString());
                    allPayPrice = allPayPrice + double.Parse(dt.Rows[i]["PayPrice"].ToString());
                    allLeftPrice = allLeftPrice + double.Parse(dt.Rows[i]["LeftPrice"].ToString());
                }
            }
            if (allLeftPrice < 0)
                txtLeftPrice.ForeColor = System.Drawing.Color.Red;
            else
                txtLeftPrice.ForeColor = System.Drawing.Color.Black;
            txtLeftPrice.Text = allLeftPrice.ToString()+"    元";
            txtPayPrice.Text = allPayPrice.ToString() + "    元";
            txtUsedAmount.Text = allUsedAmount.ToString() + "    m³";
            txtWaterAmount.Text = allWaterAmount.ToString() + "    m³";
        }
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="tbl"></param>
        //private void AddTianShuColumn(DataTable tbl)
        //{
        //    tbl.Columns.Add ("tianShu",typeof(int)
        //}

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
            string format = "{0:f2}";

            GridViewConfig c = new GridViewConfig();
            c.GridViewColumnConfigCollection.AddEditCommandField(
                ""
                );

            c.GridViewColumnConfigCollection.AddBoundField(
                "用水户", "WaterUserName");

            c.GridViewColumnConfigCollection.AddBoundField(
                "行水项目", "FeeName");

            c.GridViewColumnConfigCollection.AddBoundField(
                "开始时间", "BeginDT");

            c.GridViewColumnConfigCollection.AddBoundField(
                "结束时间", "EndDT");

            c.GridViewColumnConfigCollection.AddBoundField(
                "天数", "NumberOfDay");

            c.GridViewColumnConfigCollection.AddBoundField(
                "水费标准", "UnitPrice", format);

            c.GridViewColumnConfigCollection.AddBoundField(
                "总用水量", "WaterAmount");

            c.GridViewColumnConfigCollection.AddBoundField(
                "损耗水量", "WaterLost");

            c.GridViewColumnConfigCollection.AddBoundField(
                "结算水量", "UsedWater");
            
            c.GridViewColumnConfigCollection.AddBoundField(
                "结算水费", "UsedPrice", format);

            c.GridViewColumnConfigCollection.AddBoundField(
                "实付水费", "PayPrice", format);

            c.GridViewColumnConfigCollection.AddBoundField(
                "剩余水费", "LeftPrice", format);

            c.GridViewColumnConfigCollection.AddBoundField(
                "备注", "Remark");

            return c;
        }
        #endregion //GetGridViewConfig

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int index = e.NewEditIndex;
            object val = this.GridView1.DataKeys[index].Value;
            int id = Convert.ToInt32(val);

            string s = "pFeeItem.aspx?FeeID=" + id;
            Response.Redirect(s);
        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            //base.VerifyRenderingInServerForm(control);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnExport_Click(object sender, EventArgs e)
        {
            ExcelExporter.ExportToExcel(this.GridView1);
        }

        private void ShowOrHideControls(bool show)
        {
            this.txtLeftPrice.Visible = show;
            this.txtPayPrice.Visible = show;
            this.txtWaterAmount.Visible = show;
            this.txtUsedAmount.Visible = show;

            this.lalLeftPrice.Visible = show;
            this.lalPayPrice.Visible = show;
            this.lalPayAmount.Visible = show;
            this.lalUsedAmount.Visible = show;

            this.btnExport.Visible = show;
        }
    }
}

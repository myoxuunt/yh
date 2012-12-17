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
    /// <summary>
    /// 
    /// </summary>
    public partial class pNewDistribute : System.Web.UI.Page
    {

        /// <summary>
        /// 
        /// </summary>
        private Xdgk.UI.GridViewHelper H
        {
            get
            {
                if(_h == null)
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private GridViewConfig GetGridViewConfig()
        {
            GridViewConfig c = new GridViewConfig();
            c.GridViewColumnConfigCollection.AddBoundField(strings.WaterUserName , "WaterUserName");
            c.GridViewColumnConfigCollection.AddBoundField(strings.NeedBegin, YongShuiGuanLiDBI.DBNames.tblNeedWater.NeedBeginDT);
            c.GridViewColumnConfigCollection.AddBoundField(strings.NeedEnd, YongShuiGuanLiDBI.DBNames.tblNeedWater.NeedEndDT);
            c.GridViewColumnConfigCollection.AddBoundField(strings.NeedAmount, YongShuiGuanLiDBI.DBNames.tblNeedWater.NeedAmount);
            c.GridViewColumnConfigCollection.AddBoundField(strings.Remark, YongShuiGuanLiDBI.DBNames.tblNeedWater.Remark);
        
            c.GridViewColumnConfigCollection.AddHyperLinkField("", strings.NewDistribute,
                new string[] { YongShuiGuanLiDBI.DBNames.tblNeedWater.NeedWaterID },
                "pDistributeItem.aspx?NeedWaterID={0}");

            return c;
        } 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
                MasterPageHelper.SetTitle(this, Titles.DistributeNew);
            this.UCChildWaterUserDTTwo1.QueryEvent += new EventHandler(UCChildWaterUserDTTwo1_QueryEvent);
            if (!IsPostBack)
            {
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCChildWaterUserDTTwo1_QueryEvent(object sender, EventArgs e)
        {
            WaterUserCollection wus = this.UCChildWaterUserDTTwo1.WaterUserCollection;

            DataTable tbl = wus.GetNeedWaterDataTable(this.UCChildWaterUserDTTwo1.Begin,
                this.UCChildWaterUserDTTwo1.End);
            //this.GridView1.DataSource = tbl;
            //this.GridView1.DataBind();

            this.H.DataSource = tbl;
            this.H.Bind();
        }


        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //protected void btnNew_Click(object sender, EventArgs e)
        //{
        //    // 1. select need water
        //    int needid = 0;
        //    //this.GridView1.Rows[0].Cells[0].
        //    // 2. trans to pDistr page
        //    string s = string.Format("pDistributeItem.aspx?NeedWaterID={0}", needid);
        //    Response.Redirect(s);
        //}
    }
}

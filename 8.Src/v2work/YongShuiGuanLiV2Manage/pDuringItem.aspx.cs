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
using YongShuiGuanLiDBI;

namespace YongShuiGuanLiV2Manage
{
    public partial class pDuringItem : System.Web.UI.Page
    {
        // TODO: 2011-06-10
        //
        // 1. valid begin and end date
        // 2. valid exist name
        //
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (IsEdit())
                {
                    int id = this.DuringID;
                    DataTable tbl = DuringWaterDBI.GetDuringDataTable(id);
                    DuringWaterClass d = DuringWaterFactory.CreateDuringWater(id);
                    if (d != null)
                    {
                        this.txtName.Text = d.Name;
                        this.txtBegin.Text = d.BeginString;
                        this.txtEnd.Text = d.EndString;
                    }
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
            string bs = "2000-" + this.txtBegin.Text;
            string es = "2000-" + this.txtEnd.Text;

            DateTime b = Convert.ToDateTime(bs);
            DateTime end = Convert.ToDateTime(es);
            string name = this.txtName.Text.Trim();

            if (!IsEdit())
            {
                DuringWaterDBI.InsertDuring(name, b, end, string.Empty);
            }
            else
            {
                int id = this.DuringID;
                DuringWaterDBI.UpdateDuring(id, name, b, end, string.Empty);
            }
            Response.Redirect("pDuringList.aspx");
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsEdit()
        {
            string s = Request.QueryString["DuringID"];
            if(  s!= null )
            {
                int r ;
                bool b = int.TryParse (s, out r);
                return b;
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        private int DuringID
        {
            get
            {
                string s = Request.QueryString["DuringID"];
                return int.Parse (s);
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("pDuringList.aspx");
        }
    }
}

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


namespace YongShuiGuanLiV2.gcssgl
{
    public partial class skxx : System.Web.UI.Page
    {
        YongShuiGuanLiDBI.gcgl_data gcgl = new YongShuiGuanLiDBI.gcgl_data();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                get_data();
            }
        }
        private void get_data()
        {
            dt = gcgl.sk_query("");
            this.DataGrid1.DataSource = dt.DefaultView;
            this.DataGrid1.DataBind();
            Session["T_data"] = dt;
        }

        protected void DataGrid1_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            DataTable dt1 = new DataTable();
            if (e.CommandName == "select")
            {
                TableRow a = new TableRow();
                a = e.Item;
                dt1 = gcgl.sk_query(a.Cells[1].Text);
                if (dt1.Rows.Count > 0)
                {
                    DataRow dr = dt1.Rows[0];
                    Session["id"] = a.Cells[1].Text;
                    this.skmc.Text = dr["水库名称"].ToString();
                    this.dlwz.Text = dr["地理位置"].ToString();
                    this.gcgm.Text = dr["工程规模"].ToString();
                    this.gcdj.Text = dr["工程等级"].ToString();
                    this.zblx.Text = dr["主坝类型"].ToString();
                    this.zbgd.Text = dr["主坝高度（米）"].ToString();
                    this.zbcd.Text = dr["主坝长度（米）"].ToString();
                    this.zkr.Text = dr["总库容（万立方米）"].ToString();
                    this.xlkr.Text = dr["兴利库容（万立方米）"].ToString();
                    this.jssj.Text = dr["建设时间"].ToString();
                    this.bz.Text = dr["备注说明"].ToString();
                    this.gldw.Text = dr["管理单位"].ToString();
                    this.yxzk.Text = dr["运行状况"].ToString();
                }

            }
        }

        protected void DataGrid1_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            this.DataGrid1.SelectedIndex = -1;
            this.DataGrid1.CurrentPageIndex = e.NewPageIndex;
            this.DataGrid1.DataSource = (DataTable)Session["T_data"];
            this.DataGrid1.DataBind();
        }
    }
}

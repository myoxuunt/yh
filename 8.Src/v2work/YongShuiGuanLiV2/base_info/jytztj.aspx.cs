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

namespace YongShuiGuanLiV2.base_info
{
    public partial class jytztj : System.Web.UI.Page
    {
        YongShuiGuanLiDBI.login_data lo = new YongShuiGuanLiDBI.login_data();
        DataTable ds = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void query_Click(object sender, EventArgs e)
        {
            ds = lo.jytztj_query("", this.year.Text);
            this.DataGrid1.DataSource = ds.DefaultView;
            this.DataGrid1.DataBind();
            Session["T_data"] = ds;
        }

        protected void DataGrid1_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            DataTable dataset1 = new DataTable();
            if (e.CommandName == "select")
            {
                TableRow a = new TableRow();
                a = e.Item;
                dataset1 = lo.jytztj_query(a.Cells[1].Text, "");
                if (dataset1.Rows.Count > 0)
                {
                    Session["id"] = a.Cells[1].Text;
                    DataRow dr = dataset1.Rows[0];
                    this.Image2.ImageUrl = dr["image"].ToString();
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

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
    public partial class dbxx : System.Web.UI.Page
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
            dt = gcgl.db_query("");
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
                dt1 = gcgl.db_query(a.Cells[1].Text);
                if (dt1.Rows.Count > 0)
                {
                    DataRow dr = dt1.Rows[0];
                    Session["id"] = a.Cells[1].Text;
                    this.dbmc.Text = dr["大坝名称"].ToString();
                    this.dlwz.Text = dr["地理位置"].ToString();
                    this.dblx.Text = dr["大坝类型"].ToString();
                    this.gcdj.Text = dr["工程等级"].ToString();
                    this.dbgd.Text = dr["大坝高度（米）"].ToString();
                    this.dbcd.Text = dr["大坝长度（米）"].ToString();
                    this.dbzy.Text = dr["大坝作用"].ToString();
                    this.jzcl.Text = dr["建筑材料"].ToString();
                    this.gldw.Text = dr["管理单位"].ToString();
                    this.jssj.Text = dr["建设时间"].ToString();
                    this.yxzk.Text = dr["运行状况"].ToString();
                    this.bzsm.Text = dr["备注说明"].ToString();
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

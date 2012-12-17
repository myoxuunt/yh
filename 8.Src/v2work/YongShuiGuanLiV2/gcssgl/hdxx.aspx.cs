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
    public partial class hdxx : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        YongShuiGuanLiDBI.gcgl_data gcgl = new YongShuiGuanLiDBI.gcgl_data();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ViewState["Page"] = "0";
                get_data(qd1.get());
            }
        }
        private void get_data(string qd)
        {
            this.DataGrid1.SelectedIndex = -1;
            dt = gcgl.hd_query1(qd);
            this.DataGrid1.DataSource = dt.DefaultView;

            if (!object.Equals(ViewState["Page"], null))
                this.DataGrid1.CurrentPageIndex = int.Parse(ViewState["Page"].ToString());
            try
            {
                this.DataGrid1.DataBind();
                Session["T_data_hd"] = dt;
            }
            catch
            {
                this.DataGrid1.CurrentPageIndex = this.DataGrid1.PageCount - 1;
                this.DataGrid1.DataBind();
                Session["T_data_hd"] = dt;
            }
        }

        protected void query_Click(object sender, EventArgs e)
        {
            get_data(qd1.get());
        }

        protected void DataGrid1_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            DataTable dt1 = new DataTable();
            if (e.CommandName == "select")
            {
                TableRow a = new TableRow();
                a = e.Item;
                dt1 = gcgl.hd_query(a.Cells[1].Text);
                if (dt1.Rows.Count > 0)
                {
                    DataRow dr = dt1.Rows[0];
                    Session["id"] = a.Cells[1].Text;
                    this.hdmc.Text = dr["涵洞名称"].ToString();
                    this.ssqd.Text = dr["所属渠道"].ToString();
                    this.qszh.Text = dr["起始桩号"].ToString();
                    this.hdxs.Text = dr["涵洞型式"].ToString();
                    this.dmlx.Text = dr["断面类型"].ToString();
                    this.hdcd.Text = dr["涵洞长度（米）"].ToString();
                    this.hdgd.Text = dr["涵洞高度（米）"].ToString();
                    this.hdkd.Text = dr["涵洞宽度（米）"].ToString();
                    this.hdbj.Text = dr["涵洞半径（米）"].ToString();
                    this.sjll.Text = dr["设计流量（立方米/秒）"].ToString();
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
            this.DataGrid1.DataSource = (DataTable)Session["T_data_hd"];
            this.DataGrid1.DataBind();
        }

    }
}

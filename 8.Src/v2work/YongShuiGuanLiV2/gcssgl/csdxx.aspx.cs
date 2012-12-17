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
    public partial class csdxx : System.Web.UI.Page
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
            dt = gcgl.csd_query1(qd);
            this.DataGrid1.DataSource = dt.DefaultView;
            if (!object.Equals(ViewState["Page"], null))
                this.DataGrid1.CurrentPageIndex = int.Parse(ViewState["Page"].ToString());
            try
            {
                this.DataGrid1.DataBind();
                Session["T_data_csd"] = dt;
            }
            catch
            {
                this.DataGrid1.CurrentPageIndex = this.DataGrid1.PageCount - 1;
                this.DataGrid1.DataBind();
                Session["T_data_csd"] = dt;
            }

        }

        protected void DataGrid1_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            DataTable dt1 = new DataTable();
            if (e.CommandName == "select")
            {
                TableRow a = new TableRow();
                a = e.Item;
                dt1 = gcgl.csd_query1(a.Cells[1].Text);
                if (dt1.Rows.Count > 0)
                {
                    DataRow dr = dt1.Rows[0];
                    Session["id"] = a.Cells[1].Text;
                    this.ssqd.Text = dr["所属渠道"].ToString();
                    this.xz.Text = dr["形状"].ToString();
                    this.csdmc.Text = dr["沉沙池名称"].ToString();
                    this.qszh.Text = dr["起始桩号"].ToString();
                    this.cd.Text = dr["长度（米）"].ToString();
                    this.zdmj.Text = dr["占地面积（平方米）"].ToString();
                    this.sjcskr.Text = dr["设计沉沙库容（立方米）"].ToString();
                    this.xycskr.Text = dr["现有沉沙库容（立方米）"].ToString();
                    this.zyzy.Text = dr["主要作用"].ToString();
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
            this.DataGrid1.DataSource = (DataTable)Session["T_data_csd"];
            this.DataGrid1.DataBind();
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            get_data(qd1.get());
        }

    }
}

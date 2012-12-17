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
    public partial class qlxx : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        DataTable dt_qd = new DataTable();
        YongShuiGuanLiDBI.gcgl_data gcgl = new YongShuiGuanLiDBI.gcgl_data();
        //protected UC.qd Qd1;
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
            this.DataGrid_ql.SelectedIndex = -1;
            dt = gcgl.ql_query1(qd);
            this.DataGrid_ql.DataSource = dt.DefaultView;
            if (!object.Equals(ViewState["Page"], null))
                DataGrid_ql.CurrentPageIndex = int.Parse(ViewState["Page"].ToString());
            try
            {
                this.DataGrid_ql.DataBind();
                Session["T_data_ql"] = dt;
            }
            catch
            {
                DataGrid_ql.CurrentPageIndex = DataGrid_ql.PageCount - 1;
                this.DataGrid_ql.DataBind();
                Session["T_data_ql"] = dt;
            }

        }

        protected void button1_Click(object sender, EventArgs e)
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
                dt1 = gcgl.ql_query(a.Cells[1].Text);
                if (dt1.Rows.Count > 0)
                {
                    DataRow dr = dt1.Rows[0];
                    Session["id"] = a.Cells[1].Text;
                    this.ssqd.Text = dr["所属渠道"].ToString();
                    this.qlmc.Text = dr["桥梁名称"].ToString();
                    this.zh.Text = dr["桩号"].ToString();
                    this.qk.Text = dr["桥宽（米）"].ToString();
                    this.qc.Text = dr["桥长（米）"].ToString();
                    this.zkd.Text = dr["总跨度（米）"].ToString();
                    this.ks.Text = dr["孔数（孔）"].ToString();
                    this.dkjk.Text = dr["单孔净宽（米）"].ToString();
                    this.qxjk.Text = dr["桥下净空（米）"].ToString();
                    this.jgxs.Text = dr["结构型式"].ToString();
                    this.gsnl.Text = dr["过水能力（立方米/秒）"].ToString();
                    this.jzcl.Text = dr["建筑材料"].ToString();

                    this.sjhz.Text = dr["设计荷载"].ToString();
                    this.gldw.Text = dr["管理单位"].ToString();
                    this.yxsj.Text = dr["建设时间"].ToString();
                    this.yxzk.Text = dr["运行状况"].ToString();
                    this.bzsm.Text = dr["备注说明"].ToString();
                }

            }
        }

        protected void DataGrid1_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            this.DataGrid_ql.SelectedIndex = -1;
            DataGrid_ql.CurrentPageIndex = e.NewPageIndex;
            this.DataGrid_ql.DataSource = (DataTable)Session["T_data_ql"];
            this.DataGrid_ql.DataBind();
        }
    }
}

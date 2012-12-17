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
    public partial class dhxxx : System.Web.UI.Page
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
            dt = gcgl.dhx_query1(qd);
            this.DataGrid1.DataSource = dt.DefaultView;
            if (!object.Equals(ViewState["Page"], null))
                this.DataGrid1.CurrentPageIndex = int.Parse(ViewState["Page"].ToString());
            try
            {
                this.DataGrid1.DataBind();
                Session["T_data_dhx"] = dt;
            }
            catch
            {
                this.DataGrid1.CurrentPageIndex = this.DataGrid1.PageCount - 1;
                this.DataGrid1.DataBind();
                Session["T_data_dhx"] = dt;
            }
        }
        protected void DataGrid1_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            DataTable dt1 = new DataTable();
            if (e.CommandName == "select")
            {
                TableRow a = new TableRow();
                a = e.Item;
                dt1 = gcgl.dhx_query(a.Cells[1].Text);
                if (dt1.Rows.Count > 0)
                {
                    DataRow dr = dt1.Rows[0];
                    Session["id"] = a.Cells[1].Text;
                    this.qsmc.Text = dr["倒虹吸名称"].ToString();
                    this.dlwz.Text = dr["所属渠道"].ToString();
                    this.gclx.Text = dr["起始桩号"].ToString();
                    this.sqsy.Text = dr["倒虹吸长度（米）"].ToString();
                    this.qsll.Text = dr["设计流量（立方米/秒）"].ToString();
                    this.qszc.Text = dr["布置型式"].ToString();
                    this.gj.Text = dr["管径（米）"].ToString();
                    this.cz.Text = dr["材质"].ToString();
                    this.lx.Text = dr["断面类型"].ToString();
                    this.dc.Text = dr["洞长（米）"].ToString();
                    this.dg.Text = dr["洞高（米）"].ToString();
                    this.dk.Text = dr["洞宽（米）"].ToString();
                    this.bj.Text = dr["半径（米）"].ToString();
                    this.xc.Text = dr["吸差（米）"].ToString();
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
            this.DataGrid1.DataSource = (DataTable)Session["T_data_dhx"];
            this.DataGrid1.DataBind();
        }

        protected void query_Click(object sender, EventArgs e)
        {
            get_data(qd1.get());
        }
    }
}

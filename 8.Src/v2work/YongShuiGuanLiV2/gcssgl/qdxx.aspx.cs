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
    public partial class qdxx : System.Web.UI.Page
    {
        YongShuiGuanLiDBI.gcgl_data gc = new YongShuiGuanLiDBI.gcgl_data();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                get_data(qd1.get());
            }
        }
        private void get_data(string qd)
        {
            this.DataGrid1.SelectedIndex = -1;
            dt = gc.qd_query3(qd);
            this.DataGrid1.DataSource = dt.DefaultView;
            if (!object.Equals(ViewState["Page"], null))
                this.DataGrid1.CurrentPageIndex = int.Parse(ViewState["Page"].ToString());
            try
            {
                this.DataGrid1.DataBind();
                Session["T_data"] = dt;
            }
            catch
            {
                this.DataGrid1.CurrentPageIndex = this.DataGrid1.PageCount - 1;
                this.DataGrid1.DataBind();
                Session["T_data"] = dt;
            }
        }

        protected void DataGrid1_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            DataTable dt1 = new DataTable();
            if (e.CommandName == "select")
            {
                TableRow a = new TableRow();
                a = e.Item;
                dt1 = gc.qd_query(a.Cells[1].Text);
                if (dt1.Rows.Count > 0)
                {
                    DataRow dr = dt1.Rows[0];
                    Session["id"] = a.Cells[1].Text;
                    this.qdmc.Text = dr["渠道名称"].ToString();
                    this.qdjc.Text = dr["渠道简称"].ToString();
                    this.qdjb.Text = dr["渠道级别"].ToString();
                    this.sjqd.Text = dr["上级渠道"].ToString();
                    this.qdcd.Text = dr["渠道长度（千米）"].ToString();
                    this.sjll.Text = dr["设计流量（立方米/秒）"].ToString();
                    this.ljsjqdss.Text = dr["联接上级渠道设施"].ToString();
                    this.bjqdzh.Text = dr["本级渠道在上级渠道上的桩号"].ToString();
                    this.shjfscd.Text = dr["实际防渗长度（千米）"].ToString();
                    this.sjfscd.Text = dr["设计防渗长度（千米）"].ToString();
                    this.qdfsl.Text = dr["渠道防渗率（%）"].ToString();
                    this.shjggmj.Text = dr["设计灌溉面积（万亩）"].ToString();

                    this.yxggmj.Text = dr["有效灌溉面积（万亩）"].ToString();
                    this.sjggmj.Text = dr["实际灌溉面积（万亩）"].ToString();
                    this.qdslyxs.Text = dr["渠道水利用系数"].ToString();
                    this.ghfsmj.Text = dr["规划防渗面积（平方米）"].ToString();
                    this.gldw.Text = dr["管理单位"].ToString();
                    this.jssj.Text = dr["建设时间"].ToString();
                    this.yszk.Text = dr["运行状况"].ToString();
                    this.bzsm.Text = dr["备注说明"].ToString();
                }

            }
        }

        protected void DataGrid1_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            DataGrid1.CurrentPageIndex = e.NewPageIndex;
            DataGrid1.SelectedIndex = -1;
            DataGrid1.DataSource = (DataTable)Session["T_data"];
            DataGrid1.DataBind();
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            get_data(qd1.get());
        }
    }
}

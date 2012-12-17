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
    public partial class qdjscs : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        YongShuiGuanLiDBI.gcgl_data gcgl = new YongShuiGuanLiDBI.gcgl_data();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ViewState["Page"] = "0";
                qd1.enable_true();
                get_data(qd1.get());
            }
        }
        private void get_data(string id)
        {
            this.DataGrid1.SelectedIndex = -1;
            dt = gcgl.qdjscs_query1(id);
            this.DataGrid1.DataSource = dt.DefaultView;
            if (!object.Equals(ViewState["Page"], null))
                this.DataGrid1.CurrentPageIndex = int.Parse(ViewState["Page"].ToString());
            try
            {
                this.DataGrid1.DataBind();
                Session["T_data_qdjscs"] = dt;
            }
            catch
            {
                this.DataGrid1.CurrentPageIndex = this.DataGrid1.PageCount - 1;
                this.DataGrid1.DataBind();
                Session["T_data_qdjscs"] = dt;
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
                dt1 = gcgl.qdjscs_query(a.Cells[1].Text);
                if (dt1.Rows.Count > 0)
                {
                    DataRow dr = dt1.Rows[0];
                    Session["id"] = a.Cells[1].Text;
                    this.ssqd.Text = dr["所属渠道"].ToString();
                    this.qdcd.Text = dr["渠段长度（千米）"].ToString();
                    this.qszh.Text = dr["起始桩号"].ToString();
                    this.zzzh.Text = dr["终止桩号"].ToString();
                    this.dmxs.Text = dr["断面形式"].ToString();
                    this.sjll.Text = dr["设计流量(立方米/秒)"].ToString();
                    this.jdll.Text = dr["加大流量(立方米/秒)"].ToString();
                    this.sjls.Text = dr["设计流速(立方米/秒)"].ToString();
                    this.sjss.Text = dr["设计水深(米)"].ToString();
                    this.qdslyxs.Text = dr["渠道水利用系数（%）"].ToString();
                    this.ljbcls.Text = dr["临界不冲流速（立方米/秒）"].ToString();
                    this.ljbyls.Text = dr["临界不淤流速（立方米/秒）"].ToString();

                    this.qdbj.Text = dr["渠道比降"].ToString();
                    this.nbpxs.Text = dr["内边坡系数"].ToString();
                    this.wbpxs.Text = dr["外边坡系数"].ToString();
                    this.cl.Text = dr["糙率"].ToString();
                    this.qdk.Text = dr["渠底宽（米）"].ToString();
                    this.skk.Text = dr["上口宽（米）"].ToString();
                    this.zddkd.Text = dr["左堤顶宽度（米）"].ToString();
                    this.yddkd.Text = dr["右堤顶宽度（米）"].ToString();
                    this.bzsm.Text = dr["备注说明"].ToString();
                }

            }
        }

        protected void DataGrid1_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            DataGrid1.CurrentPageIndex = e.NewPageIndex;
            DataGrid1.SelectedIndex = -1;
            DataGrid1.DataSource = (DataTable)Session["T_data_qdjscs"];
            DataGrid1.DataBind();
        }
    }
}

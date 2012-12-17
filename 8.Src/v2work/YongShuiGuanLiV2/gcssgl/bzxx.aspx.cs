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
    public partial class bzxx : System.Web.UI.Page
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
        private void get_data(string id)
        {
            this.DataGrid1.SelectedIndex = -1;
            
            dt = gcgl.bz_query1(id);
            this.DataGrid1.DataSource = dt.DefaultView;
            if (!object.Equals(ViewState["Page"], null))
                this.DataGrid1.CurrentPageIndex = int.Parse(ViewState["Page"].ToString());
            try
            {
                this.DataGrid1.DataBind();
                Session["T_data_bz"] = dt;
            }
            catch
            {
                this.DataGrid1.CurrentPageIndex = this.DataGrid1.PageCount - 1;
            }

        }

        protected void DataGrid1_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            DataTable dt1 = new DataTable();
            if (e.CommandName == "select")
            {
                TableRow a = new TableRow();
                a = e.Item;
                dt1 = gcgl.bz_query(a.Cells[1].Text);
                if (dt1.Rows.Count > 0)
                {
                    DataRow dr = dt1.Rows[0];
                    Session["id"] = a.Cells[1].Text;
                    this.ssqd.Text = dr["所属渠道"].ToString();
                    this.bzmc.Text = dr["泵站名称"].ToString();
                    this.zh.Text = dr["桩号"].ToString();
                    this.dlwz.Text = dr["地理位置"].ToString();
                    this.bzgm.Text = dr["泵站规模"].ToString();
                    this.bzlx.Text = dr["泵站类型"].ToString();
                    this.jzts.Text = dr["机组台数（台）"].ToString();
                    this.zzjrl.Text = dr["总装机容量（千瓦）"].ToString();
                    this.sjyc.Text = dr["设计扬程（米）"].ToString();
                    this.sjll.Text = dr["设计流量（立方米/秒）"].ToString();
                    this.zzxl.Text = dr["装置效率（%）"].ToString();
                    this.gldw.Text = dr["管理单位"].ToString();

                    this.jzbh.Text = dr["机组编号"].ToString();
                    this.sblx.Text = dr["水泵类型"].ToString();
                    this.xh.Text = dr["型号"].ToString();
                    this.ll.Text = dr["流量（立方米/秒）"].ToString();
                    this.yc.Text = dr["扬程（米）"].ToString();
                    this.gl.Text = dr["功率（千瓦）"].ToString();
                    this.xl.Text = dr["效率（%）"].ToString();
                    this.ptdl.Text = dr["配套动力"].ToString();
                    this.sccj.Text = dr["生产厂家"].ToString();

                    this.ccrq.Text = dr["出厂日期"].ToString();
                    this.synx.Text = dr["使用年限"].ToString();
                }

            }
        }

        protected void DataGrid1_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            DataGrid1.CurrentPageIndex = e.NewPageIndex;
            DataGrid1.SelectedIndex = -1;
            DataGrid1.DataSource = (DataTable)Session["T_data_bz"];
            DataGrid1.DataBind();
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            get_data(qd1.get());
        }
    }
}

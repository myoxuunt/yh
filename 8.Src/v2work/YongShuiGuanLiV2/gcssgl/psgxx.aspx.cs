using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace YongShuiGuanLiV2.gcssgl
{
    public partial class psgxx : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        YongShuiGuanLiDBI.gcgl_data gcgl = new YongShuiGuanLiDBI.gcgl_data();
        protected void Page_Load(object sender, EventArgs e)
        {
            MasterPageHelper.SetTitle(this, "排水沟信息查询");
            if (!Page.IsPostBack)
            {
                get_data();
            }
        }
        private void get_data()
        {
            dt = gcgl.psg_query("");
            this.DataGrid1.DataSource = dt.DefaultView;
            this.DataGrid1.DataBind();
            Session["T_data_psg"] = dt;
        }

        protected void DataGrid1_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            DataTable dt1 = new DataTable();
            if (e.CommandName == "select")
            {
                TableRow a = new TableRow();
                a = e.Item;
                dt1 = gcgl.psg_query(a.Cells[1].Text);
                if (dt1.Rows.Count > 0)
                {
                    DataRow dr = dt1.Rows[0];
                    Session["id"] = a.Cells[1].Text;
                    this.gdmc.Text = dr["沟道名称"].ToString();
                    this.gdjc.Text = dr["沟道简称"].ToString();
                    this.sjgd.Text = dr["上级沟道"].ToString();
                    this.plmj.Text = dr["排涝面积（万亩）"].ToString();
                    this.sjpsbz.Text = dr["设计排水标准（年）"].ToString();
                    this.xypsbz.Text = dr["现有排水标准（年）"].ToString();
                    this.sjcd.Text = dr["设计长度（千米）"].ToString();
                    this.xycd.Text = dr["现有长度（千米）"].ToString();
                    this.sjll.Text = dr["设计流量（立方米/秒）"].ToString();
                    this.xyll.Text = dr["（立方米/秒）"].ToString();
                    this.sjsd.Text = dr["设计深度（米）"].ToString();
                    this.xysd.Text = dr["现有深度（米）"].ToString();
                    this.sjskk.Text = dr["设计上口宽（米）"].ToString();
                    this.xyskk.Text = dr["现有上口宽（米）"].ToString();
                    this.sjdk.Text = dr["设计底宽（米）"].ToString();
                    this.xydk.Text = dr["现有底宽（米）"].ToString();
                    this.sjpj.Text = dr["设计坡降"].ToString();
                    this.xypj.Text = dr["现有坡降"].ToString();
                    this.sjbp.Text = dr["设计边坡"].ToString();
                    this.xybp.Text = dr["现有边坡"].ToString();
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
            this.DataGrid1.DataSource = (DataTable)Session["T_data_psg"];
            this.DataGrid1.DataBind();
        }
    }
}

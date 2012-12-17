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

namespace YongShuiGuanLiV2.UC
{
    public partial class qd : System.Web.UI.UserControl
    {
        YongShuiGuanLiDBI.gcgl_data gc = new YongShuiGuanLiDBI.gcgl_data();
        DataTable dt_qd = new DataTable();
        DataTable dt_qd1 = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                get_data();
            }
        }
        public void get_data()
        {
            dt_qd = gc.qd_query2();
            this.DropDownList1.DataSource = dt_qd.DefaultView;
            this.DropDownList1.DataTextField = "sjqd";
            this.DropDownList1.DataValueField = "sjqd";
            this.DropDownList1.DataBind();
            this.DropDownList1.Items.Add(new ListItem("全部渠道", ""));
            this.DropDownList1.SelectedIndex = this.DropDownList1.Items.Count - 1;
            dt_qd1 = gc.qd_query1("");
            this.DropDownList2.DataSource = dt_qd1.DefaultView;
            this.DropDownList2.DataTextField = "渠道名称";
            this.DropDownList2.DataValueField = "渠道名称";
            this.DropDownList2.DataBind();
            this.DropDownList2.Items.Add(new ListItem("全部渠道", ""));
            this.DropDownList2.SelectedIndex = this.DropDownList2.Items.Count - 1;
        }
        public string get()
        {
            string str = "";
            
            if (!string.IsNullOrEmpty(this.DropDownList2.SelectedValue))
            {
                
                    str = "where 渠道.渠道名称='" + this.DropDownList2.SelectedValue + "'";
                
            }
            if (!string.IsNullOrEmpty(this.DropDownList1.SelectedValue))
            {
                if (str.Length > 0)
                {
                    str = str+" and 渠道.上级渠道='" + this.DropDownList1.SelectedValue + "'";
                }
                else
                {
                    str ="where 渠道.上级渠道='" + this.DropDownList1.SelectedValue+"' or 渠道.渠道名称='" + this.DropDownList1.SelectedValue + "'";
                }
            
            }
            return str;
        }
        public void enable_true()
        {
            this.DropDownList1.Enabled = true;
            this.DropDownList2.Enabled = true;
        }
        public void enable_false()
        {
            this.DropDownList1.Enabled = false;
            this.DropDownList2.Enabled = false;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt_qd1 = gc.qd_query1(this.DropDownList1.SelectedValue);
            this.DropDownList2.DataSource = dt_qd1.DefaultView;
            this.DropDownList2.DataTextField = "渠道名称";
            this.DropDownList2.DataValueField = "渠道名称";
            this.DropDownList2.DataBind();
            this.DropDownList2.Items.Add(new ListItem("全部渠道", ""));
            this.DropDownList2.SelectedIndex = this.DropDownList2.Items.Count - 1;
        }
    }
}
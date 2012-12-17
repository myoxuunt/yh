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
using YongShuiGuanLiDBI;

namespace YongShuiGuanLiV2.UC
{
    public partial class UCWUsedWater1 : System.Web.UI.UserControl
    {
        public event EventHandler QueryEvent;
        public event EventHandler QueryEvent2;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                hidden_yonghu.Visible = true;
                hidden_qudao.Visible = false;
                BindCheckBoxListChu();
                BindCheckBoxListGan();
            }

        }
        private void BindCheckBoxListGan()
        {
            DataTable dt = ChannelDBI.GetChannelTableForLevel(5);
            DataBindQD(dt, DropDownList4);
        }
        private void BindCheckBoxListChu()
        {
            DataTable dt = WaterUserDBI.GetWaterUserDataTable(WaterUserLevelEnum.Chu);
            DataBind(dt, DropDownList1);
        }
        private void DataBindQD(DataTable dt, DropDownList ddlChannel)
        {
            ListItemCollection ds = new ListItemCollection();
            ListItem lititle = new ListItem();
            lititle.Text = "-请选择-";
            lititle.Value = "0";
            ds.Add(lititle);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string id = dt.Rows[i]["ChannelID"].ToString();
                string name = dt.Rows[i]["ChannelName"].ToString();
                ListItem li = new ListItem();
                li.Text = name;
                li.Value = id;
                ds.Add(li);
            }
            ddlChannel.DataTextField = "Text";
            ddlChannel.DataValueField = "Value";
            ddlChannel.DataSource = ds;
            ddlChannel.DataBind();
        }
        private void DataBind(DataTable dt, DropDownList ddlChannel)
        {
            ListItemCollection ds = new ListItemCollection();
            ListItem lititle = new ListItem();
            lititle.Text = "-请选择-";
            lititle.Value = "0";
            ds.Add(lititle);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string id = dt.Rows[i]["WaterUserID"].ToString();
                string name = dt.Rows[i]["WaterUserName"].ToString();
                ListItem li = new ListItem();
                li.Text = name;
                li.Value = id;
                ds.Add(li);
            }
            ddlChannel.DataTextField = "Text";
            ddlChannel.DataValueField = "Value";
            ddlChannel.DataSource = ds;
            ddlChannel.DataBind();
        }
        public sUsedWater GetWaterUserIDS()
        {
            sUsedWater UsersIndex = new sUsedWater();
            UsersIndex.UID = "";
            UsersIndex.UName = "";
            for (int i = 0; i < this.CheckBoxList1.Items.Count; i++)
            {
                if (this.CheckBoxList1.Items[i].Selected)
                {
                    UsersIndex.UID = UsersIndex.UID + "-" + this.CheckBoxList1.Items[i].Value;
                    UsersIndex.UName = UsersIndex.UName + "-" + this.CheckBoxList1.Items[i].Text;
                }
            }
            return UsersIndex;
        }
        public sUsedWater GetChannelIDS()
        {
            sUsedWater UsersIndex = new sUsedWater();
            UsersIndex.UID = "";
            UsersIndex.UName = "";
            for (int i = 0; i < this.CheckBoxList2.Items.Count; i++)
            {
                if (this.CheckBoxList2.Items[i].Selected)
                {
                    UsersIndex.UID = UsersIndex.UID + "-" + this.CheckBoxList2.Items[i].Value;
                    UsersIndex.UName = UsersIndex.UName + "-" + this.CheckBoxList2.Items[i].Text;
                }
            }
            return UsersIndex;
        }
        public DateTime DuringBegin
        {
            get
            {
                //return Convert.ToDateTime(this.txtBegin.Text);
                return this.UCShiDuan1.DuringBegin;
            }
            set
            {
                this.UCShiDuan1.DuringEnd = value;
            }
        }
        public DateTime DuringEnd
        {
            get
            {
                //return Convert.ToDateTime(this.txtEnd.Text);
                return this.UCShiDuan1.DuringEnd;
            }
            set
            {
                this.UCShiDuan1.DuringEnd = value;
            }
        }


        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListItem li = this.DropDownList1.SelectedItem;
            if (li != null)
            {
                string value = li.Value;
                int ParentID = Convert.ToInt32(value);
                DataTable dt = WaterUserDBI.GetLowLevelWaterUserDataTable(ParentID);
                DataBind(dt, DropDownList2);
            }

        }


        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListItem li = this.DropDownList2.SelectedItem;
            if (li != null)
            {
                string value = li.Value;
                int ParentID = Convert.ToInt32(value);
                DataTable dt = WaterUserDBI.GetLowLevelWaterUserDataTable(ParentID);
                DataBind(dt, DropDownList3);
            }

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            labText.Text = "";
            ListItem li = new ListItem();
            if (DropDownList1.SelectedValue.Trim() != "0")
            {
                li.Text = DropDownList1.SelectedItem.Text;
                li.Value = DropDownList1.SelectedValue.Trim();
                if (DropDownList2.SelectedValue.Trim() != "0")
                {
                    li.Text = li.Text + "_" + DropDownList2.SelectedItem.Text;
                    li.Value = DropDownList2.SelectedValue.Trim();
                    if (DropDownList3.SelectedValue.Trim() != "0")
                    {
                        li.Text = li.Text + "_" + DropDownList3.SelectedItem.Text;
                        li.Value = DropDownList3.SelectedValue.Trim();
                    }
                }
                if (CheckBoxList1.Items.Count < 5)
                {
                    if (CheckBoxList1.Items.Count > 0)
                    {
                        for (int i = 0; i < CheckBoxList1.Items.Count; i++)
                        {
                            if (CheckBoxList1.Items[i].Text == li.Text)
                            {
                                labText.Text = "该用户已经存在";
                                return;
                            }
                        }
                    }
                    CheckBoxList1.Items.Add(li);
                }
                else
                    labText.Text = "查询用户同时不能超过5个";
            }
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            if (!this.CheckBoxList1.SelectedValue.Equals(""))
            {
                CheckBoxList1.Items.Remove(CheckBoxList1.SelectedItem);
            }
            else
            {
                labText.Text = "请正确选择删除条件";
            }

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            labText.Text = "";
            if (!this.CheckBoxList1.SelectedValue.Equals(""))
            {
                if (this.QueryEvent != null)
                {
                    this.QueryEvent(this, EventArgs.Empty);
                }
            }
            else
            {
                labText.Text = "查询条件错误";
            }

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == true)
            {
                hidden_yonghu.Visible = true;
                hidden_qudao.Visible = false;
            }
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2.Checked == true)
            {
                hidden_yonghu.Visible = false;
                hidden_qudao.Visible = true;
            }
        }

        protected void DropDownList6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListItem li = this.DropDownList5.SelectedItem;
            if (li != null)
            {
                string value = li.Value;
                int ParentID = Convert.ToInt32(value);
                DataTable dt = ChannelDBI.GetLowLevelChannelDataTable(ParentID);
                DataBind(dt, DropDownList6);
            }
        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListItem li = this.DropDownList4.SelectedItem;
            if (li != null)
            {
                string value = li.Value;
                int ParentID = Convert.ToInt32(value);
                DataTable dt = ChannelDBI.GetLowLevelChannelDataTable(ParentID);
                DataBind(dt, DropDownList5);
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (!this.CheckBoxList2.SelectedValue.Equals(""))
            {
                CheckBoxList2.Items.Remove(CheckBoxList1.SelectedItem);
            }
            else
            {
                labText2.Text = "请正确选择删除条件";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            labText2.Text = "";
            ListItem li = new ListItem();
            if (DropDownList4.SelectedValue.Trim() != "0")
            {
                li.Text = DropDownList4.SelectedItem.Text;
                li.Value = DropDownList4.SelectedValue.Trim();
                if (DropDownList5.SelectedValue.Trim() != "0")
                {
                    li.Text = li.Text + "_" + DropDownList5.SelectedItem.Text;
                    li.Value = DropDownList5.SelectedValue.Trim();
                    if (DropDownList6.SelectedValue.Trim() != "0")
                    {
                        li.Text = li.Text + "_" + DropDownList6.SelectedItem.Text;
                        li.Value = DropDownList6.SelectedValue.Trim();
                    }
                }
                if (CheckBoxList2.Items.Count < 5)
                {
                    if (CheckBoxList2.Items.Count > 0)
                    {
                        for (int i = 0; i < CheckBoxList2.Items.Count; i++)
                        {
                            if (CheckBoxList2.Items[i].Text == li.Text)
                            {
                                labText2.Text = "该用户已经存在";
                                return;
                            }
                        }
                    }
                    CheckBoxList2.Items.Add(li);
                }
                else
                    labText2.Text = "查询用户同时不能超过5个";
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            labText2.Text = "";
            if (!this.CheckBoxList2.SelectedValue.Equals(""))
            {
                if (this.QueryEvent2 != null)
                {
                    this.QueryEvent2(this, EventArgs.Empty);
                }
            }
            else
            {
                labText2.Text = "查询条件错误";
            }
        }
    }
}
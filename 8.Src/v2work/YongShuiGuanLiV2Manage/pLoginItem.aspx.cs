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
using YongShuiGuanLiLib;
using YongShuiGuanLiDBI;

namespace YongShuiGuanLiV2Manage
{
    public partial class pLoginItem : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillWaterUserDDL();
                UserClass u = GetUserClass();
                if (u != null)
                {
                    this.txtUserName.Text = u.Name;
                    this.txtPwd.Text = u.Pwd;
                    this.txtPwd2.Text = u.Pwd;
                    this.cbAllowEdit.Checked = u.AllowEditData;
                    this.txtEditPassword.Text = u.EditPassword;
                    this.ddlRole.SelectedValue = u.Role.RoleValue.ToString();
                    if (!u.IsAdd())
                    {
                        this.ddlWaterUser.SelectedValue = u.WaterUserID.ToString();
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private UserClass GetUserClass()
        {
            //string key = Request.QueryString["key"];
            //UserClass u = Session[key] as UserClass;
            UserClass u = null;

            string s = Request.QueryString["UserID"];
            if (!string.IsNullOrEmpty(s))
            {
                int userid = Convert.ToInt32(s);
                u = UserClass.CreateUser(userid);
            }
            return u;
        }


        /// <summary>
        /// 
        /// </summary>
        private void FillWaterUserDDL()
        {
            OrganizationDataBinder.DataBind(this.ddlWaterUser);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/pLoginList.aspx");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOK_Click(object sender, EventArgs e)
        {
            //UserDBI .AddUser 
            UserClass u = GetUserClass();
            if (u == null)
            {
                u = new UserClass();
            }

            u.Name = this.txtUserName.Text.Trim();
            u.Pwd = this.txtPwd.Text;
            u.WaterUserID = Convert.ToInt32(this.ddlWaterUser.SelectedValue);
            u.AllowEditData = this.cbAllowEdit.Checked;
            u.EditPassword = this.txtEditPassword.Text;
            u.Role = GetRole();
            u.Save();

            Response.Redirect("~/pLoginList.aspx");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private RoleClass GetRole()
        {
            int roleValue = Convert.ToInt32 (this.ddlRole.SelectedValue);
            RoleClass r = new RoleClass(roleValue);
            return r;
        }
    }
}

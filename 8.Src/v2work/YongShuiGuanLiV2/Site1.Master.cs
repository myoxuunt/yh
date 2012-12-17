using System;
using System.Drawing;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace YongShuiGuanLiV2
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Site1 : System.Web.UI.MasterPage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            SetMenuStyles();
            if (SessionManager.LoginSession.IsLogin())
            {
                this.lblLoginInfo.Text = GetLoginInfo();
                // TODO: modify hard code
                //
                if (this.menu1menu.Items.Count == 8)
                {
                    //MenuItem modifyWLMenuItem = this.menu1menu.Items[4];
                    if (!SessionManager.LoginSession.User.AllowEditData)
                    {
                        this.menu1menu.Items.RemoveAt(7);
                        this.menu1menu.Items.RemoveAt(6);
                        this.menu1menu.Items.RemoveAt(5);
                        this.menu1menu.Items.RemoveAt(4);
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string GetLoginInfo()
        {
            LoginSession ls = SessionManager.LoginSession ;
            //string s = string.Format("loginName: {0}, waterUserName: {1}, Level: {2}",
            //    ls.LoginUserName, ls.WaterUser.Name, ls.WaterUser.WaterUserLevel.LevelName);
            string s = string.Format("{0}({1})",ls.LoginUserName, ls.WaterUser.Name);
            return s;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            System.Web.Security.FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }


        /// <summary>
        /// 
        /// </summary>
        public string TitleLabelText
        {
            get { return this.lblTitle.Text; }
            set { this.lblTitle.Text = value; }
        }

        private void SetMenuStyles()
        {
            SetMenuStyle(this.menu0menu);
            SetMenuStyle(this.menu1menu);
            SetMenuStyle(this.menu2menu);
            SetMenuStyle(this.menu3menu);
            SetMenuStyle(this.menu4menu);
            SetMenuStyle(this.menu5menu);
            SetMenuStyle(this.menu6menu);
            SetMenuStyle(this.menu7menu);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="menu"></param>
        private void SetMenuStyle(Menu menu)
        {
            menu.Orientation = Orientation.Horizontal;
            menu.StaticDisplayLevels = 2;
            menu.BackColor = Color.FromArgb(0xe3eaeb);
            menu.DynamicHorizontalOffset = 2;
            menu.Font.Name = "Verdana";
            menu.Font.Size = new FontUnit(12, UnitType.Point);

            menu.StaticSelectedStyle.BackColor = Color.FromArgb(0x666666);
            menu.StaticSelectedStyle.ForeColor = Color.White;
            menu.StaticMenuItemStyle.HorizontalPadding = 5;
            menu.StaticMenuItemStyle.VerticalPadding = 2;

            menu.DynamicHoverStyle.BackColor = Color.FromArgb(0x666666);
            menu.DynamicHoverStyle.ForeColor = Color.White;

            menu.DynamicMenuStyle.BackColor = Color.FromArgb(0xe3eaeb);

            menu.DynamicSelectedStyle.BackColor = Color.FromArgb(0x666666);
            menu.DynamicSelectedStyle.ForeColor = Color.White;

            menu.DynamicMenuItemStyle.HorizontalPadding = 5;
            menu.DynamicMenuItemStyle.VerticalPadding = 2;
            menu.StaticHoverStyle.BackColor = Color.FromArgb(0x666666);
            menu.StaticHoverStyle.ForeColor = Color.White;
        }
    }
}

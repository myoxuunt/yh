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
using YongShuiGuanLiDBI;
using YongShuiGuanLiLib;

namespace YongShuiGuanLiV2Manage
{
    public partial class pCQItem : System.Web.UI.Page
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
                int id = this.StationID;
                if (id > 0)
                {
                    StationClass station = StationFactory.CreateStationByStationID(id);
                    this.txtOldStationName.Text = station.StationName;
                }
            }
        }

        private int StationID
        { 
            get 
            {
                string strID = Request.QueryString["ID"];
                if (!string.IsNullOrEmpty(strID))
                {
                    int result;
                    bool b = int.TryParse(strID, out result);
                    if (b)
                    {
                        return result;        
                    }
                }

                return 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnToParentPage();
        }

        private void ReturnToParentPage()
        {
            string s = "pCQModify.aspx";
            Response.Redirect(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                int id = this.StationID;
                string newName = this.txtNewStationName.Text.Trim();
                StationDBI.UpdateStationName(id, newName);

                ReturnToParentPage();
            }
        }

        protected void cvNewStationName_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = false;

            string newname = this.txtNewStationName.Text.Trim();
            int length = newname.Length;
            if (length > 0)
            {
                int index = newname.IndexOfAny(new char[] { '\'', '"' });
                if (!(index >= 0))
                {
                    if (!StationDBI.Exist(newname, this.StationID))
                    {
                        args.IsValid = true;
                    }
                }
            }
        }
    }
}

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
using System.IO;
using System.Diagnostics;

namespace YongShuiGuanLiV2
{
    public partial class webbaseinfo : System.Web.UI.Page
    {
        private string m_Path = "";
        private StreamReader m_sr;
        protected void Page_Load(object sender, EventArgs e)
        {
            MasterPageHelper.SetTitle(this, "灌区概况");
            if (!Page.IsPostBack)
            {
                if (Request.Params.Count > 0)
                {
                    if (int.Parse(Request.QueryString["para"].ToString()) > 0)
                    {
                        txtBaseInfo.ReadOnly = false;
                        btnEdit.Visible = true;
                        btnCancel.Visible = true;
                    }
                }
                this.txtBaseInfo.Width =900;
                this.txtBaseInfo.Height = 380;
                m_Path = @"C:\Inetpub\wwwroot\BaseText.txt";
                m_sr = new StreamReader(m_Path, System.Text.UnicodeEncoding.Default);
                txtBaseInfo.Text = m_sr.ReadToEnd();
                m_sr.Close();
            }
        }
    }
}

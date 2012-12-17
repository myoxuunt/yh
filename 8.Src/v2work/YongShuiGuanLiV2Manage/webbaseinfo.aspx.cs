using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Diagnostics;

namespace YongShuiGuanLiV2Manage
{
    public partial class webbaseinfo : System.Web.UI.Page
    {
        private string m_Path = "";
        private StreamReader m_sr;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                //if (Request.Params.Count > 0)
                //{
                //    if (int.Parse(Request.QueryString["para"].ToString()) > 0)
                //    {
                        txtBaseInfo.ReadOnly = false;
                        btnEdit.Visible = true;
                        btnCancel.Visible = true;
                //    }
                //}
                this.txtBaseInfo.Width = 700;
                this.txtBaseInfo.Height = 410;
                m_Path = @"C:\Inetpub\wwwroot\BaseText.txt";
                m_sr = new StreamReader(m_Path, System.Text.UnicodeEncoding.Default);
                txtBaseInfo.Text = m_sr.ReadToEnd();
                m_sr.Close();
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            m_Path = @"C:\Inetpub\wwwroot\BaseText.txt";

            StreamWriter sw = new StreamWriter(m_Path, false, System.Text.UnicodeEncoding.Default);
            sw.Write(txtBaseInfo.Text.ToString());
            sw.Close();

            //String scriptString = res_strings.ts_change;
            //RegisterStartupScript("Script", scriptString);

            m_sr = new StreamReader(m_Path, System.Text.UnicodeEncoding.Default);
            txtBaseInfo.Text = m_sr.ReadToEnd();
            m_sr.Close();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //String scriptString = res_strings.ts_change2;
            //RegisterStartupScript("Script", scriptString);

            m_Path = @"C:\Inetpub\wwwroot\BaseText.txt";
            m_sr = new StreamReader(m_Path, System.Text.UnicodeEncoding.Default);
            txtBaseInfo.Text = m_sr.ReadToEnd();
            m_sr.Close();
        }
    }
}

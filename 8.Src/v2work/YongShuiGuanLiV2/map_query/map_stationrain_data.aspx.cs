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

namespace YongShuiGuanLiV2.map_query
{
    public partial class map_stationrain_data : System.Web.UI.Page
    {
        YongShuiGuanLiDBI.station_data st = new YongShuiGuanLiDBI.station_data();
        DataTable dt1 = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ViewState["stationname"] = Request.Params[0].ToString();
                get_data(ViewState["stationname"].ToString());
            }
        }
        private void get_data(string stationid)
        {
            dt1 = st.ditch_stationrain_query(stationid);
            if (dt1.Rows.Count > 0)
            {
                this.stationname.Text = dt1.Rows[0]["stationname"].ToString();
                this.DT.Text = dt1.Rows[0]["DT"].ToString();
                this.RainFill.Text = dt1.Rows[0]["RainFill"].ToString();
            }
        }
    }
}

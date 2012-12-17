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
    public partial class map_station_sluicedata : System.Web.UI.Page
    {
        YongShuiGuanLiDBI.station_data st = new YongShuiGuanLiDBI.station_data();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString.Count > 0)
                    Session["station"] = Request.Params["is_station"].ToString();
                Session["device_id"] = Request.Params["device_id"].ToString();
                get_data(Session["station"].ToString());
            }
        }
        private void get_data(string station)
        {
            dt = st.sluice_station_query(Session["station"].ToString());
            
            if (dt.Rows.Count > 0)
            {
                this.station.Text = dt.Rows[0]["stationname"].ToString();
                this.DT1.Text = dt.Rows[0]["dt"].ToString();
                this.height.Text = dt.Rows[0]["height"].ToString();
                this.beforewl.Text = dt.Rows[0]["beforewl"].ToString();
                this.behindwl.Text = dt.Rows[0]["behindwl"].ToString();
            }
        }
    }
}

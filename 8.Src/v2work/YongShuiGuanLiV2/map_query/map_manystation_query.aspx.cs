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
    public partial class map_manystation_query : System.Web.UI.Page
    {
        YongShuiGuanLiDBI.station_data st = new YongShuiGuanLiDBI.station_data();
        DataTable dt = new DataTable();
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
            //string device_type = "";//设备类型
            //string device_id = "";//设备id
            DataTable _count = new DataTable();
            _count.Columns.Add("stationname");
            _count.Columns.Add("dt");
            _count.Columns.Add("height");
            _count.Columns.Add("beforewl");
            _count.Columns.Add("behindwl");
            string[] ic=stationid.Split(',');
            if (ic.Length> 0)
            {
                for (int i = 0; i < ic.Length; i++)
                {
                    dt = st.sluice_station_query(ic[i].ToString());
                    DataRow dr = _count.NewRow();
                    if (dt.Rows.Count > 0)
                    {
                        dr["stationname"] = dt.Rows[0]["stationname"].ToString();
                        dr["dt"] = dt.Rows[0]["dt"].ToString();
                        dr["height"] = dt.Rows[0]["height"].ToString();
                        dr["beforewl"] = dt.Rows[0]["beforewl"].ToString();
                        dr["behindwl"] = dt.Rows[0]["behindwl"].ToString();
                    }
                    _count.Rows.Add(dr);
                }
            }
            this.DataGrid1.DataSource = _count.DefaultView;
            this.DataGrid1.DataBind();

        }
    }
}

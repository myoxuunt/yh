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
using System.Xml;

namespace YongShuiGuanLiV2.map_query
{
    public partial class map_station_query1 : basepage
    {
        YongShuiGuanLiDBI.station_data st = new YongShuiGuanLiDBI.station_data();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

            }
            link();
        }
        private void link()
        {
            foreach (Control li in this.panel1.Controls)
            {
                if (li is LinkButton)
                {
                    LinkButton btn = (LinkButton)li;
                    string aaa = btn.ID.ToString();
                    btn.Click += new System.EventHandler(this.linkbutton_Click);
                }
            }
        }
        private void linkbutton_Click(object sender, EventArgs e)
        {
            string device_type = "";//设备类型
            string device_id = "";//设备id
            LinkButton ln = sender as LinkButton;
            string stationid = return_stationid(ln.ID);
            if (stationid.Length > 2)//对应多id
            {
                string cc = SecureUrlBase + "/map_query/map_manystation_query.aspx?is_station=" + stationid;
                Response.Write("<script language='javascript'>window.open('" + cc + "','','scrollbars=yes,width=760,height=230,left=200,top=300');</script>");
            }
            else
            {
                dt = st.devicetype(stationid);
                if (dt.Rows.Count > 0)
                {
                    device_type = dt.Rows[0]["devicetype"].ToString();
                    device_id = dt.Rows[0]["deviceid"].ToString();
                    int type = st.type(device_type);
                    if (type == 1)//闸控
                    {
                        string cc = SecureUrlBase + "/map_query/map_station_sluicedata.aspx?is_station=" + stationid + "&device_id=" + device_id;
                        Response.Write("<script language='javascript'>window.open('" + cc + "','','scrollbars=yes,width=550,height=230,left=300,top=300');</script>");
                    }
                    else if (type == 2)
                    {
                        string cc = SecureUrlBase + "/map_query/map_station_data.aspx?is_station=" + stationid + "&device_id=" + device_id;
                        Response.Write("<script language='javascript'>window.open('" + cc + "','','scrollbars=yes,width=550,height=210,left=300,top=300');</script>");
                    }
                    else if (type == 3)//雨量
                    {
                        string cc = SecureUrlBase + "/map_query/map_stationrain_data.aspx?is_station=" + stationid;
                        Response.Write("<script language='javascript'>window.open('" + cc + "','','scrollbars=yes,width=480,height=175,left=200,top=300');</script>");
                    }
                }
            }

        }
        private string return_stationid(string linkid)
        {
            string stationid = "";
            XmlDocument doc = new XmlDocument();
            string m_Path = Server.MapPath("~");
            doc.Load(m_Path + "/xml/station1.xml");

            XmlNodeList nodes = doc.SelectNodes("/station");
            for (int i = 0; i < nodes.Count; i++)
            {
                XmlNodeList nls = nodes[i].ChildNodes;
                for (int j = 0; j < nls.Count; j++)
                {
                    string _station = nls[j].SelectSingleNode("name").InnerText;

                    if (_station == linkid)
                    {
                        stationid = nls[j].SelectSingleNode("id").InnerText;
                        return stationid;
                    }
                }
            }
            return stationid;
        }
    }
}

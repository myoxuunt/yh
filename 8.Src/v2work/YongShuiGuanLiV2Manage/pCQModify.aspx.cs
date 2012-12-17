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
using Xdgk.UI;

namespace YongShuiGuanLiV2Manage
{
    public partial class pCQModify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Xdgk.UI.GridViewHelper h = new Xdgk.UI.GridViewHelper(this.GridView1);

            this.GridView1.RowEditing += new GridViewEditEventHandler(GridView1_RowEditing);
            this.GridView1.DataKeyNames = new string[] { YongShuiGuanLiDBI.DBNames.vStationDevice.StationID };
            if (!IsPostBack)
            {
                h.GridViewConfig = GetViewConfig();
                YongShuiGuanLiDBI.GridViewHelper.AddEditColumn(this.GridView1);
            }

            //GridViewHelper.AddEditDeleteColumn(this.GridView1);

            DataTable t = StationDBI.GetStationDataTable(DeviceTypeDefine.CQDeviceTypes);

            ////this.GridView1.DataSource = t;
            //this.GridView1.DataBind();
            h.DataSource = t;
            h.Bind();
        }

        void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            object obj = this.GridView1.DataKeys[e.NewEditIndex].Value;
            int id = Convert.ToInt32(obj);
            string s = string.Format ("pCQItem.aspx?ID={0}", id);
            Response.Redirect (s);
        }

         /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private GridViewConfig GetViewConfig()
        {
            Xdgk.UI.GridViewConfig c = new GridViewConfig();
            c.Width = 600;
            c.GridViewColumnConfigCollection.AddBoundField("站名", YongShuiGuanLiDBI.DBNames.vStationDevice.StationName );
            c.GridViewColumnConfigCollection.AddBoundField("类型", YongShuiGuanLiDBI.DBNames.vStationDevice.DeviceType);
            return c;
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            DataTable tbl = this.GridView1.DataSource as DataTable;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int idx = e.Row.RowIndex;
                string type = tbl.Rows[idx]["DeviceType"].ToString();

                e.Row.Cells[1].Text = DeviceTypeDefine.GetDeviceTypeText(type);
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class DeviceTypeDefine
    {
        static public string[] CQWater = new string[] { "CQWater" };
        static public string[] CQRain = new string[] { "CQRain" };
        static public string[] CQDeviceTypes = new string[] { CQWater[0], CQRain[0] };


        internal static string GetDeviceTypeText(string type)
        {
            Hashtable ht = new Hashtable();
            ht.Add(CQWater[0], "水位");
            ht.Add(CQRain[0], "雨量");

            object obj = ht[type];
            if (obj != null)
            {
                return obj.ToString();
            }
            else
            {
                return type;
            }
        }
    }
}

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
using YongShuiGuanLiDBI;

namespace YongShuiGuanLiV2
{
    public partial class InOutStationSelect : System.Web.UI.Page
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
                Bind();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void Bind()
        {
            DeviceCollection devices = DeviceFactory.CreateDeviceCollection();
            //DeviceFactory
            this.clStation.DataSource = devices;
            this.clStation.DataTextField = "StationName";
            this.clStation.DataValueField = "DeviceID";
            this.clStation.DataBind();


            DeviceCollection inOutDevices = GetInOrOutDeviceCollection();
            foreach (DeviceClass d in inOutDevices)
            {
                foreach (ListItem item in clStation.Items)
                {
                    if (d.DeviceID == Convert.ToInt32 (item.Value))
                    {
                        item.Selected = true;
                    }
                }
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        private void Redirect()
        {
            //WaterUserLevelEnum le = SessionManager.WaterUserSession.WaterUser.WaterUserLevelEnum;
            //WaterUserLevelEnum le = WaterUserLevelEnum.User;
            string s = "WaterUser.aspx";
            //switch (le)
            //{
            //    case WaterUserLevelEnum.Ju:
            //        s = "GuanLiJu.aspx";
            //        break;
            //    case WaterUserLevelEnum.Chu:
            //        s = "GuanLiChu.aspx";
            //        break;
            //    case WaterUserLevelEnum.User:
            //        s = "WaterUser.aspx";
            //        break;
            //    default :
            //        throw new InvalidOperationException("WaterUserLevelEnum: " + le);
            //}
            Response.Redirect(s);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Redirect();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOK_Click(object sender, EventArgs e)
        {
            DeviceCollection cs = GetInOrOutDeviceCollection();
            cs.Clear();

            foreach (ListItem li in this.clStation.Items)
            {
                if (li.Selected)
                {
                    int id = Convert.ToInt32(li.Value);
                    DeviceClass device = DeviceFactory.CreateDevice(id);
                    cs.Add(device);
                }
            }
            Redirect();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private DeviceCollection GetInOrOutDeviceCollection()
        {
            DeviceCollection cs = null;
            if (IsIN())
            {
                cs = SessionManager.WaterUserSession.WaterUser.InDeviceCollection;
            }
            else
            {
                cs = SessionManager.WaterUserSession.WaterUser.OutDeviceCollection;
            }
            return cs;
        }

        /// <summary>
        /// 
        /// </summary>
        private bool IsIN()
        {
            string inout = Request.QueryString["InOut"];
            if (Xdgk.Common.StringHelper.Equal(inout, "in"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

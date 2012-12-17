using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using YongShuiGuanLiDBI;

namespace YongShuiGuanLiV2
{
    /// <summary>
    /// 
    /// </summary>
    public class OrganizationDataBinder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ddl"></param>
        static public void DataBind(DropDownList ddl)
        {
            object obj = GetOrganizationDataSource();
            if (obj != null)
            {
                ddl.DataSource = obj;
                ddl.DataTextField = "Name";
                ddl.DataValueField = "id";
                ddl.DataBind();
            }
        }

        /// <summary>
        /// 绑定某用水户的下一级用水户到DropDownList
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="ddl"></param>
        static public void BindLowLevelWaterUser(WaterUserClass parent, DropDownList ddl)
        {
            if (parent == null)
            {
                throw new ArgumentNullException("parent");
            }
            if (ddl == null)
            {
                throw new ArgumentNullException("ddl");
            }

            NameIDPairCollection nips = new NameIDPairCollection();
            foreach (WaterUserClass w in parent.LowLevelWaterUserCollection)
            {
                NameIDPair ni = new NameIDPair(w.Name, w.WaterUserID);
                nips.Add(ni);
            }

            ddl.DataSource = nips;
            ddl.DataTextField = "Name";
            ddl.DataValueField = "id";
            ddl.DataBind();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="cbl"></param>
        static public void BindLowLevelWaterUser(WaterUserClass parent, CheckBoxList cbl)
        {
            if (parent == null)
            {
                throw new ArgumentNullException("parent");
            }
            if (cbl == null)
            {
                throw new ArgumentNullException("ddl");
            }

            NameIDPairCollection nips = new NameIDPairCollection();
            foreach (WaterUserClass w in parent.LowLevelWaterUserCollection)
            {
                NameIDPair ni = new NameIDPair(w.Name, w.WaterUserID);
                nips.Add(ni);
            }

            cbl.DataSource = nips;
            cbl.DataTextField = "Name";
            cbl.DataValueField = "id";
            cbl.DataBind();
        }

        #region GetOrganizationDataSource
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static private object GetOrganizationDataSource()
        {
            LoginSession ls = SessionManager.LoginSession;
            WaterUserClass wu = ls.WaterUser;

            if (wu != null)
            {
                // 2011-06-19
                // 只获取本单位用水户列表, 不获取本单位的下级单位
                //
                //DataTable tbl = WaterUserDBI.GetManagementOrganization(ls.WaterUser.WaterUserID,
                //    ls.WaterUser.WaterUserLevel.LevelOrdinal);
                //NameIDPairCollection c = NameIDPairFactory.Create(tbl, "WaterUserName", "WaterUserID");

                NameIDPairCollection c = new NameIDPairCollection();
                NameIDPair pair = new NameIDPair(wu.Name, wu.WaterUserID);
                c.Add(pair);
                return c;
            }
            else
            {
                return null;
            }
        }
        #endregion //GetOrganizationDataSource
    }




    /// <summary>
    /// 
    /// </summary>
    public class StationDataBinder
    {
        static public void DataBind(DropDownList ddlStation, DropDownList ddlOrganization)
        {
            DataBind(ddlStation, ddlOrganization, true);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ddlStation"></param>
        /// <param name="ddlOrganization"></param>
        static public void DataBind(DropDownList ddlStation, DropDownList ddlOrganization, bool isAddAll)
        {
            if (ddlOrganization.SelectedValue != string.Empty)
            {
                int selectedOrganizationID = int.Parse(ddlOrganization.SelectedValue);
                DataBind(ddlStation, selectedOrganizationID, isAddAll);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ddl"></param>
        /// <param name="organizationID"></param>
        static public void DataBind(DropDownList ddl, int organizationID)
        {
            DataBind(ddl, organizationID, true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ddl"></param>
        static public void DataBind(DropDownList ddl, int organizationID, bool isAddAll)
        {
            ddl.DataSource = GetStationDataSource(organizationID, isAddAll);
            ddl.DataTextField = "Name";
            ddl.DataValueField = "id";
            ddl.DataBind();
        }


        #region GetStationDataSource
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static private object GetStationDataSource(int orgaizationID, bool isAddAll)
        {
            //int waterUserID = GetSelectedOrganizationID();
            int waterUserID = orgaizationID;

            DataTable tbl = StationDeviceDBI.GetStationDeviceDataTable(waterUserID);
            // 2011-06-03 stationname -> stationID
            //
            NameIDPairCollection c = NameIDPairFactory.Create(tbl, "StationName", "StationID");
            if (isAddAll)
            {
                c.Insert(0, NameIDPair.ALL);
            }
            return c;
        }
        #endregion //GetStationDataSource
    }


    /// <summary>
    /// 
    /// </summary>
    public class WaterUserDataBinder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cbl"></param>
        static public void DataBind(WaterUserClass parentWaterUser, CheckBoxList cbl)
        {
            if (parentWaterUser == null)
            {
                return;
            }

            object ds = parentWaterUser.LowLevelWaterUserCollection;
            cbl.DataSource = ds;
            cbl.DataTextField = "Name";
            cbl.DataValueField = "WaterUserID";
            cbl.DataBind();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parentWaterUser"></param>
        /// <param name="ddl"></param>
        static public void DataBind(WaterUserClass parentWaterUser, DropDownList ddl)
        {
            if (parentWaterUser == null)
            {
                return;
            }

            object ds = parentWaterUser.LowLevelWaterUserCollection;
            ddl.DataSource = ds;
            ddl.DataTextField = "Name";
            ddl.DataValueField = "WaterUserID";
            ddl.DataBind();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ChannelDataBinder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wu"></param>
        /// <param name="ddl"></param>
        static public void DataBind(WaterUserClass wu, DropDownList ddlChannel)
        {
            ListItemCollection ds = new ListItemCollection();
            foreach (ChannelClass c in wu.ChannelCollection)
            {
                string id = c.ChannelID.ToString();
                string name = c.ChannelName;
                ListItem li = new ListItem();
                li.Text = name;
                li.Value = id;
                ds.Add(li);
            }
            ddlChannel.DataTextField = "Text";
            ddlChannel.DataValueField = "Value";
            ddlChannel.DataSource = ds;
            ddlChannel.DataBind();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="channelID"></param>
        /// <param name="cblStation"></param>
        /// <param name="deviceTypes"></param>
        static public void StationOfChannelBind(int channelID, CheckBoxList cblStation, string[] deviceTypes)
        {
            StationOfChannelBind(channelID, cblStation, deviceTypes, true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="channelID"></param>
        /// <param name="cblStation"></param>
        /// <param name="deviceTypes"></param>
        /// <param name="isSelected"></param>
        static public void StationOfChannelBind(int channelID, CheckBoxList cblStation, string[] deviceTypes, bool isSelected)
        {
            ChannelClass ch = ChannelFactory.CreateChannel(channelID);
            if (ch != null)
            {
                StationCollection sts = ch.StationCollection.GetStationCollection(deviceTypes);

                ListItemCollection stationList = GetStationListItemCollection(sts);
                cblStation.DataTextField = "Text";
                cblStation.DataValueField = "Value";
                cblStation.DataSource = stationList;
                cblStation.DataBind();

                foreach (ListItem stitem in cblStation.Items)
                {
                    stitem.Selected = isSelected;
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="channelID"></param>
        /// <param name="cblStation"></param>
        static public void StationOfChannelBind(int channelID, CheckBoxList cblStation)
        {
            StationOfChannelBind(channelID, cblStation, true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="channelID"></param>
        /// <param name="cblStation"></param>
        /// <param name="isSelected"></param>
        static public void StationOfChannelBind(int channelID, CheckBoxList cblStation, bool isSelected)
        {
            //ListItem item = this.ddlChannel.SelectedItem;
            //if (item != null)
            //{
            //int id = int.Parse(item.Value);
            //WaterUserClass wu = GetWaterUser();
            //if (wu != null)
            //{
            //ChannelClass ch = wu.ChannelCollection.GetChannelByID(id);
            ChannelClass ch = ChannelFactory.CreateChannel(channelID);
            if (ch != null)
            {
                ListItemCollection stationList = GetStationListItemCollection(ch.StationCollection);
                cblStation.DataTextField = "Text";
                cblStation.DataValueField = "Value";
                cblStation.DataSource = stationList;
                cblStation.DataBind();

                foreach (ListItem stitem in cblStation.Items)
                {
                    stitem.Selected = isSelected;
                }
            }
            //}
            //}
        }


        #region GetStationListItemCollection
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stations"></param>
        /// <returns></returns>
        static private ListItemCollection GetStationListItemCollection(StationCollection stations)
        {
            ListItemCollection r = new ListItemCollection();
            foreach (StationClass s in stations)
            {
                int id = s.StationID;
                string name = s.StationName;
                ListItem item = new ListItem(name, id.ToString());
                //item.Selected = true;
                r.Add(item);
            }
            return r;
        }
        #endregion //GetStationListItemCollection
    }
}

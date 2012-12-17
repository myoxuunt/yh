using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Web.UI.WebControls;
using Xdgk.Common;
using YongShuiGuanLiDBI;

namespace YongShuiGuanLiLib
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
            ddl.DataSource = GetOrganizationDataSource();
            ddl.DataTextField = "Name";
            ddl.DataValueField = "id";
            ddl.DataBind();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ddl"></param>
        static public void DataBind(DropDownList ddl, WaterUserClass waterUser)
        {
            if (waterUser == null)
            {
                throw new ArgumentNullException("waterUser");
            }

            ddl.DataSource = GetOrganizationDataSource(waterUser);
            ddl.DataTextField = "Name";
            ddl.DataValueField = "id";
            ddl.DataBind();
        }

        #region GetOrganizationDataSource
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static private object GetOrganizationDataSource()
        {
            DataTable tbl = WaterUserDBI.GetWaterUserDataTable();
            NameIDPairCollection c = NameIDPairFactory.Create(tbl, "WaterUserName", "WaterUserID");
            return c;
        }

        static private object GetOrganizationDataSource(WaterUserClass waterUser)
        {
            //LoginSession ls = SessionManager.LoginSession;
            //DataTable tbl = WaterUserDBI.GetManagementOrganization(ls.WaterUser.WaterUserID,
            DataTable tbl = WaterUserDBI.GetManagementOrganization(waterUser.WaterUserID,

                waterUser.WaterUserLevel.LevelOrdinal);
            NameIDPairCollection c = NameIDPairFactory.Create(tbl, "WaterUserName", "WaterUserID");
            return c;
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
            int selectedOrganizationID = int.Parse(ddlOrganization.SelectedValue);
            DataBind(ddlStation, selectedOrganizationID, isAddAll);
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
            NameIDPairCollection c = NameIDPairFactory.Create(tbl, "StationName", "DeviceID");
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
    public class NameIDPair
    {
        /// <summary>
        /// 
        /// </summary>
        static public NameIDPair ALL = new NameIDPair("<全部>", 0);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        public NameIDPair(string name, int id)
        {
            this.Name = name;
            this.ID = id;
        }

        #region Name
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get
            {
                if (_name == null)
                {
                    _name = string.Empty;
                }
                return _name;
            }
            set
            {
                _name = value;
            }
        } private string _name;
        #endregion //Name

        #region ID
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            get
            {
                return _iD;
            }
            set
            {
                _iD = value;
            }
        } private int _iD;
        #endregion //ID

    }


    /// <summary>
    /// 
    /// </summary>
    public class NameIDPairCollection : Xdgk.Common.Collection<NameIDPair>
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public class NameIDPairFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tbl"></param>
        /// <param name="nameColumn"></param>
        /// <param name="idColumn"></param>
        /// <returns></returns>
        static public NameIDPairCollection Create(DataTable tbl, string nameColumn, string idColumn)
        {
            NameIDPairCollection c = new NameIDPairCollection();
            foreach (DataRow row in tbl.Rows)
            {
                string name = row[nameColumn].ToString().Trim();
                int id = Convert.ToInt32(row[idColumn]);
                NameIDPair n = new NameIDPair(name, id);
                c.Add(n);
            }
            return c;
        }
    }


    /// <summary>
    /// 
    /// </summary>
    public class ValidatorMessageCreater
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vaildator"></param>
        static public void CreateSQLDateTimeMessage(CustomValidator validator)
        {
            if( validator == null )
            {
                throw new ArgumentNullException("validator");
            }
            validator.Text = "*";
            validator.ErrorMessage = "无效的时间格式";
          
        }
    }



    /// <summary>
    /// 
    /// </summary>
    public class DateTimeHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public DateTime GetYesterday()
        {
            DateTime dt = DateTime.Today - TimeSpan.FromDays(1d);
            return dt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public DateTime GetTomorrow()
        {
            DateTime dt = DateTime.Today + TimeSpan.FromDays(1d);
            return dt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        static public DateTime GetDateWithBeginTime(DateTime dt)
        {
            return dt.Date;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        static public DateTime GetDateWithEndTime(DateTime dt)
        {
            return dt.Date + TimeSpan.Parse("23:59:59");
        }
    }
}

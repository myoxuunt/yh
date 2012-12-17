using System;
using System.Collections.Generic;
using System.Text;
using System.Data ;
using System.Data.SqlClient;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class WaterUserDBI
    {

        #region InsertWaterUser
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        static public void InsertWaterUser(string name, string remark, int waterUserTypeID,
            bool hasParentWaterUser, int parentWaterUserID, int waterUserLevelID)
        {
            string s = @"insert into tblWaterUser(waterUserName, Remark, waterUserTypeID, parentWaterUserID, waterUserLevelID) 
                        values(@name, @remark, @waterUserTypeID, @parentWaterUserID, @waterUserLevelID)";

            SqlCommand cmd = new SqlCommand(s);
            DBI.AddSqlParameter(cmd, "name", name);
            DBI.AddSqlParameter(cmd, "remark", remark);

            DBI.AddSqlParameter(cmd, "waterUserTypeID", waterUserTypeID);

            // TODO:
            //
            if (hasParentWaterUser)
            {
                DBI.AddSqlParameter(cmd, "parentWaterUserID", parentWaterUserID);
            }
            else
            {
                DBI.AddSqlParameter(cmd, "parentWaterUserID", DBNull.Value);
            }

            DBI.AddSqlParameter(cmd, "waterUserLevelID", waterUserLevelID);

            DBI.GetDBI().ExecuteScalar(cmd);

            int waterUserID = GetWaterUserID(name);

        }
        #endregion //InsertWaterUser


        #region AssocicateWaterUserStationIn
        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserID"></param>
        /// <param name="stations"></param>
        static public void AssocicateWaterUserStationIn(int waterUserID, StationCollection stations)
        {
            DeleteWaterUserStationIN(waterUserID);
        }
        #endregion //AssocicateWaterUserStationIn


        #region AssociateWaterUserStationOut
        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserID"></param>
        /// <param name="stations"></param>
        static public void AssociateWaterUserStationOut(int waterUserID, StationCollection stations)
        {

        }
        #endregion //AssociateWaterUserStationOut


        #region DeleteWaterUserStationIN
        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserID"></param>
        static public void DeleteWaterUserStationIN(int waterUserID)
        {
            string s = string.Format("delete from tblIN where wateruserID = {0}", waterUserID);
            DBI.GetDBI().ExecuteScalar(s);
        }
        #endregion //DeleteWaterUserStationIN


        #region DeleteWaterUserStationOut
        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserID"></param>
        static public void DeleteWaterUserStationOut(int waterUserID)
        {
            string s = string.Format("delete from tblOut where wateruserID = {0}", waterUserID);
            DBI.GetDBI().ExecuteScalar(s);
        }
        #endregion //DeleteWaterUserStationOut


        #region GetWaterUserID
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        static public int GetWaterUserID(string name)
        {
            string s = "select wateruserID from tblWaterUser where wateruserName = @n";

            SqlCommand cmd = new SqlCommand(s);
            DBI.AddSqlParameter(cmd, "n", name);
            object obj = DBI.GetDBI().ExecuteScalar(cmd);
            if (obj == null || obj == DBNull.Value)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        #endregion //GetWaterUserID


        #region UpdateWaterUser
        /// <summary>
        /// 
        /// </summary>
        static public void UpdateWaterUser(int id, string newName, string newRemark, int waterUserTypeID, bool hasParent,
            int parentWaterUserID, int waterUserLevelID)
        {
            string s = @"update tblWaterUser set 
                    waterUserName = @name, 
                    Remark = @remark, 
                    waterUserTypeID = @waterUserTypeID,
                    parentWaterUserid = @parentWaterUserID, 
                    waterUserLevelID = @waterUserLevelID
                    where WaterUserID = @id";

            SqlCommand cmd = new SqlCommand(s);
            DBI.AddSqlParameter(cmd, "id", id);
            DBI.AddSqlParameter(cmd, "name",newName);
            DBI.AddSqlParameter(cmd, "remark", newRemark);
            DBI.AddSqlParameter(cmd, "waterUserTypeID", waterUserTypeID);

            // TODO:
            //
            if (hasParent)
            {
                DBI.AddSqlParameter(cmd, "parentWaterUserID", parentWaterUserID);
            }
            else
            {
                DBI.AddSqlParameter(cmd, "parentWaterUserID", DBNull.Value);
            }
            DBI.AddSqlParameter(cmd, "waterUserLevelID", waterUserLevelID);

            //DBI.AddSqlParameter(cmd, "", );
            
            DBI.GetDBI().ExecuteScalar(cmd);
        }
        #endregion //UpdateWaterUser


        #region DeleteWaterUser
        /// <summary>
        /// 
        /// </summary>
        static public void DeleteWaterUser(int id)
        {
            string s = string.Format("delete from tblWaterUser where wateruserid = {0}",
                id);
            DBI.GetDBI().ExecuteScalar(s);
        }
        #endregion //DeleteWaterUser


        //#region GetWaterUserDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public DataTable GetWaterUserDataTable()
        {
            string s = "select * from vWaterUser";
            return DBI.GetDBI().ExecuteDataTable(s);
        }


        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="levelOrdinal"></param>
        ///// <returns></returns>
        //static public DataTable GetWaterUserDataTable(int minLevelOrdinal)
        //{
        //    string s = "select * from vWaterUser where ordinal >= {0}";
        //    return DBI.GetDBI().ExecuteDataTable(s);
        //}
        //#endregion //GetWaterUserDataTable




        #region GetLowLevelWaterUserDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserID"></param>
        /// <returns></returns>
        static public DataTable GetLowLevelWaterUserDataTable(int waterUserID)
        {
            string s = string.Format(
                "select * from tblWaterUser where deleted = 0 and ParentWaterUserID = {0}",
               waterUserID  );
            return DBI.GetDBI().ExecuteDataTable(s);
        }
        #endregion //GetLowLevelWaterUserDataTable



        #region GetWaterUserDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserID"></param>
        /// <returns></returns>
        static public DataTable GetWaterUserDataTable(int waterUserID)
        {
            string s = string.Format ("select * from tblWaterUser where deleted = 0 and waterUserID = {0}",
                waterUserID);
            return DBI.GetDBI().ExecuteDataTable(s);
        }
        #endregion //GetWaterUserDataTable

        /// <summary>
        /// 
        /// </summary>
        /// <param name="levelEnum"></param>
        /// <returns></returns>
        static public DataTable GetWaterUserDataTable(WaterUserLevelEnum levelEnum)
        {
            int levelID = WaterUserLevelDBI.GetWaterUserLevelID(levelEnum);
            string s = string.Format ("select * from tblWaterUser where deleted = 0 and waterUserLevelID = {0}",
                levelID);
            DataTable tbl = DBI.GetDBI().ExecuteDataTable(s);
            return tbl;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="le"></param>
        /// <returns></returns>
        static public bool HasWaterUser(WaterUserLevelEnum le)
        {
            DataTable tbl = GetWaterUserDataTable(le);
            return tbl.Rows.Count > 0;
        }

        ///// <summary>
        ///// 管理单位级别
        ///// </summary>
        //private const int ManagementOrganizationLevelNumber = 2;


        #region GetManagementOrganization
        /// <summary>
        /// 获取管理单位
        /// </summary>
        /// <returns></returns>
        public static DataTable GetManagementOrganization()
        {
            // 不再区分是否为管理单位
            //
            //string s = string.Format ("select * from vWaterUser where ordinal >= {0}", 
            //    ManagementOrganizationLevelNumber );

            string s = string.Format("select * from vWaterUser");
            return DBI.GetDBI().ExecuteDataTable(s);
        }
        #endregion //GetManagementOrganization


        #region GetManagementOrganization
        /// <summary>
        /// 获取低于某个用户的管理单位
        /// </summary>
        /// <param name="waterUserID"></param>
        /// <param name="waterUserLevelNumber"></param>
        /// <returns></returns>
        public static DataTable GetManagementOrganization( int waterUserID, int waterUserLevelNumber)
        {
            //string s = string.Format(
            //    "select * from vWaterUser where ( ordinal >= {0} ) and (ordinal < {1} or WaterUserID = {2})",
            //    ManagementOrganizationLevelNumber ,
            //    waterUserLevelNumber,
            //    waterUserID
            //    );

            string s = string.Format(
                "select * from vWaterUser where (ordinal < {0} or WaterUserID = {1})",
                waterUserLevelNumber,
                waterUserID
                );

            return DBI.GetDBI().ExecuteDataTable(s);
        }
        #endregion //GetManagementOrganization

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newWaterUserName"></param>
        /// <param name="p"></param>
        public static bool ExistWaterUserName(string newWaterUserName, int ignoreID)
        {
            string s = "select count(*) from tblWaterUser " + 
                "where waterUsername = @waterUserName and waterUserID <> @ignoreID and deleted = 0";

            SqlCommand cmd = new SqlCommand(s);
            DBI.AddSqlParameter(cmd, "waterUserName", newWaterUserName);
            DBI.AddSqlParameter(cmd, "ignoreID", ignoreID);

            object obj = DBI.GetDBI().ExecuteScalar(cmd);
            int count = Convert.ToInt32(obj);
            return count > 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        internal static int GetParentWaterUserID(int waterUserID)
        {
            int parentWaterUserID = 0;
            string s = string.Format(
                "select parentWaterUserID from tblWaterUser where waterUserID = {0}",
                waterUserID);

            object v = DBI.GetDBI().ExecuteScalar(s);
            if (v != DBNull.Value)
            {
                parentWaterUserID = Convert.ToInt32(v);
            }
            return parentWaterUserID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="roleValue"></param>
        public void UpdateRole(int waterUserID, int roleValue)
        {
            string s = string.Format(
                "update tblWaterUser set role = {0} where waterUserID = {1}",
                waterUserID, roleValue);

            DBI.GetDBI().ExecuteScalar(s);
        }
    }
}

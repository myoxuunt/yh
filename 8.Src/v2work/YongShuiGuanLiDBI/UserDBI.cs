using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class UserDBI
    {

        /// <summary>
        /// add user return id
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <param name="WaterUserID"></param>
        /// <returns>0 - fail, otherwise - success</returns>
        static public int AddUser(string name, string pwd, int WaterUserID, int role, bool allowEdit, string editPassword)
        {
            //string s = string.Format("INSERT INTO tb_User( [Name], [Password], [role_id], [WaterUserID]) " +
            //    " VALUES(@name, @pwd, 1, @waterUserID)");

            string s = string.Format("INSERT INTO tb_User( [Name], [Password], [WaterUserID], role, allowEdit, editPassword) " +
                " VALUES(@name, @pwd, @waterUserID, @role, @allowEdit, @editPassword)");

            SqlCommand cmd = new SqlCommand(s);
            DBI.AddSqlParameter(cmd, "name", name);
            DBI.AddSqlParameter(cmd, "pwd", pwd);
            DBI.AddSqlParameter(cmd, "waterUserID", WaterUserID);
            DBI.AddSqlParameter(cmd, "role", role);
            DBI.AddSqlParameter(cmd, "allowEdit", allowEdit);
            DBI.AddSqlParameter(cmd, "editPassword", editPassword);

            DBI.GetDBI().ExecuteScalar(cmd);
            return GetUserID(name);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        static public int GetUserID(string name)
        {
            string s = "select userID from tb_user where name = @name";
            SqlCommand cmd = new SqlCommand(s);
            DBI.AddSqlParameter(cmd, "name", name);
            object obj = DBI.GetDBI().ExecuteScalar(cmd);
            if (obj != null && obj != DBNull.Value)
            {
                return Convert.ToInt32(obj);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <param name="waterUserID"></param>
        static public void UpdateUser(int userID, string name, string pwd, int waterUserID, 
            int role, bool allowEdit, string editPassword)
        {
            string s = string.Format(
                "update tb_User set [Name] = @name, [Password] = @pwd,  " + 
                "[WaterUserID] = @waterUserID, Role = @role, AllowEdit = @allowEdit, " +
                "editPassword = @editPassword " +
                "where userid = " + userID);

            SqlCommand cmd = new SqlCommand(s);
            DBI.AddSqlParameter(cmd, "name", name);
            DBI.AddSqlParameter(cmd, "pwd", pwd);
            DBI.AddSqlParameter(cmd, "waterUserID", waterUserID);
            DBI.AddSqlParameter(cmd, "role", role);
            DBI.AddSqlParameter(cmd, "allowEdit", allowEdit);
            DBI.AddSqlParameter(cmd, "editPassword", editPassword);

            DBI.GetDBI().ExecuteScalar(cmd);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userID"></param>
        static public void DeleteUser( int userID )
        {
            string s = "delete from tb_user where userid = " + userID;
            DBI.GetDBI().ExecuteScalar(s);
        }


        /// <summary>
        /// 获取登陆用户表
        /// </summary>
        /// <returns></returns>
        static public DataTable GetUserDataTable()
        {
            string s = string.Format("select * from vUserWaterUser");
            return DBI.GetDBI().ExecuteDataTable(s);
        }

        static public DataTable GetUserDataTable(int userID)
        {
            string s = string.Format("select * from vUserWaterUser where userid = {0}", userID);
            return DBI.GetDBI().ExecuteDataTable(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        static public bool CanLogin(string userName, string password, out int userID, out int waterUserID)
        {
            userID = 0;
            waterUserID = 0;

            string s = "select * from tb_user where name = @n and password = @p";
            SqlCommand cmd = new SqlCommand(s);

            DBI.AddSqlParameter(cmd, "n", userName);
            DBI.AddSqlParameter(cmd, "p", password);


            bool isLogin = false;
            DataTable tbl = DBI.GetDBI().ExecuteDataTable(cmd);
            if (tbl.Rows.Count > 0)
            {
                DataRow row = tbl.Rows[0];
                userID = Convert.ToInt32 (row["userID"]);
                waterUserID = Convert.ToInt32(row["waterUserID"]);
                isLogin = true;
            }

            return isLogin;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Xdgk.Common
{
    #region DBInfoException
    /// <summary>
    /// 
    /// </summary>
    public class DBInfoException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public DBInfoException(string message)
            : base(message)
        {
        }
    }
    #endregion //DBInfoException

    /// <summary>
    /// 
    /// </summary>
    public class DBIBase
    {
        #region static DBIBase
        /// <summary>
        /// 保存近最创建的DBIBase实例
        /// </summary>
        static public DBIBase Instance
        {
            get
            {
                return _DBIBase;
            }
        } static private DBIBase _DBIBase;
        #endregion //static DBIBase

        private string _connString;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connString"></param>
        public DBIBase(string connString)
        {
            this._connString = connString;
            _DBIBase = this;
        }

        ///// <summary>
        ///// 
        ///// </summary>
        //public void Open()
        //{
        //    this._connection = new SqlConnection(_connString);
        //    this._connection.Open();
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        //public void Close()
        //{
        //    this._connection.Close();
        //}

        //#region Connection
        ///// <summary>
        ///// 
        ///// </summary>
        //public SqlConnection Connection
        //{
        //    get { return _connection; }
        //} private SqlConnection _connection;
        //#endregion //Connection

        #region ExecuteDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable ExecuteDataTable(string sql)
        {
            //SqlCommand cmd = this._connection.CreateCommand();
            SqlCommand cmd = new SqlCommand(sql);
            return ExecuteDataTable(cmd);
        }
        #endregion //ExecuteDataTable

        #region ExecuteDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public DataTable ExecuteDataTable(SqlCommand cmd)
        {
            using (SqlConnection cn = new SqlConnection(this._connString))
            {
                cn.Open();
                cmd.Connection = cn;
                DataSet ds = new DataSet();
                SqlDataAdapter sqlda = new SqlDataAdapter(cmd);
                sqlda.Fill(ds);
                return ds.Tables[0];
            }
        }
        #endregion //ExecuteDataTable

        #region ExecuteScalar
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public object ExecuteScalar(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql);
            return ExecuteScalar(cmd);
        }
        #endregion //ExecuteScalar

        #region ExecuteScalar
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public object ExecuteScalar(SqlCommand cmd)
        {
            using (SqlConnection cn = new SqlConnection(this._connString))
            {
                cn.Open();
                cmd.Connection = cn;
                return cmd.ExecuteScalar();
            }
        }
        #endregion //ExecuteScalar

        #region GetDBInfo
        /// <summary>
        /// 获取数据库信息，如不存在返回null
        /// </summary>
        /// <returns></returns>
        public DBInfo GetDBInfo()
        {
            DBInfo dbinfo = null;
            string sql = "select top 1 * from tblDBInfo order by DBInfoID desc";
            DataTable tbl = this.ExecuteDataTable(sql);
            if (tbl.Rows.Count > 0)
            {
                DataRow row = tbl.Rows[0];
                dbinfo = new DBInfo();
                dbinfo.MajorVersion = Convert.ToInt32(row["MajorVersion"]);
                dbinfo.MinorVersion = Convert.ToInt32(row["MinorVersion"]);
                dbinfo.RevisionVersion = Convert.ToInt32(row["RevisionVersion"]);
                dbinfo.Project = row["Project"].ToString().Trim();
                dbinfo.DT = Convert.ToDateTime(row["DT"]);
            }
            return dbinfo;
        }
        #endregion //GetDBInfo


        /// <summary>
        /// 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="majorVersion"></param>
        /// <param name="minorVersion"></param>
        /// <param name="revisionVersion"></param>
        public void VerifyDBInfo(string project, int majorVersion,
            int minorVersion, int revisionVersion)
        {
            DBInfo dbinfo = this.GetDBInfo();

            if (dbinfo == null)
                throw new DBInfoException("not find DBInfo");

            if (StringHelper.Equal(project, dbinfo.Project) &&
                majorVersion == dbinfo.MajorVersion &&
                minorVersion == dbinfo.MinorVersion &&
                revisionVersion == dbinfo.RevisionVersion )
            {
                return;
            }
            else
            {
                string expectedVersion = string.Format("{0}.{1}.{2}", majorVersion, minorVersion, revisionVersion);
                string s = string.Format("Expected project '{0} V{1}', but was '{2} V{3}'",
                    project, expectedVersion, dbinfo.Project, dbinfo.VersionString);
                throw new DBInfoException(s);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetIdentity()
        {
            string sql = "select @@IDENTITY";
            object obj = ExecuteScalar(sql);
            if (obj == DBNull.Value)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
    }
}

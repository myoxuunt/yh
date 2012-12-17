using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;

namespace XDYHZKWeb
{
    /// <summary>
    /// 
    /// </summary>
    public class DBcon
    {
        private string _connstr;
        private SqlConnection _sqlConnect;
        static private DBcon s_instance;

        /// <summary>
        /// 
        /// </summary>
        static public DBcon Instance
        {
            get { return s_instance; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connstr"></param>
        public DBcon(string connstr)
        {
            _connstr = connstr;
            s_instance = this;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Open()
        {
            _sqlConnect = new SqlConnection(_connstr);
            _sqlConnect.Open();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Close()
        {
            _sqlConnect.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable GetDataTable(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, _sqlConnect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            da.Dispose();
            return ds.Tables[0];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public bool ExecuteNonQuery(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, _sqlConnect);
            if (cmd.ExecuteNonQuery() == 1)
                return true;
            else
                return false;
        }
    }
}

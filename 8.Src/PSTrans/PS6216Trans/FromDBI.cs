using System;
using System.Diagnostics;
using System.Data.OleDb;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace PS6216DataImporter
{
    public class FromDBI 
    {
        /// <summary>
        /// 
        /// </summary>
        private string _connstring;

        


        /// <summary>
        /// 
        /// </summary>
        /// <param name="connstring"></param>
        public FromDBI(string connstring)
        {
            this._connstring = connstring;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param deviceType="fromDateTime"></param>
        /// <returns></returns>
        public DataTable ReadNewDataTable(DateTime fromDateTime, string tableNameOfFromDB)
        {
            string s = string.Format(
                "SELECT * FROM [{0}] WHERE (记录时间 > #{1}#) order by 记录时间",
                tableNameOfFromDB,
                fromDateTime
                );
            return ExecuteDataTable(s);
        }

        private DataTable ExecuteDataTable(string sql)
        {
            OleDbConnection con = new OleDbConnection(this._connstring);
            con.Open();
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            con.Close();
            con.Dispose();
            return tbl;
            
        }

        private object ExecuteScalar(string sql)
        {
            OleDbConnection con = new OleDbConnection(this._connstring);
            con.Open();
            OleDbCommand cmd = new OleDbCommand(sql, con);
            object r =  cmd.ExecuteScalar();
            cmd.Dispose();
            con.Close();
            con.Dispose();
            return r;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        internal int ReadFromDeviceID(string name)
        {
            string sql = string.Format(
                "SELECT 设备标识号 FROM t_设备 where [设备名称]='{0}'",
                name);
            object r = ExecuteScalar(sql);
            if (r == null || r == DBNull.Value)
            {
                throw new ArgumentException(
                    string.Format("not find device by name: '{0}'", name)
                    );
            }
            else
            {
                return Convert.ToInt32(r);
            }
        }
    }
}

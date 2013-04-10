using System;
using System.Data.OleDb;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace PS6216DataImporter
{
    public class FromDBI 
    {
        private string _connstring;
        public FromDBI(string connstring)
        {
            this._connstring = connstring;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param deviceType="fromDateTime"></param>
        /// <returns></returns>
        public DataTable ReadNewDataTable(DateTime fromDateTime)
        {
            string s = string.Format(
                "SELECT * FROM [t_设备92记录表] WHERE (记录时间 > #{0}#)",
                fromDateTime);
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
    }
}

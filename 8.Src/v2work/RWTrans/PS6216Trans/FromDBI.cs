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

        
        #region TableNameOfFromDB
        /// <summary>
        /// 平升历史记录表名称
        /// </summary>
        public string TableNameOfFromDB
        {
            get { return _tableNameOfFromDB; }
            set { _tableNameOfFromDB = value; }
        } private string _tableNameOfFromDB;
        #endregion //TableNameOfFromDB

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connstring"></param>
        public FromDBI(string connstring, string tableNameOfFromDB)
        {
            this._connstring = connstring;

            if (string.IsNullOrEmpty(tableNameOfFromDB))
            {
                throw new ArgumentException("tablenameOfFromDB cannot is null or empty");
            }
            this._tableNameOfFromDB = tableNameOfFromDB;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param deviceType="fromDateTime"></param>
        /// <returns></returns>
        public DataTable ReadNewDataTable(DateTime fromDateTime)
        {
            string s = string.Format(
                "SELECT * FROM [{0}] WHERE (记录时间 > #{1}#) order by 记录时间",
                this.TableNameOfFromDB,
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
    }
}

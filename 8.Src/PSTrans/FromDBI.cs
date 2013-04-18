using System;
using System.Data.OleDb;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace RWTrans
{
    public class FromDBI
    {
        private string _connectionString;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString"></param>
        public FromDBI(string connectionString)
        {
            _connectionString = connectionString;
        }

        private DataTable Execute(string sql)
        {
            OleDbConnection con = new OleDbConnection(_connectionString );
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            return tbl;
        }

        public DataTable GetRainStationDataTable()
        {
            string sql = "select * from rainzdsz order by 站点名称";
            return Execute(sql);
        }

        public DataTable GetWaterStationDataTable()
        {
            string sql = "select * from waterzdsz order by 站点名称";
            return Execute(sql);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="from"></param>
        /// <returns></returns>
        public DataTable GetWaterDataTable(string stationNO, DateTime from)
        {
            string sql = string.Format(
                "select * from heightWater where 站点编号 ='{0}' and stringtime > #{1}#", 
                stationNO, 
                from);
            return Execute(sql);
        }


        public DataTable GetRainDataTable(string stationNO, DateTime from)
        {
            string sql = string.Format(
                "select * from fallrain where 站点编号 ='{0}' and stringtime > #{1}#", 
                stationNO, 
                from);
            return Execute(sql);
        }
    }
}

using System;
using System.Collections;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace YongShuiGuanLiV2
{
    /// <summary>
    /// 
    /// </summary>
    public class TClass
    {

        /// <summary>
        /// 
        /// </summary>
        Hashtable _hashTable = new Hashtable();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private DataTable GetTable(string name)
        {
            object obj = _hashTable[name];
            if (obj == null)
            {
                _hashTable[name] = CreateDataTable(name);
                return _hashTable[name] as DataTable;
            }
            else
            {
                return obj as DataTable;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private object CreateDataTable(string name)
        {
            DataTable tbl = new DataTable(name);
            tbl.Columns.Add(CreateColumn("DT", typeof(DateTime)));
            tbl.Columns.Add(CreateColumn("Wl1", typeof(double)));
            tbl.Columns.Add(CreateColumn("instantFlux", typeof(double)));
            return tbl;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private DataColumn CreateColumn(string name, Type type)
        {
            DataColumn dc = new DataColumn();
            dc.ColumnName = name;
            dc.DataType = type;
            return dc;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tbl"></param>
        /// <returns></returns>
        public DataTable[] GetTables(DataTable tbl)
        {
            foreach (DataRow row in tbl.Rows)
            {
                string stationName = row["StationName"].ToString();
                DateTime dt = Convert.ToDateTime(row["DT"]);
                double wl1 = Convert.ToDouble(row["wl1"]);
                double instantFlux = Convert.ToDouble(row["InstantFlux"]);

                DataTable newtbl = GetTable(stationName);
                DataRow newrow = newtbl.NewRow();
                newrow["DT"] = dt;
                newrow["wl1"] = wl1;
                newrow["instantflux"] = instantFlux;
                newtbl.Rows.Add(newrow);
            }

            int i=0;
            DataTable[] list = new DataTable[this._hashTable.Count];
            foreach( object obj in _hashTable.Values )
            {
                list[i++] = obj as DataTable;
            }
            return list;
        }
    }
}

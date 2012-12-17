using System;
using System.Collections.Generic;
using System.Text;

using System.Data ;
namespace YongShuiGuanLiDBI
{
    public class DebugDBI
    {
        static public DataTable Execute(string sql)
        {
            DBI dbi = DBI.GetDBI();
            return dbi.ExecuteDataTable(sql);
        }
    }
}

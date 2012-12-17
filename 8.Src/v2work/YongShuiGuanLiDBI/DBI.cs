using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Common;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    internal class DBI : DBIBase 
    {
        internal DBI(string conn)
            : base(conn)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static internal DBI GetDBI()
        {
            if (_dbi == null)
            {
                // 
                //
                //string conn = "server=192.168.1.32;initial catalog=YeHeSLDB;user=sa;password=sa";
                string conn = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
                _dbi = new DBI(conn);
            }
            return _dbi;
        }
        static internal DBI GetDBI_wmgis()
        {
            if (_d1 == null)
            {
                // 
                //
                //string conn = "server=WWW-9B16331897D/SQL2005;initial catalog=wmgis;user=sa;password=1";
                string conn = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString_wmgis"];
                _d1 = new DBI(conn);
            }
            return _d1;
        }
        static private DBI _d1;
        static internal DBI GetDBI_yhxx()
        {
            if (_d2 == null)
            {
                // 
                //
                //string conn = "server=192.168.1.32;initial catalog=YeHeSLDB;user=sa;password=sa";
                string conn = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString_yhxx"];
                _d2 = new DBI(conn);
            }
            return _d2;
        }
        static private DBI _d2;
        static private DBI _dbi;
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using Xdgk.Common;

namespace YHZKPort
{
    /// <summary>
    /// 
    /// </summary>
    public class YHZKPortDBI : DBIBase 
    {
        /// <summary>
        /// 
        /// </summary>
        static public YHZKPortDBI  Default
        {
            get
            {
                if (s_default == null)
                {
                    string connStr = ConfigurationSettings.AppSettings["ConnectionString"];
                    s_default = new YHZKPortDBI(connStr);
                    //s_default.Open();
                }
                return s_default;
            }
        } static private YHZKPortDBI s_default;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connString"></param>
        public YHZKPortDBI(string connString) :
            base(connString)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lastDT"></param>
        /// <returns></returns>
        public DataTable ExecuteSlucieDataDataTable(DateTime lastDT)
        {
            string sql = string.Format (
                "select top 30 * from vSluiceData where dt > '{0}' order by DT", lastDT);
            DataTable tbl = Default.ExecuteDataTable(sql);
            return tbl;
        }
    }
}

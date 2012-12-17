using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace YongShuiGuanLiDBI
{
    public class ConfigDBI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public string[] GetWaterLevelDeviceType()
        {
            List<string> r = new List<string>();

            string WATER_LEVEL_DEVICE_TYPE = "WaterLevelDeviceType";

            string sql = "select configValue from tblConfig where configName = '{0}'";
            sql = string.Format(sql, WATER_LEVEL_DEVICE_TYPE);

            DataTable tbl = DBI.GetDBI().ExecuteDataTable(sql);
            foreach ( DataRow row in tbl.Rows)
            {
                object obj = row[0];
                if (obj != null && obj != DBNull.Value)
                {
                    string type = obj.ToString().Trim();
                    r.Add(type);
                }
            }
            return r.ToArray();
        }
    }
}

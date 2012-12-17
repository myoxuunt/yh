using System;
using System.Collections.Generic;
using System.Text;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class SqlRowColumnConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="names"></param>
        /// <returns></returns>
        static public string MakeColumnsSql(string[] rowNames, string dataColumnName, string dataValueName)
        {
            if (rowNames == null || rowNames.Length == 0)
                throw new ArgumentException("names null or length == 0");

            string s = string.Empty ;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < rowNames.Length - 1; i++)
            {
                s = MakeColumnSql(rowNames[i], dataColumnName ,dataValueName);
                sb.Append(s + ",");
            }

            s = MakeColumnSql(rowNames[rowNames.Length - 1], dataColumnName, dataValueName);
            sb.Append(s);

            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        static private string MakeColumnSql(string rowName, string dataColumnName, string dataValueName)
        {
            string s = string.Format(
                "Max( Case when {1} = '{0}' then {2} end ) as '{0}'",
                rowName, dataColumnName, dataValueName);
            return s;
        }
    }
}

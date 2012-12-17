using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class SqlHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ids"></param>
        static public string MakeInQueryCondition( int[] ids )
        {
            //Debug.Assert(ids != null, "ids == null");
            //Debug.Assert(ids.Length > 0, "ids.Length == 0");

            if (ids == null || ids.Length == 0)
            {
                return "0";
            }

            string s = string.Empty;
            for (int i = 0; i < ids.Length - 1; i++)
            {
                s += ids[i] + ",";
            }

            s += ids[ids.Length - 1];
            return s;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        static public string MakeInQueryCondition(string[] names)
        {
            if (names == null || names.Length == 0)
            {
                return "''";
            }

            string s = string.Empty;
            for (int i = 0; i < names.Length - 1; i++)
            {
                s += "'" + names[i] + "', ";
            }

            s += "'" + names[names.Length - 1] + "'";
            return s;
        }
    }
}

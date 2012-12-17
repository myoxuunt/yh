using System;
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
    public class QueryStringParamPicker
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="queryString"></param>
        /// <param name="paramName"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        static public int PickInt32Param(System.Collections.Specialized.NameValueCollection queryString,
            string paramName, int defaultValue)
        {
            if (string.IsNullOrEmpty(paramName))
            {
                throw new ArgumentNullException("paramName");
            }

            string s = queryString[paramName];
            if (string.IsNullOrEmpty(s))
            {
                return defaultValue;
            }
            else
            {
                int r;
                bool b = int.TryParse (s,out r);
                if (b)
                {
                    return r;
                }
                else
                {
                    return defaultValue;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="queryString"></param>
        /// <param name="paramNames"></param>
        /// <param name="paramTypes"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        static public bool Pick(System.Collections.Specialized.NameValueCollection queryString,
            string[] paramNames, Type[] paramTypes, out object[] result)
        {
            if (paramNames == null)
            {
                throw new ArgumentNullException("paramNames");
            }

            if (paramTypes == null)
            {
                throw new ArgumentNullException("paramTypes");
            }

            if (paramNames.Length != paramTypes.Length)
            {
                throw new ArgumentException("paramNames.Length != paramTypes.Length");
            }


            result = new object[paramNames.Length];
            for (int i = 0; i < paramNames.Length; i++)
            {
                string name = paramNames[i];
                Type type = paramTypes[i];
                object obj = queryString[name];
                if (obj != null)
                {
                    object value = Convert.ChangeType(obj, type);
                    if (value != null)
                    {
                        result[i] = value;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}

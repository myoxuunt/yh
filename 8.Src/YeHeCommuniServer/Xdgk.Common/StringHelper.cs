using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class StringHelper
    {
        /// <summary>
        /// 比较字符串, 忽略大小写和首尾空白
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool Equal(string s1, string s2)
        {            
            return Equal(s1, s2, true, true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="ignoreCase">是否忽略大小写</param>
        /// <param name="ignoreWhite">是否忽略首尾空白</param>
        /// <returns></returns>
        public static bool Equal(string s1, string s2, bool ignoreCase, bool ignoreWhitespace)
        {
            if (s1 == null)
            {
                s1 = string.Empty;
            }

            if (s2 == null)
            {
                s2 = string.Empty;
            }

            if (ignoreWhitespace)
            {
                s1 = s1.Trim();
                s2 = s2.Trim();
            }
            return string.Compare(s1, s2, ignoreCase) == 0;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class NameValueCollection : Xdgk.Common.Collection<NameValue>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public NameValue GetByName(string name)
        {
            foreach (NameValue nv in this)
            {
                if (StringHelper.Equal(nv.Name, name))
                    return nv;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public NameValue GetByValue(object value)
        {
            foreach (NameValue nv in this)
            {
                if (nv.Value == value)
                {
                    return nv;
                }
            }
            return null;
        }
    }
}

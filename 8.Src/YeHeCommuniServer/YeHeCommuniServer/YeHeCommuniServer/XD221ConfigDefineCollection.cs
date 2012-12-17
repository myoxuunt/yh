using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Common;

namespace YeHeCommuniServer
{
    /// <summary>
    /// 
    /// </summary>
    public class XD221ConfigDefineCollection : Collection<XD221ConfigDefine>
    {
        /// <summary>
        /// 根据 name 查找 XD221ConfigItem, 如过找不到返回null
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public XD221ConfigDefine Find(string name)
        {
            foreach (XD221ConfigDefine ci in this)
            {
                if (StringHelper.Equal(ci.Name, name))
                {
                    return ci;
                }
            }
            return null;
        }

        /// <summary>
        /// 根据 wordIndex 查找 XD221ConfigItem, 如过找不到返回null
        /// </summary>
        /// <returns></returns>
        public XD221ConfigDefine Find(int offset)
        {
            foreach (XD221ConfigDefine ci in this)
            {
                if (ci.Offset == offset)
                    return ci;
            }
            return null;
        }
    }
}

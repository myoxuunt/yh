using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Xdgk.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class XmlHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="el"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        static public string GetAttribute(XmlElement el, string name)
        {
            return GetAttribute(el, name, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        static public string GetAttribute(XmlNode node, string name)
        {
            return GetAttribute(node, name, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="name"></param>
        /// <param name="canNull"></param>
        /// <returns></returns>
        static public string GetAttribute(XmlNode node, string name, bool canNull)
        {
            if (node == null)
                throw new ArgumentNullException("node");

            XmlElement e = node as XmlElement;
            if (e == null)
                throw new ArgumentException("node must be XmlElement, but was " + node.GetType().Name);

            return GetAttribute(e, name, canNull);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="el"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        static public string GetAttribute(XmlElement el, string name, bool canNull )
        {
            string str = el.GetAttribute(name);
            if (!canNull)
            {
                if (str == null || str.Length == 0)
                    throw new Exception(name + " null");
            }

            return str;
        }
    }
}

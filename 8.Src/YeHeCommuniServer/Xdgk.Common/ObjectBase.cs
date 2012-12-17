using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Common
{
     /// <summary>
    /// 
    /// </summary>
    public class ObjectBase
    {
        /// <summary>
        /// 
        /// </summary>
        public object Tag
        {
            set { _tag = value; }
            get { return _tag; }
        } private object _tag;
    }
}

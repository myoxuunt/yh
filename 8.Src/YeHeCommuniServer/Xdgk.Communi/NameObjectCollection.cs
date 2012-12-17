using System;
using System.Collections.Generic;
using System.Text;

using System.Collections.Specialized;
using System.Collections;

namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public class NameObjectCollection : NameObjectCollectionBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="obj"></param>
        public void Add(string name, object obj)
        {
            base.BaseAdd(name, obj);
        }

        // Gets a key-and-value pair (DictionaryEntry) using an index.
        public DictionaryEntry this[int index]
        {
            get
            {
                return (new DictionaryEntry(
                    this.BaseGetKey(index), this.BaseGet(index)));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public object GetObject(string name)
        {
            return base.BaseGet(name);
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="name"></param>
        ///// <returns></returns>
        //public object this[string name]
        //{
        //    get
        //    {
        //        return name;
        //        thi
        //    }
        //}
    }
}

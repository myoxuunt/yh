using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class NameValue
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public NameValue(string name, object value)
        {
            this.Name = name;
            this.Value = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        } private string _name;

        /// <summary>
        /// 
        /// </summary>
        public object Value
        {
            get { return _value; }
            set { _value = value; }
        } private object _value;
    }

}

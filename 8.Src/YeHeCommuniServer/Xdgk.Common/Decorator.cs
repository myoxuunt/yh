using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Common
{
    /// <summary>
    /// 
    /// </summary>
    abstract public class Decorator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public Decorator(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return _name; }
            set 
            {
                if (value == null || value.Trim().Length == 0)
                    throw new ArgumentException("value null or empty");
                _name = value; 
            }
        } private string _name;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        abstract public object Decorate(object value);
    }


    /// <summary>
    /// 
    /// </summary>
    public class DecoratorCollection : Collection<Decorator>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Decorator GetDecorator(string name)
        {
            foreach (Decorator d in this)
            {
                if (StringHelper.Equal(d.Name, name))
                {
                    return d;
                }
            }
            return null;
        }
    }


    /// <summary>
    /// 
    /// </summary>
    public class UnitDecorator : Decorator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="unitName"></param>
        public UnitDecorator(string name, string unitName)
            : base (name)
        {
            this.UnitName = unitName;
        }

        /// <summary>
        /// 
        /// </summary>
        public string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
        } private string _unitName;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override object Decorate(object value)
        {
            if (value == null)
                throw new ArgumentNullException("value");
            return value.ToString() + " " + UnitName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class DisplayValue
    {
        /// <summary>
        /// 
        /// </summary>
        public DisplayValue(string displayName, object value)
        {
            this.Display = displayName;
            this.Value = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Display
        {
            get
            {
                if (_display == null)
                {
                    _display = string.Empty;
                }
                return _display;
            }
            set
            {
                _display = value;
            }

        } private string _display;


        /// <summary>
        /// 
        /// </summary>
        public object Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        } private object _value;

        #region Source
        /// <summary>
        /// 
        /// </summary>
        public object Tag
        {
            get { return _tag; }
            set { _tag = value; }
        } private object _tag;
        #endregion //Source


        /// <summary>
        /// 
        /// </summary>
        public event EventHandler Activated;

        /// <summary>
        /// 
        /// </summary>
        public void Activate()
        {
            if (this.Activated != null)
            {
                this.Activated(this, EventArgs.Empty);
            }
        }

    }
}

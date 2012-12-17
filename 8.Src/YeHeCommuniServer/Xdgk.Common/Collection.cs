using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Xdgk.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class Collection<T> : System.Collections.ObjectModel.Collection<T>
    {
        public Collection()
            : this( false, false )
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="allowNull"></param>
        /// <param name="allowDuplicate"></param>
        public Collection( bool allowNull, bool allowDuplicate )
        {
            this._allowNull = allowNull;
            this._allowDuplicate = allowDuplicate;
        }

        public bool AllowNull
        {
            get { return _allowNull; }
        } private bool _allowNull ;

        public bool AllowDuplicate
        {
            get { return _allowDuplicate; }
        } private bool _allowDuplicate ;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="item"></param>
        protected override void InsertItem(int index, T item)
        {
            if (!AllowNull)
            {
                if (item == null)
                    throw new ArgumentNullException("item");
            }

            if ((!AllowDuplicate) && this.Contains(item))
                throw new ArgumentException("exist item: " + item );

            base.InsertItem(index, item);
        }
    }
}

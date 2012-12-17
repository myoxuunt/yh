using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class RangeConstraint : Constraint 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public RangeConstraint(IComparable from, IComparable to)
        {
            if (from == null)
                throw new ArgumentNullException("form");
            if (to == null)
                throw new ArgumentNullException("to");

            this.From = from;
            this.To = to;
        }

        /// <summary>
        /// 
        /// </summary>
        public IComparable From
        {
            get { return _from; }
            set { _from = value; }
        } private IComparable  _from;

        /// <summary>
        /// 
        /// </summary>
        public IComparable To
        {
            get { return _to; }
            set { _to = value; }
        } private IComparable _to;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override bool Verify(IComparable value)
        {
            int fr =value.CompareTo(this.From) ;
            int tr = value.CompareTo(this.To );

            if (fr >= 0 && tr <= 0)
            {
                return true;
            }
            return false;
        }
    }
}

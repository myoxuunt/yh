using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Common;

namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public class CommuniFailDetailCollection : Xdgk.Common.Collection<CommuniFailDetail>
    {
        private static int MAXCOUNT = 100;
        public CommuniFailDetailCollection()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="item"></param>
        protected override void InsertItem(int index, CommuniFailDetail item)
        {        
            base.InsertItem(index, item);
            if (this.Count >= MAXCOUNT)
            {
                // 2010-09-09
                //
                //this.RemoveAt(this.Count - 1);
                this.RemoveAt(0);
            }
        }
    }
}

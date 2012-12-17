using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Common;
//using Xdgk.Communi;
using Ciloci.Flee;
using System.Data;
using System.Reflection;

namespace YeHeCommuniServer
{
    /// <summary>
    /// 
    /// </summary>
    public class FormulaCollection : Collection<Formula>
    {
        public Formula Find(DateTime dt)
        {
            Formula r = null;
            foreach (Formula item in this)
            {
                if (item.Include(dt))
                {
                    r = item;
                    break;
                }
            }
            return r;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public float CalcInstantFlux(DateTime dt, int wl1, int wl2)
        {
            float instantFlux = 0;
            Formula r = Find(dt);
            if (r != null)
            {
                instantFlux = r.CalcInstantFlux(wl1, wl2);
            }
            return instantFlux;
        }
    }
}
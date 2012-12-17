using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Communi.Factory
{
    /// <summary>
    /// 
    /// </summary>
    abstract public class StrategyFactory
    {
        abstract public Strategy Create();
    }

    /// <summary>
    /// 
    /// </summary>
    public class CycleStrategyFactory : StrategyFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cycle"></param>
        public CycleStrategyFactory( TimeSpan cycle )
        {
            this.Cycle = cycle;
        }

        /// <summary>
        /// 
        /// </summary>
        public TimeSpan Cycle
        {
            get { return _cycle; }
            set 
            {
                _cycle = value;
            }
        } private TimeSpan _cycle;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Strategy Create()
        {
            return new CycleStrategy(this.Cycle); ;
        }
    }

}

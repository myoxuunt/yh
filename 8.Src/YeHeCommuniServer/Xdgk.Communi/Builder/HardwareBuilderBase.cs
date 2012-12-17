using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Communi.Builder
{
    /// <summary>
    /// 
    /// </summary>
    abstract public class HardwareBuilderBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="soft"></param>
        abstract public void Build(CommuniSoft soft);
    }
}

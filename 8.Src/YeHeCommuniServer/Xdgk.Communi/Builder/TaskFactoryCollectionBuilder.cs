using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Communi.Builder
{
    abstract public class TaskFactoryCollectionBuilder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="soft"></param>
        abstract public void Build(CommuniSoft soft);
    }
}

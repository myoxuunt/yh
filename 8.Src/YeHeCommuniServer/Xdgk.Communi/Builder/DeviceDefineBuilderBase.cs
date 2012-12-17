using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Communi.Factory;

namespace Xdgk.Communi.Builder
{
    abstract public class DeviceDefineBuilderBase
    {
        abstract public void Build(CommuniSoft soft);
        abstract public OperaFactoryBase OperaFactory
        { get; }
        
    }
}

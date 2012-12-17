using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Communi.Factory;
using Xdgk.Communi.Builder;

namespace Xdgk.Communi.XmlBuilder
{
    /// <summary>
    /// 
    /// </summary>
    public class XmlDeviceDefinePathBuild : DeviceDefineBuilderBase
    {
        /// <summary>
        /// 
        /// </summary>
        private string _path;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        public XmlDeviceDefinePathBuild(string path)
        {
            this._path = path;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="soft"></param>
        public override void Build(CommuniSoft soft)
        {
            soft.DeviceDefineManager.LoadFromPath(_path);
        }

        /// <summary>
        /// 
        /// </summary>
        public override OperaFactoryBase OperaFactory
        {
            get { throw new NotImplementedException(); }
        }
    }
}

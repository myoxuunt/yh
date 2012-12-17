using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Xdgk.Communi.Factory;
using Xdgk.Communi.Builder;

namespace Xdgk.Communi.XmlBuilder
{
    /// <summary>
    /// 
    /// </summary>
    public class XmlDeviceDefineBuild : DeviceDefineBuilderBase    
    {
        /// <summary>
        /// 
        /// </summary>
        private string _filename;

        /// <summary>
        /// 
        /// </summary>
        public override OperaFactoryBase OperaFactory
        {
            get { return _operaFactory; }
        } private OperaFactoryBase _operaFactory;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_filename"></param>
        public XmlDeviceDefineBuild(string filename)
        {
            this._filename = filename;
        }


        /// <summary>
        /// 
        /// </summary>
        public override void Build(CommuniSoft soft)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(_filename);
            XmlNode node = doc.SelectSingleNode(DeviceDefineNodeNames.DeviceDefineCollection);
            _operaFactory = new XmlOperaFactory(soft, node);
            //soft.OperaFactory = _operaFactory;


            _operaFactory.InitFDManager(soft.FDManager);
        }
    }


}

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Xdgk.Communi.Builder;

namespace Xdgk.Communi.XmlBuilder
{
    public class XmlListenBuilder : ListenBuilderBase
    {

        private string _filename;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        public XmlListenBuilder(string filename)
        {
            _filename = filename;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="soft"></param>
        public override void Build(CommuniSoft soft)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(_filename);
            XmlNode node = doc.SelectSingleNode(XmlListenNodeNames.ListenPortCollection);
            if (node != null)
            {
                foreach (XmlNode n in node.ChildNodes)
                {
                    if (n.Name == XmlListenNodeNames.ListenPort)
                    {
                        int port = int.Parse(n.InnerText);
                        SocketListener sckListener = new SocketListener(port);
                        sckListener.Start();
                        soft.SocketListenerManager.Add(sckListener);
                    }
                }
            }
        }
    }
}

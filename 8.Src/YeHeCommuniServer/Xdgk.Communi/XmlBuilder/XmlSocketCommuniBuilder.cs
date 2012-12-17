using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Net;

namespace Xdgk.Communi.XmlBuilder
{
    /// <summary>
    /// 
    /// </summary>
    public class XmlSocketCommuniBuilder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        static public CommuniType Build(XmlNode node)
        {
            return BuildSocketCommuniType(node);
        }

        #region BuildSocketCommuniType
        /// <summary>
        /// 
        /// </summary>
        /// <param name="xmlNode"></param>
        /// <returns></returns>
        static private CommuniType BuildSocketCommuniType(XmlNode socketNode)
        {
            if (socketNode == null)
                throw new ArgumentNullException("socketNode");

            XmlNode node = null;

            XmlNode discriminateModeNode = socketNode.SelectSingleNode(HardwareNodeNames.DiscriminateMode);
            string modestr = discriminateModeNode.InnerText;
            //CS.wl(modestr);
            DiscriminateMode mode = (DiscriminateMode)Enum.Parse(typeof(DiscriminateMode), modestr, true);
            if (mode == DiscriminateMode.ByIPAddress)
            {
                node = socketNode.SelectSingleNode(HardwareNodeNames.IPAddress);
                IPAddress ipaddress = IPAddress.Parse(node.InnerText);
                return new SocketCommuniType(ipaddress);
            }
            else if (mode == DiscriminateMode.ByLocalPort)
            {
                node = socketNode.SelectSingleNode(HardwareNodeNames.LocalPort);
                int localport = int.Parse(node.InnerText);
                return new SocketCommuniType( DiscriminateMode.ByLocalPort, localport);
            }
            else if (mode == DiscriminateMode.ByRemotePort)
            {
                node = socketNode.SelectSingleNode(HardwareNodeNames.RemotePort);
                int remotePort = int.Parse(node.InnerText);
                return new SocketCommuniType(DiscriminateMode.ByRemotePort, remotePort);
            }
            //else if (mode == DiscriminateMode.ByIPAddressPort)
            //{
            //    node = socketNode.SelectSingleNode(HardwareNodeNames.IPAddress);
            //    IPAddress ipaddress = IPAddress.Parse(node.InnerText);
            //    node = socketNode.SelectSingleNode(HardwareNodeNames.Port);
            //    int port = int.Parse(node.InnerText);
            //    return new SocketCommuniType(ipaddress, port);
            //}

            // TODO: by phonenumber
            //
            throw new ArgumentException("unknown discriminate mode: " + modestr);
        }
        #endregion //BuildSocketCommuniType

    }
}

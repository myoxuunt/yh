using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Net;
using NLog;
using Xdgk.Communi.XmlBuilder;
using System.IO.Ports;

namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public class CommuniTypeFactory
    {

        static private NLog.Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        static public CommuniType Create(string xmlString)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlString);
            XmlNode socketCTNode = doc.SelectSingleNode(HardwareNodeNames.SocketCommuniType);
            if (socketCTNode != null)
            {
                return CreateSocketCommuniType(socketCTNode);
            }

            XmlNode serialCTNode = doc.SelectSingleNode(HardwareNodeNames.SerialPortCommuniType);
            if (serialCTNode != null)
            {
                return CreateSerialSerialCommuniType(serialCTNode);
            }

            string errmsg = string.Format("cannot create CommuniType with: {0}", xmlString );
            logger.Error(errmsg);

            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serialCTNode"></param>
        /// <returns></returns>
        private static CommuniType CreateSerialSerialCommuniType(XmlNode serialCTNode)
        {
            if (serialCTNode == null)
            {
                throw new ArgumentNullException("serialCTNode");
            }

            XmlNode node = null;
            node = serialCTNode.SelectSingleNode(SerialCommuniTypeNodeNames.PortName);
            string portname = node.InnerText;

            node = serialCTNode.SelectSingleNode(SerialCommuniTypeNodeNames.BaudRate);
            int baudrate = int.Parse(node.InnerText );

            node = serialCTNode.SelectSingleNode(SerialCommuniTypeNodeNames.Parity);
            Parity parity = (Parity)Enum.Parse(typeof(Parity), node.InnerText);

            node = serialCTNode.SelectSingleNode(SerialCommuniTypeNodeNames.DataBits );
            int databits = int.Parse(node.InnerText);

            node = serialCTNode.SelectSingleNode(SerialCommuniTypeNodeNames.StopBits);
            StopBits stopbits = (StopBits)Enum.Parse(typeof(StopBits), node.InnerText);

            return new SerialCommuniType(portname, baudrate, parity, databits, stopbits);
        }





        /// <summary>
        /// 
        /// </summary>
        /// <param name="xmlNode"></param>
        /// <returns></returns>
        static private CommuniType CreateSocketCommuniType(XmlNode socketNode)
        {
            if (socketNode == null)
                throw new ArgumentNullException("socketNode");

            XmlNode node = null;

            XmlNode discriminateModeNode = socketNode.SelectSingleNode(SocketCommuniTypeNodeNames .DiscriminateMode);
            string modestr = discriminateModeNode.InnerText;

            DiscriminateMode mode = (DiscriminateMode)Enum.Parse(typeof(DiscriminateMode), modestr, true);
            if (mode == DiscriminateMode.ByIPAddress)
            {
                node = socketNode.SelectSingleNode(SocketCommuniTypeNodeNames.IPAddress);
                IPAddress ipaddress = IPAddress.Parse(node.InnerText);
                return new SocketCommuniType(ipaddress);
            }
            else if (mode == DiscriminateMode.ByLocalPort)
            {
                node = socketNode.SelectSingleNode(SocketCommuniTypeNodeNames.LocalPort);
                int localport = int.Parse(node.InnerText);
                return new SocketCommuniType( DiscriminateMode.ByLocalPort, localport);
            }
            else if (mode == DiscriminateMode.ByRemotePort)
            {
                node = socketNode.SelectSingleNode(SocketCommuniTypeNodeNames.RemotePort);
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
    }
}

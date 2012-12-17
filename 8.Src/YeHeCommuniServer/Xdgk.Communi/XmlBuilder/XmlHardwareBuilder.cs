using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Diagnostics;
using System.Net;

namespace Xdgk.Communi.XmlBuilder
{
    public class XmlHardwareBuilder : Xdgk.Communi.Builder.HardwareBuilderBase
    {
        private string _filename;

        /// <summary>
        /// 
        /// </summary>
        public HardwareManager HardwareManager
        {
            get { return _hardwareManager; }
        } private HardwareManager _hardwareManager;


        #region XmlHardwareBuilder
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        public XmlHardwareBuilder(string filename)
        {
            _filename = filename;
        }
        #endregion //XmlHardwareBuilder

        #region Build
        /// <summary>
        /// 
        /// </summary>
        /// <param name="soft"></param>
        public override void Build(CommuniSoft soft)
        {
            if (soft == null)
                throw new ArgumentNullException("soft");

            XmlDocument doc = new XmlDocument();
            doc.Load(_filename);
            XmlNode hardwareNode = doc.SelectSingleNode(HardwareNodeNames.Hardware);
            if (hardwareNode != null)
            {
                XmlNode stationsNode = hardwareNode.SelectSingleNode(HardwareNodeNames.StationCollection);
                if (stationsNode != null)
                {
                    BuildStationCollection(soft, stationsNode);
                }
            }
        }
        #endregion //Build

        #region BuildStationCollection
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_soft"></param>
        /// <param name="node"></param>
        private void BuildStationCollection(CommuniSoft soft, XmlNode stationsNode)
        {     
            if (soft == null)
                throw new ArgumentNullException("soft");

            if (stationsNode == null)
                throw new ArgumentNullException("stationsNode");

            foreach (XmlNode stationNode in stationsNode)
            {
                XmlNode stationNameNode = stationNode.SelectSingleNode(HardwareNodeNames.StationName);
                Debug.Assert(stationNameNode != null, "station name node == null");
                string name = stationNameNode.InnerText;

                XmlNode communitypeNode = stationNode.SelectSingleNode(HardwareNodeNames.CommuniType);
                Debug.Assert(communitypeNode != null, "communitype node == null");
                CommuniType communiType = BuildCommuniType(communitypeNode);

                DeviceCollection devices = null;
                XmlNode devicesNode = stationNode.SelectSingleNode(HardwareNodeNames.DeviceCollection);
                if (devicesNode != null)
                {
                    devices = BuildDeviceCollection(devicesNode);
                }

                Station st = new Station(name, communiType);
                st.Devices = devices;
                soft.HardwareManager.Stations.Add(st);
            }
        }
        #endregion //BuildStationCollection

        #region BuildDeviceCollection
        /// <summary>
        /// 
        /// </summary>
        /// <param name="devicesNode"></param>
        /// <returns></returns>
        private DeviceCollection BuildDeviceCollection(XmlNode devicesNode)
        {
            if (devicesNode == null)
                throw new ArgumentNullException("devicesNode");

            DeviceCollection devices = new DeviceCollection();
            foreach (XmlNode node in devicesNode.ChildNodes)
            {
                if (node.Name == HardwareNodeNames.Device)
                {
                    Device d = BuildDevice(node);
                    devices.Add(d);
                }
            }
            return devices;
        }
        #endregion //BuildDeviceCollection

        #region BuildDevice
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private Device BuildDevice(XmlNode deviceNode)
        {
            // TODO: xml device name and remark
            //
            if (deviceNode == null)
                throw new ArgumentNullException("deviceNode");

            XmlNode n = deviceNode.SelectSingleNode(HardwareNodeNames.DeviceType);
            string t = n.InnerText;
            n = deviceNode.SelectSingleNode(HardwareNodeNames.Address);
            int address = int.Parse(n.InnerText);
            // TODO: create new device by deviceDefine
            //
            //return new Device(t, address);
            return null;
        }
        #endregion //BuildDevice

        #region BuildCommuniType
        /// <summary>
        /// 
        /// </summary>
        /// <param name="communitypeNode"></param>
        /// <returns></returns>
        private CommuniType BuildCommuniType(XmlNode communitypeNode)
        {
            if (communitypeNode == null)
                throw new ArgumentNullException("communitypeNode");

            XmlNode nameNode = communitypeNode.SelectSingleNode(HardwareNodeNames.CommuniTypeName);
            string name = nameNode.InnerText;
            XmlNode node = null;

            switch (name)
            {
                case HardwareNodeNames.SocketCommuniType:
                    node = communitypeNode.SelectSingleNode(HardwareNodeNames.SocketCommuniType);
                    //return BuildSocketCommuniType(node);
                    return XmlSocketCommuniBuilder.Build(node);
                    break;

                case HardwareNodeNames.SerialPortCommuniType:
                    node = communitypeNode.SelectSingleNode(HardwareNodeNames.SerialPortCommuniType);
                    return BuildSerialPortCommuniType(node);
                    break;
                default:
                    throw new ArgumentException("unknown communi type: " + name);
            }
        }
        #endregion //BuildCommuniType

        #region BuildSerialPortCommuniType
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private CommuniType BuildSerialPortCommuniType(XmlNode node)
        {
            if (node == null)
                throw new ArgumentNullException("node");

            throw new NotImplementedException("BuildSerialPortCommuniType");
        }
        #endregion //BuildSerialPortCommuniType

    }
}

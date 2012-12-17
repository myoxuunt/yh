using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Communi.XmlBuilder
{

    /// <summary>
    /// 
    /// </summary>
    internal class HardwareNodeNames
    {
        /// <summary>
        /// 
        /// </summary>
        public const string
            Hardware = "hardware",
            StationCollection = "stations",
            Station = "station",
            StationName = "name",
            CommuniType = "communitype",
            CommuniTypeName = "name",
            SocketCommuniType = "socketcommunitype",
            SerialPortCommuniType = "serialportcommunitype",
            DiscriminateMode = "discriminatemode",
            IPAddress = "ipaddress",
            LocalPort = "localport",
            RemotePort = "remoteport",
            PhoneNumber = "phonenumber",
            DeviceCollection = "devices",
            Device = "device",
            DeviceType = "devicetype",
            Address = "address";
    }

    /// <summary>
    /// 
    /// </summary>
    internal class ParameterNodeNames
    {
        /// <summary>
        /// 
        /// </summary>
        public const string
            ParameterDefineCollection = "parameters",
            ParameterDefine = "parameter",
            Name = "name",
            Offset= "offset",
            TypeCode = "typecode",
            Converter = "converter",
            EnableNameValues = "enablenamevalues",
            Unit = "unit";
    }

    /// <summary>
    /// 
    /// </summary>
    internal class NameValueNodeNames 
    {
        /// <summary>
        /// 
        /// </summary>
        public const string
            Name = "name",
            Value = "value",
            NameValueCollection = "namevalues",
            NameValue = "namevalue";
    }


    /// <summary>
    /// 
    /// </summary>
    internal class ConstraintNodeNames
    {
        public const string
            Constraint = "constraint",
            Name = "name",
            From = "from",
            To = "to",
            RangeConstraint="rangeconstraint";
    }
}

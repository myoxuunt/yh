using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Communi.XmlBuilder
{
    class DeviceDefineNodeNames
    {
        public const string
            DeviceDefineCollection = "devicedefines",
            DeviceDefine = "devicedefine",
            DeviceType = "devicetype",
            DeviceText = "devicetext",

            // Opera
            //
            OperaDefineCollection = "operadefines",
            OperaDefine = "operadefine",
            OperaName = "name",
            OperaText = "text",
            OperaArgs = "args",

            SendPart = "sendpart",
            ReceivePart = "receivepart",
            DataField = "datafield",
            DataFieldName = "name",
            Begin = "begin",
            Length = "length",
            Converter = "converter",
            LittleEndian = "littleendian",
            Factor = "factor",
            Bytes = "bytes",
            Crc = "crc",
            CRCer = "crcer",
            MatchCheck="matchcheck",
            ReceivePartDataLength="length",
            ReceivePartName = "name";
    }
}

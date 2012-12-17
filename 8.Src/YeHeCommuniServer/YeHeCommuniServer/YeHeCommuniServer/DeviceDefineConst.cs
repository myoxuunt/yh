using System;
using System.Collections.Generic;
using System.Text;

namespace YeHeCommuniServer
{
    /// <summary>
    /// 
    /// </summary>
    public class DeviceDefineConst
    {
        /// <summary>
        /// device define type  xd221 modbus
        /// </summary>
        public const string DDT_XD221Modbus = "XD221Modbus";
        public const string DDT_XD221 = "XD221";
        public const string DDT_XD202 = "XD202";
        public const string DDT_XD2300 = "XD2300";
    }

    /// <summary>
    /// 
    /// </summary>
    public class XD221ModbusOperaNames
    {
        public const string ReadReal = "ReadReal";
        public const string ReadUsedAmount = "ReadUsedAmount";
        public const string WriteParam = "WriteParam";
    }

    /// <summary>
    /// 
    /// </summary>
    public class XD221OperaNames
    {
        public const string ReadReal = "ReadReal";
    }

    /// <summary>
    /// 
    /// </summary>
    public class XD2300OperaNames
    {
        public const string ReadReal = "ReadReal";
        public const string Down = "Down";
        public const string ReadRecordIndex = "ReadRecordIndex";
        public const string ReadRecord = "ReadRecord";
    }

    /// <summary>
    /// 
    /// </summary>
    public class OperaNames
    {
        public const string ReadReal = "ReadReal";
        public const string ReadParams = "readParams";
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Communi;
using Xdgk.Common;

namespace YeHeCommuniServer
{

    /// <summary>
    /// 
    /// </summary>
    public class XD221ModbusDevice : DitchDevice
    {
        public XD221ModbusDevice(DeviceDefine dd, string name, int address)
            : base(dd, name, address)
        {
        }
    }


    /// <summary>
    /// 
    /// </summary>
    public class DeviceFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dd"></param>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        static public Device Create(DeviceDefine dd, string name, int address)
        {
            if (Xdgk.Common.StringHelper.Equal(dd.DeviceType, DeviceDefineConst.DDT_XD221Modbus))
                return XD221ModbusDeviceFactory.Create(dd, name, address);

            if (StringHelper.Equal(dd.DeviceType, DeviceDefineConst.DDT_XD221))
                return XD221DeviceFactory.Create(dd, name, address);

            if (StringHelper.Equal(dd.DeviceType, DeviceDefineConst.DDT_XD202))
                return XD202DeviceFactory.Create(dd, name, address);

            if (StringHelper.Equal(dd.DeviceType, DeviceDefineConst.DDT_XD2300))
                return XD2300DeviceFactory.Create(dd, name, address); 

            throw new ArgumentException("not find deviceDefine: " + dd.DeviceType);
        }
    }


    /// <summary>
    /// 
    /// </summary>
    public class XD221ModbusDeviceFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public XD221ModbusDevice Create(DeviceDefine dd, string name, int address)
        {
            XD221ModbusDevice d = new XD221ModbusDevice(dd, name, address);
            return d;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class XD221DeviceFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dd"></param>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        static public XD221Device Create(DeviceDefine dd, string name, int address)
        {
            XD221Device d = new XD221Device(dd, name, address);
            return d;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class XD202DeviceFactory
    {
        static public XD202Device Create(DeviceDefine dd, string name, int address)
        {
            XD202Device d = new XD202Device(dd, name, address);
            return d;
        }
    }


    /// <summary>
    /// 
    /// </summary>
    public class XD2300DeviceFactory
    {
        static public XD2300Device Create(DeviceDefine dd, string name, int address)
        {
            XD2300Device d = new XD2300Device(dd, name, address);
            return d;
        }
    }
}

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
    public class XD221ModbusProcessor
    {
        /// <summary>
        /// 
        /// </summary>
        static public XD221ModbusProcessor Default
        {
            get
            {
                if (_default == null)
                    _default = new XD221ModbusProcessor();
                return _default;
            }
        } static private XD221ModbusProcessor _default;

        /// <summary>
        /// 毫米转换为厘米
        /// </summary>
        /// <returns></returns>
        private int MMToCM(int value)
        {
            return value / 10;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private short MMToCM(short value)
        {
            return (short)(value / 10);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        /// <param name="pr"></param>
        public void ProcessExecutedTask(Task task, ParseResult pr)
        {
            // xd221 modbus
            //
            //if (StringHelper.Equal(task.Device.DeviceDefine.DeviceType,
            //    DeviceDefineConst.DDT_XD221Modbus)
            //    &&
            if (StringHelper.Equal(task.Opera.Name, OperaNames.ReadReal))
            {
                object objTemp = pr.NameObjects.GetObject("WL1");
                Int16 wl1 = Convert.ToInt16(objTemp);
                wl1 = MMToCM(wl1);

                objTemp = pr.NameObjects.GetObject("WL2");
                Int16 wl2 = Convert.ToInt16(objTemp);
                wl2 = MMToCM(wl2);

                objTemp = pr.NameObjects.GetObject("IF");
                uint instantFlux = Convert.ToUInt32(objTemp);

                if (Config.Default.IsUseFluxFormula)
                {
                    instantFlux = (uint)YeHeCommuniServerApp.Default.DevieFormaulCollectionMapCollection.CalcInstantFlux(
                        task.Device.ID, DateTime.Now, wl1, wl2);
                }

                objTemp = pr.NameObjects.GetObject("Voltage");
                int voltage = Convert.ToInt32(objTemp);

                voltage = voltage / 100;

                DitchDevice ditchDevice = task.Device as DitchDevice;
                DitchDataCache cache = ditchDevice.DitchDataCache;

                cache.SetWLInstantFlux(wl1, wl2, instantFlux, voltage);

                if (cache.IsComplete())
                {
                    ditchDevice.DitchData = new DitchData(cache);
                    DB.DitchDataDBI.Insert(ditchDevice, cache);
                    cache.Clear();
                }
            }

            if (StringHelper.Equal(task.Opera.Name, XD221ModbusOperaNames.ReadUsedAmount))
            {
                object objTemp = pr.NameObjects.GetObject("usedAmount");
                UInt32 usedAmount = Convert.ToUInt32(objTemp);
                DitchDevice ditchDevice = task.Device as DitchDevice;
                DitchDataCache cache = ditchDevice.DitchDataCache;
                cache.SetUsedAmount(usedAmount);
                if (cache.IsComplete())
                {
                    ditchDevice.DitchData = new DitchData(cache);
                    DB.DitchDataDBI.Insert(ditchDevice, cache);
                    cache.Clear();
                }
            }
        }
    }
}

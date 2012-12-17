using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Common;

namespace Xdgk.Communi.Factory
{
    public class TaskFactory
    {
        private string _deviceType;
        private string _operaname;
        private StrategyFactory _strategyFactory;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceType"></param>
        /// <param name="operaName"></param>
        /// <param name="factory"></param>
        public TaskFactory(string deviceType, string operaName, StrategyFactory factory)
        {
            if (factory == null)
                throw new ArgumentNullException("factory");

            this._deviceType = deviceType;
            this._operaname = operaName;
            this._strategyFactory = factory;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void Create(CommuniSoft soft)
        {
            if (soft == null)
                throw new ArgumentNullException("soft");

            foreach (Station st in soft.HardwareManager.Stations)
            {
                foreach (Device d in st.Devices)
                {
                    //if (d.DeviceType == _deviceType)
                    if (StringHelper.Equal(d.DeviceDefine.DeviceType, _deviceType))
                    {
                        //Opera o = soft.OperaFactory.Create(_deviceType, _operaname);
                        DeviceDefine dd = soft.DeviceDefineManager.DeviceDefineCollection.FindDeviceDefine(_deviceType);
                        if (dd == null)
                        {
                            throw new ConfigException(_deviceType);
                        }
                        Opera o = dd.CreateOpera(_operaname);
                        if (o == null)
                        {
                            string exmsg = string.Format("Create opera fail\r\n device: '{0}'\r\n opera: '{1}'", 
                                _deviceType, _operaname );
                            throw new ConfigException(exmsg);
                        }
                        Strategy s = _strategyFactory.Create();
                        Task t = new Task(d, o, s);
                        soft.TaskManager.Tasks.Add(t);
                    }
                }
            }
        }
    }
}

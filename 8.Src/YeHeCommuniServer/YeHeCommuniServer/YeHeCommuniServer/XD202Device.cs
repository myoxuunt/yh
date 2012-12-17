using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Common;
using Xdgk.Communi;

namespace YeHeCommuniServer
{
    /// <summary>
    /// 
    /// </summary>
    public class XD202Device : Device
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dd"></param>
        /// <param name="name"></param>
        /// <param name="address"></param>
        public XD202Device(DeviceDefine dd, string name, int address)
            : base(dd, name, address)
        {

        }


        /// <summary>
        /// 
        /// </summary>
        public XD202Data XD202Data
        {
            get
            {
                return this.Data as XD202Data;
            }
            set
            {
                this.Data = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Communi;

namespace YeHeCommuniServer
{
    /// <summary>
    /// 
    /// </summary>
    public class DitchDevice : Device
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dd"></param>
        /// <param name="name"></param>
        /// <param name="address"></param>
        public DitchDevice(DeviceDefine dd, string name, int address)
            : base(dd, name, address)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        public DitchData DitchData
        {
            get { return this.Data as DitchData; }
            set { this.Data = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DitchDataCache DitchDataCache
        {
            get
            {
                if (_ditchDataCache == null)
                    _ditchDataCache = new DitchDataCache();
                return _ditchDataCache;
            }
            set { _ditchDataCache = value; }
        } private DitchDataCache _ditchDataCache;
    }
}

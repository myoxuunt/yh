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
    public class XD221Device : DitchDevice 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dd"></param>
        /// <param name="name"></param>
        /// <param name="address"></param>
        public XD221Device(DeviceDefine dd, string name, int address) :
            base(dd, name, address)
        {
        }

        #region Xd221Params
        /// <summary>
        /// 
        /// </summary>
        public XD221Params Xd221Params
        {
            get { return _xd221Params; }
            set { _xd221Params = value; }
        } private XD221Params _xd221Params;
        #endregion //Xd221Params

    }
}

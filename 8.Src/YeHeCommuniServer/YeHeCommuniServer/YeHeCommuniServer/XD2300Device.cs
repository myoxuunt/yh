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
    public class XD2300Device : DitchDevice
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dd"></param>
        /// <param name="name"></param>
        /// <param name="id"></param>
        public XD2300Device(DeviceDefine dd, string name, int address)
            : base(dd, name, address)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsLastRecordIndexValid()
        {
            if (_lastRecordIndex == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
            
        #region LastRecordIndex
        /// <summary>
        /// 
        /// </summary>
        public int LastRecordIndex
        {
            get
            {
                return _lastRecordIndex;
            }
            set
            {
                _lastRecordIndex = value;
            }
        } private int _lastRecordIndex = -1;
        #endregion //LastRecordIndex

    }
}

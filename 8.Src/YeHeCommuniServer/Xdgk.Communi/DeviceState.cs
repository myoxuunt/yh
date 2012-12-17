using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public class DeviceState
    {
        /// <summary>
        /// 
        /// </summary>
        static public readonly DeviceState None = new DeviceState(string.Empty);

        /// <summary>
        /// 
        /// </summary>
        public DeviceState(string stateText)
        {
            this.StateText = stateText;
        }

        /// <summary>
        /// 
        /// </summary>
        public string StateText
        {
            get 
            {
                if (_stateText == null)
                    _stateText = string.Empty;
                return _stateText;
            }
            set 
            {
                _stateText = value;
            }
        } private string _stateText;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.StateText;
        }
    }
}

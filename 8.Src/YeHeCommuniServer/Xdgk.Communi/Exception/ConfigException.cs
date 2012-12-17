using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public class ConfigException : System.Exception
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public ConfigException(string message)
            : base( message )
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerEx"></param>
        public ConfigException(string message, Exception innerEx)
            : base(message, innerEx)
        {
        }
    }
}

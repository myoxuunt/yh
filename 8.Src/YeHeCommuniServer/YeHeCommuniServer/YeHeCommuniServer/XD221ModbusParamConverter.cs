using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Communi;

namespace YeHeCommuniServer
{
    /// <summary>
    /// 
    /// </summary>
    public class XD221ModbusParamConverter : Xdgk.Communi.Interface.BytesConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override byte[] ConvertToBytes(object obj)
        {
            XD221ModbusConfigObject mpo = obj as XD221ModbusConfigObject;
            if (obj == null)
                throw new ArgumentException("not XD221ModbusParamObject argument");

            return mpo.ToBytes();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public override object ConvertToObject(byte[] bytes)
        {
            return XD221ModbusConfigObject.Parse(bytes);
        }
    }
}

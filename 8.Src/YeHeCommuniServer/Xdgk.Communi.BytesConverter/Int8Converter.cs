using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Communi
{
    /// <summary>
    /// 提供一个0~255范围整数 到 byte[] 之间的双向转换
    /// </summary>
    public class Int8Converter : Xdgk.Communi.Interface.BytesConverter 
    {
        #region IBytesConverter 成员
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        override public object ConvertToObject(byte[] bytes)
        {
            return bytes[0];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        override public byte[] ConvertToBytes(object obj)
        {
            byte b = Convert.ToByte(obj);
            return new byte[] { b };
        }

        #endregion
    }
}

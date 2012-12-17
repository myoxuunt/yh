using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Communi
{
    /// <summary>
    /// 提供有符号长整数 到 byte[] 之间的双向转换
    /// </summary>
    public class Int32Converter : Xdgk.Communi.Interface.BytesConverter
    {
        #region IBytesConverter 成员
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        override public byte[] ConvertToBytes(object obj)
        {
            Int32 n = Convert.ToInt32( obj );
            byte[] bs = BitConverter.GetBytes(n);
            bs = this.ReverseWithIsLittleEndian(bs);
            return bs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        override public object ConvertToObject(byte[] bytes)
        {
            bytes = this.ReverseWithIsLittleEndian(bytes);
            Int32 n = BitConverter.ToInt32(bytes, 0);
            return n;
        }

        #endregion
    }

}

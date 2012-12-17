using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Communi
{
    /// <summary>
    /// 提供float到byte[]之间的转换
    /// </summary>
    public class FloatConverter : Xdgk.Communi.Interface.BytesConverter
    {
        #region IBytesConverter 成员
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        override public object ConvertToObject(byte[] bytes)
        {
            bytes = this.ReverseWithIsLittleEndian(bytes);
            return BitConverter.ToSingle(bytes, 0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        override public byte[] ConvertToBytes(object obj)
        {
            float f = Convert.ToSingle(obj);
            byte[] bs = BitConverter.GetBytes(f);
            bs = this.ReverseWithIsLittleEndian(bs);
            return bs;
        }

        #endregion
    }
}

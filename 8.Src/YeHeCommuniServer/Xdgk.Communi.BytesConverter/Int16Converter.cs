using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public class Int16Converter : Xdgk.Communi.Interface.BytesConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override byte[] ConvertToBytes(object obj)
        {
            Int16 n = Convert.ToInt16(obj);
            byte[] bs = BitConverter.GetBytes(n);
            bs = this.ReverseWithIsLittleEndian(bs);
            return bs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public override object ConvertToObject(byte[] bytes)
        {
            bytes = this.ReverseWithIsLittleEndian(bytes);
            Int16 n = BitConverter.ToInt16(bytes, 0);
            return n;
        }
    }
}

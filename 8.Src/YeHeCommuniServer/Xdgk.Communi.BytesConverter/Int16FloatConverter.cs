using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Communi
{

    /// <summary>
    /// 提供以16位整数表示的小数 到 byte[] 之间的双向转换
    /// </summary>
    //public class Int16FloatConverter : Xdgk.Communi.Interface.IBytesConverter 
    public class Int16FloatConverter : Xdgk.Communi.Interface.BytesConverter
    {
        /// <summary>
        /// 
        /// </summary>
        public Int16FloatConverter() : this(1F)
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="factor"></param>
        public Int16FloatConverter(float factor)
        {
            this.Factor = factor;
        }


        /// <summary>
        /// 获取或设置缩放比例
        /// </summary>
        /// <remarks>
        /// object -> bytes: value = value / Factor
        /// Bytes -> object: value = value * Factor
        /// </remarks>
        public float Factor
        {
            get { return _factor; }
            set { _factor = value; }
        } private float _factor;


        #region IBytesConverter 成员

        /// <summary>
        /// (Int16)(obj / Factor) -> byte[]
        /// </summary>
        /// <param name="obj">浮点数值</param>
        /// <returns></returns>
        override public byte[] ConvertToBytes(object obj)
        {
            Single f = Convert.ToSingle(obj);
            f = f / this.Factor;
            Int16 n = (Int16)f;
            byte[] bs = BitConverter.GetBytes(n);
            bs = ReverseWithIsLittleEndian(bs);
            return bs;
        }

        /// <summary>
        /// bytes -> Int16 -> Int16 * Factor
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        override public object ConvertToObject(byte[] bytes)
        {
            bytes = ReverseWithIsLittleEndian(bytes);
            Int16 n = BitConverter.ToInt16(bytes, 0);
            Single f = n * this.Factor;
            return f;
        }

        #endregion
    }
}

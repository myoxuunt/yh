using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Communi.Interface;

    //public class BCDConvert
    //{
    //    private BCDConvert()
    //    {
    //    }

    //    static public int DecToBCD( int value )
    //    {
    //        return Convert.ToInt32( value.ToString(), 16 );
    //    }

    //    static public int BCDToDec( int value )
    //    {
    //        return Convert.ToInt32( value.ToString("X"), 10 );
    //    }
    //}

namespace Xdgk.Communi
{
    /// <summary>
    /// 提供BCD转换
    /// </summary>
    public class BCDConverter : BytesConverter
    {
        #region IBytesConverter 成员
        /// <summary>
        /// 十进制值转换为十六进制值， 10 -> 0x10
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        static public int DECToBCD(int dec)
        {
            return Convert.ToInt32(dec.ToString(), 16);
        }

        /// <summary>
        /// 十六进制值转换为十进制值， 0x10 -> 10
        /// </summary>
        /// <param name="bcd"></param>
        /// <returns></returns>
        static public int BCDToDEC(int bcd)
        {
            return int.Parse(bcd.ToString("X"));
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="bytes"></param>
        ///// <returns></returns>
        //static public object DECToBCD(byte[] bytes)
        //{
        //    byte value = bytes[0];
        //    return DECToBCD(value);
        //}

        //static public byte[] BCDToDEC(object obj)
        //{
        //    int value = Convert.ToInt32(obj);
        //    if (value < 0 || value > 99)
        //        throw new ArgumentOutOfRangeException("obj must in [0, 99]");

        //    byte b = (byte)Convert.ToInt32(value.ToString(), 16);
        //    return new byte[] { b };
        //}
        /// <summary>
        /// 将BCD形式bytes数组的转换为数字,仅第一个字节
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns>int</returns>
        override public object ConvertToObject(byte[] bytes)
        {
            // 1. byte[] -> object
            // 2. byte[0] -> int
            // 3. (bcd) -> int
            //
            byte b = bytes[0];
            int n = BCDToDEC(b);
            return n;
        }

        /// <summary>
        /// 将数字转换为BCD形式的byte数组
        /// </summary>
        /// <param name="obj">int</param>
        /// <returns>一个字节的数组</returns>
        override public byte[] ConvertToBytes(object obj)
        {
            // obj -> byte[]
            // int -> byte[0]
            // int -> hex
            //
            int n = Convert.ToInt32(obj);
            int m = DECToBCD(n);
            return new byte[] { (byte)m };
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Communi.Interface;

namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public class XGTimeConverter : BytesConverter
    {
        #region IBytesConverter 成员
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        override public byte[] ConvertToBytes(object obj)
        {
            TimeSpan ts = (TimeSpan)obj;
            byte s = (byte)BCDConverter.DECToBCD(ts.Seconds);
            byte m = (byte)BCDConverter.DECToBCD(ts.Minutes);
            byte h = (byte)BCDConverter.DECToBCD(ts.Hours);
            return new byte[] { s, m, h };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        override public object ConvertToObject(byte[] bytes)
        {
            if (bytes == null || bytes.Length < 3)
                throw new ArgumentException("bytes.Length must >= 3");
            byte s = (byte)BCDConverter.BCDToDEC(bytes[0]);
            byte m = (byte)BCDConverter.BCDToDEC(bytes[1]);
            byte h = (byte)BCDConverter.BCDToDEC(bytes[2]);

            return new TimeSpan(h, m, s);
        }

        #endregion
    }
}

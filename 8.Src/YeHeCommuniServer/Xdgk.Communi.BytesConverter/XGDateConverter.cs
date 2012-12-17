using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Communi.Interface;

namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public class XGDateConverter : BytesConverter
    {
        #region IBytesConverter 成员
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        override public byte[] ConvertToBytes(object obj)
        {
            DateTime dt = (DateTime)obj;
            byte d = (byte)BCDConverter.DECToBCD((byte)dt.Day);
            byte m = (byte)BCDConverter.DECToBCD((byte)dt.Month);
            int year = dt.Year;
            year %= 100;

            byte y = (byte)BCDConverter.DECToBCD((byte)year);
            return new byte[] { d, m, y };
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
            byte d = (byte)BCDConverter.BCDToDEC(bytes[0]);
            byte m = (byte)BCDConverter.BCDToDEC(bytes[1]);
            byte y = (byte)BCDConverter.BCDToDEC(bytes[2]);
            int year = 2000 + y;
            Console.WriteLine("{0}-{1}-{2}",year,m,d);

            return new DateTime(year, m, d);
        }

        #endregion
    }
}

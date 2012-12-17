using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Communi.Interface;

namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public class BoolBitConverter : BytesConverter
    {
        /// <summary>
        /// 
        /// </summary>
        public int BitIndex
        {
            get { return _bitIndex; }
            set
            {
                if (value >= 0 && value <= 7)
                    _bitIndex = value;
                else
                    throw new ArgumentOutOfRangeException("BitIndex out of range: " + value);
            }
        } private int _bitIndex;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        override public byte[] ConvertToBytes(object obj)
        {
            byte r = 0;
            bool b = (bool)obj;
            if (b)
                r += (byte)System.Math.Pow(2, BitIndex);
            return new byte[] { r };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        override public object ConvertToObject(byte[] bytes)
        {
            byte mask = (byte)System.Math.Pow(2, this.BitIndex);
            if ((bytes[0] & mask) > 0)
                return true;
            else
                return false;
        }
    }

}

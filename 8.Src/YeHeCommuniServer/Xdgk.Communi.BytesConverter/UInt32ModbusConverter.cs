using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Communi.Interface;


namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public class UInt32ModbusConverter : Xdgk.Communi.Interface.BytesConverter 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override byte[] ConvertToBytes(object obj)
        {
            UInt32 u = Convert.ToUInt32(obj);
            byte[] bs = BitConverter.GetBytes(u);
            //Console.WriteLine(BitConverter.ToString(bs));
            byte[] bsResult = new byte[] { bs[1], bs[0], bs[3], bs[2] };
            return bsResult;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public override object ConvertToObject(byte[] bytes)
        {
            byte[] bs = new byte[] { bytes[2], bytes[3], bytes[0], bytes[1]};
            //Console.WriteLine(BitConverter.ToString(bs));
            Array.Reverse(bs);
            return BitConverter.ToUInt32(bs, 0);
        }
    }
}

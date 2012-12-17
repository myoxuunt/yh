using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Communi.Interface;

namespace Xdgk.Communi
{
    /// <summary>
    /// CRC16计算器
    /// </summary>
    public class CRC16 : ICRCer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pByte"></param>
        /// <param name="nBeginIndex"></param>
        /// <param name="nNumberOfBytes"></param>
        /// <param name="pChecksum"></param>
        public static void CalculateCRC(byte[] pByte, int nBeginIndex, int nNumberOfBytes, out ushort pChecksum)
        {
            int nBit;
            ushort nShiftedBit;
            pChecksum = 0xFFFF;
            int nByte = nBeginIndex;
            int nEnd = nByte + nNumberOfBytes;

            //for (int nByte = 0; nByte < nNumberOfBytes; nByte++)
            for (; nByte < nEnd; nByte++)
            {
                pChecksum ^= pByte[nByte];

                for (nBit = 0; nBit < 8; nBit++)
                {
                    if ((pChecksum & 0x1) == 1)
                    {
                        nShiftedBit = 1;
                    }
                    else
                    {
                        nShiftedBit = 0;
                    }

                    pChecksum >>= 1;
                    if (nShiftedBit != 0)
                    {
                        pChecksum ^= 0xA001;
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pByte"></param>
        /// <param name="nBeginIndex"></param>
        /// <param name="nNumberOfBytes"></param>
        /// <returns></returns>
        public static byte[] CalculateCRC(byte[] pByte, int nBeginIndex, int nNumberOfBytes)
        {
            ushort checkSum;
            CalculateCRC(pByte, nBeginIndex, nNumberOfBytes, out checkSum);
            return BitConverter.GetBytes(checkSum);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pByte"></param>
        /// <returns></returns>
        public static byte[] CalculateCRC(byte[] pByte)
        {
            return CalculateCRC(pByte, 0, pByte.Length);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="begin"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public byte[] Calc(byte[] bytes, int begin, int length)
        {
            return CalculateCRC(bytes, begin, length);
        }
    }
}

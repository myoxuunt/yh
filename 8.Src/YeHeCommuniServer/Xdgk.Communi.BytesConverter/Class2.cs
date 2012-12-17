using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Communi.Interface;

namespace Xdgk.Communi
{
    /// <summary>
    /// XD100室外温度-二次供温控制曲线转换器
    /// </summary>
    public class XD100OTControlLineConverter : BytesConverter
    {
        /// <summary>
        /// 
        /// </summary>
        private const int POINT_COUNT = 8;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override byte[] ConvertToBytes(object obj)
        {
            byte[] bs = new byte[2 * POINT_COUNT];
            KeyValuePair<int, int>[] values = (KeyValuePair<int, int>[])(obj);
            for (int i = 0; i < POINT_COUNT; i++)
            {
                int index = i * 2;

                bs[index] = ByteRealValueConverter.RealValueToByteValue(values[i].Key);
                bs[index + 1] = (byte)(values[i].Value);
            }
            // 2010-08-31 
            //
            //return base.ConvertToBytes(obj);
            return bs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public override object ConvertToObject(byte[] bytes)
        {
            KeyValuePair<int, int>[] values = new KeyValuePair<int,int>[POINT_COUNT];

            for (int i = 0; i < POINT_COUNT; i++)
            {
                int index = 2 * i;
                int ot = ByteRealValueConverter.ByteValueToRealValue(bytes[index]);
                int gt2 = bytes[index + 1];
                values[i] = new KeyValuePair<int, int>(ot, gt2);
            }
            return values;
        }
    }


    /// <summary>
    /// XD100分时控制曲线转换器
    /// </summary>
    public class XD100TimeControlLineConverter : BytesConverter
    {
        // 时间分段数
        //
        private const int TIME_COUNT = 12;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override byte[] ConvertToBytes(object obj)
        {
            int[] timeControlLine = obj as int[];
            byte[] bs = new byte[TIME_COUNT];
            for (int i = 0; i < TIME_COUNT; i++)
            {
                // TODO: check range
                //
                // 温度范围 -9.9 ~ 10 ℃
                //
                byte t = ByteRealValueConverter.RealValueToByteValue(timeControlLine[i]);
                bs[i] = t;
            }
            return bs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public override object ConvertToObject(byte[] bytes)
        {
            int[] vs = new int[TIME_COUNT];
            for (int i = 0; i < TIME_COUNT; i++)
            {
                vs[i] = ByteRealValueConverter.ByteValueToRealValue(bytes[i]);
            }
            return vs;
        }

    }

    /// <summary>
    /// 提供Byte数值与真实数值之间的双向转换
    /// </summary>
    /// <remarks>
    /// 0 ~ 127 表示正值, 128 ~ 255 表示负值
    /// </remarks>
    internal class ByteRealValueConverter
    {
        /// <summary>
        /// 最大正值
        /// </summary>
        public const int Max = 127;
        public const int Min = -128;

        /// <summary>
        /// TODO:
        /// </summary>
        /// <param name="bv"></param>
        /// <returns></returns>
        static internal int ByteValueToRealValue(byte bv)
        {
            if (bv > Max)
                return bv - 256;
            else
                return bv;
        }

        /// <summary>
        /// TODO:
        /// </summary>
        /// <param name="iv"></param>
        /// <returns></returns>
        static internal byte RealValueToByteValue(int rv)
        {
            //if (rv < 0)
            //    return (byte)(rv + 256);

            //if (rv <= Max)
            //    return (byte)rv;

            if (rv > Max || rv < Min)
            {
                string s = string.Format("rv must in [{0}, {1}]", Min, Max );
                throw new ArgumentOutOfRangeException(s);
            }

			if ( rv >=0 )
				return (byte)rv;
			else
                return (byte)(rv + 256);

        }
    }
}

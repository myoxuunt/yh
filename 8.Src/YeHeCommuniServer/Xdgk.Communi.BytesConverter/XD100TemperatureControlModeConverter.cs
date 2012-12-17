using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Communi.Interface;

namespace Xdgk.Communi
{
    /// <summary>
    /// XD100供热控制器温度控制方式和调节阀类型转换器
    /// </summary>
    public class XD100TemperatureControlModeConverter: BytesConverter 
    {
        // 控制方式和调节阀类型 
        // 1个字节	
        //      高4位                       为0000表示温度曲线，    为0001表示温度设定；
        //      低4位表示控制类型，         为0000表示模拟阀、      为0001表示三位阀；
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override byte[] ConvertToBytes(object obj)
        {
            int[] values = obj as int[];
            int lo = values[0];
            int hi = values[1];

            int v = ( hi << 4 ) + lo ;
            return new byte[] { (byte)v };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public override object ConvertToObject(byte[] bytes)
        {
            byte v = bytes[0];
            int lo4bit = v & 0x0F;
            int hi4bit = v & 0xF0;

            hi4bit = hi4bit >> 4;
            return new int[] { lo4bit, hi4bit };
        }
    }
}

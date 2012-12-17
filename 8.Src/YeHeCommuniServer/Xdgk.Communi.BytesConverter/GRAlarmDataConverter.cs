using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xdgk.Communi.Interface;
using System.Diagnostics;

namespace Xdgk.Communi
{
    /// <summary>
    /// 提供供热控制器报警数据转换
    /// </summary>
    public class GRAlarmDataConverter : BytesConverter
    {
        static private readonly string[] AlarmNames1 = new string[]
        {
                "一次供温低",
                "二次供温高",
                "二次供压低",
                "二次供压高",
                "二次回压高",
                "二次回压低",
                "水箱水位低",
                "水箱水位高"
        };

        static private readonly string[] AlarmNames2 = new string[]
        {
                "循环泵1故障",
                "循环泵2故障",
                "循环泵3故障",
                "补水泵1故障",
                "补水泵2故障",
                "电源故障",
                "",
                ""
        };
        /// <summary>
        /// 
        /// </summary>
        /// <param name="byteIdx"></param>
        /// <param name="bitIdx"></param>
        /// <returns></returns>
        static private string GetAlarmName(int byteIdx, int bitIdx)
        {
            string[] ss = null;
            if (byteIdx == 1)
                ss = AlarmNames1;
            if (byteIdx == 2)
                ss = AlarmNames2;
            return ss[bitIdx];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="datas"></param>
        /// <param name="fromAddress"></param>
        /// <returns></returns>
        static public IList Parse(byte[] datas )
        {
            ArrayList list = new ArrayList();
            if (datas == null)
                throw new ArgumentNullException("datas");

            if (datas.Length < 2)
                throw new ArgumentException("datas.length must >= 2");

            byte b1 = datas[0];
            byte b2 = datas[1];

            for (int i = 0; i < 8; i++)
            {
                bool b = IsSet(b1, i);
                if (b)
                {
                    string n = GetAlarmName(1, i);
                    list.Add(n);
                }
            }

            for (int i = 0; i < 6; i++)
            {
                bool b = IsSet(b2, i);
                if (b)
                {
                    string n = GetAlarmName(2, i);
                    list.Add(n);
                }
            }
            return list;
        }

        /// <summary>
        /// 判断某一位是否为1
        /// </summary>
        /// <param name="b"></param>
        /// <param name="bitIndex"></param>
        /// <returns></returns>
        static private bool IsSet(byte b, int bitIndex)
        {
            Debug.Assert(bitIndex >= 0 && bitIndex <= 7);
            byte mask = (byte)System.Math.Pow(2, bitIndex);
            bool r = (b & mask) > 0;
            return r;
        }

        /// <summary>
        /// 返回报警名称ArrayList
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        override public object ConvertToObject(byte[] bytes)
        {
            return Parse(bytes);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        override public byte[] ConvertToBytes(object obj)
        {
            throw new NotImplementedException("GRAlarmDataConverter.ConvertToBytes");
        }

    }
}

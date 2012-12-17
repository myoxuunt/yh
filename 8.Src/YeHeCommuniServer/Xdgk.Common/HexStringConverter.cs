using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Common
{
    /// <summary>
    /// 提供十六进制字符串到byte[]之间的转换
    /// </summary>
    public class HexStringConverter : Xdgk.Communi.Interface.BytesConverter
    {
        /// <summary>
        /// 
        /// </summary>
        public readonly static HexStringConverter Default = new HexStringConverter();

        static public readonly char[] SplitChars = new char[] {' ', '\t'};
        #region IBytesConverter 成员
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        override public byte[] ConvertToBytes(object obj)
        {
            ArrayList list = new ArrayList();
            if (obj == null)
                return new byte[0];

            string str = obj.ToString().Trim();
            string[] items = str.Split(SplitChars);
            //print(items);
            if (items == null || items.Length == 0)
                return null;

            byte[] bs = new byte[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                string temp = items[i].Trim();
                if (temp.Length > 0)
                {
                    byte b = Convert.ToByte(temp, 16);
                    list.Add(b);
                }
            }
            return (byte[])list.ToArray(typeof(byte));
            //return bs;
        }

        //void print(string[] ss)
        //{
        //    Console.WriteLine("len:" + ss.Length);
        //    foreach (string s in ss)
        //    {
        //        Console.WriteLine(s);
        //    }
        //}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        override public object ConvertToObject(byte[] bytes)
        {
            string s = string.Empty;
            if (bytes == null)
            {
                return string.Empty;
            }
            if (bytes.Length == 0)
                return string.Empty;

            for (int i = 0; i < bytes.Length; i++)
            {
                s += bytes[i].ToString("X2") + ((i != bytes.Length - 1) ? " " : "");
            }
            return s;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using Xdgk.Common;
using Xdgk.Communi;
using Xdgk.Communi.Interface;

namespace YeHeCommuniServer
{
    /// <summary>
    /// 
    /// </summary>
    public class XD221ModbusConfigObject
    {
        /// <summary>
        /// 
        /// </summary>
        public XD221ModbusConfigObject(string name, object value)
        {
            this.Name = name;
            this.Value = value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public XD221ConfigDefine GetXD221ConfigDefine()
        {
            return XD221ConfigDefineCollection.Find(this.Name);
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        } private string _name;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public byte[] ToBytes()
        {
            Xdgk.Communi.BytesConverterManager bcMan = XD221ModbusConfigObject.BytesConverterManager;
            // TODO: get ci
            //
            XD221ConfigDefine ci = null; // this.XD221ConfigItem;
            IBytesConverter ibc = bcMan.CreateBytesConverter(ci.Converter, null);
            if (ibc == null)
            {
                string s = string.Format("Create converter fail, converter type '{0}'", ci.Converter );
                throw new Exception(s);
            }

            byte[] inDataBs = ibc.ConvertToBytes(this.Value);
            // TODO: convert to modbus bs
            //
            byte[] beginBs = GetModbusWordBytes(ci.Offset);
            byte[] wordCountBs = GetModbusWordBytes(inDataBs.Length / 2);
            byte[] byteCountBs = new byte[] { (byte)inDataBs.Length };


            MemoryStream ms = new MemoryStream();
            AppendBytes(ms, beginBs, wordCountBs, byteCountBs, inDataBs);
            return ms.ToArray();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ms"></param>
        /// <param name="bs"></param>
        private void AppendBytes(MemoryStream ms, byte[] bs)
        {
            ms.Write(bs, 0, bs.Length);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ms"></param>
        /// <param name="bsArray"></param>
        private void AppendBytes(MemoryStream ms, params byte[][] bsArray)
        {
            foreach (byte[] bs in bsArray)
            {
                AppendBytes(ms, bs);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private byte[] GetModbusWordBytes(int n)
        {
            Int16 n16 = Convert.ToInt16(n);
            return BitConverter.GetBytes(n16);
        }

        #region Static

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bs"></param>
        /// <returns></returns>
        static public XD221ModbusConfigObject Parse(byte[] bs)
        {
            if (bs.Length == 7)
            {
                int begin = GetModbusWord(bs, 0);
                int wordCount = GetModbusWord(bs, 2);
                int byteCount = bs[4];
                // TODO: wordindex converter
                //
                XD221ConfigDefine ci = XD221ConfigDefineCollection.Find(begin + 1);

                // TODO: ci == null
                //
                IBytesConverter ibc = BytesConverterManager.CreateBytesConverter(ci.Converter, null);
                object obj = ibc.ConvertToObject(bs);
                XD221ModbusConfigObject mpo = new XD221ModbusConfigObject(ci.Name, obj);
                return mpo;
            }
            return null;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="bs"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        static private Int16 GetModbusWord(byte[] bs, int offset)
        {
            byte[] temp = new byte[] { bs[offset + 1], bs[offset] };
            return BitConverter.ToInt16(temp, 0);
        }

        #region BytesConverterManager
        /// <summary>
        /// 
        /// </summary>
        static public BytesConverterManager BytesConverterManager
        {
            get 
            {
                // TODO: 
                // 
                return YeHeCommuniServerApp.Default.CommuniSoft.BytesConverterManager;
            }
        } 
        #endregion //BytesConverterManager

        /// <summary>
        /// 
        /// </summary>
        static public XD221ConfigDefineCollection XD221ConfigDefineCollection
        {
            get
            {
                return XD221ModbusParamConfig.Default.XD221ConfigDefineCollection; 
            }
        } 

        #region Value
        /// <summary>
        /// 
        /// </summary>
        public object Value
        {
            get { return _value; }
            set { _value = value; }
        } private object _value;
        #endregion //Value
        #endregion //Static
    }
}

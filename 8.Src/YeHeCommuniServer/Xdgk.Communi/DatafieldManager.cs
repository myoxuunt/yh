using System;
using System.IO;
using System.IO.IsolatedStorage;
using System.Diagnostics;
using System.Collections;
using Xdgk.Communi.Interface;
using NUnit.Core;
using Xdgk.Common;

namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 1. 根据datafieldCollection 生成bytes数据
    /// 2. 根据dataFieldCollection 解析bytes数据
    /// </remarks>
    public class DatafieldManager
    {
        private static Logger log = InternalTrace.GetLogger(typeof(DatafieldManager));

        #region Length
        /// <summary>
        /// 获取或设置接收数据长度
        /// </summary>
        public int Length
        {
            get { return _length; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Length must > 0");
                _length = value; 
            }
        } private int _length;
        #endregion //Length

        #region CRCer
        /// <summary>
        /// 获取或者设置校验器
        /// </summary>
        public ICRCer CRCer
        {
            get { return _crcer; }
            set { _crcer = value; }
        } private ICRCer _crcer;
        #endregion //

        #region this[]
        /// <summary>
        /// 获取指定名称的DataField, 如不存在返回null
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataField this[string name]
        {
            get 
            {
                name = name.Trim();
                foreach (DataField df in this.DataFields)
                {
                    if (string.Compare(name, df.Name.Trim(), true) == 0)
                    {
                        return df;
                    }
                }
                return null;
            }
        }
        #endregion //


        #region DataFields
        /// <summary>
        /// 
        /// </summary>
        public DataFieldCollection DataFields
        {
            get 
            {
                if (this._DatafieldCollection == null)
                {
                    this._DatafieldCollection = new DataFieldCollection();
                }
                return _DatafieldCollection;
            }
        } private DataFieldCollection _DatafieldCollection;
        #endregion //
        
        #region DatafieldManager
        /// <summary>
        /// 
        /// </summary>
        public DatafieldManager( )
        {
        }
        #endregion //

        ///// <summary>
        ///// 
        ///// </summary>
        //public ReceivePart ReceivePart
        //{
        //    get { return _receivePart; }
        //} private ReceivePart _receivePart;

        #region Pick
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public byte[][] Pick(byte[] bytes)
        {
            if (bytes == null)
                return null;

            if (bytes.Length < this.Length)
                return null;

            if (this.Length <= 0)
                return null;

            ArrayList list = new ArrayList();
            int end = bytes.Length - this.Length;
            for (int i = 0; i <= end; i++)
            {
                bool matchflag = true;
                foreach (DataField df in this.DataFields)
                {
                    if (!df.IsCRC && df.IsMatchCheck)
                    {
                        if (!df.Match(bytes, i))
                        {
                            matchflag = false;
                            break;
                        }
                    }
                }

                if (matchflag)
                {
                    byte[] bstemp = new byte[this.Length];
                    Array.Copy(bytes, i, bstemp, 0, this.Length);
                    list.Add(bstemp);
                }
            }
            if (list.Count == 0)
                return null;

            return (byte[][])list.ToArray(typeof(byte[]));
        }
        #endregion //Pick

        #region GetCRCDataField
        /// <summary>
        /// 获取校验域，如不存在返回null
        /// </summary>
        /// <returns></returns>
        public DataField GetCRCDataField()
        {
            foreach (DataField df in this.DataFields)
            {
                if (df.IsCRC)
                    return df;
            }
            return null;
        }
        #endregion //GetCRCDataField

        #region ToBytes
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public byte[] ToBytes()
        {
            MemoryStream ms = new MemoryStream();
            foreach (DataField df in this.DataFields)
            {            
                // 确保df数据写到正确的位置
                //
                if (ms.Length != df.BeginPosition)
                {
                    string errmsg = string.Format(
                        "write datafield '{0}' data being position error, expect: {1}, but was: {2}", 
                        df.Name, df.BeginPosition , ms.Length );

                    throw new InvalidDataException(errmsg);
                }

                if (!df.IsCRC)
                {
                    byte[] bs = df.Bytes;
                    if (bs == null)
                    {
                        string errmsg = string.Format("datafield '{0}' Bytes null",
                            df.Name);
                        throw new InvalidOperationException(errmsg);
                    }
                    ms.Write(bs, 0, (int)bs.Length);
                }
                else
                {
                    byte[] bs = ms.ToArray();
                    byte[] crcbs = this.CRCer.Calc(bs, 0, bs.Length);
                    df.Bytes = crcbs;
                    ms.Write(crcbs, 0, (int)crcbs.Length);
                }
            }
            return ms.ToArray();
        }
        #endregion //

        #region
        /// <summary>
        /// 检查bytes是否匹配dataFieldCollection
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public ParseResult CheckBytes( string receivePartName, byte[] bytes)
        {
            if (bytes == null)
                return new LengthErrorResult( receivePartName, this.DataFields.BytesLength, 0);

            // 1. check length
            //
            // TODO: 2010-06-08 return CheckLength max length while fail
            //
            //if (!this.DataFields.CheckLength(bytes))
            //    return new LengthErrorResult(receivePartName, this.DataFields.BytesLength, bytes.Length);
            int dfsBytesLength = this.DataFields.Length ;
            if (bytes.Length < dfsBytesLength)
                return new LengthErrorResult(receivePartName, dfsBytesLength, bytes.Length);

            // 1.1 check match check bytes
            //
            foreach(DataField df in this.DataFields )
            {
                if (df.IsMatchCheck)
                {
                    log.Debug("MatchCheck datafield: {0}", df.Name);

                    byte[] bs = df.GetMatch(bytes);
                    log.Debug("Expected: {0}, Actual: {1}", 
                        HexStringConverter.Default.ConvertToObject(df.Bytes),
                        HexStringConverter.Default.ConvertToObject(bs));

                    bool eq = BytesValueComparer.AreEqual(df.Bytes, bs);
                    if (!eq)
                    {
                        return new DataErrorResult( receivePartName, df.Bytes, bs); 
                    }
                }
            }
            // 2. check crc
            // get crcfg
            //
            DataField crcdf = this.DataFields.CRCDataField;
            if (crcdf != null)
            {
                byte[] crcbs = this.CRCer.Calc(bytes, 0, this.DataFields.Length - crcdf.DataLength);
                crcdf.Bytes = crcbs;
                if (!crcdf.Match(bytes, 0))
                {
                    return new CRCErrorResult( receivePartName, crcbs, crcdf.GetMatch(bytes, 0));
                }
            }
            
            // 3. check need match df
            //
            return new SuccessResult(receivePartName);
        }
        #endregion //
    
        #region ToValues
        /// <summary>
        /// 
        /// </summary>
        public ParseResult ToValues( string receivePartName, byte[] bytes )
        {
            log.Debug("ToValues: {0}", HexStringConverter.Default.ConvertToObject(bytes));

            ParseResult pr = this.CheckBytes(receivePartName, bytes);
            if (!pr.Success)
                return pr;

 

            SuccessResult sr = pr as SuccessResult;
            foreach (DataField df in this.DataFields)
            {
                if( (!df.IsCRC) &&
                    (!df.IsIgnore) )
                {
                    string s = string.Format("convert datafield '{0}' to object",df.Name);
                    log.Debug(s);
                    byte[] bs = df.GetMatch(bytes);

                    // try convert fail
                    //
                    try
                    {
                        df.Bytes = bs;
                        sr.NameObjects.Add(df.Name, df.Value);
                    }
                    catch (Exception ex)
                    {
                        ConvertErrorResult convertErr = new ConvertErrorResult(receivePartName, bs, df, ex);
                        return convertErr;
                    }
                }
            }

           // get remain bytes
            //
            int bytesLength = (bytes != null ? bytes.Length : 0);
            if (bytesLength > this.Length)
            {
                int n = bytesLength - this.Length;
                byte[] remain = new byte[n];
                Array.Copy(bytes, this.Length, remain, 0, n);
                pr.Remain = remain;
            }
            return pr;
        }
        #endregion //

    }//end DatafieldManager
}

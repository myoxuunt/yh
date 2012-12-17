using System;
using System.Collections.Generic;
using System.Text;

using System.Collections.Specialized;
using System.Collections;

namespace Xdgk.Communi
{
    #region ParseResult
    /// <summary>
    /// 代表设备数据的解析结果
    /// </summary>
    /// <remarks>
    /// TODO: 
    /// 1. Match address ?
    /// 2. Can re distribution. (if received data is address error can be re distribution)
    /// 
    /// </remarks>
    public abstract class ParseResult
    {
        //public ParseResult( string deviceType, string operaName )
        //{
        //    _deviceType = deviceType;
        //    _operaName = operaName;
        //}
        public ParseResult( string receivePartName)
        {
            this._receivePartName = receivePartName;
        }
        ///// <summary>
        ///// 
        ///// </summary>
        //public byte[] Bytes
        //{
        //    get { return _bytes; }
        //    set { _bytes = value; }
        //} private byte[] _bytes;

        ///// <summary>
        ///// 
        ///// </summary>
        //public string DeviceType
        //{
        //    get { return _deviceType; }
        //} private string _deviceType;

        ///// <summary>
        ///// 
        ///// </summary>
        //public string OperaName
        //{
        //    get { return _operaName; }
        //} private string _operaName;

        /// <summary>
        /// 获取检查结果标志, 如果解析成功返回true, 否则返回false
        /// </summary>
        public virtual bool Success
        {
            get { return _success; }
        } protected bool _success = false;


        /// <summary>
        /// 获取对应的ReceivePart的名称
        /// </summary>
        public string ReceivePartName
        {
            get 
            {
                if (_receivePartName == null)
                    _receivePartName = string.Empty;
                return _receivePartName; 
            }
        } private string _receivePartName;

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //public override string ToString()
        //{
        //    return strings.GetString(this.GetType().Name);
        //}

        /// <summary>
        /// 
        /// </summary>
        public NameObjectCollection NameObjects
        {
            get { return _nameObjects; }
        } private NameObjectCollection _nameObjects= new NameObjectCollection();

        /// <summary>
        /// 
        /// </summary>
        public byte[] Remain
        {
            get { return _remain; }
            set { _remain = value; }
        } private byte[] _remain;

    }
    #endregion //ParseResult

    #region SuccessResult
    /// <summary>
    /// 
    /// </summary>
    public class SuccessResult : ParseResult
    {
        /// <summary>
        /// 
        /// </summary>
        //public SuccessResult(string deviceType, string operaName)
            //: base(deviceType, operaName)
        public SuccessResult( string receivePartName)
            : base ( receivePartName )
        {
            this._success = true;
        }

        public override string ToString()
        {
            return strings.SuccessResult;
        }
    }
    #endregion //SuccessResult

    #region LengthErrorResult
    /// <summary>
    /// 长度错误结果
    /// </summary>
    public class LengthErrorResult : ParseResult
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="actual"></param>
        //public LengthErrorResult(string deviceType, string operaName, int expected, int actual)
            //: base(deviceType, operaName )
        public LengthErrorResult( string receivePartName, int expected, int actual)
            : base(receivePartName)
        {
            this._expected = expected;
            this._actual = actual;
        }

        /// <summary>
        /// 获取期望的长度
        /// </summary>
        public int Expected
        {
            get { return _expected; }
        } private int _expected;

        /// <summary>
        /// 获取实际值
        /// </summary>
        public int Actual
        {
            get { return _actual; }
        } private int _actual;

        public override string ToString()
        {
            string s = string.Format("{0}, {1} '{2}', {3} '{4}'", strings.LengthErrorResult,
                strings.Expected, Expected, strings.Actual, Actual);
            return s;
        }
    }
    #endregion //LengthErrorResult


    #region CRCErrorResult
    /// <summary>
    /// 校验错
    /// </summary>
    public class CRCErrorResult : ParseResult
    {
        /// <summary>
        /// 
        /// </summary>
        //public CRCErrorResult(string deviceType, string operaName, byte[] expected, byte[] actual)
        //    : base(deviceType, operaName )
        public CRCErrorResult(string receivePartName, byte[] expected, byte[] actual)
            : base(receivePartName)
        {
            this._expected = expected;
            this._actual = actual;
        }
        /// <summary>
        /// 获取期望值
        /// </summary>
        public byte[] Expected
        {
            get { return _expected; }
        } private byte[] _expected;

        /// <summary>
        /// 获取实际值
        /// </summary>
        public byte[] Actual
        {
            get { return _actual; }
        } private byte[] _actual;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            //return base.ToString() + " " +
            //    BitConverter.ToString( this.Expected ) + " : " + BitConverter.ToString( this.Actual );
            string s = string.Format("{0}, {1} '{2}', {3} '{4}'", strings.CRCErrorResult,
                strings.Expected, BitConverter.ToString(this.Expected),
                strings.Actual, BitConverter.ToString(this.Actual));
            return s;
        }
    }
    #endregion //CRCErrorResult


    #region ConvertErrorResult
    /// <summary>
    /// 转换错误
    /// </summary>
    public class ConvertErrorResult : ParseResult
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="df"></param>
        //public ConvertErrorResult(string deviceType, string operaName, byte[] actual, DataField df)
        //    : this(deviceType, operaName )
        public ConvertErrorResult( string receivePartName, byte[] actual, DataField df, Exception ex)
            : base(receivePartName)
        {
            this._actual = actual;
            if (df == null)
                throw new ArgumentNullException("df");
            this._df = df;
            _convertException = ex;

        }

        /// <summary>
        /// 
        /// </summary>
        public Exception ConvertException
        {
            get { return _convertException; }
        } private Exception _convertException;
        /// <summary>
        /// 
        /// </summary>
        public byte[] Actual
        {
            get { return _actual; }
        } private byte[] _actual;

        /// <summary>
        /// 
        /// </summary>
        public DataField DataField
        {
            get { return _df; }
        } private DataField _df;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            //string s = base.ToString() + " " + BitConverter.ToString(Actual) + " : " +
            //    this.DataField.Name + this.DataField.BytesConverter.ToString();

            string s = string.Format("{0}, {1} '{2}', {3} '{4}', {5} '{6}'", 
                strings.ConvertErrorResult,
                strings.Name, _df.Name,
                strings.Converter, this.DataField.BytesConverter.ToString(),
                strings.Value, BitConverter.ToString(Actual));
            return s;
        }
    }
    #endregion //ConvertErrorResult


    #region AddressErrorResult
    /// <summary>
    /// 
    /// </summary>
    public class AddressErrorResult : ParseResult
    {
        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="receivePartName"></param>
        /// <param name="expected"></param>
        /// <param name="actual"></param>
        public AddressErrorResult(string receivePartName, int expected, int actual)
            : base(receivePartName)
        {
            this._expected = expected;
            this._actual = actual;
        }
        #endregion //Constructor


        #region Expected
        /// <summary>
        /// 
        /// </summary>
        public int Expected
        {
            get { return _expected; }
        } private int _expected;
        #endregion //Expected

        #region Actual
        /// <summary>
        /// 
        /// </summary>
        public int Actual
        {
            get { return _actual; }
        } private int _actual;
        #endregion //Actual

        #region Actual
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string s = string.Format("{0}, {1} '{2}', {3} '{4}'", strings.AddressErrorResult,
                strings.Expected, this.Expected,
                strings.Actual, this.Actual);
            return s;
        }
        #endregion //Actual

    }
    #endregion //AddressErrorResult

    #region DataErrorResult
    /// <summary>
    /// 
    /// </summary>
    public class DataErrorResult : ParseResult
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="actual"></param>
        public DataErrorResult( string receivePartName, byte[] expected, byte[] actual)
            : base(receivePartName)
        {
            if (expected == null)
                throw new ArgumentNullException("expected");
            if (actual == null)
                throw new ArgumentNullException("actual");

            _expected = expected;
            _actual = actual;
        }

        public byte[] Expected
        {
            get { return _expected; }
        } private byte[] _expected;

        /// <summary>
        /// 
        /// </summary>
        public byte[] Actual
        {
            get { return _actual; }
        } private byte[] _actual;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string s = string.Format("{0}, {1} '{2}', {3} '{4}'", strings.DataErrorResult,
                strings.Expected, BitConverter.ToString(this.Expected),
                strings.Actual, BitConverter.ToString(this.Actual));
            return s;
        }
    }
    #endregion //DataErrorResult

    #region NoNameParseResult
    /// <summary>
    /// 
    /// </summary>
    /// 
    // TODO: rename noNameParseResult
    //
    public class NoNameParseResult : ParseResult
    {

        /// <summary>
        /// 
        /// </summary>
        public NoNameParseResult()
            : base (string.Empty )
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public ParseResultCollection ParseResults
        {
            get { return _parseResults; }
        } private ParseResultCollection _parseResults = new ParseResultCollection();

        /// <summary>
        /// 
        /// </summary>
        public new string ReceivePartName
        {
            get
            {
                string s = string.Empty;
                foreach (ParseResult pr in this._parseResults)
                {
                    s += pr.ReceivePartName + " ";
                }
                return s;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string s = string.Empty;
            foreach (ParseResult pr in ParseResults)
            {
                s += pr.ToString() + ",";
            }
            return s;
        }
    }
    #endregion //NoNameParseResult

}

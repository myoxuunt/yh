//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Xdgk.Communi
//{
//    /// <summary>
//    /// 
//    /// </summary>
//    public class BitDataField : DataField
//    { 
//        #region Members
//        public int BitBeginPosition
//        {
//            get { return _bitBeginPosition; }
//            set
//            {
//                if (value < 0 || value > 7)
//                    throw new ArgumentOutOfRangeException("BitBeginPosition out of range: " + value );
//                _bitBeginPosition = value;
//            }
//        } private int _bitBeginPosition;

//        public int BitLength
//        {
//            get { return _bitLength; }
//            set
//            {
//                if (value < 0 || value + _bitLength > 8)
//                    throw new ArgumentOutOfRangeException("BitLength out of range: " + value);
//                _bitLength = value;
//            }
//        } private int _bitLength;
//        #endregion //

//        #region Constructor
//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="name"></param>
//        /// <param name="beginPosition"></param>
//        /// <param name="length"></param>
//        /// <param name="bitBeginPosition"></param>
//        /// <param name="bitLength"></param>
//        /// <param name="dataFieldOption"></param>
//        public BitDataField(string name, int beginPosition, int length, int bitBeginPosition, int bitLength, DataFieldOption dataFieldOption, BytesConverter bytesConverter)
//            : base( name, beginPosition, length , dataFieldOption, bytesConverter )
//        {
//            this.BitBeginPosition = bitBeginPosition;
//            this.BitLength = bitLength;
//        }
//        #endregion //

//        #region GetMatch
//        public override byte[] GetMatch(byte[] datas, int index)
//        {
//            byte[] bs = base.GetMatch(datas, index);
//            byte b = bs[0];
//            byte mask = GetMask();
//            return new byte[] { (byte)(b & mask) };
//        }
//        #endregion //


//        #region Mask
//        /// <summary>
//        /// 
//        /// </summary>
//        /// <returns></returns>
//        private byte GetMask()
//        {
//            byte b = 0;
//            for (int i = _bitBeginPosition; i < _bitBeginPosition + _bitLength; i++)
//            {
//                b += (byte)Math.Pow(2, i);
//            }
//            return b;
//        }
//        #endregion //

//    }
//}

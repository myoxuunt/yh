using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace Xdgk.Communi.Interface
{
    #region IBytesConverter
    /// <summary>
    /// 
    /// </summary>
    public interface IBytesConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytest"></param>
        /// <returns></returns>
        object ConvertToObject(byte[] bytes);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        byte[] ConvertToBytes(object obj);

        /// <summary>
        /// 
        /// </summary>
        bool IsLittleEndian
        {
            get;
            set;
        }
    }
    #endregion //IBytesConverter


    #region BytesConverter
    /// <summary>
    /// 
    /// </summary>
    abstract public class BytesConverter : IBytesConverter
    {

        /// <summary>
        /// 
        /// </summary>
        protected BytesConverter()
            : this(true)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isLittleEndian"></param>
        protected BytesConverter(bool isLittleEndian)
        {
            this.IsLittleEndian = isLittleEndian;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsLittleEndian
        {
            get { return _isLittleEndian; }
            set { _isLittleEndian = value; }
        } private bool _isLittleEndian;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        virtual public object ConvertToObject(byte[] bytes)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        virtual public byte[] ConvertToBytes(object obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public byte[] ReverseWithIsLittleEndian(byte[] bs)
        {
            if (bs == null)
                throw new ArgumentNullException("bs");
            if (!this.IsLittleEndian)
            {
                byte[] bsclone = (byte[])bs.Clone();
                Array.Reverse(bsclone);
                return bsclone;
            }
            return bs;
        }

    }
    #endregion //BytesConverter


    #region ICRCer
    /// <summary>
    /// 
    /// </summary>
    public interface ICRCer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="begin"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        byte[] Calc(byte[] bytes, int begin, int length);
    }
    #endregion //ICRCer


    #region IBytesWrapper
    /// <summary>
    /// 
    /// </summary>
    public interface IBytesWrapper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        byte[] Wrap(byte[] bytes);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        byte[] Unwrap(byte[] bytes);
    }
    #endregion //IBytesWrapper
}

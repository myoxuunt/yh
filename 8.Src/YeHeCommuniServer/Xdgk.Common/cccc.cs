using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Common
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDataFormatter
    {
        /// <summary>
        /// 
        /// </summary>
        Type DataType
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        object Format(object value);
    }

    /// <summary>
    /// 
    /// </summary>
    abstract public class DataFormatterBase : IDataFormatter
    {
        abstract public object Format(object value);

        /// <summary>
        /// 
        /// </summary>
        protected DataFormatterBase(Type dataType)
        {
            this.DataType = dataType;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type DataType
        {
            get { return _dataType; }
            set {
                if (value == null)
                    throw new ArgumentNullException("DataType");
                _dataType = value; }
        } private Type _dataType;
    }

    /// <summary>
    /// 
    /// </summary>
    abstract public class NumberFormatterBase : DataFormatterBase
    {

        protected NumberFormatterBase(Type dataType)
            : base(dataType)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="digits"></param>
        protected NumberFormatterBase(Type dataType,int digits)
            : this(dataType)
        {
            this.Digits = digits;
        }

        /// <summary>
        /// 
        /// </summary>
        public int Digits
        {
            get { return _digits; }
            set 
            {
                if (value < 0)
                    value = 0;
                _digits = value; 
            }
        } private int _digits = 2;

    }

    /// <summary>
    /// 
    /// </summary>
    public class SingleFormatter : NumberFormatterBase 
    {
        /// <summary>
        /// 
        /// </summary>
        public SingleFormatter()
            : base(typeof(Single))
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dotNumber"></param>
        public SingleFormatter(int digits)
            : base(typeof(Single),digits)
        {
        }

        /// <summary>
        /// 将Single转换为Double
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        override public object Format(object value)
        {
            Single v = (Single)value;
            return (double)Math.Round(v, this.Digits);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class DoubleFormatter : NumberFormatterBase
    {
        public DoubleFormatter()
            : base( typeof(double) )
        {

        }


        public DoubleFormatter( int digits )
            : base( typeof(double), digits )
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        override public object Format(object value)
        {
            double v = (double)value;
            return Math.Round(v, this.Digits);
        }
    }


    /// <summary>
    /// 
    /// </summary>
    public class DecimalFormatter : NumberFormatterBase
    {
        public DecimalFormatter()
            : base( typeof(double) )
        {

        }


        public DecimalFormatter( int digits )
            : base( typeof(double), digits )
        {

        }

        public override object Format(object value)
        {
            decimal v = (decimal)value;
            return Math.Round(v, Digits);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Int32Formatter : DataFormatterBase 
    {
        #region IDataFormatter 成员

        public Int32Formatter()
            : base(typeof(Int32))
        {

        }
        override public object Format(object value)
        {
            return (Int32)value;
        }

        #endregion
    }

    /// <summary>
    /// 
    /// </summary>
    public class DataFormatterCollection : Collection<IDataFormatter>
    {
        protected override void InsertItem(int index, IDataFormatter item)
        {
            IDataFormatter df = GetDataFormatter(item.GetType());
            if (df != null)
            {
                throw new ArgumentException(
                    string.Format("exist type {0}", item.GetType().FullName)
                    );
            }
            base.InsertItem(index, item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public IDataFormatter GetDataFormatter(Type type)
        {
            foreach (IDataFormatter df in this)
            {
                if (df.DataType == type)
                {
                    return df;
                }
            }
            return null;
        }
    }
}

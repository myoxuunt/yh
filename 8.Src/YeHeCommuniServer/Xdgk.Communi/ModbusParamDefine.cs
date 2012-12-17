using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Common;
namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public class ModbusParameterDefine : ParameterDefine 
    {
        /// <summary>
        /// 
        /// </summary>
        public ModbusParameterDefine( string name, TypeCode typeCode, string conveter, int offset)
            : base ( name, typeCode, conveter )
        {
            this.Offset = offset;
        }

        #region Offset
        /// <summary>
        /// 
        /// </summary>
        public int Offset
        {
            get { return _offset; }
            set { _offset = value; }
        } private int _offset;
        #endregion //Offset
    }
}

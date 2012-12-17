using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public class Parameter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pd"></param>
        public Parameter(ParameterDefine pd)
        {
            this.ParameterDefine = pd;
        }

        #region ParameterDefine
        /// <summary>
        /// 
        /// </summary>
        public ParameterDefine ParameterDefine
        {
            get { return _parameterDefine; }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("ParameterDefine");
                }
                _parameterDefine = value; 
            }
        } private ParameterDefine _parameterDefine;
        #endregion //ParameterDefine

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

    }


    /// <summary>
    /// 
    /// </summary>
    public class ParameterCollection : Xdgk.Common.Collection<Parameter>
    {
    }
}

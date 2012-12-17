using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Common;
namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public class ParameterDefineCollection : Collection<ParameterDefine>
    {
    }

    /// <summary>
    /// 
    /// </summary>
    //public class ModbusParamterDefineCollection : Collection<ModbusParameterDefine>
    public class ModbusParamterDefineCollection : ParameterDefineCollection 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        new public ModbusParameterDefine this[int index]
        {
            get
            {
                return base[index] as ModbusParameterDefine;
            }
            set
            {
                base[index] = value;
            }
        }
    }
}

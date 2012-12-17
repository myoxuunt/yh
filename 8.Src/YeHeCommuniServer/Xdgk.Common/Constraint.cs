using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Common
{
    /// <summary>
    /// 表示一个约束
    /// </summary>
    abstract public class Constraint
    {
        /// <summary>
        /// 检验value是否复核约束条件
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        abstract public bool Verify(IComparable value);
    }
}

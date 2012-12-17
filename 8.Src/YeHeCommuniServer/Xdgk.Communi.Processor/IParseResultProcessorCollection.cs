using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Communi.Processor
{
    /// <summary>
    /// 
    /// </summary>
    public class IParseResultProcessorCollection : Xdgk.Common.Collection<IParseResultProcessor>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public IParseResultProcessor GetByName(string name)
        {
            foreach (IParseResultProcessor p in this)
            {
                if (p.Name == name)
                {
                    return p;
                }
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        public IParseResultProcessor GetByTypeFullName(string typeFullName)
        {
            foreach (IParseResultProcessor p in this)
            {
                if (p.GetType().FullName == typeFullName)
                {
                    return p;
                }
            }
            return null;
        }
    }
}

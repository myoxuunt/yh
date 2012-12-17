using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Common;

namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public class ReceivePartCollection : Collection<ReceivePart>
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        internal ParseResult ToValues(byte[] bytes)
        {
            NoNameParseResult failpr = new NoNameParseResult();

            foreach (ReceivePart rp in this)
            {
                ParseResult pr = rp.ToValues(bytes);
                if (pr.Success)
                {
                    return pr;
                }
                else
                {
                    failpr.ParseResults.Add(pr);
                }
            }
            return failpr;
        }
    }
}

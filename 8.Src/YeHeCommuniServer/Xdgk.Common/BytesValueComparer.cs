using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Common
{
    public class BytesValueComparer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bs1"></param>
        /// <param name="bs2"></param>
        /// <returns></returns>
        static public bool AreEqual(byte[] bs1, byte[] bs2)
        {
            if (bs1 == null)
            {
                if (bs2 == null)
                    return true;
                else
                    return false;
            }
            else
            {
                if (bs2 == null)
                    return false;
                else
                {
                    if (bs1.Length == bs2.Length)
                    {
                        for (int i = 0; i < bs1.Length; i++)
                        {
                            if (bs1[i] != bs2[i])
                            {
                                return false;
                            }
                        }
                        return true;
                    }
                    return false;
                }
            }
        }
    }
}

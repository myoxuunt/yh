using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public class CommuniSoftFactory
    {
        /// <summary>
        /// 
        /// </summary>
        private CommuniSoftFactory()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="settings"></param>
        /// <returns></returns>
        static public CommuniSoft Create(Hashtable settings)
        {
            if (CommuniSoft.Default == null)
            {
                CommuniSoft.Default = new CommuniSoft(settings);
            }
            return CommuniSoft.Default;
        }
    }
}

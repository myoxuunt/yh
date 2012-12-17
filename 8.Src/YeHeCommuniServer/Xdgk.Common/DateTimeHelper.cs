using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class DateTimeHelper
    {
        /// <summary>
        /// 
        /// </summary>
        private DateTimeHelper()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="datePart"></param>
        /// <param name="timePart"></param>
        /// <returns></returns>
        static public DateTime CombineDateTime(DateTime datePart, DateTime timePart)
        {
            return datePart.Date + timePart.TimeOfDay;
        }
    }
}

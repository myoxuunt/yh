using System;
using System.Collections.Generic;
using System.Text;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class DateTimePointOfFallCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="ts">间隔</param>
        /// <returns></returns>
        static public DateTime Calc(DateTime source, TimeSpan ts)
        {
            TimeSpan dayTs= source.TimeOfDay;
            int n = (int)(dayTs.TotalSeconds / ts.TotalSeconds);
            TimeSpan newDayTs = TimeSpan.FromSeconds(n * ts.TotalSeconds);

            return source.Date + newDayTs;
        }

        /// <summary>
        /// 
        /// </summary>
        static public void test()
        {
            for (int i = 0; i < 100; i++)
            {
                DateTime dt = DateTime.Now.Date + TimeSpan.FromMinutes(i);

                DateTime dt2 = Calc(dt, TimeSpan.FromMinutes(10));
                Console.WriteLine(dt.ToString() + " -> " + dt2.ToString());
            }
        }
    }
}

using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using YongShuiGuanLiDBI;
namespace ZB
{
    /// <summary>
    /// 
    /// </summary>
    public class A
    {
        /// <summary>
        /// 
        /// </summary>
        public void Do()
        {
            // devices
            //
            DeviceCollection devices = DeviceFactory.CreateDeviceCollection();

            // foreach device
            //
            foreach (DeviceClass d in devices)
            {
                DateTime dtlast = d.GetLastDateTimeForm10MinuteDataTable();
                DateTime begin = dtlast.Date + TimeSpan.FromDays(1d);
                DateTime end = DateTime.Now .Date ;
                for (DateTime temp = begin; temp < end; temp += TimeSpan.FromDays(1d))
                {
                    DataTable source = d.GetDitchData(temp, temp + TimeSpan.FromDays(1d));
                    DataTable dest = Create10MinuteDataTable(source);
                    if (dest != null && dest.Rows.Count > 0)
                    {
                        d.Write10MinuteDataTable(dest);
                    }
                }
            }
            // device last zb data dt
            //


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        private DataTable Create10MinuteDataTable(DataTable source)
        {
            if (source == null || source.Rows.Count  == 0)
                return null;

            DateTime dt = Convert.ToDateTime(source.Rows[0]["DT"]);

            DataTable dest = new DataTable();
            dest.Columns.Add("DT", typeof(DateTime));
            dest.Columns.Add("WL1", typeof(int));
            dest.Columns.Add("WL2", typeof(int));
            dest.Columns.Add("InstantFlux", typeof(int));
            dest.Columns.Add("UsedAmount", typeof(int));

            for (int i = 0; i < 144; i++)
            {
                DateTime destDT = dt.Date + TimeSpan.FromMinutes(i * 10);
                dest.Rows.Add(destDT);
            }

            foreach (DataRow row in source.Rows)
            {
                DateTime sDT = Convert.ToDateTime(row["DT"]);
                sDT = DateTimePointOfFallCalculator.Calc(sDT, TimeSpan.FromMinutes(10));
                object wl1 = row["wl1"];
                object f = row["instantflux"];
                object amount = row["usedAmount"];
                AddNewRow(dest, sDT, wl1, f, amount);
            }

            // fill null row
            //
            object stwl1 = source.Rows[0]["wl1"];
            object stif = source.Rows[0]["instantflux"];
            object stamount = source.Rows[0]["usedAmount"];

            foreach (DataRow row in dest.Rows)
            {
                object obj = row["wl1"];
                if (obj != DBNull.Value)
                {
                    stwl1 = row["wl1"];
                    stif = row["instantflux"];
                    stamount = row["usedAmount"];
                }
                else
                {
                    row["wl1"] = stwl1;
                    row["instantflux"] = stif;
                    row["usedAmount"] = stamount;
                }
            }
            return dest;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dest"></param>
        /// <param name="sDT"></param>
        /// <param name="wl1"></param>
        /// <param name="f"></param>
        /// <param name="amount"></param>
        private void AddNewRow(DataTable dest, DateTime sDT, object wl1, object f, object amount)
        {
            int idx = (int)(sDT.TimeOfDay.TotalMinutes / TimeSpan.FromMinutes (10).TotalMinutes );
            DataRow nr = dest.Rows[idx];
            nr["dt"] = sDT;
            nr["wl1"] = wl1;
            nr["instantflux"] = f;
            nr["usedAmount"] = amount;
        }
    }
}
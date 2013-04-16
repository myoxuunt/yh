
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data ;
using System.Data.SqlClient;


namespace PS6216DataImporter
{
    public class ToDevice : DeviceBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param deviceType="writeDelegate"></param>
        public ToDevice()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param deviceType="tbl"></param>
        public void WriteDataTable(DataTable tbl)
        {
            foreach (DataRow row in tbl.Rows)
            {
                WriteDataRow(row);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param deviceType="value"></param>
        /// <returns></returns>
        static private float MMToCM(float value)
        {
            return value / 10f;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param deviceType="value"></param>
        /// <returns></returns>
        static private float MToCM(float value)
        {
            return value * 100f;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param deviceType="obj"></param>
        /// <returns></returns>
        private object SafeFloat(object obj)
        {
            if (obj == null || obj == DBNull.Value)
            {
                return 0;
            }
            else
            {
                return obj;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param deviceType="row"></param>
        private void WriteDataRow(DataRow row)
        {
            DateTime dt = Convert.ToDateTime(row["记录时间"]);
            int wl = Convert.ToInt32(row["水位"]);
            float instantFlux = 123f;// Convert.ToSingle(row[""]);
            ((ToDBI)DBI).InsertDitchData(this.ID, dt, wl, instantFlux);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DateTime ReadLastDataDateTime()
        {
            ToDBI dbi = this.DBI as ToDBI;
            DateTime dt = dbi.ReadLastDitchDataDateTime(this.Name);
            return dt;
        }

    }

}

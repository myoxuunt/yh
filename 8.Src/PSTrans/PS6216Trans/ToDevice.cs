
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data ;
using System.Data.SqlClient;
using Common;


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
            DateTime dt = Convert.ToDateTime(row["¼ÇÂ¼Ê±¼ä"]);
            float wl = Convert.ToSingle(row["wl"]);
            wl = MMToCM(wl);

            float instantFlux = CalcInstantFlux(dt, wl);

            int intWL = Convert.ToInt32 ( wl );
            ((ToDBIForPs)DBI).InsertDitchData(this.ID, dt, intWL, instantFlux);
        }

        /// <summary>
        ///  TODO:
        /// </summary>
        /// <param name="wl"></param>
        /// <returns></returns>
        private float CalcInstantFlux(DateTime dt, float wl)
        {
            //throw new NotImplementedException();
            return DeviceFormaulManager.DevieFormaulCollectionMapCollection.CalcInstantFlux(this.ID, dt,
                Convert.ToInt32(wl), 0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DateTime ReadLastDataDateTime()
        {
            ToDBIForPs dbi = this.DBI as ToDBIForPs;
            DateTime dt = dbi.ReadLastDitchDataDateTime(this.Name);
            return dt;
        }

    }

}

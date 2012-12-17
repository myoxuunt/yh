using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace RWTrans
{
    public class WaterItem : Item
    {
        public override DateTime GetToLastDateTime()
        {
            DateTime dt = GetToDBI().GetLastDateTime(this.ToDeviceID, DataType.Water);
            return dt;
        }

        public override System.Data.DataTable GetTransmitDataTable(DateTime toLastDateTime)
        {
            DataTable tbl = GetFromDBI().GetWaterDataTable(this.FromID, toLastDateTime);
            return tbl;
        }

        public override void WriteTo(System.Data.DataTable tbl)
        {
            foreach (DataRow row in tbl.Rows)
            {
                DateTime dt = (DateTime)row["StringTime"];
                float water = Convert.ToSingle(row["水位值"]);

                water = MToCM(water);
                float instantFlux = CalcInstantFlux(ToDeviceID, dt, water);
                GetToDBI().InsertWater(ToDeviceID, dt, water, instantFlux);

                Log(ToDeviceID, dt, water, instantFlux);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ToDeviceID"></param>
        /// <param name="dt"></param>
        /// <param name="water"></param>
        /// <param name="instantFlux"></param>
        private void Log(int ToDeviceID, DateTime dt, float water, float instantFlux)
        {
            string s = string.Format("{0} : {1} : {2} : {3}", ToDeviceID, dt,water,instantFlux );

            App.Default.Logger.Add(s);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        static private float MToCM( float value )
        {
            return value * 100;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ToDeviceID"></param>
        /// <param name="dt"></param>
        /// <param name="water"></param>
        /// <returns></returns>
        private float CalcInstantFlux(int ToDeviceID, DateTime dt, float water)
        {
            float r = App.Default.DevieFormaulCollectionMapCollection.CalcInstantFlux(
                ToDeviceID, dt, Convert.ToInt32(water), 0);
            return r;
        }
    }
}

using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using Common;

namespace RWTrans
{
    public class RainItem : Item
    {
        public override DateTime GetToLastDateTime()
        {
            DateTime dt = GetToDBI().GetLastDateTime(this.ToDeviceID, DataType.Rain);
            return dt;
        }

        public override System.Data.DataTable GetTransmitDataTable(DateTime toLastDateTime)
        {
            DataTable tbl = GetFromDBI().GetRainDataTable(FromID, toLastDateTime);
            return tbl;
        }

        public override void WriteTo(System.Data.DataTable tbl)
        {
            foreach (DataRow row in tbl.Rows)
            {
                DateTime dt = (DateTime)row["StringTime"];
                float rain = Convert.ToSingle(row["降雨量"]);
                GetToDBI().InsertRain(ToDeviceID, dt, rain);
            }
        }
    }
}

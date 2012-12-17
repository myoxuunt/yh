using System;
using System.Collections.Generic;
using System.Text;
using System.Data ;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class DitchDataYearDBI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="de"></param>
        /// <returns></returns>
        static private string GetColumnName(DataEnum de)
        {
            switch (de)
            {
                case DataEnum.WL :
                    return "AVGWL";
                case DataEnum .Flux :
                    return "AVGFlux";
                case DataEnum.Amount:
                    return "DayAmount";
                default :
                    throw new ArgumentException("cannot find column name by '" + de + "'");
            }
        }

        /// <summary>
        /// 获取年报表数据
        /// </summary>
        /// <param name="year"></param>
        /// <param name="device"></param>
        /// <param name="de">数据标识</param>
        /// <returns></returns>
        static public DataTable ExecuteYearDataTable(int year, DeviceClass device, DataEnum de)
        {
            if (device == null)
            {
                throw new ArgumentNullException("station");
            }

            int deviceid = device.DeviceID;
            DateTime b = new DateTime(year, 1, 1);
            DateTime e = new DateTime(year + 1, 1, 1);
            string s = string.Format(
                "select * from tblDitchDataDay where deviceid = {0} and dt >= '{1}' and dt < '{2}' order by dt",
                deviceid, b, e);

            DataTable tbl = DBI.GetDBI().ExecuteDataTable(s);
            DataTable destTable = CreateDestDataTable();
            //
            //
            foreach (DataRow row in tbl.Rows)
            {
                DateTime dt = Convert.ToDateTime(row["dt"]);
                int month = dt.Month;
                int day = dt.Day;
                string columnName = GetColumnName(de);
                int value = Convert.ToInt32(row[columnName ]);

                int rowIndex = day - 1;
                // riqi 1 2 3 4 5 ... 12
                //
                int colIndex = month;
                DataRow destRow = destTable.Rows[rowIndex];
                destRow[colIndex] = value;
            }

            switch (de)
            {
                case DataEnum.WL :
                case DataEnum.Flux :
                    DataTableHelper.AddAvgRow(destTable, 1, new object[] { "平均" });
                    break;
                case DataEnum.Amount :
                    DataTableHelper.AddSumRow(destTable, 1, new object[] { "合计" });
                    break;

                default:
                    break;
            }
            return destTable;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static DataTable CreateDestDataTable()
        {
            // datatable columns:
            // 
            // day m1 m2 ... m12
            //
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Day", typeof(string));
            for (int i = 1; i <= 12; i++)
            {
                string columnName = string.Format("m{0}", i);
                tbl.Columns.Add(columnName, typeof(int));
            }

            for (int i = 1; i <= 31; i++)
            {
                string day = i.ToString();
                DataRow row = tbl.NewRow();
                row[0] = day;
                tbl.Rows.Add(row);
            }

            return tbl;
        }
    }
}

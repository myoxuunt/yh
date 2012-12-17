using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class DataTableConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public DataTable ConvertRowToColumn( DataTable source, string filterColumn,
            string valueColumn, string reserveColumn)
        {
            DataTable columnNameTable = source.DefaultView.ToTable(
                true, new string[] { filterColumn });

            // create new table 
            //
            DataTable desc = new DataTable();
            desc.Columns.Add(reserveColumn, typeof(DateTime));
            //int added = 0;
            foreach (DataRow columnNameRow in columnNameTable.Rows)
            {
                string name = columnNameRow[0].ToString();
                DataColumn col = desc.Columns.Add(name);
            }

            //
            foreach (DataRow row in source.Rows)
            {
                object value = row[valueColumn];
                object filterValue = row[filterColumn];
                object reserveValue = row[reserveColumn];

                if (desc.Columns.IndexOf(filterValue.ToString()) != -1)
                {
                    DataRow newrow = desc.NewRow();
                    newrow[reserveColumn] = reserveValue;
                    newrow[filterValue.ToString()] = value;

                    desc.Rows.Add(newrow);
                }
            }

            return desc;
        }
    }
}

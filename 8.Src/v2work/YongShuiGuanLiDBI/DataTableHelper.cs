using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class DataTableHelper
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tbl"></param>
        /// <param name="beginColumn"></param>
        /// <param name="preValues"></param>
        static public void AddSumRow(DataTable tbl, int beginColumn, object[] preValues)
        {
            AddCalcRow(tbl, beginColumn, preValues, "sum({0})");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tbl"></param>
        /// <param name="beginColumn"></param>
        /// <param name="preValues"></param>
        static public void AddAvgRow(DataTable tbl, int beginColumn, object[] preValues)
        {
            AddCalcRow(tbl, beginColumn, preValues, "avg({0})");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tbl"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        static public int[] GetIDs(DataTable tbl, string columnName)
        {
            ArrayList list = new ArrayList();
            foreach (DataRow row in tbl.Rows)
            {
                int id = Convert.ToInt32(row[columnName]);
                list.Add(id);
            }

            return (int[])list.ToArray(typeof(int));
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="tbl"></param>
        /// <param name="beginColumn"></param>
        /// <param name="preValues"></param>
        /// <param name="expressionFormat"></param>
        static public void AddCalcRow(DataTable tbl, int beginColumn, object[] preValues, string expressionFormat)
        {
            ArrayList list = new ArrayList();
            if (preValues != null && preValues.Length > 0)
            {
                list.AddRange(preValues);
            }
            for (int i = beginColumn; i < tbl.Columns.Count; i++)
            {
                string c = tbl.Columns[i].ColumnName;
                //string s = string.Format("avg({0})", c);
                string s = string.Format(expressionFormat, c);

                object obj = tbl.Compute(s, string.Empty);
                list.Add(obj);
            }
            tbl.Rows.Add(list.ToArray());

        }
    }
}

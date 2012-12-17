using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;
using System.Text;
using Xdgk.Common;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class WaterUserCollection : Collection<WaterUserClass>
    {
        ///// <summary>
        ///// 获取阶段用水量, 以日为单位
        ///// </summary>
        ///// <returns></returns>
        //public DataTable GetUsedAmount(DateTime begin ,DateTime end)
        //{
        //    foreach (WaterUserClass wuc in this)
        //    {
        //        //double 
        //            //wuc.CalcUsedAmount(begin, end);
        //    }

        //    DitchDataDayDBI.GetDayDataTable (begin, end,
        //}

        #region GetMultiYearAmount
        /// <summary>
        /// 获取历年用水量表
        /// </summary>
        /// <param name="yearBegin"></param>
        /// <param name="yearEnd"></param>
        /// <returns></returns>
        public DataTable GetMultiYearAmount(int yearBegin, int yearEnd)
        {
            DataTable tbl = CreateTable(yearBegin, yearEnd);

            foreach (WaterUserClass w in this)
            {
                for (int i = yearBegin; i <= yearEnd; i++)
                {
                    DateTime b = new DateTime(i, 1, 1);
                    DateTime e = new DateTime(i + 1, 1, 1);
                    double a = w.CalcUsedAmount(b, e);
                    SetValue(tbl, i, w.Name, a);
                }
            }

            return tbl;
        }
        #endregion //GetMultiYearAmount

        #region SetValue
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tbl"></param>
        /// <param name="i"></param>
        /// <param name="p"></param>
        /// <param name="a"></param>
        private void SetValue(DataTable tbl, int year, string name, double value)
        {
            foreach (DataRow  row in tbl.Rows )
            {
                if (row["年份"].ToString() == year.ToString())
                {
                    row[name] = value;
                }
            }
        }
        #endregion //SetValue

        #region CreateTable
        /// <summary>
        /// 
        /// </summary>
        /// <param name="yearBegin"></param>
        /// <param name="yearEnd"></param>
        /// <returns></returns>
        private DataTable CreateTable(int yearBegin, int yearEnd)
        {
            DataTable t = new DataTable();
            t.Columns.Add("年份", typeof(string));

            foreach (WaterUserClass w in this)
            {
               DataColumn c = t.Columns.Add(w.Name, typeof(double));
               c.DefaultValue = 0d;
            }

            for (int i = yearBegin ; i <= yearEnd ; i++)
            {
                DataRow r = t.NewRow();
                r["年份"] = i.ToString();
                t.Rows.Add(r);
            }
            return t;
        }
        #endregion //CreateTable

        #region CreateDuringDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <param name="duringCollection"></param>
        /// <returns></returns>
        private DataTable CreateDuringDataTable(DuringWaterCollection duringCollection)
        {
            DataTable t = new DataTable();
            t.Columns.Add ("放水季",typeof(string));
            t.Columns.Add("开始日期", typeof(string));
            t.Columns.Add("结束日期", typeof(string));

            foreach (WaterUserClass w in this)
            {
               DataColumn c = t.Columns.Add(w.Name, typeof(double));
               c.DefaultValue = 0d;
            }
            foreach (DuringWaterClass  d in duringCollection)
            {
                DataRow r = t.NewRow();
                r[0] = d.Name;
                r[1] = d.BeginString;
                r[2] = d.EndString;
                t.Rows.Add(r);
            }
            return t;
        }
        #endregion //CreateDuringDataTable

        #region GetMultiDuringAmount
        /// <summary>
        /// 
        /// </summary>
        /// <param name="year"></param>
        /// <param name="d"></param>
        public DataTable GetMultiDuringAmount(int year, DuringWaterCollection duringCollection)
        {
            DataTable t = CreateDuringDataTable(duringCollection);
            foreach (WaterUserClass w in this)
            {
                foreach( DuringWaterClass d in duringCollection )
                {
                    DateTime b = new DateTime(year, d.Begin.Month, d.Begin.Day);
                    DateTime e = new DateTime(year, d.End.Month, d.End.Day);
                    double a = w.CalcUsedAmount(b, e);

                    AddDuringWaterValue(t, d, w.Name, a);
                }
            }
            return t;
        }
        #endregion //GetMultiDuringAmount

        #region AddDuringWaterValue
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <param name="d"></param>
        /// <param name="p"></param>
        /// <param name="a"></param>
        private void AddDuringWaterValue(DataTable t, DuringWaterClass d, string waterUserName, double amount)
        {
            foreach (DataRow row in t.Rows)
            {
                string duringName = row[0].ToString();
                if (duringName == d.Name)
                {
                    row[waterUserName] = amount;
                }
            }
        }
        #endregion //AddDuringWaterValue

        #region GetNeedWaterDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <param name="b"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public DataTable GetNeedWaterDataTable(DateTime b, DateTime e)
        {
            DataTable r = null;
            foreach (WaterUserClass wu in this)
            {
                DataTable tbl = NeedWaterDBI.GetNeedWaterByWaterUser(wu.WaterUserID, b, e);
                if (r == null)
                {
                    r = tbl;
                }
                else
                {
                    r.Merge(tbl);
                }
            }
            return r; 
        }
        #endregion //GetNeedWaterDataTable

        #region GetDistributeWaterDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public DataTable GetDistributeWaterDataTable(DateTime begin, DateTime end)
        {
            DataTable r = null;
            foreach (WaterUserClass w in this )
            {
                DataTable t = DistributeDBI.GetDistributeDataTable(w.WaterUserID, begin, end);
                if (r == null)
                {
                    r = t;
                }
                else
                {
                    r.Merge(t);
                }
            }
            return r;
        }
        #endregion //GetDistributeWaterDataTable

        #region GetFeeDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public DataTable GetFeeDataTable(DateTime begin, DateTime end)
        {
            DataTable result = null;
            foreach (WaterUserClass u in this)
            {
                DataTable tbl = u.GetFeeDataTable(begin, end);
                if (result == null)
                {
                    result = tbl;
                }
                else
                {
                    result.Merge(tbl);
                }
            }
            return result;
        }
        #endregion //GetFeeDataTable

        #region GetFeeHistoryDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public DataTable GetFeeHistoryDataTable(DateTime begin, DateTime end)
        {
            int[] ids = GetWaterUserIDs();
            DataTable tbl = FeeDBI.GetFeeHistory(ids, begin, end);
            return tbl;
        }
        #endregion //GetFeeHistoryDataTable

        #region GetWaterUserIDs
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private int[] GetWaterUserIDs()
        {
            ArrayList list = new ArrayList();
            foreach (WaterUserClass u in this)
            {
                list.Add(u.WaterUserID);
            }
            return (int[])list.ToArray(typeof(int));
        }
        #endregion //GetWaterUserIDs

        /// <summary>
        /// DataTable =>
        /// 
        /// | WaterUserName | Begin | End | UsedAmount |
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public DataTable CalcUsedWaterAmount(DateTime begin, DateTime end)
        {
            DataTable tbl = CreateUsedWaterAmount();
            foreach (WaterUserClass wu in this)
            {
                double amount = wu.CalcUsedAmount(begin, end);
                AddWaterUserAmount(tbl, wu.Name, begin, end, Convert.ToInt32(amount));
            }
            return tbl;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private DataTable CreateUsedWaterAmount()
        {
            DataTable t = new DataTable();
            t.Columns.Add("WaterUserName",typeof(string));
            t.Columns.Add("Begin", typeof(DateTime));
            t.Columns.Add("End", typeof(DateTime));
            t.Columns.Add("UsedAmount", typeof(Int32));
            return t;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <param name="wuName"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="usedAmount"></param>
        private void AddWaterUserAmount(DataTable t, string wuName, DateTime begin, DateTime end, Int32 usedAmount)
        {
            t.Rows.Add(wuName, begin, end, usedAmount);
        }
    }
}

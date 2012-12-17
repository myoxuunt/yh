using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class FormulaDBI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceID"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="formulaString"></param>
        static public void Insert(int deviceID, DateTime begin, DateTime end, string formulaString)
        {
            DateTime b = new DateTime(2000, begin.Month, begin.Day);
            DateTime e = new DateTime(2000, end.Month, end.Day);

            string s = string.Format(
                "INSERT INTO tblFormula(DeviceID, DTBegin, DTEnd, Formula) " +
                "VALUES('{0}', '{1}', '{2}', '{3}')",
                deviceID, b, e, formulaString);

            DBI.GetDBI().ExecuteScalar(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="formulaID"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="formulaString"></param>
        static public void Update(int formulaID, DateTime begin, DateTime end, string formulaString)
        {
            DateTime b = new DateTime(2000, begin.Month, begin.Day);
            DateTime e = new DateTime(2000, end.Month, end.Day);
            string s = string.Format(
                "update tblFormula " +
                "set DTBegin='{1}', DTEnd='{2}', Formula = '{3}' " +
                "where formulaID = {0}",
                formulaID, b, e, formulaString);

            DBI.GetDBI().ExecuteScalar(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="formulaID"></param>
        static public void Delete(int formulaID)
        {
            string s = string.Format(
                "delete from tblFormula where formulaID = {0}", formulaID);

            DBI.GetDBI().ExecuteScalar(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceID"></param>
        /// <returns></returns>
        static public DataTable GetDataTable(int deviceID)
        {
            string s = string.Format(
                "select * from tblFormula where deviceid = {0}",
                deviceID);

            return DBI.GetDBI().ExecuteDataTable(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="formulaID"></param>
        /// <returns></returns>
        internal static DataTable GetDataTableByFormulaID(int formulaID)
        {
            string s = string.Format(
                "select * from tblFormula where formulaID = {0}",
                formulaID);

            return DBI.GetDBI().ExecuteDataTable(s);
        }
    }
}

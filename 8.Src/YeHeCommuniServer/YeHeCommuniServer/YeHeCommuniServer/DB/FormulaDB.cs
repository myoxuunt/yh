using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace YeHeCommuniServer.DB
{
    /// <summary>
    /// 
    /// </summary>
    public class FormulaDB
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceid"></param>
        /// <returns></returns>
        static public DataTable GetFormulaDataTable(int deviceid)
        {
            string s = string.Format(
                "select * from tblFormula where deviceID = {0}",
                deviceid);
            return CSDBI.Instance.ExecuteDataTable(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceid"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="express"></param>
        static public int InsertFormula(int deviceid, DateTime begin, DateTime end, string express)
        {
            string s = string.Format(
                "insert into tblFormula(deviceid, dtbegin, dtend, formula) values ({0}, '{1}', '{2}' , '{3}' );" +
                "select @@identity",
                deviceid, begin, end, express 
                );

            object obj = CSDBI.Instance.ExecuteScalar(s);
            if (obj != null && obj != DBNull.Value)
            {
                return Convert.ToInt32(obj);
            }
            throw new Exception("Insert formula fail.");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="express"></param>
        static public void UpdateFormula(int id, DateTime begin, DateTime end, string express)
        {
            string s = string.Format(
                "update tblFormula set dtbegin = '{1}', dtend = '{2}', formula = '{3}' where formulaid = {0}",
                id, begin, end, express );
            CSDBI.Instance.ExecuteScalar(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        static public void delete(int id)
        {
            string s = string.Format(
                "delete from tblformula where formulaid = {0}", 
                id);
            CSDBI.Instance.ExecuteScalar(s);
        }
    }
}

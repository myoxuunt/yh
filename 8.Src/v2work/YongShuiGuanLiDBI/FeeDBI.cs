using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class FeeDBI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        static public double GetPayedFee(int waterUserID, DateTime begin, DateTime end)
        {
            string s = string.Format(
                "select sum(totalPrice) from tblFee " +
                "where wateruserid = {0} and ( beginDT >='{1}' and endDT < '{2}')",
                waterUserID, begin, end);

            object obj = DBI.GetDBI().ExecuteScalar(s);
            if (obj != null && obj != DBNull.Value)
            {
                return Convert.ToDouble(obj);
            }
            else
            {
                return 0d;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        internal static DataTable GetFeeHistory(int[] waterUserIDs, DateTime begin, DateTime end)
        {
            string inCondition = SqlHelper.MakeInQueryCondition(waterUserIDs);

            string s = string.Format(
                "select * from vFee where waterUserID in ({0}) and beginDT >= '{1}' and beginDT < '{2}'",
                inCondition, begin, end);

            DataTable tbl = DBI.GetDBI().ExecuteDataTable(s);
            return tbl;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="feeID"></param>
        /// <returns></returns>
        static public DataTable GetFeeDataTableWithFeeID(int feeID)
        {
            string s = string.Format(
                "select * from vFee where feeID = {0}",
                feeID);
            return DBI.GetDBI().ExecuteDataTable(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserID"></param>
        /// <param name="feeName"></param>
        /// <param name="beginDT"></param>
        /// <param name="endDT"></param>
        /// <param name="unitPrice"></param>
        /// <param name="totalPrice"></param>
        /// <param name="usedAmount"></param>
        /// <param name="remark"></param>
        static public void InsertFee(int waterUserID, string feeName, DateTime beginDT, DateTime endDT, int tianShu,
            double unitPrice,  double waterAmount, double waterLost, double usedWater, double usedPrice,
            double payPrice,double leftPrice, string remark)
        {
            string format =
            "INSERT INTO tblFee(WaterUserID, FeeName, BeginDT, EndDT, NumberOfDay, " +
            "UnitPrice, WaterAmount, WaterLost, UsedWater, UsedPrice, " +
            "PayPrice, LeftPrice, Remark)" +
            "VALUES('{0}', '{1}', '{2}', '{3}', {4}, " + 
            "'{5}', '{6}', '{7}', '{8}' ,'{9}', " +
            "'{10}','{11}', '{12}') ";

            string sql = string.Format(
                format,
                waterUserID, feeName, beginDT, endDT, tianShu,
                unitPrice, waterAmount, waterLost, usedWater, usedPrice,
                payPrice, leftPrice, remark);

            DBI.GetDBI().ExecuteScalar(sql);
        }

        static public void UpdateFee(int feeID, int waterUserID, string feeName, DateTime beginDT, DateTime endDT, int tianShu,
            double unitPrice,  double waterAmount, double waterLost, double usedWater, double usedPrice,
            double payPrice,double leftPrice, string remark)
        {
            string format =
"UPDATE tblFee SET "+
"WaterUserID='{1}', FeeName='{2}', BeginDT='{3}', EndDT='{4}', NumberOfDay={5}, " +
"UnitPrice='{6}', WaterAmount='{7}', waterLost='{8}', usedWater = '{9}',usedPrice='{10}', " +
"PayPrice='{11}',LeftPrice='{12}', remark = '{13}'" +
"WHERE feeID = '{0}'";
            string s = string.Format(format, feeID, waterUserID, feeName, beginDT, endDT, tianShu,
            unitPrice, waterAmount, waterLost, usedWater, usedPrice,
            payPrice, leftPrice, remark);
            DBI.GetDBI().ExecuteScalar(s);
        }

        /// <summary>
        /// 
        /// </summary>
        static public void DeleteFee(int feeID)
        {
            string s = "delete from tblFee where FeeID = " + feeID;
            DBI.GetDBI().ExecuteDataTable(s);
        }
    }
}

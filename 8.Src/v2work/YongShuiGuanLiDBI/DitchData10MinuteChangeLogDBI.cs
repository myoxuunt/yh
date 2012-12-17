using System;
using System.Collections.Generic;
using System.Text;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class DitchData10MinuteChangeLogDBI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ditchData10MinuteID"></param>
        /// <param name="newWL"></param>
        /// <param name="loginUserName"></param>
        static public void AddDitchData10MinuteChangeItem(int ditchData10MinuteID, int newWL, string loginUserName)
        {
            int oldWL = DitchData10MinuteDBI.GetWLByID(ditchData10MinuteID);
            AddDitchData10MinuteChangeItem(ditchData10MinuteID, oldWL, newWL, loginUserName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newWL"></param>
        static public void AddDitchData10MinuteChangeItem(int ditchData10MinuteID, int oldWL, int newWL, string loginUserName)
        {
            string s = string.Format(
                "insert into tblDitchData10MinuteChangeLog(DitchData10MinuteID, ChangeDT, LoginName, OldWL, NewWL) values({0}, '{1}', '{2}', {3}, {4})",
                ditchData10MinuteID, DateTime.Now, loginUserName, oldWL, newWL);
            DBI.GetDBI().ExecuteScalar(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="WaterUserName"></param>
        /// <returns></returns>
        public static System.Data.DataTable GetChangeLog(string loginUserName)
        {
            string s = string.Format(
                "select * from vDitchData10MinuteChangedLog",
                loginUserName);
            return DBI.GetDBI().ExecuteDataTable(s);
        }
    }
}

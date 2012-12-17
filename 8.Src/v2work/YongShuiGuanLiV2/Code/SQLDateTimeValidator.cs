using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace YongShuiGuanLiV2
{
    /// <summary>
    /// 
    /// </summary>
    public class SQLDateTimeValidator
    {
        /// <summary>
        /// 
        /// </summary>
        static public readonly DateTime MinSQLDateTime = DateTime.Parse("1753-1-1");
        /// <summary>
        /// 
        /// </summary>
        static public readonly DateTime MaxSQLDateTime = DateTime.Parse("9999-12-31");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        static public bool VerifyDateTime(string datetime)
        {
            DateTime result;
            bool b = DateTime.TryParse(datetime, out result);
            if (b)
            {
                return VerifyDateTime(result);
            }
            else
            {
                return b;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        static public bool VerifyDateTime(DateTime datetime)
        {
            return (datetime > MinSQLDateTime) && (datetime < MaxSQLDateTime);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        static public bool VerifyYear(string year)
        {
            int result;
            bool b = int.TryParse(year, out result);
            if (b)
            {
                return VerifyYear(result);
            }
            return b;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        static public bool VerifyYear(int year)
        {
            return (year > MinSQLDateTime.Year) &&
                (year < MaxSQLDateTime.Year);
        }
    }
}

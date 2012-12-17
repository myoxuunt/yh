using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;

namespace XDYHZKWeb
{
    /// <summary>
    /// 
    /// </summary>
    public class SqlDB
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public int GetLastID(string tableName)
        {
            string str = string.Format("select top 1 SluiceDataID from {0} order by SluiceDataID desc", tableName);
            DataTable dt = DBcon.Instance.GetDataTable(str);
            if (dt.Rows.Count == 0)
                return 0;
            else 
                return int.Parse(dt.Rows[0][0].ToString());
        }



        public string UpDateZMDatas(DataTable dt, string tableName)
        {
            string strRecord = "";
            try
            {
                switch (tableName)
                {
                    case "Fx":
                        strRecord = "recordOK";
                        break;
                    case "Wl":
                        strRecord = "recordOK";
                        break;
                    case "Zm":
                        strRecord = "recordOK";
                        break;
                    default:
                        strRecord = "fail";
                        break;
                }
                SqlUpDateTable sqlUpDate = new SqlUpDateTable(dt,tableName);
                sqlUpDate.SqlStart();
                return strRecord;
            }
            catch (Exception ex)
            {
                return "fail";
            }
        }
    }
}

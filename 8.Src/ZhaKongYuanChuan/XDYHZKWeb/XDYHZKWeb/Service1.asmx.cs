using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Configuration;
using System.Reflection;
namespace XDYHZKWeb
{
    /// <summary>
    /// Service1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {
        /// <summary>
        /// 
        /// </summary>
        public Service1()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public string GetDescription()
        {
            return "YeHeYuanChuan web server, V1.1.0.0";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        //[WebMethod]
        private DateTime GetLastDateTime(string tableName)
        {
            return XDYHZKWebDBI.Default.GetLastDataTime(tableName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DateTime GetSluiceDataLastDateTime()
        {
            string tn = "tblSluiceData";
            return GetLastDateTime(tn);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="table"></param>
        [WebMethod]
        public void InsertSluiceData(DataTable table)
        {
            XDYHZKWebDBI.Default.InsertSluiceDatas(table);
        }

        //[WebMethod]
        //public DataTable GetTestDataTable()
        //{
        //    return XDYHZKWebDBI.Default.GetTestDataTable();
        //}
    }
}

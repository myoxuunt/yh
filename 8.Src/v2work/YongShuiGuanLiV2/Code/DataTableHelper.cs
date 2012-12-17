using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace YongShuiGuanLiV2
{
    /// <summary>
    /// 
    /// </summary>
    public class DataTableHelper
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns></returns>
        static public bool IsIncludeColumn(DataTable tbl, string columnName)
        {
            int idx = tbl.Columns.IndexOf(columnName);
            return idx >= 0;
        }

        /// <summary>
        /// 返回存在的列名称
        /// </summary>
        /// <param name="tbl"></param>
        /// <param name="columnNames"></param>
        /// <returns></returns>
        static public string GetExistColumnName(DataTable tbl, params  string[] columnNames)
        {
            string exist = string.Empty;
            foreach (string s in columnNames)
            {
                if (tbl.Columns.IndexOf(s) != -1)
                {
                    exist = s;
                    break;
                }
            }
            if (exist == string.Empty)
            {
                throw new InvalidOperationException(
                    string.Format("not find column in datatable")
                    );
            }

            return exist;
        }

    }
}

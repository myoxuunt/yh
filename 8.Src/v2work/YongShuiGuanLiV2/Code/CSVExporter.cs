using System;
using System.IO;
using System.Text;
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
    public class CSVExporter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tbl"></param>
        /// <param name="title"></param>
        /// <param name="columns"></param>
        /// <param name="headers"></param>
        static public void Export(Page page, DataTable tbl, string title, string[] columns, string[] headers, string file)
        {
            string s = page.Server.MapPath(file);
            StreamWriter sw = new StreamWriter(s, false, Encoding.Default);
            sw.WriteLine(title);

            string header = string.Join(",", headers);
            sw.WriteLine(header);

            foreach (DataRow row in tbl.Rows)
            {
                string line = string.Empty;
                foreach (string colName in columns)
                {
                    line += row[colName].ToString() + ",";
                }
                sw.WriteLine(line);
            }

            sw.Flush();
            sw.Close();
            page.Response.Redirect("~/" + file);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="tbl"></param>
        /// <param name="title"></param>
        static public void Export(Page page, DataTable tbl, string title, string file)
        {
            string[] columns = new string[tbl.Columns.Count];
            for (int i = 0; i < tbl.Columns.Count; i++)
            {
                DataColumn col = tbl.Columns[i];
                columns[i] = col.ColumnName;
            }

            Export(page, tbl, title, columns, columns, file);
        }
    }

}

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
    public class ExcelExporter
    {
        static public void ExportToExcel(Control ctl)
        {
            long n = DateTime.Now.ToBinary ();
            if (n < 0)
            {
                n = 0 - n;
            }
            string filename = string.Format("{0}.xls", n);
            ExportToExcel(ctl, filename);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="excelFileName"></param>
        static public void ExportToExcel(Control ctl, string fileName)
        {
            HttpContext.Current.Response.Charset = "UTF-8";
            HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.UTF8;
            HttpContext.Current.Response.ContentType = "application/ms-excel";
            HttpContext.Current.Response.AppendHeader("Content-Disposition", 
                "attachment;filename=" + "" + fileName);
            ctl.Page.EnableViewState = false;
            System.IO.StringWriter tw = new System.IO.StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(tw);
            ctl.RenderControl(hw);
            HttpContext.Current.Response.Write(tw.ToString());
            HttpContext.Current.Response.End();
        }
    }
}

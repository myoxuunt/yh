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
    ///// <summary>
    ///// 
    ///// </summary>
    //public class GridViewHelper
    //{
    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    /// <param name="gridview"></param>
    //    /// <param name="nts"></param>
    //    static public void SetGridViewColumn(GridView gridview, ColumnNameTextCollection nts)
    //    {
    //        gridview.Columns.Clear();

    //        foreach( ColumnNameText item in nts )
    //        {
    //            BoundField bf = new BoundField();
    //            bf.DataField = item.Name;
    //            bf.HeaderText = item.Text ;
    //            bf.ItemStyle.Width = 200;
    //            gridview.Columns.Add(bf);
    //        }
    //    }

    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    static public void AddEditDeleteColumn(GridView gridview)
    //    {
    //        CommandField delete = new CommandField();
    //        delete.ShowDeleteButton = true;
    //        //delete.HeaderText = "[Delete]";

    //        // TODO: 
    //        //
    //        delete.DeleteText = "<div onclick=\"JavaScript:return confirm('确定删除吗？')\">删除</div>";

    //        CommandField edit = new CommandField();
    //        edit.ShowEditButton = true;

    //        gridview.Columns.Add(delete);
    //        gridview.Columns.Add(edit);

    //    }
    //}
}

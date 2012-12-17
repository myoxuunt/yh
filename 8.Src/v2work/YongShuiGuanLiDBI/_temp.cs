using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls ;

namespace YongShuiGuanLiDBI
{

    /// <summary>
    /// 
    /// </summary>
    public class ColumnNameTextManager
    {

        #region ChannelList
        /// <summary>
        /// 
        /// </summary>
        static public ColumnNameTextCollection ChannelList
        {
            get
            {
                if (_channelList == null)
                {
                    string[] names = new string[] { "ChannelName", "Remark" };
                    string[] texts = new string[] { "渠道名称", "备注" };
                    _channelList = Create(names, texts);
                }
                return _channelList;
            }
        } static private ColumnNameTextCollection _channelList;
        #endregion //ChannelList




        #region WaterUserListColumnNames
        /// <summary>
        /// 
        /// </summary>
        static public ColumnNameTextCollection WaterUserListColumnNames
        {
            get
            {
                if (_waterUserList == null)
                {
                    string[] names = new string[] { "WaterUserName", "WaterUserTypeName", "Remark" };
                    string[] texts = new string[] { "名称", "用水类别", "备注" };
                    _waterUserList = Create(names, texts);
                }
                return _waterUserList;
            }
        } static private ColumnNameTextCollection _waterUserList;
        #endregion //WaterUserListColumnNames


        #region Create
        /// <summary>
        /// 
        /// </summary>
        /// <param name="?"></param>
        /// <param name="texts"></param>
        /// <returns></returns>
        private static ColumnNameTextCollection Create(string[] names, string[] texts)
        {
            ColumnNameTextCollection s = new ColumnNameTextCollection();
            for (int i = 0; i < names.Length; i++)
            {
                ColumnNameText item = new ColumnNameText();
                item.Name = names[i];
                item.Text = texts[i];
                s.Add(item);
            }
            return s;
        }
        #endregion //Create


        #region LastDataColumnNames
        /// <summary>
        /// 
        /// </summary>
        static public ColumnNameTextCollection LastDataColumnNames
        {
            get
            {
                if (_lastDataColumnNames == null)
                {
                    string[] names = new string[] { "StationName", "DT","WL1","WL2", "InstantFlux"};
                    string[] texts = new string[] { "站名","时间","水位1","水位2", "瞬时流量"};
                    _lastDataColumnNames = Create(names, texts);
                }
                return _lastDataColumnNames;
            }
        } static private ColumnNameTextCollection _lastDataColumnNames;
        #endregion //LastDataColumnNames


        /// <summary>
        /// 水位历史数据
        /// </summary>
        static public ColumnNameTextCollection WLHistoryColumnNames
        {
            get
            {
                string[] names = new string[] { "StationName", "DT", "WL1" };
                string[] texts = new string[] { "站名", "时间", "水位" };
                return Create(names, texts);
            }
        }



        /// <summary>
        /// 流量历史数据
        /// </summary>
        static public ColumnNameTextCollection FluxHistoryColumnNames
        {
            get
            {
                string[] names = new string[] { "StationName", "DT", "InstantFlux" };
                string[] texts = new string[] { "站名", "时间", "流量" };
                return Create(names, texts);
            }
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public class ColumnNameTextCollection : System.Collections.Generic.List<ColumnNameText>
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public class ColumnNameText
    {
        #region Name
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        } private string _name;
        #endregion //Name

        #region Text
        /// <summary>
        /// 
        /// </summary>
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        } private string _text;
        #endregion //Text


        /// <summary>
        /// 
        /// </summary>
        public Unit Width
        {
            get
            {
                if (_width == null)
                {
                    _width = new Unit();
                }
                return _width;
            }
            set
            {
                _width = value;
            }
        } private Unit _width;
    }
    /// <summary>
    /// 
    /// </summary>
    public class GridViewHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="gridview"></param>
        /// <param name="nts"></param>
        static public void SetGridViewColumn(GridView gridview, ColumnNameTextCollection nts)
        {
            gridview.Columns.Clear();

            foreach( ColumnNameText item in nts )
            {
                BoundField bf = new BoundField();
                bf.DataField = item.Name;
                bf.HeaderText = item.Text ;
                bf.ItemStyle.Width = 200;
                gridview.Columns.Add(bf);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        static public void AddEditDeleteColumn(GridView gridview)
        {
            CommandField delete = new CommandField();
            delete.ShowDeleteButton = true;
            //delete.HeaderText = "[Delete]";

            // TODO: 
            //
            delete.DeleteText = "<div onclick=\"JavaScript:return confirm('确定删除吗？')\">删除</div>";

            CommandField edit = new CommandField();
            edit.ShowEditButton = true;

            gridview.Columns.Add(delete);
            gridview.Columns.Add(edit);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gridview"></param>
        static public void AddEditColumn(GridView gridview)
        {
            CommandField edit = new CommandField();
            edit.ShowEditButton = true;

            gridview.Columns.Add(edit);
        }
    }
}

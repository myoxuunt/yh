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
                    string[] texts = new string[] { strings.ChannelName, strings.Remark };
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
}

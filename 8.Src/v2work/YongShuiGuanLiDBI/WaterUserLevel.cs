using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Common;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks >
    /// 对应数据库中的数值(tblWaterUserLevel.Ordianl)
    /// </remarks>
    public enum WaterUserLevelEnum
    {
        /// <summary>
        /// 局
        /// </summary>
        Ju = 5,
        /// <summary>
        /// 处
        /// </summary>
        Chu = 4,
        /// <summary>
        /// 所
        /// </summary>
        Suo = 3,
        /// <summary>
        /// 村
        /// </summary>
        Cun = 2,
        /// <summary>
        /// 斗口
        /// </summary>
        DouKou = 1,
    }

    /// <summary>
    /// 
    /// </summary>
    public class WaterUserLevel
    {

        #region WaterUserLevelID
        /// <summary>
        /// 
        /// </summary>
        public int WaterUserLevelID
        {
            get
            {
                return _waterUserLevelID;
            }
            set
            {
                _waterUserLevelID = value;
            }
        } private int _waterUserLevelID;
        #endregion //WaterUserLevelID

        #region WaterUserLevel
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="remark"></param>
        /// <param name="ordinal"></param>
        public WaterUserLevel(int id, string name, string remark, int ordinal)
        {
            this.WaterUserLevelID = id;
            this.LevelName = name;
            this.LevelRemark = remark;
            this.LevelOrdinal = ordinal;
        }
        #endregion //WaterUserLevel

        #region LevelName
        /// <summary>
        /// 
        /// </summary>
        public string LevelName
        {
            get
            {
                if (_levelName == null)
                {
                    _levelName = string.Empty;
                }
                return _levelName;
            }
            set { _levelName = value; }
        } private string _levelName;
        #endregion //LevelName

        #region LevelRemark
        /// <summary>
        /// 
        /// </summary>
        public string LevelRemark
        {
            get
            {
                if (_levelRemark == null)
                {
                    _levelRemark = string.Empty;
                }
                return _levelRemark; 
            }
            set { _levelRemark = value; }
        } private string _levelRemark;
        #endregion //LevelRemark

        #region LevelOrdinal
        /// <summary>
        /// 
        /// </summary>
        public int LevelOrdinal
        {
            get { return _levelOrdinal; }
            set { _levelOrdinal = value; }
        } private int _levelOrdinal;
        #endregion //LevelOrdinal

        #region Greater
        /// <summary>
        /// 
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        static public bool Greater(WaterUserLevel l1, WaterUserLevel l2)
        {
            return l1.LevelOrdinal > l2.LevelOrdinal;
        }
        #endregion //Greater

        #region Equal
        /// <summary>
        /// 
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        static public bool Equal(WaterUserLevel l1, WaterUserLevel l2)
        {
            return l1.LevelOrdinal == l2.LevelOrdinal;
        }
        #endregion //Equal

        #region Less
        /// <summary>
        /// 
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        static public bool Less(WaterUserLevel l1, WaterUserLevel l2)
        {
            return l1.LevelOrdinal < l2.LevelOrdinal;
        }
        #endregion //Less

        #region All
        /// <summary>
        /// 
        /// </summary>
        static public WaterUserLevelCollection All
        {
            get
            {
                if (_waterUserLevelCollection == null)
                {
                    _waterUserLevelCollection = WaterUserLevelFactory.CreateWaterUserLevelCollection();
                }
                return _waterUserLevelCollection;
            }
        } static private WaterUserLevelCollection _waterUserLevelCollection;
        #endregion //All

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        static public WaterUserLevel GetWaterUserLevel(WaterUserLevelEnum e)
        {
            foreach (WaterUserLevel l in All)
            {
                if (l.LevelOrdinal == (int)e)
                {
                    return l;
                }
            }

            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public WaterUserLevel GetNoneLevel()
        {
            return new WaterUserLevel(0, "<NoneWaterUserLevel>", "", 0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsTopManager()
        {
            return this.LevelOrdinal == (int)WaterUserLevelEnum.Ju;
        }
    }
}

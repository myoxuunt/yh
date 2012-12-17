using System;
using System.Collections.Generic;
using System.Text;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class WaterUserType
    {
        #region WaterUserTypeID
        /// <summary>
        /// 
        /// </summary>
        public int WaterUserTypeID
        {
            get
            {
                return _waterUserTypeID;
            }
            set
            {
                _waterUserTypeID = value;
            }
        } private int _waterUserTypeID;
        #endregion //WaterUserTypeID

        #region WaterUserTypeName
        /// <summary>
        /// 
        /// </summary>
        public string WaterUserTypeName
        {
            get
            {
                if (_waterUserTypeName == null)
                {
                    _waterUserTypeName = string.Empty;
                }
                return _waterUserTypeName;
            }
            set
            {
                _waterUserTypeName = value;
            }
        } private string _waterUserTypeName;
        #endregion //WaterUserTypeName

        #region WaterUserTypeRemark
        /// <summary>
        /// 
        /// </summary>
        public string WaterUserTypeRemark
        {
            get
            {
                if (_waterUserTypeRemark == null)
                {
                    _waterUserTypeRemark = string.Empty;
                }
                return _waterUserTypeRemark;
            }
            set
            {
                _waterUserTypeRemark = value;
            }
        } private string _waterUserTypeRemark;
        #endregion //WaterUserTypeRemark

        //#region IsManager
        ///// <summary>
        ///// 
        ///// </summary>
        //public int IsManager
        //{
        //    get
        //    {
        //        return _isManager;
        //    }
        //    set
        //    {
        //        _isManager = value;
        //    }
        //} private int _isManager;
        //#endregion //IsManager

        //#region All
        ///// <summary>
        ///// 
        ///// </summary>
        //static public WaterUserTypeCollection All
        //{
        //    get
        //    {
        //        if (_waterUserTypeCollection == null)
        //        {
        //            _waterUserTypeCollection = WaterUserTypeFactory.CreateWaterUserTypeCollection();
        //        }
        //        return _waterUserTypeCollection;
        //    }
        //} static private WaterUserTypeCollection _waterUserTypeCollection;
        //#endregion //All

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //static public WaterUserType GetManagerWaterUserType()
        //{
        //    return WaterUserTypeFactory.CreateManagerWaterUserType();
        //}
    }
}

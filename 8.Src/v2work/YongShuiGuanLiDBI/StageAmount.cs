using System;
using System.Collections.Generic;
using System.Text;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class StageAmount
    {

        #region WaterUserID
        /// <summary>
        /// 
        /// </summary>
        public int WaterUserID
        {
            get { return _waterUserID ; }
            set { _waterUserID = value; }
        } private int _waterUserID;
        #endregion //

        #region WaterUserName
        /// <summary>
        /// 
        /// </summary>
        public string WaterUserName
        {
            get
            {
                if (_waterUserName == null)
                {
                    _waterUserName = string.Empty;
                }
                return _waterUserName;
            }
            set
            {
                _waterUserName = value;
            }
        } private string _waterUserName;
        #endregion //WaterUserName

        #region Amount
        /// <summary>
        /// 
        /// </summary>
        public double Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        } private double _amount;
        #endregion //Amount

        #region Begin
        /// <summary>
        /// 
        /// </summary>
        public DateTime Begin
        {
            get
            {
                return _begin;
            }
            set
            {
                _begin = value;
            }
        } private DateTime _begin;
        #endregion //Begin

        #region End
        /// <summary>
        /// 
        /// </summary>
        public DateTime End
        {
            get
            {
                return _end;
            }
            set
            {
                _end = value;
            }
        } private DateTime _end;
        #endregion //End

    }

    /// <summary>
    /// 
    /// </summary>
    public class StageAmountCollection : Xdgk.Common.Collection<StageAmount>
    {

    }
}

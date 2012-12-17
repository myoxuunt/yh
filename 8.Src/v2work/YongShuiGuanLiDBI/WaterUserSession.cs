using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Common;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class WaterUserSession
    {
        //#region AdEState
        ///// <summary>
        ///// 
        ///// </summary>
        //public ADEState ADEState
        //{
        //    get
        //    {
        //        return _adEState;
        //    }
        //    set
        //    {
        //        _adEState = value;
        //        if (value == ADEState.Add)
        //        {
        //            this.WaterUser.Clear();
        //        }
        //    }
        //} private ADEState _adEState;
        //#endregion //AdEState

        /// <summary>
        /// 
        /// </summary>
        public WaterUserClass WaterUser
        {
            get
            {
                if (_waterUser == null)
                {
                    //_waterUser = new WaterUser();
                }
                return _waterUser;
            }
            set
            {
                _waterUser = value;
            }
        }private WaterUserClass _waterUser;


        ///// <summary>
        ///// 
        ///// </summary>
        //public void Save()
        //{
        //    if (ADEState == ADEState.Add)
        //    {
        //        WaterUserDBI.InsertWaterUser(this.WaterUser);
        //    }

        //    if (ADEState == ADEState.Edit)
        //    {
        //        WaterUserDBI.UpdateWaterUser(this.WaterUser);
        //    }
        //}
    }
}

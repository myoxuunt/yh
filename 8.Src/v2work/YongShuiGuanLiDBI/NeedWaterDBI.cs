using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class NeedWaterDBI
    {
        #region Deleted
        /// <summary>
        /// 
        /// </summary>
        /// <param name="needWaterID"></param>
        static public void Deleted(int needWaterID)
        {
            string s = string.Format("delete from tblNeedWater where needWaterID = {0}", needWaterID);
            DBI.GetDBI().ExecuteScalar(s);
        }
        #endregion //Deleted


        #region GetNeedWaterByWaterUser
        /// <summary>
        /// 
        /// </summary>
        /// <param name="b"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        static public DataTable GetNeedWaterByWaterUser(int waterUserID, DateTime b, DateTime e)
        {
            string s = string.Format(
                "select * from vNeedWater where (waterUserID = {0}) and (NeedBeginDT >=  '{1}' and NeedBeginDT < '{2}') " +
                "order by needBeginDT",
                waterUserID, b, e);
            return DBI.GetDBI().ExecuteDataTable(s);
        }
        #endregion //GetNeedWaterByWaterUser


        #region GetNeedWaterByID
        /// <summary>
        /// 
        /// </summary>
        /// <param name="needWaterID"></param>
        /// <returns></returns>
        static public DataTable GetNeedWaterByID(int needWaterID)
        {
            string s = "select * from tblNeedWater where NeedWaterID = " + needWaterID;
            return DBI.GetDBI().ExecuteDataTable(s);
        }
        #endregion //GetNeedWaterByID


        #region Update
        /// <summary>
        /// 
        /// </summary>
        internal static void Update(int needWaterID, string needName, DateTime b, DateTime e, int needAmount, string remark)
        {
            string s = string.Format(
                @"update tblNeedWater set
needBeginDT = '{1}' , 
needEndDT = '{2}', 
needAmount = {3}, 
remark = '{4}',
needName = '{5}'
where needWaterID = {0}",
                needWaterID, b, e, needAmount, remark, needName );

            DBI.GetDBI().ExecuteScalar(s);
        }
        #endregion //Update


        #region Insert
        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserID"></param>
        /// <param name="b"></param>
        /// <param name="e"></param>
        /// <param name="needAmount"></param>
        /// <param name="remark"></param>
        internal static void Insert(int waterUserID, string needName, DateTime b, DateTime e, 
            int needAmount, string remark)
        {
            string s = string.Format(
                "insert into tblNeedWater(waterUserID,  needName, needBeginDT, needEndDT, needAmount, remark) " +
                "values({0}, '{1}', '{2}', '{3}', {4}, '{5}')",
                waterUserID, needName, b, e, needAmount, remark);

            DBI.GetDBI().ExecuteScalar(s);
        }
        #endregion //Insert
    }


    /// <summary>
    /// 
    /// </summary>
    public class NeedWaterClass
    {
        #region NeedWaterID
        /// <summary>
        /// 
        /// </summary>
        public int NeedWaterID
        {
            get
            {
                return _needWaterID;
            }
            set
            {
                _needWaterID = value;
            }
        } private int _needWaterID;
        #endregion //NeedWaterID

        #region NeedName
        /// <summary>
        /// 
        /// </summary>
        public string NeedName
        {
            get
            {
                if (_needName == null)
                {
                    _needName = string.Empty;
                }
                return _needName;
            }
            set
            {
                _needName = value;
            }
        } private string _needName;
        #endregion //NeedName

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

        #region NeedAmount
        /// <summary>
        /// 
        /// </summary>
        public int NeedAmount
        {
            get
            {
                return _needAmount;
            }
            set
            {
                _needAmount = value;
            }
        } private int _needAmount;
        #endregion //NeedAmount

        #region Reamrk
        /// <summary>
        /// 
        /// </summary>
        public string Reamrk
        {
            get
            {
                if (_reamrk == null)
                {
                    _reamrk = string.Empty;
                }
                return _reamrk;
            }
            set
            {
                _reamrk = value;
            }
        } private string _reamrk;
        #endregion //Reamrk


        #region IsEdit
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsEdit()
        {
            return this.NeedWaterID != 0;
        }
        #endregion //IsEdit


        #region Save
        /// <summary>
        /// 
        /// </summary>
        public void Save(int waterUserID)
        {
            if (IsEdit())
            {
                NeedWaterDBI.Update(this.NeedWaterID, this.NeedName,  this.Begin, this.End, this.NeedAmount, this.Reamrk);
            }
            else
            {
                NeedWaterDBI.Insert(waterUserID, this.NeedName , this.Begin, this.End, this.NeedAmount, this.Reamrk);
            }
        }
        #endregion //Save


        /// <summary>
        /// 
        /// </summary>
        public WaterUserClass WaterUserClass
        {
            get
            {
                return _wu;
            }
            set
            {
                _wu = value;
            }
        } private WaterUserClass _wu;

        #region CreateByID
        /// <summary>
        /// 
        /// </summary>
        /// <param name="needWaterID"></param>
        /// <returns></returns>
        static public NeedWaterClass CreateByID( int needWaterID )
        {
            DataTable t = NeedWaterDBI.GetNeedWaterByID(needWaterID);
            if (t.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                DataRow row = t.Rows[0];
                int waterUserID = Convert.ToInt32 (row[DBNames.tblNeedWater.WaterUserID]);

                NeedWaterClass n = new NeedWaterClass();
                n.WaterUserClass = WaterUserFactory.CreateWaterUserByID(waterUserID);

                n.NeedWaterID = Convert.ToInt32(row[DBNames.tblNeedWater.WaterUserID]);
                n.Begin = Convert.ToDateTime(row[DBNames.tblNeedWater.NeedBeginDT]);
                n.End = Convert.ToDateTime(row[DBNames.tblNeedWater.NeedEndDT]);
                n.NeedAmount = Convert.ToInt32(row[DBNames.tblNeedWater.NeedAmount]);
                n.Reamrk = Convert.ToString(row[DBNames.tblNeedWater.Remark]);

                return n;
            }

        }
        #endregion //CreateByID

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="row"></param>
        ///// <returns></returns>
        //static public NeedWaterClass CreateByDataRow(DataRow row)
        //{

        //}
    }
}

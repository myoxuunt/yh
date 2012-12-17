using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace YongShuiGuanLiDBI
{

    /// <summary>
    /// 
    /// </summary>
    public class DistributeDBI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="needWaterID"></param>
        /// <param name="b"></param>
        /// <param name="e"></param>
        /// <param name="distributeAmount"></param>
        /// <param name="remark"></param>
        static public void Insert(int needWaterID, DateTime b, DateTime e, int distributeAmount, string remark)
        {
            string s = string.Format(
                "INSERT INTO tblDistributeWater( NeedWaterID, DistributeBeginDT, DistributeEndDT, DistributeAmount, Remark) " +
                "VALUES('{0}', '{1}', '{2}', '{3}', '{4}')",
                needWaterID, b, e, distributeAmount, remark);

            DBI.GetDBI().ExecuteScalar(s);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="distributeWaterID"></param>
        /// <param name="b"></param>
        /// <param name="e"></param>
        /// <param name="distributeAmount"></param>
        /// <param name="remark"></param>
        static public void Update(int distributeWaterID, DateTime b, DateTime e,
            int distributeAmount, string remark)
        {
            string s = string.Format(
@"UPDATE tblDistributeWater
SET DistributeBeginDT='{1}', DistributeEndDT='{2}', Remark='{3}', DistributeAmount='{4}'
WHERE DistributeWaterID = '{0}'",
                distributeWaterID, b, e, distributeAmount, remark);

            DBI.GetDBI().ExecuteScalar(s);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="distributeID"></param>
        static public void Delete(int distributeID)
        {
            string s = string.Format("delete from tblDistribute where distributeWaterID = {0}", distributeID);
            DBI.GetDBI().ExecuteScalar(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="b"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        static public DataTable GetDistributeDataTable(int waterUserID, DateTime b, DateTime e)
        {
            string s = string.Format(
                " select * from vDistributeWater " + 
                " where waterUserID = {0} and DistributeBeginDT >= '{1}' and DistributeBeginDT < '{2}' " + 
                " order by NeedBeginDT",
            waterUserID, b, e);

            return DBI.GetDBI().ExecuteDataTable(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="distributeWaterID"></param>
        /// <returns></returns>
        static public DataTable GetDistributeDataTableByID(int distributeWaterID)
        {
            string s = string.Format(
                "select * from tblDistributeWater where distributeWaterID = {0} order by DistributeBeginDT",
                distributeWaterID);

            return DBI.GetDBI().ExecuteDataTable(s);
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public class DistributeClass
    {
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

        #region DistributeAmount
        /// <summary>
        /// 
        /// </summary>
        public int DistributeAmount
        {
            get
            {
                return _distributeAmount;
            }
            set
            {
                _distributeAmount = value;
            }
        } private int _distributeAmount;
        #endregion //DistributeAmount

        #region Remark
        /// <summary>
        /// 
        /// </summary>
        public string Remark
        {
            get
            {
                if (_remark == null)
                {
                    _remark = string.Empty;
                }
                return _remark;
            }
            set
            {
                _remark = value;
            }
        } private string _remark;
        #endregion //Remark

        #region NeedWaterClass
        /// <summary>
        /// 
        /// </summary>
        public NeedWaterClass NeedWaterClass
        {
            get
            {
                return _needWaterClass;
            }
            set
            {
                _needWaterClass = value;
            }
        } private NeedWaterClass _needWaterClass;
        #endregion //NeedWaterClass

        #region DistributeWaterID
        /// <summary>
        /// 
        /// </summary>
        public int DistributeWaterID
        {
            get
            {
                return _distributeWaterID;
            }
            set
            {
                _distributeWaterID = value;
            }
        } private int _distributeWaterID;
        #endregion //DistributeWaterID


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsNew()
        {
            return this.DistributeWaterID == 0;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Save()
        {
            if (IsNew())
            {
                DistributeDBI.Insert(this.NeedWaterClass.NeedWaterID, Begin, End, this.DistributeAmount, this.Remark);
            }
            else
            {
                DistributeDBI .Update (this.DistributeWaterID, Begin, End, this.DistributeAmount, this.Remark);
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="distributeID"></param>
        /// <returns></returns>
        static public DistributeClass CreateByID(int distributeID)
        {
            DataTable tbl = DistributeDBI.GetDistributeDataTableByID(distributeID);
            if (tbl.Rows.Count > 0)
            {
                DataRow row = tbl.Rows[0];
                DistributeClass d = new DistributeClass();
                d.Begin = Convert.ToDateTime(row[DBNames.tblDistributeWater.DistributeBeginDT]);
                d.End = Convert.ToDateTime(row[DBNames.tblDistributeWater.DistributeEndDT]);
                d.DistributeAmount = Convert.ToInt32(row[DBNames.tblDistributeWater.DistributeAmount]);
                d.DistributeWaterID = Convert.ToInt32(row[DBNames.tblDistributeWater.DistributeWaterID]);
                d.Remark = row[DBNames.tblDistributeWater.Remark].ToString();

                int needID = Convert.ToInt32(row[DBNames.tblDistributeWater.NeedWaterID]);
                d.NeedWaterClass = NeedWaterClass.CreateByID(needID);

                return d;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="needWater"></param>
        /// <returns></returns>
        static public DistributeClass CreateByNeedWater(NeedWaterClass needWater)
        {
            if (needWater == null)
            {
                throw new ArgumentNullException("needWater");
            }

            DistributeClass d = new DistributeClass();
            d.NeedWaterClass = needWater;
            return d;
        }
    }
}

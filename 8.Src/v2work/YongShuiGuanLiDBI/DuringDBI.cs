using System;
using System.Collections.Generic;
using System.Data ;
using System.Text;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class DuringWaterFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public DuringWaterClass  CreateDuringWater(int id)
        {
            DataTable tbl = DuringWaterDBI.GetDuringDataTable(id);
            if (tbl.Rows.Count > 0)
            {
                return CreateDuringWater(tbl.Rows[0]);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private static DuringWaterClass CreateDuringWater(DataRow row)
        {
            //DataRow row = tbl.Rows[0];
            string name = row[YongShuiGuanLiDBI.DBNames.tblDuringWater.Name].ToString();
            int id = Convert.ToInt32(row[YongShuiGuanLiDBI.DBNames.tblDuringWater.DuringWaterID]);
            DateTime b = Convert.ToDateTime(row[YongShuiGuanLiDBI.DBNames.tblDuringWater.BeginDT]);
            DateTime e = Convert.ToDateTime(row[YongShuiGuanLiDBI.DBNames.tblDuringWater.EndDT]);

            DuringWaterClass d = new DuringWaterClass();
            d.ID = id;
            d.Name = name;
            d.Begin = b;
            d.End = e;
            return d;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public DuringWaterCollection CreateDuringWaterCollection()
        {
            DuringWaterCollection d = new DuringWaterCollection();
            DataTable t = DuringWaterDBI.GetDuringDataTable();
            foreach (DataRow row in t.Rows )
            {
                DuringWaterClass item = CreateDuringWater (row);
                d.Add(item);
            }
            return d;
        }


    }

    /// <summary>
    /// 
    /// </summary>
    public class DuringWaterClass
    {

        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        } private int _id;

        #region Name
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get
            {
                if (_name == null)
                {
                    _name = string.Empty;
                }
                return _name;
            }
            set
            {
                _name = value;
            }
        } private string _name;
        #endregion //Name

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

        #region EndString
        /// <summary>
        /// 
        /// </summary>
        public string EndString
        {
            get
            {
                //if (_endString == null)
                //{
                //    _endString = string.Empty;
                //}
                //return _endString;
                string s = string.Format("{0:MM}-{0:dd}", this.End);
                return s;
            }
            set
            {
               
            }
        } 
        #endregion //EndString

        #region BeginString
        /// <summary>
        /// 
        /// </summary>
        public string BeginString
        {
            get
            {
                string s = string.Format("{0:MM}-{0:dd}", this.Begin);
                return s;
            }
        } 
        #endregion //BeginString

        /// <summary>
        /// 
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public DateTime GetBeginDTWithYear(int year)
        {
            return new DateTime(year, this.Begin.Month, this.Begin.Day,
                this.Begin.Hour, this.Begin.Minute, this.Begin.Second);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public DateTime GetEndDTWithYear(int year)
        {
            return new DateTime(year, this.End.Month, this.End.Day,
                this.End.Hour, this.End.Minute, this.End.Second);
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public class DuringWaterCollection
        : Xdgk.Common.Collection<DuringWaterClass>
    { 
    }

    /// <summary>
    /// 
    /// </summary>
    public class DuringWaterDBI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="remark"></param>
        /// <returns></returns>
        static public int InsertDuring(string name, DateTime begin, DateTime end, string remark)
        {
            string s = "INSERT INTO tblDuringWater(Name, BeginDT, EndDT, Remark) " +
                        " VALUES('{0}', '{1}', '{2}', '{3}')";
            s = string.Format(s, name, begin, end, remark);
            DBI.GetDBI().ExecuteScalar(s);
            return GetDuringID(name);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        static public int GetDuringID(string name)
        {
            string s = string.Format("select duringWaterID from tblDuringWater where name = '{0}'",
                name);
            object obj = DBI.GetDBI().ExecuteScalar(s);
            if (obj != null && obj != DBNull.Value)
            {
                return Convert.ToInt32(obj);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        static public void DeleteDuring(int id)
        {
            string s = string.Format("delete from tblDuringWater where duringWaterID = {0}",
                id);
            DBI.GetDBI().ExecuteScalar(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newName"></param>
        /// <param name="newBegin"></param>
        /// <param name="newEnd"></param>
        /// <param name="newRemark"></param>
        static public void UpdateDuring(int id, string newName, DateTime newBegin, DateTime newEnd, string newRemark)
        {
            string s = string.Format( "UPDATE tblDuringWater SET Name='{1}', BeginDT='{2}', EndDT='{3}', Remark='{4}' " +
                                        " WHERE DuringWaterID ={0} ",
                id, newName, newBegin, newEnd, newRemark );
            DBI.GetDBI().ExecuteScalar(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public DataTable GetDuringDataTable()
        {
            string s = "select * from tblDuringWater";
            return DBI.GetDBI().ExecuteDataTable(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataTable GetDuringDataTable(int id)
        {
            string s = "select * from tblDuringWater where DuringWaterID = " + id;
            return DBI.GetDBI().ExecuteDataTable(s);
        }
    }
}

using System;
using System.Data ;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using Xdgk.Common;
using Ciloci.Flee;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class Formula
    {
        #region FormulaString
        /// <summary>
        /// 
        /// </summary>
        public string FormulaString
        {
            get
            {
                if (_formulaString == null)
                {
                    _formulaString = string.Empty;
                }
                return _formulaString;
            }
            set
            {
                _formulaString = value;
            }
        } private string _formulaString;
        #endregion //FormulaString

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

        /// <summary>
        /// 
        /// </summary>
        public string BeginString
        {
            get
            {
                return GetMMDDDate(this.Begin);
            }
            set
            {
                this.Begin = GetDateByMMDD(value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private DateTime GetDateByMMDD(string value)
        {
            string s = "2000-" + value;
            return DateTime.Parse(s);
        }

        /// <summary>
        /// 
        /// </summary>
        public string EndString
        {
            get
            {
                return GetMMDDDate(this.End);
            }
            set
            {
                this.End = GetDateByMMDD(value);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public string GetMMDDDate(DateTime dt)
        {
            return dt.ToString("MM-dd");
        }

        #region ID
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            get
            {
                return _iD;
            }
            set
            {
                _iD = value;
            }
        } private int _iD;
        #endregion //ID

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool InDTRange(DateTime dt)
        {
            DateTime begin = new DateTime(2000, this.Begin.Month, this.Begin.Day);
            DateTime end = new DateTime(2000, this.End.Month, this.End.Day);
            DateTime dttemp = new DateTime(2000, dt.Month, dt.Day);
            if (dttemp >= begin && dttemp <= end)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        //public void Save(DeviceClass device)
        public void Save ()
        {
            if (IsEdit())
            {
                FormulaDBI.Update(this.ID, this.Begin, this.End, this.FormulaString);
            }
            else
            {
                FormulaDBI.Insert(this.Device.DeviceID, this.Begin, this.End, this.FormulaString);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsAdd()
        {
            return this.ID == 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsEdit()
        {
            return this.ID > 0;
        }

        #region CalcInstantFlux
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wl"></param>
        /// <returns></returns>
        public int CalcInstantFlux(int wl)
        {
            ExpressionContext ec = new ExpressionContext();
            ec.Variables["wl"] = wl;
            IDynamicExpression de = null;
            try
            {
                de = ec.CompileDynamic(this.FormulaString);
            }
            catch( ExpressionCompileException exception)
            {
                // TODO: calc error
                //
            }
            object result = de.Evaluate();

            int flux = Convert.ToInt32(result);
            return flux;
        }
        #endregion //CalcInstantFlux

        /*
        /// <summary>
        /// 
        /// </summary>
        public DuringWaterClass DuringWaterClass
        {
            get 
            { 
            }
            set { }
        } private DuringWaterClass _duringWaterClass;
         */


        /// <summary>
        /// 
        /// </summary>
        public DeviceClass Device
        {
            get { return _device; }
            set { _device = value; }
        } private DeviceClass _device;
    }


    /// <summary>
    /// 
    /// </summary>
    public class FormulaCollection : Collection<Formula>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public Formula Find(DateTime dt)
        {
            foreach (Formula f in this)
            {
                if (f.InDTRange(dt))
                {
                    return f;
                }
            }
            return null;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class FormulaFactory
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="formulaID"></param>
        /// <returns></returns>
        static public Formula Create(int formulaID)
        {
            DataTable tbl = FormulaDBI.GetDataTableByFormulaID(formulaID);
            if (tbl.Rows.Count > 0)
            {
                DataRow row  = tbl.Rows[0];
                int deviceid = Convert.ToInt32 ( row["DeviceID"]);
                Formula f = Create(row);
                f.Device = DeviceFactory.CreateDevice(deviceid);
                return f;
            }
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="device"></param>
        /// <returns></returns>
        static public FormulaCollection Create(DeviceClass device)
        {
            if (device == null)
            {
                throw new ArgumentNullException("device");
            }

            FormulaCollection fc = new FormulaCollection();
            DataTable tbl = FormulaDBI.GetDataTable(device.DeviceID);
            foreach (DataRow row in tbl.Rows)
            {
                Formula f = Create(row);
                f.Device = device;
                fc.Add(f);
            }
            return fc;
        }

        /*
        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceID"></param>
        /// <returns></returns>
        static public FormulaCollection Create(int deviceID)
        {
            FormulaCollection fc = new FormulaCollection();
            DataTable tbl = FormulaDBI.GetDataTable(deviceID);
            foreach (DataRow row in tbl.Rows)
            {
                Formula f = Create(row);
                fc.Add(f);
            }
            return fc;
        }
        */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        static public Formula Create(DataRow row)
        {
            Formula f = new Formula();
            f.ID = Convert.ToInt32(row["FormulaID"]);
            f.Begin = GetDate(row, "DTBegin");
            f.End = GetDate(row, "DTEnd");
            f.FormulaString = row["Formula"].ToString();

            return f;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        static private DateTime GetDate(DataRow row, string columnName)
        {
            DateTime dt = Convert.ToDateTime ( row[columnName ]);
            return new DateTime(2000, dt.Month, dt.Day);
        }
    }
}
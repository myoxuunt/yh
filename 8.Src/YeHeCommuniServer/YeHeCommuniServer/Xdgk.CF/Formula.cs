using System;
using System.Reflection;
//using Xdgk.Communi;
using Ciloci.Flee;

namespace Xdgk.CF
{
    /// <summary>
    /// 
    /// </summary>
    public class Formula
    {
        #region Members
        public int ID;
        public DateTime Begin;
        public DateTime End;
        public string FormulaExpress
        {
            get
            {
                if (_formulaExpress == null)
                {
                    _formulaExpress = string.Empty;
                }
                return _formulaExpress;
            }
            set 
            {
                if (_formulaExpress != value)
                {
                    _formulaExpress = value;
                    ClearDynamicExpression();
                }
            }
        } private string _formulaExpress;
        #endregion //Members

        /// <summary>
        /// 
        /// </summary>
        private void ClearDynamicExpression()
        {
            this._ide = null;
        } 

        #region FormatDatetimeWithMMDD
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        private string FormatDatetimeWithMMDD(DateTime dt)
        {
            return string.Format("{0}-{1}", dt.Month, dt.Day);
        }
        #endregion //FormatDatetimeWithMMDD

        #region BeginString
        /// <summary>
        /// 
        /// </summary>
        public string BeginString
        {
            get { return FormatDatetimeWithMMDD(this.Begin); }
            set { }
        }
        #endregion //BeginString

        #region EndString
        /// <summary>
        /// 
        /// </summary>
        public string EndString
        {
            get
            {
                return FormatDatetimeWithMMDD(this.End);
            }
            set
            {

                #region Formula
            }
        }
                #endregion //EndString
        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="formulaExpress"></param>
        public Formula(int id, DateTime begin, DateTime end, string formulaExpress)
        {
            this.ID = id;
            this.Begin = FormatDate(begin);
            this.End = FormatDate(end);
            this.FormulaExpress = formulaExpress;
        }
        #endregion //Formula

        #region ExpressionContext
        /// <summary>
        /// 
        /// </summary>
        private ExpressionContext ExpressionContext
        {
            get
            {
                if (_ec == null)
                {
                    _ec = new ExpressionContext();
                    MethodInfo mi = typeof(Math).GetMethod("Log10");
                    _ec.Imports.AddMethod(mi, string.Empty);
                }
                return _ec;
            }
        } private ExpressionContext _ec;
        #endregion //ExpressionContext


        #region DynamicExpress
        /// <summary>
        /// 
        /// </summary>
        private IDynamicExpression DynamicExpress
        {
            get
            {
                if (_ide == null)
                {
                    _ide = this.ExpressionContext.CompileDynamic(this.FormulaExpress);
                }
                return _ide;
            }
        } private IDynamicExpression _ide;
        #endregion //DynamicExpress

        #region CalcInstantFluxForTest
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wl1"></param>
        /// <param name="wl2"></param>
        /// <returns></returns>
        public int CalcInstantFluxForTest(int wl1, int wl2)
        {
            this.ExpressionContext.Variables["wl1"] = wl1;
            this.ExpressionContext.Variables["wl2"] = wl2;
            object obj = this.DynamicExpress.Evaluate();
            return Convert.ToInt32(obj);
        }
        #endregion //CalcInstantFluxForTest

        #region CalcInstantFlux
        /// <summary>
        /// 计算顺势流量
        /// </summary>
        /// <param name="wl1"></param>
        /// <param name="wl2"></param>
        /// <returns></returns>
        public float CalcInstantFlux(int wl1, int wl2)
        {
            try
            {
                this.ExpressionContext.Variables["wl1"] = wl1;
                this.ExpressionContext.Variables["wl2"] = wl2;
                object obj = this.DynamicExpress.Evaluate();
                return Convert.ToSingle(obj);
            }
            catch (Exception ex)
            {
                Xdgk.Common.ExceptionHandler.Handle(ex, false);
                return 0;
            }
        }
        #endregion //CalcInstantFlux

        #region Include
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Include(DateTime dt)
        {
            dt = FormatDate(dt);
            return (dt >= Begin) && (dt <= End);
        }
        #endregion //Include

        #region FormatDate
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        private DateTime FormatDate(DateTime dt)
        {
            return dt.AddYears(2000 - dt.Year);
        }
        #endregion //FormatDate
    }
}

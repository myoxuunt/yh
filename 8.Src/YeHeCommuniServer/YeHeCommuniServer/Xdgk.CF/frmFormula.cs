using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using Xdgk.Communi;
//using Ciloci.Flee;

namespace Xdgk.CF
{
    public partial class frmFormula : NUnit.UiKit.SettingsDialogBase
    {

        private int _deviceID;
        private Formula _formula;
        private bool _isAdd;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsAdd()
        {
            return _isAdd;
        }
        /// <summary>
        /// 
        /// </summary>
        public frmFormula()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="device"></param>
        public void SetAddInfo(int deviceID)
        {
            //if (device == null)
            //{
            //    throw new ArgumentNullException("device");
            //}
            this._deviceID = deviceID;
            this._isAdd = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="device"></param>
        /// <param name="formula"></param>
        public void SetEditInfo(int deviceID, Formula formula)
        {
            //if (deviceID == null)
            //{
            //    throw new ArgumentNullException("device");
            //}
            if (formula == null)
            {
                throw new ArgumentNullException("formula");
            }
            this._deviceID = deviceID;
            this._formula = formula;
            this._isAdd = false;

            this.Begin = _formula.Begin;
            this.End = _formula.End;
            this.Formula = _formula.FormulaExpress;

            this.FormulaClass = formula;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            // TODO: check input
            //
            if (!checkinput())
            {
                return;
            }
            if (IsAdd())
            {
                Add();
            }
            else
            {
                Edit();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool checkinput()
        {
            DateTime r;
            bool b = false;
            b = DateTime.TryParse("2000-"+this.txtBegin.Text.Trim (), out r);
            if (!b)
            {
                NUnit.UiKit.UserMessage.DisplayFailure("无效的日期");
                return false;
            }

            b = DateTime.TryParse("2000-" + this.txtEnd.Text.Trim(), out r);
            if (!b)
            {
                NUnit.UiKit.UserMessage.DisplayFailure("无效的日期");
                return false;
            }

            // test formula
            //
            return TestFormula();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool TestFormula()
        {
            try
            {
                Formula testFormula = new Formula(
                    0,
                    DateTime.Parse("2000-1-1"),
                    DateTime.Parse("2000-12-30"),
                    this.Formula
                    );

                int result1 = testFormula.CalcInstantFluxForTest(0, 0);
                int result2 = testFormula.CalcInstantFluxForTest(10, 10);

                //NUnit.UiKit.UserMessage.Display(string.Format("{0} {1}", result1, result2));
            }
            catch (Ciloci.Flee.ExpressionCompileException ex)
            {                  
                NUnit.UiKit.UserMessage.DisplayFailure(ex.Message);
                return false;
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        private void Add()
        {
            //int id = DB.FormulaDB.InsertFormula(this._deviceID,
            //    this.Begin, this.End, this.Formula);

            this.FormulaClass = new Formula(0, this.Begin, this.End, this.Formula);
        }

        /// <summary>
        /// 
        /// </summary>
        private void Edit()
        {
            //DB.FormulaDB.UpdateFormula(this.FormulaClass.ID, Begin, End, Formula);
            this.FormulaClass.Begin = this.Begin;
            this.FormulaClass.End = this.End;
            this.FormulaClass.FormulaExpress = this.Formula;
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime End 
        {
            get
            {
                return Convert.ToDateTime("2000-" + txtEnd.Text.Trim());
            }
            set
            {
                txtEnd.Text = string.Format("{0}-{1}", value.Month , value.Day );
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime Begin
        {
            get
            {
                return Convert.ToDateTime("2000-" + txtBegin.Text.Trim());
            }
            set
            {
                txtBegin.Text = string.Format("{0}-{1}",value.Month, value.Day );
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Formula
        {
            get
            {
                return this.txtFormula.Text;
            }
            set
            {
                txtFormula.Text = value.ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Formula FormulaClass
        {
            get { return _formulaClass ; }
            set { _formulaClass = value; }
        } private Formula _formulaClass;
    }
}

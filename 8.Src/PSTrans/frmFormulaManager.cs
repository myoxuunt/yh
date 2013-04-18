using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Xdgk.CF;

namespace RWTrans
{
    public partial class frmFormulaManager : Form
    {
        public frmFormulaManager()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmFormula_Load(object sender, EventArgs e)
        {
            FillWaterDeviceList();
        }

        /// <summary>
        /// 
        /// </summary>
        private void FillWaterDeviceList()
        {
            this.lstWaterDevice.Items.Clear();

            this.lstWaterDevice.DisplayMember = "Tag";

            foreach (DeviceFormulaCollectionMap item in App.Default.DevieFormaulCollectionMapCollection)
            {
                string stationName = item.Tag.ToString();
                this.lstWaterDevice.Items.Add(item);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstWaterDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selected = this.lstWaterDevice.SelectedItem;
            DeviceFormulaCollectionMap d = selected as DeviceFormulaCollectionMap;

            if (d != null)
            {
                this.lvFormula.Items.Clear();
                foreach (Formula f in d.FormulaCollection)
                {
                    AddFormulaListViewItem(f);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private DeviceFormulaCollectionMap SelectedDeviceFormulaCollectionMap
        {
            get
            {
                object selected = this.lstWaterDevice.SelectedItem;
                DeviceFormulaCollectionMap d = selected as DeviceFormulaCollectionMap;
                return d;
            }
        }

        #region AddFormulaListViewItem
        /// <summary>
        /// 
        /// </summary>
        /// <param name="formula"></param>
        private void AddFormulaListViewItem(Formula formula)
        {
            ListViewItem lvi = new ListViewItem(new string[]{
                     ( formula.BeginString  ),
                     ( formula.EndString ),
                    formula.FormulaExpress 
                });
            lvi.Tag = formula;
            this.lvFormula.Items.Add(lvi);
        }
        #endregion //AddFormulaListViewItem

        #region btnAddFormula_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddFormula_Click(object sender, EventArgs e)
        {
            DeviceFormulaCollectionMap sel = SelectedDeviceFormulaCollectionMap;
            if (sel != null)
            {
                frmFormula f = new frmFormula();
                f.SetAddInfo(sel.DeviceID);
                DialogResult dr = f.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Formula formula = f.FormulaClass;
                    //YeHeCommuniServerApp.Default.DevieFormaulCollectionMapCollection.AddFormula(
                    //    this.Device.ID, formula);
                    int formulaID = App.Default.ToDBI.InsertFormula(sel.DeviceID,
                        formula.Begin,
                        formula.End,
                        formula.FormulaExpress);

                    formula.ID = formulaID;

                    FormulaCollection formulaCollection = App.Default.DevieFormaulCollectionMapCollection.GetFormulaCollection(sel.DeviceID);
                    formulaCollection.Add(formula);

                    AddFormulaListViewItem(formula);
                }
            }
        }
        #endregion //btnAddFormula_Click

        #region btnEditFormula_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditFormula_Click(object sender, EventArgs e)
        {
            if (this.lvFormula.SelectedItems.Count > 0)
            {
                ListViewItem lvi = this.lvFormula.SelectedItems[0];
                Formula formula = this.lvFormula.SelectedItems[0].Tag as Formula;
                if (formula != null)
                {
                    frmFormula f = new frmFormula();
                    f.SetEditInfo(this.SelectedDeviceFormulaCollectionMap.DeviceID, formula);
                    DialogResult dr = f.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        App.Default.ToDBI.UpdateFormula(formula.ID, formula.Begin, formula.End, formula.FormulaExpress);
                        lvi.SubItems[0].Text = formula.BeginString;
                        lvi.SubItems[1].Text = formula.EndString;
                        lvi.SubItems[2].Text = formula.FormulaExpress;
                    }
                }
            }
        }
        #endregion //btnEditFormula_Click

        #region btnDeleteFormula_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteFormula_Click(object sender, EventArgs e)
        {
            if (this.lvFormula.SelectedItems.Count > 0)
            {
                ListViewItem lvi = this.lvFormula.SelectedItems[0];
                Formula formula = this.lvFormula.SelectedItems[0].Tag as Formula;
                if (formula != null)
                {
                    DialogResult dr = NUnit.UiKit.UserMessage.Ask("确定要删除选择项吗?", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {

                        App.Default.DevieFormaulCollectionMapCollection.DeleteFormula(formula);
                        this.lvFormula.Items.Remove(lvi);
                        // formula id 
                        //
                        App.Default.ToDBI.DeleteFormula(formula.ID);
                    }
                }
            }
        }
        #endregion //btnDeleteFormula_Click

    }
}

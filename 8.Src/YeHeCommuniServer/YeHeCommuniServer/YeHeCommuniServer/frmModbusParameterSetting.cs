using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Xdgk.Communi;
using Xdgk.Communi.Interface;
using Xdgk.Common;

namespace YeHeCommuniServer
{
    /// <summary>
    /// 
    /// </summary>
    public partial class frmModbusParameterSetting : NUnit.UiKit.SettingsDialogBase
    {
        private Device _device;

        /// <summary>
        /// 
        /// </summary>
        public frmModbusParameterSetting(Device device)
        {
            InitializeComponent();
            this._device = device;
            BindParamName();
        }

        /// <summary>
        /// 
        /// </summary>
        private void BindParamName()
        {
            //XD221ConfigDefineCollection defines = XD221ModbusParamConfig.Default.XD221ConfigDefineCollection;
            //this.cmbParamName.DataSource = defines;
            //this.cmbParamName.DisplayMember = "Name";


            this.cmbParamName.DataSource = this._device.DeviceDefine.ParameterDefineCollection;
            this.cmbParamName.DisplayMember = "Name";
            //this.cmbParamName.ValueMember = "Offset";
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //private XD221ConfigDefine GetSelectedConfigDefine()
        //{
        //    return this.cmbParamName.SelectedItem as XD221ConfigDefine;
        //}

        /// <summary>
        /// 
        /// </summary>
        public int Offset
        {
            get 
            { 
                ParameterDefine pd = this.GetSelectedParameterDefine();
                ModbusParameterDefine mpd = pd as ModbusParameterDefine;
                return mpd.Offset;
            }
        }

        #region Datas
        /// <summary>
        /// 
        /// </summary>
        public byte[] Datas 
        {
            get { return _datas; }
        } private byte[] _datas;
        #endregion //Datas

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmParamSet_Load(object sender, EventArgs e)
        {
        }

        //}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            IComparable value;
            bool r = ParseParameterValue(out value);
            if (!r)
            {
                return;
            }

            // TODO: 2010-07-29 convert param value to byte[]
            //
            // 1. get converter name
            // 2. get bytes converter
            // 3. bc.ConvertToBytes( paramvalue ) save to data byte array
            //
            ParameterDefine pd = this.GetSelectedParameterDefine();
            string converterName = pd.ConverterName;
            IBytesConverter ibc = GetBytesConverter(converterName);

            if (ibc == null)
            {
                string exmsg = string.Format("cannot get bytesconverter '{0}'", converterName);
                throw new InvalidOperationException(exmsg);
            }

            byte[] bs = ibc.ConvertToBytes(value);
            this._datas = bs;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private IBytesConverter GetBytesConverter(string name)
        {
            return YeHeCommuniServerApp.Default.CommuniSoft.BytesConverterManager.CreateBytesConverter(name, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private ParameterDefine GetSelectedParameterDefine()
        {
            return this.cmbParamName.SelectedItem as ParameterDefine;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private object GetParameterValue()
        {
            if (cmbParamValue.DataSource == null)
            {
                return cmbParamValue.Text;
            }
            else
            {
                return cmbParamValue.SelectedValue;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool ParseParameterValue(out IComparable value)
        {
            value = null;
            ParameterDefine pd = GetSelectedParameterDefine();
            object paramValue = GetParameterValue();

            IComparable v = null;
            try
            {
                v = (IComparable)Convert.ChangeType(paramValue, pd.TypeCode);
            }
            catch (Exception ex)
            {
                NUnit.UiKit.UserMessage.Display(ex.ToString());
                return false;
            }

            if (pd.Constraint == null)
            {
                return true;
            }

            value = v;

            return pd.Constraint.Verify(v);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbParamName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModbusParameterDefine pd = this.cmbParamName.SelectedItem as ModbusParameterDefine;
            this.cmbParamValue.Text = string.Empty;
            if (pd.EnableNameValue)
            {
                this.cmbParamValue.DataSource = pd.NameValueCollection;
                this.cmbParamValue.DisplayMember = "Name";
                this.cmbParamValue.ValueMember = "Value";
                this.cmbParamValue.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else
            {
                this.cmbParamValue.DataSource = null;
                this.cmbParamValue.DropDownStyle = ComboBoxStyle.DropDown;
            }
            this.txtUnit.Text = pd.Unit;
        }
    }

}

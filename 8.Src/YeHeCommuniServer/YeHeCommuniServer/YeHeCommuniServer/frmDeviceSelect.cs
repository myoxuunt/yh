using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Xdgk.Communi;

namespace YeHeCommuniServer
{
    public partial class frmDeviceSelect : NUnit.UiKit.SettingsDialogBase 
    {
        /// <summary>
        /// 
        /// </summary>
        public frmDeviceSelect()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDeviceSelect_Load(object sender, EventArgs e)
        {
            FillDeviceType();
        }

        /// <summary>
        /// 
        /// </summary>
        private void FillDeviceType()
        {
            this.lstDeviceType.Items.Clear();
            //this.lstDeviceType.DataSource = YeHeCommuniServerApp.Default.CommuniSoft.OperaFactory.DeviceDefineCollection;
            this.lstDeviceType.DataSource = YeHeCommuniServerApp.Default.CommuniSoft.DeviceDefineManager.DeviceDefineCollection;
            this.lstDeviceType.DisplayMember = "Text";
            this.lstDeviceType.ValueMember = "DeviceType";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            object selObj = this.lstDeviceType.SelectedItem; 
            if( selObj == null)
            {
                NUnit.UiKit.UserMessage.DisplayFailure(strings.PleaseSelectDeviceType);
                return;
            }
            this.SelectedDeviceType = this.lstDeviceType.SelectedValue.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        /// <summary>
        /// 获取或设置选中的设备类型
        /// </summary>
        public string SelectedDeviceType
        {
            get { return _selectedDeviceType; }
            set { _selectedDeviceType = value; }
        } private string _selectedDeviceType;
    }
}

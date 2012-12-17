using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Xdgk.Communi;

namespace YeHeCommuniServer
{
    public partial class UCDitchDevice : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        public UCDitchDevice()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UCDitchDevice_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public DitchDevice DitchDevice
        {
            get { return _ditchDevice; }
            set 
            {
                if (value == null)
                    throw new ArgumentNullException("ditchDevice");

                _ditchDevice = value;
                this.txtStationName.Text = _ditchDevice.Station.Name;
                this.txtDevice.Text = _ditchDevice.DeviceDefine.Text;

                RefreshDitchData(_ditchDevice.DitchData);
            }
        } private DitchDevice _ditchDevice;

        /// <summary>
        /// 
        /// </summary>
        public void RefreshDitchData(DitchData ditchData)
        {
            if (ditchData != null)
            {
                txtDT.Text = ditchData.DT.ToString();
                txtWL1.Text = ditchData.WL1.ToString();
                txtWL2.Text = ditchData.WL2.ToString();
                txtInstantFlux.Text = ditchData.InstantFlux.ToString("f2");
                txtUsedAmount.Text = ditchData.UsedAmount.ToString();
                txtVoltage.Text = ditchData.Voltage.ToString();
            }
            else
            {
                txtDT.Clear();
                txtWL1.Clear();
                txtWL2.Clear();
                txtInstantFlux.Clear();
                txtUsedAmount.Clear();
                txtVoltage.Clear();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommuniLog_Click(object sender, EventArgs e)
        {
            //frmCommuniFail f = new frmCommuniFail(this.DitchDevice,
            //    this.DitchDevice.CommuniFailDetails);
            //f.ShowDialog();
            this.DitchDevice.ShowCommuniDetailsDialog();
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btnDeviceParams_Click(object sender, EventArgs e)
        //{
        //    if (this._ditchDevice is XD221Device)
        //    {
        //        XD221Device d = _ditchDevice as XD221Device;
        //        frmXD221Params f = new frmXD221Params(d.Xd221Params);
        //        f.ShowDialog();
        //    }
        //}

        ///// <summary>
        ///// write a xd221modbus param
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    frmModbusParameterSetting f = new frmModbusParameterSetting(this.DitchDevice );
        //    DialogResult dr = f.ShowDialog();


        //    if (dr == DialogResult.OK)
        //    {
        //        // TODO: 2010-07-30 check station is connected
        //        //
        //        CommuniSoft cs = YeHeCommuniServerApp.Default.CommuniSoft;
        //        string type = this.DitchDevice.DeviceDefine.DeviceType;
        //        //Opera op = cs.OperaFactory.Create(type,
        //        //    XD221ModbusOperaNames.WriteParam);
        //        Opera op = this.DitchDevice.DeviceDefine.CreateOpera(XD221ModbusOperaNames.WriteParam);

        //        op.SendPart["offset"] = f.Offset;
        //        op.SendPart["datas"] = f.Datas;

        //        Task t = new Task(this.DitchDevice, op, new ImmediateStrategy());
        //        cs.TaskManager.Tasks.AddToHead(t);
        //    }
        //}
    }
}

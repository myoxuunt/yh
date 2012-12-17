using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace YeHeCommuniServer
{
    public partial class UCXD202Device : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        public UCXD202Device()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtWL2_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UCXd202Data_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public XD202Device XD202Device
        {
            get { return _xd202Device; }
            set
            {
                _xd202Device = value;
                if (_xd202Device != null)
                {
                    this.txtStationName.Text = _xd202Device.Station.Name;
                    this.txtDevice.Text = _xd202Device.DeviceDefine.Text;
                    RefreshXD202Data(_xd202Device.XD202Data);
                }
            }
        } private XD202Device _xd202Device;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        public void RefreshXD202Data(XD202Data data)
        {
            if (data != null)
            {
                this.txtDT.Text = data.DT.ToString();
                this.txtBeforeWaterLevel.Text = data.BeforeWaterLevel.ToString();
                this.txtBehindWaterLevel.Text = data.BehindWaterLevel.ToString();
                this.txtHeight.Text = data.Height.ToString();
                this.txtRemainAmount.Text = data.RemainAmount.ToString();
                this.txtInstantFlux.Text = data.InstantFlux.ToString("f2");
            }
            else
            {
                this.txtDT.Clear();
                this.txtBeforeWaterLevel.Clear();
                this.txtBehindWaterLevel.Clear();
                this.txtHeight.Clear();
                this.txtRemainAmount.Clear();
                this.txtInstantFlux.Clear();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommuniLog_Click(object sender, EventArgs e)
        {
            //frmCommuniFail f = new frmCommuniFail(this.XD202Device ,
            //    this.XD202Device.CommuniFailDetails);
            //f.ShowDialog();
            this.XD202Device.ShowCommuniDetailsDialog();
        }
    }
}

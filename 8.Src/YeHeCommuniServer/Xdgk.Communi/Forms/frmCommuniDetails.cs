using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Xdgk.Communi;

namespace Xdgk.Communi
{
    public partial class frmCommuniDetails : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private const string SplitString = ": ";

        /// <summary>
        /// 
        /// </summary>
        private Device _device;
        //private CommuniFailDetailCollection _communiFailDetails;
        /// <summary>
        /// 
        /// </summary>
        private CommuniDetailQueue _communiDetailQueue;

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="communiFailDetails"></param>
        //public frmCommuniFail( Device device,
        //    CommuniFailDetailCollection communiFailDetails )
        //{
        //    InitializeComponent();

        //    if (communiFailDetails == null)
        //        throw new ArgumentNullException("communiFailDetails");

        //    if (device == null)
        //        throw new ArgumentNullException("device");

        //    this._communiFailDetails = communiFailDetails;
        //    this._device = device;
        //    this.Text = string.Format(strings.CommuniLogTitle,
        //        device.Station.Name,
        //        device.DeviceDefine.Text);
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="device"></param>
        /// <param name="communiDetailQueue"></param>
        public frmCommuniDetails(Device device,
            CommuniDetailQueue communiDetailQueue)
        {
            InitializeComponent();
            if (communiDetailQueue == null)
                throw new ArgumentNullException("communiDetailQueue");

            if (device == null)
                throw new ArgumentNullException("device");

            this._device = device;
            this._communiDetailQueue = communiDetailQueue;

            this.Text = string.Format(
                strings.CommuniLogTitle,
                device.Station.Name,
                device.DeviceDefine.Text
                );

            FillComboBox();
            Fill();
        }

        /// <summary>
        /// 
        /// </summary>
        private void FillComboBox()
        {
            this.cmbView.Items.Clear();
            this.cmbView.Items.Add(strings.CommuniDetailAll);
            this.cmbView.Items.Add(strings.CommuniDetailSuccess);
            this.cmbView.Items.Add(strings.CommuniDetailFail);

            this.cmbView.Text = strings.CommuniDetailAll;
        }

        private bool _showAll;
        private ParseResultEnum _showParseResultEnum;

        /// <summary>
        /// 
        /// </summary>
        private void Fill()
        {
            this.richTextBox1.Clear();
            StringBuilder sb = new StringBuilder();
            foreach (CommuniDetail cfd in this._communiDetailQueue)
            {
                if (_showAll ||
                    _showParseResultEnum == cfd.ParseResultEnum)
                {
                    sb.AppendLine(strings.Time + SplitString + cfd.DT.ToString());
                    sb.AppendLine(strings.Opera + SplitString + cfd.OperaText);
                    sb.AppendLine(strings.Result + SplitString + cfd.ParseResult);
                    sb.AppendLine(strings.Send + SplitString + BitConverter.ToString(cfd.Send));
                    sb.AppendLine(strings.Received + SplitString + BitConverter.ToString(cfd.Received));
                    sb.AppendLine();
                }
            }
            this.richTextBox1.AppendText(sb.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopyContext_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.richTextBox1.Text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            _showAll = this.cmbView.Text == strings.CommuniDetailAll;
            if (!_showAll)
            {
                if (cmbView.Text == strings.CommuniDetailSuccess)
                {
                    _showParseResultEnum = ParseResultEnum.Success;
                }

                if (cmbView.Text == strings.CommuniDetailFail)
                {
                    _showParseResultEnum = ParseResultEnum.Fail;
                }
            }
            Fill();
        }

    }
}

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
    public partial class frmCommuniFail : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private Device _device;
        private CommuniFailDetailCollection _communiFailDetails;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="communiFailDetails"></param>
        public frmCommuniFail( Device device,
            CommuniFailDetailCollection communiFailDetails )
        {
            InitializeComponent();

            if (communiFailDetails == null)
                throw new ArgumentNullException("communiFailDetails");

            if (device == null)
                throw new ArgumentNullException("device");

            this._communiFailDetails = communiFailDetails;
            this._device = device;
            this.Text = string.Format(strings.CommuniLogTitle,
                device.Station.Name,
                device.DeviceDefine.Text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCommuniFail_Load(object sender, EventArgs e)
        {
            Fill();
        }

        /// <summary>
        /// 
        /// </summary>
        private void Fill()
        {
            StringBuilder sb = new StringBuilder();
            foreach (CommuniFailDetail cfd in this._communiFailDetails)
            {
                sb.AppendLine(strings.DT + cfd.DT.ToString());
                sb.AppendLine(strings.Device + cfd.DeviceType);
                sb.AppendLine(strings.Opera + cfd.OperaText);
                sb.AppendLine(strings.Datas + BitConverter.ToString(cfd.Bytes));
                sb.AppendLine(strings.Error + cfd.ParseResult);
                sb.AppendLine();
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
    }
}

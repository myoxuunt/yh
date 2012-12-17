using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Xdgk.Common;

namespace YeHeCommuniServer
{
    public partial class frmXD221Params : NUnit.UiKit.SettingsDialogBase
    {
        private XD221Params _xd221Params;

        /// <summary>
        /// 
        /// </summary>
        public frmXD221Params(XD221Params p)
        {
            InitializeComponent();
            this._xd221Params = p;
            Fill();
        }

        private void frmXD221Params_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        private void Fill()
        {
            if (_xd221Params != null)
            {
                XD221Params p = this._xd221Params;
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("B: {0}" + Environment.NewLine, p.B );
                sb.AppendFormat("BaudRate: {0}" + Environment.NewLine, p.BaudRate );
                sb.AppendFormat("CutthroatLength: {0}" + Environment.NewLine, p.CutthroatLength );
                sb.AppendFormat("CutthroatMinWidth: {0}" + Environment.NewLine, p.CutthroatMinWidth );
                sb.AppendFormat("EchelonBottomWidth: {0}" + Environment.NewLine, p.EchelonBottomWidth );
                sb.AppendFormat("K: {0}" + Environment.NewLine, p.K );
                sb.AppendFormat("OpenChannelBorderModulus: {0}" + Environment.NewLine, p.OpenChannelBorderModulus );

                sb.AppendFormat("OpenChannelBottomSlope: {0}" + Environment.NewLine, p.OpenChannelBottomSlope );
                sb.AppendFormat("OpenChannelBottomWidth: {0}" + Environment.NewLine, p.OpenChannelBottomWidth );
                sb.AppendFormat("OpenChannelCoarseRate: {0}" + Environment.NewLine, p.OpenChannelCoarseRate );
                sb.AppendFormat("ParshallWidth: {0}" + Environment.NewLine, p.ParshallWidth );
                sb.AppendFormat("PulseModulus: {0}" + Environment.NewLine, p.PulseModulus );
                sb.AppendFormat("PulseSensitivity1: {0}" + Environment.NewLine, p.PulseSensitivity1 );
                sb.AppendFormat("RectangleHeight: {0}" + Environment.NewLine, p.RectangleHeight );
                sb.AppendFormat("RectangleTotalWidth: {0}" + Environment.NewLine, p.RectangleTotalWidth );
                sb.AppendFormat("RectangleWidth: {0}" + Environment.NewLine, p.RectangleWidth );

                this.txtXD221Params.Text = sb.ToString();
            }
        }
    }
}

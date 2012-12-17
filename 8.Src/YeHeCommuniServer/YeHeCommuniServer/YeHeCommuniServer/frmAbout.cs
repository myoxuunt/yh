using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YeHeCommuniServer
{
    /// <summary>
    /// 
    /// </summary>
    public partial class frmAbout : NUnit.UiKit.SettingsDialogBase 
    {
        /// <summary>
        /// 
        /// </summary>
        public frmAbout()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAbout_Load(object sender, EventArgs e)
        {
            this.pictureBox1.Image = SystemIcons.Information.ToBitmap();
            this.lblAppName.Text = strings.AppNameLong;
            this.lblAppVersion.Text = string.Format(strings.AppVersion, Application.ProductVersion);
            this.lblCompany.Text = strings.XdgkCompany;
            this.lnkHomaPage.Text = strings.HomePage;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkHomaPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string target = this.lnkHomaPage.Text ;
            System.Diagnostics.Process.Start(target);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

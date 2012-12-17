namespace YeHeCommuniServer
{
    partial class frmStationItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDiscriminateMode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStationName = new System.Windows.Forms.TextBox();
            this.lblDeviceType = new System.Windows.Forms.Label();
            this.panelByIPAddress = new System.Windows.Forms.Panel();
            this.txtStationIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBylRemotePort = new System.Windows.Forms.Panel();
            this.numRemotePort = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panelByLocalPort = new System.Windows.Forms.Panel();
            this.numLocalPort = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panelByIPAddress.SuspendLayout();
            this.panelBylRemotePort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRemotePort)).BeginInit();
            this.panelByLocalPort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLocalPort)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(164, 168);
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(252, 168);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(84, 93);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRemark.Size = new System.Drawing.Size(240, 69);
            this.txtRemark.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "备注：";
            // 
            // cmbDiscriminateMode
            // 
            this.cmbDiscriminateMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiscriminateMode.FormattingEnabled = true;
            this.cmbDiscriminateMode.Location = new System.Drawing.Point(84, 36);
            this.cmbDiscriminateMode.Name = "cmbDiscriminateMode";
            this.cmbDiscriminateMode.Size = new System.Drawing.Size(240, 20);
            this.cmbDiscriminateMode.TabIndex = 22;
            this.cmbDiscriminateMode.SelectedIndexChanged += new System.EventHandler(this.cmbDiscriminateMode_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "标识方式：";
            // 
            // txtStationName
            // 
            this.txtStationName.Location = new System.Drawing.Point(84, 8);
            this.txtStationName.Name = "txtStationName";
            this.txtStationName.Size = new System.Drawing.Size(240, 21);
            this.txtStationName.TabIndex = 20;
            // 
            // lblDeviceType
            // 
            this.lblDeviceType.AutoSize = true;
            this.lblDeviceType.Location = new System.Drawing.Point(13, 11);
            this.lblDeviceType.Name = "lblDeviceType";
            this.lblDeviceType.Size = new System.Drawing.Size(65, 12);
            this.lblDeviceType.TabIndex = 19;
            this.lblDeviceType.Text = "站点名称：";
            // 
            // panelByIPAddress
            // 
            this.panelByIPAddress.Controls.Add(this.txtStationIP);
            this.panelByIPAddress.Controls.Add(this.label1);
            this.panelByIPAddress.Location = new System.Drawing.Point(-1, 62);
            this.panelByIPAddress.Name = "panelByIPAddress";
            this.panelByIPAddress.Size = new System.Drawing.Size(338, 25);
            this.panelByIPAddress.TabIndex = 25;
            // 
            // txtStationIP
            // 
            this.txtStationIP.Location = new System.Drawing.Point(85, 3);
            this.txtStationIP.Name = "txtStationIP";
            this.txtStationIP.Size = new System.Drawing.Size(240, 21);
            this.txtStationIP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "站点IP：";
            // 
            // panelBylRemotePort
            // 
            this.panelBylRemotePort.Controls.Add(this.numRemotePort);
            this.panelBylRemotePort.Controls.Add(this.label4);
            this.panelBylRemotePort.Location = new System.Drawing.Point(-1, 62);
            this.panelBylRemotePort.Name = "panelBylRemotePort";
            this.panelBylRemotePort.Size = new System.Drawing.Size(338, 25);
            this.panelBylRemotePort.TabIndex = 26;
            // 
            // numRemotePort
            // 
            this.numRemotePort.Location = new System.Drawing.Point(85, 4);
            this.numRemotePort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numRemotePort.Name = "numRemotePort";
            this.numRemotePort.Size = new System.Drawing.Size(240, 21);
            this.numRemotePort.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "远程端口：";
            // 
            // panelByLocalPort
            // 
            this.panelByLocalPort.Controls.Add(this.numLocalPort);
            this.panelByLocalPort.Controls.Add(this.label3);
            this.panelByLocalPort.Location = new System.Drawing.Point(-1, 62);
            this.panelByLocalPort.Name = "panelByLocalPort";
            this.panelByLocalPort.Size = new System.Drawing.Size(338, 25);
            this.panelByLocalPort.TabIndex = 27;
            // 
            // numLocalPort
            // 
            this.numLocalPort.Location = new System.Drawing.Point(85, 4);
            this.numLocalPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numLocalPort.Name = "numLocalPort";
            this.numLocalPort.Size = new System.Drawing.Size(237, 21);
            this.numLocalPort.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "本地端口：";
            // 
            // frmStationItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 205);
            this.Controls.Add(this.panelByLocalPort);
            this.Controls.Add(this.panelBylRemotePort);
            this.Controls.Add(this.panelByIPAddress);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbDiscriminateMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStationName);
            this.Controls.Add(this.lblDeviceType);
            this.Name = "frmStationItem";
            this.Text = "站点";
            this.Load += new System.EventHandler(this.frmStationItem_Load);
            this.Controls.SetChildIndex(this.okButton, 0);
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(this.lblDeviceType, 0);
            this.Controls.SetChildIndex(this.txtStationName, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cmbDiscriminateMode, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtRemark, 0);
            this.Controls.SetChildIndex(this.panelByIPAddress, 0);
            this.Controls.SetChildIndex(this.panelBylRemotePort, 0);
            this.Controls.SetChildIndex(this.panelByLocalPort, 0);
            this.panelByIPAddress.ResumeLayout(false);
            this.panelByIPAddress.PerformLayout();
            this.panelBylRemotePort.ResumeLayout(false);
            this.panelBylRemotePort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRemotePort)).EndInit();
            this.panelByLocalPort.ResumeLayout(false);
            this.panelByLocalPort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLocalPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDiscriminateMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStationName;
        private System.Windows.Forms.Label lblDeviceType;
        private System.Windows.Forms.Panel panelByIPAddress;
        private System.Windows.Forms.TextBox txtStationIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBylRemotePort;
        private System.Windows.Forms.NumericUpDown numRemotePort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelByLocalPort;
        private System.Windows.Forms.NumericUpDown numLocalPort;
        private System.Windows.Forms.Label label3;
    }
}
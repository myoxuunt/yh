namespace YeHeCommuniServer
{
    partial class frmDeviceSelect
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
            this.lblDeviceSelect = new System.Windows.Forms.Label();
            this.lstDeviceType = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(82, 118);
            this.okButton.TabIndex = 2;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(160, 118);
            this.cancelButton.TabIndex = 3;
            // 
            // lblDeviceSelect
            // 
            this.lblDeviceSelect.AutoSize = true;
            this.lblDeviceSelect.Location = new System.Drawing.Point(12, 9);
            this.lblDeviceSelect.Name = "lblDeviceSelect";
            this.lblDeviceSelect.Size = new System.Drawing.Size(101, 12);
            this.lblDeviceSelect.TabIndex = 0;
            this.lblDeviceSelect.Text = "请选择设备类型：";
            // 
            // lstDeviceType
            // 
            this.lstDeviceType.FormattingEnabled = true;
            this.lstDeviceType.ItemHeight = 12;
            this.lstDeviceType.Location = new System.Drawing.Point(14, 24);
            this.lstDeviceType.Name = "lstDeviceType";
            this.lstDeviceType.Size = new System.Drawing.Size(218, 88);
            this.lstDeviceType.TabIndex = 1;
            // 
            // frmDeviceSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 155);
            this.Controls.Add(this.lblDeviceSelect);
            this.Controls.Add(this.lstDeviceType);
            this.Name = "frmDeviceSelect";
            this.Text = "设备类型";
            this.Load += new System.EventHandler(this.frmDeviceSelect_Load);
            this.Controls.SetChildIndex(this.okButton, 0);
            this.Controls.SetChildIndex(this.lstDeviceType, 0);
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(this.lblDeviceSelect, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeviceSelect;
        private System.Windows.Forms.ListBox lstDeviceType;
    }
}
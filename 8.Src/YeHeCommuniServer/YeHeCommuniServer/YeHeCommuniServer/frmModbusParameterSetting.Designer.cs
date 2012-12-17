namespace YeHeCommuniServer
{
    partial class frmModbusParameterSetting
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
            this.cmbParamName = new System.Windows.Forms.ComboBox();
            this.txtParamValue = new System.Windows.Forms.TextBox();
            this.lblParamName = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.cmbParamValue = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(44, 164);
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(132, 164);
            // 
            // cmbParamName
            // 
            this.cmbParamName.FormattingEnabled = true;
            this.cmbParamName.Location = new System.Drawing.Point(83, 63);
            this.cmbParamName.Name = "cmbParamName";
            this.cmbParamName.Size = new System.Drawing.Size(121, 20);
            this.cmbParamName.TabIndex = 19;
            this.cmbParamName.SelectedIndexChanged += new System.EventHandler(this.cmbParamName_SelectedIndexChanged);
            // 
            // txtParamValue
            // 
            this.txtParamValue.Location = new System.Drawing.Point(279, 92);
            this.txtParamValue.Name = "txtParamValue";
            this.txtParamValue.Size = new System.Drawing.Size(121, 21);
            this.txtParamValue.TabIndex = 20;
            // 
            // lblParamName
            // 
            this.lblParamName.AutoSize = true;
            this.lblParamName.Location = new System.Drawing.Point(12, 66);
            this.lblParamName.Name = "lblParamName";
            this.lblParamName.Size = new System.Drawing.Size(41, 12);
            this.lblParamName.TabIndex = 21;
            this.lblParamName.Text = "名称：";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(12, 92);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(41, 12);
            this.lblValue.TabIndex = 22;
            this.lblValue.Text = "数值：";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(12, 119);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(41, 12);
            this.lblUnit.TabIndex = 23;
            this.lblUnit.Text = "单位：";
            // 
            // txtUnit
            // 
            this.txtUnit.BackColor = System.Drawing.Color.White;
            this.txtUnit.Location = new System.Drawing.Point(83, 116);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(121, 21);
            this.txtUnit.TabIndex = 24;
            // 
            // cmbParamValue
            // 
            this.cmbParamValue.FormattingEnabled = true;
            this.cmbParamValue.Location = new System.Drawing.Point(83, 89);
            this.cmbParamValue.Name = "cmbParamValue";
            this.cmbParamValue.Size = new System.Drawing.Size(121, 20);
            this.cmbParamValue.TabIndex = 25;
            // 
            // frmParamSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 273);
            this.Controls.Add(this.cmbParamValue);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblParamName);
            this.Controls.Add(this.cmbParamName);
            this.Controls.Add(this.txtParamValue);
            this.Name = "frmParamSet";
            this.Text = "参数设这";
            this.Load += new System.EventHandler(this.frmParamSet_Load);
            this.Controls.SetChildIndex(this.txtParamValue, 0);
            this.Controls.SetChildIndex(this.cmbParamName, 0);
            this.Controls.SetChildIndex(this.lblParamName, 0);
            this.Controls.SetChildIndex(this.okButton, 0);
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(this.lblValue, 0);
            this.Controls.SetChildIndex(this.lblUnit, 0);
            this.Controls.SetChildIndex(this.txtUnit, 0);
            this.Controls.SetChildIndex(this.cmbParamValue, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbParamName;
        private System.Windows.Forms.TextBox txtParamValue;
        private System.Windows.Forms.Label lblParamName;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.ComboBox cmbParamValue;
    }
}
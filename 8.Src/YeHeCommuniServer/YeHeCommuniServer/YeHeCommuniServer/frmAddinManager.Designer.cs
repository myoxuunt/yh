namespace YeHeCommuniServer
{
    partial class frmAddinManager
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
            this.tcAddin = new System.Windows.Forms.TabControl();
            this.tpBC = new System.Windows.Forms.TabPage();
            this.txtBC = new System.Windows.Forms.TextBox();
            this.lstBC = new System.Windows.Forms.ListBox();
            this.tpCRC = new System.Windows.Forms.TabPage();
            this.txtCRC = new System.Windows.Forms.TextBox();
            this.lstCRC = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.tcAddin.SuspendLayout();
            this.tpBC.SuspendLayout();
            this.tpCRC.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAddin
            // 
            this.tcAddin.Controls.Add(this.tpBC);
            this.tcAddin.Controls.Add(this.tpCRC);
            this.tcAddin.Location = new System.Drawing.Point(0, 0);
            this.tcAddin.Name = "tcAddin";
            this.tcAddin.SelectedIndex = 0;
            this.tcAddin.Size = new System.Drawing.Size(282, 249);
            this.tcAddin.TabIndex = 3;
            // 
            // tpBC
            // 
            this.tpBC.Controls.Add(this.txtBC);
            this.tpBC.Controls.Add(this.lstBC);
            this.tpBC.Location = new System.Drawing.Point(4, 21);
            this.tpBC.Name = "tpBC";
            this.tpBC.Padding = new System.Windows.Forms.Padding(3);
            this.tpBC.Size = new System.Drawing.Size(274, 224);
            this.tpBC.TabIndex = 1;
            this.tpBC.Text = "转换";
            this.tpBC.UseVisualStyleBackColor = true;
            // 
            // txtBC
            // 
            this.txtBC.Location = new System.Drawing.Point(6, 100);
            this.txtBC.Multiline = true;
            this.txtBC.Name = "txtBC";
            this.txtBC.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBC.Size = new System.Drawing.Size(256, 112);
            this.txtBC.TabIndex = 6;
            // 
            // lstBC
            // 
            this.lstBC.FormattingEnabled = true;
            this.lstBC.ItemHeight = 12;
            this.lstBC.Location = new System.Drawing.Point(6, 6);
            this.lstBC.Name = "lstBC";
            this.lstBC.Size = new System.Drawing.Size(256, 88);
            this.lstBC.TabIndex = 5;
            // 
            // tpCRC
            // 
            this.tpCRC.Controls.Add(this.txtCRC);
            this.tpCRC.Controls.Add(this.lstCRC);
            this.tpCRC.Location = new System.Drawing.Point(4, 21);
            this.tpCRC.Name = "tpCRC";
            this.tpCRC.Padding = new System.Windows.Forms.Padding(3);
            this.tpCRC.Size = new System.Drawing.Size(274, 224);
            this.tpCRC.TabIndex = 2;
            this.tpCRC.Text = "校验";
            this.tpCRC.UseVisualStyleBackColor = true;
            // 
            // txtCRC
            // 
            this.txtCRC.Location = new System.Drawing.Point(6, 103);
            this.txtCRC.Multiline = true;
            this.txtCRC.Name = "txtCRC";
            this.txtCRC.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCRC.Size = new System.Drawing.Size(256, 112);
            this.txtCRC.TabIndex = 8;
            // 
            // lstCRC
            // 
            this.lstCRC.FormattingEnabled = true;
            this.lstCRC.ItemHeight = 12;
            this.lstCRC.Location = new System.Drawing.Point(6, 9);
            this.lstCRC.Name = "lstCRC";
            this.lstCRC.Size = new System.Drawing.Size(256, 88);
            this.lstCRC.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(203, 255);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddinManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 282);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcAddin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddinManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "插件管理";
            this.Load += new System.EventHandler(this.frmAddinManager_Load);
            this.tcAddin.ResumeLayout(false);
            this.tpBC.ResumeLayout(false);
            this.tpBC.PerformLayout();
            this.tpCRC.ResumeLayout(false);
            this.tpCRC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAddin;
        private System.Windows.Forms.TabPage tpBC;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtBC;
        private System.Windows.Forms.ListBox lstBC;
        private System.Windows.Forms.TabPage tpCRC;
        private System.Windows.Forms.TextBox txtCRC;
        private System.Windows.Forms.ListBox lstCRC;
    }
}
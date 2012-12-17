namespace YHZKPort
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnExec = new System.Windows.Forms.Button();
            this.tmrTransfer = new System.Windows.Forms.Timer(this.components);
            this.txtServerUrl = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtLog.Location = new System.Drawing.Point(12, 39);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(554, 313);
            this.txtLog.TabIndex = 0;
            this.txtLog.WordWrap = false;
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(572, 329);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(75, 23);
            this.btnExec.TabIndex = 1;
            this.btnExec.Text = "立即执行";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // tmrTransfer
            // 
            this.tmrTransfer.Tick += new System.EventHandler(this.tmrTransfer_Tick);
            // 
            // txtServerUrl
            // 
            this.txtServerUrl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtServerUrl.Location = new System.Drawing.Point(12, 12);
            this.txtServerUrl.Name = "txtServerUrl";
            this.txtServerUrl.ReadOnly = true;
            this.txtServerUrl.Size = new System.Drawing.Size(554, 21);
            this.txtServerUrl.TabIndex = 2;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(572, 12);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "测试";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 357);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtServerUrl);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.txtLog);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "冶河闸控数据远传";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Timer tmrTransfer;
        private System.Windows.Forms.TextBox txtServerUrl;
        private System.Windows.Forms.Button btnTest;
    }
}
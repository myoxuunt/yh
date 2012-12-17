namespace YeHeCommuniServer
{
    partial class frmXD221Params
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
            this.txtXD221Params = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(136, 151);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(224, 151);
            // 
            // txtXD221Params
            // 
            this.txtXD221Params.Location = new System.Drawing.Point(12, 12);
            this.txtXD221Params.Multiline = true;
            this.txtXD221Params.Name = "txtXD221Params";
            this.txtXD221Params.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtXD221Params.Size = new System.Drawing.Size(284, 133);
            this.txtXD221Params.TabIndex = 19;
            // 
            // frmXD221Params
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 187);
            this.Controls.Add(this.txtXD221Params);
            this.Name = "frmXD221Params";
            this.Text = "frmXD221Params";
            this.Load += new System.EventHandler(this.frmXD221Params_Load);
            this.Controls.SetChildIndex(this.txtXD221Params, 0);
            this.Controls.SetChildIndex(this.okButton, 0);
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtXD221Params;
    }
}
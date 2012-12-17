namespace RWTrans
{
    partial class frmFormulaManager
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
            this.btnEditFormula = new System.Windows.Forms.Button();
            this.btnDeleteFormula = new System.Windows.Forms.Button();
            this.btnAddFormula = new System.Windows.Forms.Button();
            this.lvFormula = new System.Windows.Forms.ListView();
            this.chBegin = new System.Windows.Forms.ColumnHeader();
            this.chEnd = new System.Windows.Forms.ColumnHeader();
            this.chExpress = new System.Windows.Forms.ColumnHeader();
            this.lstWaterDevice = new System.Windows.Forms.ListBox();
            this.lblWaterDevice = new System.Windows.Forms.Label();
            this.lblFormula = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditFormula
            // 
            this.btnEditFormula.Location = new System.Drawing.Point(94, 348);
            this.btnEditFormula.Name = "btnEditFormula";
            this.btnEditFormula.Size = new System.Drawing.Size(75, 23);
            this.btnEditFormula.TabIndex = 7;
            this.btnEditFormula.Text = "修改";
            this.btnEditFormula.UseVisualStyleBackColor = true;
            this.btnEditFormula.Click += new System.EventHandler(this.btnEditFormula_Click);
            // 
            // btnDeleteFormula
            // 
            this.btnDeleteFormula.Location = new System.Drawing.Point(175, 348);
            this.btnDeleteFormula.Name = "btnDeleteFormula";
            this.btnDeleteFormula.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFormula.TabIndex = 6;
            this.btnDeleteFormula.Text = "删除";
            this.btnDeleteFormula.UseVisualStyleBackColor = true;
            this.btnDeleteFormula.Click += new System.EventHandler(this.btnDeleteFormula_Click);
            // 
            // btnAddFormula
            // 
            this.btnAddFormula.Location = new System.Drawing.Point(13, 349);
            this.btnAddFormula.Name = "btnAddFormula";
            this.btnAddFormula.Size = new System.Drawing.Size(75, 23);
            this.btnAddFormula.TabIndex = 5;
            this.btnAddFormula.Text = "新建";
            this.btnAddFormula.UseVisualStyleBackColor = true;
            this.btnAddFormula.Click += new System.EventHandler(this.btnAddFormula_Click);
            // 
            // lvFormula
            // 
            this.lvFormula.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBegin,
            this.chEnd,
            this.chExpress});
            this.lvFormula.FullRowSelect = true;
            this.lvFormula.Location = new System.Drawing.Point(12, 175);
            this.lvFormula.Name = "lvFormula";
            this.lvFormula.Size = new System.Drawing.Size(274, 167);
            this.lvFormula.TabIndex = 4;
            this.lvFormula.UseCompatibleStateImageBehavior = false;
            this.lvFormula.View = System.Windows.Forms.View.Details;
            // 
            // chBegin
            // 
            this.chBegin.Text = "开始时间";
            // 
            // chEnd
            // 
            this.chEnd.Text = "结束时间";
            // 
            // chExpress
            // 
            this.chExpress.Text = "公式";
            this.chExpress.Width = 117;
            // 
            // lstWaterDevice
            // 
            this.lstWaterDevice.FormattingEnabled = true;
            this.lstWaterDevice.ItemHeight = 12;
            this.lstWaterDevice.Location = new System.Drawing.Point(12, 30);
            this.lstWaterDevice.Name = "lstWaterDevice";
            this.lstWaterDevice.Size = new System.Drawing.Size(274, 112);
            this.lstWaterDevice.TabIndex = 8;
            this.lstWaterDevice.SelectedIndexChanged += new System.EventHandler(this.lstWaterDevice_SelectedIndexChanged);
            // 
            // lblWaterDevice
            // 
            this.lblWaterDevice.AutoSize = true;
            this.lblWaterDevice.Location = new System.Drawing.Point(11, 9);
            this.lblWaterDevice.Name = "lblWaterDevice";
            this.lblWaterDevice.Size = new System.Drawing.Size(59, 12);
            this.lblWaterDevice.TabIndex = 9;
            this.lblWaterDevice.Text = "水位测点:";
            // 
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Location = new System.Drawing.Point(11, 156);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(59, 12);
            this.lblFormula.TabIndex = 10;
            this.lblFormula.Text = "流量公式:";
            // 
            // frmFormulaManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 382);
            this.Controls.Add(this.lblFormula);
            this.Controls.Add(this.lblWaterDevice);
            this.Controls.Add(this.lstWaterDevice);
            this.Controls.Add(this.btnEditFormula);
            this.Controls.Add(this.btnDeleteFormula);
            this.Controls.Add(this.btnAddFormula);
            this.Controls.Add(this.lvFormula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFormulaManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "公式";
            this.Load += new System.EventHandler(this.frmFormula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditFormula;
        private System.Windows.Forms.Button btnDeleteFormula;
        private System.Windows.Forms.Button btnAddFormula;
        private System.Windows.Forms.ListView lvFormula;
        private System.Windows.Forms.ColumnHeader chBegin;
        private System.Windows.Forms.ColumnHeader chEnd;
        private System.Windows.Forms.ColumnHeader chExpress;
        private System.Windows.Forms.ListBox lstWaterDevice;
        private System.Windows.Forms.Label lblWaterDevice;
        private System.Windows.Forms.Label lblFormula;
    }
}
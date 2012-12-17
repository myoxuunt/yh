namespace YeHeCommuniServer
{
    partial class frmDeviceItem
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtDeviceType = new System.Windows.Forms.TextBox();
            this.txtOwnerStatoin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numDeviceAddress = new System.Windows.Forms.NumericUpDown();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEditFormula = new System.Windows.Forms.Button();
            this.btnDeleteFormula = new System.Windows.Forms.Button();
            this.btnAddFormula = new System.Windows.Forms.Button();
            this.lvFormula = new System.Windows.Forms.ListView();
            this.chBegin = new System.Windows.Forms.ColumnHeader();
            this.chEnd = new System.Windows.Forms.ColumnHeader();
            this.chExpress = new System.Windows.Forms.ColumnHeader();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDeviceAddress)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(142, 256);
            this.okButton.TabIndex = 10;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(230, 256);
            this.cancelButton.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(294, 238);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtDeviceType);
            this.tabPage1.Controls.Add(this.txtOwnerStatoin);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.txtRemark);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.numDeviceAddress);
            this.tabPage1.Controls.Add(this.lblAddress);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(286, 213);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "常规";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtDeviceType
            // 
            this.txtDeviceType.Location = new System.Drawing.Point(80, 40);
            this.txtDeviceType.Name = "txtDeviceType";
            this.txtDeviceType.ReadOnly = true;
            this.txtDeviceType.Size = new System.Drawing.Size(192, 21);
            this.txtDeviceType.TabIndex = 13;
            // 
            // txtOwnerStatoin
            // 
            this.txtOwnerStatoin.Location = new System.Drawing.Point(81, 13);
            this.txtOwnerStatoin.Name = "txtOwnerStatoin";
            this.txtOwnerStatoin.ReadOnly = true;
            this.txtOwnerStatoin.Size = new System.Drawing.Size(192, 21);
            this.txtOwnerStatoin.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "所属站点：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "设备类型：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 21);
            this.txtName.TabIndex = 15;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(81, 120);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRemark.Size = new System.Drawing.Size(192, 81);
            this.txtRemark.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "备注：";
            // 
            // numDeviceAddress
            // 
            this.numDeviceAddress.Location = new System.Drawing.Point(81, 93);
            this.numDeviceAddress.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numDeviceAddress.Name = "numDeviceAddress";
            this.numDeviceAddress.Size = new System.Drawing.Size(191, 21);
            this.numDeviceAddress.TabIndex = 17;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(3, 95);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 12);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "设备地址：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEditFormula);
            this.tabPage2.Controls.Add(this.btnDeleteFormula);
            this.tabPage2.Controls.Add(this.btnAddFormula);
            this.tabPage2.Controls.Add(this.lvFormula);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(286, 213);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "流量公式";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEditFormula
            // 
            this.btnEditFormula.Location = new System.Drawing.Point(88, 179);
            this.btnEditFormula.Name = "btnEditFormula";
            this.btnEditFormula.Size = new System.Drawing.Size(75, 23);
            this.btnEditFormula.TabIndex = 3;
            this.btnEditFormula.Text = "修改";
            this.btnEditFormula.UseVisualStyleBackColor = true;
            this.btnEditFormula.Click += new System.EventHandler(this.btnEditFormula_Click);
            // 
            // btnDeleteFormula
            // 
            this.btnDeleteFormula.Location = new System.Drawing.Point(169, 179);
            this.btnDeleteFormula.Name = "btnDeleteFormula";
            this.btnDeleteFormula.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFormula.TabIndex = 2;
            this.btnDeleteFormula.Text = "删除";
            this.btnDeleteFormula.UseVisualStyleBackColor = true;
            this.btnDeleteFormula.Click += new System.EventHandler(this.btnDeleteFormula_Click);
            // 
            // btnAddFormula
            // 
            this.btnAddFormula.Location = new System.Drawing.Point(7, 180);
            this.btnAddFormula.Name = "btnAddFormula";
            this.btnAddFormula.Size = new System.Drawing.Size(75, 23);
            this.btnAddFormula.TabIndex = 1;
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
            this.lvFormula.Location = new System.Drawing.Point(6, 6);
            this.lvFormula.Name = "lvFormula";
            this.lvFormula.Size = new System.Drawing.Size(274, 167);
            this.lvFormula.TabIndex = 0;
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
            // 
            // frmDeviceItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 292);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmDeviceItem";
            this.Text = "frmDeviceItem";
            this.Load += new System.EventHandler(this.frmDeviceItem_Load);
            this.Controls.SetChildIndex(this.okButton, 0);
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDeviceAddress)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        protected System.Windows.Forms.TextBox txtDeviceType;
        protected System.Windows.Forms.TextBox txtOwnerStatoin;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox txtName;
        protected System.Windows.Forms.TextBox txtRemark;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.NumericUpDown numDeviceAddress;
        protected System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnEditFormula;
        private System.Windows.Forms.Button btnDeleteFormula;
        private System.Windows.Forms.Button btnAddFormula;
        private System.Windows.Forms.ListView lvFormula;
        private System.Windows.Forms.ColumnHeader chBegin;
        private System.Windows.Forms.ColumnHeader chEnd;
        private System.Windows.Forms.ColumnHeader chExpress;
    }
}
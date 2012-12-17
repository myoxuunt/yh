namespace YeHeCommuniServer
{
    partial class frmTaskManage
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
            this.lvTask = new System.Windows.Forms.ListView();
            this.chStation = new System.Windows.Forms.ColumnHeader();
            this.chDevice = new System.Windows.Forms.ColumnHeader();
            this.chTask = new System.Windows.Forms.ColumnHeader();
            this.chTaskType = new System.Windows.Forms.ColumnHeader();
            this.chLastExecute = new System.Windows.Forms.ColumnHeader();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(456, 281);
            this.okButton.TabIndex = 6;
            this.okButton.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(534, 281);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "关闭";
            // 
            // lvTask
            // 
            this.lvTask.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chStation,
            this.chDevice,
            this.chTask,
            this.chTaskType,
            this.chLastExecute});
            this.lvTask.FullRowSelect = true;
            this.lvTask.Location = new System.Drawing.Point(12, 12);
            this.lvTask.Name = "lvTask";
            this.lvTask.Size = new System.Drawing.Size(594, 265);
            this.lvTask.TabIndex = 0;
            this.lvTask.UseCompatibleStateImageBehavior = false;
            this.lvTask.View = System.Windows.Forms.View.Details;
            // 
            // chStation
            // 
            this.chStation.Text = "站点";
            this.chStation.Width = 120;
            // 
            // chDevice
            // 
            this.chDevice.Text = "设备";
            this.chDevice.Width = 90;
            // 
            // chTask
            // 
            this.chTask.Text = "名称";
            this.chTask.Width = 120;
            // 
            // chTaskType
            // 
            this.chTaskType.Text = "类型";
            this.chTaskType.Width = 90;
            // 
            // chLastExecute
            // 
            this.chLastExecute.Text = "最后执行";
            this.chLastExecute.Width = 160;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 282);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(255, 282);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(75, 23);
            this.btnDetail.TabIndex = 4;
            this.btnDetail.Text = "详细";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(93, 282);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(174, 282);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmTaskManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 315);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvTask);
            this.Name = "frmTaskManage";
            this.Text = "任务管理";
            this.Load += new System.EventHandler(this.frmTaskManage_Load);
            this.Controls.SetChildIndex(this.okButton, 0);
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(this.lvTask, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnDetail, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnRefresh, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvTask;
        private System.Windows.Forms.ColumnHeader chStation;
        private System.Windows.Forms.ColumnHeader chDevice;
        private System.Windows.Forms.ColumnHeader chTask;
        private System.Windows.Forms.ColumnHeader chTaskType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ColumnHeader chLastExecute;
    }
}
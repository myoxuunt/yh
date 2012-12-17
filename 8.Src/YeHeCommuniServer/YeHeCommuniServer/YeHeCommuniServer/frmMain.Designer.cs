namespace YeHeCommuniServer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddinManager = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaskManage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStatusbar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStationAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStationEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStationDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeviceAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeviceEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeviceDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tvStation = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssListenPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuView,
            this.mnuStation,
            this.mnuDevice,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(702, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.mnuExit,
            this.mnuAddinManager,
            this.mnuTaskManage});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(59, 20);
            this.mnuFile.Text = "文件(&F)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(136, 22);
            this.mnuExit.Text = "退出";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuAddinManager
            // 
            this.mnuAddinManager.Name = "mnuAddinManager";
            this.mnuAddinManager.Size = new System.Drawing.Size(136, 22);
            this.mnuAddinManager.Text = "插件管理(P)";
            this.mnuAddinManager.Click += new System.EventHandler(this.mnuAddinManager_Click);
            // 
            // mnuTaskManage
            // 
            this.mnuTaskManage.Name = "mnuTaskManage";
            this.mnuTaskManage.Size = new System.Drawing.Size(136, 22);
            this.mnuTaskManage.Text = "任务管理(&T)";
            this.mnuTaskManage.Click += new System.EventHandler(this.mnuTaskManage_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolbar,
            this.mnuStatusbar});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(59, 20);
            this.mnuView.Text = "视图(&V)";
            // 
            // mnuToolbar
            // 
            this.mnuToolbar.Name = "mnuToolbar";
            this.mnuToolbar.Size = new System.Drawing.Size(124, 22);
            this.mnuToolbar.Text = "工具栏(&T)";
            // 
            // mnuStatusbar
            // 
            this.mnuStatusbar.Name = "mnuStatusbar";
            this.mnuStatusbar.Size = new System.Drawing.Size(124, 22);
            this.mnuStatusbar.Text = "状态栏(&S)";
            // 
            // mnuStation
            // 
            this.mnuStation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStationAdd,
            this.mnuStationEdit,
            this.mnuStationDelete});
            this.mnuStation.Name = "mnuStation";
            this.mnuStation.Size = new System.Drawing.Size(59, 20);
            this.mnuStation.Text = "站点(&S)";
            // 
            // mnuStationAdd
            // 
            this.mnuStationAdd.Name = "mnuStationAdd";
            this.mnuStationAdd.Size = new System.Drawing.Size(112, 22);
            this.mnuStationAdd.Text = "添加(&A)";
            this.mnuStationAdd.Click += new System.EventHandler(this.mnuStationAdd_Click);
            // 
            // mnuStationEdit
            // 
            this.mnuStationEdit.Name = "mnuStationEdit";
            this.mnuStationEdit.Size = new System.Drawing.Size(112, 22);
            this.mnuStationEdit.Text = "修改(&E)";
            this.mnuStationEdit.Click += new System.EventHandler(this.mnuStationEdit_Click);
            // 
            // mnuStationDelete
            // 
            this.mnuStationDelete.Name = "mnuStationDelete";
            this.mnuStationDelete.Size = new System.Drawing.Size(112, 22);
            this.mnuStationDelete.Text = "删除(&D)";
            this.mnuStationDelete.Click += new System.EventHandler(this.mnuStationDelete_Click);
            // 
            // mnuDevice
            // 
            this.mnuDevice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDeviceAdd,
            this.mnuDeviceEdit,
            this.mnuDeviceDelete});
            this.mnuDevice.Name = "mnuDevice";
            this.mnuDevice.Size = new System.Drawing.Size(59, 20);
            this.mnuDevice.Text = "设备(&D)";
            // 
            // mnuDeviceAdd
            // 
            this.mnuDeviceAdd.Name = "mnuDeviceAdd";
            this.mnuDeviceAdd.Size = new System.Drawing.Size(112, 22);
            this.mnuDeviceAdd.Text = "添加(&A)";
            this.mnuDeviceAdd.Click += new System.EventHandler(this.mnuDeviceAdd_Click);
            // 
            // mnuDeviceEdit
            // 
            this.mnuDeviceEdit.Name = "mnuDeviceEdit";
            this.mnuDeviceEdit.Size = new System.Drawing.Size(112, 22);
            this.mnuDeviceEdit.Text = "修改(&E)";
            this.mnuDeviceEdit.Click += new System.EventHandler(this.mnuDeviceEdit_Click);
            // 
            // mnuDeviceDelete
            // 
            this.mnuDeviceDelete.Name = "mnuDeviceDelete";
            this.mnuDeviceDelete.Size = new System.Drawing.Size(112, 22);
            this.mnuDeviceDelete.Text = "删除(&D)";
            this.mnuDeviceDelete.Click += new System.EventHandler(this.mnuDeviceDelete_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(59, 20);
            this.mnuHelp.Text = "帮助(&H)";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(112, 22);
            this.mnuAbout.Text = "关于(&A)";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // tvStation
            // 
            this.tvStation.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvStation.Location = new System.Drawing.Point(0, 24);
            this.tvStation.Name = "tvStation";
            this.tvStation.Size = new System.Drawing.Size(127, 418);
            this.tvStation.TabIndex = 3;
            this.tvStation.DoubleClick += new System.EventHandler(this.tvStation_DoubleClick);
            this.tvStation.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvStation_AfterSelect);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(127, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 418);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(133, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 418);
            this.panel1.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssListenPort});
            this.statusStrip1.Location = new System.Drawing.Point(0, 442);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(702, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssListenPort
            // 
            this.tssListenPort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tssListenPort.Name = "tssListenPort";
            this.tssListenPort.Size = new System.Drawing.Size(131, 17);
            this.tssListenPort.Text = "toolStripStatusLabel1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 464);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tvStation);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TreeView tvStation;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripMenuItem mnuStation;
        private System.Windows.Forms.ToolStripMenuItem mnuDevice;
        private System.Windows.Forms.ToolStripMenuItem mnuStationAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuStationEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuStationDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuDeviceAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuDeviceEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuDeviceDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuAddinManager;
        private System.Windows.Forms.ToolStripMenuItem mnuTaskManage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuToolbar;
        private System.Windows.Forms.ToolStripMenuItem mnuStatusbar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssListenPort;
    }
}
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;
using BengZhan.AutoBackup;
using System.Data;
using System.Data.SqlClient ;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;

namespace BengZhan
{
	/// <summary>
	/// frmWaterSys 的摘要说明。
	/// </summary>
	public class frmWaterSys : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MenuItem mnu_userMana;
		private System.Windows.Forms.MenuItem mnu_exit;
		private System.Windows.Forms.MenuItem mnu_changePwd;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem mnuCountry;
		private System.Windows.Forms.MenuItem mnuDep;
		private System.Windows.Forms.MenuItem mnuHangYe;
		private System.Windows.Forms.MenuItem mnuWell;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem mnuMon;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem mnuFlowAmount;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton6;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem mnu_users;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem mnu_back;
		private System.Windows.Forms.MenuItem mnu_restore;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.ToolBarButton toolBarButton8;
		private System.Windows.Forms.MenuItem mnuChart;
		private System.Windows.Forms.MenuItem mnuReset;
		private System.Windows.Forms.ToolBarButton toolBarButton10;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.MenuItem mnuAbort;
		private System.Windows.Forms.ToolBarButton toolBarButton13;
		private System.Windows.Forms.ToolBarButton toolBarButton18;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.ErrorProvider errorProvider2;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.MenuItem menuItem18;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem menuItem20;
		private System.Windows.Forms.MenuItem menuItem21;
		private System.Windows.Forms.MenuItem mnuInfo;
		private System.Windows.Forms.ToolBarButton toolBarButton14;
		private System.Windows.Forms.MenuItem menuItem22;
		private System.Windows.Forms.MenuItem menuItem23;
		private System.Windows.Forms.ToolBarButton toolBarButton15;
		private System.Windows.Forms.ToolBarButton toolBarButton9;
		private System.Windows.Forms.MenuItem menuItem24;
		private System.Windows.Forms.MenuItem menuItem25;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.MenuItem menuItem26;
		private System.Windows.Forms.MenuItem menuItem27;
		private System.Windows.Forms.ToolBarButton toolBarButton16;
		private System.Windows.Forms.MenuItem menuItem28;
		private System.Windows.Forms.ToolBarButton toolBarButton17;
		private System.Windows.Forms.MenuItem menuItem29;
		private System.Windows.Forms.MenuItem menuItem30;
		private System.Windows.Forms.ToolBarButton toolBarButton11;

		public static string m_softName;

		public frmWaterSys()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmWaterSys));
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton14 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton10 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton17 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton9 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton18 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton13 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton16 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton15 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton8 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.mnu_users = new System.Windows.Forms.MenuItem();
			this.mnu_userMana = new System.Windows.Forms.MenuItem();
			this.mnu_changePwd = new System.Windows.Forms.MenuItem();
			this.mnuReset = new System.Windows.Forms.MenuItem();
			this.mnuInfo = new System.Windows.Forms.MenuItem();
			this.mnu_exit = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.mnuCountry = new System.Windows.Forms.MenuItem();
			this.mnuHangYe = new System.Windows.Forms.MenuItem();
			this.mnuDep = new System.Windows.Forms.MenuItem();
			this.mnuWell = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem21 = new System.Windows.Forms.MenuItem();
			this.menuItem29 = new System.Windows.Forms.MenuItem();
			this.menuItem17 = new System.Windows.Forms.MenuItem();
			this.menuItem18 = new System.Windows.Forms.MenuItem();
			this.menuItem19 = new System.Windows.Forms.MenuItem();
			this.menuItem25 = new System.Windows.Forms.MenuItem();
			this.menuItem27 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.mnuMon = new System.Windows.Forms.MenuItem();
			this.menuItem20 = new System.Windows.Forms.MenuItem();
			this.menuItem30 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.mnuFlowAmount = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem22 = new System.Windows.Forms.MenuItem();
			this.menuItem23 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem24 = new System.Windows.Forms.MenuItem();
			this.menuItem26 = new System.Windows.Forms.MenuItem();
			this.menuItem28 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.mnuChart = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.mnu_back = new System.Windows.Forms.MenuItem();
			this.mnu_restore = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.menuItem16 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.mnuAbort = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.button1 = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
			this.errorProvider2 = new System.Windows.Forms.ErrorProvider();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.toolBarButton11 = new System.Windows.Forms.ToolBarButton();
			this.SuspendLayout();
			// 
			// toolBar1
			// 
			this.toolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.toolBarButton1,
																						this.toolBarButton14,
																						this.toolBarButton10,
																						this.toolBarButton17,
																						this.toolBarButton9,
																						this.toolBarButton18,
																						this.toolBarButton3,
																						this.toolBarButton11,
																						this.toolBarButton13,
																						this.toolBarButton16,
																						this.toolBarButton15,
																						this.toolBarButton2,
																						this.toolBarButton4,
																						this.toolBarButton8,
																						this.toolBarButton5,
																						this.toolBarButton6,
																						this.toolBarButton7});
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.ImageList = this.imageList1;
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(1028, 42);
			this.toolBar1.TabIndex = 2;
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.ImageIndex = 36;
			this.toolBarButton1.Text = "用户管理";
			// 
			// toolBarButton14
			// 
			this.toolBarButton14.ImageIndex = 41;
			this.toolBarButton14.Text = "地理信息";
			// 
			// toolBarButton10
			// 
			this.toolBarButton10.ImageIndex = 28;
			this.toolBarButton10.Text = "测站信息 ";
			// 
			// toolBarButton17
			// 
			this.toolBarButton17.ImageIndex = 35;
			this.toolBarButton17.Text = "参数管理";
			// 
			// toolBarButton9
			// 
			this.toolBarButton9.ImageIndex = 43;
			this.toolBarButton9.Text = "售水统计";
			// 
			// toolBarButton18
			// 
			this.toolBarButton18.ImageIndex = 39;
			this.toolBarButton18.Text = "IC卡管理";
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.ImageIndex = 12;
			this.toolBarButton3.Text = "实时监测";
			// 
			// toolBarButton13
			// 
			this.toolBarButton13.ImageIndex = 30;
			this.toolBarButton13.Text = "实时查看";
			this.toolBarButton13.Visible = false;
			// 
			// toolBarButton16
			// 
			this.toolBarButton16.ImageIndex = 32;
			this.toolBarButton16.Text = "年结统计";
			// 
			// toolBarButton15
			// 
			this.toolBarButton15.ImageIndex = 42;
			this.toolBarButton15.Text = "总帐统计";
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.ImageIndex = 26;
			this.toolBarButton2.Text = "月结统计";
			// 
			// toolBarButton4
			// 
			this.toolBarButton4.ImageIndex = 25;
			this.toolBarButton4.Text = "流量统计";
			// 
			// toolBarButton8
			// 
			this.toolBarButton8.ImageIndex = 27;
			this.toolBarButton8.Text = "历史曲线";
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.ImageIndex = 31;
			this.toolBarButton5.Text = "欠费名单";
			// 
			// toolBarButton6
			// 
			this.toolBarButton6.ImageIndex = 20;
			this.toolBarButton6.Text = "系统帮助";
			// 
			// toolBarButton7
			// 
			this.toolBarButton7.ImageIndex = 13;
			this.toolBarButton7.Text = "退出系统";
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem3,
																					  this.menuItem17,
																					  this.menuItem4,
																					  this.menuItem5,
																					  this.menuItem9,
																					  this.menuItem2,
																					  this.menuItem14,
																					  this.menuItem6});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.mnu_users,
																					  this.mnu_userMana,
																					  this.mnu_changePwd,
																					  this.mnuReset,
																					  this.mnuInfo,
																					  this.mnu_exit});
			this.menuItem1.Text = "系统管理";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// mnu_users
			// 
			this.mnu_users.Index = 0;
			this.mnu_users.Text = "用户管理";
			this.mnu_users.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// mnu_userMana
			// 
			this.mnu_userMana.Index = 1;
			this.mnu_userMana.Text = "用户授权";
			this.mnu_userMana.Click += new System.EventHandler(this.mnu_userMana_Click);
			// 
			// mnu_changePwd
			// 
			this.mnu_changePwd.Index = 2;
			this.mnu_changePwd.Text = "密码修改";
			this.mnu_changePwd.Click += new System.EventHandler(this.mnu_changePwd_Click);
			// 
			// mnuReset
			// 
			this.mnuReset.Index = 3;
			this.mnuReset.Text = "重新登录";
			this.mnuReset.Click += new System.EventHandler(this.mnuReset_Click);
			// 
			// mnuInfo
			// 
			this.mnuInfo.Index = 4;
			this.mnuInfo.Text = "地理信息";
			this.mnuInfo.Click += new System.EventHandler(this.mnuInfo_Click);
			// 
			// mnu_exit
			// 
			this.mnu_exit.Index = 5;
			this.mnu_exit.Text = "退出";
			this.mnu_exit.Click += new System.EventHandler(this.mnu_exit_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.mnuCountry,
																					  this.mnuHangYe,
																					  this.mnuDep,
																					  this.mnuWell,
																					  this.menuItem11,
																					  this.menuItem21,
																					  this.menuItem29});
			this.menuItem3.Text = "基本信息管理";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// mnuCountry
			// 
			this.mnuCountry.Index = 0;
			this.mnuCountry.Text = "管理局信息";
			this.mnuCountry.Click += new System.EventHandler(this.mnuCountry_Click);
			// 
			// mnuHangYe
			// 
			this.mnuHangYe.Index = 1;
			this.mnuHangYe.Text = "行业(性质)信息";
			this.mnuHangYe.Click += new System.EventHandler(this.mnuHangYe_Click);
			// 
			// mnuDep
			// 
			this.mnuDep.Index = 2;
			this.mnuDep.Text = "管理处信息";
			this.mnuDep.Click += new System.EventHandler(this.mnuDep_Click);
			// 
			// mnuWell
			// 
			this.mnuWell.Index = 3;
			this.mnuWell.Text = "测站信息";
			this.mnuWell.Click += new System.EventHandler(this.mnuWell_Click);
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 4;
			this.menuItem11.Text = "报警参数";
			this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
			// 
			// menuItem21
			// 
			this.menuItem21.Index = 5;
			this.menuItem21.Text = "水价管理";
			this.menuItem21.Click += new System.EventHandler(this.menuItem21_Click);
			// 
			// menuItem29
			// 
			this.menuItem29.Index = 6;
			this.menuItem29.Text = "售水站信息";
			this.menuItem29.Click += new System.EventHandler(this.menuItem29_Click);
			// 
			// menuItem17
			// 
			this.menuItem17.Index = 2;
			this.menuItem17.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem18,
																					   this.menuItem19,
																					   this.menuItem25,
																					   this.menuItem27});
			this.menuItem17.Text = "售水管理";
			this.menuItem17.Click += new System.EventHandler(this.menuItem17_Click);
			// 
			// menuItem18
			// 
			this.menuItem18.Index = 0;
			this.menuItem18.Text = "售水管理";
			this.menuItem18.Click += new System.EventHandler(this.menuItem18_Click);
			// 
			// menuItem19
			// 
			this.menuItem19.Index = 1;
			this.menuItem19.Text = "IC卡管理";
			this.menuItem19.Click += new System.EventHandler(this.menuItem19_Click);
			// 
			// menuItem25
			// 
			this.menuItem25.Index = 2;
			this.menuItem25.Text = "售水查看";
			this.menuItem25.Click += new System.EventHandler(this.menuItem25_Click);
			// 
			// menuItem27
			// 
			this.menuItem27.Index = 3;
			this.menuItem27.Text = "TM卡售水";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 3;
			this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.mnuMon,
																					  this.menuItem20,
																					  this.menuItem30});
			this.menuItem4.Text = "实时监测";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// mnuMon
			// 
			this.mnuMon.Index = 0;
			this.mnuMon.Text = "实时监测";
			this.mnuMon.Click += new System.EventHandler(this.mnuMon_Click);
			// 
			// menuItem20
			// 
			this.menuItem20.Index = 1;
			this.menuItem20.Text = "正点定时";
			this.menuItem20.Click += new System.EventHandler(this.menuItem20_Click);
			// 
			// menuItem30
			// 
			this.menuItem30.Index = 2;
			this.menuItem30.Text = "人工录入";
			this.menuItem30.Click += new System.EventHandler(this.menuItem30_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 4;
			this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.mnuFlowAmount,
																					  this.menuItem13,
																					  this.menuItem22,
																					  this.menuItem23,
																					  this.menuItem12,
																					  this.menuItem24,
																					  this.menuItem26,
																					  this.menuItem28});
			this.menuItem5.Text = "统计报表";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// mnuFlowAmount
			// 
			this.mnuFlowAmount.Index = 0;
			this.mnuFlowAmount.Text = "流量统计";
			this.mnuFlowAmount.Click += new System.EventHandler(this.mnuFlowAmount_Click);
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 1;
			this.menuItem13.Text = "售水统计";
			this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
			// 
			// menuItem22
			// 
			this.menuItem22.Index = 2;
			this.menuItem22.Text = "单位流量统计表";
			this.menuItem22.Click += new System.EventHandler(this.menuItem22_Click);
			// 
			// menuItem23
			// 
			this.menuItem23.Index = 3;
			this.menuItem23.Text = "单位购水统计表";
			this.menuItem23.Click += new System.EventHandler(this.menuItem23_Click);
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 4;
			this.menuItem12.Text = "报警明细";
			this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
			// 
			// menuItem24
			// 
			this.menuItem24.Index = 5;
			this.menuItem24.Text = "总帐统计";
			this.menuItem24.Click += new System.EventHandler(this.menuItem24_Click);
			// 
			// menuItem26
			// 
			this.menuItem26.Index = 6;
			this.menuItem26.Text = "月结统计";
			this.menuItem26.Click += new System.EventHandler(this.menuItem26_Click);
			// 
			// menuItem28
			// 
			this.menuItem28.Index = 7;
			this.menuItem28.Text = "年结统计";
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 5;
			this.menuItem9.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.mnuChart});
			this.menuItem9.Text = "历史曲线";
			// 
			// mnuChart
			// 
			this.mnuChart.Index = 0;
			this.mnuChart.Text = "历史曲线";
			this.mnuChart.Click += new System.EventHandler(this.menuItem10_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 6;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.mnu_back,
																					  this.mnu_restore,
																					  this.menuItem10});
			this.menuItem2.Text = "数据库管理";
			// 
			// mnu_back
			// 
			this.mnu_back.Index = 0;
			this.mnu_back.Text = "备份数据库";
			this.mnu_back.Click += new System.EventHandler(this.mnu_back_Click);
			// 
			// mnu_restore
			// 
			this.mnu_restore.Index = 1;
			this.mnu_restore.Text = "还原数据库";
			this.mnu_restore.Click += new System.EventHandler(this.mnu_restore_Click);
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 2;
			this.menuItem10.Text = "自动备份数据库";
			this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click_1);
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 7;
			this.menuItem14.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem15,
																					   this.menuItem16});
			this.menuItem14.Text = "系统报警";
			this.menuItem14.Visible = false;
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 0;
			this.menuItem15.Text = "报警明细";
			this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
			// 
			// menuItem16
			// 
			this.menuItem16.Index = 1;
			this.menuItem16.Text = "欠费名单";
			this.menuItem16.Click += new System.EventHandler(this.menuItem16_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 8;
			this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.mnuAbort,
																					  this.menuItem7,
																					  this.menuItem8});
			this.menuItem6.Text = "帮助";
			// 
			// mnuAbort
			// 
			this.mnuAbort.Index = 0;
			this.mnuAbort.Text = "关于";
			this.mnuAbort.Click += new System.EventHandler(this.mnuAbort_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 1;
			this.menuItem7.Text = "系统帮助";
			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 2;
			this.menuItem8.Text = "退出";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(312, 168);
			this.button1.Name = "button1";
			this.button1.TabIndex = 4;
			this.button1.Text = "button1";
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// errorProvider2
			// 
			this.errorProvider2.ContainerControl = this;
			// 
			// linkLabel2
			// 
			this.linkLabel2.Location = new System.Drawing.Point(992, 16);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(56, 16);
			this.linkLabel2.TabIndex = 10;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "通讯异常";
			this.linkLabel2.Visible = false;
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked_1);
			// 
			// linkLabel1
			// 
			this.linkLabel1.Location = new System.Drawing.Point(976, 8);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(56, 16);
			this.linkLabel1.TabIndex = 9;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "系统报警";
			this.linkLabel1.Visible = false;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
			// 
			// toolBarButton11
			// 
			this.toolBarButton11.ImageIndex = 36;
			this.toolBarButton11.Text = "人工录入";
			// 
			// frmWaterSys
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1028, 545);
			this.Controls.Add(this.linkLabel2);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.toolBar1);
			this.IsMdiContainer = true;
			this.Menu = this.mainMenu1;
			this.Name = "frmWaterSys";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.frmWaterSys_Closing);
			this.Load += new System.EventHandler(this.frmWaterSys_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmWaterSys_Paint);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmWaterSys_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			//string strSql="delete from tbCmd insert into tbCmd values('close')";
		//	BengZhan.CDBConnection.ExecuteSql(strSql);
			BengZhan.tools.DBConnection.m_App.Close();		
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{

			Users.frmUsers frmUsersObj=new BengZhan.Users.frmUsers();
			frmUsersObj.ShowDialog();

		}

		//插入菜单用于权限管理
		private void button1_Click(object sender, System.EventArgs e)
		{
			string strSql="delete from menuInfo";
			CDBConnection.ExecuteSql(strSql);
			CInsertMenu cInsertM=new CInsertMenu();
			cInsertM.InsertMenuText(this.mainMenu1);
			MessageBox.Show("finish");
		
		}

		private void mnu_userMana_Click(object sender, System.EventArgs e)
		{
			Users.FrmMenuMana frmMeMaObj=new BengZhan.Users.FrmMenuMana();
			frmMeMaObj.ShowDialog();

		}

		private void mnu_exit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void mnu_changePwd_Click(object sender, System.EventArgs e)
		{
			FrmChangePwd frmChangePwdObj=new FrmChangePwd();
			frmChangePwdObj.ShowDialog();

		}

		private void mnu_reLoad_click(object sender, System.EventArgs e)
		{
			BengZhan.tools.DBConnection.m_App.m_frm=this;
			BengZhan.tools.DBConnection.m_App.Show();
		}

		private void disToolBar()
		{
			try
			{
				for(int i=0;i<this.toolBar1.Buttons.Count;i++)
				{
					if(this.toolBar1.Buttons[i].Enabled==false)
					{
						this.toolBar1.Buttons[i].Visible=false;
					}
				}
					  }
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
	}

		private void frmWaterSys_Load(object sender, System.EventArgs e)
		{
			try
			{
				string strSql=string.Format("select softName,userName,version,image from tbAdInfo where userid='{0}'",BengZhan.CDBConnection.m_strUserID);
				DataTable dtAdInfo=new DataTable();

				BengZhan.CDBConnection.getDataTable(ref dtAdInfo,strSql,"dt");

				XmlDocument xDocInfo=new XmlDocument();
				xDocInfo.Load(@"ini/sysIni.xml");

				xDocInfo.DocumentElement.SelectSingleNode("./abort/softName").Attributes.GetNamedItem("val").Value=dtAdInfo.Rows[0]["softName"].ToString().Trim();
				xDocInfo.DocumentElement.SelectSingleNode("./abort/version").Attributes.GetNamedItem("val").Value=dtAdInfo.Rows[0]["version"].ToString().Trim();
				xDocInfo.DocumentElement.SelectSingleNode("./abort/user").Attributes.GetNamedItem("val").Value=dtAdInfo.Rows[0]["userName"].ToString().Trim();

				xDocInfo.Save(@"ini/sysIni.xml");

				System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmWaterSys));				

//				if(dtAdInfo.Rows[0]["image"].ToString().Trim()=="frm1")
//				{
//
//					BengZhan.frm1 frm=new frm1();
//					System.Drawing.Image im=frm.BackgroundImage;
//					this.BackgroundImage=im;
//					
//				}
//
//				if(dtAdInfo.Rows[0]["image"].ToString().Trim()=="frmWaterSys1")
//				{
//					BengZhan.frm2 frm=new frm2();
//					System.Drawing.Image im=frm.BackgroundImage;
//					this.BackgroundImage=im;
//				}
//
//				if(dtAdInfo.Rows[0]["image"].ToString().Trim()=="th")				
//				{
//					this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
//				}			


				//System.Drawing.Image im=frm.BackgroundImage;




				//	string strSql=string.Format("delete from tbcmd insert into tbCmd values('start')");
				//	BengZhan.CDBConnection.ExecuteSql(strSql);
				//				this.pictureBox1.Location=new Point((this.toolBar1.Location.Y+this.toolBar1.Height),this.toolBar1.Location.X);
				//				this.pictureBox1.Height=this.Height-this.pictureBox1.Location.Y;
				//				this.pictureBox1.Width=this.Width;
				//this.pictureBox1.Image=((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));

				//this.errorProvider2.SetError(this.toolBar1.b,"warn");

				//初始一个视图
				iniWellAmount();

				CInsertMenu cInsertM=new CInsertMenu();
				cInsertM.EnableMenu(this.mainMenu1);
				cInsertM.enableToolbar(this.toolBar1,this.mainMenu1);
				//this.enableToolBar();
				this.iniFrm();			

				//*******************************系统初始化**********************************************				
				//New.laidianDisplay.GDBConnection GDBC=new New.laidianDisplay.GDBConnection();
				//GDBC.initialCDB();

				BengZhan.CDBConnection cdb=new CDBConnection();
				cdb.initialCon();				
				//初始化remoting系统表
				GprsSoft.serverMonitor.CServer csObj=new GprsSoft.serverMonitor.CServer();
				csObj.InitialCServer();
				CDBConnection.refreshHis();
				//***************************************************************************************

				if(BengZhan.CDBConnection.m_bClient==true)
				{
					this.Text=this.Text+"[客户端]";
				}
				if(BengZhan.CDBConnection.m_bServer==true)
				{
					this.Text=this.Text+"[服务器]";
				}

				if(m_softName!=null)
				{
					if(m_softName.Trim()!="")
					{
						
						this.Text=m_softName;
						//this.Text=m_softName+string.Format("    [当前用户：{0}]",CDBConnection.m_strUserName);
					}				
				}

				//this.BackgroundImage=null;
				//自动备份数据库

				//this.startFrm();
				
				autoBackup();

				this.startTimer();

				this.regCom();

				this.disToolBar();

				this.BackColor=Color.White;
				this.Text=this.Text+"[新版]";

				this.Text="灌区管理系统";

				XmlDocument xDoc=new XmlDocument();

				xDoc.Load("Server.xml");

				string strTitle=xDoc.DocumentElement.SelectSingleNode("./abort/softName").Attributes.GetNamedItem("val").Value.Trim();

				this.Text=strTitle;
             
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void regCom()
		{
			try
			{

				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("Server.xml");

				string strKey=xDoc.DocumentElement.SelectSingleNode("./regCom").Attributes.GetNamedItem("key").Value.Trim();
				string strVal=xDoc.DocumentElement.SelectSingleNode("./regCom").Attributes.GetNamedItem("val").Value.Trim();

				RegistryKey rk=Microsoft.Win32.Registry.ClassesRoot;
				RegistryKey sk1=rk.CreateSubKey(string.Format("{0}","Licenses"));
				RegistryKey sk2=sk1.CreateSubKey(strKey);
				//sk2=sk1.OpenSubKey(strKey);
				if(sk2==null){
					Console.WriteLine("false");
				}

				//Console.WriteLine(sk2.GetValue("").ToString());

				if(sk2.GetValue("")==null)
				{
					sk2.SetValue("",strVal);
				}

				if(sk2.GetValue("").ToString()==strVal)
				{
					return;
				}
				else
				{
					sk2.SetValue("",strVal);
				}

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void startFrm()
		{
			try
			{
				decApp.CDecApp cda=new decApp.CDecApp();

				
					XmlDocument xDoc=new XmlDocument();
					xDoc.Load("Info.xml");

					if(xDoc.DocumentElement.SelectSingleNode("./dispB").Attributes.GetNamedItem("val").Value.Trim()=="true")
					{
						this.button1.Visible=true;
					}

					string strFileName=xDoc.DocumentElement.SelectSingleNode("./dbFile").Attributes.GetNamedItem("name").Value.Trim();

					if(!File.Exists(strFileName))
					{
						return;
					}

					if(xDoc.DocumentElement.SelectSingleNode("./bAutoRun").Attributes.GetNamedItem("val").Value.Trim()=="true")
					{
						mnuMon_Click(null,null);
					}	

//					string strPath=xDoc.DocumentElement.SelectSingleNode("./startSoft").Attributes.GetNamedItem("val").Value.Trim();
//
//					strFileName=strPath;
//					System.Diagnostics.Process proc = new System.Diagnostics.Process();
//					proc.EnableRaisingEvents=false;
//			
//					proc.StartInfo.FileName=strFileName;
			//	proc.StartInfo.WindowStyle=ProcessWindowStyle.Minimized;
					//proc.Start();
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		
		private void mnuCountry_Click(object sender, System.EventArgs e)
		{
			baseInfo.country.frmCountry frmCountryObj=new BengZhan.baseInfo.country.frmCountry();
			frmCountryObj.ShowDialog();
		}

		private void mnuHangYe_Click(object sender, System.EventArgs e)
		{			
			hangYe.frmHangYeType frmHangYeObj=new BengZhan.hangYe.frmHangYeType();
			frmHangYeObj.ShowDialog();
		}

		private void mnuDep_Click(object sender, System.EventArgs e)
		{
		
			deps.frmDep frmDepObj=new BengZhan.deps.frmDep();
			//frmDepObj.MdiParent=this;
			frmDepObj.ShowDialog();

		}

		private void mnuWell_Click(object sender, System.EventArgs e)
		{
				bengzhans.frmBengZhans frmBengZhanObj=new BengZhan.bengzhans.frmBengZhans();
				frmBengZhanObj.ShowDialog();

		}

		private void mnuMon_Click(object sender, System.EventArgs e)
		{
			
			this.showMonitor();
		}

		private void mnuFlowAmount_Click(object sender, System.EventArgs e)
		{
			this.miniFrms();
			if(this.showFrm("监测站流量统计"))
			{
				return;
			}
		
			CReportDll.comReport.newRep.frmReport frmRepO=new CReportDll.comReport.newRep.frmReport();
			frmRepO.MdiParent=this;
			frmRepO.WindowState=System.Windows.Forms.FormWindowState.Maximized;
			frmRepO.Show();

			m_arrFrms.Add(frmRepO);
			
		}

		private void showYearStac1()		
		{
			this.miniFrms();
			if(this.showFrm("年结统计表"))
			{
				return;
			}
			//cReport.CCrystalReport 

			New.cReport.frmMonthStac1  frmRepO=new New.cReport.frmMonthStac1();
			frmRepO.MdiParent=this;
			frmRepO.WindowState=System.Windows.Forms.FormWindowState.Maximized;
			frmRepO.Show();

			m_arrFrms.Add(frmRepO);
		}

		private void showYearStac()
		{
			
			this.miniFrms();
			if(this.showFrm("月结统计表"))
			{
				return;
			}

			//cReport.CCrystalReport 

			New.cReport.frmMonthStacYear  frmRepO=new New.cReport.frmMonthStacYear();
			frmRepO.MdiParent=this;
			frmRepO.WindowState=System.Windows.Forms.FormWindowState.Maximized;
			frmRepO.Show();

			m_arrFrms.Add(frmRepO);
		}

		private void mnuSalWaterRep_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.ActiveMdiChild!=null)
				{
					MessageBox.Show("请先关闭已打开窗体!");
					return;
					this.ActiveMdiChild.Close();
				}
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void showGis()
		{
			try
			{		
				
//				MapGis.frmGis frmG=new MapGis.frmGis();
//				frmG.ShowDialog();
//				
				myGisP.Form1 frm=new myGisP.Form1();
				//frm.MdiParent=this;
					frm.WindowState=System.Windows.Forms.FormWindowState.Maximized ;
				frm.ShowDialog();
			

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void showSalSta()
		{
			this.miniFrms();

			if(this.showFrm("总账统计表"))
			{
				return;
			}

			New.cReport.frmMonthStac frmSO=new New.cReport.frmMonthStac();
			frmSO.MdiParent=this;
			frmSO.WindowState=System.Windows.Forms.FormWindowState.Maximized;
			frmSO.Show();

			m_arrFrms.Add(frmSO);

		}

		private void showICSal()
		{
			return;
			this.miniFrms();

			if(this.showFrm("售水查看"))
			{
				return;
			}

			NFrmIC.frmSal frmSO=new NFrmIC.frmSal();
			frmSO.WindowState=System.Windows.Forms.FormWindowState.Maximized;
			frmSO.MdiParent=this;
			frmSO.Show();

m_arrFrms.Add(frmSO);

		}

		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			try
			{
				if(e.Button.Text.Trim()=="人工录入")
				{
					this.miniFrms();
					if(this.showFrm("人工录入"))
					{
						return;
					}
					bengzhans.frmDatasEdit frmedit=new BengZhan.bengzhans.frmDatasEdit();
					frmedit.Text="人工录入";
					frmedit.MdiParent=this;
					frmedit.WindowState=System.Windows.Forms.FormWindowState.Maximized;
					frmedit.Show();

					m_arrFrms.Add(frmedit);
					
				}
				if(e.Button.Text.Trim()=="参数管理")
				{
					New.cReport.frmParamSet frmPS=new New.cReport.frmParamSet();
					frmPS.ShowDialog();
					return ;
				}
				if(e.Button.Text.Trim()=="测站信息")
				{
					bengzhans.frmBengZhans frmBengZhanObj=new BengZhan.bengzhans.frmBengZhans();
					frmBengZhanObj.ShowDialog();
					return;
				}
				if(e.Button.Text.Trim()=="退出系统")
				{
					this.Close();
					return;
				}
				if(e.Button.Text.Trim()=="售水查看")
				{

					this.showICSal();
				}
				
				CInsertMenu cInsertM=new CInsertMenu();

				if(!cInsertM.enableToolbar(e.Button.Text.Trim(),this.mainMenu1))
				{
					MessageBox.Show("权限不足！");
					return;
				}

				if(e.Button.Text.Trim()=="监测站")
				{
					this.mnuWell_Click(null,null);
				}
				if(e.Button.Text.Trim()=="单位信息")
				{
					this.mnuDep_Click(null,null);
				}
				if(e.Button.Text.Trim()=="退出系统")
				{
					this.Close();
				}
				if(e.Button.Text.Trim()=="用户管理")
				{
					Users.frmUsers frmUsersObj=new BengZhan.Users.frmUsers();
					frmUsersObj.ShowDialog();
				}
				if(e.Button.Text.Trim()=="用户授权")
				{
					Users.FrmMenuMana frmMeMaObj=new BengZhan.Users.FrmMenuMana();
					frmMeMaObj.ShowDialog();
				}
				if(e.Button.Text.Trim()=="实时监测")
				{		
					this.miniFrms();						
					this.showMonitor();
				}			
				if(e.Button.Text.Trim()=="售水统计")
				{
					try
					{	
						New.cReport.frmSalRep frmSalR=new New.cReport.frmSalRep();
						frmSalR.ShowDialog();
					}
					catch(Exception ex)
					{
						MessageBox.Show(ex.ToString());
					}
				}
				if(e.Button.Text.Trim()=="历史曲线")
				{
					this.miniFrms();
					if(this.showFrm("流量图表"))
					{
						return;
					}
					CReportDll.comReport.newRep.frmChart frmC=new CReportDll.comReport.newRep.frmChart();
					frmC.MdiParent=this;
					frmC.WindowState=System.Windows.Forms.FormWindowState.Maximized;
					frmC.Show();	
					m_arrFrms.Add(frmC);
				}
				if(e.Button.Text.Trim()=="系统帮助")
				{
					Help.ShowHelp(this,"help.chm");
				}
				if(e.Button.Text.Trim()=="报警参数")
				{
						BengZhan.warn.frmWarnLevel  frmSWL=new BengZhan.warn.frmWarnLevel();
						frmSWL.ShowDialog();
				}
				if(e.Button.Text.Trim()=="报警明细")
				{
					
					frmWarn.Form1 frmWarnO=new frmWarn.Form1();
					frmWarnO.m_strFormType="";
					frmWarnO.ShowDialog();					
				}
				if(e.Button.Text=="实时查看")
				{
				
				}
				if(e.Button.Text=="正点定时")
				{
					if(this.ActiveMdiChild!=null)
					{
						MessageBox.Show("请先关闭已打开窗体!");
						return;
						this.ActiveMdiChild.Close();
					}
					BengZhan.warn.onTimeSet.frmOnTimeSet   frmT=new BengZhan.warn.onTimeSet.frmOnTimeSet();
					frmT.ShowDialog();
				}
				if(e.Button.Text.Trim()=="IC卡售水")
				{				
					showICSale();					
				}
				if(e.Button.Text.Trim()=="IC卡管理")
				{
					showICMana();
				}
				if(e.Button.Text.Trim()=="流量统计")
				{	
					this.miniFrms();
					if(this.showFrm("监测站流量统计"))
					{
						return;
					}
					CReportDll.comReport.newRep.frmReport frmRepO=new CReportDll.comReport.newRep.frmReport();
					frmRepO.MdiParent=this;
					frmRepO.WindowState=System.Windows.Forms.FormWindowState.Maximized;
					frmRepO.Show();
					m_arrFrms.Add(frmRepO);

				}
				if(e.Button.Text.Trim()=="欠费名单")
				{					
					CWarnDll.frmWarn.Form2 frmWarnTb=new CWarnDll.frmWarn.Form2();
					frmWarnTb.ShowDialog();			
				}
				if(e.Button.Text.Trim()=="地理信息")
				{
					this.showGis();
				}
				if(e.Button.Text.Trim()=="总帐统计")
				{
					showSalSta();
				}
				if(e.Button.Text.Trim()=="月结统计")
				{
					this.showYearStac();
				}
				if(e.Button.Text.Trim()=="年结统计")
				{

				}
				if(e.Button.Text.Trim()=="TM卡售水")
				{
					string strFileName=string.Format(@"test/test.exe",BengZhan.CDBConnection.m_strUserID);
					System.Diagnostics.Process proc = new System.Diagnostics.Process();
					proc.EnableRaisingEvents=false;
			
					proc.StartInfo.FileName=strFileName;
					proc.StartInfo.Arguments=BengZhan.CDBConnection.m_strUserID;
				//	proc.StartInfo.WindowStyle=ProcessWindowStyle.Minimized;
					proc.Start();
					System.IO.Directory.SetCurrentDirectory(Application.StartupPath);
				}
				if(e.Button.Text.Trim()=="年结统计")
				{
					this.showYearStac1();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
		}



		private void showAmountReport()
		{

		}
		private void showICMana()
			   {
			XmlDocument xDoc=new XmlDocument();
			xDoc.Load("Info.xml");

			string strFileName=xDoc.DocumentElement.SelectSingleNode("./dbFile").Attributes.GetNamedItem("name").Value.Trim();

			if(!File.Exists(strFileName))
			{
				MessageBox.Show("客户端程序不能执行IC卡管理操作！");
				return;
			}

			 xDoc=new XmlDocument();
			xDoc.Load("icSys/icSys.xml");

			xDoc.DocumentElement.SelectSingleNode("./sysForm").Attributes.GetNamedItem("val").Value="manaIC";
			xDoc.Save("icSys/icSys.xml");

			NFrmIC.frmIC frmICObj=new NFrmIC.frmIC();
			frmICObj.m_strSalerName=BengZhan.CDBConnection.m_strUserName;
			frmICObj.ShowDialog();
			   }
		private void showICSale()
		{
			try
			{	
				if(ComSoft.frmMonitorEx.m_dtFarCmd==null)
				{
					MessageBox.Show("请先打开实时监测界面!");
					return;
				}

				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("icSys/icSys.xml");

				xDoc.DocumentElement.SelectSingleNode("./sysForm").Attributes.GetNamedItem("val").Value="saleIC";
				xDoc.Save("icSys/icSys.xml");

				NFrmIC.frmIC frmICO=new NFrmIC.frmIC();
				frmICO.m_strSalerName=BengZhan.CDBConnection.m_strUserName;
				frmICO.Show();				

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());

			}
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void mnuFarMana_Click(object sender, System.EventArgs e)
		{
			this.showMonitor();
		}

		public static ArrayList m_arrFrms=new ArrayList();

		//显示监控窗体
		private void showMonitor()
		{
			XmlDocument xDoc=new XmlDocument();
			xDoc.Load("Info.xml");

			string strFileName=xDoc.DocumentElement.SelectSingleNode("./dbFile").Attributes.GetNamedItem("name").Value.Trim();

			if(!File.Exists(strFileName))
			{
				MessageBox.Show("客户端软件不能执行远程监测操作！");
				return;
			}

			if(this.showFrm("实时监测"))
			{
				return;
			} 

//			ComSoft.frmMonitorEx frmMoniObj=new ComSoft.frmMonitorEx();
//			frmMoniObj.m_sCon=CDBConnection.m_sCon;
//			frmMoniObj.MdiParent=this;
//			frmMoniObj.WindowState=System.Windows.Forms.FormWindowState.Maximized;				
//			frmMoniObj.Show();

			winCom.frmReport frmMoniObj=new winCom.frmReport();
			frmMoniObj.MdiParent=this;
			frmMoniObj.WindowState=System.Windows.Forms.FormWindowState.Maximized;
			frmMoniObj.Show();
			m_arrFrms.Add(frmMoniObj);

		}

		private void mnuSalWater_Click(object sender, System.EventArgs e)
		{
			this.showMonitor();
		}

		private void mnuSetInterval_Click(object sender, System.EventArgs e)
		{
			database.frmSysSet frmSysObj=new BengZhan.database.frmSysSet();
			frmSysObj.ShowDialog();
		}

		private void mnu_back_Click(object sender, System.EventArgs e)
		{
			database.frmBackRestoreDB fidb=new BengZhan.database.frmBackRestoreDB();
			fidb.m_bBack=true;
			fidb.ShowDialog();
		}

		private void mnu_restore_Click(object sender, System.EventArgs e)
		{
			database.frmBackRestoreDB fidb=new BengZhan.database.frmBackRestoreDB();
			fidb.m_bRestore=true;
			fidb.ShowDialog();
		}

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			this.miniFrms();
			if(this.showFrm("流量图表"))
			{
				return;
			}
			CReportDll.comReport.newRep.frmChart frmC=new CReportDll.comReport.newRep.frmChart();
			frmC.MdiParent=this;
			frmC.WindowState=System.Windows.Forms.FormWindowState.Maximized;
			frmC.Show();	
			m_arrFrms.Add(frmC);
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			Help.ShowHelp(this,"help.chm");		
		}

		private void mnuReset_Click(object sender, System.EventArgs e)
		{
			if(this.ActiveMdiChild!=null)
			{
				MessageBox.Show("请先关闭已打开窗体!");
				return;
				this.ActiveMdiChild.Close();
			}

			Form1 frm1=new Form1();
			frm1.ShowDialog();

			CInsertMenu cInsertM=new CInsertMenu();
			cInsertM.EnableMenu(this.mainMenu1);
			//cInsertM.enableToolbar(this.toolBar1,this.mainMenu1);

			//this.enableToolBar();
		}

		private void enableToolBar()
		{
			for(int i=0;i<this.mainMenu1.MenuItems.Count;i++)
			{
				this.mainMenu1.MenuItems[i].Enabled=true;
			}
			this.mnu_exit.Enabled=true;		
		
			for(int i=0;i<this.toolBar1.Buttons.Count;i++)
			{
				this.toolBar1.Buttons[i].Enabled=true;
			}

			 if(this.mnu_users.Enabled==false)
			{
				this.toolBar1.Buttons[0].Enabled=false;
			}
			if(this.mnu_userMana.Enabled==false)
			{
				this.toolBar1.Buttons[1].Enabled=false;
			}
			if(this.mnuMon.Enabled==false)
			{
				this.toolBar1.Buttons[2].Enabled=false;
			}
			if(this.mnuFlowAmount.Enabled==false)
			{
				this.toolBar1.Buttons[3].Enabled=false;
			}
//			if(this.mnuSalWaterRep.Enabled==false)
//			{
//				this.toolBar1.Buttons[4].Enabled=false;
//			}
			if(this.mnuChart.Enabled==false)
			{
				this.toolBar1.Buttons[5].Enabled=false;
			}
			if(this.mnuDep.Enabled==false)
			{
				this.toolBar1.Buttons[3].Enabled=false;
			}
			if(this.mnuWell.Enabled==false)
			{
				this.toolBar1.Buttons[4].Enabled=false;
			}

		}
		//初始界面
		private void iniFrm()
		{
			try
			{
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("sysForm.xml");
				string strDisCountry=xDoc.DocumentElement.SelectSingleNode("./dispCountry").Attributes.GetNamedItem("val").Value.ToString().Trim();
				if(strDisCountry!="1")
				{
					this.mnuCountry.Visible=false;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		//初始化wellAmount表
		private void iniWellAmount()
		{
			try
			{
				string strSql=String.Format("select count(*) from sysobjects where name='tbWellAmount' and xtype='V'");
				string strCount=CDBConnection.ExecuteScalar(strSql);
				if(strCount=="")
				{
					createTable();
					}
				else
				{
					if(int.Parse(strCount)<1)
					{
						this.createTable();
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		private void createTable()
		{	
			try
			{
				string strSql=String.Format("create view tbWellAmount as select * from waterDatas");
				CDBConnection.ExecuteSql(strSql);

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
				
			
		}
		private void autoBackup()
		{
			try
			{
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("Server.xml");
				string strCon=xDoc.DocumentElement.SelectSingleNode("./strCon").InnerText.Trim();
				SqlConnection sConEx=new   SqlConnection(strCon);
				sConEx.Open();

				BengZhan.AutoBackup.CAutoBackup cab=new BengZhan.AutoBackup.CAutoBackup();
				BengZhan.AutoBackup.CAutoBackup.m_sCon=sConEx;			
				this.Cursor=Cursors.WaitCursor;
				cab.autoBackup();	
				this.Cursor=Cursors.Default;
			}
			catch(Exception ex)
			{
				this.Cursor=Cursors.Default;
				MessageBox.Show(ex.ToString());
			}
				
		}

		private void menuItem10_Click_1(object sender, System.EventArgs e)
		{
			try
			{
				BengZhan.AutoBackup.Form1 frm=new BengZhan.AutoBackup.Form1();
				frm.ShowDialog();
			}
			catch(Exception ex)
			{
				this.Cursor=Cursors.Default;
				MessageBox.Show(ex.ToString());
			}
		
		}

		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			BengZhan.warn.frmWarnLevel  frmSWL=new BengZhan.warn.frmWarnLevel();
			frmSWL.ShowDialog();
		}

		private void menuItem12_Click(object sender, System.EventArgs e)
		{
			if(this.ActiveMdiChild!=null)
			{
				MessageBox.Show("请先关闭已打开窗体!");
				return;
				this.ActiveMdiChild.Close();
			}
			frmWarn.Form1 frmWarnO=new frmWarn.Form1();
			frmWarnO.m_strFormType="";
			frmWarnO.ShowDialog();	
		}

		private void mnuAbort_Click(object sender, System.EventArgs e)
		{
			BengZhan.abort.frmAbort frmA=new BengZhan.abort.frmAbort();
			frmA.ShowDialog();
		}

		private void mnuClient_Click(object sender, System.EventArgs e)
		{
			if(this.ActiveMdiChild!=null)
			{
				MessageBox.Show("请先关闭已打开窗体!");
				return;
				this.ActiveMdiChild.Close();
			}
		
		}

		private void mnuDbUp_Click(object sender, System.EventArgs e)
		{
						XmlDocument xDoc=new XmlDocument();
			xDoc.Load("Info.xml");

			string strBUp=xDoc.DocumentElement.SelectSingleNode("./bUp").Attributes.GetNamedItem("val").Value.ToString().Trim();
			
			if(strBUp=="false")
			{
				MessageBox.Show("该数据库版本已经是最新，不需要升级！");
				return;
			}

						
						CAutoBackup cab=new CAutoBackup();
						cab.iniCon();
						if(cab.executeSqlFile("delTable.sql")==true)
						{
							MessageBox.Show("升级完成！");
						}
			xDoc.DocumentElement.SelectSingleNode("./bUp").Attributes.GetNamedItem("val").Value="true";
			xDoc.Save("info.xml");
		}

		private void mnuOnTime_Click(object sender, System.EventArgs e)
		{
			if(this.ActiveMdiChild!=null)
			{
				MessageBox.Show("请先关闭已打开窗体!");
				return;
				this.ActiveMdiChild.Close();
			}
			BengZhan.warn.onTimeSet.frmOnTimeSet   frmT=new BengZhan.warn.onTimeSet.frmOnTimeSet();
			frmT.ShowDialog();
		}

		private void menuItem13_Click(object sender, System.EventArgs e)
		{
			try
			{	
				New.cReport.frmSalRep frmSalR=new New.cReport.frmSalRep();
				frmSalR.ShowDialog();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		bool bPaint=false;
		private BengZhan.sysWarn.CSysWarn m_cSysW;

		private void frmWaterSys_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
//			if(!bPaint)
//			{
//				BengZhan.sysWarn.CSysWarn cSysW=new BengZhan.sysWarn.CSysWarn();
//				cSysW.OnWarn+=new BengZhan.sysWarn.CSysWarn.warnData(cSysW_OnWarn);
//				cSysW.iniWarn();
//				this.m_cSysW=cSysW;
//				bPaint=true;
//			}
		}

		private string m_strSysWarnT="";
		private string m_strComWarnT="";

		private void cSysW_OnWarn()
		{
			try
			{
				DataTable dtWarn=this.m_cSysW.getWarnTime();
				if(dtWarn!=null)				
				{
					for(int i=0;i<dtWarn.Rows.Count;i++)
					{
						bool bDeal=false;
						if(dtWarn.Rows[i]["sysWarnT"]!=null)
						{
							if(dtWarn.Rows[i]["sysWarnT"].ToString().Trim()!="")
							{
								if(this.m_strSysWarnT.Trim()=="")
								{
									this.m_strSysWarnT=dtWarn.Rows[i]["sysWarnT"].ToString().Trim();
								}
								this.linkLabel1.Visible=true;
								this.errorProvider1.SetError(this.linkLabel1,this.linkLabel1.Text);	
								dtWarn.Rows.RemoveAt(i);
								i--;	
								bDeal=true;
							}
						}
						if(!bDeal)
						{
							if(dtWarn.Rows[i]["comWarnT"]!=null)							
							{
								if(dtWarn.Rows[i]["comWarnT"].ToString().Trim()!="")
								{
									if(this.m_strComWarnT.Trim()=="")
									{
										this.m_strComWarnT=dtWarn.Rows[i]["comWarnT"].ToString();
									}
									this.linkLabel2.Visible=true;
									this.errorProvider2.SetError(this.linkLabel2,this.linkLabel2.Text);
									dtWarn.Rows.RemoveAt(i);
									i--;
								}
							}
						}
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			ComP.dingFengReLi.warn.shangRun.frmWarnDetail frmWarnD=new ComP.dingFengReLi.warn.shangRun.frmWarnDetail();
			frmWarnD.m_strWarnType="sysWarn";
			frmWarnD.ShowDialog();
			this.linkLabel1.Visible=false;
			this.errorProvider1.SetError(this.linkLabel1,"");
			this.m_strSysWarnT="";
		}

		private void linkLabel2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			ComP.dingFengReLi.warn.shangRun.frmWarnDetail frmWarnD=new ComP.dingFengReLi.warn.shangRun.frmWarnDetail();
			frmWarnD.m_strWarnType="longTimeWarn";
			frmWarnD.m_strFormType="ComErr";
			frmWarnD.ShowDialog();
			this.linkLabel2.Visible=false;
			this.errorProvider2.SetError(this.linkLabel2,"");
			this.m_strComWarnT="";
		}

		private void linkLabel1_LinkClicked_1(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this.linkLabel1_LinkClicked(null,null);
		}

		private void linkLabel2_LinkClicked_1(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this.linkLabel2_LinkClicked(null,null);
		}

		private void menuItem15_Click(object sender, System.EventArgs e)
		{
			if(this.ActiveMdiChild!=null)
			{
				MessageBox.Show("请先关闭已打开窗体!");
				return;
				this.ActiveMdiChild.Close();
			}
			frmWarn.Form1 frmWarnO=new frmWarn.Form1();
			frmWarnO.m_strFormType="";
			frmWarnO.ShowDialog();				
		}

		private void menuItem16_Click(object sender, System.EventArgs e)
		{
			if(this.ActiveMdiChild!=null)
			{
				MessageBox.Show("请先关闭已打开窗体!");
				return;
				this.ActiveMdiChild.Close();
			}
					
			CWarnDll.frmWarn.Form2 frmWarnTb=new CWarnDll.frmWarn.Form2();
			frmWarnTb.ShowDialog();
		}

		private void menuItem18_Click(object sender, System.EventArgs e)
		{
			New.cReport.frmSal frmSo=new New.cReport.frmSal();
			frmSo.ShowDialog();
			//showICSale();		
		}

		private void menuItem19_Click(object sender, System.EventArgs e)
		{
			showICMana();
		}

		private void menuItem20_Click(object sender, System.EventArgs e)
		{
			if(this.ActiveMdiChild!=null)
			{
				MessageBox.Show("请先关闭已打开窗体!");
				return;
				this.ActiveMdiChild.Close();
			}
			BengZhan.warn.onTimeSet.frmOnTimeSet   frmT=new BengZhan.warn.onTimeSet.frmOnTimeSet();
			frmT.ShowDialog();
		}

		#region"定时备份数据库"

		private System.Timers.Timer m_timerBac;
		private XmlDocument m_xDocTimer;
		private int iInstance;

		private void startTimer()		
		{
			try			
			{
				if(this.m_xDocTimer!=null)			
				{
					return;
				}
				this.m_xDocTimer=new XmlDocument();
				this.m_xDocTimer.Load(@"timers\timerSys.xml");

				this.m_timerBac=new System.Timers.Timer();
				this.m_timerBac.Interval=1000;
				this.iInstance=1000;
				this.m_timerBac.Elapsed+=new System.Timers.ElapsedEventHandler(m_timerBac_Elapsed);
				this.m_timerBac.Start();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}			
		}

		private void m_timerBac_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			try
			{
				this.m_timerBac.Stop();

				for(int i=0;i<this.m_xDocTimer.DocumentElement.ChildNodes.Count;i++)
				{

					string strLong=this.m_xDocTimer.DocumentElement.ChildNodes[i].Attributes.GetNamedItem("long").Value.Trim();
					string strInterval=this.m_xDocTimer.DocumentElement.ChildNodes[i].Attributes.GetNamedItem("interval").Value.Trim();
					uint iLong=uint.Parse(strLong)+(uint)this.iInstance;
					string strName=this.m_xDocTimer.DocumentElement.ChildNodes[i].Attributes.GetNamedItem("name").Value.Trim();

					if(iLong>=uint.Parse(strInterval))
					{
						this.execTime(strName);
						this.m_xDocTimer.DocumentElement.ChildNodes[i].Attributes.GetNamedItem("long").Value="0";
					}	
					else
					{
						this.m_xDocTimer.DocumentElement.ChildNodes[i].Attributes.GetNamedItem("long").Value=iLong.ToString();
					}

				}

			    this.m_timerBac.Start();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}	
		}

		private void execTime(string strName)
		{
			try
			{	
				string strErr="";
				string strFileName="";
				if(strName=="backUp")
				{
					BengZhan.AutoBackup.CAutoBackup cab=new CAutoBackup();
					cab.backUp(ref strErr,ref strFileName);
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		#endregion

		private void menuItem21_Click(object sender, System.EventArgs e)
		{
			if(this.ActiveMdiChild!=null)
			{
				MessageBox.Show("请先关闭已打开窗体!");
				return;
				this.ActiveMdiChild.Close();
			}
			BengZhan.hangYe.frmPrice frmP=new BengZhan.hangYe.frmPrice();
			frmP.ShowDialog();
		}

		private void mnuInfo_Click(object sender, System.EventArgs e)
		{
			this.showGis();
		}

		private void menuItem22_Click(object sender, System.EventArgs e)
		{	
			if(this.showFrm("单位流量统计表"))
			{
				 return;
			}
			CReportDll.comReport.newRep.frmRepDep frmRepO=new CReportDll.comReport.newRep.frmRepDep();
			frmRepO.MdiParent=this;
			frmRepO.WindowState=System.Windows.Forms.FormWindowState.Maximized;
			frmRepO.Show();
			m_arrFrms.Add(frmRepO);


		}

		private void menuItem23_Click(object sender, System.EventArgs e)
		{
			if(this.showFrm("单位购水统计表"))
			{
				return;
			}
			CReportDll.comReport.newRep.frmSalReportDep frmRepO=new CReportDll.comReport.newRep.frmSalReportDep();
			frmRepO.MdiParent=this;
			frmRepO.WindowState=System.Windows.Forms.FormWindowState.Maximized;
			frmRepO.Show();
			m_arrFrms.Add(frmRepO);

		}	
	
		private void miniFrms()
		{
			try
			{
				for(int i=0;i<m_arrFrms.Count;i++)
				{
					Form frm=(Form)m_arrFrms[i];
					frm.WindowState=System.Windows.Forms.FormWindowState.Minimized;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private bool showFrm(string strText)
		{
			try
			{
				for(int i=0;i<m_arrFrms.Count;i++)
				{
					Form frm=(Form)m_arrFrms[i];
					if(frm.Text.IndexOf(strText)>=0)
					{
						frm.WindowState=System.Windows.Forms.FormWindowState.Maximized;
						return true;
					}
				}
						 
				return false;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
		
		}

		private void menuItem24_Click(object sender, System.EventArgs e)
		{
			this.showSalSta();
		}

		private void menuItem17_Click(object sender, System.EventArgs e)
		{
		
		}

		private void menuItem25_Click(object sender, System.EventArgs e)
		{
			this.showICSal();
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			
		}

		private void pictureBox1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void menuItem26_Click(object sender, System.EventArgs e)
		{
			this.showYearStac();
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void menuItem29_Click(object sender, System.EventArgs e)
		{
			BengZhan.deps.frmSalZhans frmZ=new BengZhan.deps.frmSalZhans();
			frmZ.ShowDialog();
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
		
		}

		private void menuItem30_Click(object sender, System.EventArgs e)
		{
			this.miniFrms();
			if(this.showFrm("人工录入"))
			{
				return;
			}
			bengzhans.frmDatasEdit frmedit=new BengZhan.bengzhans.frmDatasEdit();
			frmedit.Text="人工录入";
			frmedit.MdiParent=this;
			frmedit.WindowState=System.Windows.Forms.FormWindowState.Maximized;
			frmedit.Show();

			m_arrFrms.Add(frmedit);
		}
	}

}

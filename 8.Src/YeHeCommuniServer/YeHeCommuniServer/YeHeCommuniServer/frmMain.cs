using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Xdgk.Communi;
using System.Threading;

namespace YeHeCommuniServer
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public YeHeCommuniServer.YeHeCommuniServerApp appp;

        /// <summary>
        /// 
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            
            CommuniSoft.UISynchronizationContext = WindowsFormsSynchronizationContext.Current;
            CommuniSoft.IsUseUISynchronizationContext = true;

            this.tvStation.ImageList = YeHeCommuniServerApp.Default.ResourceManager.ImageList;
            appp = YeHeCommuniServer.YeHeCommuniServerApp.Default;

            appp.MainForm = this;
            this.Text = strings.AppName;
            this.SetListenPortText();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            FillStationTreeView(appp.CommuniSoft.HardwareManager, this.tvStation);

            CommuniSoft soft = appp.CommuniSoft;
            // register events
            //
            new CommuniSoftEventsRegister(soft, appp.YeHeProcessor).Registe();
            appp.CommuniSoft.Start();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hardWareManager"></param>
        /// <param name="treeView"></param>
        private void FillStationTreeView(HardwareManager hardWareManager, TreeView treeView)
        {
            foreach (Station station in hardWareManager.Stations)
            {
                TreeNode stationTreeNode = AddStationToTreeView(treeView, station);
                foreach (Device device in station.Devices)
                {
                    AddDeviceToStationTreeNode(stationTreeNode, device);
                }
            }
            treeView.Sort();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stationTreeNode"></param>
        /// <param name="device"></param>
        private static void AddDeviceToStationTreeNode(TreeNode stationTreeNode, Device device)
        {
            string deviceType = device.DeviceType;
            TreeNode deviceTreeNode = stationTreeNode.Nodes.Add(deviceType);
            deviceTreeNode.ImageKey = "Device";
            deviceTreeNode.SelectedImageKey = "device";
            deviceTreeNode.Tag = device;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="treeView"></param>
        /// <param name="station"></param>
        /// <returns></returns>
        private static TreeNode AddStationToTreeView(TreeView treeView, Station station)
        {
            string stationName = station.Name;
            TreeNode stationTreeNode = treeView.Nodes.Add(stationName);
            stationTreeNode.ImageIndex = -1;
            stationTreeNode.Tag = station;
            station.Tag = stationTreeNode;
            return stationTreeNode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuAddinManager_Click(object sender, EventArgs e)
        {
            //frmAddinManager f = new frmAddinManager(YeHeCommuniServerApp.Default.IParseResultProcessorManager);
            frmAddinManager f = new frmAddinManager();
            f.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuStationEdit_Click(object sender, EventArgs e)
        {
            TreeNode selectedTN = this.tvStation.SelectedNode;
            if (selectedTN != null)
            {
                Station st = selectedTN.Tag as Station;
                if (st != null)
                {
                    StationCollection ss = YeHeCommuniServerApp.Default.CommuniSoft.HardwareManager.Stations;
                    frmStationItem f = new frmStationItem(ss, st);
                    DialogResult dr = f.ShowDialog(this);
                    if (dr == DialogResult.OK)
                    {
                        selectedTN.Text = st.Name;
                    }
                }
                else
                {
                    NUnit.UiKit.UserMessage.DisplayFailure(strings.PleaseSelectStation);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuStationAdd_Click(object sender, EventArgs e)
        {
                StationCollection ss = YeHeCommuniServerApp.Default.CommuniSoft.HardwareManager.Stations;
            frmStationItem f = new frmStationItem(ss);
            DialogResult dr = f.ShowDialog();
            if (dr == DialogResult.OK)
            {
                AddStationToTreeView(this.tvStation, f.Station);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuDeviceEdit_Click(object sender, EventArgs e)
        {
            Device device = GetSelectedDevice();
            if (device != null)
            {
                frmDeviceItem f = new frmDeviceItem(device);
                f.ShowDialog();
            }
            else
            {
                ShowNeedSelectDeviceMessage();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private static void ShowNeedSelectDeviceMessage()
        {
            NUnit.UiKit.UserMessage.DisplayFailure(strings.PleaseSelectDeviceType);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Station GetSelectedStation()
        {
            TreeNode selectedTN = this.tvStation.SelectedNode;
            if (selectedTN != null)
            {
                return selectedTN.Tag as Station;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Device GetSelectedDevice()
        {
            Device device = null;
            TreeNode selectedTN = this.tvStation.SelectedNode;
            if (selectedTN != null)
            {
                device = selectedTN.Tag as Device;
            }
            return device;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuDeviceAdd_Click(object sender, EventArgs e)
        {
            Station station = GetSelectedStation();
            if (station != null)
            {
                frmDeviceSelect fDeviceSelect = new frmDeviceSelect();
                DialogResult drds = fDeviceSelect.ShowDialog(this);
                if (drds == DialogResult.OK)
                {
                    string newDeviceType = fDeviceSelect.SelectedDeviceType;
                    frmDeviceItem f = new frmDeviceItem(station, newDeviceType);
                    DialogResult dr = f.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        // update treeview
                        //
                        AddDeviceToStationTreeNode(this.tvStation.SelectedNode, f.Device);
                    }
                }
            }
            else
            {
                NUnit.UiKit.UserMessage.DisplayFailure(strings.PleaseSelectStation );
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuTaskManage_Click(object sender, EventArgs e)
        {
            frmTaskManage f = new frmTaskManage();
            f.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuStationDelete_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.tvStation.SelectedNode;
            if (selectedNode == null)
            {
                NUnit.UiKit.UserMessage.DisplayFailure(strings.PleaseSelectStation);
                return;
            }

            // TODO: delete station msgbox?
            //

            Station selectedStation = selectedNode.Tag as Station;
            if (selectedStation == null)
            {
                NUnit.UiKit.UserMessage.DisplayFailure(strings.PleaseSelectStation);
                return;
            }
            string deleteMsg = string.Format(strings.DeleteStation, selectedStation.Name);
            DialogResult dr = NUnit.UiKit.UserMessage.Ask(deleteMsg);
            if (dr == DialogResult.No)
            {
                return;
            }

            // TODO:
            //
            // 1. stop station 's device task
            //
            YeHeCommuniServerApp.Default.CommuniSoft.TaskManager.RemoveTaskByDeviceCollection(selectedStation.Devices);

            // 2. remove station from hardwareManager
            //
            YeHeCommuniServerApp.Default.CommuniSoft.HardwareManager.Stations.Remove(selectedStation);

            // 3. remove station from db
            //
            YeHeCommuniServerApp.Default.CSDBI.DeleteStaion(selectedStation.ID);

            // 
            //
            selectedNode.Remove();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuDeviceDelete_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.tvStation.SelectedNode;
            if (selectedNode == null)
            {
                NUnit.UiKit.UserMessage.DisplayFailure(strings.NotSelectedDevice);
                return;
            }
            Device selectedDevice = selectedNode.Tag as Device;
            if (selectedDevice == null)
            {
                NUnit.UiKit.UserMessage.DisplayFailure(strings.NotSelectedDevice);
                return;
            }

            string deleteMsg = string.Format(strings.DeleteDevice, selectedDevice.DeviceDefine.Text);
            DialogResult dr = NUnit.UiKit.UserMessage.Ask(deleteMsg);
            if (dr == DialogResult.No)
            {
                return;
            }

            YeHeCommuniServerApp.Default.CommuniSoft.TaskManager.RemoveTaskByDevice(selectedDevice);
            YeHeCommuniServerApp.Default.CSDBI.DeleteDevice(selectedDevice.ID);
            selectedNode.Remove();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuAbout_Click(object sender, EventArgs e)
        {
            frmAbout f = new frmAbout();
            f.ShowDialog(this);
        }

        #region tvStation_AfterSelect
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvStation_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        #endregion //tvStation_AfterSelect

        #region tvStation_DoubleClick
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvStation_DoubleClick(object sender, EventArgs e)
        {
            Device device = GetSelectedDevice();
            if (device != null)
            {
                if (device is DitchDevice)
                {
                    ShowDitchDevice(device as DitchDevice);
                }
                else if( device is XD202Device )
                {
                    ShowXD202Device( device as XD202Device );
                }
                //else if (device is XD2300Device)
                //{
                //    ShowXD2300Device(device as XD2300Device);
                //}
                //YeHeCommuniServerApp.Default.CommuniSoft.IDeviceViewManager.Show(this.panel1, device);
                //UserControl uc = CommuniServerApp.Default.CommuniSoft.IDeviceViewManager.IDeviceViewCollection[0].UserControl;

                //this.panel1.Controls.Clear();
                //this.panel1.Controls.Add(uc);
                //Console.WriteLine(string.Format("panel.count: {0}",this.panel1.Controls.Count ));
            }
            else
            {
                //ShowNeedSelectDeviceMessage();
            }
        }
        #endregion //tvStation_DoubleClick

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="xD2300Device"></param>
        //private void ShowXD2300Device(XD2300Device xD2300Device)
        //{
        //    xD2300Device .DitchData 
        //}


        /// <summary>
        /// 
        /// </summary>
        /// <param name="xD202Device"></param>
        private void ShowXD202Device(XD202Device xD202Device)
        {
            UCXD202Device uc = GetUCXD202Device();
            OnlyVisible(uc);
            uc.XD202Device = xD202Device;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private UCXD202Device GetUCXD202Device()
        {
            return (UCXD202Device)this.GetUC (typeof(UCXD202Device));
        }


        /// <summary>
        /// 
        /// </summary>
        private void ShowDevice(Device device)
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ditchDevice"></param>
        private void ShowDitchDevice(DitchDevice ditchDevice)
        {
            UCDitchDevice uc = GetUDDitchDevice();
            OnlyVisible(uc);
            uc.DitchDevice = ditchDevice;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private UCDitchDevice GetUDDitchDevice()
        {
            return (UCDitchDevice)this.GetUC(typeof(UCDitchDevice));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private Control GetUC(Type type)
        {
            foreach (Control c in this.panel1.Controls)
            {
                if (c.GetType() == type)
                    return c;
            }

            Control nc = null;
            if (type == typeof(UCDitchDevice))
            {
                nc = new UCDitchDevice();
            }
            else if (type == typeof(UCXD202Device))
            {
                nc = new UCXD202Device();
            }
            else
            {
                string s = string.Format("", type);
                throw new NotImplementedException(s);
            }

            this.panel1.Controls.Add(nc);
            return nc;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        private void OnlyVisible(Control vc)
        {
            foreach (Control c in this.panel1.Controls)
            {
                if (c == vc)
                {
                    vc.Visible = true;
                }
                else
                {
                    c.Visible = false;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void SetListenPortText()
        {
            string s = string.Empty;
            foreach( SocketListener sl in appp.CommuniSoft.SocketListenerManager.SocketListeners)
            {
                if (s != string.Empty)
                    s += ", ";
                s += sl.LocalEndpoint.ToString();
            }
            this.ListenPortText = string.Format(strings.Listening, s);
        }
        /// <summary>
        /// 
        /// </summary>
        public string ListenPortText
        {
            get { return this.tssListenPort.Text; }
            set { this.tssListenPort.Text = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = NUnit.UiKit.UserMessage.Ask(strings.AreYouExit);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }

}

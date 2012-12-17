using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Xdgk.Communi.Interface;
using Xdgk.Communi;
//using Xdgk.Communi.Processor;

namespace YeHeCommuniServer
{
    public partial class frmAddinManager : Form
    {
        //private IParseResultProcessorManager _iParseResultProcessorManager;

        //public frmAddinManager(IParseResultProcessorManager iParseResultProcessorManager)
        public frmAddinManager ()
        {
            InitializeComponent();
            //_iParseResultProcessorManager = iParseResultProcessorManager;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAddinManager_Load(object sender, EventArgs e)
        {
            //FillProcessorListBox(this.lstProcessor);
            FillCRCListBox(this.lstCRC);
            FillBCListBox(this.lstBC);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listBox"></param>
        //private void FillProcessorListBox(ListBox listBox)
        //{
        //    listBox.Items.Clear();
        //    foreach (IParseResultProcessor p in _iParseResultProcessorManager.IParseResultProcessorCollection)
        //    {
        //        listBox.Items.Add(p.GetType().FullName);
        //    }
        //}

        private void FillBCListBox(ListBox listBox)
        {
            listBox.Items.Clear();
            BytesConverterManager bcm = YeHeCommuniServerApp.Default.CommuniSoft.BytesConverterManager;

            foreach (IBytesConverter ibc in bcm.BytesConverterCollection)
            {
                listBox.Items.Add(ibc.GetType().FullName);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listBox"></param>
        private void FillCRCListBox(ListBox listBox)
        {
            listBox.Items.Clear();
            CRCerManager crcm = YeHeCommuniServerApp.Default.CommuniSoft.CRCerManager;
            foreach (ICRCer icrc in crcm.CRCers)
            {
                listBox.Items.Add(icrc.GetType().FullName);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="p"></param>
        //private void DisplayProcessor(ListView listView, IParseResultProcessor p)
        //{
        //    string s = string.Empty;
        //    StringBuilder sb = new StringBuilder();

        //    listView.Items.Clear();

        //    AddListViewItem(listView, "名称", p.Name);
        //    AddListViewItem (listView, "目标设备", p.ForDevice);
        //    AddListViewItem (listView , "描述", p.Description);
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lv"></param>
        /// <param name="p"></param>
        /// <param name="v"></param>
        private void AddListViewItem(ListView lv, string p, string v)
        {
            ListViewItem lvi = lv.Items.Add(p);
            lvi.SubItems.Add(v);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstProcessor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //object selectedItem = this.lstProcessor.SelectedItem;
            //if (selectedItem != null)
            //{
            //    string pName = selectedItem.ToString();
            //    IParseResultProcessor p = _iParseResultProcessorManager.IParseResultProcessorCollection.GetByTypeFullName(pName);
            //    if (p != null)
            //    {
            //        DisplayProcessor(this.lvProcessor, p);
            //    }
            //}
        }

    }
}

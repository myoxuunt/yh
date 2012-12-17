using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using YongShuiGuanLiDBI;

namespace YongShuiGuanLiV2
{
    /// <summary>
    /// 
    /// </summary>
    public partial class pProject : System.Web.UI.Page
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            MasterPageHelper.SetTitle(this, Titles.Project);
            if (!IsPostBack)
            {
                BindTree();
                TreeNode defaultTreeNode = null;
                if (this.TreeView1.Nodes.Count > 0)
                {
                    defaultTreeNode = this.TreeView1.Nodes[0];
                    BindChannelOrStation(defaultTreeNode);
                }
                else
                {
                    this.UCChannel1.Visible = false;
                    this.UCStation1.Visible = false;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void BindTree()
        {
            TreeView1.Nodes.Clear();
            WaterUserClass wu = SessionManager.LoginSession.WaterUser;
            ChannelCollection channels = wu.ChannelCollection;
            foreach (ChannelClass c in channels)
            {
                //this.TreeView1 
                TreeNode n = CreateChannelTreeNode(c);
                CreateLowLevelChannel(n, c.LowLevelCollection);
                CreateStation(n, c.StationCollection);
                this.TreeView1.Nodes.Add(n);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="channelCollection"></param>
        private void CreateLowLevelChannel(TreeNode parent, ChannelCollection channelCollection)
        {
            foreach (ChannelClass c in channelCollection)
            {
                TreeNode n = CreateChannelTreeNode(c);
                CreateLowLevelChannel(n, c.LowLevelCollection);
                parent.ChildNodes.Add(n);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="stationCollection"></param>
        private void CreateStation(TreeNode parent, StationCollection stationCollection)
        {
            foreach (StationClass s in stationCollection)
            {
                TreeNode stationTN = CreateStationTreeNode(s);
                parent.ChildNodes.Add(stationTN);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private TreeNode CreateStationTreeNode(StationClass s)
        {
            string stationValue = "s" + s.StationID;
            TreeNode n = new TreeNode(s.StationName);
            n.Value = stationValue;
            return n;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private TreeNode CreateChannelTreeNode(ChannelClass c)
        {
            string channelvalue = "c" + c.ChannelID;
            TreeNode n = new TreeNode(c.ChannelName);
            n.Value = channelvalue;
            return n;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {
            TreeNode selected = this.TreeView1.SelectedNode;
            BindChannelOrStation(selected);
        }

        /// <summary>
        /// 
        /// </summary>
        private void BindChannelOrStation(TreeNode selected)
        {
            if (IsChannelTreeNode(selected))
            {
                int channelID = GetSelectedID(selected);
                ChannelClass c = ChannelFactory.CreateChannel(channelID);
                this.UCChannel1.Bind(c);

                this.UCChannel1.Visible = true;
                this.UCStation1.Visible = false;
            }
            else
            {
                int stationID = GetSelectedID(selected);
                StationClass s = StationFactory.CreateStationByStationID(stationID);
                this.UCStation1.Bind(s);

                this.UCChannel1.Visible = false;
                this.UCStation1.Visible = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private int GetSelectedID(TreeNode node)
        {
            // TODO:
            //
            string idstring = node.Value.Substring(1);
            return Convert.ToInt32(idstring);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private bool IsChannelTreeNode(TreeNode node)
        {
            // TODO:
            //
            //node.value
            string v = node.Value;
            if (v[0] == 'c')
                return true;
            else
                return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDeleteChannel_Click(object sender, EventArgs e)
        {
            TreeNode tn = this.TreeView1.SelectedNode;
            if (IsChannelTreeNode(tn))
            {
                int id = GetSelectedID(tn);
                ChannelDBI.DeleteChannel(id);
                BindTree();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAddChannel_Click(object sender, EventArgs e)
        {
            ChannelClass newChannel = new ChannelClass();
            newChannel.ChannelName = "new channel";
            this.UCChannel1.Bind(newChannel);
            //SessionManager.ChannelSession.
        }
    }
}

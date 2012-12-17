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
    using WaterUser = YongShuiGuanLiDBI.WaterUserClass;

    public partial class pWaterUser : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
                MasterPageHelper.SetTitle(this, Titles.WaterUser);
            if (!IsPostBack)
            {
                BindTree();
                TreeNode defaultTreeNode = null;
                if (this.TreeView1.Nodes.Count > 0)
                {
                    defaultTreeNode = this.TreeView1.Nodes[0];
                    BindWaterUserItem(defaultTreeNode);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void BindTree()
        {
            YongShuiGuanLiDBI.WaterUserClass u = SessionManager.LoginSession.WaterUser;
            BindTree(u);
        }

        /// <summary>
        /// 
        /// </summary>
        private void BindWaterUserItem(TreeNode node)
        {
            if (node != null)
            {
                int id = Convert.ToInt32(node.Value);
                if (id != 0)
                {
                    WaterUserClass selectedWU = WaterUserFactory.CreateWaterUserByID(id);
                    this.UCWaterUser1.Bind(selectedWU);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void SelectDefaultTreeNode()
        {
            this.TreeView1.Nodes[0].SelectAction = TreeNodeSelectAction.Select;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="u"></param>
        private void BindTree(YongShuiGuanLiDBI.WaterUserClass u)
        {
            TreeNode node = CreateNode(u);
            this.TreeView1.Nodes.Add(node);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="wu"></param>
        /// <returns></returns>
        private TreeNode CreateNode(YongShuiGuanLiDBI.WaterUserClass wu )
        {
            TreeNode node = new TreeNode(wu.Name, wu.WaterUserID.ToString());
            CreateLowLevelWaterUser(node, wu.LowLevelWaterUserCollection);
            return node;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parentNode"></param>
        /// <param name="wuc"></param>
        private void CreateLowLevelWaterUser(TreeNode parentNode, WaterUserCollection wuc)
        {
            if (parentNode == null)
            {
                throw new ArgumentNullException("parentNode");
            }

            foreach (WaterUserClass u in wuc)
            {
                TreeNode node = new TreeNode(u.Name, u.WaterUserID.ToString());
                CreateLowLevelWaterUser(node, u.LowLevelWaterUserCollection);

                parentNode.ChildNodes.Add(node);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {
            TreeNode tn = this.TreeView1.SelectedNode;
            BindWaterUserItem(tn);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void TreeView1_Load(object sender, EventArgs e)
        {
        }
    }
}

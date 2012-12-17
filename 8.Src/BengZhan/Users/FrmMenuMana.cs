using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace BengZhan.Users
{
	/// <summary>
	/// FrmMenuMana 的摘要说明。
	/// </summary>
	public class FrmMenuMana : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TreeView tvwMenuInfo;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ListView lswUserInfo;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmMenuMana()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmMenuMana));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tvwMenuInfo = new System.Windows.Forms.TreeView();
			this.lswUserInfo = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnExit);
			this.groupBox1.Controls.Add(this.btnSave);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(224, 48);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(120, 16);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "放弃";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(24, 16);
			this.btnSave.Name = "btnSave";
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "保存";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tvwMenuInfo);
			this.groupBox2.Controls.Add(this.lswUserInfo);
			this.groupBox2.Location = new System.Drawing.Point(8, 56);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(568, 440);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			// 
			// tvwMenuInfo
			// 
			this.tvwMenuInfo.CheckBoxes = true;
			this.tvwMenuInfo.ImageIndex = -1;
			this.tvwMenuInfo.Location = new System.Drawing.Point(232, 16);
			this.tvwMenuInfo.Name = "tvwMenuInfo";
			this.tvwMenuInfo.SelectedImageIndex = -1;
			this.tvwMenuInfo.Size = new System.Drawing.Size(328, 416);
			this.tvwMenuInfo.TabIndex = 3;
			this.tvwMenuInfo.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvwMenuInfo_AfterCheck);
			// 
			// lswUserInfo
			// 
			this.lswUserInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						  this.columnHeader1,
																						  this.columnHeader2});
			this.lswUserInfo.FullRowSelect = true;
			this.lswUserInfo.GridLines = true;
			this.lswUserInfo.Location = new System.Drawing.Point(8, 16);
			this.lswUserInfo.MultiSelect = false;
			this.lswUserInfo.Name = "lswUserInfo";
			this.lswUserInfo.Size = new System.Drawing.Size(216, 416);
			this.lswUserInfo.TabIndex = 2;
			this.lswUserInfo.View = System.Windows.Forms.View.Details;
			this.lswUserInfo.Click += new System.EventHandler(this.lswUserInfo_Click);
			this.lswUserInfo.SelectedIndexChanged += new System.EventHandler(this.lswUserInfo_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "用户号";
			this.columnHeader1.Width = 101;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "用户名称";
			this.columnHeader2.Width = 101;
			// 
			// FrmMenuMana
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(584, 502);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmMenuMana";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "权限管理";
			this.Load += new System.EventHandler(this.FrmMenuMana_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void FrmMenuMana_Load(object sender, System.EventArgs e)
		{
			try
			{
				this.lswUserInfo.Items.Clear();				
				string strSql="select userID,userName from tbUsers";
				DataTable dtUsers=new DataTable();
				CDBConnection.getDataTable(ref dtUsers ,strSql,"userInfo");		
		
				for(int i=0;i<dtUsers.Rows.Count;i++)
				{
					string strUserID=dtUsers.Rows[i]["userID"].ToString().Trim();
					string strUserName=dtUsers.Rows[i]["userName"].ToString().Trim();					
					
					this.lswUserInfo.Items.Add(strUserID);
					this.lswUserInfo.Items[i].SubItems.Add(strUserName);

				}					  
				
				strSql="select menuName,menuParent from MenuInfo where len(ltrim(rtrim(menuParent)))=0";
				DataTable dtMenu=new DataTable();
				CDBConnection.getDataTable(ref dtMenu,strSql,"MenuInfo");

				for(int i=0;i<dtMenu.Rows.Count;i++)
				{
					string strMenuName=dtMenu.Rows[i]["menuName"].ToString();
					this.tvwMenuInfo.Nodes.Add(strMenuName);
				}
				
				for(int i=0;i<this.tvwMenuInfo.Nodes.Count;i++)
				{
					string strParent=this.tvwMenuInfo.Nodes[i].Text.Trim();
					strSql=String.Format("select menuName from MenuInfo where rtrim(ltrim(menuParent))='{0}'",strParent);
					
					CDBConnection.getDataTable(ref dtMenu,strSql,"MenuInfo");

					for(int j=0;j<dtMenu.Rows.Count;j++)
					{
						string strChild=dtMenu.Rows[j]["menuName"].ToString();
						this.tvwMenuInfo.Nodes[i].Nodes.Add(strChild);
					}					
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		

		private void tvwMenuInfo_AfterCheck(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			// The code only executes if the user caused the checked state to change.
			if(e.Action != TreeViewAction.Unknown)
			{
				if(e.Node.Nodes.Count > 0)
				{
					/* Calls the CheckAllChildNodes method, passing in the current 
					Checked value of the TreeNode whose checked state changed. */
					this.CheckAllChildNodes(e.Node, e.Node.Checked);
				}
			}

		}
		private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
		{
			foreach(TreeNode node in treeNode.Nodes)
			{
				node.Checked = nodeChecked;
				if(node.Nodes.Count > 0)
				{
					// If the current node has child nodes, call the CheckAllChildsNodes method recursively.
					this.CheckAllChildNodes(node, nodeChecked);
				}
			}
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.lswUserInfo.SelectedItems.Count==0)
				{
					MessageBox.Show("请选中一名用户！");
					return;
				}

				string strUserID=this.lswUserInfo.SelectedItems[0].Text.Trim();
				string strSql=String.Format("delete from userMenu where UserID='{0}'",strUserID);
				CDBConnection.ExecuteSql(strSql);				

				for(int i=0;i<this.tvwMenuInfo.Nodes.Count;i++)
				{
					if(this.tvwMenuInfo.Nodes[i].Checked)
					{
						string strMenu=this.tvwMenuInfo.Nodes[i].Text.Trim();
						strSql=String.Format("insert into userMenu(userID,MenuName) values('{0}','{1}')",strUserID,strMenu);
						CDBConnection.ExecuteSql(strSql);
					}
					for(int j=0;j<this.tvwMenuInfo.Nodes[i].Nodes.Count;j++)
					{
						if(this.tvwMenuInfo.Nodes[i].Nodes[j].Checked)
						{
							string strMenuChild=this.tvwMenuInfo.Nodes[i].Nodes[j].Text.Trim();
							strSql=String.Format("insert into userMenu(userID,MenuName) values('{0}','{1}')",strUserID,strMenuChild);
							CDBConnection.ExecuteSql(strSql);
						}
					}
				}
				MessageBox.Show("权限设置成功！");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
			
		}

		private void lswUserInfo_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			
		}

		//判断该节点是否有效
		private bool checkSelectedItem()
		{
			string strUID=this.lswUserInfo.SelectedItems[0].Text.Trim();
			string strSql=String.Format("select parentManager from tbUsers where userID='{0}'",strUID);
			string strParentManager=CDBConnection.ExecuteScalar(strSql);

			if(strParentManager.Trim()!="")
			{
				string strInfo=String.Format("该操作员的权限与操作员{0}相同！",strParentManager.Trim());
				MessageBox.Show(strInfo);
				selectItem(strParentManager);
				return false;
			}
			else
			{
				return true;
			}			
		}
		private void selectItem(string strUserName)
		{
			for(int i=0;i<this.lswUserInfo.Items.Count;i++)
			{
				if(this.lswUserInfo.Items[i].SubItems[1].Text==strUserName)
				{
					this.lswUserInfo.Items[i].Selected=true;
					return;
				}
			}
		}

		private void lswUserInfo_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(lswUserInfo.SelectedItems.Count==0)
				{
					return;
				}

				if(checkSelectedItem()==false)
				{
					//判断是否同权限
					//return;
				}

				for(int z=0;z<this.tvwMenuInfo.Nodes.Count;z++)
				{
					this.tvwMenuInfo.Nodes[z].Checked=false;
					CheckAllChildNodes(this.tvwMenuInfo.Nodes[z],false);
				}

				string strUserID=this.lswUserInfo.SelectedItems[0].Text.Trim();
				string strSql=String.Format("select ltrim(rtrim(menuName)) as menuName from  userMenu where userID='{0}'",strUserID);							
				DataTable dtUserMenu=new DataTable();
				CDBConnection.getDataTable(ref dtUserMenu,strSql,"userMenu");

				for(int i=0;i<this.tvwMenuInfo.Nodes.Count;i++)

				{
					for(int x=0;x<dtUserMenu.Rows.Count;x++)
					{
						if(this.tvwMenuInfo.Nodes[i].Text.Trim()==dtUserMenu.Rows[x][0].ToString().Trim())
						{

							this.tvwMenuInfo.Nodes[i].Checked=true;
							break;
						}
						else
						{
							this.tvwMenuInfo.Nodes[i].Checked=false;
						}
					}
						
					for(int j=0;j<this.tvwMenuInfo.Nodes[i].Nodes.Count;j++)
					{
						for(int y=0;y<dtUserMenu.Rows.Count;y++)
						{
							if(this.tvwMenuInfo.Nodes[i].Nodes[j].Text.Trim()==dtUserMenu.Rows[y][0].ToString().Trim())
							{
								this.tvwMenuInfo.Nodes[i].Nodes[j].Checked=true;
								break;
							}
							else
							{
								this.tvwMenuInfo.Nodes[i].Nodes[j].Checked=false;
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

		
	}
}

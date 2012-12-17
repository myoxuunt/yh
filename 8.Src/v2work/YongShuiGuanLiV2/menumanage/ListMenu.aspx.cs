using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;


namespace YongShuiGuanLiV2.menumanage
{
	/// <summary>
	/// ListMenu 的摘要说明。
	/// </summary>
	public class ListMenu : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button btnDel;
		public string allNodes;
        YongShuiGuanLiDBI.MenuDBI lo = new YongShuiGuanLiDBI.MenuDBI();
		
		private void Page_Load(object sender, System.EventArgs e)
		{
            //String c="";
//			if(!IsPostBack)
//			{
//				if(Request.Params.Count>1)
//				{
//					c=Request.QueryString["para"].ToString();
//				}
//				String user_name=Session["username"].ToString();
//			}

            string admin = Session["admin"].ToString();
            string role_type = lo.role_type(admin);
            allNodes = lo.getAllNodes(role_type);
			//Response.Write("<script type='text/javascript' src=http://localhost/yh/js/MzTreeView10.js> </script>"); 
		}

		#region Web 窗体设计器生成的代码
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{    
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnDel_Click(object sender, System.EventArgs e)
		{
	      string menuId=Request.Params["NodeId"].ToString();
		  if((menuId=="")||(menuId==null))
		  {
			  
			  
			  String scriptString = "<script language=JavaScript> ";
			  scriptString += "alert('请选择要删除的模块！')</script>";
			  this.RegisterStartupScript("Script", scriptString);
			   return;	
		  }

		  string fatherId=lo.GetModuleInfo(menuId).Rows[0][1].ToString();
		  if(fatherId=="-1")
		  {
			  String scriptString = "<script language=JavaScript> ";
			  scriptString += "alert('对不起，不能删除根模块！')</script>";
			  this.RegisterStartupScript("Script", scriptString);
			  return;	
		  }
 
		  lo.DelModuleInfo(menuId);
		  Response.Redirect("ListMenu.aspx");
//		  
		}
	}
}

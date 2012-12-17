using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace YongShuiGuanLiV2
{
    public partial class left : System.Web.UI.Page
    {
        YongShuiGuanLiDBI.MenuDBI lo = new YongShuiGuanLiDBI.MenuDBI();
        public string admin = "";//普通用户
        public string menu = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] != null)
            {
                //部门id
                //string username = Session["username"].ToString().Trim();
                //admin角色
                admin = Session["admin"].ToString();
                Session["role_type"] = lo.role_type(admin);

                //				string menu="";
                //根据用户身份获取菜单列表
                //data_link.login_data myDB = new data_link.login_data();
                DataTable dtMenu = lo.getFirstMenu(admin);//获取第一级菜单menuid, name,menuurl,seq				
                for (int i = 0; i < dtMenu.Rows.Count; i++)
                {
                    //第一级菜单
                    string fun = "onclick='menuChange3(" + dtMenu.Rows.Count + "," + i.ToString() + ")'";
                    menu += "<table class='leftTable' align='center' cellpadding='0px' cellspacing='1px'><tr style='CURSOR: hand'>" +
                        "<td  class='left' onmouseover=$this.className='left2';$ #" +
                        "onmouseout=$this.className='left';$ >" +
                        "<span>";
                    string url;
                    if (dtMenu.Rows[i][2].ToString() != "")
                    {
                        url = "<IMG src=' Images/left/2.gif' vspace='5'><a  class='mA' href='" + dtMenu.Rows[i][2].ToString() + "' target='right'>" + dtMenu.Rows[i]["name"].ToString() + "</a>";
                    }
                    else
                    {
                        url = "&nbsp;<IMG src=' Images/left/2.gif' vspace='5'>&nbsp;" + dtMenu.Rows[i]["name"].ToString();
                    }
                    menu += url + "</span></td></tr>";
                    //第二级菜单
                    string menuId = dtMenu.Rows[i][0].ToString();

                    DataTable dt1 =lo.get_menu2("select menu_id from tb_role_linkmenu where father_id=" + menuId + " and role_id=" + admin);
                    string secUrl = "";
                    menu += "<tr><td><div class='sec_menu' id='menu" + i.ToString() + "' style='DISPLAY: none' align='center'>" +
                        "<table class='leftTable2'>";
                    for (int c = 0; c < dt1.Rows.Count; c++)
                    {
                        Session["menu_first_id"] = dt1.Rows[c]["menu_id"].ToString();
                        DataTable myDt =lo.getChild(Session["menu_first_id"].ToString()).Tables[0];//包含自己及所以子节点
                        //						DataTable myDt=myDB.getChild(menuId).Tables[0];//包含自己及所以子节点
                        if (myDt.Rows.Count > 0)
                        {

                            for (int j = 0; j < myDt.Rows.Count; j++)
                            {
                                if (myDt.Rows[j][0].ToString() != menuId)
                                {

                                    DataTable menuInfo =lo.GetModuleInfo(myDt.Rows[j][0].ToString());
                                    secUrl += "<tr style='CURSOR: hand'><td  onmouseover=$this.className='sec_over';$ onmouseout=$this.className='sec_out';$><a href='" +
                                        menuInfo.Rows[0][3].ToString() + "' target='right'>" + menuInfo.Rows[0][0].ToString() + "</a></td></tr>";
                                }
                            }


                        }
                        else
                        {
                            //							menu=menu.Replace("#",""); 
                            //							if( menu.IndexOf("#") == -1 )
                            //							{
                            //								System.Diagnostics.Debug.Fail("####");
                            //							}
                        }

                    }

                    menu += secUrl + "</table></div></td></tr>";
                    menu = menu.Replace("#", fun);
                    menu += "</table>";
                    menu = menu.Replace("$", "\"");
                    Console.WriteLine(menu);

                }
            }
        }
    }
}

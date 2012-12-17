using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace YongShuiGuanLiDBI
{
    public class MenuDBI
    {
        string conn = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
        #region 菜单管理
        //根据登录角色查询角色类型
        public string role_type(string role_id)
        {
            string roletype = "";
            DataTable dt = new DataTable();
            if (role_id.Length > 0)
            {
                dt =DBI.GetDBI().ExecuteDataTable("select role_type from tb_role where role_id=" + role_id);
            }
            else
            {
                dt = DBI.GetDBI().ExecuteDataTable("select role_type from tb_role");
            }
            try
            {
                if (dt.Rows.Count > 0)
                {
                    roletype = dt.Rows[0]["role_type"].ToString();
                }
            }
            catch
            {
                roletype = "";
            }
            return roletype;
        }
        /// <summary>
        /// 根据登录角色构建一级菜单
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public DataTable getFirstMenu(string role_id)
        {
            string strQuery;
            string roletype = role_type(role_id);
            if (int.Parse(roletype) == 1)//roletype=1所有管理局用户
            {
                if (role_id == "1")
                {
                    strQuery = "select menu_id,name,menulink from tb_menu where fatherid=(select menu_id from tb_menu where fatherid=-1 and role_type=1) order by seq";
                }
                else
                {
                    strQuery = "select menu_id,name,menulink from tb_menu where fatherid=(select menu_id from tb_menu where fatherid=-1 and role_type=1) and name!='系统维护管理' order by seq";
                }
            }
            else//所有管理处用户
            {
                if (role_id == "2")
                {
                    strQuery = "select menu_id,name,menulink from tb_menu where fatherid=(select menu_id from tb_menu where fatherid=-1 and role_type=2) order by seq";
                }
                else
                {
                    strQuery = "select menu_id,name,menulink from tb_menu where fatherid=(select menu_id from tb_menu where fatherid=-1 and role_type=2) and name!='系统维护管理' order by seq";
                }
            }
            try
            {

                return DBI.GetDBI().ExecuteDataTable(strQuery);
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 二级菜单检索
        /// </summary>
        /// <param name="fatherid"></param>
        /// <returns></returns>
        public DataSet getChild(string fatherid)
        {
            SqlConnection myConnection = new SqlConnection(conn);
            SqlCommand myCommand = new SqlCommand("sp_getChild", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter p_tablename = new SqlParameter("@TName", SqlDbType.VarChar,40);
            p_tablename.Value ="tb_menu";
            myCommand.Parameters.Add(p_tablename);

            SqlParameter p_tableid = new SqlParameter("@IDName", SqlDbType.VarChar,40);
            p_tableid.Value = "menu_id";
            myCommand.Parameters.Add(p_tableid);

            SqlParameter p_fatherid = new SqlParameter("@PIDName", SqlDbType.VarChar,40);
            p_fatherid.Value = "fatherid";
            myCommand.Parameters.Add(p_fatherid);

            SqlParameter p_storename = new SqlParameter("@Name", SqlDbType.VarChar,40);
            p_storename.Value = "name";
            myCommand.Parameters.Add(p_storename);

            SqlParameter p_id = new SqlParameter("@ID", SqlDbType.VarChar,40);
            p_id.Value =fatherid;
            myCommand.Parameters.Add(p_id);

            SqlDataAdapter myDA = new SqlDataAdapter(myCommand);
            DataSet myDS = new DataSet();
            myDA.Fill(myDS, "menu");
            return myDS;
        }
        /// <summary>
        /// 按角色类型检索所有二级菜单
        /// </summary>
        /// <param name="role_type"></param>
        /// <returns></returns>
        public DataTable getchild_roletype(string role_type)
        {
            DataTable dt = new DataTable();
            if (int.Parse(role_type.ToString()) == 1)//管理局所有二级菜单
            {
                dt = DBI.GetDBI().ExecuteDataTable("select * from tb_menu where fatherid!='-1'and fatherid!='1' and role_type=" + role_type);
            }
            else//管理处所有二级菜单
            {
                dt = DBI.GetDBI().ExecuteDataTable("select * from tb_menu where fatherid!='-1'and fatherid!='3' and role_type=" + role_type);
            }

            return dt;
        }
        public DataTable get_menu2(string sql)
        {
            DataTable dt = new DataTable();
            dt = DBI.GetDBI().ExecuteDataTable(sql);
            return dt;
        }
        #endregion
        #region(模块管理)
        //获取所有菜单节点
        public string getAllNodes(string roletype)
        {
            SqlConnection myConnection = new SqlConnection(conn);
            string strQuery = string.Format("select menu_id, fatherid ,name from tb_menu where role_type={0} order by fatherid, seq ", roletype);
            String result = "";
            try
            {
                SqlDataAdapter myDA = new SqlDataAdapter(strQuery, myConnection);
                DataSet myDS = new DataSet();
                myDA.Fill(myDS, "menu");
                DataTable myDT = myDS.Tables["menu"];
                for (int i = 0; i < myDT.Rows.Count; i++)
                {
                    String menuId = myDT.Rows[i][0].ToString();
                    String fatherId = myDT.Rows[i][1].ToString();
                    String name = myDT.Rows[i][2].ToString();
                    result = result + menuId + "," + name + "," + fatherId + ";";

                }
                return result;
            }
            catch (Exception ex)
            {
                string er = ex.Message;
                return result;
            }
        }

        //获取上级菜单名称
        public string GetFName(string MenuId)
        {
            SqlConnection myConnection = new SqlConnection(conn);
            string strQuery = "select b.name  from tb_menu a,tb_menu b " +
                " where  a.fatherid=b.menu_id  and a.menu_id= " + MenuId;

            try
            {
                SqlDataAdapter myDA = new SqlDataAdapter(strQuery, myConnection);
                DataSet myDS = new DataSet();
                myDA.Fill(myDS, "tb_menu");
                return myDS.Tables["menu"].Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                string er = ex.Message;
                return null;
            }
        }

        //获取模块列表名称
        public DataTable GetModuleInfo(string MenuId)
        {
            SqlConnection myConnection = new SqlConnection(conn);
            string strQuery = "select name,fatherid ,seq,menulink from tb_menu where menu_id=" + MenuId;

            //try
            //{
                SqlDataAdapter myDA = new SqlDataAdapter(strQuery, myConnection);
                DataSet myDS = new DataSet();
                myDA.Fill(myDS, "menu");
                return myDS.Tables["menu"];
            //}
            //catch (Exception ex)
            //{

            //    return null;
            //}
        }


        //更新菜单
        public bool UpdateModuleInfo(string MenuId, string fatherid, string seq, string name, string menulink)
        {

            SqlConnection myConnection = new SqlConnection(conn);

            string strCmd;
            strCmd = "update tb_menu set name=@name ,fatherid=@fatherid,seq=@seq ,menulink=@menulink" +
                " where menu_id=" + MenuId;
            //sqlhelp.ExecuteNonQuery(conn,CommandType.Text,strCmd,SqlParameter("@name",SqlDbType.VarChar,100)
            SqlCommand nCommand = new SqlCommand(strCmd, myConnection);

            nCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar, 100));
            nCommand.Parameters["@name"].Value = name;

            nCommand.Parameters.Add(new SqlParameter("@fatherid", SqlDbType.Int, 4));
            nCommand.Parameters["@fatherid"].Value = Int16.Parse(fatherid);

            nCommand.Parameters.Add(new SqlParameter("@seq", SqlDbType.Int, 4));
            nCommand.Parameters["@seq"].Value = Int16.Parse(seq);

            nCommand.Parameters.Add(new SqlParameter("@menulink", SqlDbType.VarChar, 100));
            nCommand.Parameters["@menulink"].Value = menulink;




            //try
            //{
                myConnection.Open();
                nCommand.ExecuteNonQuery();
                myConnection.Close();
            //}
            //catch (Exception ex)
            //{
            //    return false;
            //}
            return true;
        }


        //插入菜单
        public bool InSertModuleInfo(string fatherid, string seq, string name, string menulink, string roletype)
        {

            SqlConnection myConnection = new SqlConnection(conn);
            string strCmd;
            strCmd = "insert tb_menu(name,fatherid,seq,menulink,role_type) values(@name ,@fatherid,@seq ,@menulink,@role_type)";

            SqlCommand nCommand = new SqlCommand(strCmd, myConnection);

            nCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar, 100));
            nCommand.Parameters["@name"].Value = name;

            nCommand.Parameters.Add(new SqlParameter("@fatherid", SqlDbType.Int, 4));
            nCommand.Parameters["@fatherid"].Value = Int16.Parse(fatherid);

            nCommand.Parameters.Add(new SqlParameter("@seq", SqlDbType.Int, 4));
            nCommand.Parameters["@seq"].Value = Int16.Parse(seq);

            nCommand.Parameters.Add(new SqlParameter("@menulink", SqlDbType.VarChar, 100));
            nCommand.Parameters["@menulink"].Value = menulink;

            nCommand.Parameters.Add(new SqlParameter("@role_type", SqlDbType.VarChar, 10));
            nCommand.Parameters["@role_type"].Value = roletype;

            //try
            //{
                myConnection.Open();
                nCommand.ExecuteNonQuery();
                myConnection.Close();
            //}
            //catch (Exception ex)
            //{
            //    return false;
            //}
            return true;
        }

        //删除菜单
        public bool DelModuleInfo(string menuId)
        {

            SqlConnection myConnection = new SqlConnection(conn);
            string strCmd;
            strCmd = "delete from  tb_menu where menu_id=" + menuId;
            SqlCommand nCommand = new SqlCommand(strCmd, myConnection);
            SqlTransaction myTrans;
            myConnection.Open();
            myTrans = myConnection.BeginTransaction();
            nCommand.Transaction = myTrans;
            try
            {
                nCommand.ExecuteNonQuery();

                strCmd = "create table #T(menuID int,fatherID int,Name VARCHAR(100))";
                nCommand.CommandText = strCmd;
                nCommand.ExecuteNonQuery();

                strCmd = "insert into #T exec sp_getChild  'tb_menu','menu_id','fatherid','name','" + menuId + "'";
                nCommand.CommandText = strCmd;
                nCommand.ExecuteNonQuery();

                strCmd = "delete from tb_menu where menu_id in (select menuID from #T)";
                nCommand.CommandText = strCmd;
                nCommand.ExecuteNonQuery();

                strCmd = "drop table #T";
                nCommand.CommandText = strCmd;
                nCommand.ExecuteNonQuery();

                myTrans.Commit();
                myConnection.Close();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                myTrans.Rollback();
                return false;
            }
            finally
            {
                myConnection.Close();
            }
            return true;
        }
        #endregion
        #region 角色管理
        public DataTable role_query(string role_id, string role_type)
        {
            DataTable dt = new DataTable();
            if (role_id.Length > 0)
            {
                dt = DBI.GetDBI().ExecuteDataTable("select * from tb_role where role_id=" + role_id);
            }
            else
            {
                dt = DBI.GetDBI().ExecuteDataTable("select * from tb_role where role_type=" + role_type);
            }

            return dt;
        }
        #endregion
    }
}

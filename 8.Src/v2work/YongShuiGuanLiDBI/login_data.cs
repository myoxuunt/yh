using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace YongShuiGuanLiDBI
{
    public class login_data
    {
        #region 管理情况统计
        public void glqktj_new(string stryear, string strimage, string strremark, string strtime)
        {
            DateTime dt = System.Convert.ToDateTime(strtime);
            string sql = string.Format("insert into tb_glqktj(year,image,remark,time)values('{0}','{1}','{2}','{3}')", stryear, strimage, strremark, dt);
            DBI.GetDBI_yhxx().ExecuteScalar(sql);
            //			sqlhelp.ExecuteNonQuery(conn,CommandType.Text,"insert into tb_glqktj(year,image,time,remark)values('{0}','{1}','{2}','{3}')",stryear,strimage,strremark,strtime);
        }
        public DataTable glqktj_query(string glqk_id, string year)
        {
            string str1="";
            if (!string.IsNullOrEmpty(glqk_id))
            { str1 = "where tb_glqktj.glqk_id='" + glqk_id+ "'"; }
            if (!string.IsNullOrEmpty(year))
            {
                if (str1.Length > 0)
                {
                    str1 = str1 + " and tb_glqktj.year='" + year + "'";
                }
                else
                {
                    str1 = "where tb_glqktj.year='" + year+ "'";
                }
            }
            string str = "select * from tb_glqktj " + str1;
            DataTable ds = DBI.GetDBI_yhxx().ExecuteDataTable(str);
            return ds;
        }
        #endregion
        #region 经营投资情况
        public void jytztj_new(string stryear, string strimage, string strremark, string strtime)
        {
            DateTime dt = System.Convert.ToDateTime(strtime);
            string sql = string.Format("insert into tb_jytztj(year,image,remark,time)values('{0}','{1}','{2}','{3}')", stryear, strimage, strremark, dt);
            DBI.GetDBI_yhxx().ExecuteScalar(sql);

        }
        public DataTable jytztj_query(string jytz_id, string year)
        {
            string str1 = "";
            if (!string.IsNullOrEmpty(jytz_id))
            { str1 = "where tb_jytztj.jytz_id='" + jytz_id + "'"; }
            if (!string.IsNullOrEmpty(year))
            {
                if (str1.Length > 0)
                {
                    str1 = str1 + " and tb_jytztj.year='" + year + "'";
                }
                else
                {
                    str1 = "where tb_jytztj.year='" + year + "'";
                }
            }
            string str = "select * from tb_jytztj " + str1;
            DataTable ds = DBI.GetDBI_yhxx().ExecuteDataTable(str);
            return ds;
        }
        #endregion
        #region 工程数据统计
        public void gcsjtj_new(string stryear, string strimage, string strremark, string strtime)
        {
            DateTime dt = System.Convert.ToDateTime(strtime);
            string sql = string.Format("insert into tb_gcsjtj(year,image,remark,time)values('{0}','{1}','{2}','{3}')", stryear, strimage, strremark, dt);
            DBI.GetDBI_yhxx().ExecuteScalar(sql);

        }
        public DataTable gcsjtj_query(string gcsj_id, string year)
        {
            string str1 = "";
            if (!string.IsNullOrEmpty(gcsj_id))
            { str1 = "where tb_gcsjtj.gcsj_id='" + gcsj_id + "'"; }
            if (!string.IsNullOrEmpty(year))
            {
                if (str1.Length > 0)
                {
                    str1 = str1 + " and tb_gcsjtj.year='" + year + "'";
                }
                else
                {
                    str1 = "where tb_gcsjtj.year='" + year + "'";
                }
            }
            string str = "select * from tb_gcsjtj " + str1;
            DataTable ds = DBI.GetDBI_yhxx().ExecuteDataTable(str);
            return ds;
            
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace YongShuiGuanLiDBI
{
    public class gcgl_data
    {
        #region 水库信息查询
        /// <summary>
        /// 水库信息查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable sk_query(string id)
        {
            string sql = "";
            string conn = System.Configuration.ConfigurationSettings.AppSettings["wmgis"];
            if (id.ToString() != "")
            {
                sql = string.Format("select * from 水库  where id='{0}'", id);
            }
            else
            {
                sql = string.Format("select * from 水库");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        #endregion
        #region 大坝信息查询
        /// <summary>
        /// 大坝信息查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable db_query(string id)
        {
            string sql = "";
            if (id.ToString() != "")
            {
                sql = string.Format("select * from 大坝  where id='{0}'", id);
            }
            else
            {
                sql = string.Format("select * from 大坝");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        #endregion
        #region 渠系建筑物查询
        /// <summary>
        /// 渠道查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable qd_query(string id)
        {
            string sql = "";
            if (id.ToString() != "")
            {
                sql = string.Format("select * from 渠道  where id='{0}'", id);
            }
            else
            {
                sql = string.Format("select * from 渠道");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        public DataTable qd_query3(string name)
        {
            string sql = "";
            if (name.ToString() != "")
            {
                sql = string.Format("select * from 渠道  " + name + "");
            }
            else
            {
                sql = string.Format("select * from 渠道");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        #endregion
        #region 渠道查询
        /// <summary>
        /// 渠道查询                                                       
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual DataTable qd_query1(string name)
        {
            string sql = "";
            if (name.ToString() != "")     
            {
                sql = string.Format("select * from 渠道  where 上级渠道='{0}'", name);
            }
            else
            {
                sql = string.Format("select * from 渠道 where 上级渠道 is not null");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        /// <summary>
        /// 查询所有上级渠道
        /// </summary>
        /// <returns></returns>
        public virtual DataTable qd_query2()
        {
            string sql = string.Format("select distinct(上级渠道) as sjqd from 渠道 where 上级渠道 is not null");
            
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        #endregion
        #region 渠道防渗查询
        /// <summary>
        /// 渠道防渗查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable qdfs_query(string id)
        {
            string sql = "";
            if (id.ToString() != "")
            {
                sql = string.Format("select * from 渠道防渗  where id='{0}'", id);
            }
            else
            {
                sql = string.Format("select * from 渠道防渗");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        public DataTable qdfs_query1(string name)
        {
            string sql = "";
            if (name.ToString() != "")
            {
                sql = string.Format("select dbo.渠道防渗.* FROM dbo.渠道 INNER JOIN dbo.渠道防渗 ON dbo.渠道.渠道名称 = dbo.渠道防渗.所属渠道 "+name+"");
            }
            else
            {
                sql = string.Format("select * from 渠道防渗");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        #endregion
        #region 渠道技术参数查询
        /// <summary>
        /// 渠道技术参数查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable qdjscs_query(string id)
        {
            string sql = "";
            if (id.ToString() != "")
            {
                sql = string.Format("select * from 渠道技术参数  where id='{0}'", id);
            }
            else
            {
                sql = string.Format("select * from 渠道技术参数");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        public DataTable qdjscs_query1(string name)
        {
            string sql = "";
            if (name.ToString() != "")
            {
                sql = string.Format("select dbo.渠道技术参数.* FROM dbo.渠道 INNER JOIN dbo.渠道技术参数 ON dbo.渠道.渠道名称 = dbo.渠道技术参数.所属渠道 " + name + "");
            }
            else
            {
                sql = string.Format("select * from 渠道技术参数");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        #endregion
        #region 渠道险工险段查询
        /// <summary>
        /// 渠道险工险段查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable qdxgxd_query(string id)
        {
            string sql = "";
            if (id.ToString() != "")
            {
                sql = string.Format("select * from 渠道险工险段  where id='{0}'", id);
            }
            else
            {
                sql = string.Format("select * from 渠道险工险段");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        public DataTable qdxgxd_query1(string name)
        {
            string sql = "";
            if (name.ToString() != "")
            {
                sql = string.Format("select dbo.渠道险工险段.* FROM dbo.渠道 INNER JOIN dbo.渠道险工险段 ON dbo.渠道.渠道名称 = dbo.渠道险工险段.所属渠道 " + name + "");
            }
            else
            {
                sql = string.Format("select * from 渠道险工险段");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        #endregion
        #region 渠首信息查询
        /// <summary>
        /// 渠首信息查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable qs_query(string id)
        {
            string sql = "";
            if (id.ToString() != "")
            {
                sql = string.Format("select * from 渠首  where id='{0}'", id);
            }
            else
            {
                sql = string.Format("select * from 渠首");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        #endregion
        #region 倒虹吸信息查询
        /// <summary>
        /// 倒虹吸信息查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable dhx_query(string id)
        {
            string sql = "";
            if (id.ToString() != "")
            {
                sql = string.Format("select * from 倒虹吸  where id='{0}'", id);
            }
            else
            {
                sql = string.Format("select * from 倒虹吸");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        public virtual DataTable dhx_query1(string name)
        {
            string sql = "";
            if (name != "")
            {
                sql = string.Format("select dbo.倒虹吸.* FROM dbo.渠道 INNER JOIN dbo.倒虹吸 ON dbo.渠道.渠道名称 = dbo.倒虹吸.所属渠道 " + name + "");
            }
            else
            {
                sql = string.Format("select * from 倒虹吸");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        #endregion
        #region 桥梁信息查询
        /// <summary>
        /// 桥梁信息查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable ql_query(string id)
        {
            string sql = "";
            if (id.ToString() != "")
            {
                sql = string.Format("select * from 桥梁  where id='{0}'", id);
            }
            else
            {
                sql = string.Format("select * from 桥梁");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        public virtual DataTable ql_query1(string name)
        {
            string sql = "";
            if (name != "")
            {
                sql = string.Format("select dbo.桥梁.* FROM dbo.渠道 INNER JOIN dbo.桥梁 ON dbo.渠道.渠道名称 = dbo.桥梁.所属渠道 " + name + "");
            }
            else
            {
                sql = string.Format("select * from 桥梁");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        #endregion
        #region 其它建筑物信息查询
        /// <summary>
        /// 其它建筑物信息查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable qt_query(string id)
        {
            string sql = "";
            if (id.ToString() != "")
            {
                sql = string.Format("select * from 其它建筑物  where id='{0}'", id);
            }
            else
            {
                sql = string.Format("select * from 其它建筑物");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        public virtual DataTable qt_query1(string name)
        {
            string sql = "";
            if (name != "")
            {
                sql = string.Format("select dbo.其它建筑物.* FROM dbo.渠道 INNER JOIN dbo.其它建筑物 ON dbo.渠道.渠道名称 = dbo.其它建筑物.所属渠道 " + name + "");
            }
            else
            {
                sql = string.Format("select * from 其它建筑物");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        #endregion
        #region 涵洞信息查询
        /// <summary>
        /// 涵洞信息查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable hd_query(string id)
        {
            string sql = "";
            if (id.ToString() != "")
            {
                sql = string.Format("select * from 涵洞  where id='{0}'", id);
            }
            else
            {
                sql = string.Format("select * from 涵洞");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        public virtual DataTable hd_query1(string name)
        {
            string sql = "";
            if (name != "")
            {
                sql = string.Format("select dbo.涵洞.* FROM dbo.渠道 INNER JOIN dbo.涵洞 ON dbo.渠道.渠道名称 = dbo.涵洞.所属渠道 " + name + "");
            }
            else
            {
                sql = string.Format("select * from 涵洞");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        #endregion
        #region 水电站信息查询
        /// <summary>
        /// 水电站信息查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable sdz_query(string id)
        {
            string sql = "";
            if (id.ToString() != "")
            {
                sql = string.Format("select * from 水电站  where id='{0}'", id);
            }
            else
            {
                sql = string.Format("select * from 水电站");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        #endregion
        #region 隧洞信息查询
        /// <summary>
        /// 隧洞信息查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable sd_query(string id)
        {
            string sql = "";
            if (id.ToString() != "")
            {
                sql = string.Format("select * from 隧洞  where id='{0}'", id);
            }
            else
            {
                sql = string.Format("select * from 隧洞");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        public virtual DataTable sd_query1(string name)
        {
            string sql = "";
            if (name != "")
            {
                sql = string.Format("select dbo.隧洞.* FROM dbo.渠道 INNER JOIN dbo.隧洞 ON dbo.渠道.渠道名称 = dbo.隧洞.所属渠道 " + name + "");
            }
            else
            {
                sql = string.Format("select * from 隧洞");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        #endregion
        #region 排水沟信息查询
        /// <summary>
        /// 排水沟信息查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable psg_query(string id)
        {
            string sql = "";
            if (id.ToString() != "")
            {
                sql = string.Format("select * from 排水沟道  where id='{0}'", id);
            }
            else
            {
                sql = string.Format("select * from 排水沟道");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        #endregion
        #region 渡槽信息查询
        /// <summary>
        /// 渡槽信息查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable dc_query(string id)
        {
            string sql = "";
            if (id.ToString() != "")
            {
                sql = string.Format("select * from 渡槽  where id='{0}'", id);
            }
            else
            {
                sql = string.Format("select * from 渡槽");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        /// <summary>
        /// 渡槽查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public virtual DataTable dc_query1(string name)
        {
            string sql = "";
            if (name != "")
            {
                sql = string.Format("select dbo.渡槽.* FROM dbo.渠道 INNER JOIN dbo.渡槽 ON dbo.渠道.渠道名称 = dbo.渡槽.所属渠道 " + name + "");
            }
            else
            {
                sql = string.Format("select * from 渡槽");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        #endregion
        #region 跌水信息查询
        /// <summary>
        /// 跌水信息查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable ds_query(string id)
        {
            string sql = "";
            if (id.ToString() != "")
            {
                sql = string.Format("select * from 跌水  where id='{0}'", id);
            }
            else
            {
                sql = string.Format("select * from 跌水");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        public virtual DataTable ds_query1(string name)
        {
            string sql = "";
            if (name != "")
            {
                sql = string.Format("select dbo.跌水.* FROM dbo.渠道 INNER JOIN dbo.跌水 ON dbo.渠道.渠道名称 = dbo.跌水.所属渠道 " + name + "");
            }
            else
            {
                sql = string.Format("select * from 跌水");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        #endregion
        #region 陡坡信息查询
        /// <summary>
        /// 陡坡信息查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable dp_query(string id)
        {
            string sql = "";
            if (id.ToString() != "")
            {
                sql = string.Format("select * from 陡坡  where id='{0}'", id);
            }
            else
            {
                sql = string.Format("select * from 陡坡");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        public virtual DataTable dp_query1(string name)
        {
            string sql = "";
            if (name != "")
            {
                sql = string.Format("select dbo.陡坡.* FROM dbo.渠道 INNER JOIN dbo.陡坡 ON dbo.渠道.渠道名称 = dbo.陡坡.所属渠道 " + name + "");
            }
            else
            {
                sql = string.Format("select * from 陡坡");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        #endregion
        #region 水闸查询
        /// <summary>
        /// 水闸信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable shz_query(string id)
        {
            string sql = "";
            if (id.ToString() != "")
            {
                sql = string.Format("select * from 水闸  where id='{0}'", id);
            }
            else
            {
                sql = string.Format("select * from 水闸");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        public DataTable shz_query1(string name)
        {
            string sql = "";
            if (name.ToString() != "")
            {
                sql = string.Format("select dbo.水闸.* FROM dbo.渠道 INNER JOIN dbo.水闸 ON dbo.渠道.渠道名称 = dbo.水闸.所属渠道 " + name + "");
            }
            else
            {
                sql = string.Format("select * from 水闸");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        #endregion
        #region 泵站查询
        /// <summary>
        /// 泵站信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable bz_query(string id)
        {
            string sql = "";
            if (id.ToString() != "")
            {
                sql = string.Format("select * from 泵站  where id='{0}'", id);
            }
            else
            {
                sql = string.Format("select * from 泵站");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        public DataTable bz_query1(string name)
        {
            string sql = "";
            if (name.ToString() != "")
            {
                sql = string.Format("select dbo.泵站.* FROM dbo.渠道 INNER JOIN dbo.泵站 ON dbo.渠道.渠道名称 = dbo.泵站.所属渠道 "+name+"");
            }
            else
            {
                sql = string.Format("select * from 泵站");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        #endregion
        #region 沉沙地查询
        /// <summary>
        /// 沉沙地信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable csd_query(string id)
        {
            string sql = "";
            if (id.ToString() != "")
            {
                sql = string.Format("select * from 沉沙池  where id='{0}'", id);
            }
            else
            {
                sql = string.Format("select * from 沉沙池");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        public DataTable csd_query1(string name)
        {
            string sql = "";
            if (name.ToString() != "")
            {
                sql = string.Format("select dbo.沉沙池.* FROM dbo.渠道 INNER JOIN dbo.沉沙池 ON dbo.渠道.渠道名称 = dbo.沉沙池.所属渠道 " + name + "");
            }
            else
            {
                sql = string.Format("select * from 沉沙池");
            }
            DataTable dt = DBI.GetDBI_wmgis().ExecuteDataTable(sql);
            return dt;
        }
        #endregion
    }
}

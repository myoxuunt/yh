using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Xml;

namespace YHZKPort
{
    class DBcon
    {
        #region var
        private XmlDocument xDoc = null;
        private XmlNode XNode = null;
        private string _connstr;
        private SqlConnection _sqlConnect;
        static private DBcon _db;
        #endregion

        static public DBcon Instance
        {
            get { return _db; }
        }

        public DBcon()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
            xDoc = new XmlDocument();
            xDoc.Load("Config.xml");
            _connstr = DataBase();
            _db = this;
        }

        public void Open()
        {
            _sqlConnect = new SqlConnection(_connstr);
            _sqlConnect.Open();
        }

        public void Close()
        {
            _sqlConnect.Close();
        }

        public DataTable GetDataTable(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, _sqlConnect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            da.Dispose();
            return ds.Tables[0];
        }

        public bool ExecuteNonQuery(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, _sqlConnect);
            if (cmd.ExecuteNonQuery() == 1)
                return true;
            else
                return false;
        }

        public string DataBase()
        {
            string str = "";
            XNode = xDoc.DocumentElement.SelectSingleNode("./SqlCon");
            for (int i = 0; i < XNode.ChildNodes.Count; i++)
            {
                str = str + XNode.ChildNodes[i].Name;
                str = str + "=";
                str = str + XNode.ChildNodes[i].InnerText.Trim();
                str = str + ";";
            }

            return str;
        }

        #region Service
        public string GetServicePath()
        {
            string str = "";
            XNode = xDoc.DocumentElement.SelectSingleNode("./listen");
            str = XNode.ChildNodes[0].InnerText.Trim();
            return str;
        }
        public string GetSendTime()
        {
            string str = "";
            XNode = xDoc.DocumentElement.SelectSingleNode("./SendTime");
            str = XNode.ChildNodes[0].InnerText.Trim();
            return str;
        }
        public bool SetServicePath(string Path)
        {
            try
            {
                XNode = xDoc.DocumentElement.SelectSingleNode("./listen");
                XNode.ChildNodes[0].InnerText = Path;
                xDoc.Save("Config.xml");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool SetSendTime(string time)
        {
            try
            {
                XNode = xDoc.DocumentElement.SelectSingleNode("./SendTime");
                XNode.ChildNodes[0].InnerText = time;
                xDoc.Save("Config.xml");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion
    }
}

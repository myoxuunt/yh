using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace YongShuiGuanLiV2
{
    /// <summary>
    /// 
    /// </summary>
    public class NameIDPair
    {
        /// <summary>
        /// 
        /// </summary>
        static public NameIDPair ALL = new NameIDPair("<全部>", 0);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        public NameIDPair(string name, int id)
        {
            this.Name = name;
            this.ID = id;
        }

        #region Name
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get
            {
                if (_name == null)
                {
                    _name = string.Empty;
                }
                return _name;
            }
            set
            {
                _name = value;
            }
        } private string _name;
        #endregion //Name

        #region ID
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            get
            {
                return _iD;
            }
            set
            {
                _iD = value;
            }
        } private int _iD;
        #endregion //ID

    }


    /// <summary>
    /// 
    /// </summary>
    public class NameIDPairCollection : Xdgk.Common.Collection<NameIDPair>
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public class NameIDPairFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tbl"></param>
        /// <param name="nameColumn"></param>
        /// <param name="idColumn"></param>
        /// <returns></returns>
        static public NameIDPairCollection Create(DataTable tbl, string nameColumn, string idColumn)
        {
            NameIDPairCollection c = new NameIDPairCollection();
            foreach (DataRow row in tbl.Rows)
            {
                string name = row[nameColumn].ToString().Trim();
                int id = Convert.ToInt32(row[idColumn]);
                NameIDPair n = new NameIDPair(name,id);
                c.Add(n);
            }
            return c;
        }
    }
}

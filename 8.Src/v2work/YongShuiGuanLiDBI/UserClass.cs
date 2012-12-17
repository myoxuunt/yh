using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class UserClass
    {
        /// <summary>
        /// 
        /// </summary>
        public void Save()
        {
            if (IsAdd())
            {
                this.UserID = UserDBI.AddUser(this.Name, this.Pwd, this.WaterUserID,
                    this.Role.RoleValue, this.AllowEditData, this.EditPassword);
            }
            else
            {
                UserDBI.UpdateUser(this.UserID, this.Name, this.Pwd, this.WaterUserID,
                    this.Role.RoleValue, this.AllowEditData, this.EditPassword);
            }
        }

        #region UserID
        /// <summary>
        /// 
        /// </summary>
        public int UserID
        {
            get
            {
                return _userID;
            }
            set
            {
                _userID = value;
            }
        } private int _userID;
        #endregion //UserID

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

        #region Pwd
        /// <summary>
        /// 
        /// </summary>
        public string Pwd
        {
            get
            {
                if (_pwd == null)
                {
                    _pwd = string.Empty;
                }
                return _pwd;
            }
            set
            {
                _pwd = value;
            }
        } private string _pwd;
        #endregion //Pwd

        #region WaterUserID
        /// <summary>
        /// 
        /// </summary>
        public int WaterUserID
        {
            get
            {
                return _waterUserID;
            }
            set
            {
                _waterUserID = value;
            }
        } private int _waterUserID;
        #endregion //WaterUserID

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsAdd()
        {
            return this.UserID == 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        static public UserClass CreateUser(int userID)
        {
            DataTable tbl = UserDBI.GetUserDataTable(userID);
            if (tbl.Rows.Count > 0)
            {
                DataRow row = tbl.Rows[0];
                string name = row[DBNames.tb_User.Name].ToString();
                string pwd = row[DBNames.tb_User.Password].ToString();
                int waterUserID = Convert.ToInt32(row[DBNames.tb_User.WaterUserID]);
                int rolevalue = Convert.ToInt32(row["role"]);
                bool allowEdit = Convert.ToBoolean(row["allowEdit"]);
                string editPassword = row["EditPassword"].ToString();

                UserClass u = new UserClass();
                u.UserID = userID;
                u.Name = name;
                u.Pwd = pwd;
                u.WaterUserID = waterUserID;
                u.Role = new RoleClass(rolevalue);
                u.AllowEditData = allowEdit;
                u.EditPassword = editPassword;

                return u;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        public RoleClass Role
        {
            get
            {
                if (_roleClass == null)
                {
                    _roleClass = new RoleClass();
                }
                return _roleClass;
            }
            set
            {
                _roleClass = value;
            }
        } private RoleClass _roleClass;

        #region AllowEditData
        /// <summary>
        /// 用户能够编辑数据
        /// </summary>
        public bool AllowEditData
        {
            get
            {
                return _allowEditData;
            }
            set
            {
                _allowEditData = value;
            }
        } private bool _allowEditData;
        #endregion //AllowEditData


        #region EditPassword
        /// <summary>
        /// 
        /// </summary>
        public string EditPassword
        {
            get
            {
                if (_editPassword == null)
                {
                    _editPassword = string.Empty;
                }
                return _editPassword;
            }
            set
            {
                _editPassword = value;
            }
        } private string _editPassword;
        #endregion //EditPassword

        /// <summary>
        /// 
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool CheckEditPassword(string password)
        {
            return password == EditPassword;
        }

    }
}

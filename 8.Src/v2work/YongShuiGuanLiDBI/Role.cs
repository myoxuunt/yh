using System;
using System.Collections.Generic;
using System.Text;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class RoleClass
    {
        public const int SYSTEMADMIN = 2;
        public const int DEPARTMENTADMIN = 1;
        public const int USER = 0;

        /// <summary>
        /// 
        /// </summary>
        public RoleClass()
            : this(0)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="roleValue"></param>
        public RoleClass(int roleValue)
        {
            this.RoleValue = roleValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsSystemAdmin()
        {
            return this.RoleValue == SYSTEMADMIN;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsDepartmentAdmin()
        {
            return this.RoleValue == DEPARTMENTADMIN;
        }

        #region RoleValue
        /// <summary>
        /// 
        /// </summary>
        public int RoleValue
        {
            get
            {
                return _roleValue;
            }
            set
            {
                _roleValue = value;
            }
        } private int _roleValue;
        #endregion //RoleValue

    }
}

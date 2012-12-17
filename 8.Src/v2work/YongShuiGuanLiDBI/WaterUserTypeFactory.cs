using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace YongShuiGuanLiDBI
{
    public class WaterUserTypeFactory
    {
        static NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();


        #region CreateWaterUserTypeByID
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public WaterUserType CreateWaterUserTypeByID(int id)
        {
            WaterUserType wut = null;
            DataTable tbl = WaterUserTypeDBI.GetWaterUserTypeDataTable(id);

            if (tbl.Rows.Count > 0)
            {
                DataRow row = tbl.Rows[0];
                wut = CreateWaterUserType(row);
            }
            else
            {
                string err = string.Format("not find water user type by id '{0}'",id);
                log.Error(err);
            }
            return wut ;
        }
        #endregion //CreateWaterUserTypeByID

        #region CreateDefaultWaterUserType
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public WaterUserType CreateDefaultWaterUserType()
        {
            DataTable tbl = WaterUserTypeDBI.GetDefaultWaterUserTypeDataTable();
            if (tbl.Rows.Count > 0)
            {
                WaterUserType t = CreateWaterUserType(tbl.Rows[0]);
                return t;
            }
            else
            {
                string exmsg = "cannot find default water user type";
                throw new InvalidOperationException(exmsg);
            }
        }
        #endregion // CreateDefaultWaterUserType

        #region CreateWaterUserType
        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private static WaterUserType CreateWaterUserType(DataRow row)
        {
            WaterUserType wut = new WaterUserType();
            int id = Convert.ToInt32(row["waterUserTypeID"]);
            string n = row["WaterUserTypeName"].ToString();
            string remark = row["WaterUserTypeRemark"].ToString();
            //int isManager = Convert.ToInt32(row["IsManager"]);

            wut.WaterUserTypeID = id;
            wut.WaterUserTypeName = n;
            wut.WaterUserTypeRemark = remark;
            //wut.IsManager = isManager;
            return wut;
        }
        #endregion //CreateWaterUserType


        #region CreateWaterUserTypeCollection
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal static WaterUserTypeCollection CreateWaterUserTypeCollection()
        {
            WaterUserTypeCollection  wutc = new WaterUserTypeCollection();
            DataTable tbl = WaterUserTypeDBI.GetWaterUserTypeDataTable();
            foreach (DataRow row in tbl.Rows)
            {
                WaterUserType t = CreateWaterUserType(row);
                wutc.Add(t);
            }
            return wutc; 
        }
        #endregion //CreateWaterUserTypeCollection


        #region CreateManagerWaterUserType
        /// <summary>
        /// 
        /// </summary>
        internal static WaterUserType CreateManagerWaterUserType()
        {
            WaterUserType t = null;
            DataTable tbl = WaterUserTypeDBI.GetManagerWaterUserDataTable();
            if (tbl.Rows.Count > 0)
            {
                DataRow row = tbl.Rows[0];
                t = CreateWaterUserType(row);
            }
            return t;
        }
        #endregion //CreateManagerWaterUserType

        /// <summary>
        /// 
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        internal static WaterUserType GetDefaultWaterUserType(WaterUserLevel level)
        {
            if (level == null)
            {
                throw new ArgumentNullException("level");
            }

            return CreateDefaultWaterUserType();
        }

        #region All
        /// <summary>
        /// 
        /// </summary>
        static public WaterUserTypeCollection All
        {
            get
            {
                if (_waterUserTypeCollection == null)
                {
                    _waterUserTypeCollection = WaterUserTypeFactory.CreateWaterUserTypeCollection();
                }
                return _waterUserTypeCollection;
            }
        } static private WaterUserTypeCollection _waterUserTypeCollection;
        #endregion //All
    }
}

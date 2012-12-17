using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using NLog;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class WaterUserFactory
    {
        static Logger log = LogManager.GetCurrentClassLogger();

        //#region CreateJu
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //static public WaterUser CreateJu()
        //{
        //    // TODO:
        //    //
        //    return new WaterUser(null);
        //}
        //#endregion //CreateJu

        // TODO:
        // chu
        // 


        #region CreateWaterUser
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public WaterUserClass CreateWaterUser(WaterUserLevel level)
        {
            if( level == null )
            {
                throw new ArgumentNullException("level");
            }

            WaterUserClass wu = new WaterUserClass();
            wu.WaterUserLevel = level;
            //wu.WaterUserType = WaterUserTypeFactory.CreateDefaultWaterUserType(level);
            //WaterUserType.GetManagerWaterUserType
            wu.WaterUserType = WaterUserTypeFactory.GetDefaultWaterUserType(level);
            return wu;
            
        }
        #endregion //CreateWaterUser


        #region CreateWaterUserByID
        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterUserID"></param>
        /// <returns></returns>
        static public WaterUserClass CreateWaterUserByID(int waterUserID)
        {
            WaterUserClass wu = null;

            DataTable tbl = WaterUserDBI.GetWaterUserDataTable(waterUserID);
            if (tbl.Rows.Count > 0)
            {
                DataRow row = tbl.Rows[0];
                //int waterUserID = Convert.ToInt32(row["WaterUserID"]);
                wu = CreateWaterUser(row);
            }
            else
            {
                string err = string.Format("not find water user by id '{0}'", waterUserID);
                log.Error(err);
            }
            return wu;
        }
        #endregion //CreateWaterUserByID


        #region CreateLowLevelWaterUserCollection
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal static WaterUserCollection CreateLowLevelWaterUserCollection(int currentWaterUserID)
        {
            WaterUserCollection wuc = new WaterUserCollection();
            DataTable tbl = WaterUserDBI.GetLowLevelWaterUserDataTable(currentWaterUserID);
            foreach( DataRow row in tbl.Rows )
            {
                WaterUserClass u =  CreateWaterUser(row);
                wuc.Add(u);
            }
            return wuc;
        }
        #endregion //CreateLowLevelWaterUserCollection



        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private static float GetUnitPriceFromDataRow(DataRow row)
        {
            object obj = row["UnitPrice"];
            if (obj != DBNull.Value)
            {
                return Convert.ToSingle(obj);
            }
            return 0f;
        }

        #region CreateWaterUser
        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private static WaterUserClass CreateWaterUser(DataRow row)
        {
            int waterUserID = Convert.ToInt32(row["WaterUserID"]);
            int waterUserLevelID = Convert.ToInt32(row["WaterUserLevelID"]);
            int wuTypeID = Convert.ToInt32(row["WaterUserTypeID"]);
            string name = row["WaterUserName"].ToString();
            string remark = row["remark"].ToString();
            float unitPrice = GetUnitPriceFromDataRow(row);


            // TODO: 2011-04-08  
            // parent wateruser, wulevel, indevice ... 
            // init at get property
            // 
            // 2. dead loop
            //
            //WaterUserClass parentWaterUser = null;
            //object parentObject = row["ParentWaterUserID"];
            //if (parentObject != DBNull.Value)
            //{
            //    int parentID = Convert.ToInt32(row["ParentWaterUserID"]);
            //    if (parentID != waterUserID)
            //    {
            //        parentWaterUser = CreateWaterUserByID(parentID);
            //    }
            //}
            //wu.ParentWaterUser = CreateWaterUserByID(parentID);
            //wu.ParentWaterUser = parentWaterUser;

            WaterUserLevel wuLevel = WaterUserLevelFactory.CreateWaterUserLevelByID(waterUserLevelID);
            //WaterUserType
            WaterUserType wuType = WaterUserTypeFactory.CreateWaterUserTypeByID(wuTypeID);

            WaterUserClass wu = new WaterUserClass();
            wu.Name = name;
            wu.WaterUserID = waterUserID;
            wu.WaterUserLevel = wuLevel;
            wu.WaterUserType = wuType;
            wu.Remark = remark;
            wu.UnitPrice = unitPrice;


            wu.ChannelCollection = ChannelFactory.CreateChannelCollection(waterUserID);

            //wu.InStationCollection 
            //wu.InDeviceCollection = CreateInDevice
            //wu.OutStationCollection

            //wu.InDeviceCollection = DeviceFactory.CreateInDeviceCollection(waterUserID);
            //wu.OutDeviceCollection = DeviceFactory.CreateOutDeviceCollection(waterUserID);

            return wu;
        }
        #endregion //CreateWaterUser

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static WaterUserCollection CreateManagementWaterUserCollection()
        {
            WaterUserCollection wuc = new WaterUserCollection();
            DataTable tbl =  WaterUserDBI.GetManagementOrganization();

            foreach (DataRow row in tbl.Rows)
            {
                WaterUserClass wu = CreateWaterUser(row);
                wuc.Add(wu);
            }
            return wuc;
        }
    }

}

//using System;
//using System.Data;
//using System.Configuration;
//using System.Web;
//using System.Web.Security;
//using System.Web.UI;
//using System.Web.UI.HtmlControls;
//using System.Web.UI.WebControls;
//using System.Web.UI.WebControls.WebParts;

//namespace YongShuiGuanLiV2.DBNames
//{

//    /// <summary>
//    /// 
//    /// </summary>
//        #region tb_menu
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tb_menu
//        {
//            /// <summary>
//            /// table name: tb_menu
//            /// </summary>
//            public const string TABLE_NAME = "tb_menu";

//            /// <summary>
//            /// DB type: int identity
//            /// </summary>
//            public const string menu_id = "menu_id";

//            /// <summary>
//            /// DB type: varchar
//            /// </summary>
//            public const string name = "name";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string fatherid = "fatherid";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string seq = "seq";

//            /// <summary>
//            /// DB type: varchar
//            /// </summary>
//            public const string menulink = "menulink";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string role_type = "role_type";

//        }
//        #endregion //

//        #region tb_role
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tb_role
//        {
//            /// <summary>
//            /// table name: tb_role
//            /// </summary>
//            public const string TABLE_NAME = "tb_role";

//            /// <summary>
//            /// DB type: int identity
//            /// </summary>
//            public const string role_id = "role_id";

//            /// <summary>
//            /// DB type: varchar
//            /// </summary>
//            public const string rolename = "rolename";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string role_type = "role_type";

//            /// <summary>
//            /// DB type: varchar
//            /// </summary>
//            public const string remark = "remark";

//        }
//        #endregion //

//        #region tb_role_linkmenu
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tb_role_linkmenu
//        {
//            /// <summary>
//            /// table name: tb_role_linkmenu
//            /// </summary>
//            public const string TABLE_NAME = "tb_role_linkmenu";

//            /// <summary>
//            /// DB type: int identity
//            /// </summary>
//            public const string id = "id";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string role_id = "role_id";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string menu_id = "menu_id";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string father_id = "father_id";

//        }
//        #endregion //

//        #region tb_User
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tb_User
//        {
//            /// <summary>
//            /// table name: tb_User
//            /// </summary>
//            public const string TABLE_NAME = "tb_User";

//            /// <summary>
//            /// DB type: int identity
//            /// </summary>
//            public const string UserID = "UserID";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string Name = "Name";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string Password = "Password";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string role_id = "role_id";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string WaterUserID = "WaterUserID";

//        }
//        #endregion //

//        #region tblChannel
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tblChannel
//        {
//            /// <summary>
//            /// table name: tblChannel
//            /// </summary>
//            public const string TABLE_NAME = "tblChannel";

//            /// <summary>
//            /// DB type: int identity
//            /// </summary>
//            public const string ChannelID = "ChannelID";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string ChannelName = "ChannelName";

//            /// <summary>
//            /// DB type: bit
//            /// </summary>
//            public const string Deleted = "Deleted";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string Remark = "Remark";

//        }
//        #endregion //

//        #region tblChannelStationMap
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tblChannelStationMap
//        {
//            /// <summary>
//            /// table name: tblChannelStationMap
//            /// </summary>
//            public const string TABLE_NAME = "tblChannelStationMap";

//            /// <summary>
//            /// DB type: int identity
//            /// </summary>
//            public const string ChannelStationMapID = "ChannelStationMapID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string StationID = "StationID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string ChannelID = "ChannelID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string StationOrdinal = "StationOrdinal";

//        }
//        #endregion //

//        #region tblDBInfo
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tblDBInfo
//        {
//            /// <summary>
//            /// table name: tblDBInfo
//            /// </summary>
//            public const string TABLE_NAME = "tblDBInfo";

//            /// <summary>
//            /// DB type: int identity
//            /// </summary>
//            public const string DBInfoID = "DBInfoID";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string Project = "Project";

//            /// <summary>
//            /// DB type: datetime
//            /// </summary>
//            public const string DT = "DT";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string MajorVersion = "MajorVersion";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string MinorVersion = "MinorVersion";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string RevisionVersion = "RevisionVersion";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string Remark = "Remark";

//        }
//        #endregion //

//        #region tblDeivceDitch
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tblDeivceDitch
//        {
//            /// <summary>
//            /// table name: tblDeivceDitch
//            /// </summary>
//            public const string TABLE_NAME = "tblDeivceDitch";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string DeviceID = "DeviceID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string LowLimit = "LowLimit";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string HighLimit = "HighLimit";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string FluxFormula = "FluxFormula";

//        }
//        #endregion //

//        #region tblDevice
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tblDevice
//        {
//            /// <summary>
//            /// table name: tblDevice
//            /// </summary>
//            public const string TABLE_NAME = "tblDevice";

//            /// <summary>
//            /// DB type: int identity
//            /// </summary>
//            public const string DeviceID = "DeviceID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string StationID = "StationID";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string Name = "Name";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string Address = "Address";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string DeviceKind = "DeviceKind";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string DeviceType = "DeviceType";

//            /// <summary>
//            /// DB type: bit
//            /// </summary>
//            public const string Deleted = "Deleted";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string Remark = "Remark";

//        }
//        #endregion //

//        #region tblDeviceDitch
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tblDeviceDitch
//        {
//            /// <summary>
//            /// table name: tblDeviceDitch
//            /// </summary>
//            public const string TABLE_NAME = "tblDeviceDitch";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string DeviceID = "DeviceID";

//            /// <summary>
//            /// DB type: bit
//            /// </summary>
//            public const string HasWL1 = "HasWL1";

//            /// <summary>
//            /// DB type: bit
//            /// </summary>
//            public const string HasWL2 = "HasWL2";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string LowLimit = "LowLimit";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string HighLimit = "HighLimit";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string FluxFormula = "FluxFormula";

//        }
//        #endregion //

//        #region tblDeviceSluice
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tblDeviceSluice
//        {
//            /// <summary>
//            /// table name: tblDeviceSluice
//            /// </summary>
//            public const string TABLE_NAME = "tblDeviceSluice";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string DeviceID = "DeviceID";

//            /// <summary>
//            /// DB type: bit
//            /// </summary>
//            public const string HasBeforeWL = "HasBeforeWL";

//            /// <summary>
//            /// DB type: bit
//            /// </summary>
//            public const string HasBehindWL = "HasBehindWL";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string FluxFormula = "FluxFormula";

//        }
//        #endregion //

//        #region tblDistributeWater
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tblDistributeWater
//        {
//            /// <summary>
//            /// table name: tblDistributeWater
//            /// </summary>
//            public const string TABLE_NAME = "tblDistributeWater";

//            /// <summary>
//            /// DB type: int identity
//            /// </summary>
//            public const string DistributeWaterID = "DistributeWaterID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string NeedWaterID = "NeedWaterID";

//            /// <summary>
//            /// DB type: datetime
//            /// </summary>
//            public const string DistributeBeginDT = "DistributeBeginDT";

//            /// <summary>
//            /// DB type: datetime
//            /// </summary>
//            public const string DistributeEndDT = "DistributeEndDT";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string Remark = "Remark";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string DistributeAmount = "DistributeAmount";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string FromWaterSource = "FromWaterSource";

//        }
//        #endregion //

//        #region tblDitchData
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tblDitchData
//        {
//            /// <summary>
//            /// table name: tblDitchData
//            /// </summary>
//            public const string TABLE_NAME = "tblDitchData";

//            /// <summary>
//            /// DB type: int identity
//            /// </summary>
//            public const string DitchDataID = "DitchDataID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string DeviceID = "DeviceID";

//            /// <summary>
//            /// DB type: datetime
//            /// </summary>
//            public const string DT = "DT";

//            /// <summary>
//            /// DB type: smallint
//            /// </summary>
//            public const string WL1 = "WL1";

//            /// <summary>
//            /// DB type: smallint
//            /// </summary>
//            public const string WL2 = "WL2";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string InstantFlux = "InstantFlux";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string UsedAmount = "UsedAmount";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string Voltage = "Voltage";

//        }
//        #endregion //

//        #region tblDitchData2Hour
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tblDitchData2Hour
//        {
//            /// <summary>
//            /// table name: tblDitchData2Hour
//            /// </summary>
//            public const string TABLE_NAME = "tblDitchData2Hour";

//            /// <summary>
//            /// DB type: int identity
//            /// </summary>
//            public const string tblDitchData2HourID = "tblDitchData2HourID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string DeviceID = "DeviceID";

//            /// <summary>
//            /// DB type: datetime
//            /// </summary>
//            public const string DT = "DT";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string AVGWL = "AVGWL";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string AVGFlux = "AVGFlux";

//        }
//        #endregion //

//        #region tblDitchDataDay
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tblDitchDataDay
//        {
//            /// <summary>
//            /// table name: tblDitchDataDay
//            /// </summary>
//            public const string TABLE_NAME = "tblDitchDataDay";

//            /// <summary>
//            /// DB type: int identity
//            /// </summary>
//            public const string DitchDataDayID = "DitchDataDayID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string DeviceID = "DeviceID";

//            /// <summary>
//            /// DB type: datetime
//            /// </summary>
//            public const string DT = "DT";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string AVGWL = "AVGWL";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string AVGFlux = "AVGFlux";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string DayAmount = "DayAmount";

//        }
//        #endregion //

//        #region tblDitchDataLast
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tblDitchDataLast
//        {
//            /// <summary>
//            /// table name: tblDitchDataLast
//            /// </summary>
//            public const string TABLE_NAME = "tblDitchDataLast";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string DeviceID = "DeviceID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string DitchDataID = "DitchDataID";

//            /// <summary>
//            /// DB type: int identity
//            /// </summary>
//            public const string DitchDataLastID = "DitchDataLastID";

//        }
//        #endregion //

//        #region tblDitchDataReal
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tblDitchDataReal
//        {
//            /// <summary>
//            /// table name: tblDitchDataReal
//            /// </summary>
//            public const string TABLE_NAME = "tblDitchDataReal";

//            /// <summary>
//            /// DB type: int identity
//            /// </summary>
//            public const string DitchDataRealID = "DitchDataRealID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string DeviceID = "DeviceID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string DitchDataID = "DitchDataID";

//        }
//        #endregion //

//        #region tblDuringWater
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tblDuringWater
//        {
//            /// <summary>
//            /// table name: tblDuringWater
//            /// </summary>
//            public const string TABLE_NAME = "tblDuringWater";

//            /// <summary>
//            /// DB type: int identity
//            /// </summary>
//            public const string DuringWaterID = "DuringWaterID";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string Name = "Name";

//            /// <summary>
//            /// DB type: datetime
//            /// </summary>
//            public const string BeginDT = "BeginDT";

//            /// <summary>
//            /// DB type: datetime
//            /// </summary>
//            public const string EndDT = "EndDT";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string Remark = "Remark";

//        }
//        #endregion //

//        #region tblFee
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tblFee
//        {
//            /// <summary>
//            /// table name: tblFee
//            /// </summary>
//            public const string TABLE_NAME = "tblFee";

//            /// <summary>
//            /// DB type: int identity
//            /// </summary>
//            public const string FeeID = "FeeID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string WaterUserID = "WaterUserID";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string FeeName = "FeeName";

//            /// <summary>
//            /// DB type: datetime
//            /// </summary>
//            public const string BeginDT = "BeginDT";

//            /// <summary>
//            /// DB type: datetime
//            /// </summary>
//            public const string EndDT = "EndDT";

//            /// <summary>
//            /// DB type: smallmoney
//            /// </summary>
//            public const string UnitPrice = "UnitPrice";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string TotalPrice = "TotalPrice";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string WaterAmount = "WaterAmount";

//            /// <summary>
//            /// DB type: bit
//            /// </summary>
//            public const string Deleted = "Deleted";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string Remark = "Remark";

//        }
//        #endregion //

//        #region tblIn
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tblIn
//        {
//            /// <summary>
//            /// table name: tblIn
//            /// </summary>
//            public const string TABLE_NAME = "tblIn";

//            /// <summary>
//            /// DB type: int identity
//            /// </summary>
//            public const string InID = "InID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string WaterUserID = "WaterUserID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string DeviceID = "DeviceID";

//            /// <summary>
//            /// DB type: smallmoney
//            /// </summary>
//            public const string UnitPrice = "UnitPrice";

//        }
//        #endregion //

//        #region tblMeasureSluiceData
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tblMeasureSluiceData
//        {
//            /// <summary>
//            /// table name: tblMeasureSluiceData
//            /// </summary>
//            public const string TABLE_NAME = "tblMeasureSluiceData";

//            /// <summary>
//            /// DB type: int identity
//            /// </summary>
//            public const string MeasureSluiceDataID = "MeasureSluiceDataID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string DeviceID = "DeviceID";

//            /// <summary>
//            /// DB type: datetime
//            /// </summary>
//            public const string DT = "DT";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string BeforeWL = "BeforeWL";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string BehindWL = "BehindWL";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string InstantFlux = "InstantFlux";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string Height = "Height";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string RemainedAmount = "RemainedAmount";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string UsedAmount = "UsedAmount";

//        }
//        #endregion //

//        #region tblNeedWater
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tblNeedWater
//        {
//            /// <summary>
//            /// table name: tblNeedWater
//            /// </summary>
//            public const string TABLE_NAME = "tblNeedWater";

//            /// <summary>
//            /// DB type: int identity
//            /// </summary>
//            public const string NeedWaterID = "NeedWaterID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string WaterUserID = "WaterUserID";

//            /// <summary>
//            /// DB type: datetime
//            /// </summary>
//            public const string NeedBeginDT = "NeedBeginDT";

//            /// <summary>
//            /// DB type: datetime
//            /// </summary>
//            public const string NeedEndDT = "NeedEndDT";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string NeedAmount = "NeedAmount";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string ExpandInfo = "ExpandInfo";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string Remark = "Remark";

//        }
//        #endregion //

//        #region tblOut
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tblOut
//        {
//            /// <summary>
//            /// table name: tblOut
//            /// </summary>
//            public const string TABLE_NAME = "tblOut";

//            /// <summary>
//            /// DB type: int identity
//            /// </summary>
//            public const string OutID = "OutID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string WaterUserID = "WaterUserID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string DeviceID = "DeviceID";

//            /// <summary>
//            /// DB type: smallmoney
//            /// </summary>
//            public const string UnitPrice = "UnitPrice";

//        }
//        #endregion //

//        #region tblRainFillData
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tblRainFillData
//        {
//            /// <summary>
//            /// table name: tblRainFillData
//            /// </summary>
//            public const string TABLE_NAME = "tblRainFillData";

//            /// <summary>
//            /// DB type: int identity
//            /// </summary>
//            public const string RainFillDataID = "RainFillDataID";

//            /// <summary>
//            /// DB type: datetime
//            /// </summary>
//            public const string DT = "DT";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string RainFill = "RainFill";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string Remark = "Remark";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string DeviceID = "DeviceID";

//        }
//        #endregion //

//        #region tblSluiceData
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tblSluiceData
//        {
//            /// <summary>
//            /// table name: tblSluiceData
//            /// </summary>
//            public const string TABLE_NAME = "tblSluiceData";

//            /// <summary>
//            /// DB type: int identity
//            /// </summary>
//            public const string SluiceDataID = "SluiceDataID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string DeviceID = "DeviceID";

//            /// <summary>
//            /// DB type: datetime
//            /// </summary>
//            public const string DT = "DT";

//            /// <summary>
//            /// DB type: smallint
//            /// </summary>
//            public const string Height = "Height";

//            /// <summary>
//            /// DB type: smallint
//            /// </summary>
//            public const string BeforeWL = "BeforeWL";

//            /// <summary>
//            /// DB type: smallint
//            /// </summary>
//            public const string BehindWL = "BehindWL";

//        }
//        #endregion //

//        #region tblStation
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tblStation
//        {
//            /// <summary>
//            /// table name: tblStation
//            /// </summary>
//            public const string TABLE_NAME = "tblStation";

//            /// <summary>
//            /// DB type: int identity
//            /// </summary>
//            public const string StationID = "StationID";

//            /// <summary>
//            /// DB type: bit
//            /// </summary>
//            public const string Deleted = "Deleted";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string Name = "Name";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string Remark = "Remark";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string CommuniType = "CommuniType";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string CommuniTypeContent = "CommuniTypeContent";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string Ordinal = "Ordinal";

//            /// <summary>
//            /// DB type: bigint
//            /// </summary>
//            public const string CanalID = "CanalID";

//            /// <summary>
//            /// DB type: varchar
//            /// </summary>
//            public const string IrrID = "IrrID";

//        }
//        #endregion //

//        #region tblWaterLevelData
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tblWaterLevelData
//        {
//            /// <summary>
//            /// table name: tblWaterLevelData
//            /// </summary>
//            public const string TABLE_NAME = "tblWaterLevelData";

//            /// <summary>
//            /// DB type: int identity
//            /// </summary>
//            public const string WaterLevelDataID = "WaterLevelDataID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string DeviceID = "DeviceID";

//            /// <summary>
//            /// DB type: datetime
//            /// </summary>
//            public const string DT = "DT";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string BeforeWL = "BeforeWL";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string BehindWL = "BehindWL";

//        }
//        #endregion //

//        #region tblWaterUser
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tblWaterUser
//        {
//            /// <summary>
//            /// table name: tblWaterUser
//            /// </summary>
//            public const string TABLE_NAME = "tblWaterUser";

//            /// <summary>
//            /// DB type: int identity
//            /// </summary>
//            public const string WaterUserID = "WaterUserID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string ParentWaterUserID = "ParentWaterUserID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string WaterUserLevelID = "WaterUserLevelID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string WaterUserTypeID = "WaterUserTypeID";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string WaterUserName = "WaterUserName";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string WaterUserInfo = "WaterUserInfo";

//            /// <summary>
//            /// DB type: bit
//            /// </summary>
//            public const string Deleted = "Deleted";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string Remark = "Remark";

//        }
//        #endregion //

//        #region tblWaterUserChannelMap
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tblWaterUserChannelMap
//        {
//            /// <summary>
//            /// table name: tblWaterUserChannelMap
//            /// </summary>
//            public const string TABLE_NAME = "tblWaterUserChannelMap";

//            /// <summary>
//            /// DB type: int identity
//            /// </summary>
//            public const string WaterUserChannelMapID = "WaterUserChannelMapID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string ChannelID = "ChannelID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string WaterUserID = "WaterUserID";

//        }
//        #endregion //

//        #region tblWaterUserLevel
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tblWaterUserLevel
//        {
//            /// <summary>
//            /// table name: tblWaterUserLevel
//            /// </summary>
//            public const string TABLE_NAME = "tblWaterUserLevel";

//            /// <summary>
//            /// DB type: int identity
//            /// </summary>
//            public const string WaterUserLevelID = "WaterUserLevelID";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string WaterUserLevelName = "WaterUserLevelName";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string Ordinal = "Ordinal";

//            /// <summary>
//            /// DB type: bit
//            /// </summary>
//            public const string Deleted = "Deleted";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string Remark = "Remark";

//        }
//        #endregion //

//        #region tblWaterUserType
//        /// <summary>
//        /// 
//        /// </summary>
//        public class tblWaterUserType
//        {
//            /// <summary>
//            /// table name: tblWaterUserType
//            /// </summary>
//            public const string TABLE_NAME = "tblWaterUserType";

//            /// <summary>
//            /// DB type: int identity
//            /// </summary>
//            public const string WaterUserTypeID = "WaterUserTypeID";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string WaterUserTypeName = "WaterUserTypeName";

//            /// <summary>
//            /// DB type: char
//            /// </summary>
//            public const string WaterUserTypeRemark = "WaterUserTypeRemark";

//            ///// <summary>
//            ///// DB type: int
//            ///// </summary>
//            //public const string IsManager = "IsManager";

//        }
//        #endregion //

//        #region sysconstraints
//        /// <summary>
//        /// 
//        /// </summary>
//        public class sysconstraints
//        {
//            /// <summary>
//            /// table name: sysconstraints
//            /// </summary>
//            public const string TABLE_NAME = "sysconstraints";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string constid = "constid";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string id = "id";

//            /// <summary>
//            /// DB type: smallint
//            /// </summary>
//            public const string colid = "colid";

//            /// <summary>
//            /// DB type: tinyint
//            /// </summary>
//            public const string spare1 = "spare1";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string status = "status";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string actions = "actions";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string error = "error";

//        }
//        #endregion //

//        #region syssegments
//        /// <summary>
//        /// 
//        /// </summary>
//        public class syssegments
//        {
//            /// <summary>
//            /// table name: syssegments
//            /// </summary>
//            public const string TABLE_NAME = "syssegments";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string segment = "segment";

//            /// <summary>
//            /// DB type: varchar
//            /// </summary>
//            public const string name = "name";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string status = "status";

//        }
//        #endregion //

//        #region vDitchData
//        /// <summary>
//        /// 
//        /// </summary>
//        public class vDitchData
//        {
//            /// <summary>
//            /// table name: vDitchData
//            /// </summary>
//            public const string TABLE_NAME = "vDitchData";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string ChannelID = "ChannelID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string StationID = "StationID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string DeviceID = "DeviceID";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string ChannelName = "ChannelName";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string StationName = "StationName";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string StationOrdinal = "StationOrdinal";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string DeviceKind = "DeviceKind";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string DeviceType = "DeviceType";

//            /// <summary>
//            /// DB type: datetime
//            /// </summary>
//            public const string DT = "DT";

//            /// <summary>
//            /// DB type: smallint
//            /// </summary>
//            public const string WL1 = "WL1";

//            /// <summary>
//            /// DB type: smallint
//            /// </summary>
//            public const string WL2 = "WL2";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string InstantFlux = "InstantFlux";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string UsedAmount = "UsedAmount";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string Voltage = "Voltage";

//        }
//        #endregion //

//        #region vDitchData2Hour
//        /// <summary>
//        /// 
//        /// </summary>
//        public class vDitchData2Hour
//        {
//            /// <summary>
//            /// table name: vDitchData2Hour
//            /// </summary>
//            public const string TABLE_NAME = "vDitchData2Hour";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string ChannelName = "ChannelName";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string StationOrdinal = "StationOrdinal";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string StationName = "StationName";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string DeviceKind = "DeviceKind";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string DeviceType = "DeviceType";

//            /// <summary>
//            /// DB type: datetime
//            /// </summary>
//            public const string DT = "DT";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string AVGWL = "AVGWL";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string AVGFlux = "AVGFlux";

//        }
//        #endregion //

//        #region vDitchDataDay
//        /// <summary>
//        /// 
//        /// </summary>
//        public class vDitchDataDay
//        {
//            /// <summary>
//            /// table name: vDitchDataDay
//            /// </summary>
//            public const string TABLE_NAME = "vDitchDataDay";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string ChannelName = "ChannelName";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string StationName = "StationName";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string StationOrdinal = "StationOrdinal";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string DeviceKind = "DeviceKind";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string DeviceType = "DeviceType";

//            /// <summary>
//            /// DB type: datetime
//            /// </summary>
//            public const string DT = "DT";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string AVGWL = "AVGWL";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string AVGFlux = "AVGFlux";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string DayAmount = "DayAmount";

//        }
//        #endregion //

//        #region vDitchDataLast
//        /// <summary>
//        /// 
//        /// </summary>
//        public class vDitchDataLast
//        {
//            /// <summary>
//            /// table name: vDitchDataLast
//            /// </summary>
//            public const string TABLE_NAME = "vDitchDataLast";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string ChannelName = "ChannelName";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string StationName = "StationName";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string StationOrdinal = "StationOrdinal";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string DeviceType = "DeviceType";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string DeviceKind = "DeviceKind";

//            /// <summary>
//            /// DB type: datetime
//            /// </summary>
//            public const string DT = "DT";

//            /// <summary>
//            /// DB type: smallint
//            /// </summary>
//            public const string WL1 = "WL1";

//            /// <summary>
//            /// DB type: smallint
//            /// </summary>
//            public const string WL2 = "WL2";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string InstantFlux = "InstantFlux";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string UsedAmount = "UsedAmount";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string Voltage = "Voltage";

//        }
//        #endregion //

//        #region vDitchDataReal
//        /// <summary>
//        /// 
//        /// </summary>
//        public class vDitchDataReal
//        {
//            /// <summary>
//            /// table name: vDitchDataReal
//            /// </summary>
//            public const string TABLE_NAME = "vDitchDataReal";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string ChannelName = "ChannelName";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string StationName = "StationName";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string StationOrdinal = "StationOrdinal";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string DeviceKind = "DeviceKind";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string DeviceType = "DeviceType";

//            /// <summary>
//            /// DB type: datetime
//            /// </summary>
//            public const string DT = "DT";

//            /// <summary>
//            /// DB type: smallint
//            /// </summary>
//            public const string WL1 = "WL1";

//            /// <summary>
//            /// DB type: smallint
//            /// </summary>
//            public const string WL2 = "WL2";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string InstantFlux = "InstantFlux";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string UsedAmount = "UsedAmount";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string Voltage = "Voltage";

//        }
//        #endregion //

//        #region vRainFillData
//        /// <summary>
//        /// 
//        /// </summary>
//        public class vRainFillData
//        {
//            /// <summary>
//            /// table name: vRainFillData
//            /// </summary>
//            public const string TABLE_NAME = "vRainFillData";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string StationID = "StationID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string DeviceID = "DeviceID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string RainFillDataID = "RainFillDataID";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string Name = "Name";

//            /// <summary>
//            /// DB type: datetime
//            /// </summary>
//            public const string DT = "DT";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string RainFill = "RainFill";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string Remark = "Remark";

//        }
//        #endregion //

//        #region vRTDitchData
//        /// <summary>
//        /// 
//        /// </summary>
//        public class vRTDitchData
//        {
//            /// <summary>
//            /// table name: vRTDitchData
//            /// </summary>
//            public const string TABLE_NAME = "vRTDitchData";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string StationID = "StationID";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string Name = "Name";

//            /// <summary>
//            /// DB type: datetime
//            /// </summary>
//            public const string DT = "DT";

//            /// <summary>
//            /// DB type: smallint
//            /// </summary>
//            public const string WaterLevel = "WaterLevel";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string InstantFlux = "InstantFlux";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string UsedAmount = "UsedAmount";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string LeftMoney = "LeftMoney";

//        }
//        #endregion //

//        #region vRTDitchStation
//        /// <summary>
//        /// 
//        /// </summary>
//        public class vRTDitchStation
//        {
//            /// <summary>
//            /// table name: vRTDitchStation
//            /// </summary>
//            public const string TABLE_NAME = "vRTDitchStation";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string StationID = "StationID";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string Name = "Name";

//            /// <summary>
//            /// DB type: bigint
//            /// </summary>
//            public const string CanalID = "CanalID";

//            /// <summary>
//            /// DB type: varchar
//            /// </summary>
//            public const string IrrID = "IrrID";

//        }
//        #endregion //

//        #region vRTRainFillData
//        /// <summary>
//        /// 
//        /// </summary>
//        public class vRTRainFillData
//        {
//            /// <summary>
//            /// table name: vRTRainFillData
//            /// </summary>
//            public const string TABLE_NAME = "vRTRainFillData";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string StationID = "StationID";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string Name = "Name";

//            /// <summary>
//            /// DB type: datetime
//            /// </summary>
//            public const string DT = "DT";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string RainFill = "RainFill";

//        }
//        #endregion //

//        #region vRTRainFillStation
//        /// <summary>
//        /// 
//        /// </summary>
//        public class vRTRainFillStation
//        {
//            /// <summary>
//            /// table name: vRTRainFillStation
//            /// </summary>
//            public const string TABLE_NAME = "vRTRainFillStation";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string StationID = "StationID";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string Name = "Name";

//            /// <summary>
//            /// DB type: bigint
//            /// </summary>
//            public const string CanalID = "CanalID";

//            /// <summary>
//            /// DB type: varchar
//            /// </summary>
//            public const string IrrID = "IrrID";

//        }
//        #endregion //

//        #region vRTSluiceData
//        /// <summary>
//        /// 
//        /// </summary>
//        public class vRTSluiceData
//        {
//            /// <summary>
//            /// table name: vRTSluiceData
//            /// </summary>
//            public const string TABLE_NAME = "vRTSluiceData";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string StationID = "StationID";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string Name = "Name";

//            /// <summary>
//            /// DB type: smallint
//            /// </summary>
//            public const string Height = "Height";

//            /// <summary>
//            /// DB type: smallint
//            /// </summary>
//            public const string WaterLevel1 = "WaterLevel1";

//            /// <summary>
//            /// DB type: smallint
//            /// </summary>
//            public const string WaterLevel2 = "WaterLevel2";

//            /// <summary>
//            /// DB type: datetime
//            /// </summary>
//            public const string DT = "DT";

//        }
//        #endregion //

//        #region vRTSluiceStation
//        /// <summary>
//        /// 
//        /// </summary>
//        public class vRTSluiceStation
//        {
//            /// <summary>
//            /// table name: vRTSluiceStation
//            /// </summary>
//            public const string TABLE_NAME = "vRTSluiceStation";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string StationID = "StationID";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string Name = "Name";

//            /// <summary>
//            /// DB type: bigint
//            /// </summary>
//            public const string CanalID = "CanalID";

//            /// <summary>
//            /// DB type: varchar
//            /// </summary>
//            public const string IrrID = "IrrID";

//        }
//        #endregion //

//        #region vSluiceData
//        /// <summary>
//        /// 
//        /// </summary>
//        public class vSluiceData
//        {
//            /// <summary>
//            /// table name: vSluiceData
//            /// </summary>
//            public const string TABLE_NAME = "vSluiceData";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string StationID = "StationID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string DeviceID = "DeviceID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string SluiceDataID = "SluiceDataID";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string StationName = "StationName";

//            /// <summary>
//            /// DB type: datetime
//            /// </summary>
//            public const string DT = "DT";

//            /// <summary>
//            /// DB type: smallint
//            /// </summary>
//            public const string Height = "Height";

//            /// <summary>
//            /// DB type: smallint
//            /// </summary>
//            public const string BeforeWL = "BeforeWL";

//            /// <summary>
//            /// DB type: smallint
//            /// </summary>
//            public const string BehindWL = "BehindWL";

//        }
//        #endregion //

//        #region vStationDevice
//        /// <summary>
//        /// 
//        /// </summary>
//        public class vStationDevice
//        {
//            /// <summary>
//            /// table name: vStationDevice
//            /// </summary>
//            public const string TABLE_NAME = "vStationDevice";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string StationID = "StationID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string DeviceID = "DeviceID";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string StationName = "StationName";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string DeviceKind = "DeviceKind";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string DeviceType = "DeviceType";

//        }
//        #endregion //

//        #region vWaterLevelData
//        /// <summary>
//        /// 
//        /// </summary>
//        public class vWaterLevelData
//        {
//            /// <summary>
//            /// table name: vWaterLevelData
//            /// </summary>
//            public const string TABLE_NAME = "vWaterLevelData";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string WaterLevelDataID = "WaterLevelDataID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string StationID = "StationID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string DeviceID = "DeviceID";

//            /// <summary>
//            /// DB type: datetime
//            /// </summary>
//            public const string DT = "DT";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string BeforeWL = "BeforeWL";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string BehindWL = "BehindWL";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string DeviceType = "DeviceType";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string Name = "Name";

//        }
//        #endregion //

//        #region vWaterUser
//        /// <summary>
//        /// 
//        /// </summary>
//        public class vWaterUser
//        {
//            /// <summary>
//            /// table name: vWaterUser
//            /// </summary>
//            public const string TABLE_NAME = "vWaterUser";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string WaterUserID = "WaterUserID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string ParentWaterUserID = "ParentWaterUserID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string WaterUserTypeID = "WaterUserTypeID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string WaterUserLevelID = "WaterUserLevelID";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string WaterUserName = "WaterUserName";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string WaterUserLevelName = "WaterUserLevelName";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string WaterUserTypeName = "WaterUserTypeName";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string Ordinal = "Ordinal";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string Remark = "Remark";

//            /// <summary>
//            /// DB type: int
//            ///// </summary>
//            //public const string IsManager = "IsManager";

//        }
//        #endregion //

//        #region vWaterUserChannelStationDevice
//        /// <summary>
//        /// 
//        /// </summary>
//        public class vWaterUserChannelStationDevice
//        {
//            /// <summary>
//            /// table name: vWaterUserChannelStationDevice
//            /// </summary>
//            public const string TABLE_NAME = "vWaterUserChannelStationDevice";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string WaterUserID = "WaterUserID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string ChannelID = "ChannelID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string StationID = "StationID";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string DeviceID = "DeviceID";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string WaterUserName = "WaterUserName";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string WaterUserLevelName = "WaterUserLevelName";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string ChannelName = "ChannelName";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string StationName = "StationName";

//            /// <summary>
//            /// DB type: int
//            /// </summary>
//            public const string StationOrdinal = "StationOrdinal";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string DeviceKind = "DeviceKind";

//            /// <summary>
//            /// DB type: nvarchar
//            /// </summary>
//            public const string DeviceType = "DeviceType";

//        }
//        #endregion //

//}
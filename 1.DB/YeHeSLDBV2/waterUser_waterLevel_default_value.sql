/*
 * 2011-06-17
 * insert tblWaterUserLevel and tblWaterUsertype default values
 */
SET IDENTITY_INSERT tblWaterUserLevel ON
Insert tblWaterUserLevel (WaterUserLevelID,WaterUserLevelName,Ordinal,Deleted,Remark)  values ( 1,'管理局',5,0,NULL)
insert tblWaterUserLevel (WaterUserLevelID,WaterUserLevelName,Ordinal,Deleted,Remark)  values ( 2,'管理处',4,0,NULL)
insert tblWaterUserLevel (WaterUserLevelID,WaterUserLevelName,Ordinal,Deleted,Remark)  values ( 3,'管理所',3,0,NULL)
insert tblWaterUserLevel (WaterUserLevelID,WaterUserLevelName,Ordinal,Deleted,Remark)  values ( 4,'村',2,0,NULL)
insert tblWaterUserLevel (WaterUserLevelID,WaterUserLevelName,Ordinal,Deleted,Remark)  values ( 5,'斗口',1,0,NULL)
SET IDENTITY_INSERT tblWaterUserLevel OFF



SET IDENTITY_INSERT tblWaterUsertype ON
insert tblWaterUsertype (WaterUserTypeID,WaterUserTypeName,WaterUserTypeRemark)  values ( 1,'农业','')
insert tblWaterUsertype (WaterUserTypeID,WaterUserTypeName,WaterUserTypeRemark)  values ( 2,'工业','')
insert tblWaterUsertype (WaterUserTypeID,WaterUserTypeName,WaterUserTypeRemark)  values ( 3,'环境','')
insert tblWaterUsertype (WaterUserTypeID,WaterUserTypeName,WaterUserTypeRemark)  values ( 4,'其他','')
SET IDENTITY_INSERT tblWaterUsertype OFF

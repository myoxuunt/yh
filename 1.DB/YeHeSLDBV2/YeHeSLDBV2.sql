set quoted_identifier on 
GO

/****** Object:  User dbo    Script Date: 2012-08-16 09:36:52 ******/
/****** Object:  User guest    Script Date: 2012-08-16 09:36:52 ******/
if not exists (select * from dbo.sysusers where name = N'guest' and uid < 16382 and hasdbaccess = 1)
	EXEC sp_grantdbaccess N'guest'
GO

/****** Object:  Trigger dbo.insert_ditchdata_trigger    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[insert_ditchdata_trigger]') and OBJECTPROPERTY(id, N'IsTrigger') = 1)
drop trigger [dbo].[insert_ditchdata_trigger]
GO

/****** 对象:  用户定义的函数 dbo.Get10MinuteRow    脚本日期: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Get10MinuteRow]') and xtype in (N'FN', N'IF', N'TF'))
drop function [dbo].[Get10MinuteRow]
GO

/****** 对象:  用户定义的函数 dbo.f2    脚本日期: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[f2]') and xtype in (N'FN', N'IF', N'TF'))
drop function [dbo].[f2]
GO

/****** 对象:  用户定义的函数 dbo.F1    脚本日期: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[F1]') and xtype in (N'FN', N'IF', N'TF'))
drop function [dbo].[F1]
GO

/****** 对象:  用户定义的函数 dbo.Get10MinuteDateTime    脚本日期: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Get10MinuteDateTime]') and xtype in (N'FN', N'IF', N'TF'))
drop function [dbo].[Get10MinuteDateTime]
GO

/****** Object:  Stored Procedure dbo.Save10MinuteRow    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Save10MinuteRow]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[Save10MinuteRow]
GO

/****** Object:  Stored Procedure dbo.Create10MinuteDayRows    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Create10MinuteDayRows]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[Create10MinuteDayRows]
GO

/****** Object:  Stored Procedure dbo.CreateDitchDataDay    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CreateDitchDataDay]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[CreateDitchDataDay]
GO

/****** Object:  Stored Procedure dbo.CreateDitchDataHour    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CreateDitchDataHour]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[CreateDitchDataHour]
GO

/****** Object:  Stored Procedure dbo.Update10MinuteRow    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Update10MinuteRow]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[Update10MinuteRow]
GO

/****** Object:  Stored Procedure dbo.GetDBName    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GetDBName]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[GetDBName]
GO

/****** Object:  Stored Procedure dbo.GetDBVersion    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GetDBVersion]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[GetDBVersion]
GO

/****** Object:  Stored Procedure dbo.sp_getChild    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_getChild]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sp_getChild]
GO

/****** Object:  Stored Procedure dbo.sp_login    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_login]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sp_login]
GO

/****** Object:  View dbo.vDitchData10MinuteChangedLog    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vDitchData10MinuteChangedLog]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vDitchData10MinuteChangedLog]
GO

/****** Object:  View dbo.vDitchDataLast    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vDitchDataLast]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vDitchDataLast]
GO

/****** Object:  View dbo.vDitchDataReal    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vDitchDataReal]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vDitchDataReal]
GO

/****** Object:  View dbo.vDitchData    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vDitchData]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vDitchData]
GO

/****** Object:  View dbo.vDitchData2Hour    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vDitchData2Hour]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vDitchData2Hour]
GO

/****** Object:  View dbo.vDitchDataDay    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vDitchDataDay]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vDitchDataDay]
GO

/****** Object:  View dbo.vDitchDataDaySD    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vDitchDataDaySD]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vDitchDataDaySD]
GO

/****** Object:  View dbo.vDitchDataHour    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vDitchDataHour]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vDitchDataHour]
GO

/****** Object:  View dbo.vMeasureSluiceData    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vMeasureSluiceData]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vMeasureSluiceData]
GO

/****** Object:  View dbo.vRTSluiceData    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vRTSluiceData]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vRTSluiceData]
GO

/****** Object:  View dbo.vSluiceData    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vSluiceData]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vSluiceData]
GO

/****** Object:  View dbo.vWaterLevelData    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vWaterLevelData]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vWaterLevelData]
GO

/****** Object:  View dbo.vWaterUserChannelStationDevice    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vWaterUserChannelStationDevice]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vWaterUserChannelStationDevice]
GO

/****** Object:  View dbo.vDeviceType    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vDeviceType]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vDeviceType]
GO

/****** Object:  View dbo.vDistributeWater    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vDistributeWater]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vDistributeWater]
GO

/****** Object:  View dbo.vDitchDataSD    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vDitchDataSD]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vDitchDataSD]
GO

/****** Object:  View dbo.vFee    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vFee]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vFee]
GO

/****** Object:  View dbo.vRainFillData    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vRainFillData]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vRainFillData]
GO

/****** Object:  View dbo.vRTDitchData    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vRTDitchData]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vRTDitchData]
GO

/****** Object:  View dbo.vRTDitchStation    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vRTDitchStation]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vRTDitchStation]
GO

/****** Object:  View dbo.vRTRainFillData    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vRTRainFillData]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vRTRainFillData]
GO

/****** Object:  View dbo.vRTRainFillStation    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vRTRainFillStation]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vRTRainFillStation]
GO

/****** Object:  View dbo.vRTSluiceStation    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vRTSluiceStation]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vRTSluiceStation]
GO

/****** Object:  View dbo.vStationDevice    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vStationDevice]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vStationDevice]
GO

/****** Object:  View dbo.vUserWaterUser    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vUserWaterUser]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vUserWaterUser]
GO

/****** Object:  View dbo.vNeedWater    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vNeedWater]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vNeedWater]
GO

/****** Object:  View dbo.vWaterUser    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vWaterUser]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vWaterUser]
GO

/****** Object:  Table [dbo].[tblDitchData10MinuteChangeLog]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDitchData10MinuteChangeLog]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblDitchData10MinuteChangeLog]
GO

/****** Object:  Table [dbo].[tblDitchDataLast]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDitchDataLast]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblDitchDataLast]
GO

/****** Object:  Table [dbo].[tblDitchDataReal]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDitchDataReal]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblDitchDataReal]
GO

/****** Object:  Table [dbo].[tblAlarm]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblAlarm]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblAlarm]
GO

/****** Object:  Table [dbo].[tblChannelStationMap]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblChannelStationMap]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblChannelStationMap]
GO

/****** Object:  Table [dbo].[tblDeviceDitch]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDeviceDitch]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblDeviceDitch]
GO

/****** Object:  Table [dbo].[tblDeviceSluice]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDeviceSluice]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblDeviceSluice]
GO

/****** Object:  Table [dbo].[tblDitchData]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDitchData]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblDitchData]
GO

/****** Object:  Table [dbo].[tblDitchData10Minute]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDitchData10Minute]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblDitchData10Minute]
GO

/****** Object:  Table [dbo].[tblDitchData2Hour]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDitchData2Hour]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblDitchData2Hour]
GO

/****** Object:  Table [dbo].[tblDitchDataDay]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDitchDataDay]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblDitchDataDay]
GO

/****** Object:  Table [dbo].[tblDitchDataHour]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDitchDataHour]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblDitchDataHour]
GO

/****** Object:  Table [dbo].[tblFormula]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblFormula]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblFormula]
GO

/****** Object:  Table [dbo].[tblIn]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblIn]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblIn]
GO

/****** Object:  Table [dbo].[tblMeasureSluiceData]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblMeasureSluiceData]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblMeasureSluiceData]
GO

/****** Object:  Table [dbo].[tblOut]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblOut]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblOut]
GO

/****** Object:  Table [dbo].[tblRainFillData]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblRainFillData]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblRainFillData]
GO

/****** Object:  Table [dbo].[tblSluiceData]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblSluiceData]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblSluiceData]
GO

/****** Object:  Table [dbo].[tblWaterLevelData]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblWaterLevelData]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblWaterLevelData]
GO

/****** Object:  Table [dbo].[tblWaterUserChannelMap]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblWaterUserChannelMap]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblWaterUserChannelMap]
GO

/****** Object:  Table [dbo].[tb_role_linkmenu]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tb_role_linkmenu]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tb_role_linkmenu]
GO

/****** Object:  Table [dbo].[tb_User]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tb_User]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tb_User]
GO

/****** Object:  Table [dbo].[tblChannel]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblChannel]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblChannel]
GO

/****** Object:  Table [dbo].[tblDevice]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDevice]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblDevice]
GO

/****** Object:  Table [dbo].[tblDistributeWater]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDistributeWater]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblDistributeWater]
GO

/****** Object:  Table [dbo].[tblWaterUser]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblWaterUser]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblWaterUser]
GO

/****** Object:  Table [dbo].[tb_menu]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tb_menu]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tb_menu]
GO

/****** Object:  Table [dbo].[tb_role]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tb_role]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tb_role]
GO

/****** Object:  Table [dbo].[tblChannal]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblChannal]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblChannal]
GO

/****** Object:  Table [dbo].[tblChannelLevel]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblChannelLevel]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblChannelLevel]
GO

/****** Object:  Table [dbo].[tblConfig]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblConfig]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblConfig]
GO

/****** Object:  Table [dbo].[tblDBInfo]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDBInfo]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblDBInfo]
GO

/****** Object:  Table [dbo].[tblDeivceDitch]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDeivceDitch]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblDeivceDitch]
GO

/****** Object:  Table [dbo].[tbldevicealarm]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tbldevicealarm]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tbldevicealarm]
GO

/****** Object:  Table [dbo].[tblDuringWater]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDuringWater]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblDuringWater]
GO

/****** Object:  Table [dbo].[tblFee]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblFee]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblFee]
GO

/****** Object:  Table [dbo].[tblG1]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblG1]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblG1]
GO

/****** Object:  Table [dbo].[tblNeedWater]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblNeedWater]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblNeedWater]
GO

/****** Object:  Table [dbo].[tblStation]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblStation]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblStation]
GO

/****** Object:  Table [dbo].[tblWaterUserLevel]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblWaterUserLevel]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblWaterUserLevel]
GO

/****** Object:  Table [dbo].[tblWaterUserType]    Script Date: 2012-08-16 09:36:56 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblWaterUserType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblWaterUserType]
GO

/****** Object:  Table [dbo].[tb_menu]    Script Date: 2012-08-16 09:36:56 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tb_menu]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tb_menu] (
	[menu_id] [int] IDENTITY (1, 1) NOT NULL ,
	[name] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[fatherid] [int] NULL ,
	[seq] [int] NULL ,
	[menulink] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[role_type] [int] NULL 
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tb_role]    Script Date: 2012-08-16 09:36:57 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tb_role]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tb_role] (
	[role_id] [int] IDENTITY (1, 1) NOT NULL ,
	[rolename] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[role_type] [int] NULL ,
	[remark] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [PK_tb_role] PRIMARY KEY  CLUSTERED 
	(
		[role_id]
	)  ON [PRIMARY] 
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblChannal]    Script Date: 2012-08-16 09:36:57 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblChannal]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblChannal] (
	[ChannalID] [int] IDENTITY (1, 1) NOT NULL ,
	[WaterUserID] [int] NULL ,
	[ChannalName] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[Deleted] [bit] NULL ,
	[Remark] [nvarchar] (400) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblChannelLevel]    Script Date: 2012-08-16 09:36:57 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblChannelLevel]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblChannelLevel] (
	[ChannelLevelID] [int] IDENTITY (1, 1) NOT NULL ,
	[ChannelLevelName] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[ChannelLevelOrdinal] [int] NULL ,
	[ChannelLevelRemark] [nvarchar] (400) COLLATE Chinese_PRC_CI_AS NULL ,
	[ChannelLevelDeleted] [bit] NOT NULL CONSTRAINT [DF_tblChannelLevel_ChannelLevelDeleted] DEFAULT (0),
	CONSTRAINT [PK_tblChannelLevel] PRIMARY KEY  CLUSTERED 
	(
		[ChannelLevelID]
	)  ON [PRIMARY] 
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblConfig]    Script Date: 2012-08-16 09:36:57 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblConfig]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblConfig] (
	[ConfigID] [int] IDENTITY (1, 1) NOT NULL ,
	[ConfigName] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[ConfigValue] [nvarchar] (400) COLLATE Chinese_PRC_CI_AS NULL ,
	[ConfigRemark] [nvarchar] (400) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [PK_tblConfig] PRIMARY KEY  CLUSTERED 
	(
		[ConfigID]
	)  ON [PRIMARY] 
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblDBInfo]    Script Date: 2012-08-16 09:36:57 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDBInfo]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblDBInfo] (
	[DBInfoID] [int] IDENTITY (1, 1) NOT NULL ,
	[Project] [nvarchar] (255) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[DT] [datetime] NULL ,
	[MajorVersion] [int] NOT NULL CONSTRAINT [DF__tblDBInfo__Major__2B3F6F97] DEFAULT (0),
	[MinorVersion] [int] NOT NULL CONSTRAINT [DF__tblDBInfo__Minor__2C3393D0] DEFAULT (0),
	[RevisionVersion] [int] NOT NULL CONSTRAINT [DF__tblDBInfo__Revis__2D27B809] DEFAULT (0),
	[Remark] [nvarchar] (400) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [PK__tblDBInfo__038683F8] PRIMARY KEY  NONCLUSTERED 
	(
		[DBInfoID]
	)  ON [PRIMARY] 
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblDeivceDitch]    Script Date: 2012-08-16 09:36:57 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDeivceDitch]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblDeivceDitch] (
	[DeviceID] [int] NOT NULL ,
	[LowLimit] [int] NULL ,
	[HighLimit] [int] NULL ,
	[FluxFormula] [nvarchar] (1000) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tbldevicealarm]    Script Date: 2012-08-16 09:36:57 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tbldevicealarm]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tbldevicealarm] (
	[devicealarmid] [int] IDENTITY (1, 1) NOT NULL ,
	[deviceid] [int] NULL ,
	[high] [decimal](18, 2) NULL ,
	[low] [decimal](18, 2) NULL 
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblDuringWater]    Script Date: 2012-08-16 09:36:57 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDuringWater]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblDuringWater] (
	[DuringWaterID] [int] IDENTITY (1, 1) NOT NULL ,
	[Name] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[BeginDT] [datetime] NULL ,
	[EndDT] [datetime] NULL ,
	[Remark] [nvarchar] (1000) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [tblDuringWater_PK] PRIMARY KEY  CLUSTERED 
	(
		[DuringWaterID]
	)  ON [PRIMARY] 
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblFee]    Script Date: 2012-08-16 09:36:57 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblFee]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblFee] (
	[FeeID] [int] IDENTITY (1, 1) NOT NULL ,
	[WaterUserID] [int] NULL ,
	[FeeName] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[BeginDT] [datetime] NULL ,
	[EndDT] [datetime] NULL ,
	[NumberOfDay] [int] NULL ,
	[Deleted] [bit] NULL CONSTRAINT [DF__tblFee__Deleted__0BC6C43E] DEFAULT (0),
	[UnitPrice] [decimal](10, 4) NULL ,
	[WaterAmount] [decimal](10, 2) NULL ,
	[WaterLost] [decimal](18, 2) NULL ,
	[UsedWater] [decimal](18, 2) NULL ,
	[UsedPrice] [decimal](10, 2) NULL ,
	[PayPrice] [decimal](10, 2) NULL ,
	[LeftPrice] [decimal](10, 2) NULL ,
	[Remark] [nvarchar] (400) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [tblFee_PK] PRIMARY KEY  CLUSTERED 
	(
		[FeeID]
	)  ON [PRIMARY] 
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblG1]    Script Date: 2012-08-16 09:36:58 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblG1]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblG1] (
	[G1ID] [int] IDENTITY (1, 1) NOT NULL ,
	[Name] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Remark] [nvarchar] (400) COLLATE Chinese_PRC_CI_AS NULL ,
	[G2ID-changed] [int] NULL ,
	[remark333] [char] (10) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblNeedWater]    Script Date: 2012-08-16 09:36:58 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblNeedWater]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblNeedWater] (
	[NeedWaterID] [int] IDENTITY (1, 1) NOT NULL ,
	[WaterUserID] [int] NULL ,
	[NeedName] [nvarchar] (255) COLLATE Chinese_PRC_CI_AS NULL ,
	[NeedBeginDT] [datetime] NULL ,
	[NeedEndDT] [datetime] NULL ,
	[NeedAmount] [int] NULL ,
	[ExpandInfo] [nvarchar] (4000) COLLATE Chinese_PRC_CI_AS NULL ,
	[Remark] [nvarchar] (400) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [tblNeedWater_PK] PRIMARY KEY  CLUSTERED 
	(
		[NeedWaterID]
	)  ON [PRIMARY] 
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblStation]    Script Date: 2012-08-16 09:36:58 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblStation]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblStation] (
	[StationID] [int] IDENTITY (1, 1) NOT NULL ,
	[Deleted] [bit] NULL CONSTRAINT [DF__tblStatio__Delet__164452B1] DEFAULT (0),
	[Name] [nvarchar] (255) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[Remark] [nvarchar] (1000) COLLATE Chinese_PRC_CI_AS NULL ,
	[CommuniType] [int] NULL ,
	[CommuniTypeContent] [nvarchar] (1000) COLLATE Chinese_PRC_CI_AS NULL ,
	[Ordinal] [int] NULL ,
	[CanalID] [bigint] NOT NULL CONSTRAINT [DF__tblStatio__Canal__173876EA] DEFAULT (0),
	[IrrID] [varchar] (10) COLLATE Chinese_PRC_CI_AS NOT NULL CONSTRAINT [DF__tblStatio__IrrID__182C9B23] DEFAULT ('0'),
	[ChannalID] [int] NULL ,
	[G1ID] [int] NULL ,
	[Color] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [PK__tblStation__0D0FEE32] PRIMARY KEY  NONCLUSTERED 
	(
		[StationID]
	)  ON [PRIMARY] 
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblWaterUserLevel]    Script Date: 2012-08-16 09:36:58 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblWaterUserLevel]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblWaterUserLevel] (
	[WaterUserLevelID] [int] IDENTITY (1, 1) NOT NULL ,
	[WaterUserLevelName] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[Ordinal] [int] NOT NULL ,
	[Deleted] [bit] NULL CONSTRAINT [DF__tblWaterU__Delet__0425A276] DEFAULT (0),
	[Remark] [nvarchar] (400) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [tblWaterUserLevel_PK] PRIMARY KEY  CLUSTERED 
	(
		[WaterUserLevelID]
	)  ON [PRIMARY] 
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblWaterUserType]    Script Date: 2012-08-16 09:36:58 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblWaterUserType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblWaterUserType] (
	[WaterUserTypeID] [int] IDENTITY (1, 1) NOT NULL ,
	[WaterUserTypeName] [nvarchar] (255) COLLATE Chinese_PRC_CI_AS NULL ,
	[WaterUserTypeRemark] [char] (10) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [PK_tblWaterUserType] PRIMARY KEY  CLUSTERED 
	(
		[WaterUserTypeID]
	)  ON [PRIMARY] 
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tb_role_linkmenu]    Script Date: 2012-08-16 09:36:58 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tb_role_linkmenu]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tb_role_linkmenu] (
	[id] [int] IDENTITY (1, 1) NOT NULL ,
	[role_id] [int] NULL ,
	[menu_id] [int] NULL ,
	[father_id] [int] NULL ,
	CONSTRAINT [PK_tb_role_linkmenu] PRIMARY KEY  CLUSTERED 
	(
		[id]
	)  ON [PRIMARY] ,
	CONSTRAINT [FK_tb_role_linkmenu_tb_role] FOREIGN KEY 
	(
		[role_id]
	) REFERENCES [dbo].[tb_role] (
		[role_id]
	)
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tb_User]    Script Date: 2012-08-16 09:36:58 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tb_User]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tb_User] (
	[UserID] [int] IDENTITY (1, 1) NOT NULL ,
	[Name] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[Password] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[role_id] [int] NULL ,
	[WaterUserID] [int] NULL ,
	[Role] [int] NOT NULL CONSTRAINT [DF_tb_User_Role] DEFAULT (0),
	[AllowEdit] [bit] NOT NULL CONSTRAINT [DF_tb_User_AllowEdit] DEFAULT (0),
	[EditPassword] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [PK_tb_User] PRIMARY KEY  CLUSTERED 
	(
		[UserID]
	)  ON [PRIMARY] ,
	CONSTRAINT [FK_tb_User_tb_role] FOREIGN KEY 
	(
		[role_id]
	) REFERENCES [dbo].[tb_role] (
		[role_id]
	),
	CONSTRAINT [FK_tb_User_tb_role1] FOREIGN KEY 
	(
		[role_id]
	) REFERENCES [dbo].[tb_role] (
		[role_id]
	)
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblChannel]    Script Date: 2012-08-16 09:36:58 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblChannel]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblChannel] (
	[ChannelID] [int] IDENTITY (1, 1) NOT NULL ,
	[ChannelName] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[Deleted] [bit] NULL CONSTRAINT [DF__tblChanna__Delet__117F9D94] DEFAULT (0),
	[Remark] [nvarchar] (400) COLLATE Chinese_PRC_CI_AS NULL ,
	[ChannelLevelID] [int] NULL ,
	[ParentChannelID] [int] NULL ,
	CONSTRAINT [tblCanal_PK] PRIMARY KEY  CLUSTERED 
	(
		[ChannelID]
	)  ON [PRIMARY] ,
	CONSTRAINT [FK_tblChannel_tblChannelLevel] FOREIGN KEY 
	(
		[ChannelLevelID]
	) REFERENCES [dbo].[tblChannelLevel] (
		[ChannelLevelID]
	)
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblDevice]    Script Date: 2012-08-16 09:36:58 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDevice]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblDevice] (
	[DeviceID] [int] IDENTITY (1, 1) NOT NULL ,
	[StationID] [int] NULL ,
	[Name] [nvarchar] (255) COLLATE Chinese_PRC_CI_AS NULL ,
	[Address] [int] NULL ,
	[DeviceKind] [nvarchar] (255) COLLATE Chinese_PRC_CI_AS NULL ,
	[DeviceType] [nvarchar] (255) COLLATE Chinese_PRC_CI_AS NULL ,
	[Deleted] [bit] NULL CONSTRAINT [DF__tblDevice__Delet__267ABA7A] DEFAULT (0),
	[Remark] [nvarchar] (1000) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [PK__tblDevice__019E3B86] PRIMARY KEY  NONCLUSTERED 
	(
		[DeviceID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblStation_tblDevice_FK1] FOREIGN KEY 
	(
		[StationID]
	) REFERENCES [dbo].[tblStation] (
		[StationID]
	)
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblDistributeWater]    Script Date: 2012-08-16 09:36:58 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDistributeWater]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblDistributeWater] (
	[DistributeWaterID] [int] IDENTITY (1, 1) NOT NULL ,
	[NeedWaterID] [int] NULL ,
	[DistributeBeginDT] [datetime] NULL ,
	[DistributeEndDT] [datetime] NULL ,
	[Remark] [nvarchar] (400) COLLATE Chinese_PRC_CI_AS NULL ,
	[DistributeAmount] [int] NULL ,
	[FromWaterSource] [nvarchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [tblDistributeWater_PK] PRIMARY KEY  CLUSTERED 
	(
		[DistributeWaterID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblNeedWater_tblDistributeWater_FK1] FOREIGN KEY 
	(
		[NeedWaterID]
	) REFERENCES [dbo].[tblNeedWater] (
		[NeedWaterID]
	)
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblWaterUser]    Script Date: 2012-08-16 09:36:58 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblWaterUser]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblWaterUser] (
	[WaterUserID] [int] IDENTITY (1, 1) NOT NULL ,
	[ParentWaterUserID] [int] NULL ,
	[WaterUserLevelID] [int] NULL ,
	[WaterUserName] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[waterusertype] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[WaterUserInfo] [nvarchar] (1000) COLLATE Chinese_PRC_CI_AS NULL ,
	[Deleted] [bit] NULL CONSTRAINT [DF__tblWaterU__Delet__0EA330E9] DEFAULT (0),
	[Remark] [nvarchar] (400) COLLATE Chinese_PRC_CI_AS NULL ,
	[UnitPrice] [float] NULL ,
	[waterusertypeid] [int] NULL ,
	CONSTRAINT [PK_tblWaterUser] PRIMARY KEY  CLUSTERED 
	(
		[WaterUserID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblWaterUserLevel_tblWaterUser_FK1] FOREIGN KEY 
	(
		[WaterUserLevelID]
	) REFERENCES [dbo].[tblWaterUserLevel] (
		[WaterUserLevelID]
	)
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblAlarm]    Script Date: 2012-08-16 09:36:58 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblAlarm]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblAlarm] (
	[AlarmID] [int] IDENTITY (1, 1) NOT NULL ,
	[DeviceID] [int] NULL ,
	[HighLimit] [int] NULL ,
	[LowLimit] [int] NULL ,
	[Remark] [nvarchar] (400) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [PK_tblAlarm] PRIMARY KEY  CLUSTERED 
	(
		[AlarmID]
	)  ON [PRIMARY] ,
	CONSTRAINT [FK_tblAlarm_tblDevice] FOREIGN KEY 
	(
		[DeviceID]
	) REFERENCES [dbo].[tblDevice] (
		[DeviceID]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblChannelStationMap]    Script Date: 2012-08-16 09:36:59 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblChannelStationMap]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblChannelStationMap] (
	[ChannelStationMapID] [int] IDENTITY (1, 1) NOT NULL ,
	[StationID] [int] NULL ,
	[ChannelID] [int] NULL ,
	[StationOrdinal] [int] NULL ,
	CONSTRAINT [tblChannelStationMap_PK] PRIMARY KEY  CLUSTERED 
	(
		[ChannelStationMapID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblChannel_tblChannelStationMap_FK1] FOREIGN KEY 
	(
		[ChannelID]
	) REFERENCES [dbo].[tblChannel] (
		[ChannelID]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	CONSTRAINT [tblStation_tblChannelStationMap_FK1] FOREIGN KEY 
	(
		[StationID]
	) REFERENCES [dbo].[tblStation] (
		[StationID]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblDeviceDitch]    Script Date: 2012-08-16 09:36:59 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDeviceDitch]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblDeviceDitch] (
	[DeviceID] [int] NOT NULL ,
	[HasWL1] [bit] NULL ,
	[HasWL2] [bit] NULL ,
	[LowLimit] [int] NULL ,
	[HighLimit] [int] NULL ,
	[FluxFormula] [nvarchar] (1000) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [tblDeivceDitch_PK] PRIMARY KEY  CLUSTERED 
	(
		[DeviceID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblDevice_tblDeivceDitch_FK1] FOREIGN KEY 
	(
		[DeviceID]
	) REFERENCES [dbo].[tblDevice] (
		[DeviceID]
	) ON DELETE CASCADE 
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblDeviceSluice]    Script Date: 2012-08-16 09:36:59 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDeviceSluice]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblDeviceSluice] (
	[DeviceID] [int] NOT NULL ,
	[HasBeforeWL] [bit] NULL CONSTRAINT [DF__tblDevice__HasBe__22AA2996] DEFAULT (0),
	[HasBehindWL] [bit] NULL CONSTRAINT [DF__tblDevice__HasBe__239E4DCF] DEFAULT (0),
	[FluxFormula] [nvarchar] (1000) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [tblDeviceSluice_PK] PRIMARY KEY  CLUSTERED 
	(
		[DeviceID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblDevice_tblDeviceSluice_FK1] FOREIGN KEY 
	(
		[DeviceID]
	) REFERENCES [dbo].[tblDevice] (
		[DeviceID]
	) ON DELETE CASCADE 
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblDitchData]    Script Date: 2012-08-16 09:36:59 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDitchData]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblDitchData] (
	[DitchDataID] [int] IDENTITY (1, 1) NOT NULL ,
	[DeviceID] [int] NULL ,
	[DT] [datetime] NULL ,
	[WL1] [smallint] NULL ,
	[WL2] [smallint] NULL ,
	[InstantFlux] [real] NULL ,
	[UsedAmount] [int] NULL ,
	[Voltage] [int] NULL ,
	CONSTRAINT [tblWaterInfo_PK] PRIMARY KEY  NONCLUSTERED 
	(
		[DitchDataID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblDevice_tblDitchData_FK1] FOREIGN KEY 
	(
		[DeviceID]
	) REFERENCES [dbo].[tblDevice] (
		[DeviceID]
	)
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblDitchData10Minute]    Script Date: 2012-08-16 09:36:59 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDitchData10Minute]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblDitchData10Minute] (
	[DitchData10MinuteID] [int] IDENTITY (1, 1) NOT NULL ,
	[DeviceID] [int] NULL ,
	[DT] [datetime] NULL ,
	[WL1] [smallint] NULL CONSTRAINT [DF_tblDitchData10Minute_WL1] DEFAULT ((-10)),
	[WL2] [smallint] NULL CONSTRAINT [DF_tblDitchData10Minute_WL2] DEFAULT (0),
	[InstantFlux] [int] NULL CONSTRAINT [DF_tblDitchData10Minute_InstantFlux] DEFAULT (0),
	[UsedAmount] [int] NULL CONSTRAINT [DF_tblDitchData10Minute_UsedAmount] DEFAULT (0),
	[Voltage] [int] NULL ,
	CONSTRAINT [tblWaterInfo_PK_123] PRIMARY KEY  NONCLUSTERED 
	(
		[DitchData10MinuteID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblDevice_tblDitchData_FK1_123] FOREIGN KEY 
	(
		[DeviceID]
	) REFERENCES [dbo].[tblDevice] (
		[DeviceID]
	)
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblDitchData2Hour]    Script Date: 2012-08-16 09:36:59 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDitchData2Hour]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblDitchData2Hour] (
	[tblDitchData2HourID] [int] IDENTITY (1, 1) NOT NULL ,
	[DeviceID] [int] NULL ,
	[DT] [datetime] NULL ,
	[AVGWL] [int] NULL ,
	[AVGFlux] [int] NULL ,
	CONSTRAINT [PK_tblDitchData2Hour] PRIMARY KEY  CLUSTERED 
	(
		[tblDitchData2HourID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblDevice_tblDitchData2Hour_FK1] FOREIGN KEY 
	(
		[DeviceID]
	) REFERENCES [dbo].[tblDevice] (
		[DeviceID]
	)
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblDitchDataDay]    Script Date: 2012-08-16 09:36:59 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDitchDataDay]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblDitchDataDay] (
	[DitchDataDayID] [int] IDENTITY (1, 1) NOT NULL ,
	[DeviceID] [int] NULL ,
	[DT] [datetime] NULL ,
	[AVGWL] [int] NULL ,
	[AVGFlux] [int] NULL ,
	[DayAmount] [int] NULL ,
	CONSTRAINT [PK_tblDitchDataDay] PRIMARY KEY  CLUSTERED 
	(
		[DitchDataDayID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblDevice_tblDitchDataDay_FK1] FOREIGN KEY 
	(
		[DeviceID]
	) REFERENCES [dbo].[tblDevice] (
		[DeviceID]
	)
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblDitchDataHour]    Script Date: 2012-08-16 09:36:59 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDitchDataHour]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblDitchDataHour] (
	[DitchDataHourID] [int] IDENTITY (1, 1) NOT NULL ,
	[DeviceID] [int] NULL ,
	[DT] [datetime] NULL ,
	[AVGWL] [int] NULL ,
	[AVGFlux] [int] NULL ,
	[DayAmount] [int] NULL ,
	CONSTRAINT [FK_tblDitchDataHour_tblDevice] FOREIGN KEY 
	(
		[DeviceID]
	) REFERENCES [dbo].[tblDevice] (
		[DeviceID]
	)
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblFormula]    Script Date: 2012-08-16 09:36:59 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblFormula]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblFormula] (
	[FormulaID] [int] IDENTITY (1, 1) NOT NULL ,
	[DeviceID] [int] NULL ,
	[DTBegin] [datetime] NULL ,
	[DTEnd] [datetime] NULL ,
	[Formula] [nvarchar] (400) COLLATE Chinese_PRC_CI_AS NULL ,
	[Remark] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [PK_tblFormula] PRIMARY KEY  CLUSTERED 
	(
		[FormulaID]
	)  ON [PRIMARY] ,
	CONSTRAINT [FK_tblFormula_tblDevice] FOREIGN KEY 
	(
		[DeviceID]
	) REFERENCES [dbo].[tblDevice] (
		[DeviceID]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblIn]    Script Date: 2012-08-16 09:36:59 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblIn]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblIn] (
	[InID] [int] IDENTITY (1, 1) NOT NULL ,
	[WaterUserID] [int] NULL ,
	[DeviceID] [int] NULL ,
	[UnitPrice] [smallmoney] NULL ,
	CONSTRAINT [tblIn_PK] PRIMARY KEY  CLUSTERED 
	(
		[InID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblDevice_tblIn_FK1] FOREIGN KEY 
	(
		[DeviceID]
	) REFERENCES [dbo].[tblDevice] (
		[DeviceID]
	)
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblMeasureSluiceData]    Script Date: 2012-08-16 09:36:59 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblMeasureSluiceData]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblMeasureSluiceData] (
	[MeasureSluiceDataID] [int] IDENTITY (1, 1) NOT NULL ,
	[DeviceID] [int] NULL ,
	[DT] [datetime] NULL ,
	[BeforeWL] [int] NULL ,
	[BehindWL] [int] NULL ,
	[InstantFlux] [int] NULL ,
	[Height] [int] NULL ,
	[RemainedAmount] [int] NULL ,
	[UsedAmount] [int] NULL ,
	CONSTRAINT [PK_tblMeasureSlucieData] PRIMARY KEY  CLUSTERED 
	(
		[MeasureSluiceDataID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblDevice_tblMeasureSluiceData_FK1] FOREIGN KEY 
	(
		[DeviceID]
	) REFERENCES [dbo].[tblDevice] (
		[DeviceID]
	)
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblOut]    Script Date: 2012-08-16 09:36:59 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblOut]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblOut] (
	[OutID] [int] IDENTITY (1, 1) NOT NULL ,
	[WaterUserID] [int] NULL ,
	[DeviceID] [int] NULL ,
	[UnitPrice] [smallmoney] NULL ,
	CONSTRAINT [tblOut_PK] PRIMARY KEY  CLUSTERED 
	(
		[OutID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblDevice_tblOut_FK1] FOREIGN KEY 
	(
		[DeviceID]
	) REFERENCES [dbo].[tblDevice] (
		[DeviceID]
	)
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblRainFillData]    Script Date: 2012-08-16 09:36:59 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblRainFillData]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblRainFillData] (
	[RainFillDataID] [int] IDENTITY (1, 1) NOT NULL ,
	[DT] [datetime] NULL ,
	[RainFill] [real] NULL ,
	[Remark] [nvarchar] (400) COLLATE Chinese_PRC_CI_AS NULL ,
	[DeviceID] [int] NULL ,
	CONSTRAINT [PK_tblRainFillData] PRIMARY KEY  CLUSTERED 
	(
		[RainFillDataID]
	)  ON [PRIMARY] ,
	CONSTRAINT [FK_tblRainFillData_tblDevice] FOREIGN KEY 
	(
		[DeviceID]
	) REFERENCES [dbo].[tblDevice] (
		[DeviceID]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblSluiceData]    Script Date: 2012-08-16 09:36:59 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblSluiceData]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblSluiceData] (
	[SluiceDataID] [int] IDENTITY (1, 1) NOT NULL ,
	[DeviceID] [int] NULL ,
	[DT] [datetime] NULL ,
	[Height] [smallint] NULL ,
	[BeforeWL] [smallint] NULL ,
	[BehindWL] [smallint] NULL ,
	CONSTRAINT [tblSluiceData_PK] PRIMARY KEY  CLUSTERED 
	(
		[SluiceDataID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblDevice_tblSluiceData_FK1] FOREIGN KEY 
	(
		[DeviceID]
	) REFERENCES [dbo].[tblDevice] (
		[DeviceID]
	)
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblWaterLevelData]    Script Date: 2012-08-16 09:36:59 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblWaterLevelData]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblWaterLevelData] (
	[WaterLevelDataID] [int] IDENTITY (1, 1) NOT NULL ,
	[DeviceID] [int] NULL ,
	[DT] [datetime] NULL ,
	[BeforeWL] [int] NULL ,
	[BehindWL] [int] NULL ,
	CONSTRAINT [PK_tblWaterLevel] PRIMARY KEY  CLUSTERED 
	(
		[WaterLevelDataID]
	)  ON [PRIMARY] ,
	CONSTRAINT [FK_tblWaterLevelData_tblDevice] FOREIGN KEY 
	(
		[DeviceID]
	) REFERENCES [dbo].[tblDevice] (
		[DeviceID]
	)
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblWaterUserChannelMap]    Script Date: 2012-08-16 09:36:59 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblWaterUserChannelMap]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblWaterUserChannelMap] (
	[WaterUserChannelMapID] [int] IDENTITY (1, 1) NOT NULL ,
	[ChannelID] [int] NULL ,
	[WaterUserID] [int] NULL ,
	CONSTRAINT [tblWaterUserChannelMap_PK] PRIMARY KEY  CLUSTERED 
	(
		[WaterUserChannelMapID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblChannel_tblWaterUserChannelMap_FK1] FOREIGN KEY 
	(
		[ChannelID]
	) REFERENCES [dbo].[tblChannel] (
		[ChannelID]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblDitchData10MinuteChangeLog]    Script Date: 2012-08-16 09:37:00 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDitchData10MinuteChangeLog]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblDitchData10MinuteChangeLog] (
	[DitchData10MinuteChangeLogID] [int] IDENTITY (1, 1) NOT NULL ,
	[DitchData10MinuteID] [int] NOT NULL ,
	[ChangeDT] [datetime] NULL ,
	[LoginName] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[OldWL] [int] NULL ,
	[NewWL] [int] NULL ,
	CONSTRAINT [PK_tblDitchData10MinuteChangeLog] PRIMARY KEY  CLUSTERED 
	(
		[DitchData10MinuteChangeLogID]
	)  ON [PRIMARY] ,
	CONSTRAINT [FK_tblDitchData10MinuteChangeLog_tblDitchData10Minute] FOREIGN KEY 
	(
		[DitchData10MinuteID]
	) REFERENCES [dbo].[tblDitchData10Minute] (
		[DitchData10MinuteID]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblDitchDataLast]    Script Date: 2012-08-16 09:37:00 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDitchDataLast]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblDitchDataLast] (
	[DeviceID] [int] NOT NULL ,
	[DitchDataID] [int] NOT NULL ,
	[DitchDataLastID] [int] IDENTITY (1, 1) NOT NULL ,
	CONSTRAINT [tblDitchDataLast_PK] PRIMARY KEY  CLUSTERED 
	(
		[DitchDataLastID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblDevice_tblDitchDataLast_FK1] FOREIGN KEY 
	(
		[DeviceID]
	) REFERENCES [dbo].[tblDevice] (
		[DeviceID]
	),
	CONSTRAINT [tblDitchData_tblDitchDataLast_FK1] FOREIGN KEY 
	(
		[DitchDataID]
	) REFERENCES [dbo].[tblDitchData] (
		[DitchDataID]
	)
) ON [PRIMARY]
END

GO


/****** Object:  Table [dbo].[tblDitchDataReal]    Script Date: 2012-08-16 09:37:00 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDitchDataReal]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblDitchDataReal] (
	[DitchDataRealID] [int] IDENTITY (1, 1) NOT NULL ,
	[DeviceID] [int] NOT NULL ,
	[DitchDataID] [int] NOT NULL ,
	CONSTRAINT [tblDitchDataReal_PK] PRIMARY KEY  CLUSTERED 
	(
		[DitchDataRealID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblDevice_tblDitchDataReal_FK1] FOREIGN KEY 
	(
		[DeviceID]
	) REFERENCES [dbo].[tblDevice] (
		[DeviceID]
	),
	CONSTRAINT [tblDitchData_tblDitchDataReal_FK1] FOREIGN KEY 
	(
		[DitchDataID]
	) REFERENCES [dbo].[tblDitchData] (
		[DitchDataID]
	)
) ON [PRIMARY]
END

GO


SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  View dbo.vNeedWater    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  View dbo.vNeedWater    Script Date: 2011-11-17 14:18:03 ******/

/****** 对象: 视图 dbo.vNeedWater    脚本日期: 2011-6-17 9:48:33 ******/
CREATE VIEW dbo.vNeedWater
AS
SELECT dbo.tblWaterUser.WaterUserID, dbo.tblWaterUser.ParentWaterUserID, 
      dbo.tblNeedWater.NeedWaterID, dbo.tblNeedWater.NeedBeginDT, 
      dbo.tblNeedWater.NeedEndDT, dbo.tblNeedWater.NeedAmount, 
      dbo.tblNeedWater.ExpandInfo, dbo.tblNeedWater.Remark, 
      dbo.tblWaterUser.WaterUserName
FROM dbo.tblNeedWater INNER JOIN
      dbo.tblWaterUser ON 
      dbo.tblNeedWater.WaterUserID = dbo.tblWaterUser.WaterUserID
WHERE (dbo.tblWaterUser.Deleted <> 1)



GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  View dbo.vWaterUser    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  View dbo.vWaterUser    Script Date: 2011-11-17 14:18:03 ******/


/****** 对象: 视图 dbo.vWaterUser    脚本日期: 2011-6-17 9:48:33 ******/
/****** 对象: 视图 dbo.vWaterUser    脚本日期: 2011-04-27 16:40:18 *****
***** 对象: 视图 dbo.vWaterUser    脚本日期: 2011-03-23 15:16:23 *****
***** 对象: 视图 dbo.vWaterUser    脚本日期: 2011-03-17 14:57:08 *****
*/
CREATE  VIEW dbo.vWaterUser
AS
SELECT dbo.tblWaterUser.WaterUserID, dbo.tblWaterUser.ParentWaterUserID, 
      dbo.tblWaterUserType.WaterUserTypeID, dbo.tblWaterUser.WaterUserLevelID, 
      dbo.tblWaterUser.WaterUserName, dbo.tblWaterUserLevel.WaterUserLevelName, 
      dbo.tblWaterUserType.WaterUserTypeName, dbo.tblWaterUserLevel.Ordinal, 
      dbo.tblWaterUser.Remark, dbo.tblWaterUser.UnitPrice
FROM dbo.tblWaterUser INNER JOIN
      dbo.tblWaterUserLevel ON 
      dbo.tblWaterUser.WaterUserLevelID = dbo.tblWaterUserLevel.WaterUserLevelID INNER
       JOIN
      dbo.tblWaterUserType ON 
      dbo.tblWaterUser.WaterUserTypeID = dbo.tblWaterUserType.WaterUserTypeID
WHERE (dbo.tblWaterUserLevel.Deleted = 0) AND (dbo.tblWaterUser.Deleted = 0)




GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  View dbo.vDeviceType    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  View dbo.vDeviceType    Script Date: 2011-11-17 14:18:03 ******/
CREATE VIEW dbo.vDeviceType
AS
SELECT dbo.tblDevice.DeviceType, dbo.tblStation.Name AS station_name, 
      dbo.tblDevice.DeviceID
FROM dbo.tblStation INNER JOIN
      dbo.tblDevice ON dbo.tblStation.StationID = dbo.tblDevice.StationID


GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  View dbo.vDistributeWater    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  View dbo.vDistributeWater    Script Date: 2011-11-17 14:18:03 ******/

/****** 对象: 视图 dbo.vDistributeWater    脚本日期: 2011-6-17 9:48:33 ******/
CREATE VIEW dbo.vDistributeWater
AS
SELECT dbo.tblWaterUser.WaterUserID, dbo.tblWaterUser.WaterUserName, 
      dbo.tblNeedWater.NeedWaterID, dbo.tblDistributeWater.DistributeWaterID, 
      dbo.tblNeedWater.NeedBeginDT, dbo.tblNeedWater.NeedEndDT, 
      dbo.tblNeedWater.NeedAmount, dbo.tblDistributeWater.DistributeBeginDT, 
      dbo.tblDistributeWater.DistributeEndDT, 
      dbo.tblDistributeWater.DistributeAmount
FROM dbo.tblNeedWater INNER JOIN
      dbo.tblWaterUser ON 
      dbo.tblNeedWater.WaterUserID = dbo.tblWaterUser.WaterUserID INNER JOIN
      dbo.tblDistributeWater ON 
      dbo.tblNeedWater.NeedWaterID = dbo.tblDistributeWater.NeedWaterID



GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  View dbo.vDitchDataSD    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  View dbo.vDitchDataSD    Script Date: 2011-11-17 14:18:03 ******/

/****** 对象: 视图 dbo.vDitchDataSD    脚本日期: 2011-6-17 9:48:33 ******/
CREATE VIEW dbo.vDitchDataSD
AS
SELECT dbo.tblStation.StationID, dbo.tblDevice.DeviceID, 
      dbo.tblStation.Name AS StationName, dbo.tblDevice.DeviceKind, 
      dbo.tblDevice.DeviceType, dbo.tblDitchData.DT, dbo.tblDitchData.WL1, 
      dbo.tblDitchData.WL2, dbo.tblDitchData.InstantFlux, dbo.tblDitchData.UsedAmount, 
      dbo.tblDitchData.Voltage
FROM dbo.tblDevice INNER JOIN
      dbo.tblStation ON dbo.tblDevice.StationID = dbo.tblStation.StationID INNER JOIN
      dbo.tblDitchData ON dbo.tblDevice.DeviceID = dbo.tblDitchData.DeviceID
WHERE (dbo.tblStation.Deleted = 0) AND (dbo.tblDevice.Deleted = 0)



GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  View dbo.vFee    Script Date: 2012-08-16 09:37:00 ******/
/****** Object:  View dbo.vFee    Script Date: 2011-11-17 14:18:03 ******/
CREATE VIEW dbo.vFee
AS
SELECT dbo.tblWaterUser.WaterUserName, dbo.tblFee.*
FROM dbo.tblFee INNER JOIN
      dbo.tblWaterUser ON 
      dbo.tblFee.WaterUserID = dbo.tblWaterUser.WaterUserID
WHERE (dbo.tblWaterUser.Deleted <> 1)

GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  View dbo.vRainFillData    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  View dbo.vRainFillData    Script Date: 2011-11-17 14:18:03 ******/

/****** 对象: 视图 dbo.vRainFillData    脚本日期: 2011-6-17 9:48:33 ******/

/****** 对象: 视图 dbo.vRainFillData    脚本日期: 2011-04-27 16:40:18 ******/

/****** 对象: 视图 dbo.vRainFillData    脚本日期: 2011-03-23 15:16:23 ******/

/****** 对象: 视图 dbo.vRainFillData    脚本日期: 2011-03-17 14:57:09 ******/
CREATE VIEW dbo.vRainFillData  AS  SELECT dbo.tblStation.StationID, dbo.tblRainFillData.DeviceID,         dbo.tblRainFillData.RainFillDataID, dbo.tblStation.Name, dbo.tblRainFillData.DT,         dbo.tblRainFillData.RainFill, dbo.tblRainFillData.Remark  FROM dbo.tblDevice INNER JOIN        dbo.tblStation ON dbo.tblDevice.StationID = dbo.tblStation.StationID INNER JOIN        dbo.tblRainFillData ON         dbo.tblDevice.DeviceID = dbo.tblRainFillData.DeviceID  WHERE (dbo.tblDevice.Deleted = 0) AND (dbo.tblStation.Deleted = 0)      





GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  View dbo.vRTDitchData    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  View dbo.vRTDitchData    Script Date: 2011-11-17 14:18:03 ******/

/****** 对象: 视图 dbo.vRTDitchData    脚本日期: 2011-6-17 9:48:33 ******/

/****** 对象: 视图 dbo.vRTDitchData    脚本日期: 2011-04-27 16:40:18 ******/

/****** 对象: 视图 dbo.vRTDitchData    脚本日期: 2011-03-23 15:16:23 ******/

/****** 对象: 视图 dbo.vRTDitchData    脚本日期: 2011-03-17 14:57:09 ******/
CREATE VIEW dbo.vRTDitchData  AS  SELECT dbo.tblStation.StationID, dbo.tblStation.Name, dbo.tblDitchData.DT,         dbo.tblDitchData.WL1 AS WaterLevel, dbo.tblDitchData.InstantFlux,         dbo.tblDitchData.UsedAmount, 0 AS LeftMoney  FROM dbo.tblDevice INNER JOIN        dbo.tblStation ON dbo.tblDevice.StationID = dbo.tblStation.StationID INNER JOIN        dbo.tblDitchData ON dbo.tblDevice.DeviceID = dbo.tblDitchData.DeviceID  WHERE (dbo.tblDevice.Deleted = 0) AND (dbo.tblStation.Deleted = 0)      





GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  View dbo.vRTDitchStation    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  View dbo.vRTDitchStation    Script Date: 2011-11-17 14:18:03 ******/

/****** 对象: 视图 dbo.vRTDitchStation    脚本日期: 2011-6-17 9:48:33 ******/

/****** 对象: 视图 dbo.vRTDitchStation    脚本日期: 2011-04-27 16:40:18 ******/

/****** 对象: 视图 dbo.vRTDitchStation    脚本日期: 2011-03-23 15:16:23 ******/

/****** 对象: 视图 dbo.vRTDitchStation    脚本日期: 2011-03-17 14:57:08 ******/
CREATE VIEW dbo.vRTDitchStation  AS  SELECT dbo.tblStation.StationID, dbo.tblStation.Name, dbo.tblStation.CanalID,         dbo.tblStation.IrrID  FROM dbo.tblStation INNER JOIN        dbo.tblDevice ON dbo.tblStation.StationID = dbo.tblDevice.StationID  WHERE (dbo.tblStation.Deleted = 0) AND (dbo.tblDevice.Deleted = 0) AND         (dbo.tblDevice.DeviceType = 'XD221')      





GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  View dbo.vRTRainFillData    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  View dbo.vRTRainFillData    Script Date: 2011-11-17 14:18:03 ******/

/****** 对象: 视图 dbo.vRTRainFillData    脚本日期: 2011-6-17 9:48:33 ******/

/****** 对象: 视图 dbo.vRTRainFillData    脚本日期: 2011-04-27 16:40:18 ******/

/****** 对象: 视图 dbo.vRTRainFillData    脚本日期: 2011-03-23 15:16:23 ******/

/****** 对象: 视图 dbo.vRTRainFillData    脚本日期: 2011-03-17 14:57:09 ******/
CREATE VIEW dbo.vRTRainFillData  AS  SELECT dbo.tblStation.StationID, dbo.tblStation.Name, dbo.tblRainFillData.DT,         dbo.tblRainFillData.RainFill  FROM dbo.tblDevice INNER JOIN        dbo.tblStation ON dbo.tblDevice.StationID = dbo.tblStation.StationID INNER JOIN        dbo.tblRainFillData ON         dbo.tblDevice.DeviceID = dbo.tblRainFillData.DeviceID  WHERE (dbo.tblDevice.Deleted = 0) AND (dbo.tblStation.Deleted = 0)      





GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  View dbo.vRTRainFillStation    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  View dbo.vRTRainFillStation    Script Date: 2011-11-17 14:18:03 ******/

/****** 对象: 视图 dbo.vRTRainFillStation    脚本日期: 2011-6-17 9:48:33 ******/

/****** 对象: 视图 dbo.vRTRainFillStation    脚本日期: 2011-04-27 16:40:18 ******/

/****** 对象: 视图 dbo.vRTRainFillStation    脚本日期: 2011-03-23 15:16:23 ******/

/****** 对象: 视图 dbo.vRTRainFillStation    脚本日期: 2011-03-17 14:57:08 ******/
CREATE VIEW dbo.vRTRainFillStation  AS  SELECT dbo.tblStation.StationID, dbo.tblStation.Name, dbo.tblStation.CanalID,         dbo.tblStation.IrrID  FROM dbo.tblStation INNER JOIN        dbo.tblDevice ON dbo.tblStation.StationID = dbo.tblDevice.StationID  WHERE (dbo.tblStation.Deleted = 0) AND (dbo.tblDevice.Deleted = 0) AND         (dbo.tblDevice.DeviceType = 'RF')      





GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  View dbo.vRTSluiceStation    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  View dbo.vRTSluiceStation    Script Date: 2011-11-17 14:18:03 ******/

/****** 对象: 视图 dbo.vRTSluiceStation    脚本日期: 2011-6-17 9:48:33 ******/

/****** 对象: 视图 dbo.vRTSluiceStation    脚本日期: 2011-04-27 16:40:18 ******/

/****** 对象: 视图 dbo.vRTSluiceStation    脚本日期: 2011-03-23 15:16:23 ******/

/****** 对象: 视图 dbo.vRTSluiceStation    脚本日期: 2011-03-17 14:57:08 ******/
CREATE VIEW dbo.vRTSluiceStation  AS  SELECT dbo.tblStation.StationID, dbo.tblStation.Name, dbo.tblStation.CanalID,         dbo.tblStation.IrrID  FROM dbo.tblStation INNER JOIN        dbo.tblDevice ON dbo.tblStation.StationID = dbo.tblDevice.StationID  WHERE (dbo.tblStation.Deleted = 0) AND (dbo.tblDevice.Deleted = 0) AND         (dbo.tblDevice.DeviceType = 'XD100')      





GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  View dbo.vStationDevice    Script Date: 2012-08-16 09:37:00 ******/
/****** Object:  View dbo.vStationDevice    Script Date: 2011-11-17 14:18:03 *****
***** 对象: 视图 dbo.vStationDevice    脚本日期: 2011-6-17 9:48:33 *****
***** 对象: 视图 dbo.vStationDevice    脚本日期: 2011-04-27 16:40:18 ******/
CREATE VIEW dbo.vStationDevice
AS
SELECT dbo.tblStation.StationID, dbo.tblDevice.DeviceID, 
      dbo.tblStation.Name AS StationName, dbo.tblDevice.DeviceKind, 
      dbo.tblDevice.DeviceType, dbo.tblStation.Color
FROM dbo.tblStation INNER JOIN
      dbo.tblDevice ON dbo.tblStation.StationID = dbo.tblDevice.StationID
WHERE (dbo.tblStation.Deleted = 0) AND (dbo.tblDevice.Deleted = 0)

GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  View dbo.vUserWaterUser    Script Date: 2012-08-16 09:37:00 ******/
/****** Object:  View dbo.vUserWaterUser    Script Date: 2011-11-17 14:18:03 *****
***** 对象: 视图 dbo.vUserWaterUser    脚本日期: 2011-6-17 9:48:33 ******/
CREATE VIEW dbo.vUserWaterUser
AS
SELECT dbo.tb_User.UserID, dbo.tb_User.Name, dbo.tb_User.Password, 
      dbo.tblWaterUser.WaterUserID, dbo.tblWaterUser.WaterUserName, 
      dbo.tb_User.Role, dbo.tb_User.AllowEdit, dbo.tb_User.EditPassword
FROM dbo.tb_User INNER JOIN
      dbo.tblWaterUser ON dbo.tb_User.WaterUserID = dbo.tblWaterUser.WaterUserID

GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  View dbo.vDitchData    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  View dbo.vDitchData    Script Date: 2011-11-17 14:18:03 ******/
/****** 对象: 视图 dbo.vDitchData    脚本日期: 2011-6-17 9:48:33 *****
***** 对象: 视图 dbo.vDitchData    脚本日期: 2011-04-27 16:40:18 *****
***** 对象: 视图 dbo.vDitchData    脚本日期: 2011-03-23 15:16:23 *****
***** 对象: 视图 dbo.vDitchData    脚本日期: 2011-03-17 14:57:08 *****
*/
CREATE VIEW dbo.vDitchData
AS
SELECT dbo.tblChannel.ChannelID, dbo.tblStation.StationID, dbo.tblDevice.DeviceID, 
      dbo.tblChannel.ChannelName, dbo.tblStation.Name AS StationName, 
      dbo.tblChannelStationMap.StationOrdinal, dbo.tblDevice.DeviceKind, 
      dbo.tblDevice.DeviceType, dbo.tblDitchData.DitchDataID, dbo.tblDitchData.DT, 
      dbo.tblDitchData.WL1, dbo.tblDitchData.WL2, dbo.tblDitchData.InstantFlux, 
      dbo.tblDitchData.UsedAmount, dbo.tblDitchData.Voltage
FROM dbo.tblChannel INNER JOIN
      dbo.tblChannelStationMap ON 
      dbo.tblChannel.ChannelID = dbo.tblChannelStationMap.ChannelID INNER JOIN
      dbo.tblStation ON 
      dbo.tblChannelStationMap.StationID = dbo.tblStation.StationID INNER JOIN
      dbo.tblDevice ON dbo.tblStation.StationID = dbo.tblDevice.StationID INNER JOIN
      dbo.tblDitchData ON dbo.tblDevice.DeviceID = dbo.tblDitchData.DeviceID
WHERE (dbo.tblChannel.Deleted = 0) AND (dbo.tblStation.Deleted = 0) AND 
      (dbo.tblDevice.Deleted = 0)


GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  View dbo.vDitchData2Hour    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  View dbo.vDitchData2Hour    Script Date: 2011-11-17 14:18:03 ******/

/****** 对象: 视图 dbo.vDitchData2Hour    脚本日期: 2011-6-17 9:48:33 ******/

/****** 对象: 视图 dbo.vDitchData2Hour    脚本日期: 2011-04-27 16:40:18 ******/
/****** 对象: 视图 dbo.vDitchData2Hour    脚本日期: 2011-03-23 15:16:23 *****
***** 对象: 视图 dbo.vDitchData2Hour    脚本日期: 2011-03-17 14:57:09 ******/
CREATE VIEW dbo.vDitchData2Hour
AS
SELECT dbo.tblChannel.ChannelName, dbo.tblChannelStationMap.StationOrdinal, 
      dbo.tblStation.Name AS StationName, dbo.tblDevice.DeviceKind, 
      dbo.tblDevice.DeviceType, dbo.tblDitchData2Hour.DT, dbo.tblDitchData2Hour.AVGWL, 
      dbo.tblDitchData2Hour.AVGFlux
FROM dbo.tblDevice INNER JOIN
      dbo.tblStation ON dbo.tblDevice.StationID = dbo.tblStation.StationID INNER JOIN
      dbo.tblChannelStationMap ON 
      dbo.tblStation.StationID = dbo.tblChannelStationMap.StationID INNER JOIN
      dbo.tblChannel ON 
      dbo.tblChannelStationMap.ChannelID = dbo.tblChannel.ChannelID INNER JOIN
      dbo.tblDitchData2Hour ON 
      dbo.tblDevice.DeviceID = dbo.tblDitchData2Hour.DeviceID
WHERE (dbo.tblStation.Deleted = 0) AND (dbo.tblDevice.Deleted = 0) AND 
      (dbo.tblChannel.Deleted = 0)




GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  View dbo.vDitchDataDay    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  View dbo.vDitchDataDay    Script Date: 2011-11-17 14:18:03 ******/
/****** 对象: 视图 dbo.vDitchDataDay    脚本日期: 2011-6-17 9:48:33 *****
***** 对象: 视图 dbo.vDitchDataDay    脚本日期: 2011-04-27 16:40:18 *****
***** 对象: 视图 dbo.vDitchDataDay    脚本日期: 2011-03-23 15:16:23 *****
***** 对象: 视图 dbo.vDitchDataDay    脚本日期: 2011-03-17 14:57:09 ******/
CREATE VIEW dbo.vDitchDataDay
AS
SELECT dbo.tblChannel.ChannelName, dbo.tblStation.Name AS StationName, 
      dbo.tblChannelStationMap.StationOrdinal, dbo.tblDevice.DeviceKind, 
      dbo.tblDevice.DeviceType, dbo.tblDitchDataDay.DT, dbo.tblDitchDataDay.AVGWL, 
      dbo.tblDitchDataDay.AVGFlux, dbo.tblDitchDataDay.DayAmount, 
      dbo.tblChannel.ChannelID, dbo.tblStation.StationID, dbo.tblDevice.DeviceID
FROM dbo.tblChannel INNER JOIN
      dbo.tblChannelStationMap ON 
      dbo.tblChannel.ChannelID = dbo.tblChannelStationMap.ChannelID INNER JOIN
      dbo.tblStation ON 
      dbo.tblChannelStationMap.StationID = dbo.tblStation.StationID INNER JOIN
      dbo.tblDevice ON dbo.tblStation.StationID = dbo.tblDevice.StationID INNER JOIN
      dbo.tblDitchDataDay ON 
      dbo.tblDevice.DeviceID = dbo.tblDitchDataDay.DeviceID
WHERE (dbo.tblChannel.Deleted = 0) AND (dbo.tblDevice.Deleted = 0) AND 
      (dbo.tblStation.Deleted = 0)


GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  View dbo.vDitchDataDaySD    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  View dbo.vDitchDataDaySD    Script Date: 2011-11-17 14:18:03 ******/

/****** 对象: 视图 dbo.vDitchDataDaySD    脚本日期: 2011-6-17 9:48:33 ******/
CREATE VIEW dbo.vDitchDataDaySD
AS
SELECT dbo.tblStation.Name AS StationName, dbo.tblDevice.DeviceKind, 
      dbo.tblDevice.DeviceType, dbo.tblDitchDataDay.DT, dbo.tblDitchDataDay.AVGWL, 
      dbo.tblDitchDataDay.AVGFlux, dbo.tblDitchDataDay.DayAmount, 
      dbo.tblStation.StationID, dbo.tblDevice.DeviceID
FROM dbo.tblStation INNER JOIN
      dbo.tblDevice ON dbo.tblStation.StationID = dbo.tblDevice.StationID INNER JOIN
      dbo.tblDitchDataDay ON 
      dbo.tblDevice.DeviceID = dbo.tblDitchDataDay.DeviceID
WHERE (dbo.tblDevice.Deleted = 0) AND (dbo.tblStation.Deleted = 0)



GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  View dbo.vDitchDataHour    Script Date: 2012-08-16 09:37:00 ******/
CREATE VIEW dbo.vDitchDataHour
AS
SELECT dbo.tblChannel.ChannelName, dbo.tblStation.Name AS StationName, 
      dbo.tblChannelStationMap.StationOrdinal, dbo.tblDevice.DeviceKind, 
      dbo.tblDevice.DeviceType, dbo.tblChannel.ChannelID, dbo.tblStation.StationID, 
      dbo.tblDevice.DeviceID, dbo.tblDitchDataHour.DT, dbo.tblDitchDataHour.AVGWL, 
      dbo.tblDitchDataHour.AVGFlux, dbo.tblDitchDataHour.DayAmount
FROM dbo.tblChannel INNER JOIN
      dbo.tblChannelStationMap ON 
      dbo.tblChannel.ChannelID = dbo.tblChannelStationMap.ChannelID INNER JOIN
      dbo.tblStation ON 
      dbo.tblChannelStationMap.StationID = dbo.tblStation.StationID INNER JOIN
      dbo.tblDevice ON dbo.tblStation.StationID = dbo.tblDevice.StationID INNER JOIN
      dbo.tblDitchDataHour ON 
      dbo.tblDevice.DeviceID = dbo.tblDitchDataHour.DeviceID
WHERE (dbo.tblChannel.Deleted = 0) AND (dbo.tblDevice.Deleted = 0) AND 
      (dbo.tblStation.Deleted = 0)

GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  View dbo.vMeasureSluiceData    Script Date: 2012-08-16 09:37:00 ******/
CREATE VIEW dbo.vMeasureSluiceData
AS
SELECT dbo.tblStation.StationID, dbo.tblDevice.DeviceID, 
      dbo.tblStation.Name AS StationName, 
      dbo.tblMeasureSluiceData.MeasureSluiceDataID, dbo.tblMeasureSluiceData.DT, 
      dbo.tblMeasureSluiceData.BeforeWL, dbo.tblMeasureSluiceData.BehindWL, 
      dbo.tblMeasureSluiceData.InstantFlux, dbo.tblMeasureSluiceData.Height
FROM dbo.tblStation INNER JOIN
      dbo.tblDevice ON dbo.tblStation.StationID = dbo.tblDevice.StationID INNER JOIN
      dbo.tblMeasureSluiceData ON 
      dbo.tblDevice.DeviceID = dbo.tblMeasureSluiceData.DeviceID
WHERE (dbo.tblStation.Deleted = 0) AND (dbo.tblDevice.Deleted = 0)

GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  View dbo.vRTSluiceData    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  View dbo.vRTSluiceData    Script Date: 2011-11-17 14:18:03 ******/

/****** 对象: 视图 dbo.vRTSluiceData    脚本日期: 2011-6-17 9:48:33 ******/

/****** 对象: 视图 dbo.vRTSluiceData    脚本日期: 2011-04-27 16:40:18 ******/

/****** 对象: 视图 dbo.vRTSluiceData    脚本日期: 2011-03-23 15:16:23 ******/

/****** 对象: 视图 dbo.vRTSluiceData    脚本日期: 2011-03-17 14:57:09 ******/
CREATE VIEW dbo.vRTSluiceData  AS  SELECT dbo.tblStation.StationID, dbo.tblStation.Name, dbo.tblSluiceData.Height,         dbo.tblSluiceData.BeforeWL AS WaterLevel1,         dbo.tblSluiceData.BehindWL AS WaterLevel2, dbo.tblSluiceData.DT  FROM dbo.tblDevice INNER JOIN        dbo.tblStation ON dbo.tblDevice.StationID = dbo.tblStation.StationID INNER JOIN        dbo.tblSluiceData ON dbo.tblDevice.DeviceID = dbo.tblSluiceData.DeviceID  WHERE (dbo.tblDevice.Deleted = 0) AND (dbo.tblStation.Deleted = 0)      





GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  View dbo.vSluiceData    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  View dbo.vSluiceData    Script Date: 2011-11-17 14:18:03 ******/

/****** 对象: 视图 dbo.vSluiceData    脚本日期: 2011-6-17 9:48:33 ******/

/****** 对象: 视图 dbo.vSluiceData    脚本日期: 2011-04-27 16:40:18 ******/

/****** 对象: 视图 dbo.vSluiceData    脚本日期: 2011-03-23 15:16:23 ******/

/****** 对象: 视图 dbo.vSluiceData    脚本日期: 2011-03-17 14:57:09 ******/
CREATE VIEW dbo.vSluiceData  AS  SELECT dbo.tblStation.StationID, dbo.tblDevice.DeviceID, dbo.tblSluiceData.SluiceDataID,         dbo.tblStation.Name AS StationName, dbo.tblSluiceData.DT, dbo.tblSluiceData.Height,         dbo.tblSluiceData.BeforeWL, dbo.tblSluiceData.BehindWL  FROM dbo.tblStation INNER JOIN        dbo.tblDevice ON dbo.tblStation.StationID = dbo.tblDevice.StationID INNER JOIN        dbo.tblSluiceData ON dbo.tblDevice.DeviceID = dbo.tblSluiceData.DeviceID      





GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  View dbo.vWaterLevelData    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  View dbo.vWaterLevelData    Script Date: 2011-11-17 14:18:03 ******/

/****** 对象: 视图 dbo.vWaterLevelData    脚本日期: 2011-6-17 9:48:33 ******/

/****** 对象: 视图 dbo.vWaterLevelData    脚本日期: 2011-04-27 16:40:18 ******/

/****** 对象: 视图 dbo.vWaterLevelData    脚本日期: 2011-03-23 15:16:23 ******/

/****** 对象: 视图 dbo.vWaterLevelData    脚本日期: 2011-03-17 14:57:09 ******/
CREATE VIEW dbo.vWaterLevelData  AS  SELECT dbo.tblWaterLevelData.WaterLevelDataID, dbo.tblStation.StationID,         dbo.tblWaterLevelData.DeviceID, dbo.tblWaterLevelData.DT,         dbo.tblWaterLevelData.BeforeWL, dbo.tblWaterLevelData.BehindWL,         dbo.tblDevice.DeviceType, dbo.tblStation.Name  FROM dbo.tblWaterLevelData INNER JOIN        dbo.tblDevice ON         dbo.tblWaterLevelData.DeviceID = dbo.tblDevice.DeviceID INNER JOIN        dbo.tblStation ON dbo.tblDevice.StationID = dbo.tblStation.StationID        





GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  View dbo.vWaterUserChannelStationDevice    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  View dbo.vWaterUserChannelStationDevice    Script Date: 2011-11-17 14:18:03 ******/

/****** 对象: 视图 dbo.vWaterUserChannelStationDevice    脚本日期: 2011-6-17 9:48:33 ******/

/****** 对象: 视图 dbo.vWaterUserChannelStationDevice    脚本日期: 2011-04-27 16:40:18 ******/
/****** 对象: 视图 dbo.vWaterUserChannel    脚本日期: 2011-03-23 15:16:23 *****
***** 对象: 视图 dbo.vWaterUserChannelStationDevice    脚本日期: 2011-03-17 14:57:09 ******/
CREATE VIEW dbo.vWaterUserChannelStationDevice
AS
SELECT dbo.tblWaterUser.WaterUserID, dbo.tblChannel.ChannelID, 
      dbo.tblStation.StationID, dbo.tblDevice.DeviceID, dbo.tblWaterUser.WaterUserName, 
      dbo.tblWaterUserLevel.WaterUserLevelName, dbo.tblChannel.ChannelName, 
      dbo.tblStation.Name AS StationName, dbo.tblChannelStationMap.StationOrdinal, 
      dbo.tblDevice.DeviceKind, dbo.tblDevice.DeviceType
FROM dbo.tblDevice INNER JOIN
      dbo.tblStation ON dbo.tblDevice.StationID = dbo.tblStation.StationID INNER JOIN
      dbo.tblChannelStationMap ON 
      dbo.tblStation.StationID = dbo.tblChannelStationMap.StationID INNER JOIN
      dbo.tblChannel INNER JOIN
      dbo.tblWaterUserChannelMap ON 
      dbo.tblChannel.ChannelID = dbo.tblWaterUserChannelMap.ChannelID INNER JOIN
      dbo.tblWaterUser ON 
      dbo.tblWaterUserChannelMap.WaterUserID = dbo.tblWaterUser.WaterUserID INNER JOIN
      dbo.tblWaterUserLevel ON 
      dbo.tblWaterUser.WaterUserLevelID = dbo.tblWaterUserLevel.WaterUserLevelID ON 
      dbo.tblChannelStationMap.ChannelID = dbo.tblChannel.ChannelID
WHERE (dbo.tblWaterUserLevel.Deleted = 0) AND (dbo.tblWaterUser.Deleted = 0) AND 
      (dbo.tblChannel.Deleted = 0) AND (dbo.tblStation.Deleted = 0) AND 
      (dbo.tblDevice.Deleted = 0)




GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  View dbo.vDitchData10MinuteChangedLog    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  View dbo.vDitchData10MinuteChangeLog    Script Date: 2011-11-17 14:18:03 ******/
CREATE VIEW dbo.vDitchData10MinuteChangedLog
AS
SELECT dbo.tblDitchData10MinuteChangeLog.DitchData10MinuteChangeLogID, 
      dbo.tblChannel.ChannelName, dbo.tblStation.Name AS StationName, 
      dbo.tblDitchData10Minute.DT, dbo.tblDitchData10Minute.WL1, 
      dbo.tblDitchData10MinuteChangeLog.LoginName, 
      dbo.tblDitchData10MinuteChangeLog.OldWL, 
      dbo.tblDitchData10MinuteChangeLog.NewWL, 
      dbo.tblDitchData10MinuteChangeLog.ChangeDT
FROM dbo.tblStation INNER JOIN
      dbo.tblDevice ON dbo.tblStation.StationID = dbo.tblDevice.StationID INNER JOIN
      dbo.tblChannelStationMap ON 
      dbo.tblStation.StationID = dbo.tblChannelStationMap.StationID INNER JOIN
      dbo.tblChannel ON 
      dbo.tblChannelStationMap.ChannelID = dbo.tblChannel.ChannelID INNER JOIN
      dbo.tblDitchData10MinuteChangeLog INNER JOIN
      dbo.tblDitchData10Minute ON 
      dbo.tblDitchData10MinuteChangeLog.DitchData10MinuteID = dbo.tblDitchData10Minute.DitchData10MinuteID
       ON dbo.tblDevice.DeviceID = dbo.tblDitchData10Minute.DeviceID
WHERE (dbo.tblDevice.Deleted = 0) AND (dbo.tblStation.Deleted = 0)


GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  View dbo.vDitchDataLast    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  View dbo.vDitchDataLast    Script Date: 2011-11-17 14:18:03 ******/

/****** 对象: 视图 dbo.vDitchDataLast    脚本日期: 2011-6-17 9:48:33 ******/
/****** 对象: 视图 dbo.vDitchDataLast    脚本日期: 2011-04-27 16:40:18 *****
***** 对象: 视图 dbo.vDitchDataLast    脚本日期: 2011-03-23 15:16:23 *****
***** 对象: 视图 dbo.vDitchDataLast    脚本日期: 2011-03-17 14:57:09 ******/
CREATE VIEW dbo.vDitchDataLast
AS
SELECT dbo.tblChannel.ChannelName, dbo.tblStation.Name AS StationName, 
      dbo.tblChannelStationMap.StationOrdinal, dbo.tblDevice.DeviceType, 
      dbo.tblDevice.DeviceKind, dbo.tblDitchData.DT, dbo.tblDitchData.WL1, 
      dbo.tblDitchData.WL2, dbo.tblDitchData.InstantFlux, dbo.tblDitchData.UsedAmount, 
      dbo.tblDitchData.Voltage, dbo.tblStation.StationID
FROM dbo.tblDitchDataLast INNER JOIN
      dbo.tblDevice ON 
      dbo.tblDitchDataLast.DeviceID = dbo.tblDevice.DeviceID INNER JOIN
      dbo.tblStation ON dbo.tblDevice.StationID = dbo.tblStation.StationID INNER JOIN
      dbo.tblDitchData ON 
      dbo.tblDitchDataLast.DitchDataID = dbo.tblDitchData.DitchDataID AND 
      dbo.tblDevice.DeviceID = dbo.tblDitchData.DeviceID INNER JOIN
      dbo.tblChannelStationMap ON 
      dbo.tblStation.StationID = dbo.tblChannelStationMap.StationID INNER JOIN
      dbo.tblChannel ON 
      dbo.tblChannelStationMap.ChannelID = dbo.tblChannel.ChannelID
WHERE (dbo.tblStation.Deleted = 0) AND (dbo.tblDevice.Deleted = 0) AND 
      (dbo.tblChannel.Deleted = 0)



GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  View dbo.vDitchDataReal    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  View dbo.vDitchDataReal    Script Date: 2011-11-17 14:18:03 ******/
/****** 对象: 视图 dbo.vDitchDataReal    脚本日期: 2011-6-17 9:48:33 *****
***** 对象: 视图 dbo.vDitchDataReal    脚本日期: 2011-04-27 16:40:18 *****
***** 对象: 视图 dbo.vDitchDataReal    脚本日期: 2011-03-23 15:16:23 *****
***** 对象: 视图 dbo.vDitchDataReal    脚本日期: 2011-03-17 14:57:09 ******/
CREATE VIEW dbo.vDitchDataReal
AS
SELECT dbo.tblChannel.ChannelName, dbo.tblStation.Name AS StationName, 
      dbo.tblChannelStationMap.StationOrdinal, dbo.tblDevice.DeviceKind, 
      dbo.tblDevice.DeviceType, dbo.tblDitchData.DT, dbo.tblDitchData.WL1, 
      dbo.tblDitchData.WL2, dbo.tblDitchData.InstantFlux, dbo.tblDitchData.UsedAmount, 
      dbo.tblDitchData.Voltage, dbo.tblStation.StationID
FROM dbo.tblDitchData INNER JOIN
      dbo.tblDevice ON dbo.tblDitchData.DeviceID = dbo.tblDevice.DeviceID INNER JOIN
      dbo.tblDitchDataReal ON 
      dbo.tblDitchData.DitchDataID = dbo.tblDitchDataReal.DitchDataID AND 
      dbo.tblDevice.DeviceID = dbo.tblDitchDataReal.DeviceID INNER JOIN
      dbo.tblStation ON dbo.tblDevice.StationID = dbo.tblStation.StationID INNER JOIN
      dbo.tblChannel INNER JOIN
      dbo.tblChannelStationMap ON 
      dbo.tblChannel.ChannelID = dbo.tblChannelStationMap.ChannelID ON 
      dbo.tblStation.StationID = dbo.tblChannelStationMap.StationID
WHERE (dbo.tblChannel.Deleted = 0) AND (dbo.tblStation.Deleted = 0) AND 
      (dbo.tblDevice.Deleted = 0)


GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.GetDBName    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  Stored Procedure dbo.GetDBName    Script Date: 2011-11-17 14:18:03 ******/
CREATE PROCEDURE GetDBName AS

select ('yehesldb') as DBName

GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.GetDBVersion    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  Stored Procedure dbo.GetDBVersion    Script Date: 2011-11-17 14:18:03 ******/
CREATE PROCEDURE [GetDBVersion] AS
select 4 as DBVersion
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.sp_getChild    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  Stored Procedure dbo.sp_getChild    Script Date: 2011-11-17 14:18:03 ******/

/****** 对象: 存储过程 dbo.sp_getChild    脚本日期: 2011-6-17 9:48:33 ******/

/****** 对象: 存储过程 dbo.sp_getChild    脚本日期: 2011-04-27 16:40:18 ******/

CREATE procedure sp_getChild
@TName   nvarchar(40),
@IDName  nvarchar(40),
@PIDName nvarchar(40),
@Name    nvarchar(40),
@ID      nvarchar(20)

as
begin
    create table #T(menu_id INT,FatherID INT,Name VARCHAR(100),Level INT)
    
    declare @s nvarchar(4000)
    
    set @s = N'declare @i int  set @i = 1'
    set @s = @s + N'   
                    insert into #t select '+@IDName+N','+@PIDName+N','+@Name+N',@i from '+@TName+N' where  menu_id='''+@ID+N''''
	print @s   
 set @s = @s + N'
    while @@rowcount<>0
    begin
        set @i = @i + 1
        
        insert into #t 
        select 
            a.'+@IDName+N',a.'+@PIDName+N',a.'+@Name+N',@i 
        from 
            '+@TName+N' a,#t b 
        where 
            a.'+@PIDName+N'=b.'+@IDName+N' and b.Level = @i-1  order by seq
    end'

    exec(@s)
    
    select menu_id,fatherID,Name from #T
end




GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.sp_login    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  Stored Procedure dbo.sp_login    Script Date: 2011-11-17 14:18:03 ******/

/****** 对象: 存储过程 dbo.sp_login    脚本日期: 2011-6-17 9:48:33 ******/

/****** 对象: 存储过程 dbo.sp_login    脚本日期: 2011-04-27 16:40:18 ******/

CREATE PROCEDURE sp_login
@userid varchar(10),
@password varchar(10),
@reason varchar(10) output,
@role_id varchar(10) output,
@per_id varchar(10) output

AS
declare @select_s nvarchar(1000)
select wateruserid  from tb_user where  name = @userid
         if (@@RowCount<1)
            begin ----1
               set  @reason ='noUser'
                set @role_id='-1'
	set @per_id=''
             end------1
         else 
               begin  ----2        
    
	      SELECT   wateruserid    FROM tb_user
	            WHERE (name = @userid) AND (password = @password )
                     if (@@RowCount<1)
                        begin -----3
                         set  @reason ='pError'
                         set @role_id='-1'
	         set @per_id=''
                         end-------3
                    else
                        begin  ------4
                             set  @reason ='access'
                             /*set @select_s='where (dbo.tb_user.userid ='''+ @userid+''') AND (dbo.tb_user.password ='''+ @password+''' )'
             	        
		exec('SELECT  dbo.tb_personal.per_name,dbo.tb_user.role_id
FROM dbo.tb_user LEFT OUTER JOIN
      dbo.tb_personal ON dbo.tb_user.per_id = dbo.tb_personal.per_id '+@select_s)*/

		select @per_id=wateruserid,@role_id=role_id from tb_user where (name = @userid) AND (password = @password )
 
                     


                          end -----4        
                end------2
	RETURN




GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.Create10MinuteDayRows    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  Stored Procedure dbo.Create10MinuteDayRows    Script Date: 2011-11-17 14:18:03 ******/
CREATE PROCEDURE Create10MinuteDayRows
    @deviceid   as  int,
    @dt         as  datetime
as

declare @date           as datetime
declare @dateString     as nvarchar(100)
declare @dateRow        as datetime
--declare @minuteOfDay    as int
declare @numberOf10Minute   as int

--set @minuteOfDay = 0
set @numberOf10Minute = 0

set @dateString = str(year(@dt)) + 
		'-' + 
		str(month(@dt)) + 
		'-' + 
		str(day(@dt))



        set @date = convert(datetime, @dateString)
        set @dateRow = @date

while (@numberOf10Minute < 144)
    begin
        set @dateRow = dateadd(minute, 10 * @numberOf10Minute, @date)
        insert into tblDitchData10Minute(DeviceID, DT) values(@deviceid, @dateRow)
       set @numberOf10Minute = @numberOf10Minute + 1
    end


GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.CreateDitchDataDay    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  Stored Procedure dbo.CreateDitchDataDay    Script Date: 2011-11-17 14:18:03 ******/

/****** 对象: 存储过程 dbo.CreateDitchDataDay    脚本日期: 2011-6-17 9:48:33 ******/
CREATE PROCEDURE CreateDitchDataDay AS

/* 
 * create day ditch data
 * 
 * 1. read last day ditch data from tblDitchDataDay
 * 2. read ditch data greate then last DT
 * 3. calc day ditch data
 * 4. write to tblDitchDataDay
 *
 */

declare @lastDayDitchDataDT 	as 	datetime
declare @lastDitchDataDT       	as 	datetime
declare @deviceid          	as  	int
declare @wl1               	as  	int
declare @wl2                	as  	int
declare @instantflux        	as  	int
declare @dayamount          	as  	int
declare @daydt             	as  	datetime
declare @nowdt	 		as 	datetime
declare @nowhour		as	int


/*
 * 
 */
select  @lastDayDitchDataDT = max(dt)  from tblDitchDataDay


if @lastDayDitchDataDT is null 
begin
	set @lastDayDitchDataDT = '1900-1-1'
end
set @lastDayDitchDataDT = dateadd(day, 1, @lastDayDitchDataDT)
--select @lastdayditchdatadt as LastDayDitchDataDT


/*
 *
 */
set @nowdt = getdate()
--select @nowdt

set @nowhour = datepart(hour, @nowdt)
--select @nowhour as nowhour

if( @nowhour < 8 )
begin
	return
end
/*
 * last ditchdata dt for calc day ditch data
 */
set @lastditchdatadt = convert( nvarchar(10), @nowdt, 120 )
--select @lastditchdatadt as LastDitchDataDT


declare dayDitchData_cursor  cursor for
select  deviceid, convert(varchar(10), dt, 120) as dt, avg(wl1) as wl1, avg(wl2) as wl2,
        avg(convert(bigint, instantflux)) as instantFlux
    from tblDitchData 
    where DT > @lastDayDitchDataDT and dt < @lastDitchDataDT
    group by deviceid, convert(varchar(10), dt, 120)



open dayDitchData_cursor
fetch next from dayDitchData_cursor into @deviceid, @daydt, @wl1, @wl2, @instantflux
while @@fetch_status = 0
    begin
	/*
	 * int datatype overflow
	 */
	if @instantflux > (5000 * 10000)
	begin 
			set @dayAmount = -1
	end
	else 
	begin
		set @dayAmount = @instantflux * 24
	end
	insert into tblDitchDataDay(DeviceID, DT, avgwl, avgflux, dayamount )
		values (@deviceid, @daydt, @wl1, @instantflux, @dayAmount)

        fetch next from dayDitchData_cursor into @deviceid, @daydt, @wl1, @wl2, @instantflux        
    end

close dayDitchData_cursor
deallocate dayDitchData_cursor
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.CreateDitchDataHour    Script Date: 2012-08-16 09:37:00 ******/
CREATE PROCEDURE CreateDitchDataHour AS

/* 
 * create day ditch data
 * 
 * 1. read last day ditch data from tblDitchDataHour
 * 2. read ditch data greate then last DT
 * 3. calc day ditch data
 * 4. write to tblDitchDataHour
 *
 */

declare @lastDayDitchDataDT 	as 	datetime
declare @lastDitchDataDT       	as 	datetime
declare @deviceid          	as  	int
declare @wl1               	as  	int
declare @wl2                	as  	int
declare @instantflux        	as  	int
declare @dayamount          	as  	int
declare @daydt             	as  	datetime
declare @nowdt	 		as 	datetime
declare @nowhour		as	int
declare @h			as 	int


/*
 * 
 */
select  @lastDayDitchDataDT = max(dt)  from tblDitchDataHour


if @lastDayDitchDataDT is null 
begin
	set @lastDayDitchDataDT = '1900-1-1'
end
set @lastDayDitchDataDT = dateadd(day, 1, @lastDayDitchDataDT)
--select @lastdayditchdatadt as LastDayDitchDataDT


/*
 *
 */
set @nowdt = getdate()
--select @nowdt

set @nowhour = datepart(hour, @nowdt)
--select @nowhour as nowhour

if( @nowhour < 8 )
begin
	return
end
/*
 * last ditchdata dt for calc day ditch data
 */
set @lastditchdatadt = convert( nvarchar(10), @nowdt, 120 )
--select @lastditchdatadt as LastDitchDataDT


declare dayDitchData_cursor  cursor for
select  deviceid, convert(varchar(10), dt, 120) as dt, datepart(hour, dt) as h, avg(wl1) as wl1, avg(wl2) as wl2,
        avg(convert(bigint, instantflux)) as instantFlux
    from tblDitchData 
    where DT > @lastDayDitchDataDT and dt < @lastDitchDataDT
    group by deviceid, convert(varchar(10), dt, 120), datepart(hour, dt)


open dayDitchData_cursor
fetch next from dayDitchData_cursor into @deviceid, @daydt, @h, @wl1, @wl2, @instantflux
while @@fetch_status = 0
    begin
	/*
	 * int datatype overflow
	 */
	if @instantflux > (5000 * 10000)
	begin 
		set @dayAmount = -1
	end
	else 
	begin
		set @dayAmount = @instantflux * 1
	end
    /*
     * add hour to daydt
     */
    set @daydt = dateadd( hour, @h, @daydt )

	insert into tblDitchDataHour(DeviceID, DT, avgwl, avgflux, dayamount )
		values (@deviceid, @daydt, @wl1, @instantflux, @dayAmount)

        fetch next from dayDitchData_cursor into @deviceid, @daydt, @h, @wl1, @wl2, @instantflux        
    end

close dayDitchData_cursor
deallocate dayDitchData_cursor
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.Update10MinuteRow    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  Stored Procedure dbo.Update10MinuteRow    Script Date: 2011-11-17 14:18:03 ******/
/*
 *
 */
create PROCEDURE Update10MinuteRow 
    @DeviceID       as int,
    @DT             as datetime,
    @wl1            as int,
    @wl2            as int,
    @instantFlux    as int,
    @usedAmount     as int
as
    update tblDitchData10Minute set wl1 = @wl1, wl2 = @wl2, instantFlux = @instantFlux, usedAmount = @usedAmount
    where deviceid = @DeviceID and DT = @DT


GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.Save10MinuteRow    Script Date: 2012-08-16 09:37:00 ******/

/****** Object:  Stored Procedure dbo.Save10MinuteRow    Script Date: 2011-11-17 14:18:03 ******/

CREATE PROCEDURE Save10MinuteRow 
    @DeviceID       as int,
    @DT             as datetime,
    @wl1            as int,
    @wl2            as int,
    @instantFlux    as int,
    @usedAmount     as int
as

    declare @dt10minute     as datetime
    declare @isExist        as int 

    set @dt10minute = dbo.Get10MinuteDateTime(@DT)
    set @isExist = dbo.Get10MinuteRow( @DeviceID, @dt10minute )


    -- exist10Minute record?
    if @isExist = 0
        begin
            -- no: create 10 minute records
            exec Create10MinuteDayRows @DeviceID, @dt10minute

        end
    
   exec  Update10MinuteRow @DeviceID, @dt10minute, @wl1, @wl2, @instantFlux, @usedAmount





GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

/****** 对象:  用户定义的函数 dbo.F1    脚本日期: 2012-08-16 09:37:00 ******/

/****** 对象:  用户定义的函数 dbo.F1    脚本日期: 2011-11-17 14:18:03 ******/

CREATE  FUNCTION F1()
RETURNS int
AS  
BEGIN 
	--print 'call function - f1()'
	return 1
END


GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

/****** 对象:  用户定义的函数 dbo.Get10MinuteDateTime    脚本日期: 2012-08-16 09:37:00 ******/

/****** 对象:  用户定义的函数 dbo.Get10MinuteDateTime    脚本日期: 2011-11-17 14:18:03 ******/
CREATE FUNCTION Get10MinuteDateTime( @source as datetime)
RETURNS datetime
AS  

BEGIN 
	declare @strdt as nvarchar(400)
	declare @min as int
	declare @strMinute as nvarchar(10)

	set @min = datepart(minute, @source)
	set @min = @min / 10 * 10	
	set @strMinute = str(@min)

	set @strdt = str(year(@source)) + 
		'-' + 
		str(month(@source)) + 
		'-' + 
		str(day(@source)) +
		' ' +
		str(datepart(hour, @source)) +
		':' +
		@strMinute +
		':00'

	return convert( datetime, @strdt)
END



GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

/****** 对象:  用户定义的函数 dbo.f2    脚本日期: 2012-08-16 09:37:00 ******/

/****** 对象:  用户定义的函数 dbo.f2    脚本日期: 2011-11-17 14:18:03 ******/

CREATE  FUNCTION f2()
RETURNS table AS  

return select * from tblstation



GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

/****** 对象:  用户定义的函数 dbo.Get10MinuteRow    脚本日期: 2012-08-16 09:37:00 ******/

/****** 对象:  用户定义的函数 dbo.Get10MinuteRow    脚本日期: 2011-11-17 14:18:03 ******/
CREATE FUNCTION Get10MinuteRow ( 
    @DeviceID   as      int,
    @DT         as      datetime
)  

RETURNS int AS  
BEGIN 
    return (select count(*) from tblDitchData10Minute where DeviceID = @DeviceID and dt = @DT)
END

GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Trigger dbo.insert_ditchdata_trigger    Script Date: 2012-08-16 09:37:00 ******/
/****** Object:  Trigger dbo.insert_ditchdata_trigger    Script Date: 2011-11-17 14:18:03 ******/
/****** 对象: 触发器 dbo.insert_ditchdata_trigger    脚本日期: 2011-6-17 9:48:33 ******/

CREATE  TRIGGER insert_ditchdata_trigger ON dbo.tblDitchData 
FOR INSERT
AS

declare @ditchDataID	int,
	@deviceID	int,
	@dt		datetime,
	@wl1		int,
	@wl2		int,
	@instantFlux	int,
	@usedAmount	int


select 	@ditchDataID = ditchDataID,
	@deviceID = deviceID,
	@dt = dt,
	@wl1 = wl1,
	@wl2 = wl2,
	@instantFlux = instantFlux,
	@usedAmount = usedAmount
	 from inserted
/*
 *
 */
exec Save10MinuteRow @deviceID, @dt, @wl1, @wl2, @instantFlux, @usedAmount


/*
 * delete exist device data
 */
if exists( select * from tblDitchDataLast where deviceID = @deviceID )
begin
	delete from tblDitchDataLast where deviceID = @deviceID
end
/*
 * insert last ditchdata id
 */
insert into tblDitchDataLast(DitchDataID, DeviceID) values(@ditchDataID, @deviceID)


/*
 * ditch data real save record count = 50
 */
declare @ditchRealDatacount	int
select @ditchRealDataCount = count(*) from tblDitchDataReal where deviceID = @deviceID
if @ditchRealDataCount >= 50 
begin
	delete from tblDitchDataReal where ditchDataRealID = 
		(select min(ditchDataRealID) from tblDitchDataReal where deviceID = @deviceID)
end

insert into tblDitchDataReal( ditchDataID, deviceID) values(@ditchDataID, @deviceID)

GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO


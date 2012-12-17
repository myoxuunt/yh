using System;
using System.Collections.Generic;
using System.Text;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public enum DataEnum
    {
        /// <summary>
        /// 水位
        /// </summary>
        WL,

        /// <summary>
        /// 流量
        /// </summary>
        Flux,

        /// <summary>
        /// 用水量
        /// </summary>
        Amount,
    }

    /// <summary>
    /// 
    /// </summary>
    public class DataEnumClass
    {
        /// <summary>
        /// 
        /// </summary>
        static NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="queryStringCollection"></param>
        /// <param name="keyName"></param>
        /// <returns></returns>
        static public DataEnum GetDataEnumFromQueryString(
            System.Collections.Specialized.NameValueCollection queryStringCollection,
            string keyName)
        {
             object obj = null;
                string dataEnumString = queryStringCollection[keyName];
                if (dataEnumString == null || dataEnumString.Length == 0)
                {
                    return DataEnum.WL;
                }
                else
                {
                    try
                    {
                        obj = Enum.Parse(typeof(DataEnum), dataEnumString, true);
                    }
                    catch (ArgumentException aex)
                    {
                        log.Error(aex.ToString());
                        obj = DataEnum.WL;
                    }
                }
                return (DataEnum)obj;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="de"></param>
        /// <returns></returns>
        static public string GetDataColumnNameByDataEnum(DataEnum de)
        {
            string n = string.Empty;
            switch (de)
            {
                case DataEnum.WL :
                    n = "AVGWL";
                    break;

                case DataEnum.Flux :
                    n = "AVGFlux";
                    break;

                case DataEnum.Amount :
                    n = "DayAmount";
                    break;
                default :
                    throw new ArgumentException("cannot find datacolumn name by dataenum : " + de );
            }

            return n;
        }

        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="de"></param>
        /// <returns></returns>
        static public string GetDataEnumTitle(DataEnum de)
        {
            string n = string.Empty;
            switch (de)
            {
                case DataEnum.WL :
                    n = "水位查询";
                    break;

                case DataEnum.Flux :
                    n = "流量查询";
                    break;

                case DataEnum.Amount :
                    n = "水量查询";
                    break;
                default :
                    throw new ArgumentException("cannot find datenum string by dataenum : " + de );
            }

            return n;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="de"></param>
        /// <returns></returns>
        static public string GetDataEnumString(DataEnum de)
        {
            string n = string.Empty;
            switch (de)
            {
                case DataEnum.WL :
                    n = "水位";
                    break;

                case DataEnum.Flux :
                    n = "流量";
                    break;

                case DataEnum.Amount :
                    n = "用水量";
                    break;
                default :
                    throw new ArgumentException("cannot find datenum string by dataenum : " + de );
            }

            return n;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="de"></param>
        /// <returns></returns>
        static public string GetDataEnumUnit( DataEnum de )
        {
            string n = string.Empty ;
            switch (de)
            {
                case DataEnum.WL :
                    n = "cm";
                    break;

                case DataEnum.Flux :
                    n = "m3/s";
                    break;

                case DataEnum.Amount :
                    n = "m3";
                    break;
                default :
                    break;
            }

            return n;
        }
    }

}

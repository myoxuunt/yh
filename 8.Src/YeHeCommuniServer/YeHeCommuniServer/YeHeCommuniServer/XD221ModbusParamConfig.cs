using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Common;

namespace YeHeCommuniServer
{
    /// <summary>
    /// 
    /// </summary>
    public class XD221ModbusParamConfig : Xdgk.Common.SelfSerializer
    {
        /// <summary>
        /// 
        /// </summary>
        private const string ConfigFileName = "XD221ModbusParamConfig.xml";

        /// <summary>
        /// 
        /// </summary>
        static public XD221ModbusParamConfig Default
        {
            get
            {
                if (s_default == null)
                {
                    try
                    {
                        s_default = (XD221ModbusParamConfig)Xdgk.Common.SelfSerializer.Load(
                            typeof(XD221ModbusParamConfig),
                            ConfigFileName);
                    }
                    catch 
                    {
                        try
                        {
                            s_default = new XD221ModbusParamConfig();
                            s_default.Save(ConfigFileName);
                        }
                        catch (Exception ex1)
                        {
                            string s = ex1.Message;
                        }
                    }
                }
                return s_default;
            }
        } static private XD221ModbusParamConfig s_default;


        /// <summary>
        /// 
        /// </summary>
        public XD221ConfigDefineCollection  XD221ConfigDefineCollection
        {
            get { return _defines; }
            set { _defines = value; }
        } private XD221ConfigDefineCollection _defines = new XD221ConfigDefineCollection();
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Diagnostics;
using Xdgk.Communi.Interface;
using NUnit.Core;
using Xdgk.Common;
using Xdgk.Communi.XmlBuilder;
//using Xdgk.Communi.Interface;

namespace Xdgk.Communi.Factory
{
    /// <summary>
    /// 
    /// </summary>
    public class XmlOperaFactory : OperaFactoryBase
    {

        #region Members
        /// <summary>
        /// 
        /// </summary>
        static private Logger log = InternalTrace.GetLogger(typeof(XmlOperaFactory));
        #endregion //Members

        #region XmlOperaFactory
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        public XmlOperaFactory(CommuniSoft communiSoft, XmlNode deviceDefinesNode)
            : base(communiSoft)
        {
            if (deviceDefinesNode == null)
                throw new ArgumentNullException("node");
            this._deviceDefinesNode = deviceDefinesNode;

            foreach( XmlNode deviceDefineNode in deviceDefinesNode.ChildNodes )
            {
                if (deviceDefineNode.Name == DeviceDefineNodeNames.DeviceDefine)
                {
                    string deviceType = GetAttribute((XmlElement)deviceDefineNode,
                        DeviceDefineNodeNames.DeviceType);
                    string deviceText = GetAttribute((XmlElement)deviceDefineNode,
                        DeviceDefineNodeNames.DeviceText);

                    // TODO: remove xmlOperaFactory DeviceDefineCollection
                    //
                    // TODO: 2010-07-28 add device parameter define 
                    //
                    DeviceDefine dd = new DeviceDefine(deviceType, deviceText);        
                    
                    XmlNode paramDefinesNode = deviceDefineNode.SelectSingleNode(ParameterNodeNames.ParameterDefineCollection);
                    if (paramDefinesNode != null)
                    {
                        ParameterDefineCollection paramDefines = XmlModbusParameterDefineBuilder.BuildParameterDefineCollection(paramDefinesNode);
                        dd.ParameterDefineCollection = paramDefines;
                    }

                    this.DeviceDefineCollection.Add(dd);

                    //this.CommuniSoft.DeviceDefineCollection.Add(dd);
                }
            }
        }
        #endregion //XmlOperaFactory

        //#region DeviceDefineCollection
        ///// <summary>
        ///// 
        ///// </summary>
        //public override DeviceDefineCollection DeviceDefineCollection
        //{
        //    get { throw new NotImplementedException(); }
        //}
        //#endregion //DeviceDefineCollection

        #region InitFDManager
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fDManager"></param>
        public override void InitFDManager(FDManager fDManager)
        {
            XmlNodeList ddnodelist = this.DeviceDefinesNode.SelectNodes(DeviceDefineNodeNames.DeviceDefine);

            foreach (XmlNode ddnode in ddnodelist)
            {
                string deviceType = GetAttribute(ddnode as XmlElement, DeviceDefineNodeNames.DeviceType);
                XmlNodeList opnodelist = ddnode.SelectNodes(DeviceDefineNodeNames.OperaDefine);
                foreach (XmlNode opnode in opnodelist)
                {
                    string str = GetAttribute(opnode as XmlElement, "processfd", true);
                    bool b = false;
                    if (str != null && str.Length > 0)
                        b = bool.Parse(str);
                    if (b)
                    {
                        Opera op = Create(deviceType, opnode);
                        fDManager.Operas.Add(op);
                        log.Debug("add FD opera: " + op.Name );
                    }
                }
            }
        }
        #endregion //InitFDManager



        #region DeviceDefinesNode
        /// <summary>
        /// 
        /// </summary>
        public XmlNode DeviceDefinesNode
        {
            get { return _deviceDefinesNode; }
            set { _deviceDefinesNode = value; }
        } private XmlNode _deviceDefinesNode;
        #endregion //DeviceDefinesNode

        #region Create
        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceType"></param>
        /// <param name="operaname"></param>
        /// <returns></returns>
        public override Opera Create(string deviceType, string operaname)
        {
            if (deviceType.Length == 0)
                throw new ArgumentException("invalid devicetype: " + deviceType);

            if (operaname.Length == 0)
                throw new ArgumentException("invalid operaname: " + operaname);

            XmlNodeList ddnodelist = DeviceDefinesNode.SelectNodes(DeviceDefineNodeNames.DeviceDefine);
            foreach (XmlNode ddnode in ddnodelist)
            {
                string str = GetAttribute(ddnode as XmlElement, DeviceDefineNodeNames.DeviceType);
                //if (str == deviceType)
                if (Xdgk.Common.StringHelper.Equal(str, deviceType))
                {
                    // find device type
                    //
                    XmlNodeList opnodelist = ddnode.SelectNodes(DeviceDefineNodeNames.OperaDefine);
                    foreach (XmlNode opnode in opnodelist)
                    {
                        string opname = GetAttribute(opnode as XmlElement, DeviceDefineNodeNames.OperaName);
                        //if (opname == operaname)
                        if (StringHelper.Equal(opname, operaname))
                        {
                            return Create(deviceType, opnode);
                        }
                    }
                }
            }
            return null;
        }
        #endregion //Create

        #region Create
        /// <summary>
        /// 
        /// </summary>
        /// <param name="operanode"></param>
        /// <returns></returns>
        private Opera Create(string deviceType, XmlNode operaNode)
        {
            XmlElement e = operaNode as XmlElement;
            Opera opera = null;
            SendPart sp = null;
            ReceivePartCollection rps = new ReceivePartCollection();
            string name = GetAttribute(e, DeviceDefineNodeNames.OperaName);
            string text = GetAttribute(e, DeviceDefineNodeNames.OperaText, true);
            //if (text == string.Empty)
            //{
            //}
            string args = GetAttribute(e, DeviceDefineNodeNames.OperaArgs, true);
            

            foreach (XmlNode node in operaNode.ChildNodes)
            {
                switch (node.Name)
                {
                    case DeviceDefineNodeNames.SendPart:
                        sp = CreateSendPart(node);
                        break;

                    case DeviceDefineNodeNames.ReceivePart:
                        ReceivePart rp = CreateReceivePart(node);
                        rps.Add(rp);
                        break;
                }
            }

            opera = new Opera(deviceType, name, text, args);
            opera.SendPart = sp;
            opera.ReceiveParts = rps;
            log.Info("Create opera '{0}', receivepart count '{1}'", name, rps.Count);
            return opera;
        }
        #endregion //Create

        #region CreateReceivePart
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private ReceivePart CreateReceivePart(XmlNode recievepartnode)
        {
            XmlElement e = recievepartnode as XmlElement;
            string str = GetAttribute(e, DeviceDefineNodeNames.ReceivePartDataLength);
            int rpLength = int.Parse(str);

            string name = GetAttribute(e, DeviceDefineNodeNames.ReceivePartName,true);

            ReceivePart rp = new ReceivePart(name, rpLength);

            foreach (XmlNode node in recievepartnode.ChildNodes)
            {
                switch (node.Name)
                {
                    case DeviceDefineNodeNames.DataField:
                        DataField df = CreateDataField(node);
                        df.IsBytesVolatile = true;
                        rp.Add(df);
                        break;
                }
            }
            ICRCer crcer = GetCRCer(recievepartnode);
            rp.DataFieldManager.CRCer = crcer;

            if (rp.DataFieldManager.CRCer == null &&
                rp.DataFieldManager.GetCRCDataField() != null)
            {
                throw new ConfigException("not exist CRCer");
            }
            return rp;
        }
        #endregion //CreateReceivePart

        #region CreateSendPart
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sendpartnode"></param>
        /// <returns></returns>
        private SendPart CreateSendPart(XmlNode sendpartnode)
        {
            SendPart sp = new SendPart();

            DataField df = null;
            foreach (XmlNode node in sendpartnode.ChildNodes)
            {
                switch (node.Name)
                {
                    case DeviceDefineNodeNames.DataField:
                        df = CreateDataField(node);
                        df.IsValueVolatile = true;
                        sp.Add(df);
                        break;
                }
            }

            ICRCer crcer = GetCRCer(sendpartnode);
            sp.DataFieldManager.CRCer = crcer;
            return sp;
        }
        #endregion //CreateSendPart

        #region GetCRCer
        /// <summary>
        /// 获取sendpart或receivepart的crcer,如不存在返回null
        /// </summary>
        /// <param name="node">sendpart xmlnode or receivepart xmlnode</param>
        /// <returns></returns>
        private ICRCer GetCRCer(XmlNode node)
        {
            XmlNode crcerNode = node.SelectSingleNode(DeviceDefineNodeNames.CRCer);
            if (crcerNode != null)
            {
                string name = crcerNode.Attributes["name"].Value;
                ICRCer crcer = CommuniSoft.Default.CRCerManager.GetCRCer(name);
                if (crcer == null)
                    throw new ConfigException("not find CRCer: " + name);
                return crcer;
            }
            return null;

        }
        #endregion //GetCRCer

        #region GetAttribute
        /// <summary>
        /// 
        /// </summary>
        /// <param name="el"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        private string GetAttribute(XmlElement el, string name)
        {
            //return GetAttribute(el, name, false);
            return Xdgk.Common.XmlHelper.GetAttribute(el, name);
        }
        #endregion //GetAttribute

        #region GetAttribute
        /// <summary>
        /// 
        /// </summary>
        /// <param name="el"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        private string GetAttribute(XmlElement el, string name, bool canNull )
        {
            //string str = el.GetAttribute(name);
            //if (!canNull)
            //{
            //    if (str == null || str.Length == 0)
            //        throw new Exception(name + " null");
            //}

            //return str;
            return Xdgk.Common.XmlHelper.GetAttribute(el, name, canNull);
        }
        #endregion //GetAttribute

        #region CreateDataField
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datafieldnode"></param>
        /// <returns></returns>
        private DataField CreateDataField(XmlNode datafieldnode)
        {
            string name = string.Empty;
            string factor = string.Empty;
            object[] convertArgs = null;
            int begin = 0;
            int length = 0;
            IBytesConverter ibc = null;
            bool iscrc = false;
            bool isMatchCheck = false;
            byte[] bytes = null;
            bool littleEndian = true;

            string str = string.Empty;

            XmlElement el = datafieldnode as XmlElement;
            name = GetAttribute(el, DeviceDefineNodeNames.DataFieldName);

            str = GetAttribute(el, DeviceDefineNodeNames.Begin);
            begin = int.Parse(str);

            str = GetAttribute(el, DeviceDefineNodeNames.Length);
            length = int.Parse(str);

            str = GetAttribute(el, DeviceDefineNodeNames.Converter, true);
            if (str == null || str.Length == 0)
                str = "Xdgk.Communi.OriginalConverter";

            //
            //
            factor = GetAttribute(el, DeviceDefineNodeNames.Factor, true);
            if (factor != null && factor.Length > 0)
            {
                try
                {
                    float n = Convert.ToSingle(factor);
                    convertArgs = new object[] { n };
                }
                catch (FormatException formatEx)
                {
                    string s = string.Format("Invalid Factor '{0}'", factor);
                    throw new ConfigException(s, formatEx);
                }
            }
            ibc = GetBytesConvert(str, convertArgs);

            //
            //
            str = GetAttribute(el, DeviceDefineNodeNames.LittleEndian, true);
            if (str.Length > 0)
            {
                littleEndian = bool.Parse(str);
            }
            ibc.IsLittleEndian = littleEndian;

            str = GetAttribute(el, DeviceDefineNodeNames.Bytes, true);
            if (str != null && str.Length > 0)
            {
                bytes = HexStringConverter.Default.ConvertToBytes(str);
            }

            str = GetAttribute(el, DeviceDefineNodeNames.Crc, true);
            if (str != null && str.Length > 0)
            {
                iscrc = bool.Parse(str);
            }

            str = GetAttribute(el, DeviceDefineNodeNames.MatchCheck, true);
            if (str != null && str.Length > 0)
            {
                isMatchCheck = bool.Parse(str);
            }

            DataField df = new DataField(name, begin, length, (IBytesConverter)ibc);
            df.IsMatchCheck = isMatchCheck;
            if (bytes != null)
                df.Bytes = bytes;

            if( df.IsMatchCheck &&
                (df.Bytes == null || df.Bytes.Length == 0))
            {
                throw new Exception("must set bytes while matchCheck == true");
            }
            df.IsCRC = iscrc;

            return df;
        }
        #endregion //CreateDataField

        #region GetBytesConvert
        /// <summary>
        /// 
        /// </summary>
        /// <param name="convertName"></param>
        /// <returns></returns>
        private IBytesConverter GetBytesConvert(string converterName, object[] args)
        {
            BytesConverterManager bcm = CommuniSoft.Default.BytesConverterManager;
            //IBytesConverter bc = bcm.GetBytesConverter(convertName);
            IBytesConverter bc = bcm.CreateBytesConverter(converterName, args);
            if (bc == null)
            {
                //bc = new OriginalConverter();
                log.Error("not find BytesConvert: " + converterName);
                throw new ArgumentException("not find BytesConvert: " + converterName);
            }
            else
            {
            }
            return bc;
        }
        #endregion //GetBytesConvert
    }

    public class MyOperaFactory 
    {

        #region Members
        /// <summary>
        /// 
        /// </summary>
        static private Logger log = InternalTrace.GetLogger(typeof(XmlOperaFactory));
        #endregion //Members

        //#region XmlOperaFactory
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="node"></param>
        //public MyOperaFactory(CommuniSoft communiSoft, XmlNode deviceDefinesNode)
        //    : base(communiSoft)
        //{
        //    if (deviceDefinesNode == null)
        //        throw new ArgumentNullException("node");
        //    this._deviceDefinesNode = deviceDefinesNode;

        //    foreach( XmlNode deviceDefineNode in deviceDefinesNode.ChildNodes )
        //    {
        //        if (deviceDefineNode.Name == DeviceDefineNodeNames.DeviceDefine)
        //        {
        //            string deviceType = GetAttribute((XmlElement)deviceDefineNode,
        //                DeviceDefineNodeNames.DeviceType);
        //            string deviceText = GetAttribute((XmlElement)deviceDefineNode,
        //                DeviceDefineNodeNames.DeviceText);

        //            // TODO: remove xmlOperaFactory DeviceDefineCollection
        //            //
        //            // TODO: 2010-07-28 add device parameter define 
        //            //
        //            DeviceDefine dd = new DeviceDefine(deviceType, deviceText);        
                    
        //            XmlNode paramDefinesNode = deviceDefineNode.SelectSingleNode(ParameterNodeNames.ParameterDefineCollection);
        //            if (paramDefinesNode != null)
        //            {
        //                ParameterDefineCollection paramDefines = XmlModbusParameterDefineBuilder.BuildParameterDefineCollection(paramDefinesNode);
        //                dd.ParameterDefineCollection = paramDefines;
        //            }

        //            this.DeviceDefineCollection.Add(dd);

        //            this.CommuniSoft.DeviceDefineCollection.Add(dd);
        //        }
        //    }
        //}
        //#endregion //XmlOperaFactory

        //#region DeviceDefineCollection
        ///// <summary>
        ///// 
        ///// </summary>
        //public override DeviceDefineCollection DeviceDefineCollection
        //{
        //    get { throw new NotImplementedException(); }
        //}
        //#endregion //DeviceDefineCollection

        //#region InitFDManager
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="fDManager"></param>
        //public override void InitFDManager(FDManager fDManager)
        //{
        //    XmlNodeList ddnodelist = this.DeviceDefinesNode.SelectNodes(DeviceDefineNodeNames.DeviceDefine);

        //    foreach (XmlNode ddnode in ddnodelist)
        //    {
        //        string deviceType = GetAttribute(ddnode as XmlElement, DeviceDefineNodeNames.DeviceType);
        //        XmlNodeList opnodelist = ddnode.SelectNodes(DeviceDefineNodeNames.OperaDefine);
        //        foreach (XmlNode opnode in opnodelist)
        //        {
        //            string str = GetAttribute(opnode as XmlElement, "processfd", true);
        //            bool b = false;
        //            if (str != null && str.Length > 0)
        //                b = bool.Parse(str);
        //            if (b)
        //            {
        //                Opera op = Create(deviceType, opnode);
        //                fDManager.Operas.Add(op);
        //                log.Debug("add FD opera: " + op.Name );
        //            }
        //        }
        //    }
        //}
        //#endregion //InitFDManager



        //#region DeviceDefinesNode
        ///// <summary>
        ///// 
        ///// </summary>
        //public XmlNode DeviceDefinesNode
        //{
        //    get { return _deviceDefinesNode; }
        //    set { _deviceDefinesNode = value; }
        //} private XmlNode _deviceDefinesNode;
        //#endregion //DeviceDefinesNode

        #region Create
        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceType"></param>
        /// <param name="operaname"></param>
        /// <returns></returns>
        //public Opera Create(string deviceType, string operaname, XmlNode DeviceDefinesNode)
        static public Opera Create(string devicetype, string operaname, XmlNode deviceDefineNode)
        {
            //if (deviceType.Length == 0)
            //    throw new ArgumentException("invalid devicetype: " + deviceType);

            //if (operaname.Length == 0)
            //    throw new ArgumentException("invalid operaname: " + operaname);

            //XmlNodeList ddnodelist = DeviceDefinesNode.SelectNodes(DeviceDefineNodeNames.DeviceDefine);
            //foreach (XmlNode ddnode in ddnodelist)
            //{
            //string str = GetAttribute(ddnode as XmlElement, DeviceDefineNodeNames.DeviceType);
            //if (str == deviceType)
            //if (Xdgk.Common.StringHelper.Equal(str, deviceType))
            //{
            // find device type
            //
            XmlNodeList opnodelist = deviceDefineNode.SelectNodes(DeviceDefineNodeNames.OperaDefine);
            foreach (XmlNode opnode in opnodelist)
            {
                string opname = GetAttribute(opnode as XmlElement, DeviceDefineNodeNames.OperaName);
                //if (opname == operaname)
                if (StringHelper.Equal(opname, operaname))
                {
                    //return Create(deviceType, opnode);
                    return CreateFromOperaNode(devicetype, opnode);
                }
            }
            //}
            //}
            return null;
        }
        #endregion //Create

        #region Create
        /// <summary>
        /// 
        /// </summary>
        /// <param name="operanode"></param>
        /// <returns></returns>
        static private Opera CreateFromOperaNode(string deviceType, XmlNode operaNode)
        {
            XmlElement e = operaNode as XmlElement;
            Opera opera = null;
            SendPart sp = null;
            ReceivePartCollection rps = new ReceivePartCollection();
            string name = GetAttribute(e, DeviceDefineNodeNames.OperaName);
            string text = GetAttribute(e, DeviceDefineNodeNames.OperaText, true);
            //if (text == string.Empty)
            //{
            //}
            string args = GetAttribute(e, DeviceDefineNodeNames.OperaArgs, true);
            

            foreach (XmlNode node in operaNode.ChildNodes)
            {
                switch (node.Name)
                {
                    case DeviceDefineNodeNames.SendPart:
                        sp = CreateSendPart(node);
                        break;

                    case DeviceDefineNodeNames.ReceivePart:
                        ReceivePart rp = CreateReceivePart(node);
                        rps.Add(rp);
                        break;
                }
            }

            opera = new Opera(deviceType, name, text, args);
            opera.SendPart = sp;
            opera.ReceiveParts = rps;
            log.Info("Create opera '{0}', receivepart count '{1}'", name, rps.Count);
            return opera;
        }
        #endregion //Create

        #region CreateReceivePart
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        static private ReceivePart CreateReceivePart(XmlNode recievepartnode)
        {
            XmlElement e = recievepartnode as XmlElement;
            string str = GetAttribute(e, DeviceDefineNodeNames.ReceivePartDataLength);
            int rpLength = int.Parse(str);

            string name = GetAttribute(e, DeviceDefineNodeNames.ReceivePartName,true);

            ReceivePart rp = new ReceivePart(name, rpLength);

            foreach (XmlNode node in recievepartnode.ChildNodes)
            {
                switch (node.Name)
                {
                    case DeviceDefineNodeNames.DataField:
                        DataField df = CreateDataField(node);
                        df.IsBytesVolatile = true;
                        rp.Add(df);
                        break;
                }
            }
            ICRCer crcer = GetCRCer(recievepartnode);
            rp.DataFieldManager.CRCer = crcer;

            if (rp.DataFieldManager.CRCer == null &&
                rp.DataFieldManager.GetCRCDataField() != null)
            {
                throw new ConfigException("not exist CRCer");
            }
            return rp;
        }
        #endregion //CreateReceivePart

        #region CreateSendPart
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sendpartnode"></param>
        /// <returns></returns>
        static private SendPart CreateSendPart(XmlNode sendpartnode)
        {
            SendPart sp = new SendPart();

            DataField df = null;
            foreach (XmlNode node in sendpartnode.ChildNodes)
            {
                switch (node.Name)
                {
                    case DeviceDefineNodeNames.DataField:
                        df = CreateDataField(node);
                        df.IsValueVolatile = true;
                        sp.Add(df);
                        break;
                }
            }

            ICRCer crcer = GetCRCer(sendpartnode);
            sp.DataFieldManager.CRCer = crcer;
            return sp;
        }
        #endregion //CreateSendPart

        #region GetCRCer
        /// <summary>
        /// 获取sendpart或receivepart的crcer,如不存在返回null
        /// </summary>
        /// <param name="node">sendpart xmlnode or receivepart xmlnode</param>
        /// <returns></returns>
        static private ICRCer GetCRCer(XmlNode node)
        {
            XmlNode crcerNode = node.SelectSingleNode(DeviceDefineNodeNames.CRCer);
            if (crcerNode != null)
            {
                string name = crcerNode.Attributes["name"].Value;
                ICRCer crcer = CommuniSoft.Default.CRCerManager.GetCRCer(name);
                if (crcer == null)
                    throw new ConfigException("not find CRCer: " + name);
                return crcer;
            }
            return null;

        }
        #endregion //GetCRCer

        #region GetAttribute
        /// <summary>
        /// 
        /// </summary>
        /// <param name="el"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        static private string GetAttribute(XmlElement el, string name)
        {
            //return GetAttribute(el, name, false);
            return Xdgk.Common.XmlHelper.GetAttribute(el, name);
        }
        #endregion //GetAttribute

        #region GetAttribute
        /// <summary>
        /// 
        /// </summary>
        /// <param name="el"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        static private string GetAttribute(XmlElement el, string name, bool canNull )
        {
            //string str = el.GetAttribute(name);
            //if (!canNull)
            //{
            //    if (str == null || str.Length == 0)
            //        throw new Exception(name + " null");
            //}

            //return str;
            return Xdgk.Common.XmlHelper.GetAttribute(el, name, canNull);
        }
        #endregion //GetAttribute

        #region CreateDataField
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datafieldnode"></param>
        /// <returns></returns>
        static private DataField CreateDataField(XmlNode datafieldnode)
        {
            string name = string.Empty;
            string factor = string.Empty;
            object[] convertArgs = null;
            int begin = 0;
            int length = 0;
            IBytesConverter ibc = null;
            bool iscrc = false;
            bool isMatchCheck = false;
            byte[] bytes = null;
            bool littleEndian = true;

            string str = string.Empty;

            XmlElement el = datafieldnode as XmlElement;
            name = GetAttribute(el, DeviceDefineNodeNames.DataFieldName);

            str = GetAttribute(el, DeviceDefineNodeNames.Begin);
            begin = int.Parse(str);

            str = GetAttribute(el, DeviceDefineNodeNames.Length);
            length = int.Parse(str);

            str = GetAttribute(el, DeviceDefineNodeNames.Converter, true);
            if (str == null || str.Length == 0)
                str = "Xdgk.Communi.OriginalConverter";

            //
            //
            factor = GetAttribute(el, DeviceDefineNodeNames.Factor, true);
            if (factor != null && factor.Length > 0)
            {
                try
                {
                    float n = Convert.ToSingle(factor);
                    convertArgs = new object[] { n };
                }
                catch (FormatException formatEx)
                {
                    string s = string.Format("Invalid Factor '{0}'", factor);
                    throw new ConfigException(s, formatEx);
                }
            }
            ibc = GetBytesConvert(str, convertArgs);

            //
            //
            str = GetAttribute(el, DeviceDefineNodeNames.LittleEndian, true);
            if (str.Length > 0)
            {
                littleEndian = bool.Parse(str);
            }
            ibc.IsLittleEndian = littleEndian;

            str = GetAttribute(el, DeviceDefineNodeNames.Bytes, true);
            if (str != null && str.Length > 0)
            {
                bytes = HexStringConverter.Default.ConvertToBytes(str);
            }

            str = GetAttribute(el, DeviceDefineNodeNames.Crc, true);
            if (str != null && str.Length > 0)
            {
                iscrc = bool.Parse(str);
            }

            str = GetAttribute(el, DeviceDefineNodeNames.MatchCheck, true);
            if (str != null && str.Length > 0)
            {
                isMatchCheck = bool.Parse(str);
            }

            DataField df = new DataField(name, begin, length, (IBytesConverter)ibc);
            df.IsMatchCheck = isMatchCheck;
            if (bytes != null)
                df.Bytes = bytes;

            if( df.IsMatchCheck &&
                (df.Bytes == null || df.Bytes.Length == 0))
            {
                throw new Exception("must set bytes while matchCheck == true");
            }
            df.IsCRC = iscrc;

            return df;
        }
        #endregion //CreateDataField

        #region GetBytesConvert
        /// <summary>
        /// 
        /// </summary>
        /// <param name="convertName"></param>
        /// <returns></returns>
        static private IBytesConverter GetBytesConvert(string converterName, object[] args)
        {
            BytesConverterManager bcm = CommuniSoft.Default.BytesConverterManager;
            //IBytesConverter bc = bcm.GetBytesConverter(convertName);
            IBytesConverter bc = bcm.CreateBytesConverter(converterName, args);
            if (bc == null)
            {
                //bc = new OriginalConverter();
                log.Error("not find BytesConvert: " + converterName);
                throw new ArgumentException("not find BytesConvert: " + converterName);
            }
            else
            {
            }
            return bc;
        }
        #endregion //GetBytesConvert
    }
}

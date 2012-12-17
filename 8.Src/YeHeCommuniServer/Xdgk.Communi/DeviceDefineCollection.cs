using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Xdgk.Common;
using Xdgk.Communi.XmlBuilder;
using System.IO;

namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public class DeviceDefineCollection : Xdgk.Common.Collection<DeviceDefine>
    {
        // TODO: 2010-09-10
        //
        // cannot add same name devicedefine
        //


        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="item"></param>
        protected override void InsertItem(int index, DeviceDefine item)
        {
            if (item == null)
                throw new ArgumentNullException("item");

            if (Exist(item.DeviceType))
            {
                string s = string.Format("DeivceType '{0}' exist", item.DeviceType );
                ConfigException ex = new ConfigException(s);
                throw ex;
            }
            base.InsertItem(index, item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceType"></param>
        /// <returns></returns>
        public bool Exist(string deviceType)
        {
            foreach (DeviceDefine item in this)
            {
                if (StringHelper.Equal(item.DeviceType, deviceType))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceType"></param>
        /// <returns></returns>
        public string GetDeviceText(string deviceType)
        {
            foreach (DeviceDefine dd in this)
            {
                if (StringHelper.Equal(dd.DeviceType, deviceType, false, true))
                {
                    return dd.Text;
                }
            }
            return string.Empty;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceType"></param>
        /// <returns></returns>
        public DeviceDefine FindDeviceDefine(string deviceType)
        {
            foreach (DeviceDefine dd in this)
            {
                if (StringHelper.Equal(dd.DeviceType, deviceType))
                {
                    return dd;
                }
            }
            return null;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class DeviceDefineManager
    {
        /// <summary>
        /// 
        /// </summary>
        NUnit.Core.Logger logger = NUnit.Core.InternalTrace.GetLogger(typeof(DeviceDefineManager));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="soft"></param>
        public DeviceDefineManager(CommuniSoft soft)
        {
            if( soft == null )
            {
                throw new ArgumentNullException ("soft");
            }
            this._communiSoft = soft;
        }

        #region DeviceDefineCollection
        /// <summary>
        /// 
        /// </summary>
        public DeviceDefineCollection DeviceDefineCollection
        {
            get 
            {
                if (_deviceDefineCollection == null)
                {
                    _deviceDefineCollection = new DeviceDefineCollection();
                }
                return _deviceDefineCollection; 
            }
        } private DeviceDefineCollection _deviceDefineCollection;
        #endregion //DeviceDefineCollection


        #region CommuniSoft
        /// <summary>
        /// 
        /// </summary>
        public CommuniSoft CommuniSoft
        {
            get { return _communiSoft; }
        } private CommuniSoft _communiSoft;
        #endregion //CommuniSoft    

        #region LoadFromFile
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        public void LoadFromFile(string filename)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);

            // 2010-09-10
            // 
            // device defines node is null, file is not devicedefine file
            // 
            XmlNode deviceDefinesNode = doc.SelectSingleNode(DeviceDefineNodeNames.DeviceDefineCollection);

            if (deviceDefinesNode == null)
            {
                logger.Error("load " + filename + " fail");
                return;
            }

            foreach( XmlNode deviceDefineNode in deviceDefinesNode.ChildNodes )
            {
                if (deviceDefineNode.Name == DeviceDefineNodeNames.DeviceDefine)
                {
                    string deviceType = XmlHelper.GetAttribute((XmlElement)deviceDefineNode,
                        DeviceDefineNodeNames.DeviceType);
                    string deviceText = XmlHelper.GetAttribute((XmlElement)deviceDefineNode,
                        DeviceDefineNodeNames.DeviceText);

                    // TODO: remove xmlOperaFactory DeviceDefineCollection
                    //
                    // TODO: 2010-07-28 add device parameter define 
                    //
                    DeviceDefine dd = new DeviceDefine(deviceType, deviceText);

                    dd.DevcieDefineNode = deviceDefineNode;

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
        #endregion //LoadFromFile


        #region LoadFromPath
        /// <summary>
        /// 
        /// </summary>
        /// <param name="directoryName"></param>
        public void LoadFromPath(string path)
        {
            string searchPattern = "*.xml";
            string[] files = Directory.GetFiles(path, searchPattern);

            foreach (string file in files)
            {
                this.LoadFromFile(file);
            }
        }
        #endregion //LoadFromPath


    }
}

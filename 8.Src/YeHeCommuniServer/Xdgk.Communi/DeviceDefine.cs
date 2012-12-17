using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public class DeviceDefine
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="text"></param>
        public DeviceDefine(string deviceType, string text)
        {
            if (deviceType == null || deviceType.Trim().Length == 0)
                throw new ArgumentNullException("deviceType");
            if (text == null || text.Trim().Length == 0)
                throw new ArgumentNullException("text");

            this.DeviceType = deviceType;
            this.Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        public string DeviceType
        {
            get { return this._devcieType; }
            set { this._devcieType = value; }
        } private string _devcieType;

        /// <summary>
        /// 
        /// </summary>
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        } private string _text;

        /// <summary>
        /// 
        /// </summary>
        public ParameterDefineCollection ParameterDefineCollection
        {
            get 
            {
                if (_parameterDefineCollection == null)
                {
                    _parameterDefineCollection = new ParameterDefineCollection();
                }
                return _parameterDefineCollection; 
            }
            set { _parameterDefineCollection = value; }
        } private ParameterDefineCollection _parameterDefineCollection;

        /// <summary>
        /// 
        /// </summary>
        public XmlNode DevcieDefineNode
        {
            get
            {
                return _deviceDefineNode;
            }
            set 
            {
                _deviceDefineNode = value;
            }
        } private XmlNode _deviceDefineNode;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Opera CreateOpera(string operaName)
        {
            //Xdgk.Communi.Factory.XmlOperaFactory f = new Xdgk.Communi.Factory.XmlOperaFactory(
            //    null, this.DevcieDefineNode);
            //return f.Create(this.DeviceType, operaName);
            return Xdgk.Communi.Factory.MyOperaFactory.Create(this.DeviceType,
                operaName, this.DevcieDefineNode);
        }
    }
}

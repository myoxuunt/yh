using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Communi.Factory
{

    /// <summary>
    /// 
    /// </summary>
    abstract public class OperaFactoryBase
    {
        #region CommuniSoft
        /// <summary>
        /// 
        /// </summary>
        public CommuniSoft CommuniSoft
        {
            get { return _communiSoft; }
        } private CommuniSoft _communiSoft;
        #endregion //CommuniSoft

        /// <summary>
        /// 
        /// </summary>
        /// <param name="soft"></param>
        public OperaFactoryBase(CommuniSoft communiSoft)
        {
            if (communiSoft == null)
                throw new ArgumentNullException("communiSoft");
            _communiSoft = communiSoft;
        }

        /// <summary>
        /// 
        /// </summary>
        public DeviceDefineCollection DeviceDefineCollection
        {
            get 
            {
                if (_deviceDefineCollection == null)
                    _deviceDefineCollection = new DeviceDefineCollection();
                return _deviceDefineCollection;
            }
            set { _deviceDefineCollection = value; }
        } private DeviceDefineCollection _deviceDefineCollection;

        /// <summary>
        /// 根据设备类型和操作名称创建Opera
        /// </summary>
        /// <param name="deviceType"></param>
        /// <param name="operaName"></param>
        /// <returns></returns>
        abstract public Opera Create(string deviceType, string operaName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fDManager"></param>
        abstract public void InitFDManager(FDManager fDManager);
    }
}

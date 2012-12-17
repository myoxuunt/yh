using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Common;
//using Xdgk.Communi;

namespace YeHeCommuniServer
{
    /// <summary>
    /// 
    /// </summary>
    public class DeviceFormulaCollectionMap
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="device"></param>
        public DeviceFormulaCollectionMap(int deviceID)
        {
            this.DeviceID = deviceID;
        }

        #region Device
        /// <summary>
        /// 
        /// </summary>
        public int DeviceID
        {
            get
            {
                return _deviceID;
            }
            set
            {
                _deviceID = value;
            }
        } private int _deviceID;
        #endregion //Device

        #region FormulaCollection
        /// <summary>
        /// 
        /// </summary>
        public FormulaCollection FormulaCollection
        {
            get
            {
                if (_formulaCollection == null)
                {
                    _formulaCollection = new FormulaCollection();
                }
                return _formulaCollection;
            }
            set
            {
                _formulaCollection = value;
            }
        } private FormulaCollection _formulaCollection;
        #endregion //FormulaCollection
    }
}

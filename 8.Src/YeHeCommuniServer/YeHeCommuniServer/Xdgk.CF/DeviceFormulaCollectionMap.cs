using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Common;
//using Xdgk.Communi;

namespace Xdgk.CF
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

        #region DeviceID
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
        #endregion //DeviceID

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

#region Tag
/// <summary>
/// 
/// </summary>
public object Tag
{
	get
	{
		if (_tag == null)
		{
			_tag = new object();
		}
		return _tag;
	}
	set
	{
		_tag = value;
	}
} private object _tag;
#endregion //Tag

    }
}

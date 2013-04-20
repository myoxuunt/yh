using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.CF;

namespace Common
{
    public class DeviceFormaulManager
    {
        /// <summary>
        /// 
        /// </summary>
        private DeviceFormaulManager()
        {
        }

        #region IsInitCQFormaul
        /// <summary>
        /// 
        /// </summary>
        static public bool IsInitCQFormaul
        {
            get
            {
                return _isInitCQFormaul;
            }
            set
            {
                _isInitCQFormaul = value;
            }
        } static private bool _isInitCQFormaul = true;
        #endregion //IsInitCQFormaul

        #region IsInitPSFormaul
        /// <summary>
        /// 
        /// </summary>
        static public bool IsInitPSFormaul
        {
            get
            {
                return _isInitPSFormaul;
            }
            set
            {
                _isInitPSFormaul = value;
            }
        } static private bool _isInitPSFormaul = false;
        #endregion //IsInitPSFormaul

        /// <summary>
        /// 
        /// </summary>
        static public DevieFormaulCollectionMapCollection DevieFormaulCollectionMapCollection
        {
            get
            {
                if (_deviceFormaulCollectionMapCollection == null)
                {
                    _deviceFormaulCollectionMapCollection = new DevieFormaulCollectionMapCollection();
                }
                return _deviceFormaulCollectionMapCollection;
            }
        } static private DevieFormaulCollectionMapCollection _deviceFormaulCollectionMapCollection;
    }
}

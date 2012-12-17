using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Communi.Interface;

namespace Xdgk.Communi
{
    /// <summary>
    /// 代表通信数据中的最小含义单位
    /// </summary>
    public class BytesDataField : DataField
    {
        #region Members


        #endregion //Members

        #region Constructor
        /// <summary>
        /// 由beginPosition起始，长度为dataLength，数据为values的域
        /// </summary>
        /// <param name="beginPosition"></param>
        /// <param name="dataLength"></param>
        /// <param name="values"></param>
        public BytesDataField ( string name, int beginPosition, int dataLength, IBytesConverter bytesConverter, DataFieldOption dataFieldOption )
            : base( name, beginPosition, dataLength, bytesConverter, dataFieldOption) 
        {
        }
        #endregion //Constructor

        #region Properties
        #endregion //Properties

        #region Method
        #endregion //Method
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace YeHeCommuniServer
{
    /// <summary>
    /// 
    /// </summary>
    public class XD221ConfigDefine
    {
        /// <summary>
        /// 
        /// </summary>
        public XD221ConfigDefine()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public XD221ConfigDefine(string name, int offset, string datatype, string converter)
        {
            this.Name = name;
            this.Offset = offset;
            this.DataType = datatype;
            this.Converter = converter;
        }

        #region Name
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        } private string _name;
        #endregion //Name

        /// <summary>
        /// 
        /// </summary>
        public int Offset
        {
            get { return _offset; }
            set { _offset = value; }
        } private int _offset;

        #region DataType
        /// <summary>
        /// 
        /// </summary>
        public string DataType
        {
            get { return _dataType; }
            set { _dataType = value; }
        } private string _dataType;
        #endregion //DataType

        /// <summary>
        /// 
        /// </summary>
        public string Converter
        {
            get { return _converter; }
            set { _converter = value; }
        } private string _converter;

        #region Unit
        /// <summary>
        /// 
        /// </summary>
        public string Unit
        {
            get { return _unit; }
            set { _unit = value; }
        } private string _unit;
        #endregion //Unit

        // TODO: value range and factor
        //
        //#region ValueRange
        ///// <summary>
        ///// 
        ///// </summary>
        //public object ValueRange
        //{
        //    // TODO: ValueRange data type
        //    //
        //    get { return _valueRange; }
        //    set { _valueRange = value; }
        //} private object _valueRange;
        //#endregion //ValueRange

        //#region Factor
        ///// <summary>
        ///// 
        ///// </summary>
        //public float Factor
        //{
        //    get { return _factor; }
        //    set { _factor = value; }
        //} private float _factor;
        //#endregion //Factor
    }
}

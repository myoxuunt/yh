using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Common;

namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public class ParameterDefine
    {
        /// <summary>
        /// 
        /// </summary>
        public ParameterDefine( string name, TypeCode typeCode, string conveter)
        {
            // TODO: 2010-07-29 add converterName
            //
            this.Name = name;
            this.TypeCode = typeCode;
            this.ConverterName = conveter;
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
        
        #region TypeCode
        /// <summary>
        /// 
        /// </summary>
        public TypeCode TypeCode
        {
            get { return _typeCode; }
            set { _typeCode = value; }
        } private TypeCode _typeCode;
        #endregion //TypeCode

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
        

        #region NameValueCollection
        /// <summary>
        /// 
        /// </summary>
        public NameValueCollection NameValueCollection
        {
            get
            {
                if (_nameValueCollection == null)
                {
                    _nameValueCollection = new NameValueCollection();
                }
                return _nameValueCollection;
            }
            set { _nameValueCollection = value; }
        } private NameValueCollection _nameValueCollection;
        #endregion //NameValueCollection


        #region EnableNameValue
        /// <summary>
        /// 
        /// </summary>
        public bool EnableNameValue
        {
            get { return _enableNameValue; }
            set { _enableNameValue = value; }
        } private bool _enableNameValue = false;
        #endregion //EnableNameValue



        #region Constraint
        /// <summary>
        /// 
        /// </summary>
        public Constraint Constraint
        {
            get { return _constraint; }
            set { _constraint = value; }
        } private Constraint _constraint;
        #endregion //Constraint

        #region ConverterName
        /// <summary>
        /// 
        /// </summary>
        public string ConverterName
        {
            get { return _converterName; }
            set { _converterName = value; }
        } private string _converterName;
        #endregion //ConverterName

    }
}

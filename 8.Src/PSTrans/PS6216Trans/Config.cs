using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text;
using Xdgk.Common;

namespace PS6216DataImporter
{

    /// <summary>
    /// 
    /// </summary>
    public class Config : Xdgk.Common.SelfSerializer 
    {
        #region ImportInterval
        /// <summary>
        /// 
        /// </summary>
        public string ImportIntervalString
        {
            get { return _importIntervalString; }
            set { _importIntervalString = value; }
        } private string _importIntervalString = "00:00:10";

        /// <summary>
        /// 
        /// </summary>
        /// 
        [XmlIgnore]
        public TimeSpan ImportInterval
        {
            get
            {
                return TimeSpan.Parse(ImportIntervalString);
            }
            set
            {
                ImportIntervalString = value.ToString();
            }
        } 
        #endregion //ImportInterval

        #region FromConnectionString
        /// <summary>
        /// 
        /// </summary>
        public string FromConnectionString
        {
            get
            {
                if (_fromConnectionString == null)
                {
                    _fromConnectionString = string.Empty;
                }
                return _fromConnectionString;
            }
            set
            {
                _fromConnectionString = value;
            }
        } private string _fromConnectionString;
        #endregion //FromConnectionString

        #region ToConnectionString
        /// <summary>
        /// 
        /// </summary>
        public string ToConnectionString
        {
            get
            {
                if (_toConnectionString == null)
                {
                    _toConnectionString = string.Empty;
                }
                return _toConnectionString;
            }
            set
            {
                _toConnectionString = value;
            }
        } private string _toConnectionString;
        #endregion //ToConnectionString

        #region Enabled
        /// <summary>
        /// 
        /// </summary>
        public bool Enabled
        {
            get
            {
                return _enabled;
            }
            set
            {
                _enabled = value;
            }
        } private bool _enabled;
        #endregion //Enabled

        #region NameMapCollection
        /// <summary>
        /// 
        /// </summary>
        public NameMapCollection NameMapCollection
        {
            get
            {
                if (_nameMapCollection == null)
                {
                    _nameMapCollection = new NameMapCollection();
                }
                return _nameMapCollection;
            }
            set
            {
                _nameMapCollection = value;
            }
        } private NameMapCollection _nameMapCollection;
        #endregion //NameMapCollection

        #region FromDBI
        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public FromDBI FromDBI
        {
            get
            {
                if (_fromDBI == null)
                {
                    _fromDBI = new FromDBI(this.FromConnectionString);
                }
                return _fromDBI;
            }
        } private FromDBI _fromDBI;
        #endregion //FromDBI

        #region ToDBIForPs
        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public ToDBIForPs ToDBI
        {
            get
            {
                if (_toDBI == null)
                {

                    _toDBI = new ToDBIForPs(ToConnectionString);
                }
                return _toDBI;
            }
        } private ToDBIForPs _toDBI;
        #endregion //ToDBIForPs
    }
}

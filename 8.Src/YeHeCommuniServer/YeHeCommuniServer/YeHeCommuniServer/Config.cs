using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using Xdgk.Common;

namespace YeHeCommuniServer
{
    /// <summary>
    /// 
    /// </summary>
    public class Config: Xdgk.Common.SelfSerializer
    {
        #region ConfigFileName
        /// <summary>
        /// 
        /// </summary>
        public const string ConfigFileName = "YeHeCSConfig.xml";
        #endregion //ConfigFileName

        #region Save
        /// <summary>
        /// 
        /// </summary>
        public void Save()
        {
            this.Save(ConfigFileName);
        }
        #endregion //Save

        #region Default
        /// <summary>
        /// 
        /// </summary>
        static public Config Default
        {
            get
            {
                if (s_default == null)
                {
                    try
                    {
                        object obj = Xdgk.Common.SelfSerializer.Load(typeof(Config), ConfigFileName );
                        if (obj != null)
                            s_default = (Config)obj;
                    }
                    catch
                    {
                        s_default = new Config();
                        //Xdgk.Common.SelfSerializer ss = new Xdgk.Common.SelfSerializer();
                        s_default.Save(ConfigFileName);
                    }
                }
                return s_default;
            }
        } static private Config s_default;
        #endregion //Default

        #region TaskTimeout

        /// <summary>
        /// 
        /// </summary>
        /// 
        [XmlIgnore()]
        public TimeSpan TaskTimeout
        {
            get { return _taskTimeout; }
            set { _taskTimeout = value; }
        } private TimeSpan _taskTimeout;
        #endregion //TaskTimeout

        #region TaskTimeoutString
        /// <summary>
        /// 
        /// </summary>
        /// 
        [XmlElement("TaskTimeout")]
        public string TaskTimeoutString
        {
            get { return TaskTimeout.ToString(); }
            set { TaskTimeout = TimeSpan.Parse(value); }
        }
        #endregion //TaskTimeoutString

        #region ConnectionString
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("ConectionString")]
        public string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        } private string _connectionString;
        #endregion //ConnectionString

        #region ProjectName
        /// <summary>
        /// 
        /// </summary>
        public string ProjectName
        {
            get { return _projectName; }
            set { _projectName = value; }
        } private string _projectName="string.Empty";
        #endregion //ProjectName

        #region MajorVersion
        /// <summary>
        /// 
        /// </summary>
        public int MajorVersion
        {
            get { return _majorVersion; }
            set { _majorVersion = value; }
        } private int _majorVersion;
        #endregion //MajorVersion

        #region MinorVersion
        /// <summary>
        /// 
        /// </summary>
        public int MinorVersion
        {
            get { return _minorVersion; }
            set { _minorVersion = value; }
        } private int _minorVersion;
        #endregion //MinorVersion

        #region RevisionVersion
        /// <summary>
        /// 
        /// </summary>
        public int RevisionVersion
        {
            get { return _revisionVersion; }
            set { _revisionVersion = value; }
        } private int _revisionVersion;
        #endregion //RevisionVersion

        #region IsUseFluxFormula
        /// <summary>
        /// 
        /// </summary>
        public bool IsUseFluxFormula
        {
            get { return _isUseFluxFormula; }
            set { _isUseFluxFormula = value; }
        } private bool _isUseFluxFormula = true;
        #endregion //IsUseFluxFormula


    }
}

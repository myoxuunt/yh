using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class DBInfo
    {
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

        ///// <summary>
        ///// 
        ///// </summary>
        //public int Version
        //{
        //    get { return _version; }
        //    set { _version = value; }
        //} private int _version;

        /// <summary>
        /// 
        /// </summary>
        public string VersionString
        {
            get
            {
                return string.Format("{0}.{1}.{2}", 
                    this.MajorVersion, this.MinorVersion, this.RevisionVersion );
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Project
        {
            get { return _project; }
            set { _project = value; }
        } private string _project;

        /// <summary>
        /// 
        /// </summary>
        public DateTime DT
        {
            get { return _dt; }
            set { _dt = value; }
        } private DateTime _dt;
    }
}

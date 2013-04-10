using System;
using System.Collections.Generic;
using System.Text;

namespace PS6216DataImporter
{
    public class NameMap
    {
        #region FromName
        /// <summary>
        /// 
        /// </summary>
        public string FromName
        {
            get
            {
                if (_fromName == null)
                {
                    _fromName = string.Empty;
                }
                return _fromName;
            }
            set
            {
                _fromName = value;
            }
        } private string _fromName;
        #endregion //FromName

        #region ToName
        /// <summary>
        /// 
        /// </summary>
        public string ToName
        {
            get
            {
                if (_toName == null)
                {
                    _toName = string.Empty;
                }
                return _toName;
            }
            set
            {
                _toName = value;
            }
        } private string _toName;
        #endregion //ToName

        #region Elvation
        /// <summary>
        /// 
        /// </summary>
        public float Elvation
        {
            get
            {
                return _elvation;
            }
            set
            {
                _elvation = value;
            }
        } private float _elvation;
        #endregion //Elvation

    }
}

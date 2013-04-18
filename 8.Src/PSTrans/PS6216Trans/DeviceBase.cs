
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data ;
using System.Data.SqlClient;


namespace PS6216DataImporter
{
    public class DeviceBase
    {
#region Name
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get
            {
                if (_name == null)
                {
                    _name = string.Empty;
                }
                return _name;
            }
            set
            {
                _name = value;
            }
        } private string _name;
#endregion //Name

#region ID
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            get
            {
                return _iD;
            }
            set
            {
                _iD = value;
            }
        } private int _iD;
#endregion //ID

#region DBI
        /// <summary>
        /// 
        /// </summary>
        public object DBI
        {
            get
            {
                return _dBI;
            }
            set
            {
                _dBI = value;
            }
        } private object _dBI;
#endregion //DBI


#region Elvation
        /// <summary>
        /// 基本高程, 单位M
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

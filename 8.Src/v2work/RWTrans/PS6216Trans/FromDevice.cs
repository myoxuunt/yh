
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data ;
using System.Data.SqlClient;


namespace PS6216DataImporter
{
    public class FromDevice : DeviceBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param deviceType="formDateTime"></param>
        /// <returns></returns>
        public DataTable ReadDataTable(DateTime fromDateTime)
        {
            return ((FromDBI)DBI).ReadNewDataTable(fromDateTime);
        }

        new private string Name
        {
            get { return base.Name; }
            set { base.Name = value; }
        }

        new private int ID
        {
            get { return base.ID; }
            set { base.ID = value; }
        }
    }

}

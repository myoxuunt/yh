using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using Xdgk.Common;
//using Xdgk.Communi;

namespace Xdgk.CF
{
    /// <summary>
    /// 
    /// </summary>
    public class DevieFormaulCollectionMapCollection : Collection<DeviceFormulaCollectionMap>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="device"></param>
        public void AddDevice(int deviceID, DataRowCollection formulaDataRows)
        {
            // TODO:
            //
            //if (deviceID == null)
            //{
            //    throw new ArgumentNullException("device");
            //}
            DeviceFormulaCollectionMap dfsmap = new DeviceFormulaCollectionMap(deviceID);
            AddDeviceFormula(dfsmap, formulaDataRows);
            this.Add(dfsmap);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dfsmap"></param>
        private void AddDeviceFormula(DeviceFormulaCollectionMap dfsmap, DataRowCollection formulaDataRows)
        {
            //int deviceid = dfsmap.Device.ID;
            int deviceid = dfsmap.DeviceID;
            //DataTable tbl = DB.FormulaDB.GetFormulaDataTable(deviceid);
            foreach (DataRow row in formulaDataRows)
            {
                int id = Convert.ToInt32(row["formulaid"]);
                DateTime begin = Convert.ToDateTime(row["dtbegin"]);
                DateTime end = Convert.ToDateTime(row["dtend"]);
                string s = row["formula"].ToString().Trim ();

                Formula f = new Formula(id, begin, end, s);
                dfsmap.FormulaCollection.Add(f);
            }
        }

        /// <summary>
        /// 计算顺势流量
        /// </summary>
        /// <param name="device"></param>
        /// <param name="dt"></param>
        /// <param name="wl1"></param>
        /// <param name="wl2"></param>
        /// <returns></returns>
        public float CalcInstantFlux(int deviceID, DateTime dt, int wl1, int wl2)
        {
            foreach (DeviceFormulaCollectionMap item in this)
            {
                if (deviceID == item.DeviceID)
                {
                    return  item.FormulaCollection.CalcInstantFlux(dt, wl1, wl2);
                }
            }
            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="formula"></param>
        public void DeleteFormula(Formula formula)
        {
            foreach (DeviceFormulaCollectionMap item in this)
            {
                item.FormulaCollection.Remove(formula);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="device"></param>
        /// <returns></returns>
        public FormulaCollection GetFormulaCollection(int deviceID)
        {
            foreach (DeviceFormulaCollectionMap item in this)
            {
                if (item.DeviceID == deviceID )
                {
                    return item.FormulaCollection;
                }
            }
            return new FormulaCollection();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="device"></param>
        /// <param name="formula"></param>
        public void AddFormula(int deviceID, Formula formula)
        {
            foreach (DeviceFormulaCollectionMap item in this)
            {
                if (item.DeviceID == deviceID)
                {
                    item.FormulaCollection.Add(formula);
                }
            }
        }
    }
    
}

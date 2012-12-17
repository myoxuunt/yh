using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xdgk.Common;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class DeviceCollection : Collection<DeviceClass>
    {

        /// <summary>
        /// 获取设备所属站点的集合
        /// </summary>
        public StationCollection StationCollection
        {
            get
            {
                StationCollection sc = new StationCollection();
                foreach (DeviceClass d in this)
                {
                    sc.Add(d.StationClass);
                }
                return sc;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int[] GetDeviceIDs()
        {
            ArrayList list = new ArrayList();
            foreach (DeviceClass device in this)
            {
                list.Add(device.DeviceID);
            }

            return (int[])list.ToArray(typeof(int));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedInID"></param>
        public void RemoveByID(int deviceID)
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                DeviceClass d = this[i];
                if (d.DeviceID == deviceID)
                {
                    this.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        internal double CalcUsedAmount(DateTime begin, DateTime end)
        {
            double amount = 0d;
            foreach( DeviceClass d in this )
            {
                double deviceAmount = d.CalcUsedAmount(begin, end);
                amount += deviceAmount;
            }

            return amount;
        }

        /// <summary>
        /// 计算每个设备的时段用水量
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public double[] CalcEachDeviceUsedAmount(DateTime begin, DateTime end)
        {
            double[] result = new double[this.Count];
            int i = 0;
            foreach (DeviceClass d in this)
            {
                result[i++] = d.CalcUsedAmount(begin, end);
            }
            return result;
        }

        /// <summary>
        /// 集合中的设备类型是否在devicetypes中
        /// </summary>
        /// <param name="deviceTypes"></param>
        /// <returns></returns>
        internal bool Include(string[] deviceTypes)
        {
            foreach (DeviceClass d in this)
            {
                foreach ( string type in deviceTypes ){
                    if (StringHelper.Equal(d.DeviceType, type))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

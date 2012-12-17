//using System;
//using System.Collections.Generic;
//using System.Text;
//using Xdgk.Common;
//using System.Windows.Forms;

//namespace Xdgk.Communi
//{
//    /// <summary>
//    /// 
//    /// </summary>
//    public class IDeviceViewCollection : Collection<IDeviceView>
//    {
//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="device"></param>
//        public void Show(Control parent, Device device)
//        {
//            foreach (IDeviceView dv in this)
//            {
//                if (StringHelper.Equal(dv.ForDevice, device.DeviceType))
//                {
//                    dv.Show(parent, device);
//                }
//            }
//        }
//    }
//}
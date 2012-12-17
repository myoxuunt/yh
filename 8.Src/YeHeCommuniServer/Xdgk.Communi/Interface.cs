//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Windows.Forms;

//namespace Xdgk.Communi
//{
//    /// <summary>
//    /// 
//    /// </summary>
//    public interface IView
//    {
//        /// <summary>
//        /// 
//        /// </summary>
//        UserControl UserControl { get; set; }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="obj"></param>
//        void Show(Control parent, object obj);
//    }

//    /// <summary>
//    /// 
//    /// </summary>
//    public interface IDeviceView : IView 
//    {
//        /// <summary>
//        /// 
//        /// </summary>
//        string ForDevice { get; set; }
//    }

//    /// <summary>
//    /// 
//    /// </summary>
//    public interface IStationView : IView
//    {
//        /// <summary>
//        /// 
//        /// </summary>
//        string ForStation { get; set; }
//    }
//}
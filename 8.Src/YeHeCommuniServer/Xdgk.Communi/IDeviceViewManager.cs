//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.IO;
//using System.Windows.Forms;
//using System.Reflection;
//using Xdgk.Common;

//namespace Xdgk.Communi
//{
//    /// <summary>
//    /// 
//    /// </summary>
//    public class IDeviceViewManager
//    {
//        /// <summary>
//        /// 
//        /// </summary>
//        public IDeviceViewCollection IDeviceViewCollection
//        {
//            get
//            {
//                if (_iDeviceViewCollection == null)
//                {
//                    Init();
//                }
//                return _iDeviceViewCollection;
//            }
//        } private IDeviceViewCollection _iDeviceViewCollection;

//        /// <summary>
//        /// 
//        /// </summary>
//        private void Init()
//        {
//            this._iDeviceViewCollection = new IDeviceViewCollection();

//            string addinDirectory = Path.Combine(Application.StartupPath, "DeviceView");
//            DirectoryInfo dir = new DirectoryInfo(addinDirectory);

//            if (dir.Exists)
//                foreach (FileInfo file in dir.GetFiles("*.dll"))
//                    Register(file.FullName);
//        }


//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="path"></param>
//        private void Register(string path)
//        {
//            try
//            {
//                AssemblyName assemblyName = new AssemblyName();
//                assemblyName.Name = Path.GetFileNameWithoutExtension(path);
//                assemblyName.CodeBase = path;
//                Assembly assembly = Assembly.Load(assemblyName);

//                foreach (Type type in assembly.GetExportedTypes())
//                {
//                    if (type.IsClass && typeof(IDeviceView).IsAssignableFrom(type))
//                    {
//                        IDeviceView idv = (IDeviceView)Activator.CreateInstance(type);
//                        this.IDeviceViewCollection.Add(idv);
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        } 


//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="device"></param>
//        public void Show(Control parent, Device device)
//        {
//            this.IDeviceViewCollection.Show(parent, device);
//        }
//    }
//}

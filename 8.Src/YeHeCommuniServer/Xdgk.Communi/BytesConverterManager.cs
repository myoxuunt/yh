using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

using NUnit.Core;
using Xdgk.Common;
using Xdgk.Communi.Interface;

namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public class BytesConverterManager
    {
        static private Logger log = InternalTrace.GetLogger(typeof(BytesConverterManager));
        static private string BytesConverterAddinDir = "bc";
        private List<Assembly> _assemblyList= new List<Assembly>();

        #region BytesConverterCollection
        /// <summary>
        /// 
        /// </summary>
        public BytesConverterCollection BytesConverterCollection
        {
            get { return _bytesConverterCollection; }
        } private BytesConverterCollection _bytesConverterCollection = new BytesConverterCollection();
        #endregion //BytesConverterCollection

        #region BytesConverterManager
        /// <summary>
        /// 
        /// </summary>
        public BytesConverterManager() 
        {
            RegisterAddins();
        }
        #endregion //BytesConverterManager

        #region RegisterAddins
        /// <summary>
        /// 
        /// </summary>
        private void RegisterAddins()
        {
            // Load any extensions in the addins directory
            string addinDirectory = Path.Combine(Application.StartupPath, BytesConverterAddinDir );
            DirectoryInfo dir = new DirectoryInfo(addinDirectory);

            if (dir.Exists)
                foreach (FileInfo file in dir.GetFiles("*.dll"))
                    Register(file.FullName);
        }
        #endregion //RegisterAddins


        #region Register
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        private void Register(string path)
        {
            try
            {
                AssemblyName assemblyName = new AssemblyName();
                assemblyName.Name = Path.GetFileNameWithoutExtension(path);
                assemblyName.CodeBase = path;
                Assembly assembly = Assembly.Load(assemblyName);
                log.Debug("Loaded " + Path.GetFileName(path));
                this._assemblyList.Add(assembly);

                foreach (Type type in assembly.GetExportedTypes())
                {
                    if (type.IsClass && typeof(IBytesConverter).IsAssignableFrom(type))
                    {
                        IBytesConverter ibc = (IBytesConverter)Activator.CreateInstance(type);
                        this._bytesConverterCollection.Add( ibc );
                        //log.Error("Addin {0} was already registered", addin.Name);
                        //else
                        //{
                        //    addinRegistry.Register(addin);
                        log.Debug("Registered addin: {0}", ibc.GetType());
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                // NOTE: Since the gui isn't loaded at this point, 
                // the trace output will only show up in Visual Studio
                log.Error("Failed to load" + path, ex);
            }
        }
        #endregion //Register


        #region GetType
        /// <summary>
        /// 
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        private Type GetType(string typeName)
        {
            foreach (Assembly a in _assemblyList)
            {
                Type t = a.GetType(typeName);
                if (t != null)
                    return t;
            }
            return null;
        }
        #endregion //GetType


        #region CreateBytesConverter
        /// <summary>
        /// 
        /// </summary>
        /// <param name="typeName"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public IBytesConverter CreateBytesConverter(string typeName, object[] args)
        {
            Type t = this.GetType(typeName);
            if (t != null)
            {
                return (IBytesConverter)Activator.CreateInstance(t, args);
            }
            else
            {
                return null;
            }
        }
        #endregion //CreateBytesConverter
    }
}

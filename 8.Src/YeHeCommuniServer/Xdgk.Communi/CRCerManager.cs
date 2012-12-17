using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using Xdgk.Communi.Interface;
using NUnit.Core;

namespace Xdgk.Communi
{
    public class CRCerManager
    {
        static private Logger log = InternalTrace.GetLogger(typeof(CRCerManager));
        /// <summary>
        /// 
        /// </summary>
        public CRCerCollection CRCers
        {
            get
            {
                if (_CRCers == null)
                {
                    InitCRCers();
                }
                return _CRCers;
            }
        }private CRCerCollection _CRCers;

        /// <summary>
        /// 
        /// </summary>
        private void InitCRCers()
        {
            this._CRCers = new CRCerCollection();

            string addinDirectory = Path.Combine(Application.StartupPath, "crc");
            DirectoryInfo dir = new DirectoryInfo(addinDirectory);

            if (dir.Exists)
                foreach (FileInfo file in dir.GetFiles("*.dll"))
                    Register(file.FullName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public ICRCer GetCRCer(string name)
        {
            if (name == null)
                throw new ArgumentNullException("name");
            name = name.Trim();
            foreach (ICRCer crcer in this.CRCers)
            {
                if (crcer.GetType().FullName == name)
                {
                    return crcer;
                }
            }
            return null;
        }



        #region Register
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        public void Register(string path)
        {
            try
            {
                AssemblyName assemblyName = new AssemblyName();
                assemblyName.Name = Path.GetFileNameWithoutExtension(path);
                assemblyName.CodeBase = path;
                Assembly assembly = Assembly.Load(assemblyName);
                log.Debug("Loaded " + Path.GetFileName(path));

                foreach (Type type in assembly.GetExportedTypes())
                {
                    if (type.IsClass && typeof(ICRCer).IsAssignableFrom(type))
                    {
                        ICRCer crc = (ICRCer)Activator.CreateInstance(type);
                        this._CRCers.Add( crc );
                        //log.Error("Addin {0} was already registered", addin.Name);
                        //else
                        //{
                        //    addinRegistry.Register(addin);
                        log.Debug("Registered addin: {0}", crc.GetType());
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                // NOTE: Since the gui isn't loaded at this point, 
                // the trace output will only show up in Visual Studio
                log.Error("Failed to load" + path, ex);

                throw ex;
            }
        }

        #endregion //Register
    }
}

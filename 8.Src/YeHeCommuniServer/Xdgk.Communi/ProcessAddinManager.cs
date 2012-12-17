using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;
using System.Windows.Forms;

namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public class ProcessAddinManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="communiSoft"></param>
        public ProcessAddinManager(CommuniSoft communiSoft)
        {
            if (communiSoft == null)
            {
                throw new ArgumentNullException("communiSoft");
            }
            this._communiSoft = communiSoft;
        }

        /// <summary>
        /// 
        /// </summary>
        public CommuniSoft CommuniSoft
        {
            get { return _communiSoft; }
        } private CommuniSoft _communiSoft;

        /// <summary>
        /// 
        /// </summary>
        public IProcessAddin ProcessAddin
        {
            get
            {
                //if (_processAddin == null)
                //{
                //    //Load();
                //}
                return _processAddin;
            }
            set
            {
                _processAddin = value;
            }
        } private IProcessAddin _processAddin;

        ///// <summary>
        ///// 
        ///// </summary>
        //private void Load()
        //{
        //    // TODO: load process addin
        //    //
        //    string addinDirectory = Path.Combine(Application.StartupPath, "ProcessAddin");
        //    DirectoryInfo dir = new DirectoryInfo(addinDirectory);

        //    if (dir.Exists)
        //        foreach (FileInfo file in dir.GetFiles("*.dll"))
        //            Register(file.FullName);
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        private void Register( string path)
        {
            AssemblyName assemblyName = new AssemblyName();
            assemblyName.Name = Path.GetFileNameWithoutExtension(path);
            assemblyName.CodeBase = path;
            Assembly assembly = Assembly.Load(assemblyName);

            foreach (Type type in assembly.GetExportedTypes())
            {
                if (type.IsClass && typeof(IProcessAddin ).IsAssignableFrom(type))
                {
                    IProcessAddin  p= (IProcessAddin )Activator.CreateInstance(type);
                    this._processAddin = p;
                    //log.Error("Addin {0} was already registered", addin.Name);
                    //else
                    //{
                    //    addinRegistry.Register(addin);
                    //}
                }
            }
        }
    }
}

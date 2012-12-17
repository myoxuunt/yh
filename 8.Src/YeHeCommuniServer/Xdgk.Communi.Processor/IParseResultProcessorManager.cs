using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;
using System.Windows.Forms;
using Xdgk.Common;
using NUnit.Core;

namespace Xdgk.Communi.Processor
{
    /// <summary>
    /// 
    /// </summary>
    public class IParseResultProcessorManager
    {
        static private Logger log = InternalTrace.GetLogger(typeof(IParseResultProcessorManager));
        /// <summary>
        /// 
        /// </summary>
        private const string ProcessorAddinDir = "processor";

        /// <summary>
        /// 
        /// </summary>
        public IParseResultProcessorCollection IParseResultProcessorCollection
        {
            get
            {
                if (_iParseResultProcessorCollection == null)
                {
                    _iParseResultProcessorCollection = new IParseResultProcessorCollection();
                    Load();
                }
                return _iParseResultProcessorCollection;
            }
        } private IParseResultProcessorCollection _iParseResultProcessorCollection;


        /// <summary>
        /// 
        /// </summary>
        private void Load()
        {
            // Load any extensions in the addins directory
            string addinDirectory = Path.Combine(Application.StartupPath, ProcessorAddinDir );
            DirectoryInfo dir = new DirectoryInfo(addinDirectory);

            if (dir.Exists)
                foreach (FileInfo file in dir.GetFiles("*.dll"))
                    Register(file.FullName);
        }

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
                //this._assemblyList.Add(assembly);

                foreach (Type type in assembly.GetExportedTypes())
                {
                    if (type.IsClass && typeof(IParseResultProcessor).IsAssignableFrom(type))
                    {
                        IParseResultProcessor iProcessor = (IParseResultProcessor)Activator.CreateInstance(type);
                        this.IParseResultProcessorCollection.Add(iProcessor);
                        //log.Error("Addin {0} was already registered", addin.Name);
                        //else
                        //{
                        //    addinRegistry.Register(addin);
                        log.Debug("Registered addin: {0}", iProcessor.GetType());
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="communiSoft"></param>
        /// <param name="dbiBase"></param>
        /// <param name="fromStation"></param>
        /// <param name="fromDevice"></param>
        /// <param name="fromOpera"></param>
        /// <param name="fromReceivePart"></param>
        /// <param name="fromAddress"></param>
        /// <param name="pr"></param>
        /// <returns></returns>
        public bool ProcessParseResult(CommuniSoft communiSoft, DBIBase dbiBase, string fromStation,
            string fromDevice, string fromOpera, string fromReceivePart, int fromAddress, ParseResult pr)
        {
            foreach (IParseResultProcessor p in IParseResultProcessorCollection)
            {
                if (p.ForDevice == fromDevice)
                {
                    p.DBIBase = dbiBase;
                    p.FromStation = fromStation;
                    p.FromDevice = fromDevice;
                    p.FromOpera = fromOpera;
                    p.FromAddress = fromAddress;
                    p.FromReceivePart = fromReceivePart;

                    p.ProcessParseResult(communiSoft, pr);
                    return true;
                }
            }
            return false;
        }
    }
}

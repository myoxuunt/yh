using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Collections;
using Xdgk.Communi;
using Xdgk.Communi.Builder;
using Xdgk.Communi.XmlBuilder;
using Xdgk.Common;
using NUnit.Core;

namespace YeHeCommuniServer
{
    static class Program
    {
        // TODO: enable 
        //
        static private bool EnableExceptionHandle = true;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // preinstance 
            //
            if (Diagnostics.HasPreInstance())
            {
                NUnit.UiKit.UserMessage.Display(strings.AppRunning);
                return;
            }

            if (EnableExceptionHandle)
            {
                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
                Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(
                    Application_ThreadException);
            }

            InternalTrace.Initialize("CommuniServer_%p.log");

            CSDBI csdbi = CSDBI.Instance;
            YeHeCommuniServerApp.Default.CSDBI = csdbi;


            csdbi.VerifyDBInfo(Config.Default.ProjectName, Config.Default.MajorVersion, 
                Config.Default.MinorVersion , Config.Default.RevisionVersion );

            DeviceDefineBuilderBase d = new XmlDeviceDefinePathBuild("xml");

            System.Data.DataTable tblStation = YeHeCommuniServerApp.Default.CSDBI.ExecuteStationDataTable();
            System.Data.DataTable tblDevice = YeHeCommuniServerApp.Default.CSDBI.ExecuteDeviceDataTable();
            HardwareBuilderBase h = new DBHardWareBuilder(tblStation, tblDevice);

            TaskFactoryCollectionBuilder t = new XmlTaskFactoryCollectionBuilder("xml\\task.xml");
            ListenBuilderBase l = new XmlListenBuilder("xml\\listenport.xml");

            // create communisoft
            //
            Hashtable settings = new Hashtable();
            settings.Add("TaskTimeout", Config.Default.TaskTimeout);
            //CommuniSoftFactory.get.Create(settings);
            
            CommuniSoftFactory.Init(h);
            YeHeCommuniServerApp.Default.CommuniSoft = CommuniSoft.Default;
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
            Config.Default.Save();

            object obj = XD221ModbusConfigObject.XD221ConfigDefineCollection;

        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = e.ExceptionObject as Exception;
            ExceptionHandler.Handle(ex);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            ExceptionHandler.Handle(e.Exception);
        }
    }
}

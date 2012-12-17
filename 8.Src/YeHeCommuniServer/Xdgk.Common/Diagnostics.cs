using System;
using System.Diagnostics;

namespace Xdgk.Common
{
    /// <summary>
    /// Diagnostics 的摘要说明。
    /// </summary>
    public class Diagnostics
    {
        /// <summary>
        /// 
        /// </summary>
        private Diagnostics()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handle"></param>
        /// <returns></returns>
        static public bool HasPreInstance(out IntPtr handle, out IntPtr hwnd)
        {
            handle = IntPtr.Zero;
            hwnd = IntPtr.Zero;
            string processName = Process.GetCurrentProcess().ProcessName;
            Process[] processes = Process.GetProcessesByName(processName);
            if (processes.Length > 0)
            {
                Process p = processes[0];
                handle = p.Handle;
                hwnd = p.MainWindowHandle;
            }
            return processes.Length > 1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public bool HasPreInstance()
        {
            //string processName = Process.GetCurrentProcess().ProcessName;
            //Process[] processes = Process.GetProcessesByName(processName);
            //return processes.Length > 1;
            IntPtr handle, hwnd;
            return HasPreInstance(out handle, out hwnd);
        }
    }
}

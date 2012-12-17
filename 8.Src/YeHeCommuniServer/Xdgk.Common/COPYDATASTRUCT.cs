using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Xdgk.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class WindowMessageCode
    {
        /// <summary>
        /// 
        /// </summary>
        private WindowMessageCode()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public const int WM_COPYDATA = 0x004A;
    }

    /// <summary>
    /// 
    /// </summary>
    public class Win32API
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        [DllImport("User32.dll", EntryPoint = "SetForegroundWindow")]
        public static extern int SetForegroundWindow(int hWnd);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hWnd">handle to destination window</param>
        /// <param name="Msg">message</param>
        /// <param name="wParam">first message parameter</param>
        /// <param name="lParam">second message parameter</param>
        /// <returns></returns>
        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(
        int hWnd,
        int Msg,
        int wParam,
        ref COPYDATASTRUCT lParam
        );

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lpClassName"></param>
        /// <param name="lpWindowName"></param>
        /// <returns></returns>
        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);
    }

    /// <summary>
    /// 
    /// </summary>
    public struct COPYDATASTRUCT
    {
        public IntPtr dwData;
        public int cbData;
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpData;
    }
}
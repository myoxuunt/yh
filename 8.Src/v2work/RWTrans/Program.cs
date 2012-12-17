using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RWTrans
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Xdgk.Common.Diagnostics.HasPreInstance())
            {
                NUnit.UiKit.UserMessage.DisplayFailure(strings.Running);
                return;
            }
            App.Default.Run();

        }
    }
}

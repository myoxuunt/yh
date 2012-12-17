using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public interface IProcessAddin
    {
        /// <summary>
        /// 
        /// </summary>
        Control Control { get; }

        /// <summary>
        /// 
        /// </summary>
        void Init(CommuniSoft communiSoft);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        void ProcessExecutingTask(Task task);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        /// <param name="pr"></param>
        void ProcessExecutedTask(Task task, ParseResult pr);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        void ProcessFD(FDEventArgs e);

        /// <summary>
        /// 
        /// </summary>
        void CommuniPortChanged(Station station);

        /// <summary>
        /// 
        /// </summary>
        string Description { get; }
    }
}

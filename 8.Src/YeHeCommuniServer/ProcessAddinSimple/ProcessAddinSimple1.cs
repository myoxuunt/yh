using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Communi;

namespace ProcessAddinSimple
{
    /// <summary>
    /// 
    /// </summary>
    public class ProcessAddinSimple1 :  IProcessAddin 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        UC GetUC()
        {
            return new UC();
        }

        #region IProcessAddin 成员

        public void Init(CommuniSoft communiSoft)
        {
            UC u = GetUC();
            //u.Top = 240;
            //u.Dock = System.Windows.Forms.DockStyle.Fill;
            u.Description = this.Description;
            communiSoft.UIManager.ParentControl.Controls.Add(u);
        }
        

        public void ProcessExecutingTask(Task task)
        {
            throw new NotImplementedException();
        }

        public void ProcessExecutedTask(Task task, ParseResult pr)
        {
            throw new NotImplementedException();
        }

        public void ProcessFD(FDEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void CommuniPortChanged(Station station)
        {
            throw new NotImplementedException();
        }

        public string Description
        {
            get { return "4"; }
        }

        #endregion

        #region IProcessAddin 成员

        public System.Windows.Forms.Control Control
        {
            get { return this.GetUC(); }
        }

        #endregion
    }
}

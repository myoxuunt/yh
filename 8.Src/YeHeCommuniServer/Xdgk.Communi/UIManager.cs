using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public class UIManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="communiSoft"></param>
        public UIManager(CommuniSoft communiSoft)
        {
            if (communiSoft == null)
                throw new ArgumentNullException("communiSoft");
            this._communiSoft = communiSoft;
        }

        /// <summary>
        /// 
        /// </summary>
        public CommuniSoft CommuniSoft
        {
            get { return _communiSoft; }
        } private CommuniSoft _communiSoft;

        #region MainForm
        /// <summary>
        /// 
        /// </summary>
        public Form MainForm
        {
            get { return _mainForm; }
            set { _mainForm = value; }
        } private Form _mainForm;
        #endregion //MainForm

        #region ParentControl
        /// <summary>
        /// 
        /// </summary>
        public Control ParentControl
        {
            get { return _parentControl; }
            set { _parentControl = value; }
        } private Control _parentControl;
        #endregion //ParentControl

        //#region StatusBar
        ///// <summary>
        ///// 
        ///// </summary>
        //public StatusBar StatusBar
        //{
        //    get { return _statusBar; }
        //    set { _statusBar = value; }
        //} private StatusBar _statusBar;
        //#endregion //StatusBar

        //#region AlarmForm
        ///// <summary>
        ///// 
        ///// </summary>
        //public Form AlarmForm
        //{
        //    get { return _alarmForm; }
        //    set { _alarmForm = value; }
        //} private Form _alarmForm;
        //#endregion //AlarmForm

    }
}

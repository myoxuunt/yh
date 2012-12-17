using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public class FDManager
    {
        #region FDEvent
        /// <summary>
        /// 
        /// </summary>
        public event FDEventHandler FDEvent;
        #endregion //FDEvent

        #region CommuniSoft
        /// <summary>
        /// 
        /// </summary>
        public CommuniSoft CommuniSoft
        {
            get { return _soft; }
        } private CommuniSoft _soft;
        #endregion //CommuniSoft

        #region FDManager
        /// <summary>
        /// 
        /// </summary>
        /// <param name="soft"></param>
        public FDManager(CommuniSoft soft)
        {
            if (soft == null)
                throw new ArgumentNullException("soft");
            this._soft = soft;
        }
        #endregion //FDManager

        #region Operas
        /// <summary>
        /// 
        /// </summary>
        public OperaCollection Operas
        {
            get
            {
                if (_operaCollection == null)
                    _operaCollection = new OperaCollection();
                return _operaCollection;
            }
        } private OperaCollection _operaCollection;
        #endregion //Operas


        #region Porcess
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fromCommuniPort"></param>
        /// <param name="bytes"></param>
        public void Process(CommuniPort fromCommuniPort, byte[] bytes)
        {
            foreach (Opera op in this.Operas)
            {
                byte[][] bss = op.ReceivePart.DataFieldManager.Pick(bytes);
                if (bss != null)
                {
                    foreach (byte[] bs in bss)
                    {
                        ParseResult pr = op.ReceivePart.ToValues( bs );
                        if (pr.Success)
                        {
                            // process success event
                            //
                            //OnFDEvent(fromCommuniPort, op, pr);
                            if (CommuniSoft.IsUseUISynchronizationContext)
                            {
                                Xdgk.Communi.CommuniSoft.UISynchronizationContext.Post(
                                    this.FDCallback, new object[] { fromCommuniPort, op, pr });
                            }
                            else
                            {
                                OnFDEvent(fromCommuniPort, op, pr);
                            }
                        }
                    }
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private SendOrPostCallback FDCallback
        {
            get
            {
                return new SendOrPostCallback(FDCallbackTarget);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="state"></param>
        private void FDCallbackTarget(object state)
        {
            object[] array = (object[])state;
            CommuniPort from = (CommuniPort)array[0];
            Opera op = (Opera)array[1];
            ParseResult pr = (ParseResult)array[2];
            OnFDEvent(from, op, pr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fromCommuniPort"></param>
        /// <param name="op"></param>
        /// <param name="pr"></param>
        private void OnFDEvent(CommuniPort fromCommuniPort, Opera op, ParseResult pr)
        {
            if (FDEvent != null)
            {
                FDEventArgs e = new FDEventArgs(fromCommuniPort, op.DeviceType, op.Name, pr);
                FDEvent(this, e);
            }
        }
        #endregion //Porcess

    }
}

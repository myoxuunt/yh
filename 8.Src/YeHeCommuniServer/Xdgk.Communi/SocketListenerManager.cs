using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using NUnit.Core;

namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public class SocketListenerManager
    {
        static Logger log = InternalTrace.GetLogger(typeof(SocketListenerManager));

        #region SocketListenerManager
        public SocketListenerManager(CommuniSoft soft)
        {
            if (soft == null)
                throw new ArgumentNullException("communiSoft");
            this._communiSoft = soft;
        }
        #endregion //SocketListenerManager


        #region CommuniSoft
        /// <summary>
        /// 
        /// </summary>
        public CommuniSoft CommuniSoft
        {
            get { return _communiSoft; }
        } private CommuniSoft _communiSoft;
        #endregion //CommuniSoft

        ///// <summary>
        ///// 
        ///// </summary>
        //public event NewConnectEventHandler NewConnectEvent;

        #region SocketListeners
        /// <summary>
        /// 
        /// </summary>
        public SocketListenerCollection SocketListeners
        {
            get
            {
                if (this._socketListenerCollection == null)
                    this._socketListenerCollection = new SocketListenerCollection();
                return _socketListenerCollection;
            }
        } private SocketListenerCollection _socketListenerCollection;
        #endregion //SocketListeners


        #region Add
        /// <summary>
        /// 添加item到SocketListeners集合，并注册NewConnect事件
        /// </summary>
        /// <param name="item"></param>
        public void Add(SocketListener item)
        {
            this.SocketListeners.Add(item);
            ReginsterEvents(item);
        }
        #endregion //Add

        #region Remove
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public bool Remove(SocketListener item)
        {
            if (this.SocketListeners.Remove(item))
            {
                UnregisterEvents(item);
                return true;
            }
            return false;
        }
        #endregion //Remove

        #region ReginsterEvents
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        private void ReginsterEvents(SocketListener item)
        {
            item.ConnectedEvent += new EventHandler(item_ConnectedEvent);
        }
        #endregion //ReginsterEvents

        #region UnregisterEvents
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        private void UnregisterEvents(SocketListener item)
        {
            item.ConnectedEvent -= new EventHandler(item_ConnectedEvent);
        }
        #endregion //UnregisterEvents

        #region item_ConnectedEvent
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_ConnectedEvent(object sender, EventArgs e)
        {
            SocketListener sl = sender as SocketListener;
            Socket newsocket = sl.NewSocket;
            if( newsocket == null)
                return;
            if (!newsocket.Connected)
            {
                return;
            }
            
            SocketCommuniPort scp = null;
            try
            {
                scp = new SocketCommuniPort(newsocket);
            }
            catch
            {
                CloseSocket(newsocket);
                return;
            }

            scp.ReceivedEvent += new EventHandler(scp_ReceivedEvent);
            bool b = StationCommuniPortBinder.Bind(
                this._communiSoft.HardwareManager.Stations, scp);

            if (!b)
            {
                this._communiSoft.CommuniPortManager.Add(scp);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sck"></param>
        private void CloseSocket(Socket sck)
        {
            try
            {
                sck.Shutdown(SocketShutdown.Both);
                sck.Close();
            }
            catch(Exception ex)
            {
                // TODO: 
                // do nothing
                log.Error("SocketListenerManager.CloseSocket exception", ex); 
            }
        }

        /// <summary>
        /// FD event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scp_ReceivedEvent(object sender, EventArgs e)
        {
            SocketCommuniPort sckcp = sender as SocketCommuniPort;
            byte[] bs = sckcp.Read();
            this.CommuniSoft.FDManager.Process(sckcp, bs);
        }
        #endregion //item_ConnectedEvent
    }
}

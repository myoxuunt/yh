using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;

namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public class SocketListener : TcpListener
    {
        /// <summary>
        /// 
        /// </summary>
        static private NUnit.Core.Logger log = NUnit.Core.InternalTrace.GetLogger(typeof(SocketListener));

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler ConnectedEvent;


        #region NewSocket
        /// <summary>
        /// 
        /// </summary>
        public Socket NewSocket
        {
            get { return _newSocket; }
        } private Socket _newSocket;
        #endregion //NewSocket

        ///// <summary>
        ///// 
        ///// </summary>
        //private TcpListener _tcpListener;

        /// <summary>
        /// 
        /// </summary>
        public bool IsListening
        {
            get { return this.Active; }
        }

        #region SocketListener
        /// <summary>
        /// 
        /// </summary>
        /// <param name="port"></param>
        public SocketListener(int port)
            : base(port)
        {
            //this._tcpListener = new TcpListener(port);
            //this._tcpListener.Start();
        }
        #endregion //SocketListener

        /// <summary>
        /// 
        /// </summary>
        public new void Start()
        {
            base.Start();
            this.BeginAcceptSocketHelper();
        }

        /// <summary>
        /// 
        /// </summary>
        private void BeginAcceptSocketHelper()
        {
            AsyncCallback callback = new AsyncCallback( this.BeginAcceptSocketCallback);
            // TODO: 2009-11-04 beginAcceptSocket exception
            //
            //try
            //{
                this.BeginAcceptSocket(
                    callback,
                    this);
            //}
            
        }

        #region BeginAcceptSocketCallback
        /// <summary>
        /// 
        /// </summary>
        private void BeginAcceptSocketCallback(IAsyncResult ar)
        {
            // TODO: ex at here 2009-11-04
            //

            Socket socket = null;
            try
            {
                socket = this.EndAcceptSocket(ar);
            }
            catch (Exception ex)
            {
                log.Error("EndAcceptSocket exception", ex);
            }

            if (socket != null)
            {
                this._newSocket = socket;
                if (ConnectedEvent != null)
                {
                    this.ConnectedEvent(this, EventArgs.Empty);
                }
            }

            this.BeginAcceptSocketHelper();
        }
        #endregion //BeginAcceptSocketCallback
    }

}

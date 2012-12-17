using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;

namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void NewConnectEventHandler(object sender, NewConnectEventArgs e);

    /// <summary>
    /// 
    /// </summary>
    public class NewConnectEventArgs : System.EventArgs
    {
        public NewConnectEventArgs(SocketListener socketListener, Socket socket)
        {
            if (socketListener == null)
                throw new ArgumentNullException("socketListener");

            if (socket == null)
                throw new ArgumentNullException("socket");

            this._socket = socket;
            this._socketListener = socketListener;
        }

        /// <summary>
        /// 
        /// </summary>
        public SocketListener SocketListener
        {
            get { return _socketListener; }
        } private SocketListener _socketListener;

        /// <summary>
        /// 
        /// </summary>
        public Socket Socket
        {
            get { return _socket; }
        } private Socket _socket;
    }
}

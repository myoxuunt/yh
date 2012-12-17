using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

using NUnit.Core;


namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public class SocketCommuniPort : CommuniPort
    {
        #region Members
        /// <summary>
        /// 
        /// </summary>
        static private  Logger log = InternalTrace.GetLogger(typeof(SocketCommuniPort));

        /// <summary>
        /// 
        /// </summary>
        private const int BUFFER_SIZE = 1024 * 2;

        /// <summary>
        /// 
        /// </summary>
        private byte[] _receBuffer = new byte[BUFFER_SIZE];
        #endregion //Members

        #region Events
        /// <summary>
        /// 
        /// </summary>
        public event ExceptionEventHandler ExceptionEvent;

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler ReceivedEvent;

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler ClosedEvent;
        #endregion //Events

        #region SocketCommuniPort
        /// <summary>
        /// 
        /// </summary>
        /// <param name="socket"></param>
        public SocketCommuniPort(Socket socket)
        {
            if (socket == null)
            {
                throw new ArgumentNullException("socket");
            }
            if (!socket.Connected)
            {
                throw new ArgumentException("socket not connected");
            }

            this._socket = socket;
            this.LocalEndPoint = this._socket.LocalEndPoint;
            this.RemoteEndPoint = this._socket.RemoteEndPoint;
            //IPEndPoint ipep = this._socket.LocalEndPoint;

            BeginReceiveHelper();
        }
        #endregion //SocketCommuniPort


        #region LocalEndPoint
        /// <summary>
        /// 
        /// </summary>
        public EndPoint LocalEndPoint
        {
            get { return _localEndPoint; }
            set { _localEndPoint = CloneEndPoint(value); }
        } private EndPoint _localEndPoint;
        #endregion //LocalEndPoint


        #region RemoteEndPoint
        /// <summary>
        /// 
        /// </summary>
        public EndPoint RemoteEndPoint
        {
            get { return _remoteEndPoint; }
            set { _remoteEndPoint = CloneEndPoint(value); }
        } private EndPoint _remoteEndPoint;
        #endregion //RemoteEndPoint



        #region CloneEndPoint
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ep"></param>
        /// <returns></returns>
        static private EndPoint CloneEndPoint(EndPoint ep)
        {
            if (ep == null)
                throw new ArgumentNullException("ep");

            IPEndPoint ipep = ep as IPEndPoint;
            if (ipep == null)
                throw new ArgumentException("ep is not IPEndPoint");

            IPEndPoint n = new IPEndPoint(ipep.Address.Address, ipep.Port);
            return n;
        }
        #endregion //CloneEndPoint

        #region BeginReceiveHelper
        /// <summary>
        /// 
        /// </summary>
        public void BeginReceiveHelper()
        {
            try
            {
                // start apm receive
                // 
                // TODO: exception handler
                //
                AsyncCallback cb = this.ReceiveCallback;
                IAsyncResult ia = _socket.BeginReceive(_receBuffer, 0, BUFFER_SIZE,
                        SocketFlags.None, cb, _socket);
            }
            catch (Exception ex)
            {
                log.Error("SocketCommuniPort.BeginReceiveHelper exception:", ex);
                throw ex;
            }
        }
        #endregion //BeginReceiveHelper

        #region ReceiveCallback
        /// <summary>
        /// 
        /// </summary>
        private AsyncCallback ReceiveCallback
        {
            get
            {
                if (_receiveCallback == null)
                    _receiveCallback = new AsyncCallback(BeginReceiveCallback);
                return _receiveCallback;
            }
        } private AsyncCallback _receiveCallback;
        #endregion //ReceiveCallback

        #region BeginReveiveCallback
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ia"></param>
        private void BeginReceiveCallback(IAsyncResult ia)
        {
            Socket sck = ia.AsyncState as Socket;
            int n = 0;
            try
            {
                n = sck.EndReceive(ia);
            }
            catch (ObjectDisposedException odEx)
            {
                OnException(odEx);
                return;
            }
            catch (SocketException sckEx)
            {
                OnException(sckEx);
                this.CloseHelper();
                return;
            }
            catch
            {
                throw;
            }
            log.Debug("Received bytes length: " + n);

            if (n > 0)
            {
                _memoryStream.Write(_receBuffer, 0, n);
                if (this.IsOccupy)
                {
                    // do nothing 
                }
                else
                {
                    OnReceived();
                }
                //log.Debug("Received bytes: " + BitConverter.ToString(ReceivedBytes));

                BeginReceiveHelper();
            }
            else
            {
                CloseHelper();
            }
        }
        #endregion //BeginReveiveCallback

        #region OnReceived
        /// <summary>
        /// 
        /// </summary>
        public void OnReceived()
        {
            if (ReceivedEvent != null)
            {
                EventHandler t = this.ReceivedEvent;
                t(this, EventArgs.Empty);
            }
        }
        #endregion //OnReceived

        #region OnException
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ex"></param>
        private void OnException(Exception ex)
        {
            ExceptionEventArgs e = new ExceptionEventArgs(ex);
            if (this.ExceptionEvent != null)
            {
                ExceptionEventHandler t = this.ExceptionEvent;
                t(this, e);
            }
        }
        #endregion //OnException

        #region Closed
        /// <summary>
        /// 
        /// </summary>
        public bool Closed
        {
            get { return _closed; }
        } private bool _closed;
        #endregion //Closed

        #region CloseHelper
        /// <summary>
        /// 
        /// </summary>
        private void CloseHelper()
        {
            if (!this._closed)
            {
                _socket.Shutdown(SocketShutdown.Both);
                _socket.Close();
                this._closed = true;
                StationCommuniPortBinder.ClearBind(this);
                OnClosed();
            }
        }
        #endregion //CloseHelper

        #region OnClosed
        /// <summary>
        /// 
        /// </summary>
        private void OnClosed()
        {
            if (this.ClosedEvent != null)
            {
                EventHandler t = ClosedEvent;
                t(this, EventArgs.Empty);
            }
        }
        #endregion //OnClosed


        #region Socket
        /// <summary>
        /// 
        /// </summary>
        public Socket Socket
        {
            get { return _socket; }
        } private Socket _socket;
        #endregion //Socket

        #region Write
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        public override bool Write(byte[] bytes)
        {
            try
            {
                this._socket.Send(bytes);
                return true;
            }
            catch (SocketException sckEx)
            {
                OnException(sckEx);
                CloseHelper();
            }
            catch (ObjectDisposedException odEx)
            {
                OnException(odEx);
            }
            catch
            {
                // argument null exception
                //
                throw;
            }
            return false;
        }
        #endregion //Write

        #region Read
        /// <summary>
        /// 
        /// </summary>
        private System.IO.MemoryStream _memoryStream = new System.IO.MemoryStream();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override byte[] Read()
        {
            // TODO: clear memorystream
            //
            byte[] bs = _memoryStream.ToArray();
            //_memoryStream.Flush();
            _memoryStream.SetLength(0);
            return bs;

            try
            {
                if (this._socket.Available > 0)
                {
                    byte[] buffer = new byte[2048];
                    int n = this._socket.Receive(buffer);
                    byte[] r = new byte[n];
                    Array.Copy(buffer, r, n);
                    return r;
                }
                else
                {
                    return new byte[0];
                }
            }
            catch (SocketException sckEx)
            {
                OnException(sckEx);
                CloseHelper();
            }
            catch (ObjectDisposedException odEx)
            {
                OnException(odEx);
            }           
            catch
            {
                throw;
            }
            return new byte[0];

        }
        #endregion //Read


        #region Remove
        /// <summary>
        /// 
        /// </summary>
        public override void Remove()
        {
            this.CloseHelper();
            base.Remove();
        }
        #endregion //Remove

        #region GetIPEndPoint
        /// <summary>
        /// 
        /// </summary>
        /// <param name="socket"></param>
        /// <returns></returns>
        private IPEndPoint GetIPEndPoint(Socket socket)
        {
            try
            {
                return socket.RemoteEndPoint as IPEndPoint;
            }
            catch (SocketException socketex)
            {
                string s = string.Format("{0}", socketex.ToString());
                log.Error(s);
                return null;
            }
            catch (ObjectDisposedException odex)
            {
                string s = string.Format("{0}", odex.ToString());
                log.Error(s);
                return null;
            }
            catch
            {
                throw;
            }
        }
        #endregion //GetIPEndPoint

        #region Match
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        public override bool Match(CommuniType communiType)
        {
            if (communiType == null)
                throw new ArgumentNullException("communiType");

            bool result = false;
            SocketCommuniType gprsct = communiType as SocketCommuniType;
            if (gprsct != null)
            {
                // 2009-09-14
                // throw ObjectDisposedException if socket is disposed
                //
                //IPEndPoint remoteIpep = ((IPEndPoint)this.Socket.RemoteEndPoint);
                //IPEndPoint localIpep = ((IPEndPoint)this.Socket.LocalEndPoint);
                IPEndPoint remoteIpep = ((IPEndPoint)this.RemoteEndPoint);
                IPEndPoint localIpep = ((IPEndPoint)this.LocalEndPoint);

                switch (gprsct.DiscriminateMode)
                {
                    case DiscriminateMode.ByIPAddress:
                        result = gprsct.IPAddress.Equals(remoteIpep.Address);
                        break;

                    case DiscriminateMode.ByLocalPort:
                        result = (localIpep.Port == gprsct.LocalPort);
                        break;

                    case DiscriminateMode.ByRemotePort:
                        result = remoteIpep.Port == gprsct.RemotePort;
                        break;

                    //case DiscriminateMode.ByIPAddressPort:
                    //    result = (gprsct.IPAddress.Equals(remoteIpep.Address) &&
                    //        (localIpep.Port == gprsct.LocalPort));
                    //    break;

                    case DiscriminateMode.ByPhoneNumber:
                        throw new NotImplementedException("DiscriminateMode.ByPhoneNumber");

                    default:
                        throw new ArgumentException("unknown DiscriminateMode: " + gprsct.DiscriminateMode);
                }
            }
            return result;
        }
        #endregion //Match
    }
}

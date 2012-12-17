using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets ;

namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public class CommuniPortFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SocketCommuniPort CreateSocketCommuniPort(Socket socket )
        {
            if (socket == null)
                throw new ArgumentNullException("socket");

            SocketCommuniPort scp = new SocketCommuniPort(socket);
            return scp;
        }

        //public SerialCommuniType 
    }
}

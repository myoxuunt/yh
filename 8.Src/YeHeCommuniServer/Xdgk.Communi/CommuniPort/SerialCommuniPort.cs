using System.IO.Ports;
using Xdgk.Common;
using System;

namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public class SerialCommuniPort : CommuniPort
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="portName"></param>
        /// <param name="baudRate"></param>
        /// <param name="parity"></param>
        /// <param name="dataBits"></param>
        /// <param name="stopBits"></param>
        public SerialCommuniPort( string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits)
        {
            _serialPort = new SerialPort(portName, baudRate, parity, dataBits, stopBits);
            _serialPort.Open();
        }

        /// <summary>
        /// 
        /// </summary>
        public SerialPort SerialPort
        {
            get { return _serialPort; }
        } private SerialPort _serialPort;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override byte[] Read()
        {
            int readCount = this.SerialPort.BytesToRead;
            if (readCount > 0)
            {
                byte[] buffer = new byte[this.SerialPort.BytesToRead];
                this.SerialPort.Read(buffer, 0, readCount);
                return buffer;
            }
            else
            {
                return new byte[0];
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public override bool Write(byte[] bytes)
        {
            if (bytes == null)
            {
                throw new ArgumentNullException("bytes");
            }
            this.SerialPort.Write(bytes, 0, bytes.Length);
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="communiType"></param>
        /// <returns></returns>
        public override bool Match(CommuniType communiType)
        {
            if( communiType == null )
                throw new ArgumentNullException ("communiType" );

            if (communiType is SerialCommuniType)
            {
                    
            }
            return false;
        }
    }
}
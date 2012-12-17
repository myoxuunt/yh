using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.IO.Ports;

namespace Xdgk.Communi
{

    /// <summary>
    /// 串口通讯类型
    /// </summary>
    public class SerialCommuniType : CommuniType
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToXml()
        {
            string format =
@"<?xml version=""1.0"" encoding=""utf-8"" ?>
<serialcommunitype>
<portname>{0}</portname>
<baudrate>{1}</baudrate>
<parity>{2}</parity>
<databits>{3}</databits>
<stopbits>{4}</stopbits>
</serialcommunitype>";
            string xml = string.Format(format, this.PortName, this.BaudRate,
                this.Parity, this.DataBits, this.StopBits);
            return xml;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="portName"></param>
        /// <param name="baudRate"></param>
        /// <param name="parity"></param>
        /// <param name="dataBits"></param>
        /// <param name="stopBits"></param>
        public SerialCommuniType(string portName, int baudRate,
            Parity parity, int dataBits, StopBits stopBits)
        {
            this.PortName = portName;
            this.BaudRate = baudRate;
            this.Parity = parity;
            this.DataBits = dataBits;
            this.StopBits = stopBits;
        }


        #region PortName
        /// <summary>
        /// 
        /// </summary>
        public string PortName
        {
            get { return _portName; }
            set { _portName = value; }
        } private string _portName;
        #endregion //PortName

        #region BaudRate
        /// <summary>
        /// 
        /// </summary>
        public int BaudRate
        {
            get { return _baudRate; }
            set { _baudRate = value; }
        } private int _baudRate;
        #endregion //BaudRate

        #region Parity
        /// <summary>
        /// 
        /// </summary>
        public Parity Parity
        {
            get { return _parity; }
            set { _parity = value; }
        } private Parity _parity;
        #endregion //Parity

        #region DataBits
        /// <summary>
        /// 
        /// </summary>
        public int DataBits
        {
            get { return _dataBits; }
            set { _dataBits = value; }
        } private int _dataBits;
        #endregion //DataBits

        #region StopBits
        /// <summary>
        /// 
        /// </summary>
        public StopBits StopBits
        {
            get { return _stopBits; }
            set { _stopBits = value; }
        } private StopBits _stopBits;
        #endregion //StopBits

    }
}
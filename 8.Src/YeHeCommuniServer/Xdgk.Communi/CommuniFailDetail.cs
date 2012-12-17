using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    public class CommuniFailDetail
    {
        /// <summary>
        /// 
        /// </summary>
        public CommuniFailDetail( string deviceType, string operaText, string parseResult, byte[] bytes )
        {
            this._deviceType = deviceType;
            this._operaText = operaText;

            if (parseResult == null)
                throw new ArgumentNullException("parseResult");
            this._parseResult = parseResult.ToString();

            if( bytes == null )
                bytes = new byte[0];
            this._bytes = bytes;
        }

        /// <summary>
        /// 
        /// </summary>
        public byte[] Bytes
        {
            get { return _bytes; }
        } private byte[] _bytes;

        /// <summary>
        /// 
        /// </summary>
        public DateTime DT
        {
            get { return _dt; }
        } private DateTime _dt = DateTime.Now;

        /// <summary>
        /// 
        /// </summary>
        public string ParseResult
        {
            get { return _parseResult; }
        } private string _parseResult;

        /// <summary>
        /// 
        /// </summary>
        public string DeviceType
        {
            get { return _deviceType; }
        } private string _deviceType;

        /// <summary>
        /// 
        /// </summary>
        public string OperaText
        {
            get { return _operaText; }
        } private string _operaText;
    }
}
